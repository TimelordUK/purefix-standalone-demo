using Arrow.Threading.Tasks;
using PureFix.Transport;
using PureFix.Transport.Session;
using PureFix.Transport.SocketTransport;
using PureFix.Types;
using TradeCaptureDemo.Support;

// Parse command line args
var mode = args.Length > 0 ? args[0].ToLower() : "reset";

Console.WriteLine("PureFix Standalone Trade Capture Demo");
Console.WriteLine("======================================");
Console.WriteLine($"Mode: {mode}");
Console.WriteLine();

if (mode == "help" || mode == "-h" || mode == "--help")
{
    Console.WriteLine("Usage: dotnet run [mode]");
    Console.WriteLine();
    Console.WriteLine("Modes:");
    Console.WriteLine("  reset        - Always reset sequence numbers (default)");
    Console.WriteLine("  recovery     - Use file store, resume from last session");
    Console.WriteLine("  broker-reset - Client sends N, broker responds Y (forces reset)");
    Console.WriteLine("  clear        - Delete store files and exit");
    Console.WriteLine();
    Console.WriteLine("Recovery test:");
    Console.WriteLine("  1. dotnet run clear        # Start fresh");
    Console.WriteLine("  2. dotnet run recovery     # Run, exchange messages, Ctrl+C");
    Console.WriteLine("  3. dotnet run recovery     # Run again - should resume from stored seq nums");
    Console.WriteLine();
    Console.WriteLine("Broker reset test (simulates daily reset):");
    Console.WriteLine("  1. dotnet run clear");
    Console.WriteLine("  2. dotnet run broker-reset # Client sends N, broker forces Y");
    Console.WriteLine("     Watch: Client should reset its store when broker responds Y");
    return;
}

// Paths
var baseDir = AppContext.BaseDirectory;
var dictRootPath = Path.Join(baseDir, "Data");
var sessionRootPath = Path.Join(dictRootPath, "Session");
var storeDir = Path.Join(baseDir, "store");

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
var acceptorTask = StartSession(acceptorConfig, dictRootPath, "Server");

// Wait a bit for the server to start listening
await Task.Delay(500);

// Start the initiator (client)
var initiatorTask = StartSession(initiatorConfig, dictRootPath, "Client");

// Wait for both to complete
await Task.WhenAll(acceptorTask, initiatorTask);

Console.WriteLine();
Console.WriteLine("Demo complete!");

static async Task StartSession(string configPath, string dictRootPath, string name)
{
    Console.WriteLine($"Starting {name}...");

    // Load config
    var config = FixConfig.MakeConfigFromPaths(dictRootPath, configPath);

    var storeType = config.Description?.Store?.Type ?? "memory";
    var resetFlag = config.Description?.ResetSeqNumFlag ?? false;
    Console.WriteLine($"  {name}: {config.Description?.SenderCompID} -> {config.Description?.TargetCompID}");
    Console.WriteLine($"  Store: {storeType}, ResetSeqNumFlag: {resetFlag}");

    // Create log factory from config
    var logFactory = new ConsoleLogFactory(config.Description);
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
