using Arrow.Threading.Tasks;
using PureFix.Buffer;
using PureFix.Transport.Recovery;
using PureFix.Transport.Session;
using PureFix.Types;

namespace TradeCaptureDemo.Support;

public class DemoSessionFactory : ISessionFactory
{
    private readonly IFixConfig _config;
    private readonly IFixLogRecovery? _fixLogRecovery;
    private readonly ILogFactory _logFactory;
    private readonly IFixMessageFactory _fixMessageFactory;
    private readonly IMessageParser _parser;
    private readonly IMessageEncoder _encoder;
    private readonly AsyncWorkQueue _queue;
    private readonly IFixClock _clock;

    public DemoSessionFactory(
        IFixConfig config,
        IFixLogRecovery? fixLogRecovery,
        ILogFactory logFactory,
        IFixMessageFactory fixMessageFactory,
        IMessageParser parser,
        IMessageEncoder encoder,
        AsyncWorkQueue q,
        IFixClock clock)
    {
        _config = config;
        _fixLogRecovery = fixLogRecovery;
        _logFactory = logFactory;
        _fixMessageFactory = fixMessageFactory;
        _parser = parser;
        _encoder = encoder;
        _queue = q;
        _clock = clock;
    }

    public FixSession MakeSession()
    {
        if (_config.IsInitiator())
        {
            return new DemoClient(_config, _fixLogRecovery, _logFactory, _fixMessageFactory, _parser, _encoder, _queue, _clock);
        }
        else
        {
            return new DemoServer(_config, _fixLogRecovery, _logFactory, _fixMessageFactory, _parser, _encoder, _queue, _clock);
        }
    }
}
