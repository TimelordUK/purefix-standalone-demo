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
1. Start a FIX acceptor (server) on `localhost:2346`
2. Start a FIX initiator (client) that connects to the server
3. Exchange logon messages and establish a session
4. Client requests trade capture reports
5. Server streams trade data every 5 seconds

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

## License

MIT

## Links

- [PureFix on NuGet](https://www.nuget.org/packages?q=purefix)
