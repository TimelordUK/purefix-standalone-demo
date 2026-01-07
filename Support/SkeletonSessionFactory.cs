using Arrow.Threading.Tasks;
using PureFix.Buffer;
using PureFix.Transport.Recovery;
using PureFix.Transport.Session;
using PureFix.Types;

namespace TradeCaptureDemo.Support;

/// <summary>
/// Session factory for skeleton mode.
/// Creates SkeletonHandler for both initiator and acceptor roles.
/// </summary>
public class SkeletonSessionFactory(
    IFixConfig config,
    IFixLogRecovery? fixLogRecovery,
    ILogFactory logFactory,
    IFixMessageFactory fixMessageFactory,
    IMessageParser parser,
    IMessageEncoder encoder,
    IFixClock clock)
    : ISessionFactory
{
    public FixSession MakeSession()
    {
        // Use the same SkeletonHandler for both client and server
        return new SkeletonHandler(config, fixLogRecovery, logFactory, fixMessageFactory, parser, encoder, clock);
    }
}
