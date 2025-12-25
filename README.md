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

## License

MIT

## Links

- [PureFix on NuGet](https://www.nuget.org/packages?q=purefix)
