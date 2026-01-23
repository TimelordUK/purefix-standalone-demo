using PureFix.Buffer;
using PureFix.Transport.Ascii;
using PureFix.Transport.Recovery;
using PureFix.Transport.Session;
using PureFix.Types;
using PureFix.Types.Core;
using TradeCaptureDemo.Infrastructure;
using TradeCaptureDemo.Types.FIX50SP2TC;

namespace TradeCaptureDemo;

/// <summary>
/// Trade Capture Client - connects to server and requests securities and trades.
/// Sends SecurityDefinitionRequest, then TradeCaptureReportRequest once securities are received.
/// </summary>
internal class TradeCaptureClient : BaseApp
{
    /// <summary>
    /// If set, disconnect the transport after this many seconds (for testing reconnection)
    /// </summary>
    public static int? DisconnectAfterSeconds { get; set; }

    private readonly FixMessageFactory m_msg_factory = new();
    private int _receivedTradeCount;
    private int _receivedSecurityCount;
    private const int ExpectedSecurityCount = 5;
    private readonly List<string> _knownSecurities = [];
    private bool _hasSentTradeRequest;
    private bool _hasScheduledDisconnect;

    public TradeCaptureClient(IFixConfig config, IFixLogRecovery? fixLogRecover, ILogFactory logFactory, IFixMessageFactory fixMessageFactory, IMessageParser parser, IMessageEncoder encoder, IFixClock clock)
        : base(config, fixLogRecover, logFactory, fixMessageFactory, parser, encoder, clock)
    {
        m_logReceivedMessages = true;
    }

    protected override async Task OnApplicationMsg(string msgType, IMessageView view)
    {
        switch (msgType)
        {
            case MsgType.SecurityDefinition:
            {
                await SecurityDefinition(view);
                break;
            }

            case MsgType.TradeCaptureReport:
            {
                TradeCaptureReport(view);
                break;
            }

            case MsgType.TradeCaptureReportRequestAck:
            {
                TradeCaptureReportRequestAck(view);
                break;
            }
        }
    }

    private void TradeCaptureReportRequestAck(IMessageView view)
    {
        var tca = (TradeCaptureReportRequestAck)m_msg_factory.ToFixMessage(view)!;
        m_logger.Info($"Trade request ack: {tca.TradeRequestID} status={tca.TradeRequestStatus}");
    }

    private void TradeCaptureReport(IMessageView view)
    {
        var tc = (TradeCaptureReport)m_msg_factory.ToFixMessage(view)!;
        _receivedTradeCount++;
        m_logger.Info($"[{_receivedTradeCount}] Received Trade: {tc.Instrument?.Symbol} {tc.LastQty} @ ${tc.LastPx}");
    }

    private async Task SecurityDefinition(IMessageView view)
    {
        var sd = (SecurityDefinition)m_msg_factory.ToFixMessage(view)!;
        var symbol = sd.Instrument?.Symbol ?? "Unknown";
        _knownSecurities.Add(symbol);
        _receivedSecurityCount++;
        m_logger.Info($"[{_receivedSecurityCount}/{ExpectedSecurityCount}] Received Security: {symbol}");

        // Once we have all securities, request trades (only once per session)
        if (_receivedSecurityCount >= ExpectedSecurityCount && !_hasSentTradeRequest)
        {
            _hasSentTradeRequest = true;
            m_logger.Info($"Received all {ExpectedSecurityCount} securities - now requesting trades");
            await SendTradeCaptureRequest();
        }
    }

    protected override bool OnLogon(IMessageView view, string? user, string? password)
    {
        m_logger.Info($"Server accepted logon for user: {user}");
        return true;
    }

    protected override async Task OnReady(IMessageView view)
    {
        // Reset all state on each new session (reconnect scenario)
        _receivedSecurityCount = 0;
        _receivedTradeCount = 0;
        _knownSecurities.Clear();
        _hasSentTradeRequest = false;

        // Schedule disconnect if configured (only once per session lifetime)
        if (DisconnectAfterSeconds.HasValue && !_hasScheduledDisconnect)
        {
            _hasScheduledDisconnect = true;
            var seconds = DisconnectAfterSeconds.Value;
            m_logger.Info($"Will disconnect transport in {seconds} seconds (testing reconnection)");
            _ = Task.Run(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(seconds));
                m_logger.Info("Triggering scheduled disconnect for reconnection test");
                Stop();
            });
        }

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
