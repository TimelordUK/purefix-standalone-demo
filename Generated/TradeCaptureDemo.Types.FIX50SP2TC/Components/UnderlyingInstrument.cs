using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingInstrument : IFixComponent
	{
		[TagDetails(Tag = 311, Type = TagType.String, Offset = 0, Required = false)]
		public string? UnderlyingSymbol {get; set;}
		
		[TagDetails(Tag = 312, Type = TagType.String, Offset = 1, Required = false)]
		public string? UnderlyingSymbolSfx {get; set;}
		
		[TagDetails(Tag = 309, Type = TagType.String, Offset = 2, Required = false)]
		public string? UnderlyingSecurityID {get; set;}
		
		[TagDetails(Tag = 305, Type = TagType.String, Offset = 3, Required = false)]
		public string? UnderlyingSecurityIDSource {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public UndSecAltIDGrp? UndSecAltIDGrp {get; set;}
		
		[TagDetails(Tag = 2874, Type = TagType.String, Offset = 5, Required = false)]
		public string? UnderlyingID {get; set;}
		
		[TagDetails(Tag = 462, Type = TagType.Int, Offset = 6, Required = false)]
		public int? UnderlyingProduct {get; set;}
		
		[Component(Offset = 7, Required = false)]
		public UnderlyingSecurityXML? UnderlyingSecurityXML {get; set;}
		
		[TagDetails(Tag = 463, Type = TagType.String, Offset = 8, Required = false)]
		public string? UnderlyingCFICode {get; set;}
		
		[TagDetails(Tag = 2894, Type = TagType.String, Offset = 9, Required = false)]
		public string? UnderlyingUPICode {get; set;}
		
		[TagDetails(Tag = 310, Type = TagType.String, Offset = 10, Required = false)]
		public string? UnderlyingSecurityType {get; set;}
		
		[TagDetails(Tag = 763, Type = TagType.String, Offset = 11, Required = false)]
		public string? UnderlyingSecuritySubType {get; set;}
		
		[TagDetails(Tag = 313, Type = TagType.MonthYear, Offset = 12, Required = false)]
		public MonthYear? UnderlyingMaturityMonthYear {get; set;}
		
		[TagDetails(Tag = 542, Type = TagType.LocalDate, Offset = 13, Required = false)]
		public DateOnly? UnderlyingMaturityDate {get; set;}
		
		[TagDetails(Tag = 1213, Type = TagType.String, Offset = 14, Required = false)]
		public string? UnderlyingMaturityTime {get; set;}
		
		[TagDetails(Tag = 1837, Type = TagType.MonthYear, Offset = 15, Required = false)]
		public MonthYear? UnderlyingContractPriceRefMonth {get; set;}
		
		[TagDetails(Tag = 241, Type = TagType.LocalDate, Offset = 16, Required = false)]
		public DateOnly? UnderlyingCouponPaymentDate {get; set;}
		
		[TagDetails(Tag = 1453, Type = TagType.String, Offset = 17, Required = false)]
		public string? UnderlyingRestructuringType {get; set;}
		
		[TagDetails(Tag = 1454, Type = TagType.String, Offset = 18, Required = false)]
		public string? UnderlyingSeniority {get; set;}
		
		[TagDetails(Tag = 2614, Type = TagType.Float, Offset = 19, Required = false)]
		public double? UnderlyingNotional {get; set;}
		
		[TagDetails(Tag = 2615, Type = TagType.String, Offset = 20, Required = false)]
		public string? UnderlyingNotionalCurrency {get; set;}
		
		[TagDetails(Tag = 2921, Type = TagType.String, Offset = 21, Required = false)]
		public string? UnderlyingNotionalCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 2616, Type = TagType.String, Offset = 22, Required = false)]
		public string? UnderlyingNotionalDeterminationMethod {get; set;}
		
		[TagDetails(Tag = 2617, Type = TagType.Int, Offset = 23, Required = false)]
		public int? UnderlyingNotionalAdjustments {get; set;}
		
		[TagDetails(Tag = 2619, Type = TagType.String, Offset = 24, Required = false)]
		public string? UnderlyingNotionalXIDRef {get; set;}
		
		[TagDetails(Tag = 1455, Type = TagType.Float, Offset = 25, Required = false)]
		public double? UnderlyingNotionalPercentageOutstanding {get; set;}
		
		[TagDetails(Tag = 1456, Type = TagType.Float, Offset = 26, Required = false)]
		public double? UnderlyingOriginalNotionalPercentageOutstanding {get; set;}
		
		[TagDetails(Tag = 1459, Type = TagType.Float, Offset = 27, Required = false)]
		public double? UnderlyingAttachmentPoint {get; set;}
		
		[TagDetails(Tag = 1460, Type = TagType.Float, Offset = 28, Required = false)]
		public double? UnderlyingDetachmentPoint {get; set;}
		
		[TagDetails(Tag = 242, Type = TagType.LocalDate, Offset = 29, Required = false)]
		public DateOnly? UnderlyingIssueDate {get; set;}
		
		[TagDetails(Tag = 243, Type = TagType.String, Offset = 30, Required = false)]
		public string? UnderlyingRepoCollateralSecurityType {get; set;}
		
		[TagDetails(Tag = 244, Type = TagType.Int, Offset = 31, Required = false)]
		public int? UnderlyingRepurchaseTerm {get; set;}
		
		[TagDetails(Tag = 245, Type = TagType.Float, Offset = 32, Required = false)]
		public double? UnderlyingRepurchaseRate {get; set;}
		
		[TagDetails(Tag = 246, Type = TagType.Float, Offset = 33, Required = false)]
		public double? UnderlyingFactor {get; set;}
		
		[TagDetails(Tag = 256, Type = TagType.String, Offset = 34, Required = false)]
		public string? UnderlyingCreditRating {get; set;}
		
		[TagDetails(Tag = 595, Type = TagType.String, Offset = 35, Required = false)]
		public string? UnderlyingInstrRegistry {get; set;}
		
		[TagDetails(Tag = 592, Type = TagType.String, Offset = 36, Required = false)]
		public string? UnderlyingCountryOfIssue {get; set;}
		
		[TagDetails(Tag = 593, Type = TagType.String, Offset = 37, Required = false)]
		public string? UnderlyingStateOrProvinceOfIssue {get; set;}
		
		[TagDetails(Tag = 594, Type = TagType.String, Offset = 38, Required = false)]
		public string? UnderlyingLocaleOfIssue {get; set;}
		
		[TagDetails(Tag = 247, Type = TagType.LocalDate, Offset = 39, Required = false)]
		public DateOnly? UnderlyingRedemptionDate {get; set;}
		
		[TagDetails(Tag = 316, Type = TagType.Float, Offset = 40, Required = false)]
		public double? UnderlyingStrikePrice {get; set;}
		
		[TagDetails(Tag = 941, Type = TagType.String, Offset = 41, Required = false)]
		public string? UnderlyingStrikeCurrency {get; set;}
		
		[TagDetails(Tag = 2917, Type = TagType.String, Offset = 42, Required = false)]
		public string? UnderlyingStrikeCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 317, Type = TagType.String, Offset = 43, Required = false)]
		public string? UnderlyingOptAttribute {get; set;}
		
		[TagDetails(Tag = 436, Type = TagType.Float, Offset = 44, Required = false)]
		public double? UnderlyingContractMultiplier {get; set;}
		
		[TagDetails(Tag = 1437, Type = TagType.Int, Offset = 45, Required = false)]
		public int? UnderlyingContractMultiplierUnit {get; set;}
		
		[TagDetails(Tag = 2363, Type = TagType.Int, Offset = 46, Required = false)]
		public int? UnderlyingTradingUnitPeriodMultiplier {get; set;}
		
		[TagDetails(Tag = 1441, Type = TagType.Int, Offset = 47, Required = false)]
		public int? UnderlyingFlowScheduleType {get; set;}
		
		[TagDetails(Tag = 998, Type = TagType.String, Offset = 48, Required = false)]
		public string? UnderlyingUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 1423, Type = TagType.Float, Offset = 49, Required = false)]
		public double? UnderlyingUnitOfMeasureQty {get; set;}
		
		[TagDetails(Tag = 1718, Type = TagType.String, Offset = 50, Required = false)]
		public string? UnderlyingUnitOfMeasureCurrency {get; set;}
		
		[TagDetails(Tag = 2918, Type = TagType.String, Offset = 51, Required = false)]
		public string? UnderlyingUnitOfMeasureCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 1424, Type = TagType.String, Offset = 52, Required = false)]
		public string? UnderlyingPriceUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 1425, Type = TagType.Float, Offset = 53, Required = false)]
		public double? UnderlyingPriceUnitOfMeasureQty {get; set;}
		
		[TagDetails(Tag = 1719, Type = TagType.String, Offset = 54, Required = false)]
		public string? UnderlyingPriceUnitOfMeasureCurrency {get; set;}
		
		[TagDetails(Tag = 2919, Type = TagType.String, Offset = 55, Required = false)]
		public string? UnderlyingPriceUnitOfMeasureCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 1000, Type = TagType.String, Offset = 56, Required = false)]
		public string? UnderlyingTimeUnit {get; set;}
		
		[TagDetails(Tag = 1419, Type = TagType.Int, Offset = 57, Required = false)]
		public int? UnderlyingExerciseStyle {get; set;}
		
		[TagDetails(Tag = 1526, Type = TagType.String, Offset = 58, Required = false)]
		public string? UnderlyingPriceQuoteCurrency {get; set;}
		
		[TagDetails(Tag = 2920, Type = TagType.String, Offset = 59, Required = false)]
		public string? UnderlyingPriceQuoteCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 435, Type = TagType.Float, Offset = 60, Required = false)]
		public double? UnderlyingCouponRate {get; set;}
		
		[TagDetails(Tag = 308, Type = TagType.String, Offset = 61, Required = false)]
		public string? UnderlyingSecurityExchange {get; set;}
		
		[TagDetails(Tag = 306, Type = TagType.String, Offset = 62, Required = false)]
		public string? UnderlyingIssuer {get; set;}
		
		[TagDetails(Tag = 362, Type = TagType.Length, Offset = 63, Required = false)]
		public int? EncodedUnderlyingIssuerLen {get; set;}
		
		[TagDetails(Tag = 363, Type = TagType.RawData, Offset = 64, Required = false)]
		public byte[]? EncodedUnderlyingIssuer {get; set;}
		
		[TagDetails(Tag = 2742, Type = TagType.String, Offset = 65, Required = false)]
		public string? UnderlyingFinancialInstrumentShortName {get; set;}
		
		[TagDetails(Tag = 2720, Type = TagType.String, Offset = 66, Required = false)]
		public string? UnderlyingFinancialInstrumentFullName {get; set;}
		
		[TagDetails(Tag = 2721, Type = TagType.Length, Offset = 67, Required = false)]
		public int? EncodedUnderlyingFinancialInstrumentFullNameLen {get; set;}
		
		[TagDetails(Tag = 2722, Type = TagType.RawData, Offset = 68, Required = false)]
		public byte[]? EncodedUnderlyingFinancialInstrumentFullName {get; set;}
		
		[TagDetails(Tag = 2723, Type = TagType.String, Offset = 69, Required = false)]
		public string? UnderlyingIndexCurveUnit {get; set;}
		
		[TagDetails(Tag = 2724, Type = TagType.Int, Offset = 70, Required = false)]
		public int? UnderlyingIndexCurvePeriod {get; set;}
		
		[TagDetails(Tag = 307, Type = TagType.String, Offset = 71, Required = false)]
		public string? UnderlyingSecurityDesc {get; set;}
		
		[TagDetails(Tag = 364, Type = TagType.Length, Offset = 72, Required = false)]
		public int? EncodedUnderlyingSecurityDescLen {get; set;}
		
		[TagDetails(Tag = 365, Type = TagType.RawData, Offset = 73, Required = false)]
		public byte[]? EncodedUnderlyingSecurityDesc {get; set;}
		
		[TagDetails(Tag = 877, Type = TagType.Int, Offset = 74, Required = false)]
		public int? UnderlyingCPProgram {get; set;}
		
		[TagDetails(Tag = 878, Type = TagType.String, Offset = 75, Required = false)]
		public string? UnderlyingCPRegType {get; set;}
		
		[TagDetails(Tag = 972, Type = TagType.Float, Offset = 76, Required = false)]
		public double? UnderlyingAllocationPercent {get; set;}
		
		[TagDetails(Tag = 318, Type = TagType.String, Offset = 77, Required = false)]
		public string? UnderlyingCurrency {get; set;}
		
		[TagDetails(Tag = 2916, Type = TagType.String, Offset = 78, Required = false)]
		public string? UnderlyingCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 879, Type = TagType.Float, Offset = 79, Required = false)]
		public double? UnderlyingQty {get; set;}
		
		[TagDetails(Tag = 975, Type = TagType.Int, Offset = 80, Required = false)]
		public int? UnderlyingSettlementType {get; set;}
		
		[TagDetails(Tag = 973, Type = TagType.Float, Offset = 81, Required = false)]
		public double? UnderlyingCashAmount {get; set;}
		
		[TagDetails(Tag = 974, Type = TagType.String, Offset = 82, Required = false)]
		public string? UnderlyingCashType {get; set;}
		
		[TagDetails(Tag = 810, Type = TagType.Float, Offset = 83, Required = false)]
		public double? UnderlyingPx {get; set;}
		
		[TagDetails(Tag = 882, Type = TagType.Float, Offset = 84, Required = false)]
		public double? UnderlyingDirtyPrice {get; set;}
		
		[TagDetails(Tag = 883, Type = TagType.Float, Offset = 85, Required = false)]
		public double? UnderlyingEndPrice {get; set;}
		
		[TagDetails(Tag = 884, Type = TagType.Float, Offset = 86, Required = false)]
		public double? UnderlyingStartValue {get; set;}
		
		[TagDetails(Tag = 885, Type = TagType.Float, Offset = 87, Required = false)]
		public double? UnderlyingCurrentValue {get; set;}
		
		[TagDetails(Tag = 886, Type = TagType.Float, Offset = 88, Required = false)]
		public double? UnderlyingEndValue {get; set;}
		
		[TagDetails(Tag = 2885, Type = TagType.Float, Offset = 89, Required = false)]
		public double? UnderlyingAccruedInterestAmt {get; set;}
		
		[TagDetails(Tag = 2886, Type = TagType.Int, Offset = 90, Required = false)]
		public int? UnderlyingNumDaysInterest {get; set;}
		
		[Component(Offset = 91, Required = false)]
		public UnderlyingStipulations? UnderlyingStipulations {get; set;}
		
		[TagDetails(Tag = 1044, Type = TagType.Float, Offset = 92, Required = false)]
		public double? UnderlyingAdjustedQuantity {get; set;}
		
		[TagDetails(Tag = 1045, Type = TagType.Float, Offset = 93, Required = false)]
		public double? UnderlyingFXRate {get; set;}
		
		[TagDetails(Tag = 1046, Type = TagType.String, Offset = 94, Required = false)]
		public string? UnderlyingFXRateCalc {get; set;}
		
		[TagDetails(Tag = 1038, Type = TagType.Float, Offset = 95, Required = false)]
		public double? UnderlyingCapValue {get; set;}
		
		[Component(Offset = 96, Required = false)]
		public UndlyInstrumentParties? UndlyInstrumentParties {get; set;}
		
		[TagDetails(Tag = 1039, Type = TagType.String, Offset = 97, Required = false)]
		public string? UnderlyingSettlMethod {get; set;}
		
		[TagDetails(Tag = 315, Type = TagType.Int, Offset = 98, Required = false)]
		public int? UnderlyingPutOrCall {get; set;}
		
		[TagDetails(Tag = 2683, Type = TagType.Int, Offset = 99, Required = false)]
		public int? UnderlyingInTheMoneyCondition {get; set;}
		
		[TagDetails(Tag = 2687, Type = TagType.Boolean, Offset = 100, Required = false)]
		public bool? UnderlyingContraryInstructionEligibilityIndicator {get; set;}
		
		[TagDetails(Tag = 1988, Type = TagType.Float, Offset = 101, Required = false)]
		public double? UnderlyingConstituentWeight {get; set;}
		
		[TagDetails(Tag = 1989, Type = TagType.Int, Offset = 102, Required = false)]
		public int? UnderlyingCouponType {get; set;}
		
		[TagDetails(Tag = 1990, Type = TagType.Float, Offset = 103, Required = false)]
		public double? UnderlyingTotalIssuedAmount {get; set;}
		
		[TagDetails(Tag = 1991, Type = TagType.Int, Offset = 104, Required = false)]
		public int? UnderlyingCouponFrequencyPeriod {get; set;}
		
		[TagDetails(Tag = 1992, Type = TagType.String, Offset = 105, Required = false)]
		public string? UnderlyingCouponFrequencyUnit {get; set;}
		
		[TagDetails(Tag = 1993, Type = TagType.Int, Offset = 106, Required = false)]
		public int? UnderlyingCouponDayCount {get; set;}
		
		[TagDetails(Tag = 2881, Type = TagType.String, Offset = 107, Required = false)]
		public string? UnderlyingCouponOtherDayCount {get; set;}
		
		[TagDetails(Tag = 1994, Type = TagType.String, Offset = 108, Required = false)]
		public string? UnderlyingObligationID {get; set;}
		
		[TagDetails(Tag = 1995, Type = TagType.String, Offset = 109, Required = false)]
		public string? UnderlyingObligationIDSource {get; set;}
		
		[TagDetails(Tag = 1996, Type = TagType.String, Offset = 110, Required = false)]
		public string? UnderlyingEquityID {get; set;}
		
		[TagDetails(Tag = 1997, Type = TagType.String, Offset = 111, Required = false)]
		public string? UnderlyingEquityIDSource {get; set;}
		
		[TagDetails(Tag = 2620, Type = TagType.String, Offset = 112, Required = false)]
		public string? UnderlyingFutureID {get; set;}
		
		[TagDetails(Tag = 2621, Type = TagType.String, Offset = 113, Required = false)]
		public string? UnderlyingFutureIDSource {get; set;}
		
		[Component(Offset = 114, Required = false)]
		public UnderlyingEvntGrp? UnderlyingEvntGrp {get; set;}
		
		[TagDetails(Tag = 1998, Type = TagType.Int, Offset = 115, Required = false)]
		public int? UnderlyingLienSeniority {get; set;}
		
		[TagDetails(Tag = 1999, Type = TagType.Int, Offset = 116, Required = false)]
		public int? UnderlyingLoanFacility {get; set;}
		
		[TagDetails(Tag = 2000, Type = TagType.Int, Offset = 117, Required = false)]
		public int? UnderlyingReferenceEntityType {get; set;}
		
		[TagDetails(Tag = 2003, Type = TagType.Int, Offset = 118, Required = false)]
		public int? UnderlyingIndexSeries {get; set;}
		
		[TagDetails(Tag = 2004, Type = TagType.Int, Offset = 119, Required = false)]
		public int? UnderlyingIndexAnnexVersion {get; set;}
		
		[TagDetails(Tag = 2005, Type = TagType.LocalDate, Offset = 120, Required = false)]
		public DateOnly? UnderlyingIndexAnnexDate {get; set;}
		
		[TagDetails(Tag = 2006, Type = TagType.String, Offset = 121, Required = false)]
		public string? UnderlyingIndexAnnexSource {get; set;}
		
		[TagDetails(Tag = 2284, Type = TagType.String, Offset = 122, Required = false)]
		public string? UnderlyingSettlRateIndex {get; set;}
		
		[TagDetails(Tag = 2285, Type = TagType.String, Offset = 123, Required = false)]
		public string? UnderlyingSettlRateIndexLocation {get; set;}
		
		[TagDetails(Tag = 2286, Type = TagType.String, Offset = 124, Required = false)]
		public string? UnderlyingOptionExpirationDesc {get; set;}
		
		[TagDetails(Tag = 2287, Type = TagType.Length, Offset = 125, Required = false)]
		public int? EncodedUnderlyingOptionExpirationDescLen {get; set;}
		
		[TagDetails(Tag = 2288, Type = TagType.RawData, Offset = 126, Required = false)]
		public byte[]? EncodedUnderlyingOptionExpirationDesc {get; set;}
		
		[TagDetails(Tag = 2007, Type = TagType.String, Offset = 127, Required = false)]
		public string? UnderlyingProductComplex {get; set;}
		
		[TagDetails(Tag = 2008, Type = TagType.String, Offset = 128, Required = false)]
		public string? UnderlyingSecurityGroup {get; set;}
		
		[TagDetails(Tag = 2009, Type = TagType.String, Offset = 129, Required = false)]
		public string? UnderlyingSettleOnOpenFlag {get; set;}
		
		[TagDetails(Tag = 2010, Type = TagType.String, Offset = 130, Required = false)]
		public string? UnderlyingAssignmentMethod {get; set;}
		
		[TagDetails(Tag = 2011, Type = TagType.String, Offset = 131, Required = false)]
		public string? UnderlyingSecurityStatus {get; set;}
		
		[TagDetails(Tag = 2012, Type = TagType.String, Offset = 132, Required = false)]
		public string? UnderlyingObligationType {get; set;}
		
		[TagDetails(Tag = 2491, Type = TagType.Int, Offset = 133, Required = false)]
		public int? UnderlyingAssetGroup {get; set;}
		
		[TagDetails(Tag = 2013, Type = TagType.Int, Offset = 134, Required = false)]
		public int? UnderlyingAssetClass {get; set;}
		
		[TagDetails(Tag = 2014, Type = TagType.Int, Offset = 135, Required = false)]
		public int? UnderlyingAssetSubClass {get; set;}
		
		[TagDetails(Tag = 2015, Type = TagType.String, Offset = 136, Required = false)]
		public string? UnderlyingAssetType {get; set;}
		
		[TagDetails(Tag = 2744, Type = TagType.String, Offset = 137, Required = false)]
		public string? UnderlyingAssetSubType {get; set;}
		
		[Component(Offset = 138, Required = false)]
		public UnderlyingSecondaryAssetGrp? UnderlyingSecondaryAssetGrp {get; set;}
		
		[Component(Offset = 139, Required = false)]
		public UnderlyingAssetAttributeGrp? UnderlyingAssetAttributeGrp {get; set;}
		
		[TagDetails(Tag = 2016, Type = TagType.String, Offset = 140, Required = false)]
		public string? UnderlyingSwapClass {get; set;}
		
		[TagDetails(Tag = 2289, Type = TagType.String, Offset = 141, Required = false)]
		public string? UnderlyingSwapSubClass {get; set;}
		
		[TagDetails(Tag = 2017, Type = TagType.Int, Offset = 142, Required = false)]
		public int? UnderlyingNthToDefault {get; set;}
		
		[TagDetails(Tag = 2018, Type = TagType.Int, Offset = 143, Required = false)]
		public int? UnderlyingMthToDefault {get; set;}
		
		[TagDetails(Tag = 2019, Type = TagType.String, Offset = 144, Required = false)]
		public string? UnderlyingSettledEntityMatrixSource {get; set;}
		
		[TagDetails(Tag = 2020, Type = TagType.LocalDate, Offset = 145, Required = false)]
		public DateOnly? UnderlyingSettledEntityMatrixPublicationDate {get; set;}
		
		[TagDetails(Tag = 2021, Type = TagType.Float, Offset = 146, Required = false)]
		public double? UnderlyingStrikeMultiplier {get; set;}
		
		[TagDetails(Tag = 2022, Type = TagType.Float, Offset = 147, Required = false)]
		public double? UnderlyingStrikeValue {get; set;}
		
		[TagDetails(Tag = 2290, Type = TagType.String, Offset = 148, Required = false)]
		public string? UnderlyingStrikeUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 2622, Type = TagType.String, Offset = 149, Required = false)]
		public string? UnderlyingStrikeIndexCurvePoint {get; set;}
		
		[TagDetails(Tag = 2291, Type = TagType.String, Offset = 150, Required = false)]
		public string? UnderlyingStrikeIndex {get; set;}
		
		[TagDetails(Tag = 2623, Type = TagType.Int, Offset = 151, Required = false)]
		public int? UnderlyingStrikeIndexQuote {get; set;}
		
		[TagDetails(Tag = 2292, Type = TagType.Float, Offset = 152, Required = false)]
		public double? UnderlyingStrikeIndexSpread {get; set;}
		
		[TagDetails(Tag = 2023, Type = TagType.Int, Offset = 153, Required = false)]
		public int? UnderlyingStrikePriceDeterminationMethod {get; set;}
		
		[TagDetails(Tag = 2024, Type = TagType.Int, Offset = 154, Required = false)]
		public int? UnderlyingStrikePriceBoundaryMethod {get; set;}
		
		[TagDetails(Tag = 2025, Type = TagType.Float, Offset = 155, Required = false)]
		public double? UnderlyingStrikePriceBoundaryPrecision {get; set;}
		
		[TagDetails(Tag = 2026, Type = TagType.Float, Offset = 156, Required = false)]
		public double? UnderlyingMinPriceIncrement {get; set;}
		
		[TagDetails(Tag = 2027, Type = TagType.Float, Offset = 157, Required = false)]
		public double? UnderlyingMinPriceIncrementAmount {get; set;}
		
		[TagDetails(Tag = 2028, Type = TagType.Int, Offset = 158, Required = false)]
		public int? UnderlyingOptPayoutType {get; set;}
		
		[TagDetails(Tag = 2029, Type = TagType.Float, Offset = 159, Required = false)]
		public double? UnderlyingOptPayoutAmount {get; set;}
		
		[TagDetails(Tag = 2757, Type = TagType.Int, Offset = 160, Required = false)]
		public int? UnderlyingReturnTrigger {get; set;}
		
		[TagDetails(Tag = 2030, Type = TagType.String, Offset = 161, Required = false)]
		public string? UnderlyingPriceQuoteMethod {get; set;}
		
		[TagDetails(Tag = 2031, Type = TagType.String, Offset = 162, Required = false)]
		public string? UnderlyingValuationMethod {get; set;}
		
		[TagDetails(Tag = 2293, Type = TagType.String, Offset = 163, Required = false)]
		public string? UnderlyingValuationSource {get; set;}
		
		[TagDetails(Tag = 2294, Type = TagType.String, Offset = 164, Required = false)]
		public string? UnderlyingValuationReferenceModel {get; set;}
		
		[TagDetails(Tag = 2032, Type = TagType.Int, Offset = 165, Required = false)]
		public int? UnderlyingListMethod {get; set;}
		
		[TagDetails(Tag = 2033, Type = TagType.Float, Offset = 166, Required = false)]
		public double? UnderlyingCapPrice {get; set;}
		
		[TagDetails(Tag = 2034, Type = TagType.Float, Offset = 167, Required = false)]
		public double? UnderlyingFloorPrice {get; set;}
		
		[TagDetails(Tag = 2035, Type = TagType.Boolean, Offset = 168, Required = false)]
		public bool? UnderlyingFlexibleIndicator {get; set;}
		
		[TagDetails(Tag = 2036, Type = TagType.Boolean, Offset = 169, Required = false)]
		public bool? UnderlyingFlexProductEligibilityIndicator {get; set;}
		
		[TagDetails(Tag = 2037, Type = TagType.Int, Offset = 170, Required = false)]
		public int? UnderlyingPositionLimit {get; set;}
		
		[TagDetails(Tag = 2038, Type = TagType.Int, Offset = 171, Required = false)]
		public int? UnderlyingNTPositionLimit {get; set;}
		
		[TagDetails(Tag = 2039, Type = TagType.String, Offset = 172, Required = false)]
		public string? UnderlyingPool {get; set;}
		
		[TagDetails(Tag = 2040, Type = TagType.MonthYear, Offset = 173, Required = false)]
		public MonthYear? UnderlyingContractSettlMonth {get; set;}
		
		[TagDetails(Tag = 2041, Type = TagType.LocalDate, Offset = 174, Required = false)]
		public DateOnly? UnderlyingDatedDate {get; set;}
		
		[TagDetails(Tag = 2042, Type = TagType.LocalDate, Offset = 175, Required = false)]
		public DateOnly? UnderlyingInterestAccrualDate {get; set;}
		
		[TagDetails(Tag = 2043, Type = TagType.Int, Offset = 176, Required = false)]
		public int? UnderlyingShortSaleRestriction {get; set;}
		
		[TagDetails(Tag = 2044, Type = TagType.Int, Offset = 177, Required = false)]
		public int? UnderlyingRefTickTableID {get; set;}
		
		[TagDetails(Tag = 41314, Type = TagType.String, Offset = 178, Required = false)]
		public string? UnderlyingProtectionTermXIDRef {get; set;}
		
		[TagDetails(Tag = 41315, Type = TagType.String, Offset = 179, Required = false)]
		public string? UnderlyingSettlTermXIDRef {get; set;}
		
		[Component(Offset = 180, Required = false)]
		public UnderlyingComplexEvents? UnderlyingComplexEvents {get; set;}
		
		[TagDetails(Tag = 2295, Type = TagType.String, Offset = 181, Required = false)]
		public string? UnderlyingStrategyType {get; set;}
		
		[TagDetails(Tag = 2296, Type = TagType.Boolean, Offset = 182, Required = false)]
		public bool? UnderlyingCommonPricingIndicator {get; set;}
		
		[TagDetails(Tag = 2297, Type = TagType.Int, Offset = 183, Required = false)]
		public int? UnderlyingSettlDisruptionProvision {get; set;}
		
		[TagDetails(Tag = 2756, Type = TagType.String, Offset = 184, Required = false)]
		public string? UnderlyingDeliveryRouteOrCharter {get; set;}
		
		[TagDetails(Tag = 2298, Type = TagType.String, Offset = 185, Required = false)]
		public string? UnderlyingInstrumentRoundingDirection {get; set;}
		
		[TagDetails(Tag = 2299, Type = TagType.Int, Offset = 186, Required = false)]
		public int? UnderlyingInstrumentRoundingPrecision {get; set;}
		
		[Component(Offset = 187, Required = false)]
		public UnderlyingDateAdjustment? UnderlyingDateAdjustment {get; set;}
		
		[Component(Offset = 188, Required = false)]
		public UnderlyingPricingDateTime? UnderlyingPricingDateTime {get; set;}
		
		[Component(Offset = 189, Required = false)]
		public UnderlyingMarketDisruption? UnderlyingMarketDisruption {get; set;}
		
		[Component(Offset = 190, Required = false)]
		public UnderlyingOptionExercise? UnderlyingOptionExercise {get; set;}
		
		[Component(Offset = 191, Required = false)]
		public UnderlyingStreamGrp? UnderlyingStreamGrp {get; set;}
		
		[Component(Offset = 192, Required = false)]
		public UnderlyingProvisionGrp? UnderlyingProvisionGrp {get; set;}
		
		[Component(Offset = 193, Required = false)]
		public UnderlyingAdditionalTermGrp? UnderlyingAdditionalTermGrp {get; set;}
		
		[Component(Offset = 194, Required = false)]
		public UnderlyingProtectionTermGrp? UnderlyingProtectionTermGrp {get; set;}
		
		[Component(Offset = 195, Required = false)]
		public UnderlyingCashSettlTermGrp? UnderlyingCashSettlTermGrp {get; set;}
		
		[Component(Offset = 196, Required = false)]
		public UnderlyingPhysicalSettlTermGrp? UnderlyingPhysicalSettlTermGrp {get; set;}
		
		[Component(Offset = 197, Required = false)]
		public UnderlyingRateSpreadSchedule? UnderlyingRateSpreadSchedule {get; set;}
		
		[Component(Offset = 198, Required = false)]
		public UnderlyingDividendPayout? UnderlyingDividendPayout {get; set;}
		
		[Component(Offset = 199, Required = false)]
		public UnderlyingExtraordinaryEventGrp? UnderlyingExtraordinaryEventGrp {get; set;}
		
		[TagDetails(Tag = 2624, Type = TagType.Int, Offset = 200, Required = false)]
		public int? UnderlyingExtraordinaryEventAdjustmentMethod {get; set;}
		
		[TagDetails(Tag = 2625, Type = TagType.Boolean, Offset = 201, Required = false)]
		public bool? UnderlyingExchangeLookAlike {get; set;}
		
		[TagDetails(Tag = 2626, Type = TagType.Float, Offset = 202, Required = false)]
		public double? UnderlyingAverageVolumeLimitationPercentage {get; set;}
		
		[TagDetails(Tag = 2627, Type = TagType.Int, Offset = 203, Required = false)]
		public int? UnderlyingAverageVolumeLimitationPeriodDays {get; set;}
		
		[TagDetails(Tag = 2628, Type = TagType.Boolean, Offset = 204, Required = false)]
		public bool? UnderlyingDepositoryReceiptIndicator {get; set;}
		
		[TagDetails(Tag = 2629, Type = TagType.Float, Offset = 205, Required = false)]
		public double? UnderlyingOpenUnits {get; set;}
		
		[TagDetails(Tag = 2630, Type = TagType.Float, Offset = 206, Required = false)]
		public double? UnderlyingBasketDivisor {get; set;}
		
		[TagDetails(Tag = 2631, Type = TagType.String, Offset = 207, Required = false)]
		public string? UnderlyingInstrumentXID {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingSymbol is not null) writer.WriteString(311, UnderlyingSymbol);
			if (UnderlyingSymbolSfx is not null) writer.WriteString(312, UnderlyingSymbolSfx);
			if (UnderlyingSecurityID is not null) writer.WriteString(309, UnderlyingSecurityID);
			if (UnderlyingSecurityIDSource is not null) writer.WriteString(305, UnderlyingSecurityIDSource);
			if (UndSecAltIDGrp is not null) ((IFixEncoder)UndSecAltIDGrp).Encode(writer);
			if (UnderlyingID is not null) writer.WriteString(2874, UnderlyingID);
			if (UnderlyingProduct is not null) writer.WriteWholeNumber(462, UnderlyingProduct.Value);
			if (UnderlyingSecurityXML is not null) ((IFixEncoder)UnderlyingSecurityXML).Encode(writer);
			if (UnderlyingCFICode is not null) writer.WriteString(463, UnderlyingCFICode);
			if (UnderlyingUPICode is not null) writer.WriteString(2894, UnderlyingUPICode);
			if (UnderlyingSecurityType is not null) writer.WriteString(310, UnderlyingSecurityType);
			if (UnderlyingSecuritySubType is not null) writer.WriteString(763, UnderlyingSecuritySubType);
			if (UnderlyingMaturityMonthYear is not null) writer.WriteMonthYear(313, UnderlyingMaturityMonthYear.Value);
			if (UnderlyingMaturityDate is not null) writer.WriteLocalDateOnly(542, UnderlyingMaturityDate.Value);
			if (UnderlyingMaturityTime is not null) writer.WriteString(1213, UnderlyingMaturityTime);
			if (UnderlyingContractPriceRefMonth is not null) writer.WriteMonthYear(1837, UnderlyingContractPriceRefMonth.Value);
			if (UnderlyingCouponPaymentDate is not null) writer.WriteLocalDateOnly(241, UnderlyingCouponPaymentDate.Value);
			if (UnderlyingRestructuringType is not null) writer.WriteString(1453, UnderlyingRestructuringType);
			if (UnderlyingSeniority is not null) writer.WriteString(1454, UnderlyingSeniority);
			if (UnderlyingNotional is not null) writer.WriteNumber(2614, UnderlyingNotional.Value);
			if (UnderlyingNotionalCurrency is not null) writer.WriteString(2615, UnderlyingNotionalCurrency);
			if (UnderlyingNotionalCurrencyCodeSource is not null) writer.WriteString(2921, UnderlyingNotionalCurrencyCodeSource);
			if (UnderlyingNotionalDeterminationMethod is not null) writer.WriteString(2616, UnderlyingNotionalDeterminationMethod);
			if (UnderlyingNotionalAdjustments is not null) writer.WriteWholeNumber(2617, UnderlyingNotionalAdjustments.Value);
			if (UnderlyingNotionalXIDRef is not null) writer.WriteString(2619, UnderlyingNotionalXIDRef);
			if (UnderlyingNotionalPercentageOutstanding is not null) writer.WriteNumber(1455, UnderlyingNotionalPercentageOutstanding.Value);
			if (UnderlyingOriginalNotionalPercentageOutstanding is not null) writer.WriteNumber(1456, UnderlyingOriginalNotionalPercentageOutstanding.Value);
			if (UnderlyingAttachmentPoint is not null) writer.WriteNumber(1459, UnderlyingAttachmentPoint.Value);
			if (UnderlyingDetachmentPoint is not null) writer.WriteNumber(1460, UnderlyingDetachmentPoint.Value);
			if (UnderlyingIssueDate is not null) writer.WriteLocalDateOnly(242, UnderlyingIssueDate.Value);
			if (UnderlyingRepoCollateralSecurityType is not null) writer.WriteString(243, UnderlyingRepoCollateralSecurityType);
			if (UnderlyingRepurchaseTerm is not null) writer.WriteWholeNumber(244, UnderlyingRepurchaseTerm.Value);
			if (UnderlyingRepurchaseRate is not null) writer.WriteNumber(245, UnderlyingRepurchaseRate.Value);
			if (UnderlyingFactor is not null) writer.WriteNumber(246, UnderlyingFactor.Value);
			if (UnderlyingCreditRating is not null) writer.WriteString(256, UnderlyingCreditRating);
			if (UnderlyingInstrRegistry is not null) writer.WriteString(595, UnderlyingInstrRegistry);
			if (UnderlyingCountryOfIssue is not null) writer.WriteString(592, UnderlyingCountryOfIssue);
			if (UnderlyingStateOrProvinceOfIssue is not null) writer.WriteString(593, UnderlyingStateOrProvinceOfIssue);
			if (UnderlyingLocaleOfIssue is not null) writer.WriteString(594, UnderlyingLocaleOfIssue);
			if (UnderlyingRedemptionDate is not null) writer.WriteLocalDateOnly(247, UnderlyingRedemptionDate.Value);
			if (UnderlyingStrikePrice is not null) writer.WriteNumber(316, UnderlyingStrikePrice.Value);
			if (UnderlyingStrikeCurrency is not null) writer.WriteString(941, UnderlyingStrikeCurrency);
			if (UnderlyingStrikeCurrencyCodeSource is not null) writer.WriteString(2917, UnderlyingStrikeCurrencyCodeSource);
			if (UnderlyingOptAttribute is not null) writer.WriteString(317, UnderlyingOptAttribute);
			if (UnderlyingContractMultiplier is not null) writer.WriteNumber(436, UnderlyingContractMultiplier.Value);
			if (UnderlyingContractMultiplierUnit is not null) writer.WriteWholeNumber(1437, UnderlyingContractMultiplierUnit.Value);
			if (UnderlyingTradingUnitPeriodMultiplier is not null) writer.WriteWholeNumber(2363, UnderlyingTradingUnitPeriodMultiplier.Value);
			if (UnderlyingFlowScheduleType is not null) writer.WriteWholeNumber(1441, UnderlyingFlowScheduleType.Value);
			if (UnderlyingUnitOfMeasure is not null) writer.WriteString(998, UnderlyingUnitOfMeasure);
			if (UnderlyingUnitOfMeasureQty is not null) writer.WriteNumber(1423, UnderlyingUnitOfMeasureQty.Value);
			if (UnderlyingUnitOfMeasureCurrency is not null) writer.WriteString(1718, UnderlyingUnitOfMeasureCurrency);
			if (UnderlyingUnitOfMeasureCurrencyCodeSource is not null) writer.WriteString(2918, UnderlyingUnitOfMeasureCurrencyCodeSource);
			if (UnderlyingPriceUnitOfMeasure is not null) writer.WriteString(1424, UnderlyingPriceUnitOfMeasure);
			if (UnderlyingPriceUnitOfMeasureQty is not null) writer.WriteNumber(1425, UnderlyingPriceUnitOfMeasureQty.Value);
			if (UnderlyingPriceUnitOfMeasureCurrency is not null) writer.WriteString(1719, UnderlyingPriceUnitOfMeasureCurrency);
			if (UnderlyingPriceUnitOfMeasureCurrencyCodeSource is not null) writer.WriteString(2919, UnderlyingPriceUnitOfMeasureCurrencyCodeSource);
			if (UnderlyingTimeUnit is not null) writer.WriteString(1000, UnderlyingTimeUnit);
			if (UnderlyingExerciseStyle is not null) writer.WriteWholeNumber(1419, UnderlyingExerciseStyle.Value);
			if (UnderlyingPriceQuoteCurrency is not null) writer.WriteString(1526, UnderlyingPriceQuoteCurrency);
			if (UnderlyingPriceQuoteCurrencyCodeSource is not null) writer.WriteString(2920, UnderlyingPriceQuoteCurrencyCodeSource);
			if (UnderlyingCouponRate is not null) writer.WriteNumber(435, UnderlyingCouponRate.Value);
			if (UnderlyingSecurityExchange is not null) writer.WriteString(308, UnderlyingSecurityExchange);
			if (UnderlyingIssuer is not null) writer.WriteString(306, UnderlyingIssuer);
			if (EncodedUnderlyingIssuerLen is not null) writer.WriteWholeNumber(362, EncodedUnderlyingIssuerLen.Value);
			if (EncodedUnderlyingIssuer is not null) writer.WriteBuffer(363, EncodedUnderlyingIssuer);
			if (UnderlyingFinancialInstrumentShortName is not null) writer.WriteString(2742, UnderlyingFinancialInstrumentShortName);
			if (UnderlyingFinancialInstrumentFullName is not null) writer.WriteString(2720, UnderlyingFinancialInstrumentFullName);
			if (EncodedUnderlyingFinancialInstrumentFullNameLen is not null) writer.WriteWholeNumber(2721, EncodedUnderlyingFinancialInstrumentFullNameLen.Value);
			if (EncodedUnderlyingFinancialInstrumentFullName is not null) writer.WriteBuffer(2722, EncodedUnderlyingFinancialInstrumentFullName);
			if (UnderlyingIndexCurveUnit is not null) writer.WriteString(2723, UnderlyingIndexCurveUnit);
			if (UnderlyingIndexCurvePeriod is not null) writer.WriteWholeNumber(2724, UnderlyingIndexCurvePeriod.Value);
			if (UnderlyingSecurityDesc is not null) writer.WriteString(307, UnderlyingSecurityDesc);
			if (EncodedUnderlyingSecurityDescLen is not null) writer.WriteWholeNumber(364, EncodedUnderlyingSecurityDescLen.Value);
			if (EncodedUnderlyingSecurityDesc is not null) writer.WriteBuffer(365, EncodedUnderlyingSecurityDesc);
			if (UnderlyingCPProgram is not null) writer.WriteWholeNumber(877, UnderlyingCPProgram.Value);
			if (UnderlyingCPRegType is not null) writer.WriteString(878, UnderlyingCPRegType);
			if (UnderlyingAllocationPercent is not null) writer.WriteNumber(972, UnderlyingAllocationPercent.Value);
			if (UnderlyingCurrency is not null) writer.WriteString(318, UnderlyingCurrency);
			if (UnderlyingCurrencyCodeSource is not null) writer.WriteString(2916, UnderlyingCurrencyCodeSource);
			if (UnderlyingQty is not null) writer.WriteNumber(879, UnderlyingQty.Value);
			if (UnderlyingSettlementType is not null) writer.WriteWholeNumber(975, UnderlyingSettlementType.Value);
			if (UnderlyingCashAmount is not null) writer.WriteNumber(973, UnderlyingCashAmount.Value);
			if (UnderlyingCashType is not null) writer.WriteString(974, UnderlyingCashType);
			if (UnderlyingPx is not null) writer.WriteNumber(810, UnderlyingPx.Value);
			if (UnderlyingDirtyPrice is not null) writer.WriteNumber(882, UnderlyingDirtyPrice.Value);
			if (UnderlyingEndPrice is not null) writer.WriteNumber(883, UnderlyingEndPrice.Value);
			if (UnderlyingStartValue is not null) writer.WriteNumber(884, UnderlyingStartValue.Value);
			if (UnderlyingCurrentValue is not null) writer.WriteNumber(885, UnderlyingCurrentValue.Value);
			if (UnderlyingEndValue is not null) writer.WriteNumber(886, UnderlyingEndValue.Value);
			if (UnderlyingAccruedInterestAmt is not null) writer.WriteNumber(2885, UnderlyingAccruedInterestAmt.Value);
			if (UnderlyingNumDaysInterest is not null) writer.WriteWholeNumber(2886, UnderlyingNumDaysInterest.Value);
			if (UnderlyingStipulations is not null) ((IFixEncoder)UnderlyingStipulations).Encode(writer);
			if (UnderlyingAdjustedQuantity is not null) writer.WriteNumber(1044, UnderlyingAdjustedQuantity.Value);
			if (UnderlyingFXRate is not null) writer.WriteNumber(1045, UnderlyingFXRate.Value);
			if (UnderlyingFXRateCalc is not null) writer.WriteString(1046, UnderlyingFXRateCalc);
			if (UnderlyingCapValue is not null) writer.WriteNumber(1038, UnderlyingCapValue.Value);
			if (UndlyInstrumentParties is not null) ((IFixEncoder)UndlyInstrumentParties).Encode(writer);
			if (UnderlyingSettlMethod is not null) writer.WriteString(1039, UnderlyingSettlMethod);
			if (UnderlyingPutOrCall is not null) writer.WriteWholeNumber(315, UnderlyingPutOrCall.Value);
			if (UnderlyingInTheMoneyCondition is not null) writer.WriteWholeNumber(2683, UnderlyingInTheMoneyCondition.Value);
			if (UnderlyingContraryInstructionEligibilityIndicator is not null) writer.WriteBoolean(2687, UnderlyingContraryInstructionEligibilityIndicator.Value);
			if (UnderlyingConstituentWeight is not null) writer.WriteNumber(1988, UnderlyingConstituentWeight.Value);
			if (UnderlyingCouponType is not null) writer.WriteWholeNumber(1989, UnderlyingCouponType.Value);
			if (UnderlyingTotalIssuedAmount is not null) writer.WriteNumber(1990, UnderlyingTotalIssuedAmount.Value);
			if (UnderlyingCouponFrequencyPeriod is not null) writer.WriteWholeNumber(1991, UnderlyingCouponFrequencyPeriod.Value);
			if (UnderlyingCouponFrequencyUnit is not null) writer.WriteString(1992, UnderlyingCouponFrequencyUnit);
			if (UnderlyingCouponDayCount is not null) writer.WriteWholeNumber(1993, UnderlyingCouponDayCount.Value);
			if (UnderlyingCouponOtherDayCount is not null) writer.WriteString(2881, UnderlyingCouponOtherDayCount);
			if (UnderlyingObligationID is not null) writer.WriteString(1994, UnderlyingObligationID);
			if (UnderlyingObligationIDSource is not null) writer.WriteString(1995, UnderlyingObligationIDSource);
			if (UnderlyingEquityID is not null) writer.WriteString(1996, UnderlyingEquityID);
			if (UnderlyingEquityIDSource is not null) writer.WriteString(1997, UnderlyingEquityIDSource);
			if (UnderlyingFutureID is not null) writer.WriteString(2620, UnderlyingFutureID);
			if (UnderlyingFutureIDSource is not null) writer.WriteString(2621, UnderlyingFutureIDSource);
			if (UnderlyingEvntGrp is not null) ((IFixEncoder)UnderlyingEvntGrp).Encode(writer);
			if (UnderlyingLienSeniority is not null) writer.WriteWholeNumber(1998, UnderlyingLienSeniority.Value);
			if (UnderlyingLoanFacility is not null) writer.WriteWholeNumber(1999, UnderlyingLoanFacility.Value);
			if (UnderlyingReferenceEntityType is not null) writer.WriteWholeNumber(2000, UnderlyingReferenceEntityType.Value);
			if (UnderlyingIndexSeries is not null) writer.WriteWholeNumber(2003, UnderlyingIndexSeries.Value);
			if (UnderlyingIndexAnnexVersion is not null) writer.WriteWholeNumber(2004, UnderlyingIndexAnnexVersion.Value);
			if (UnderlyingIndexAnnexDate is not null) writer.WriteLocalDateOnly(2005, UnderlyingIndexAnnexDate.Value);
			if (UnderlyingIndexAnnexSource is not null) writer.WriteString(2006, UnderlyingIndexAnnexSource);
			if (UnderlyingSettlRateIndex is not null) writer.WriteString(2284, UnderlyingSettlRateIndex);
			if (UnderlyingSettlRateIndexLocation is not null) writer.WriteString(2285, UnderlyingSettlRateIndexLocation);
			if (UnderlyingOptionExpirationDesc is not null) writer.WriteString(2286, UnderlyingOptionExpirationDesc);
			if (EncodedUnderlyingOptionExpirationDescLen is not null) writer.WriteWholeNumber(2287, EncodedUnderlyingOptionExpirationDescLen.Value);
			if (EncodedUnderlyingOptionExpirationDesc is not null) writer.WriteBuffer(2288, EncodedUnderlyingOptionExpirationDesc);
			if (UnderlyingProductComplex is not null) writer.WriteString(2007, UnderlyingProductComplex);
			if (UnderlyingSecurityGroup is not null) writer.WriteString(2008, UnderlyingSecurityGroup);
			if (UnderlyingSettleOnOpenFlag is not null) writer.WriteString(2009, UnderlyingSettleOnOpenFlag);
			if (UnderlyingAssignmentMethod is not null) writer.WriteString(2010, UnderlyingAssignmentMethod);
			if (UnderlyingSecurityStatus is not null) writer.WriteString(2011, UnderlyingSecurityStatus);
			if (UnderlyingObligationType is not null) writer.WriteString(2012, UnderlyingObligationType);
			if (UnderlyingAssetGroup is not null) writer.WriteWholeNumber(2491, UnderlyingAssetGroup.Value);
			if (UnderlyingAssetClass is not null) writer.WriteWholeNumber(2013, UnderlyingAssetClass.Value);
			if (UnderlyingAssetSubClass is not null) writer.WriteWholeNumber(2014, UnderlyingAssetSubClass.Value);
			if (UnderlyingAssetType is not null) writer.WriteString(2015, UnderlyingAssetType);
			if (UnderlyingAssetSubType is not null) writer.WriteString(2744, UnderlyingAssetSubType);
			if (UnderlyingSecondaryAssetGrp is not null) ((IFixEncoder)UnderlyingSecondaryAssetGrp).Encode(writer);
			if (UnderlyingAssetAttributeGrp is not null) ((IFixEncoder)UnderlyingAssetAttributeGrp).Encode(writer);
			if (UnderlyingSwapClass is not null) writer.WriteString(2016, UnderlyingSwapClass);
			if (UnderlyingSwapSubClass is not null) writer.WriteString(2289, UnderlyingSwapSubClass);
			if (UnderlyingNthToDefault is not null) writer.WriteWholeNumber(2017, UnderlyingNthToDefault.Value);
			if (UnderlyingMthToDefault is not null) writer.WriteWholeNumber(2018, UnderlyingMthToDefault.Value);
			if (UnderlyingSettledEntityMatrixSource is not null) writer.WriteString(2019, UnderlyingSettledEntityMatrixSource);
			if (UnderlyingSettledEntityMatrixPublicationDate is not null) writer.WriteLocalDateOnly(2020, UnderlyingSettledEntityMatrixPublicationDate.Value);
			if (UnderlyingStrikeMultiplier is not null) writer.WriteNumber(2021, UnderlyingStrikeMultiplier.Value);
			if (UnderlyingStrikeValue is not null) writer.WriteNumber(2022, UnderlyingStrikeValue.Value);
			if (UnderlyingStrikeUnitOfMeasure is not null) writer.WriteString(2290, UnderlyingStrikeUnitOfMeasure);
			if (UnderlyingStrikeIndexCurvePoint is not null) writer.WriteString(2622, UnderlyingStrikeIndexCurvePoint);
			if (UnderlyingStrikeIndex is not null) writer.WriteString(2291, UnderlyingStrikeIndex);
			if (UnderlyingStrikeIndexQuote is not null) writer.WriteWholeNumber(2623, UnderlyingStrikeIndexQuote.Value);
			if (UnderlyingStrikeIndexSpread is not null) writer.WriteNumber(2292, UnderlyingStrikeIndexSpread.Value);
			if (UnderlyingStrikePriceDeterminationMethod is not null) writer.WriteWholeNumber(2023, UnderlyingStrikePriceDeterminationMethod.Value);
			if (UnderlyingStrikePriceBoundaryMethod is not null) writer.WriteWholeNumber(2024, UnderlyingStrikePriceBoundaryMethod.Value);
			if (UnderlyingStrikePriceBoundaryPrecision is not null) writer.WriteNumber(2025, UnderlyingStrikePriceBoundaryPrecision.Value);
			if (UnderlyingMinPriceIncrement is not null) writer.WriteNumber(2026, UnderlyingMinPriceIncrement.Value);
			if (UnderlyingMinPriceIncrementAmount is not null) writer.WriteNumber(2027, UnderlyingMinPriceIncrementAmount.Value);
			if (UnderlyingOptPayoutType is not null) writer.WriteWholeNumber(2028, UnderlyingOptPayoutType.Value);
			if (UnderlyingOptPayoutAmount is not null) writer.WriteNumber(2029, UnderlyingOptPayoutAmount.Value);
			if (UnderlyingReturnTrigger is not null) writer.WriteWholeNumber(2757, UnderlyingReturnTrigger.Value);
			if (UnderlyingPriceQuoteMethod is not null) writer.WriteString(2030, UnderlyingPriceQuoteMethod);
			if (UnderlyingValuationMethod is not null) writer.WriteString(2031, UnderlyingValuationMethod);
			if (UnderlyingValuationSource is not null) writer.WriteString(2293, UnderlyingValuationSource);
			if (UnderlyingValuationReferenceModel is not null) writer.WriteString(2294, UnderlyingValuationReferenceModel);
			if (UnderlyingListMethod is not null) writer.WriteWholeNumber(2032, UnderlyingListMethod.Value);
			if (UnderlyingCapPrice is not null) writer.WriteNumber(2033, UnderlyingCapPrice.Value);
			if (UnderlyingFloorPrice is not null) writer.WriteNumber(2034, UnderlyingFloorPrice.Value);
			if (UnderlyingFlexibleIndicator is not null) writer.WriteBoolean(2035, UnderlyingFlexibleIndicator.Value);
			if (UnderlyingFlexProductEligibilityIndicator is not null) writer.WriteBoolean(2036, UnderlyingFlexProductEligibilityIndicator.Value);
			if (UnderlyingPositionLimit is not null) writer.WriteWholeNumber(2037, UnderlyingPositionLimit.Value);
			if (UnderlyingNTPositionLimit is not null) writer.WriteWholeNumber(2038, UnderlyingNTPositionLimit.Value);
			if (UnderlyingPool is not null) writer.WriteString(2039, UnderlyingPool);
			if (UnderlyingContractSettlMonth is not null) writer.WriteMonthYear(2040, UnderlyingContractSettlMonth.Value);
			if (UnderlyingDatedDate is not null) writer.WriteLocalDateOnly(2041, UnderlyingDatedDate.Value);
			if (UnderlyingInterestAccrualDate is not null) writer.WriteLocalDateOnly(2042, UnderlyingInterestAccrualDate.Value);
			if (UnderlyingShortSaleRestriction is not null) writer.WriteWholeNumber(2043, UnderlyingShortSaleRestriction.Value);
			if (UnderlyingRefTickTableID is not null) writer.WriteWholeNumber(2044, UnderlyingRefTickTableID.Value);
			if (UnderlyingProtectionTermXIDRef is not null) writer.WriteString(41314, UnderlyingProtectionTermXIDRef);
			if (UnderlyingSettlTermXIDRef is not null) writer.WriteString(41315, UnderlyingSettlTermXIDRef);
			if (UnderlyingComplexEvents is not null) ((IFixEncoder)UnderlyingComplexEvents).Encode(writer);
			if (UnderlyingStrategyType is not null) writer.WriteString(2295, UnderlyingStrategyType);
			if (UnderlyingCommonPricingIndicator is not null) writer.WriteBoolean(2296, UnderlyingCommonPricingIndicator.Value);
			if (UnderlyingSettlDisruptionProvision is not null) writer.WriteWholeNumber(2297, UnderlyingSettlDisruptionProvision.Value);
			if (UnderlyingDeliveryRouteOrCharter is not null) writer.WriteString(2756, UnderlyingDeliveryRouteOrCharter);
			if (UnderlyingInstrumentRoundingDirection is not null) writer.WriteString(2298, UnderlyingInstrumentRoundingDirection);
			if (UnderlyingInstrumentRoundingPrecision is not null) writer.WriteWholeNumber(2299, UnderlyingInstrumentRoundingPrecision.Value);
			if (UnderlyingDateAdjustment is not null) ((IFixEncoder)UnderlyingDateAdjustment).Encode(writer);
			if (UnderlyingPricingDateTime is not null) ((IFixEncoder)UnderlyingPricingDateTime).Encode(writer);
			if (UnderlyingMarketDisruption is not null) ((IFixEncoder)UnderlyingMarketDisruption).Encode(writer);
			if (UnderlyingOptionExercise is not null) ((IFixEncoder)UnderlyingOptionExercise).Encode(writer);
			if (UnderlyingStreamGrp is not null) ((IFixEncoder)UnderlyingStreamGrp).Encode(writer);
			if (UnderlyingProvisionGrp is not null) ((IFixEncoder)UnderlyingProvisionGrp).Encode(writer);
			if (UnderlyingAdditionalTermGrp is not null) ((IFixEncoder)UnderlyingAdditionalTermGrp).Encode(writer);
			if (UnderlyingProtectionTermGrp is not null) ((IFixEncoder)UnderlyingProtectionTermGrp).Encode(writer);
			if (UnderlyingCashSettlTermGrp is not null) ((IFixEncoder)UnderlyingCashSettlTermGrp).Encode(writer);
			if (UnderlyingPhysicalSettlTermGrp is not null) ((IFixEncoder)UnderlyingPhysicalSettlTermGrp).Encode(writer);
			if (UnderlyingRateSpreadSchedule is not null) ((IFixEncoder)UnderlyingRateSpreadSchedule).Encode(writer);
			if (UnderlyingDividendPayout is not null) ((IFixEncoder)UnderlyingDividendPayout).Encode(writer);
			if (UnderlyingExtraordinaryEventGrp is not null) ((IFixEncoder)UnderlyingExtraordinaryEventGrp).Encode(writer);
			if (UnderlyingExtraordinaryEventAdjustmentMethod is not null) writer.WriteWholeNumber(2624, UnderlyingExtraordinaryEventAdjustmentMethod.Value);
			if (UnderlyingExchangeLookAlike is not null) writer.WriteBoolean(2625, UnderlyingExchangeLookAlike.Value);
			if (UnderlyingAverageVolumeLimitationPercentage is not null) writer.WriteNumber(2626, UnderlyingAverageVolumeLimitationPercentage.Value);
			if (UnderlyingAverageVolumeLimitationPeriodDays is not null) writer.WriteWholeNumber(2627, UnderlyingAverageVolumeLimitationPeriodDays.Value);
			if (UnderlyingDepositoryReceiptIndicator is not null) writer.WriteBoolean(2628, UnderlyingDepositoryReceiptIndicator.Value);
			if (UnderlyingOpenUnits is not null) writer.WriteNumber(2629, UnderlyingOpenUnits.Value);
			if (UnderlyingBasketDivisor is not null) writer.WriteNumber(2630, UnderlyingBasketDivisor.Value);
			if (UnderlyingInstrumentXID is not null) writer.WriteString(2631, UnderlyingInstrumentXID);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingSymbol = view.GetString(311);
			UnderlyingSymbolSfx = view.GetString(312);
			UnderlyingSecurityID = view.GetString(309);
			UnderlyingSecurityIDSource = view.GetString(305);
			if (view.GetView("UndSecAltIDGrp") is IMessageView viewUndSecAltIDGrp)
			{
				UndSecAltIDGrp = new();
				((IFixParser)UndSecAltIDGrp).Parse(viewUndSecAltIDGrp);
			}
			UnderlyingID = view.GetString(2874);
			UnderlyingProduct = view.GetInt32(462);
			if (view.GetView("UnderlyingSecurityXML") is IMessageView viewUnderlyingSecurityXML)
			{
				UnderlyingSecurityXML = new();
				((IFixParser)UnderlyingSecurityXML).Parse(viewUnderlyingSecurityXML);
			}
			UnderlyingCFICode = view.GetString(463);
			UnderlyingUPICode = view.GetString(2894);
			UnderlyingSecurityType = view.GetString(310);
			UnderlyingSecuritySubType = view.GetString(763);
			UnderlyingMaturityMonthYear = view.GetMonthYear(313);
			UnderlyingMaturityDate = view.GetDateOnly(542);
			UnderlyingMaturityTime = view.GetString(1213);
			UnderlyingContractPriceRefMonth = view.GetMonthYear(1837);
			UnderlyingCouponPaymentDate = view.GetDateOnly(241);
			UnderlyingRestructuringType = view.GetString(1453);
			UnderlyingSeniority = view.GetString(1454);
			UnderlyingNotional = view.GetDouble(2614);
			UnderlyingNotionalCurrency = view.GetString(2615);
			UnderlyingNotionalCurrencyCodeSource = view.GetString(2921);
			UnderlyingNotionalDeterminationMethod = view.GetString(2616);
			UnderlyingNotionalAdjustments = view.GetInt32(2617);
			UnderlyingNotionalXIDRef = view.GetString(2619);
			UnderlyingNotionalPercentageOutstanding = view.GetDouble(1455);
			UnderlyingOriginalNotionalPercentageOutstanding = view.GetDouble(1456);
			UnderlyingAttachmentPoint = view.GetDouble(1459);
			UnderlyingDetachmentPoint = view.GetDouble(1460);
			UnderlyingIssueDate = view.GetDateOnly(242);
			UnderlyingRepoCollateralSecurityType = view.GetString(243);
			UnderlyingRepurchaseTerm = view.GetInt32(244);
			UnderlyingRepurchaseRate = view.GetDouble(245);
			UnderlyingFactor = view.GetDouble(246);
			UnderlyingCreditRating = view.GetString(256);
			UnderlyingInstrRegistry = view.GetString(595);
			UnderlyingCountryOfIssue = view.GetString(592);
			UnderlyingStateOrProvinceOfIssue = view.GetString(593);
			UnderlyingLocaleOfIssue = view.GetString(594);
			UnderlyingRedemptionDate = view.GetDateOnly(247);
			UnderlyingStrikePrice = view.GetDouble(316);
			UnderlyingStrikeCurrency = view.GetString(941);
			UnderlyingStrikeCurrencyCodeSource = view.GetString(2917);
			UnderlyingOptAttribute = view.GetString(317);
			UnderlyingContractMultiplier = view.GetDouble(436);
			UnderlyingContractMultiplierUnit = view.GetInt32(1437);
			UnderlyingTradingUnitPeriodMultiplier = view.GetInt32(2363);
			UnderlyingFlowScheduleType = view.GetInt32(1441);
			UnderlyingUnitOfMeasure = view.GetString(998);
			UnderlyingUnitOfMeasureQty = view.GetDouble(1423);
			UnderlyingUnitOfMeasureCurrency = view.GetString(1718);
			UnderlyingUnitOfMeasureCurrencyCodeSource = view.GetString(2918);
			UnderlyingPriceUnitOfMeasure = view.GetString(1424);
			UnderlyingPriceUnitOfMeasureQty = view.GetDouble(1425);
			UnderlyingPriceUnitOfMeasureCurrency = view.GetString(1719);
			UnderlyingPriceUnitOfMeasureCurrencyCodeSource = view.GetString(2919);
			UnderlyingTimeUnit = view.GetString(1000);
			UnderlyingExerciseStyle = view.GetInt32(1419);
			UnderlyingPriceQuoteCurrency = view.GetString(1526);
			UnderlyingPriceQuoteCurrencyCodeSource = view.GetString(2920);
			UnderlyingCouponRate = view.GetDouble(435);
			UnderlyingSecurityExchange = view.GetString(308);
			UnderlyingIssuer = view.GetString(306);
			EncodedUnderlyingIssuerLen = view.GetInt32(362);
			EncodedUnderlyingIssuer = view.GetByteArray(363);
			UnderlyingFinancialInstrumentShortName = view.GetString(2742);
			UnderlyingFinancialInstrumentFullName = view.GetString(2720);
			EncodedUnderlyingFinancialInstrumentFullNameLen = view.GetInt32(2721);
			EncodedUnderlyingFinancialInstrumentFullName = view.GetByteArray(2722);
			UnderlyingIndexCurveUnit = view.GetString(2723);
			UnderlyingIndexCurvePeriod = view.GetInt32(2724);
			UnderlyingSecurityDesc = view.GetString(307);
			EncodedUnderlyingSecurityDescLen = view.GetInt32(364);
			EncodedUnderlyingSecurityDesc = view.GetByteArray(365);
			UnderlyingCPProgram = view.GetInt32(877);
			UnderlyingCPRegType = view.GetString(878);
			UnderlyingAllocationPercent = view.GetDouble(972);
			UnderlyingCurrency = view.GetString(318);
			UnderlyingCurrencyCodeSource = view.GetString(2916);
			UnderlyingQty = view.GetDouble(879);
			UnderlyingSettlementType = view.GetInt32(975);
			UnderlyingCashAmount = view.GetDouble(973);
			UnderlyingCashType = view.GetString(974);
			UnderlyingPx = view.GetDouble(810);
			UnderlyingDirtyPrice = view.GetDouble(882);
			UnderlyingEndPrice = view.GetDouble(883);
			UnderlyingStartValue = view.GetDouble(884);
			UnderlyingCurrentValue = view.GetDouble(885);
			UnderlyingEndValue = view.GetDouble(886);
			UnderlyingAccruedInterestAmt = view.GetDouble(2885);
			UnderlyingNumDaysInterest = view.GetInt32(2886);
			if (view.GetView("UnderlyingStipulations") is IMessageView viewUnderlyingStipulations)
			{
				UnderlyingStipulations = new();
				((IFixParser)UnderlyingStipulations).Parse(viewUnderlyingStipulations);
			}
			UnderlyingAdjustedQuantity = view.GetDouble(1044);
			UnderlyingFXRate = view.GetDouble(1045);
			UnderlyingFXRateCalc = view.GetString(1046);
			UnderlyingCapValue = view.GetDouble(1038);
			if (view.GetView("UndlyInstrumentParties") is IMessageView viewUndlyInstrumentParties)
			{
				UndlyInstrumentParties = new();
				((IFixParser)UndlyInstrumentParties).Parse(viewUndlyInstrumentParties);
			}
			UnderlyingSettlMethod = view.GetString(1039);
			UnderlyingPutOrCall = view.GetInt32(315);
			UnderlyingInTheMoneyCondition = view.GetInt32(2683);
			UnderlyingContraryInstructionEligibilityIndicator = view.GetBool(2687);
			UnderlyingConstituentWeight = view.GetDouble(1988);
			UnderlyingCouponType = view.GetInt32(1989);
			UnderlyingTotalIssuedAmount = view.GetDouble(1990);
			UnderlyingCouponFrequencyPeriod = view.GetInt32(1991);
			UnderlyingCouponFrequencyUnit = view.GetString(1992);
			UnderlyingCouponDayCount = view.GetInt32(1993);
			UnderlyingCouponOtherDayCount = view.GetString(2881);
			UnderlyingObligationID = view.GetString(1994);
			UnderlyingObligationIDSource = view.GetString(1995);
			UnderlyingEquityID = view.GetString(1996);
			UnderlyingEquityIDSource = view.GetString(1997);
			UnderlyingFutureID = view.GetString(2620);
			UnderlyingFutureIDSource = view.GetString(2621);
			if (view.GetView("UnderlyingEvntGrp") is IMessageView viewUnderlyingEvntGrp)
			{
				UnderlyingEvntGrp = new();
				((IFixParser)UnderlyingEvntGrp).Parse(viewUnderlyingEvntGrp);
			}
			UnderlyingLienSeniority = view.GetInt32(1998);
			UnderlyingLoanFacility = view.GetInt32(1999);
			UnderlyingReferenceEntityType = view.GetInt32(2000);
			UnderlyingIndexSeries = view.GetInt32(2003);
			UnderlyingIndexAnnexVersion = view.GetInt32(2004);
			UnderlyingIndexAnnexDate = view.GetDateOnly(2005);
			UnderlyingIndexAnnexSource = view.GetString(2006);
			UnderlyingSettlRateIndex = view.GetString(2284);
			UnderlyingSettlRateIndexLocation = view.GetString(2285);
			UnderlyingOptionExpirationDesc = view.GetString(2286);
			EncodedUnderlyingOptionExpirationDescLen = view.GetInt32(2287);
			EncodedUnderlyingOptionExpirationDesc = view.GetByteArray(2288);
			UnderlyingProductComplex = view.GetString(2007);
			UnderlyingSecurityGroup = view.GetString(2008);
			UnderlyingSettleOnOpenFlag = view.GetString(2009);
			UnderlyingAssignmentMethod = view.GetString(2010);
			UnderlyingSecurityStatus = view.GetString(2011);
			UnderlyingObligationType = view.GetString(2012);
			UnderlyingAssetGroup = view.GetInt32(2491);
			UnderlyingAssetClass = view.GetInt32(2013);
			UnderlyingAssetSubClass = view.GetInt32(2014);
			UnderlyingAssetType = view.GetString(2015);
			UnderlyingAssetSubType = view.GetString(2744);
			if (view.GetView("UnderlyingSecondaryAssetGrp") is IMessageView viewUnderlyingSecondaryAssetGrp)
			{
				UnderlyingSecondaryAssetGrp = new();
				((IFixParser)UnderlyingSecondaryAssetGrp).Parse(viewUnderlyingSecondaryAssetGrp);
			}
			if (view.GetView("UnderlyingAssetAttributeGrp") is IMessageView viewUnderlyingAssetAttributeGrp)
			{
				UnderlyingAssetAttributeGrp = new();
				((IFixParser)UnderlyingAssetAttributeGrp).Parse(viewUnderlyingAssetAttributeGrp);
			}
			UnderlyingSwapClass = view.GetString(2016);
			UnderlyingSwapSubClass = view.GetString(2289);
			UnderlyingNthToDefault = view.GetInt32(2017);
			UnderlyingMthToDefault = view.GetInt32(2018);
			UnderlyingSettledEntityMatrixSource = view.GetString(2019);
			UnderlyingSettledEntityMatrixPublicationDate = view.GetDateOnly(2020);
			UnderlyingStrikeMultiplier = view.GetDouble(2021);
			UnderlyingStrikeValue = view.GetDouble(2022);
			UnderlyingStrikeUnitOfMeasure = view.GetString(2290);
			UnderlyingStrikeIndexCurvePoint = view.GetString(2622);
			UnderlyingStrikeIndex = view.GetString(2291);
			UnderlyingStrikeIndexQuote = view.GetInt32(2623);
			UnderlyingStrikeIndexSpread = view.GetDouble(2292);
			UnderlyingStrikePriceDeterminationMethod = view.GetInt32(2023);
			UnderlyingStrikePriceBoundaryMethod = view.GetInt32(2024);
			UnderlyingStrikePriceBoundaryPrecision = view.GetDouble(2025);
			UnderlyingMinPriceIncrement = view.GetDouble(2026);
			UnderlyingMinPriceIncrementAmount = view.GetDouble(2027);
			UnderlyingOptPayoutType = view.GetInt32(2028);
			UnderlyingOptPayoutAmount = view.GetDouble(2029);
			UnderlyingReturnTrigger = view.GetInt32(2757);
			UnderlyingPriceQuoteMethod = view.GetString(2030);
			UnderlyingValuationMethod = view.GetString(2031);
			UnderlyingValuationSource = view.GetString(2293);
			UnderlyingValuationReferenceModel = view.GetString(2294);
			UnderlyingListMethod = view.GetInt32(2032);
			UnderlyingCapPrice = view.GetDouble(2033);
			UnderlyingFloorPrice = view.GetDouble(2034);
			UnderlyingFlexibleIndicator = view.GetBool(2035);
			UnderlyingFlexProductEligibilityIndicator = view.GetBool(2036);
			UnderlyingPositionLimit = view.GetInt32(2037);
			UnderlyingNTPositionLimit = view.GetInt32(2038);
			UnderlyingPool = view.GetString(2039);
			UnderlyingContractSettlMonth = view.GetMonthYear(2040);
			UnderlyingDatedDate = view.GetDateOnly(2041);
			UnderlyingInterestAccrualDate = view.GetDateOnly(2042);
			UnderlyingShortSaleRestriction = view.GetInt32(2043);
			UnderlyingRefTickTableID = view.GetInt32(2044);
			UnderlyingProtectionTermXIDRef = view.GetString(41314);
			UnderlyingSettlTermXIDRef = view.GetString(41315);
			if (view.GetView("UnderlyingComplexEvents") is IMessageView viewUnderlyingComplexEvents)
			{
				UnderlyingComplexEvents = new();
				((IFixParser)UnderlyingComplexEvents).Parse(viewUnderlyingComplexEvents);
			}
			UnderlyingStrategyType = view.GetString(2295);
			UnderlyingCommonPricingIndicator = view.GetBool(2296);
			UnderlyingSettlDisruptionProvision = view.GetInt32(2297);
			UnderlyingDeliveryRouteOrCharter = view.GetString(2756);
			UnderlyingInstrumentRoundingDirection = view.GetString(2298);
			UnderlyingInstrumentRoundingPrecision = view.GetInt32(2299);
			if (view.GetView("UnderlyingDateAdjustment") is IMessageView viewUnderlyingDateAdjustment)
			{
				UnderlyingDateAdjustment = new();
				((IFixParser)UnderlyingDateAdjustment).Parse(viewUnderlyingDateAdjustment);
			}
			if (view.GetView("UnderlyingPricingDateTime") is IMessageView viewUnderlyingPricingDateTime)
			{
				UnderlyingPricingDateTime = new();
				((IFixParser)UnderlyingPricingDateTime).Parse(viewUnderlyingPricingDateTime);
			}
			if (view.GetView("UnderlyingMarketDisruption") is IMessageView viewUnderlyingMarketDisruption)
			{
				UnderlyingMarketDisruption = new();
				((IFixParser)UnderlyingMarketDisruption).Parse(viewUnderlyingMarketDisruption);
			}
			if (view.GetView("UnderlyingOptionExercise") is IMessageView viewUnderlyingOptionExercise)
			{
				UnderlyingOptionExercise = new();
				((IFixParser)UnderlyingOptionExercise).Parse(viewUnderlyingOptionExercise);
			}
			if (view.GetView("UnderlyingStreamGrp") is IMessageView viewUnderlyingStreamGrp)
			{
				UnderlyingStreamGrp = new();
				((IFixParser)UnderlyingStreamGrp).Parse(viewUnderlyingStreamGrp);
			}
			if (view.GetView("UnderlyingProvisionGrp") is IMessageView viewUnderlyingProvisionGrp)
			{
				UnderlyingProvisionGrp = new();
				((IFixParser)UnderlyingProvisionGrp).Parse(viewUnderlyingProvisionGrp);
			}
			if (view.GetView("UnderlyingAdditionalTermGrp") is IMessageView viewUnderlyingAdditionalTermGrp)
			{
				UnderlyingAdditionalTermGrp = new();
				((IFixParser)UnderlyingAdditionalTermGrp).Parse(viewUnderlyingAdditionalTermGrp);
			}
			if (view.GetView("UnderlyingProtectionTermGrp") is IMessageView viewUnderlyingProtectionTermGrp)
			{
				UnderlyingProtectionTermGrp = new();
				((IFixParser)UnderlyingProtectionTermGrp).Parse(viewUnderlyingProtectionTermGrp);
			}
			if (view.GetView("UnderlyingCashSettlTermGrp") is IMessageView viewUnderlyingCashSettlTermGrp)
			{
				UnderlyingCashSettlTermGrp = new();
				((IFixParser)UnderlyingCashSettlTermGrp).Parse(viewUnderlyingCashSettlTermGrp);
			}
			if (view.GetView("UnderlyingPhysicalSettlTermGrp") is IMessageView viewUnderlyingPhysicalSettlTermGrp)
			{
				UnderlyingPhysicalSettlTermGrp = new();
				((IFixParser)UnderlyingPhysicalSettlTermGrp).Parse(viewUnderlyingPhysicalSettlTermGrp);
			}
			if (view.GetView("UnderlyingRateSpreadSchedule") is IMessageView viewUnderlyingRateSpreadSchedule)
			{
				UnderlyingRateSpreadSchedule = new();
				((IFixParser)UnderlyingRateSpreadSchedule).Parse(viewUnderlyingRateSpreadSchedule);
			}
			if (view.GetView("UnderlyingDividendPayout") is IMessageView viewUnderlyingDividendPayout)
			{
				UnderlyingDividendPayout = new();
				((IFixParser)UnderlyingDividendPayout).Parse(viewUnderlyingDividendPayout);
			}
			if (view.GetView("UnderlyingExtraordinaryEventGrp") is IMessageView viewUnderlyingExtraordinaryEventGrp)
			{
				UnderlyingExtraordinaryEventGrp = new();
				((IFixParser)UnderlyingExtraordinaryEventGrp).Parse(viewUnderlyingExtraordinaryEventGrp);
			}
			UnderlyingExtraordinaryEventAdjustmentMethod = view.GetInt32(2624);
			UnderlyingExchangeLookAlike = view.GetBool(2625);
			UnderlyingAverageVolumeLimitationPercentage = view.GetDouble(2626);
			UnderlyingAverageVolumeLimitationPeriodDays = view.GetInt32(2627);
			UnderlyingDepositoryReceiptIndicator = view.GetBool(2628);
			UnderlyingOpenUnits = view.GetDouble(2629);
			UnderlyingBasketDivisor = view.GetDouble(2630);
			UnderlyingInstrumentXID = view.GetString(2631);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingSymbol":
				{
					value = UnderlyingSymbol;
					break;
				}
				case "UnderlyingSymbolSfx":
				{
					value = UnderlyingSymbolSfx;
					break;
				}
				case "UnderlyingSecurityID":
				{
					value = UnderlyingSecurityID;
					break;
				}
				case "UnderlyingSecurityIDSource":
				{
					value = UnderlyingSecurityIDSource;
					break;
				}
				case "UndSecAltIDGrp":
				{
					value = UndSecAltIDGrp;
					break;
				}
				case "UnderlyingID":
				{
					value = UnderlyingID;
					break;
				}
				case "UnderlyingProduct":
				{
					value = UnderlyingProduct;
					break;
				}
				case "UnderlyingSecurityXML":
				{
					value = UnderlyingSecurityXML;
					break;
				}
				case "UnderlyingCFICode":
				{
					value = UnderlyingCFICode;
					break;
				}
				case "UnderlyingUPICode":
				{
					value = UnderlyingUPICode;
					break;
				}
				case "UnderlyingSecurityType":
				{
					value = UnderlyingSecurityType;
					break;
				}
				case "UnderlyingSecuritySubType":
				{
					value = UnderlyingSecuritySubType;
					break;
				}
				case "UnderlyingMaturityMonthYear":
				{
					value = UnderlyingMaturityMonthYear;
					break;
				}
				case "UnderlyingMaturityDate":
				{
					value = UnderlyingMaturityDate;
					break;
				}
				case "UnderlyingMaturityTime":
				{
					value = UnderlyingMaturityTime;
					break;
				}
				case "UnderlyingContractPriceRefMonth":
				{
					value = UnderlyingContractPriceRefMonth;
					break;
				}
				case "UnderlyingCouponPaymentDate":
				{
					value = UnderlyingCouponPaymentDate;
					break;
				}
				case "UnderlyingRestructuringType":
				{
					value = UnderlyingRestructuringType;
					break;
				}
				case "UnderlyingSeniority":
				{
					value = UnderlyingSeniority;
					break;
				}
				case "UnderlyingNotional":
				{
					value = UnderlyingNotional;
					break;
				}
				case "UnderlyingNotionalCurrency":
				{
					value = UnderlyingNotionalCurrency;
					break;
				}
				case "UnderlyingNotionalCurrencyCodeSource":
				{
					value = UnderlyingNotionalCurrencyCodeSource;
					break;
				}
				case "UnderlyingNotionalDeterminationMethod":
				{
					value = UnderlyingNotionalDeterminationMethod;
					break;
				}
				case "UnderlyingNotionalAdjustments":
				{
					value = UnderlyingNotionalAdjustments;
					break;
				}
				case "UnderlyingNotionalXIDRef":
				{
					value = UnderlyingNotionalXIDRef;
					break;
				}
				case "UnderlyingNotionalPercentageOutstanding":
				{
					value = UnderlyingNotionalPercentageOutstanding;
					break;
				}
				case "UnderlyingOriginalNotionalPercentageOutstanding":
				{
					value = UnderlyingOriginalNotionalPercentageOutstanding;
					break;
				}
				case "UnderlyingAttachmentPoint":
				{
					value = UnderlyingAttachmentPoint;
					break;
				}
				case "UnderlyingDetachmentPoint":
				{
					value = UnderlyingDetachmentPoint;
					break;
				}
				case "UnderlyingIssueDate":
				{
					value = UnderlyingIssueDate;
					break;
				}
				case "UnderlyingRepoCollateralSecurityType":
				{
					value = UnderlyingRepoCollateralSecurityType;
					break;
				}
				case "UnderlyingRepurchaseTerm":
				{
					value = UnderlyingRepurchaseTerm;
					break;
				}
				case "UnderlyingRepurchaseRate":
				{
					value = UnderlyingRepurchaseRate;
					break;
				}
				case "UnderlyingFactor":
				{
					value = UnderlyingFactor;
					break;
				}
				case "UnderlyingCreditRating":
				{
					value = UnderlyingCreditRating;
					break;
				}
				case "UnderlyingInstrRegistry":
				{
					value = UnderlyingInstrRegistry;
					break;
				}
				case "UnderlyingCountryOfIssue":
				{
					value = UnderlyingCountryOfIssue;
					break;
				}
				case "UnderlyingStateOrProvinceOfIssue":
				{
					value = UnderlyingStateOrProvinceOfIssue;
					break;
				}
				case "UnderlyingLocaleOfIssue":
				{
					value = UnderlyingLocaleOfIssue;
					break;
				}
				case "UnderlyingRedemptionDate":
				{
					value = UnderlyingRedemptionDate;
					break;
				}
				case "UnderlyingStrikePrice":
				{
					value = UnderlyingStrikePrice;
					break;
				}
				case "UnderlyingStrikeCurrency":
				{
					value = UnderlyingStrikeCurrency;
					break;
				}
				case "UnderlyingStrikeCurrencyCodeSource":
				{
					value = UnderlyingStrikeCurrencyCodeSource;
					break;
				}
				case "UnderlyingOptAttribute":
				{
					value = UnderlyingOptAttribute;
					break;
				}
				case "UnderlyingContractMultiplier":
				{
					value = UnderlyingContractMultiplier;
					break;
				}
				case "UnderlyingContractMultiplierUnit":
				{
					value = UnderlyingContractMultiplierUnit;
					break;
				}
				case "UnderlyingTradingUnitPeriodMultiplier":
				{
					value = UnderlyingTradingUnitPeriodMultiplier;
					break;
				}
				case "UnderlyingFlowScheduleType":
				{
					value = UnderlyingFlowScheduleType;
					break;
				}
				case "UnderlyingUnitOfMeasure":
				{
					value = UnderlyingUnitOfMeasure;
					break;
				}
				case "UnderlyingUnitOfMeasureQty":
				{
					value = UnderlyingUnitOfMeasureQty;
					break;
				}
				case "UnderlyingUnitOfMeasureCurrency":
				{
					value = UnderlyingUnitOfMeasureCurrency;
					break;
				}
				case "UnderlyingUnitOfMeasureCurrencyCodeSource":
				{
					value = UnderlyingUnitOfMeasureCurrencyCodeSource;
					break;
				}
				case "UnderlyingPriceUnitOfMeasure":
				{
					value = UnderlyingPriceUnitOfMeasure;
					break;
				}
				case "UnderlyingPriceUnitOfMeasureQty":
				{
					value = UnderlyingPriceUnitOfMeasureQty;
					break;
				}
				case "UnderlyingPriceUnitOfMeasureCurrency":
				{
					value = UnderlyingPriceUnitOfMeasureCurrency;
					break;
				}
				case "UnderlyingPriceUnitOfMeasureCurrencyCodeSource":
				{
					value = UnderlyingPriceUnitOfMeasureCurrencyCodeSource;
					break;
				}
				case "UnderlyingTimeUnit":
				{
					value = UnderlyingTimeUnit;
					break;
				}
				case "UnderlyingExerciseStyle":
				{
					value = UnderlyingExerciseStyle;
					break;
				}
				case "UnderlyingPriceQuoteCurrency":
				{
					value = UnderlyingPriceQuoteCurrency;
					break;
				}
				case "UnderlyingPriceQuoteCurrencyCodeSource":
				{
					value = UnderlyingPriceQuoteCurrencyCodeSource;
					break;
				}
				case "UnderlyingCouponRate":
				{
					value = UnderlyingCouponRate;
					break;
				}
				case "UnderlyingSecurityExchange":
				{
					value = UnderlyingSecurityExchange;
					break;
				}
				case "UnderlyingIssuer":
				{
					value = UnderlyingIssuer;
					break;
				}
				case "EncodedUnderlyingIssuerLen":
				{
					value = EncodedUnderlyingIssuerLen;
					break;
				}
				case "EncodedUnderlyingIssuer":
				{
					value = EncodedUnderlyingIssuer;
					break;
				}
				case "UnderlyingFinancialInstrumentShortName":
				{
					value = UnderlyingFinancialInstrumentShortName;
					break;
				}
				case "UnderlyingFinancialInstrumentFullName":
				{
					value = UnderlyingFinancialInstrumentFullName;
					break;
				}
				case "EncodedUnderlyingFinancialInstrumentFullNameLen":
				{
					value = EncodedUnderlyingFinancialInstrumentFullNameLen;
					break;
				}
				case "EncodedUnderlyingFinancialInstrumentFullName":
				{
					value = EncodedUnderlyingFinancialInstrumentFullName;
					break;
				}
				case "UnderlyingIndexCurveUnit":
				{
					value = UnderlyingIndexCurveUnit;
					break;
				}
				case "UnderlyingIndexCurvePeriod":
				{
					value = UnderlyingIndexCurvePeriod;
					break;
				}
				case "UnderlyingSecurityDesc":
				{
					value = UnderlyingSecurityDesc;
					break;
				}
				case "EncodedUnderlyingSecurityDescLen":
				{
					value = EncodedUnderlyingSecurityDescLen;
					break;
				}
				case "EncodedUnderlyingSecurityDesc":
				{
					value = EncodedUnderlyingSecurityDesc;
					break;
				}
				case "UnderlyingCPProgram":
				{
					value = UnderlyingCPProgram;
					break;
				}
				case "UnderlyingCPRegType":
				{
					value = UnderlyingCPRegType;
					break;
				}
				case "UnderlyingAllocationPercent":
				{
					value = UnderlyingAllocationPercent;
					break;
				}
				case "UnderlyingCurrency":
				{
					value = UnderlyingCurrency;
					break;
				}
				case "UnderlyingCurrencyCodeSource":
				{
					value = UnderlyingCurrencyCodeSource;
					break;
				}
				case "UnderlyingQty":
				{
					value = UnderlyingQty;
					break;
				}
				case "UnderlyingSettlementType":
				{
					value = UnderlyingSettlementType;
					break;
				}
				case "UnderlyingCashAmount":
				{
					value = UnderlyingCashAmount;
					break;
				}
				case "UnderlyingCashType":
				{
					value = UnderlyingCashType;
					break;
				}
				case "UnderlyingPx":
				{
					value = UnderlyingPx;
					break;
				}
				case "UnderlyingDirtyPrice":
				{
					value = UnderlyingDirtyPrice;
					break;
				}
				case "UnderlyingEndPrice":
				{
					value = UnderlyingEndPrice;
					break;
				}
				case "UnderlyingStartValue":
				{
					value = UnderlyingStartValue;
					break;
				}
				case "UnderlyingCurrentValue":
				{
					value = UnderlyingCurrentValue;
					break;
				}
				case "UnderlyingEndValue":
				{
					value = UnderlyingEndValue;
					break;
				}
				case "UnderlyingAccruedInterestAmt":
				{
					value = UnderlyingAccruedInterestAmt;
					break;
				}
				case "UnderlyingNumDaysInterest":
				{
					value = UnderlyingNumDaysInterest;
					break;
				}
				case "UnderlyingStipulations":
				{
					value = UnderlyingStipulations;
					break;
				}
				case "UnderlyingAdjustedQuantity":
				{
					value = UnderlyingAdjustedQuantity;
					break;
				}
				case "UnderlyingFXRate":
				{
					value = UnderlyingFXRate;
					break;
				}
				case "UnderlyingFXRateCalc":
				{
					value = UnderlyingFXRateCalc;
					break;
				}
				case "UnderlyingCapValue":
				{
					value = UnderlyingCapValue;
					break;
				}
				case "UndlyInstrumentParties":
				{
					value = UndlyInstrumentParties;
					break;
				}
				case "UnderlyingSettlMethod":
				{
					value = UnderlyingSettlMethod;
					break;
				}
				case "UnderlyingPutOrCall":
				{
					value = UnderlyingPutOrCall;
					break;
				}
				case "UnderlyingInTheMoneyCondition":
				{
					value = UnderlyingInTheMoneyCondition;
					break;
				}
				case "UnderlyingContraryInstructionEligibilityIndicator":
				{
					value = UnderlyingContraryInstructionEligibilityIndicator;
					break;
				}
				case "UnderlyingConstituentWeight":
				{
					value = UnderlyingConstituentWeight;
					break;
				}
				case "UnderlyingCouponType":
				{
					value = UnderlyingCouponType;
					break;
				}
				case "UnderlyingTotalIssuedAmount":
				{
					value = UnderlyingTotalIssuedAmount;
					break;
				}
				case "UnderlyingCouponFrequencyPeriod":
				{
					value = UnderlyingCouponFrequencyPeriod;
					break;
				}
				case "UnderlyingCouponFrequencyUnit":
				{
					value = UnderlyingCouponFrequencyUnit;
					break;
				}
				case "UnderlyingCouponDayCount":
				{
					value = UnderlyingCouponDayCount;
					break;
				}
				case "UnderlyingCouponOtherDayCount":
				{
					value = UnderlyingCouponOtherDayCount;
					break;
				}
				case "UnderlyingObligationID":
				{
					value = UnderlyingObligationID;
					break;
				}
				case "UnderlyingObligationIDSource":
				{
					value = UnderlyingObligationIDSource;
					break;
				}
				case "UnderlyingEquityID":
				{
					value = UnderlyingEquityID;
					break;
				}
				case "UnderlyingEquityIDSource":
				{
					value = UnderlyingEquityIDSource;
					break;
				}
				case "UnderlyingFutureID":
				{
					value = UnderlyingFutureID;
					break;
				}
				case "UnderlyingFutureIDSource":
				{
					value = UnderlyingFutureIDSource;
					break;
				}
				case "UnderlyingEvntGrp":
				{
					value = UnderlyingEvntGrp;
					break;
				}
				case "UnderlyingLienSeniority":
				{
					value = UnderlyingLienSeniority;
					break;
				}
				case "UnderlyingLoanFacility":
				{
					value = UnderlyingLoanFacility;
					break;
				}
				case "UnderlyingReferenceEntityType":
				{
					value = UnderlyingReferenceEntityType;
					break;
				}
				case "UnderlyingIndexSeries":
				{
					value = UnderlyingIndexSeries;
					break;
				}
				case "UnderlyingIndexAnnexVersion":
				{
					value = UnderlyingIndexAnnexVersion;
					break;
				}
				case "UnderlyingIndexAnnexDate":
				{
					value = UnderlyingIndexAnnexDate;
					break;
				}
				case "UnderlyingIndexAnnexSource":
				{
					value = UnderlyingIndexAnnexSource;
					break;
				}
				case "UnderlyingSettlRateIndex":
				{
					value = UnderlyingSettlRateIndex;
					break;
				}
				case "UnderlyingSettlRateIndexLocation":
				{
					value = UnderlyingSettlRateIndexLocation;
					break;
				}
				case "UnderlyingOptionExpirationDesc":
				{
					value = UnderlyingOptionExpirationDesc;
					break;
				}
				case "EncodedUnderlyingOptionExpirationDescLen":
				{
					value = EncodedUnderlyingOptionExpirationDescLen;
					break;
				}
				case "EncodedUnderlyingOptionExpirationDesc":
				{
					value = EncodedUnderlyingOptionExpirationDesc;
					break;
				}
				case "UnderlyingProductComplex":
				{
					value = UnderlyingProductComplex;
					break;
				}
				case "UnderlyingSecurityGroup":
				{
					value = UnderlyingSecurityGroup;
					break;
				}
				case "UnderlyingSettleOnOpenFlag":
				{
					value = UnderlyingSettleOnOpenFlag;
					break;
				}
				case "UnderlyingAssignmentMethod":
				{
					value = UnderlyingAssignmentMethod;
					break;
				}
				case "UnderlyingSecurityStatus":
				{
					value = UnderlyingSecurityStatus;
					break;
				}
				case "UnderlyingObligationType":
				{
					value = UnderlyingObligationType;
					break;
				}
				case "UnderlyingAssetGroup":
				{
					value = UnderlyingAssetGroup;
					break;
				}
				case "UnderlyingAssetClass":
				{
					value = UnderlyingAssetClass;
					break;
				}
				case "UnderlyingAssetSubClass":
				{
					value = UnderlyingAssetSubClass;
					break;
				}
				case "UnderlyingAssetType":
				{
					value = UnderlyingAssetType;
					break;
				}
				case "UnderlyingAssetSubType":
				{
					value = UnderlyingAssetSubType;
					break;
				}
				case "UnderlyingSecondaryAssetGrp":
				{
					value = UnderlyingSecondaryAssetGrp;
					break;
				}
				case "UnderlyingAssetAttributeGrp":
				{
					value = UnderlyingAssetAttributeGrp;
					break;
				}
				case "UnderlyingSwapClass":
				{
					value = UnderlyingSwapClass;
					break;
				}
				case "UnderlyingSwapSubClass":
				{
					value = UnderlyingSwapSubClass;
					break;
				}
				case "UnderlyingNthToDefault":
				{
					value = UnderlyingNthToDefault;
					break;
				}
				case "UnderlyingMthToDefault":
				{
					value = UnderlyingMthToDefault;
					break;
				}
				case "UnderlyingSettledEntityMatrixSource":
				{
					value = UnderlyingSettledEntityMatrixSource;
					break;
				}
				case "UnderlyingSettledEntityMatrixPublicationDate":
				{
					value = UnderlyingSettledEntityMatrixPublicationDate;
					break;
				}
				case "UnderlyingStrikeMultiplier":
				{
					value = UnderlyingStrikeMultiplier;
					break;
				}
				case "UnderlyingStrikeValue":
				{
					value = UnderlyingStrikeValue;
					break;
				}
				case "UnderlyingStrikeUnitOfMeasure":
				{
					value = UnderlyingStrikeUnitOfMeasure;
					break;
				}
				case "UnderlyingStrikeIndexCurvePoint":
				{
					value = UnderlyingStrikeIndexCurvePoint;
					break;
				}
				case "UnderlyingStrikeIndex":
				{
					value = UnderlyingStrikeIndex;
					break;
				}
				case "UnderlyingStrikeIndexQuote":
				{
					value = UnderlyingStrikeIndexQuote;
					break;
				}
				case "UnderlyingStrikeIndexSpread":
				{
					value = UnderlyingStrikeIndexSpread;
					break;
				}
				case "UnderlyingStrikePriceDeterminationMethod":
				{
					value = UnderlyingStrikePriceDeterminationMethod;
					break;
				}
				case "UnderlyingStrikePriceBoundaryMethod":
				{
					value = UnderlyingStrikePriceBoundaryMethod;
					break;
				}
				case "UnderlyingStrikePriceBoundaryPrecision":
				{
					value = UnderlyingStrikePriceBoundaryPrecision;
					break;
				}
				case "UnderlyingMinPriceIncrement":
				{
					value = UnderlyingMinPriceIncrement;
					break;
				}
				case "UnderlyingMinPriceIncrementAmount":
				{
					value = UnderlyingMinPriceIncrementAmount;
					break;
				}
				case "UnderlyingOptPayoutType":
				{
					value = UnderlyingOptPayoutType;
					break;
				}
				case "UnderlyingOptPayoutAmount":
				{
					value = UnderlyingOptPayoutAmount;
					break;
				}
				case "UnderlyingReturnTrigger":
				{
					value = UnderlyingReturnTrigger;
					break;
				}
				case "UnderlyingPriceQuoteMethod":
				{
					value = UnderlyingPriceQuoteMethod;
					break;
				}
				case "UnderlyingValuationMethod":
				{
					value = UnderlyingValuationMethod;
					break;
				}
				case "UnderlyingValuationSource":
				{
					value = UnderlyingValuationSource;
					break;
				}
				case "UnderlyingValuationReferenceModel":
				{
					value = UnderlyingValuationReferenceModel;
					break;
				}
				case "UnderlyingListMethod":
				{
					value = UnderlyingListMethod;
					break;
				}
				case "UnderlyingCapPrice":
				{
					value = UnderlyingCapPrice;
					break;
				}
				case "UnderlyingFloorPrice":
				{
					value = UnderlyingFloorPrice;
					break;
				}
				case "UnderlyingFlexibleIndicator":
				{
					value = UnderlyingFlexibleIndicator;
					break;
				}
				case "UnderlyingFlexProductEligibilityIndicator":
				{
					value = UnderlyingFlexProductEligibilityIndicator;
					break;
				}
				case "UnderlyingPositionLimit":
				{
					value = UnderlyingPositionLimit;
					break;
				}
				case "UnderlyingNTPositionLimit":
				{
					value = UnderlyingNTPositionLimit;
					break;
				}
				case "UnderlyingPool":
				{
					value = UnderlyingPool;
					break;
				}
				case "UnderlyingContractSettlMonth":
				{
					value = UnderlyingContractSettlMonth;
					break;
				}
				case "UnderlyingDatedDate":
				{
					value = UnderlyingDatedDate;
					break;
				}
				case "UnderlyingInterestAccrualDate":
				{
					value = UnderlyingInterestAccrualDate;
					break;
				}
				case "UnderlyingShortSaleRestriction":
				{
					value = UnderlyingShortSaleRestriction;
					break;
				}
				case "UnderlyingRefTickTableID":
				{
					value = UnderlyingRefTickTableID;
					break;
				}
				case "UnderlyingProtectionTermXIDRef":
				{
					value = UnderlyingProtectionTermXIDRef;
					break;
				}
				case "UnderlyingSettlTermXIDRef":
				{
					value = UnderlyingSettlTermXIDRef;
					break;
				}
				case "UnderlyingComplexEvents":
				{
					value = UnderlyingComplexEvents;
					break;
				}
				case "UnderlyingStrategyType":
				{
					value = UnderlyingStrategyType;
					break;
				}
				case "UnderlyingCommonPricingIndicator":
				{
					value = UnderlyingCommonPricingIndicator;
					break;
				}
				case "UnderlyingSettlDisruptionProvision":
				{
					value = UnderlyingSettlDisruptionProvision;
					break;
				}
				case "UnderlyingDeliveryRouteOrCharter":
				{
					value = UnderlyingDeliveryRouteOrCharter;
					break;
				}
				case "UnderlyingInstrumentRoundingDirection":
				{
					value = UnderlyingInstrumentRoundingDirection;
					break;
				}
				case "UnderlyingInstrumentRoundingPrecision":
				{
					value = UnderlyingInstrumentRoundingPrecision;
					break;
				}
				case "UnderlyingDateAdjustment":
				{
					value = UnderlyingDateAdjustment;
					break;
				}
				case "UnderlyingPricingDateTime":
				{
					value = UnderlyingPricingDateTime;
					break;
				}
				case "UnderlyingMarketDisruption":
				{
					value = UnderlyingMarketDisruption;
					break;
				}
				case "UnderlyingOptionExercise":
				{
					value = UnderlyingOptionExercise;
					break;
				}
				case "UnderlyingStreamGrp":
				{
					value = UnderlyingStreamGrp;
					break;
				}
				case "UnderlyingProvisionGrp":
				{
					value = UnderlyingProvisionGrp;
					break;
				}
				case "UnderlyingAdditionalTermGrp":
				{
					value = UnderlyingAdditionalTermGrp;
					break;
				}
				case "UnderlyingProtectionTermGrp":
				{
					value = UnderlyingProtectionTermGrp;
					break;
				}
				case "UnderlyingCashSettlTermGrp":
				{
					value = UnderlyingCashSettlTermGrp;
					break;
				}
				case "UnderlyingPhysicalSettlTermGrp":
				{
					value = UnderlyingPhysicalSettlTermGrp;
					break;
				}
				case "UnderlyingRateSpreadSchedule":
				{
					value = UnderlyingRateSpreadSchedule;
					break;
				}
				case "UnderlyingDividendPayout":
				{
					value = UnderlyingDividendPayout;
					break;
				}
				case "UnderlyingExtraordinaryEventGrp":
				{
					value = UnderlyingExtraordinaryEventGrp;
					break;
				}
				case "UnderlyingExtraordinaryEventAdjustmentMethod":
				{
					value = UnderlyingExtraordinaryEventAdjustmentMethod;
					break;
				}
				case "UnderlyingExchangeLookAlike":
				{
					value = UnderlyingExchangeLookAlike;
					break;
				}
				case "UnderlyingAverageVolumeLimitationPercentage":
				{
					value = UnderlyingAverageVolumeLimitationPercentage;
					break;
				}
				case "UnderlyingAverageVolumeLimitationPeriodDays":
				{
					value = UnderlyingAverageVolumeLimitationPeriodDays;
					break;
				}
				case "UnderlyingDepositoryReceiptIndicator":
				{
					value = UnderlyingDepositoryReceiptIndicator;
					break;
				}
				case "UnderlyingOpenUnits":
				{
					value = UnderlyingOpenUnits;
					break;
				}
				case "UnderlyingBasketDivisor":
				{
					value = UnderlyingBasketDivisor;
					break;
				}
				case "UnderlyingInstrumentXID":
				{
					value = UnderlyingInstrumentXID;
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
			UnderlyingSymbol = null;
			UnderlyingSymbolSfx = null;
			UnderlyingSecurityID = null;
			UnderlyingSecurityIDSource = null;
			((IFixReset?)UndSecAltIDGrp)?.Reset();
			UnderlyingID = null;
			UnderlyingProduct = null;
			((IFixReset?)UnderlyingSecurityXML)?.Reset();
			UnderlyingCFICode = null;
			UnderlyingUPICode = null;
			UnderlyingSecurityType = null;
			UnderlyingSecuritySubType = null;
			UnderlyingMaturityMonthYear = null;
			UnderlyingMaturityDate = null;
			UnderlyingMaturityTime = null;
			UnderlyingContractPriceRefMonth = null;
			UnderlyingCouponPaymentDate = null;
			UnderlyingRestructuringType = null;
			UnderlyingSeniority = null;
			UnderlyingNotional = null;
			UnderlyingNotionalCurrency = null;
			UnderlyingNotionalCurrencyCodeSource = null;
			UnderlyingNotionalDeterminationMethod = null;
			UnderlyingNotionalAdjustments = null;
			UnderlyingNotionalXIDRef = null;
			UnderlyingNotionalPercentageOutstanding = null;
			UnderlyingOriginalNotionalPercentageOutstanding = null;
			UnderlyingAttachmentPoint = null;
			UnderlyingDetachmentPoint = null;
			UnderlyingIssueDate = null;
			UnderlyingRepoCollateralSecurityType = null;
			UnderlyingRepurchaseTerm = null;
			UnderlyingRepurchaseRate = null;
			UnderlyingFactor = null;
			UnderlyingCreditRating = null;
			UnderlyingInstrRegistry = null;
			UnderlyingCountryOfIssue = null;
			UnderlyingStateOrProvinceOfIssue = null;
			UnderlyingLocaleOfIssue = null;
			UnderlyingRedemptionDate = null;
			UnderlyingStrikePrice = null;
			UnderlyingStrikeCurrency = null;
			UnderlyingStrikeCurrencyCodeSource = null;
			UnderlyingOptAttribute = null;
			UnderlyingContractMultiplier = null;
			UnderlyingContractMultiplierUnit = null;
			UnderlyingTradingUnitPeriodMultiplier = null;
			UnderlyingFlowScheduleType = null;
			UnderlyingUnitOfMeasure = null;
			UnderlyingUnitOfMeasureQty = null;
			UnderlyingUnitOfMeasureCurrency = null;
			UnderlyingUnitOfMeasureCurrencyCodeSource = null;
			UnderlyingPriceUnitOfMeasure = null;
			UnderlyingPriceUnitOfMeasureQty = null;
			UnderlyingPriceUnitOfMeasureCurrency = null;
			UnderlyingPriceUnitOfMeasureCurrencyCodeSource = null;
			UnderlyingTimeUnit = null;
			UnderlyingExerciseStyle = null;
			UnderlyingPriceQuoteCurrency = null;
			UnderlyingPriceQuoteCurrencyCodeSource = null;
			UnderlyingCouponRate = null;
			UnderlyingSecurityExchange = null;
			UnderlyingIssuer = null;
			EncodedUnderlyingIssuerLen = null;
			EncodedUnderlyingIssuer = null;
			UnderlyingFinancialInstrumentShortName = null;
			UnderlyingFinancialInstrumentFullName = null;
			EncodedUnderlyingFinancialInstrumentFullNameLen = null;
			EncodedUnderlyingFinancialInstrumentFullName = null;
			UnderlyingIndexCurveUnit = null;
			UnderlyingIndexCurvePeriod = null;
			UnderlyingSecurityDesc = null;
			EncodedUnderlyingSecurityDescLen = null;
			EncodedUnderlyingSecurityDesc = null;
			UnderlyingCPProgram = null;
			UnderlyingCPRegType = null;
			UnderlyingAllocationPercent = null;
			UnderlyingCurrency = null;
			UnderlyingCurrencyCodeSource = null;
			UnderlyingQty = null;
			UnderlyingSettlementType = null;
			UnderlyingCashAmount = null;
			UnderlyingCashType = null;
			UnderlyingPx = null;
			UnderlyingDirtyPrice = null;
			UnderlyingEndPrice = null;
			UnderlyingStartValue = null;
			UnderlyingCurrentValue = null;
			UnderlyingEndValue = null;
			UnderlyingAccruedInterestAmt = null;
			UnderlyingNumDaysInterest = null;
			((IFixReset?)UnderlyingStipulations)?.Reset();
			UnderlyingAdjustedQuantity = null;
			UnderlyingFXRate = null;
			UnderlyingFXRateCalc = null;
			UnderlyingCapValue = null;
			((IFixReset?)UndlyInstrumentParties)?.Reset();
			UnderlyingSettlMethod = null;
			UnderlyingPutOrCall = null;
			UnderlyingInTheMoneyCondition = null;
			UnderlyingContraryInstructionEligibilityIndicator = null;
			UnderlyingConstituentWeight = null;
			UnderlyingCouponType = null;
			UnderlyingTotalIssuedAmount = null;
			UnderlyingCouponFrequencyPeriod = null;
			UnderlyingCouponFrequencyUnit = null;
			UnderlyingCouponDayCount = null;
			UnderlyingCouponOtherDayCount = null;
			UnderlyingObligationID = null;
			UnderlyingObligationIDSource = null;
			UnderlyingEquityID = null;
			UnderlyingEquityIDSource = null;
			UnderlyingFutureID = null;
			UnderlyingFutureIDSource = null;
			((IFixReset?)UnderlyingEvntGrp)?.Reset();
			UnderlyingLienSeniority = null;
			UnderlyingLoanFacility = null;
			UnderlyingReferenceEntityType = null;
			UnderlyingIndexSeries = null;
			UnderlyingIndexAnnexVersion = null;
			UnderlyingIndexAnnexDate = null;
			UnderlyingIndexAnnexSource = null;
			UnderlyingSettlRateIndex = null;
			UnderlyingSettlRateIndexLocation = null;
			UnderlyingOptionExpirationDesc = null;
			EncodedUnderlyingOptionExpirationDescLen = null;
			EncodedUnderlyingOptionExpirationDesc = null;
			UnderlyingProductComplex = null;
			UnderlyingSecurityGroup = null;
			UnderlyingSettleOnOpenFlag = null;
			UnderlyingAssignmentMethod = null;
			UnderlyingSecurityStatus = null;
			UnderlyingObligationType = null;
			UnderlyingAssetGroup = null;
			UnderlyingAssetClass = null;
			UnderlyingAssetSubClass = null;
			UnderlyingAssetType = null;
			UnderlyingAssetSubType = null;
			((IFixReset?)UnderlyingSecondaryAssetGrp)?.Reset();
			((IFixReset?)UnderlyingAssetAttributeGrp)?.Reset();
			UnderlyingSwapClass = null;
			UnderlyingSwapSubClass = null;
			UnderlyingNthToDefault = null;
			UnderlyingMthToDefault = null;
			UnderlyingSettledEntityMatrixSource = null;
			UnderlyingSettledEntityMatrixPublicationDate = null;
			UnderlyingStrikeMultiplier = null;
			UnderlyingStrikeValue = null;
			UnderlyingStrikeUnitOfMeasure = null;
			UnderlyingStrikeIndexCurvePoint = null;
			UnderlyingStrikeIndex = null;
			UnderlyingStrikeIndexQuote = null;
			UnderlyingStrikeIndexSpread = null;
			UnderlyingStrikePriceDeterminationMethod = null;
			UnderlyingStrikePriceBoundaryMethod = null;
			UnderlyingStrikePriceBoundaryPrecision = null;
			UnderlyingMinPriceIncrement = null;
			UnderlyingMinPriceIncrementAmount = null;
			UnderlyingOptPayoutType = null;
			UnderlyingOptPayoutAmount = null;
			UnderlyingReturnTrigger = null;
			UnderlyingPriceQuoteMethod = null;
			UnderlyingValuationMethod = null;
			UnderlyingValuationSource = null;
			UnderlyingValuationReferenceModel = null;
			UnderlyingListMethod = null;
			UnderlyingCapPrice = null;
			UnderlyingFloorPrice = null;
			UnderlyingFlexibleIndicator = null;
			UnderlyingFlexProductEligibilityIndicator = null;
			UnderlyingPositionLimit = null;
			UnderlyingNTPositionLimit = null;
			UnderlyingPool = null;
			UnderlyingContractSettlMonth = null;
			UnderlyingDatedDate = null;
			UnderlyingInterestAccrualDate = null;
			UnderlyingShortSaleRestriction = null;
			UnderlyingRefTickTableID = null;
			UnderlyingProtectionTermXIDRef = null;
			UnderlyingSettlTermXIDRef = null;
			((IFixReset?)UnderlyingComplexEvents)?.Reset();
			UnderlyingStrategyType = null;
			UnderlyingCommonPricingIndicator = null;
			UnderlyingSettlDisruptionProvision = null;
			UnderlyingDeliveryRouteOrCharter = null;
			UnderlyingInstrumentRoundingDirection = null;
			UnderlyingInstrumentRoundingPrecision = null;
			((IFixReset?)UnderlyingDateAdjustment)?.Reset();
			((IFixReset?)UnderlyingPricingDateTime)?.Reset();
			((IFixReset?)UnderlyingMarketDisruption)?.Reset();
			((IFixReset?)UnderlyingOptionExercise)?.Reset();
			((IFixReset?)UnderlyingStreamGrp)?.Reset();
			((IFixReset?)UnderlyingProvisionGrp)?.Reset();
			((IFixReset?)UnderlyingAdditionalTermGrp)?.Reset();
			((IFixReset?)UnderlyingProtectionTermGrp)?.Reset();
			((IFixReset?)UnderlyingCashSettlTermGrp)?.Reset();
			((IFixReset?)UnderlyingPhysicalSettlTermGrp)?.Reset();
			((IFixReset?)UnderlyingRateSpreadSchedule)?.Reset();
			((IFixReset?)UnderlyingDividendPayout)?.Reset();
			((IFixReset?)UnderlyingExtraordinaryEventGrp)?.Reset();
			UnderlyingExtraordinaryEventAdjustmentMethod = null;
			UnderlyingExchangeLookAlike = null;
			UnderlyingAverageVolumeLimitationPercentage = null;
			UnderlyingAverageVolumeLimitationPeriodDays = null;
			UnderlyingDepositoryReceiptIndicator = null;
			UnderlyingOpenUnits = null;
			UnderlyingBasketDivisor = null;
			UnderlyingInstrumentXID = null;
		}
	}
}
