using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("J", FixVersion.FIX50SP2)]
	public sealed partial class AllocationInstruction : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 70, Type = TagType.String, Offset = 1, Required = true)]
		public string? AllocID {get; set;}
		
		[TagDetails(Tag = 2758, Type = TagType.String, Offset = 2, Required = false)]
		public string? AllocRequestID {get; set;}
		
		[TagDetails(Tag = 71, Type = TagType.String, Offset = 3, Required = true)]
		public string? AllocTransType {get; set;}
		
		[TagDetails(Tag = 626, Type = TagType.Int, Offset = 4, Required = true)]
		public int? AllocType {get; set;}
		
		[TagDetails(Tag = 793, Type = TagType.String, Offset = 5, Required = false)]
		public string? SecondaryAllocID {get; set;}
		
		[TagDetails(Tag = 72, Type = TagType.String, Offset = 6, Required = false)]
		public string? RefAllocID {get; set;}
		
		[TagDetails(Tag = 796, Type = TagType.Int, Offset = 7, Required = false)]
		public int? AllocCancReplaceReason {get; set;}
		
		[TagDetails(Tag = 808, Type = TagType.Int, Offset = 8, Required = false)]
		public int? AllocIntermedReqType {get; set;}
		
		[TagDetails(Tag = 196, Type = TagType.String, Offset = 9, Required = false)]
		public string? AllocLinkID {get; set;}
		
		[TagDetails(Tag = 197, Type = TagType.Int, Offset = 10, Required = false)]
		public int? AllocLinkType {get; set;}
		
		[TagDetails(Tag = 1730, Type = TagType.String, Offset = 11, Required = false)]
		public string? AllocGroupID {get; set;}
		
		[TagDetails(Tag = 1728, Type = TagType.String, Offset = 12, Required = false)]
		public string? FirmGroupID {get; set;}
		
		[TagDetails(Tag = 466, Type = TagType.String, Offset = 13, Required = false)]
		public string? BookingRefID {get; set;}
		
		[TagDetails(Tag = 857, Type = TagType.Int, Offset = 14, Required = false)]
		public int? AllocNoOrdersType {get; set;}
		
		[Component(Offset = 15, Required = false)]
		public OrdAllocGrp? OrdAllocGrp {get; set;}
		
		[Component(Offset = 16, Required = false)]
		public ExecAllocGrp? ExecAllocGrp {get; set;}
		
		[TagDetails(Tag = 570, Type = TagType.Boolean, Offset = 17, Required = false)]
		public bool? PreviouslyReported {get; set;}
		
		[TagDetails(Tag = 700, Type = TagType.Boolean, Offset = 18, Required = false)]
		public bool? ReversalIndicator {get; set;}
		
		[TagDetails(Tag = 574, Type = TagType.String, Offset = 19, Required = false)]
		public string? MatchType {get; set;}
		
		[TagDetails(Tag = 54, Type = TagType.String, Offset = 20, Required = true)]
		public string? Side {get; set;}
		
		[Component(Offset = 21, Required = true)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 22, Required = false)]
		public InstrumentExtension? InstrumentExtension {get; set;}
		
		[Component(Offset = 23, Required = false)]
		public FinancingDetails? FinancingDetails {get; set;}
		
		[Component(Offset = 24, Required = false)]
		public UndInstrmtGrp? UndInstrmtGrp {get; set;}
		
		[Component(Offset = 25, Required = false)]
		public InstrmtLegGrp? InstrmtLegGrp {get; set;}
		
		[TagDetails(Tag = 53, Type = TagType.Float, Offset = 26, Required = true)]
		public double? Quantity {get; set;}
		
		[TagDetails(Tag = 854, Type = TagType.Int, Offset = 27, Required = false)]
		public int? QtyType {get; set;}
		
		[TagDetails(Tag = 30, Type = TagType.String, Offset = 28, Required = false)]
		public string? LastMkt {get; set;}
		
		[TagDetails(Tag = 229, Type = TagType.LocalDate, Offset = 29, Required = false)]
		public DateOnly? TradeOriginationDate {get; set;}
		
		[TagDetails(Tag = 336, Type = TagType.String, Offset = 30, Required = false)]
		public string? TradingSessionID {get; set;}
		
		[TagDetails(Tag = 625, Type = TagType.String, Offset = 31, Required = false)]
		public string? TradingSessionSubID {get; set;}
		
		[TagDetails(Tag = 423, Type = TagType.Int, Offset = 32, Required = false)]
		public int? PriceType {get; set;}
		
		[Component(Offset = 33, Required = false)]
		public PriceQualifierGrp? PriceQualifierGrp {get; set;}
		
		[TagDetails(Tag = 6, Type = TagType.Float, Offset = 34, Required = false)]
		public double? AvgPx {get; set;}
		
		[TagDetails(Tag = 860, Type = TagType.Float, Offset = 35, Required = false)]
		public double? AvgParPx {get; set;}
		
		[Component(Offset = 36, Required = false)]
		public SpreadOrBenchmarkCurveData? SpreadOrBenchmarkCurveData {get; set;}
		
		[TagDetails(Tag = 15, Type = TagType.String, Offset = 37, Required = false)]
		public string? Currency {get; set;}
		
		[TagDetails(Tag = 2897, Type = TagType.String, Offset = 38, Required = false)]
		public string? CurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 74, Type = TagType.Int, Offset = 39, Required = false)]
		public int? AvgPxPrecision {get; set;}
		
		[TagDetails(Tag = 2795, Type = TagType.Int, Offset = 40, Required = false)]
		public int? OffshoreIndicator {get; set;}
		
		[Component(Offset = 41, Required = false)]
		public Parties? Parties {get; set;}
		
		[TagDetails(Tag = 75, Type = TagType.LocalDate, Offset = 42, Required = true)]
		public DateOnly? TradeDate {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 43, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 63, Type = TagType.String, Offset = 44, Required = false)]
		public string? SettlType {get; set;}
		
		[TagDetails(Tag = 64, Type = TagType.LocalDate, Offset = 45, Required = false)]
		public DateOnly? SettlDate {get; set;}
		
		[TagDetails(Tag = 775, Type = TagType.Int, Offset = 46, Required = false)]
		public int? BookingType {get; set;}
		
		[TagDetails(Tag = 381, Type = TagType.Float, Offset = 47, Required = false)]
		public double? GrossTradeAmt {get; set;}
		
		[TagDetails(Tag = 238, Type = TagType.Float, Offset = 48, Required = false)]
		public double? Concession {get; set;}
		
		[TagDetails(Tag = 237, Type = TagType.Float, Offset = 49, Required = false)]
		public double? TotalTakedown {get; set;}
		
		[TagDetails(Tag = 118, Type = TagType.Float, Offset = 50, Required = false)]
		public double? NetMoney {get; set;}
		
		[TagDetails(Tag = 77, Type = TagType.String, Offset = 51, Required = false)]
		public string? PositionEffect {get; set;}
		
		[TagDetails(Tag = 754, Type = TagType.Boolean, Offset = 52, Required = false)]
		public bool? AutoAcceptIndicator {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 53, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 54, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 55, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[TagDetails(Tag = 157, Type = TagType.Int, Offset = 56, Required = false)]
		public int? NumDaysInterest {get; set;}
		
		[TagDetails(Tag = 158, Type = TagType.Float, Offset = 57, Required = false)]
		public double? AccruedInterestRate {get; set;}
		
		[TagDetails(Tag = 159, Type = TagType.Float, Offset = 58, Required = false)]
		public double? AccruedInterestAmt {get; set;}
		
		[TagDetails(Tag = 540, Type = TagType.Float, Offset = 59, Required = false)]
		public double? TotalAccruedInterestAmt {get; set;}
		
		[TagDetails(Tag = 738, Type = TagType.Float, Offset = 60, Required = false)]
		public double? InterestAtMaturity {get; set;}
		
		[TagDetails(Tag = 920, Type = TagType.Float, Offset = 61, Required = false)]
		public double? EndAccruedInterestAmt {get; set;}
		
		[TagDetails(Tag = 921, Type = TagType.Float, Offset = 62, Required = false)]
		public double? StartCash {get; set;}
		
		[TagDetails(Tag = 922, Type = TagType.Float, Offset = 63, Required = false)]
		public double? EndCash {get; set;}
		
		[TagDetails(Tag = 650, Type = TagType.Boolean, Offset = 64, Required = false)]
		public bool? LegalConfirm {get; set;}
		
		[Component(Offset = 65, Required = false)]
		public Stipulations? Stipulations {get; set;}
		
		[Component(Offset = 66, Required = false)]
		public YieldData? YieldData {get; set;}
		
		[Component(Offset = 67, Required = false)]
		public RegulatoryTradeIDGrp? RegulatoryTradeIDGrp {get; set;}
		
		[Component(Offset = 68, Required = false)]
		public PositionAmountData? PositionAmountData {get; set;}
		
		[TagDetails(Tag = 892, Type = TagType.Int, Offset = 69, Required = false)]
		public int? TotNoAllocs {get; set;}
		
		[TagDetails(Tag = 893, Type = TagType.Boolean, Offset = 70, Required = false)]
		public bool? LastFragment {get; set;}
		
		[Component(Offset = 71, Required = false)]
		public AllocGrp? AllocGrp {get; set;}
		
		[TagDetails(Tag = 819, Type = TagType.Int, Offset = 72, Required = false)]
		public int? AvgPxIndicator {get; set;}
		
		[TagDetails(Tag = 1731, Type = TagType.String, Offset = 73, Required = false)]
		public string? AvgPxGroupID {get; set;}
		
		[TagDetails(Tag = 715, Type = TagType.LocalDate, Offset = 74, Required = false)]
		public DateOnly? ClearingBusinessDate {get; set;}
		
		[TagDetails(Tag = 828, Type = TagType.Int, Offset = 75, Required = false)]
		public int? TrdType {get; set;}
		
		[TagDetails(Tag = 829, Type = TagType.Int, Offset = 76, Required = false)]
		public int? TrdSubType {get; set;}
		
		[TagDetails(Tag = 855, Type = TagType.Int, Offset = 77, Required = false)]
		public int? SecondaryTrdType {get; set;}
		
		[TagDetails(Tag = 1937, Type = TagType.Int, Offset = 78, Required = false)]
		public int? TradeContinuation {get; set;}
		
		[TagDetails(Tag = 2374, Type = TagType.String, Offset = 79, Required = false)]
		public string? TradeContinuationText {get; set;}
		
		[TagDetails(Tag = 2372, Type = TagType.Length, Offset = 80, Required = false)]
		public int? EncodedTradeContinuationTextLen {get; set;}
		
		[TagDetails(Tag = 2371, Type = TagType.RawData, Offset = 81, Required = false)]
		public byte[]? EncodedTradeContinuationText {get; set;}
		
		[TagDetails(Tag = 582, Type = TagType.Int, Offset = 82, Required = false)]
		public int? CustOrderCapacity {get; set;}
		
		[TagDetails(Tag = 578, Type = TagType.String, Offset = 83, Required = false)]
		public string? TradeInputSource {get; set;}
		
		[TagDetails(Tag = 442, Type = TagType.String, Offset = 84, Required = false)]
		public string? MultiLegReportingType {get; set;}
		
		[TagDetails(Tag = 1011, Type = TagType.String, Offset = 85, Required = false)]
		public string? MessageEventSource {get; set;}
		
		[TagDetails(Tag = 991, Type = TagType.Float, Offset = 86, Required = false)]
		public double? RndPx {get; set;}
		
		[Component(Offset = 87, Required = false)]
		public RateSource? RateSource {get; set;}
		
		[TagDetails(Tag = 1430, Type = TagType.String, Offset = 88, Required = false)]
		public string? VenueType {get; set;}
		
		[TagDetails(Tag = 2334, Type = TagType.String, Offset = 89, Required = false)]
		public string? RefRiskLimitCheckID {get; set;}
		
		[TagDetails(Tag = 2335, Type = TagType.Int, Offset = 90, Required = false)]
		public int? RefRiskLimitCheckIDType {get; set;}
		
		[TagDetails(Tag = 2343, Type = TagType.Int, Offset = 91, Required = false)]
		public int? RiskLimitCheckStatus {get; set;}
		
		[Component(Offset = 92, Required = true)]
		public StandardTrailer? StandardTrailer {get; set;}
		
		
		IStandardHeader? IFixMessage.StandardHeader => StandardHeader;
		
		IStandardTrailer? IFixMessage.StandardTrailer => StandardTrailer;
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return (!config.CheckStandardHeader || (StandardHeader is not null && ((IFixValidator)StandardHeader).IsValid(in config))) && (!config.CheckStandardTrailer || (StandardTrailer is not null && ((IFixValidator)StandardTrailer).IsValid(in config)));
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (StandardHeader is not null) ((IFixEncoder)StandardHeader).Encode(writer);
			if (AllocID is not null) writer.WriteString(70, AllocID);
			if (AllocRequestID is not null) writer.WriteString(2758, AllocRequestID);
			if (AllocTransType is not null) writer.WriteString(71, AllocTransType);
			if (AllocType is not null) writer.WriteWholeNumber(626, AllocType.Value);
			if (SecondaryAllocID is not null) writer.WriteString(793, SecondaryAllocID);
			if (RefAllocID is not null) writer.WriteString(72, RefAllocID);
			if (AllocCancReplaceReason is not null) writer.WriteWholeNumber(796, AllocCancReplaceReason.Value);
			if (AllocIntermedReqType is not null) writer.WriteWholeNumber(808, AllocIntermedReqType.Value);
			if (AllocLinkID is not null) writer.WriteString(196, AllocLinkID);
			if (AllocLinkType is not null) writer.WriteWholeNumber(197, AllocLinkType.Value);
			if (AllocGroupID is not null) writer.WriteString(1730, AllocGroupID);
			if (FirmGroupID is not null) writer.WriteString(1728, FirmGroupID);
			if (BookingRefID is not null) writer.WriteString(466, BookingRefID);
			if (AllocNoOrdersType is not null) writer.WriteWholeNumber(857, AllocNoOrdersType.Value);
			if (OrdAllocGrp is not null) ((IFixEncoder)OrdAllocGrp).Encode(writer);
			if (ExecAllocGrp is not null) ((IFixEncoder)ExecAllocGrp).Encode(writer);
			if (PreviouslyReported is not null) writer.WriteBoolean(570, PreviouslyReported.Value);
			if (ReversalIndicator is not null) writer.WriteBoolean(700, ReversalIndicator.Value);
			if (MatchType is not null) writer.WriteString(574, MatchType);
			if (Side is not null) writer.WriteString(54, Side);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (InstrumentExtension is not null) ((IFixEncoder)InstrumentExtension).Encode(writer);
			if (FinancingDetails is not null) ((IFixEncoder)FinancingDetails).Encode(writer);
			if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
			if (InstrmtLegGrp is not null) ((IFixEncoder)InstrmtLegGrp).Encode(writer);
			if (Quantity is not null) writer.WriteNumber(53, Quantity.Value);
			if (QtyType is not null) writer.WriteWholeNumber(854, QtyType.Value);
			if (LastMkt is not null) writer.WriteString(30, LastMkt);
			if (TradeOriginationDate is not null) writer.WriteLocalDateOnly(229, TradeOriginationDate.Value);
			if (TradingSessionID is not null) writer.WriteString(336, TradingSessionID);
			if (TradingSessionSubID is not null) writer.WriteString(625, TradingSessionSubID);
			if (PriceType is not null) writer.WriteWholeNumber(423, PriceType.Value);
			if (PriceQualifierGrp is not null) ((IFixEncoder)PriceQualifierGrp).Encode(writer);
			if (AvgPx is not null) writer.WriteNumber(6, AvgPx.Value);
			if (AvgParPx is not null) writer.WriteNumber(860, AvgParPx.Value);
			if (SpreadOrBenchmarkCurveData is not null) ((IFixEncoder)SpreadOrBenchmarkCurveData).Encode(writer);
			if (Currency is not null) writer.WriteString(15, Currency);
			if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
			if (AvgPxPrecision is not null) writer.WriteWholeNumber(74, AvgPxPrecision.Value);
			if (OffshoreIndicator is not null) writer.WriteWholeNumber(2795, OffshoreIndicator.Value);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (TradeDate is not null) writer.WriteLocalDateOnly(75, TradeDate.Value);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (SettlType is not null) writer.WriteString(63, SettlType);
			if (SettlDate is not null) writer.WriteLocalDateOnly(64, SettlDate.Value);
			if (BookingType is not null) writer.WriteWholeNumber(775, BookingType.Value);
			if (GrossTradeAmt is not null) writer.WriteNumber(381, GrossTradeAmt.Value);
			if (Concession is not null) writer.WriteNumber(238, Concession.Value);
			if (TotalTakedown is not null) writer.WriteNumber(237, TotalTakedown.Value);
			if (NetMoney is not null) writer.WriteNumber(118, NetMoney.Value);
			if (PositionEffect is not null) writer.WriteString(77, PositionEffect);
			if (AutoAcceptIndicator is not null) writer.WriteBoolean(754, AutoAcceptIndicator.Value);
			if (Text is not null) writer.WriteString(58, Text);
			if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
			if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
			if (NumDaysInterest is not null) writer.WriteWholeNumber(157, NumDaysInterest.Value);
			if (AccruedInterestRate is not null) writer.WriteNumber(158, AccruedInterestRate.Value);
			if (AccruedInterestAmt is not null) writer.WriteNumber(159, AccruedInterestAmt.Value);
			if (TotalAccruedInterestAmt is not null) writer.WriteNumber(540, TotalAccruedInterestAmt.Value);
			if (InterestAtMaturity is not null) writer.WriteNumber(738, InterestAtMaturity.Value);
			if (EndAccruedInterestAmt is not null) writer.WriteNumber(920, EndAccruedInterestAmt.Value);
			if (StartCash is not null) writer.WriteNumber(921, StartCash.Value);
			if (EndCash is not null) writer.WriteNumber(922, EndCash.Value);
			if (LegalConfirm is not null) writer.WriteBoolean(650, LegalConfirm.Value);
			if (Stipulations is not null) ((IFixEncoder)Stipulations).Encode(writer);
			if (YieldData is not null) ((IFixEncoder)YieldData).Encode(writer);
			if (RegulatoryTradeIDGrp is not null) ((IFixEncoder)RegulatoryTradeIDGrp).Encode(writer);
			if (PositionAmountData is not null) ((IFixEncoder)PositionAmountData).Encode(writer);
			if (TotNoAllocs is not null) writer.WriteWholeNumber(892, TotNoAllocs.Value);
			if (LastFragment is not null) writer.WriteBoolean(893, LastFragment.Value);
			if (AllocGrp is not null) ((IFixEncoder)AllocGrp).Encode(writer);
			if (AvgPxIndicator is not null) writer.WriteWholeNumber(819, AvgPxIndicator.Value);
			if (AvgPxGroupID is not null) writer.WriteString(1731, AvgPxGroupID);
			if (ClearingBusinessDate is not null) writer.WriteLocalDateOnly(715, ClearingBusinessDate.Value);
			if (TrdType is not null) writer.WriteWholeNumber(828, TrdType.Value);
			if (TrdSubType is not null) writer.WriteWholeNumber(829, TrdSubType.Value);
			if (SecondaryTrdType is not null) writer.WriteWholeNumber(855, SecondaryTrdType.Value);
			if (TradeContinuation is not null) writer.WriteWholeNumber(1937, TradeContinuation.Value);
			if (TradeContinuationText is not null) writer.WriteString(2374, TradeContinuationText);
			if (EncodedTradeContinuationTextLen is not null) writer.WriteWholeNumber(2372, EncodedTradeContinuationTextLen.Value);
			if (EncodedTradeContinuationText is not null) writer.WriteBuffer(2371, EncodedTradeContinuationText);
			if (CustOrderCapacity is not null) writer.WriteWholeNumber(582, CustOrderCapacity.Value);
			if (TradeInputSource is not null) writer.WriteString(578, TradeInputSource);
			if (MultiLegReportingType is not null) writer.WriteString(442, MultiLegReportingType);
			if (MessageEventSource is not null) writer.WriteString(1011, MessageEventSource);
			if (RndPx is not null) writer.WriteNumber(991, RndPx.Value);
			if (RateSource is not null) ((IFixEncoder)RateSource).Encode(writer);
			if (VenueType is not null) writer.WriteString(1430, VenueType);
			if (RefRiskLimitCheckID is not null) writer.WriteString(2334, RefRiskLimitCheckID);
			if (RefRiskLimitCheckIDType is not null) writer.WriteWholeNumber(2335, RefRiskLimitCheckIDType.Value);
			if (RiskLimitCheckStatus is not null) writer.WriteWholeNumber(2343, RiskLimitCheckStatus.Value);
			if (StandardTrailer is not null) ((IFixEncoder)StandardTrailer).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("StandardHeader") is IMessageView viewStandardHeader)
			{
				StandardHeader = new();
				((IFixParser)StandardHeader).Parse(viewStandardHeader);
			}
			AllocID = view.GetString(70);
			AllocRequestID = view.GetString(2758);
			AllocTransType = view.GetString(71);
			AllocType = view.GetInt32(626);
			SecondaryAllocID = view.GetString(793);
			RefAllocID = view.GetString(72);
			AllocCancReplaceReason = view.GetInt32(796);
			AllocIntermedReqType = view.GetInt32(808);
			AllocLinkID = view.GetString(196);
			AllocLinkType = view.GetInt32(197);
			AllocGroupID = view.GetString(1730);
			FirmGroupID = view.GetString(1728);
			BookingRefID = view.GetString(466);
			AllocNoOrdersType = view.GetInt32(857);
			if (view.GetView("OrdAllocGrp") is IMessageView viewOrdAllocGrp)
			{
				OrdAllocGrp = new();
				((IFixParser)OrdAllocGrp).Parse(viewOrdAllocGrp);
			}
			if (view.GetView("ExecAllocGrp") is IMessageView viewExecAllocGrp)
			{
				ExecAllocGrp = new();
				((IFixParser)ExecAllocGrp).Parse(viewExecAllocGrp);
			}
			PreviouslyReported = view.GetBool(570);
			ReversalIndicator = view.GetBool(700);
			MatchType = view.GetString(574);
			Side = view.GetString(54);
			if (view.GetView("Instrument") is IMessageView viewInstrument)
			{
				Instrument = new();
				((IFixParser)Instrument).Parse(viewInstrument);
			}
			if (view.GetView("InstrumentExtension") is IMessageView viewInstrumentExtension)
			{
				InstrumentExtension = new();
				((IFixParser)InstrumentExtension).Parse(viewInstrumentExtension);
			}
			if (view.GetView("FinancingDetails") is IMessageView viewFinancingDetails)
			{
				FinancingDetails = new();
				((IFixParser)FinancingDetails).Parse(viewFinancingDetails);
			}
			if (view.GetView("UndInstrmtGrp") is IMessageView viewUndInstrmtGrp)
			{
				UndInstrmtGrp = new();
				((IFixParser)UndInstrmtGrp).Parse(viewUndInstrmtGrp);
			}
			if (view.GetView("InstrmtLegGrp") is IMessageView viewInstrmtLegGrp)
			{
				InstrmtLegGrp = new();
				((IFixParser)InstrmtLegGrp).Parse(viewInstrmtLegGrp);
			}
			Quantity = view.GetDouble(53);
			QtyType = view.GetInt32(854);
			LastMkt = view.GetString(30);
			TradeOriginationDate = view.GetDateOnly(229);
			TradingSessionID = view.GetString(336);
			TradingSessionSubID = view.GetString(625);
			PriceType = view.GetInt32(423);
			if (view.GetView("PriceQualifierGrp") is IMessageView viewPriceQualifierGrp)
			{
				PriceQualifierGrp = new();
				((IFixParser)PriceQualifierGrp).Parse(viewPriceQualifierGrp);
			}
			AvgPx = view.GetDouble(6);
			AvgParPx = view.GetDouble(860);
			if (view.GetView("SpreadOrBenchmarkCurveData") is IMessageView viewSpreadOrBenchmarkCurveData)
			{
				SpreadOrBenchmarkCurveData = new();
				((IFixParser)SpreadOrBenchmarkCurveData).Parse(viewSpreadOrBenchmarkCurveData);
			}
			Currency = view.GetString(15);
			CurrencyCodeSource = view.GetString(2897);
			AvgPxPrecision = view.GetInt32(74);
			OffshoreIndicator = view.GetInt32(2795);
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			TradeDate = view.GetDateOnly(75);
			TransactTime = view.GetDateTime(60);
			SettlType = view.GetString(63);
			SettlDate = view.GetDateOnly(64);
			BookingType = view.GetInt32(775);
			GrossTradeAmt = view.GetDouble(381);
			Concession = view.GetDouble(238);
			TotalTakedown = view.GetDouble(237);
			NetMoney = view.GetDouble(118);
			PositionEffect = view.GetString(77);
			AutoAcceptIndicator = view.GetBool(754);
			Text = view.GetString(58);
			EncodedTextLen = view.GetInt32(354);
			EncodedText = view.GetByteArray(355);
			NumDaysInterest = view.GetInt32(157);
			AccruedInterestRate = view.GetDouble(158);
			AccruedInterestAmt = view.GetDouble(159);
			TotalAccruedInterestAmt = view.GetDouble(540);
			InterestAtMaturity = view.GetDouble(738);
			EndAccruedInterestAmt = view.GetDouble(920);
			StartCash = view.GetDouble(921);
			EndCash = view.GetDouble(922);
			LegalConfirm = view.GetBool(650);
			if (view.GetView("Stipulations") is IMessageView viewStipulations)
			{
				Stipulations = new();
				((IFixParser)Stipulations).Parse(viewStipulations);
			}
			if (view.GetView("YieldData") is IMessageView viewYieldData)
			{
				YieldData = new();
				((IFixParser)YieldData).Parse(viewYieldData);
			}
			if (view.GetView("RegulatoryTradeIDGrp") is IMessageView viewRegulatoryTradeIDGrp)
			{
				RegulatoryTradeIDGrp = new();
				((IFixParser)RegulatoryTradeIDGrp).Parse(viewRegulatoryTradeIDGrp);
			}
			if (view.GetView("PositionAmountData") is IMessageView viewPositionAmountData)
			{
				PositionAmountData = new();
				((IFixParser)PositionAmountData).Parse(viewPositionAmountData);
			}
			TotNoAllocs = view.GetInt32(892);
			LastFragment = view.GetBool(893);
			if (view.GetView("AllocGrp") is IMessageView viewAllocGrp)
			{
				AllocGrp = new();
				((IFixParser)AllocGrp).Parse(viewAllocGrp);
			}
			AvgPxIndicator = view.GetInt32(819);
			AvgPxGroupID = view.GetString(1731);
			ClearingBusinessDate = view.GetDateOnly(715);
			TrdType = view.GetInt32(828);
			TrdSubType = view.GetInt32(829);
			SecondaryTrdType = view.GetInt32(855);
			TradeContinuation = view.GetInt32(1937);
			TradeContinuationText = view.GetString(2374);
			EncodedTradeContinuationTextLen = view.GetInt32(2372);
			EncodedTradeContinuationText = view.GetByteArray(2371);
			CustOrderCapacity = view.GetInt32(582);
			TradeInputSource = view.GetString(578);
			MultiLegReportingType = view.GetString(442);
			MessageEventSource = view.GetString(1011);
			RndPx = view.GetDouble(991);
			if (view.GetView("RateSource") is IMessageView viewRateSource)
			{
				RateSource = new();
				((IFixParser)RateSource).Parse(viewRateSource);
			}
			VenueType = view.GetString(1430);
			RefRiskLimitCheckID = view.GetString(2334);
			RefRiskLimitCheckIDType = view.GetInt32(2335);
			RiskLimitCheckStatus = view.GetInt32(2343);
			if (view.GetView("StandardTrailer") is IMessageView viewStandardTrailer)
			{
				StandardTrailer = new();
				((IFixParser)StandardTrailer).Parse(viewStandardTrailer);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "StandardHeader":
				{
					value = StandardHeader;
					break;
				}
				case "AllocID":
				{
					value = AllocID;
					break;
				}
				case "AllocRequestID":
				{
					value = AllocRequestID;
					break;
				}
				case "AllocTransType":
				{
					value = AllocTransType;
					break;
				}
				case "AllocType":
				{
					value = AllocType;
					break;
				}
				case "SecondaryAllocID":
				{
					value = SecondaryAllocID;
					break;
				}
				case "RefAllocID":
				{
					value = RefAllocID;
					break;
				}
				case "AllocCancReplaceReason":
				{
					value = AllocCancReplaceReason;
					break;
				}
				case "AllocIntermedReqType":
				{
					value = AllocIntermedReqType;
					break;
				}
				case "AllocLinkID":
				{
					value = AllocLinkID;
					break;
				}
				case "AllocLinkType":
				{
					value = AllocLinkType;
					break;
				}
				case "AllocGroupID":
				{
					value = AllocGroupID;
					break;
				}
				case "FirmGroupID":
				{
					value = FirmGroupID;
					break;
				}
				case "BookingRefID":
				{
					value = BookingRefID;
					break;
				}
				case "AllocNoOrdersType":
				{
					value = AllocNoOrdersType;
					break;
				}
				case "OrdAllocGrp":
				{
					value = OrdAllocGrp;
					break;
				}
				case "ExecAllocGrp":
				{
					value = ExecAllocGrp;
					break;
				}
				case "PreviouslyReported":
				{
					value = PreviouslyReported;
					break;
				}
				case "ReversalIndicator":
				{
					value = ReversalIndicator;
					break;
				}
				case "MatchType":
				{
					value = MatchType;
					break;
				}
				case "Side":
				{
					value = Side;
					break;
				}
				case "Instrument":
				{
					value = Instrument;
					break;
				}
				case "InstrumentExtension":
				{
					value = InstrumentExtension;
					break;
				}
				case "FinancingDetails":
				{
					value = FinancingDetails;
					break;
				}
				case "UndInstrmtGrp":
				{
					value = UndInstrmtGrp;
					break;
				}
				case "InstrmtLegGrp":
				{
					value = InstrmtLegGrp;
					break;
				}
				case "Quantity":
				{
					value = Quantity;
					break;
				}
				case "QtyType":
				{
					value = QtyType;
					break;
				}
				case "LastMkt":
				{
					value = LastMkt;
					break;
				}
				case "TradeOriginationDate":
				{
					value = TradeOriginationDate;
					break;
				}
				case "TradingSessionID":
				{
					value = TradingSessionID;
					break;
				}
				case "TradingSessionSubID":
				{
					value = TradingSessionSubID;
					break;
				}
				case "PriceType":
				{
					value = PriceType;
					break;
				}
				case "PriceQualifierGrp":
				{
					value = PriceQualifierGrp;
					break;
				}
				case "AvgPx":
				{
					value = AvgPx;
					break;
				}
				case "AvgParPx":
				{
					value = AvgParPx;
					break;
				}
				case "SpreadOrBenchmarkCurveData":
				{
					value = SpreadOrBenchmarkCurveData;
					break;
				}
				case "Currency":
				{
					value = Currency;
					break;
				}
				case "CurrencyCodeSource":
				{
					value = CurrencyCodeSource;
					break;
				}
				case "AvgPxPrecision":
				{
					value = AvgPxPrecision;
					break;
				}
				case "OffshoreIndicator":
				{
					value = OffshoreIndicator;
					break;
				}
				case "Parties":
				{
					value = Parties;
					break;
				}
				case "TradeDate":
				{
					value = TradeDate;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "SettlType":
				{
					value = SettlType;
					break;
				}
				case "SettlDate":
				{
					value = SettlDate;
					break;
				}
				case "BookingType":
				{
					value = BookingType;
					break;
				}
				case "GrossTradeAmt":
				{
					value = GrossTradeAmt;
					break;
				}
				case "Concession":
				{
					value = Concession;
					break;
				}
				case "TotalTakedown":
				{
					value = TotalTakedown;
					break;
				}
				case "NetMoney":
				{
					value = NetMoney;
					break;
				}
				case "PositionEffect":
				{
					value = PositionEffect;
					break;
				}
				case "AutoAcceptIndicator":
				{
					value = AutoAcceptIndicator;
					break;
				}
				case "Text":
				{
					value = Text;
					break;
				}
				case "EncodedTextLen":
				{
					value = EncodedTextLen;
					break;
				}
				case "EncodedText":
				{
					value = EncodedText;
					break;
				}
				case "NumDaysInterest":
				{
					value = NumDaysInterest;
					break;
				}
				case "AccruedInterestRate":
				{
					value = AccruedInterestRate;
					break;
				}
				case "AccruedInterestAmt":
				{
					value = AccruedInterestAmt;
					break;
				}
				case "TotalAccruedInterestAmt":
				{
					value = TotalAccruedInterestAmt;
					break;
				}
				case "InterestAtMaturity":
				{
					value = InterestAtMaturity;
					break;
				}
				case "EndAccruedInterestAmt":
				{
					value = EndAccruedInterestAmt;
					break;
				}
				case "StartCash":
				{
					value = StartCash;
					break;
				}
				case "EndCash":
				{
					value = EndCash;
					break;
				}
				case "LegalConfirm":
				{
					value = LegalConfirm;
					break;
				}
				case "Stipulations":
				{
					value = Stipulations;
					break;
				}
				case "YieldData":
				{
					value = YieldData;
					break;
				}
				case "RegulatoryTradeIDGrp":
				{
					value = RegulatoryTradeIDGrp;
					break;
				}
				case "PositionAmountData":
				{
					value = PositionAmountData;
					break;
				}
				case "TotNoAllocs":
				{
					value = TotNoAllocs;
					break;
				}
				case "LastFragment":
				{
					value = LastFragment;
					break;
				}
				case "AllocGrp":
				{
					value = AllocGrp;
					break;
				}
				case "AvgPxIndicator":
				{
					value = AvgPxIndicator;
					break;
				}
				case "AvgPxGroupID":
				{
					value = AvgPxGroupID;
					break;
				}
				case "ClearingBusinessDate":
				{
					value = ClearingBusinessDate;
					break;
				}
				case "TrdType":
				{
					value = TrdType;
					break;
				}
				case "TrdSubType":
				{
					value = TrdSubType;
					break;
				}
				case "SecondaryTrdType":
				{
					value = SecondaryTrdType;
					break;
				}
				case "TradeContinuation":
				{
					value = TradeContinuation;
					break;
				}
				case "TradeContinuationText":
				{
					value = TradeContinuationText;
					break;
				}
				case "EncodedTradeContinuationTextLen":
				{
					value = EncodedTradeContinuationTextLen;
					break;
				}
				case "EncodedTradeContinuationText":
				{
					value = EncodedTradeContinuationText;
					break;
				}
				case "CustOrderCapacity":
				{
					value = CustOrderCapacity;
					break;
				}
				case "TradeInputSource":
				{
					value = TradeInputSource;
					break;
				}
				case "MultiLegReportingType":
				{
					value = MultiLegReportingType;
					break;
				}
				case "MessageEventSource":
				{
					value = MessageEventSource;
					break;
				}
				case "RndPx":
				{
					value = RndPx;
					break;
				}
				case "RateSource":
				{
					value = RateSource;
					break;
				}
				case "VenueType":
				{
					value = VenueType;
					break;
				}
				case "RefRiskLimitCheckID":
				{
					value = RefRiskLimitCheckID;
					break;
				}
				case "RefRiskLimitCheckIDType":
				{
					value = RefRiskLimitCheckIDType;
					break;
				}
				case "RiskLimitCheckStatus":
				{
					value = RiskLimitCheckStatus;
					break;
				}
				case "StandardTrailer":
				{
					value = StandardTrailer;
					break;
				}
				default:
				{
					return false;
				}
			}
			return true;
		}
		
		void IFixReset.Reset()
		{
			((IFixReset?)StandardHeader)?.Reset();
			AllocID = null;
			AllocRequestID = null;
			AllocTransType = null;
			AllocType = null;
			SecondaryAllocID = null;
			RefAllocID = null;
			AllocCancReplaceReason = null;
			AllocIntermedReqType = null;
			AllocLinkID = null;
			AllocLinkType = null;
			AllocGroupID = null;
			FirmGroupID = null;
			BookingRefID = null;
			AllocNoOrdersType = null;
			((IFixReset?)OrdAllocGrp)?.Reset();
			((IFixReset?)ExecAllocGrp)?.Reset();
			PreviouslyReported = null;
			ReversalIndicator = null;
			MatchType = null;
			Side = null;
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)InstrumentExtension)?.Reset();
			((IFixReset?)FinancingDetails)?.Reset();
			((IFixReset?)UndInstrmtGrp)?.Reset();
			((IFixReset?)InstrmtLegGrp)?.Reset();
			Quantity = null;
			QtyType = null;
			LastMkt = null;
			TradeOriginationDate = null;
			TradingSessionID = null;
			TradingSessionSubID = null;
			PriceType = null;
			((IFixReset?)PriceQualifierGrp)?.Reset();
			AvgPx = null;
			AvgParPx = null;
			((IFixReset?)SpreadOrBenchmarkCurveData)?.Reset();
			Currency = null;
			CurrencyCodeSource = null;
			AvgPxPrecision = null;
			OffshoreIndicator = null;
			((IFixReset?)Parties)?.Reset();
			TradeDate = null;
			TransactTime = null;
			SettlType = null;
			SettlDate = null;
			BookingType = null;
			GrossTradeAmt = null;
			Concession = null;
			TotalTakedown = null;
			NetMoney = null;
			PositionEffect = null;
			AutoAcceptIndicator = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			NumDaysInterest = null;
			AccruedInterestRate = null;
			AccruedInterestAmt = null;
			TotalAccruedInterestAmt = null;
			InterestAtMaturity = null;
			EndAccruedInterestAmt = null;
			StartCash = null;
			EndCash = null;
			LegalConfirm = null;
			((IFixReset?)Stipulations)?.Reset();
			((IFixReset?)YieldData)?.Reset();
			((IFixReset?)RegulatoryTradeIDGrp)?.Reset();
			((IFixReset?)PositionAmountData)?.Reset();
			TotNoAllocs = null;
			LastFragment = null;
			((IFixReset?)AllocGrp)?.Reset();
			AvgPxIndicator = null;
			AvgPxGroupID = null;
			ClearingBusinessDate = null;
			TrdType = null;
			TrdSubType = null;
			SecondaryTrdType = null;
			TradeContinuation = null;
			TradeContinuationText = null;
			EncodedTradeContinuationTextLen = null;
			EncodedTradeContinuationText = null;
			CustOrderCapacity = null;
			TradeInputSource = null;
			MultiLegReportingType = null;
			MessageEventSource = null;
			RndPx = null;
			((IFixReset?)RateSource)?.Reset();
			VenueType = null;
			RefRiskLimitCheckID = null;
			RefRiskLimitCheckIDType = null;
			RiskLimitCheckStatus = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
