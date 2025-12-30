using System.CommandLine;
using System.Diagnostics;
using Arrow.Threading.Tasks;
using PureFix.Transport;
using PureFix.Transport.Session;
using PureFix.Transport.SocketTransport;
using PureFix.Transport.Store;
using PureFix.Types;
using Serilog;
using TradeCaptureDemo.Support;

// ─────────────────────────────────────────────────────────────────────────────
// CLI Setup
// ─────────────────────────────────────────────────────────────────────────────
var modeArg = new Argument<string>("mode", () => "reset", "Operating mode: reset, recovery, broker-reset, clear");
var clientOption = new Option<bool>(["--client", "-c"], "Run client (initiator) only");
var serverOption = new Option<bool>(["--server", "-S"], "Run server (acceptor) only");
var skeletonOption = new Option<bool>("--skeleton", "Skeleton mode - no app messages, only heartbeats (for GC baseline testing)");
var logOption = new Option<bool>(["--log", "-l"], "Enable file logging to logs/ directory");
var storeOption = new Option<string?>(["--store", "-s"], "Use file store in specified directory");
var configOption = new Option<string?>("--config", "Custom config file path (for --client or --server)");
var dryRunOption = new Option<bool>("--dry-run", "Read and display file store state, then exit without starting session");
var truncateSeqOption = new Option<int?>("--truncate-seq", "Truncate sender sequence number to specified value (use with --client and --store)");
var timeoutOption = new Option<int?>(["--timeout", "-t"], "Exit after specified number of seconds");

var rootCommand = new RootCommand("PureFix Standalone Trade Capture Demo - FIX engine demonstration with GC monitoring")
{
    modeArg, clientOption, serverOption, skeletonOption, logOption, storeOption, configOption, dryRunOption, truncateSeqOption, timeoutOption
};

rootCommand.SetHandler(async (context) =>
{
    var mode = context.ParseResult.GetValueForArgument(modeArg);
    var client = context.ParseResult.GetValueForOption(clientOption);
    var server = context.ParseResult.GetValueForOption(serverOption);
    var skeleton = context.ParseResult.GetValueForOption(skeletonOption);
    var log = context.ParseResult.GetValueForOption(logOption);
    var store = context.ParseResult.GetValueForOption(storeOption);
    var config = context.ParseResult.GetValueForOption(configOption);
    var dryRun = context.ParseResult.GetValueForOption(dryRunOption);
    var truncateSeq = context.ParseResult.GetValueForOption(truncateSeqOption);
    var timeout = context.ParseResult.GetValueForOption(timeoutOption);

    var options = new RunOptions(mode, client, server, skeleton, log, store, config, dryRun, truncateSeq, timeout);
    await Run(options);
});

return await rootCommand.InvokeAsync(args);

// ─────────────────────────────────────────────────────────────────────────────
// Main Entry Point
// ─────────────────────────────────────────────────────────────────────────────
async Task Run(RunOptions opt)
{
    PrintBanner(opt);

    // Validate flags
    if (opt.ClientOnly && opt.ServerOnly)
    {
        Console.WriteLine("Error: cannot specify both --client and --server");
        return;
    }

    var paths = new PathConfig();

    // Handle clear mode
    if (opt.Mode == "clear")
    {
        ClearStore(paths.StoreDir);
        return;
    }

    // Select config files
    var (acceptorConfig, initiatorConfig) = SelectConfigs(opt, paths);

    // Apply custom config override
    if (!string.IsNullOrEmpty(opt.CustomConfig))
    {
        if (!File.Exists(opt.CustomConfig))
        {
            Console.WriteLine($"Error: Config file not found: {opt.CustomConfig}");
            return;
        }
        if (opt.ClientOnly) initiatorConfig = opt.CustomConfig;
        if (opt.ServerOnly) acceptorConfig = opt.CustomConfig;
    }

    // Handle truncate-seq (must be with --client and --store)
    if (opt.TruncateSeq.HasValue)
    {
        if (!opt.ClientOnly)
        {
            Console.WriteLine("Error: --truncate-seq requires --client");
            return;
        }
        if (string.IsNullOrEmpty(opt.StoreDirectory))
        {
            Console.WriteLine("Error: --truncate-seq requires --store");
            return;
        }
        await TruncateSenderSeq(initiatorConfig, paths, opt);
        if (!opt.DryRun) return; // Exit after truncation unless dry-run follows
    }

    // Handle dry-run (display store state and exit)
    if (opt.DryRun)
    {
        if (string.IsNullOrEmpty(opt.StoreDirectory))
        {
            Console.WriteLine("Error: --dry-run requires --store");
            return;
        }
        await DisplayStoreState(opt.ClientOnly ? initiatorConfig : acceptorConfig, paths, opt);
        return;
    }

    // Dispatch to appropriate runner
    if (opt.ClientOnly)
        await RunClient(initiatorConfig, paths, opt);
    else if (opt.ServerOnly)
        await RunServer(acceptorConfig, paths, opt);
    else
        await RunBoth(acceptorConfig, initiatorConfig, paths, opt);
}

// ─────────────────────────────────────────────────────────────────────────────
// Run Modes
// ─────────────────────────────────────────────────────────────────────────────
async Task RunClient(string configPath, PathConfig paths, RunOptions opt)
{
    PrintSessionInfo(configPath, paths.DictRootPath, "Client", isAcceptor: false);
    PrintStoreInfo(opt.StoreDirectory, configPath, paths.DictRootPath);

    await WithGcMonitoring(async () =>
    {
        await StartSession(configPath, paths, "Client", opt);
    }, opt.LogDir);

    Console.WriteLine("\nClient session ended.");
}

async Task RunServer(string configPath, PathConfig paths, RunOptions opt)
{
    PrintSessionInfo(configPath, paths.DictRootPath, "Server", isAcceptor: true);
    PrintStoreInfo(opt.StoreDirectory, configPath, paths.DictRootPath);

    await WithGcMonitoring(async () =>
    {
        await StartSession(configPath, paths, "Server", opt);
    }, opt.LogDir);

    Console.WriteLine("\nServer session ended.");
}

async Task RunBoth(string acceptorConfig, string initiatorConfig, PathConfig paths, RunOptions opt)
{
    PrintModeInfo(opt, paths.StoreDir);

    await WithGcMonitoring(async () =>
    {
        // Start server first
        var serverTask = StartSession(acceptorConfig, paths, "Server", opt);
        await Task.Delay(500); // Let server start listening

        // Then start client
        var clientTask = StartSession(initiatorConfig, paths, "Client", opt);

        await Task.WhenAll(serverTask, clientTask);
    }, opt.LogDir);

    Console.WriteLine("\nDemo complete!");
}

// ─────────────────────────────────────────────────────────────────────────────
// Session Management
// ─────────────────────────────────────────────────────────────────────────────
async Task StartSession(string configPath, PathConfig paths, string name, RunOptions opt)
{
    Console.WriteLine($"Starting {name}{(opt.Skeleton ? " (skeleton)" : "")}...");

    var config = FixConfig.MakeConfigFromPaths(paths.DictRootPath, configPath);

    // Override store if directory specified
    if (!string.IsNullOrEmpty(opt.StoreDirectory) && config is FixConfig fixConfig)
    {
        fixConfig.SessionStoreFactory = new FileSessionStoreFactory(opt.StoreDirectory);
    }

    var storeType = opt.StoreDirectory != null ? "file" : (config.Description?.Store?.Type ?? "memory");
    var resetFlag = config.Description?.ResetSeqNumFlag ?? false;
    Console.WriteLine($"  {name}: {config.Description?.SenderCompID} -> {config.Description?.TargetCompID}");
    Console.WriteLine($"  Store: {storeType}, ResetSeqNumFlag: {resetFlag}");
    Console.WriteLine($"  SessionStoreFactory: {config.SessionStoreFactory?.GetType().Name ?? "null"}");
    Console.WriteLine($"  Store config dir: {config.Description?.Store?.Directory ?? "null"}");

    var logFactory = new ConsoleLogFactory(config.Description, opt.LogDir);
    var queue = new AsyncWorkQueue();
    var clock = new RealtimeClock();

    BaseAppDI host = opt.Skeleton
        ? new SkeletonHost(queue, logFactory, clock, config)
        : new DemoHost(queue, logFactory, clock, config);

    var entity = host.Resolve<ITcpEntity>();
    if (entity != null)
    {
        var cts = new CancellationTokenSource();

        // Set timeout if specified
        if (opt.TimeoutSecs.HasValue)
        {
            cts.CancelAfter(TimeSpan.FromSeconds(opt.TimeoutSecs.Value));
            Console.WriteLine($"  Timeout: {opt.TimeoutSecs.Value} seconds");
        }

        try
        {
            await entity.Start(cts.Token);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine($"\n{name} timed out after {opt.TimeoutSecs} seconds.");
        }
    }
}

// ─────────────────────────────────────────────────────────────────────────────
// Helper Methods
// ─────────────────────────────────────────────────────────────────────────────
void PrintBanner(RunOptions opt)
{
    Console.WriteLine("PureFix Standalone Trade Capture Demo");
    Console.WriteLine("======================================");

    var runMode = (opt.ClientOnly, opt.ServerOnly, opt.Skeleton) switch
    {
        (true, false, true) => "skeleton client",
        (false, true, true) => "skeleton server",
        (false, false, true) => "skeleton (both)",
        (true, false, false) => "client",
        (false, true, false) => "server",
        _ => opt.Mode
    };

    Console.WriteLine($"Mode: {runMode}");
    if (opt.EnableLogs) Console.WriteLine("Logging: enabled (writing to logs/ directory)");
    Console.WriteLine();
}

void PrintSessionInfo(string configPath, string dictRootPath, string role, bool isAcceptor)
{
    var config = FixConfig.MakeConfigFromPaths(dictRootPath, configPath);
    var desc = config.Description;

    Console.WriteLine($"{role}-only mode");
    Console.WriteLine();
    Console.WriteLine("Session Configuration:");
    Console.WriteLine($"  Config file:    {configPath}");
    Console.WriteLine($"  BeginString:    {desc?.BeginString}");
    Console.WriteLine($"  SenderCompID:   {desc?.SenderCompID}");
    Console.WriteLine($"  TargetCompID:   {desc?.TargetCompID}");

    if (isAcceptor)
    {
        Console.WriteLine($"  Listen:         {desc?.Application?.Tcp?.Host}:{desc?.Application?.Tcp?.Port}");
    }
    else
    {
        Console.WriteLine($"  Host:           {desc?.Application?.Tcp?.Host}:{desc?.Application?.Tcp?.Port}");
        Console.WriteLine($"  TLS Enabled:    {desc?.Application?.Tcp?.Tls?.Enabled ?? false}");
        if (desc?.Application?.Tcp?.Tls?.Enabled == true)
        {
            Console.WriteLine($"  TLS Cert:       {desc?.Application?.Tcp?.Tls?.Certificate}");
            Console.WriteLine($"  TLS TargetHost: {desc?.Application?.Tcp?.Tls?.TargetHost ?? desc?.Application?.Tcp?.Host}");
        }
    }
    Console.WriteLine();
}

void PrintStoreInfo(string? storeDirectory, string configPath, string dictRootPath)
{
    if (storeDirectory != null)
    {
        Console.WriteLine($"Store:  {storeDirectory} (file store)");
    }
    else
    {
        var config = FixConfig.MakeConfigFromPaths(dictRootPath, configPath);
        var storeType = config.Description?.Store?.Type ?? "memory";
        Console.WriteLine($"Store:  {storeType} (from config)");
    }
    Console.WriteLine();
}

void PrintModeInfo(RunOptions opt, string storeDir)
{
    if (opt.Skeleton)
    {
        Console.WriteLine("SKELETON MODE: No application messages, only session heartbeats");
        Console.WriteLine("Using MEMORY store with ResetSeqNumFlag=true");
    }
    else if (opt.Mode == "recovery")
    {
        Console.WriteLine("Using FILE store with ResetSeqNumFlag=false (both sides)");
        Console.WriteLine($"Store directory: {storeDir}");
    }
    else if (opt.Mode == "broker-reset")
    {
        Console.WriteLine("Broker reset simulation:");
        Console.WriteLine("  Client: FILE store, ResetSeqNumFlag=N");
        Console.WriteLine("  Server: FILE store, ResetSeqNumFlag=Y (forces client reset)");
        Console.WriteLine($"Store directory: {storeDir}");
    }
    else
    {
        Console.WriteLine("Using MEMORY store with ResetSeqNumFlag=true");
    }
    Console.WriteLine();
}

(string acceptor, string initiator) SelectConfigs(RunOptions opt, PathConfig paths)
{
    var sessionPath = paths.SessionRootPath;

    return (opt.Skeleton || opt.Mode == "reset") switch
    {
        true => (Path.Join(sessionPath, "test-qf52-acceptor.json"),
                 Path.Join(sessionPath, "test-qf52-initiator.json")),
        false => opt.Mode switch
        {
            "recovery" => (Path.Join(sessionPath, "recovery-acceptor.json"),
                          Path.Join(sessionPath, "recovery-initiator.json")),
            "broker-reset" => (Path.Join(sessionPath, "broker-reset-acceptor.json"),
                              Path.Join(sessionPath, "broker-reset-initiator.json")),
            _ => (Path.Join(sessionPath, "test-qf52-acceptor.json"),
                  Path.Join(sessionPath, "test-qf52-initiator.json"))
        }
    };
}

void ClearStore(string storeDir)
{
    Console.WriteLine("Clearing store directory...");
    if (Directory.Exists(storeDir))
    {
        Directory.Delete(storeDir, recursive: true);
        Console.WriteLine($"Deleted: {storeDir}");
    }
    else
    {
        Console.WriteLine("Store directory doesn't exist.");
    }
}

async Task DisplayStoreState(string configPath, PathConfig paths, RunOptions opt)
{
    var config = FixConfig.MakeConfigFromPaths(paths.DictRootPath, configPath);
    var desc = config.Description;

    if (desc == null)
    {
        Console.WriteLine("Error: Could not load config description");
        return;
    }

    var sessionId = new SessionId(
        desc.BeginString ?? "FIX.5.0SP2",
        desc.SenderCompID ?? "unknown",
        desc.TargetCompID ?? "unknown"
    );

    Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════╗");
    Console.WriteLine("║                           FILE STORE STATE                                 ║");
    Console.WriteLine("╠════════════════════════════════════════════════════════════════════════════╣");
    Console.WriteLine($"║  Store Directory:  {opt.StoreDirectory,-54} ║");
    Console.WriteLine($"║  Session ID:       {sessionId,-54} ║");
    Console.WriteLine("╟────────────────────────────────────────────────────────────────────────────╢");

    var storeFactory = new FileSessionStoreFactory(opt.StoreDirectory!);
    var store = storeFactory.Create(sessionId);

    try
    {
        await store.Initialize();

        Console.WriteLine($"║  Sender Seq Num:   {store.SenderSeqNum,-54} ║");
        Console.WriteLine($"║  Target Seq Num:   {store.TargetSeqNum,-54} ║");
        Console.WriteLine($"║  Creation Time:    {store.CreationTime,-54} ║");
        Console.WriteLine("╟────────────────────────────────────────────────────────────────────────────╢");

        // Check the actual files
        var senderFile = Path.Combine(opt.StoreDirectory!, $"{sessionId}.sender.seqnum");
        var targetFile = Path.Combine(opt.StoreDirectory!, $"{sessionId}.target.seqnum");
        var messagesFile = Path.Combine(opt.StoreDirectory!, $"{sessionId}.messages");

        Console.WriteLine($"║  Sender seq file:  {(File.Exists(senderFile) ? "exists" : "missing"),-54} ║");
        Console.WriteLine($"║  Target seq file:  {(File.Exists(targetFile) ? "exists" : "missing"),-54} ║");
        Console.WriteLine($"║  Messages file:    {(File.Exists(messagesFile) ? "exists" : "missing"),-54} ║");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"║  Error loading store: {ex.Message,-51} ║");
        Console.WriteLine($"║  (Store may not exist yet - run a session first)                          ║");
    }

    Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════╝");
}

async Task TruncateSenderSeq(string configPath, PathConfig paths, RunOptions opt)
{
    var config = FixConfig.MakeConfigFromPaths(paths.DictRootPath, configPath);
    var desc = config.Description;

    if (desc == null)
    {
        Console.WriteLine("Error: Could not load config description");
        return;
    }

    var sessionId = new SessionId(
        desc.BeginString ?? "FIX.5.0SP2",
        desc.SenderCompID ?? "unknown",
        desc.TargetCompID ?? "unknown"
    );

    var storeFactory = new FileSessionStoreFactory(opt.StoreDirectory!);
    var store = storeFactory.Create(sessionId);

    try
    {
        await store.Initialize();
        var oldSeq = store.SenderSeqNum;
        var newSeq = opt.TruncateSeq!.Value;

        Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                      TRUNCATING SENDER SEQUENCE                            ║");
        Console.WriteLine("╠════════════════════════════════════════════════════════════════════════════╣");
        Console.WriteLine($"║  Session ID:       {sessionId,-54} ║");
        Console.WriteLine($"║  Old Sender Seq:   {oldSeq,-54} ║");
        Console.WriteLine($"║  New Sender Seq:   {newSeq,-54} ║");
        Console.WriteLine("╟────────────────────────────────────────────────────────────────────────────╢");

        if (newSeq >= oldSeq)
        {
            Console.WriteLine($"║  WARNING: New sequence ({newSeq}) >= old sequence ({oldSeq})                    ║");
            Console.WriteLine($"║  No change made - truncate should reduce the sequence number.             ║");
        }
        else
        {
            await store.SetSenderSeqNum(newSeq);
            Console.WriteLine($"║  SUCCESS: Sender sequence truncated from {oldSeq} to {newSeq,-26} ║");
            Console.WriteLine($"║  Server will reject logon until client catches up.                       ║");
        }

        Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════╝");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error truncating sequence: {ex.Message}");
    }
}

async Task WithGcMonitoring(Func<Task> action, string? logDir)
{
    var monitor = new GcMonitor(logDir);
    var cts = new CancellationTokenSource();
    var monitorTask = monitor.Start(cts.Token);

    await action();

    cts.Cancel();
    try { await monitorTask; } catch (OperationCanceledException) { }
    monitor.PrintSummary();
}

// ─────────────────────────────────────────────────────────────────────────────
// Types
// ─────────────────────────────────────────────────────────────────────────────
record RunOptions(
    string Mode,
    bool ClientOnly,
    bool ServerOnly,
    bool Skeleton,
    bool EnableLogs,
    string? StoreDirectory,
    string? CustomConfig,
    bool DryRun,
    int? TruncateSeq,
    int? TimeoutSecs)
{
    public string? LogDir => EnableLogs ? Path.Join(AppContext.BaseDirectory, "logs") : null;
}

class PathConfig
{
    public string BaseDir { get; } = AppContext.BaseDirectory;
    public string DictRootPath => Path.Join(BaseDir, "Data");
    public string SessionRootPath => Path.Join(DictRootPath, "Session");
    public string StoreDir => Path.Join(BaseDir, "store");
}

class GcMonitor
{
    private int _lastGen0, _lastGen1, _lastGen2;
    private long _lastAllocatedBytes;
    private readonly Stopwatch _stopwatch = Stopwatch.StartNew();
    private readonly Serilog.ILogger? _fileLogger;

    public GcMonitor(string? logDir = null)
    {
        if (logDir != null)
        {
            Directory.CreateDirectory(logDir);
            _fileLogger = new LoggerConfiguration()
                .WriteTo.File(
                    Path.Combine(logDir, "gc-monitor-.log"),
                    outputTemplate: "{Message:lj}{NewLine}",
                    rollingInterval: RollingInterval.Day,
                    retainedFileCountLimit: null)
                .CreateLogger();
        }
    }

    public async Task Start(CancellationToken ct)
    {
        _lastGen0 = GC.CollectionCount(0);
        _lastGen1 = GC.CollectionCount(1);
        _lastGen2 = GC.CollectionCount(2);
        _lastAllocatedBytes = GC.GetTotalAllocatedBytes();

        Log("");
        Log($"[GC] Monitor started at {DateTime.Now:yyyy-MM-dd HH:mm:ss} (reporting every 5 seconds)");
        Log("[GC] ──────────────────────────────────────────────────────────────────────────────────────");
        Log("[GC] Elapsed  │ Clock    │ Gen0 │ Gen1 │ Gen2 │ Heap (MB) │ Allocated (MB) │ Alloc Rate");
        Log("[GC] ──────────────────────────────────────────────────────────────────────────────────────");

        while (!ct.IsCancellationRequested)
        {
            try
            {
                await Task.Delay(5000, ct);
                PrintStats();
            }
            catch (OperationCanceledException)
            {
                break;
            }
        }
    }

    private void PrintStats()
    {
        var gen0 = GC.CollectionCount(0);
        var gen1 = GC.CollectionCount(1);
        var gen2 = GC.CollectionCount(2);
        var heapBytes = GC.GetTotalMemory(false);
        var allocatedBytes = GC.GetTotalAllocatedBytes();

        var deltaGen0 = gen0 - _lastGen0;
        var deltaGen1 = gen1 - _lastGen1;
        var deltaGen2 = gen2 - _lastGen2;
        var deltaAllocated = allocatedBytes - _lastAllocatedBytes;

        var elapsed = _stopwatch.Elapsed;
        var heapMB = heapBytes / (1024.0 * 1024.0);
        var allocatedMB = allocatedBytes / (1024.0 * 1024.0);
        var allocRateKBps = deltaAllocated / 5.0 / 1024.0;

        Log($"[GC] {elapsed:hh\\:mm\\:ss} │ {DateTime.Now:HH:mm:ss} │ +{deltaGen0,-3} │ +{deltaGen1,-3} │ +{deltaGen2,-3} │ {heapMB,9:F2} │ {allocatedMB,14:F2} │ {allocRateKBps,8:F1} KB/s");

        _lastGen0 = gen0;
        _lastGen1 = gen1;
        _lastGen2 = gen2;
        _lastAllocatedBytes = allocatedBytes;
    }

    public void PrintSummary()
    {
        var elapsed = _stopwatch.Elapsed;
        var gen0 = GC.CollectionCount(0);
        var gen1 = GC.CollectionCount(1);
        var gen2 = GC.CollectionCount(2);
        var heapBytes = GC.GetTotalMemory(false);
        var allocatedBytes = GC.GetTotalAllocatedBytes();

        Log("");
        Log("[GC] ═══════════════════════════════════════════════════════════════════════");
        Log("[GC] Summary");
        Log("[GC] ═══════════════════════════════════════════════════════════════════════");
        Log($"[GC]   Runtime:            {elapsed:hh\\:mm\\:ss\\.fff}");
        Log($"[GC]   Total Collections:  Gen0={gen0}, Gen1={gen1}, Gen2={gen2}");
        Log($"[GC]   Final Heap Size:    {heapBytes / (1024.0 * 1024.0):F2} MB");
        Log($"[GC]   Total Allocated:    {allocatedBytes / (1024.0 * 1024.0):F2} MB");
        Log($"[GC]   Avg Alloc Rate:     {allocatedBytes / elapsed.TotalSeconds / 1024.0:F1} KB/s");

        var gcInfo = GC.GetGCMemoryInfo();
        Log($"[GC]   High Memory Load:   {gcInfo.HighMemoryLoadThresholdBytes / (1024.0 * 1024.0):F0} MB threshold");
        Log($"[GC]   Heap Size (Commit): {gcInfo.HeapSizeBytes / (1024.0 * 1024.0):F2} MB");
        Log($"[GC]   Fragmented Bytes:   {gcInfo.FragmentedBytes / 1024.0:F1} KB");
        Log($"[GC]   Pinned Objects:     {gcInfo.PinnedObjectsCount}");
        Log("[GC] ═══════════════════════════════════════════════════════════════════════");
    }

    private void Log(string message)
    {
        Console.WriteLine(message);
        _fileLogger?.Information(message);
    }
}
