using Arrow.Threading.Tasks;
using PureFix.Buffer;
using PureFix.Transport.Recovery;
using PureFix.Transport.Session;
using PureFix.Types;

namespace TradeCaptureDemo.Support;

public class DemoSessionFactory(
    IFixConfig config,
    IFixLogRecovery? fixLogRecovery,
    ILogFactory logFactory,
    IFixMessageFactory fixMessageFactory,
    IMessageParser parser,
    IMessageEncoder encoder,
    AsyncWorkQueue q,
    IFixClock clock)
    : ISessionFactory
{
    public FixSession MakeSession()
    {
        FixSession entity = config.IsInitiator() 
            ? new DemoClient(config, fixLogRecovery, logFactory, fixMessageFactory, parser, encoder, q, clock)
            : new DemoServer(config, fixLogRecovery, logFactory, fixMessageFactory, parser, encoder, q, clock);

        return entity;
    }
}
