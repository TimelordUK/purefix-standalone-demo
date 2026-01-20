using PureFix.Buffer;
using PureFix.Buffer.Ascii;
using PureFix.Transport.Recovery;
using PureFix.Transport.Session;
using PureFix.Types;

namespace TradeCaptureDemo.Support;

/// <summary>
/// Session factory that creates a fresh parser per session.
/// This ensures thread isolation - each session has its own parse state.
/// Critical for acceptors with multiple concurrent clients.
/// </summary>
public class DemoSessionFactory(
    IFixConfig config,
    IFixLogRecovery? fixLogRecovery,
    ILogFactory logFactory,
    IFixMessageFactory fixMessageFactory,
    IMessageEncoder encoder,
    IFixClock clock)
    : ISessionFactory
{
    public FixSession MakeSession()
    {
        // Create a NEW parser per session to ensure thread isolation.
        // The parser holds mutable state (_state, _pool) that is not thread-safe.
        // If multiple sessions shared one parser, concurrent ParseFrom() calls
        // would corrupt each other's state.
        var parser = new AsciiParser(config.Definitions!)
        {
            Delimiter = config.Delimiter
        };

        FixSession entity = config.IsInitiator()
            ? new DemoClient(config, fixLogRecovery, logFactory, fixMessageFactory, parser, encoder, clock)
            : new DemoServer(config, fixLogRecovery, logFactory, fixMessageFactory, parser, encoder, clock);

        return entity;
    }
}
