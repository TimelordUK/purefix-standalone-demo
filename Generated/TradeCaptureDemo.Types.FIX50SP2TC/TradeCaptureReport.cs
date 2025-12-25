using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("AE", FixVersion.FIX50SP2)]
	public sealed partial class TradeCaptureReport : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public ApplicationSequenceControl? ApplicationSequenceControl {get; set;}
		
		[TagDetails(Tag = 571, Type = TagType.String, Offset = 2, Required = false)]
		public string? TradeReportID {get; set;}
		
		[TagDetails(Tag = 1003, Type = TagType.String, Offset = 3, Required = false)]
		public string? TradeID {get; set;}
		
		[TagDetails(Tag = 1040, Type = TagType.String, Offset = 4, Required = false)]
		public string? SecondaryTradeID {get; set;}
		
		[TagDetails(Tag = 1041, Type = TagType.String, Offset = 5, Required = false)]
		public string? FirmTradeID {get; set;}
		
		[TagDetails(Tag = 1042, Type = TagType.String, Offset = 6, Required = false)]
		public string? SecondaryFirmTradeID {get; set;}
		
		[TagDetails(Tag = 2489, Type = TagType.String, Offset = 7, Required = false)]
		public string? PackageID {get; set;}
		
		[TagDetails(Tag = 2490, Type = TagType.Int, Offset = 8, Required = false)]
		public int? TradeNumber {get; set;}
		
		[TagDetails(Tag = 487, Type = TagType.Int, Offset = 9, Required = false)]
		public int? TradeReportTransType {get; set;}
		
		[TagDetails(Tag = 856, Type = TagType.Int, Offset = 10, Required = false)]
		public int? TradeReportType {get; set;}
		
		[TagDetails(Tag = 939, Type = TagType.Int, Offset = 11, Required = false)]
		public int? TrdRptStatus {get; set;}
		
		[TagDetails(Tag = 568, Type = TagType.String, Offset = 12, Required = false)]
		public string? TradeRequestID {get; set;}
		
		[TagDetails(Tag = 828, Type = TagType.Int, Offset = 13, Required = false)]
		public int? TrdType {get; set;}
		
		[TagDetails(Tag = 829, Type = TagType.Int, Offset = 14, Required = false)]
		public int? TrdSubType {get; set;}
		
		[TagDetails(Tag = 855, Type = TagType.Int, Offset = 15, Required = false)]
		public int? SecondaryTrdType {get; set;}
		
		[TagDetails(Tag = 2896, Type = TagType.Int, Offset = 16, Required = false)]
		public int? TertiaryTrdType {get; set;}
		
		[TagDetails(Tag = 2961, Type = TagType.Boolean, Offset = 17, Required = false)]
		public bool? AnonymousTradeIndicator {get; set;}
		
		[TagDetails(Tag = 2667, Type = TagType.Int, Offset = 18, Required = false)]
		public int? AlgorithmicTradeIndicator {get; set;}
		
		[TagDetails(Tag = 1849, Type = TagType.Int, Offset = 19, Required = false)]
		public int? OffsetInstruction {get; set;}
		
		[Component(Offset = 20, Required = false)]
		public TradePriceConditionGrp? TradePriceConditionGrp {get; set;}
		
		[TagDetails(Tag = 1123, Type = TagType.String, Offset = 21, Required = false)]
		public string? TradeHandlingInstr {get; set;}
		
		[TagDetails(Tag = 1124, Type = TagType.String, Offset = 22, Required = false)]
		public string? OrigTradeHandlingInstr {get; set;}
		
		[TagDetails(Tag = 1125, Type = TagType.LocalDate, Offset = 23, Required = false)]
		public DateOnly? OrigTradeDate {get; set;}
		
		[TagDetails(Tag = 1126, Type = TagType.String, Offset = 24, Required = false)]
		public string? OrigTradeID {get; set;}
		
		[TagDetails(Tag = 1127, Type = TagType.String, Offset = 25, Required = false)]
		public string? OrigSecondaryTradeID {get; set;}
		
		[TagDetails(Tag = 830, Type = TagType.String, Offset = 26, Required = false)]
		public string? TransferReason {get; set;}
		
		[TagDetails(Tag = 150, Type = TagType.String, Offset = 27, Required = false)]
		public string? ExecType {get; set;}
		
		[TagDetails(Tag = 748, Type = TagType.Int, Offset = 28, Required = false)]
		public int? TotNumTradeReports {get; set;}
		
		[TagDetails(Tag = 912, Type = TagType.Boolean, Offset = 29, Required = false)]
		public bool? LastRptRequested {get; set;}
		
		[TagDetails(Tag = 1028, Type = TagType.Boolean, Offset = 30, Required = false)]
		public bool? ManualOrderIndicator {get; set;}
		
		[TagDetails(Tag = 325, Type = TagType.Boolean, Offset = 31, Required = false)]
		public bool? UnsolicitedIndicator {get; set;}
		
		[TagDetails(Tag = 263, Type = TagType.String, Offset = 32, Required = false)]
		public string? SubscriptionRequestType {get; set;}
		
		[TagDetails(Tag = 572, Type = TagType.String, Offset = 33, Required = false)]
		public string? TradeReportRefID {get; set;}
		
		[TagDetails(Tag = 881, Type = TagType.String, Offset = 34, Required = false)]
		public string? SecondaryTradeReportRefID {get; set;}
		
		[TagDetails(Tag = 818, Type = TagType.String, Offset = 35, Required = false)]
		public string? SecondaryTradeReportID {get; set;}
		
		[TagDetails(Tag = 820, Type = TagType.String, Offset = 36, Required = false)]
		public string? TradeLinkID {get; set;}
		
		[TagDetails(Tag = 880, Type = TagType.String, Offset = 37, Required = false)]
		public string? TrdMatchID {get; set;}
		
		[TagDetails(Tag = 17, Type = TagType.String, Offset = 38, Required = false)]
		public string? ExecID {get; set;}
		
		[TagDetails(Tag = 19, Type = TagType.String, Offset = 39, Required = false)]
		public string? ExecRefID {get; set;}
		
		[TagDetails(Tag = 527, Type = TagType.String, Offset = 40, Required = false)]
		public string? SecondaryExecID {get; set;}
		
		[TagDetails(Tag = 378, Type = TagType.Int, Offset = 41, Required = false)]
		public int? ExecRestatementReason {get; set;}
		
		[TagDetails(Tag = 2347, Type = TagType.Int, Offset = 42, Required = false)]
		public int? RegulatoryTransactionType {get; set;}
		
		[Component(Offset = 43, Required = false)]
		public RegulatoryTradeIDGrp? RegulatoryTradeIDGrp {get; set;}
		
		[TagDetails(Tag = 570, Type = TagType.Boolean, Offset = 44, Required = false)]
		public bool? PreviouslyReported {get; set;}
		
		[TagDetails(Tag = 423, Type = TagType.Int, Offset = 45, Required = false)]
		public int? PriceType {get; set;}
		
		[Component(Offset = 46, Required = false)]
		public PriceQualifierGrp? PriceQualifierGrp {get; set;}
		
		[TagDetails(Tag = 549, Type = TagType.Int, Offset = 47, Required = false)]
		public int? CrossType {get; set;}
		
		[Component(Offset = 48, Required = false)]
		public RootParties? RootParties {get; set;}
		
		[TagDetails(Tag = 1015, Type = TagType.String, Offset = 49, Required = false)]
		public string? AsOfIndicator {get; set;}
		
		[TagDetails(Tag = 716, Type = TagType.String, Offset = 50, Required = false)]
		public string? SettlSessID {get; set;}
		
		[TagDetails(Tag = 717, Type = TagType.String, Offset = 51, Required = false)]
		public string? SettlSessSubID {get; set;}
		
		[TagDetails(Tag = 1430, Type = TagType.String, Offset = 52, Required = false)]
		public string? VenueType {get; set;}
		
		[TagDetails(Tag = 1300, Type = TagType.String, Offset = 53, Required = false)]
		public string? MarketSegmentID {get; set;}
		
		[TagDetails(Tag = 1301, Type = TagType.String, Offset = 54, Required = false)]
		public string? MarketID {get; set;}
		
		[TagDetails(Tag = 2375, Type = TagType.String, Offset = 55, Required = false)]
		public string? TaxonomyType {get; set;}
		
		[Component(Offset = 56, Required = true)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 57, Required = false)]
		public InstrumentExtension? InstrumentExtension {get; set;}
		
		[Component(Offset = 58, Required = false)]
		public FinancingDetails? FinancingDetails {get; set;}
		
		[Component(Offset = 59, Required = false)]
		public PaymentGrp? PaymentGrp {get; set;}
		
		[TagDetails(Tag = 854, Type = TagType.Int, Offset = 60, Required = false)]
		public int? QtyType {get; set;}
		
		[Component(Offset = 61, Required = false)]
		public YieldData? YieldData {get; set;}
		
		[Component(Offset = 62, Required = false)]
		public UndInstrmtGrp? UndInstrmtGrp {get; set;}
		
		[Component(Offset = 63, Required = false)]
		public RelatedInstrumentGrp? RelatedInstrumentGrp {get; set;}
		
		[Component(Offset = 64, Required = false)]
		public CollateralAmountGrp? CollateralAmountGrp {get; set;}
		
		[TagDetails(Tag = 2868, Type = TagType.LocalDate, Offset = 65, Required = false)]
		public DateOnly? CollateralizationValueDate {get; set;}
		
		[Component(Offset = 66, Required = false)]
		public RateSource? RateSource {get; set;}
		
		[Component(Offset = 67, Required = false)]
		public TransactionAttributeGrp? TransactionAttributeGrp {get; set;}
		
		[TagDetails(Tag = 822, Type = TagType.String, Offset = 68, Required = false)]
		public string? UnderlyingTradingSessionID {get; set;}
		
		[TagDetails(Tag = 823, Type = TagType.String, Offset = 69, Required = false)]
		public string? UnderlyingTradingSessionSubID {get; set;}
		
		[TagDetails(Tag = 32, Type = TagType.Float, Offset = 70, Required = false)]
		public double? LastQty {get; set;}
		
		[TagDetails(Tag = 1828, Type = TagType.Float, Offset = 71, Required = false)]
		public double? LastQtyVariance {get; set;}
		
		[TagDetails(Tag = 2301, Type = TagType.Float, Offset = 72, Required = false)]
		public double? LastQtyChanged {get; set;}
		
		[TagDetails(Tag = 2368, Type = TagType.Float, Offset = 73, Required = false)]
		public double? LastMultipliedQty {get; set;}
		
		[TagDetails(Tag = 2367, Type = TagType.Float, Offset = 74, Required = false)]
		public double? TotalTradeQty {get; set;}
		
		[TagDetails(Tag = 2370, Type = TagType.Float, Offset = 75, Required = false)]
		public double? TotalTradeMultipliedQty {get; set;}
		
		[TagDetails(Tag = 31, Type = TagType.Float, Offset = 76, Required = false)]
		public double? LastPx {get; set;}
		
		[TagDetails(Tag = 631, Type = TagType.Float, Offset = 77, Required = false)]
		public double? MidPx {get; set;}
		
		[TagDetails(Tag = 1522, Type = TagType.Float, Offset = 78, Required = false)]
		public double? DifferentialPrice {get; set;}
		
		[TagDetails(Tag = 1056, Type = TagType.Float, Offset = 79, Required = false)]
		public double? CalculatedCcyLastQty {get; set;}
		
		[TagDetails(Tag = 2762, Type = TagType.Float, Offset = 80, Required = false)]
		public double? PriceMarkup {get; set;}
		
		[Component(Offset = 81, Required = false)]
		public AveragePriceDetail? AveragePriceDetail {get; set;}
		
		[TagDetails(Tag = 15, Type = TagType.String, Offset = 82, Required = false)]
		public string? Currency {get; set;}
		
		[TagDetails(Tag = 2897, Type = TagType.String, Offset = 83, Required = false)]
		public string? CurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 120, Type = TagType.String, Offset = 84, Required = false)]
		public string? SettlCurrency {get; set;}
		
		[TagDetails(Tag = 2899, Type = TagType.String, Offset = 85, Required = false)]
		public string? SettlCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 2366, Type = TagType.String, Offset = 86, Required = false)]
		public string? SettlPriceFxRateCalc {get; set;}
		
		[TagDetails(Tag = 669, Type = TagType.Float, Offset = 87, Required = false)]
		public double? LastParPx {get; set;}
		
		[TagDetails(Tag = 194, Type = TagType.Float, Offset = 88, Required = false)]
		public double? LastSpotRate {get; set;}
		
		[TagDetails(Tag = 195, Type = TagType.Float, Offset = 89, Required = false)]
		public double? LastForwardPoints {get; set;}
		
		[TagDetails(Tag = 1071, Type = TagType.Float, Offset = 90, Required = false)]
		public double? LastSwapPoints {get; set;}
		
		[TagDetails(Tag = 2349, Type = TagType.Int, Offset = 91, Required = false)]
		public int? PricePrecision {get; set;}
		
		[TagDetails(Tag = 30, Type = TagType.String, Offset = 92, Required = false)]
		public string? LastMkt {get; set;}
		
		[TagDetails(Tag = 1596, Type = TagType.Float, Offset = 93, Required = false)]
		public double? ClearingTradePrice {get; set;}
		
		[TagDetails(Tag = 1740, Type = TagType.Int, Offset = 94, Required = false)]
		public int? TradePriceNegotiationMethod {get; set;}
		
		[TagDetails(Tag = 1743, Type = TagType.Float, Offset = 95, Required = false)]
		public double? LastUpfrontPrice {get; set;}
		
		[TagDetails(Tag = 1741, Type = TagType.Int, Offset = 96, Required = false)]
		public int? UpfrontPriceType {get; set;}
		
		[TagDetails(Tag = 75, Type = TagType.LocalDate, Offset = 97, Required = false)]
		public DateOnly? TradeDate {get; set;}
		
		[TagDetails(Tag = 715, Type = TagType.LocalDate, Offset = 98, Required = false)]
		public DateOnly? ClearingBusinessDate {get; set;}
		
		[TagDetails(Tag = 2870, Type = TagType.String, Offset = 99, Required = false)]
		public string? ClearingPortfolioID {get; set;}
		
		[TagDetails(Tag = 6, Type = TagType.Float, Offset = 100, Required = false)]
		public double? AvgPx {get; set;}
		
		[Component(Offset = 101, Required = false)]
		public SpreadOrBenchmarkCurveData? SpreadOrBenchmarkCurveData {get; set;}
		
		[TagDetails(Tag = 1731, Type = TagType.String, Offset = 102, Required = false)]
		public string? AvgPxGroupID {get; set;}
		
		[TagDetails(Tag = 819, Type = TagType.Int, Offset = 103, Required = false)]
		public int? AvgPxIndicator {get; set;}
		
		[TagDetails(Tag = 2085, Type = TagType.LocalDate, Offset = 104, Required = false)]
		public DateOnly? ValuationDate {get; set;}
		
		[TagDetails(Tag = 2086, Type = TagType.String, Offset = 105, Required = false)]
		public string? ValuationTime {get; set;}
		
		[TagDetails(Tag = 2087, Type = TagType.String, Offset = 106, Required = false)]
		public string? ValuationBusinessCenter {get; set;}
		
		[Component(Offset = 107, Required = false)]
		public PositionAmountData? PositionAmountData {get; set;}
		
		[TagDetails(Tag = 442, Type = TagType.String, Offset = 108, Required = false)]
		public string? MultiLegReportingType {get; set;}
		
		[TagDetails(Tag = 824, Type = TagType.String, Offset = 109, Required = false)]
		public string? TradeLegRefID {get; set;}
		
		[Component(Offset = 110, Required = false)]
		public TrdInstrmtLegGrp? TrdInstrmtLegGrp {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 111, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[Component(Offset = 112, Required = false)]
		public TrdRegTimestamps? TrdRegTimestamps {get; set;}
		
		[TagDetails(Tag = 63, Type = TagType.String, Offset = 113, Required = false)]
		public string? SettlType {get; set;}
		
		[TagDetails(Tag = 64, Type = TagType.LocalDate, Offset = 114, Required = false)]
		public DateOnly? SettlDate {get; set;}
		
		[TagDetails(Tag = 2878, Type = TagType.LocalDate, Offset = 115, Required = false)]
		public DateOnly? TerminationDate {get; set;}
		
		[TagDetails(Tag = 987, Type = TagType.LocalDate, Offset = 116, Required = false)]
		public DateOnly? UnderlyingSettlementDate {get; set;}
		
		[TagDetails(Tag = 573, Type = TagType.String, Offset = 117, Required = false)]
		public string? MatchStatus {get; set;}
		
		[TagDetails(Tag = 2405, Type = TagType.Int, Offset = 118, Required = false)]
		public int? ExecMethod {get; set;}
		
		[TagDetails(Tag = 574, Type = TagType.String, Offset = 119, Required = false)]
		public string? MatchType {get; set;}
		
		[Component(Offset = 120, Required = false)]
		public TradeQtyGrp? TradeQtyGrp {get; set;}
		
		[Component(Offset = 121, Required = true)]
		public TrdCapRptSideGrp? TrdCapRptSideGrp {get; set;}
		
		[TagDetails(Tag = 1188, Type = TagType.Float, Offset = 122, Required = false)]
		public double? Volatility {get; set;}
		
		[TagDetails(Tag = 1189, Type = TagType.Float, Offset = 123, Required = false)]
		public double? TimeToExpiration {get; set;}
		
		[TagDetails(Tag = 1380, Type = TagType.Float, Offset = 124, Required = false)]
		public double? DividendYield {get; set;}
		
		[TagDetails(Tag = 1190, Type = TagType.Float, Offset = 125, Required = false)]
		public double? RiskFreeRate {get; set;}
		
		[TagDetails(Tag = 811, Type = TagType.Float, Offset = 126, Required = false)]
		public double? PriceDelta {get; set;}
		
		[TagDetails(Tag = 1382, Type = TagType.Float, Offset = 127, Required = false)]
		public double? CurrencyRatio {get; set;}
		
		[TagDetails(Tag = 797, Type = TagType.Boolean, Offset = 128, Required = false)]
		public bool? CopyMsgIndicator {get; set;}
		
		[Component(Offset = 129, Required = false)]
		public TrdRepIndicatorsGrp? TrdRepIndicatorsGrp {get; set;}
		
		[TagDetails(Tag = 2524, Type = TagType.Int, Offset = 130, Required = false)]
		public int? TradeReportingIndicator {get; set;}
		
		[TagDetails(Tag = 852, Type = TagType.Boolean, Offset = 131, Required = false)]
		public bool? PublishTrdIndicator {get; set;}
		
		[TagDetails(Tag = 1390, Type = TagType.Int, Offset = 132, Required = false)]
		public int? TradePublishIndicator {get; set;}
		
		[Component(Offset = 133, Required = false)]
		public TrdRegPublicationGrp? TrdRegPublicationGrp {get; set;}
		
		[TagDetails(Tag = 853, Type = TagType.Int, Offset = 134, Required = false)]
		public int? ShortSaleReason {get; set;}
		
		[TagDetails(Tag = 994, Type = TagType.String, Offset = 135, Required = false)]
		public string? TierCode {get; set;}
		
		[TagDetails(Tag = 1011, Type = TagType.String, Offset = 136, Required = false)]
		public string? MessageEventSource {get; set;}
		
		[TagDetails(Tag = 779, Type = TagType.UtcTimestamp, Offset = 137, Required = false)]
		public DateTime? LastUpdateTime {get; set;}
		
		[TagDetails(Tag = 991, Type = TagType.Float, Offset = 138, Required = false)]
		public double? RndPx {get; set;}
		
		[TagDetails(Tag = 1132, Type = TagType.String, Offset = 139, Required = false)]
		public string? TZTransactTime {get; set;}
		
		[TagDetails(Tag = 1134, Type = TagType.Boolean, Offset = 140, Required = false)]
		public bool? ReportedPxDiff {get; set;}
		
		[TagDetails(Tag = 381, Type = TagType.Float, Offset = 141, Required = false)]
		public double? GrossTradeAmt {get; set;}
		
		[TagDetails(Tag = 2369, Type = TagType.Float, Offset = 142, Required = false)]
		public double? TotalGrossTradeAmt {get; set;}
		
		[TagDetails(Tag = 751, Type = TagType.Int, Offset = 143, Required = false)]
		public int? TradeReportRejectReason {get; set;}
		
		[TagDetails(Tag = 1328, Type = TagType.String, Offset = 144, Required = false)]
		public string? RejectText {get; set;}
		
		[TagDetails(Tag = 1664, Type = TagType.Length, Offset = 145, Required = false)]
		public int? EncodedRejectTextLen {get; set;}
		
		[TagDetails(Tag = 1665, Type = TagType.RawData, Offset = 146, Required = false)]
		public byte[]? EncodedRejectText {get; set;}
		
		[TagDetails(Tag = 1329, Type = TagType.Float, Offset = 147, Required = false)]
		public double? FeeMultiplier {get; set;}
		
		[TagDetails(Tag = 1832, Type = TagType.Int, Offset = 148, Required = false)]
		public int? ClearedIndicator {get; set;}
		
		[TagDetails(Tag = 1924, Type = TagType.Int, Offset = 149, Required = false)]
		public int? ClearingIntention {get; set;}
		
		[TagDetails(Tag = 1925, Type = TagType.Int, Offset = 150, Required = false)]
		public int? TradeClearingInstruction {get; set;}
		
		[TagDetails(Tag = 1926, Type = TagType.Boolean, Offset = 151, Required = false)]
		public bool? BackloadedTradeIndicator {get; set;}
		
		[TagDetails(Tag = 1927, Type = TagType.Int, Offset = 152, Required = false)]
		public int? ConfirmationMethod {get; set;}
		
		[TagDetails(Tag = 1928, Type = TagType.Boolean, Offset = 153, Required = false)]
		public bool? MandatoryClearingIndicator {get; set;}
		
		[Component(Offset = 154, Required = false)]
		public MandatoryClearingJurisdictionGrp? MandatoryClearingJurisdictionGrp {get; set;}
		
		[TagDetails(Tag = 1929, Type = TagType.Boolean, Offset = 155, Required = false)]
		public bool? MixedSwapIndicator {get; set;}
		
		[TagDetails(Tag = 2527, Type = TagType.Boolean, Offset = 156, Required = false)]
		public bool? MultiAssetSwapIndicator {get; set;}
		
		[TagDetails(Tag = 2526, Type = TagType.Boolean, Offset = 157, Required = false)]
		public bool? InternationalSwapIndicator {get; set;}
		
		[TagDetails(Tag = 1930, Type = TagType.Boolean, Offset = 158, Required = false)]
		public bool? OffMarketPriceIndicator {get; set;}
		
		[TagDetails(Tag = 1931, Type = TagType.Int, Offset = 159, Required = false)]
		public int? VerificationMethod {get; set;}
		
		[TagDetails(Tag = 1932, Type = TagType.Int, Offset = 160, Required = false)]
		public int? ClearingRequirementException {get; set;}
		
		[TagDetails(Tag = 1933, Type = TagType.String, Offset = 161, Required = false)]
		public string? IRSDirection {get; set;}
		
		[TagDetails(Tag = 1934, Type = TagType.Int, Offset = 162, Required = false)]
		public int? RegulatoryReportType {get; set;}
		
		[TagDetails(Tag = 2869, Type = TagType.LocalDate, Offset = 163, Required = false)]
		public DateOnly? RegulatoryReportTypeBusinessDate {get; set;}
		
		[TagDetails(Tag = 1935, Type = TagType.Boolean, Offset = 164, Required = false)]
		public bool? VoluntaryRegulatoryReport {get; set;}
		
		[TagDetails(Tag = 2963, Type = TagType.Int, Offset = 165, Required = false)]
		public int? MultiJurisdictionReportingIndicator {get; set;}
		
		[TagDetails(Tag = 1936, Type = TagType.Int, Offset = 166, Required = false)]
		public int? TradeCollateralization {get; set;}
		
		[TagDetails(Tag = 1937, Type = TagType.Int, Offset = 167, Required = false)]
		public int? TradeContinuation {get; set;}
		
		[TagDetails(Tag = 2387, Type = TagType.Int, Offset = 168, Required = false)]
		public int? TradeContingency {get; set;}
		
		[TagDetails(Tag = 2302, Type = TagType.String, Offset = 169, Required = false)]
		public string? TradeVersion {get; set;}
		
		[TagDetails(Tag = 2303, Type = TagType.Boolean, Offset = 170, Required = false)]
		public bool? HistoricalReportIndicator {get; set;}
		
		[TagDetails(Tag = 2596, Type = TagType.Boolean, Offset = 171, Required = false)]
		public bool? DeltaCrossed {get; set;}
		
		[TagDetails(Tag = 2374, Type = TagType.String, Offset = 172, Required = false)]
		public string? TradeContinuationText {get; set;}
		
		[TagDetails(Tag = 2372, Type = TagType.Length, Offset = 173, Required = false)]
		public int? EncodedTradeContinuationTextLen {get; set;}
		
		[TagDetails(Tag = 2371, Type = TagType.RawData, Offset = 174, Required = false)]
		public byte[]? EncodedTradeContinuationText {get; set;}
		
		[TagDetails(Tag = 2373, Type = TagType.Boolean, Offset = 175, Required = false)]
		public bool? IntraFirmTradeIndicator {get; set;}
		
		[TagDetails(Tag = 2525, Type = TagType.Boolean, Offset = 176, Required = false)]
		public bool? AffiliatedFirmsTradeIndicator {get; set;}
		
		[Component(Offset = 177, Required = false)]
		public AttachmentGrp? AttachmentGrp {get; set;}
		
		[TagDetails(Tag = 2343, Type = TagType.Int, Offset = 178, Required = false)]
		public int? RiskLimitCheckStatus {get; set;}
		
		[Component(Offset = 179, Required = true)]
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
			if (TradeReportID is not null) writer.WriteString(571, TradeReportID);
			if (TradeID is not null) writer.WriteString(1003, TradeID);
			if (SecondaryTradeID is not null) writer.WriteString(1040, SecondaryTradeID);
			if (FirmTradeID is not null) writer.WriteString(1041, FirmTradeID);
			if (SecondaryFirmTradeID is not null) writer.WriteString(1042, SecondaryFirmTradeID);
			if (PackageID is not null) writer.WriteString(2489, PackageID);
			if (TradeNumber is not null) writer.WriteWholeNumber(2490, TradeNumber.Value);
			if (TradeReportTransType is not null) writer.WriteWholeNumber(487, TradeReportTransType.Value);
			if (TradeReportType is not null) writer.WriteWholeNumber(856, TradeReportType.Value);
			if (TrdRptStatus is not null) writer.WriteWholeNumber(939, TrdRptStatus.Value);
			if (TradeRequestID is not null) writer.WriteString(568, TradeRequestID);
			if (TrdType is not null) writer.WriteWholeNumber(828, TrdType.Value);
			if (TrdSubType is not null) writer.WriteWholeNumber(829, TrdSubType.Value);
			if (SecondaryTrdType is not null) writer.WriteWholeNumber(855, SecondaryTrdType.Value);
			if (TertiaryTrdType is not null) writer.WriteWholeNumber(2896, TertiaryTrdType.Value);
			if (AnonymousTradeIndicator is not null) writer.WriteBoolean(2961, AnonymousTradeIndicator.Value);
			if (AlgorithmicTradeIndicator is not null) writer.WriteWholeNumber(2667, AlgorithmicTradeIndicator.Value);
			if (OffsetInstruction is not null) writer.WriteWholeNumber(1849, OffsetInstruction.Value);
			if (TradePriceConditionGrp is not null) ((IFixEncoder)TradePriceConditionGrp).Encode(writer);
			if (TradeHandlingInstr is not null) writer.WriteString(1123, TradeHandlingInstr);
			if (OrigTradeHandlingInstr is not null) writer.WriteString(1124, OrigTradeHandlingInstr);
			if (OrigTradeDate is not null) writer.WriteLocalDateOnly(1125, OrigTradeDate.Value);
			if (OrigTradeID is not null) writer.WriteString(1126, OrigTradeID);
			if (OrigSecondaryTradeID is not null) writer.WriteString(1127, OrigSecondaryTradeID);
			if (TransferReason is not null) writer.WriteString(830, TransferReason);
			if (ExecType is not null) writer.WriteString(150, ExecType);
			if (TotNumTradeReports is not null) writer.WriteWholeNumber(748, TotNumTradeReports.Value);
			if (LastRptRequested is not null) writer.WriteBoolean(912, LastRptRequested.Value);
			if (ManualOrderIndicator is not null) writer.WriteBoolean(1028, ManualOrderIndicator.Value);
			if (UnsolicitedIndicator is not null) writer.WriteBoolean(325, UnsolicitedIndicator.Value);
			if (SubscriptionRequestType is not null) writer.WriteString(263, SubscriptionRequestType);
			if (TradeReportRefID is not null) writer.WriteString(572, TradeReportRefID);
			if (SecondaryTradeReportRefID is not null) writer.WriteString(881, SecondaryTradeReportRefID);
			if (SecondaryTradeReportID is not null) writer.WriteString(818, SecondaryTradeReportID);
			if (TradeLinkID is not null) writer.WriteString(820, TradeLinkID);
			if (TrdMatchID is not null) writer.WriteString(880, TrdMatchID);
			if (ExecID is not null) writer.WriteString(17, ExecID);
			if (ExecRefID is not null) writer.WriteString(19, ExecRefID);
			if (SecondaryExecID is not null) writer.WriteString(527, SecondaryExecID);
			if (ExecRestatementReason is not null) writer.WriteWholeNumber(378, ExecRestatementReason.Value);
			if (RegulatoryTransactionType is not null) writer.WriteWholeNumber(2347, RegulatoryTransactionType.Value);
			if (RegulatoryTradeIDGrp is not null) ((IFixEncoder)RegulatoryTradeIDGrp).Encode(writer);
			if (PreviouslyReported is not null) writer.WriteBoolean(570, PreviouslyReported.Value);
			if (PriceType is not null) writer.WriteWholeNumber(423, PriceType.Value);
			if (PriceQualifierGrp is not null) ((IFixEncoder)PriceQualifierGrp).Encode(writer);
			if (CrossType is not null) writer.WriteWholeNumber(549, CrossType.Value);
			if (RootParties is not null) ((IFixEncoder)RootParties).Encode(writer);
			if (AsOfIndicator is not null) writer.WriteString(1015, AsOfIndicator);
			if (SettlSessID is not null) writer.WriteString(716, SettlSessID);
			if (SettlSessSubID is not null) writer.WriteString(717, SettlSessSubID);
			if (VenueType is not null) writer.WriteString(1430, VenueType);
			if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
			if (MarketID is not null) writer.WriteString(1301, MarketID);
			if (TaxonomyType is not null) writer.WriteString(2375, TaxonomyType);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (InstrumentExtension is not null) ((IFixEncoder)InstrumentExtension).Encode(writer);
			if (FinancingDetails is not null) ((IFixEncoder)FinancingDetails).Encode(writer);
			if (PaymentGrp is not null) ((IFixEncoder)PaymentGrp).Encode(writer);
			if (QtyType is not null) writer.WriteWholeNumber(854, QtyType.Value);
			if (YieldData is not null) ((IFixEncoder)YieldData).Encode(writer);
			if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
			if (RelatedInstrumentGrp is not null) ((IFixEncoder)RelatedInstrumentGrp).Encode(writer);
			if (CollateralAmountGrp is not null) ((IFixEncoder)CollateralAmountGrp).Encode(writer);
			if (CollateralizationValueDate is not null) writer.WriteLocalDateOnly(2868, CollateralizationValueDate.Value);
			if (RateSource is not null) ((IFixEncoder)RateSource).Encode(writer);
			if (TransactionAttributeGrp is not null) ((IFixEncoder)TransactionAttributeGrp).Encode(writer);
			if (UnderlyingTradingSessionID is not null) writer.WriteString(822, UnderlyingTradingSessionID);
			if (UnderlyingTradingSessionSubID is not null) writer.WriteString(823, UnderlyingTradingSessionSubID);
			if (LastQty is not null) writer.WriteNumber(32, LastQty.Value);
			if (LastQtyVariance is not null) writer.WriteNumber(1828, LastQtyVariance.Value);
			if (LastQtyChanged is not null) writer.WriteNumber(2301, LastQtyChanged.Value);
			if (LastMultipliedQty is not null) writer.WriteNumber(2368, LastMultipliedQty.Value);
			if (TotalTradeQty is not null) writer.WriteNumber(2367, TotalTradeQty.Value);
			if (TotalTradeMultipliedQty is not null) writer.WriteNumber(2370, TotalTradeMultipliedQty.Value);
			if (LastPx is not null) writer.WriteNumber(31, LastPx.Value);
			if (MidPx is not null) writer.WriteNumber(631, MidPx.Value);
			if (DifferentialPrice is not null) writer.WriteNumber(1522, DifferentialPrice.Value);
			if (CalculatedCcyLastQty is not null) writer.WriteNumber(1056, CalculatedCcyLastQty.Value);
			if (PriceMarkup is not null) writer.WriteNumber(2762, PriceMarkup.Value);
			if (AveragePriceDetail is not null) ((IFixEncoder)AveragePriceDetail).Encode(writer);
			if (Currency is not null) writer.WriteString(15, Currency);
			if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
			if (SettlCurrency is not null) writer.WriteString(120, SettlCurrency);
			if (SettlCurrencyCodeSource is not null) writer.WriteString(2899, SettlCurrencyCodeSource);
			if (SettlPriceFxRateCalc is not null) writer.WriteString(2366, SettlPriceFxRateCalc);
			if (LastParPx is not null) writer.WriteNumber(669, LastParPx.Value);
			if (LastSpotRate is not null) writer.WriteNumber(194, LastSpotRate.Value);
			if (LastForwardPoints is not null) writer.WriteNumber(195, LastForwardPoints.Value);
			if (LastSwapPoints is not null) writer.WriteNumber(1071, LastSwapPoints.Value);
			if (PricePrecision is not null) writer.WriteWholeNumber(2349, PricePrecision.Value);
			if (LastMkt is not null) writer.WriteString(30, LastMkt);
			if (ClearingTradePrice is not null) writer.WriteNumber(1596, ClearingTradePrice.Value);
			if (TradePriceNegotiationMethod is not null) writer.WriteWholeNumber(1740, TradePriceNegotiationMethod.Value);
			if (LastUpfrontPrice is not null) writer.WriteNumber(1743, LastUpfrontPrice.Value);
			if (UpfrontPriceType is not null) writer.WriteWholeNumber(1741, UpfrontPriceType.Value);
			if (TradeDate is not null) writer.WriteLocalDateOnly(75, TradeDate.Value);
			if (ClearingBusinessDate is not null) writer.WriteLocalDateOnly(715, ClearingBusinessDate.Value);
			if (ClearingPortfolioID is not null) writer.WriteString(2870, ClearingPortfolioID);
			if (AvgPx is not null) writer.WriteNumber(6, AvgPx.Value);
			if (SpreadOrBenchmarkCurveData is not null) ((IFixEncoder)SpreadOrBenchmarkCurveData).Encode(writer);
			if (AvgPxGroupID is not null) writer.WriteString(1731, AvgPxGroupID);
			if (AvgPxIndicator is not null) writer.WriteWholeNumber(819, AvgPxIndicator.Value);
			if (ValuationDate is not null) writer.WriteLocalDateOnly(2085, ValuationDate.Value);
			if (ValuationTime is not null) writer.WriteString(2086, ValuationTime);
			if (ValuationBusinessCenter is not null) writer.WriteString(2087, ValuationBusinessCenter);
			if (PositionAmountData is not null) ((IFixEncoder)PositionAmountData).Encode(writer);
			if (MultiLegReportingType is not null) writer.WriteString(442, MultiLegReportingType);
			if (TradeLegRefID is not null) writer.WriteString(824, TradeLegRefID);
			if (TrdInstrmtLegGrp is not null) ((IFixEncoder)TrdInstrmtLegGrp).Encode(writer);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (TrdRegTimestamps is not null) ((IFixEncoder)TrdRegTimestamps).Encode(writer);
			if (SettlType is not null) writer.WriteString(63, SettlType);
			if (SettlDate is not null) writer.WriteLocalDateOnly(64, SettlDate.Value);
			if (TerminationDate is not null) writer.WriteLocalDateOnly(2878, TerminationDate.Value);
			if (UnderlyingSettlementDate is not null) writer.WriteLocalDateOnly(987, UnderlyingSettlementDate.Value);
			if (MatchStatus is not null) writer.WriteString(573, MatchStatus);
			if (ExecMethod is not null) writer.WriteWholeNumber(2405, ExecMethod.Value);
			if (MatchType is not null) writer.WriteString(574, MatchType);
			if (TradeQtyGrp is not null) ((IFixEncoder)TradeQtyGrp).Encode(writer);
			if (TrdCapRptSideGrp is not null) ((IFixEncoder)TrdCapRptSideGrp).Encode(writer);
			if (Volatility is not null) writer.WriteNumber(1188, Volatility.Value);
			if (TimeToExpiration is not null) writer.WriteNumber(1189, TimeToExpiration.Value);
			if (DividendYield is not null) writer.WriteNumber(1380, DividendYield.Value);
			if (RiskFreeRate is not null) writer.WriteNumber(1190, RiskFreeRate.Value);
			if (PriceDelta is not null) writer.WriteNumber(811, PriceDelta.Value);
			if (CurrencyRatio is not null) writer.WriteNumber(1382, CurrencyRatio.Value);
			if (CopyMsgIndicator is not null) writer.WriteBoolean(797, CopyMsgIndicator.Value);
			if (TrdRepIndicatorsGrp is not null) ((IFixEncoder)TrdRepIndicatorsGrp).Encode(writer);
			if (TradeReportingIndicator is not null) writer.WriteWholeNumber(2524, TradeReportingIndicator.Value);
			if (PublishTrdIndicator is not null) writer.WriteBoolean(852, PublishTrdIndicator.Value);
			if (TradePublishIndicator is not null) writer.WriteWholeNumber(1390, TradePublishIndicator.Value);
			if (TrdRegPublicationGrp is not null) ((IFixEncoder)TrdRegPublicationGrp).Encode(writer);
			if (ShortSaleReason is not null) writer.WriteWholeNumber(853, ShortSaleReason.Value);
			if (TierCode is not null) writer.WriteString(994, TierCode);
			if (MessageEventSource is not null) writer.WriteString(1011, MessageEventSource);
			if (LastUpdateTime is not null) writer.WriteUtcTimeStamp(779, LastUpdateTime.Value);
			if (RndPx is not null) writer.WriteNumber(991, RndPx.Value);
			if (TZTransactTime is not null) writer.WriteString(1132, TZTransactTime);
			if (ReportedPxDiff is not null) writer.WriteBoolean(1134, ReportedPxDiff.Value);
			if (GrossTradeAmt is not null) writer.WriteNumber(381, GrossTradeAmt.Value);
			if (TotalGrossTradeAmt is not null) writer.WriteNumber(2369, TotalGrossTradeAmt.Value);
			if (TradeReportRejectReason is not null) writer.WriteWholeNumber(751, TradeReportRejectReason.Value);
			if (RejectText is not null) writer.WriteString(1328, RejectText);
			if (EncodedRejectTextLen is not null) writer.WriteWholeNumber(1664, EncodedRejectTextLen.Value);
			if (EncodedRejectText is not null) writer.WriteBuffer(1665, EncodedRejectText);
			if (FeeMultiplier is not null) writer.WriteNumber(1329, FeeMultiplier.Value);
			if (ClearedIndicator is not null) writer.WriteWholeNumber(1832, ClearedIndicator.Value);
			if (ClearingIntention is not null) writer.WriteWholeNumber(1924, ClearingIntention.Value);
			if (TradeClearingInstruction is not null) writer.WriteWholeNumber(1925, TradeClearingInstruction.Value);
			if (BackloadedTradeIndicator is not null) writer.WriteBoolean(1926, BackloadedTradeIndicator.Value);
			if (ConfirmationMethod is not null) writer.WriteWholeNumber(1927, ConfirmationMethod.Value);
			if (MandatoryClearingIndicator is not null) writer.WriteBoolean(1928, MandatoryClearingIndicator.Value);
			if (MandatoryClearingJurisdictionGrp is not null) ((IFixEncoder)MandatoryClearingJurisdictionGrp).Encode(writer);
			if (MixedSwapIndicator is not null) writer.WriteBoolean(1929, MixedSwapIndicator.Value);
			if (MultiAssetSwapIndicator is not null) writer.WriteBoolean(2527, MultiAssetSwapIndicator.Value);
			if (InternationalSwapIndicator is not null) writer.WriteBoolean(2526, InternationalSwapIndicator.Value);
			if (OffMarketPriceIndicator is not null) writer.WriteBoolean(1930, OffMarketPriceIndicator.Value);
			if (VerificationMethod is not null) writer.WriteWholeNumber(1931, VerificationMethod.Value);
			if (ClearingRequirementException is not null) writer.WriteWholeNumber(1932, ClearingRequirementException.Value);
			if (IRSDirection is not null) writer.WriteString(1933, IRSDirection);
			if (RegulatoryReportType is not null) writer.WriteWholeNumber(1934, RegulatoryReportType.Value);
			if (RegulatoryReportTypeBusinessDate is not null) writer.WriteLocalDateOnly(2869, RegulatoryReportTypeBusinessDate.Value);
			if (VoluntaryRegulatoryReport is not null) writer.WriteBoolean(1935, VoluntaryRegulatoryReport.Value);
			if (MultiJurisdictionReportingIndicator is not null) writer.WriteWholeNumber(2963, MultiJurisdictionReportingIndicator.Value);
			if (TradeCollateralization is not null) writer.WriteWholeNumber(1936, TradeCollateralization.Value);
			if (TradeContinuation is not null) writer.WriteWholeNumber(1937, TradeContinuation.Value);
			if (TradeContingency is not null) writer.WriteWholeNumber(2387, TradeContingency.Value);
			if (TradeVersion is not null) writer.WriteString(2302, TradeVersion);
			if (HistoricalReportIndicator is not null) writer.WriteBoolean(2303, HistoricalReportIndicator.Value);
			if (DeltaCrossed is not null) writer.WriteBoolean(2596, DeltaCrossed.Value);
			if (TradeContinuationText is not null) writer.WriteString(2374, TradeContinuationText);
			if (EncodedTradeContinuationTextLen is not null) writer.WriteWholeNumber(2372, EncodedTradeContinuationTextLen.Value);
			if (EncodedTradeContinuationText is not null) writer.WriteBuffer(2371, EncodedTradeContinuationText);
			if (IntraFirmTradeIndicator is not null) writer.WriteBoolean(2373, IntraFirmTradeIndicator.Value);
			if (AffiliatedFirmsTradeIndicator is not null) writer.WriteBoolean(2525, AffiliatedFirmsTradeIndicator.Value);
			if (AttachmentGrp is not null) ((IFixEncoder)AttachmentGrp).Encode(writer);
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
			if (view.GetView("ApplicationSequenceControl") is IMessageView viewApplicationSequenceControl)
			{
				ApplicationSequenceControl = new();
				((IFixParser)ApplicationSequenceControl).Parse(viewApplicationSequenceControl);
			}
			TradeReportID = view.GetString(571);
			TradeID = view.GetString(1003);
			SecondaryTradeID = view.GetString(1040);
			FirmTradeID = view.GetString(1041);
			SecondaryFirmTradeID = view.GetString(1042);
			PackageID = view.GetString(2489);
			TradeNumber = view.GetInt32(2490);
			TradeReportTransType = view.GetInt32(487);
			TradeReportType = view.GetInt32(856);
			TrdRptStatus = view.GetInt32(939);
			TradeRequestID = view.GetString(568);
			TrdType = view.GetInt32(828);
			TrdSubType = view.GetInt32(829);
			SecondaryTrdType = view.GetInt32(855);
			TertiaryTrdType = view.GetInt32(2896);
			AnonymousTradeIndicator = view.GetBool(2961);
			AlgorithmicTradeIndicator = view.GetInt32(2667);
			OffsetInstruction = view.GetInt32(1849);
			if (view.GetView("TradePriceConditionGrp") is IMessageView viewTradePriceConditionGrp)
			{
				TradePriceConditionGrp = new();
				((IFixParser)TradePriceConditionGrp).Parse(viewTradePriceConditionGrp);
			}
			TradeHandlingInstr = view.GetString(1123);
			OrigTradeHandlingInstr = view.GetString(1124);
			OrigTradeDate = view.GetDateOnly(1125);
			OrigTradeID = view.GetString(1126);
			OrigSecondaryTradeID = view.GetString(1127);
			TransferReason = view.GetString(830);
			ExecType = view.GetString(150);
			TotNumTradeReports = view.GetInt32(748);
			LastRptRequested = view.GetBool(912);
			ManualOrderIndicator = view.GetBool(1028);
			UnsolicitedIndicator = view.GetBool(325);
			SubscriptionRequestType = view.GetString(263);
			TradeReportRefID = view.GetString(572);
			SecondaryTradeReportRefID = view.GetString(881);
			SecondaryTradeReportID = view.GetString(818);
			TradeLinkID = view.GetString(820);
			TrdMatchID = view.GetString(880);
			ExecID = view.GetString(17);
			ExecRefID = view.GetString(19);
			SecondaryExecID = view.GetString(527);
			ExecRestatementReason = view.GetInt32(378);
			RegulatoryTransactionType = view.GetInt32(2347);
			if (view.GetView("RegulatoryTradeIDGrp") is IMessageView viewRegulatoryTradeIDGrp)
			{
				RegulatoryTradeIDGrp = new();
				((IFixParser)RegulatoryTradeIDGrp).Parse(viewRegulatoryTradeIDGrp);
			}
			PreviouslyReported = view.GetBool(570);
			PriceType = view.GetInt32(423);
			if (view.GetView("PriceQualifierGrp") is IMessageView viewPriceQualifierGrp)
			{
				PriceQualifierGrp = new();
				((IFixParser)PriceQualifierGrp).Parse(viewPriceQualifierGrp);
			}
			CrossType = view.GetInt32(549);
			if (view.GetView("RootParties") is IMessageView viewRootParties)
			{
				RootParties = new();
				((IFixParser)RootParties).Parse(viewRootParties);
			}
			AsOfIndicator = view.GetString(1015);
			SettlSessID = view.GetString(716);
			SettlSessSubID = view.GetString(717);
			VenueType = view.GetString(1430);
			MarketSegmentID = view.GetString(1300);
			MarketID = view.GetString(1301);
			TaxonomyType = view.GetString(2375);
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
			if (view.GetView("PaymentGrp") is IMessageView viewPaymentGrp)
			{
				PaymentGrp = new();
				((IFixParser)PaymentGrp).Parse(viewPaymentGrp);
			}
			QtyType = view.GetInt32(854);
			if (view.GetView("YieldData") is IMessageView viewYieldData)
			{
				YieldData = new();
				((IFixParser)YieldData).Parse(viewYieldData);
			}
			if (view.GetView("UndInstrmtGrp") is IMessageView viewUndInstrmtGrp)
			{
				UndInstrmtGrp = new();
				((IFixParser)UndInstrmtGrp).Parse(viewUndInstrmtGrp);
			}
			if (view.GetView("RelatedInstrumentGrp") is IMessageView viewRelatedInstrumentGrp)
			{
				RelatedInstrumentGrp = new();
				((IFixParser)RelatedInstrumentGrp).Parse(viewRelatedInstrumentGrp);
			}
			if (view.GetView("CollateralAmountGrp") is IMessageView viewCollateralAmountGrp)
			{
				CollateralAmountGrp = new();
				((IFixParser)CollateralAmountGrp).Parse(viewCollateralAmountGrp);
			}
			CollateralizationValueDate = view.GetDateOnly(2868);
			if (view.GetView("RateSource") is IMessageView viewRateSource)
			{
				RateSource = new();
				((IFixParser)RateSource).Parse(viewRateSource);
			}
			if (view.GetView("TransactionAttributeGrp") is IMessageView viewTransactionAttributeGrp)
			{
				TransactionAttributeGrp = new();
				((IFixParser)TransactionAttributeGrp).Parse(viewTransactionAttributeGrp);
			}
			UnderlyingTradingSessionID = view.GetString(822);
			UnderlyingTradingSessionSubID = view.GetString(823);
			LastQty = view.GetDouble(32);
			LastQtyVariance = view.GetDouble(1828);
			LastQtyChanged = view.GetDouble(2301);
			LastMultipliedQty = view.GetDouble(2368);
			TotalTradeQty = view.GetDouble(2367);
			TotalTradeMultipliedQty = view.GetDouble(2370);
			LastPx = view.GetDouble(31);
			MidPx = view.GetDouble(631);
			DifferentialPrice = view.GetDouble(1522);
			CalculatedCcyLastQty = view.GetDouble(1056);
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
			SettlPriceFxRateCalc = view.GetString(2366);
			LastParPx = view.GetDouble(669);
			LastSpotRate = view.GetDouble(194);
			LastForwardPoints = view.GetDouble(195);
			LastSwapPoints = view.GetDouble(1071);
			PricePrecision = view.GetInt32(2349);
			LastMkt = view.GetString(30);
			ClearingTradePrice = view.GetDouble(1596);
			TradePriceNegotiationMethod = view.GetInt32(1740);
			LastUpfrontPrice = view.GetDouble(1743);
			UpfrontPriceType = view.GetInt32(1741);
			TradeDate = view.GetDateOnly(75);
			ClearingBusinessDate = view.GetDateOnly(715);
			ClearingPortfolioID = view.GetString(2870);
			AvgPx = view.GetDouble(6);
			if (view.GetView("SpreadOrBenchmarkCurveData") is IMessageView viewSpreadOrBenchmarkCurveData)
			{
				SpreadOrBenchmarkCurveData = new();
				((IFixParser)SpreadOrBenchmarkCurveData).Parse(viewSpreadOrBenchmarkCurveData);
			}
			AvgPxGroupID = view.GetString(1731);
			AvgPxIndicator = view.GetInt32(819);
			ValuationDate = view.GetDateOnly(2085);
			ValuationTime = view.GetString(2086);
			ValuationBusinessCenter = view.GetString(2087);
			if (view.GetView("PositionAmountData") is IMessageView viewPositionAmountData)
			{
				PositionAmountData = new();
				((IFixParser)PositionAmountData).Parse(viewPositionAmountData);
			}
			MultiLegReportingType = view.GetString(442);
			TradeLegRefID = view.GetString(824);
			if (view.GetView("TrdInstrmtLegGrp") is IMessageView viewTrdInstrmtLegGrp)
			{
				TrdInstrmtLegGrp = new();
				((IFixParser)TrdInstrmtLegGrp).Parse(viewTrdInstrmtLegGrp);
			}
			TransactTime = view.GetDateTime(60);
			if (view.GetView("TrdRegTimestamps") is IMessageView viewTrdRegTimestamps)
			{
				TrdRegTimestamps = new();
				((IFixParser)TrdRegTimestamps).Parse(viewTrdRegTimestamps);
			}
			SettlType = view.GetString(63);
			SettlDate = view.GetDateOnly(64);
			TerminationDate = view.GetDateOnly(2878);
			UnderlyingSettlementDate = view.GetDateOnly(987);
			MatchStatus = view.GetString(573);
			ExecMethod = view.GetInt32(2405);
			MatchType = view.GetString(574);
			if (view.GetView("TradeQtyGrp") is IMessageView viewTradeQtyGrp)
			{
				TradeQtyGrp = new();
				((IFixParser)TradeQtyGrp).Parse(viewTradeQtyGrp);
			}
			if (view.GetView("TrdCapRptSideGrp") is IMessageView viewTrdCapRptSideGrp)
			{
				TrdCapRptSideGrp = new();
				((IFixParser)TrdCapRptSideGrp).Parse(viewTrdCapRptSideGrp);
			}
			Volatility = view.GetDouble(1188);
			TimeToExpiration = view.GetDouble(1189);
			DividendYield = view.GetDouble(1380);
			RiskFreeRate = view.GetDouble(1190);
			PriceDelta = view.GetDouble(811);
			CurrencyRatio = view.GetDouble(1382);
			CopyMsgIndicator = view.GetBool(797);
			if (view.GetView("TrdRepIndicatorsGrp") is IMessageView viewTrdRepIndicatorsGrp)
			{
				TrdRepIndicatorsGrp = new();
				((IFixParser)TrdRepIndicatorsGrp).Parse(viewTrdRepIndicatorsGrp);
			}
			TradeReportingIndicator = view.GetInt32(2524);
			PublishTrdIndicator = view.GetBool(852);
			TradePublishIndicator = view.GetInt32(1390);
			if (view.GetView("TrdRegPublicationGrp") is IMessageView viewTrdRegPublicationGrp)
			{
				TrdRegPublicationGrp = new();
				((IFixParser)TrdRegPublicationGrp).Parse(viewTrdRegPublicationGrp);
			}
			ShortSaleReason = view.GetInt32(853);
			TierCode = view.GetString(994);
			MessageEventSource = view.GetString(1011);
			LastUpdateTime = view.GetDateTime(779);
			RndPx = view.GetDouble(991);
			TZTransactTime = view.GetString(1132);
			ReportedPxDiff = view.GetBool(1134);
			GrossTradeAmt = view.GetDouble(381);
			TotalGrossTradeAmt = view.GetDouble(2369);
			TradeReportRejectReason = view.GetInt32(751);
			RejectText = view.GetString(1328);
			EncodedRejectTextLen = view.GetInt32(1664);
			EncodedRejectText = view.GetByteArray(1665);
			FeeMultiplier = view.GetDouble(1329);
			ClearedIndicator = view.GetInt32(1832);
			ClearingIntention = view.GetInt32(1924);
			TradeClearingInstruction = view.GetInt32(1925);
			BackloadedTradeIndicator = view.GetBool(1926);
			ConfirmationMethod = view.GetInt32(1927);
			MandatoryClearingIndicator = view.GetBool(1928);
			if (view.GetView("MandatoryClearingJurisdictionGrp") is IMessageView viewMandatoryClearingJurisdictionGrp)
			{
				MandatoryClearingJurisdictionGrp = new();
				((IFixParser)MandatoryClearingJurisdictionGrp).Parse(viewMandatoryClearingJurisdictionGrp);
			}
			MixedSwapIndicator = view.GetBool(1929);
			MultiAssetSwapIndicator = view.GetBool(2527);
			InternationalSwapIndicator = view.GetBool(2526);
			OffMarketPriceIndicator = view.GetBool(1930);
			VerificationMethod = view.GetInt32(1931);
			ClearingRequirementException = view.GetInt32(1932);
			IRSDirection = view.GetString(1933);
			RegulatoryReportType = view.GetInt32(1934);
			RegulatoryReportTypeBusinessDate = view.GetDateOnly(2869);
			VoluntaryRegulatoryReport = view.GetBool(1935);
			MultiJurisdictionReportingIndicator = view.GetInt32(2963);
			TradeCollateralization = view.GetInt32(1936);
			TradeContinuation = view.GetInt32(1937);
			TradeContingency = view.GetInt32(2387);
			TradeVersion = view.GetString(2302);
			HistoricalReportIndicator = view.GetBool(2303);
			DeltaCrossed = view.GetBool(2596);
			TradeContinuationText = view.GetString(2374);
			EncodedTradeContinuationTextLen = view.GetInt32(2372);
			EncodedTradeContinuationText = view.GetByteArray(2371);
			IntraFirmTradeIndicator = view.GetBool(2373);
			AffiliatedFirmsTradeIndicator = view.GetBool(2525);
			if (view.GetView("AttachmentGrp") is IMessageView viewAttachmentGrp)
			{
				AttachmentGrp = new();
				((IFixParser)AttachmentGrp).Parse(viewAttachmentGrp);
			}
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
				case "ApplicationSequenceControl":
				{
					value = ApplicationSequenceControl;
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
				case "PackageID":
				{
					value = PackageID;
					break;
				}
				case "TradeNumber":
				{
					value = TradeNumber;
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
				case "TrdRptStatus":
				{
					value = TrdRptStatus;
					break;
				}
				case "TradeRequestID":
				{
					value = TradeRequestID;
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
				case "TertiaryTrdType":
				{
					value = TertiaryTrdType;
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
				case "OffsetInstruction":
				{
					value = OffsetInstruction;
					break;
				}
				case "TradePriceConditionGrp":
				{
					value = TradePriceConditionGrp;
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
				case "ExecType":
				{
					value = ExecType;
					break;
				}
				case "TotNumTradeReports":
				{
					value = TotNumTradeReports;
					break;
				}
				case "LastRptRequested":
				{
					value = LastRptRequested;
					break;
				}
				case "ManualOrderIndicator":
				{
					value = ManualOrderIndicator;
					break;
				}
				case "UnsolicitedIndicator":
				{
					value = UnsolicitedIndicator;
					break;
				}
				case "SubscriptionRequestType":
				{
					value = SubscriptionRequestType;
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
				case "SecondaryTradeReportID":
				{
					value = SecondaryTradeReportID;
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
				case "ExecRefID":
				{
					value = ExecRefID;
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
				case "RootParties":
				{
					value = RootParties;
					break;
				}
				case "AsOfIndicator":
				{
					value = AsOfIndicator;
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
				case "TaxonomyType":
				{
					value = TaxonomyType;
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
				case "PaymentGrp":
				{
					value = PaymentGrp;
					break;
				}
				case "QtyType":
				{
					value = QtyType;
					break;
				}
				case "YieldData":
				{
					value = YieldData;
					break;
				}
				case "UndInstrmtGrp":
				{
					value = UndInstrmtGrp;
					break;
				}
				case "RelatedInstrumentGrp":
				{
					value = RelatedInstrumentGrp;
					break;
				}
				case "CollateralAmountGrp":
				{
					value = CollateralAmountGrp;
					break;
				}
				case "CollateralizationValueDate":
				{
					value = CollateralizationValueDate;
					break;
				}
				case "RateSource":
				{
					value = RateSource;
					break;
				}
				case "TransactionAttributeGrp":
				{
					value = TransactionAttributeGrp;
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
				case "LastQty":
				{
					value = LastQty;
					break;
				}
				case "LastQtyVariance":
				{
					value = LastQtyVariance;
					break;
				}
				case "LastQtyChanged":
				{
					value = LastQtyChanged;
					break;
				}
				case "LastMultipliedQty":
				{
					value = LastMultipliedQty;
					break;
				}
				case "TotalTradeQty":
				{
					value = TotalTradeQty;
					break;
				}
				case "TotalTradeMultipliedQty":
				{
					value = TotalTradeMultipliedQty;
					break;
				}
				case "LastPx":
				{
					value = LastPx;
					break;
				}
				case "MidPx":
				{
					value = MidPx;
					break;
				}
				case "DifferentialPrice":
				{
					value = DifferentialPrice;
					break;
				}
				case "CalculatedCcyLastQty":
				{
					value = CalculatedCcyLastQty;
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
				case "SettlPriceFxRateCalc":
				{
					value = SettlPriceFxRateCalc;
					break;
				}
				case "LastParPx":
				{
					value = LastParPx;
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
				case "LastSwapPoints":
				{
					value = LastSwapPoints;
					break;
				}
				case "PricePrecision":
				{
					value = PricePrecision;
					break;
				}
				case "LastMkt":
				{
					value = LastMkt;
					break;
				}
				case "ClearingTradePrice":
				{
					value = ClearingTradePrice;
					break;
				}
				case "TradePriceNegotiationMethod":
				{
					value = TradePriceNegotiationMethod;
					break;
				}
				case "LastUpfrontPrice":
				{
					value = LastUpfrontPrice;
					break;
				}
				case "UpfrontPriceType":
				{
					value = UpfrontPriceType;
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
				case "ClearingPortfolioID":
				{
					value = ClearingPortfolioID;
					break;
				}
				case "AvgPx":
				{
					value = AvgPx;
					break;
				}
				case "SpreadOrBenchmarkCurveData":
				{
					value = SpreadOrBenchmarkCurveData;
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
				case "ValuationDate":
				{
					value = ValuationDate;
					break;
				}
				case "ValuationTime":
				{
					value = ValuationTime;
					break;
				}
				case "ValuationBusinessCenter":
				{
					value = ValuationBusinessCenter;
					break;
				}
				case "PositionAmountData":
				{
					value = PositionAmountData;
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
				case "TrdInstrmtLegGrp":
				{
					value = TrdInstrmtLegGrp;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "TrdRegTimestamps":
				{
					value = TrdRegTimestamps;
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
				case "TerminationDate":
				{
					value = TerminationDate;
					break;
				}
				case "UnderlyingSettlementDate":
				{
					value = UnderlyingSettlementDate;
					break;
				}
				case "MatchStatus":
				{
					value = MatchStatus;
					break;
				}
				case "ExecMethod":
				{
					value = ExecMethod;
					break;
				}
				case "MatchType":
				{
					value = MatchType;
					break;
				}
				case "TradeQtyGrp":
				{
					value = TradeQtyGrp;
					break;
				}
				case "TrdCapRptSideGrp":
				{
					value = TrdCapRptSideGrp;
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
				case "DividendYield":
				{
					value = DividendYield;
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
				case "CurrencyRatio":
				{
					value = CurrencyRatio;
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
				case "TradeReportingIndicator":
				{
					value = TradeReportingIndicator;
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
				case "TrdRegPublicationGrp":
				{
					value = TrdRegPublicationGrp;
					break;
				}
				case "ShortSaleReason":
				{
					value = ShortSaleReason;
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
				case "TZTransactTime":
				{
					value = TZTransactTime;
					break;
				}
				case "ReportedPxDiff":
				{
					value = ReportedPxDiff;
					break;
				}
				case "GrossTradeAmt":
				{
					value = GrossTradeAmt;
					break;
				}
				case "TotalGrossTradeAmt":
				{
					value = TotalGrossTradeAmt;
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
				case "FeeMultiplier":
				{
					value = FeeMultiplier;
					break;
				}
				case "ClearedIndicator":
				{
					value = ClearedIndicator;
					break;
				}
				case "ClearingIntention":
				{
					value = ClearingIntention;
					break;
				}
				case "TradeClearingInstruction":
				{
					value = TradeClearingInstruction;
					break;
				}
				case "BackloadedTradeIndicator":
				{
					value = BackloadedTradeIndicator;
					break;
				}
				case "ConfirmationMethod":
				{
					value = ConfirmationMethod;
					break;
				}
				case "MandatoryClearingIndicator":
				{
					value = MandatoryClearingIndicator;
					break;
				}
				case "MandatoryClearingJurisdictionGrp":
				{
					value = MandatoryClearingJurisdictionGrp;
					break;
				}
				case "MixedSwapIndicator":
				{
					value = MixedSwapIndicator;
					break;
				}
				case "MultiAssetSwapIndicator":
				{
					value = MultiAssetSwapIndicator;
					break;
				}
				case "InternationalSwapIndicator":
				{
					value = InternationalSwapIndicator;
					break;
				}
				case "OffMarketPriceIndicator":
				{
					value = OffMarketPriceIndicator;
					break;
				}
				case "VerificationMethod":
				{
					value = VerificationMethod;
					break;
				}
				case "ClearingRequirementException":
				{
					value = ClearingRequirementException;
					break;
				}
				case "IRSDirection":
				{
					value = IRSDirection;
					break;
				}
				case "RegulatoryReportType":
				{
					value = RegulatoryReportType;
					break;
				}
				case "RegulatoryReportTypeBusinessDate":
				{
					value = RegulatoryReportTypeBusinessDate;
					break;
				}
				case "VoluntaryRegulatoryReport":
				{
					value = VoluntaryRegulatoryReport;
					break;
				}
				case "MultiJurisdictionReportingIndicator":
				{
					value = MultiJurisdictionReportingIndicator;
					break;
				}
				case "TradeCollateralization":
				{
					value = TradeCollateralization;
					break;
				}
				case "TradeContinuation":
				{
					value = TradeContinuation;
					break;
				}
				case "TradeContingency":
				{
					value = TradeContingency;
					break;
				}
				case "TradeVersion":
				{
					value = TradeVersion;
					break;
				}
				case "HistoricalReportIndicator":
				{
					value = HistoricalReportIndicator;
					break;
				}
				case "DeltaCrossed":
				{
					value = DeltaCrossed;
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
				case "IntraFirmTradeIndicator":
				{
					value = IntraFirmTradeIndicator;
					break;
				}
				case "AffiliatedFirmsTradeIndicator":
				{
					value = AffiliatedFirmsTradeIndicator;
					break;
				}
				case "AttachmentGrp":
				{
					value = AttachmentGrp;
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
			((IFixReset?)ApplicationSequenceControl)?.Reset();
			TradeReportID = null;
			TradeID = null;
			SecondaryTradeID = null;
			FirmTradeID = null;
			SecondaryFirmTradeID = null;
			PackageID = null;
			TradeNumber = null;
			TradeReportTransType = null;
			TradeReportType = null;
			TrdRptStatus = null;
			TradeRequestID = null;
			TrdType = null;
			TrdSubType = null;
			SecondaryTrdType = null;
			TertiaryTrdType = null;
			AnonymousTradeIndicator = null;
			AlgorithmicTradeIndicator = null;
			OffsetInstruction = null;
			((IFixReset?)TradePriceConditionGrp)?.Reset();
			TradeHandlingInstr = null;
			OrigTradeHandlingInstr = null;
			OrigTradeDate = null;
			OrigTradeID = null;
			OrigSecondaryTradeID = null;
			TransferReason = null;
			ExecType = null;
			TotNumTradeReports = null;
			LastRptRequested = null;
			ManualOrderIndicator = null;
			UnsolicitedIndicator = null;
			SubscriptionRequestType = null;
			TradeReportRefID = null;
			SecondaryTradeReportRefID = null;
			SecondaryTradeReportID = null;
			TradeLinkID = null;
			TrdMatchID = null;
			ExecID = null;
			ExecRefID = null;
			SecondaryExecID = null;
			ExecRestatementReason = null;
			RegulatoryTransactionType = null;
			((IFixReset?)RegulatoryTradeIDGrp)?.Reset();
			PreviouslyReported = null;
			PriceType = null;
			((IFixReset?)PriceQualifierGrp)?.Reset();
			CrossType = null;
			((IFixReset?)RootParties)?.Reset();
			AsOfIndicator = null;
			SettlSessID = null;
			SettlSessSubID = null;
			VenueType = null;
			MarketSegmentID = null;
			MarketID = null;
			TaxonomyType = null;
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)InstrumentExtension)?.Reset();
			((IFixReset?)FinancingDetails)?.Reset();
			((IFixReset?)PaymentGrp)?.Reset();
			QtyType = null;
			((IFixReset?)YieldData)?.Reset();
			((IFixReset?)UndInstrmtGrp)?.Reset();
			((IFixReset?)RelatedInstrumentGrp)?.Reset();
			((IFixReset?)CollateralAmountGrp)?.Reset();
			CollateralizationValueDate = null;
			((IFixReset?)RateSource)?.Reset();
			((IFixReset?)TransactionAttributeGrp)?.Reset();
			UnderlyingTradingSessionID = null;
			UnderlyingTradingSessionSubID = null;
			LastQty = null;
			LastQtyVariance = null;
			LastQtyChanged = null;
			LastMultipliedQty = null;
			TotalTradeQty = null;
			TotalTradeMultipliedQty = null;
			LastPx = null;
			MidPx = null;
			DifferentialPrice = null;
			CalculatedCcyLastQty = null;
			PriceMarkup = null;
			((IFixReset?)AveragePriceDetail)?.Reset();
			Currency = null;
			CurrencyCodeSource = null;
			SettlCurrency = null;
			SettlCurrencyCodeSource = null;
			SettlPriceFxRateCalc = null;
			LastParPx = null;
			LastSpotRate = null;
			LastForwardPoints = null;
			LastSwapPoints = null;
			PricePrecision = null;
			LastMkt = null;
			ClearingTradePrice = null;
			TradePriceNegotiationMethod = null;
			LastUpfrontPrice = null;
			UpfrontPriceType = null;
			TradeDate = null;
			ClearingBusinessDate = null;
			ClearingPortfolioID = null;
			AvgPx = null;
			((IFixReset?)SpreadOrBenchmarkCurveData)?.Reset();
			AvgPxGroupID = null;
			AvgPxIndicator = null;
			ValuationDate = null;
			ValuationTime = null;
			ValuationBusinessCenter = null;
			((IFixReset?)PositionAmountData)?.Reset();
			MultiLegReportingType = null;
			TradeLegRefID = null;
			((IFixReset?)TrdInstrmtLegGrp)?.Reset();
			TransactTime = null;
			((IFixReset?)TrdRegTimestamps)?.Reset();
			SettlType = null;
			SettlDate = null;
			TerminationDate = null;
			UnderlyingSettlementDate = null;
			MatchStatus = null;
			ExecMethod = null;
			MatchType = null;
			((IFixReset?)TradeQtyGrp)?.Reset();
			((IFixReset?)TrdCapRptSideGrp)?.Reset();
			Volatility = null;
			TimeToExpiration = null;
			DividendYield = null;
			RiskFreeRate = null;
			PriceDelta = null;
			CurrencyRatio = null;
			CopyMsgIndicator = null;
			((IFixReset?)TrdRepIndicatorsGrp)?.Reset();
			TradeReportingIndicator = null;
			PublishTrdIndicator = null;
			TradePublishIndicator = null;
			((IFixReset?)TrdRegPublicationGrp)?.Reset();
			ShortSaleReason = null;
			TierCode = null;
			MessageEventSource = null;
			LastUpdateTime = null;
			RndPx = null;
			TZTransactTime = null;
			ReportedPxDiff = null;
			GrossTradeAmt = null;
			TotalGrossTradeAmt = null;
			TradeReportRejectReason = null;
			RejectText = null;
			EncodedRejectTextLen = null;
			EncodedRejectText = null;
			FeeMultiplier = null;
			ClearedIndicator = null;
			ClearingIntention = null;
			TradeClearingInstruction = null;
			BackloadedTradeIndicator = null;
			ConfirmationMethod = null;
			MandatoryClearingIndicator = null;
			((IFixReset?)MandatoryClearingJurisdictionGrp)?.Reset();
			MixedSwapIndicator = null;
			MultiAssetSwapIndicator = null;
			InternationalSwapIndicator = null;
			OffMarketPriceIndicator = null;
			VerificationMethod = null;
			ClearingRequirementException = null;
			IRSDirection = null;
			RegulatoryReportType = null;
			RegulatoryReportTypeBusinessDate = null;
			VoluntaryRegulatoryReport = null;
			MultiJurisdictionReportingIndicator = null;
			TradeCollateralization = null;
			TradeContinuation = null;
			TradeContingency = null;
			TradeVersion = null;
			HistoricalReportIndicator = null;
			DeltaCrossed = null;
			TradeContinuationText = null;
			EncodedTradeContinuationTextLen = null;
			EncodedTradeContinuationText = null;
			IntraFirmTradeIndicator = null;
			AffiliatedFirmsTradeIndicator = null;
			((IFixReset?)AttachmentGrp)?.Reset();
			RiskLimitCheckStatus = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
