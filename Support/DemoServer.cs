using Arrow.Threading.Tasks;
using PureFix.Buffer;
using PureFix.Transport.Ascii;
using PureFix.Transport.Recovery;
using PureFix.Transport.Session;
using PureFix.Types;
using PureFix.Types.Core;
using TradeCaptureDemo.Types.FIX50SP2TC;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Support;

internal class DemoServer : BaseApp
{
    private readonly FixMessageFactory m_msg_factory = new();
    private int _nextTradeId = 100000;
    private int _nextExecId = 600000;
    private readonly string[] _securities = ["Gold", "Silver", "Platinum", "Copper", "Steel"];

    public DemoServer(IFixConfig config, IFixLogRecovery? fixLogRecover, ILogFactory logFactory, IFixMessageFactory fixMessageFactory, IMessageParser parser, IMessageEncoder encoder, AsyncWorkQueue q, IFixClock clock)
        : base(config, fixLogRecover, logFactory, fixMessageFactory, parser, encoder, q, clock)
    {
        m_logReceivedMessages = true;
    }

    protected override async Task OnApplicationMsg(string msgType, IMessageView view)
    {
        switch (msgType)
        {
            case MsgType.SecurityDefinitionRequest:
            {
                await SecurityDefinitionRequest(view);
                break;
            }

            case MsgType.TradeCaptureReportRequest:
            {
                await TradeCaptureReportRequest(view);
                break;
            }

            default:
            {
                await Reject(msgType, view);
                break;
            }
        }
    }

    private async Task Reject(string msgType, IMessageView view)
    {
        var seqNo = view.GetInt32((int)MsgTag.MsgSeqNum);
        var reject = m_config.MessageFactory?.Reject(msgType, seqNo ?? 0, "unknown msg type.", BusinessRejectReasonValues.UnsupportedMessageType);
        if (reject != null)
        {
            await Send(MsgTypeValues.Reject, reject);
            m_logger.Info($"Rejecting unknown message type: {msgType}");
        }
    }

    private async Task TradeCaptureReportRequest(IMessageView view)
    {
        var tcr = (TradeCaptureReportRequest)m_msg_factory.ToFixMessage(view)!;
        m_logger.Info($"Received trade request: {tcr.TradeRequestID}, SubscriptionType={tcr.SubscriptionRequestType}");

        // Send ack
        var ack = new TradeCaptureReportRequestAck
        {
            TradeRequestID = tcr.TradeRequestID,
            TradeRequestType = tcr.TradeRequestType,
            TradeRequestStatus = TradeRequestStatusValues.Accepted,
            TradeRequestResult = TradeRequestResultValues.Successful
        };
        await Send(MsgTypeValues.TradeCaptureReportRequestAck, ack);

        // Send initial snapshot of trades
        await SendBatchOfTrades(5);

        // Send completed ack for the snapshot
        var completedAck = new TradeCaptureReportRequestAck
        {
            TradeRequestID = tcr.TradeRequestID,
            TradeRequestType = tcr.TradeRequestType,
            TradeRequestStatus = TradeRequestStatusValues.Completed,
            TradeRequestResult = TradeRequestResultValues.Successful
        };
        await Send(MsgTypeValues.TradeCaptureReportRequestAck, completedAck);

        // If client requested ongoing updates, start sending unsolicited trades
        if (tcr.SubscriptionRequestType == SubscriptionRequestTypeValues.SnapshotAndUpdates)
        {
            m_logger.Info("Client subscribed to updates - starting unsolicited trade timer");
            StartUnsolicitedTradeTimer();
        }
    }

    private async Task SecurityDefinitionRequest(IMessageView view)
    {
        var sdr = (SecurityDefinitionRequest)m_msg_factory.ToFixMessage(view)!;
        m_logger.Info($"Received security definition request: {sdr.SecurityReqID}, MarketID={sdr.MarketID}");

        // Send SecurityDefinitionRequest for each registered security
        var responseId = 1;
        foreach (var symbol in _securities)
        {
            var secDef = new SecurityDefinition
            {
                SecurityReqID = sdr.SecurityReqID,
                SecurityResponseID = $"sec-resp-{responseId++}",
                SecurityRequestResult = SecurityRequestResultValues.ValidRequest,
                Instrument = new Instrument
                {
                    Symbol = symbol,
                    SecurityID = symbol,
                    SecurityType = "CMDTY"  // Commodity
                },
                Currency = "USD",
                TransactTime = m_clock.Current
            };
            await Send(MsgTypeValues.SecurityDefinition, secDef);
            m_logger.Info($"Sent security definition: {symbol}");
        }
    }

    private async Task SendBatchOfTrades(int count)
    {
        for (var i = 0; i < count; i++)
        {
            var trade = MakeTrade(i);
            await Send(MsgTypeValues.TradeCaptureReport, trade);
        }
    }

    private void StartUnsolicitedTradeTimer()
    {
        if (m_parentToken == null) return;

        var timer = new TimerDispatcher.AsyncTimer(m_logger);
        var batchNumber = 1;

        _ = timer.Start(TimeSpan.FromSeconds(5), async () =>
        {
            var count = (batchNumber % 3) + 1;  // 1-3 trades per batch
            m_logger.Info($"Sending unsolicited batch #{batchNumber} ({count} trades)");
            await SendBatchOfTrades(count);
            batchNumber++;
        }, m_parentToken.Value);
    }

    private TradeCaptureReport MakeTrade(int index)
    {
        var symbol = _securities[index % _securities.Length];
        var random = new Random();

        return new TradeCaptureReport
        {
            TradeReportID = $"{_nextTradeId++}",
            TradeReportTransType = TradeReportTransTypeValues.New,
            TradeReportType = TradeReportTypeValues.Submit,
            TrdType = TrdTypeValues.RegularTrade,
            TransactTime = m_clock.Current,
            ExecID = $"{_nextExecId++}",
            PreviouslyReported = false,
            Instrument = new Instrument
            {
                SecurityID = symbol,
                Symbol = symbol
            },
            TradeDate = DateOnly.FromDateTime(m_clock.Current.Date),
            LastQty = random.Next(100, 10000),
            LastPx = Math.Round(random.NextDouble() * 1000 + 10, 2)
        };
    }

    protected override bool OnLogon(IMessageView view, string? user, string? password)
    {
        m_logger.Info($"Client logging in: {user}");
        return true;
    }

    protected override Task OnReady(IMessageView view)
    {
        m_logger.Info("Server session ready - waiting for trade requests");
        return Task.CompletedTask;
    }

    protected override void OnStopped(Exception? error)
    {
        m_logger.Info("Server stopped.");
    }
}
