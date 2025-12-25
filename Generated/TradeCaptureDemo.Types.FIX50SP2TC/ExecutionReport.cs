using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("8", FixVersion.FIX50SP2)]
	public sealed partial class ExecutionReport : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public ApplicationSequenceControl? ApplicationSequenceControl {get; set;}
		
		[TagDetails(Tag = 37, Type = TagType.String, Offset = 2, Required = true)]
		public string? OrderID {get; set;}
		
		[TagDetails(Tag = 2422, Type = TagType.Int, Offset = 3, Required = false)]
		public int? OrderRequestID {get; set;}
		
		[TagDetails(Tag = 2423, Type = TagType.String, Offset = 4, Required = false)]
		public string? MassOrderRequestID {get; set;}
		
		[TagDetails(Tag = 198, Type = TagType.String, Offset = 5, Required = false)]
		public string? SecondaryOrderID {get; set;}
		
		[TagDetails(Tag = 526, Type = TagType.String, Offset = 6, Required = false)]
		public string? SecondaryClOrdID {get; set;}
		
		[TagDetails(Tag = 527, Type = TagType.String, Offset = 7, Required = false)]
		public string? SecondaryExecID {get; set;}
		
		[TagDetails(Tag = 11, Type = TagType.String, Offset = 8, Required = false)]
		public string? ClOrdID {get; set;}
		
		[TagDetails(Tag = 1166, Type = TagType.String, Offset = 9, Required = false)]
		public string? QuoteMsgID {get; set;}
		
		[TagDetails(Tag = 41, Type = TagType.String, Offset = 10, Required = false)]
		public string? OrigClOrdID {get; set;}
		
		[TagDetails(Tag = 583, Type = TagType.String, Offset = 11, Required = false)]
		public string? ClOrdLinkID {get; set;}
		
		[TagDetails(Tag = 278, Type = TagType.String, Offset = 12, Required = false)]
		public string? MDEntryID {get; set;}
		
		[TagDetails(Tag = 693, Type = TagType.String, Offset = 13, Required = false)]
		public string? QuoteRespID {get; set;}
		
		[TagDetails(Tag = 790, Type = TagType.String, Offset = 14, Required = false)]
		public string? OrdStatusReqID {get; set;}
		
		[TagDetails(Tag = 584, Type = TagType.String, Offset = 15, Required = false)]
		public string? MassStatusReqID {get; set;}
		
		[TagDetails(Tag = 961, Type = TagType.String, Offset = 16, Required = false)]
		public string? HostCrossID {get; set;}
		
		[TagDetails(Tag = 911, Type = TagType.Int, Offset = 17, Required = false)]
		public int? TotNumReports {get; set;}
		
		[TagDetails(Tag = 912, Type = TagType.Boolean, Offset = 18, Required = false)]
		public bool? LastRptRequested {get; set;}
		
		[Component(Offset = 19, Required = false)]
		public Parties? Parties {get; set;}
		
		[Component(Offset = 20, Required = false)]
		public TargetParties? TargetParties {get; set;}
		
		[TagDetails(Tag = 229, Type = TagType.LocalDate, Offset = 21, Required = false)]
		public DateOnly? TradeOriginationDate {get; set;}
		
		[Component(Offset = 22, Required = false)]
		public ContraGrp? ContraGrp {get; set;}
		
		[TagDetails(Tag = 66, Type = TagType.String, Offset = 23, Required = false)]
		public string? ListID {get; set;}
		
		[TagDetails(Tag = 548, Type = TagType.String, Offset = 24, Required = false)]
		public string? CrossID {get; set;}
		
		[TagDetails(Tag = 551, Type = TagType.String, Offset = 25, Required = false)]
		public string? OrigCrossID {get; set;}
		
		[TagDetails(Tag = 549, Type = TagType.Int, Offset = 26, Required = false)]
		public int? CrossType {get; set;}
		
		[TagDetails(Tag = 2334, Type = TagType.String, Offset = 27, Required = false)]
		public string? RefRiskLimitCheckID {get; set;}
		
		[TagDetails(Tag = 2335, Type = TagType.Int, Offset = 28, Required = false)]
		public int? RefRiskLimitCheckIDType {get; set;}
		
		[TagDetails(Tag = 880, Type = TagType.String, Offset = 29, Required = false)]
		public string? TrdMatchID {get; set;}
		
		[TagDetails(Tag = 1891, Type = TagType.String, Offset = 30, Required = false)]
		public string? TrdMatchSubID {get; set;}
		
		[TagDetails(Tag = 17, Type = TagType.String, Offset = 31, Required = true)]
		public string? ExecID {get; set;}
		
		[TagDetails(Tag = 19, Type = TagType.String, Offset = 32, Required = false)]
		public string? ExecRefID {get; set;}
		
		[TagDetails(Tag = 150, Type = TagType.String, Offset = 33, Required = true)]
		public string? ExecType {get; set;}
		
		[TagDetails(Tag = 2431, Type = TagType.Int, Offset = 34, Required = false)]
		public int? ExecTypeReason {get; set;}
		
		[TagDetails(Tag = 39, Type = TagType.String, Offset = 35, Required = true)]
		public string? OrdStatus {get; set;}
		
		[TagDetails(Tag = 636, Type = TagType.Boolean, Offset = 36, Required = false)]
		public bool? WorkingIndicator {get; set;}
		
		[TagDetails(Tag = 2838, Type = TagType.Float, Offset = 37, Required = false)]
		public double? CurrentWorkingPrice {get; set;}
		
		[TagDetails(Tag = 103, Type = TagType.Int, Offset = 38, Required = false)]
		public int? OrdRejReason {get; set;}
		
		[TagDetails(Tag = 1328, Type = TagType.String, Offset = 39, Required = false)]
		public string? RejectText {get; set;}
		
		[TagDetails(Tag = 1664, Type = TagType.Length, Offset = 40, Required = false)]
		public int? EncodedRejectTextLen {get; set;}
		
		[TagDetails(Tag = 1665, Type = TagType.RawData, Offset = 41, Required = false)]
		public byte[]? EncodedRejectText {get; set;}
		
		[TagDetails(Tag = 378, Type = TagType.Int, Offset = 42, Required = false)]
		public int? ExecRestatementReason {get; set;}
		
		[TagDetails(Tag = 2961, Type = TagType.Boolean, Offset = 43, Required = false)]
		public bool? AnonymousTradeIndicator {get; set;}
		
		[TagDetails(Tag = 2667, Type = TagType.Int, Offset = 44, Required = false)]
		public int? AlgorithmicTradeIndicator {get; set;}
		
		[TagDetails(Tag = 828, Type = TagType.Int, Offset = 45, Required = false)]
		public int? TrdType {get; set;}
		
		[TagDetails(Tag = 829, Type = TagType.Int, Offset = 46, Required = false)]
		public int? TrdSubType {get; set;}
		
		[TagDetails(Tag = 855, Type = TagType.Int, Offset = 47, Required = false)]
		public int? SecondaryTrdType {get; set;}
		
		[TagDetails(Tag = 2347, Type = TagType.Int, Offset = 48, Required = false)]
		public int? RegulatoryTransactionType {get; set;}
		
		[Component(Offset = 49, Required = false)]
		public RegulatoryTradeIDGrp? RegulatoryTradeIDGrp {get; set;}
		
		[TagDetails(Tag = 570, Type = TagType.Boolean, Offset = 50, Required = false)]
		public bool? PreviouslyReported {get; set;}
		
		[TagDetails(Tag = 2524, Type = TagType.Int, Offset = 51, Required = false)]
		public int? TradeReportingIndicator {get; set;}
		
		[TagDetails(Tag = 1, Type = TagType.String, Offset = 52, Required = false)]
		public string? Account {get; set;}
		
		[TagDetails(Tag = 660, Type = TagType.Int, Offset = 53, Required = false)]
		public int? AcctIDSource {get; set;}
		
		[TagDetails(Tag = 581, Type = TagType.Int, Offset = 54, Required = false)]
		public int? AccountType {get; set;}
		
		[TagDetails(Tag = 589, Type = TagType.String, Offset = 55, Required = false)]
		public string? DayBookingInst {get; set;}
		
		[TagDetails(Tag = 590, Type = TagType.String, Offset = 56, Required = false)]
		public string? BookingUnit {get; set;}
		
		[TagDetails(Tag = 591, Type = TagType.String, Offset = 57, Required = false)]
		public string? PreallocMethod {get; set;}
		
		[TagDetails(Tag = 70, Type = TagType.String, Offset = 58, Required = false)]
		public string? AllocID {get; set;}
		
		[Component(Offset = 59, Required = false)]
		public PreAllocGrp? PreAllocGrp {get; set;}
		
		[TagDetails(Tag = 63, Type = TagType.String, Offset = 60, Required = false)]
		public string? SettlType {get; set;}
		
		[TagDetails(Tag = 64, Type = TagType.LocalDate, Offset = 61, Required = false)]
		public DateOnly? SettlDate {get; set;}
		
		[TagDetails(Tag = 574, Type = TagType.String, Offset = 62, Required = false)]
		public string? MatchType {get; set;}
		
		[TagDetails(Tag = 1115, Type = TagType.String, Offset = 63, Required = false)]
		public string? OrderCategory {get; set;}
		
		[TagDetails(Tag = 544, Type = TagType.String, Offset = 64, Required = false)]
		public string? CashMargin {get; set;}
		
		[TagDetails(Tag = 635, Type = TagType.String, Offset = 65, Required = false)]
		public string? ClearingFeeIndicator {get; set;}
		
		[Component(Offset = 66, Required = true)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 67, Required = false)]
		public FinancingDetails? FinancingDetails {get; set;}
		
		[Component(Offset = 68, Required = false)]
		public UndInstrmtGrp? UndInstrmtGrp {get; set;}
		
		[Component(Offset = 69, Required = false)]
		public PaymentGrp? PaymentGrp {get; set;}
		
		[TagDetails(Tag = 54, Type = TagType.String, Offset = 70, Required = true)]
		public string? Side {get; set;}
		
		[TagDetails(Tag = 2102, Type = TagType.Boolean, Offset = 71, Required = false)]
		public bool? ShortMarkingExemptIndicator {get; set;}
		
		[TagDetails(Tag = 1688, Type = TagType.Int, Offset = 72, Required = false)]
		public int? ShortSaleExemptionReason {get; set;}
		
		[Component(Offset = 73, Required = false)]
		public Stipulations? Stipulations {get; set;}
		
		[TagDetails(Tag = 854, Type = TagType.Int, Offset = 74, Required = false)]
		public int? QtyType {get; set;}
		
		[Component(Offset = 75, Required = false)]
		public OrderQtyData? OrderQtyData {get; set;}
		
		[TagDetails(Tag = 1093, Type = TagType.String, Offset = 76, Required = false)]
		public string? LotType {get; set;}
		
		[TagDetails(Tag = 40, Type = TagType.String, Offset = 77, Required = false)]
		public string? OrdType {get; set;}
		
		[TagDetails(Tag = 423, Type = TagType.Int, Offset = 78, Required = false)]
		public int? PriceType {get; set;}
		
		[Component(Offset = 79, Required = false)]
		public PriceQualifierGrp? PriceQualifierGrp {get; set;}
		
		[TagDetails(Tag = 44, Type = TagType.Float, Offset = 80, Required = false)]
		public double? Price {get; set;}
		
		[TagDetails(Tag = 1092, Type = TagType.String, Offset = 81, Required = false)]
		public string? PriceProtectionScope {get; set;}
		
		[TagDetails(Tag = 99, Type = TagType.Float, Offset = 82, Required = false)]
		public double? StopPx {get; set;}
		
		[Component(Offset = 83, Required = false)]
		public TriggeringInstruction? TriggeringInstruction {get; set;}
		
		[TagDetails(Tag = 1823, Type = TagType.Int, Offset = 84, Required = false)]
		public int? Triggered {get; set;}
		
		[Component(Offset = 85, Required = false)]
		public PegInstructions? PegInstructions {get; set;}
		
		[Component(Offset = 86, Required = false)]
		public DiscretionInstructions? DiscretionInstructions {get; set;}
		
		[TagDetails(Tag = 839, Type = TagType.Float, Offset = 87, Required = false)]
		public double? PeggedPrice {get; set;}
		
		[TagDetails(Tag = 1095, Type = TagType.Float, Offset = 88, Required = false)]
		public double? PeggedRefPrice {get; set;}
		
		[TagDetails(Tag = 845, Type = TagType.Float, Offset = 89, Required = false)]
		public double? DiscretionPrice {get; set;}
		
		[TagDetails(Tag = 1740, Type = TagType.Int, Offset = 90, Required = false)]
		public int? TradePriceNegotiationMethod {get; set;}
		
		[TagDetails(Tag = 1742, Type = TagType.Float, Offset = 91, Required = false)]
		public double? UpfrontPrice {get; set;}
		
		[TagDetails(Tag = 1741, Type = TagType.Int, Offset = 92, Required = false)]
		public int? UpfrontPriceType {get; set;}
		
		[TagDetails(Tag = 847, Type = TagType.Int, Offset = 93, Required = false)]
		public int? TargetStrategy {get; set;}
		
		[Component(Offset = 94, Required = false)]
		public StrategyParametersGrp? StrategyParametersGrp {get; set;}
		
		[TagDetails(Tag = 848, Type = TagType.String, Offset = 95, Required = false)]
		public string? TargetStrategyParameters {get; set;}
		
		[TagDetails(Tag = 849, Type = TagType.Float, Offset = 96, Required = false)]
		public double? ParticipationRate {get; set;}
		
		[TagDetails(Tag = 850, Type = TagType.Float, Offset = 97, Required = false)]
		public double? TargetStrategyPerformance {get; set;}
		
		[TagDetails(Tag = 15, Type = TagType.String, Offset = 98, Required = false)]
		public string? Currency {get; set;}
		
		[TagDetails(Tag = 2897, Type = TagType.String, Offset = 99, Required = false)]
		public string? CurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 376, Type = TagType.String, Offset = 100, Required = false)]
		public string? ComplianceID {get; set;}
		
		[TagDetails(Tag = 2404, Type = TagType.String, Offset = 101, Required = false)]
		public string? ComplianceText {get; set;}
		
		[TagDetails(Tag = 2351, Type = TagType.Length, Offset = 102, Required = false)]
		public int? EncodedComplianceTextLen {get; set;}
		
		[TagDetails(Tag = 2352, Type = TagType.RawData, Offset = 103, Required = false)]
		public byte[]? EncodedComplianceText {get; set;}
		
		[TagDetails(Tag = 377, Type = TagType.Boolean, Offset = 104, Required = false)]
		public bool? SolicitedFlag {get; set;}
		
		[TagDetails(Tag = 59, Type = TagType.String, Offset = 105, Required = false)]
		public string? TimeInForce {get; set;}
		
		[TagDetails(Tag = 168, Type = TagType.UtcTimestamp, Offset = 106, Required = false)]
		public DateTime? EffectiveTime {get; set;}
		
		[TagDetails(Tag = 432, Type = TagType.LocalDate, Offset = 107, Required = false)]
		public DateOnly? ExpireDate {get; set;}
		
		[TagDetails(Tag = 126, Type = TagType.UtcTimestamp, Offset = 108, Required = false)]
		public DateTime? ExpireTime {get; set;}
		
		[TagDetails(Tag = 1629, Type = TagType.Int, Offset = 109, Required = false)]
		public int? ExposureDuration {get; set;}
		
		[TagDetails(Tag = 1916, Type = TagType.Int, Offset = 110, Required = false)]
		public int? ExposureDurationUnit {get; set;}
		
		[TagDetails(Tag = 18, Type = TagType.String, Offset = 111, Required = false)]
		public string? ExecInst {get; set;}
		
		[TagDetails(Tag = 1805, Type = TagType.Int, Offset = 112, Required = false)]
		public int? AuctionInstruction {get; set;}
		
		[TagDetails(Tag = 1057, Type = TagType.Boolean, Offset = 113, Required = false)]
		public bool? AggressorIndicator {get; set;}
		
		[TagDetails(Tag = 528, Type = TagType.String, Offset = 114, Required = false)]
		public string? OrderCapacity {get; set;}
		
		[TagDetails(Tag = 529, Type = TagType.String, Offset = 115, Required = false)]
		public string? OrderRestrictions {get; set;}
		
		[TagDetails(Tag = 1815, Type = TagType.Int, Offset = 116, Required = false)]
		public int? TradingCapacity {get; set;}
		
		[TagDetails(Tag = 1934, Type = TagType.Int, Offset = 117, Required = false)]
		public int? RegulatoryReportType {get; set;}
		
		[TagDetails(Tag = 1091, Type = TagType.Boolean, Offset = 118, Required = false)]
		public bool? PreTradeAnonymity {get; set;}
		
		[TagDetails(Tag = 1390, Type = TagType.Int, Offset = 119, Required = false)]
		public int? TradePublishIndicator {get; set;}
		
		[TagDetails(Tag = 582, Type = TagType.Int, Offset = 120, Required = false)]
		public int? CustOrderCapacity {get; set;}
		
		[Component(Offset = 121, Required = false)]
		public OrderAttributeGrp? OrderAttributeGrp {get; set;}
		
		[TagDetails(Tag = 32, Type = TagType.Float, Offset = 122, Required = false)]
		public double? LastQty {get; set;}
		
		[TagDetails(Tag = 1056, Type = TagType.Float, Offset = 123, Required = false)]
		public double? CalculatedCcyLastQty {get; set;}
		
		[TagDetails(Tag = 1071, Type = TagType.Float, Offset = 124, Required = false)]
		public double? LastSwapPoints {get; set;}
		
		[TagDetails(Tag = 652, Type = TagType.Float, Offset = 125, Required = false)]
		public double? UnderlyingLastQty {get; set;}
		
		[TagDetails(Tag = 1828, Type = TagType.Float, Offset = 126, Required = false)]
		public double? LastQtyVariance {get; set;}
		
		[TagDetails(Tag = 31, Type = TagType.Float, Offset = 127, Required = false)]
		public double? LastPx {get; set;}
		
		[TagDetails(Tag = 651, Type = TagType.Float, Offset = 128, Required = false)]
		public double? UnderlyingLastPx {get; set;}
		
		[TagDetails(Tag = 669, Type = TagType.Float, Offset = 129, Required = false)]
		public double? LastParPx {get; set;}
		
		[TagDetails(Tag = 631, Type = TagType.Float, Offset = 130, Required = false)]
		public double? MidPx {get; set;}
		
		[TagDetails(Tag = 194, Type = TagType.Float, Offset = 131, Required = false)]
		public double? LastSpotRate {get; set;}
		
		[TagDetails(Tag = 195, Type = TagType.Float, Offset = 132, Required = false)]
		public double? LastForwardPoints {get; set;}
		
		[TagDetails(Tag = 1743, Type = TagType.Float, Offset = 133, Required = false)]
		public double? LastUpfrontPrice {get; set;}
		
		[TagDetails(Tag = 2750, Type = TagType.Float, Offset = 134, Required = false)]
		public double? ReportingPx {get; set;}
		
		[TagDetails(Tag = 2751, Type = TagType.Float, Offset = 135, Required = false)]
		public double? ReportingQty {get; set;}
		
		[TagDetails(Tag = 30, Type = TagType.String, Offset = 136, Required = false)]
		public string? LastMkt {get; set;}
		
		[TagDetails(Tag = 1430, Type = TagType.String, Offset = 137, Required = false)]
		public string? VenueType {get; set;}
		
		[TagDetails(Tag = 1300, Type = TagType.String, Offset = 138, Required = false)]
		public string? MarketSegmentID {get; set;}
		
		[TagDetails(Tag = 100, Type = TagType.String, Offset = 139, Required = false)]
		public string? ExDestination {get; set;}
		
		[TagDetails(Tag = 1133, Type = TagType.String, Offset = 140, Required = false)]
		public string? ExDestinationIDSource {get; set;}
		
		[TagDetails(Tag = 2704, Type = TagType.Int, Offset = 141, Required = false)]
		public int? ExDestinationType {get; set;}
		
		[TagDetails(Tag = 336, Type = TagType.String, Offset = 142, Required = false)]
		public string? TradingSessionID {get; set;}
		
		[TagDetails(Tag = 625, Type = TagType.String, Offset = 143, Required = false)]
		public string? TradingSessionSubID {get; set;}
		
		[TagDetails(Tag = 943, Type = TagType.String, Offset = 144, Required = false)]
		public string? TimeBracket {get; set;}
		
		[TagDetails(Tag = 29, Type = TagType.String, Offset = 145, Required = false)]
		public string? LastCapacity {get; set;}
		
		[Component(Offset = 146, Required = false)]
		public LimitAmts? LimitAmts {get; set;}
		
		[TagDetails(Tag = 151, Type = TagType.Float, Offset = 147, Required = true)]
		public double? LeavesQty {get; set;}
		
		[TagDetails(Tag = 14, Type = TagType.Float, Offset = 148, Required = true)]
		public double? CumQty {get; set;}
		
		[TagDetails(Tag = 84, Type = TagType.Float, Offset = 149, Required = false)]
		public double? CxlQty {get; set;}
		
		[TagDetails(Tag = 6, Type = TagType.Float, Offset = 150, Required = false)]
		public double? AvgPx {get; set;}
		
		[TagDetails(Tag = 424, Type = TagType.Float, Offset = 151, Required = false)]
		public double? DayOrderQty {get; set;}
		
		[TagDetails(Tag = 425, Type = TagType.Float, Offset = 152, Required = false)]
		public double? DayCumQty {get; set;}
		
		[TagDetails(Tag = 426, Type = TagType.Float, Offset = 153, Required = false)]
		public double? DayAvgPx {get; set;}
		
		[TagDetails(Tag = 1361, Type = TagType.Int, Offset = 154, Required = false)]
		public int? TotNoFills {get; set;}
		
		[TagDetails(Tag = 893, Type = TagType.Boolean, Offset = 155, Required = false)]
		public bool? LastFragment {get; set;}
		
		[Component(Offset = 156, Required = false)]
		public FillsGrp? FillsGrp {get; set;}
		
		[Component(Offset = 157, Required = false)]
		public OrderEventGrp? OrderEventGrp {get; set;}
		
		[TagDetails(Tag = 2830, Type = TagType.String, Offset = 158, Required = false)]
		public string? EventInitiatorType {get; set;}
		
		[TagDetails(Tag = 427, Type = TagType.Int, Offset = 159, Required = false)]
		public int? GTBookingInst {get; set;}
		
		[TagDetails(Tag = 75, Type = TagType.LocalDate, Offset = 160, Required = false)]
		public DateOnly? TradeDate {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 161, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 113, Type = TagType.Boolean, Offset = 162, Required = false)]
		public bool? ReportToExch {get; set;}
		
		[Component(Offset = 163, Required = false)]
		public CommissionData? CommissionData {get; set;}
		
		[Component(Offset = 164, Required = false)]
		public CommissionDataGrp? CommissionDataGrp {get; set;}
		
		[Component(Offset = 165, Required = false)]
		public SpreadOrBenchmarkCurveData? SpreadOrBenchmarkCurveData {get; set;}
		
		[Component(Offset = 166, Required = false)]
		public RelativeValueGrp? RelativeValueGrp {get; set;}
		
		[Component(Offset = 167, Required = false)]
		public YieldData? YieldData {get; set;}
		
		[TagDetails(Tag = 381, Type = TagType.Float, Offset = 168, Required = false)]
		public double? GrossTradeAmt {get; set;}
		
		[TagDetails(Tag = 157, Type = TagType.Int, Offset = 169, Required = false)]
		public int? NumDaysInterest {get; set;}
		
		[TagDetails(Tag = 230, Type = TagType.LocalDate, Offset = 170, Required = false)]
		public DateOnly? ExDate {get; set;}
		
		[TagDetails(Tag = 158, Type = TagType.Float, Offset = 171, Required = false)]
		public double? AccruedInterestRate {get; set;}
		
		[TagDetails(Tag = 159, Type = TagType.Float, Offset = 172, Required = false)]
		public double? AccruedInterestAmt {get; set;}
		
		[TagDetails(Tag = 738, Type = TagType.Float, Offset = 173, Required = false)]
		public double? InterestAtMaturity {get; set;}
		
		[TagDetails(Tag = 920, Type = TagType.Float, Offset = 174, Required = false)]
		public double? EndAccruedInterestAmt {get; set;}
		
		[TagDetails(Tag = 921, Type = TagType.Float, Offset = 175, Required = false)]
		public double? StartCash {get; set;}
		
		[TagDetails(Tag = 922, Type = TagType.Float, Offset = 176, Required = false)]
		public double? EndCash {get; set;}
		
		[TagDetails(Tag = 258, Type = TagType.Boolean, Offset = 177, Required = false)]
		public bool? TradedFlatSwitch {get; set;}
		
		[TagDetails(Tag = 259, Type = TagType.LocalDate, Offset = 178, Required = false)]
		public DateOnly? BasisFeatureDate {get; set;}
		
		[TagDetails(Tag = 260, Type = TagType.Float, Offset = 179, Required = false)]
		public double? BasisFeaturePrice {get; set;}
		
		[TagDetails(Tag = 238, Type = TagType.Float, Offset = 180, Required = false)]
		public double? Concession {get; set;}
		
		[TagDetails(Tag = 237, Type = TagType.Float, Offset = 181, Required = false)]
		public double? TotalTakedown {get; set;}
		
		[TagDetails(Tag = 118, Type = TagType.Float, Offset = 182, Required = false)]
		public double? NetMoney {get; set;}
		
		[TagDetails(Tag = 119, Type = TagType.Float, Offset = 183, Required = false)]
		public double? SettlCurrAmt {get; set;}
		
		[TagDetails(Tag = 120, Type = TagType.String, Offset = 184, Required = false)]
		public string? SettlCurrency {get; set;}
		
		[TagDetails(Tag = 2899, Type = TagType.String, Offset = 185, Required = false)]
		public string? SettlCurrencyCodeSource {get; set;}
		
		[Component(Offset = 186, Required = false)]
		public RateSource? RateSource {get; set;}
		
		[TagDetails(Tag = 2795, Type = TagType.Int, Offset = 187, Required = false)]
		public int? OffshoreIndicator {get; set;}
		
		[TagDetails(Tag = 155, Type = TagType.Float, Offset = 188, Required = false)]
		public double? SettlCurrFxRate {get; set;}
		
		[TagDetails(Tag = 156, Type = TagType.String, Offset = 189, Required = false)]
		public string? SettlCurrFxRateCalc {get; set;}
		
		[TagDetails(Tag = 21, Type = TagType.String, Offset = 190, Required = false)]
		public string? HandlInst {get; set;}
		
		[TagDetails(Tag = 110, Type = TagType.Float, Offset = 191, Required = false)]
		public double? MinQty {get; set;}
		
		[TagDetails(Tag = 1822, Type = TagType.Int, Offset = 192, Required = false)]
		public int? MinQtyMethod {get; set;}
		
		[TagDetails(Tag = 1089, Type = TagType.Float, Offset = 193, Required = false)]
		public double? MatchIncrement {get; set;}
		
		[TagDetails(Tag = 1090, Type = TagType.Int, Offset = 194, Required = false)]
		public int? MaxPriceLevels {get; set;}
		
		[TagDetails(Tag = 2676, Type = TagType.Float, Offset = 195, Required = false)]
		public double? MaximumPriceDeviation {get; set;}
		
		[Component(Offset = 196, Required = false)]
		public ValueChecksGrp? ValueChecksGrp {get; set;}
		
		[Component(Offset = 197, Required = false)]
		public MatchingInstructions? MatchingInstructions {get; set;}
		
		[TagDetails(Tag = 2362, Type = TagType.String, Offset = 198, Required = false)]
		public string? SelfMatchPreventionID {get; set;}
		
		[TagDetails(Tag = 2964, Type = TagType.Int, Offset = 199, Required = false)]
		public int? SelfMatchPreventionInstruction {get; set;}
		
		[TagDetails(Tag = 2523, Type = TagType.Int, Offset = 200, Required = false)]
		public int? CrossedIndicator {get; set;}
		
		[Component(Offset = 201, Required = false)]
		public DisplayInstruction? DisplayInstruction {get; set;}
		
		[Component(Offset = 202, Required = false)]
		public DisclosureInstructionGrp? DisclosureInstructionGrp {get; set;}
		
		[TagDetails(Tag = 111, Type = TagType.Float, Offset = 203, Required = false)]
		public double? MaxFloor {get; set;}
		
		[TagDetails(Tag = 1816, Type = TagType.Int, Offset = 204, Required = false)]
		public int? ClearingAccountType {get; set;}
		
		[TagDetails(Tag = 77, Type = TagType.String, Offset = 205, Required = false)]
		public string? PositionEffect {get; set;}
		
		[TagDetails(Tag = 210, Type = TagType.Float, Offset = 206, Required = false)]
		public double? MaxShow {get; set;}
		
		[TagDetails(Tag = 775, Type = TagType.Int, Offset = 207, Required = false)]
		public int? BookingType {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 208, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 209, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 210, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[TagDetails(Tag = 193, Type = TagType.LocalDate, Offset = 211, Required = false)]
		public DateOnly? SettlDate2 {get; set;}
		
		[TagDetails(Tag = 192, Type = TagType.Float, Offset = 212, Required = false)]
		public double? OrderQty2 {get; set;}
		
		[TagDetails(Tag = 641, Type = TagType.Float, Offset = 213, Required = false)]
		public double? LastForwardPoints2 {get; set;}
		
		[TagDetails(Tag = 442, Type = TagType.String, Offset = 214, Required = false)]
		public string? MultiLegReportingType {get; set;}
		
		[TagDetails(Tag = 1385, Type = TagType.Int, Offset = 215, Required = false)]
		public int? ContingencyType {get; set;}
		
		[TagDetails(Tag = 480, Type = TagType.String, Offset = 216, Required = false)]
		public string? CancellationRights {get; set;}
		
		[TagDetails(Tag = 481, Type = TagType.String, Offset = 217, Required = false)]
		public string? MoneyLaunderingStatus {get; set;}
		
		[TagDetails(Tag = 513, Type = TagType.String, Offset = 218, Required = false)]
		public string? RegistID {get; set;}
		
		[TagDetails(Tag = 494, Type = TagType.String, Offset = 219, Required = false)]
		public string? Designation {get; set;}
		
		[TagDetails(Tag = 483, Type = TagType.UtcTimestamp, Offset = 220, Required = false)]
		public DateTime? TransBkdTime {get; set;}
		
		[TagDetails(Tag = 515, Type = TagType.UtcTimestamp, Offset = 221, Required = false)]
		public DateTime? ExecValuationPoint {get; set;}
		
		[TagDetails(Tag = 484, Type = TagType.String, Offset = 222, Required = false)]
		public string? ExecPriceType {get; set;}
		
		[TagDetails(Tag = 485, Type = TagType.Float, Offset = 223, Required = false)]
		public double? ExecPriceAdjustment {get; set;}
		
		[TagDetails(Tag = 638, Type = TagType.Int, Offset = 224, Required = false)]
		public int? PriorityIndicator {get; set;}
		
		[TagDetails(Tag = 639, Type = TagType.Float, Offset = 225, Required = false)]
		public double? PriceImprovement {get; set;}
		
		[TagDetails(Tag = 851, Type = TagType.Int, Offset = 226, Required = false)]
		public int? LastLiquidityInd {get; set;}
		
		[Component(Offset = 227, Required = false)]
		public ContAmtGrp? ContAmtGrp {get; set;}
		
		[Component(Offset = 228, Required = false)]
		public InstrmtLegExecGrp? InstrmtLegExecGrp {get; set;}
		
		[TagDetails(Tag = 797, Type = TagType.Boolean, Offset = 229, Required = false)]
		public bool? CopyMsgIndicator {get; set;}
		
		[Component(Offset = 230, Required = false)]
		public MiscFeesGrp? MiscFeesGrp {get; set;}
		
		[TagDetails(Tag = 1380, Type = TagType.Float, Offset = 231, Required = false)]
		public double? DividendYield {get; set;}
		
		[TagDetails(Tag = 1028, Type = TagType.Boolean, Offset = 232, Required = false)]
		public bool? ManualOrderIndicator {get; set;}
		
		[TagDetails(Tag = 1029, Type = TagType.Boolean, Offset = 233, Required = false)]
		public bool? CustDirectedOrder {get; set;}
		
		[TagDetails(Tag = 1030, Type = TagType.String, Offset = 234, Required = false)]
		public string? ReceivedDeptID {get; set;}
		
		[TagDetails(Tag = 1031, Type = TagType.String, Offset = 235, Required = false)]
		public string? CustOrderHandlingInst {get; set;}
		
		[TagDetails(Tag = 1032, Type = TagType.Int, Offset = 236, Required = false)]
		public int? OrderHandlingInstSource {get; set;}
		
		[TagDetails(Tag = 1724, Type = TagType.Int, Offset = 237, Required = false)]
		public int? OrderOrigination {get; set;}
		
		[TagDetails(Tag = 2882, Type = TagType.Int, Offset = 238, Required = false)]
		public int? ContraOrderOrigination {get; set;}
		
		[TagDetails(Tag = 1725, Type = TagType.String, Offset = 239, Required = false)]
		public string? OriginatingDeptID {get; set;}
		
		[TagDetails(Tag = 1726, Type = TagType.String, Offset = 240, Required = false)]
		public string? ReceivingDeptID {get; set;}
		
		[TagDetails(Tag = 2883, Type = TagType.Int, Offset = 241, Required = false)]
		public int? RoutingArrangmentIndicator {get; set;}
		
		[TagDetails(Tag = 2884, Type = TagType.Int, Offset = 242, Required = false)]
		public int? ContraRoutingArrangmentIndicator {get; set;}
		
		[TagDetails(Tag = 2525, Type = TagType.Boolean, Offset = 243, Required = false)]
		public bool? AffiliatedFirmsTradeIndicator {get; set;}
		
		[TagDetails(Tag = 522, Type = TagType.Int, Offset = 244, Required = false)]
		public int? OwnerType {get; set;}
		
		[TagDetails(Tag = 2679, Type = TagType.Int, Offset = 245, Required = false)]
		public int? OrderOwnershipIndicator {get; set;}
		
		[Component(Offset = 246, Required = false)]
		public TrdRegTimestamps? TrdRegTimestamps {get; set;}
		
		[Component(Offset = 247, Required = false)]
		public TrdRegPublicationGrp? TrdRegPublicationGrp {get; set;}
		
		[Component(Offset = 248, Required = false)]
		public TradePriceConditionGrp? TradePriceConditionGrp {get; set;}
		
		[TagDetails(Tag = 1937, Type = TagType.Int, Offset = 249, Required = false)]
		public int? TradeContinuation {get; set;}
		
		[TagDetails(Tag = 2374, Type = TagType.String, Offset = 250, Required = false)]
		public string? TradeContinuationText {get; set;}
		
		[TagDetails(Tag = 2372, Type = TagType.Length, Offset = 251, Required = false)]
		public int? EncodedTradeContinuationTextLen {get; set;}
		
		[TagDetails(Tag = 2371, Type = TagType.RawData, Offset = 252, Required = false)]
		public byte[]? EncodedTradeContinuationText {get; set;}
		
		[TagDetails(Tag = 1188, Type = TagType.Float, Offset = 253, Required = false)]
		public double? Volatility {get; set;}
		
		[TagDetails(Tag = 1189, Type = TagType.Float, Offset = 254, Required = false)]
		public double? TimeToExpiration {get; set;}
		
		[TagDetails(Tag = 1190, Type = TagType.Float, Offset = 255, Required = false)]
		public double? RiskFreeRate {get; set;}
		
		[TagDetails(Tag = 811, Type = TagType.Float, Offset = 256, Required = false)]
		public double? PriceDelta {get; set;}
		
		[TagDetails(Tag = 1917, Type = TagType.Float, Offset = 257, Required = false)]
		public double? CoverPrice {get; set;}
		
		[Component(Offset = 258, Required = false)]
		public ThrottleResponse? ThrottleResponse {get; set;}
		
		[TagDetails(Tag = 1080, Type = TagType.String, Offset = 259, Required = false)]
		public string? RefOrderID {get; set;}
		
		[TagDetails(Tag = 1081, Type = TagType.String, Offset = 260, Required = false)]
		public string? RefOrderIDSource {get; set;}
		
		[TagDetails(Tag = 1806, Type = TagType.String, Offset = 261, Required = false)]
		public string? RefClOrdID {get; set;}
		
		[Component(Offset = 262, Required = false)]
		public RelatedOrderGrp? RelatedOrderGrp {get; set;}
		
		[TagDetails(Tag = 1803, Type = TagType.Int, Offset = 263, Required = false)]
		public int? AuctionType {get; set;}
		
		[TagDetails(Tag = 1804, Type = TagType.Float, Offset = 264, Required = false)]
		public double? AuctionAllocationPct {get; set;}
		
		[TagDetails(Tag = 1808, Type = TagType.Float, Offset = 265, Required = false)]
		public double? LockedQty {get; set;}
		
		[TagDetails(Tag = 1809, Type = TagType.Float, Offset = 266, Required = false)]
		public double? SecondaryLockedQty {get; set;}
		
		[TagDetails(Tag = 1807, Type = TagType.Int, Offset = 267, Required = false)]
		public int? LockType {get; set;}
		
		[TagDetails(Tag = 1810, Type = TagType.Int, Offset = 268, Required = false)]
		public int? ReleaseInstruction {get; set;}
		
		[TagDetails(Tag = 1811, Type = TagType.Float, Offset = 269, Required = false)]
		public double? ReleaseQty {get; set;}
		
		[TagDetails(Tag = 1819, Type = TagType.Float, Offset = 270, Required = false)]
		public double? RelatedHighPrice {get; set;}
		
		[TagDetails(Tag = 1820, Type = TagType.Float, Offset = 271, Required = false)]
		public double? RelatedLowPrice {get; set;}
		
		[TagDetails(Tag = 1821, Type = TagType.Int, Offset = 272, Required = false)]
		public int? RelatedPriceSource {get; set;}
		
		[Component(Offset = 273, Required = true)]
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
			if (ApplicationSequenceControl is not null) ((IFixEncoder)ApplicationSequenceControl).Encode(writer);
			if (OrderID is not null) writer.WriteString(37, OrderID);
			if (OrderRequestID is not null) writer.WriteWholeNumber(2422, OrderRequestID.Value);
			if (MassOrderRequestID is not null) writer.WriteString(2423, MassOrderRequestID);
			if (SecondaryOrderID is not null) writer.WriteString(198, SecondaryOrderID);
			if (SecondaryClOrdID is not null) writer.WriteString(526, SecondaryClOrdID);
			if (SecondaryExecID is not null) writer.WriteString(527, SecondaryExecID);
			if (ClOrdID is not null) writer.WriteString(11, ClOrdID);
			if (QuoteMsgID is not null) writer.WriteString(1166, QuoteMsgID);
			if (OrigClOrdID is not null) writer.WriteString(41, OrigClOrdID);
			if (ClOrdLinkID is not null) writer.WriteString(583, ClOrdLinkID);
			if (MDEntryID is not null) writer.WriteString(278, MDEntryID);
			if (QuoteRespID is not null) writer.WriteString(693, QuoteRespID);
			if (OrdStatusReqID is not null) writer.WriteString(790, OrdStatusReqID);
			if (MassStatusReqID is not null) writer.WriteString(584, MassStatusReqID);
			if (HostCrossID is not null) writer.WriteString(961, HostCrossID);
			if (TotNumReports is not null) writer.WriteWholeNumber(911, TotNumReports.Value);
			if (LastRptRequested is not null) writer.WriteBoolean(912, LastRptRequested.Value);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (TargetParties is not null) ((IFixEncoder)TargetParties).Encode(writer);
			if (TradeOriginationDate is not null) writer.WriteLocalDateOnly(229, TradeOriginationDate.Value);
			if (ContraGrp is not null) ((IFixEncoder)ContraGrp).Encode(writer);
			if (ListID is not null) writer.WriteString(66, ListID);
			if (CrossID is not null) writer.WriteString(548, CrossID);
			if (OrigCrossID is not null) writer.WriteString(551, OrigCrossID);
			if (CrossType is not null) writer.WriteWholeNumber(549, CrossType.Value);
			if (RefRiskLimitCheckID is not null) writer.WriteString(2334, RefRiskLimitCheckID);
			if (RefRiskLimitCheckIDType is not null) writer.WriteWholeNumber(2335, RefRiskLimitCheckIDType.Value);
			if (TrdMatchID is not null) writer.WriteString(880, TrdMatchID);
			if (TrdMatchSubID is not null) writer.WriteString(1891, TrdMatchSubID);
			if (ExecID is not null) writer.WriteString(17, ExecID);
			if (ExecRefID is not null) writer.WriteString(19, ExecRefID);
			if (ExecType is not null) writer.WriteString(150, ExecType);
			if (ExecTypeReason is not null) writer.WriteWholeNumber(2431, ExecTypeReason.Value);
			if (OrdStatus is not null) writer.WriteString(39, OrdStatus);
			if (WorkingIndicator is not null) writer.WriteBoolean(636, WorkingIndicator.Value);
			if (CurrentWorkingPrice is not null) writer.WriteNumber(2838, CurrentWorkingPrice.Value);
			if (OrdRejReason is not null) writer.WriteWholeNumber(103, OrdRejReason.Value);
			if (RejectText is not null) writer.WriteString(1328, RejectText);
			if (EncodedRejectTextLen is not null) writer.WriteWholeNumber(1664, EncodedRejectTextLen.Value);
			if (EncodedRejectText is not null) writer.WriteBuffer(1665, EncodedRejectText);
			if (ExecRestatementReason is not null) writer.WriteWholeNumber(378, ExecRestatementReason.Value);
			if (AnonymousTradeIndicator is not null) writer.WriteBoolean(2961, AnonymousTradeIndicator.Value);
			if (AlgorithmicTradeIndicator is not null) writer.WriteWholeNumber(2667, AlgorithmicTradeIndicator.Value);
			if (TrdType is not null) writer.WriteWholeNumber(828, TrdType.Value);
			if (TrdSubType is not null) writer.WriteWholeNumber(829, TrdSubType.Value);
			if (SecondaryTrdType is not null) writer.WriteWholeNumber(855, SecondaryTrdType.Value);
			if (RegulatoryTransactionType is not null) writer.WriteWholeNumber(2347, RegulatoryTransactionType.Value);
			if (RegulatoryTradeIDGrp is not null) ((IFixEncoder)RegulatoryTradeIDGrp).Encode(writer);
			if (PreviouslyReported is not null) writer.WriteBoolean(570, PreviouslyReported.Value);
			if (TradeReportingIndicator is not null) writer.WriteWholeNumber(2524, TradeReportingIndicator.Value);
			if (Account is not null) writer.WriteString(1, Account);
			if (AcctIDSource is not null) writer.WriteWholeNumber(660, AcctIDSource.Value);
			if (AccountType is not null) writer.WriteWholeNumber(581, AccountType.Value);
			if (DayBookingInst is not null) writer.WriteString(589, DayBookingInst);
			if (BookingUnit is not null) writer.WriteString(590, BookingUnit);
			if (PreallocMethod is not null) writer.WriteString(591, PreallocMethod);
			if (AllocID is not null) writer.WriteString(70, AllocID);
			if (PreAllocGrp is not null) ((IFixEncoder)PreAllocGrp).Encode(writer);
			if (SettlType is not null) writer.WriteString(63, SettlType);
			if (SettlDate is not null) writer.WriteLocalDateOnly(64, SettlDate.Value);
			if (MatchType is not null) writer.WriteString(574, MatchType);
			if (OrderCategory is not null) writer.WriteString(1115, OrderCategory);
			if (CashMargin is not null) writer.WriteString(544, CashMargin);
			if (ClearingFeeIndicator is not null) writer.WriteString(635, ClearingFeeIndicator);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (FinancingDetails is not null) ((IFixEncoder)FinancingDetails).Encode(writer);
			if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
			if (PaymentGrp is not null) ((IFixEncoder)PaymentGrp).Encode(writer);
			if (Side is not null) writer.WriteString(54, Side);
			if (ShortMarkingExemptIndicator is not null) writer.WriteBoolean(2102, ShortMarkingExemptIndicator.Value);
			if (ShortSaleExemptionReason is not null) writer.WriteWholeNumber(1688, ShortSaleExemptionReason.Value);
			if (Stipulations is not null) ((IFixEncoder)Stipulations).Encode(writer);
			if (QtyType is not null) writer.WriteWholeNumber(854, QtyType.Value);
			if (OrderQtyData is not null) ((IFixEncoder)OrderQtyData).Encode(writer);
			if (LotType is not null) writer.WriteString(1093, LotType);
			if (OrdType is not null) writer.WriteString(40, OrdType);
			if (PriceType is not null) writer.WriteWholeNumber(423, PriceType.Value);
			if (PriceQualifierGrp is not null) ((IFixEncoder)PriceQualifierGrp).Encode(writer);
			if (Price is not null) writer.WriteNumber(44, Price.Value);
			if (PriceProtectionScope is not null) writer.WriteString(1092, PriceProtectionScope);
			if (StopPx is not null) writer.WriteNumber(99, StopPx.Value);
			if (TriggeringInstruction is not null) ((IFixEncoder)TriggeringInstruction).Encode(writer);
			if (Triggered is not null) writer.WriteWholeNumber(1823, Triggered.Value);
			if (PegInstructions is not null) ((IFixEncoder)PegInstructions).Encode(writer);
			if (DiscretionInstructions is not null) ((IFixEncoder)DiscretionInstructions).Encode(writer);
			if (PeggedPrice is not null) writer.WriteNumber(839, PeggedPrice.Value);
			if (PeggedRefPrice is not null) writer.WriteNumber(1095, PeggedRefPrice.Value);
			if (DiscretionPrice is not null) writer.WriteNumber(845, DiscretionPrice.Value);
			if (TradePriceNegotiationMethod is not null) writer.WriteWholeNumber(1740, TradePriceNegotiationMethod.Value);
			if (UpfrontPrice is not null) writer.WriteNumber(1742, UpfrontPrice.Value);
			if (UpfrontPriceType is not null) writer.WriteWholeNumber(1741, UpfrontPriceType.Value);
			if (TargetStrategy is not null) writer.WriteWholeNumber(847, TargetStrategy.Value);
			if (StrategyParametersGrp is not null) ((IFixEncoder)StrategyParametersGrp).Encode(writer);
			if (TargetStrategyParameters is not null) writer.WriteString(848, TargetStrategyParameters);
			if (ParticipationRate is not null) writer.WriteNumber(849, ParticipationRate.Value);
			if (TargetStrategyPerformance is not null) writer.WriteNumber(850, TargetStrategyPerformance.Value);
			if (Currency is not null) writer.WriteString(15, Currency);
			if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
			if (ComplianceID is not null) writer.WriteString(376, ComplianceID);
			if (ComplianceText is not null) writer.WriteString(2404, ComplianceText);
			if (EncodedComplianceTextLen is not null) writer.WriteWholeNumber(2351, EncodedComplianceTextLen.Value);
			if (EncodedComplianceText is not null) writer.WriteBuffer(2352, EncodedComplianceText);
			if (SolicitedFlag is not null) writer.WriteBoolean(377, SolicitedFlag.Value);
			if (TimeInForce is not null) writer.WriteString(59, TimeInForce);
			if (EffectiveTime is not null) writer.WriteUtcTimeStamp(168, EffectiveTime.Value);
			if (ExpireDate is not null) writer.WriteLocalDateOnly(432, ExpireDate.Value);
			if (ExpireTime is not null) writer.WriteUtcTimeStamp(126, ExpireTime.Value);
			if (ExposureDuration is not null) writer.WriteWholeNumber(1629, ExposureDuration.Value);
			if (ExposureDurationUnit is not null) writer.WriteWholeNumber(1916, ExposureDurationUnit.Value);
			if (ExecInst is not null) writer.WriteString(18, ExecInst);
			if (AuctionInstruction is not null) writer.WriteWholeNumber(1805, AuctionInstruction.Value);
			if (AggressorIndicator is not null) writer.WriteBoolean(1057, AggressorIndicator.Value);
			if (OrderCapacity is not null) writer.WriteString(528, OrderCapacity);
			if (OrderRestrictions is not null) writer.WriteString(529, OrderRestrictions);
			if (TradingCapacity is not null) writer.WriteWholeNumber(1815, TradingCapacity.Value);
			if (RegulatoryReportType is not null) writer.WriteWholeNumber(1934, RegulatoryReportType.Value);
			if (PreTradeAnonymity is not null) writer.WriteBoolean(1091, PreTradeAnonymity.Value);
			if (TradePublishIndicator is not null) writer.WriteWholeNumber(1390, TradePublishIndicator.Value);
			if (CustOrderCapacity is not null) writer.WriteWholeNumber(582, CustOrderCapacity.Value);
			if (OrderAttributeGrp is not null) ((IFixEncoder)OrderAttributeGrp).Encode(writer);
			if (LastQty is not null) writer.WriteNumber(32, LastQty.Value);
			if (CalculatedCcyLastQty is not null) writer.WriteNumber(1056, CalculatedCcyLastQty.Value);
			if (LastSwapPoints is not null) writer.WriteNumber(1071, LastSwapPoints.Value);
			if (UnderlyingLastQty is not null) writer.WriteNumber(652, UnderlyingLastQty.Value);
			if (LastQtyVariance is not null) writer.WriteNumber(1828, LastQtyVariance.Value);
			if (LastPx is not null) writer.WriteNumber(31, LastPx.Value);
			if (UnderlyingLastPx is not null) writer.WriteNumber(651, UnderlyingLastPx.Value);
			if (LastParPx is not null) writer.WriteNumber(669, LastParPx.Value);
			if (MidPx is not null) writer.WriteNumber(631, MidPx.Value);
			if (LastSpotRate is not null) writer.WriteNumber(194, LastSpotRate.Value);
			if (LastForwardPoints is not null) writer.WriteNumber(195, LastForwardPoints.Value);
			if (LastUpfrontPrice is not null) writer.WriteNumber(1743, LastUpfrontPrice.Value);
			if (ReportingPx is not null) writer.WriteNumber(2750, ReportingPx.Value);
			if (ReportingQty is not null) writer.WriteNumber(2751, ReportingQty.Value);
			if (LastMkt is not null) writer.WriteString(30, LastMkt);
			if (VenueType is not null) writer.WriteString(1430, VenueType);
			if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
			if (ExDestination is not null) writer.WriteString(100, ExDestination);
			if (ExDestinationIDSource is not null) writer.WriteString(1133, ExDestinationIDSource);
			if (ExDestinationType is not null) writer.WriteWholeNumber(2704, ExDestinationType.Value);
			if (TradingSessionID is not null) writer.WriteString(336, TradingSessionID);
			if (TradingSessionSubID is not null) writer.WriteString(625, TradingSessionSubID);
			if (TimeBracket is not null) writer.WriteString(943, TimeBracket);
			if (LastCapacity is not null) writer.WriteString(29, LastCapacity);
			if (LimitAmts is not null) ((IFixEncoder)LimitAmts).Encode(writer);
			if (LeavesQty is not null) writer.WriteNumber(151, LeavesQty.Value);
			if (CumQty is not null) writer.WriteNumber(14, CumQty.Value);
			if (CxlQty is not null) writer.WriteNumber(84, CxlQty.Value);
			if (AvgPx is not null) writer.WriteNumber(6, AvgPx.Value);
			if (DayOrderQty is not null) writer.WriteNumber(424, DayOrderQty.Value);
			if (DayCumQty is not null) writer.WriteNumber(425, DayCumQty.Value);
			if (DayAvgPx is not null) writer.WriteNumber(426, DayAvgPx.Value);
			if (TotNoFills is not null) writer.WriteWholeNumber(1361, TotNoFills.Value);
			if (LastFragment is not null) writer.WriteBoolean(893, LastFragment.Value);
			if (FillsGrp is not null) ((IFixEncoder)FillsGrp).Encode(writer);
			if (OrderEventGrp is not null) ((IFixEncoder)OrderEventGrp).Encode(writer);
			if (EventInitiatorType is not null) writer.WriteString(2830, EventInitiatorType);
			if (GTBookingInst is not null) writer.WriteWholeNumber(427, GTBookingInst.Value);
			if (TradeDate is not null) writer.WriteLocalDateOnly(75, TradeDate.Value);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (ReportToExch is not null) writer.WriteBoolean(113, ReportToExch.Value);
			if (CommissionData is not null) ((IFixEncoder)CommissionData).Encode(writer);
			if (CommissionDataGrp is not null) ((IFixEncoder)CommissionDataGrp).Encode(writer);
			if (SpreadOrBenchmarkCurveData is not null) ((IFixEncoder)SpreadOrBenchmarkCurveData).Encode(writer);
			if (RelativeValueGrp is not null) ((IFixEncoder)RelativeValueGrp).Encode(writer);
			if (YieldData is not null) ((IFixEncoder)YieldData).Encode(writer);
			if (GrossTradeAmt is not null) writer.WriteNumber(381, GrossTradeAmt.Value);
			if (NumDaysInterest is not null) writer.WriteWholeNumber(157, NumDaysInterest.Value);
			if (ExDate is not null) writer.WriteLocalDateOnly(230, ExDate.Value);
			if (AccruedInterestRate is not null) writer.WriteNumber(158, AccruedInterestRate.Value);
			if (AccruedInterestAmt is not null) writer.WriteNumber(159, AccruedInterestAmt.Value);
			if (InterestAtMaturity is not null) writer.WriteNumber(738, InterestAtMaturity.Value);
			if (EndAccruedInterestAmt is not null) writer.WriteNumber(920, EndAccruedInterestAmt.Value);
			if (StartCash is not null) writer.WriteNumber(921, StartCash.Value);
			if (EndCash is not null) writer.WriteNumber(922, EndCash.Value);
			if (TradedFlatSwitch is not null) writer.WriteBoolean(258, TradedFlatSwitch.Value);
			if (BasisFeatureDate is not null) writer.WriteLocalDateOnly(259, BasisFeatureDate.Value);
			if (BasisFeaturePrice is not null) writer.WriteNumber(260, BasisFeaturePrice.Value);
			if (Concession is not null) writer.WriteNumber(238, Concession.Value);
			if (TotalTakedown is not null) writer.WriteNumber(237, TotalTakedown.Value);
			if (NetMoney is not null) writer.WriteNumber(118, NetMoney.Value);
			if (SettlCurrAmt is not null) writer.WriteNumber(119, SettlCurrAmt.Value);
			if (SettlCurrency is not null) writer.WriteString(120, SettlCurrency);
			if (SettlCurrencyCodeSource is not null) writer.WriteString(2899, SettlCurrencyCodeSource);
			if (RateSource is not null) ((IFixEncoder)RateSource).Encode(writer);
			if (OffshoreIndicator is not null) writer.WriteWholeNumber(2795, OffshoreIndicator.Value);
			if (SettlCurrFxRate is not null) writer.WriteNumber(155, SettlCurrFxRate.Value);
			if (SettlCurrFxRateCalc is not null) writer.WriteString(156, SettlCurrFxRateCalc);
			if (HandlInst is not null) writer.WriteString(21, HandlInst);
			if (MinQty is not null) writer.WriteNumber(110, MinQty.Value);
			if (MinQtyMethod is not null) writer.WriteWholeNumber(1822, MinQtyMethod.Value);
			if (MatchIncrement is not null) writer.WriteNumber(1089, MatchIncrement.Value);
			if (MaxPriceLevels is not null) writer.WriteWholeNumber(1090, MaxPriceLevels.Value);
			if (MaximumPriceDeviation is not null) writer.WriteNumber(2676, MaximumPriceDeviation.Value);
			if (ValueChecksGrp is not null) ((IFixEncoder)ValueChecksGrp).Encode(writer);
			if (MatchingInstructions is not null) ((IFixEncoder)MatchingInstructions).Encode(writer);
			if (SelfMatchPreventionID is not null) writer.WriteString(2362, SelfMatchPreventionID);
			if (SelfMatchPreventionInstruction is not null) writer.WriteWholeNumber(2964, SelfMatchPreventionInstruction.Value);
			if (CrossedIndicator is not null) writer.WriteWholeNumber(2523, CrossedIndicator.Value);
			if (DisplayInstruction is not null) ((IFixEncoder)DisplayInstruction).Encode(writer);
			if (DisclosureInstructionGrp is not null) ((IFixEncoder)DisclosureInstructionGrp).Encode(writer);
			if (MaxFloor is not null) writer.WriteNumber(111, MaxFloor.Value);
			if (ClearingAccountType is not null) writer.WriteWholeNumber(1816, ClearingAccountType.Value);
			if (PositionEffect is not null) writer.WriteString(77, PositionEffect);
			if (MaxShow is not null) writer.WriteNumber(210, MaxShow.Value);
			if (BookingType is not null) writer.WriteWholeNumber(775, BookingType.Value);
			if (Text is not null) writer.WriteString(58, Text);
			if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
			if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
			if (SettlDate2 is not null) writer.WriteLocalDateOnly(193, SettlDate2.Value);
			if (OrderQty2 is not null) writer.WriteNumber(192, OrderQty2.Value);
			if (LastForwardPoints2 is not null) writer.WriteNumber(641, LastForwardPoints2.Value);
			if (MultiLegReportingType is not null) writer.WriteString(442, MultiLegReportingType);
			if (ContingencyType is not null) writer.WriteWholeNumber(1385, ContingencyType.Value);
			if (CancellationRights is not null) writer.WriteString(480, CancellationRights);
			if (MoneyLaunderingStatus is not null) writer.WriteString(481, MoneyLaunderingStatus);
			if (RegistID is not null) writer.WriteString(513, RegistID);
			if (Designation is not null) writer.WriteString(494, Designation);
			if (TransBkdTime is not null) writer.WriteUtcTimeStamp(483, TransBkdTime.Value);
			if (ExecValuationPoint is not null) writer.WriteUtcTimeStamp(515, ExecValuationPoint.Value);
			if (ExecPriceType is not null) writer.WriteString(484, ExecPriceType);
			if (ExecPriceAdjustment is not null) writer.WriteNumber(485, ExecPriceAdjustment.Value);
			if (PriorityIndicator is not null) writer.WriteWholeNumber(638, PriorityIndicator.Value);
			if (PriceImprovement is not null) writer.WriteNumber(639, PriceImprovement.Value);
			if (LastLiquidityInd is not null) writer.WriteWholeNumber(851, LastLiquidityInd.Value);
			if (ContAmtGrp is not null) ((IFixEncoder)ContAmtGrp).Encode(writer);
			if (InstrmtLegExecGrp is not null) ((IFixEncoder)InstrmtLegExecGrp).Encode(writer);
			if (CopyMsgIndicator is not null) writer.WriteBoolean(797, CopyMsgIndicator.Value);
			if (MiscFeesGrp is not null) ((IFixEncoder)MiscFeesGrp).Encode(writer);
			if (DividendYield is not null) writer.WriteNumber(1380, DividendYield.Value);
			if (ManualOrderIndicator is not null) writer.WriteBoolean(1028, ManualOrderIndicator.Value);
			if (CustDirectedOrder is not null) writer.WriteBoolean(1029, CustDirectedOrder.Value);
			if (ReceivedDeptID is not null) writer.WriteString(1030, ReceivedDeptID);
			if (CustOrderHandlingInst is not null) writer.WriteString(1031, CustOrderHandlingInst);
			if (OrderHandlingInstSource is not null) writer.WriteWholeNumber(1032, OrderHandlingInstSource.Value);
			if (OrderOrigination is not null) writer.WriteWholeNumber(1724, OrderOrigination.Value);
			if (ContraOrderOrigination is not null) writer.WriteWholeNumber(2882, ContraOrderOrigination.Value);
			if (OriginatingDeptID is not null) writer.WriteString(1725, OriginatingDeptID);
			if (ReceivingDeptID is not null) writer.WriteString(1726, ReceivingDeptID);
			if (RoutingArrangmentIndicator is not null) writer.WriteWholeNumber(2883, RoutingArrangmentIndicator.Value);
			if (ContraRoutingArrangmentIndicator is not null) writer.WriteWholeNumber(2884, ContraRoutingArrangmentIndicator.Value);
			if (AffiliatedFirmsTradeIndicator is not null) writer.WriteBoolean(2525, AffiliatedFirmsTradeIndicator.Value);
			if (OwnerType is not null) writer.WriteWholeNumber(522, OwnerType.Value);
			if (OrderOwnershipIndicator is not null) writer.WriteWholeNumber(2679, OrderOwnershipIndicator.Value);
			if (TrdRegTimestamps is not null) ((IFixEncoder)TrdRegTimestamps).Encode(writer);
			if (TrdRegPublicationGrp is not null) ((IFixEncoder)TrdRegPublicationGrp).Encode(writer);
			if (TradePriceConditionGrp is not null) ((IFixEncoder)TradePriceConditionGrp).Encode(writer);
			if (TradeContinuation is not null) writer.WriteWholeNumber(1937, TradeContinuation.Value);
			if (TradeContinuationText is not null) writer.WriteString(2374, TradeContinuationText);
			if (EncodedTradeContinuationTextLen is not null) writer.WriteWholeNumber(2372, EncodedTradeContinuationTextLen.Value);
			if (EncodedTradeContinuationText is not null) writer.WriteBuffer(2371, EncodedTradeContinuationText);
			if (Volatility is not null) writer.WriteNumber(1188, Volatility.Value);
			if (TimeToExpiration is not null) writer.WriteNumber(1189, TimeToExpiration.Value);
			if (RiskFreeRate is not null) writer.WriteNumber(1190, RiskFreeRate.Value);
			if (PriceDelta is not null) writer.WriteNumber(811, PriceDelta.Value);
			if (CoverPrice is not null) writer.WriteNumber(1917, CoverPrice.Value);
			if (ThrottleResponse is not null) ((IFixEncoder)ThrottleResponse).Encode(writer);
			if (RefOrderID is not null) writer.WriteString(1080, RefOrderID);
			if (RefOrderIDSource is not null) writer.WriteString(1081, RefOrderIDSource);
			if (RefClOrdID is not null) writer.WriteString(1806, RefClOrdID);
			if (RelatedOrderGrp is not null) ((IFixEncoder)RelatedOrderGrp).Encode(writer);
			if (AuctionType is not null) writer.WriteWholeNumber(1803, AuctionType.Value);
			if (AuctionAllocationPct is not null) writer.WriteNumber(1804, AuctionAllocationPct.Value);
			if (LockedQty is not null) writer.WriteNumber(1808, LockedQty.Value);
			if (SecondaryLockedQty is not null) writer.WriteNumber(1809, SecondaryLockedQty.Value);
			if (LockType is not null) writer.WriteWholeNumber(1807, LockType.Value);
			if (ReleaseInstruction is not null) writer.WriteWholeNumber(1810, ReleaseInstruction.Value);
			if (ReleaseQty is not null) writer.WriteNumber(1811, ReleaseQty.Value);
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
			if (view.GetView("ApplicationSequenceControl") is IMessageView viewApplicationSequenceControl)
			{
				ApplicationSequenceControl = new();
				((IFixParser)ApplicationSequenceControl).Parse(viewApplicationSequenceControl);
			}
			OrderID = view.GetString(37);
			OrderRequestID = view.GetInt32(2422);
			MassOrderRequestID = view.GetString(2423);
			SecondaryOrderID = view.GetString(198);
			SecondaryClOrdID = view.GetString(526);
			SecondaryExecID = view.GetString(527);
			ClOrdID = view.GetString(11);
			QuoteMsgID = view.GetString(1166);
			OrigClOrdID = view.GetString(41);
			ClOrdLinkID = view.GetString(583);
			MDEntryID = view.GetString(278);
			QuoteRespID = view.GetString(693);
			OrdStatusReqID = view.GetString(790);
			MassStatusReqID = view.GetString(584);
			HostCrossID = view.GetString(961);
			TotNumReports = view.GetInt32(911);
			LastRptRequested = view.GetBool(912);
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
			if (view.GetView("ContraGrp") is IMessageView viewContraGrp)
			{
				ContraGrp = new();
				((IFixParser)ContraGrp).Parse(viewContraGrp);
			}
			ListID = view.GetString(66);
			CrossID = view.GetString(548);
			OrigCrossID = view.GetString(551);
			CrossType = view.GetInt32(549);
			RefRiskLimitCheckID = view.GetString(2334);
			RefRiskLimitCheckIDType = view.GetInt32(2335);
			TrdMatchID = view.GetString(880);
			TrdMatchSubID = view.GetString(1891);
			ExecID = view.GetString(17);
			ExecRefID = view.GetString(19);
			ExecType = view.GetString(150);
			ExecTypeReason = view.GetInt32(2431);
			OrdStatus = view.GetString(39);
			WorkingIndicator = view.GetBool(636);
			CurrentWorkingPrice = view.GetDouble(2838);
			OrdRejReason = view.GetInt32(103);
			RejectText = view.GetString(1328);
			EncodedRejectTextLen = view.GetInt32(1664);
			EncodedRejectText = view.GetByteArray(1665);
			ExecRestatementReason = view.GetInt32(378);
			AnonymousTradeIndicator = view.GetBool(2961);
			AlgorithmicTradeIndicator = view.GetInt32(2667);
			TrdType = view.GetInt32(828);
			TrdSubType = view.GetInt32(829);
			SecondaryTrdType = view.GetInt32(855);
			RegulatoryTransactionType = view.GetInt32(2347);
			if (view.GetView("RegulatoryTradeIDGrp") is IMessageView viewRegulatoryTradeIDGrp)
			{
				RegulatoryTradeIDGrp = new();
				((IFixParser)RegulatoryTradeIDGrp).Parse(viewRegulatoryTradeIDGrp);
			}
			PreviouslyReported = view.GetBool(570);
			TradeReportingIndicator = view.GetInt32(2524);
			Account = view.GetString(1);
			AcctIDSource = view.GetInt32(660);
			AccountType = view.GetInt32(581);
			DayBookingInst = view.GetString(589);
			BookingUnit = view.GetString(590);
			PreallocMethod = view.GetString(591);
			AllocID = view.GetString(70);
			if (view.GetView("PreAllocGrp") is IMessageView viewPreAllocGrp)
			{
				PreAllocGrp = new();
				((IFixParser)PreAllocGrp).Parse(viewPreAllocGrp);
			}
			SettlType = view.GetString(63);
			SettlDate = view.GetDateOnly(64);
			MatchType = view.GetString(574);
			OrderCategory = view.GetString(1115);
			CashMargin = view.GetString(544);
			ClearingFeeIndicator = view.GetString(635);
			if (view.GetView("Instrument") is IMessageView viewInstrument)
			{
				Instrument = new();
				((IFixParser)Instrument).Parse(viewInstrument);
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
			if (view.GetView("PaymentGrp") is IMessageView viewPaymentGrp)
			{
				PaymentGrp = new();
				((IFixParser)PaymentGrp).Parse(viewPaymentGrp);
			}
			Side = view.GetString(54);
			ShortMarkingExemptIndicator = view.GetBool(2102);
			ShortSaleExemptionReason = view.GetInt32(1688);
			if (view.GetView("Stipulations") is IMessageView viewStipulations)
			{
				Stipulations = new();
				((IFixParser)Stipulations).Parse(viewStipulations);
			}
			QtyType = view.GetInt32(854);
			if (view.GetView("OrderQtyData") is IMessageView viewOrderQtyData)
			{
				OrderQtyData = new();
				((IFixParser)OrderQtyData).Parse(viewOrderQtyData);
			}
			LotType = view.GetString(1093);
			OrdType = view.GetString(40);
			PriceType = view.GetInt32(423);
			if (view.GetView("PriceQualifierGrp") is IMessageView viewPriceQualifierGrp)
			{
				PriceQualifierGrp = new();
				((IFixParser)PriceQualifierGrp).Parse(viewPriceQualifierGrp);
			}
			Price = view.GetDouble(44);
			PriceProtectionScope = view.GetString(1092);
			StopPx = view.GetDouble(99);
			if (view.GetView("TriggeringInstruction") is IMessageView viewTriggeringInstruction)
			{
				TriggeringInstruction = new();
				((IFixParser)TriggeringInstruction).Parse(viewTriggeringInstruction);
			}
			Triggered = view.GetInt32(1823);
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
			PeggedPrice = view.GetDouble(839);
			PeggedRefPrice = view.GetDouble(1095);
			DiscretionPrice = view.GetDouble(845);
			TradePriceNegotiationMethod = view.GetInt32(1740);
			UpfrontPrice = view.GetDouble(1742);
			UpfrontPriceType = view.GetInt32(1741);
			TargetStrategy = view.GetInt32(847);
			if (view.GetView("StrategyParametersGrp") is IMessageView viewStrategyParametersGrp)
			{
				StrategyParametersGrp = new();
				((IFixParser)StrategyParametersGrp).Parse(viewStrategyParametersGrp);
			}
			TargetStrategyParameters = view.GetString(848);
			ParticipationRate = view.GetDouble(849);
			TargetStrategyPerformance = view.GetDouble(850);
			Currency = view.GetString(15);
			CurrencyCodeSource = view.GetString(2897);
			ComplianceID = view.GetString(376);
			ComplianceText = view.GetString(2404);
			EncodedComplianceTextLen = view.GetInt32(2351);
			EncodedComplianceText = view.GetByteArray(2352);
			SolicitedFlag = view.GetBool(377);
			TimeInForce = view.GetString(59);
			EffectiveTime = view.GetDateTime(168);
			ExpireDate = view.GetDateOnly(432);
			ExpireTime = view.GetDateTime(126);
			ExposureDuration = view.GetInt32(1629);
			ExposureDurationUnit = view.GetInt32(1916);
			ExecInst = view.GetString(18);
			AuctionInstruction = view.GetInt32(1805);
			AggressorIndicator = view.GetBool(1057);
			OrderCapacity = view.GetString(528);
			OrderRestrictions = view.GetString(529);
			TradingCapacity = view.GetInt32(1815);
			RegulatoryReportType = view.GetInt32(1934);
			PreTradeAnonymity = view.GetBool(1091);
			TradePublishIndicator = view.GetInt32(1390);
			CustOrderCapacity = view.GetInt32(582);
			if (view.GetView("OrderAttributeGrp") is IMessageView viewOrderAttributeGrp)
			{
				OrderAttributeGrp = new();
				((IFixParser)OrderAttributeGrp).Parse(viewOrderAttributeGrp);
			}
			LastQty = view.GetDouble(32);
			CalculatedCcyLastQty = view.GetDouble(1056);
			LastSwapPoints = view.GetDouble(1071);
			UnderlyingLastQty = view.GetDouble(652);
			LastQtyVariance = view.GetDouble(1828);
			LastPx = view.GetDouble(31);
			UnderlyingLastPx = view.GetDouble(651);
			LastParPx = view.GetDouble(669);
			MidPx = view.GetDouble(631);
			LastSpotRate = view.GetDouble(194);
			LastForwardPoints = view.GetDouble(195);
			LastUpfrontPrice = view.GetDouble(1743);
			ReportingPx = view.GetDouble(2750);
			ReportingQty = view.GetDouble(2751);
			LastMkt = view.GetString(30);
			VenueType = view.GetString(1430);
			MarketSegmentID = view.GetString(1300);
			ExDestination = view.GetString(100);
			ExDestinationIDSource = view.GetString(1133);
			ExDestinationType = view.GetInt32(2704);
			TradingSessionID = view.GetString(336);
			TradingSessionSubID = view.GetString(625);
			TimeBracket = view.GetString(943);
			LastCapacity = view.GetString(29);
			if (view.GetView("LimitAmts") is IMessageView viewLimitAmts)
			{
				LimitAmts = new();
				((IFixParser)LimitAmts).Parse(viewLimitAmts);
			}
			LeavesQty = view.GetDouble(151);
			CumQty = view.GetDouble(14);
			CxlQty = view.GetDouble(84);
			AvgPx = view.GetDouble(6);
			DayOrderQty = view.GetDouble(424);
			DayCumQty = view.GetDouble(425);
			DayAvgPx = view.GetDouble(426);
			TotNoFills = view.GetInt32(1361);
			LastFragment = view.GetBool(893);
			if (view.GetView("FillsGrp") is IMessageView viewFillsGrp)
			{
				FillsGrp = new();
				((IFixParser)FillsGrp).Parse(viewFillsGrp);
			}
			if (view.GetView("OrderEventGrp") is IMessageView viewOrderEventGrp)
			{
				OrderEventGrp = new();
				((IFixParser)OrderEventGrp).Parse(viewOrderEventGrp);
			}
			EventInitiatorType = view.GetString(2830);
			GTBookingInst = view.GetInt32(427);
			TradeDate = view.GetDateOnly(75);
			TransactTime = view.GetDateTime(60);
			ReportToExch = view.GetBool(113);
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
			if (view.GetView("SpreadOrBenchmarkCurveData") is IMessageView viewSpreadOrBenchmarkCurveData)
			{
				SpreadOrBenchmarkCurveData = new();
				((IFixParser)SpreadOrBenchmarkCurveData).Parse(viewSpreadOrBenchmarkCurveData);
			}
			if (view.GetView("RelativeValueGrp") is IMessageView viewRelativeValueGrp)
			{
				RelativeValueGrp = new();
				((IFixParser)RelativeValueGrp).Parse(viewRelativeValueGrp);
			}
			if (view.GetView("YieldData") is IMessageView viewYieldData)
			{
				YieldData = new();
				((IFixParser)YieldData).Parse(viewYieldData);
			}
			GrossTradeAmt = view.GetDouble(381);
			NumDaysInterest = view.GetInt32(157);
			ExDate = view.GetDateOnly(230);
			AccruedInterestRate = view.GetDouble(158);
			AccruedInterestAmt = view.GetDouble(159);
			InterestAtMaturity = view.GetDouble(738);
			EndAccruedInterestAmt = view.GetDouble(920);
			StartCash = view.GetDouble(921);
			EndCash = view.GetDouble(922);
			TradedFlatSwitch = view.GetBool(258);
			BasisFeatureDate = view.GetDateOnly(259);
			BasisFeaturePrice = view.GetDouble(260);
			Concession = view.GetDouble(238);
			TotalTakedown = view.GetDouble(237);
			NetMoney = view.GetDouble(118);
			SettlCurrAmt = view.GetDouble(119);
			SettlCurrency = view.GetString(120);
			SettlCurrencyCodeSource = view.GetString(2899);
			if (view.GetView("RateSource") is IMessageView viewRateSource)
			{
				RateSource = new();
				((IFixParser)RateSource).Parse(viewRateSource);
			}
			OffshoreIndicator = view.GetInt32(2795);
			SettlCurrFxRate = view.GetDouble(155);
			SettlCurrFxRateCalc = view.GetString(156);
			HandlInst = view.GetString(21);
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
			CrossedIndicator = view.GetInt32(2523);
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
			ClearingAccountType = view.GetInt32(1816);
			PositionEffect = view.GetString(77);
			MaxShow = view.GetDouble(210);
			BookingType = view.GetInt32(775);
			Text = view.GetString(58);
			EncodedTextLen = view.GetInt32(354);
			EncodedText = view.GetByteArray(355);
			SettlDate2 = view.GetDateOnly(193);
			OrderQty2 = view.GetDouble(192);
			LastForwardPoints2 = view.GetDouble(641);
			MultiLegReportingType = view.GetString(442);
			ContingencyType = view.GetInt32(1385);
			CancellationRights = view.GetString(480);
			MoneyLaunderingStatus = view.GetString(481);
			RegistID = view.GetString(513);
			Designation = view.GetString(494);
			TransBkdTime = view.GetDateTime(483);
			ExecValuationPoint = view.GetDateTime(515);
			ExecPriceType = view.GetString(484);
			ExecPriceAdjustment = view.GetDouble(485);
			PriorityIndicator = view.GetInt32(638);
			PriceImprovement = view.GetDouble(639);
			LastLiquidityInd = view.GetInt32(851);
			if (view.GetView("ContAmtGrp") is IMessageView viewContAmtGrp)
			{
				ContAmtGrp = new();
				((IFixParser)ContAmtGrp).Parse(viewContAmtGrp);
			}
			if (view.GetView("InstrmtLegExecGrp") is IMessageView viewInstrmtLegExecGrp)
			{
				InstrmtLegExecGrp = new();
				((IFixParser)InstrmtLegExecGrp).Parse(viewInstrmtLegExecGrp);
			}
			CopyMsgIndicator = view.GetBool(797);
			if (view.GetView("MiscFeesGrp") is IMessageView viewMiscFeesGrp)
			{
				MiscFeesGrp = new();
				((IFixParser)MiscFeesGrp).Parse(viewMiscFeesGrp);
			}
			DividendYield = view.GetDouble(1380);
			ManualOrderIndicator = view.GetBool(1028);
			CustDirectedOrder = view.GetBool(1029);
			ReceivedDeptID = view.GetString(1030);
			CustOrderHandlingInst = view.GetString(1031);
			OrderHandlingInstSource = view.GetInt32(1032);
			OrderOrigination = view.GetInt32(1724);
			ContraOrderOrigination = view.GetInt32(2882);
			OriginatingDeptID = view.GetString(1725);
			ReceivingDeptID = view.GetString(1726);
			RoutingArrangmentIndicator = view.GetInt32(2883);
			ContraRoutingArrangmentIndicator = view.GetInt32(2884);
			AffiliatedFirmsTradeIndicator = view.GetBool(2525);
			OwnerType = view.GetInt32(522);
			OrderOwnershipIndicator = view.GetInt32(2679);
			if (view.GetView("TrdRegTimestamps") is IMessageView viewTrdRegTimestamps)
			{
				TrdRegTimestamps = new();
				((IFixParser)TrdRegTimestamps).Parse(viewTrdRegTimestamps);
			}
			if (view.GetView("TrdRegPublicationGrp") is IMessageView viewTrdRegPublicationGrp)
			{
				TrdRegPublicationGrp = new();
				((IFixParser)TrdRegPublicationGrp).Parse(viewTrdRegPublicationGrp);
			}
			if (view.GetView("TradePriceConditionGrp") is IMessageView viewTradePriceConditionGrp)
			{
				TradePriceConditionGrp = new();
				((IFixParser)TradePriceConditionGrp).Parse(viewTradePriceConditionGrp);
			}
			TradeContinuation = view.GetInt32(1937);
			TradeContinuationText = view.GetString(2374);
			EncodedTradeContinuationTextLen = view.GetInt32(2372);
			EncodedTradeContinuationText = view.GetByteArray(2371);
			Volatility = view.GetDouble(1188);
			TimeToExpiration = view.GetDouble(1189);
			RiskFreeRate = view.GetDouble(1190);
			PriceDelta = view.GetDouble(811);
			CoverPrice = view.GetDouble(1917);
			if (view.GetView("ThrottleResponse") is IMessageView viewThrottleResponse)
			{
				ThrottleResponse = new();
				((IFixParser)ThrottleResponse).Parse(viewThrottleResponse);
			}
			RefOrderID = view.GetString(1080);
			RefOrderIDSource = view.GetString(1081);
			RefClOrdID = view.GetString(1806);
			if (view.GetView("RelatedOrderGrp") is IMessageView viewRelatedOrderGrp)
			{
				RelatedOrderGrp = new();
				((IFixParser)RelatedOrderGrp).Parse(viewRelatedOrderGrp);
			}
			AuctionType = view.GetInt32(1803);
			AuctionAllocationPct = view.GetDouble(1804);
			LockedQty = view.GetDouble(1808);
			SecondaryLockedQty = view.GetDouble(1809);
			LockType = view.GetInt32(1807);
			ReleaseInstruction = view.GetInt32(1810);
			ReleaseQty = view.GetDouble(1811);
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
				case "ApplicationSequenceControl":
				{
					value = ApplicationSequenceControl;
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
				case "MassOrderRequestID":
				{
					value = MassOrderRequestID;
					break;
				}
				case "SecondaryOrderID":
				{
					value = SecondaryOrderID;
					break;
				}
				case "SecondaryClOrdID":
				{
					value = SecondaryClOrdID;
					break;
				}
				case "SecondaryExecID":
				{
					value = SecondaryExecID;
					break;
				}
				case "ClOrdID":
				{
					value = ClOrdID;
					break;
				}
				case "QuoteMsgID":
				{
					value = QuoteMsgID;
					break;
				}
				case "OrigClOrdID":
				{
					value = OrigClOrdID;
					break;
				}
				case "ClOrdLinkID":
				{
					value = ClOrdLinkID;
					break;
				}
				case "MDEntryID":
				{
					value = MDEntryID;
					break;
				}
				case "QuoteRespID":
				{
					value = QuoteRespID;
					break;
				}
				case "OrdStatusReqID":
				{
					value = OrdStatusReqID;
					break;
				}
				case "MassStatusReqID":
				{
					value = MassStatusReqID;
					break;
				}
				case "HostCrossID":
				{
					value = HostCrossID;
					break;
				}
				case "TotNumReports":
				{
					value = TotNumReports;
					break;
				}
				case "LastRptRequested":
				{
					value = LastRptRequested;
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
				case "ContraGrp":
				{
					value = ContraGrp;
					break;
				}
				case "ListID":
				{
					value = ListID;
					break;
				}
				case "CrossID":
				{
					value = CrossID;
					break;
				}
				case "OrigCrossID":
				{
					value = OrigCrossID;
					break;
				}
				case "CrossType":
				{
					value = CrossType;
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
				case "TrdMatchID":
				{
					value = TrdMatchID;
					break;
				}
				case "TrdMatchSubID":
				{
					value = TrdMatchSubID;
					break;
				}
				case "ExecID":
				{
					value = ExecID;
					break;
				}
				case "ExecRefID":
				{
					value = ExecRefID;
					break;
				}
				case "ExecType":
				{
					value = ExecType;
					break;
				}
				case "ExecTypeReason":
				{
					value = ExecTypeReason;
					break;
				}
				case "OrdStatus":
				{
					value = OrdStatus;
					break;
				}
				case "WorkingIndicator":
				{
					value = WorkingIndicator;
					break;
				}
				case "CurrentWorkingPrice":
				{
					value = CurrentWorkingPrice;
					break;
				}
				case "OrdRejReason":
				{
					value = OrdRejReason;
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
				case "ExecRestatementReason":
				{
					value = ExecRestatementReason;
					break;
				}
				case "AnonymousTradeIndicator":
				{
					value = AnonymousTradeIndicator;
					break;
				}
				case "AlgorithmicTradeIndicator":
				{
					value = AlgorithmicTradeIndicator;
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
				case "RegulatoryTransactionType":
				{
					value = RegulatoryTransactionType;
					break;
				}
				case "RegulatoryTradeIDGrp":
				{
					value = RegulatoryTradeIDGrp;
					break;
				}
				case "PreviouslyReported":
				{
					value = PreviouslyReported;
					break;
				}
				case "TradeReportingIndicator":
				{
					value = TradeReportingIndicator;
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
				case "PreAllocGrp":
				{
					value = PreAllocGrp;
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
				case "MatchType":
				{
					value = MatchType;
					break;
				}
				case "OrderCategory":
				{
					value = OrderCategory;
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
				case "Instrument":
				{
					value = Instrument;
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
				case "PaymentGrp":
				{
					value = PaymentGrp;
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
				case "ShortSaleExemptionReason":
				{
					value = ShortSaleExemptionReason;
					break;
				}
				case "Stipulations":
				{
					value = Stipulations;
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
				case "LotType":
				{
					value = LotType;
					break;
				}
				case "OrdType":
				{
					value = OrdType;
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
				case "Triggered":
				{
					value = Triggered;
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
				case "PeggedPrice":
				{
					value = PeggedPrice;
					break;
				}
				case "PeggedRefPrice":
				{
					value = PeggedRefPrice;
					break;
				}
				case "DiscretionPrice":
				{
					value = DiscretionPrice;
					break;
				}
				case "TradePriceNegotiationMethod":
				{
					value = TradePriceNegotiationMethod;
					break;
				}
				case "UpfrontPrice":
				{
					value = UpfrontPrice;
					break;
				}
				case "UpfrontPriceType":
				{
					value = UpfrontPriceType;
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
				case "ParticipationRate":
				{
					value = ParticipationRate;
					break;
				}
				case "TargetStrategyPerformance":
				{
					value = TargetStrategyPerformance;
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
				case "AggressorIndicator":
				{
					value = AggressorIndicator;
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
				case "RegulatoryReportType":
				{
					value = RegulatoryReportType;
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
				case "OrderAttributeGrp":
				{
					value = OrderAttributeGrp;
					break;
				}
				case "LastQty":
				{
					value = LastQty;
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
				case "UnderlyingLastQty":
				{
					value = UnderlyingLastQty;
					break;
				}
				case "LastQtyVariance":
				{
					value = LastQtyVariance;
					break;
				}
				case "LastPx":
				{
					value = LastPx;
					break;
				}
				case "UnderlyingLastPx":
				{
					value = UnderlyingLastPx;
					break;
				}
				case "LastParPx":
				{
					value = LastParPx;
					break;
				}
				case "MidPx":
				{
					value = MidPx;
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
				case "LastUpfrontPrice":
				{
					value = LastUpfrontPrice;
					break;
				}
				case "ReportingPx":
				{
					value = ReportingPx;
					break;
				}
				case "ReportingQty":
				{
					value = ReportingQty;
					break;
				}
				case "LastMkt":
				{
					value = LastMkt;
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
				case "TimeBracket":
				{
					value = TimeBracket;
					break;
				}
				case "LastCapacity":
				{
					value = LastCapacity;
					break;
				}
				case "LimitAmts":
				{
					value = LimitAmts;
					break;
				}
				case "LeavesQty":
				{
					value = LeavesQty;
					break;
				}
				case "CumQty":
				{
					value = CumQty;
					break;
				}
				case "CxlQty":
				{
					value = CxlQty;
					break;
				}
				case "AvgPx":
				{
					value = AvgPx;
					break;
				}
				case "DayOrderQty":
				{
					value = DayOrderQty;
					break;
				}
				case "DayCumQty":
				{
					value = DayCumQty;
					break;
				}
				case "DayAvgPx":
				{
					value = DayAvgPx;
					break;
				}
				case "TotNoFills":
				{
					value = TotNoFills;
					break;
				}
				case "LastFragment":
				{
					value = LastFragment;
					break;
				}
				case "FillsGrp":
				{
					value = FillsGrp;
					break;
				}
				case "OrderEventGrp":
				{
					value = OrderEventGrp;
					break;
				}
				case "EventInitiatorType":
				{
					value = EventInitiatorType;
					break;
				}
				case "GTBookingInst":
				{
					value = GTBookingInst;
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
				case "ReportToExch":
				{
					value = ReportToExch;
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
				case "SpreadOrBenchmarkCurveData":
				{
					value = SpreadOrBenchmarkCurveData;
					break;
				}
				case "RelativeValueGrp":
				{
					value = RelativeValueGrp;
					break;
				}
				case "YieldData":
				{
					value = YieldData;
					break;
				}
				case "GrossTradeAmt":
				{
					value = GrossTradeAmt;
					break;
				}
				case "NumDaysInterest":
				{
					value = NumDaysInterest;
					break;
				}
				case "ExDate":
				{
					value = ExDate;
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
				case "TradedFlatSwitch":
				{
					value = TradedFlatSwitch;
					break;
				}
				case "BasisFeatureDate":
				{
					value = BasisFeatureDate;
					break;
				}
				case "BasisFeaturePrice":
				{
					value = BasisFeaturePrice;
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
				case "SettlCurrAmt":
				{
					value = SettlCurrAmt;
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
				case "RateSource":
				{
					value = RateSource;
					break;
				}
				case "OffshoreIndicator":
				{
					value = OffshoreIndicator;
					break;
				}
				case "SettlCurrFxRate":
				{
					value = SettlCurrFxRate;
					break;
				}
				case "SettlCurrFxRateCalc":
				{
					value = SettlCurrFxRateCalc;
					break;
				}
				case "HandlInst":
				{
					value = HandlInst;
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
				case "CrossedIndicator":
				{
					value = CrossedIndicator;
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
				case "MaxShow":
				{
					value = MaxShow;
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
				case "SettlDate2":
				{
					value = SettlDate2;
					break;
				}
				case "OrderQty2":
				{
					value = OrderQty2;
					break;
				}
				case "LastForwardPoints2":
				{
					value = LastForwardPoints2;
					break;
				}
				case "MultiLegReportingType":
				{
					value = MultiLegReportingType;
					break;
				}
				case "ContingencyType":
				{
					value = ContingencyType;
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
				case "TransBkdTime":
				{
					value = TransBkdTime;
					break;
				}
				case "ExecValuationPoint":
				{
					value = ExecValuationPoint;
					break;
				}
				case "ExecPriceType":
				{
					value = ExecPriceType;
					break;
				}
				case "ExecPriceAdjustment":
				{
					value = ExecPriceAdjustment;
					break;
				}
				case "PriorityIndicator":
				{
					value = PriorityIndicator;
					break;
				}
				case "PriceImprovement":
				{
					value = PriceImprovement;
					break;
				}
				case "LastLiquidityInd":
				{
					value = LastLiquidityInd;
					break;
				}
				case "ContAmtGrp":
				{
					value = ContAmtGrp;
					break;
				}
				case "InstrmtLegExecGrp":
				{
					value = InstrmtLegExecGrp;
					break;
				}
				case "CopyMsgIndicator":
				{
					value = CopyMsgIndicator;
					break;
				}
				case "MiscFeesGrp":
				{
					value = MiscFeesGrp;
					break;
				}
				case "DividendYield":
				{
					value = DividendYield;
					break;
				}
				case "ManualOrderIndicator":
				{
					value = ManualOrderIndicator;
					break;
				}
				case "CustDirectedOrder":
				{
					value = CustDirectedOrder;
					break;
				}
				case "ReceivedDeptID":
				{
					value = ReceivedDeptID;
					break;
				}
				case "CustOrderHandlingInst":
				{
					value = CustOrderHandlingInst;
					break;
				}
				case "OrderHandlingInstSource":
				{
					value = OrderHandlingInstSource;
					break;
				}
				case "OrderOrigination":
				{
					value = OrderOrigination;
					break;
				}
				case "ContraOrderOrigination":
				{
					value = ContraOrderOrigination;
					break;
				}
				case "OriginatingDeptID":
				{
					value = OriginatingDeptID;
					break;
				}
				case "ReceivingDeptID":
				{
					value = ReceivingDeptID;
					break;
				}
				case "RoutingArrangmentIndicator":
				{
					value = RoutingArrangmentIndicator;
					break;
				}
				case "ContraRoutingArrangmentIndicator":
				{
					value = ContraRoutingArrangmentIndicator;
					break;
				}
				case "AffiliatedFirmsTradeIndicator":
				{
					value = AffiliatedFirmsTradeIndicator;
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
				case "TrdRegTimestamps":
				{
					value = TrdRegTimestamps;
					break;
				}
				case "TrdRegPublicationGrp":
				{
					value = TrdRegPublicationGrp;
					break;
				}
				case "TradePriceConditionGrp":
				{
					value = TradePriceConditionGrp;
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
				case "Volatility":
				{
					value = Volatility;
					break;
				}
				case "TimeToExpiration":
				{
					value = TimeToExpiration;
					break;
				}
				case "RiskFreeRate":
				{
					value = RiskFreeRate;
					break;
				}
				case "PriceDelta":
				{
					value = PriceDelta;
					break;
				}
				case "CoverPrice":
				{
					value = CoverPrice;
					break;
				}
				case "ThrottleResponse":
				{
					value = ThrottleResponse;
					break;
				}
				case "RefOrderID":
				{
					value = RefOrderID;
					break;
				}
				case "RefOrderIDSource":
				{
					value = RefOrderIDSource;
					break;
				}
				case "RefClOrdID":
				{
					value = RefClOrdID;
					break;
				}
				case "RelatedOrderGrp":
				{
					value = RelatedOrderGrp;
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
				case "LockedQty":
				{
					value = LockedQty;
					break;
				}
				case "SecondaryLockedQty":
				{
					value = SecondaryLockedQty;
					break;
				}
				case "LockType":
				{
					value = LockType;
					break;
				}
				case "ReleaseInstruction":
				{
					value = ReleaseInstruction;
					break;
				}
				case "ReleaseQty":
				{
					value = ReleaseQty;
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
			((IFixReset?)ApplicationSequenceControl)?.Reset();
			OrderID = null;
			OrderRequestID = null;
			MassOrderRequestID = null;
			SecondaryOrderID = null;
			SecondaryClOrdID = null;
			SecondaryExecID = null;
			ClOrdID = null;
			QuoteMsgID = null;
			OrigClOrdID = null;
			ClOrdLinkID = null;
			MDEntryID = null;
			QuoteRespID = null;
			OrdStatusReqID = null;
			MassStatusReqID = null;
			HostCrossID = null;
			TotNumReports = null;
			LastRptRequested = null;
			((IFixReset?)Parties)?.Reset();
			((IFixReset?)TargetParties)?.Reset();
			TradeOriginationDate = null;
			((IFixReset?)ContraGrp)?.Reset();
			ListID = null;
			CrossID = null;
			OrigCrossID = null;
			CrossType = null;
			RefRiskLimitCheckID = null;
			RefRiskLimitCheckIDType = null;
			TrdMatchID = null;
			TrdMatchSubID = null;
			ExecID = null;
			ExecRefID = null;
			ExecType = null;
			ExecTypeReason = null;
			OrdStatus = null;
			WorkingIndicator = null;
			CurrentWorkingPrice = null;
			OrdRejReason = null;
			RejectText = null;
			EncodedRejectTextLen = null;
			EncodedRejectText = null;
			ExecRestatementReason = null;
			AnonymousTradeIndicator = null;
			AlgorithmicTradeIndicator = null;
			TrdType = null;
			TrdSubType = null;
			SecondaryTrdType = null;
			RegulatoryTransactionType = null;
			((IFixReset?)RegulatoryTradeIDGrp)?.Reset();
			PreviouslyReported = null;
			TradeReportingIndicator = null;
			Account = null;
			AcctIDSource = null;
			AccountType = null;
			DayBookingInst = null;
			BookingUnit = null;
			PreallocMethod = null;
			AllocID = null;
			((IFixReset?)PreAllocGrp)?.Reset();
			SettlType = null;
			SettlDate = null;
			MatchType = null;
			OrderCategory = null;
			CashMargin = null;
			ClearingFeeIndicator = null;
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)FinancingDetails)?.Reset();
			((IFixReset?)UndInstrmtGrp)?.Reset();
			((IFixReset?)PaymentGrp)?.Reset();
			Side = null;
			ShortMarkingExemptIndicator = null;
			ShortSaleExemptionReason = null;
			((IFixReset?)Stipulations)?.Reset();
			QtyType = null;
			((IFixReset?)OrderQtyData)?.Reset();
			LotType = null;
			OrdType = null;
			PriceType = null;
			((IFixReset?)PriceQualifierGrp)?.Reset();
			Price = null;
			PriceProtectionScope = null;
			StopPx = null;
			((IFixReset?)TriggeringInstruction)?.Reset();
			Triggered = null;
			((IFixReset?)PegInstructions)?.Reset();
			((IFixReset?)DiscretionInstructions)?.Reset();
			PeggedPrice = null;
			PeggedRefPrice = null;
			DiscretionPrice = null;
			TradePriceNegotiationMethod = null;
			UpfrontPrice = null;
			UpfrontPriceType = null;
			TargetStrategy = null;
			((IFixReset?)StrategyParametersGrp)?.Reset();
			TargetStrategyParameters = null;
			ParticipationRate = null;
			TargetStrategyPerformance = null;
			Currency = null;
			CurrencyCodeSource = null;
			ComplianceID = null;
			ComplianceText = null;
			EncodedComplianceTextLen = null;
			EncodedComplianceText = null;
			SolicitedFlag = null;
			TimeInForce = null;
			EffectiveTime = null;
			ExpireDate = null;
			ExpireTime = null;
			ExposureDuration = null;
			ExposureDurationUnit = null;
			ExecInst = null;
			AuctionInstruction = null;
			AggressorIndicator = null;
			OrderCapacity = null;
			OrderRestrictions = null;
			TradingCapacity = null;
			RegulatoryReportType = null;
			PreTradeAnonymity = null;
			TradePublishIndicator = null;
			CustOrderCapacity = null;
			((IFixReset?)OrderAttributeGrp)?.Reset();
			LastQty = null;
			CalculatedCcyLastQty = null;
			LastSwapPoints = null;
			UnderlyingLastQty = null;
			LastQtyVariance = null;
			LastPx = null;
			UnderlyingLastPx = null;
			LastParPx = null;
			MidPx = null;
			LastSpotRate = null;
			LastForwardPoints = null;
			LastUpfrontPrice = null;
			ReportingPx = null;
			ReportingQty = null;
			LastMkt = null;
			VenueType = null;
			MarketSegmentID = null;
			ExDestination = null;
			ExDestinationIDSource = null;
			ExDestinationType = null;
			TradingSessionID = null;
			TradingSessionSubID = null;
			TimeBracket = null;
			LastCapacity = null;
			((IFixReset?)LimitAmts)?.Reset();
			LeavesQty = null;
			CumQty = null;
			CxlQty = null;
			AvgPx = null;
			DayOrderQty = null;
			DayCumQty = null;
			DayAvgPx = null;
			TotNoFills = null;
			LastFragment = null;
			((IFixReset?)FillsGrp)?.Reset();
			((IFixReset?)OrderEventGrp)?.Reset();
			EventInitiatorType = null;
			GTBookingInst = null;
			TradeDate = null;
			TransactTime = null;
			ReportToExch = null;
			((IFixReset?)CommissionData)?.Reset();
			((IFixReset?)CommissionDataGrp)?.Reset();
			((IFixReset?)SpreadOrBenchmarkCurveData)?.Reset();
			((IFixReset?)RelativeValueGrp)?.Reset();
			((IFixReset?)YieldData)?.Reset();
			GrossTradeAmt = null;
			NumDaysInterest = null;
			ExDate = null;
			AccruedInterestRate = null;
			AccruedInterestAmt = null;
			InterestAtMaturity = null;
			EndAccruedInterestAmt = null;
			StartCash = null;
			EndCash = null;
			TradedFlatSwitch = null;
			BasisFeatureDate = null;
			BasisFeaturePrice = null;
			Concession = null;
			TotalTakedown = null;
			NetMoney = null;
			SettlCurrAmt = null;
			SettlCurrency = null;
			SettlCurrencyCodeSource = null;
			((IFixReset?)RateSource)?.Reset();
			OffshoreIndicator = null;
			SettlCurrFxRate = null;
			SettlCurrFxRateCalc = null;
			HandlInst = null;
			MinQty = null;
			MinQtyMethod = null;
			MatchIncrement = null;
			MaxPriceLevels = null;
			MaximumPriceDeviation = null;
			((IFixReset?)ValueChecksGrp)?.Reset();
			((IFixReset?)MatchingInstructions)?.Reset();
			SelfMatchPreventionID = null;
			SelfMatchPreventionInstruction = null;
			CrossedIndicator = null;
			((IFixReset?)DisplayInstruction)?.Reset();
			((IFixReset?)DisclosureInstructionGrp)?.Reset();
			MaxFloor = null;
			ClearingAccountType = null;
			PositionEffect = null;
			MaxShow = null;
			BookingType = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			SettlDate2 = null;
			OrderQty2 = null;
			LastForwardPoints2 = null;
			MultiLegReportingType = null;
			ContingencyType = null;
			CancellationRights = null;
			MoneyLaunderingStatus = null;
			RegistID = null;
			Designation = null;
			TransBkdTime = null;
			ExecValuationPoint = null;
			ExecPriceType = null;
			ExecPriceAdjustment = null;
			PriorityIndicator = null;
			PriceImprovement = null;
			LastLiquidityInd = null;
			((IFixReset?)ContAmtGrp)?.Reset();
			((IFixReset?)InstrmtLegExecGrp)?.Reset();
			CopyMsgIndicator = null;
			((IFixReset?)MiscFeesGrp)?.Reset();
			DividendYield = null;
			ManualOrderIndicator = null;
			CustDirectedOrder = null;
			ReceivedDeptID = null;
			CustOrderHandlingInst = null;
			OrderHandlingInstSource = null;
			OrderOrigination = null;
			ContraOrderOrigination = null;
			OriginatingDeptID = null;
			ReceivingDeptID = null;
			RoutingArrangmentIndicator = null;
			ContraRoutingArrangmentIndicator = null;
			AffiliatedFirmsTradeIndicator = null;
			OwnerType = null;
			OrderOwnershipIndicator = null;
			((IFixReset?)TrdRegTimestamps)?.Reset();
			((IFixReset?)TrdRegPublicationGrp)?.Reset();
			((IFixReset?)TradePriceConditionGrp)?.Reset();
			TradeContinuation = null;
			TradeContinuationText = null;
			EncodedTradeContinuationTextLen = null;
			EncodedTradeContinuationText = null;
			Volatility = null;
			TimeToExpiration = null;
			RiskFreeRate = null;
			PriceDelta = null;
			CoverPrice = null;
			((IFixReset?)ThrottleResponse)?.Reset();
			RefOrderID = null;
			RefOrderIDSource = null;
			RefClOrdID = null;
			((IFixReset?)RelatedOrderGrp)?.Reset();
			AuctionType = null;
			AuctionAllocationPct = null;
			LockedQty = null;
			SecondaryLockedQty = null;
			LockType = null;
			ReleaseInstruction = null;
			ReleaseQty = null;
			RelatedHighPrice = null;
			RelatedLowPrice = null;
			RelatedPriceSource = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
