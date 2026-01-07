using System.CommandLine;
using System.Diagnostics;
using Arrow.Threading.Tasks;
using PureFix.Transport;
using PureFix.Transport.Session;
using PureFix.Transport.SocketTransport;
using PureFix.Transport.Store;
using PureFix.Types;
using Serilog;
using TradeCaptureDemo;
using TradeCaptureDemo.Support;

// ─────────────────────────────────────────────────────────────────────────────
// CLI Setup
// ─────────────────────────────────────────────────────────────────────────────
var rootCommand = CliOptions.CreateRootCommand();
rootCommand.SetHandler(async (CliOptions opt) => await Run(opt), new CliOptionsBinder());

return await rootCommand.InvokeAsync(args);

// ─────────────────────────────────────────────────────────────────────────────
// Main Entry Point
// ─────────────────────────────────────────────────────────────────────────────
async Task Run(CliOptions opt)
{
    PrintBanner(opt);

    // Validate flags
    if (opt.Client && opt.Server)
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
    if (!string.IsNullOrEmpty(opt.Config))
    {
        if (!File.Exists(opt.Config))
        {
            Console.WriteLine($"Error: Config file not found: {opt.Config}");
            return;
        }
        if (opt.Client) initiatorConfig = opt.Config;
        if (opt.Server) acceptorConfig = opt.Config;
    }

    // Handle truncate-seq (must be with --client and --store)
    if (opt.TruncateSeq.HasValue)
    {
        if (!opt.Client)
        {
            Console.WriteLine("Error: --truncate-seq requires --client");
            return;
        }
        if (string.IsNullOrEmpty(opt.Store))
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
        if (string.IsNullOrEmpty(opt.Store))
        {
            Console.WriteLine("Error: --dry-run requires --store");
            return;
        }
        await DisplayStoreState(opt.Client ? initiatorConfig : acceptorConfig, paths, opt);
        return;
    }

    // Dispatch to appropriate runner
    if (opt.Client)
        await RunClient(initiatorConfig, paths, opt);
    else if (opt.Server)
        await RunServer(acceptorConfig, paths, opt);
    else
        await RunBoth(acceptorConfig, initiatorConfig, paths, opt);
}

// ─────────────────────────────────────────────────────────────────────────────
// Run Modes
// ─────────────────────────────────────────────────────────────────────────────
async Task RunClient(string configPath, PathConfig paths, CliOptions opt)
{
    PrintSessionInfo(configPath, paths.DictRootPath, "Client", isAcceptor: false);
    PrintStoreInfo(opt.Store, configPath, paths.DictRootPath);

    await WithGcMonitoring(async () =>
    {
        await StartSession(configPath, paths, "Client", opt);
    }, opt.LogDir);

    Console.WriteLine("\nClient session ended.");
}

async Task RunServer(string configPath, PathConfig paths, CliOptions opt)
{
    PrintSessionInfo(configPath, paths.DictRootPath, "Server", isAcceptor: true);
    PrintStoreInfo(opt.Store, configPath, paths.DictRootPath);

    await WithGcMonitoring(async () =>
    {
        await StartSession(configPath, paths, "Server", opt);
    }, opt.LogDir);

    Console.WriteLine("\nServer session ended.");
}

async Task RunBoth(string acceptorConfig, string initiatorConfig, PathConfig paths, CliOptions opt)
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
async Task StartSession(string configPath, PathConfig paths, string name, CliOptions opt)
{
    Console.WriteLine($"Starting {name}{(opt.Skeleton ? " (skeleton)" : "")}...");

    var config = FixConfig.MakeConfigFromPaths(paths.DictRootPath, configPath);

    // Override store if directory specified
    if (!string.IsNullOrEmpty(opt.Store) && config is FixConfig fixConfig)
    {
        fixConfig.SessionStoreFactory = new FileSessionStoreFactory(opt.Store);
    }

    var storeType = opt.Store != null ? "file" : (config.Description?.Store?.Type ?? "memory");
    var resetFlag = config.Description?.ResetSeqNumFlag ?? false;
    Console.WriteLine($"  {name}: {config.Description?.SenderCompID} -> {config.Description?.TargetCompID}");
    Console.WriteLine($"  Store: {storeType}, ResetSeqNumFlag: {resetFlag}");
    Console.WriteLine($"  SessionStoreFactory: {config.SessionStoreFactory?.GetType().Name ?? "null"}");
    Console.WriteLine($"  Store config dir: {config.Description?.Store?.Directory ?? "null"}");

    var logFactory = new ConsoleLogFactory(config.Description, opt.LogDir);
    var clock = new RealtimeClock();

    BaseAppDI host = opt.Skeleton
        ? new SkeletonHost(logFactory, clock, config)
        : new DemoHost(logFactory, clock, config);

    var entity = host.Resolve<ITcpEntity>();
    if (entity != null)
    {
        var cts = new CancellationTokenSource();

        // Set timeout if specified
        if (opt.Timeout.HasValue)
        {
            cts.CancelAfter(TimeSpan.FromSeconds(opt.Timeout.Value));
            Console.WriteLine($"  Timeout: {opt.Timeout.Value} seconds");
        }

        try
        {
            await entity.Start(cts.Token);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine($"\n{name} timed out after {opt.Timeout} seconds.");
        }
    }
}

// ─────────────────────────────────────────────────────────────────────────────
// Helper Methods
// ─────────────────────────────────────────────────────────────────────────────
void PrintBanner(CliOptions opt)
{
    Console.WriteLine("PureFix Standalone Trade Capture Demo");
    Console.WriteLine("======================================");

    var runMode = (opt.Client, opt.Server, opt.Skeleton) switch
    {
        (true, false, true) => "skeleton client",
        (false, true, true) => "skeleton server",
        (false, false, true) => "skeleton (both)",
        (true, false, false) => "client",
        (false, true, false) => "server",
        _ => opt.Mode
    };

    Console.WriteLine($"Mode: {runMode}");
    if (opt.Log) Console.WriteLine("Logging: enabled (writing to logs/ directory)");
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

void PrintModeInfo(CliOptions opt, string storeDir)
{
    if (opt.Tls)
    {
        Console.WriteLine("TLS MODE: Using encrypted connection");
        Console.WriteLine("  Certificates: Data/certs/");
        Console.WriteLine("Using MEMORY store with ResetSeqNumFlag=true");
    }
    else if (opt.Skeleton)
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

(string acceptor, string initiator) SelectConfigs(CliOptions opt, PathConfig paths)
{
    var sessionPath = paths.SessionRootPath;

    // TLS mode takes priority
    if (opt.Tls)
    {
        return (Path.Join(sessionPath, "test-acceptor-tls.json"),
                Path.Join(sessionPath, "test-initiator-tls.json"));
    }

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

async Task DisplayStoreState(string configPath, PathConfig paths, CliOptions opt)
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
    Console.WriteLine($"║  Store Directory:  {opt.Store,-54} ║");
    Console.WriteLine($"║  Session ID:       {sessionId,-54} ║");
    Console.WriteLine("╟────────────────────────────────────────────────────────────────────────────╢");

    var storeFactory = new FileSessionStoreFactory(opt.Store!);
    var store = storeFactory.Create(sessionId);

    try
    {
        await store.Initialize();

        Console.WriteLine($"║  Sender Seq Num:   {store.SenderSeqNum,-54} ║");
        Console.WriteLine($"║  Target Seq Num:   {store.TargetSeqNum,-54} ║");
        Console.WriteLine($"║  Creation Time:    {store.CreationTime,-54} ║");
        Console.WriteLine("╟────────────────────────────────────────────────────────────────────────────╢");

        // Check the actual files (QuickFix-compatible format)
        var seqnumsFile = Path.Combine(opt.Store!, $"{sessionId}.seqnums");
        var sessionFile = Path.Combine(opt.Store!, $"{sessionId}.session");
        var bodyFile = Path.Combine(opt.Store!, $"{sessionId}.body");
        var headerFile = Path.Combine(opt.Store!, $"{sessionId}.header");

        Console.WriteLine($"║  Seqnums file:     {(File.Exists(seqnumsFile) ? "exists" : "missing"),-54} ║");
        Console.WriteLine($"║  Session file:     {(File.Exists(sessionFile) ? "exists" : "missing"),-54} ║");
        Console.WriteLine($"║  Body file:        {(File.Exists(bodyFile) ? "exists" : "missing"),-54} ║");
        Console.WriteLine($"║  Header file:      {(File.Exists(headerFile) ? "exists" : "missing"),-54} ║");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"║  Error loading store: {ex.Message,-51} ║");
        Console.WriteLine($"║  (Store may not exist yet - run a session first)                          ║");
    }

    Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════╝");
}

async Task TruncateSenderSeq(string configPath, PathConfig paths, CliOptions opt)
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

    var storeFactory = new FileSessionStoreFactory(opt.Store!);
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
