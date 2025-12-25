# PureFix.Transport

A high-performance C# FIX protocol engine for .NET.

## Features

- **Strongly-typed messages** - Generate C# classes from FIX XML dictionaries with full IntelliSense support
- **Automatic serialization** - Messages encode/decode without manual byte manipulation
- **Session management** - Logon, logout, heartbeat, sequence numbers handled automatically
- **Message recovery** - Resend requests and gap fill support built-in
- **Persistent stores** - File-based or in-memory message stores for session continuity
- **SSL/TLS support** - Secure connections out of the box
- **Broker reset handling** - Automatic sequence number reset negotiation
- **Dependency injection** - Clean integration with Microsoft.Extensions.DependencyInjection

## Quick Start

See the [full demo project](https://github.com/TimelordUK/purefix-standalone-demo) for a complete working example with Trade Capture.

### Installation

```bash
# Install runtime packages
dotnet add package PureFix.Transport
dotnet add package PureFix.Types
dotnet add package PureFix.Types.Core

# Install code generator tool
dotnet tool install purefix-gen
```

### Generate Types from FIX Dictionary

```bash
purefix-gen -D FIX50SP2.xml -g -p Generated --nuget --namespace MyApp.Fix.Types
```

This generates:
- Strongly-typed message classes (`NewOrderSingle`, `ExecutionReport`, etc.)
- Component classes (`Instrument`, `Parties`, etc.)
- Enum value constants (`SideValues.Buy`, `OrdTypeValues.Limit`, etc.)
- A `FixMessageFactory` for parsing incoming messages

## Example Usage

### Sending Messages

```csharp
// Create a strongly-typed order
var order = new NewOrderSingle
{
    ClOrdID = "order-123",
    Instrument = new Instrument { Symbol = "AAPL" },
    Side = SideValues.Buy,
    OrderQty = 100,
    OrdType = OrdTypeValues.Market,
    TransactTime = DateTime.UtcNow
};

// Send it - serialization is automatic
await session.Send(MsgTypeValues.NewOrderSingle, order);
```

### Receiving Messages

```csharp
protected override Task OnApplicationMsg(string msgType, IMessageView view)
{
    switch (msgType)
    {
        case MsgType.ExecutionReport:
            // Parse into strongly-typed object
            var exec = (ExecutionReport)messageFactory.ToFixMessage(view)!;

            // Access typed properties with IntelliSense
            Console.WriteLine($"Fill: {exec.Instrument?.Symbol} " +
                            $"{exec.LastQty} @ {exec.LastPx}");
            break;

        case MsgType.OrderCancelReject:
            var reject = (OrderCancelReject)messageFactory.ToFixMessage(view)!;
            Console.WriteLine($"Reject: {reject.Text}");
            break;
    }
    return Task.CompletedTask;
}
```

### Session Configuration

```json
{
  "application": {
    "type": "initiator",
    "tcp": { "host": "fix.broker.com", "port": 9823 },
    "protocol": "ascii",
    "dictionary": "FIX44.xml"
  },
  "store": {
    "type": "file",
    "directory": "store/session1"
  },
  "ResetSeqNumFlag": false,
  "HeartBtInt": 30,
  "SenderCompId": "YOUR_COMP_ID",
  "TargetCompID": "BROKER_COMP_ID",
  "BeginString": "FIX.4.4",
  "Username": "your_username",
  "Password": "your_password"
}
```

## How It Works

```
┌─────────────────┐     ┌──────────────────┐     ┌─────────────────┐
│  FIX Dictionary │────►│   purefix-gen    │────►│ Generated Types │
│   (XML file)    │     │  (code generator)│     │   (C# classes)  │
└─────────────────┘     └──────────────────┘     └─────────────────┘
                                                          │
                                                          ▼
┌─────────────────┐     ┌──────────────────┐     ┌─────────────────┐
│   Your Code     │◄───►│ PureFix.Transport│◄───►│   FIX Server    │
│ (type-safe API) │     │ (session/network)│     │    (broker)     │
└─────────────────┘     └──────────────────┘     └─────────────────┘
```

1. **Define** your FIX schema in an XML dictionary (or use standard FIX44/FIX50SP2)
2. **Generate** strongly-typed C# classes with `purefix-gen`
3. **Send/receive** messages using the type-safe API
4. **PureFix handles** session management, heartbeats, sequence numbers, and recovery

## Supported FIX Versions

- FIX 4.0, 4.1, 4.2, 4.3, 4.4
- FIX 5.0, 5.0 SP1, 5.0 SP2
- Custom dictionaries

## Documentation & Examples

| Resource | Description |
|----------|-------------|
| [Demo Project](https://github.com/TimelordUK/purefix-standalone-demo) | Full working example with Trade Capture workflow |
| [Type Generation](https://github.com/TimelordUK/purefix-standalone-demo#how-type-generation-works) | How XML dictionaries become C# classes |
| [Broker Reset](https://github.com/TimelordUK/purefix-standalone-demo#broker-reset-scenario) | Handling daily sequence number resets |
| [Session Recovery](https://github.com/TimelordUK/purefix-standalone-demo#recovery-mode) | Resuming sessions after restart |

## Related Packages

| Package | Purpose |
|---------|---------|
| [PureFix.Transport](https://www.nuget.org/packages/PureFix.Transport) | Session management, TCP transport, stores |
| [PureFix.Types.Core](https://www.nuget.org/packages/PureFix.Types.Core) | Base interfaces (IFixMessage, IFixParser, etc.) |
| [PureFix.Types](https://www.nuget.org/packages/PureFix.Types) | Standard FIX types and utilities |

## License

MIT
