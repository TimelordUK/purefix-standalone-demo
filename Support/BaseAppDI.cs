using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using PureFix.Transport.Session;
using PureFix.Types;
using PureFix.Buffer;
using PureFix.Buffer.Ascii;
using PureFix.Transport.Store;
using PureFix.Transport.SocketTransport;
using PureFix.Transport;
using PureFix.Transport.Recovery;

namespace TradeCaptureDemo.Support;

public abstract class BaseAppDI
{
    public V? Resolve<V>()
    {
        return AppHost == null ? default : AppHost.Services.GetService<V>();
    }

    protected IHost? AppHost { get; set; }
    protected readonly HostApplicationBuilder _builder;

    protected BaseAppDI(ILogFactory factory, IFixClock clock, IFixConfig config)
    {
        ArgumentNullException.ThrowIfNull(config);
        ArgumentNullException.ThrowIfNull(config.Description);
        ArgumentNullException.ThrowIfNull(config.Definitions);
        ArgumentNullException.ThrowIfNull(config.Description.Application);
        ArgumentNullException.ThrowIfNull(config.Description.SenderCompID);

        _builder = Host.CreateApplicationBuilder();

        _builder.Services.AddSingleton(factory);
        _builder.Services.AddSingleton(clock);
        _builder.Services.AddSingleton(config);
        // NOTE: IMessageParser is NOT registered here - each session factory creates
        // its own parser instance in MakeSession() to ensure thread isolation.
        // Sharing a parser across sessions would cause race conditions.
        _builder.Services.AddSingleton<IMessageEncoder, AsciiEncoder>();
        _builder.Services.AddSingleton<IFixLogParser, FixLogParser>();
        _builder.Services.AddSingleton(config.Description);
        _builder.Services.AddSingleton(config.Definitions);
        _builder.Services.AddSingleton(config.Description.Application);
       
        var msgStore = new FixMsgMemoryStore(config.Description.SenderCompID);
        _builder.Services.AddSingleton<IFixMsgStore>(msgStore);
        _builder.Services.AddSingleton<IFixLogParser, FixLogParser>();
        _builder.Services.AddSingleton<IFixLogRecovery, FixLogRecovery>();

        if (config.IsInitiator())
        {
            _builder.Services.AddSingleton<ITcpEntity, TcpInitiatorConnector>();
        }
        else
        {
            _builder.Services.AddSingleton<ITcpEntity, TcpAcceptorListener>();
        }
    }
}
