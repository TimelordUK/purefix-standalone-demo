using Arrow.Threading.Tasks;
using PureFix.Buffer;
using PureFix.Transport.Ascii;
using PureFix.Transport.Recovery;
using PureFix.Transport.Session;
using PureFix.Types;

namespace TradeCaptureDemo.Support;

/// <summary>
/// Minimal skeleton handler for GC baseline testing.
/// Does nothing on application messages - only session-level heartbeats flow after logon.
/// Use this with --skeleton flag to measure baseline GC overhead of the FIX engine.
/// </summary>
internal class SkeletonHandler : BaseApp
{
    private readonly string _role;

    public SkeletonHandler(
        IFixConfig config,
        IFixLogRecovery? fixLogRecover,
        ILogFactory logFactory,
        IFixMessageFactory fixMessageFactory,
        IMessageParser parser,
        IMessageEncoder encoder,
        IFixClock clock)
        : base(config, fixLogRecover, logFactory, fixMessageFactory, parser, encoder, clock)
    {
        _role = config.IsInitiator() ? "Client" : "Server";
        m_logReceivedMessages = false; // Minimize allocations
    }

    protected override Task OnApplicationMsg(string msgType, IMessageView view)
    {
        // Do nothing - this is a skeleton for baseline GC testing
        return Task.CompletedTask;
    }

    protected override bool OnLogon(IMessageView view, string? user, string? password)
    {
        m_logger.Info($"[Skeleton {_role}] Logon accepted");
        return true;
    }

    protected override Task OnReady(IMessageView view)
    {
        m_logger.Info($"[Skeleton {_role}] Session ready - running in heartbeat-only mode");
        return Task.CompletedTask;
    }

    protected override void OnStopped(Exception? error)
    {
        m_logger.Info($"[Skeleton {_role}] Session stopped");
    }
}
