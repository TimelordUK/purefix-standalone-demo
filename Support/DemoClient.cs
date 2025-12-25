using Arrow.Threading.Tasks;
using PureFix.Buffer;
using PureFix.Transport.Ascii;
using PureFix.Transport.Recovery;
using PureFix.Transport.Session;
using PureFix.Types;
using PureFix.Types.Core;
using PureFix.Types.FIX50SP2;

namespace TradeCaptureDemo.Support;

internal class DemoClient : BaseApp
{
    private readonly FixMessageFactory m_msg_factory = new();
    private int _receivedCount = 0;

    public DemoClient(IFixConfig config, IFixLogRecovery? fixLogRecover, ILogFactory logFactory, IFixMessageFactory fixMessageFactory, IMessageParser parser, IMessageEncoder encoder, AsyncWorkQueue q, IFixClock clock)
        : base(config, fixLogRecover, logFactory, fixMessageFactory, parser, encoder, q, clock)
    {
        m_logReceivedMessages = true;
    }

    protected override Task OnApplicationMsg(string msgType, IMessageView view)
    {
        switch (msgType)
        {
            case MsgType.TradeCaptureReport:
                {
                    var tc = (TradeCaptureReport)m_msg_factory.ToFixMessage(view)!;
                    _receivedCount++;
                    m_logger.Info($"[{_receivedCount}] Received Trade: {tc?.Instrument?.Symbol} {tc?.LastQty} @ ${tc?.LastPx}");
                    break;
                }

            case MsgType.TradeCaptureReportRequestAck:
                {
                    var tca = (TradeCaptureReportRequestAck)m_msg_factory.ToFixMessage(view)!;
                    m_logger.Info($"Trade request ack: {tca?.TradeRequestID} status={tca?.TradeRequestStatus}");
                    break;
                }
        }

        return Task.CompletedTask;
    }

    protected override bool OnLogon(IMessageView view, string user, string password)
    {
        m_logger.Info($"Server accepted logon for user: {user}");
        return true;
    }

    protected override async Task OnReady(IMessageView view)
    {
        m_logger.Info("Session ready - requesting trades");

        var tcr = new TradeCaptureReportRequest
        {
            TradeRequestID = "demo-request-1",
            TradeRequestType = TradeRequestTypeValues.AllTrades,
            SubscriptionRequestType = SubscriptionRequestTypeValues.SnapshotAndUpdates  // Request ongoing updates
        };

        await Send(MsgTypeValues.TradeCaptureReportRequest, tcr);
    }

    protected override void OnStopped(Exception? error)
    {
        m_logger.Info($"Client stopped. Received {_receivedCount} trades.");
    }
}
