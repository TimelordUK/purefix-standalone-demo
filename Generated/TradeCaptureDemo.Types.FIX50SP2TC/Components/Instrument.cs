using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class Instrument : IFixComponent
	{
		[TagDetails(Tag = 55, Type = TagType.String, Offset = 0, Required = false)]
		public string? Symbol {get; set;}
		
		[TagDetails(Tag = 65, Type = TagType.String, Offset = 1, Required = false)]
		public string? SymbolSfx {get; set;}
		
		[TagDetails(Tag = 48, Type = TagType.String, Offset = 2, Required = false)]
		public string? SecurityID {get; set;}
		
		[TagDetails(Tag = 22, Type = TagType.String, Offset = 3, Required = false)]
		public string? SecurityIDSource {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public SecAltIDGrp? SecAltIDGrp {get; set;}
		
		[TagDetails(Tag = 460, Type = TagType.Int, Offset = 5, Required = false)]
		public int? Product {get; set;}
		
		[TagDetails(Tag = 1227, Type = TagType.String, Offset = 6, Required = false)]
		public string? ProductComplex {get; set;}
		
		[TagDetails(Tag = 1151, Type = TagType.String, Offset = 7, Required = false)]
		public string? SecurityGroup {get; set;}
		
		[TagDetails(Tag = 461, Type = TagType.String, Offset = 8, Required = false)]
		public string? CFICode {get; set;}
		
		[TagDetails(Tag = 2891, Type = TagType.String, Offset = 9, Required = false)]
		public string? UPICode {get; set;}
		
		[TagDetails(Tag = 167, Type = TagType.String, Offset = 10, Required = false)]
		public string? SecurityType {get; set;}
		
		[TagDetails(Tag = 762, Type = TagType.String, Offset = 11, Required = false)]
		public string? SecuritySubType {get; set;}
		
		[TagDetails(Tag = 15, Type = TagType.String, Offset = 12, Required = false)]
		public string? Currency {get; set;}
		
		[TagDetails(Tag = 20460, Type = TagType.String, Offset = 13, Required = false)]
		public string? InstrumentCustom {get; set;}
		
		[TagDetails(Tag = 200, Type = TagType.MonthYear, Offset = 14, Required = false)]
		public MonthYear? MaturityMonthYear {get; set;}
		
		[TagDetails(Tag = 541, Type = TagType.LocalDate, Offset = 15, Required = false)]
		public DateOnly? MaturityDate {get; set;}
		
		[TagDetails(Tag = 1079, Type = TagType.String, Offset = 16, Required = false)]
		public string? MaturityTime {get; set;}
		
		[TagDetails(Tag = 966, Type = TagType.String, Offset = 17, Required = false)]
		public string? SettleOnOpenFlag {get; set;}
		
		[TagDetails(Tag = 1049, Type = TagType.String, Offset = 18, Required = false)]
		public string? InstrmtAssignmentMethod {get; set;}
		
		[TagDetails(Tag = 965, Type = TagType.String, Offset = 19, Required = false)]
		public string? SecurityStatus {get; set;}
		
		[TagDetails(Tag = 224, Type = TagType.LocalDate, Offset = 20, Required = false)]
		public DateOnly? CouponPaymentDate {get; set;}
		
		[TagDetails(Tag = 1449, Type = TagType.String, Offset = 21, Required = false)]
		public string? RestructuringType {get; set;}
		
		[TagDetails(Tag = 1450, Type = TagType.String, Offset = 22, Required = false)]
		public string? Seniority {get; set;}
		
		[TagDetails(Tag = 1451, Type = TagType.Float, Offset = 23, Required = false)]
		public double? NotionalPercentageOutstanding {get; set;}
		
		[TagDetails(Tag = 1452, Type = TagType.Float, Offset = 24, Required = false)]
		public double? OriginalNotionalPercentageOutstanding {get; set;}
		
		[TagDetails(Tag = 1457, Type = TagType.Float, Offset = 25, Required = false)]
		public double? AttachmentPoint {get; set;}
		
		[TagDetails(Tag = 1458, Type = TagType.Float, Offset = 26, Required = false)]
		public double? DetachmentPoint {get; set;}
		
		[TagDetails(Tag = 1739, Type = TagType.String, Offset = 27, Required = false)]
		public string? ObligationType {get; set;}
		
		[TagDetails(Tag = 2210, Type = TagType.Int, Offset = 28, Required = false)]
		public int? AssetGroup {get; set;}
		
		[TagDetails(Tag = 1938, Type = TagType.Int, Offset = 29, Required = false)]
		public int? AssetClass {get; set;}
		
		[TagDetails(Tag = 1939, Type = TagType.Int, Offset = 30, Required = false)]
		public int? AssetSubClass {get; set;}
		
		[TagDetails(Tag = 1940, Type = TagType.String, Offset = 31, Required = false)]
		public string? AssetType {get; set;}
		
		[TagDetails(Tag = 2735, Type = TagType.String, Offset = 32, Required = false)]
		public string? AssetSubType {get; set;}
		
		[Component(Offset = 33, Required = false)]
		public SecondaryAssetGrp? SecondaryAssetGrp {get; set;}
		
		[Component(Offset = 34, Required = false)]
		public AssetAttributeGrp? AssetAttributeGrp {get; set;}
		
		[TagDetails(Tag = 1941, Type = TagType.String, Offset = 35, Required = false)]
		public string? SwapClass {get; set;}
		
		[TagDetails(Tag = 1575, Type = TagType.String, Offset = 36, Required = false)]
		public string? SwapSubClass {get; set;}
		
		[TagDetails(Tag = 1942, Type = TagType.Int, Offset = 37, Required = false)]
		public int? NthToDefault {get; set;}
		
		[TagDetails(Tag = 1943, Type = TagType.Int, Offset = 38, Required = false)]
		public int? MthToDefault {get; set;}
		
		[TagDetails(Tag = 1944, Type = TagType.String, Offset = 39, Required = false)]
		public string? SettledEntityMatrixSource {get; set;}
		
		[TagDetails(Tag = 1945, Type = TagType.LocalDate, Offset = 40, Required = false)]
		public DateOnly? SettledEntityMatrixPublicationDate {get; set;}
		
		[TagDetails(Tag = 1946, Type = TagType.Int, Offset = 41, Required = false)]
		public int? CouponType {get; set;}
		
		[TagDetails(Tag = 1947, Type = TagType.Float, Offset = 42, Required = false)]
		public double? TotalIssuedAmount {get; set;}
		
		[TagDetails(Tag = 1948, Type = TagType.Int, Offset = 43, Required = false)]
		public int? CouponFrequencyPeriod {get; set;}
		
		[TagDetails(Tag = 1949, Type = TagType.String, Offset = 44, Required = false)]
		public string? CouponFrequencyUnit {get; set;}
		
		[TagDetails(Tag = 1950, Type = TagType.Int, Offset = 45, Required = false)]
		public int? CouponDayCount {get; set;}
		
		[TagDetails(Tag = 2879, Type = TagType.String, Offset = 46, Required = false)]
		public string? CouponOtherDayCount {get; set;}
		
		[TagDetails(Tag = 1951, Type = TagType.String, Offset = 47, Required = false)]
		public string? ConvertibleBondEquityID {get; set;}
		
		[TagDetails(Tag = 1952, Type = TagType.String, Offset = 48, Required = false)]
		public string? ConvertibleBondEquityIDSource {get; set;}
		
		[TagDetails(Tag = 1953, Type = TagType.MonthYear, Offset = 49, Required = false)]
		public MonthYear? ContractPriceRefMonth {get; set;}
		
		[TagDetails(Tag = 1954, Type = TagType.Int, Offset = 50, Required = false)]
		public int? LienSeniority {get; set;}
		
		[TagDetails(Tag = 1955, Type = TagType.Int, Offset = 51, Required = false)]
		public int? LoanFacility {get; set;}
		
		[TagDetails(Tag = 1956, Type = TagType.Int, Offset = 52, Required = false)]
		public int? ReferenceEntityType {get; set;}
		
		[TagDetails(Tag = 1957, Type = TagType.Int, Offset = 53, Required = false)]
		public int? IndexSeries {get; set;}
		
		[TagDetails(Tag = 1958, Type = TagType.Int, Offset = 54, Required = false)]
		public int? IndexAnnexVersion {get; set;}
		
		[TagDetails(Tag = 1959, Type = TagType.LocalDate, Offset = 55, Required = false)]
		public DateOnly? IndexAnnexDate {get; set;}
		
		[TagDetails(Tag = 1960, Type = TagType.String, Offset = 56, Required = false)]
		public string? IndexAnnexSource {get; set;}
		
		[TagDetails(Tag = 1577, Type = TagType.String, Offset = 57, Required = false)]
		public string? SettlRateIndex {get; set;}
		
		[TagDetails(Tag = 1580, Type = TagType.String, Offset = 58, Required = false)]
		public string? SettlRateIndexLocation {get; set;}
		
		[TagDetails(Tag = 1581, Type = TagType.String, Offset = 59, Required = false)]
		public string? OptionExpirationDesc {get; set;}
		
		[TagDetails(Tag = 1678, Type = TagType.Length, Offset = 60, Required = false)]
		public int? EncodedOptionExpirationDescLen {get; set;}
		
		[TagDetails(Tag = 1697, Type = TagType.RawData, Offset = 61, Required = false)]
		public byte[]? EncodedOptionExpirationDesc {get; set;}
		
		[TagDetails(Tag = 225, Type = TagType.LocalDate, Offset = 62, Required = false)]
		public DateOnly? IssueDate {get; set;}
		
		[TagDetails(Tag = 239, Type = TagType.String, Offset = 63, Required = false)]
		public string? RepoCollateralSecurityType {get; set;}
		
		[TagDetails(Tag = 226, Type = TagType.Int, Offset = 64, Required = false)]
		public int? RepurchaseTerm {get; set;}
		
		[TagDetails(Tag = 227, Type = TagType.Float, Offset = 65, Required = false)]
		public double? RepurchaseRate {get; set;}
		
		[TagDetails(Tag = 228, Type = TagType.Float, Offset = 66, Required = false)]
		public double? Factor {get; set;}
		
		[TagDetails(Tag = 255, Type = TagType.String, Offset = 67, Required = false)]
		public string? CreditRating {get; set;}
		
		[TagDetails(Tag = 543, Type = TagType.String, Offset = 68, Required = false)]
		public string? InstrRegistry {get; set;}
		
		[TagDetails(Tag = 470, Type = TagType.String, Offset = 69, Required = false)]
		public string? CountryOfIssue {get; set;}
		
		[TagDetails(Tag = 471, Type = TagType.String, Offset = 70, Required = false)]
		public string? StateOrProvinceOfIssue {get; set;}
		
		[TagDetails(Tag = 472, Type = TagType.String, Offset = 71, Required = false)]
		public string? LocaleOfIssue {get; set;}
		
		[TagDetails(Tag = 240, Type = TagType.LocalDate, Offset = 72, Required = false)]
		public DateOnly? RedemptionDate {get; set;}
		
		[TagDetails(Tag = 202, Type = TagType.Float, Offset = 73, Required = false)]
		public double? StrikePrice {get; set;}
		
		[TagDetails(Tag = 2578, Type = TagType.Float, Offset = 74, Required = false)]
		public double? OrigStrikePrice {get; set;}
		
		[TagDetails(Tag = 2577, Type = TagType.Int, Offset = 75, Required = false)]
		public int? StrikePricePrecision {get; set;}
		
		[TagDetails(Tag = 947, Type = TagType.String, Offset = 76, Required = false)]
		public string? StrikeCurrency {get; set;}
		
		[TagDetails(Tag = 2904, Type = TagType.String, Offset = 77, Required = false)]
		public string? StrikeCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 967, Type = TagType.Float, Offset = 78, Required = false)]
		public double? StrikeMultiplier {get; set;}
		
		[TagDetails(Tag = 968, Type = TagType.Float, Offset = 79, Required = false)]
		public double? StrikeValue {get; set;}
		
		[TagDetails(Tag = 1698, Type = TagType.String, Offset = 80, Required = false)]
		public string? StrikeUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 1866, Type = TagType.String, Offset = 81, Required = false)]
		public string? StrikeIndex {get; set;}
		
		[TagDetails(Tag = 2600, Type = TagType.String, Offset = 82, Required = false)]
		public string? StrikeIndexCurvePoint {get; set;}
		
		[TagDetails(Tag = 2001, Type = TagType.Float, Offset = 83, Required = false)]
		public double? StrikeIndexSpread {get; set;}
		
		[TagDetails(Tag = 2601, Type = TagType.Int, Offset = 84, Required = false)]
		public int? StrikeIndexQuote {get; set;}
		
		[TagDetails(Tag = 1478, Type = TagType.Int, Offset = 85, Required = false)]
		public int? StrikePriceDeterminationMethod {get; set;}
		
		[TagDetails(Tag = 1479, Type = TagType.Int, Offset = 86, Required = false)]
		public int? StrikePriceBoundaryMethod {get; set;}
		
		[TagDetails(Tag = 1480, Type = TagType.Float, Offset = 87, Required = false)]
		public double? StrikePriceBoundaryPrecision {get; set;}
		
		[TagDetails(Tag = 1481, Type = TagType.Int, Offset = 88, Required = false)]
		public int? UnderlyingPriceDeterminationMethod {get; set;}
		
		[TagDetails(Tag = 206, Type = TagType.String, Offset = 89, Required = false)]
		public string? OptAttribute {get; set;}
		
		[TagDetails(Tag = 231, Type = TagType.Float, Offset = 90, Required = false)]
		public double? ContractMultiplier {get; set;}
		
		[TagDetails(Tag = 1435, Type = TagType.Int, Offset = 91, Required = false)]
		public int? ContractMultiplierUnit {get; set;}
		
		[TagDetails(Tag = 2353, Type = TagType.Int, Offset = 92, Required = false)]
		public int? TradingUnitPeriodMultiplier {get; set;}
		
		[TagDetails(Tag = 1439, Type = TagType.Int, Offset = 93, Required = false)]
		public int? FlowScheduleType {get; set;}
		
		[TagDetails(Tag = 969, Type = TagType.Float, Offset = 94, Required = false)]
		public double? MinPriceIncrement {get; set;}
		
		[TagDetails(Tag = 1146, Type = TagType.Float, Offset = 95, Required = false)]
		public double? MinPriceIncrementAmount {get; set;}
		
		[TagDetails(Tag = 996, Type = TagType.String, Offset = 96, Required = false)]
		public string? UnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 1147, Type = TagType.Float, Offset = 97, Required = false)]
		public double? UnitOfMeasureQty {get; set;}
		
		[TagDetails(Tag = 1716, Type = TagType.String, Offset = 98, Required = false)]
		public string? UnitOfMeasureCurrency {get; set;}
		
		[TagDetails(Tag = 2905, Type = TagType.String, Offset = 99, Required = false)]
		public string? UnitOfMeasureCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 1191, Type = TagType.String, Offset = 100, Required = false)]
		public string? PriceUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 1192, Type = TagType.Float, Offset = 101, Required = false)]
		public double? PriceUnitOfMeasureQty {get; set;}
		
		[TagDetails(Tag = 1717, Type = TagType.String, Offset = 102, Required = false)]
		public string? PriceUnitOfMeasureCurrency {get; set;}
		
		[TagDetails(Tag = 2906, Type = TagType.String, Offset = 103, Required = false)]
		public string? PriceUnitOfMeasureCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 1193, Type = TagType.String, Offset = 104, Required = false)]
		public string? SettlMethod {get; set;}
		
		[TagDetails(Tag = 2579, Type = TagType.Int, Offset = 105, Required = false)]
		public int? SettlSubMethod {get; set;}
		
		[TagDetails(Tag = 1194, Type = TagType.Int, Offset = 106, Required = false)]
		public int? ExerciseStyle {get; set;}
		
		[TagDetails(Tag = 1482, Type = TagType.Int, Offset = 107, Required = false)]
		public int? OptPayoutType {get; set;}
		
		[TagDetails(Tag = 1195, Type = TagType.Float, Offset = 108, Required = false)]
		public double? OptPayoutAmount {get; set;}
		
		[TagDetails(Tag = 2753, Type = TagType.Int, Offset = 109, Required = false)]
		public int? ReturnTrigger {get; set;}
		
		[TagDetails(Tag = 1196, Type = TagType.String, Offset = 110, Required = false)]
		public string? PriceQuoteMethod {get; set;}
		
		[TagDetails(Tag = 1197, Type = TagType.String, Offset = 111, Required = false)]
		public string? ValuationMethod {get; set;}
		
		[TagDetails(Tag = 2002, Type = TagType.String, Offset = 112, Required = false)]
		public string? ValuationSource {get; set;}
		
		[TagDetails(Tag = 2140, Type = TagType.String, Offset = 113, Required = false)]
		public string? ValuationReferenceModel {get; set;}
		
		[TagDetails(Tag = 1524, Type = TagType.String, Offset = 114, Required = false)]
		public string? PriceQuoteCurrency {get; set;}
		
		[TagDetails(Tag = 2907, Type = TagType.String, Offset = 115, Required = false)]
		public string? PriceQuoteCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 1198, Type = TagType.Int, Offset = 116, Required = false)]
		public int? ListMethod {get; set;}
		
		[TagDetails(Tag = 1199, Type = TagType.Float, Offset = 117, Required = false)]
		public double? CapPrice {get; set;}
		
		[TagDetails(Tag = 1200, Type = TagType.Float, Offset = 118, Required = false)]
		public double? FloorPrice {get; set;}
		
		[TagDetails(Tag = 201, Type = TagType.Int, Offset = 119, Required = false)]
		public int? PutOrCall {get; set;}
		
		[TagDetails(Tag = 2681, Type = TagType.Int, Offset = 120, Required = false)]
		public int? InTheMoneyCondition {get; set;}
		
		[TagDetails(Tag = 2685, Type = TagType.Boolean, Offset = 121, Required = false)]
		public bool? ContraryInstructionEligibilityIndicator {get; set;}
		
		[TagDetails(Tag = 1244, Type = TagType.Boolean, Offset = 122, Required = false)]
		public bool? FlexibleIndicator {get; set;}
		
		[TagDetails(Tag = 1242, Type = TagType.Boolean, Offset = 123, Required = false)]
		public bool? FlexProductEligibilityIndicator {get; set;}
		
		[TagDetails(Tag = 2575, Type = TagType.Boolean, Offset = 124, Required = false)]
		public bool? BlockTradeEligibilityIndicator {get; set;}
		
		[TagDetails(Tag = 2574, Type = TagType.Boolean, Offset = 125, Required = false)]
		public bool? LowExercisePriceOptionIndicator {get; set;}
		
		[TagDetails(Tag = 997, Type = TagType.String, Offset = 126, Required = false)]
		public string? TimeUnit {get; set;}
		
		[TagDetails(Tag = 223, Type = TagType.Float, Offset = 127, Required = false)]
		public double? CouponRate {get; set;}
		
		[TagDetails(Tag = 207, Type = TagType.String, Offset = 128, Required = false)]
		public string? SecurityExchange {get; set;}
		
		[TagDetails(Tag = 970, Type = TagType.Int, Offset = 129, Required = false)]
		public int? PositionLimit {get; set;}
		
		[TagDetails(Tag = 971, Type = TagType.Int, Offset = 130, Required = false)]
		public int? NTPositionLimit {get; set;}
		
		[TagDetails(Tag = 106, Type = TagType.String, Offset = 131, Required = false)]
		public string? Issuer {get; set;}
		
		[TagDetails(Tag = 348, Type = TagType.Length, Offset = 132, Required = false)]
		public int? EncodedIssuerLen {get; set;}
		
		[TagDetails(Tag = 349, Type = TagType.RawData, Offset = 133, Required = false)]
		public byte[]? EncodedIssuer {get; set;}
		
		[TagDetails(Tag = 2737, Type = TagType.String, Offset = 134, Required = false)]
		public string? FinancialInstrumentShortName {get; set;}
		
		[TagDetails(Tag = 2714, Type = TagType.String, Offset = 135, Required = false)]
		public string? FinancialInstrumentFullName {get; set;}
		
		[TagDetails(Tag = 2715, Type = TagType.Length, Offset = 136, Required = false)]
		public int? EncodedFinancialInstrumentFullNameLen {get; set;}
		
		[TagDetails(Tag = 2716, Type = TagType.RawData, Offset = 137, Required = false)]
		public byte[]? EncodedFinancialInstrumentFullName {get; set;}
		
		[TagDetails(Tag = 107, Type = TagType.String, Offset = 138, Required = false)]
		public string? SecurityDesc {get; set;}
		
		[TagDetails(Tag = 350, Type = TagType.Length, Offset = 139, Required = false)]
		public int? EncodedSecurityDescLen {get; set;}
		
		[TagDetails(Tag = 351, Type = TagType.RawData, Offset = 140, Required = false)]
		public byte[]? EncodedSecurityDesc {get; set;}
		
		[Component(Offset = 141, Required = false)]
		public SecurityXML? SecurityXML {get; set;}
		
		[TagDetails(Tag = 691, Type = TagType.String, Offset = 142, Required = false)]
		public string? Pool {get; set;}
		
		[TagDetails(Tag = 667, Type = TagType.MonthYear, Offset = 143, Required = false)]
		public MonthYear? ContractSettlMonth {get; set;}
		
		[TagDetails(Tag = 875, Type = TagType.Int, Offset = 144, Required = false)]
		public int? CPProgram {get; set;}
		
		[TagDetails(Tag = 876, Type = TagType.String, Offset = 145, Required = false)]
		public string? CPRegType {get; set;}
		
		[Component(Offset = 146, Required = false)]
		public EvntGrp? EvntGrp {get; set;}
		
		[TagDetails(Tag = 873, Type = TagType.LocalDate, Offset = 147, Required = false)]
		public DateOnly? DatedDate {get; set;}
		
		[TagDetails(Tag = 874, Type = TagType.LocalDate, Offset = 148, Required = false)]
		public DateOnly? InterestAccrualDate {get; set;}
		
		[Component(Offset = 149, Required = false)]
		public InstrumentParties? InstrumentParties {get; set;}
		
		[TagDetails(Tag = 1687, Type = TagType.Int, Offset = 150, Required = false)]
		public int? ShortSaleRestriction {get; set;}
		
		[Component(Offset = 151, Required = false)]
		public ComplexEvents? ComplexEvents {get; set;}
		
		[TagDetails(Tag = 1787, Type = TagType.Int, Offset = 152, Required = false)]
		public int? RefTickTableID {get; set;}
		
		[TagDetails(Tag = 2141, Type = TagType.String, Offset = 153, Required = false)]
		public string? StrategyType {get; set;}
		
		[TagDetails(Tag = 2142, Type = TagType.Boolean, Offset = 154, Required = false)]
		public bool? CommonPricingIndicator {get; set;}
		
		[TagDetails(Tag = 2143, Type = TagType.Int, Offset = 155, Required = false)]
		public int? SettlDisruptionProvision {get; set;}
		
		[TagDetails(Tag = 2752, Type = TagType.String, Offset = 156, Required = false)]
		public string? DeliveryRouteOrCharter {get; set;}
		
		[TagDetails(Tag = 2144, Type = TagType.String, Offset = 157, Required = false)]
		public string? InstrumentRoundingDirection {get; set;}
		
		[TagDetails(Tag = 2145, Type = TagType.Int, Offset = 158, Required = false)]
		public int? InstrumentRoundingPrecision {get; set;}
		
		[TagDetails(Tag = 2576, Type = TagType.Int, Offset = 159, Required = false)]
		public int? InstrumentPricePrecision {get; set;}
		
		[TagDetails(Tag = 2962, Type = TagType.String, Offset = 160, Required = false)]
		public string? SecurityReferenceDataSupplement {get; set;}
		
		[Component(Offset = 161, Required = false)]
		public DateAdjustment? DateAdjustment {get; set;}
		
		[Component(Offset = 162, Required = false)]
		public PricingDateTime? PricingDateTime {get; set;}
		
		[Component(Offset = 163, Required = false)]
		public MarketDisruption? MarketDisruption {get; set;}
		
		[Component(Offset = 164, Required = false)]
		public OptionExercise? OptionExercise {get; set;}
		
		[Component(Offset = 165, Required = false)]
		public StreamGrp? StreamGrp {get; set;}
		
		[Component(Offset = 166, Required = false)]
		public ProvisionGrp? ProvisionGrp {get; set;}
		
		[Component(Offset = 167, Required = false)]
		public AdditionalTermGrp? AdditionalTermGrp {get; set;}
		
		[Component(Offset = 168, Required = false)]
		public ProtectionTermGrp? ProtectionTermGrp {get; set;}
		
		[Component(Offset = 169, Required = false)]
		public CashSettlTermGrp? CashSettlTermGrp {get; set;}
		
		[Component(Offset = 170, Required = false)]
		public PhysicalSettlTermGrp? PhysicalSettlTermGrp {get; set;}
		
		[Component(Offset = 171, Required = false)]
		public ExtraordinaryEventGrp? ExtraordinaryEventGrp {get; set;}
		
		[TagDetails(Tag = 2602, Type = TagType.Int, Offset = 172, Required = false)]
		public int? ExtraordinaryEventAdjustmentMethod {get; set;}
		
		[TagDetails(Tag = 2603, Type = TagType.Boolean, Offset = 173, Required = false)]
		public bool? ExchangeLookAlike {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Symbol is not null) writer.WriteString(55, Symbol);
			if (SymbolSfx is not null) writer.WriteString(65, SymbolSfx);
			if (SecurityID is not null) writer.WriteString(48, SecurityID);
			if (SecurityIDSource is not null) writer.WriteString(22, SecurityIDSource);
			if (SecAltIDGrp is not null) ((IFixEncoder)SecAltIDGrp).Encode(writer);
			if (Product is not null) writer.WriteWholeNumber(460, Product.Value);
			if (ProductComplex is not null) writer.WriteString(1227, ProductComplex);
			if (SecurityGroup is not null) writer.WriteString(1151, SecurityGroup);
			if (CFICode is not null) writer.WriteString(461, CFICode);
			if (UPICode is not null) writer.WriteString(2891, UPICode);
			if (SecurityType is not null) writer.WriteString(167, SecurityType);
			if (SecuritySubType is not null) writer.WriteString(762, SecuritySubType);
			if (Currency is not null) writer.WriteString(15, Currency);
			if (InstrumentCustom is not null) writer.WriteString(20460, InstrumentCustom);
			if (MaturityMonthYear is not null) writer.WriteMonthYear(200, MaturityMonthYear.Value);
			if (MaturityDate is not null) writer.WriteLocalDateOnly(541, MaturityDate.Value);
			if (MaturityTime is not null) writer.WriteString(1079, MaturityTime);
			if (SettleOnOpenFlag is not null) writer.WriteString(966, SettleOnOpenFlag);
			if (InstrmtAssignmentMethod is not null) writer.WriteString(1049, InstrmtAssignmentMethod);
			if (SecurityStatus is not null) writer.WriteString(965, SecurityStatus);
			if (CouponPaymentDate is not null) writer.WriteLocalDateOnly(224, CouponPaymentDate.Value);
			if (RestructuringType is not null) writer.WriteString(1449, RestructuringType);
			if (Seniority is not null) writer.WriteString(1450, Seniority);
			if (NotionalPercentageOutstanding is not null) writer.WriteNumber(1451, NotionalPercentageOutstanding.Value);
			if (OriginalNotionalPercentageOutstanding is not null) writer.WriteNumber(1452, OriginalNotionalPercentageOutstanding.Value);
			if (AttachmentPoint is not null) writer.WriteNumber(1457, AttachmentPoint.Value);
			if (DetachmentPoint is not null) writer.WriteNumber(1458, DetachmentPoint.Value);
			if (ObligationType is not null) writer.WriteString(1739, ObligationType);
			if (AssetGroup is not null) writer.WriteWholeNumber(2210, AssetGroup.Value);
			if (AssetClass is not null) writer.WriteWholeNumber(1938, AssetClass.Value);
			if (AssetSubClass is not null) writer.WriteWholeNumber(1939, AssetSubClass.Value);
			if (AssetType is not null) writer.WriteString(1940, AssetType);
			if (AssetSubType is not null) writer.WriteString(2735, AssetSubType);
			if (SecondaryAssetGrp is not null) ((IFixEncoder)SecondaryAssetGrp).Encode(writer);
			if (AssetAttributeGrp is not null) ((IFixEncoder)AssetAttributeGrp).Encode(writer);
			if (SwapClass is not null) writer.WriteString(1941, SwapClass);
			if (SwapSubClass is not null) writer.WriteString(1575, SwapSubClass);
			if (NthToDefault is not null) writer.WriteWholeNumber(1942, NthToDefault.Value);
			if (MthToDefault is not null) writer.WriteWholeNumber(1943, MthToDefault.Value);
			if (SettledEntityMatrixSource is not null) writer.WriteString(1944, SettledEntityMatrixSource);
			if (SettledEntityMatrixPublicationDate is not null) writer.WriteLocalDateOnly(1945, SettledEntityMatrixPublicationDate.Value);
			if (CouponType is not null) writer.WriteWholeNumber(1946, CouponType.Value);
			if (TotalIssuedAmount is not null) writer.WriteNumber(1947, TotalIssuedAmount.Value);
			if (CouponFrequencyPeriod is not null) writer.WriteWholeNumber(1948, CouponFrequencyPeriod.Value);
			if (CouponFrequencyUnit is not null) writer.WriteString(1949, CouponFrequencyUnit);
			if (CouponDayCount is not null) writer.WriteWholeNumber(1950, CouponDayCount.Value);
			if (CouponOtherDayCount is not null) writer.WriteString(2879, CouponOtherDayCount);
			if (ConvertibleBondEquityID is not null) writer.WriteString(1951, ConvertibleBondEquityID);
			if (ConvertibleBondEquityIDSource is not null) writer.WriteString(1952, ConvertibleBondEquityIDSource);
			if (ContractPriceRefMonth is not null) writer.WriteMonthYear(1953, ContractPriceRefMonth.Value);
			if (LienSeniority is not null) writer.WriteWholeNumber(1954, LienSeniority.Value);
			if (LoanFacility is not null) writer.WriteWholeNumber(1955, LoanFacility.Value);
			if (ReferenceEntityType is not null) writer.WriteWholeNumber(1956, ReferenceEntityType.Value);
			if (IndexSeries is not null) writer.WriteWholeNumber(1957, IndexSeries.Value);
			if (IndexAnnexVersion is not null) writer.WriteWholeNumber(1958, IndexAnnexVersion.Value);
			if (IndexAnnexDate is not null) writer.WriteLocalDateOnly(1959, IndexAnnexDate.Value);
			if (IndexAnnexSource is not null) writer.WriteString(1960, IndexAnnexSource);
			if (SettlRateIndex is not null) writer.WriteString(1577, SettlRateIndex);
			if (SettlRateIndexLocation is not null) writer.WriteString(1580, SettlRateIndexLocation);
			if (OptionExpirationDesc is not null) writer.WriteString(1581, OptionExpirationDesc);
			if (EncodedOptionExpirationDescLen is not null) writer.WriteWholeNumber(1678, EncodedOptionExpirationDescLen.Value);
			if (EncodedOptionExpirationDesc is not null) writer.WriteBuffer(1697, EncodedOptionExpirationDesc);
			if (IssueDate is not null) writer.WriteLocalDateOnly(225, IssueDate.Value);
			if (RepoCollateralSecurityType is not null) writer.WriteString(239, RepoCollateralSecurityType);
			if (RepurchaseTerm is not null) writer.WriteWholeNumber(226, RepurchaseTerm.Value);
			if (RepurchaseRate is not null) writer.WriteNumber(227, RepurchaseRate.Value);
			if (Factor is not null) writer.WriteNumber(228, Factor.Value);
			if (CreditRating is not null) writer.WriteString(255, CreditRating);
			if (InstrRegistry is not null) writer.WriteString(543, InstrRegistry);
			if (CountryOfIssue is not null) writer.WriteString(470, CountryOfIssue);
			if (StateOrProvinceOfIssue is not null) writer.WriteString(471, StateOrProvinceOfIssue);
			if (LocaleOfIssue is not null) writer.WriteString(472, LocaleOfIssue);
			if (RedemptionDate is not null) writer.WriteLocalDateOnly(240, RedemptionDate.Value);
			if (StrikePrice is not null) writer.WriteNumber(202, StrikePrice.Value);
			if (OrigStrikePrice is not null) writer.WriteNumber(2578, OrigStrikePrice.Value);
			if (StrikePricePrecision is not null) writer.WriteWholeNumber(2577, StrikePricePrecision.Value);
			if (StrikeCurrency is not null) writer.WriteString(947, StrikeCurrency);
			if (StrikeCurrencyCodeSource is not null) writer.WriteString(2904, StrikeCurrencyCodeSource);
			if (StrikeMultiplier is not null) writer.WriteNumber(967, StrikeMultiplier.Value);
			if (StrikeValue is not null) writer.WriteNumber(968, StrikeValue.Value);
			if (StrikeUnitOfMeasure is not null) writer.WriteString(1698, StrikeUnitOfMeasure);
			if (StrikeIndex is not null) writer.WriteString(1866, StrikeIndex);
			if (StrikeIndexCurvePoint is not null) writer.WriteString(2600, StrikeIndexCurvePoint);
			if (StrikeIndexSpread is not null) writer.WriteNumber(2001, StrikeIndexSpread.Value);
			if (StrikeIndexQuote is not null) writer.WriteWholeNumber(2601, StrikeIndexQuote.Value);
			if (StrikePriceDeterminationMethod is not null) writer.WriteWholeNumber(1478, StrikePriceDeterminationMethod.Value);
			if (StrikePriceBoundaryMethod is not null) writer.WriteWholeNumber(1479, StrikePriceBoundaryMethod.Value);
			if (StrikePriceBoundaryPrecision is not null) writer.WriteNumber(1480, StrikePriceBoundaryPrecision.Value);
			if (UnderlyingPriceDeterminationMethod is not null) writer.WriteWholeNumber(1481, UnderlyingPriceDeterminationMethod.Value);
			if (OptAttribute is not null) writer.WriteString(206, OptAttribute);
			if (ContractMultiplier is not null) writer.WriteNumber(231, ContractMultiplier.Value);
			if (ContractMultiplierUnit is not null) writer.WriteWholeNumber(1435, ContractMultiplierUnit.Value);
			if (TradingUnitPeriodMultiplier is not null) writer.WriteWholeNumber(2353, TradingUnitPeriodMultiplier.Value);
			if (FlowScheduleType is not null) writer.WriteWholeNumber(1439, FlowScheduleType.Value);
			if (MinPriceIncrement is not null) writer.WriteNumber(969, MinPriceIncrement.Value);
			if (MinPriceIncrementAmount is not null) writer.WriteNumber(1146, MinPriceIncrementAmount.Value);
			if (UnitOfMeasure is not null) writer.WriteString(996, UnitOfMeasure);
			if (UnitOfMeasureQty is not null) writer.WriteNumber(1147, UnitOfMeasureQty.Value);
			if (UnitOfMeasureCurrency is not null) writer.WriteString(1716, UnitOfMeasureCurrency);
			if (UnitOfMeasureCurrencyCodeSource is not null) writer.WriteString(2905, UnitOfMeasureCurrencyCodeSource);
			if (PriceUnitOfMeasure is not null) writer.WriteString(1191, PriceUnitOfMeasure);
			if (PriceUnitOfMeasureQty is not null) writer.WriteNumber(1192, PriceUnitOfMeasureQty.Value);
			if (PriceUnitOfMeasureCurrency is not null) writer.WriteString(1717, PriceUnitOfMeasureCurrency);
			if (PriceUnitOfMeasureCurrencyCodeSource is not null) writer.WriteString(2906, PriceUnitOfMeasureCurrencyCodeSource);
			if (SettlMethod is not null) writer.WriteString(1193, SettlMethod);
			if (SettlSubMethod is not null) writer.WriteWholeNumber(2579, SettlSubMethod.Value);
			if (ExerciseStyle is not null) writer.WriteWholeNumber(1194, ExerciseStyle.Value);
			if (OptPayoutType is not null) writer.WriteWholeNumber(1482, OptPayoutType.Value);
			if (OptPayoutAmount is not null) writer.WriteNumber(1195, OptPayoutAmount.Value);
			if (ReturnTrigger is not null) writer.WriteWholeNumber(2753, ReturnTrigger.Value);
			if (PriceQuoteMethod is not null) writer.WriteString(1196, PriceQuoteMethod);
			if (ValuationMethod is not null) writer.WriteString(1197, ValuationMethod);
			if (ValuationSource is not null) writer.WriteString(2002, ValuationSource);
			if (ValuationReferenceModel is not null) writer.WriteString(2140, ValuationReferenceModel);
			if (PriceQuoteCurrency is not null) writer.WriteString(1524, PriceQuoteCurrency);
			if (PriceQuoteCurrencyCodeSource is not null) writer.WriteString(2907, PriceQuoteCurrencyCodeSource);
			if (ListMethod is not null) writer.WriteWholeNumber(1198, ListMethod.Value);
			if (CapPrice is not null) writer.WriteNumber(1199, CapPrice.Value);
			if (FloorPrice is not null) writer.WriteNumber(1200, FloorPrice.Value);
			if (PutOrCall is not null) writer.WriteWholeNumber(201, PutOrCall.Value);
			if (InTheMoneyCondition is not null) writer.WriteWholeNumber(2681, InTheMoneyCondition.Value);
			if (ContraryInstructionEligibilityIndicator is not null) writer.WriteBoolean(2685, ContraryInstructionEligibilityIndicator.Value);
			if (FlexibleIndicator is not null) writer.WriteBoolean(1244, FlexibleIndicator.Value);
			if (FlexProductEligibilityIndicator is not null) writer.WriteBoolean(1242, FlexProductEligibilityIndicator.Value);
			if (BlockTradeEligibilityIndicator is not null) writer.WriteBoolean(2575, BlockTradeEligibilityIndicator.Value);
			if (LowExercisePriceOptionIndicator is not null) writer.WriteBoolean(2574, LowExercisePriceOptionIndicator.Value);
			if (TimeUnit is not null) writer.WriteString(997, TimeUnit);
			if (CouponRate is not null) writer.WriteNumber(223, CouponRate.Value);
			if (SecurityExchange is not null) writer.WriteString(207, SecurityExchange);
			if (PositionLimit is not null) writer.WriteWholeNumber(970, PositionLimit.Value);
			if (NTPositionLimit is not null) writer.WriteWholeNumber(971, NTPositionLimit.Value);
			if (Issuer is not null) writer.WriteString(106, Issuer);
			if (EncodedIssuerLen is not null) writer.WriteWholeNumber(348, EncodedIssuerLen.Value);
			if (EncodedIssuer is not null) writer.WriteBuffer(349, EncodedIssuer);
			if (FinancialInstrumentShortName is not null) writer.WriteString(2737, FinancialInstrumentShortName);
			if (FinancialInstrumentFullName is not null) writer.WriteString(2714, FinancialInstrumentFullName);
			if (EncodedFinancialInstrumentFullNameLen is not null) writer.WriteWholeNumber(2715, EncodedFinancialInstrumentFullNameLen.Value);
			if (EncodedFinancialInstrumentFullName is not null) writer.WriteBuffer(2716, EncodedFinancialInstrumentFullName);
			if (SecurityDesc is not null) writer.WriteString(107, SecurityDesc);
			if (EncodedSecurityDescLen is not null) writer.WriteWholeNumber(350, EncodedSecurityDescLen.Value);
			if (EncodedSecurityDesc is not null) writer.WriteBuffer(351, EncodedSecurityDesc);
			if (SecurityXML is not null) ((IFixEncoder)SecurityXML).Encode(writer);
			if (Pool is not null) writer.WriteString(691, Pool);
			if (ContractSettlMonth is not null) writer.WriteMonthYear(667, ContractSettlMonth.Value);
			if (CPProgram is not null) writer.WriteWholeNumber(875, CPProgram.Value);
			if (CPRegType is not null) writer.WriteString(876, CPRegType);
			if (EvntGrp is not null) ((IFixEncoder)EvntGrp).Encode(writer);
			if (DatedDate is not null) writer.WriteLocalDateOnly(873, DatedDate.Value);
			if (InterestAccrualDate is not null) writer.WriteLocalDateOnly(874, InterestAccrualDate.Value);
			if (InstrumentParties is not null) ((IFixEncoder)InstrumentParties).Encode(writer);
			if (ShortSaleRestriction is not null) writer.WriteWholeNumber(1687, ShortSaleRestriction.Value);
			if (ComplexEvents is not null) ((IFixEncoder)ComplexEvents).Encode(writer);
			if (RefTickTableID is not null) writer.WriteWholeNumber(1787, RefTickTableID.Value);
			if (StrategyType is not null) writer.WriteString(2141, StrategyType);
			if (CommonPricingIndicator is not null) writer.WriteBoolean(2142, CommonPricingIndicator.Value);
			if (SettlDisruptionProvision is not null) writer.WriteWholeNumber(2143, SettlDisruptionProvision.Value);
			if (DeliveryRouteOrCharter is not null) writer.WriteString(2752, DeliveryRouteOrCharter);
			if (InstrumentRoundingDirection is not null) writer.WriteString(2144, InstrumentRoundingDirection);
			if (InstrumentRoundingPrecision is not null) writer.WriteWholeNumber(2145, InstrumentRoundingPrecision.Value);
			if (InstrumentPricePrecision is not null) writer.WriteWholeNumber(2576, InstrumentPricePrecision.Value);
			if (SecurityReferenceDataSupplement is not null) writer.WriteString(2962, SecurityReferenceDataSupplement);
			if (DateAdjustment is not null) ((IFixEncoder)DateAdjustment).Encode(writer);
			if (PricingDateTime is not null) ((IFixEncoder)PricingDateTime).Encode(writer);
			if (MarketDisruption is not null) ((IFixEncoder)MarketDisruption).Encode(writer);
			if (OptionExercise is not null) ((IFixEncoder)OptionExercise).Encode(writer);
			if (StreamGrp is not null) ((IFixEncoder)StreamGrp).Encode(writer);
			if (ProvisionGrp is not null) ((IFixEncoder)ProvisionGrp).Encode(writer);
			if (AdditionalTermGrp is not null) ((IFixEncoder)AdditionalTermGrp).Encode(writer);
			if (ProtectionTermGrp is not null) ((IFixEncoder)ProtectionTermGrp).Encode(writer);
			if (CashSettlTermGrp is not null) ((IFixEncoder)CashSettlTermGrp).Encode(writer);
			if (PhysicalSettlTermGrp is not null) ((IFixEncoder)PhysicalSettlTermGrp).Encode(writer);
			if (ExtraordinaryEventGrp is not null) ((IFixEncoder)ExtraordinaryEventGrp).Encode(writer);
			if (ExtraordinaryEventAdjustmentMethod is not null) writer.WriteWholeNumber(2602, ExtraordinaryEventAdjustmentMethod.Value);
			if (ExchangeLookAlike is not null) writer.WriteBoolean(2603, ExchangeLookAlike.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			Symbol = view.GetString(55);
			SymbolSfx = view.GetString(65);
			SecurityID = view.GetString(48);
			SecurityIDSource = view.GetString(22);
			if (view.GetView("SecAltIDGrp") is IMessageView viewSecAltIDGrp)
			{
				SecAltIDGrp = new();
				((IFixParser)SecAltIDGrp).Parse(viewSecAltIDGrp);
			}
			Product = view.GetInt32(460);
			ProductComplex = view.GetString(1227);
			SecurityGroup = view.GetString(1151);
			CFICode = view.GetString(461);
			UPICode = view.GetString(2891);
			SecurityType = view.GetString(167);
			SecuritySubType = view.GetString(762);
			Currency = view.GetString(15);
			InstrumentCustom = view.GetString(20460);
			MaturityMonthYear = view.GetMonthYear(200);
			MaturityDate = view.GetDateOnly(541);
			MaturityTime = view.GetString(1079);
			SettleOnOpenFlag = view.GetString(966);
			InstrmtAssignmentMethod = view.GetString(1049);
			SecurityStatus = view.GetString(965);
			CouponPaymentDate = view.GetDateOnly(224);
			RestructuringType = view.GetString(1449);
			Seniority = view.GetString(1450);
			NotionalPercentageOutstanding = view.GetDouble(1451);
			OriginalNotionalPercentageOutstanding = view.GetDouble(1452);
			AttachmentPoint = view.GetDouble(1457);
			DetachmentPoint = view.GetDouble(1458);
			ObligationType = view.GetString(1739);
			AssetGroup = view.GetInt32(2210);
			AssetClass = view.GetInt32(1938);
			AssetSubClass = view.GetInt32(1939);
			AssetType = view.GetString(1940);
			AssetSubType = view.GetString(2735);
			if (view.GetView("SecondaryAssetGrp") is IMessageView viewSecondaryAssetGrp)
			{
				SecondaryAssetGrp = new();
				((IFixParser)SecondaryAssetGrp).Parse(viewSecondaryAssetGrp);
			}
			if (view.GetView("AssetAttributeGrp") is IMessageView viewAssetAttributeGrp)
			{
				AssetAttributeGrp = new();
				((IFixParser)AssetAttributeGrp).Parse(viewAssetAttributeGrp);
			}
			SwapClass = view.GetString(1941);
			SwapSubClass = view.GetString(1575);
			NthToDefault = view.GetInt32(1942);
			MthToDefault = view.GetInt32(1943);
			SettledEntityMatrixSource = view.GetString(1944);
			SettledEntityMatrixPublicationDate = view.GetDateOnly(1945);
			CouponType = view.GetInt32(1946);
			TotalIssuedAmount = view.GetDouble(1947);
			CouponFrequencyPeriod = view.GetInt32(1948);
			CouponFrequencyUnit = view.GetString(1949);
			CouponDayCount = view.GetInt32(1950);
			CouponOtherDayCount = view.GetString(2879);
			ConvertibleBondEquityID = view.GetString(1951);
			ConvertibleBondEquityIDSource = view.GetString(1952);
			ContractPriceRefMonth = view.GetMonthYear(1953);
			LienSeniority = view.GetInt32(1954);
			LoanFacility = view.GetInt32(1955);
			ReferenceEntityType = view.GetInt32(1956);
			IndexSeries = view.GetInt32(1957);
			IndexAnnexVersion = view.GetInt32(1958);
			IndexAnnexDate = view.GetDateOnly(1959);
			IndexAnnexSource = view.GetString(1960);
			SettlRateIndex = view.GetString(1577);
			SettlRateIndexLocation = view.GetString(1580);
			OptionExpirationDesc = view.GetString(1581);
			EncodedOptionExpirationDescLen = view.GetInt32(1678);
			EncodedOptionExpirationDesc = view.GetByteArray(1697);
			IssueDate = view.GetDateOnly(225);
			RepoCollateralSecurityType = view.GetString(239);
			RepurchaseTerm = view.GetInt32(226);
			RepurchaseRate = view.GetDouble(227);
			Factor = view.GetDouble(228);
			CreditRating = view.GetString(255);
			InstrRegistry = view.GetString(543);
			CountryOfIssue = view.GetString(470);
			StateOrProvinceOfIssue = view.GetString(471);
			LocaleOfIssue = view.GetString(472);
			RedemptionDate = view.GetDateOnly(240);
			StrikePrice = view.GetDouble(202);
			OrigStrikePrice = view.GetDouble(2578);
			StrikePricePrecision = view.GetInt32(2577);
			StrikeCurrency = view.GetString(947);
			StrikeCurrencyCodeSource = view.GetString(2904);
			StrikeMultiplier = view.GetDouble(967);
			StrikeValue = view.GetDouble(968);
			StrikeUnitOfMeasure = view.GetString(1698);
			StrikeIndex = view.GetString(1866);
			StrikeIndexCurvePoint = view.GetString(2600);
			StrikeIndexSpread = view.GetDouble(2001);
			StrikeIndexQuote = view.GetInt32(2601);
			StrikePriceDeterminationMethod = view.GetInt32(1478);
			StrikePriceBoundaryMethod = view.GetInt32(1479);
			StrikePriceBoundaryPrecision = view.GetDouble(1480);
			UnderlyingPriceDeterminationMethod = view.GetInt32(1481);
			OptAttribute = view.GetString(206);
			ContractMultiplier = view.GetDouble(231);
			ContractMultiplierUnit = view.GetInt32(1435);
			TradingUnitPeriodMultiplier = view.GetInt32(2353);
			FlowScheduleType = view.GetInt32(1439);
			MinPriceIncrement = view.GetDouble(969);
			MinPriceIncrementAmount = view.GetDouble(1146);
			UnitOfMeasure = view.GetString(996);
			UnitOfMeasureQty = view.GetDouble(1147);
			UnitOfMeasureCurrency = view.GetString(1716);
			UnitOfMeasureCurrencyCodeSource = view.GetString(2905);
			PriceUnitOfMeasure = view.GetString(1191);
			PriceUnitOfMeasureQty = view.GetDouble(1192);
			PriceUnitOfMeasureCurrency = view.GetString(1717);
			PriceUnitOfMeasureCurrencyCodeSource = view.GetString(2906);
			SettlMethod = view.GetString(1193);
			SettlSubMethod = view.GetInt32(2579);
			ExerciseStyle = view.GetInt32(1194);
			OptPayoutType = view.GetInt32(1482);
			OptPayoutAmount = view.GetDouble(1195);
			ReturnTrigger = view.GetInt32(2753);
			PriceQuoteMethod = view.GetString(1196);
			ValuationMethod = view.GetString(1197);
			ValuationSource = view.GetString(2002);
			ValuationReferenceModel = view.GetString(2140);
			PriceQuoteCurrency = view.GetString(1524);
			PriceQuoteCurrencyCodeSource = view.GetString(2907);
			ListMethod = view.GetInt32(1198);
			CapPrice = view.GetDouble(1199);
			FloorPrice = view.GetDouble(1200);
			PutOrCall = view.GetInt32(201);
			InTheMoneyCondition = view.GetInt32(2681);
			ContraryInstructionEligibilityIndicator = view.GetBool(2685);
			FlexibleIndicator = view.GetBool(1244);
			FlexProductEligibilityIndicator = view.GetBool(1242);
			BlockTradeEligibilityIndicator = view.GetBool(2575);
			LowExercisePriceOptionIndicator = view.GetBool(2574);
			TimeUnit = view.GetString(997);
			CouponRate = view.GetDouble(223);
			SecurityExchange = view.GetString(207);
			PositionLimit = view.GetInt32(970);
			NTPositionLimit = view.GetInt32(971);
			Issuer = view.GetString(106);
			EncodedIssuerLen = view.GetInt32(348);
			EncodedIssuer = view.GetByteArray(349);
			FinancialInstrumentShortName = view.GetString(2737);
			FinancialInstrumentFullName = view.GetString(2714);
			EncodedFinancialInstrumentFullNameLen = view.GetInt32(2715);
			EncodedFinancialInstrumentFullName = view.GetByteArray(2716);
			SecurityDesc = view.GetString(107);
			EncodedSecurityDescLen = view.GetInt32(350);
			EncodedSecurityDesc = view.GetByteArray(351);
			if (view.GetView("SecurityXML") is IMessageView viewSecurityXML)
			{
				SecurityXML = new();
				((IFixParser)SecurityXML).Parse(viewSecurityXML);
			}
			Pool = view.GetString(691);
			ContractSettlMonth = view.GetMonthYear(667);
			CPProgram = view.GetInt32(875);
			CPRegType = view.GetString(876);
			if (view.GetView("EvntGrp") is IMessageView viewEvntGrp)
			{
				EvntGrp = new();
				((IFixParser)EvntGrp).Parse(viewEvntGrp);
			}
			DatedDate = view.GetDateOnly(873);
			InterestAccrualDate = view.GetDateOnly(874);
			if (view.GetView("InstrumentParties") is IMessageView viewInstrumentParties)
			{
				InstrumentParties = new();
				((IFixParser)InstrumentParties).Parse(viewInstrumentParties);
			}
			ShortSaleRestriction = view.GetInt32(1687);
			if (view.GetView("ComplexEvents") is IMessageView viewComplexEvents)
			{
				ComplexEvents = new();
				((IFixParser)ComplexEvents).Parse(viewComplexEvents);
			}
			RefTickTableID = view.GetInt32(1787);
			StrategyType = view.GetString(2141);
			CommonPricingIndicator = view.GetBool(2142);
			SettlDisruptionProvision = view.GetInt32(2143);
			DeliveryRouteOrCharter = view.GetString(2752);
			InstrumentRoundingDirection = view.GetString(2144);
			InstrumentRoundingPrecision = view.GetInt32(2145);
			InstrumentPricePrecision = view.GetInt32(2576);
			SecurityReferenceDataSupplement = view.GetString(2962);
			if (view.GetView("DateAdjustment") is IMessageView viewDateAdjustment)
			{
				DateAdjustment = new();
				((IFixParser)DateAdjustment).Parse(viewDateAdjustment);
			}
			if (view.GetView("PricingDateTime") is IMessageView viewPricingDateTime)
			{
				PricingDateTime = new();
				((IFixParser)PricingDateTime).Parse(viewPricingDateTime);
			}
			if (view.GetView("MarketDisruption") is IMessageView viewMarketDisruption)
			{
				MarketDisruption = new();
				((IFixParser)MarketDisruption).Parse(viewMarketDisruption);
			}
			if (view.GetView("OptionExercise") is IMessageView viewOptionExercise)
			{
				OptionExercise = new();
				((IFixParser)OptionExercise).Parse(viewOptionExercise);
			}
			if (view.GetView("StreamGrp") is IMessageView viewStreamGrp)
			{
				StreamGrp = new();
				((IFixParser)StreamGrp).Parse(viewStreamGrp);
			}
			if (view.GetView("ProvisionGrp") is IMessageView viewProvisionGrp)
			{
				ProvisionGrp = new();
				((IFixParser)ProvisionGrp).Parse(viewProvisionGrp);
			}
			if (view.GetView("AdditionalTermGrp") is IMessageView viewAdditionalTermGrp)
			{
				AdditionalTermGrp = new();
				((IFixParser)AdditionalTermGrp).Parse(viewAdditionalTermGrp);
			}
			if (view.GetView("ProtectionTermGrp") is IMessageView viewProtectionTermGrp)
			{
				ProtectionTermGrp = new();
				((IFixParser)ProtectionTermGrp).Parse(viewProtectionTermGrp);
			}
			if (view.GetView("CashSettlTermGrp") is IMessageView viewCashSettlTermGrp)
			{
				CashSettlTermGrp = new();
				((IFixParser)CashSettlTermGrp).Parse(viewCashSettlTermGrp);
			}
			if (view.GetView("PhysicalSettlTermGrp") is IMessageView viewPhysicalSettlTermGrp)
			{
				PhysicalSettlTermGrp = new();
				((IFixParser)PhysicalSettlTermGrp).Parse(viewPhysicalSettlTermGrp);
			}
			if (view.GetView("ExtraordinaryEventGrp") is IMessageView viewExtraordinaryEventGrp)
			{
				ExtraordinaryEventGrp = new();
				((IFixParser)ExtraordinaryEventGrp).Parse(viewExtraordinaryEventGrp);
			}
			ExtraordinaryEventAdjustmentMethod = view.GetInt32(2602);
			ExchangeLookAlike = view.GetBool(2603);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "Symbol":
				{
					value = Symbol;
					break;
				}
				case "SymbolSfx":
				{
					value = SymbolSfx;
					break;
				}
				case "SecurityID":
				{
					value = SecurityID;
					break;
				}
				case "SecurityIDSource":
				{
					value = SecurityIDSource;
					break;
				}
				case "SecAltIDGrp":
				{
					value = SecAltIDGrp;
					break;
				}
				case "Product":
				{
					value = Product;
					break;
				}
				case "ProductComplex":
				{
					value = ProductComplex;
					break;
				}
				case "SecurityGroup":
				{
					value = SecurityGroup;
					break;
				}
				case "CFICode":
				{
					value = CFICode;
					break;
				}
				case "UPICode":
				{
					value = UPICode;
					break;
				}
				case "SecurityType":
				{
					value = SecurityType;
					break;
				}
				case "SecuritySubType":
				{
					value = SecuritySubType;
					break;
				}
				case "Currency":
				{
					value = Currency;
					break;
				}
				case "InstrumentCustom":
				{
					value = InstrumentCustom;
					break;
				}
				case "MaturityMonthYear":
				{
					value = MaturityMonthYear;
					break;
				}
				case "MaturityDate":
				{
					value = MaturityDate;
					break;
				}
				case "MaturityTime":
				{
					value = MaturityTime;
					break;
				}
				case "SettleOnOpenFlag":
				{
					value = SettleOnOpenFlag;
					break;
				}
				case "InstrmtAssignmentMethod":
				{
					value = InstrmtAssignmentMethod;
					break;
				}
				case "SecurityStatus":
				{
					value = SecurityStatus;
					break;
				}
				case "CouponPaymentDate":
				{
					value = CouponPaymentDate;
					break;
				}
				case "RestructuringType":
				{
					value = RestructuringType;
					break;
				}
				case "Seniority":
				{
					value = Seniority;
					break;
				}
				case "NotionalPercentageOutstanding":
				{
					value = NotionalPercentageOutstanding;
					break;
				}
				case "OriginalNotionalPercentageOutstanding":
				{
					value = OriginalNotionalPercentageOutstanding;
					break;
				}
				case "AttachmentPoint":
				{
					value = AttachmentPoint;
					break;
				}
				case "DetachmentPoint":
				{
					value = DetachmentPoint;
					break;
				}
				case "ObligationType":
				{
					value = ObligationType;
					break;
				}
				case "AssetGroup":
				{
					value = AssetGroup;
					break;
				}
				case "AssetClass":
				{
					value = AssetClass;
					break;
				}
				case "AssetSubClass":
				{
					value = AssetSubClass;
					break;
				}
				case "AssetType":
				{
					value = AssetType;
					break;
				}
				case "AssetSubType":
				{
					value = AssetSubType;
					break;
				}
				case "SecondaryAssetGrp":
				{
					value = SecondaryAssetGrp;
					break;
				}
				case "AssetAttributeGrp":
				{
					value = AssetAttributeGrp;
					break;
				}
				case "SwapClass":
				{
					value = SwapClass;
					break;
				}
				case "SwapSubClass":
				{
					value = SwapSubClass;
					break;
				}
				case "NthToDefault":
				{
					value = NthToDefault;
					break;
				}
				case "MthToDefault":
				{
					value = MthToDefault;
					break;
				}
				case "SettledEntityMatrixSource":
				{
					value = SettledEntityMatrixSource;
					break;
				}
				case "SettledEntityMatrixPublicationDate":
				{
					value = SettledEntityMatrixPublicationDate;
					break;
				}
				case "CouponType":
				{
					value = CouponType;
					break;
				}
				case "TotalIssuedAmount":
				{
					value = TotalIssuedAmount;
					break;
				}
				case "CouponFrequencyPeriod":
				{
					value = CouponFrequencyPeriod;
					break;
				}
				case "CouponFrequencyUnit":
				{
					value = CouponFrequencyUnit;
					break;
				}
				case "CouponDayCount":
				{
					value = CouponDayCount;
					break;
				}
				case "CouponOtherDayCount":
				{
					value = CouponOtherDayCount;
					break;
				}
				case "ConvertibleBondEquityID":
				{
					value = ConvertibleBondEquityID;
					break;
				}
				case "ConvertibleBondEquityIDSource":
				{
					value = ConvertibleBondEquityIDSource;
					break;
				}
				case "ContractPriceRefMonth":
				{
					value = ContractPriceRefMonth;
					break;
				}
				case "LienSeniority":
				{
					value = LienSeniority;
					break;
				}
				case "LoanFacility":
				{
					value = LoanFacility;
					break;
				}
				case "ReferenceEntityType":
				{
					value = ReferenceEntityType;
					break;
				}
				case "IndexSeries":
				{
					value = IndexSeries;
					break;
				}
				case "IndexAnnexVersion":
				{
					value = IndexAnnexVersion;
					break;
				}
				case "IndexAnnexDate":
				{
					value = IndexAnnexDate;
					break;
				}
				case "IndexAnnexSource":
				{
					value = IndexAnnexSource;
					break;
				}
				case "SettlRateIndex":
				{
					value = SettlRateIndex;
					break;
				}
				case "SettlRateIndexLocation":
				{
					value = SettlRateIndexLocation;
					break;
				}
				case "OptionExpirationDesc":
				{
					value = OptionExpirationDesc;
					break;
				}
				case "EncodedOptionExpirationDescLen":
				{
					value = EncodedOptionExpirationDescLen;
					break;
				}
				case "EncodedOptionExpirationDesc":
				{
					value = EncodedOptionExpirationDesc;
					break;
				}
				case "IssueDate":
				{
					value = IssueDate;
					break;
				}
				case "RepoCollateralSecurityType":
				{
					value = RepoCollateralSecurityType;
					break;
				}
				case "RepurchaseTerm":
				{
					value = RepurchaseTerm;
					break;
				}
				case "RepurchaseRate":
				{
					value = RepurchaseRate;
					break;
				}
				case "Factor":
				{
					value = Factor;
					break;
				}
				case "CreditRating":
				{
					value = CreditRating;
					break;
				}
				case "InstrRegistry":
				{
					value = InstrRegistry;
					break;
				}
				case "CountryOfIssue":
				{
					value = CountryOfIssue;
					break;
				}
				case "StateOrProvinceOfIssue":
				{
					value = StateOrProvinceOfIssue;
					break;
				}
				case "LocaleOfIssue":
				{
					value = LocaleOfIssue;
					break;
				}
				case "RedemptionDate":
				{
					value = RedemptionDate;
					break;
				}
				case "StrikePrice":
				{
					value = StrikePrice;
					break;
				}
				case "OrigStrikePrice":
				{
					value = OrigStrikePrice;
					break;
				}
				case "StrikePricePrecision":
				{
					value = StrikePricePrecision;
					break;
				}
				case "StrikeCurrency":
				{
					value = StrikeCurrency;
					break;
				}
				case "StrikeCurrencyCodeSource":
				{
					value = StrikeCurrencyCodeSource;
					break;
				}
				case "StrikeMultiplier":
				{
					value = StrikeMultiplier;
					break;
				}
				case "StrikeValue":
				{
					value = StrikeValue;
					break;
				}
				case "StrikeUnitOfMeasure":
				{
					value = StrikeUnitOfMeasure;
					break;
				}
				case "StrikeIndex":
				{
					value = StrikeIndex;
					break;
				}
				case "StrikeIndexCurvePoint":
				{
					value = StrikeIndexCurvePoint;
					break;
				}
				case "StrikeIndexSpread":
				{
					value = StrikeIndexSpread;
					break;
				}
				case "StrikeIndexQuote":
				{
					value = StrikeIndexQuote;
					break;
				}
				case "StrikePriceDeterminationMethod":
				{
					value = StrikePriceDeterminationMethod;
					break;
				}
				case "StrikePriceBoundaryMethod":
				{
					value = StrikePriceBoundaryMethod;
					break;
				}
				case "StrikePriceBoundaryPrecision":
				{
					value = StrikePriceBoundaryPrecision;
					break;
				}
				case "UnderlyingPriceDeterminationMethod":
				{
					value = UnderlyingPriceDeterminationMethod;
					break;
				}
				case "OptAttribute":
				{
					value = OptAttribute;
					break;
				}
				case "ContractMultiplier":
				{
					value = ContractMultiplier;
					break;
				}
				case "ContractMultiplierUnit":
				{
					value = ContractMultiplierUnit;
					break;
				}
				case "TradingUnitPeriodMultiplier":
				{
					value = TradingUnitPeriodMultiplier;
					break;
				}
				case "FlowScheduleType":
				{
					value = FlowScheduleType;
					break;
				}
				case "MinPriceIncrement":
				{
					value = MinPriceIncrement;
					break;
				}
				case "MinPriceIncrementAmount":
				{
					value = MinPriceIncrementAmount;
					break;
				}
				case "UnitOfMeasure":
				{
					value = UnitOfMeasure;
					break;
				}
				case "UnitOfMeasureQty":
				{
					value = UnitOfMeasureQty;
					break;
				}
				case "UnitOfMeasureCurrency":
				{
					value = UnitOfMeasureCurrency;
					break;
				}
				case "UnitOfMeasureCurrencyCodeSource":
				{
					value = UnitOfMeasureCurrencyCodeSource;
					break;
				}
				case "PriceUnitOfMeasure":
				{
					value = PriceUnitOfMeasure;
					break;
				}
				case "PriceUnitOfMeasureQty":
				{
					value = PriceUnitOfMeasureQty;
					break;
				}
				case "PriceUnitOfMeasureCurrency":
				{
					value = PriceUnitOfMeasureCurrency;
					break;
				}
				case "PriceUnitOfMeasureCurrencyCodeSource":
				{
					value = PriceUnitOfMeasureCurrencyCodeSource;
					break;
				}
				case "SettlMethod":
				{
					value = SettlMethod;
					break;
				}
				case "SettlSubMethod":
				{
					value = SettlSubMethod;
					break;
				}
				case "ExerciseStyle":
				{
					value = ExerciseStyle;
					break;
				}
				case "OptPayoutType":
				{
					value = OptPayoutType;
					break;
				}
				case "OptPayoutAmount":
				{
					value = OptPayoutAmount;
					break;
				}
				case "ReturnTrigger":
				{
					value = ReturnTrigger;
					break;
				}
				case "PriceQuoteMethod":
				{
					value = PriceQuoteMethod;
					break;
				}
				case "ValuationMethod":
				{
					value = ValuationMethod;
					break;
				}
				case "ValuationSource":
				{
					value = ValuationSource;
					break;
				}
				case "ValuationReferenceModel":
				{
					value = ValuationReferenceModel;
					break;
				}
				case "PriceQuoteCurrency":
				{
					value = PriceQuoteCurrency;
					break;
				}
				case "PriceQuoteCurrencyCodeSource":
				{
					value = PriceQuoteCurrencyCodeSource;
					break;
				}
				case "ListMethod":
				{
					value = ListMethod;
					break;
				}
				case "CapPrice":
				{
					value = CapPrice;
					break;
				}
				case "FloorPrice":
				{
					value = FloorPrice;
					break;
				}
				case "PutOrCall":
				{
					value = PutOrCall;
					break;
				}
				case "InTheMoneyCondition":
				{
					value = InTheMoneyCondition;
					break;
				}
				case "ContraryInstructionEligibilityIndicator":
				{
					value = ContraryInstructionEligibilityIndicator;
					break;
				}
				case "FlexibleIndicator":
				{
					value = FlexibleIndicator;
					break;
				}
				case "FlexProductEligibilityIndicator":
				{
					value = FlexProductEligibilityIndicator;
					break;
				}
				case "BlockTradeEligibilityIndicator":
				{
					value = BlockTradeEligibilityIndicator;
					break;
				}
				case "LowExercisePriceOptionIndicator":
				{
					value = LowExercisePriceOptionIndicator;
					break;
				}
				case "TimeUnit":
				{
					value = TimeUnit;
					break;
				}
				case "CouponRate":
				{
					value = CouponRate;
					break;
				}
				case "SecurityExchange":
				{
					value = SecurityExchange;
					break;
				}
				case "PositionLimit":
				{
					value = PositionLimit;
					break;
				}
				case "NTPositionLimit":
				{
					value = NTPositionLimit;
					break;
				}
				case "Issuer":
				{
					value = Issuer;
					break;
				}
				case "EncodedIssuerLen":
				{
					value = EncodedIssuerLen;
					break;
				}
				case "EncodedIssuer":
				{
					value = EncodedIssuer;
					break;
				}
				case "FinancialInstrumentShortName":
				{
					value = FinancialInstrumentShortName;
					break;
				}
				case "FinancialInstrumentFullName":
				{
					value = FinancialInstrumentFullName;
					break;
				}
				case "EncodedFinancialInstrumentFullNameLen":
				{
					value = EncodedFinancialInstrumentFullNameLen;
					break;
				}
				case "EncodedFinancialInstrumentFullName":
				{
					value = EncodedFinancialInstrumentFullName;
					break;
				}
				case "SecurityDesc":
				{
					value = SecurityDesc;
					break;
				}
				case "EncodedSecurityDescLen":
				{
					value = EncodedSecurityDescLen;
					break;
				}
				case "EncodedSecurityDesc":
				{
					value = EncodedSecurityDesc;
					break;
				}
				case "SecurityXML":
				{
					value = SecurityXML;
					break;
				}
				case "Pool":
				{
					value = Pool;
					break;
				}
				case "ContractSettlMonth":
				{
					value = ContractSettlMonth;
					break;
				}
				case "CPProgram":
				{
					value = CPProgram;
					break;
				}
				case "CPRegType":
				{
					value = CPRegType;
					break;
				}
				case "EvntGrp":
				{
					value = EvntGrp;
					break;
				}
				case "DatedDate":
				{
					value = DatedDate;
					break;
				}
				case "InterestAccrualDate":
				{
					value = InterestAccrualDate;
					break;
				}
				case "InstrumentParties":
				{
					value = InstrumentParties;
					break;
				}
				case "ShortSaleRestriction":
				{
					value = ShortSaleRestriction;
					break;
				}
				case "ComplexEvents":
				{
					value = ComplexEvents;
					break;
				}
				case "RefTickTableID":
				{
					value = RefTickTableID;
					break;
				}
				case "StrategyType":
				{
					value = StrategyType;
					break;
				}
				case "CommonPricingIndicator":
				{
					value = CommonPricingIndicator;
					break;
				}
				case "SettlDisruptionProvision":
				{
					value = SettlDisruptionProvision;
					break;
				}
				case "DeliveryRouteOrCharter":
				{
					value = DeliveryRouteOrCharter;
					break;
				}
				case "InstrumentRoundingDirection":
				{
					value = InstrumentRoundingDirection;
					break;
				}
				case "InstrumentRoundingPrecision":
				{
					value = InstrumentRoundingPrecision;
					break;
				}
				case "InstrumentPricePrecision":
				{
					value = InstrumentPricePrecision;
					break;
				}
				case "SecurityReferenceDataSupplement":
				{
					value = SecurityReferenceDataSupplement;
					break;
				}
				case "DateAdjustment":
				{
					value = DateAdjustment;
					break;
				}
				case "PricingDateTime":
				{
					value = PricingDateTime;
					break;
				}
				case "MarketDisruption":
				{
					value = MarketDisruption;
					break;
				}
				case "OptionExercise":
				{
					value = OptionExercise;
					break;
				}
				case "StreamGrp":
				{
					value = StreamGrp;
					break;
				}
				case "ProvisionGrp":
				{
					value = ProvisionGrp;
					break;
				}
				case "AdditionalTermGrp":
				{
					value = AdditionalTermGrp;
					break;
				}
				case "ProtectionTermGrp":
				{
					value = ProtectionTermGrp;
					break;
				}
				case "CashSettlTermGrp":
				{
					value = CashSettlTermGrp;
					break;
				}
				case "PhysicalSettlTermGrp":
				{
					value = PhysicalSettlTermGrp;
					break;
				}
				case "ExtraordinaryEventGrp":
				{
					value = ExtraordinaryEventGrp;
					break;
				}
				case "ExtraordinaryEventAdjustmentMethod":
				{
					value = ExtraordinaryEventAdjustmentMethod;
					break;
				}
				case "ExchangeLookAlike":
				{
					value = ExchangeLookAlike;
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
			Symbol = null;
			SymbolSfx = null;
			SecurityID = null;
			SecurityIDSource = null;
			((IFixReset?)SecAltIDGrp)?.Reset();
			Product = null;
			ProductComplex = null;
			SecurityGroup = null;
			CFICode = null;
			UPICode = null;
			SecurityType = null;
			SecuritySubType = null;
			Currency = null;
			InstrumentCustom = null;
			MaturityMonthYear = null;
			MaturityDate = null;
			MaturityTime = null;
			SettleOnOpenFlag = null;
			InstrmtAssignmentMethod = null;
			SecurityStatus = null;
			CouponPaymentDate = null;
			RestructuringType = null;
			Seniority = null;
			NotionalPercentageOutstanding = null;
			OriginalNotionalPercentageOutstanding = null;
			AttachmentPoint = null;
			DetachmentPoint = null;
			ObligationType = null;
			AssetGroup = null;
			AssetClass = null;
			AssetSubClass = null;
			AssetType = null;
			AssetSubType = null;
			((IFixReset?)SecondaryAssetGrp)?.Reset();
			((IFixReset?)AssetAttributeGrp)?.Reset();
			SwapClass = null;
			SwapSubClass = null;
			NthToDefault = null;
			MthToDefault = null;
			SettledEntityMatrixSource = null;
			SettledEntityMatrixPublicationDate = null;
			CouponType = null;
			TotalIssuedAmount = null;
			CouponFrequencyPeriod = null;
			CouponFrequencyUnit = null;
			CouponDayCount = null;
			CouponOtherDayCount = null;
			ConvertibleBondEquityID = null;
			ConvertibleBondEquityIDSource = null;
			ContractPriceRefMonth = null;
			LienSeniority = null;
			LoanFacility = null;
			ReferenceEntityType = null;
			IndexSeries = null;
			IndexAnnexVersion = null;
			IndexAnnexDate = null;
			IndexAnnexSource = null;
			SettlRateIndex = null;
			SettlRateIndexLocation = null;
			OptionExpirationDesc = null;
			EncodedOptionExpirationDescLen = null;
			EncodedOptionExpirationDesc = null;
			IssueDate = null;
			RepoCollateralSecurityType = null;
			RepurchaseTerm = null;
			RepurchaseRate = null;
			Factor = null;
			CreditRating = null;
			InstrRegistry = null;
			CountryOfIssue = null;
			StateOrProvinceOfIssue = null;
			LocaleOfIssue = null;
			RedemptionDate = null;
			StrikePrice = null;
			OrigStrikePrice = null;
			StrikePricePrecision = null;
			StrikeCurrency = null;
			StrikeCurrencyCodeSource = null;
			StrikeMultiplier = null;
			StrikeValue = null;
			StrikeUnitOfMeasure = null;
			StrikeIndex = null;
			StrikeIndexCurvePoint = null;
			StrikeIndexSpread = null;
			StrikeIndexQuote = null;
			StrikePriceDeterminationMethod = null;
			StrikePriceBoundaryMethod = null;
			StrikePriceBoundaryPrecision = null;
			UnderlyingPriceDeterminationMethod = null;
			OptAttribute = null;
			ContractMultiplier = null;
			ContractMultiplierUnit = null;
			TradingUnitPeriodMultiplier = null;
			FlowScheduleType = null;
			MinPriceIncrement = null;
			MinPriceIncrementAmount = null;
			UnitOfMeasure = null;
			UnitOfMeasureQty = null;
			UnitOfMeasureCurrency = null;
			UnitOfMeasureCurrencyCodeSource = null;
			PriceUnitOfMeasure = null;
			PriceUnitOfMeasureQty = null;
			PriceUnitOfMeasureCurrency = null;
			PriceUnitOfMeasureCurrencyCodeSource = null;
			SettlMethod = null;
			SettlSubMethod = null;
			ExerciseStyle = null;
			OptPayoutType = null;
			OptPayoutAmount = null;
			ReturnTrigger = null;
			PriceQuoteMethod = null;
			ValuationMethod = null;
			ValuationSource = null;
			ValuationReferenceModel = null;
			PriceQuoteCurrency = null;
			PriceQuoteCurrencyCodeSource = null;
			ListMethod = null;
			CapPrice = null;
			FloorPrice = null;
			PutOrCall = null;
			InTheMoneyCondition = null;
			ContraryInstructionEligibilityIndicator = null;
			FlexibleIndicator = null;
			FlexProductEligibilityIndicator = null;
			BlockTradeEligibilityIndicator = null;
			LowExercisePriceOptionIndicator = null;
			TimeUnit = null;
			CouponRate = null;
			SecurityExchange = null;
			PositionLimit = null;
			NTPositionLimit = null;
			Issuer = null;
			EncodedIssuerLen = null;
			EncodedIssuer = null;
			FinancialInstrumentShortName = null;
			FinancialInstrumentFullName = null;
			EncodedFinancialInstrumentFullNameLen = null;
			EncodedFinancialInstrumentFullName = null;
			SecurityDesc = null;
			EncodedSecurityDescLen = null;
			EncodedSecurityDesc = null;
			((IFixReset?)SecurityXML)?.Reset();
			Pool = null;
			ContractSettlMonth = null;
			CPProgram = null;
			CPRegType = null;
			((IFixReset?)EvntGrp)?.Reset();
			DatedDate = null;
			InterestAccrualDate = null;
			((IFixReset?)InstrumentParties)?.Reset();
			ShortSaleRestriction = null;
			((IFixReset?)ComplexEvents)?.Reset();
			RefTickTableID = null;
			StrategyType = null;
			CommonPricingIndicator = null;
			SettlDisruptionProvision = null;
			DeliveryRouteOrCharter = null;
			InstrumentRoundingDirection = null;
			InstrumentRoundingPrecision = null;
			InstrumentPricePrecision = null;
			SecurityReferenceDataSupplement = null;
			((IFixReset?)DateAdjustment)?.Reset();
			((IFixReset?)PricingDateTime)?.Reset();
			((IFixReset?)MarketDisruption)?.Reset();
			((IFixReset?)OptionExercise)?.Reset();
			((IFixReset?)StreamGrp)?.Reset();
			((IFixReset?)ProvisionGrp)?.Reset();
			((IFixReset?)AdditionalTermGrp)?.Reset();
			((IFixReset?)ProtectionTermGrp)?.Reset();
			((IFixReset?)CashSettlTermGrp)?.Reset();
			((IFixReset?)PhysicalSettlTermGrp)?.Reset();
			((IFixReset?)ExtraordinaryEventGrp)?.Reset();
			ExtraordinaryEventAdjustmentMethod = null;
			ExchangeLookAlike = null;
		}
	}
}
