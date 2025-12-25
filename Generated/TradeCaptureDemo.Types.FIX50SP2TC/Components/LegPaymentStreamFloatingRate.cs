using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStreamFloatingRate : IFixComponent
	{
		[TagDetails(Tag = 40331, Type = TagType.String, Offset = 0, Required = false)]
		public string? LegPaymentStreamRateIndex {get; set;}
		
		[TagDetails(Tag = 40332, Type = TagType.Int, Offset = 1, Required = false)]
		public int? LegPaymentStreamRateIndexSource {get; set;}
		
		[TagDetails(Tag = 43088, Type = TagType.String, Offset = 2, Required = false)]
		public string? LegPaymentStreamRateIndexID {get; set;}
		
		[TagDetails(Tag = 43089, Type = TagType.String, Offset = 3, Required = false)]
		public string? LegPaymentStreamRateIndexIDSource {get; set;}
		
		[TagDetails(Tag = 40333, Type = TagType.String, Offset = 4, Required = false)]
		public string? LegPaymentStreamRateIndexCurveUnit {get; set;}
		
		[TagDetails(Tag = 40334, Type = TagType.Int, Offset = 5, Required = false)]
		public int? LegPaymentStreamRateIndexCurvePeriod {get; set;}
		
		[TagDetails(Tag = 43116, Type = TagType.String, Offset = 6, Required = false)]
		public string? LegPaymentStreamRateIndex2 {get; set;}
		
		[TagDetails(Tag = 43117, Type = TagType.Int, Offset = 7, Required = false)]
		public int? LegPaymentStreamRateIndex2Source {get; set;}
		
		[TagDetails(Tag = 43118, Type = TagType.String, Offset = 8, Required = false)]
		public string? LegPaymentStreamRateIndex2ID {get; set;}
		
		[TagDetails(Tag = 43119, Type = TagType.String, Offset = 9, Required = false)]
		public string? LegPaymentStreamRateIndex2IDSource {get; set;}
		
		[TagDetails(Tag = 41563, Type = TagType.String, Offset = 10, Required = false)]
		public string? LegPaymentStreamRateIndex2CurveUnit {get; set;}
		
		[TagDetails(Tag = 41564, Type = TagType.Int, Offset = 11, Required = false)]
		public int? LegPaymentStreamRateIndex2CurvePeriod {get; set;}
		
		[TagDetails(Tag = 41565, Type = TagType.String, Offset = 12, Required = false)]
		public string? LegPaymentStreamRateIndexLocation {get; set;}
		
		[TagDetails(Tag = 41566, Type = TagType.Float, Offset = 13, Required = false)]
		public double? LegPaymentStreamRateIndexLevel {get; set;}
		
		[TagDetails(Tag = 41567, Type = TagType.String, Offset = 14, Required = false)]
		public string? LegPaymentStreamRateIndexUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 41568, Type = TagType.Int, Offset = 15, Required = false)]
		public int? LegPaymentStreamSettlLevel {get; set;}
		
		[TagDetails(Tag = 41569, Type = TagType.Float, Offset = 16, Required = false)]
		public double? LegPaymentStreamReferenceLevel {get; set;}
		
		[TagDetails(Tag = 41570, Type = TagType.String, Offset = 17, Required = false)]
		public string? LegPaymentStreamReferenceLevelUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 41571, Type = TagType.Boolean, Offset = 18, Required = false)]
		public bool? LegPaymentStreamReferenceLevelEqualsZeroIndicator {get; set;}
		
		[TagDetails(Tag = 40335, Type = TagType.Float, Offset = 19, Required = false)]
		public double? LegPaymentStreamRateMultiplier {get; set;}
		
		[TagDetails(Tag = 40336, Type = TagType.Float, Offset = 20, Required = false)]
		public double? LegPaymentStreamRateSpread {get; set;}
		
		[TagDetails(Tag = 41572, Type = TagType.String, Offset = 21, Required = false)]
		public string? LegPaymentStreamRateSpreadCurrency {get; set;}
		
		[TagDetails(Tag = 41573, Type = TagType.String, Offset = 22, Required = false)]
		public string? LegPaymentStreamRateSpreadUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 41574, Type = TagType.Float, Offset = 23, Required = false)]
		public double? LegPaymentStreamRateConversionFactor {get; set;}
		
		[TagDetails(Tag = 41575, Type = TagType.Int, Offset = 24, Required = false)]
		public int? LegPaymentStreamRateSpreadType {get; set;}
		
		[TagDetails(Tag = 40337, Type = TagType.Int, Offset = 25, Required = false)]
		public int? LegPaymentStreamRateSpreadPositionType {get; set;}
		
		[TagDetails(Tag = 40338, Type = TagType.Int, Offset = 26, Required = false)]
		public int? LegPaymentStreamRateTreatment {get; set;}
		
		[TagDetails(Tag = 40339, Type = TagType.Float, Offset = 27, Required = false)]
		public double? LegPaymentStreamCapRate {get; set;}
		
		[TagDetails(Tag = 40340, Type = TagType.Int, Offset = 28, Required = false)]
		public int? LegPaymentStreamCapRateBuySide {get; set;}
		
		[TagDetails(Tag = 40341, Type = TagType.Int, Offset = 29, Required = false)]
		public int? LegPaymentStreamCapRateSellSide {get; set;}
		
		[TagDetails(Tag = 40342, Type = TagType.Float, Offset = 30, Required = false)]
		public double? LegPaymentStreamFloorRate {get; set;}
		
		[TagDetails(Tag = 40343, Type = TagType.Int, Offset = 31, Required = false)]
		public int? LegPaymentStreamFloorRateBuySide {get; set;}
		
		[TagDetails(Tag = 40344, Type = TagType.Int, Offset = 32, Required = false)]
		public int? LegPaymentStreamFloorRateSellSide {get; set;}
		
		[TagDetails(Tag = 40345, Type = TagType.Float, Offset = 33, Required = false)]
		public double? LegPaymentStreamInitialRate {get; set;}
		
		[TagDetails(Tag = 41576, Type = TagType.Float, Offset = 34, Required = false)]
		public double? LegPaymentStreamLastResetRate {get; set;}
		
		[TagDetails(Tag = 41577, Type = TagType.Float, Offset = 35, Required = false)]
		public double? LegPaymentStreamFinalRate {get; set;}
		
		[TagDetails(Tag = 40346, Type = TagType.String, Offset = 36, Required = false)]
		public string? LegPaymentStreamFinalRateRoundingDirection {get; set;}
		
		[TagDetails(Tag = 40347, Type = TagType.Int, Offset = 37, Required = false)]
		public int? LegPaymentStreamFinalRatePrecision {get; set;}
		
		[TagDetails(Tag = 40348, Type = TagType.Int, Offset = 38, Required = false)]
		public int? LegPaymentStreamAveragingMethod {get; set;}
		
		[TagDetails(Tag = 40349, Type = TagType.Int, Offset = 39, Required = false)]
		public int? LegPaymentStreamNegativeRateTreatment {get; set;}
		
		[TagDetails(Tag = 41578, Type = TagType.Int, Offset = 40, Required = false)]
		public int? LegPaymentStreamCalculationLagPeriod {get; set;}
		
		[TagDetails(Tag = 41579, Type = TagType.String, Offset = 41, Required = false)]
		public string? LegPaymentStreamCalculationLagUnit {get; set;}
		
		[TagDetails(Tag = 42462, Type = TagType.LocalDate, Offset = 42, Required = false)]
		public DateOnly? LegPaymentStreamFirstObservationDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42463, Type = TagType.Int, Offset = 43, Required = false)]
		public int? LegPaymentStreamFirstObservationDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42464, Type = TagType.Int, Offset = 44, Required = false)]
		public int? LegPaymentStreamFirstObservationDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 41580, Type = TagType.Int, Offset = 45, Required = false)]
		public int? LegPaymentStreamFirstObservationDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 41581, Type = TagType.String, Offset = 46, Required = false)]
		public string? LegPaymentStreamFirstObservationDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42465, Type = TagType.LocalDate, Offset = 47, Required = false)]
		public DateOnly? LegPaymentStreamFirstObservationDateAdjusted {get; set;}
		
		[TagDetails(Tag = 41582, Type = TagType.Int, Offset = 48, Required = false)]
		public int? LegPaymentStreamPricingDayType {get; set;}
		
		[TagDetails(Tag = 41583, Type = TagType.Int, Offset = 49, Required = false)]
		public int? LegPaymentStreamPricingDayDistribution {get; set;}
		
		[TagDetails(Tag = 41584, Type = TagType.Int, Offset = 50, Required = false)]
		public int? LegPaymentStreamPricingDayCount {get; set;}
		
		[TagDetails(Tag = 41585, Type = TagType.String, Offset = 51, Required = false)]
		public string? LegPaymentStreamPricingBusinessCalendar {get; set;}
		
		[TagDetails(Tag = 41586, Type = TagType.Int, Offset = 52, Required = false)]
		public int? LegPaymentStreamPricingBusinessDayConvention {get; set;}
		
		[Component(Offset = 53, Required = false)]
		public LegPaymentStreamPricingBusinessCenterGrp? LegPaymentStreamPricingBusinessCenterGrp {get; set;}
		
		[Component(Offset = 54, Required = false)]
		public LegPaymentStreamPricingDayGrp? LegPaymentStreamPricingDayGrp {get; set;}
		
		[Component(Offset = 55, Required = false)]
		public LegPaymentStreamPricingDateGrp? LegPaymentStreamPricingDateGrp {get; set;}
		
		[TagDetails(Tag = 40350, Type = TagType.Int, Offset = 56, Required = false)]
		public int? LegPaymentStreamInflationLagPeriod {get; set;}
		
		[TagDetails(Tag = 40351, Type = TagType.String, Offset = 57, Required = false)]
		public string? LegPaymentStreamInflationLagUnit {get; set;}
		
		[TagDetails(Tag = 40352, Type = TagType.Int, Offset = 58, Required = false)]
		public int? LegPaymentStreamInflationLagDayType {get; set;}
		
		[TagDetails(Tag = 40353, Type = TagType.Int, Offset = 59, Required = false)]
		public int? LegPaymentStreamInflationInterpolationMethod {get; set;}
		
		[TagDetails(Tag = 40354, Type = TagType.Int, Offset = 60, Required = false)]
		public int? LegPaymentStreamInflationIndexSource {get; set;}
		
		[TagDetails(Tag = 40355, Type = TagType.String, Offset = 61, Required = false)]
		public string? LegPaymentStreamInflationPublicationSource {get; set;}
		
		[TagDetails(Tag = 40356, Type = TagType.Float, Offset = 62, Required = false)]
		public double? LegPaymentStreamInflationInitialIndexLevel {get; set;}
		
		[TagDetails(Tag = 40357, Type = TagType.Boolean, Offset = 63, Required = false)]
		public bool? LegPaymentStreamInflationFallbackBondApplicable {get; set;}
		
		[TagDetails(Tag = 40358, Type = TagType.Int, Offset = 64, Required = false)]
		public int? LegPaymentStreamFRADiscounting {get; set;}
		
		[TagDetails(Tag = 42466, Type = TagType.String, Offset = 65, Required = false)]
		public string? LegPaymentStreamUnderlierRefID {get; set;}
		
		[Component(Offset = 66, Required = false)]
		public LegPaymentStreamFormula? LegPaymentStreamFormula {get; set;}
		
		[Component(Offset = 67, Required = false)]
		public LegDividendConditions? LegDividendConditions {get; set;}
		
		[TagDetails(Tag = 42467, Type = TagType.Boolean, Offset = 68, Required = false)]
		public bool? LegReturnRateNotionalReset {get; set;}
		
		[Component(Offset = 69, Required = false)]
		public LegReturnRateGrp? LegReturnRateGrp {get; set;}
		
		[TagDetails(Tag = 42468, Type = TagType.Float, Offset = 70, Required = false)]
		public double? LegPaymentStreamLinkInitialLevel {get; set;}
		
		[TagDetails(Tag = 42469, Type = TagType.Boolean, Offset = 71, Required = false)]
		public bool? LegPaymentStreamLinkClosingLevelIndicator {get; set;}
		
		[TagDetails(Tag = 42470, Type = TagType.Boolean, Offset = 72, Required = false)]
		public bool? LegPaymentStreamLinkExpiringLevelIndicator {get; set;}
		
		[TagDetails(Tag = 42471, Type = TagType.Int, Offset = 73, Required = false)]
		public int? LegPaymentStreamLinkEstimatedTradingDays {get; set;}
		
		[TagDetails(Tag = 42472, Type = TagType.Float, Offset = 74, Required = false)]
		public double? LegPaymentStreamLinkStrikePrice {get; set;}
		
		[TagDetails(Tag = 42473, Type = TagType.Int, Offset = 75, Required = false)]
		public int? LegPaymentStreamLinkStrikePriceType {get; set;}
		
		[TagDetails(Tag = 42474, Type = TagType.Float, Offset = 76, Required = false)]
		public double? LegPaymentStreamLinkMaximumBoundary {get; set;}
		
		[TagDetails(Tag = 42475, Type = TagType.Float, Offset = 77, Required = false)]
		public double? LegPaymentStreamLinkMinimumBoundary {get; set;}
		
		[TagDetails(Tag = 42476, Type = TagType.Int, Offset = 78, Required = false)]
		public int? LegPaymentStreamLinkNumberOfDataSeries {get; set;}
		
		[TagDetails(Tag = 42477, Type = TagType.Float, Offset = 79, Required = false)]
		public double? LegPaymentStreamVarianceUnadjustedCap {get; set;}
		
		[TagDetails(Tag = 42478, Type = TagType.Int, Offset = 80, Required = false)]
		public int? LegPaymentStreamRealizedVarianceMethod {get; set;}
		
		[TagDetails(Tag = 42479, Type = TagType.Boolean, Offset = 81, Required = false)]
		public bool? LegPaymentStreamDaysAdjustmentIndicator {get; set;}
		
		[TagDetails(Tag = 42480, Type = TagType.String, Offset = 82, Required = false)]
		public string? LegPaymentStreamNearestExchangeContractRefID {get; set;}
		
		[TagDetails(Tag = 42481, Type = TagType.Float, Offset = 83, Required = false)]
		public double? LegPaymentStreamVegaNotionalAmount {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStreamRateIndex is not null) writer.WriteString(40331, LegPaymentStreamRateIndex);
			if (LegPaymentStreamRateIndexSource is not null) writer.WriteWholeNumber(40332, LegPaymentStreamRateIndexSource.Value);
			if (LegPaymentStreamRateIndexID is not null) writer.WriteString(43088, LegPaymentStreamRateIndexID);
			if (LegPaymentStreamRateIndexIDSource is not null) writer.WriteString(43089, LegPaymentStreamRateIndexIDSource);
			if (LegPaymentStreamRateIndexCurveUnit is not null) writer.WriteString(40333, LegPaymentStreamRateIndexCurveUnit);
			if (LegPaymentStreamRateIndexCurvePeriod is not null) writer.WriteWholeNumber(40334, LegPaymentStreamRateIndexCurvePeriod.Value);
			if (LegPaymentStreamRateIndex2 is not null) writer.WriteString(43116, LegPaymentStreamRateIndex2);
			if (LegPaymentStreamRateIndex2Source is not null) writer.WriteWholeNumber(43117, LegPaymentStreamRateIndex2Source.Value);
			if (LegPaymentStreamRateIndex2ID is not null) writer.WriteString(43118, LegPaymentStreamRateIndex2ID);
			if (LegPaymentStreamRateIndex2IDSource is not null) writer.WriteString(43119, LegPaymentStreamRateIndex2IDSource);
			if (LegPaymentStreamRateIndex2CurveUnit is not null) writer.WriteString(41563, LegPaymentStreamRateIndex2CurveUnit);
			if (LegPaymentStreamRateIndex2CurvePeriod is not null) writer.WriteWholeNumber(41564, LegPaymentStreamRateIndex2CurvePeriod.Value);
			if (LegPaymentStreamRateIndexLocation is not null) writer.WriteString(41565, LegPaymentStreamRateIndexLocation);
			if (LegPaymentStreamRateIndexLevel is not null) writer.WriteNumber(41566, LegPaymentStreamRateIndexLevel.Value);
			if (LegPaymentStreamRateIndexUnitOfMeasure is not null) writer.WriteString(41567, LegPaymentStreamRateIndexUnitOfMeasure);
			if (LegPaymentStreamSettlLevel is not null) writer.WriteWholeNumber(41568, LegPaymentStreamSettlLevel.Value);
			if (LegPaymentStreamReferenceLevel is not null) writer.WriteNumber(41569, LegPaymentStreamReferenceLevel.Value);
			if (LegPaymentStreamReferenceLevelUnitOfMeasure is not null) writer.WriteString(41570, LegPaymentStreamReferenceLevelUnitOfMeasure);
			if (LegPaymentStreamReferenceLevelEqualsZeroIndicator is not null) writer.WriteBoolean(41571, LegPaymentStreamReferenceLevelEqualsZeroIndicator.Value);
			if (LegPaymentStreamRateMultiplier is not null) writer.WriteNumber(40335, LegPaymentStreamRateMultiplier.Value);
			if (LegPaymentStreamRateSpread is not null) writer.WriteNumber(40336, LegPaymentStreamRateSpread.Value);
			if (LegPaymentStreamRateSpreadCurrency is not null) writer.WriteString(41572, LegPaymentStreamRateSpreadCurrency);
			if (LegPaymentStreamRateSpreadUnitOfMeasure is not null) writer.WriteString(41573, LegPaymentStreamRateSpreadUnitOfMeasure);
			if (LegPaymentStreamRateConversionFactor is not null) writer.WriteNumber(41574, LegPaymentStreamRateConversionFactor.Value);
			if (LegPaymentStreamRateSpreadType is not null) writer.WriteWholeNumber(41575, LegPaymentStreamRateSpreadType.Value);
			if (LegPaymentStreamRateSpreadPositionType is not null) writer.WriteWholeNumber(40337, LegPaymentStreamRateSpreadPositionType.Value);
			if (LegPaymentStreamRateTreatment is not null) writer.WriteWholeNumber(40338, LegPaymentStreamRateTreatment.Value);
			if (LegPaymentStreamCapRate is not null) writer.WriteNumber(40339, LegPaymentStreamCapRate.Value);
			if (LegPaymentStreamCapRateBuySide is not null) writer.WriteWholeNumber(40340, LegPaymentStreamCapRateBuySide.Value);
			if (LegPaymentStreamCapRateSellSide is not null) writer.WriteWholeNumber(40341, LegPaymentStreamCapRateSellSide.Value);
			if (LegPaymentStreamFloorRate is not null) writer.WriteNumber(40342, LegPaymentStreamFloorRate.Value);
			if (LegPaymentStreamFloorRateBuySide is not null) writer.WriteWholeNumber(40343, LegPaymentStreamFloorRateBuySide.Value);
			if (LegPaymentStreamFloorRateSellSide is not null) writer.WriteWholeNumber(40344, LegPaymentStreamFloorRateSellSide.Value);
			if (LegPaymentStreamInitialRate is not null) writer.WriteNumber(40345, LegPaymentStreamInitialRate.Value);
			if (LegPaymentStreamLastResetRate is not null) writer.WriteNumber(41576, LegPaymentStreamLastResetRate.Value);
			if (LegPaymentStreamFinalRate is not null) writer.WriteNumber(41577, LegPaymentStreamFinalRate.Value);
			if (LegPaymentStreamFinalRateRoundingDirection is not null) writer.WriteString(40346, LegPaymentStreamFinalRateRoundingDirection);
			if (LegPaymentStreamFinalRatePrecision is not null) writer.WriteWholeNumber(40347, LegPaymentStreamFinalRatePrecision.Value);
			if (LegPaymentStreamAveragingMethod is not null) writer.WriteWholeNumber(40348, LegPaymentStreamAveragingMethod.Value);
			if (LegPaymentStreamNegativeRateTreatment is not null) writer.WriteWholeNumber(40349, LegPaymentStreamNegativeRateTreatment.Value);
			if (LegPaymentStreamCalculationLagPeriod is not null) writer.WriteWholeNumber(41578, LegPaymentStreamCalculationLagPeriod.Value);
			if (LegPaymentStreamCalculationLagUnit is not null) writer.WriteString(41579, LegPaymentStreamCalculationLagUnit);
			if (LegPaymentStreamFirstObservationDateUnadjusted is not null) writer.WriteLocalDateOnly(42462, LegPaymentStreamFirstObservationDateUnadjusted.Value);
			if (LegPaymentStreamFirstObservationDateRelativeTo is not null) writer.WriteWholeNumber(42463, LegPaymentStreamFirstObservationDateRelativeTo.Value);
			if (LegPaymentStreamFirstObservationDateOffsetDayType is not null) writer.WriteWholeNumber(42464, LegPaymentStreamFirstObservationDateOffsetDayType.Value);
			if (LegPaymentStreamFirstObservationDateOffsetPeriod is not null) writer.WriteWholeNumber(41580, LegPaymentStreamFirstObservationDateOffsetPeriod.Value);
			if (LegPaymentStreamFirstObservationDateOffsetUnit is not null) writer.WriteString(41581, LegPaymentStreamFirstObservationDateOffsetUnit);
			if (LegPaymentStreamFirstObservationDateAdjusted is not null) writer.WriteLocalDateOnly(42465, LegPaymentStreamFirstObservationDateAdjusted.Value);
			if (LegPaymentStreamPricingDayType is not null) writer.WriteWholeNumber(41582, LegPaymentStreamPricingDayType.Value);
			if (LegPaymentStreamPricingDayDistribution is not null) writer.WriteWholeNumber(41583, LegPaymentStreamPricingDayDistribution.Value);
			if (LegPaymentStreamPricingDayCount is not null) writer.WriteWholeNumber(41584, LegPaymentStreamPricingDayCount.Value);
			if (LegPaymentStreamPricingBusinessCalendar is not null) writer.WriteString(41585, LegPaymentStreamPricingBusinessCalendar);
			if (LegPaymentStreamPricingBusinessDayConvention is not null) writer.WriteWholeNumber(41586, LegPaymentStreamPricingBusinessDayConvention.Value);
			if (LegPaymentStreamPricingBusinessCenterGrp is not null) ((IFixEncoder)LegPaymentStreamPricingBusinessCenterGrp).Encode(writer);
			if (LegPaymentStreamPricingDayGrp is not null) ((IFixEncoder)LegPaymentStreamPricingDayGrp).Encode(writer);
			if (LegPaymentStreamPricingDateGrp is not null) ((IFixEncoder)LegPaymentStreamPricingDateGrp).Encode(writer);
			if (LegPaymentStreamInflationLagPeriod is not null) writer.WriteWholeNumber(40350, LegPaymentStreamInflationLagPeriod.Value);
			if (LegPaymentStreamInflationLagUnit is not null) writer.WriteString(40351, LegPaymentStreamInflationLagUnit);
			if (LegPaymentStreamInflationLagDayType is not null) writer.WriteWholeNumber(40352, LegPaymentStreamInflationLagDayType.Value);
			if (LegPaymentStreamInflationInterpolationMethod is not null) writer.WriteWholeNumber(40353, LegPaymentStreamInflationInterpolationMethod.Value);
			if (LegPaymentStreamInflationIndexSource is not null) writer.WriteWholeNumber(40354, LegPaymentStreamInflationIndexSource.Value);
			if (LegPaymentStreamInflationPublicationSource is not null) writer.WriteString(40355, LegPaymentStreamInflationPublicationSource);
			if (LegPaymentStreamInflationInitialIndexLevel is not null) writer.WriteNumber(40356, LegPaymentStreamInflationInitialIndexLevel.Value);
			if (LegPaymentStreamInflationFallbackBondApplicable is not null) writer.WriteBoolean(40357, LegPaymentStreamInflationFallbackBondApplicable.Value);
			if (LegPaymentStreamFRADiscounting is not null) writer.WriteWholeNumber(40358, LegPaymentStreamFRADiscounting.Value);
			if (LegPaymentStreamUnderlierRefID is not null) writer.WriteString(42466, LegPaymentStreamUnderlierRefID);
			if (LegPaymentStreamFormula is not null) ((IFixEncoder)LegPaymentStreamFormula).Encode(writer);
			if (LegDividendConditions is not null) ((IFixEncoder)LegDividendConditions).Encode(writer);
			if (LegReturnRateNotionalReset is not null) writer.WriteBoolean(42467, LegReturnRateNotionalReset.Value);
			if (LegReturnRateGrp is not null) ((IFixEncoder)LegReturnRateGrp).Encode(writer);
			if (LegPaymentStreamLinkInitialLevel is not null) writer.WriteNumber(42468, LegPaymentStreamLinkInitialLevel.Value);
			if (LegPaymentStreamLinkClosingLevelIndicator is not null) writer.WriteBoolean(42469, LegPaymentStreamLinkClosingLevelIndicator.Value);
			if (LegPaymentStreamLinkExpiringLevelIndicator is not null) writer.WriteBoolean(42470, LegPaymentStreamLinkExpiringLevelIndicator.Value);
			if (LegPaymentStreamLinkEstimatedTradingDays is not null) writer.WriteWholeNumber(42471, LegPaymentStreamLinkEstimatedTradingDays.Value);
			if (LegPaymentStreamLinkStrikePrice is not null) writer.WriteNumber(42472, LegPaymentStreamLinkStrikePrice.Value);
			if (LegPaymentStreamLinkStrikePriceType is not null) writer.WriteWholeNumber(42473, LegPaymentStreamLinkStrikePriceType.Value);
			if (LegPaymentStreamLinkMaximumBoundary is not null) writer.WriteNumber(42474, LegPaymentStreamLinkMaximumBoundary.Value);
			if (LegPaymentStreamLinkMinimumBoundary is not null) writer.WriteNumber(42475, LegPaymentStreamLinkMinimumBoundary.Value);
			if (LegPaymentStreamLinkNumberOfDataSeries is not null) writer.WriteWholeNumber(42476, LegPaymentStreamLinkNumberOfDataSeries.Value);
			if (LegPaymentStreamVarianceUnadjustedCap is not null) writer.WriteNumber(42477, LegPaymentStreamVarianceUnadjustedCap.Value);
			if (LegPaymentStreamRealizedVarianceMethod is not null) writer.WriteWholeNumber(42478, LegPaymentStreamRealizedVarianceMethod.Value);
			if (LegPaymentStreamDaysAdjustmentIndicator is not null) writer.WriteBoolean(42479, LegPaymentStreamDaysAdjustmentIndicator.Value);
			if (LegPaymentStreamNearestExchangeContractRefID is not null) writer.WriteString(42480, LegPaymentStreamNearestExchangeContractRefID);
			if (LegPaymentStreamVegaNotionalAmount is not null) writer.WriteNumber(42481, LegPaymentStreamVegaNotionalAmount.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegPaymentStreamRateIndex = view.GetString(40331);
			LegPaymentStreamRateIndexSource = view.GetInt32(40332);
			LegPaymentStreamRateIndexID = view.GetString(43088);
			LegPaymentStreamRateIndexIDSource = view.GetString(43089);
			LegPaymentStreamRateIndexCurveUnit = view.GetString(40333);
			LegPaymentStreamRateIndexCurvePeriod = view.GetInt32(40334);
			LegPaymentStreamRateIndex2 = view.GetString(43116);
			LegPaymentStreamRateIndex2Source = view.GetInt32(43117);
			LegPaymentStreamRateIndex2ID = view.GetString(43118);
			LegPaymentStreamRateIndex2IDSource = view.GetString(43119);
			LegPaymentStreamRateIndex2CurveUnit = view.GetString(41563);
			LegPaymentStreamRateIndex2CurvePeriod = view.GetInt32(41564);
			LegPaymentStreamRateIndexLocation = view.GetString(41565);
			LegPaymentStreamRateIndexLevel = view.GetDouble(41566);
			LegPaymentStreamRateIndexUnitOfMeasure = view.GetString(41567);
			LegPaymentStreamSettlLevel = view.GetInt32(41568);
			LegPaymentStreamReferenceLevel = view.GetDouble(41569);
			LegPaymentStreamReferenceLevelUnitOfMeasure = view.GetString(41570);
			LegPaymentStreamReferenceLevelEqualsZeroIndicator = view.GetBool(41571);
			LegPaymentStreamRateMultiplier = view.GetDouble(40335);
			LegPaymentStreamRateSpread = view.GetDouble(40336);
			LegPaymentStreamRateSpreadCurrency = view.GetString(41572);
			LegPaymentStreamRateSpreadUnitOfMeasure = view.GetString(41573);
			LegPaymentStreamRateConversionFactor = view.GetDouble(41574);
			LegPaymentStreamRateSpreadType = view.GetInt32(41575);
			LegPaymentStreamRateSpreadPositionType = view.GetInt32(40337);
			LegPaymentStreamRateTreatment = view.GetInt32(40338);
			LegPaymentStreamCapRate = view.GetDouble(40339);
			LegPaymentStreamCapRateBuySide = view.GetInt32(40340);
			LegPaymentStreamCapRateSellSide = view.GetInt32(40341);
			LegPaymentStreamFloorRate = view.GetDouble(40342);
			LegPaymentStreamFloorRateBuySide = view.GetInt32(40343);
			LegPaymentStreamFloorRateSellSide = view.GetInt32(40344);
			LegPaymentStreamInitialRate = view.GetDouble(40345);
			LegPaymentStreamLastResetRate = view.GetDouble(41576);
			LegPaymentStreamFinalRate = view.GetDouble(41577);
			LegPaymentStreamFinalRateRoundingDirection = view.GetString(40346);
			LegPaymentStreamFinalRatePrecision = view.GetInt32(40347);
			LegPaymentStreamAveragingMethod = view.GetInt32(40348);
			LegPaymentStreamNegativeRateTreatment = view.GetInt32(40349);
			LegPaymentStreamCalculationLagPeriod = view.GetInt32(41578);
			LegPaymentStreamCalculationLagUnit = view.GetString(41579);
			LegPaymentStreamFirstObservationDateUnadjusted = view.GetDateOnly(42462);
			LegPaymentStreamFirstObservationDateRelativeTo = view.GetInt32(42463);
			LegPaymentStreamFirstObservationDateOffsetDayType = view.GetInt32(42464);
			LegPaymentStreamFirstObservationDateOffsetPeriod = view.GetInt32(41580);
			LegPaymentStreamFirstObservationDateOffsetUnit = view.GetString(41581);
			LegPaymentStreamFirstObservationDateAdjusted = view.GetDateOnly(42465);
			LegPaymentStreamPricingDayType = view.GetInt32(41582);
			LegPaymentStreamPricingDayDistribution = view.GetInt32(41583);
			LegPaymentStreamPricingDayCount = view.GetInt32(41584);
			LegPaymentStreamPricingBusinessCalendar = view.GetString(41585);
			LegPaymentStreamPricingBusinessDayConvention = view.GetInt32(41586);
			if (view.GetView("LegPaymentStreamPricingBusinessCenterGrp") is IMessageView viewLegPaymentStreamPricingBusinessCenterGrp)
			{
				LegPaymentStreamPricingBusinessCenterGrp = new();
				((IFixParser)LegPaymentStreamPricingBusinessCenterGrp).Parse(viewLegPaymentStreamPricingBusinessCenterGrp);
			}
			if (view.GetView("LegPaymentStreamPricingDayGrp") is IMessageView viewLegPaymentStreamPricingDayGrp)
			{
				LegPaymentStreamPricingDayGrp = new();
				((IFixParser)LegPaymentStreamPricingDayGrp).Parse(viewLegPaymentStreamPricingDayGrp);
			}
			if (view.GetView("LegPaymentStreamPricingDateGrp") is IMessageView viewLegPaymentStreamPricingDateGrp)
			{
				LegPaymentStreamPricingDateGrp = new();
				((IFixParser)LegPaymentStreamPricingDateGrp).Parse(viewLegPaymentStreamPricingDateGrp);
			}
			LegPaymentStreamInflationLagPeriod = view.GetInt32(40350);
			LegPaymentStreamInflationLagUnit = view.GetString(40351);
			LegPaymentStreamInflationLagDayType = view.GetInt32(40352);
			LegPaymentStreamInflationInterpolationMethod = view.GetInt32(40353);
			LegPaymentStreamInflationIndexSource = view.GetInt32(40354);
			LegPaymentStreamInflationPublicationSource = view.GetString(40355);
			LegPaymentStreamInflationInitialIndexLevel = view.GetDouble(40356);
			LegPaymentStreamInflationFallbackBondApplicable = view.GetBool(40357);
			LegPaymentStreamFRADiscounting = view.GetInt32(40358);
			LegPaymentStreamUnderlierRefID = view.GetString(42466);
			if (view.GetView("LegPaymentStreamFormula") is IMessageView viewLegPaymentStreamFormula)
			{
				LegPaymentStreamFormula = new();
				((IFixParser)LegPaymentStreamFormula).Parse(viewLegPaymentStreamFormula);
			}
			if (view.GetView("LegDividendConditions") is IMessageView viewLegDividendConditions)
			{
				LegDividendConditions = new();
				((IFixParser)LegDividendConditions).Parse(viewLegDividendConditions);
			}
			LegReturnRateNotionalReset = view.GetBool(42467);
			if (view.GetView("LegReturnRateGrp") is IMessageView viewLegReturnRateGrp)
			{
				LegReturnRateGrp = new();
				((IFixParser)LegReturnRateGrp).Parse(viewLegReturnRateGrp);
			}
			LegPaymentStreamLinkInitialLevel = view.GetDouble(42468);
			LegPaymentStreamLinkClosingLevelIndicator = view.GetBool(42469);
			LegPaymentStreamLinkExpiringLevelIndicator = view.GetBool(42470);
			LegPaymentStreamLinkEstimatedTradingDays = view.GetInt32(42471);
			LegPaymentStreamLinkStrikePrice = view.GetDouble(42472);
			LegPaymentStreamLinkStrikePriceType = view.GetInt32(42473);
			LegPaymentStreamLinkMaximumBoundary = view.GetDouble(42474);
			LegPaymentStreamLinkMinimumBoundary = view.GetDouble(42475);
			LegPaymentStreamLinkNumberOfDataSeries = view.GetInt32(42476);
			LegPaymentStreamVarianceUnadjustedCap = view.GetDouble(42477);
			LegPaymentStreamRealizedVarianceMethod = view.GetInt32(42478);
			LegPaymentStreamDaysAdjustmentIndicator = view.GetBool(42479);
			LegPaymentStreamNearestExchangeContractRefID = view.GetString(42480);
			LegPaymentStreamVegaNotionalAmount = view.GetDouble(42481);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegPaymentStreamRateIndex":
				{
					value = LegPaymentStreamRateIndex;
					break;
				}
				case "LegPaymentStreamRateIndexSource":
				{
					value = LegPaymentStreamRateIndexSource;
					break;
				}
				case "LegPaymentStreamRateIndexID":
				{
					value = LegPaymentStreamRateIndexID;
					break;
				}
				case "LegPaymentStreamRateIndexIDSource":
				{
					value = LegPaymentStreamRateIndexIDSource;
					break;
				}
				case "LegPaymentStreamRateIndexCurveUnit":
				{
					value = LegPaymentStreamRateIndexCurveUnit;
					break;
				}
				case "LegPaymentStreamRateIndexCurvePeriod":
				{
					value = LegPaymentStreamRateIndexCurvePeriod;
					break;
				}
				case "LegPaymentStreamRateIndex2":
				{
					value = LegPaymentStreamRateIndex2;
					break;
				}
				case "LegPaymentStreamRateIndex2Source":
				{
					value = LegPaymentStreamRateIndex2Source;
					break;
				}
				case "LegPaymentStreamRateIndex2ID":
				{
					value = LegPaymentStreamRateIndex2ID;
					break;
				}
				case "LegPaymentStreamRateIndex2IDSource":
				{
					value = LegPaymentStreamRateIndex2IDSource;
					break;
				}
				case "LegPaymentStreamRateIndex2CurveUnit":
				{
					value = LegPaymentStreamRateIndex2CurveUnit;
					break;
				}
				case "LegPaymentStreamRateIndex2CurvePeriod":
				{
					value = LegPaymentStreamRateIndex2CurvePeriod;
					break;
				}
				case "LegPaymentStreamRateIndexLocation":
				{
					value = LegPaymentStreamRateIndexLocation;
					break;
				}
				case "LegPaymentStreamRateIndexLevel":
				{
					value = LegPaymentStreamRateIndexLevel;
					break;
				}
				case "LegPaymentStreamRateIndexUnitOfMeasure":
				{
					value = LegPaymentStreamRateIndexUnitOfMeasure;
					break;
				}
				case "LegPaymentStreamSettlLevel":
				{
					value = LegPaymentStreamSettlLevel;
					break;
				}
				case "LegPaymentStreamReferenceLevel":
				{
					value = LegPaymentStreamReferenceLevel;
					break;
				}
				case "LegPaymentStreamReferenceLevelUnitOfMeasure":
				{
					value = LegPaymentStreamReferenceLevelUnitOfMeasure;
					break;
				}
				case "LegPaymentStreamReferenceLevelEqualsZeroIndicator":
				{
					value = LegPaymentStreamReferenceLevelEqualsZeroIndicator;
					break;
				}
				case "LegPaymentStreamRateMultiplier":
				{
					value = LegPaymentStreamRateMultiplier;
					break;
				}
				case "LegPaymentStreamRateSpread":
				{
					value = LegPaymentStreamRateSpread;
					break;
				}
				case "LegPaymentStreamRateSpreadCurrency":
				{
					value = LegPaymentStreamRateSpreadCurrency;
					break;
				}
				case "LegPaymentStreamRateSpreadUnitOfMeasure":
				{
					value = LegPaymentStreamRateSpreadUnitOfMeasure;
					break;
				}
				case "LegPaymentStreamRateConversionFactor":
				{
					value = LegPaymentStreamRateConversionFactor;
					break;
				}
				case "LegPaymentStreamRateSpreadType":
				{
					value = LegPaymentStreamRateSpreadType;
					break;
				}
				case "LegPaymentStreamRateSpreadPositionType":
				{
					value = LegPaymentStreamRateSpreadPositionType;
					break;
				}
				case "LegPaymentStreamRateTreatment":
				{
					value = LegPaymentStreamRateTreatment;
					break;
				}
				case "LegPaymentStreamCapRate":
				{
					value = LegPaymentStreamCapRate;
					break;
				}
				case "LegPaymentStreamCapRateBuySide":
				{
					value = LegPaymentStreamCapRateBuySide;
					break;
				}
				case "LegPaymentStreamCapRateSellSide":
				{
					value = LegPaymentStreamCapRateSellSide;
					break;
				}
				case "LegPaymentStreamFloorRate":
				{
					value = LegPaymentStreamFloorRate;
					break;
				}
				case "LegPaymentStreamFloorRateBuySide":
				{
					value = LegPaymentStreamFloorRateBuySide;
					break;
				}
				case "LegPaymentStreamFloorRateSellSide":
				{
					value = LegPaymentStreamFloorRateSellSide;
					break;
				}
				case "LegPaymentStreamInitialRate":
				{
					value = LegPaymentStreamInitialRate;
					break;
				}
				case "LegPaymentStreamLastResetRate":
				{
					value = LegPaymentStreamLastResetRate;
					break;
				}
				case "LegPaymentStreamFinalRate":
				{
					value = LegPaymentStreamFinalRate;
					break;
				}
				case "LegPaymentStreamFinalRateRoundingDirection":
				{
					value = LegPaymentStreamFinalRateRoundingDirection;
					break;
				}
				case "LegPaymentStreamFinalRatePrecision":
				{
					value = LegPaymentStreamFinalRatePrecision;
					break;
				}
				case "LegPaymentStreamAveragingMethod":
				{
					value = LegPaymentStreamAveragingMethod;
					break;
				}
				case "LegPaymentStreamNegativeRateTreatment":
				{
					value = LegPaymentStreamNegativeRateTreatment;
					break;
				}
				case "LegPaymentStreamCalculationLagPeriod":
				{
					value = LegPaymentStreamCalculationLagPeriod;
					break;
				}
				case "LegPaymentStreamCalculationLagUnit":
				{
					value = LegPaymentStreamCalculationLagUnit;
					break;
				}
				case "LegPaymentStreamFirstObservationDateUnadjusted":
				{
					value = LegPaymentStreamFirstObservationDateUnadjusted;
					break;
				}
				case "LegPaymentStreamFirstObservationDateRelativeTo":
				{
					value = LegPaymentStreamFirstObservationDateRelativeTo;
					break;
				}
				case "LegPaymentStreamFirstObservationDateOffsetDayType":
				{
					value = LegPaymentStreamFirstObservationDateOffsetDayType;
					break;
				}
				case "LegPaymentStreamFirstObservationDateOffsetPeriod":
				{
					value = LegPaymentStreamFirstObservationDateOffsetPeriod;
					break;
				}
				case "LegPaymentStreamFirstObservationDateOffsetUnit":
				{
					value = LegPaymentStreamFirstObservationDateOffsetUnit;
					break;
				}
				case "LegPaymentStreamFirstObservationDateAdjusted":
				{
					value = LegPaymentStreamFirstObservationDateAdjusted;
					break;
				}
				case "LegPaymentStreamPricingDayType":
				{
					value = LegPaymentStreamPricingDayType;
					break;
				}
				case "LegPaymentStreamPricingDayDistribution":
				{
					value = LegPaymentStreamPricingDayDistribution;
					break;
				}
				case "LegPaymentStreamPricingDayCount":
				{
					value = LegPaymentStreamPricingDayCount;
					break;
				}
				case "LegPaymentStreamPricingBusinessCalendar":
				{
					value = LegPaymentStreamPricingBusinessCalendar;
					break;
				}
				case "LegPaymentStreamPricingBusinessDayConvention":
				{
					value = LegPaymentStreamPricingBusinessDayConvention;
					break;
				}
				case "LegPaymentStreamPricingBusinessCenterGrp":
				{
					value = LegPaymentStreamPricingBusinessCenterGrp;
					break;
				}
				case "LegPaymentStreamPricingDayGrp":
				{
					value = LegPaymentStreamPricingDayGrp;
					break;
				}
				case "LegPaymentStreamPricingDateGrp":
				{
					value = LegPaymentStreamPricingDateGrp;
					break;
				}
				case "LegPaymentStreamInflationLagPeriod":
				{
					value = LegPaymentStreamInflationLagPeriod;
					break;
				}
				case "LegPaymentStreamInflationLagUnit":
				{
					value = LegPaymentStreamInflationLagUnit;
					break;
				}
				case "LegPaymentStreamInflationLagDayType":
				{
					value = LegPaymentStreamInflationLagDayType;
					break;
				}
				case "LegPaymentStreamInflationInterpolationMethod":
				{
					value = LegPaymentStreamInflationInterpolationMethod;
					break;
				}
				case "LegPaymentStreamInflationIndexSource":
				{
					value = LegPaymentStreamInflationIndexSource;
					break;
				}
				case "LegPaymentStreamInflationPublicationSource":
				{
					value = LegPaymentStreamInflationPublicationSource;
					break;
				}
				case "LegPaymentStreamInflationInitialIndexLevel":
				{
					value = LegPaymentStreamInflationInitialIndexLevel;
					break;
				}
				case "LegPaymentStreamInflationFallbackBondApplicable":
				{
					value = LegPaymentStreamInflationFallbackBondApplicable;
					break;
				}
				case "LegPaymentStreamFRADiscounting":
				{
					value = LegPaymentStreamFRADiscounting;
					break;
				}
				case "LegPaymentStreamUnderlierRefID":
				{
					value = LegPaymentStreamUnderlierRefID;
					break;
				}
				case "LegPaymentStreamFormula":
				{
					value = LegPaymentStreamFormula;
					break;
				}
				case "LegDividendConditions":
				{
					value = LegDividendConditions;
					break;
				}
				case "LegReturnRateNotionalReset":
				{
					value = LegReturnRateNotionalReset;
					break;
				}
				case "LegReturnRateGrp":
				{
					value = LegReturnRateGrp;
					break;
				}
				case "LegPaymentStreamLinkInitialLevel":
				{
					value = LegPaymentStreamLinkInitialLevel;
					break;
				}
				case "LegPaymentStreamLinkClosingLevelIndicator":
				{
					value = LegPaymentStreamLinkClosingLevelIndicator;
					break;
				}
				case "LegPaymentStreamLinkExpiringLevelIndicator":
				{
					value = LegPaymentStreamLinkExpiringLevelIndicator;
					break;
				}
				case "LegPaymentStreamLinkEstimatedTradingDays":
				{
					value = LegPaymentStreamLinkEstimatedTradingDays;
					break;
				}
				case "LegPaymentStreamLinkStrikePrice":
				{
					value = LegPaymentStreamLinkStrikePrice;
					break;
				}
				case "LegPaymentStreamLinkStrikePriceType":
				{
					value = LegPaymentStreamLinkStrikePriceType;
					break;
				}
				case "LegPaymentStreamLinkMaximumBoundary":
				{
					value = LegPaymentStreamLinkMaximumBoundary;
					break;
				}
				case "LegPaymentStreamLinkMinimumBoundary":
				{
					value = LegPaymentStreamLinkMinimumBoundary;
					break;
				}
				case "LegPaymentStreamLinkNumberOfDataSeries":
				{
					value = LegPaymentStreamLinkNumberOfDataSeries;
					break;
				}
				case "LegPaymentStreamVarianceUnadjustedCap":
				{
					value = LegPaymentStreamVarianceUnadjustedCap;
					break;
				}
				case "LegPaymentStreamRealizedVarianceMethod":
				{
					value = LegPaymentStreamRealizedVarianceMethod;
					break;
				}
				case "LegPaymentStreamDaysAdjustmentIndicator":
				{
					value = LegPaymentStreamDaysAdjustmentIndicator;
					break;
				}
				case "LegPaymentStreamNearestExchangeContractRefID":
				{
					value = LegPaymentStreamNearestExchangeContractRefID;
					break;
				}
				case "LegPaymentStreamVegaNotionalAmount":
				{
					value = LegPaymentStreamVegaNotionalAmount;
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
			LegPaymentStreamRateIndex = null;
			LegPaymentStreamRateIndexSource = null;
			LegPaymentStreamRateIndexID = null;
			LegPaymentStreamRateIndexIDSource = null;
			LegPaymentStreamRateIndexCurveUnit = null;
			LegPaymentStreamRateIndexCurvePeriod = null;
			LegPaymentStreamRateIndex2 = null;
			LegPaymentStreamRateIndex2Source = null;
			LegPaymentStreamRateIndex2ID = null;
			LegPaymentStreamRateIndex2IDSource = null;
			LegPaymentStreamRateIndex2CurveUnit = null;
			LegPaymentStreamRateIndex2CurvePeriod = null;
			LegPaymentStreamRateIndexLocation = null;
			LegPaymentStreamRateIndexLevel = null;
			LegPaymentStreamRateIndexUnitOfMeasure = null;
			LegPaymentStreamSettlLevel = null;
			LegPaymentStreamReferenceLevel = null;
			LegPaymentStreamReferenceLevelUnitOfMeasure = null;
			LegPaymentStreamReferenceLevelEqualsZeroIndicator = null;
			LegPaymentStreamRateMultiplier = null;
			LegPaymentStreamRateSpread = null;
			LegPaymentStreamRateSpreadCurrency = null;
			LegPaymentStreamRateSpreadUnitOfMeasure = null;
			LegPaymentStreamRateConversionFactor = null;
			LegPaymentStreamRateSpreadType = null;
			LegPaymentStreamRateSpreadPositionType = null;
			LegPaymentStreamRateTreatment = null;
			LegPaymentStreamCapRate = null;
			LegPaymentStreamCapRateBuySide = null;
			LegPaymentStreamCapRateSellSide = null;
			LegPaymentStreamFloorRate = null;
			LegPaymentStreamFloorRateBuySide = null;
			LegPaymentStreamFloorRateSellSide = null;
			LegPaymentStreamInitialRate = null;
			LegPaymentStreamLastResetRate = null;
			LegPaymentStreamFinalRate = null;
			LegPaymentStreamFinalRateRoundingDirection = null;
			LegPaymentStreamFinalRatePrecision = null;
			LegPaymentStreamAveragingMethod = null;
			LegPaymentStreamNegativeRateTreatment = null;
			LegPaymentStreamCalculationLagPeriod = null;
			LegPaymentStreamCalculationLagUnit = null;
			LegPaymentStreamFirstObservationDateUnadjusted = null;
			LegPaymentStreamFirstObservationDateRelativeTo = null;
			LegPaymentStreamFirstObservationDateOffsetDayType = null;
			LegPaymentStreamFirstObservationDateOffsetPeriod = null;
			LegPaymentStreamFirstObservationDateOffsetUnit = null;
			LegPaymentStreamFirstObservationDateAdjusted = null;
			LegPaymentStreamPricingDayType = null;
			LegPaymentStreamPricingDayDistribution = null;
			LegPaymentStreamPricingDayCount = null;
			LegPaymentStreamPricingBusinessCalendar = null;
			LegPaymentStreamPricingBusinessDayConvention = null;
			((IFixReset?)LegPaymentStreamPricingBusinessCenterGrp)?.Reset();
			((IFixReset?)LegPaymentStreamPricingDayGrp)?.Reset();
			((IFixReset?)LegPaymentStreamPricingDateGrp)?.Reset();
			LegPaymentStreamInflationLagPeriod = null;
			LegPaymentStreamInflationLagUnit = null;
			LegPaymentStreamInflationLagDayType = null;
			LegPaymentStreamInflationInterpolationMethod = null;
			LegPaymentStreamInflationIndexSource = null;
			LegPaymentStreamInflationPublicationSource = null;
			LegPaymentStreamInflationInitialIndexLevel = null;
			LegPaymentStreamInflationFallbackBondApplicable = null;
			LegPaymentStreamFRADiscounting = null;
			LegPaymentStreamUnderlierRefID = null;
			((IFixReset?)LegPaymentStreamFormula)?.Reset();
			((IFixReset?)LegDividendConditions)?.Reset();
			LegReturnRateNotionalReset = null;
			((IFixReset?)LegReturnRateGrp)?.Reset();
			LegPaymentStreamLinkInitialLevel = null;
			LegPaymentStreamLinkClosingLevelIndicator = null;
			LegPaymentStreamLinkExpiringLevelIndicator = null;
			LegPaymentStreamLinkEstimatedTradingDays = null;
			LegPaymentStreamLinkStrikePrice = null;
			LegPaymentStreamLinkStrikePriceType = null;
			LegPaymentStreamLinkMaximumBoundary = null;
			LegPaymentStreamLinkMinimumBoundary = null;
			LegPaymentStreamLinkNumberOfDataSeries = null;
			LegPaymentStreamVarianceUnadjustedCap = null;
			LegPaymentStreamRealizedVarianceMethod = null;
			LegPaymentStreamDaysAdjustmentIndicator = null;
			LegPaymentStreamNearestExchangeContractRefID = null;
			LegPaymentStreamVegaNotionalAmount = null;
		}
	}
}
