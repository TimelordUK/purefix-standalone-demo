using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("AC", FixVersion.FIX50SP2)]
	public sealed partial class MultilegOrderCancelReplace : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 37, Type = TagType.String, Offset = 1, Required = false)]
		public string? OrderID {get; set;}
		
		[TagDetails(Tag = 2422, Type = TagType.Int, Offset = 2, Required = false)]
		public int? OrderRequestID {get; set;}
		
		[TagDetails(Tag = 41, Type = TagType.String, Offset = 3, Required = false)]
		public string? OrigClOrdID {get; set;}
		
		[TagDetails(Tag = 11, Type = TagType.String, Offset = 4, Required = false)]
		public string? ClOrdID {get; set;}
		
		[TagDetails(Tag = 526, Type = TagType.String, Offset = 5, Required = false)]
		public string? SecondaryClOrdID {get; set;}
		
		[TagDetails(Tag = 583, Type = TagType.String, Offset = 6, Required = false)]
		public string? ClOrdLinkID {get; set;}
		
		[TagDetails(Tag = 586, Type = TagType.UtcTimestamp, Offset = 7, Required = false)]
		public DateTime? OrigOrdModTime {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public Parties? Parties {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public TargetParties? TargetParties {get; set;}
		
		[TagDetails(Tag = 229, Type = TagType.LocalDate, Offset = 10, Required = false)]
		public DateOnly? TradeOriginationDate {get; set;}
		
		[TagDetails(Tag = 75, Type = TagType.LocalDate, Offset = 11, Required = false)]
		public DateOnly? TradeDate {get; set;}
		
		[TagDetails(Tag = 1, Type = TagType.String, Offset = 12, Required = false)]
		public string? Account {get; set;}
		
		[TagDetails(Tag = 660, Type = TagType.Int, Offset = 13, Required = false)]
		public int? AcctIDSource {get; set;}
		
		[TagDetails(Tag = 581, Type = TagType.Int, Offset = 14, Required = false)]
		public int? AccountType {get; set;}
		
		[TagDetails(Tag = 589, Type = TagType.String, Offset = 15, Required = false)]
		public string? DayBookingInst {get; set;}
		
		[TagDetails(Tag = 590, Type = TagType.String, Offset = 16, Required = false)]
		public string? BookingUnit {get; set;}
		
		[TagDetails(Tag = 591, Type = TagType.String, Offset = 17, Required = false)]
		public string? PreallocMethod {get; set;}
		
		[TagDetails(Tag = 70, Type = TagType.String, Offset = 18, Required = false)]
		public string? AllocID {get; set;}
		
		[Component(Offset = 19, Required = false)]
		public PreAllocMlegGrp? PreAllocMlegGrp {get; set;}
		
		[TagDetails(Tag = 63, Type = TagType.String, Offset = 20, Required = false)]
		public string? SettlType {get; set;}
		
		[TagDetails(Tag = 64, Type = TagType.LocalDate, Offset = 21, Required = false)]
		public DateOnly? SettlDate {get; set;}
		
		[TagDetails(Tag = 544, Type = TagType.String, Offset = 22, Required = false)]
		public string? CashMargin {get; set;}
		
		[TagDetails(Tag = 635, Type = TagType.String, Offset = 23, Required = false)]
		public string? ClearingFeeIndicator {get; set;}
		
		[TagDetails(Tag = 21, Type = TagType.String, Offset = 24, Required = false)]
		public string? HandlInst {get; set;}
		
		[TagDetails(Tag = 18, Type = TagType.String, Offset = 25, Required = false)]
		public string? ExecInst {get; set;}
		
		[TagDetails(Tag = 1805, Type = TagType.Int, Offset = 26, Required = false)]
		public int? AuctionInstruction {get; set;}
		
		[TagDetails(Tag = 110, Type = TagType.Float, Offset = 27, Required = false)]
		public double? MinQty {get; set;}
		
		[TagDetails(Tag = 1822, Type = TagType.Int, Offset = 28, Required = false)]
		public int? MinQtyMethod {get; set;}
		
		[TagDetails(Tag = 1089, Type = TagType.Float, Offset = 29, Required = false)]
		public double? MatchIncrement {get; set;}
		
		[TagDetails(Tag = 1090, Type = TagType.Int, Offset = 30, Required = false)]
		public int? MaxPriceLevels {get; set;}
		
		[TagDetails(Tag = 2676, Type = TagType.Float, Offset = 31, Required = false)]
		public double? MaximumPriceDeviation {get; set;}
		
		[Component(Offset = 32, Required = false)]
		public ValueChecksGrp? ValueChecksGrp {get; set;}
		
		[Component(Offset = 33, Required = false)]
		public MatchingInstructions? MatchingInstructions {get; set;}
		
		[TagDetails(Tag = 2362, Type = TagType.String, Offset = 34, Required = false)]
		public string? SelfMatchPreventionID {get; set;}
		
		[TagDetails(Tag = 2964, Type = TagType.Int, Offset = 35, Required = false)]
		public int? SelfMatchPreventionInstruction {get; set;}
		
		[Component(Offset = 36, Required = false)]
		public DisplayInstruction? DisplayInstruction {get; set;}
		
		[Component(Offset = 37, Required = false)]
		public DisclosureInstructionGrp? DisclosureInstructionGrp {get; set;}
		
		[TagDetails(Tag = 111, Type = TagType.Float, Offset = 38, Required = false)]
		public double? MaxFloor {get; set;}
		
		[TagDetails(Tag = 1300, Type = TagType.String, Offset = 39, Required = false)]
		public string? MarketSegmentID {get; set;}
		
		[TagDetails(Tag = 100, Type = TagType.String, Offset = 40, Required = false)]
		public string? ExDestination {get; set;}
		
		[TagDetails(Tag = 1133, Type = TagType.String, Offset = 41, Required = false)]
		public string? ExDestinationIDSource {get; set;}
		
		[TagDetails(Tag = 2704, Type = TagType.Int, Offset = 42, Required = false)]
		public int? ExDestinationType {get; set;}
		
		[Component(Offset = 43, Required = false)]
		public TrdgSesGrp? TrdgSesGrp {get; set;}
		
		[TagDetails(Tag = 81, Type = TagType.String, Offset = 44, Required = false)]
		public string? ProcessCode {get; set;}
		
		[TagDetails(Tag = 54, Type = TagType.String, Offset = 45, Required = true)]
		public string? Side {get; set;}
		
		[TagDetails(Tag = 2102, Type = TagType.Boolean, Offset = 46, Required = false)]
		public bool? ShortMarkingExemptIndicator {get; set;}
		
		[Component(Offset = 47, Required = false)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 48, Required = false)]
		public UndInstrmtGrp? UndInstrmtGrp {get; set;}
		
		[TagDetails(Tag = 140, Type = TagType.Float, Offset = 49, Required = false)]
		public double? PrevClosePx {get; set;}
		
		[TagDetails(Tag = 1069, Type = TagType.Float, Offset = 50, Required = false)]
		public double? SwapPoints {get; set;}
		
		[Component(Offset = 51, Required = false)]
		public LegOrdGrp? LegOrdGrp {get; set;}
		
		[TagDetails(Tag = 114, Type = TagType.Boolean, Offset = 52, Required = false)]
		public bool? LocateReqd {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 53, Required = true)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 854, Type = TagType.Int, Offset = 54, Required = false)]
		public int? QtyType {get; set;}
		
		[Component(Offset = 55, Required = false)]
		public OrderQtyData? OrderQtyData {get; set;}
		
		[TagDetails(Tag = 40, Type = TagType.String, Offset = 56, Required = true)]
		public string? OrdType {get; set;}
		
		[TagDetails(Tag = 1377, Type = TagType.Int, Offset = 57, Required = false)]
		public int? MultilegModel {get; set;}
		
		[TagDetails(Tag = 1378, Type = TagType.Int, Offset = 58, Required = false)]
		public int? MultilegPriceMethod {get; set;}
		
		[TagDetails(Tag = 423, Type = TagType.Int, Offset = 59, Required = false)]
		public int? PriceType {get; set;}
		
		[TagDetails(Tag = 44, Type = TagType.Float, Offset = 60, Required = false)]
		public double? Price {get; set;}
		
		[TagDetails(Tag = 1092, Type = TagType.String, Offset = 61, Required = false)]
		public string? PriceProtectionScope {get; set;}
		
		[TagDetails(Tag = 99, Type = TagType.Float, Offset = 62, Required = false)]
		public double? StopPx {get; set;}
		
		[Component(Offset = 63, Required = false)]
		public TriggeringInstruction? TriggeringInstruction {get; set;}
		
		[TagDetails(Tag = 15, Type = TagType.String, Offset = 64, Required = false)]
		public string? Currency {get; set;}
		
		[TagDetails(Tag = 2897, Type = TagType.String, Offset = 65, Required = false)]
		public string? CurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 376, Type = TagType.String, Offset = 66, Required = false)]
		public string? ComplianceID {get; set;}
		
		[TagDetails(Tag = 2404, Type = TagType.String, Offset = 67, Required = false)]
		public string? ComplianceText {get; set;}
		
		[TagDetails(Tag = 2351, Type = TagType.Length, Offset = 68, Required = false)]
		public int? EncodedComplianceTextLen {get; set;}
		
		[TagDetails(Tag = 2352, Type = TagType.RawData, Offset = 69, Required = false)]
		public byte[]? EncodedComplianceText {get; set;}
		
		[TagDetails(Tag = 377, Type = TagType.Boolean, Offset = 70, Required = false)]
		public bool? SolicitedFlag {get; set;}
		
		[TagDetails(Tag = 23, Type = TagType.String, Offset = 71, Required = false)]
		public string? IOIID {get; set;}
		
		[TagDetails(Tag = 117, Type = TagType.String, Offset = 72, Required = false)]
		public string? QuoteID {get; set;}
		
		[TagDetails(Tag = 59, Type = TagType.String, Offset = 73, Required = false)]
		public string? TimeInForce {get; set;}
		
		[TagDetails(Tag = 168, Type = TagType.UtcTimestamp, Offset = 74, Required = false)]
		public DateTime? EffectiveTime {get; set;}
		
		[TagDetails(Tag = 432, Type = TagType.LocalDate, Offset = 75, Required = false)]
		public DateOnly? ExpireDate {get; set;}
		
		[TagDetails(Tag = 126, Type = TagType.UtcTimestamp, Offset = 76, Required = false)]
		public DateTime? ExpireTime {get; set;}
		
		[TagDetails(Tag = 427, Type = TagType.Int, Offset = 77, Required = false)]
		public int? GTBookingInst {get; set;}
		
		[TagDetails(Tag = 1629, Type = TagType.Int, Offset = 78, Required = false)]
		public int? ExposureDuration {get; set;}
		
		[TagDetails(Tag = 1916, Type = TagType.Int, Offset = 79, Required = false)]
		public int? ExposureDurationUnit {get; set;}
		
		[Component(Offset = 80, Required = false)]
		public CommissionData? CommissionData {get; set;}
		
		[Component(Offset = 81, Required = false)]
		public CommissionDataGrp? CommissionDataGrp {get; set;}
		
		[TagDetails(Tag = 528, Type = TagType.String, Offset = 82, Required = false)]
		public string? OrderCapacity {get; set;}
		
		[TagDetails(Tag = 529, Type = TagType.String, Offset = 83, Required = false)]
		public string? OrderRestrictions {get; set;}
		
		[TagDetails(Tag = 1815, Type = TagType.Int, Offset = 84, Required = false)]
		public int? TradingCapacity {get; set;}
		
		[TagDetails(Tag = 1091, Type = TagType.Boolean, Offset = 85, Required = false)]
		public bool? PreTradeAnonymity {get; set;}
		
		[TagDetails(Tag = 1390, Type = TagType.Int, Offset = 86, Required = false)]
		public int? TradePublishIndicator {get; set;}
		
		[TagDetails(Tag = 582, Type = TagType.Int, Offset = 87, Required = false)]
		public int? CustOrderCapacity {get; set;}
		
		[TagDetails(Tag = 1724, Type = TagType.Int, Offset = 88, Required = false)]
		public int? OrderOrigination {get; set;}
		
		[Component(Offset = 89, Required = false)]
		public OrderAttributeGrp? OrderAttributeGrp {get; set;}
		
		[TagDetails(Tag = 121, Type = TagType.Boolean, Offset = 90, Required = false)]
		public bool? ForexReq {get; set;}
		
		[TagDetails(Tag = 120, Type = TagType.String, Offset = 91, Required = false)]
		public string? SettlCurrency {get; set;}
		
		[TagDetails(Tag = 2899, Type = TagType.String, Offset = 92, Required = false)]
		public string? SettlCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 775, Type = TagType.Int, Offset = 93, Required = false)]
		public int? BookingType {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 94, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 95, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 96, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[TagDetails(Tag = 1816, Type = TagType.Int, Offset = 97, Required = false)]
		public int? ClearingAccountType {get; set;}
		
		[TagDetails(Tag = 77, Type = TagType.String, Offset = 98, Required = false)]
		public string? PositionEffect {get; set;}
		
		[TagDetails(Tag = 203, Type = TagType.Int, Offset = 99, Required = false)]
		public int? CoveredOrUncovered {get; set;}
		
		[TagDetails(Tag = 210, Type = TagType.Float, Offset = 100, Required = false)]
		public double? MaxShow {get; set;}
		
		[Component(Offset = 101, Required = false)]
		public PegInstructions? PegInstructions {get; set;}
		
		[Component(Offset = 102, Required = false)]
		public DiscretionInstructions? DiscretionInstructions {get; set;}
		
		[TagDetails(Tag = 847, Type = TagType.Int, Offset = 103, Required = false)]
		public int? TargetStrategy {get; set;}
		
		[Component(Offset = 104, Required = false)]
		public StrategyParametersGrp? StrategyParametersGrp {get; set;}
		
		[TagDetails(Tag = 848, Type = TagType.String, Offset = 105, Required = false)]
		public string? TargetStrategyParameters {get; set;}
		
		[TagDetails(Tag = 1190, Type = TagType.Float, Offset = 106, Required = false)]
		public double? RiskFreeRate {get; set;}
		
		[TagDetails(Tag = 849, Type = TagType.Float, Offset = 107, Required = false)]
		public double? ParticipationRate {get; set;}
		
		[TagDetails(Tag = 480, Type = TagType.String, Offset = 108, Required = false)]
		public string? CancellationRights {get; set;}
		
		[TagDetails(Tag = 481, Type = TagType.String, Offset = 109, Required = false)]
		public string? MoneyLaunderingStatus {get; set;}
		
		[TagDetails(Tag = 513, Type = TagType.String, Offset = 110, Required = false)]
		public string? RegistID {get; set;}
		
		[TagDetails(Tag = 494, Type = TagType.String, Offset = 111, Required = false)]
		public string? Designation {get; set;}
		
		[TagDetails(Tag = 522, Type = TagType.Int, Offset = 112, Required = false)]
		public int? OwnerType {get; set;}
		
		[TagDetails(Tag = 2679, Type = TagType.Int, Offset = 113, Required = false)]
		public int? OrderOwnershipIndicator {get; set;}
		
		[TagDetails(Tag = 563, Type = TagType.Int, Offset = 114, Required = false)]
		public int? MultiLegRptTypeReq {get; set;}
		
		[TagDetails(Tag = 1685, Type = TagType.Int, Offset = 115, Required = false)]
		public int? ThrottleInst {get; set;}
		
		[TagDetails(Tag = 1803, Type = TagType.Int, Offset = 116, Required = false)]
		public int? AuctionType {get; set;}
		
		[TagDetails(Tag = 1804, Type = TagType.Float, Offset = 117, Required = false)]
		public double? AuctionAllocationPct {get; set;}
		
		[TagDetails(Tag = 1819, Type = TagType.Float, Offset = 118, Required = false)]
		public double? RelatedHighPrice {get; set;}
		
		[TagDetails(Tag = 1820, Type = TagType.Float, Offset = 119, Required = false)]
		public double? RelatedLowPrice {get; set;}
		
		[TagDetails(Tag = 1821, Type = TagType.Int, Offset = 120, Required = false)]
		public int? RelatedPriceSource {get; set;}
		
		[Component(Offset = 121, Required = true)]
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
			if (OrderID is not null) writer.WriteString(37, OrderID);
			if (OrderRequestID is not null) writer.WriteWholeNumber(2422, OrderRequestID.Value);
			if (OrigClOrdID is not null) writer.WriteString(41, OrigClOrdID);
			if (ClOrdID is not null) writer.WriteString(11, ClOrdID);
			if (SecondaryClOrdID is not null) writer.WriteString(526, SecondaryClOrdID);
			if (ClOrdLinkID is not null) writer.WriteString(583, ClOrdLinkID);
			if (OrigOrdModTime is not null) writer.WriteUtcTimeStamp(586, OrigOrdModTime.Value);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (TargetParties is not null) ((IFixEncoder)TargetParties).Encode(writer);
			if (TradeOriginationDate is not null) writer.WriteLocalDateOnly(229, TradeOriginationDate.Value);
			if (TradeDate is not null) writer.WriteLocalDateOnly(75, TradeDate.Value);
			if (Account is not null) writer.WriteString(1, Account);
			if (AcctIDSource is not null) writer.WriteWholeNumber(660, AcctIDSource.Value);
			if (AccountType is not null) writer.WriteWholeNumber(581, AccountType.Value);
			if (DayBookingInst is not null) writer.WriteString(589, DayBookingInst);
			if (BookingUnit is not null) writer.WriteString(590, BookingUnit);
			if (PreallocMethod is not null) writer.WriteString(591, PreallocMethod);
			if (AllocID is not null) writer.WriteString(70, AllocID);
			if (PreAllocMlegGrp is not null) ((IFixEncoder)PreAllocMlegGrp).Encode(writer);
			if (SettlType is not null) writer.WriteString(63, SettlType);
			if (SettlDate is not null) writer.WriteLocalDateOnly(64, SettlDate.Value);
			if (CashMargin is not null) writer.WriteString(544, CashMargin);
			if (ClearingFeeIndicator is not null) writer.WriteString(635, ClearingFeeIndicator);
			if (HandlInst is not null) writer.WriteString(21, HandlInst);
			if (ExecInst is not null) writer.WriteString(18, ExecInst);
			if (AuctionInstruction is not null) writer.WriteWholeNumber(1805, AuctionInstruction.Value);
			if (MinQty is not null) writer.WriteNumber(110, MinQty.Value);
			if (MinQtyMethod is not null) writer.WriteWholeNumber(1822, MinQtyMethod.Value);
			if (MatchIncrement is not null) writer.WriteNumber(1089, MatchIncrement.Value);
			if (MaxPriceLevels is not null) writer.WriteWholeNumber(1090, MaxPriceLevels.Value);
			if (MaximumPriceDeviation is not null) writer.WriteNumber(2676, MaximumPriceDeviation.Value);
			if (ValueChecksGrp is not null) ((IFixEncoder)ValueChecksGrp).Encode(writer);
			if (MatchingInstructions is not null) ((IFixEncoder)MatchingInstructions).Encode(writer);
			if (SelfMatchPreventionID is not null) writer.WriteString(2362, SelfMatchPreventionID);
			if (SelfMatchPreventionInstruction is not null) writer.WriteWholeNumber(2964, SelfMatchPreventionInstruction.Value);
			if (DisplayInstruction is not null) ((IFixEncoder)DisplayInstruction).Encode(writer);
			if (DisclosureInstructionGrp is not null) ((IFixEncoder)DisclosureInstructionGrp).Encode(writer);
			if (MaxFloor is not null) writer.WriteNumber(111, MaxFloor.Value);
			if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
			if (ExDestination is not null) writer.WriteString(100, ExDestination);
			if (ExDestinationIDSource is not null) writer.WriteString(1133, ExDestinationIDSource);
			if (ExDestinationType is not null) writer.WriteWholeNumber(2704, ExDestinationType.Value);
			if (TrdgSesGrp is not null) ((IFixEncoder)TrdgSesGrp).Encode(writer);
			if (ProcessCode is not null) writer.WriteString(81, ProcessCode);
			if (Side is not null) writer.WriteString(54, Side);
			if (ShortMarkingExemptIndicator is not null) writer.WriteBoolean(2102, ShortMarkingExemptIndicator.Value);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
			if (PrevClosePx is not null) writer.WriteNumber(140, PrevClosePx.Value);
			if (SwapPoints is not null) writer.WriteNumber(1069, SwapPoints.Value);
			if (LegOrdGrp is not null) ((IFixEncoder)LegOrdGrp).Encode(writer);
			if (LocateReqd is not null) writer.WriteBoolean(114, LocateReqd.Value);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (QtyType is not null) writer.WriteWholeNumber(854, QtyType.Value);
			if (OrderQtyData is not null) ((IFixEncoder)OrderQtyData).Encode(writer);
			if (OrdType is not null) writer.WriteString(40, OrdType);
			if (MultilegModel is not null) writer.WriteWholeNumber(1377, MultilegModel.Value);
			if (MultilegPriceMethod is not null) writer.WriteWholeNumber(1378, MultilegPriceMethod.Value);
			if (PriceType is not null) writer.WriteWholeNumber(423, PriceType.Value);
			if (Price is not null) writer.WriteNumber(44, Price.Value);
			if (PriceProtectionScope is not null) writer.WriteString(1092, PriceProtectionScope);
			if (StopPx is not null) writer.WriteNumber(99, StopPx.Value);
			if (TriggeringInstruction is not null) ((IFixEncoder)TriggeringInstruction).Encode(writer);
			if (Currency is not null) writer.WriteString(15, Currency);
			if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
			if (ComplianceID is not null) writer.WriteString(376, ComplianceID);
			if (ComplianceText is not null) writer.WriteString(2404, ComplianceText);
			if (EncodedComplianceTextLen is not null) writer.WriteWholeNumber(2351, EncodedComplianceTextLen.Value);
			if (EncodedComplianceText is not null) writer.WriteBuffer(2352, EncodedComplianceText);
			if (SolicitedFlag is not null) writer.WriteBoolean(377, SolicitedFlag.Value);
			if (IOIID is not null) writer.WriteString(23, IOIID);
			if (QuoteID is not null) writer.WriteString(117, QuoteID);
			if (TimeInForce is not null) writer.WriteString(59, TimeInForce);
			if (EffectiveTime is not null) writer.WriteUtcTimeStamp(168, EffectiveTime.Value);
			if (ExpireDate is not null) writer.WriteLocalDateOnly(432, ExpireDate.Value);
			if (ExpireTime is not null) writer.WriteUtcTimeStamp(126, ExpireTime.Value);
			if (GTBookingInst is not null) writer.WriteWholeNumber(427, GTBookingInst.Value);
			if (ExposureDuration is not null) writer.WriteWholeNumber(1629, ExposureDuration.Value);
			if (ExposureDurationUnit is not null) writer.WriteWholeNumber(1916, ExposureDurationUnit.Value);
			if (CommissionData is not null) ((IFixEncoder)CommissionData).Encode(writer);
			if (CommissionDataGrp is not null) ((IFixEncoder)CommissionDataGrp).Encode(writer);
			if (OrderCapacity is not null) writer.WriteString(528, OrderCapacity);
			if (OrderRestrictions is not null) writer.WriteString(529, OrderRestrictions);
			if (TradingCapacity is not null) writer.WriteWholeNumber(1815, TradingCapacity.Value);
			if (PreTradeAnonymity is not null) writer.WriteBoolean(1091, PreTradeAnonymity.Value);
			if (TradePublishIndicator is not null) writer.WriteWholeNumber(1390, TradePublishIndicator.Value);
			if (CustOrderCapacity is not null) writer.WriteWholeNumber(582, CustOrderCapacity.Value);
			if (OrderOrigination is not null) writer.WriteWholeNumber(1724, OrderOrigination.Value);
			if (OrderAttributeGrp is not null) ((IFixEncoder)OrderAttributeGrp).Encode(writer);
			if (ForexReq is not null) writer.WriteBoolean(121, ForexReq.Value);
			if (SettlCurrency is not null) writer.WriteString(120, SettlCurrency);
			if (SettlCurrencyCodeSource is not null) writer.WriteString(2899, SettlCurrencyCodeSource);
			if (BookingType is not null) writer.WriteWholeNumber(775, BookingType.Value);
			if (Text is not null) writer.WriteString(58, Text);
			if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
			if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
			if (ClearingAccountType is not null) writer.WriteWholeNumber(1816, ClearingAccountType.Value);
			if (PositionEffect is not null) writer.WriteString(77, PositionEffect);
			if (CoveredOrUncovered is not null) writer.WriteWholeNumber(203, CoveredOrUncovered.Value);
			if (MaxShow is not null) writer.WriteNumber(210, MaxShow.Value);
			if (PegInstructions is not null) ((IFixEncoder)PegInstructions).Encode(writer);
			if (DiscretionInstructions is not null) ((IFixEncoder)DiscretionInstructions).Encode(writer);
			if (TargetStrategy is not null) writer.WriteWholeNumber(847, TargetStrategy.Value);
			if (StrategyParametersGrp is not null) ((IFixEncoder)StrategyParametersGrp).Encode(writer);
			if (TargetStrategyParameters is not null) writer.WriteString(848, TargetStrategyParameters);
			if (RiskFreeRate is not null) writer.WriteNumber(1190, RiskFreeRate.Value);
			if (ParticipationRate is not null) writer.WriteNumber(849, ParticipationRate.Value);
			if (CancellationRights is not null) writer.WriteString(480, CancellationRights);
			if (MoneyLaunderingStatus is not null) writer.WriteString(481, MoneyLaunderingStatus);
			if (RegistID is not null) writer.WriteString(513, RegistID);
			if (Designation is not null) writer.WriteString(494, Designation);
			if (OwnerType is not null) writer.WriteWholeNumber(522, OwnerType.Value);
			if (OrderOwnershipIndicator is not null) writer.WriteWholeNumber(2679, OrderOwnershipIndicator.Value);
			if (MultiLegRptTypeReq is not null) writer.WriteWholeNumber(563, MultiLegRptTypeReq.Value);
			if (ThrottleInst is not null) writer.WriteWholeNumber(1685, ThrottleInst.Value);
			if (AuctionType is not null) writer.WriteWholeNumber(1803, AuctionType.Value);
			if (AuctionAllocationPct is not null) writer.WriteNumber(1804, AuctionAllocationPct.Value);
			if (RelatedHighPrice is not null) writer.WriteNumber(1819, RelatedHighPrice.Value);
			if (RelatedLowPrice is not null) writer.WriteNumber(1820, RelatedLowPrice.Value);
			if (RelatedPriceSource is not null) writer.WriteWholeNumber(1821, RelatedPriceSource.Value);
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
			OrderID = view.GetString(37);
			OrderRequestID = view.GetInt32(2422);
			OrigClOrdID = view.GetString(41);
			ClOrdID = view.GetString(11);
			SecondaryClOrdID = view.GetString(526);
			ClOrdLinkID = view.GetString(583);
			OrigOrdModTime = view.GetDateTime(586);
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			if (view.GetView("TargetParties") is IMessageView viewTargetParties)
			{
				TargetParties = new();
				((IFixParser)TargetParties).Parse(viewTargetParties);
			}
			TradeOriginationDate = view.GetDateOnly(229);
			TradeDate = view.GetDateOnly(75);
			Account = view.GetString(1);
			AcctIDSource = view.GetInt32(660);
			AccountType = view.GetInt32(581);
			DayBookingInst = view.GetString(589);
			BookingUnit = view.GetString(590);
			PreallocMethod = view.GetString(591);
			AllocID = view.GetString(70);
			if (view.GetView("PreAllocMlegGrp") is IMessageView viewPreAllocMlegGrp)
			{
				PreAllocMlegGrp = new();
				((IFixParser)PreAllocMlegGrp).Parse(viewPreAllocMlegGrp);
			}
			SettlType = view.GetString(63);
			SettlDate = view.GetDateOnly(64);
			CashMargin = view.GetString(544);
			ClearingFeeIndicator = view.GetString(635);
			HandlInst = view.GetString(21);
			ExecInst = view.GetString(18);
			AuctionInstruction = view.GetInt32(1805);
			MinQty = view.GetDouble(110);
			MinQtyMethod = view.GetInt32(1822);
			MatchIncrement = view.GetDouble(1089);
			MaxPriceLevels = view.GetInt32(1090);
			MaximumPriceDeviation = view.GetDouble(2676);
			if (view.GetView("ValueChecksGrp") is IMessageView viewValueChecksGrp)
			{
				ValueChecksGrp = new();
				((IFixParser)ValueChecksGrp).Parse(viewValueChecksGrp);
			}
			if (view.GetView("MatchingInstructions") is IMessageView viewMatchingInstructions)
			{
				MatchingInstructions = new();
				((IFixParser)MatchingInstructions).Parse(viewMatchingInstructions);
			}
			SelfMatchPreventionID = view.GetString(2362);
			SelfMatchPreventionInstruction = view.GetInt32(2964);
			if (view.GetView("DisplayInstruction") is IMessageView viewDisplayInstruction)
			{
				DisplayInstruction = new();
				((IFixParser)DisplayInstruction).Parse(viewDisplayInstruction);
			}
			if (view.GetView("DisclosureInstructionGrp") is IMessageView viewDisclosureInstructionGrp)
			{
				DisclosureInstructionGrp = new();
				((IFixParser)DisclosureInstructionGrp).Parse(viewDisclosureInstructionGrp);
			}
			MaxFloor = view.GetDouble(111);
			MarketSegmentID = view.GetString(1300);
			ExDestination = view.GetString(100);
			ExDestinationIDSource = view.GetString(1133);
			ExDestinationType = view.GetInt32(2704);
			if (view.GetView("TrdgSesGrp") is IMessageView viewTrdgSesGrp)
			{
				TrdgSesGrp = new();
				((IFixParser)TrdgSesGrp).Parse(viewTrdgSesGrp);
			}
			ProcessCode = view.GetString(81);
			Side = view.GetString(54);
			ShortMarkingExemptIndicator = view.GetBool(2102);
			if (view.GetView("Instrument") is IMessageView viewInstrument)
			{
				Instrument = new();
				((IFixParser)Instrument).Parse(viewInstrument);
			}
			if (view.GetView("UndInstrmtGrp") is IMessageView viewUndInstrmtGrp)
			{
				UndInstrmtGrp = new();
				((IFixParser)UndInstrmtGrp).Parse(viewUndInstrmtGrp);
			}
			PrevClosePx = view.GetDouble(140);
			SwapPoints = view.GetDouble(1069);
			if (view.GetView("LegOrdGrp") is IMessageView viewLegOrdGrp)
			{
				LegOrdGrp = new();
				((IFixParser)LegOrdGrp).Parse(viewLegOrdGrp);
			}
			LocateReqd = view.GetBool(114);
			TransactTime = view.GetDateTime(60);
			QtyType = view.GetInt32(854);
			if (view.GetView("OrderQtyData") is IMessageView viewOrderQtyData)
			{
				OrderQtyData = new();
				((IFixParser)OrderQtyData).Parse(viewOrderQtyData);
			}
			OrdType = view.GetString(40);
			MultilegModel = view.GetInt32(1377);
			MultilegPriceMethod = view.GetInt32(1378);
			PriceType = view.GetInt32(423);
			Price = view.GetDouble(44);
			PriceProtectionScope = view.GetString(1092);
			StopPx = view.GetDouble(99);
			if (view.GetView("TriggeringInstruction") is IMessageView viewTriggeringInstruction)
			{
				TriggeringInstruction = new();
				((IFixParser)TriggeringInstruction).Parse(viewTriggeringInstruction);
			}
			Currency = view.GetString(15);
			CurrencyCodeSource = view.GetString(2897);
			ComplianceID = view.GetString(376);
			ComplianceText = view.GetString(2404);
			EncodedComplianceTextLen = view.GetInt32(2351);
			EncodedComplianceText = view.GetByteArray(2352);
			SolicitedFlag = view.GetBool(377);
			IOIID = view.GetString(23);
			QuoteID = view.GetString(117);
			TimeInForce = view.GetString(59);
			EffectiveTime = view.GetDateTime(168);
			ExpireDate = view.GetDateOnly(432);
			ExpireTime = view.GetDateTime(126);
			GTBookingInst = view.GetInt32(427);
			ExposureDuration = view.GetInt32(1629);
			ExposureDurationUnit = view.GetInt32(1916);
			if (view.GetView("CommissionData") is IMessageView viewCommissionData)
			{
				CommissionData = new();
				((IFixParser)CommissionData).Parse(viewCommissionData);
			}
			if (view.GetView("CommissionDataGrp") is IMessageView viewCommissionDataGrp)
			{
				CommissionDataGrp = new();
				((IFixParser)CommissionDataGrp).Parse(viewCommissionDataGrp);
			}
			OrderCapacity = view.GetString(528);
			OrderRestrictions = view.GetString(529);
			TradingCapacity = view.GetInt32(1815);
			PreTradeAnonymity = view.GetBool(1091);
			TradePublishIndicator = view.GetInt32(1390);
			CustOrderCapacity = view.GetInt32(582);
			OrderOrigination = view.GetInt32(1724);
			if (view.GetView("OrderAttributeGrp") is IMessageView viewOrderAttributeGrp)
			{
				OrderAttributeGrp = new();
				((IFixParser)OrderAttributeGrp).Parse(viewOrderAttributeGrp);
			}
			ForexReq = view.GetBool(121);
			SettlCurrency = view.GetString(120);
			SettlCurrencyCodeSource = view.GetString(2899);
			BookingType = view.GetInt32(775);
			Text = view.GetString(58);
			EncodedTextLen = view.GetInt32(354);
			EncodedText = view.GetByteArray(355);
			ClearingAccountType = view.GetInt32(1816);
			PositionEffect = view.GetString(77);
			CoveredOrUncovered = view.GetInt32(203);
			MaxShow = view.GetDouble(210);
			if (view.GetView("PegInstructions") is IMessageView viewPegInstructions)
			{
				PegInstructions = new();
				((IFixParser)PegInstructions).Parse(viewPegInstructions);
			}
			if (view.GetView("DiscretionInstructions") is IMessageView viewDiscretionInstructions)
			{
				DiscretionInstructions = new();
				((IFixParser)DiscretionInstructions).Parse(viewDiscretionInstructions);
			}
			TargetStrategy = view.GetInt32(847);
			if (view.GetView("StrategyParametersGrp") is IMessageView viewStrategyParametersGrp)
			{
				StrategyParametersGrp = new();
				((IFixParser)StrategyParametersGrp).Parse(viewStrategyParametersGrp);
			}
			TargetStrategyParameters = view.GetString(848);
			RiskFreeRate = view.GetDouble(1190);
			ParticipationRate = view.GetDouble(849);
			CancellationRights = view.GetString(480);
			MoneyLaunderingStatus = view.GetString(481);
			RegistID = view.GetString(513);
			Designation = view.GetString(494);
			OwnerType = view.GetInt32(522);
			OrderOwnershipIndicator = view.GetInt32(2679);
			MultiLegRptTypeReq = view.GetInt32(563);
			ThrottleInst = view.GetInt32(1685);
			AuctionType = view.GetInt32(1803);
			AuctionAllocationPct = view.GetDouble(1804);
			RelatedHighPrice = view.GetDouble(1819);
			RelatedLowPrice = view.GetDouble(1820);
			RelatedPriceSource = view.GetInt32(1821);
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
				case "OrderID":
				{
					value = OrderID;
					break;
				}
				case "OrderRequestID":
				{
					value = OrderRequestID;
					break;
				}
				case "OrigClOrdID":
				{
					value = OrigClOrdID;
					break;
				}
				case "ClOrdID":
				{
					value = ClOrdID;
					break;
				}
				case "SecondaryClOrdID":
				{
					value = SecondaryClOrdID;
					break;
				}
				case "ClOrdLinkID":
				{
					value = ClOrdLinkID;
					break;
				}
				case "OrigOrdModTime":
				{
					value = OrigOrdModTime;
					break;
				}
				case "Parties":
				{
					value = Parties;
					break;
				}
				case "TargetParties":
				{
					value = TargetParties;
					break;
				}
				case "TradeOriginationDate":
				{
					value = TradeOriginationDate;
					break;
				}
				case "TradeDate":
				{
					value = TradeDate;
					break;
				}
				case "Account":
				{
					value = Account;
					break;
				}
				case "AcctIDSource":
				{
					value = AcctIDSource;
					break;
				}
				case "AccountType":
				{
					value = AccountType;
					break;
				}
				case "DayBookingInst":
				{
					value = DayBookingInst;
					break;
				}
				case "BookingUnit":
				{
					value = BookingUnit;
					break;
				}
				case "PreallocMethod":
				{
					value = PreallocMethod;
					break;
				}
				case "AllocID":
				{
					value = AllocID;
					break;
				}
				case "PreAllocMlegGrp":
				{
					value = PreAllocMlegGrp;
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
				case "CashMargin":
				{
					value = CashMargin;
					break;
				}
				case "ClearingFeeIndicator":
				{
					value = ClearingFeeIndicator;
					break;
				}
				case "HandlInst":
				{
					value = HandlInst;
					break;
				}
				case "ExecInst":
				{
					value = ExecInst;
					break;
				}
				case "AuctionInstruction":
				{
					value = AuctionInstruction;
					break;
				}
				case "MinQty":
				{
					value = MinQty;
					break;
				}
				case "MinQtyMethod":
				{
					value = MinQtyMethod;
					break;
				}
				case "MatchIncrement":
				{
					value = MatchIncrement;
					break;
				}
				case "MaxPriceLevels":
				{
					value = MaxPriceLevels;
					break;
				}
				case "MaximumPriceDeviation":
				{
					value = MaximumPriceDeviation;
					break;
				}
				case "ValueChecksGrp":
				{
					value = ValueChecksGrp;
					break;
				}
				case "MatchingInstructions":
				{
					value = MatchingInstructions;
					break;
				}
				case "SelfMatchPreventionID":
				{
					value = SelfMatchPreventionID;
					break;
				}
				case "SelfMatchPreventionInstruction":
				{
					value = SelfMatchPreventionInstruction;
					break;
				}
				case "DisplayInstruction":
				{
					value = DisplayInstruction;
					break;
				}
				case "DisclosureInstructionGrp":
				{
					value = DisclosureInstructionGrp;
					break;
				}
				case "MaxFloor":
				{
					value = MaxFloor;
					break;
				}
				case "MarketSegmentID":
				{
					value = MarketSegmentID;
					break;
				}
				case "ExDestination":
				{
					value = ExDestination;
					break;
				}
				case "ExDestinationIDSource":
				{
					value = ExDestinationIDSource;
					break;
				}
				case "ExDestinationType":
				{
					value = ExDestinationType;
					break;
				}
				case "TrdgSesGrp":
				{
					value = TrdgSesGrp;
					break;
				}
				case "ProcessCode":
				{
					value = ProcessCode;
					break;
				}
				case "Side":
				{
					value = Side;
					break;
				}
				case "ShortMarkingExemptIndicator":
				{
					value = ShortMarkingExemptIndicator;
					break;
				}
				case "Instrument":
				{
					value = Instrument;
					break;
				}
				case "UndInstrmtGrp":
				{
					value = UndInstrmtGrp;
					break;
				}
				case "PrevClosePx":
				{
					value = PrevClosePx;
					break;
				}
				case "SwapPoints":
				{
					value = SwapPoints;
					break;
				}
				case "LegOrdGrp":
				{
					value = LegOrdGrp;
					break;
				}
				case "LocateReqd":
				{
					value = LocateReqd;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "QtyType":
				{
					value = QtyType;
					break;
				}
				case "OrderQtyData":
				{
					value = OrderQtyData;
					break;
				}
				case "OrdType":
				{
					value = OrdType;
					break;
				}
				case "MultilegModel":
				{
					value = MultilegModel;
					break;
				}
				case "MultilegPriceMethod":
				{
					value = MultilegPriceMethod;
					break;
				}
				case "PriceType":
				{
					value = PriceType;
					break;
				}
				case "Price":
				{
					value = Price;
					break;
				}
				case "PriceProtectionScope":
				{
					value = PriceProtectionScope;
					break;
				}
				case "StopPx":
				{
					value = StopPx;
					break;
				}
				case "TriggeringInstruction":
				{
					value = TriggeringInstruction;
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
				case "ComplianceID":
				{
					value = ComplianceID;
					break;
				}
				case "ComplianceText":
				{
					value = ComplianceText;
					break;
				}
				case "EncodedComplianceTextLen":
				{
					value = EncodedComplianceTextLen;
					break;
				}
				case "EncodedComplianceText":
				{
					value = EncodedComplianceText;
					break;
				}
				case "SolicitedFlag":
				{
					value = SolicitedFlag;
					break;
				}
				case "IOIID":
				{
					value = IOIID;
					break;
				}
				case "QuoteID":
				{
					value = QuoteID;
					break;
				}
				case "TimeInForce":
				{
					value = TimeInForce;
					break;
				}
				case "EffectiveTime":
				{
					value = EffectiveTime;
					break;
				}
				case "ExpireDate":
				{
					value = ExpireDate;
					break;
				}
				case "ExpireTime":
				{
					value = ExpireTime;
					break;
				}
				case "GTBookingInst":
				{
					value = GTBookingInst;
					break;
				}
				case "ExposureDuration":
				{
					value = ExposureDuration;
					break;
				}
				case "ExposureDurationUnit":
				{
					value = ExposureDurationUnit;
					break;
				}
				case "CommissionData":
				{
					value = CommissionData;
					break;
				}
				case "CommissionDataGrp":
				{
					value = CommissionDataGrp;
					break;
				}
				case "OrderCapacity":
				{
					value = OrderCapacity;
					break;
				}
				case "OrderRestrictions":
				{
					value = OrderRestrictions;
					break;
				}
				case "TradingCapacity":
				{
					value = TradingCapacity;
					break;
				}
				case "PreTradeAnonymity":
				{
					value = PreTradeAnonymity;
					break;
				}
				case "TradePublishIndicator":
				{
					value = TradePublishIndicator;
					break;
				}
				case "CustOrderCapacity":
				{
					value = CustOrderCapacity;
					break;
				}
				case "OrderOrigination":
				{
					value = OrderOrigination;
					break;
				}
				case "OrderAttributeGrp":
				{
					value = OrderAttributeGrp;
					break;
				}
				case "ForexReq":
				{
					value = ForexReq;
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
				case "BookingType":
				{
					value = BookingType;
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
				case "ClearingAccountType":
				{
					value = ClearingAccountType;
					break;
				}
				case "PositionEffect":
				{
					value = PositionEffect;
					break;
				}
				case "CoveredOrUncovered":
				{
					value = CoveredOrUncovered;
					break;
				}
				case "MaxShow":
				{
					value = MaxShow;
					break;
				}
				case "PegInstructions":
				{
					value = PegInstructions;
					break;
				}
				case "DiscretionInstructions":
				{
					value = DiscretionInstructions;
					break;
				}
				case "TargetStrategy":
				{
					value = TargetStrategy;
					break;
				}
				case "StrategyParametersGrp":
				{
					value = StrategyParametersGrp;
					break;
				}
				case "TargetStrategyParameters":
				{
					value = TargetStrategyParameters;
					break;
				}
				case "RiskFreeRate":
				{
					value = RiskFreeRate;
					break;
				}
				case "ParticipationRate":
				{
					value = ParticipationRate;
					break;
				}
				case "CancellationRights":
				{
					value = CancellationRights;
					break;
				}
				case "MoneyLaunderingStatus":
				{
					value = MoneyLaunderingStatus;
					break;
				}
				case "RegistID":
				{
					value = RegistID;
					break;
				}
				case "Designation":
				{
					value = Designation;
					break;
				}
				case "OwnerType":
				{
					value = OwnerType;
					break;
				}
				case "OrderOwnershipIndicator":
				{
					value = OrderOwnershipIndicator;
					break;
				}
				case "MultiLegRptTypeReq":
				{
					value = MultiLegRptTypeReq;
					break;
				}
				case "ThrottleInst":
				{
					value = ThrottleInst;
					break;
				}
				case "AuctionType":
				{
					value = AuctionType;
					break;
				}
				case "AuctionAllocationPct":
				{
					value = AuctionAllocationPct;
					break;
				}
				case "RelatedHighPrice":
				{
					value = RelatedHighPrice;
					break;
				}
				case "RelatedLowPrice":
				{
					value = RelatedLowPrice;
					break;
				}
				case "RelatedPriceSource":
				{
					value = RelatedPriceSource;
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
			OrderID = null;
			OrderRequestID = null;
			OrigClOrdID = null;
			ClOrdID = null;
			SecondaryClOrdID = null;
			ClOrdLinkID = null;
			OrigOrdModTime = null;
			((IFixReset?)Parties)?.Reset();
			((IFixReset?)TargetParties)?.Reset();
			TradeOriginationDate = null;
			TradeDate = null;
			Account = null;
			AcctIDSource = null;
			AccountType = null;
			DayBookingInst = null;
			BookingUnit = null;
			PreallocMethod = null;
			AllocID = null;
			((IFixReset?)PreAllocMlegGrp)?.Reset();
			SettlType = null;
			SettlDate = null;
			CashMargin = null;
			ClearingFeeIndicator = null;
			HandlInst = null;
			ExecInst = null;
			AuctionInstruction = null;
			MinQty = null;
			MinQtyMethod = null;
			MatchIncrement = null;
			MaxPriceLevels = null;
			MaximumPriceDeviation = null;
			((IFixReset?)ValueChecksGrp)?.Reset();
			((IFixReset?)MatchingInstructions)?.Reset();
			SelfMatchPreventionID = null;
			SelfMatchPreventionInstruction = null;
			((IFixReset?)DisplayInstruction)?.Reset();
			((IFixReset?)DisclosureInstructionGrp)?.Reset();
			MaxFloor = null;
			MarketSegmentID = null;
			ExDestination = null;
			ExDestinationIDSource = null;
			ExDestinationType = null;
			((IFixReset?)TrdgSesGrp)?.Reset();
			ProcessCode = null;
			Side = null;
			ShortMarkingExemptIndicator = null;
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)UndInstrmtGrp)?.Reset();
			PrevClosePx = null;
			SwapPoints = null;
			((IFixReset?)LegOrdGrp)?.Reset();
			LocateReqd = null;
			TransactTime = null;
			QtyType = null;
			((IFixReset?)OrderQtyData)?.Reset();
			OrdType = null;
			MultilegModel = null;
			MultilegPriceMethod = null;
			PriceType = null;
			Price = null;
			PriceProtectionScope = null;
			StopPx = null;
			((IFixReset?)TriggeringInstruction)?.Reset();
			Currency = null;
			CurrencyCodeSource = null;
			ComplianceID = null;
			ComplianceText = null;
			EncodedComplianceTextLen = null;
			EncodedComplianceText = null;
			SolicitedFlag = null;
			IOIID = null;
			QuoteID = null;
			TimeInForce = null;
			EffectiveTime = null;
			ExpireDate = null;
			ExpireTime = null;
			GTBookingInst = null;
			ExposureDuration = null;
			ExposureDurationUnit = null;
			((IFixReset?)CommissionData)?.Reset();
			((IFixReset?)CommissionDataGrp)?.Reset();
			OrderCapacity = null;
			OrderRestrictions = null;
			TradingCapacity = null;
			PreTradeAnonymity = null;
			TradePublishIndicator = null;
			CustOrderCapacity = null;
			OrderOrigination = null;
			((IFixReset?)OrderAttributeGrp)?.Reset();
			ForexReq = null;
			SettlCurrency = null;
			SettlCurrencyCodeSource = null;
			BookingType = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			ClearingAccountType = null;
			PositionEffect = null;
			CoveredOrUncovered = null;
			MaxShow = null;
			((IFixReset?)PegInstructions)?.Reset();
			((IFixReset?)DiscretionInstructions)?.Reset();
			TargetStrategy = null;
			((IFixReset?)StrategyParametersGrp)?.Reset();
			TargetStrategyParameters = null;
			RiskFreeRate = null;
			ParticipationRate = null;
			CancellationRights = null;
			MoneyLaunderingStatus = null;
			RegistID = null;
			Designation = null;
			OwnerType = null;
			OrderOwnershipIndicator = null;
			MultiLegRptTypeReq = null;
			ThrottleInst = null;
			AuctionType = null;
			AuctionAllocationPct = null;
			RelatedHighPrice = null;
			RelatedLowPrice = null;
			RelatedPriceSource = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
