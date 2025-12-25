using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class InstrumentLeg : IFixComponent
	{
		[TagDetails(Tag = 600, Type = TagType.String, Offset = 0, Required = false)]
		public string? LegSymbol {get; set;}
		
		[TagDetails(Tag = 601, Type = TagType.String, Offset = 1, Required = false)]
		public string? LegSymbolSfx {get; set;}
		
		[TagDetails(Tag = 602, Type = TagType.String, Offset = 2, Required = false)]
		public string? LegSecurityID {get; set;}
		
		[TagDetails(Tag = 603, Type = TagType.String, Offset = 3, Required = false)]
		public string? LegSecurityIDSource {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public LegSecAltIDGrp? LegSecAltIDGrp {get; set;}
		
		[TagDetails(Tag = 1788, Type = TagType.String, Offset = 5, Required = false)]
		public string? LegID {get; set;}
		
		[TagDetails(Tag = 607, Type = TagType.Int, Offset = 6, Required = false)]
		public int? LegProduct {get; set;}
		
		[TagDetails(Tag = 1594, Type = TagType.String, Offset = 7, Required = false)]
		public string? LegSecurityGroup {get; set;}
		
		[TagDetails(Tag = 608, Type = TagType.String, Offset = 8, Required = false)]
		public string? LegCFICode {get; set;}
		
		[TagDetails(Tag = 2893, Type = TagType.String, Offset = 9, Required = false)]
		public string? LegUPICode {get; set;}
		
		[TagDetails(Tag = 609, Type = TagType.String, Offset = 10, Required = false)]
		public string? LegSecurityType {get; set;}
		
		[TagDetails(Tag = 764, Type = TagType.String, Offset = 11, Required = false)]
		public string? LegSecuritySubType {get; set;}
		
		[TagDetails(Tag = 610, Type = TagType.MonthYear, Offset = 12, Required = false)]
		public MonthYear? LegMaturityMonthYear {get; set;}
		
		[TagDetails(Tag = 611, Type = TagType.LocalDate, Offset = 13, Required = false)]
		public DateOnly? LegMaturityDate {get; set;}
		
		[TagDetails(Tag = 1212, Type = TagType.String, Offset = 14, Required = false)]
		public string? LegMaturityTime {get; set;}
		
		[TagDetails(Tag = 2146, Type = TagType.String, Offset = 15, Required = false)]
		public string? LegSettleOnOpenFlag {get; set;}
		
		[TagDetails(Tag = 2147, Type = TagType.String, Offset = 16, Required = false)]
		public string? LegInstrmtAssignmentMethod {get; set;}
		
		[TagDetails(Tag = 2148, Type = TagType.String, Offset = 17, Required = false)]
		public string? LegSecurityStatus {get; set;}
		
		[TagDetails(Tag = 248, Type = TagType.LocalDate, Offset = 18, Required = false)]
		public DateOnly? LegCouponPaymentDate {get; set;}
		
		[TagDetails(Tag = 2149, Type = TagType.String, Offset = 19, Required = false)]
		public string? LegRestructuringType {get; set;}
		
		[TagDetails(Tag = 2150, Type = TagType.String, Offset = 20, Required = false)]
		public string? LegSeniority {get; set;}
		
		[TagDetails(Tag = 2151, Type = TagType.Float, Offset = 21, Required = false)]
		public double? LegNotionalPercentageOutstanding {get; set;}
		
		[TagDetails(Tag = 2152, Type = TagType.Float, Offset = 22, Required = false)]
		public double? LegOriginalNotionalPercentageOutstanding {get; set;}
		
		[TagDetails(Tag = 2153, Type = TagType.Float, Offset = 23, Required = false)]
		public double? LegAttachmentPoint {get; set;}
		
		[TagDetails(Tag = 2154, Type = TagType.Float, Offset = 24, Required = false)]
		public double? LegDetachmentPoint {get; set;}
		
		[TagDetails(Tag = 2155, Type = TagType.String, Offset = 25, Required = false)]
		public string? LegObligationType {get; set;}
		
		[TagDetails(Tag = 2348, Type = TagType.Int, Offset = 26, Required = false)]
		public int? LegAssetGroup {get; set;}
		
		[TagDetails(Tag = 2067, Type = TagType.Int, Offset = 27, Required = false)]
		public int? LegAssetClass {get; set;}
		
		[TagDetails(Tag = 2068, Type = TagType.Int, Offset = 28, Required = false)]
		public int? LegAssetSubClass {get; set;}
		
		[TagDetails(Tag = 2069, Type = TagType.String, Offset = 29, Required = false)]
		public string? LegAssetType {get; set;}
		
		[TagDetails(Tag = 2739, Type = TagType.String, Offset = 30, Required = false)]
		public string? LegAssetSubType {get; set;}
		
		[Component(Offset = 31, Required = false)]
		public LegSecondaryAssetGrp? LegSecondaryAssetGrp {get; set;}
		
		[Component(Offset = 32, Required = false)]
		public LegAssetAttributeGrp? LegAssetAttributeGrp {get; set;}
		
		[TagDetails(Tag = 2070, Type = TagType.String, Offset = 33, Required = false)]
		public string? LegSwapClass {get; set;}
		
		[TagDetails(Tag = 2156, Type = TagType.String, Offset = 34, Required = false)]
		public string? LegSwapSubClass {get; set;}
		
		[TagDetails(Tag = 2157, Type = TagType.Int, Offset = 35, Required = false)]
		public int? LegNthToDefault {get; set;}
		
		[TagDetails(Tag = 2158, Type = TagType.Int, Offset = 36, Required = false)]
		public int? LegMthToDefault {get; set;}
		
		[TagDetails(Tag = 2159, Type = TagType.String, Offset = 37, Required = false)]
		public string? LegSettledEntityMatrixSource {get; set;}
		
		[TagDetails(Tag = 2160, Type = TagType.LocalDate, Offset = 38, Required = false)]
		public DateOnly? LegSettledEntityMatrixPublicationDate {get; set;}
		
		[TagDetails(Tag = 2161, Type = TagType.Int, Offset = 39, Required = false)]
		public int? LegCouponType {get; set;}
		
		[TagDetails(Tag = 2162, Type = TagType.Float, Offset = 40, Required = false)]
		public double? LegTotalIssuedAmount {get; set;}
		
		[TagDetails(Tag = 2163, Type = TagType.Int, Offset = 41, Required = false)]
		public int? LegCouponFrequencyPeriod {get; set;}
		
		[TagDetails(Tag = 2164, Type = TagType.String, Offset = 42, Required = false)]
		public string? LegCouponFrequencyUnit {get; set;}
		
		[TagDetails(Tag = 2165, Type = TagType.Int, Offset = 43, Required = false)]
		public int? LegCouponDayCount {get; set;}
		
		[TagDetails(Tag = 2880, Type = TagType.String, Offset = 44, Required = false)]
		public string? LegCouponOtherDayCount {get; set;}
		
		[TagDetails(Tag = 2166, Type = TagType.String, Offset = 45, Required = false)]
		public string? LegConvertibleBondEquityID {get; set;}
		
		[TagDetails(Tag = 2167, Type = TagType.String, Offset = 46, Required = false)]
		public string? LegConvertibleBondEquityIDSource {get; set;}
		
		[TagDetails(Tag = 2168, Type = TagType.MonthYear, Offset = 47, Required = false)]
		public MonthYear? LegContractPriceRefMonth {get; set;}
		
		[TagDetails(Tag = 2169, Type = TagType.Int, Offset = 48, Required = false)]
		public int? LegLienSeniority {get; set;}
		
		[TagDetails(Tag = 2170, Type = TagType.Int, Offset = 49, Required = false)]
		public int? LegLoanFacility {get; set;}
		
		[TagDetails(Tag = 2171, Type = TagType.Int, Offset = 50, Required = false)]
		public int? LegReferenceEntityType {get; set;}
		
		[TagDetails(Tag = 2172, Type = TagType.Int, Offset = 51, Required = false)]
		public int? LegIndexSeries {get; set;}
		
		[TagDetails(Tag = 2173, Type = TagType.Int, Offset = 52, Required = false)]
		public int? LegIndexAnnexVersion {get; set;}
		
		[TagDetails(Tag = 2174, Type = TagType.LocalDate, Offset = 53, Required = false)]
		public DateOnly? LegIndexAnnexDate {get; set;}
		
		[TagDetails(Tag = 2175, Type = TagType.String, Offset = 54, Required = false)]
		public string? LegIndexAnnexSource {get; set;}
		
		[TagDetails(Tag = 2176, Type = TagType.String, Offset = 55, Required = false)]
		public string? LegSettlRateIndex {get; set;}
		
		[TagDetails(Tag = 2177, Type = TagType.String, Offset = 56, Required = false)]
		public string? LegSettlRateIndexLocation {get; set;}
		
		[TagDetails(Tag = 2178, Type = TagType.String, Offset = 57, Required = false)]
		public string? LegOptionExpirationDesc {get; set;}
		
		[TagDetails(Tag = 2179, Type = TagType.Length, Offset = 58, Required = false)]
		public int? EncodedLegOptionExpirationDescLen {get; set;}
		
		[TagDetails(Tag = 2180, Type = TagType.RawData, Offset = 59, Required = false)]
		public byte[]? EncodedLegOptionExpirationDesc {get; set;}
		
		[TagDetails(Tag = 249, Type = TagType.LocalDate, Offset = 60, Required = false)]
		public DateOnly? LegIssueDate {get; set;}
		
		[TagDetails(Tag = 250, Type = TagType.String, Offset = 61, Required = false)]
		public string? LegRepoCollateralSecurityType {get; set;}
		
		[TagDetails(Tag = 251, Type = TagType.Int, Offset = 62, Required = false)]
		public int? LegRepurchaseTerm {get; set;}
		
		[TagDetails(Tag = 252, Type = TagType.Float, Offset = 63, Required = false)]
		public double? LegRepurchaseRate {get; set;}
		
		[TagDetails(Tag = 253, Type = TagType.Float, Offset = 64, Required = false)]
		public double? LegFactor {get; set;}
		
		[TagDetails(Tag = 257, Type = TagType.String, Offset = 65, Required = false)]
		public string? LegCreditRating {get; set;}
		
		[TagDetails(Tag = 599, Type = TagType.String, Offset = 66, Required = false)]
		public string? LegInstrRegistry {get; set;}
		
		[TagDetails(Tag = 596, Type = TagType.String, Offset = 67, Required = false)]
		public string? LegCountryOfIssue {get; set;}
		
		[TagDetails(Tag = 597, Type = TagType.String, Offset = 68, Required = false)]
		public string? LegStateOrProvinceOfIssue {get; set;}
		
		[TagDetails(Tag = 598, Type = TagType.String, Offset = 69, Required = false)]
		public string? LegLocaleOfIssue {get; set;}
		
		[TagDetails(Tag = 254, Type = TagType.LocalDate, Offset = 70, Required = false)]
		public DateOnly? LegRedemptionDate {get; set;}
		
		[TagDetails(Tag = 612, Type = TagType.Float, Offset = 71, Required = false)]
		public double? LegStrikePrice {get; set;}
		
		[TagDetails(Tag = 942, Type = TagType.String, Offset = 72, Required = false)]
		public string? LegStrikeCurrency {get; set;}
		
		[TagDetails(Tag = 2908, Type = TagType.String, Offset = 73, Required = false)]
		public string? LegStrikeCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 2181, Type = TagType.Float, Offset = 74, Required = false)]
		public double? LegStrikeMultiplier {get; set;}
		
		[TagDetails(Tag = 2182, Type = TagType.Float, Offset = 75, Required = false)]
		public double? LegStrikeValue {get; set;}
		
		[TagDetails(Tag = 2183, Type = TagType.String, Offset = 76, Required = false)]
		public string? LegStrikeUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 2184, Type = TagType.String, Offset = 77, Required = false)]
		public string? LegStrikeIndex {get; set;}
		
		[TagDetails(Tag = 2604, Type = TagType.String, Offset = 78, Required = false)]
		public string? LegStrikeIndexCurvePoint {get; set;}
		
		[TagDetails(Tag = 2185, Type = TagType.Float, Offset = 79, Required = false)]
		public double? LegStrikeIndexSpread {get; set;}
		
		[TagDetails(Tag = 2605, Type = TagType.Int, Offset = 80, Required = false)]
		public int? LegStrikeIndexQuote {get; set;}
		
		[TagDetails(Tag = 2186, Type = TagType.Int, Offset = 81, Required = false)]
		public int? LegStrikePriceDeterminationMethod {get; set;}
		
		[TagDetails(Tag = 2187, Type = TagType.Int, Offset = 82, Required = false)]
		public int? LegStrikePriceBoundaryMethod {get; set;}
		
		[TagDetails(Tag = 2188, Type = TagType.Float, Offset = 83, Required = false)]
		public double? LegStrikePriceBoundaryPrecision {get; set;}
		
		[TagDetails(Tag = 2189, Type = TagType.Int, Offset = 84, Required = false)]
		public int? LegUnderlyingPriceDeterminationMethod {get; set;}
		
		[TagDetails(Tag = 613, Type = TagType.String, Offset = 85, Required = false)]
		public string? LegOptAttribute {get; set;}
		
		[TagDetails(Tag = 614, Type = TagType.Float, Offset = 86, Required = false)]
		public double? LegContractMultiplier {get; set;}
		
		[TagDetails(Tag = 1436, Type = TagType.Int, Offset = 87, Required = false)]
		public int? LegContractMultiplierUnit {get; set;}
		
		[TagDetails(Tag = 2354, Type = TagType.Int, Offset = 88, Required = false)]
		public int? LegTradingUnitPeriodMultiplier {get; set;}
		
		[TagDetails(Tag = 1440, Type = TagType.Int, Offset = 89, Required = false)]
		public int? LegFlowScheduleType {get; set;}
		
		[TagDetails(Tag = 2190, Type = TagType.Float, Offset = 90, Required = false)]
		public double? LegMinPriceIncrement {get; set;}
		
		[TagDetails(Tag = 2191, Type = TagType.Float, Offset = 91, Required = false)]
		public double? LegMinPriceIncrementAmount {get; set;}
		
		[TagDetails(Tag = 999, Type = TagType.String, Offset = 92, Required = false)]
		public string? LegUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 1224, Type = TagType.Float, Offset = 93, Required = false)]
		public double? LegUnitOfMeasureQty {get; set;}
		
		[TagDetails(Tag = 1720, Type = TagType.String, Offset = 94, Required = false)]
		public string? LegUnitOfMeasureCurrency {get; set;}
		
		[TagDetails(Tag = 2909, Type = TagType.String, Offset = 95, Required = false)]
		public string? LegUnitOfMeasureCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 1421, Type = TagType.String, Offset = 96, Required = false)]
		public string? LegPriceUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 1422, Type = TagType.Float, Offset = 97, Required = false)]
		public double? LegPriceUnitOfMeasureQty {get; set;}
		
		[TagDetails(Tag = 1721, Type = TagType.String, Offset = 98, Required = false)]
		public string? LegPriceUnitOfMeasureCurrency {get; set;}
		
		[TagDetails(Tag = 2910, Type = TagType.String, Offset = 99, Required = false)]
		public string? LegPriceUnitOfMeasureCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 2192, Type = TagType.String, Offset = 100, Required = false)]
		public string? LegSettlMethod {get; set;}
		
		[TagDetails(Tag = 1001, Type = TagType.String, Offset = 101, Required = false)]
		public string? LegTimeUnit {get; set;}
		
		[TagDetails(Tag = 1420, Type = TagType.Int, Offset = 102, Required = false)]
		public int? LegExerciseStyle {get; set;}
		
		[TagDetails(Tag = 2193, Type = TagType.Int, Offset = 103, Required = false)]
		public int? LegOptPayoutType {get; set;}
		
		[TagDetails(Tag = 2194, Type = TagType.Float, Offset = 104, Required = false)]
		public double? LegOptPayoutAmount {get; set;}
		
		[TagDetails(Tag = 2755, Type = TagType.Int, Offset = 105, Required = false)]
		public int? LegReturnTrigger {get; set;}
		
		[TagDetails(Tag = 2195, Type = TagType.String, Offset = 106, Required = false)]
		public string? LegPriceQuoteMethod {get; set;}
		
		[TagDetails(Tag = 2196, Type = TagType.String, Offset = 107, Required = false)]
		public string? LegValuationMethod {get; set;}
		
		[TagDetails(Tag = 2197, Type = TagType.String, Offset = 108, Required = false)]
		public string? LegValuationSource {get; set;}
		
		[TagDetails(Tag = 2198, Type = TagType.String, Offset = 109, Required = false)]
		public string? LegValuationReferenceModel {get; set;}
		
		[TagDetails(Tag = 1528, Type = TagType.String, Offset = 110, Required = false)]
		public string? LegPriceQuoteCurrency {get; set;}
		
		[TagDetails(Tag = 2911, Type = TagType.String, Offset = 111, Required = false)]
		public string? LegPriceQuoteCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 2199, Type = TagType.Int, Offset = 112, Required = false)]
		public int? LegListMethod {get; set;}
		
		[TagDetails(Tag = 2200, Type = TagType.Float, Offset = 113, Required = false)]
		public double? LegCapPrice {get; set;}
		
		[TagDetails(Tag = 2201, Type = TagType.Float, Offset = 114, Required = false)]
		public double? LegFloorPrice {get; set;}
		
		[TagDetails(Tag = 2202, Type = TagType.Boolean, Offset = 115, Required = false)]
		public bool? LegFlexibleIndicator {get; set;}
		
		[TagDetails(Tag = 2203, Type = TagType.Boolean, Offset = 116, Required = false)]
		public bool? LegFlexProductEligibilityIndicator {get; set;}
		
		[TagDetails(Tag = 615, Type = TagType.Float, Offset = 117, Required = false)]
		public double? LegCouponRate {get; set;}
		
		[TagDetails(Tag = 616, Type = TagType.String, Offset = 118, Required = false)]
		public string? LegSecurityExchange {get; set;}
		
		[TagDetails(Tag = 2205, Type = TagType.Int, Offset = 119, Required = false)]
		public int? LegPositionLimit {get; set;}
		
		[TagDetails(Tag = 2206, Type = TagType.Int, Offset = 120, Required = false)]
		public int? LegNTPositionLimit {get; set;}
		
		[TagDetails(Tag = 617, Type = TagType.String, Offset = 121, Required = false)]
		public string? LegIssuer {get; set;}
		
		[TagDetails(Tag = 618, Type = TagType.Length, Offset = 122, Required = false)]
		public int? EncodedLegIssuerLen {get; set;}
		
		[TagDetails(Tag = 619, Type = TagType.RawData, Offset = 123, Required = false)]
		public byte[]? EncodedLegIssuer {get; set;}
		
		[TagDetails(Tag = 2740, Type = TagType.String, Offset = 124, Required = false)]
		public string? LegFinancialInstrumentShortName {get; set;}
		
		[TagDetails(Tag = 2717, Type = TagType.String, Offset = 125, Required = false)]
		public string? LegFinancialInstrumentFullName {get; set;}
		
		[TagDetails(Tag = 2718, Type = TagType.Length, Offset = 126, Required = false)]
		public int? EncodedLegFinancialInstrumentFullNameLen {get; set;}
		
		[TagDetails(Tag = 2719, Type = TagType.RawData, Offset = 127, Required = false)]
		public byte[]? EncodedLegFinancialInstrumentFullName {get; set;}
		
		[TagDetails(Tag = 620, Type = TagType.String, Offset = 128, Required = false)]
		public string? LegSecurityDesc {get; set;}
		
		[TagDetails(Tag = 621, Type = TagType.Length, Offset = 129, Required = false)]
		public int? EncodedLegSecurityDescLen {get; set;}
		
		[TagDetails(Tag = 622, Type = TagType.RawData, Offset = 130, Required = false)]
		public byte[]? EncodedLegSecurityDesc {get; set;}
		
		[Component(Offset = 131, Required = false)]
		public LegSecurityXML? LegSecurityXML {get; set;}
		
		[TagDetails(Tag = 2207, Type = TagType.Int, Offset = 132, Required = false)]
		public int? LegCPProgram {get; set;}
		
		[TagDetails(Tag = 2208, Type = TagType.String, Offset = 133, Required = false)]
		public string? LegCPRegType {get; set;}
		
		[TagDetails(Tag = 623, Type = TagType.Float, Offset = 134, Required = false)]
		public double? LegRatioQty {get; set;}
		
		[TagDetails(Tag = 624, Type = TagType.String, Offset = 135, Required = false)]
		public string? LegSide {get; set;}
		
		[TagDetails(Tag = 556, Type = TagType.String, Offset = 136, Required = false)]
		public string? LegCurrency {get; set;}
		
		[TagDetails(Tag = 2898, Type = TagType.String, Offset = 137, Required = false)]
		public string? LegCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 740, Type = TagType.String, Offset = 138, Required = false)]
		public string? LegPool {get; set;}
		
		[TagDetails(Tag = 739, Type = TagType.LocalDate, Offset = 139, Required = false)]
		public DateOnly? LegDatedDate {get; set;}
		
		[TagDetails(Tag = 955, Type = TagType.MonthYear, Offset = 140, Required = false)]
		public MonthYear? LegContractSettlMonth {get; set;}
		
		[TagDetails(Tag = 956, Type = TagType.LocalDate, Offset = 141, Required = false)]
		public DateOnly? LegInterestAccrualDate {get; set;}
		
		[TagDetails(Tag = 1358, Type = TagType.Int, Offset = 142, Required = false)]
		public int? LegPutOrCall {get; set;}
		
		[TagDetails(Tag = 2682, Type = TagType.Int, Offset = 143, Required = false)]
		public int? LegInTheMoneyCondition {get; set;}
		
		[TagDetails(Tag = 2686, Type = TagType.Boolean, Offset = 144, Required = false)]
		public bool? LegContraryInstructionEligibilityIndicator {get; set;}
		
		[TagDetails(Tag = 1017, Type = TagType.Float, Offset = 145, Required = false)]
		public double? LegOptionRatio {get; set;}
		
		[TagDetails(Tag = 566, Type = TagType.Float, Offset = 146, Required = false)]
		public double? LegPrice {get; set;}
		
		[Component(Offset = 147, Required = false)]
		public LegEvntGrp? LegEvntGrp {get; set;}
		
		[Component(Offset = 148, Required = false)]
		public LegInstrumentParties? LegInstrumentParties {get; set;}
		
		[TagDetails(Tag = 2209, Type = TagType.Int, Offset = 149, Required = false)]
		public int? LegShortSaleRestriction {get; set;}
		
		[Component(Offset = 150, Required = false)]
		public LegComplexEvents? LegComplexEvents {get; set;}
		
		[TagDetails(Tag = 2211, Type = TagType.String, Offset = 151, Required = false)]
		public string? LegStrategyType {get; set;}
		
		[TagDetails(Tag = 2212, Type = TagType.Boolean, Offset = 152, Required = false)]
		public bool? LegCommonPricingIndicator {get; set;}
		
		[TagDetails(Tag = 2213, Type = TagType.Int, Offset = 153, Required = false)]
		public int? LegSettlDisruptionProvision {get; set;}
		
		[TagDetails(Tag = 2754, Type = TagType.String, Offset = 154, Required = false)]
		public string? LegDeliveryRouteOrCharter {get; set;}
		
		[TagDetails(Tag = 2214, Type = TagType.String, Offset = 155, Required = false)]
		public string? LegInstrumentRoundingDirection {get; set;}
		
		[TagDetails(Tag = 2215, Type = TagType.Int, Offset = 156, Required = false)]
		public int? LegInstrumentRoundingPrecision {get; set;}
		
		[Component(Offset = 157, Required = false)]
		public LegDateAdjustment? LegDateAdjustment {get; set;}
		
		[Component(Offset = 158, Required = false)]
		public LegPricingDateTime? LegPricingDateTime {get; set;}
		
		[Component(Offset = 159, Required = false)]
		public LegMarketDisruption? LegMarketDisruption {get; set;}
		
		[Component(Offset = 160, Required = false)]
		public LegOptionExercise? LegOptionExercise {get; set;}
		
		[Component(Offset = 161, Required = false)]
		public LegStreamGrp? LegStreamGrp {get; set;}
		
		[Component(Offset = 162, Required = false)]
		public LegProvisionGrp? LegProvisionGrp {get; set;}
		
		[Component(Offset = 163, Required = false)]
		public LegAdditionalTermGrp? LegAdditionalTermGrp {get; set;}
		
		[Component(Offset = 164, Required = false)]
		public LegProtectionTermGrp? LegProtectionTermGrp {get; set;}
		
		[Component(Offset = 165, Required = false)]
		public LegCashSettlTermGrp? LegCashSettlTermGrp {get; set;}
		
		[Component(Offset = 166, Required = false)]
		public LegPhysicalSettlTermGrp? LegPhysicalSettlTermGrp {get; set;}
		
		[Component(Offset = 167, Required = false)]
		public LegExtraordinaryEventGrp? LegExtraordinaryEventGrp {get; set;}
		
		[TagDetails(Tag = 2606, Type = TagType.Int, Offset = 168, Required = false)]
		public int? LegExtraordinaryEventAdjustmentMethod {get; set;}
		
		[TagDetails(Tag = 2607, Type = TagType.Boolean, Offset = 169, Required = false)]
		public bool? LegExchangeLookAlike {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegSymbol is not null) writer.WriteString(600, LegSymbol);
			if (LegSymbolSfx is not null) writer.WriteString(601, LegSymbolSfx);
			if (LegSecurityID is not null) writer.WriteString(602, LegSecurityID);
			if (LegSecurityIDSource is not null) writer.WriteString(603, LegSecurityIDSource);
			if (LegSecAltIDGrp is not null) ((IFixEncoder)LegSecAltIDGrp).Encode(writer);
			if (LegID is not null) writer.WriteString(1788, LegID);
			if (LegProduct is not null) writer.WriteWholeNumber(607, LegProduct.Value);
			if (LegSecurityGroup is not null) writer.WriteString(1594, LegSecurityGroup);
			if (LegCFICode is not null) writer.WriteString(608, LegCFICode);
			if (LegUPICode is not null) writer.WriteString(2893, LegUPICode);
			if (LegSecurityType is not null) writer.WriteString(609, LegSecurityType);
			if (LegSecuritySubType is not null) writer.WriteString(764, LegSecuritySubType);
			if (LegMaturityMonthYear is not null) writer.WriteMonthYear(610, LegMaturityMonthYear.Value);
			if (LegMaturityDate is not null) writer.WriteLocalDateOnly(611, LegMaturityDate.Value);
			if (LegMaturityTime is not null) writer.WriteString(1212, LegMaturityTime);
			if (LegSettleOnOpenFlag is not null) writer.WriteString(2146, LegSettleOnOpenFlag);
			if (LegInstrmtAssignmentMethod is not null) writer.WriteString(2147, LegInstrmtAssignmentMethod);
			if (LegSecurityStatus is not null) writer.WriteString(2148, LegSecurityStatus);
			if (LegCouponPaymentDate is not null) writer.WriteLocalDateOnly(248, LegCouponPaymentDate.Value);
			if (LegRestructuringType is not null) writer.WriteString(2149, LegRestructuringType);
			if (LegSeniority is not null) writer.WriteString(2150, LegSeniority);
			if (LegNotionalPercentageOutstanding is not null) writer.WriteNumber(2151, LegNotionalPercentageOutstanding.Value);
			if (LegOriginalNotionalPercentageOutstanding is not null) writer.WriteNumber(2152, LegOriginalNotionalPercentageOutstanding.Value);
			if (LegAttachmentPoint is not null) writer.WriteNumber(2153, LegAttachmentPoint.Value);
			if (LegDetachmentPoint is not null) writer.WriteNumber(2154, LegDetachmentPoint.Value);
			if (LegObligationType is not null) writer.WriteString(2155, LegObligationType);
			if (LegAssetGroup is not null) writer.WriteWholeNumber(2348, LegAssetGroup.Value);
			if (LegAssetClass is not null) writer.WriteWholeNumber(2067, LegAssetClass.Value);
			if (LegAssetSubClass is not null) writer.WriteWholeNumber(2068, LegAssetSubClass.Value);
			if (LegAssetType is not null) writer.WriteString(2069, LegAssetType);
			if (LegAssetSubType is not null) writer.WriteString(2739, LegAssetSubType);
			if (LegSecondaryAssetGrp is not null) ((IFixEncoder)LegSecondaryAssetGrp).Encode(writer);
			if (LegAssetAttributeGrp is not null) ((IFixEncoder)LegAssetAttributeGrp).Encode(writer);
			if (LegSwapClass is not null) writer.WriteString(2070, LegSwapClass);
			if (LegSwapSubClass is not null) writer.WriteString(2156, LegSwapSubClass);
			if (LegNthToDefault is not null) writer.WriteWholeNumber(2157, LegNthToDefault.Value);
			if (LegMthToDefault is not null) writer.WriteWholeNumber(2158, LegMthToDefault.Value);
			if (LegSettledEntityMatrixSource is not null) writer.WriteString(2159, LegSettledEntityMatrixSource);
			if (LegSettledEntityMatrixPublicationDate is not null) writer.WriteLocalDateOnly(2160, LegSettledEntityMatrixPublicationDate.Value);
			if (LegCouponType is not null) writer.WriteWholeNumber(2161, LegCouponType.Value);
			if (LegTotalIssuedAmount is not null) writer.WriteNumber(2162, LegTotalIssuedAmount.Value);
			if (LegCouponFrequencyPeriod is not null) writer.WriteWholeNumber(2163, LegCouponFrequencyPeriod.Value);
			if (LegCouponFrequencyUnit is not null) writer.WriteString(2164, LegCouponFrequencyUnit);
			if (LegCouponDayCount is not null) writer.WriteWholeNumber(2165, LegCouponDayCount.Value);
			if (LegCouponOtherDayCount is not null) writer.WriteString(2880, LegCouponOtherDayCount);
			if (LegConvertibleBondEquityID is not null) writer.WriteString(2166, LegConvertibleBondEquityID);
			if (LegConvertibleBondEquityIDSource is not null) writer.WriteString(2167, LegConvertibleBondEquityIDSource);
			if (LegContractPriceRefMonth is not null) writer.WriteMonthYear(2168, LegContractPriceRefMonth.Value);
			if (LegLienSeniority is not null) writer.WriteWholeNumber(2169, LegLienSeniority.Value);
			if (LegLoanFacility is not null) writer.WriteWholeNumber(2170, LegLoanFacility.Value);
			if (LegReferenceEntityType is not null) writer.WriteWholeNumber(2171, LegReferenceEntityType.Value);
			if (LegIndexSeries is not null) writer.WriteWholeNumber(2172, LegIndexSeries.Value);
			if (LegIndexAnnexVersion is not null) writer.WriteWholeNumber(2173, LegIndexAnnexVersion.Value);
			if (LegIndexAnnexDate is not null) writer.WriteLocalDateOnly(2174, LegIndexAnnexDate.Value);
			if (LegIndexAnnexSource is not null) writer.WriteString(2175, LegIndexAnnexSource);
			if (LegSettlRateIndex is not null) writer.WriteString(2176, LegSettlRateIndex);
			if (LegSettlRateIndexLocation is not null) writer.WriteString(2177, LegSettlRateIndexLocation);
			if (LegOptionExpirationDesc is not null) writer.WriteString(2178, LegOptionExpirationDesc);
			if (EncodedLegOptionExpirationDescLen is not null) writer.WriteWholeNumber(2179, EncodedLegOptionExpirationDescLen.Value);
			if (EncodedLegOptionExpirationDesc is not null) writer.WriteBuffer(2180, EncodedLegOptionExpirationDesc);
			if (LegIssueDate is not null) writer.WriteLocalDateOnly(249, LegIssueDate.Value);
			if (LegRepoCollateralSecurityType is not null) writer.WriteString(250, LegRepoCollateralSecurityType);
			if (LegRepurchaseTerm is not null) writer.WriteWholeNumber(251, LegRepurchaseTerm.Value);
			if (LegRepurchaseRate is not null) writer.WriteNumber(252, LegRepurchaseRate.Value);
			if (LegFactor is not null) writer.WriteNumber(253, LegFactor.Value);
			if (LegCreditRating is not null) writer.WriteString(257, LegCreditRating);
			if (LegInstrRegistry is not null) writer.WriteString(599, LegInstrRegistry);
			if (LegCountryOfIssue is not null) writer.WriteString(596, LegCountryOfIssue);
			if (LegStateOrProvinceOfIssue is not null) writer.WriteString(597, LegStateOrProvinceOfIssue);
			if (LegLocaleOfIssue is not null) writer.WriteString(598, LegLocaleOfIssue);
			if (LegRedemptionDate is not null) writer.WriteLocalDateOnly(254, LegRedemptionDate.Value);
			if (LegStrikePrice is not null) writer.WriteNumber(612, LegStrikePrice.Value);
			if (LegStrikeCurrency is not null) writer.WriteString(942, LegStrikeCurrency);
			if (LegStrikeCurrencyCodeSource is not null) writer.WriteString(2908, LegStrikeCurrencyCodeSource);
			if (LegStrikeMultiplier is not null) writer.WriteNumber(2181, LegStrikeMultiplier.Value);
			if (LegStrikeValue is not null) writer.WriteNumber(2182, LegStrikeValue.Value);
			if (LegStrikeUnitOfMeasure is not null) writer.WriteString(2183, LegStrikeUnitOfMeasure);
			if (LegStrikeIndex is not null) writer.WriteString(2184, LegStrikeIndex);
			if (LegStrikeIndexCurvePoint is not null) writer.WriteString(2604, LegStrikeIndexCurvePoint);
			if (LegStrikeIndexSpread is not null) writer.WriteNumber(2185, LegStrikeIndexSpread.Value);
			if (LegStrikeIndexQuote is not null) writer.WriteWholeNumber(2605, LegStrikeIndexQuote.Value);
			if (LegStrikePriceDeterminationMethod is not null) writer.WriteWholeNumber(2186, LegStrikePriceDeterminationMethod.Value);
			if (LegStrikePriceBoundaryMethod is not null) writer.WriteWholeNumber(2187, LegStrikePriceBoundaryMethod.Value);
			if (LegStrikePriceBoundaryPrecision is not null) writer.WriteNumber(2188, LegStrikePriceBoundaryPrecision.Value);
			if (LegUnderlyingPriceDeterminationMethod is not null) writer.WriteWholeNumber(2189, LegUnderlyingPriceDeterminationMethod.Value);
			if (LegOptAttribute is not null) writer.WriteString(613, LegOptAttribute);
			if (LegContractMultiplier is not null) writer.WriteNumber(614, LegContractMultiplier.Value);
			if (LegContractMultiplierUnit is not null) writer.WriteWholeNumber(1436, LegContractMultiplierUnit.Value);
			if (LegTradingUnitPeriodMultiplier is not null) writer.WriteWholeNumber(2354, LegTradingUnitPeriodMultiplier.Value);
			if (LegFlowScheduleType is not null) writer.WriteWholeNumber(1440, LegFlowScheduleType.Value);
			if (LegMinPriceIncrement is not null) writer.WriteNumber(2190, LegMinPriceIncrement.Value);
			if (LegMinPriceIncrementAmount is not null) writer.WriteNumber(2191, LegMinPriceIncrementAmount.Value);
			if (LegUnitOfMeasure is not null) writer.WriteString(999, LegUnitOfMeasure);
			if (LegUnitOfMeasureQty is not null) writer.WriteNumber(1224, LegUnitOfMeasureQty.Value);
			if (LegUnitOfMeasureCurrency is not null) writer.WriteString(1720, LegUnitOfMeasureCurrency);
			if (LegUnitOfMeasureCurrencyCodeSource is not null) writer.WriteString(2909, LegUnitOfMeasureCurrencyCodeSource);
			if (LegPriceUnitOfMeasure is not null) writer.WriteString(1421, LegPriceUnitOfMeasure);
			if (LegPriceUnitOfMeasureQty is not null) writer.WriteNumber(1422, LegPriceUnitOfMeasureQty.Value);
			if (LegPriceUnitOfMeasureCurrency is not null) writer.WriteString(1721, LegPriceUnitOfMeasureCurrency);
			if (LegPriceUnitOfMeasureCurrencyCodeSource is not null) writer.WriteString(2910, LegPriceUnitOfMeasureCurrencyCodeSource);
			if (LegSettlMethod is not null) writer.WriteString(2192, LegSettlMethod);
			if (LegTimeUnit is not null) writer.WriteString(1001, LegTimeUnit);
			if (LegExerciseStyle is not null) writer.WriteWholeNumber(1420, LegExerciseStyle.Value);
			if (LegOptPayoutType is not null) writer.WriteWholeNumber(2193, LegOptPayoutType.Value);
			if (LegOptPayoutAmount is not null) writer.WriteNumber(2194, LegOptPayoutAmount.Value);
			if (LegReturnTrigger is not null) writer.WriteWholeNumber(2755, LegReturnTrigger.Value);
			if (LegPriceQuoteMethod is not null) writer.WriteString(2195, LegPriceQuoteMethod);
			if (LegValuationMethod is not null) writer.WriteString(2196, LegValuationMethod);
			if (LegValuationSource is not null) writer.WriteString(2197, LegValuationSource);
			if (LegValuationReferenceModel is not null) writer.WriteString(2198, LegValuationReferenceModel);
			if (LegPriceQuoteCurrency is not null) writer.WriteString(1528, LegPriceQuoteCurrency);
			if (LegPriceQuoteCurrencyCodeSource is not null) writer.WriteString(2911, LegPriceQuoteCurrencyCodeSource);
			if (LegListMethod is not null) writer.WriteWholeNumber(2199, LegListMethod.Value);
			if (LegCapPrice is not null) writer.WriteNumber(2200, LegCapPrice.Value);
			if (LegFloorPrice is not null) writer.WriteNumber(2201, LegFloorPrice.Value);
			if (LegFlexibleIndicator is not null) writer.WriteBoolean(2202, LegFlexibleIndicator.Value);
			if (LegFlexProductEligibilityIndicator is not null) writer.WriteBoolean(2203, LegFlexProductEligibilityIndicator.Value);
			if (LegCouponRate is not null) writer.WriteNumber(615, LegCouponRate.Value);
			if (LegSecurityExchange is not null) writer.WriteString(616, LegSecurityExchange);
			if (LegPositionLimit is not null) writer.WriteWholeNumber(2205, LegPositionLimit.Value);
			if (LegNTPositionLimit is not null) writer.WriteWholeNumber(2206, LegNTPositionLimit.Value);
			if (LegIssuer is not null) writer.WriteString(617, LegIssuer);
			if (EncodedLegIssuerLen is not null) writer.WriteWholeNumber(618, EncodedLegIssuerLen.Value);
			if (EncodedLegIssuer is not null) writer.WriteBuffer(619, EncodedLegIssuer);
			if (LegFinancialInstrumentShortName is not null) writer.WriteString(2740, LegFinancialInstrumentShortName);
			if (LegFinancialInstrumentFullName is not null) writer.WriteString(2717, LegFinancialInstrumentFullName);
			if (EncodedLegFinancialInstrumentFullNameLen is not null) writer.WriteWholeNumber(2718, EncodedLegFinancialInstrumentFullNameLen.Value);
			if (EncodedLegFinancialInstrumentFullName is not null) writer.WriteBuffer(2719, EncodedLegFinancialInstrumentFullName);
			if (LegSecurityDesc is not null) writer.WriteString(620, LegSecurityDesc);
			if (EncodedLegSecurityDescLen is not null) writer.WriteWholeNumber(621, EncodedLegSecurityDescLen.Value);
			if (EncodedLegSecurityDesc is not null) writer.WriteBuffer(622, EncodedLegSecurityDesc);
			if (LegSecurityXML is not null) ((IFixEncoder)LegSecurityXML).Encode(writer);
			if (LegCPProgram is not null) writer.WriteWholeNumber(2207, LegCPProgram.Value);
			if (LegCPRegType is not null) writer.WriteString(2208, LegCPRegType);
			if (LegRatioQty is not null) writer.WriteNumber(623, LegRatioQty.Value);
			if (LegSide is not null) writer.WriteString(624, LegSide);
			if (LegCurrency is not null) writer.WriteString(556, LegCurrency);
			if (LegCurrencyCodeSource is not null) writer.WriteString(2898, LegCurrencyCodeSource);
			if (LegPool is not null) writer.WriteString(740, LegPool);
			if (LegDatedDate is not null) writer.WriteLocalDateOnly(739, LegDatedDate.Value);
			if (LegContractSettlMonth is not null) writer.WriteMonthYear(955, LegContractSettlMonth.Value);
			if (LegInterestAccrualDate is not null) writer.WriteLocalDateOnly(956, LegInterestAccrualDate.Value);
			if (LegPutOrCall is not null) writer.WriteWholeNumber(1358, LegPutOrCall.Value);
			if (LegInTheMoneyCondition is not null) writer.WriteWholeNumber(2682, LegInTheMoneyCondition.Value);
			if (LegContraryInstructionEligibilityIndicator is not null) writer.WriteBoolean(2686, LegContraryInstructionEligibilityIndicator.Value);
			if (LegOptionRatio is not null) writer.WriteNumber(1017, LegOptionRatio.Value);
			if (LegPrice is not null) writer.WriteNumber(566, LegPrice.Value);
			if (LegEvntGrp is not null) ((IFixEncoder)LegEvntGrp).Encode(writer);
			if (LegInstrumentParties is not null) ((IFixEncoder)LegInstrumentParties).Encode(writer);
			if (LegShortSaleRestriction is not null) writer.WriteWholeNumber(2209, LegShortSaleRestriction.Value);
			if (LegComplexEvents is not null) ((IFixEncoder)LegComplexEvents).Encode(writer);
			if (LegStrategyType is not null) writer.WriteString(2211, LegStrategyType);
			if (LegCommonPricingIndicator is not null) writer.WriteBoolean(2212, LegCommonPricingIndicator.Value);
			if (LegSettlDisruptionProvision is not null) writer.WriteWholeNumber(2213, LegSettlDisruptionProvision.Value);
			if (LegDeliveryRouteOrCharter is not null) writer.WriteString(2754, LegDeliveryRouteOrCharter);
			if (LegInstrumentRoundingDirection is not null) writer.WriteString(2214, LegInstrumentRoundingDirection);
			if (LegInstrumentRoundingPrecision is not null) writer.WriteWholeNumber(2215, LegInstrumentRoundingPrecision.Value);
			if (LegDateAdjustment is not null) ((IFixEncoder)LegDateAdjustment).Encode(writer);
			if (LegPricingDateTime is not null) ((IFixEncoder)LegPricingDateTime).Encode(writer);
			if (LegMarketDisruption is not null) ((IFixEncoder)LegMarketDisruption).Encode(writer);
			if (LegOptionExercise is not null) ((IFixEncoder)LegOptionExercise).Encode(writer);
			if (LegStreamGrp is not null) ((IFixEncoder)LegStreamGrp).Encode(writer);
			if (LegProvisionGrp is not null) ((IFixEncoder)LegProvisionGrp).Encode(writer);
			if (LegAdditionalTermGrp is not null) ((IFixEncoder)LegAdditionalTermGrp).Encode(writer);
			if (LegProtectionTermGrp is not null) ((IFixEncoder)LegProtectionTermGrp).Encode(writer);
			if (LegCashSettlTermGrp is not null) ((IFixEncoder)LegCashSettlTermGrp).Encode(writer);
			if (LegPhysicalSettlTermGrp is not null) ((IFixEncoder)LegPhysicalSettlTermGrp).Encode(writer);
			if (LegExtraordinaryEventGrp is not null) ((IFixEncoder)LegExtraordinaryEventGrp).Encode(writer);
			if (LegExtraordinaryEventAdjustmentMethod is not null) writer.WriteWholeNumber(2606, LegExtraordinaryEventAdjustmentMethod.Value);
			if (LegExchangeLookAlike is not null) writer.WriteBoolean(2607, LegExchangeLookAlike.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegSymbol = view.GetString(600);
			LegSymbolSfx = view.GetString(601);
			LegSecurityID = view.GetString(602);
			LegSecurityIDSource = view.GetString(603);
			if (view.GetView("LegSecAltIDGrp") is IMessageView viewLegSecAltIDGrp)
			{
				LegSecAltIDGrp = new();
				((IFixParser)LegSecAltIDGrp).Parse(viewLegSecAltIDGrp);
			}
			LegID = view.GetString(1788);
			LegProduct = view.GetInt32(607);
			LegSecurityGroup = view.GetString(1594);
			LegCFICode = view.GetString(608);
			LegUPICode = view.GetString(2893);
			LegSecurityType = view.GetString(609);
			LegSecuritySubType = view.GetString(764);
			LegMaturityMonthYear = view.GetMonthYear(610);
			LegMaturityDate = view.GetDateOnly(611);
			LegMaturityTime = view.GetString(1212);
			LegSettleOnOpenFlag = view.GetString(2146);
			LegInstrmtAssignmentMethod = view.GetString(2147);
			LegSecurityStatus = view.GetString(2148);
			LegCouponPaymentDate = view.GetDateOnly(248);
			LegRestructuringType = view.GetString(2149);
			LegSeniority = view.GetString(2150);
			LegNotionalPercentageOutstanding = view.GetDouble(2151);
			LegOriginalNotionalPercentageOutstanding = view.GetDouble(2152);
			LegAttachmentPoint = view.GetDouble(2153);
			LegDetachmentPoint = view.GetDouble(2154);
			LegObligationType = view.GetString(2155);
			LegAssetGroup = view.GetInt32(2348);
			LegAssetClass = view.GetInt32(2067);
			LegAssetSubClass = view.GetInt32(2068);
			LegAssetType = view.GetString(2069);
			LegAssetSubType = view.GetString(2739);
			if (view.GetView("LegSecondaryAssetGrp") is IMessageView viewLegSecondaryAssetGrp)
			{
				LegSecondaryAssetGrp = new();
				((IFixParser)LegSecondaryAssetGrp).Parse(viewLegSecondaryAssetGrp);
			}
			if (view.GetView("LegAssetAttributeGrp") is IMessageView viewLegAssetAttributeGrp)
			{
				LegAssetAttributeGrp = new();
				((IFixParser)LegAssetAttributeGrp).Parse(viewLegAssetAttributeGrp);
			}
			LegSwapClass = view.GetString(2070);
			LegSwapSubClass = view.GetString(2156);
			LegNthToDefault = view.GetInt32(2157);
			LegMthToDefault = view.GetInt32(2158);
			LegSettledEntityMatrixSource = view.GetString(2159);
			LegSettledEntityMatrixPublicationDate = view.GetDateOnly(2160);
			LegCouponType = view.GetInt32(2161);
			LegTotalIssuedAmount = view.GetDouble(2162);
			LegCouponFrequencyPeriod = view.GetInt32(2163);
			LegCouponFrequencyUnit = view.GetString(2164);
			LegCouponDayCount = view.GetInt32(2165);
			LegCouponOtherDayCount = view.GetString(2880);
			LegConvertibleBondEquityID = view.GetString(2166);
			LegConvertibleBondEquityIDSource = view.GetString(2167);
			LegContractPriceRefMonth = view.GetMonthYear(2168);
			LegLienSeniority = view.GetInt32(2169);
			LegLoanFacility = view.GetInt32(2170);
			LegReferenceEntityType = view.GetInt32(2171);
			LegIndexSeries = view.GetInt32(2172);
			LegIndexAnnexVersion = view.GetInt32(2173);
			LegIndexAnnexDate = view.GetDateOnly(2174);
			LegIndexAnnexSource = view.GetString(2175);
			LegSettlRateIndex = view.GetString(2176);
			LegSettlRateIndexLocation = view.GetString(2177);
			LegOptionExpirationDesc = view.GetString(2178);
			EncodedLegOptionExpirationDescLen = view.GetInt32(2179);
			EncodedLegOptionExpirationDesc = view.GetByteArray(2180);
			LegIssueDate = view.GetDateOnly(249);
			LegRepoCollateralSecurityType = view.GetString(250);
			LegRepurchaseTerm = view.GetInt32(251);
			LegRepurchaseRate = view.GetDouble(252);
			LegFactor = view.GetDouble(253);
			LegCreditRating = view.GetString(257);
			LegInstrRegistry = view.GetString(599);
			LegCountryOfIssue = view.GetString(596);
			LegStateOrProvinceOfIssue = view.GetString(597);
			LegLocaleOfIssue = view.GetString(598);
			LegRedemptionDate = view.GetDateOnly(254);
			LegStrikePrice = view.GetDouble(612);
			LegStrikeCurrency = view.GetString(942);
			LegStrikeCurrencyCodeSource = view.GetString(2908);
			LegStrikeMultiplier = view.GetDouble(2181);
			LegStrikeValue = view.GetDouble(2182);
			LegStrikeUnitOfMeasure = view.GetString(2183);
			LegStrikeIndex = view.GetString(2184);
			LegStrikeIndexCurvePoint = view.GetString(2604);
			LegStrikeIndexSpread = view.GetDouble(2185);
			LegStrikeIndexQuote = view.GetInt32(2605);
			LegStrikePriceDeterminationMethod = view.GetInt32(2186);
			LegStrikePriceBoundaryMethod = view.GetInt32(2187);
			LegStrikePriceBoundaryPrecision = view.GetDouble(2188);
			LegUnderlyingPriceDeterminationMethod = view.GetInt32(2189);
			LegOptAttribute = view.GetString(613);
			LegContractMultiplier = view.GetDouble(614);
			LegContractMultiplierUnit = view.GetInt32(1436);
			LegTradingUnitPeriodMultiplier = view.GetInt32(2354);
			LegFlowScheduleType = view.GetInt32(1440);
			LegMinPriceIncrement = view.GetDouble(2190);
			LegMinPriceIncrementAmount = view.GetDouble(2191);
			LegUnitOfMeasure = view.GetString(999);
			LegUnitOfMeasureQty = view.GetDouble(1224);
			LegUnitOfMeasureCurrency = view.GetString(1720);
			LegUnitOfMeasureCurrencyCodeSource = view.GetString(2909);
			LegPriceUnitOfMeasure = view.GetString(1421);
			LegPriceUnitOfMeasureQty = view.GetDouble(1422);
			LegPriceUnitOfMeasureCurrency = view.GetString(1721);
			LegPriceUnitOfMeasureCurrencyCodeSource = view.GetString(2910);
			LegSettlMethod = view.GetString(2192);
			LegTimeUnit = view.GetString(1001);
			LegExerciseStyle = view.GetInt32(1420);
			LegOptPayoutType = view.GetInt32(2193);
			LegOptPayoutAmount = view.GetDouble(2194);
			LegReturnTrigger = view.GetInt32(2755);
			LegPriceQuoteMethod = view.GetString(2195);
			LegValuationMethod = view.GetString(2196);
			LegValuationSource = view.GetString(2197);
			LegValuationReferenceModel = view.GetString(2198);
			LegPriceQuoteCurrency = view.GetString(1528);
			LegPriceQuoteCurrencyCodeSource = view.GetString(2911);
			LegListMethod = view.GetInt32(2199);
			LegCapPrice = view.GetDouble(2200);
			LegFloorPrice = view.GetDouble(2201);
			LegFlexibleIndicator = view.GetBool(2202);
			LegFlexProductEligibilityIndicator = view.GetBool(2203);
			LegCouponRate = view.GetDouble(615);
			LegSecurityExchange = view.GetString(616);
			LegPositionLimit = view.GetInt32(2205);
			LegNTPositionLimit = view.GetInt32(2206);
			LegIssuer = view.GetString(617);
			EncodedLegIssuerLen = view.GetInt32(618);
			EncodedLegIssuer = view.GetByteArray(619);
			LegFinancialInstrumentShortName = view.GetString(2740);
			LegFinancialInstrumentFullName = view.GetString(2717);
			EncodedLegFinancialInstrumentFullNameLen = view.GetInt32(2718);
			EncodedLegFinancialInstrumentFullName = view.GetByteArray(2719);
			LegSecurityDesc = view.GetString(620);
			EncodedLegSecurityDescLen = view.GetInt32(621);
			EncodedLegSecurityDesc = view.GetByteArray(622);
			if (view.GetView("LegSecurityXML") is IMessageView viewLegSecurityXML)
			{
				LegSecurityXML = new();
				((IFixParser)LegSecurityXML).Parse(viewLegSecurityXML);
			}
			LegCPProgram = view.GetInt32(2207);
			LegCPRegType = view.GetString(2208);
			LegRatioQty = view.GetDouble(623);
			LegSide = view.GetString(624);
			LegCurrency = view.GetString(556);
			LegCurrencyCodeSource = view.GetString(2898);
			LegPool = view.GetString(740);
			LegDatedDate = view.GetDateOnly(739);
			LegContractSettlMonth = view.GetMonthYear(955);
			LegInterestAccrualDate = view.GetDateOnly(956);
			LegPutOrCall = view.GetInt32(1358);
			LegInTheMoneyCondition = view.GetInt32(2682);
			LegContraryInstructionEligibilityIndicator = view.GetBool(2686);
			LegOptionRatio = view.GetDouble(1017);
			LegPrice = view.GetDouble(566);
			if (view.GetView("LegEvntGrp") is IMessageView viewLegEvntGrp)
			{
				LegEvntGrp = new();
				((IFixParser)LegEvntGrp).Parse(viewLegEvntGrp);
			}
			if (view.GetView("LegInstrumentParties") is IMessageView viewLegInstrumentParties)
			{
				LegInstrumentParties = new();
				((IFixParser)LegInstrumentParties).Parse(viewLegInstrumentParties);
			}
			LegShortSaleRestriction = view.GetInt32(2209);
			if (view.GetView("LegComplexEvents") is IMessageView viewLegComplexEvents)
			{
				LegComplexEvents = new();
				((IFixParser)LegComplexEvents).Parse(viewLegComplexEvents);
			}
			LegStrategyType = view.GetString(2211);
			LegCommonPricingIndicator = view.GetBool(2212);
			LegSettlDisruptionProvision = view.GetInt32(2213);
			LegDeliveryRouteOrCharter = view.GetString(2754);
			LegInstrumentRoundingDirection = view.GetString(2214);
			LegInstrumentRoundingPrecision = view.GetInt32(2215);
			if (view.GetView("LegDateAdjustment") is IMessageView viewLegDateAdjustment)
			{
				LegDateAdjustment = new();
				((IFixParser)LegDateAdjustment).Parse(viewLegDateAdjustment);
			}
			if (view.GetView("LegPricingDateTime") is IMessageView viewLegPricingDateTime)
			{
				LegPricingDateTime = new();
				((IFixParser)LegPricingDateTime).Parse(viewLegPricingDateTime);
			}
			if (view.GetView("LegMarketDisruption") is IMessageView viewLegMarketDisruption)
			{
				LegMarketDisruption = new();
				((IFixParser)LegMarketDisruption).Parse(viewLegMarketDisruption);
			}
			if (view.GetView("LegOptionExercise") is IMessageView viewLegOptionExercise)
			{
				LegOptionExercise = new();
				((IFixParser)LegOptionExercise).Parse(viewLegOptionExercise);
			}
			if (view.GetView("LegStreamGrp") is IMessageView viewLegStreamGrp)
			{
				LegStreamGrp = new();
				((IFixParser)LegStreamGrp).Parse(viewLegStreamGrp);
			}
			if (view.GetView("LegProvisionGrp") is IMessageView viewLegProvisionGrp)
			{
				LegProvisionGrp = new();
				((IFixParser)LegProvisionGrp).Parse(viewLegProvisionGrp);
			}
			if (view.GetView("LegAdditionalTermGrp") is IMessageView viewLegAdditionalTermGrp)
			{
				LegAdditionalTermGrp = new();
				((IFixParser)LegAdditionalTermGrp).Parse(viewLegAdditionalTermGrp);
			}
			if (view.GetView("LegProtectionTermGrp") is IMessageView viewLegProtectionTermGrp)
			{
				LegProtectionTermGrp = new();
				((IFixParser)LegProtectionTermGrp).Parse(viewLegProtectionTermGrp);
			}
			if (view.GetView("LegCashSettlTermGrp") is IMessageView viewLegCashSettlTermGrp)
			{
				LegCashSettlTermGrp = new();
				((IFixParser)LegCashSettlTermGrp).Parse(viewLegCashSettlTermGrp);
			}
			if (view.GetView("LegPhysicalSettlTermGrp") is IMessageView viewLegPhysicalSettlTermGrp)
			{
				LegPhysicalSettlTermGrp = new();
				((IFixParser)LegPhysicalSettlTermGrp).Parse(viewLegPhysicalSettlTermGrp);
			}
			if (view.GetView("LegExtraordinaryEventGrp") is IMessageView viewLegExtraordinaryEventGrp)
			{
				LegExtraordinaryEventGrp = new();
				((IFixParser)LegExtraordinaryEventGrp).Parse(viewLegExtraordinaryEventGrp);
			}
			LegExtraordinaryEventAdjustmentMethod = view.GetInt32(2606);
			LegExchangeLookAlike = view.GetBool(2607);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegSymbol":
				{
					value = LegSymbol;
					break;
				}
				case "LegSymbolSfx":
				{
					value = LegSymbolSfx;
					break;
				}
				case "LegSecurityID":
				{
					value = LegSecurityID;
					break;
				}
				case "LegSecurityIDSource":
				{
					value = LegSecurityIDSource;
					break;
				}
				case "LegSecAltIDGrp":
				{
					value = LegSecAltIDGrp;
					break;
				}
				case "LegID":
				{
					value = LegID;
					break;
				}
				case "LegProduct":
				{
					value = LegProduct;
					break;
				}
				case "LegSecurityGroup":
				{
					value = LegSecurityGroup;
					break;
				}
				case "LegCFICode":
				{
					value = LegCFICode;
					break;
				}
				case "LegUPICode":
				{
					value = LegUPICode;
					break;
				}
				case "LegSecurityType":
				{
					value = LegSecurityType;
					break;
				}
				case "LegSecuritySubType":
				{
					value = LegSecuritySubType;
					break;
				}
				case "LegMaturityMonthYear":
				{
					value = LegMaturityMonthYear;
					break;
				}
				case "LegMaturityDate":
				{
					value = LegMaturityDate;
					break;
				}
				case "LegMaturityTime":
				{
					value = LegMaturityTime;
					break;
				}
				case "LegSettleOnOpenFlag":
				{
					value = LegSettleOnOpenFlag;
					break;
				}
				case "LegInstrmtAssignmentMethod":
				{
					value = LegInstrmtAssignmentMethod;
					break;
				}
				case "LegSecurityStatus":
				{
					value = LegSecurityStatus;
					break;
				}
				case "LegCouponPaymentDate":
				{
					value = LegCouponPaymentDate;
					break;
				}
				case "LegRestructuringType":
				{
					value = LegRestructuringType;
					break;
				}
				case "LegSeniority":
				{
					value = LegSeniority;
					break;
				}
				case "LegNotionalPercentageOutstanding":
				{
					value = LegNotionalPercentageOutstanding;
					break;
				}
				case "LegOriginalNotionalPercentageOutstanding":
				{
					value = LegOriginalNotionalPercentageOutstanding;
					break;
				}
				case "LegAttachmentPoint":
				{
					value = LegAttachmentPoint;
					break;
				}
				case "LegDetachmentPoint":
				{
					value = LegDetachmentPoint;
					break;
				}
				case "LegObligationType":
				{
					value = LegObligationType;
					break;
				}
				case "LegAssetGroup":
				{
					value = LegAssetGroup;
					break;
				}
				case "LegAssetClass":
				{
					value = LegAssetClass;
					break;
				}
				case "LegAssetSubClass":
				{
					value = LegAssetSubClass;
					break;
				}
				case "LegAssetType":
				{
					value = LegAssetType;
					break;
				}
				case "LegAssetSubType":
				{
					value = LegAssetSubType;
					break;
				}
				case "LegSecondaryAssetGrp":
				{
					value = LegSecondaryAssetGrp;
					break;
				}
				case "LegAssetAttributeGrp":
				{
					value = LegAssetAttributeGrp;
					break;
				}
				case "LegSwapClass":
				{
					value = LegSwapClass;
					break;
				}
				case "LegSwapSubClass":
				{
					value = LegSwapSubClass;
					break;
				}
				case "LegNthToDefault":
				{
					value = LegNthToDefault;
					break;
				}
				case "LegMthToDefault":
				{
					value = LegMthToDefault;
					break;
				}
				case "LegSettledEntityMatrixSource":
				{
					value = LegSettledEntityMatrixSource;
					break;
				}
				case "LegSettledEntityMatrixPublicationDate":
				{
					value = LegSettledEntityMatrixPublicationDate;
					break;
				}
				case "LegCouponType":
				{
					value = LegCouponType;
					break;
				}
				case "LegTotalIssuedAmount":
				{
					value = LegTotalIssuedAmount;
					break;
				}
				case "LegCouponFrequencyPeriod":
				{
					value = LegCouponFrequencyPeriod;
					break;
				}
				case "LegCouponFrequencyUnit":
				{
					value = LegCouponFrequencyUnit;
					break;
				}
				case "LegCouponDayCount":
				{
					value = LegCouponDayCount;
					break;
				}
				case "LegCouponOtherDayCount":
				{
					value = LegCouponOtherDayCount;
					break;
				}
				case "LegConvertibleBondEquityID":
				{
					value = LegConvertibleBondEquityID;
					break;
				}
				case "LegConvertibleBondEquityIDSource":
				{
					value = LegConvertibleBondEquityIDSource;
					break;
				}
				case "LegContractPriceRefMonth":
				{
					value = LegContractPriceRefMonth;
					break;
				}
				case "LegLienSeniority":
				{
					value = LegLienSeniority;
					break;
				}
				case "LegLoanFacility":
				{
					value = LegLoanFacility;
					break;
				}
				case "LegReferenceEntityType":
				{
					value = LegReferenceEntityType;
					break;
				}
				case "LegIndexSeries":
				{
					value = LegIndexSeries;
					break;
				}
				case "LegIndexAnnexVersion":
				{
					value = LegIndexAnnexVersion;
					break;
				}
				case "LegIndexAnnexDate":
				{
					value = LegIndexAnnexDate;
					break;
				}
				case "LegIndexAnnexSource":
				{
					value = LegIndexAnnexSource;
					break;
				}
				case "LegSettlRateIndex":
				{
					value = LegSettlRateIndex;
					break;
				}
				case "LegSettlRateIndexLocation":
				{
					value = LegSettlRateIndexLocation;
					break;
				}
				case "LegOptionExpirationDesc":
				{
					value = LegOptionExpirationDesc;
					break;
				}
				case "EncodedLegOptionExpirationDescLen":
				{
					value = EncodedLegOptionExpirationDescLen;
					break;
				}
				case "EncodedLegOptionExpirationDesc":
				{
					value = EncodedLegOptionExpirationDesc;
					break;
				}
				case "LegIssueDate":
				{
					value = LegIssueDate;
					break;
				}
				case "LegRepoCollateralSecurityType":
				{
					value = LegRepoCollateralSecurityType;
					break;
				}
				case "LegRepurchaseTerm":
				{
					value = LegRepurchaseTerm;
					break;
				}
				case "LegRepurchaseRate":
				{
					value = LegRepurchaseRate;
					break;
				}
				case "LegFactor":
				{
					value = LegFactor;
					break;
				}
				case "LegCreditRating":
				{
					value = LegCreditRating;
					break;
				}
				case "LegInstrRegistry":
				{
					value = LegInstrRegistry;
					break;
				}
				case "LegCountryOfIssue":
				{
					value = LegCountryOfIssue;
					break;
				}
				case "LegStateOrProvinceOfIssue":
				{
					value = LegStateOrProvinceOfIssue;
					break;
				}
				case "LegLocaleOfIssue":
				{
					value = LegLocaleOfIssue;
					break;
				}
				case "LegRedemptionDate":
				{
					value = LegRedemptionDate;
					break;
				}
				case "LegStrikePrice":
				{
					value = LegStrikePrice;
					break;
				}
				case "LegStrikeCurrency":
				{
					value = LegStrikeCurrency;
					break;
				}
				case "LegStrikeCurrencyCodeSource":
				{
					value = LegStrikeCurrencyCodeSource;
					break;
				}
				case "LegStrikeMultiplier":
				{
					value = LegStrikeMultiplier;
					break;
				}
				case "LegStrikeValue":
				{
					value = LegStrikeValue;
					break;
				}
				case "LegStrikeUnitOfMeasure":
				{
					value = LegStrikeUnitOfMeasure;
					break;
				}
				case "LegStrikeIndex":
				{
					value = LegStrikeIndex;
					break;
				}
				case "LegStrikeIndexCurvePoint":
				{
					value = LegStrikeIndexCurvePoint;
					break;
				}
				case "LegStrikeIndexSpread":
				{
					value = LegStrikeIndexSpread;
					break;
				}
				case "LegStrikeIndexQuote":
				{
					value = LegStrikeIndexQuote;
					break;
				}
				case "LegStrikePriceDeterminationMethod":
				{
					value = LegStrikePriceDeterminationMethod;
					break;
				}
				case "LegStrikePriceBoundaryMethod":
				{
					value = LegStrikePriceBoundaryMethod;
					break;
				}
				case "LegStrikePriceBoundaryPrecision":
				{
					value = LegStrikePriceBoundaryPrecision;
					break;
				}
				case "LegUnderlyingPriceDeterminationMethod":
				{
					value = LegUnderlyingPriceDeterminationMethod;
					break;
				}
				case "LegOptAttribute":
				{
					value = LegOptAttribute;
					break;
				}
				case "LegContractMultiplier":
				{
					value = LegContractMultiplier;
					break;
				}
				case "LegContractMultiplierUnit":
				{
					value = LegContractMultiplierUnit;
					break;
				}
				case "LegTradingUnitPeriodMultiplier":
				{
					value = LegTradingUnitPeriodMultiplier;
					break;
				}
				case "LegFlowScheduleType":
				{
					value = LegFlowScheduleType;
					break;
				}
				case "LegMinPriceIncrement":
				{
					value = LegMinPriceIncrement;
					break;
				}
				case "LegMinPriceIncrementAmount":
				{
					value = LegMinPriceIncrementAmount;
					break;
				}
				case "LegUnitOfMeasure":
				{
					value = LegUnitOfMeasure;
					break;
				}
				case "LegUnitOfMeasureQty":
				{
					value = LegUnitOfMeasureQty;
					break;
				}
				case "LegUnitOfMeasureCurrency":
				{
					value = LegUnitOfMeasureCurrency;
					break;
				}
				case "LegUnitOfMeasureCurrencyCodeSource":
				{
					value = LegUnitOfMeasureCurrencyCodeSource;
					break;
				}
				case "LegPriceUnitOfMeasure":
				{
					value = LegPriceUnitOfMeasure;
					break;
				}
				case "LegPriceUnitOfMeasureQty":
				{
					value = LegPriceUnitOfMeasureQty;
					break;
				}
				case "LegPriceUnitOfMeasureCurrency":
				{
					value = LegPriceUnitOfMeasureCurrency;
					break;
				}
				case "LegPriceUnitOfMeasureCurrencyCodeSource":
				{
					value = LegPriceUnitOfMeasureCurrencyCodeSource;
					break;
				}
				case "LegSettlMethod":
				{
					value = LegSettlMethod;
					break;
				}
				case "LegTimeUnit":
				{
					value = LegTimeUnit;
					break;
				}
				case "LegExerciseStyle":
				{
					value = LegExerciseStyle;
					break;
				}
				case "LegOptPayoutType":
				{
					value = LegOptPayoutType;
					break;
				}
				case "LegOptPayoutAmount":
				{
					value = LegOptPayoutAmount;
					break;
				}
				case "LegReturnTrigger":
				{
					value = LegReturnTrigger;
					break;
				}
				case "LegPriceQuoteMethod":
				{
					value = LegPriceQuoteMethod;
					break;
				}
				case "LegValuationMethod":
				{
					value = LegValuationMethod;
					break;
				}
				case "LegValuationSource":
				{
					value = LegValuationSource;
					break;
				}
				case "LegValuationReferenceModel":
				{
					value = LegValuationReferenceModel;
					break;
				}
				case "LegPriceQuoteCurrency":
				{
					value = LegPriceQuoteCurrency;
					break;
				}
				case "LegPriceQuoteCurrencyCodeSource":
				{
					value = LegPriceQuoteCurrencyCodeSource;
					break;
				}
				case "LegListMethod":
				{
					value = LegListMethod;
					break;
				}
				case "LegCapPrice":
				{
					value = LegCapPrice;
					break;
				}
				case "LegFloorPrice":
				{
					value = LegFloorPrice;
					break;
				}
				case "LegFlexibleIndicator":
				{
					value = LegFlexibleIndicator;
					break;
				}
				case "LegFlexProductEligibilityIndicator":
				{
					value = LegFlexProductEligibilityIndicator;
					break;
				}
				case "LegCouponRate":
				{
					value = LegCouponRate;
					break;
				}
				case "LegSecurityExchange":
				{
					value = LegSecurityExchange;
					break;
				}
				case "LegPositionLimit":
				{
					value = LegPositionLimit;
					break;
				}
				case "LegNTPositionLimit":
				{
					value = LegNTPositionLimit;
					break;
				}
				case "LegIssuer":
				{
					value = LegIssuer;
					break;
				}
				case "EncodedLegIssuerLen":
				{
					value = EncodedLegIssuerLen;
					break;
				}
				case "EncodedLegIssuer":
				{
					value = EncodedLegIssuer;
					break;
				}
				case "LegFinancialInstrumentShortName":
				{
					value = LegFinancialInstrumentShortName;
					break;
				}
				case "LegFinancialInstrumentFullName":
				{
					value = LegFinancialInstrumentFullName;
					break;
				}
				case "EncodedLegFinancialInstrumentFullNameLen":
				{
					value = EncodedLegFinancialInstrumentFullNameLen;
					break;
				}
				case "EncodedLegFinancialInstrumentFullName":
				{
					value = EncodedLegFinancialInstrumentFullName;
					break;
				}
				case "LegSecurityDesc":
				{
					value = LegSecurityDesc;
					break;
				}
				case "EncodedLegSecurityDescLen":
				{
					value = EncodedLegSecurityDescLen;
					break;
				}
				case "EncodedLegSecurityDesc":
				{
					value = EncodedLegSecurityDesc;
					break;
				}
				case "LegSecurityXML":
				{
					value = LegSecurityXML;
					break;
				}
				case "LegCPProgram":
				{
					value = LegCPProgram;
					break;
				}
				case "LegCPRegType":
				{
					value = LegCPRegType;
					break;
				}
				case "LegRatioQty":
				{
					value = LegRatioQty;
					break;
				}
				case "LegSide":
				{
					value = LegSide;
					break;
				}
				case "LegCurrency":
				{
					value = LegCurrency;
					break;
				}
				case "LegCurrencyCodeSource":
				{
					value = LegCurrencyCodeSource;
					break;
				}
				case "LegPool":
				{
					value = LegPool;
					break;
				}
				case "LegDatedDate":
				{
					value = LegDatedDate;
					break;
				}
				case "LegContractSettlMonth":
				{
					value = LegContractSettlMonth;
					break;
				}
				case "LegInterestAccrualDate":
				{
					value = LegInterestAccrualDate;
					break;
				}
				case "LegPutOrCall":
				{
					value = LegPutOrCall;
					break;
				}
				case "LegInTheMoneyCondition":
				{
					value = LegInTheMoneyCondition;
					break;
				}
				case "LegContraryInstructionEligibilityIndicator":
				{
					value = LegContraryInstructionEligibilityIndicator;
					break;
				}
				case "LegOptionRatio":
				{
					value = LegOptionRatio;
					break;
				}
				case "LegPrice":
				{
					value = LegPrice;
					break;
				}
				case "LegEvntGrp":
				{
					value = LegEvntGrp;
					break;
				}
				case "LegInstrumentParties":
				{
					value = LegInstrumentParties;
					break;
				}
				case "LegShortSaleRestriction":
				{
					value = LegShortSaleRestriction;
					break;
				}
				case "LegComplexEvents":
				{
					value = LegComplexEvents;
					break;
				}
				case "LegStrategyType":
				{
					value = LegStrategyType;
					break;
				}
				case "LegCommonPricingIndicator":
				{
					value = LegCommonPricingIndicator;
					break;
				}
				case "LegSettlDisruptionProvision":
				{
					value = LegSettlDisruptionProvision;
					break;
				}
				case "LegDeliveryRouteOrCharter":
				{
					value = LegDeliveryRouteOrCharter;
					break;
				}
				case "LegInstrumentRoundingDirection":
				{
					value = LegInstrumentRoundingDirection;
					break;
				}
				case "LegInstrumentRoundingPrecision":
				{
					value = LegInstrumentRoundingPrecision;
					break;
				}
				case "LegDateAdjustment":
				{
					value = LegDateAdjustment;
					break;
				}
				case "LegPricingDateTime":
				{
					value = LegPricingDateTime;
					break;
				}
				case "LegMarketDisruption":
				{
					value = LegMarketDisruption;
					break;
				}
				case "LegOptionExercise":
				{
					value = LegOptionExercise;
					break;
				}
				case "LegStreamGrp":
				{
					value = LegStreamGrp;
					break;
				}
				case "LegProvisionGrp":
				{
					value = LegProvisionGrp;
					break;
				}
				case "LegAdditionalTermGrp":
				{
					value = LegAdditionalTermGrp;
					break;
				}
				case "LegProtectionTermGrp":
				{
					value = LegProtectionTermGrp;
					break;
				}
				case "LegCashSettlTermGrp":
				{
					value = LegCashSettlTermGrp;
					break;
				}
				case "LegPhysicalSettlTermGrp":
				{
					value = LegPhysicalSettlTermGrp;
					break;
				}
				case "LegExtraordinaryEventGrp":
				{
					value = LegExtraordinaryEventGrp;
					break;
				}
				case "LegExtraordinaryEventAdjustmentMethod":
				{
					value = LegExtraordinaryEventAdjustmentMethod;
					break;
				}
				case "LegExchangeLookAlike":
				{
					value = LegExchangeLookAlike;
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
			LegSymbol = null;
			LegSymbolSfx = null;
			LegSecurityID = null;
			LegSecurityIDSource = null;
			((IFixReset?)LegSecAltIDGrp)?.Reset();
			LegID = null;
			LegProduct = null;
			LegSecurityGroup = null;
			LegCFICode = null;
			LegUPICode = null;
			LegSecurityType = null;
			LegSecuritySubType = null;
			LegMaturityMonthYear = null;
			LegMaturityDate = null;
			LegMaturityTime = null;
			LegSettleOnOpenFlag = null;
			LegInstrmtAssignmentMethod = null;
			LegSecurityStatus = null;
			LegCouponPaymentDate = null;
			LegRestructuringType = null;
			LegSeniority = null;
			LegNotionalPercentageOutstanding = null;
			LegOriginalNotionalPercentageOutstanding = null;
			LegAttachmentPoint = null;
			LegDetachmentPoint = null;
			LegObligationType = null;
			LegAssetGroup = null;
			LegAssetClass = null;
			LegAssetSubClass = null;
			LegAssetType = null;
			LegAssetSubType = null;
			((IFixReset?)LegSecondaryAssetGrp)?.Reset();
			((IFixReset?)LegAssetAttributeGrp)?.Reset();
			LegSwapClass = null;
			LegSwapSubClass = null;
			LegNthToDefault = null;
			LegMthToDefault = null;
			LegSettledEntityMatrixSource = null;
			LegSettledEntityMatrixPublicationDate = null;
			LegCouponType = null;
			LegTotalIssuedAmount = null;
			LegCouponFrequencyPeriod = null;
			LegCouponFrequencyUnit = null;
			LegCouponDayCount = null;
			LegCouponOtherDayCount = null;
			LegConvertibleBondEquityID = null;
			LegConvertibleBondEquityIDSource = null;
			LegContractPriceRefMonth = null;
			LegLienSeniority = null;
			LegLoanFacility = null;
			LegReferenceEntityType = null;
			LegIndexSeries = null;
			LegIndexAnnexVersion = null;
			LegIndexAnnexDate = null;
			LegIndexAnnexSource = null;
			LegSettlRateIndex = null;
			LegSettlRateIndexLocation = null;
			LegOptionExpirationDesc = null;
			EncodedLegOptionExpirationDescLen = null;
			EncodedLegOptionExpirationDesc = null;
			LegIssueDate = null;
			LegRepoCollateralSecurityType = null;
			LegRepurchaseTerm = null;
			LegRepurchaseRate = null;
			LegFactor = null;
			LegCreditRating = null;
			LegInstrRegistry = null;
			LegCountryOfIssue = null;
			LegStateOrProvinceOfIssue = null;
			LegLocaleOfIssue = null;
			LegRedemptionDate = null;
			LegStrikePrice = null;
			LegStrikeCurrency = null;
			LegStrikeCurrencyCodeSource = null;
			LegStrikeMultiplier = null;
			LegStrikeValue = null;
			LegStrikeUnitOfMeasure = null;
			LegStrikeIndex = null;
			LegStrikeIndexCurvePoint = null;
			LegStrikeIndexSpread = null;
			LegStrikeIndexQuote = null;
			LegStrikePriceDeterminationMethod = null;
			LegStrikePriceBoundaryMethod = null;
			LegStrikePriceBoundaryPrecision = null;
			LegUnderlyingPriceDeterminationMethod = null;
			LegOptAttribute = null;
			LegContractMultiplier = null;
			LegContractMultiplierUnit = null;
			LegTradingUnitPeriodMultiplier = null;
			LegFlowScheduleType = null;
			LegMinPriceIncrement = null;
			LegMinPriceIncrementAmount = null;
			LegUnitOfMeasure = null;
			LegUnitOfMeasureQty = null;
			LegUnitOfMeasureCurrency = null;
			LegUnitOfMeasureCurrencyCodeSource = null;
			LegPriceUnitOfMeasure = null;
			LegPriceUnitOfMeasureQty = null;
			LegPriceUnitOfMeasureCurrency = null;
			LegPriceUnitOfMeasureCurrencyCodeSource = null;
			LegSettlMethod = null;
			LegTimeUnit = null;
			LegExerciseStyle = null;
			LegOptPayoutType = null;
			LegOptPayoutAmount = null;
			LegReturnTrigger = null;
			LegPriceQuoteMethod = null;
			LegValuationMethod = null;
			LegValuationSource = null;
			LegValuationReferenceModel = null;
			LegPriceQuoteCurrency = null;
			LegPriceQuoteCurrencyCodeSource = null;
			LegListMethod = null;
			LegCapPrice = null;
			LegFloorPrice = null;
			LegFlexibleIndicator = null;
			LegFlexProductEligibilityIndicator = null;
			LegCouponRate = null;
			LegSecurityExchange = null;
			LegPositionLimit = null;
			LegNTPositionLimit = null;
			LegIssuer = null;
			EncodedLegIssuerLen = null;
			EncodedLegIssuer = null;
			LegFinancialInstrumentShortName = null;
			LegFinancialInstrumentFullName = null;
			EncodedLegFinancialInstrumentFullNameLen = null;
			EncodedLegFinancialInstrumentFullName = null;
			LegSecurityDesc = null;
			EncodedLegSecurityDescLen = null;
			EncodedLegSecurityDesc = null;
			((IFixReset?)LegSecurityXML)?.Reset();
			LegCPProgram = null;
			LegCPRegType = null;
			LegRatioQty = null;
			LegSide = null;
			LegCurrency = null;
			LegCurrencyCodeSource = null;
			LegPool = null;
			LegDatedDate = null;
			LegContractSettlMonth = null;
			LegInterestAccrualDate = null;
			LegPutOrCall = null;
			LegInTheMoneyCondition = null;
			LegContraryInstructionEligibilityIndicator = null;
			LegOptionRatio = null;
			LegPrice = null;
			((IFixReset?)LegEvntGrp)?.Reset();
			((IFixReset?)LegInstrumentParties)?.Reset();
			LegShortSaleRestriction = null;
			((IFixReset?)LegComplexEvents)?.Reset();
			LegStrategyType = null;
			LegCommonPricingIndicator = null;
			LegSettlDisruptionProvision = null;
			LegDeliveryRouteOrCharter = null;
			LegInstrumentRoundingDirection = null;
			LegInstrumentRoundingPrecision = null;
			((IFixReset?)LegDateAdjustment)?.Reset();
			((IFixReset?)LegPricingDateTime)?.Reset();
			((IFixReset?)LegMarketDisruption)?.Reset();
			((IFixReset?)LegOptionExercise)?.Reset();
			((IFixReset?)LegStreamGrp)?.Reset();
			((IFixReset?)LegProvisionGrp)?.Reset();
			((IFixReset?)LegAdditionalTermGrp)?.Reset();
			((IFixReset?)LegProtectionTermGrp)?.Reset();
			((IFixReset?)LegCashSettlTermGrp)?.Reset();
			((IFixReset?)LegPhysicalSettlTermGrp)?.Reset();
			((IFixReset?)LegExtraordinaryEventGrp)?.Reset();
			LegExtraordinaryEventAdjustmentMethod = null;
			LegExchangeLookAlike = null;
		}
	}
}
