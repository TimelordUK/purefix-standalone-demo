using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStreamFloatingRate : IFixComponent
	{
		[TagDetails(Tag = 40620, Type = TagType.String, Offset = 0, Required = false)]
		public string? UnderlyingPaymentStreamRateIndex {get; set;}
		
		[TagDetails(Tag = 40621, Type = TagType.Int, Offset = 1, Required = false)]
		public int? UnderlyingPaymentStreamRateIndexSource {get; set;}
		
		[TagDetails(Tag = 43092, Type = TagType.String, Offset = 2, Required = false)]
		public string? UnderlyingPaymentStreamRateIndexID {get; set;}
		
		[TagDetails(Tag = 43093, Type = TagType.String, Offset = 3, Required = false)]
		public string? UnderlyingPaymentStreamRateIndexIDSource {get; set;}
		
		[TagDetails(Tag = 40622, Type = TagType.String, Offset = 4, Required = false)]
		public string? UnderlyingPaymentStreamRateIndexCurveUnit {get; set;}
		
		[TagDetails(Tag = 40623, Type = TagType.Int, Offset = 5, Required = false)]
		public int? UnderlyingPaymentStreamRateIndexCurvePeriod {get; set;}
		
		[TagDetails(Tag = 43120, Type = TagType.String, Offset = 6, Required = false)]
		public string? UnderlyingPaymentStreamRateIndex2 {get; set;}
		
		[TagDetails(Tag = 43121, Type = TagType.Int, Offset = 7, Required = false)]
		public int? UnderlyingPaymentStreamRateIndex2Source {get; set;}
		
		[TagDetails(Tag = 43122, Type = TagType.String, Offset = 8, Required = false)]
		public string? UnderlyingPaymentStreamRateIndex2ID {get; set;}
		
		[TagDetails(Tag = 43123, Type = TagType.String, Offset = 9, Required = false)]
		public string? UnderlyingPaymentStreamRateIndex2IDSource {get; set;}
		
		[TagDetails(Tag = 41911, Type = TagType.String, Offset = 10, Required = false)]
		public string? UnderlyingPaymentStreamRateIndex2CurveUnit {get; set;}
		
		[TagDetails(Tag = 41912, Type = TagType.Int, Offset = 11, Required = false)]
		public int? UnderlyingPaymentStreamRateIndex2CurvePeriod {get; set;}
		
		[TagDetails(Tag = 41913, Type = TagType.String, Offset = 12, Required = false)]
		public string? UnderlyingPaymentStreamRateIndexLocation {get; set;}
		
		[TagDetails(Tag = 41914, Type = TagType.Float, Offset = 13, Required = false)]
		public double? UnderlyingPaymentStreamRateIndexLevel {get; set;}
		
		[TagDetails(Tag = 41915, Type = TagType.String, Offset = 14, Required = false)]
		public string? UnderlyingPaymentStreamRateIndexUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 41916, Type = TagType.Int, Offset = 15, Required = false)]
		public int? UnderlyingPaymentStreamSettlLevel {get; set;}
		
		[TagDetails(Tag = 41917, Type = TagType.Float, Offset = 16, Required = false)]
		public double? UnderlyingPaymentStreamReferenceLevel {get; set;}
		
		[TagDetails(Tag = 41918, Type = TagType.String, Offset = 17, Required = false)]
		public string? UnderlyingPaymentStreamReferenceLevelUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 41919, Type = TagType.Boolean, Offset = 18, Required = false)]
		public bool? UnderlyingPaymentStreamReferenceLevelEqualsZeroIndicator {get; set;}
		
		[TagDetails(Tag = 40624, Type = TagType.Float, Offset = 19, Required = false)]
		public double? UnderlyingPaymentStreamRateMultiplier {get; set;}
		
		[TagDetails(Tag = 40625, Type = TagType.Float, Offset = 20, Required = false)]
		public double? UnderlyingPaymentStreamRateSpread {get; set;}
		
		[TagDetails(Tag = 41920, Type = TagType.String, Offset = 21, Required = false)]
		public string? UnderlyingPaymentStreamRateSpreadCurrency {get; set;}
		
		[TagDetails(Tag = 41921, Type = TagType.String, Offset = 22, Required = false)]
		public string? UnderlyingPaymentStreamRateSpreadUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 41922, Type = TagType.Float, Offset = 23, Required = false)]
		public double? UnderlyingPaymentStreamRateConversionFactor {get; set;}
		
		[TagDetails(Tag = 41923, Type = TagType.Int, Offset = 24, Required = false)]
		public int? UnderlyingPaymentStreamRateSpreadType {get; set;}
		
		[TagDetails(Tag = 40626, Type = TagType.Int, Offset = 25, Required = false)]
		public int? UnderlyingPaymentStreamRateSpreadPositionType {get; set;}
		
		[TagDetails(Tag = 40627, Type = TagType.Int, Offset = 26, Required = false)]
		public int? UnderlyingPaymentStreamRateTreatment {get; set;}
		
		[TagDetails(Tag = 40628, Type = TagType.Float, Offset = 27, Required = false)]
		public double? UnderlyingPaymentStreamCapRate {get; set;}
		
		[TagDetails(Tag = 40629, Type = TagType.Int, Offset = 28, Required = false)]
		public int? UnderlyingPaymentStreamCapRateBuySide {get; set;}
		
		[TagDetails(Tag = 40630, Type = TagType.Int, Offset = 29, Required = false)]
		public int? UnderlyingPaymentStreamCapRateSellSide {get; set;}
		
		[TagDetails(Tag = 40631, Type = TagType.Float, Offset = 30, Required = false)]
		public double? UnderlyingPaymentStreamFloorRate {get; set;}
		
		[TagDetails(Tag = 40632, Type = TagType.Int, Offset = 31, Required = false)]
		public int? UnderlyingPaymentStreamFloorRateBuySide {get; set;}
		
		[TagDetails(Tag = 40633, Type = TagType.Int, Offset = 32, Required = false)]
		public int? UnderlyingPaymentStreamFloorRateSellSide {get; set;}
		
		[TagDetails(Tag = 40634, Type = TagType.Float, Offset = 33, Required = false)]
		public double? UnderlyingPaymentStreamInitialRate {get; set;}
		
		[TagDetails(Tag = 41924, Type = TagType.Float, Offset = 34, Required = false)]
		public double? UnderlyingPaymentStreamLastResetRate {get; set;}
		
		[TagDetails(Tag = 41925, Type = TagType.Float, Offset = 35, Required = false)]
		public double? UnderlyingPaymentStreamFinalRate {get; set;}
		
		[TagDetails(Tag = 40635, Type = TagType.String, Offset = 36, Required = false)]
		public string? UnderlyingPaymentStreamFinalRateRoundingDirection {get; set;}
		
		[TagDetails(Tag = 40636, Type = TagType.Int, Offset = 37, Required = false)]
		public int? UnderlyingPaymentStreamFinalRatePrecision {get; set;}
		
		[TagDetails(Tag = 40637, Type = TagType.Int, Offset = 38, Required = false)]
		public int? UnderlyingPaymentStreamAveragingMethod {get; set;}
		
		[TagDetails(Tag = 40638, Type = TagType.Int, Offset = 39, Required = false)]
		public int? UnderlyingPaymentStreamNegativeRateTreatment {get; set;}
		
		[TagDetails(Tag = 41926, Type = TagType.Int, Offset = 40, Required = false)]
		public int? UnderlyingPaymentStreamCalculationLagPeriod {get; set;}
		
		[TagDetails(Tag = 41927, Type = TagType.String, Offset = 41, Required = false)]
		public string? UnderlyingPaymentStreamCalculationLagUnit {get; set;}
		
		[TagDetails(Tag = 42958, Type = TagType.LocalDate, Offset = 42, Required = false)]
		public DateOnly? UnderlyingPaymentStreamFirstObservationDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42959, Type = TagType.Int, Offset = 43, Required = false)]
		public int? UnderlyingPaymentStreamFirstObservationDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42960, Type = TagType.Int, Offset = 44, Required = false)]
		public int? UnderlyingPaymentStreamFirstObservationDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 41928, Type = TagType.Int, Offset = 45, Required = false)]
		public int? UnderlyingPaymentStreamFirstObservationDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 41929, Type = TagType.String, Offset = 46, Required = false)]
		public string? UnderlyingPaymentStreamFirstObservationDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42961, Type = TagType.LocalDate, Offset = 47, Required = false)]
		public DateOnly? UnderlyingPaymentStreamFirstObservationDateAdjusted {get; set;}
		
		[TagDetails(Tag = 41930, Type = TagType.Int, Offset = 48, Required = false)]
		public int? UnderlyingPaymentStreamPricingDayType {get; set;}
		
		[TagDetails(Tag = 41931, Type = TagType.Int, Offset = 49, Required = false)]
		public int? UnderlyingPaymentStreamPricingDayDistribution {get; set;}
		
		[TagDetails(Tag = 41932, Type = TagType.Int, Offset = 50, Required = false)]
		public int? UnderlyingPaymentStreamPricingDayCount {get; set;}
		
		[TagDetails(Tag = 41933, Type = TagType.String, Offset = 51, Required = false)]
		public string? UnderlyingPaymentStreamPricingBusinessCalendar {get; set;}
		
		[TagDetails(Tag = 41934, Type = TagType.Int, Offset = 52, Required = false)]
		public int? UnderlyingPaymentStreamPricingBusinessDayConvention {get; set;}
		
		[Component(Offset = 53, Required = false)]
		public UnderlyingPaymentStreamPricingBusinessCenterGrp? UnderlyingPaymentStreamPricingBusinessCenterGrp {get; set;}
		
		[Component(Offset = 54, Required = false)]
		public UnderlyingPaymentStreamPricingDayGrp? UnderlyingPaymentStreamPricingDayGrp {get; set;}
		
		[Component(Offset = 55, Required = false)]
		public UnderlyingPaymentStreamPricingDateGrp? UnderlyingPaymentStreamPricingDateGrp {get; set;}
		
		[TagDetails(Tag = 40639, Type = TagType.Int, Offset = 56, Required = false)]
		public int? UnderlyingPaymentStreamInflationLagPeriod {get; set;}
		
		[TagDetails(Tag = 40640, Type = TagType.String, Offset = 57, Required = false)]
		public string? UnderlyingPaymentStreamInflationLagUnit {get; set;}
		
		[TagDetails(Tag = 40641, Type = TagType.Int, Offset = 58, Required = false)]
		public int? UnderlyingPaymentStreamInflationLagDayType {get; set;}
		
		[TagDetails(Tag = 40642, Type = TagType.Int, Offset = 59, Required = false)]
		public int? UnderlyingPaymentStreamInflationInterpolationMethod {get; set;}
		
		[TagDetails(Tag = 40643, Type = TagType.Int, Offset = 60, Required = false)]
		public int? UnderlyingPaymentStreamInflationIndexSource {get; set;}
		
		[TagDetails(Tag = 40644, Type = TagType.String, Offset = 61, Required = false)]
		public string? UnderlyingPaymentStreamInflationPublicationSource {get; set;}
		
		[TagDetails(Tag = 40645, Type = TagType.Float, Offset = 62, Required = false)]
		public double? UnderlyingPaymentStreamInflationInitialIndexLevel {get; set;}
		
		[TagDetails(Tag = 40646, Type = TagType.Boolean, Offset = 63, Required = false)]
		public bool? UnderlyingPaymentStreamInflationFallbackBondApplicable {get; set;}
		
		[TagDetails(Tag = 40647, Type = TagType.Int, Offset = 64, Required = false)]
		public int? UnderlyingPaymentStreamFRADiscounting {get; set;}
		
		[TagDetails(Tag = 42962, Type = TagType.String, Offset = 65, Required = false)]
		public string? UnderlyingPaymentStreamUnderlierRefID {get; set;}
		
		[Component(Offset = 66, Required = false)]
		public UnderlyingPaymentStreamFormula? UnderlyingPaymentStreamFormula {get; set;}
		
		[Component(Offset = 67, Required = false)]
		public UnderlyingDividendConditions? UnderlyingDividendConditions {get; set;}
		
		[TagDetails(Tag = 42963, Type = TagType.Boolean, Offset = 68, Required = false)]
		public bool? UnderlyingReturnRateNotionalReset {get; set;}
		
		[Component(Offset = 69, Required = false)]
		public UnderlyingReturnRateGrp? UnderlyingReturnRateGrp {get; set;}
		
		[TagDetails(Tag = 42964, Type = TagType.Float, Offset = 70, Required = false)]
		public double? UnderlyingPaymentStreamLinkInitialLevel {get; set;}
		
		[TagDetails(Tag = 42965, Type = TagType.Boolean, Offset = 71, Required = false)]
		public bool? UnderlyingPaymentStreamLinkClosingLevelIndicator {get; set;}
		
		[TagDetails(Tag = 42966, Type = TagType.Boolean, Offset = 72, Required = false)]
		public bool? UnderlyingPaymentStreamLinkExpiringLevelIndicator {get; set;}
		
		[TagDetails(Tag = 42967, Type = TagType.Int, Offset = 73, Required = false)]
		public int? UnderlyingPaymentStreamLinkEstimatedTradingDays {get; set;}
		
		[TagDetails(Tag = 42968, Type = TagType.Float, Offset = 74, Required = false)]
		public double? UnderlyingPaymentStreamLinkStrikePrice {get; set;}
		
		[TagDetails(Tag = 42969, Type = TagType.Int, Offset = 75, Required = false)]
		public int? UnderlyingPaymentStreamLinkStrikePriceType {get; set;}
		
		[TagDetails(Tag = 42970, Type = TagType.Float, Offset = 76, Required = false)]
		public double? UnderlyingPaymentStreamLinkMaximumBoundary {get; set;}
		
		[TagDetails(Tag = 42971, Type = TagType.Float, Offset = 77, Required = false)]
		public double? UnderlyingPaymentStreamLinkMinimumBoundary {get; set;}
		
		[TagDetails(Tag = 42972, Type = TagType.Int, Offset = 78, Required = false)]
		public int? UnderlyingPaymentStreamLinkNumberOfDataSeries {get; set;}
		
		[TagDetails(Tag = 42973, Type = TagType.Float, Offset = 79, Required = false)]
		public double? UnderlyingPaymentStreamVarianceUnadjustedCap {get; set;}
		
		[TagDetails(Tag = 42974, Type = TagType.Int, Offset = 80, Required = false)]
		public int? UnderlyingPaymentStreamRealizedVarianceMethod {get; set;}
		
		[TagDetails(Tag = 42975, Type = TagType.Boolean, Offset = 81, Required = false)]
		public bool? UnderlyingPaymentStreamDaysAdjustmentIndicator {get; set;}
		
		[TagDetails(Tag = 42976, Type = TagType.String, Offset = 82, Required = false)]
		public string? UnderlyingPaymentStreamNearestExchangeContractRefID {get; set;}
		
		[TagDetails(Tag = 42977, Type = TagType.Float, Offset = 83, Required = false)]
		public double? UnderlyingPaymentStreamVegaNotionalAmount {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStreamRateIndex is not null) writer.WriteString(40620, UnderlyingPaymentStreamRateIndex);
			if (UnderlyingPaymentStreamRateIndexSource is not null) writer.WriteWholeNumber(40621, UnderlyingPaymentStreamRateIndexSource.Value);
			if (UnderlyingPaymentStreamRateIndexID is not null) writer.WriteString(43092, UnderlyingPaymentStreamRateIndexID);
			if (UnderlyingPaymentStreamRateIndexIDSource is not null) writer.WriteString(43093, UnderlyingPaymentStreamRateIndexIDSource);
			if (UnderlyingPaymentStreamRateIndexCurveUnit is not null) writer.WriteString(40622, UnderlyingPaymentStreamRateIndexCurveUnit);
			if (UnderlyingPaymentStreamRateIndexCurvePeriod is not null) writer.WriteWholeNumber(40623, UnderlyingPaymentStreamRateIndexCurvePeriod.Value);
			if (UnderlyingPaymentStreamRateIndex2 is not null) writer.WriteString(43120, UnderlyingPaymentStreamRateIndex2);
			if (UnderlyingPaymentStreamRateIndex2Source is not null) writer.WriteWholeNumber(43121, UnderlyingPaymentStreamRateIndex2Source.Value);
			if (UnderlyingPaymentStreamRateIndex2ID is not null) writer.WriteString(43122, UnderlyingPaymentStreamRateIndex2ID);
			if (UnderlyingPaymentStreamRateIndex2IDSource is not null) writer.WriteString(43123, UnderlyingPaymentStreamRateIndex2IDSource);
			if (UnderlyingPaymentStreamRateIndex2CurveUnit is not null) writer.WriteString(41911, UnderlyingPaymentStreamRateIndex2CurveUnit);
			if (UnderlyingPaymentStreamRateIndex2CurvePeriod is not null) writer.WriteWholeNumber(41912, UnderlyingPaymentStreamRateIndex2CurvePeriod.Value);
			if (UnderlyingPaymentStreamRateIndexLocation is not null) writer.WriteString(41913, UnderlyingPaymentStreamRateIndexLocation);
			if (UnderlyingPaymentStreamRateIndexLevel is not null) writer.WriteNumber(41914, UnderlyingPaymentStreamRateIndexLevel.Value);
			if (UnderlyingPaymentStreamRateIndexUnitOfMeasure is not null) writer.WriteString(41915, UnderlyingPaymentStreamRateIndexUnitOfMeasure);
			if (UnderlyingPaymentStreamSettlLevel is not null) writer.WriteWholeNumber(41916, UnderlyingPaymentStreamSettlLevel.Value);
			if (UnderlyingPaymentStreamReferenceLevel is not null) writer.WriteNumber(41917, UnderlyingPaymentStreamReferenceLevel.Value);
			if (UnderlyingPaymentStreamReferenceLevelUnitOfMeasure is not null) writer.WriteString(41918, UnderlyingPaymentStreamReferenceLevelUnitOfMeasure);
			if (UnderlyingPaymentStreamReferenceLevelEqualsZeroIndicator is not null) writer.WriteBoolean(41919, UnderlyingPaymentStreamReferenceLevelEqualsZeroIndicator.Value);
			if (UnderlyingPaymentStreamRateMultiplier is not null) writer.WriteNumber(40624, UnderlyingPaymentStreamRateMultiplier.Value);
			if (UnderlyingPaymentStreamRateSpread is not null) writer.WriteNumber(40625, UnderlyingPaymentStreamRateSpread.Value);
			if (UnderlyingPaymentStreamRateSpreadCurrency is not null) writer.WriteString(41920, UnderlyingPaymentStreamRateSpreadCurrency);
			if (UnderlyingPaymentStreamRateSpreadUnitOfMeasure is not null) writer.WriteString(41921, UnderlyingPaymentStreamRateSpreadUnitOfMeasure);
			if (UnderlyingPaymentStreamRateConversionFactor is not null) writer.WriteNumber(41922, UnderlyingPaymentStreamRateConversionFactor.Value);
			if (UnderlyingPaymentStreamRateSpreadType is not null) writer.WriteWholeNumber(41923, UnderlyingPaymentStreamRateSpreadType.Value);
			if (UnderlyingPaymentStreamRateSpreadPositionType is not null) writer.WriteWholeNumber(40626, UnderlyingPaymentStreamRateSpreadPositionType.Value);
			if (UnderlyingPaymentStreamRateTreatment is not null) writer.WriteWholeNumber(40627, UnderlyingPaymentStreamRateTreatment.Value);
			if (UnderlyingPaymentStreamCapRate is not null) writer.WriteNumber(40628, UnderlyingPaymentStreamCapRate.Value);
			if (UnderlyingPaymentStreamCapRateBuySide is not null) writer.WriteWholeNumber(40629, UnderlyingPaymentStreamCapRateBuySide.Value);
			if (UnderlyingPaymentStreamCapRateSellSide is not null) writer.WriteWholeNumber(40630, UnderlyingPaymentStreamCapRateSellSide.Value);
			if (UnderlyingPaymentStreamFloorRate is not null) writer.WriteNumber(40631, UnderlyingPaymentStreamFloorRate.Value);
			if (UnderlyingPaymentStreamFloorRateBuySide is not null) writer.WriteWholeNumber(40632, UnderlyingPaymentStreamFloorRateBuySide.Value);
			if (UnderlyingPaymentStreamFloorRateSellSide is not null) writer.WriteWholeNumber(40633, UnderlyingPaymentStreamFloorRateSellSide.Value);
			if (UnderlyingPaymentStreamInitialRate is not null) writer.WriteNumber(40634, UnderlyingPaymentStreamInitialRate.Value);
			if (UnderlyingPaymentStreamLastResetRate is not null) writer.WriteNumber(41924, UnderlyingPaymentStreamLastResetRate.Value);
			if (UnderlyingPaymentStreamFinalRate is not null) writer.WriteNumber(41925, UnderlyingPaymentStreamFinalRate.Value);
			if (UnderlyingPaymentStreamFinalRateRoundingDirection is not null) writer.WriteString(40635, UnderlyingPaymentStreamFinalRateRoundingDirection);
			if (UnderlyingPaymentStreamFinalRatePrecision is not null) writer.WriteWholeNumber(40636, UnderlyingPaymentStreamFinalRatePrecision.Value);
			if (UnderlyingPaymentStreamAveragingMethod is not null) writer.WriteWholeNumber(40637, UnderlyingPaymentStreamAveragingMethod.Value);
			if (UnderlyingPaymentStreamNegativeRateTreatment is not null) writer.WriteWholeNumber(40638, UnderlyingPaymentStreamNegativeRateTreatment.Value);
			if (UnderlyingPaymentStreamCalculationLagPeriod is not null) writer.WriteWholeNumber(41926, UnderlyingPaymentStreamCalculationLagPeriod.Value);
			if (UnderlyingPaymentStreamCalculationLagUnit is not null) writer.WriteString(41927, UnderlyingPaymentStreamCalculationLagUnit);
			if (UnderlyingPaymentStreamFirstObservationDateUnadjusted is not null) writer.WriteLocalDateOnly(42958, UnderlyingPaymentStreamFirstObservationDateUnadjusted.Value);
			if (UnderlyingPaymentStreamFirstObservationDateRelativeTo is not null) writer.WriteWholeNumber(42959, UnderlyingPaymentStreamFirstObservationDateRelativeTo.Value);
			if (UnderlyingPaymentStreamFirstObservationDateOffsetDayType is not null) writer.WriteWholeNumber(42960, UnderlyingPaymentStreamFirstObservationDateOffsetDayType.Value);
			if (UnderlyingPaymentStreamFirstObservationDateOffsetPeriod is not null) writer.WriteWholeNumber(41928, UnderlyingPaymentStreamFirstObservationDateOffsetPeriod.Value);
			if (UnderlyingPaymentStreamFirstObservationDateOffsetUnit is not null) writer.WriteString(41929, UnderlyingPaymentStreamFirstObservationDateOffsetUnit);
			if (UnderlyingPaymentStreamFirstObservationDateAdjusted is not null) writer.WriteLocalDateOnly(42961, UnderlyingPaymentStreamFirstObservationDateAdjusted.Value);
			if (UnderlyingPaymentStreamPricingDayType is not null) writer.WriteWholeNumber(41930, UnderlyingPaymentStreamPricingDayType.Value);
			if (UnderlyingPaymentStreamPricingDayDistribution is not null) writer.WriteWholeNumber(41931, UnderlyingPaymentStreamPricingDayDistribution.Value);
			if (UnderlyingPaymentStreamPricingDayCount is not null) writer.WriteWholeNumber(41932, UnderlyingPaymentStreamPricingDayCount.Value);
			if (UnderlyingPaymentStreamPricingBusinessCalendar is not null) writer.WriteString(41933, UnderlyingPaymentStreamPricingBusinessCalendar);
			if (UnderlyingPaymentStreamPricingBusinessDayConvention is not null) writer.WriteWholeNumber(41934, UnderlyingPaymentStreamPricingBusinessDayConvention.Value);
			if (UnderlyingPaymentStreamPricingBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingPaymentStreamPricingBusinessCenterGrp).Encode(writer);
			if (UnderlyingPaymentStreamPricingDayGrp is not null) ((IFixEncoder)UnderlyingPaymentStreamPricingDayGrp).Encode(writer);
			if (UnderlyingPaymentStreamPricingDateGrp is not null) ((IFixEncoder)UnderlyingPaymentStreamPricingDateGrp).Encode(writer);
			if (UnderlyingPaymentStreamInflationLagPeriod is not null) writer.WriteWholeNumber(40639, UnderlyingPaymentStreamInflationLagPeriod.Value);
			if (UnderlyingPaymentStreamInflationLagUnit is not null) writer.WriteString(40640, UnderlyingPaymentStreamInflationLagUnit);
			if (UnderlyingPaymentStreamInflationLagDayType is not null) writer.WriteWholeNumber(40641, UnderlyingPaymentStreamInflationLagDayType.Value);
			if (UnderlyingPaymentStreamInflationInterpolationMethod is not null) writer.WriteWholeNumber(40642, UnderlyingPaymentStreamInflationInterpolationMethod.Value);
			if (UnderlyingPaymentStreamInflationIndexSource is not null) writer.WriteWholeNumber(40643, UnderlyingPaymentStreamInflationIndexSource.Value);
			if (UnderlyingPaymentStreamInflationPublicationSource is not null) writer.WriteString(40644, UnderlyingPaymentStreamInflationPublicationSource);
			if (UnderlyingPaymentStreamInflationInitialIndexLevel is not null) writer.WriteNumber(40645, UnderlyingPaymentStreamInflationInitialIndexLevel.Value);
			if (UnderlyingPaymentStreamInflationFallbackBondApplicable is not null) writer.WriteBoolean(40646, UnderlyingPaymentStreamInflationFallbackBondApplicable.Value);
			if (UnderlyingPaymentStreamFRADiscounting is not null) writer.WriteWholeNumber(40647, UnderlyingPaymentStreamFRADiscounting.Value);
			if (UnderlyingPaymentStreamUnderlierRefID is not null) writer.WriteString(42962, UnderlyingPaymentStreamUnderlierRefID);
			if (UnderlyingPaymentStreamFormula is not null) ((IFixEncoder)UnderlyingPaymentStreamFormula).Encode(writer);
			if (UnderlyingDividendConditions is not null) ((IFixEncoder)UnderlyingDividendConditions).Encode(writer);
			if (UnderlyingReturnRateNotionalReset is not null) writer.WriteBoolean(42963, UnderlyingReturnRateNotionalReset.Value);
			if (UnderlyingReturnRateGrp is not null) ((IFixEncoder)UnderlyingReturnRateGrp).Encode(writer);
			if (UnderlyingPaymentStreamLinkInitialLevel is not null) writer.WriteNumber(42964, UnderlyingPaymentStreamLinkInitialLevel.Value);
			if (UnderlyingPaymentStreamLinkClosingLevelIndicator is not null) writer.WriteBoolean(42965, UnderlyingPaymentStreamLinkClosingLevelIndicator.Value);
			if (UnderlyingPaymentStreamLinkExpiringLevelIndicator is not null) writer.WriteBoolean(42966, UnderlyingPaymentStreamLinkExpiringLevelIndicator.Value);
			if (UnderlyingPaymentStreamLinkEstimatedTradingDays is not null) writer.WriteWholeNumber(42967, UnderlyingPaymentStreamLinkEstimatedTradingDays.Value);
			if (UnderlyingPaymentStreamLinkStrikePrice is not null) writer.WriteNumber(42968, UnderlyingPaymentStreamLinkStrikePrice.Value);
			if (UnderlyingPaymentStreamLinkStrikePriceType is not null) writer.WriteWholeNumber(42969, UnderlyingPaymentStreamLinkStrikePriceType.Value);
			if (UnderlyingPaymentStreamLinkMaximumBoundary is not null) writer.WriteNumber(42970, UnderlyingPaymentStreamLinkMaximumBoundary.Value);
			if (UnderlyingPaymentStreamLinkMinimumBoundary is not null) writer.WriteNumber(42971, UnderlyingPaymentStreamLinkMinimumBoundary.Value);
			if (UnderlyingPaymentStreamLinkNumberOfDataSeries is not null) writer.WriteWholeNumber(42972, UnderlyingPaymentStreamLinkNumberOfDataSeries.Value);
			if (UnderlyingPaymentStreamVarianceUnadjustedCap is not null) writer.WriteNumber(42973, UnderlyingPaymentStreamVarianceUnadjustedCap.Value);
			if (UnderlyingPaymentStreamRealizedVarianceMethod is not null) writer.WriteWholeNumber(42974, UnderlyingPaymentStreamRealizedVarianceMethod.Value);
			if (UnderlyingPaymentStreamDaysAdjustmentIndicator is not null) writer.WriteBoolean(42975, UnderlyingPaymentStreamDaysAdjustmentIndicator.Value);
			if (UnderlyingPaymentStreamNearestExchangeContractRefID is not null) writer.WriteString(42976, UnderlyingPaymentStreamNearestExchangeContractRefID);
			if (UnderlyingPaymentStreamVegaNotionalAmount is not null) writer.WriteNumber(42977, UnderlyingPaymentStreamVegaNotionalAmount.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingPaymentStreamRateIndex = view.GetString(40620);
			UnderlyingPaymentStreamRateIndexSource = view.GetInt32(40621);
			UnderlyingPaymentStreamRateIndexID = view.GetString(43092);
			UnderlyingPaymentStreamRateIndexIDSource = view.GetString(43093);
			UnderlyingPaymentStreamRateIndexCurveUnit = view.GetString(40622);
			UnderlyingPaymentStreamRateIndexCurvePeriod = view.GetInt32(40623);
			UnderlyingPaymentStreamRateIndex2 = view.GetString(43120);
			UnderlyingPaymentStreamRateIndex2Source = view.GetInt32(43121);
			UnderlyingPaymentStreamRateIndex2ID = view.GetString(43122);
			UnderlyingPaymentStreamRateIndex2IDSource = view.GetString(43123);
			UnderlyingPaymentStreamRateIndex2CurveUnit = view.GetString(41911);
			UnderlyingPaymentStreamRateIndex2CurvePeriod = view.GetInt32(41912);
			UnderlyingPaymentStreamRateIndexLocation = view.GetString(41913);
			UnderlyingPaymentStreamRateIndexLevel = view.GetDouble(41914);
			UnderlyingPaymentStreamRateIndexUnitOfMeasure = view.GetString(41915);
			UnderlyingPaymentStreamSettlLevel = view.GetInt32(41916);
			UnderlyingPaymentStreamReferenceLevel = view.GetDouble(41917);
			UnderlyingPaymentStreamReferenceLevelUnitOfMeasure = view.GetString(41918);
			UnderlyingPaymentStreamReferenceLevelEqualsZeroIndicator = view.GetBool(41919);
			UnderlyingPaymentStreamRateMultiplier = view.GetDouble(40624);
			UnderlyingPaymentStreamRateSpread = view.GetDouble(40625);
			UnderlyingPaymentStreamRateSpreadCurrency = view.GetString(41920);
			UnderlyingPaymentStreamRateSpreadUnitOfMeasure = view.GetString(41921);
			UnderlyingPaymentStreamRateConversionFactor = view.GetDouble(41922);
			UnderlyingPaymentStreamRateSpreadType = view.GetInt32(41923);
			UnderlyingPaymentStreamRateSpreadPositionType = view.GetInt32(40626);
			UnderlyingPaymentStreamRateTreatment = view.GetInt32(40627);
			UnderlyingPaymentStreamCapRate = view.GetDouble(40628);
			UnderlyingPaymentStreamCapRateBuySide = view.GetInt32(40629);
			UnderlyingPaymentStreamCapRateSellSide = view.GetInt32(40630);
			UnderlyingPaymentStreamFloorRate = view.GetDouble(40631);
			UnderlyingPaymentStreamFloorRateBuySide = view.GetInt32(40632);
			UnderlyingPaymentStreamFloorRateSellSide = view.GetInt32(40633);
			UnderlyingPaymentStreamInitialRate = view.GetDouble(40634);
			UnderlyingPaymentStreamLastResetRate = view.GetDouble(41924);
			UnderlyingPaymentStreamFinalRate = view.GetDouble(41925);
			UnderlyingPaymentStreamFinalRateRoundingDirection = view.GetString(40635);
			UnderlyingPaymentStreamFinalRatePrecision = view.GetInt32(40636);
			UnderlyingPaymentStreamAveragingMethod = view.GetInt32(40637);
			UnderlyingPaymentStreamNegativeRateTreatment = view.GetInt32(40638);
			UnderlyingPaymentStreamCalculationLagPeriod = view.GetInt32(41926);
			UnderlyingPaymentStreamCalculationLagUnit = view.GetString(41927);
			UnderlyingPaymentStreamFirstObservationDateUnadjusted = view.GetDateOnly(42958);
			UnderlyingPaymentStreamFirstObservationDateRelativeTo = view.GetInt32(42959);
			UnderlyingPaymentStreamFirstObservationDateOffsetDayType = view.GetInt32(42960);
			UnderlyingPaymentStreamFirstObservationDateOffsetPeriod = view.GetInt32(41928);
			UnderlyingPaymentStreamFirstObservationDateOffsetUnit = view.GetString(41929);
			UnderlyingPaymentStreamFirstObservationDateAdjusted = view.GetDateOnly(42961);
			UnderlyingPaymentStreamPricingDayType = view.GetInt32(41930);
			UnderlyingPaymentStreamPricingDayDistribution = view.GetInt32(41931);
			UnderlyingPaymentStreamPricingDayCount = view.GetInt32(41932);
			UnderlyingPaymentStreamPricingBusinessCalendar = view.GetString(41933);
			UnderlyingPaymentStreamPricingBusinessDayConvention = view.GetInt32(41934);
			if (view.GetView("UnderlyingPaymentStreamPricingBusinessCenterGrp") is IMessageView viewUnderlyingPaymentStreamPricingBusinessCenterGrp)
			{
				UnderlyingPaymentStreamPricingBusinessCenterGrp = new();
				((IFixParser)UnderlyingPaymentStreamPricingBusinessCenterGrp).Parse(viewUnderlyingPaymentStreamPricingBusinessCenterGrp);
			}
			if (view.GetView("UnderlyingPaymentStreamPricingDayGrp") is IMessageView viewUnderlyingPaymentStreamPricingDayGrp)
			{
				UnderlyingPaymentStreamPricingDayGrp = new();
				((IFixParser)UnderlyingPaymentStreamPricingDayGrp).Parse(viewUnderlyingPaymentStreamPricingDayGrp);
			}
			if (view.GetView("UnderlyingPaymentStreamPricingDateGrp") is IMessageView viewUnderlyingPaymentStreamPricingDateGrp)
			{
				UnderlyingPaymentStreamPricingDateGrp = new();
				((IFixParser)UnderlyingPaymentStreamPricingDateGrp).Parse(viewUnderlyingPaymentStreamPricingDateGrp);
			}
			UnderlyingPaymentStreamInflationLagPeriod = view.GetInt32(40639);
			UnderlyingPaymentStreamInflationLagUnit = view.GetString(40640);
			UnderlyingPaymentStreamInflationLagDayType = view.GetInt32(40641);
			UnderlyingPaymentStreamInflationInterpolationMethod = view.GetInt32(40642);
			UnderlyingPaymentStreamInflationIndexSource = view.GetInt32(40643);
			UnderlyingPaymentStreamInflationPublicationSource = view.GetString(40644);
			UnderlyingPaymentStreamInflationInitialIndexLevel = view.GetDouble(40645);
			UnderlyingPaymentStreamInflationFallbackBondApplicable = view.GetBool(40646);
			UnderlyingPaymentStreamFRADiscounting = view.GetInt32(40647);
			UnderlyingPaymentStreamUnderlierRefID = view.GetString(42962);
			if (view.GetView("UnderlyingPaymentStreamFormula") is IMessageView viewUnderlyingPaymentStreamFormula)
			{
				UnderlyingPaymentStreamFormula = new();
				((IFixParser)UnderlyingPaymentStreamFormula).Parse(viewUnderlyingPaymentStreamFormula);
			}
			if (view.GetView("UnderlyingDividendConditions") is IMessageView viewUnderlyingDividendConditions)
			{
				UnderlyingDividendConditions = new();
				((IFixParser)UnderlyingDividendConditions).Parse(viewUnderlyingDividendConditions);
			}
			UnderlyingReturnRateNotionalReset = view.GetBool(42963);
			if (view.GetView("UnderlyingReturnRateGrp") is IMessageView viewUnderlyingReturnRateGrp)
			{
				UnderlyingReturnRateGrp = new();
				((IFixParser)UnderlyingReturnRateGrp).Parse(viewUnderlyingReturnRateGrp);
			}
			UnderlyingPaymentStreamLinkInitialLevel = view.GetDouble(42964);
			UnderlyingPaymentStreamLinkClosingLevelIndicator = view.GetBool(42965);
			UnderlyingPaymentStreamLinkExpiringLevelIndicator = view.GetBool(42966);
			UnderlyingPaymentStreamLinkEstimatedTradingDays = view.GetInt32(42967);
			UnderlyingPaymentStreamLinkStrikePrice = view.GetDouble(42968);
			UnderlyingPaymentStreamLinkStrikePriceType = view.GetInt32(42969);
			UnderlyingPaymentStreamLinkMaximumBoundary = view.GetDouble(42970);
			UnderlyingPaymentStreamLinkMinimumBoundary = view.GetDouble(42971);
			UnderlyingPaymentStreamLinkNumberOfDataSeries = view.GetInt32(42972);
			UnderlyingPaymentStreamVarianceUnadjustedCap = view.GetDouble(42973);
			UnderlyingPaymentStreamRealizedVarianceMethod = view.GetInt32(42974);
			UnderlyingPaymentStreamDaysAdjustmentIndicator = view.GetBool(42975);
			UnderlyingPaymentStreamNearestExchangeContractRefID = view.GetString(42976);
			UnderlyingPaymentStreamVegaNotionalAmount = view.GetDouble(42977);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingPaymentStreamRateIndex":
				{
					value = UnderlyingPaymentStreamRateIndex;
					break;
				}
				case "UnderlyingPaymentStreamRateIndexSource":
				{
					value = UnderlyingPaymentStreamRateIndexSource;
					break;
				}
				case "UnderlyingPaymentStreamRateIndexID":
				{
					value = UnderlyingPaymentStreamRateIndexID;
					break;
				}
				case "UnderlyingPaymentStreamRateIndexIDSource":
				{
					value = UnderlyingPaymentStreamRateIndexIDSource;
					break;
				}
				case "UnderlyingPaymentStreamRateIndexCurveUnit":
				{
					value = UnderlyingPaymentStreamRateIndexCurveUnit;
					break;
				}
				case "UnderlyingPaymentStreamRateIndexCurvePeriod":
				{
					value = UnderlyingPaymentStreamRateIndexCurvePeriod;
					break;
				}
				case "UnderlyingPaymentStreamRateIndex2":
				{
					value = UnderlyingPaymentStreamRateIndex2;
					break;
				}
				case "UnderlyingPaymentStreamRateIndex2Source":
				{
					value = UnderlyingPaymentStreamRateIndex2Source;
					break;
				}
				case "UnderlyingPaymentStreamRateIndex2ID":
				{
					value = UnderlyingPaymentStreamRateIndex2ID;
					break;
				}
				case "UnderlyingPaymentStreamRateIndex2IDSource":
				{
					value = UnderlyingPaymentStreamRateIndex2IDSource;
					break;
				}
				case "UnderlyingPaymentStreamRateIndex2CurveUnit":
				{
					value = UnderlyingPaymentStreamRateIndex2CurveUnit;
					break;
				}
				case "UnderlyingPaymentStreamRateIndex2CurvePeriod":
				{
					value = UnderlyingPaymentStreamRateIndex2CurvePeriod;
					break;
				}
				case "UnderlyingPaymentStreamRateIndexLocation":
				{
					value = UnderlyingPaymentStreamRateIndexLocation;
					break;
				}
				case "UnderlyingPaymentStreamRateIndexLevel":
				{
					value = UnderlyingPaymentStreamRateIndexLevel;
					break;
				}
				case "UnderlyingPaymentStreamRateIndexUnitOfMeasure":
				{
					value = UnderlyingPaymentStreamRateIndexUnitOfMeasure;
					break;
				}
				case "UnderlyingPaymentStreamSettlLevel":
				{
					value = UnderlyingPaymentStreamSettlLevel;
					break;
				}
				case "UnderlyingPaymentStreamReferenceLevel":
				{
					value = UnderlyingPaymentStreamReferenceLevel;
					break;
				}
				case "UnderlyingPaymentStreamReferenceLevelUnitOfMeasure":
				{
					value = UnderlyingPaymentStreamReferenceLevelUnitOfMeasure;
					break;
				}
				case "UnderlyingPaymentStreamReferenceLevelEqualsZeroIndicator":
				{
					value = UnderlyingPaymentStreamReferenceLevelEqualsZeroIndicator;
					break;
				}
				case "UnderlyingPaymentStreamRateMultiplier":
				{
					value = UnderlyingPaymentStreamRateMultiplier;
					break;
				}
				case "UnderlyingPaymentStreamRateSpread":
				{
					value = UnderlyingPaymentStreamRateSpread;
					break;
				}
				case "UnderlyingPaymentStreamRateSpreadCurrency":
				{
					value = UnderlyingPaymentStreamRateSpreadCurrency;
					break;
				}
				case "UnderlyingPaymentStreamRateSpreadUnitOfMeasure":
				{
					value = UnderlyingPaymentStreamRateSpreadUnitOfMeasure;
					break;
				}
				case "UnderlyingPaymentStreamRateConversionFactor":
				{
					value = UnderlyingPaymentStreamRateConversionFactor;
					break;
				}
				case "UnderlyingPaymentStreamRateSpreadType":
				{
					value = UnderlyingPaymentStreamRateSpreadType;
					break;
				}
				case "UnderlyingPaymentStreamRateSpreadPositionType":
				{
					value = UnderlyingPaymentStreamRateSpreadPositionType;
					break;
				}
				case "UnderlyingPaymentStreamRateTreatment":
				{
					value = UnderlyingPaymentStreamRateTreatment;
					break;
				}
				case "UnderlyingPaymentStreamCapRate":
				{
					value = UnderlyingPaymentStreamCapRate;
					break;
				}
				case "UnderlyingPaymentStreamCapRateBuySide":
				{
					value = UnderlyingPaymentStreamCapRateBuySide;
					break;
				}
				case "UnderlyingPaymentStreamCapRateSellSide":
				{
					value = UnderlyingPaymentStreamCapRateSellSide;
					break;
				}
				case "UnderlyingPaymentStreamFloorRate":
				{
					value = UnderlyingPaymentStreamFloorRate;
					break;
				}
				case "UnderlyingPaymentStreamFloorRateBuySide":
				{
					value = UnderlyingPaymentStreamFloorRateBuySide;
					break;
				}
				case "UnderlyingPaymentStreamFloorRateSellSide":
				{
					value = UnderlyingPaymentStreamFloorRateSellSide;
					break;
				}
				case "UnderlyingPaymentStreamInitialRate":
				{
					value = UnderlyingPaymentStreamInitialRate;
					break;
				}
				case "UnderlyingPaymentStreamLastResetRate":
				{
					value = UnderlyingPaymentStreamLastResetRate;
					break;
				}
				case "UnderlyingPaymentStreamFinalRate":
				{
					value = UnderlyingPaymentStreamFinalRate;
					break;
				}
				case "UnderlyingPaymentStreamFinalRateRoundingDirection":
				{
					value = UnderlyingPaymentStreamFinalRateRoundingDirection;
					break;
				}
				case "UnderlyingPaymentStreamFinalRatePrecision":
				{
					value = UnderlyingPaymentStreamFinalRatePrecision;
					break;
				}
				case "UnderlyingPaymentStreamAveragingMethod":
				{
					value = UnderlyingPaymentStreamAveragingMethod;
					break;
				}
				case "UnderlyingPaymentStreamNegativeRateTreatment":
				{
					value = UnderlyingPaymentStreamNegativeRateTreatment;
					break;
				}
				case "UnderlyingPaymentStreamCalculationLagPeriod":
				{
					value = UnderlyingPaymentStreamCalculationLagPeriod;
					break;
				}
				case "UnderlyingPaymentStreamCalculationLagUnit":
				{
					value = UnderlyingPaymentStreamCalculationLagUnit;
					break;
				}
				case "UnderlyingPaymentStreamFirstObservationDateUnadjusted":
				{
					value = UnderlyingPaymentStreamFirstObservationDateUnadjusted;
					break;
				}
				case "UnderlyingPaymentStreamFirstObservationDateRelativeTo":
				{
					value = UnderlyingPaymentStreamFirstObservationDateRelativeTo;
					break;
				}
				case "UnderlyingPaymentStreamFirstObservationDateOffsetDayType":
				{
					value = UnderlyingPaymentStreamFirstObservationDateOffsetDayType;
					break;
				}
				case "UnderlyingPaymentStreamFirstObservationDateOffsetPeriod":
				{
					value = UnderlyingPaymentStreamFirstObservationDateOffsetPeriod;
					break;
				}
				case "UnderlyingPaymentStreamFirstObservationDateOffsetUnit":
				{
					value = UnderlyingPaymentStreamFirstObservationDateOffsetUnit;
					break;
				}
				case "UnderlyingPaymentStreamFirstObservationDateAdjusted":
				{
					value = UnderlyingPaymentStreamFirstObservationDateAdjusted;
					break;
				}
				case "UnderlyingPaymentStreamPricingDayType":
				{
					value = UnderlyingPaymentStreamPricingDayType;
					break;
				}
				case "UnderlyingPaymentStreamPricingDayDistribution":
				{
					value = UnderlyingPaymentStreamPricingDayDistribution;
					break;
				}
				case "UnderlyingPaymentStreamPricingDayCount":
				{
					value = UnderlyingPaymentStreamPricingDayCount;
					break;
				}
				case "UnderlyingPaymentStreamPricingBusinessCalendar":
				{
					value = UnderlyingPaymentStreamPricingBusinessCalendar;
					break;
				}
				case "UnderlyingPaymentStreamPricingBusinessDayConvention":
				{
					value = UnderlyingPaymentStreamPricingBusinessDayConvention;
					break;
				}
				case "UnderlyingPaymentStreamPricingBusinessCenterGrp":
				{
					value = UnderlyingPaymentStreamPricingBusinessCenterGrp;
					break;
				}
				case "UnderlyingPaymentStreamPricingDayGrp":
				{
					value = UnderlyingPaymentStreamPricingDayGrp;
					break;
				}
				case "UnderlyingPaymentStreamPricingDateGrp":
				{
					value = UnderlyingPaymentStreamPricingDateGrp;
					break;
				}
				case "UnderlyingPaymentStreamInflationLagPeriod":
				{
					value = UnderlyingPaymentStreamInflationLagPeriod;
					break;
				}
				case "UnderlyingPaymentStreamInflationLagUnit":
				{
					value = UnderlyingPaymentStreamInflationLagUnit;
					break;
				}
				case "UnderlyingPaymentStreamInflationLagDayType":
				{
					value = UnderlyingPaymentStreamInflationLagDayType;
					break;
				}
				case "UnderlyingPaymentStreamInflationInterpolationMethod":
				{
					value = UnderlyingPaymentStreamInflationInterpolationMethod;
					break;
				}
				case "UnderlyingPaymentStreamInflationIndexSource":
				{
					value = UnderlyingPaymentStreamInflationIndexSource;
					break;
				}
				case "UnderlyingPaymentStreamInflationPublicationSource":
				{
					value = UnderlyingPaymentStreamInflationPublicationSource;
					break;
				}
				case "UnderlyingPaymentStreamInflationInitialIndexLevel":
				{
					value = UnderlyingPaymentStreamInflationInitialIndexLevel;
					break;
				}
				case "UnderlyingPaymentStreamInflationFallbackBondApplicable":
				{
					value = UnderlyingPaymentStreamInflationFallbackBondApplicable;
					break;
				}
				case "UnderlyingPaymentStreamFRADiscounting":
				{
					value = UnderlyingPaymentStreamFRADiscounting;
					break;
				}
				case "UnderlyingPaymentStreamUnderlierRefID":
				{
					value = UnderlyingPaymentStreamUnderlierRefID;
					break;
				}
				case "UnderlyingPaymentStreamFormula":
				{
					value = UnderlyingPaymentStreamFormula;
					break;
				}
				case "UnderlyingDividendConditions":
				{
					value = UnderlyingDividendConditions;
					break;
				}
				case "UnderlyingReturnRateNotionalReset":
				{
					value = UnderlyingReturnRateNotionalReset;
					break;
				}
				case "UnderlyingReturnRateGrp":
				{
					value = UnderlyingReturnRateGrp;
					break;
				}
				case "UnderlyingPaymentStreamLinkInitialLevel":
				{
					value = UnderlyingPaymentStreamLinkInitialLevel;
					break;
				}
				case "UnderlyingPaymentStreamLinkClosingLevelIndicator":
				{
					value = UnderlyingPaymentStreamLinkClosingLevelIndicator;
					break;
				}
				case "UnderlyingPaymentStreamLinkExpiringLevelIndicator":
				{
					value = UnderlyingPaymentStreamLinkExpiringLevelIndicator;
					break;
				}
				case "UnderlyingPaymentStreamLinkEstimatedTradingDays":
				{
					value = UnderlyingPaymentStreamLinkEstimatedTradingDays;
					break;
				}
				case "UnderlyingPaymentStreamLinkStrikePrice":
				{
					value = UnderlyingPaymentStreamLinkStrikePrice;
					break;
				}
				case "UnderlyingPaymentStreamLinkStrikePriceType":
				{
					value = UnderlyingPaymentStreamLinkStrikePriceType;
					break;
				}
				case "UnderlyingPaymentStreamLinkMaximumBoundary":
				{
					value = UnderlyingPaymentStreamLinkMaximumBoundary;
					break;
				}
				case "UnderlyingPaymentStreamLinkMinimumBoundary":
				{
					value = UnderlyingPaymentStreamLinkMinimumBoundary;
					break;
				}
				case "UnderlyingPaymentStreamLinkNumberOfDataSeries":
				{
					value = UnderlyingPaymentStreamLinkNumberOfDataSeries;
					break;
				}
				case "UnderlyingPaymentStreamVarianceUnadjustedCap":
				{
					value = UnderlyingPaymentStreamVarianceUnadjustedCap;
					break;
				}
				case "UnderlyingPaymentStreamRealizedVarianceMethod":
				{
					value = UnderlyingPaymentStreamRealizedVarianceMethod;
					break;
				}
				case "UnderlyingPaymentStreamDaysAdjustmentIndicator":
				{
					value = UnderlyingPaymentStreamDaysAdjustmentIndicator;
					break;
				}
				case "UnderlyingPaymentStreamNearestExchangeContractRefID":
				{
					value = UnderlyingPaymentStreamNearestExchangeContractRefID;
					break;
				}
				case "UnderlyingPaymentStreamVegaNotionalAmount":
				{
					value = UnderlyingPaymentStreamVegaNotionalAmount;
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
			UnderlyingPaymentStreamRateIndex = null;
			UnderlyingPaymentStreamRateIndexSource = null;
			UnderlyingPaymentStreamRateIndexID = null;
			UnderlyingPaymentStreamRateIndexIDSource = null;
			UnderlyingPaymentStreamRateIndexCurveUnit = null;
			UnderlyingPaymentStreamRateIndexCurvePeriod = null;
			UnderlyingPaymentStreamRateIndex2 = null;
			UnderlyingPaymentStreamRateIndex2Source = null;
			UnderlyingPaymentStreamRateIndex2ID = null;
			UnderlyingPaymentStreamRateIndex2IDSource = null;
			UnderlyingPaymentStreamRateIndex2CurveUnit = null;
			UnderlyingPaymentStreamRateIndex2CurvePeriod = null;
			UnderlyingPaymentStreamRateIndexLocation = null;
			UnderlyingPaymentStreamRateIndexLevel = null;
			UnderlyingPaymentStreamRateIndexUnitOfMeasure = null;
			UnderlyingPaymentStreamSettlLevel = null;
			UnderlyingPaymentStreamReferenceLevel = null;
			UnderlyingPaymentStreamReferenceLevelUnitOfMeasure = null;
			UnderlyingPaymentStreamReferenceLevelEqualsZeroIndicator = null;
			UnderlyingPaymentStreamRateMultiplier = null;
			UnderlyingPaymentStreamRateSpread = null;
			UnderlyingPaymentStreamRateSpreadCurrency = null;
			UnderlyingPaymentStreamRateSpreadUnitOfMeasure = null;
			UnderlyingPaymentStreamRateConversionFactor = null;
			UnderlyingPaymentStreamRateSpreadType = null;
			UnderlyingPaymentStreamRateSpreadPositionType = null;
			UnderlyingPaymentStreamRateTreatment = null;
			UnderlyingPaymentStreamCapRate = null;
			UnderlyingPaymentStreamCapRateBuySide = null;
			UnderlyingPaymentStreamCapRateSellSide = null;
			UnderlyingPaymentStreamFloorRate = null;
			UnderlyingPaymentStreamFloorRateBuySide = null;
			UnderlyingPaymentStreamFloorRateSellSide = null;
			UnderlyingPaymentStreamInitialRate = null;
			UnderlyingPaymentStreamLastResetRate = null;
			UnderlyingPaymentStreamFinalRate = null;
			UnderlyingPaymentStreamFinalRateRoundingDirection = null;
			UnderlyingPaymentStreamFinalRatePrecision = null;
			UnderlyingPaymentStreamAveragingMethod = null;
			UnderlyingPaymentStreamNegativeRateTreatment = null;
			UnderlyingPaymentStreamCalculationLagPeriod = null;
			UnderlyingPaymentStreamCalculationLagUnit = null;
			UnderlyingPaymentStreamFirstObservationDateUnadjusted = null;
			UnderlyingPaymentStreamFirstObservationDateRelativeTo = null;
			UnderlyingPaymentStreamFirstObservationDateOffsetDayType = null;
			UnderlyingPaymentStreamFirstObservationDateOffsetPeriod = null;
			UnderlyingPaymentStreamFirstObservationDateOffsetUnit = null;
			UnderlyingPaymentStreamFirstObservationDateAdjusted = null;
			UnderlyingPaymentStreamPricingDayType = null;
			UnderlyingPaymentStreamPricingDayDistribution = null;
			UnderlyingPaymentStreamPricingDayCount = null;
			UnderlyingPaymentStreamPricingBusinessCalendar = null;
			UnderlyingPaymentStreamPricingBusinessDayConvention = null;
			((IFixReset?)UnderlyingPaymentStreamPricingBusinessCenterGrp)?.Reset();
			((IFixReset?)UnderlyingPaymentStreamPricingDayGrp)?.Reset();
			((IFixReset?)UnderlyingPaymentStreamPricingDateGrp)?.Reset();
			UnderlyingPaymentStreamInflationLagPeriod = null;
			UnderlyingPaymentStreamInflationLagUnit = null;
			UnderlyingPaymentStreamInflationLagDayType = null;
			UnderlyingPaymentStreamInflationInterpolationMethod = null;
			UnderlyingPaymentStreamInflationIndexSource = null;
			UnderlyingPaymentStreamInflationPublicationSource = null;
			UnderlyingPaymentStreamInflationInitialIndexLevel = null;
			UnderlyingPaymentStreamInflationFallbackBondApplicable = null;
			UnderlyingPaymentStreamFRADiscounting = null;
			UnderlyingPaymentStreamUnderlierRefID = null;
			((IFixReset?)UnderlyingPaymentStreamFormula)?.Reset();
			((IFixReset?)UnderlyingDividendConditions)?.Reset();
			UnderlyingReturnRateNotionalReset = null;
			((IFixReset?)UnderlyingReturnRateGrp)?.Reset();
			UnderlyingPaymentStreamLinkInitialLevel = null;
			UnderlyingPaymentStreamLinkClosingLevelIndicator = null;
			UnderlyingPaymentStreamLinkExpiringLevelIndicator = null;
			UnderlyingPaymentStreamLinkEstimatedTradingDays = null;
			UnderlyingPaymentStreamLinkStrikePrice = null;
			UnderlyingPaymentStreamLinkStrikePriceType = null;
			UnderlyingPaymentStreamLinkMaximumBoundary = null;
			UnderlyingPaymentStreamLinkMinimumBoundary = null;
			UnderlyingPaymentStreamLinkNumberOfDataSeries = null;
			UnderlyingPaymentStreamVarianceUnadjustedCap = null;
			UnderlyingPaymentStreamRealizedVarianceMethod = null;
			UnderlyingPaymentStreamDaysAdjustmentIndicator = null;
			UnderlyingPaymentStreamNearestExchangeContractRefID = null;
			UnderlyingPaymentStreamVegaNotionalAmount = null;
		}
	}
}
