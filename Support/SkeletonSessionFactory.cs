using PureFix.Buffer;
using PureFix.Buffer.Ascii;
using PureFix.Transport.Recovery;
using PureFix.Transport.Session;
using PureFix.Types;

namespace TradeCaptureDemo.Support;

/// <summary>
/// Session factory for skeleton mode.
/// Creates SkeletonHandler for both initiator and acceptor roles.
/// Creates a fresh parser per session to ensure thread isolation.
/// </summary>
public class SkeletonSessionFactory(
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
        var parser = new AsciiParser(config.Definitions!)
        {
            Delimiter = config.Delimiter
        };

        return new SkeletonHandler(config, fixLogRecovery, logFactory, fixMessageFactory, parser, encoder, clock);
    }
}
