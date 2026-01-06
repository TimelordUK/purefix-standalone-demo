using Arrow.Threading.Tasks;
using PureFix.Buffer;
using PureFix.Transport.Ascii;
using PureFix.Transport.Recovery;
using PureFix.Transport.Session;
using PureFix.Types;
using PureFix.Types.Core;
using TradeCaptureDemo.Types.FIX50SP2TC;

namespace TradeCaptureDemo.Support;

internal class DemoClient : BaseApp
{
    private readonly FixMessageFactory m_msg_factory = new();
    private int _receivedTradeCount;
    private int _receivedSecurityCount;
    private const int ExpectedSecurityCount = 5;
    private readonly List<string> _knownSecurities = [];

    public DemoClient(IFixConfig config, IFixLogRecovery? fixLogRecover, ILogFactory logFactory, IFixMessageFactory fixMessageFactory, IMessageParser parser, IMessageEncoder encoder, AsyncWorkQueue q, IFixClock clock)
        : base(config, fixLogRecover, logFactory, fixMessageFactory, parser, encoder, q, clock)
    {
        m_logReceivedMessages = true;
    }

    protected override async Task OnApplicationMsg(string msgType, IMessageView view)
    {
        switch (msgType)
        {
            case MsgType.SecurityDefinition:
                {
                    var sd = (SecurityDefinition)m_msg_factory.ToFixMessage(view)!;
                    var symbol = sd.Instrument?.Symbol ?? "Unknown";
                    _knownSecurities.Add(symbol);
                    _receivedSecurityCount++;
                    m_logger.Info($"[{_receivedSecurityCount}/{ExpectedSecurityCount}] Received Security: {symbol}");

                    // Once we have all securities, request trades
                    if (_receivedSecurityCount >= ExpectedSecurityCount)
                    {
                        m_logger.Info($"Received all {ExpectedSecurityCount} securities - now requesting trades");
                        await SendTradeCaptureRequest();
                    }
                    break;
                }

            case MsgType.TradeCaptureReport:
                {
                    var tc = (TradeCaptureReport)m_msg_factory.ToFixMessage(view)!;
                    _receivedTradeCount++;
                    m_logger.Info($"[{_receivedTradeCount}] Received Trade: {tc.Instrument?.Symbol} {tc.LastQty} @ ${tc.LastPx}");
                    break;
                }

            case MsgType.TradeCaptureReportRequestAck:
                {
                    var tca = (TradeCaptureReportRequestAck)m_msg_factory.ToFixMessage(view)!;
                    m_logger.Info($"Trade request ack: {tca.TradeRequestID} status={tca.TradeRequestStatus}");
                    break;
                }
        }
    }

    protected override bool OnLogon(IMessageView view, string? user, string? password)
    {
        m_logger.Info($"Server accepted logon for user: {user}");
        return true;
    }

    protected override async Task OnReady(IMessageView view)
    {
        m_logger.Info("Session ready - requesting security definitions for market 20 (Precious Metals)");

        var sdr = new SecurityDefinitionRequest
        {
            SecurityReqID = "sec-req-1",
            SecurityRequestType = SecurityRequestTypeValues.MarketIdOrMarketId,
            MarketID = "20"  // Precious Metals market
        };

        await Send(MsgTypeValues.SecurityDefinitionRequest, sdr);
    }

    private async Task SendTradeCaptureRequest()
    {
        var tcr = new TradeCaptureReportRequest
        {
            TradeRequestID = "demo-request-1",
            TradeRequestType = TradeRequestTypeValues.AllTrades,
            SubscriptionRequestType = SubscriptionRequestTypeValues.SnapshotAndUpdates
        };

        await Send(MsgTypeValues.TradeCaptureReportRequest, tcr);
    }

    protected override void OnStopped(Exception? error)
    {
        m_logger.Info($"Client stopped. Received {_receivedSecurityCount} securities, {_receivedTradeCount} trades.");
    }
}
