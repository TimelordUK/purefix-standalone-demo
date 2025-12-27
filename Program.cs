using System.Diagnostics;
using Arrow.Threading.Tasks;
using PureFix.Transport;
using PureFix.Transport.Session;
using PureFix.Transport.SocketTransport;
using PureFix.Transport.Store;
using PureFix.Types;
using TradeCaptureDemo.Support;

// Parse command line args
var enableLogs = false;
var clientOnly = false;
string? customConfig = null;
string? storeDirectory = null;
string mode = "reset";

for (var i = 0; i < args.Length; i++)
{
    switch (args[i])
    {
        case "--log" or "-l":
            enableLogs = true;
            break;
        case "--client" or "-c":
            clientOnly = true;
            if (i + 1 < args.Length && !args[i + 1].StartsWith("-"))
            {
                customConfig = args[++i];
            }
            break;
        case "--store" or "-s":
            if (i + 1 < args.Length && !args[i + 1].StartsWith("-"))
            {
                storeDirectory = args[++i];
            }
            break;
        case "--help" or "-h" or "help":
            mode = "help";
            break;
        case "reset" or "recovery" or "broker-reset" or "clear":
            mode = args[i].ToLower();
            break;
        default:
            // Unknown arg - if not starting with dash, treat as mode for backwards compat
            if (!args[i].StartsWith("-"))
            {
                mode = args[i].ToLower();
            }
            break;
    }
}

Console.WriteLine("PureFix Standalone Trade Capture Demo");
Console.WriteLine("======================================");
if (clientOnly)
{
    Console.WriteLine("Mode: client");
}
else
{
    Console.WriteLine($"Mode: {mode}");
}
if (enableLogs) Console.WriteLine("Logging: enabled (writing to logs/ directory)");
Console.WriteLine();

if (mode == "help")
{
    Console.WriteLine("Usage:");
    Console.WriteLine();
    Console.WriteLine("  Local testing (runs both server and client):");
    Console.WriteLine("    dotnet run [mode] [-l]");
    Console.WriteLine();
    Console.WriteLine("  Connect to broker (client only):");
    Console.WriteLine("    dotnet run -- --client [config] [-s store] [-l]");
    Console.WriteLine();
    Console.WriteLine("Modes:");
    Console.WriteLine("  reset          Memory store, always reset sequence numbers (default)");
    Console.WriteLine("  recovery       File store, resume from last session");
    Console.WriteLine("  broker-reset   Simulate broker forcing sequence reset");
    Console.WriteLine("  clear          Delete local store files and exit");
    Console.WriteLine();
    Console.WriteLine("Options:");
    Console.WriteLine("  -c, --client [config]   Run client only (connect to external broker)");
    Console.WriteLine("  -s, --store <dir>       Use file store in <dir>");
    Console.WriteLine("  -l, --log               Enable file logging (logs/ directory)");
    Console.WriteLine("  -h, --help              Show this help");
    Console.WriteLine();
    Console.WriteLine("Examples:");
    Console.WriteLine();
    Console.WriteLine("  # Local testing");
    Console.WriteLine("  dotnet run                              # Server + client, memory store");
    Console.WriteLine("  dotnet run recovery                     # Server + client, file store");
    Console.WriteLine("  dotnet run -l                           # With logging enabled");
    Console.WriteLine();
    Console.WriteLine("  # Connect to broker");
    Console.WriteLine("  dotnet run -- -c                        # Use default initiator config");
    Console.WriteLine("  dotnet run -- -c mybroker.json          # Use custom config");
    Console.WriteLine("  dotnet run -- -c mybroker.json -s ./store   # With file persistence");
    Console.WriteLine("  dotnet run -- -c mybroker.json -s ./store -l");
    return;
}

// Paths
var baseDir = AppContext.BaseDirectory;
var dictRootPath = Path.Join(baseDir, "Data");
var sessionRootPath = Path.Join(dictRootPath, "Session");
var storeDir = Path.Join(baseDir, "store");
var logDir = enableLogs ? Path.Join(baseDir, "logs") : null;

if (mode == "clear")
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
    return;
}

// Client-only mode - connect to external broker
if (clientOnly)
{
    var configPath = customConfig ?? Path.Join(sessionRootPath, "test-qf52-initiator.json");

    if (!File.Exists(configPath))
    {
        Console.WriteLine($"Error: Config file not found: {configPath}");
        return;
    }

    // Load config to show session details
    var config = FixConfig.MakeConfigFromPaths(dictRootPath, configPath);
    var desc = config.Description;

    Console.WriteLine("Client-only mode");
    Console.WriteLine();
    Console.WriteLine("Session Configuration:");
    Console.WriteLine($"  Config file:    {configPath}");
    Console.WriteLine($"  BeginString:    {desc?.BeginString}");
    Console.WriteLine($"  SenderCompID:   {desc?.SenderCompID}");
    Console.WriteLine($"  TargetCompID:   {desc?.TargetCompID}");
    Console.WriteLine($"  Host:           {desc?.Application?.Tcp?.Host}:{desc?.Application?.Tcp?.Port}");
    Console.WriteLine($"  TLS Enabled:    {desc?.Application?.Tcp?.Tls?.Enabled ?? false}");
    if (desc?.Application?.Tcp?.Tls?.Enabled == true)
    {
        Console.WriteLine($"  TLS Cert:       {desc?.Application?.Tcp?.Tls?.Certificate}");
        Console.WriteLine($"  TLS TargetHost: {desc?.Application?.Tcp?.Tls?.TargetHost ?? desc?.Application?.Tcp?.Host}");
    }
    Console.WriteLine();

    Console.WriteLine("Starting FIX client (connecting to external broker)...");
    if (storeDirectory != null)
    {
        Console.WriteLine($"Store:  {storeDirectory} (file store)");
    }
    else
    {
        var storeType = desc?.Store?.Type ?? "memory";
        Console.WriteLine($"Store:  {storeType} (from config)");
    }
    Console.WriteLine();

    await StartSession(configPath, dictRootPath, "Client", logDir, storeDirectory);

    Console.WriteLine();
    Console.WriteLine("Client session ended.");
    return;
}

// Start GC monitor
var gcMonitor = new GcMonitor();
var gcMonitorCts = new CancellationTokenSource();
var gcMonitorTask = gcMonitor.Start(gcMonitorCts.Token);

// Local testing mode - run both server and client
// Select config files based on mode
string acceptorConfig, initiatorConfig;
if (mode == "recovery")
{
    acceptorConfig = Path.Join(sessionRootPath, "recovery-acceptor.json");
    initiatorConfig = Path.Join(sessionRootPath, "recovery-initiator.json");
    Console.WriteLine("Using FILE store with ResetSeqNumFlag=false (both sides)");
    Console.WriteLine($"Store directory: {storeDir}");
}
else if (mode == "broker-reset")
{
    acceptorConfig = Path.Join(sessionRootPath, "broker-reset-acceptor.json");
    initiatorConfig = Path.Join(sessionRootPath, "broker-reset-initiator.json");
    Console.WriteLine("Broker reset simulation:");
    Console.WriteLine("  Client: FILE store, ResetSeqNumFlag=N");
    Console.WriteLine("  Server: FILE store, ResetSeqNumFlag=Y (forces client reset)");
    Console.WriteLine($"Store directory: {storeDir}");
}
else
{
    acceptorConfig = Path.Join(sessionRootPath, "test-qf52-acceptor.json");
    initiatorConfig = Path.Join(sessionRootPath, "test-qf52-initiator.json");
    Console.WriteLine("Using MEMORY store with ResetSeqNumFlag=true");
}

Console.WriteLine();

// Start the acceptor (server) first
var acceptorTask = StartSession(acceptorConfig, dictRootPath, "Server", logDir);

// Wait a bit for the server to start listening
await Task.Delay(500);

// Start the initiator (client)
var initiatorTask = StartSession(initiatorConfig, dictRootPath, "Client", logDir);

// Wait for both to complete
await Task.WhenAll(acceptorTask, initiatorTask);

// Stop GC monitor and print final stats
gcMonitorCts.Cancel();
try { await gcMonitorTask; } catch (OperationCanceledException) { }
gcMonitor.PrintSummary();

Console.WriteLine();
Console.WriteLine("Demo complete!");

static async Task StartSession(string configPath, string dictRootPath, string name, string? logDir, string? storeDirectory = null)
{
    Console.WriteLine($"Starting {name}...");

    // Load config
    var config = FixConfig.MakeConfigFromPaths(dictRootPath, configPath);

    // Override store if directory specified
    if (!string.IsNullOrEmpty(storeDirectory) && config is FixConfig fixConfig)
    {
        fixConfig.SessionStoreFactory = new FileSessionStoreFactory(storeDirectory);
    }

    var storeType = storeDirectory != null ? "file" : (config.Description?.Store?.Type ?? "memory");
    var resetFlag = config.Description?.ResetSeqNumFlag ?? false;
    Console.WriteLine($"  {name}: {config.Description?.SenderCompID} -> {config.Description?.TargetCompID}");
    Console.WriteLine($"  Store: {storeType}, ResetSeqNumFlag: {resetFlag}");

    // Create log factory from config
    var logFactory = new ConsoleLogFactory(config.Description, logDir);
    var queue = new AsyncWorkQueue();
    var clock = new RealtimeClock();

    // Create the DI host
    var host = new DemoHost(queue, logFactory, clock, config);

    // Get the TCP entity and run
    var entity = host.Resolve<ITcpEntity>();
    if (entity != null)
    {
        var cts = new CancellationTokenSource();
        await entity.Start(cts.Token);
    }
}

// GC Monitoring - use a class to hold state since top-level can't have static fields
class GcMonitor
{
    public int LastGen0, LastGen1, LastGen2;
    public long LastAllocatedBytes;
    public Stopwatch Stopwatch = Stopwatch.StartNew();

    public async Task Start(CancellationToken ct)
    {
        // Capture initial state
        LastGen0 = GC.CollectionCount(0);
        LastGen1 = GC.CollectionCount(1);
        LastGen2 = GC.CollectionCount(2);
        LastAllocatedBytes = GC.GetTotalAllocatedBytes();

        Console.WriteLine();
        Console.WriteLine("[GC] Monitor started (reporting every 5 seconds)");
        Console.WriteLine("[GC] ─────────────────────────────────────────────────────────────────────────");
        Console.WriteLine("[GC] Time     │ Gen0 │ Gen1 │ Gen2 │ Heap (MB) │ Allocated (MB) │ Alloc Rate");
        Console.WriteLine("[GC] ─────────────────────────────────────────────────────────────────────────");

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

    public void PrintStats()
    {
        var gen0 = GC.CollectionCount(0);
        var gen1 = GC.CollectionCount(1);
        var gen2 = GC.CollectionCount(2);
        var heapBytes = GC.GetTotalMemory(false);
        var allocatedBytes = GC.GetTotalAllocatedBytes();

        var deltaGen0 = gen0 - LastGen0;
        var deltaGen1 = gen1 - LastGen1;
        var deltaGen2 = gen2 - LastGen2;
        var deltaAllocated = allocatedBytes - LastAllocatedBytes;

        var elapsed = Stopwatch.Elapsed;
        var heapMB = heapBytes / (1024.0 * 1024.0);
        var allocatedMB = allocatedBytes / (1024.0 * 1024.0);
        var allocRateKBps = deltaAllocated / 5.0 / 1024.0; // KB/s over 5 second interval

        Console.WriteLine($"[GC] {elapsed:mm\\:ss\\.f}  │ +{deltaGen0,-3} │ +{deltaGen1,-3} │ +{deltaGen2,-3} │ {heapMB,9:F2} │ {allocatedMB,14:F2} │ {allocRateKBps,8:F1} KB/s");

        LastGen0 = gen0;
        LastGen1 = gen1;
        LastGen2 = gen2;
        LastAllocatedBytes = allocatedBytes;
    }

    public void PrintSummary()
    {
        var elapsed = Stopwatch.Elapsed;
        var gen0 = GC.CollectionCount(0);
        var gen1 = GC.CollectionCount(1);
        var gen2 = GC.CollectionCount(2);
        var heapBytes = GC.GetTotalMemory(false);
        var allocatedBytes = GC.GetTotalAllocatedBytes();

        Console.WriteLine();
        Console.WriteLine("[GC] ═══════════════════════════════════════════════════════════════════════");
        Console.WriteLine("[GC] Summary");
        Console.WriteLine("[GC] ═══════════════════════════════════════════════════════════════════════");
        Console.WriteLine($"[GC]   Runtime:            {elapsed:mm\\:ss\\.fff}");
        Console.WriteLine($"[GC]   Total Collections:  Gen0={gen0}, Gen1={gen1}, Gen2={gen2}");
        Console.WriteLine($"[GC]   Final Heap Size:    {heapBytes / (1024.0 * 1024.0):F2} MB");
        Console.WriteLine($"[GC]   Total Allocated:    {allocatedBytes / (1024.0 * 1024.0):F2} MB");
        Console.WriteLine($"[GC]   Avg Alloc Rate:     {allocatedBytes / elapsed.TotalSeconds / 1024.0:F1} KB/s");

        // GC memory info for more details
        var gcInfo = GC.GetGCMemoryInfo();
        Console.WriteLine($"[GC]   High Memory Load:   {gcInfo.HighMemoryLoadThresholdBytes / (1024.0 * 1024.0):F0} MB threshold");
        Console.WriteLine($"[GC]   Heap Size (Commit): {gcInfo.HeapSizeBytes / (1024.0 * 1024.0):F2} MB");
        Console.WriteLine($"[GC]   Fragmented Bytes:   {gcInfo.FragmentedBytes / 1024.0:F1} KB");
        Console.WriteLine($"[GC]   Pinned Objects:     {gcInfo.PinnedObjectsCount}");
        Console.WriteLine("[GC] ═══════════════════════════════════════════════════════════════════════");
    }
}
