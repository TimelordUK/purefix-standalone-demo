# PureFix Trade Capture Demo

A standalone demonstration of the **PureFix** FIX engine for .NET, showcasing strongly-typed message generation, session management, and sequence number recovery scenarios.

## Overview

This demo implements a complete FIX 5.0 SP2 trade capture workflow:

- **Server (Acceptor)**: Listens for connections, processes `TradeCaptureReportRequest` messages, and streams `TradeCaptureReport` messages
- **Client (Initiator)**: Connects to the server, subscribes to trade updates, and receives real-time trade data

The demo highlights PureFix's key features:
- **Code generation** from FIX XML dictionaries producing strongly-typed C# classes
- **Automatic session management** (logon, heartbeat, sequence numbers)
- **Persistent message store** with broker-initiated reset handling
- **Dependency injection** integration

## Prerequisites

- .NET 9.0 SDK
- The `purefix-gen` tool (automatically restored during build)

## Quick Start

```bash
# Clone and run
git clone git@github.com:TimelordUK/purefix-standalone-demo.git
cd purefix-standalone-demo
dotnet run
```

The demo will:
1. Start a FIX acceptor (server) on `localhost:2344`
2. Start a FIX initiator (client) that connects to the server
3. Exchange logon messages and establish a session
4. Client requests security definitions for market "20" (Precious Metals)
5. Server responds with 5 SecurityDefinition messages (Gold, Silver, Platinum, Copper, Steel)
6. Client receives all securities, then requests trade capture reports
7. Server streams trade data every 5 seconds

## Message Flow

```
Client                              Server
   |                                   |
   |--- Logon ----------------------->|
   |<-- Logon -------------------------|
   |                                   |
   |--- SecurityDefinitionRequest ---->|  (MarketID=20)
   |                                   |
   |<-- SecurityDefinition (Gold) -----|
   |<-- SecurityDefinition (Silver) ---|
   |<-- SecurityDefinition (Platinum) -|
   |<-- SecurityDefinition (Copper) ---|
   |<-- SecurityDefinition (Steel) ----|
   |                                   |
   |--- TradeCaptureReportRequest ---->|  (after 5 securities received)
   |<-- TradeCaptureReportRequestAck --|
   |<-- TradeCaptureReport (Gold) -----|
   |<-- TradeCaptureReport (Silver) ---|
   |    ... trades continue ...        |
```

This demonstrates a realistic FIX workflow where the client first discovers available instruments before subscribing to trade data

Press `Ctrl+C` to stop.

## Run Modes

### Default Mode (reset)
```bash
dotnet run
# or
dotnet run reset
```
Uses in-memory store with `ResetSeqNumFlag=Y`. Sequence numbers reset on each run.

### Recovery Mode
```bash
dotnet run clear      # Start fresh
dotnet run recovery   # Run, exchange messages, Ctrl+C to stop
dotnet run recovery   # Run again - resumes from stored sequence numbers
```
Uses file-based store with `ResetSeqNumFlag=N`. Demonstrates session resumption after restart.

### Broker Reset Mode
```bash
dotnet run clear
dotnet run broker-reset
```
Simulates a daily reset scenario where:
- **Client** sends `ResetSeqNumFlag=N` (wants to resume)
- **Server** responds with `ResetSeqNumFlag=Y` (forces reset)
- Client detects the mismatch and resets its local store

This is the common real-world scenario where brokers reset sequence numbers daily.

### Enable File Logging
```bash
dotnet run reset --log
dotnet run recovery -l
```
Writes detailed FIX message logs to the `logs/` directory.

## Project Structure

```
purefix-standalone-demo/
├── Program.cs                 # Entry point, mode selection
├── TradeCaptureDemo.csproj    # Main project
├── TradeCaptureDemo.sln       # Solution file
├── Directory.Build.targets    # MSBuild targets for code generation
├── Data/
│   ├── FIX50SP2-TC.xml        # FIX dictionary (customized for Trade Capture)
│   ├── FIX50SP2.xml           # Standard FIX 5.0 SP2 dictionary
│   └── Session/               # Session configuration files
│       ├── broker-reset-*.json
│       ├── recovery-*.json
│       └── test-qf52-*.json
├── Generated/                 # Auto-generated types (do not edit)
│   └── TradeCaptureDemo.Types.FIX50SP2TC/
│       ├── TradeCaptureDemo.Types.FIX50SP2TC.csproj
│       ├── FixMessageFactory.cs      # Message type switch/parser
│       ├── TradeCaptureReport.cs     # Generated message class
│       ├── Logon.cs, Heartbeat.cs... # Session messages
│       ├── Components/               # Reusable components
│       └── Enums/                    # Field value enumerations
└── Support/
    ├── DemoHost.cs            # DI container setup
    ├── DemoClient.cs          # Client session logic
    ├── DemoServer.cs          # Server session logic
    └── ...
```

## How Type Generation Works

PureFix generates strongly-typed C# classes from FIX XML dictionary files. This happens automatically during build.

### 1. FIX Dictionary (XML)

The `Data/FIX50SP2-TC.xml` file defines the FIX protocol schema:

```xml
<fix type='FIX' major='5' minor='0' servicepack='2'>
  <messages>
    <message name='TradeCaptureReport' msgcat='app' msgtype='AE'>
      <field name='TradeReportID' required='Y' />
      <field name='TradeReportTransType' required='N' />
      <component name='Instrument' required='N' />
      <field name='LastQty' required='N' />
      <field name='LastPx' required='N' />
      ...
    </message>
  </messages>
  <fields>
    <field number='571' name='TradeReportID' type='STRING' />
    <field number='32' name='LastQty' type='QTY' />
    ...
  </fields>
</fix>
```

### 2. Code Generation (MSBuild)

The `Directory.Build.targets` file triggers generation before build:

```xml
<Target Name="GeneratePureFixTypes" BeforeTargets="Restore">
  <Exec Command="dotnet tool run purefix-gen
    -D $(PureFixDictionary)
    -g -p $(PureFixGeneratedPath)
    --nuget --pkg-version $(PureFixVersion)
    --namespace $(PureFixNamespace)" />
</Target>
```

This runs automatically when the dictionary is newer than the generated code.

### 3. Generated Types

The generator creates:

**Message Classes** (`TradeCaptureReport.cs`):
```csharp
public class TradeCaptureReport : IFixMessage, IFixParser, IFixEncoder
{
    public string? TradeReportID { get; set; }
    public int? TradeReportTransType { get; set; }
    public Instrument? Instrument { get; set; }
    public decimal? LastQty { get; set; }
    public decimal? LastPx { get; set; }
    // ... all fields from the dictionary

    void IFixParser.Parse(IMessageView view) { /* ... */ }
    void IFixEncoder.Encode(IBufferWriter writer) { /* ... */ }
}
```

**Message Factory** (`FixMessageFactory.cs`):
```csharp
public class FixMessageFactory : IFixMessageFactory
{
    public IFixMessage? ToFixMessage(IMessageView view)
    {
        var msgType = view.GetString((int)MsgTag.MsgType);
        switch (msgType)
        {
            case "AE":  // TradeCaptureReport
                var o = new TradeCaptureReport();
                ((IFixParser)o).Parse(view);
                return o;
            // ... all message types
        }
    }
}
```

**Enums** (`Enums/TradeReportTransTypeValues.cs`):
```csharp
public static class TradeReportTransTypeValues
{
    public const int New = 0;
    public const int Cancel = 1;
    public const int Replace = 2;
    // ...
}
```

## Type Registration and Dependency Injection

The generated types are integrated via generic type parameters and DI:

### 1. DemoHost Configuration

```csharp
// Support/DemoHost.cs
internal class DemoHost : AppHost<DemoSessionFactory, FixMessageFactory, Fix50SP2SessionMessageFactory>
{
    // FixMessageFactory = generated factory for parsing incoming messages
    // Fix50SP2SessionMessageFactory = factory for session messages (Logon, etc.)
}
```

### 2. AppHost DI Registration

```csharp
// Support/AppHost.cs
public class AppHost<T, U, V> : BaseAppDI
    where U : class, IFixMessageFactory
{
    protected AppHost(...)
    {
        _builder.Services.AddSingleton<IFixMessageFactory, U>();
        // U = FixMessageFactory from Generated assembly
    }
}
```

### 3. Message Handling

```csharp
// Support/DemoClient.cs
protected override Task OnApplicationMsg(string msgType, IMessageView view)
{
    switch (msgType)
    {
        case MsgType.TradeCaptureReport:
            // Parse raw bytes into strongly-typed object
            var tc = (TradeCaptureReport)m_msg_factory.ToFixMessage(view)!;

            // Access typed properties
            Console.WriteLine($"Trade: {tc.Instrument?.Symbol} {tc.LastQty} @ ${tc.LastPx}");
            break;
    }
}
```

## Session Configuration

Session configs are JSON files in `Data/Session/`:

```json
{
  "application": {
    "type": "initiator",           // or "acceptor"
    "tcp": { "host": "localhost", "port": 2346 },
    "protocol": "ascii",
    "dictionary": "FIX50SP2.xml"
  },
  "store": {
    "type": "file",                // or "memory"
    "directory": "store/client"
  },
  "ResetSeqNumFlag": false,        // Key for recovery scenarios
  "HeartBtInt": 30,
  "SenderCompId": "CLIENT",
  "TargetCompID": "SERVER",
  "BeginString": "FIX.5.0SP2"
}
```

## Broker Reset Scenario

The broker-reset mode demonstrates a real-world scenario:

```
┌─────────────────────────────────────────────────────────────────────┐
│                     Broker Reset Flow                               │
├─────────────────────────────────────────────────────────────────────┤
│                                                                     │
│  Client (Initiator)              Server (Acceptor/Broker)           │
│  ─────────────────               ───────────────────────            │
│                                                                     │
│  Has stored seqnum=50            Resets daily, starts at seqnum=1   │
│  ResetSeqNumFlag=N               ResetSeqNumFlag=Y                  │
│                                                                     │
│        ──────── Logon (SeqNum=50, Reset=N) ────────►                │
│                                                                     │
│        ◄─────── Logon (SeqNum=1, Reset=Y) ─────────                 │
│                                                                     │
│  Detects Reset=Y from server                                        │
│  Clears local store                                                 │
│  Resets to seqnum=1                                                 │
│                                                                     │
│        ──────── Messages continue normally ────────►                │
│                                                                     │
└─────────────────────────────────────────────────────────────────────┘
```

Run the demo:
```bash
dotnet run clear        # Clean any existing store
dotnet run broker-reset # Watch the reset negotiation
```

Watch the logs for:
```
Client: FILE store, ResetSeqNumFlag=N
Server: FILE store, ResetSeqNumFlag=Y (forces client reset)
```

## Customizing the Dictionary

To modify the FIX schema:

1. Edit `Data/FIX50SP2-TC.xml` (add/remove messages, fields, components)
2. Run `dotnet build` - regeneration happens automatically
3. Use the new types in your code

The generator detects when the dictionary is newer than generated code and regenerates.

## Key PureFix Packages

| Package | Purpose |
|---------|---------|
| `PureFix.Transport` | Session management, TCP transport, stores |
| `PureFix.Types.Core` | Base interfaces (`IFixMessage`, `IFixParser`, etc.) |
| `PureFix.Types` | Standard FIX types and utilities |

## GC Performance

The demo includes built-in GC monitoring to observe allocation behaviour. While PureFix is not designed as a zero-allocation engine, it aims to be efficient and avoid wasteful allocations.

### Running a Soak Test

```bash
dotnet run --configuration Release 2>&1 | tee soak-test.log

# Extract GC stats
grep "^\[GC\]" soak-test.log
```

### Sample Results (43-minute soak test)

```
[GC] Time     │ Gen0 │ Gen1 │ Gen2 │ Heap (MB) │ Allocated (MB) │ Alloc Rate
[GC] ─────────────────────────────────────────────────────────────────────────
[GC] 00:05.0  │ +39  │ +22  │ +5   │    276.87 │         583.05 │ 119392.6 KB/s  <- startup
[GC] 00:10.0  │ +0   │ +0   │ +0   │    277.09 │         583.27 │     44.3 KB/s
[GC] 00:15.0  │ +0   │ +0   │ +0   │    277.37 │         583.56 │     58.5 KB/s
...
[GC] 01:15.0  │ +1   │ +0   │ +0   │    272.66 │         586.01 │     54.0 KB/s  <- Gen0 collection
...
[GC] 42:46.1  │ +0   │ +0   │ +0   │    280.80 │         685.58 │     55.4 KB/s
```

### Summary

| Metric | Startup | Steady State |
|--------|---------|--------------|
| Gen0 collections | 39 | ~1 per 5 minutes |
| Gen1 collections | 22 | ~1 per 35 minutes |
| Gen2 collections | 5 | 0 |
| Allocation rate | 119 MB/s (JIT, DI, init) | ~40 KB/s |
| Heap size | - | Stable ~275-280 MB |

**Key observations:**
- Startup burst is expected (.NET runtime, DI container, JIT compilation)
- Steady-state shows minimal GC pressure with infrequent Gen0 collections
- No Gen2 collections during operation indicates no memory leaks
- Heap size remains stable throughout the test
- Total allocation over 43 minutes: ~100 MB (~40 KB/s average)

### Skeleton Mode (Baseline Testing)

To measure the GC overhead of just the FIX engine without application messages, use skeleton mode:

```bash
dotnet run -- --skeleton 2>&1 | tee gc.log

# Let it run, then check for GC activity
grep "\[GC\]" gc.log
```

In skeleton mode, client and server connect and maintain the session with heartbeats only - no application messages are sent. This isolates the engine's baseline allocation behaviour.

**Sample results (15-minute skeleton soak test):**

```
[GC] Time     │ Gen0 │ Gen1 │ Gen2 │ Heap (MB) │ Allocated (MB) │ Alloc Rate
[GC] ─────────────────────────────────────────────────────────────────────────
[GC] 00:05.0  │ +30  │ +22  │ +5   │    266.37 │         582.50 │ 119284.2 KB/s  <- startup
[GC] 00:10.0  │ +0   │ +0   │ +0   │    266.42 │         582.55 │      9.6 KB/s
[GC] 00:15.0  │ +0   │ +0   │ +0   │    266.42 │         582.59 │      8.2 KB/s
...
[GC] 15:00.0  │ +0   │ +0   │ +0   │    266.45 │         582.91 │      6.4 KB/s
```

| Mode | Steady-State Alloc Rate | Gen0 Collections |
|------|------------------------|------------------|
| Skeleton (heartbeats only) | ~6-10 KB/s | 0 over 15 minutes |
| With trades (5s batches) | ~40-55 KB/s | ~1 per 5 minutes |

**Key insight:** The engine's baseline overhead is minimal. Zero Gen0 collections over 15 minutes in skeleton mode demonstrates no GC pressure from the session layer, timers, or heartbeat processing. The ~80% of allocations in normal mode come from application-level message encoding/decoding.

### Isolated Client/Server Testing

To measure GC overhead of just the client (initiator) or server (acceptor) independently, use the `--client` or `--server` flags. This is useful for testing against an external broker or isolating which side contributes to GC pressure.

```bash
# Run only the server (acceptor) - listens for connections
dotnet run -- --server

# Run only the client (initiator) - connects to server
dotnet run -- --client

# Skeleton mode variants for baseline GC testing
dotnet run -- --skeleton --server   # Server with heartbeats only
dotnet run -- --skeleton --client   # Client with heartbeats only

# Connect to an external broker with custom config
dotnet run -- --client --config /path/to/broker-config.json
```

**Sample results (client-only skeleton mode):**

```
[GC] Time     │ Gen0 │ Gen1 │ Gen2 │ Heap (MB) │ Allocated (MB) │ Alloc Rate
[GC] ─────────────────────────────────────────────────────────────────────────
[GC] 00:05.0  │ +14  │ +10  │ +1   │    380.26 │         872.13 │  59640.9 KB/s  <- startup
[GC] 00:10.0  │ +0   │ +0   │ +0   │    380.28 │         872.16 │      4.8 KB/s
[GC] 00:15.0  │ +0   │ +0   │ +0   │    380.31 │         872.18 │      4.7 KB/s
[GC] 00:20.0  │ +0   │ +0   │ +0   │    380.34 │         872.20 │      4.8 KB/s
```

This allows you to:
- Test your client against a real external FIX broker
- Isolate GC overhead to client vs server
- Run server in one terminal, client in another for debugging
- Use different configs for each side

### Reconnection Testing

The FIX engine supports automatic reconnection when the connection is lost. The client (initiator) will retry connecting at intervals defined by `reconnectSeconds` in the config (default 10 seconds).

**Test scenario 1: Server restart**

```bash
# Terminal 1 - Start server
dotnet run -- --skeleton --server

# Terminal 2 - Start client (connects successfully)
dotnet run -- --skeleton --client

# Kill server (Ctrl+C in Terminal 1)
# Client detects disconnect and starts retry loop:
#   [INF] Reader received TransportDead signal, stopping session.
#   [INF] session has ended.
#   [INF] waiting 10s before reconnection attempt
#   [INF] attempting to connect attempt 1
#   [ERR] Connection refused
#   [INF] waiting 10s for reconnection attempt
#   ... retries every 10 seconds ...

# Restart server (Terminal 1)
dotnet run -- --skeleton --server

# Client reconnects automatically:
#   [INF] reconnected to endpoint, reusing session.
#   [INF] PrepareForReconnect: resetting session state
#   [INF] Session ready - running in heartbeat-only mode
```

**Test scenario 2: Client starts before server**

```bash
# Terminal 1 - Start client first (no server running)
dotnet run -- --skeleton --client
# Client retries in a loop:
#   [INF] attempting to connect attempt 1
#   [ERR] Connection refused
#   [INF] waiting 10s for reconnection attempt
#   ...

# Terminal 2 - Start server
dotnet run -- --skeleton --server

# Client connects on next attempt:
#   [INF] connected to endpoint, creating session.
#   [INF] Session ready
```

**Key behaviours:**
- Same session instance is reused across reconnects (app state preserved)
- Sequence numbers are preserved when using file store with `ResetSeqNumFlag=false`
- With `ResetSeqNumFlag=true` (default for skeleton mode), sequences reset on each logon
- Reconnect interval is configurable via `reconnectSeconds` in session config

## Test Scenarios

The demo includes a comprehensive test script that validates common FIX session scenarios. These cover the typical situations encountered when connecting to brokers in production.

```bash
./test-scenarios.sh --help
```

```
┌─────────────────────────────────────────────────────────────────────────────┐
│                        Test Scenarios Summary                               │
├─────────────────┬───────────────────────────────────────────────────────────┤
│ seq-mismatch    │ Client sequence too low on logon                          │
│                 │ → Server rejects, client retries with +1 until aligned    │
│                 │ → QuickFix compatible behavior                            │
├─────────────────┼───────────────────────────────────────────────────────────┤
│ server-bounce   │ Server restarts mid-session                               │
│                 │ → Both sides use file store to persist sequences          │
│                 │ → Session resumes from where it left off                  │
├─────────────────┼───────────────────────────────────────────────────────────┤
│ client-bounce   │ Client restarts mid-session (most common real-world)      │
│                 │ → Server keeps running (simulates broker)                 │
│                 │ → Client reconnects with reset=N, resumes from store      │
├─────────────────┼───────────────────────────────────────────────────────────┤
│ broker-reset    │ Server-initiated daily sequence reset                     │
│                 │ → Client sends reset=N, server responds reset=Y           │
│                 │ → Both sides reset to seq=1 (broker controls reset time)  │
│                 │ → Typical broker pattern (e.g., 22:10 daily reset)        │
├─────────────────┼───────────────────────────────────────────────────────────┤
│ all             │ Run all scenarios sequentially                            │
└─────────────────┴───────────────────────────────────────────────────────────┘
```

**Run individual scenarios:**

```bash
./test-scenarios.sh seq-mismatch    # Test sequence recovery
./test-scenarios.sh client-bounce   # Test client reconnection
./test-scenarios.sh broker-reset    # Test daily reset handling
./test-scenarios.sh all             # Run all tests
```

Each scenario validates that:
- Sequence numbers are correctly persisted and recovered
- Reset flags are handled according to FIX protocol
- Sessions can resume after disconnection
- Both sides remain synchronized

## TLS Encrypted Connections

Most brokers require TLS encryption for FIX connections. PureFix supports TLS 1.2/1.3 with certificate-based authentication.

### Generate Certificates

For testing, generate self-signed certificates:

```bash
# Linux/macOS
./genkey.sh                 # Uses default password 'jspurefix'
./genkey.sh mypassword      # Uses custom password

# Windows (PowerShell)
.\genkey.ps1                # Interactive prompts
```

This creates certificates in `Data/certs/`:
```
Data/certs/
├── ca/ca.crt           # Certificate Authority
├── server/server.pfx   # Server certificate (PFX format for .NET)
└── client/client.pfx   # Client certificate (PFX format for .NET)
```

### Run with TLS

```bash
# Generate certs first (if not already done)
./genkey.sh

# Run with TLS encryption
dotnet run -- --tls --timeout 10

# TLS with skeleton mode (for GC baseline testing)
dotnet run -- --tls --skeleton --timeout 30
```

### TLS Configuration

The TLS session configs are in `Data/Session/test-*-tls.json`:

```json
{
  "application": {
    "tcp": {
      "host": "localhost",
      "port": 2345,
      "tls": {
        "enabled": true,
        "certificate": "Data/certs/server/server.pfx",
        "password": "jspurefix",
        "validateServerCertificate": false
      }
    }
  }
}
```

**TLS Options:**

| Option | Description |
|--------|-------------|
| `enabled` | Enable TLS encryption |
| `certificate` | Path to PFX/P12 certificate file |
| `password` | Certificate password |
| `targetHost` | SNI hostname (client only, defaults to tcp.host) |
| `validateServerCertificate` | Validate server cert chain (set `false` for self-signed) |

### Connecting to Brokers with TLS

When connecting to a real broker:

1. Obtain their CA certificate or use system trust store
2. Generate or obtain your client certificate
3. Convert to PFX format if needed:
   ```bash
   openssl pkcs12 -export -out client.pfx \
       -inkey client.key -in client.crt \
       -passout pass:yourpassword
   ```
4. Configure `validateServerCertificate: true` for production

## License

MIT

## Links

- [PureFix on NuGet](https://www.nuget.org/packages?q=purefix)
