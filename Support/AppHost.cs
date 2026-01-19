using Arrow.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using PureFix.Transport.Session;
using PureFix.Types;

namespace TradeCaptureDemo.Support;

public class AppHost<T, U, V> : BaseAppDI
    where T : class, ISessionFactory
    where U : class, IFixMessageFactory
    where V : class, ISessionMessageFactory
{
    protected AppHost(ILogFactory factory, IFixClock clock, IFixConfig config)
        : base(factory, clock, config)
    {
        _builder.Services.AddSingleton<ISessionFactory, T>();
        _builder.Services.AddSingleton<IFixMessageFactory, U>();
        _builder.Services.AddSingleton<ISessionMessageFactory, V>();
        AppHost = _builder.Build();

        // Set the MessageFactory on the config from DI
        var sessionMessageFactory = AppHost.Services.GetRequiredService<ISessionMessageFactory>();
        if (config is PureFix.Transport.FixConfig fixConfig)
        {
            fixConfig.MessageFactory = sessionMessageFactory;

            // For acceptors, add a session registry to prevent stale transport issues on client reconnect.
            // When a client reconnects before the old transport detects disconnect, the registry
            // stops the old session to prevent it from writing to a stale transport handle.
            if (!config.IsInitiator())
            {
                fixConfig.SessionRegistry = new SessionRegistry(factory);
            }
        }
    }
}
