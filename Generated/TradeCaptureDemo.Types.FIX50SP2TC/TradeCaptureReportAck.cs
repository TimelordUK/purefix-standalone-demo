using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("AR", FixVersion.FIX50SP2)]
	public sealed partial class TradeCaptureReportAck : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 571, Type = TagType.String, Offset = 1, Required = false)]
		public string? TradeReportID {get; set;}
		
		[TagDetails(Tag = 1003, Type = TagType.String, Offset = 2, Required = false)]
		public string? TradeID {get; set;}
		
		[TagDetails(Tag = 1040, Type = TagType.String, Offset = 3, Required = false)]
		public string? SecondaryTradeID {get; set;}
		
		[TagDetails(Tag = 1041, Type = TagType.String, Offset = 4, Required = false)]
		public string? FirmTradeID {get; set;}
		
		[TagDetails(Tag = 1042, Type = TagType.String, Offset = 5, Required = false)]
		public string? SecondaryFirmTradeID {get; set;}
		
		[TagDetails(Tag = 487, Type = TagType.Int, Offset = 6, Required = false)]
		public int? TradeReportTransType {get; set;}
		
		[TagDetails(Tag = 856, Type = TagType.Int, Offset = 7, Required = false)]
		public int? TradeReportType {get; set;}
		
		[TagDetails(Tag = 828, Type = TagType.Int, Offset = 8, Required = false)]
		public int? TrdType {get; set;}
		
		[TagDetails(Tag = 829, Type = TagType.Int, Offset = 9, Required = false)]
		public int? TrdSubType {get; set;}
		
		[TagDetails(Tag = 855, Type = TagType.Int, Offset = 10, Required = false)]
		public int? SecondaryTrdType {get; set;}
		
		[TagDetails(Tag = 1849, Type = TagType.Int, Offset = 11, Required = false)]
		public int? OffsetInstruction {get; set;}
		
		[TagDetails(Tag = 1123, Type = TagType.String, Offset = 12, Required = false)]
		public string? TradeHandlingInstr {get; set;}
		
		[TagDetails(Tag = 1124, Type = TagType.String, Offset = 13, Required = false)]
		public string? OrigTradeHandlingInstr {get; set;}
		
		[TagDetails(Tag = 1125, Type = TagType.LocalDate, Offset = 14, Required = false)]
		public DateOnly? OrigTradeDate {get; set;}
		
		[TagDetails(Tag = 1126, Type = TagType.String, Offset = 15, Required = false)]
		public string? OrigTradeID {get; set;}
		
		[TagDetails(Tag = 1127, Type = TagType.String, Offset = 16, Required = false)]
		public string? OrigSecondaryTradeID {get; set;}
		
		[TagDetails(Tag = 830, Type = TagType.String, Offset = 17, Required = false)]
		public string? TransferReason {get; set;}
		
		[Component(Offset = 18, Required = false)]
		public RootParties? RootParties {get; set;}
		
		[TagDetails(Tag = 150, Type = TagType.String, Offset = 19, Required = false)]
		public string? ExecType {get; set;}
		
		[TagDetails(Tag = 572, Type = TagType.String, Offset = 20, Required = false)]
		public string? TradeReportRefID {get; set;}
		
		[TagDetails(Tag = 881, Type = TagType.String, Offset = 21, Required = false)]
		public string? SecondaryTradeReportRefID {get; set;}
		
		[TagDetails(Tag = 939, Type = TagType.Int, Offset = 22, Required = false)]
		public int? TrdRptStatus {get; set;}
		
		[TagDetails(Tag = 1523, Type = TagType.Int, Offset = 23, Required = false)]
		public int? TrdAckStatus {get; set;}
		
		[TagDetails(Tag = 751, Type = TagType.Int, Offset = 24, Required = false)]
		public int? TradeReportRejectReason {get; set;}
		
		[TagDetails(Tag = 1328, Type = TagType.String, Offset = 25, Required = false)]
		public string? RejectText {get; set;}
		
		[TagDetails(Tag = 1664, Type = TagType.Length, Offset = 26, Required = false)]
		public int? EncodedRejectTextLen {get; set;}
		
		[TagDetails(Tag = 1665, Type = TagType.RawData, Offset = 27, Required = false)]
		public byte[]? EncodedRejectText {get; set;}
		
		[TagDetails(Tag = 818, Type = TagType.String, Offset = 28, Required = false)]
		public string? SecondaryTradeReportID {get; set;}
		
		[TagDetails(Tag = 263, Type = TagType.String, Offset = 29, Required = false)]
		public string? SubscriptionRequestType {get; set;}
		
		[TagDetails(Tag = 820, Type = TagType.String, Offset = 30, Required = false)]
		public string? TradeLinkID {get; set;}
		
		[TagDetails(Tag = 880, Type = TagType.String, Offset = 31, Required = false)]
		public string? TrdMatchID {get; set;}
		
		[TagDetails(Tag = 17, Type = TagType.String, Offset = 32, Required = false)]
		public string? ExecID {get; set;}
		
		[TagDetails(Tag = 527, Type = TagType.String, Offset = 33, Required = false)]
		public string? SecondaryExecID {get; set;}
		
		[TagDetails(Tag = 378, Type = TagType.Int, Offset = 34, Required = false)]
		public int? ExecRestatementReason {get; set;}
		
		[TagDetails(Tag = 570, Type = TagType.Boolean, Offset = 35, Required = false)]
		public bool? PreviouslyReported {get; set;}
		
		[TagDetails(Tag = 423, Type = TagType.Int, Offset = 36, Required = false)]
		public int? PriceType {get; set;}
		
		[Component(Offset = 37, Required = false)]
		public PriceQualifierGrp? PriceQualifierGrp {get; set;}
		
		[TagDetails(Tag = 549, Type = TagType.Int, Offset = 38, Required = false)]
		public int? CrossType {get; set;}
		
		[TagDetails(Tag = 822, Type = TagType.String, Offset = 39, Required = false)]
		public string? UnderlyingTradingSessionID {get; set;}
		
		[TagDetails(Tag = 823, Type = TagType.String, Offset = 40, Required = false)]
		public string? UnderlyingTradingSessionSubID {get; set;}
		
		[TagDetails(Tag = 716, Type = TagType.String, Offset = 41, Required = false)]
		public string? SettlSessID {get; set;}
		
		[TagDetails(Tag = 717, Type = TagType.String, Offset = 42, Required = false)]
		public string? SettlSessSubID {get; set;}
		
		[TagDetails(Tag = 854, Type = TagType.Int, Offset = 43, Required = false)]
		public int? QtyType {get; set;}
		
		[TagDetails(Tag = 32, Type = TagType.Float, Offset = 44, Required = false)]
		public double? LastQty {get; set;}
		
		[TagDetails(Tag = 31, Type = TagType.Float, Offset = 45, Required = false)]
		public double? LastPx {get; set;}
		
		[TagDetails(Tag = 1430, Type = TagType.String, Offset = 46, Required = false)]
		public string? VenueType {get; set;}
		
		[TagDetails(Tag = 1300, Type = TagType.String, Offset = 47, Required = false)]
		public string? MarketSegmentID {get; set;}
		
		[TagDetails(Tag = 1301, Type = TagType.String, Offset = 48, Required = false)]
		public string? MarketID {get; set;}
		
		[Component(Offset = 49, Required = true)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 50, Required = false)]
		public InstrumentExtension? InstrumentExtension {get; set;}
		
		[Component(Offset = 51, Required = false)]
		public FinancingDetails? FinancingDetails {get; set;}
		
		[TagDetails(Tag = 669, Type = TagType.Float, Offset = 52, Required = false)]
		public double? LastParPx {get; set;}
		
		[TagDetails(Tag = 1056, Type = TagType.Float, Offset = 53, Required = false)]
		public double? CalculatedCcyLastQty {get; set;}
		
		[TagDetails(Tag = 1071, Type = TagType.Float, Offset = 54, Required = false)]
		public double? LastSwapPoints {get; set;}
		
		[TagDetails(Tag = 2762, Type = TagType.Float, Offset = 55, Required = false)]
		public double? PriceMarkup {get; set;}
		
		[Component(Offset = 56, Required = false)]
		public AveragePriceDetail? AveragePriceDetail {get; set;}
		
		[TagDetails(Tag = 15, Type = TagType.String, Offset = 57, Required = false)]
		public string? Currency {get; set;}
		
		[TagDetails(Tag = 2897, Type = TagType.String, Offset = 58, Required = false)]
		public string? CurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 120, Type = TagType.String, Offset = 59, Required = false)]
		public string? SettlCurrency {get; set;}
		
		[TagDetails(Tag = 2899, Type = TagType.String, Offset = 60, Required = false)]
		public string? SettlCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 194, Type = TagType.Float, Offset = 61, Required = false)]
		public double? LastSpotRate {get; set;}
		
		[TagDetails(Tag = 195, Type = TagType.Float, Offset = 62, Required = false)]
		public double? LastForwardPoints {get; set;}
		
		[TagDetails(Tag = 30, Type = TagType.String, Offset = 63, Required = false)]
		public string? LastMkt {get; set;}
		
		[TagDetails(Tag = 75, Type = TagType.LocalDate, Offset = 64, Required = false)]
		public DateOnly? TradeDate {get; set;}
		
		[TagDetails(Tag = 715, Type = TagType.LocalDate, Offset = 65, Required = false)]
		public DateOnly? ClearingBusinessDate {get; set;}
		
		[TagDetails(Tag = 6, Type = TagType.Float, Offset = 66, Required = false)]
		public double? AvgPx {get; set;}
		
		[TagDetails(Tag = 1731, Type = TagType.String, Offset = 67, Required = false)]
		public string? AvgPxGroupID {get; set;}
		
		[TagDetails(Tag = 819, Type = TagType.Int, Offset = 68, Required = false)]
		public int? AvgPxIndicator {get; set;}
		
		[TagDetails(Tag = 442, Type = TagType.String, Offset = 69, Required = false)]
		public string? MultiLegReportingType {get; set;}
		
		[TagDetails(Tag = 824, Type = TagType.String, Offset = 70, Required = false)]
		public string? TradeLegRefID {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 71, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 63, Type = TagType.String, Offset = 72, Required = false)]
		public string? SettlType {get; set;}
		
		[Component(Offset = 73, Required = false)]
		public UndInstrmtGrp? UndInstrmtGrp {get; set;}
		
		[TagDetails(Tag = 573, Type = TagType.String, Offset = 74, Required = false)]
		public string? MatchStatus {get; set;}
		
		[TagDetails(Tag = 574, Type = TagType.String, Offset = 75, Required = false)]
		public string? MatchType {get; set;}
		
		[TagDetails(Tag = 797, Type = TagType.Boolean, Offset = 76, Required = false)]
		public bool? CopyMsgIndicator {get; set;}
		
		[Component(Offset = 77, Required = false)]
		public TrdRepIndicatorsGrp? TrdRepIndicatorsGrp {get; set;}
		
		[TagDetails(Tag = 852, Type = TagType.Boolean, Offset = 78, Required = false)]
		public bool? PublishTrdIndicator {get; set;}
		
		[TagDetails(Tag = 1390, Type = TagType.Int, Offset = 79, Required = false)]
		public int? TradePublishIndicator {get; set;}
		
		[TagDetails(Tag = 853, Type = TagType.Int, Offset = 80, Required = false)]
		public int? ShortSaleReason {get; set;}
		
		[Component(Offset = 81, Required = false)]
		public TrdInstrmtLegGrp? TrdInstrmtLegGrp {get; set;}
		
		[Component(Offset = 82, Required = false)]
		public TrdRegTimestamps? TrdRegTimestamps {get; set;}
		
		[TagDetails(Tag = 725, Type = TagType.Int, Offset = 83, Required = false)]
		public int? ResponseTransportType {get; set;}
		
		[TagDetails(Tag = 726, Type = TagType.String, Offset = 84, Required = false)]
		public string? ResponseDestination {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 85, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 86, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 87, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[TagDetails(Tag = 1015, Type = TagType.String, Offset = 88, Required = false)]
		public string? AsOfIndicator {get; set;}
		
		[TagDetails(Tag = 635, Type = TagType.String, Offset = 89, Required = false)]
		public string? ClearingFeeIndicator {get; set;}
		
		[Component(Offset = 90, Required = false)]
		public PositionAmountData? PositionAmountData {get; set;}
		
		[TagDetails(Tag = 994, Type = TagType.String, Offset = 91, Required = false)]
		public string? TierCode {get; set;}
		
		[TagDetails(Tag = 1011, Type = TagType.String, Offset = 92, Required = false)]
		public string? MessageEventSource {get; set;}
		
		[TagDetails(Tag = 779, Type = TagType.UtcTimestamp, Offset = 93, Required = false)]
		public DateTime? LastUpdateTime {get; set;}
		
		[TagDetails(Tag = 991, Type = TagType.Float, Offset = 94, Required = false)]
		public double? RndPx {get; set;}
		
		[Component(Offset = 95, Required = false)]
		public TradeQtyGrp? TradeQtyGrp {get; set;}
		
		[Component(Offset = 96, Required = false)]
		public TrdCapRptAckSideGrp? TrdCapRptAckSideGrp {get; set;}
		
		[TagDetails(Tag = 1135, Type = TagType.String, Offset = 97, Required = false)]
		public string? RptSys {get; set;}
		
		[TagDetails(Tag = 381, Type = TagType.Float, Offset = 98, Required = false)]
		public double? GrossTradeAmt {get; set;}
		
		[TagDetails(Tag = 64, Type = TagType.LocalDate, Offset = 99, Required = false)]
		public DateOnly? SettlDate {get; set;}
		
		[TagDetails(Tag = 1329, Type = TagType.Float, Offset = 100, Required = false)]
		public double? FeeMultiplier {get; set;}
		
		[TagDetails(Tag = 2343, Type = TagType.Int, Offset = 101, Required = false)]
		public int? RiskLimitCheckStatus {get; set;}
		
		[Component(Offset = 102, Required = true)]
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
			if (TradeReportID is not null) writer.WriteString(571, TradeReportID);
			if (TradeID is not null) writer.WriteString(1003, TradeID);
			if (SecondaryTradeID is not null) writer.WriteString(1040, SecondaryTradeID);
			if (FirmTradeID is not null) writer.WriteString(1041, FirmTradeID);
			if (SecondaryFirmTradeID is not null) writer.WriteString(1042, SecondaryFirmTradeID);
			if (TradeReportTransType is not null) writer.WriteWholeNumber(487, TradeReportTransType.Value);
			if (TradeReportType is not null) writer.WriteWholeNumber(856, TradeReportType.Value);
			if (TrdType is not null) writer.WriteWholeNumber(828, TrdType.Value);
			if (TrdSubType is not null) writer.WriteWholeNumber(829, TrdSubType.Value);
			if (SecondaryTrdType is not null) writer.WriteWholeNumber(855, SecondaryTrdType.Value);
			if (OffsetInstruction is not null) writer.WriteWholeNumber(1849, OffsetInstruction.Value);
			if (TradeHandlingInstr is not null) writer.WriteString(1123, TradeHandlingInstr);
			if (OrigTradeHandlingInstr is not null) writer.WriteString(1124, OrigTradeHandlingInstr);
			if (OrigTradeDate is not null) writer.WriteLocalDateOnly(1125, OrigTradeDate.Value);
			if (OrigTradeID is not null) writer.WriteString(1126, OrigTradeID);
			if (OrigSecondaryTradeID is not null) writer.WriteString(1127, OrigSecondaryTradeID);
			if (TransferReason is not null) writer.WriteString(830, TransferReason);
			if (RootParties is not null) ((IFixEncoder)RootParties).Encode(writer);
			if (ExecType is not null) writer.WriteString(150, ExecType);
			if (TradeReportRefID is not null) writer.WriteString(572, TradeReportRefID);
			if (SecondaryTradeReportRefID is not null) writer.WriteString(881, SecondaryTradeReportRefID);
			if (TrdRptStatus is not null) writer.WriteWholeNumber(939, TrdRptStatus.Value);
			if (TrdAckStatus is not null) writer.WriteWholeNumber(1523, TrdAckStatus.Value);
			if (TradeReportRejectReason is not null) writer.WriteWholeNumber(751, TradeReportRejectReason.Value);
			if (RejectText is not null) writer.WriteString(1328, RejectText);
			if (EncodedRejectTextLen is not null) writer.WriteWholeNumber(1664, EncodedRejectTextLen.Value);
			if (EncodedRejectText is not null) writer.WriteBuffer(1665, EncodedRejectText);
			if (SecondaryTradeReportID is not null) writer.WriteString(818, SecondaryTradeReportID);
			if (SubscriptionRequestType is not null) writer.WriteString(263, SubscriptionRequestType);
			if (TradeLinkID is not null) writer.WriteString(820, TradeLinkID);
			if (TrdMatchID is not null) writer.WriteString(880, TrdMatchID);
			if (ExecID is not null) writer.WriteString(17, ExecID);
			if (SecondaryExecID is not null) writer.WriteString(527, SecondaryExecID);
			if (ExecRestatementReason is not null) writer.WriteWholeNumber(378, ExecRestatementReason.Value);
			if (PreviouslyReported is not null) writer.WriteBoolean(570, PreviouslyReported.Value);
			if (PriceType is not null) writer.WriteWholeNumber(423, PriceType.Value);
			if (PriceQualifierGrp is not null) ((IFixEncoder)PriceQualifierGrp).Encode(writer);
			if (CrossType is not null) writer.WriteWholeNumber(549, CrossType.Value);
			if (UnderlyingTradingSessionID is not null) writer.WriteString(822, UnderlyingTradingSessionID);
			if (UnderlyingTradingSessionSubID is not null) writer.WriteString(823, UnderlyingTradingSessionSubID);
			if (SettlSessID is not null) writer.WriteString(716, SettlSessID);
			if (SettlSessSubID is not null) writer.WriteString(717, SettlSessSubID);
			if (QtyType is not null) writer.WriteWholeNumber(854, QtyType.Value);
			if (LastQty is not null) writer.WriteNumber(32, LastQty.Value);
			if (LastPx is not null) writer.WriteNumber(31, LastPx.Value);
			if (VenueType is not null) writer.WriteString(1430, VenueType);
			if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
			if (MarketID is not null) writer.WriteString(1301, MarketID);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (InstrumentExtension is not null) ((IFixEncoder)InstrumentExtension).Encode(writer);
			if (FinancingDetails is not null) ((IFixEncoder)FinancingDetails).Encode(writer);
			if (LastParPx is not null) writer.WriteNumber(669, LastParPx.Value);
			if (CalculatedCcyLastQty is not null) writer.WriteNumber(1056, CalculatedCcyLastQty.Value);
			if (LastSwapPoints is not null) writer.WriteNumber(1071, LastSwapPoints.Value);
			if (PriceMarkup is not null) writer.WriteNumber(2762, PriceMarkup.Value);
			if (AveragePriceDetail is not null) ((IFixEncoder)AveragePriceDetail).Encode(writer);
			if (Currency is not null) writer.WriteString(15, Currency);
			if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
			if (SettlCurrency is not null) writer.WriteString(120, SettlCurrency);
			if (SettlCurrencyCodeSource is not null) writer.WriteString(2899, SettlCurrencyCodeSource);
			if (LastSpotRate is not null) writer.WriteNumber(194, LastSpotRate.Value);
			if (LastForwardPoints is not null) writer.WriteNumber(195, LastForwardPoints.Value);
			if (LastMkt is not null) writer.WriteString(30, LastMkt);
			if (TradeDate is not null) writer.WriteLocalDateOnly(75, TradeDate.Value);
			if (ClearingBusinessDate is not null) writer.WriteLocalDateOnly(715, ClearingBusinessDate.Value);
			if (AvgPx is not null) writer.WriteNumber(6, AvgPx.Value);
			if (AvgPxGroupID is not null) writer.WriteString(1731, AvgPxGroupID);
			if (AvgPxIndicator is not null) writer.WriteWholeNumber(819, AvgPxIndicator.Value);
			if (MultiLegReportingType is not null) writer.WriteString(442, MultiLegReportingType);
			if (TradeLegRefID is not null) writer.WriteString(824, TradeLegRefID);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (SettlType is not null) writer.WriteString(63, SettlType);
			if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
			if (MatchStatus is not null) writer.WriteString(573, MatchStatus);
			if (MatchType is not null) writer.WriteString(574, MatchType);
			if (CopyMsgIndicator is not null) writer.WriteBoolean(797, CopyMsgIndicator.Value);
			if (TrdRepIndicatorsGrp is not null) ((IFixEncoder)TrdRepIndicatorsGrp).Encode(writer);
			if (PublishTrdIndicator is not null) writer.WriteBoolean(852, PublishTrdIndicator.Value);
			if (TradePublishIndicator is not null) writer.WriteWholeNumber(1390, TradePublishIndicator.Value);
			if (ShortSaleReason is not null) writer.WriteWholeNumber(853, ShortSaleReason.Value);
			if (TrdInstrmtLegGrp is not null) ((IFixEncoder)TrdInstrmtLegGrp).Encode(writer);
			if (TrdRegTimestamps is not null) ((IFixEncoder)TrdRegTimestamps).Encode(writer);
			if (ResponseTransportType is not null) writer.WriteWholeNumber(725, ResponseTransportType.Value);
			if (ResponseDestination is not null) writer.WriteString(726, ResponseDestination);
			if (Text is not null) writer.WriteString(58, Text);
			if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
			if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
			if (AsOfIndicator is not null) writer.WriteString(1015, AsOfIndicator);
			if (ClearingFeeIndicator is not null) writer.WriteString(635, ClearingFeeIndicator);
			if (PositionAmountData is not null) ((IFixEncoder)PositionAmountData).Encode(writer);
			if (TierCode is not null) writer.WriteString(994, TierCode);
			if (MessageEventSource is not null) writer.WriteString(1011, MessageEventSource);
			if (LastUpdateTime is not null) writer.WriteUtcTimeStamp(779, LastUpdateTime.Value);
			if (RndPx is not null) writer.WriteNumber(991, RndPx.Value);
			if (TradeQtyGrp is not null) ((IFixEncoder)TradeQtyGrp).Encode(writer);
			if (TrdCapRptAckSideGrp is not null) ((IFixEncoder)TrdCapRptAckSideGrp).Encode(writer);
			if (RptSys is not null) writer.WriteString(1135, RptSys);
			if (GrossTradeAmt is not null) writer.WriteNumber(381, GrossTradeAmt.Value);
			if (SettlDate is not null) writer.WriteLocalDateOnly(64, SettlDate.Value);
			if (FeeMultiplier is not null) writer.WriteNumber(1329, FeeMultiplier.Value);
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
			TradeReportID = view.GetString(571);
			TradeID = view.GetString(1003);
			SecondaryTradeID = view.GetString(1040);
			FirmTradeID = view.GetString(1041);
			SecondaryFirmTradeID = view.GetString(1042);
			TradeReportTransType = view.GetInt32(487);
			TradeReportType = view.GetInt32(856);
			TrdType = view.GetInt32(828);
			TrdSubType = view.GetInt32(829);
			SecondaryTrdType = view.GetInt32(855);
			OffsetInstruction = view.GetInt32(1849);
			TradeHandlingInstr = view.GetString(1123);
			OrigTradeHandlingInstr = view.GetString(1124);
			OrigTradeDate = view.GetDateOnly(1125);
			OrigTradeID = view.GetString(1126);
			OrigSecondaryTradeID = view.GetString(1127);
			TransferReason = view.GetString(830);
			if (view.GetView("RootParties") is IMessageView viewRootParties)
			{
				RootParties = new();
				((IFixParser)RootParties).Parse(viewRootParties);
			}
			ExecType = view.GetString(150);
			TradeReportRefID = view.GetString(572);
			SecondaryTradeReportRefID = view.GetString(881);
			TrdRptStatus = view.GetInt32(939);
			TrdAckStatus = view.GetInt32(1523);
			TradeReportRejectReason = view.GetInt32(751);
			RejectText = view.GetString(1328);
			EncodedRejectTextLen = view.GetInt32(1664);
			EncodedRejectText = view.GetByteArray(1665);
			SecondaryTradeReportID = view.GetString(818);
			SubscriptionRequestType = view.GetString(263);
			TradeLinkID = view.GetString(820);
			TrdMatchID = view.GetString(880);
			ExecID = view.GetString(17);
			SecondaryExecID = view.GetString(527);
			ExecRestatementReason = view.GetInt32(378);
			PreviouslyReported = view.GetBool(570);
			PriceType = view.GetInt32(423);
			if (view.GetView("PriceQualifierGrp") is IMessageView viewPriceQualifierGrp)
			{
				PriceQualifierGrp = new();
				((IFixParser)PriceQualifierGrp).Parse(viewPriceQualifierGrp);
			}
			CrossType = view.GetInt32(549);
			UnderlyingTradingSessionID = view.GetString(822);
			UnderlyingTradingSessionSubID = view.GetString(823);
			SettlSessID = view.GetString(716);
			SettlSessSubID = view.GetString(717);
			QtyType = view.GetInt32(854);
			LastQty = view.GetDouble(32);
			LastPx = view.GetDouble(31);
			VenueType = view.GetString(1430);
			MarketSegmentID = view.GetString(1300);
			MarketID = view.GetString(1301);
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
			LastParPx = view.GetDouble(669);
			CalculatedCcyLastQty = view.GetDouble(1056);
			LastSwapPoints = view.GetDouble(1071);
			PriceMarkup = view.GetDouble(2762);
			if (view.GetView("AveragePriceDetail") is IMessageView viewAveragePriceDetail)
			{
				AveragePriceDetail = new();
				((IFixParser)AveragePriceDetail).Parse(viewAveragePriceDetail);
			}
			Currency = view.GetString(15);
			CurrencyCodeSource = view.GetString(2897);
			SettlCurrency = view.GetString(120);
			SettlCurrencyCodeSource = view.GetString(2899);
			LastSpotRate = view.GetDouble(194);
			LastForwardPoints = view.GetDouble(195);
			LastMkt = view.GetString(30);
			TradeDate = view.GetDateOnly(75);
			ClearingBusinessDate = view.GetDateOnly(715);
			AvgPx = view.GetDouble(6);
			AvgPxGroupID = view.GetString(1731);
			AvgPxIndicator = view.GetInt32(819);
			MultiLegReportingType = view.GetString(442);
			TradeLegRefID = view.GetString(824);
			TransactTime = view.GetDateTime(60);
			SettlType = view.GetString(63);
			if (view.GetView("UndInstrmtGrp") is IMessageView viewUndInstrmtGrp)
			{
				UndInstrmtGrp = new();
				((IFixParser)UndInstrmtGrp).Parse(viewUndInstrmtGrp);
			}
			MatchStatus = view.GetString(573);
			MatchType = view.GetString(574);
			CopyMsgIndicator = view.GetBool(797);
			if (view.GetView("TrdRepIndicatorsGrp") is IMessageView viewTrdRepIndicatorsGrp)
			{
				TrdRepIndicatorsGrp = new();
				((IFixParser)TrdRepIndicatorsGrp).Parse(viewTrdRepIndicatorsGrp);
			}
			PublishTrdIndicator = view.GetBool(852);
			TradePublishIndicator = view.GetInt32(1390);
			ShortSaleReason = view.GetInt32(853);
			if (view.GetView("TrdInstrmtLegGrp") is IMessageView viewTrdInstrmtLegGrp)
			{
				TrdInstrmtLegGrp = new();
				((IFixParser)TrdInstrmtLegGrp).Parse(viewTrdInstrmtLegGrp);
			}
			if (view.GetView("TrdRegTimestamps") is IMessageView viewTrdRegTimestamps)
			{
				TrdRegTimestamps = new();
				((IFixParser)TrdRegTimestamps).Parse(viewTrdRegTimestamps);
			}
			ResponseTransportType = view.GetInt32(725);
			ResponseDestination = view.GetString(726);
			Text = view.GetString(58);
			EncodedTextLen = view.GetInt32(354);
			EncodedText = view.GetByteArray(355);
			AsOfIndicator = view.GetString(1015);
			ClearingFeeIndicator = view.GetString(635);
			if (view.GetView("PositionAmountData") is IMessageView viewPositionAmountData)
			{
				PositionAmountData = new();
				((IFixParser)PositionAmountData).Parse(viewPositionAmountData);
			}
			TierCode = view.GetString(994);
			MessageEventSource = view.GetString(1011);
			LastUpdateTime = view.GetDateTime(779);
			RndPx = view.GetDouble(991);
			if (view.GetView("TradeQtyGrp") is IMessageView viewTradeQtyGrp)
			{
				TradeQtyGrp = new();
				((IFixParser)TradeQtyGrp).Parse(viewTradeQtyGrp);
			}
			if (view.GetView("TrdCapRptAckSideGrp") is IMessageView viewTrdCapRptAckSideGrp)
			{
				TrdCapRptAckSideGrp = new();
				((IFixParser)TrdCapRptAckSideGrp).Parse(viewTrdCapRptAckSideGrp);
			}
			RptSys = view.GetString(1135);
			GrossTradeAmt = view.GetDouble(381);
			SettlDate = view.GetDateOnly(64);
			FeeMultiplier = view.GetDouble(1329);
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
				case "TradeReportID":
				{
					value = TradeReportID;
					break;
				}
				case "TradeID":
				{
					value = TradeID;
					break;
				}
				case "SecondaryTradeID":
				{
					value = SecondaryTradeID;
					break;
				}
				case "FirmTradeID":
				{
					value = FirmTradeID;
					break;
				}
				case "SecondaryFirmTradeID":
				{
					value = SecondaryFirmTradeID;
					break;
				}
				case "TradeReportTransType":
				{
					value = TradeReportTransType;
					break;
				}
				case "TradeReportType":
				{
					value = TradeReportType;
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
				case "OffsetInstruction":
				{
					value = OffsetInstruction;
					break;
				}
				case "TradeHandlingInstr":
				{
					value = TradeHandlingInstr;
					break;
				}
				case "OrigTradeHandlingInstr":
				{
					value = OrigTradeHandlingInstr;
					break;
				}
				case "OrigTradeDate":
				{
					value = OrigTradeDate;
					break;
				}
				case "OrigTradeID":
				{
					value = OrigTradeID;
					break;
				}
				case "OrigSecondaryTradeID":
				{
					value = OrigSecondaryTradeID;
					break;
				}
				case "TransferReason":
				{
					value = TransferReason;
					break;
				}
				case "RootParties":
				{
					value = RootParties;
					break;
				}
				case "ExecType":
				{
					value = ExecType;
					break;
				}
				case "TradeReportRefID":
				{
					value = TradeReportRefID;
					break;
				}
				case "SecondaryTradeReportRefID":
				{
					value = SecondaryTradeReportRefID;
					break;
				}
				case "TrdRptStatus":
				{
					value = TrdRptStatus;
					break;
				}
				case "TrdAckStatus":
				{
					value = TrdAckStatus;
					break;
				}
				case "TradeReportRejectReason":
				{
					value = TradeReportRejectReason;
					break;
				}
				case "RejectText":
				{
					value = RejectText;
					break;
				}
				case "EncodedRejectTextLen":
				{
					value = EncodedRejectTextLen;
					break;
				}
				case "EncodedRejectText":
				{
					value = EncodedRejectText;
					break;
				}
				case "SecondaryTradeReportID":
				{
					value = SecondaryTradeReportID;
					break;
				}
				case "SubscriptionRequestType":
				{
					value = SubscriptionRequestType;
					break;
				}
				case "TradeLinkID":
				{
					value = TradeLinkID;
					break;
				}
				case "TrdMatchID":
				{
					value = TrdMatchID;
					break;
				}
				case "ExecID":
				{
					value = ExecID;
					break;
				}
				case "SecondaryExecID":
				{
					value = SecondaryExecID;
					break;
				}
				case "ExecRestatementReason":
				{
					value = ExecRestatementReason;
					break;
				}
				case "PreviouslyReported":
				{
					value = PreviouslyReported;
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
				case "CrossType":
				{
					value = CrossType;
					break;
				}
				case "UnderlyingTradingSessionID":
				{
					value = UnderlyingTradingSessionID;
					break;
				}
				case "UnderlyingTradingSessionSubID":
				{
					value = UnderlyingTradingSessionSubID;
					break;
				}
				case "SettlSessID":
				{
					value = SettlSessID;
					break;
				}
				case "SettlSessSubID":
				{
					value = SettlSessSubID;
					break;
				}
				case "QtyType":
				{
					value = QtyType;
					break;
				}
				case "LastQty":
				{
					value = LastQty;
					break;
				}
				case "LastPx":
				{
					value = LastPx;
					break;
				}
				case "VenueType":
				{
					value = VenueType;
					break;
				}
				case "MarketSegmentID":
				{
					value = MarketSegmentID;
					break;
				}
				case "MarketID":
				{
					value = MarketID;
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
				case "LastParPx":
				{
					value = LastParPx;
					break;
				}
				case "CalculatedCcyLastQty":
				{
					value = CalculatedCcyLastQty;
					break;
				}
				case "LastSwapPoints":
				{
					value = LastSwapPoints;
					break;
				}
				case "PriceMarkup":
				{
					value = PriceMarkup;
					break;
				}
				case "AveragePriceDetail":
				{
					value = AveragePriceDetail;
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
				case "SettlCurrency":
				{
					value = SettlCurrency;
					break;
				}
				case "SettlCurrencyCodeSource":
				{
					value = SettlCurrencyCodeSource;
					break;
				}
				case "LastSpotRate":
				{
					value = LastSpotRate;
					break;
				}
				case "LastForwardPoints":
				{
					value = LastForwardPoints;
					break;
				}
				case "LastMkt":
				{
					value = LastMkt;
					break;
				}
				case "TradeDate":
				{
					value = TradeDate;
					break;
				}
				case "ClearingBusinessDate":
				{
					value = ClearingBusinessDate;
					break;
				}
				case "AvgPx":
				{
					value = AvgPx;
					break;
				}
				case "AvgPxGroupID":
				{
					value = AvgPxGroupID;
					break;
				}
				case "AvgPxIndicator":
				{
					value = AvgPxIndicator;
					break;
				}
				case "MultiLegReportingType":
				{
					value = MultiLegReportingType;
					break;
				}
				case "TradeLegRefID":
				{
					value = TradeLegRefID;
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
				case "UndInstrmtGrp":
				{
					value = UndInstrmtGrp;
					break;
				}
				case "MatchStatus":
				{
					value = MatchStatus;
					break;
				}
				case "MatchType":
				{
					value = MatchType;
					break;
				}
				case "CopyMsgIndicator":
				{
					value = CopyMsgIndicator;
					break;
				}
				case "TrdRepIndicatorsGrp":
				{
					value = TrdRepIndicatorsGrp;
					break;
				}
				case "PublishTrdIndicator":
				{
					value = PublishTrdIndicator;
					break;
				}
				case "TradePublishIndicator":
				{
					value = TradePublishIndicator;
					break;
				}
				case "ShortSaleReason":
				{
					value = ShortSaleReason;
					break;
				}
				case "TrdInstrmtLegGrp":
				{
					value = TrdInstrmtLegGrp;
					break;
				}
				case "TrdRegTimestamps":
				{
					value = TrdRegTimestamps;
					break;
				}
				case "ResponseTransportType":
				{
					value = ResponseTransportType;
					break;
				}
				case "ResponseDestination":
				{
					value = ResponseDestination;
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
				case "AsOfIndicator":
				{
					value = AsOfIndicator;
					break;
				}
				case "ClearingFeeIndicator":
				{
					value = ClearingFeeIndicator;
					break;
				}
				case "PositionAmountData":
				{
					value = PositionAmountData;
					break;
				}
				case "TierCode":
				{
					value = TierCode;
					break;
				}
				case "MessageEventSource":
				{
					value = MessageEventSource;
					break;
				}
				case "LastUpdateTime":
				{
					value = LastUpdateTime;
					break;
				}
				case "RndPx":
				{
					value = RndPx;
					break;
				}
				case "TradeQtyGrp":
				{
					value = TradeQtyGrp;
					break;
				}
				case "TrdCapRptAckSideGrp":
				{
					value = TrdCapRptAckSideGrp;
					break;
				}
				case "RptSys":
				{
					value = RptSys;
					break;
				}
				case "GrossTradeAmt":
				{
					value = GrossTradeAmt;
					break;
				}
				case "SettlDate":
				{
					value = SettlDate;
					break;
				}
				case "FeeMultiplier":
				{
					value = FeeMultiplier;
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
			TradeReportID = null;
			TradeID = null;
			SecondaryTradeID = null;
			FirmTradeID = null;
			SecondaryFirmTradeID = null;
			TradeReportTransType = null;
			TradeReportType = null;
			TrdType = null;
			TrdSubType = null;
			SecondaryTrdType = null;
			OffsetInstruction = null;
			TradeHandlingInstr = null;
			OrigTradeHandlingInstr = null;
			OrigTradeDate = null;
			OrigTradeID = null;
			OrigSecondaryTradeID = null;
			TransferReason = null;
			((IFixReset?)RootParties)?.Reset();
			ExecType = null;
			TradeReportRefID = null;
			SecondaryTradeReportRefID = null;
			TrdRptStatus = null;
			TrdAckStatus = null;
			TradeReportRejectReason = null;
			RejectText = null;
			EncodedRejectTextLen = null;
			EncodedRejectText = null;
			SecondaryTradeReportID = null;
			SubscriptionRequestType = null;
			TradeLinkID = null;
			TrdMatchID = null;
			ExecID = null;
			SecondaryExecID = null;
			ExecRestatementReason = null;
			PreviouslyReported = null;
			PriceType = null;
			((IFixReset?)PriceQualifierGrp)?.Reset();
			CrossType = null;
			UnderlyingTradingSessionID = null;
			UnderlyingTradingSessionSubID = null;
			SettlSessID = null;
			SettlSessSubID = null;
			QtyType = null;
			LastQty = null;
			LastPx = null;
			VenueType = null;
			MarketSegmentID = null;
			MarketID = null;
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)InstrumentExtension)?.Reset();
			((IFixReset?)FinancingDetails)?.Reset();
			LastParPx = null;
			CalculatedCcyLastQty = null;
			LastSwapPoints = null;
			PriceMarkup = null;
			((IFixReset?)AveragePriceDetail)?.Reset();
			Currency = null;
			CurrencyCodeSource = null;
			SettlCurrency = null;
			SettlCurrencyCodeSource = null;
			LastSpotRate = null;
			LastForwardPoints = null;
			LastMkt = null;
			TradeDate = null;
			ClearingBusinessDate = null;
			AvgPx = null;
			AvgPxGroupID = null;
			AvgPxIndicator = null;
			MultiLegReportingType = null;
			TradeLegRefID = null;
			TransactTime = null;
			SettlType = null;
			((IFixReset?)UndInstrmtGrp)?.Reset();
			MatchStatus = null;
			MatchType = null;
			CopyMsgIndicator = null;
			((IFixReset?)TrdRepIndicatorsGrp)?.Reset();
			PublishTrdIndicator = null;
			TradePublishIndicator = null;
			ShortSaleReason = null;
			((IFixReset?)TrdInstrmtLegGrp)?.Reset();
			((IFixReset?)TrdRegTimestamps)?.Reset();
			ResponseTransportType = null;
			ResponseDestination = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			AsOfIndicator = null;
			ClearingFeeIndicator = null;
			((IFixReset?)PositionAmountData)?.Reset();
			TierCode = null;
			MessageEventSource = null;
			LastUpdateTime = null;
			RndPx = null;
			((IFixReset?)TradeQtyGrp)?.Reset();
			((IFixReset?)TrdCapRptAckSideGrp)?.Reset();
			RptSys = null;
			GrossTradeAmt = null;
			SettlDate = null;
			FeeMultiplier = null;
			RiskLimitCheckStatus = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
