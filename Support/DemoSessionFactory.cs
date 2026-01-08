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
    IFixClock clock)
    : ISessionFactory
{
    public FixSession MakeSession()
    {
        FixSession entity = config.IsInitiator() 
            ? new DemoClient(config, fixLogRecovery, logFactory, fixMessageFactory, parser, encoder, clock)
            : new DemoServer(config, fixLogRecovery, logFactory, fixMessageFactory, parser, encoder, clock);

        return entity;
    }
}
