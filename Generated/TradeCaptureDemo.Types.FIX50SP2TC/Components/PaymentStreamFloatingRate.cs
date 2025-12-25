using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStreamFloatingRate : IFixComponent
	{
		[TagDetails(Tag = 40789, Type = TagType.String, Offset = 0, Required = false)]
		public string? PaymentStreamRateIndex {get; set;}
		
		[TagDetails(Tag = 40790, Type = TagType.Int, Offset = 1, Required = false)]
		public int? PaymentStreamRateIndexSource {get; set;}
		
		[TagDetails(Tag = 43090, Type = TagType.String, Offset = 2, Required = false)]
		public string? PaymentStreamRateIndexID {get; set;}
		
		[TagDetails(Tag = 43091, Type = TagType.String, Offset = 3, Required = false)]
		public string? PaymentStreamRateIndexIDSource {get; set;}
		
		[TagDetails(Tag = 40791, Type = TagType.String, Offset = 4, Required = false)]
		public string? PaymentStreamRateIndexCurveUnit {get; set;}
		
		[TagDetails(Tag = 40792, Type = TagType.Int, Offset = 5, Required = false)]
		public int? PaymentStreamRateIndexCurvePeriod {get; set;}
		
		[TagDetails(Tag = 43112, Type = TagType.String, Offset = 6, Required = false)]
		public string? PaymentStreamRateIndex2 {get; set;}
		
		[TagDetails(Tag = 43113, Type = TagType.Int, Offset = 7, Required = false)]
		public int? PaymentStreamRateIndex2Source {get; set;}
		
		[TagDetails(Tag = 43114, Type = TagType.String, Offset = 8, Required = false)]
		public string? PaymentStreamRateIndex2ID {get; set;}
		
		[TagDetails(Tag = 43115, Type = TagType.String, Offset = 9, Required = false)]
		public string? PaymentStreamRateIndex2IDSource {get; set;}
		
		[TagDetails(Tag = 41194, Type = TagType.Int, Offset = 10, Required = false)]
		public int? PaymentStreamRateIndex2CurvePeriod {get; set;}
		
		[TagDetails(Tag = 41195, Type = TagType.String, Offset = 11, Required = false)]
		public string? PaymentStreamRateIndex2CurveUnit {get; set;}
		
		[TagDetails(Tag = 41196, Type = TagType.String, Offset = 12, Required = false)]
		public string? PaymentStreamRateIndexLocation {get; set;}
		
		[TagDetails(Tag = 41197, Type = TagType.Float, Offset = 13, Required = false)]
		public double? PaymentStreamRateIndexLevel {get; set;}
		
		[TagDetails(Tag = 41198, Type = TagType.String, Offset = 14, Required = false)]
		public string? PaymentStreamRateIndexUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 41199, Type = TagType.Int, Offset = 15, Required = false)]
		public int? PaymentStreamSettlLevel {get; set;}
		
		[TagDetails(Tag = 41200, Type = TagType.Float, Offset = 16, Required = false)]
		public double? PaymentStreamReferenceLevel {get; set;}
		
		[TagDetails(Tag = 41201, Type = TagType.String, Offset = 17, Required = false)]
		public string? PaymentStreamReferenceLevelUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 41202, Type = TagType.Boolean, Offset = 18, Required = false)]
		public bool? PaymentStreamReferenceLevelEqualsZeroIndicator {get; set;}
		
		[TagDetails(Tag = 40793, Type = TagType.Float, Offset = 19, Required = false)]
		public double? PaymentStreamRateMultiplier {get; set;}
		
		[TagDetails(Tag = 40794, Type = TagType.Float, Offset = 20, Required = false)]
		public double? PaymentStreamRateSpread {get; set;}
		
		[TagDetails(Tag = 41203, Type = TagType.String, Offset = 21, Required = false)]
		public string? PaymentStreamRateSpreadCurrency {get; set;}
		
		[TagDetails(Tag = 41204, Type = TagType.String, Offset = 22, Required = false)]
		public string? PaymentStreamRateSpreadUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 41205, Type = TagType.Float, Offset = 23, Required = false)]
		public double? PaymentStreamRateConversionFactor {get; set;}
		
		[TagDetails(Tag = 41206, Type = TagType.Int, Offset = 24, Required = false)]
		public int? PaymentStreamRateSpreadType {get; set;}
		
		[TagDetails(Tag = 40795, Type = TagType.Int, Offset = 25, Required = false)]
		public int? PaymentStreamRateSpreadPositionType {get; set;}
		
		[TagDetails(Tag = 40796, Type = TagType.Int, Offset = 26, Required = false)]
		public int? PaymentStreamRateTreatment {get; set;}
		
		[TagDetails(Tag = 40797, Type = TagType.Float, Offset = 27, Required = false)]
		public double? PaymentStreamCapRate {get; set;}
		
		[TagDetails(Tag = 40798, Type = TagType.Int, Offset = 28, Required = false)]
		public int? PaymentStreamCapRateBuySide {get; set;}
		
		[TagDetails(Tag = 40799, Type = TagType.Int, Offset = 29, Required = false)]
		public int? PaymentStreamCapRateSellSide {get; set;}
		
		[TagDetails(Tag = 40800, Type = TagType.Float, Offset = 30, Required = false)]
		public double? PaymentStreamFloorRate {get; set;}
		
		[TagDetails(Tag = 40801, Type = TagType.Int, Offset = 31, Required = false)]
		public int? PaymentStreamFloorRateBuySide {get; set;}
		
		[TagDetails(Tag = 40802, Type = TagType.Int, Offset = 32, Required = false)]
		public int? PaymentStreamFloorRateSellSide {get; set;}
		
		[TagDetails(Tag = 40803, Type = TagType.Float, Offset = 33, Required = false)]
		public double? PaymentStreamInitialRate {get; set;}
		
		[TagDetails(Tag = 41207, Type = TagType.Float, Offset = 34, Required = false)]
		public double? PaymentStreamLastResetRate {get; set;}
		
		[TagDetails(Tag = 41208, Type = TagType.Float, Offset = 35, Required = false)]
		public double? PaymentStreamFinalRate {get; set;}
		
		[TagDetails(Tag = 40804, Type = TagType.String, Offset = 36, Required = false)]
		public string? PaymentStreamFinalRateRoundingDirection {get; set;}
		
		[TagDetails(Tag = 40805, Type = TagType.Int, Offset = 37, Required = false)]
		public int? PaymentStreamFinalRatePrecision {get; set;}
		
		[TagDetails(Tag = 40806, Type = TagType.Int, Offset = 38, Required = false)]
		public int? PaymentStreamAveragingMethod {get; set;}
		
		[TagDetails(Tag = 40807, Type = TagType.Int, Offset = 39, Required = false)]
		public int? PaymentStreamNegativeRateTreatment {get; set;}
		
		[TagDetails(Tag = 41209, Type = TagType.Int, Offset = 40, Required = false)]
		public int? PaymentStreamCalculationLagPeriod {get; set;}
		
		[TagDetails(Tag = 41210, Type = TagType.String, Offset = 41, Required = false)]
		public string? PaymentStreamCalculationLagUnit {get; set;}
		
		[TagDetails(Tag = 42663, Type = TagType.LocalDate, Offset = 42, Required = false)]
		public DateOnly? PaymentStreamFirstObservationDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42664, Type = TagType.Int, Offset = 43, Required = false)]
		public int? PaymentStreamFirstObservationDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42665, Type = TagType.Int, Offset = 44, Required = false)]
		public int? PaymentStreamFirstObservationDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 41211, Type = TagType.Int, Offset = 45, Required = false)]
		public int? PaymentStreamFirstObservationDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 41212, Type = TagType.String, Offset = 46, Required = false)]
		public string? PaymentStreamFirstObservationDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42666, Type = TagType.LocalDate, Offset = 47, Required = false)]
		public DateOnly? PaymentStreamFirstObservationDateAdjusted {get; set;}
		
		[TagDetails(Tag = 41213, Type = TagType.Int, Offset = 48, Required = false)]
		public int? PaymentStreamPricingDayType {get; set;}
		
		[TagDetails(Tag = 41214, Type = TagType.Int, Offset = 49, Required = false)]
		public int? PaymentStreamPricingDayDistribution {get; set;}
		
		[TagDetails(Tag = 41215, Type = TagType.Int, Offset = 50, Required = false)]
		public int? PaymentStreamPricingDayCount {get; set;}
		
		[TagDetails(Tag = 41216, Type = TagType.String, Offset = 51, Required = false)]
		public string? PaymentStreamPricingBusinessCalendar {get; set;}
		
		[TagDetails(Tag = 41217, Type = TagType.Int, Offset = 52, Required = false)]
		public int? PaymentStreamPricingBusinessDayConvention {get; set;}
		
		[Component(Offset = 53, Required = false)]
		public PaymentStreamPricingBusinessCenterGrp? PaymentStreamPricingBusinessCenterGrp {get; set;}
		
		[Component(Offset = 54, Required = false)]
		public PaymentStreamPricingDayGrp? PaymentStreamPricingDayGrp {get; set;}
		
		[Component(Offset = 55, Required = false)]
		public PaymentStreamPricingDateGrp? PaymentStreamPricingDateGrp {get; set;}
		
		[TagDetails(Tag = 40808, Type = TagType.Int, Offset = 56, Required = false)]
		public int? PaymentStreamInflationLagPeriod {get; set;}
		
		[TagDetails(Tag = 40809, Type = TagType.String, Offset = 57, Required = false)]
		public string? PaymentStreamInflationLagUnit {get; set;}
		
		[TagDetails(Tag = 40810, Type = TagType.Int, Offset = 58, Required = false)]
		public int? PaymentStreamInflationLagDayType {get; set;}
		
		[TagDetails(Tag = 40811, Type = TagType.Int, Offset = 59, Required = false)]
		public int? PaymentStreamInflationInterpolationMethod {get; set;}
		
		[TagDetails(Tag = 40812, Type = TagType.Int, Offset = 60, Required = false)]
		public int? PaymentStreamInflationIndexSource {get; set;}
		
		[TagDetails(Tag = 40813, Type = TagType.String, Offset = 61, Required = false)]
		public string? PaymentStreamInflationPublicationSource {get; set;}
		
		[TagDetails(Tag = 40814, Type = TagType.Float, Offset = 62, Required = false)]
		public double? PaymentStreamInflationInitialIndexLevel {get; set;}
		
		[TagDetails(Tag = 40815, Type = TagType.Boolean, Offset = 63, Required = false)]
		public bool? PaymentStreamInflationFallbackBondApplicable {get; set;}
		
		[TagDetails(Tag = 40816, Type = TagType.Int, Offset = 64, Required = false)]
		public int? PaymentStreamFRADiscounting {get; set;}
		
		[TagDetails(Tag = 42667, Type = TagType.String, Offset = 65, Required = false)]
		public string? PaymentStreamUnderlierRefID {get; set;}
		
		[Component(Offset = 66, Required = false)]
		public PaymentStreamFormula? PaymentStreamFormula {get; set;}
		
		[Component(Offset = 67, Required = false)]
		public DividendConditions? DividendConditions {get; set;}
		
		[TagDetails(Tag = 42668, Type = TagType.Boolean, Offset = 68, Required = false)]
		public bool? ReturnRateNotionalReset {get; set;}
		
		[Component(Offset = 69, Required = false)]
		public ReturnRateGrp? ReturnRateGrp {get; set;}
		
		[TagDetails(Tag = 42669, Type = TagType.Float, Offset = 70, Required = false)]
		public double? PaymentStreamLinkInitialLevel {get; set;}
		
		[TagDetails(Tag = 42670, Type = TagType.Boolean, Offset = 71, Required = false)]
		public bool? PaymentStreamLinkClosingLevelIndicator {get; set;}
		
		[TagDetails(Tag = 42671, Type = TagType.Boolean, Offset = 72, Required = false)]
		public bool? PaymentStreamLinkExpiringLevelIndicator {get; set;}
		
		[TagDetails(Tag = 42672, Type = TagType.Int, Offset = 73, Required = false)]
		public int? PaymentStreamLinkEstimatedTradingDays {get; set;}
		
		[TagDetails(Tag = 42673, Type = TagType.Float, Offset = 74, Required = false)]
		public double? PaymentStreamLinkStrikePrice {get; set;}
		
		[TagDetails(Tag = 42674, Type = TagType.Int, Offset = 75, Required = false)]
		public int? PaymentStreamLinkStrikePriceType {get; set;}
		
		[TagDetails(Tag = 42675, Type = TagType.Float, Offset = 76, Required = false)]
		public double? PaymentStreamLinkMaximumBoundary {get; set;}
		
		[TagDetails(Tag = 42676, Type = TagType.Float, Offset = 77, Required = false)]
		public double? PaymentStreamLinkMinimumBoundary {get; set;}
		
		[TagDetails(Tag = 42677, Type = TagType.Int, Offset = 78, Required = false)]
		public int? PaymentStreamLinkNumberOfDataSeries {get; set;}
		
		[TagDetails(Tag = 42678, Type = TagType.Float, Offset = 79, Required = false)]
		public double? PaymentStreamVarianceUnadjustedCap {get; set;}
		
		[TagDetails(Tag = 42679, Type = TagType.Int, Offset = 80, Required = false)]
		public int? PaymentStreamRealizedVarianceMethod {get; set;}
		
		[TagDetails(Tag = 42680, Type = TagType.Boolean, Offset = 81, Required = false)]
		public bool? PaymentStreamDaysAdjustmentIndicator {get; set;}
		
		[TagDetails(Tag = 42681, Type = TagType.String, Offset = 82, Required = false)]
		public string? PaymentStreamNearestExchangeContractRefID {get; set;}
		
		[TagDetails(Tag = 42682, Type = TagType.Float, Offset = 83, Required = false)]
		public double? PaymentStreamVegaNotionalAmount {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStreamRateIndex is not null) writer.WriteString(40789, PaymentStreamRateIndex);
			if (PaymentStreamRateIndexSource is not null) writer.WriteWholeNumber(40790, PaymentStreamRateIndexSource.Value);
			if (PaymentStreamRateIndexID is not null) writer.WriteString(43090, PaymentStreamRateIndexID);
			if (PaymentStreamRateIndexIDSource is not null) writer.WriteString(43091, PaymentStreamRateIndexIDSource);
			if (PaymentStreamRateIndexCurveUnit is not null) writer.WriteString(40791, PaymentStreamRateIndexCurveUnit);
			if (PaymentStreamRateIndexCurvePeriod is not null) writer.WriteWholeNumber(40792, PaymentStreamRateIndexCurvePeriod.Value);
			if (PaymentStreamRateIndex2 is not null) writer.WriteString(43112, PaymentStreamRateIndex2);
			if (PaymentStreamRateIndex2Source is not null) writer.WriteWholeNumber(43113, PaymentStreamRateIndex2Source.Value);
			if (PaymentStreamRateIndex2ID is not null) writer.WriteString(43114, PaymentStreamRateIndex2ID);
			if (PaymentStreamRateIndex2IDSource is not null) writer.WriteString(43115, PaymentStreamRateIndex2IDSource);
			if (PaymentStreamRateIndex2CurvePeriod is not null) writer.WriteWholeNumber(41194, PaymentStreamRateIndex2CurvePeriod.Value);
			if (PaymentStreamRateIndex2CurveUnit is not null) writer.WriteString(41195, PaymentStreamRateIndex2CurveUnit);
			if (PaymentStreamRateIndexLocation is not null) writer.WriteString(41196, PaymentStreamRateIndexLocation);
			if (PaymentStreamRateIndexLevel is not null) writer.WriteNumber(41197, PaymentStreamRateIndexLevel.Value);
			if (PaymentStreamRateIndexUnitOfMeasure is not null) writer.WriteString(41198, PaymentStreamRateIndexUnitOfMeasure);
			if (PaymentStreamSettlLevel is not null) writer.WriteWholeNumber(41199, PaymentStreamSettlLevel.Value);
			if (PaymentStreamReferenceLevel is not null) writer.WriteNumber(41200, PaymentStreamReferenceLevel.Value);
			if (PaymentStreamReferenceLevelUnitOfMeasure is not null) writer.WriteString(41201, PaymentStreamReferenceLevelUnitOfMeasure);
			if (PaymentStreamReferenceLevelEqualsZeroIndicator is not null) writer.WriteBoolean(41202, PaymentStreamReferenceLevelEqualsZeroIndicator.Value);
			if (PaymentStreamRateMultiplier is not null) writer.WriteNumber(40793, PaymentStreamRateMultiplier.Value);
			if (PaymentStreamRateSpread is not null) writer.WriteNumber(40794, PaymentStreamRateSpread.Value);
			if (PaymentStreamRateSpreadCurrency is not null) writer.WriteString(41203, PaymentStreamRateSpreadCurrency);
			if (PaymentStreamRateSpreadUnitOfMeasure is not null) writer.WriteString(41204, PaymentStreamRateSpreadUnitOfMeasure);
			if (PaymentStreamRateConversionFactor is not null) writer.WriteNumber(41205, PaymentStreamRateConversionFactor.Value);
			if (PaymentStreamRateSpreadType is not null) writer.WriteWholeNumber(41206, PaymentStreamRateSpreadType.Value);
			if (PaymentStreamRateSpreadPositionType is not null) writer.WriteWholeNumber(40795, PaymentStreamRateSpreadPositionType.Value);
			if (PaymentStreamRateTreatment is not null) writer.WriteWholeNumber(40796, PaymentStreamRateTreatment.Value);
			if (PaymentStreamCapRate is not null) writer.WriteNumber(40797, PaymentStreamCapRate.Value);
			if (PaymentStreamCapRateBuySide is not null) writer.WriteWholeNumber(40798, PaymentStreamCapRateBuySide.Value);
			if (PaymentStreamCapRateSellSide is not null) writer.WriteWholeNumber(40799, PaymentStreamCapRateSellSide.Value);
			if (PaymentStreamFloorRate is not null) writer.WriteNumber(40800, PaymentStreamFloorRate.Value);
			if (PaymentStreamFloorRateBuySide is not null) writer.WriteWholeNumber(40801, PaymentStreamFloorRateBuySide.Value);
			if (PaymentStreamFloorRateSellSide is not null) writer.WriteWholeNumber(40802, PaymentStreamFloorRateSellSide.Value);
			if (PaymentStreamInitialRate is not null) writer.WriteNumber(40803, PaymentStreamInitialRate.Value);
			if (PaymentStreamLastResetRate is not null) writer.WriteNumber(41207, PaymentStreamLastResetRate.Value);
			if (PaymentStreamFinalRate is not null) writer.WriteNumber(41208, PaymentStreamFinalRate.Value);
			if (PaymentStreamFinalRateRoundingDirection is not null) writer.WriteString(40804, PaymentStreamFinalRateRoundingDirection);
			if (PaymentStreamFinalRatePrecision is not null) writer.WriteWholeNumber(40805, PaymentStreamFinalRatePrecision.Value);
			if (PaymentStreamAveragingMethod is not null) writer.WriteWholeNumber(40806, PaymentStreamAveragingMethod.Value);
			if (PaymentStreamNegativeRateTreatment is not null) writer.WriteWholeNumber(40807, PaymentStreamNegativeRateTreatment.Value);
			if (PaymentStreamCalculationLagPeriod is not null) writer.WriteWholeNumber(41209, PaymentStreamCalculationLagPeriod.Value);
			if (PaymentStreamCalculationLagUnit is not null) writer.WriteString(41210, PaymentStreamCalculationLagUnit);
			if (PaymentStreamFirstObservationDateUnadjusted is not null) writer.WriteLocalDateOnly(42663, PaymentStreamFirstObservationDateUnadjusted.Value);
			if (PaymentStreamFirstObservationDateRelativeTo is not null) writer.WriteWholeNumber(42664, PaymentStreamFirstObservationDateRelativeTo.Value);
			if (PaymentStreamFirstObservationDateOffsetDayType is not null) writer.WriteWholeNumber(42665, PaymentStreamFirstObservationDateOffsetDayType.Value);
			if (PaymentStreamFirstObservationDateOffsetPeriod is not null) writer.WriteWholeNumber(41211, PaymentStreamFirstObservationDateOffsetPeriod.Value);
			if (PaymentStreamFirstObservationDateOffsetUnit is not null) writer.WriteString(41212, PaymentStreamFirstObservationDateOffsetUnit);
			if (PaymentStreamFirstObservationDateAdjusted is not null) writer.WriteLocalDateOnly(42666, PaymentStreamFirstObservationDateAdjusted.Value);
			if (PaymentStreamPricingDayType is not null) writer.WriteWholeNumber(41213, PaymentStreamPricingDayType.Value);
			if (PaymentStreamPricingDayDistribution is not null) writer.WriteWholeNumber(41214, PaymentStreamPricingDayDistribution.Value);
			if (PaymentStreamPricingDayCount is not null) writer.WriteWholeNumber(41215, PaymentStreamPricingDayCount.Value);
			if (PaymentStreamPricingBusinessCalendar is not null) writer.WriteString(41216, PaymentStreamPricingBusinessCalendar);
			if (PaymentStreamPricingBusinessDayConvention is not null) writer.WriteWholeNumber(41217, PaymentStreamPricingBusinessDayConvention.Value);
			if (PaymentStreamPricingBusinessCenterGrp is not null) ((IFixEncoder)PaymentStreamPricingBusinessCenterGrp).Encode(writer);
			if (PaymentStreamPricingDayGrp is not null) ((IFixEncoder)PaymentStreamPricingDayGrp).Encode(writer);
			if (PaymentStreamPricingDateGrp is not null) ((IFixEncoder)PaymentStreamPricingDateGrp).Encode(writer);
			if (PaymentStreamInflationLagPeriod is not null) writer.WriteWholeNumber(40808, PaymentStreamInflationLagPeriod.Value);
			if (PaymentStreamInflationLagUnit is not null) writer.WriteString(40809, PaymentStreamInflationLagUnit);
			if (PaymentStreamInflationLagDayType is not null) writer.WriteWholeNumber(40810, PaymentStreamInflationLagDayType.Value);
			if (PaymentStreamInflationInterpolationMethod is not null) writer.WriteWholeNumber(40811, PaymentStreamInflationInterpolationMethod.Value);
			if (PaymentStreamInflationIndexSource is not null) writer.WriteWholeNumber(40812, PaymentStreamInflationIndexSource.Value);
			if (PaymentStreamInflationPublicationSource is not null) writer.WriteString(40813, PaymentStreamInflationPublicationSource);
			if (PaymentStreamInflationInitialIndexLevel is not null) writer.WriteNumber(40814, PaymentStreamInflationInitialIndexLevel.Value);
			if (PaymentStreamInflationFallbackBondApplicable is not null) writer.WriteBoolean(40815, PaymentStreamInflationFallbackBondApplicable.Value);
			if (PaymentStreamFRADiscounting is not null) writer.WriteWholeNumber(40816, PaymentStreamFRADiscounting.Value);
			if (PaymentStreamUnderlierRefID is not null) writer.WriteString(42667, PaymentStreamUnderlierRefID);
			if (PaymentStreamFormula is not null) ((IFixEncoder)PaymentStreamFormula).Encode(writer);
			if (DividendConditions is not null) ((IFixEncoder)DividendConditions).Encode(writer);
			if (ReturnRateNotionalReset is not null) writer.WriteBoolean(42668, ReturnRateNotionalReset.Value);
			if (ReturnRateGrp is not null) ((IFixEncoder)ReturnRateGrp).Encode(writer);
			if (PaymentStreamLinkInitialLevel is not null) writer.WriteNumber(42669, PaymentStreamLinkInitialLevel.Value);
			if (PaymentStreamLinkClosingLevelIndicator is not null) writer.WriteBoolean(42670, PaymentStreamLinkClosingLevelIndicator.Value);
			if (PaymentStreamLinkExpiringLevelIndicator is not null) writer.WriteBoolean(42671, PaymentStreamLinkExpiringLevelIndicator.Value);
			if (PaymentStreamLinkEstimatedTradingDays is not null) writer.WriteWholeNumber(42672, PaymentStreamLinkEstimatedTradingDays.Value);
			if (PaymentStreamLinkStrikePrice is not null) writer.WriteNumber(42673, PaymentStreamLinkStrikePrice.Value);
			if (PaymentStreamLinkStrikePriceType is not null) writer.WriteWholeNumber(42674, PaymentStreamLinkStrikePriceType.Value);
			if (PaymentStreamLinkMaximumBoundary is not null) writer.WriteNumber(42675, PaymentStreamLinkMaximumBoundary.Value);
			if (PaymentStreamLinkMinimumBoundary is not null) writer.WriteNumber(42676, PaymentStreamLinkMinimumBoundary.Value);
			if (PaymentStreamLinkNumberOfDataSeries is not null) writer.WriteWholeNumber(42677, PaymentStreamLinkNumberOfDataSeries.Value);
			if (PaymentStreamVarianceUnadjustedCap is not null) writer.WriteNumber(42678, PaymentStreamVarianceUnadjustedCap.Value);
			if (PaymentStreamRealizedVarianceMethod is not null) writer.WriteWholeNumber(42679, PaymentStreamRealizedVarianceMethod.Value);
			if (PaymentStreamDaysAdjustmentIndicator is not null) writer.WriteBoolean(42680, PaymentStreamDaysAdjustmentIndicator.Value);
			if (PaymentStreamNearestExchangeContractRefID is not null) writer.WriteString(42681, PaymentStreamNearestExchangeContractRefID);
			if (PaymentStreamVegaNotionalAmount is not null) writer.WriteNumber(42682, PaymentStreamVegaNotionalAmount.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			PaymentStreamRateIndex = view.GetString(40789);
			PaymentStreamRateIndexSource = view.GetInt32(40790);
			PaymentStreamRateIndexID = view.GetString(43090);
			PaymentStreamRateIndexIDSource = view.GetString(43091);
			PaymentStreamRateIndexCurveUnit = view.GetString(40791);
			PaymentStreamRateIndexCurvePeriod = view.GetInt32(40792);
			PaymentStreamRateIndex2 = view.GetString(43112);
			PaymentStreamRateIndex2Source = view.GetInt32(43113);
			PaymentStreamRateIndex2ID = view.GetString(43114);
			PaymentStreamRateIndex2IDSource = view.GetString(43115);
			PaymentStreamRateIndex2CurvePeriod = view.GetInt32(41194);
			PaymentStreamRateIndex2CurveUnit = view.GetString(41195);
			PaymentStreamRateIndexLocation = view.GetString(41196);
			PaymentStreamRateIndexLevel = view.GetDouble(41197);
			PaymentStreamRateIndexUnitOfMeasure = view.GetString(41198);
			PaymentStreamSettlLevel = view.GetInt32(41199);
			PaymentStreamReferenceLevel = view.GetDouble(41200);
			PaymentStreamReferenceLevelUnitOfMeasure = view.GetString(41201);
			PaymentStreamReferenceLevelEqualsZeroIndicator = view.GetBool(41202);
			PaymentStreamRateMultiplier = view.GetDouble(40793);
			PaymentStreamRateSpread = view.GetDouble(40794);
			PaymentStreamRateSpreadCurrency = view.GetString(41203);
			PaymentStreamRateSpreadUnitOfMeasure = view.GetString(41204);
			PaymentStreamRateConversionFactor = view.GetDouble(41205);
			PaymentStreamRateSpreadType = view.GetInt32(41206);
			PaymentStreamRateSpreadPositionType = view.GetInt32(40795);
			PaymentStreamRateTreatment = view.GetInt32(40796);
			PaymentStreamCapRate = view.GetDouble(40797);
			PaymentStreamCapRateBuySide = view.GetInt32(40798);
			PaymentStreamCapRateSellSide = view.GetInt32(40799);
			PaymentStreamFloorRate = view.GetDouble(40800);
			PaymentStreamFloorRateBuySide = view.GetInt32(40801);
			PaymentStreamFloorRateSellSide = view.GetInt32(40802);
			PaymentStreamInitialRate = view.GetDouble(40803);
			PaymentStreamLastResetRate = view.GetDouble(41207);
			PaymentStreamFinalRate = view.GetDouble(41208);
			PaymentStreamFinalRateRoundingDirection = view.GetString(40804);
			PaymentStreamFinalRatePrecision = view.GetInt32(40805);
			PaymentStreamAveragingMethod = view.GetInt32(40806);
			PaymentStreamNegativeRateTreatment = view.GetInt32(40807);
			PaymentStreamCalculationLagPeriod = view.GetInt32(41209);
			PaymentStreamCalculationLagUnit = view.GetString(41210);
			PaymentStreamFirstObservationDateUnadjusted = view.GetDateOnly(42663);
			PaymentStreamFirstObservationDateRelativeTo = view.GetInt32(42664);
			PaymentStreamFirstObservationDateOffsetDayType = view.GetInt32(42665);
			PaymentStreamFirstObservationDateOffsetPeriod = view.GetInt32(41211);
			PaymentStreamFirstObservationDateOffsetUnit = view.GetString(41212);
			PaymentStreamFirstObservationDateAdjusted = view.GetDateOnly(42666);
			PaymentStreamPricingDayType = view.GetInt32(41213);
			PaymentStreamPricingDayDistribution = view.GetInt32(41214);
			PaymentStreamPricingDayCount = view.GetInt32(41215);
			PaymentStreamPricingBusinessCalendar = view.GetString(41216);
			PaymentStreamPricingBusinessDayConvention = view.GetInt32(41217);
			if (view.GetView("PaymentStreamPricingBusinessCenterGrp") is IMessageView viewPaymentStreamPricingBusinessCenterGrp)
			{
				PaymentStreamPricingBusinessCenterGrp = new();
				((IFixParser)PaymentStreamPricingBusinessCenterGrp).Parse(viewPaymentStreamPricingBusinessCenterGrp);
			}
			if (view.GetView("PaymentStreamPricingDayGrp") is IMessageView viewPaymentStreamPricingDayGrp)
			{
				PaymentStreamPricingDayGrp = new();
				((IFixParser)PaymentStreamPricingDayGrp).Parse(viewPaymentStreamPricingDayGrp);
			}
			if (view.GetView("PaymentStreamPricingDateGrp") is IMessageView viewPaymentStreamPricingDateGrp)
			{
				PaymentStreamPricingDateGrp = new();
				((IFixParser)PaymentStreamPricingDateGrp).Parse(viewPaymentStreamPricingDateGrp);
			}
			PaymentStreamInflationLagPeriod = view.GetInt32(40808);
			PaymentStreamInflationLagUnit = view.GetString(40809);
			PaymentStreamInflationLagDayType = view.GetInt32(40810);
			PaymentStreamInflationInterpolationMethod = view.GetInt32(40811);
			PaymentStreamInflationIndexSource = view.GetInt32(40812);
			PaymentStreamInflationPublicationSource = view.GetString(40813);
			PaymentStreamInflationInitialIndexLevel = view.GetDouble(40814);
			PaymentStreamInflationFallbackBondApplicable = view.GetBool(40815);
			PaymentStreamFRADiscounting = view.GetInt32(40816);
			PaymentStreamUnderlierRefID = view.GetString(42667);
			if (view.GetView("PaymentStreamFormula") is IMessageView viewPaymentStreamFormula)
			{
				PaymentStreamFormula = new();
				((IFixParser)PaymentStreamFormula).Parse(viewPaymentStreamFormula);
			}
			if (view.GetView("DividendConditions") is IMessageView viewDividendConditions)
			{
				DividendConditions = new();
				((IFixParser)DividendConditions).Parse(viewDividendConditions);
			}
			ReturnRateNotionalReset = view.GetBool(42668);
			if (view.GetView("ReturnRateGrp") is IMessageView viewReturnRateGrp)
			{
				ReturnRateGrp = new();
				((IFixParser)ReturnRateGrp).Parse(viewReturnRateGrp);
			}
			PaymentStreamLinkInitialLevel = view.GetDouble(42669);
			PaymentStreamLinkClosingLevelIndicator = view.GetBool(42670);
			PaymentStreamLinkExpiringLevelIndicator = view.GetBool(42671);
			PaymentStreamLinkEstimatedTradingDays = view.GetInt32(42672);
			PaymentStreamLinkStrikePrice = view.GetDouble(42673);
			PaymentStreamLinkStrikePriceType = view.GetInt32(42674);
			PaymentStreamLinkMaximumBoundary = view.GetDouble(42675);
			PaymentStreamLinkMinimumBoundary = view.GetDouble(42676);
			PaymentStreamLinkNumberOfDataSeries = view.GetInt32(42677);
			PaymentStreamVarianceUnadjustedCap = view.GetDouble(42678);
			PaymentStreamRealizedVarianceMethod = view.GetInt32(42679);
			PaymentStreamDaysAdjustmentIndicator = view.GetBool(42680);
			PaymentStreamNearestExchangeContractRefID = view.GetString(42681);
			PaymentStreamVegaNotionalAmount = view.GetDouble(42682);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "PaymentStreamRateIndex":
				{
					value = PaymentStreamRateIndex;
					break;
				}
				case "PaymentStreamRateIndexSource":
				{
					value = PaymentStreamRateIndexSource;
					break;
				}
				case "PaymentStreamRateIndexID":
				{
					value = PaymentStreamRateIndexID;
					break;
				}
				case "PaymentStreamRateIndexIDSource":
				{
					value = PaymentStreamRateIndexIDSource;
					break;
				}
				case "PaymentStreamRateIndexCurveUnit":
				{
					value = PaymentStreamRateIndexCurveUnit;
					break;
				}
				case "PaymentStreamRateIndexCurvePeriod":
				{
					value = PaymentStreamRateIndexCurvePeriod;
					break;
				}
				case "PaymentStreamRateIndex2":
				{
					value = PaymentStreamRateIndex2;
					break;
				}
				case "PaymentStreamRateIndex2Source":
				{
					value = PaymentStreamRateIndex2Source;
					break;
				}
				case "PaymentStreamRateIndex2ID":
				{
					value = PaymentStreamRateIndex2ID;
					break;
				}
				case "PaymentStreamRateIndex2IDSource":
				{
					value = PaymentStreamRateIndex2IDSource;
					break;
				}
				case "PaymentStreamRateIndex2CurvePeriod":
				{
					value = PaymentStreamRateIndex2CurvePeriod;
					break;
				}
				case "PaymentStreamRateIndex2CurveUnit":
				{
					value = PaymentStreamRateIndex2CurveUnit;
					break;
				}
				case "PaymentStreamRateIndexLocation":
				{
					value = PaymentStreamRateIndexLocation;
					break;
				}
				case "PaymentStreamRateIndexLevel":
				{
					value = PaymentStreamRateIndexLevel;
					break;
				}
				case "PaymentStreamRateIndexUnitOfMeasure":
				{
					value = PaymentStreamRateIndexUnitOfMeasure;
					break;
				}
				case "PaymentStreamSettlLevel":
				{
					value = PaymentStreamSettlLevel;
					break;
				}
				case "PaymentStreamReferenceLevel":
				{
					value = PaymentStreamReferenceLevel;
					break;
				}
				case "PaymentStreamReferenceLevelUnitOfMeasure":
				{
					value = PaymentStreamReferenceLevelUnitOfMeasure;
					break;
				}
				case "PaymentStreamReferenceLevelEqualsZeroIndicator":
				{
					value = PaymentStreamReferenceLevelEqualsZeroIndicator;
					break;
				}
				case "PaymentStreamRateMultiplier":
				{
					value = PaymentStreamRateMultiplier;
					break;
				}
				case "PaymentStreamRateSpread":
				{
					value = PaymentStreamRateSpread;
					break;
				}
				case "PaymentStreamRateSpreadCurrency":
				{
					value = PaymentStreamRateSpreadCurrency;
					break;
				}
				case "PaymentStreamRateSpreadUnitOfMeasure":
				{
					value = PaymentStreamRateSpreadUnitOfMeasure;
					break;
				}
				case "PaymentStreamRateConversionFactor":
				{
					value = PaymentStreamRateConversionFactor;
					break;
				}
				case "PaymentStreamRateSpreadType":
				{
					value = PaymentStreamRateSpreadType;
					break;
				}
				case "PaymentStreamRateSpreadPositionType":
				{
					value = PaymentStreamRateSpreadPositionType;
					break;
				}
				case "PaymentStreamRateTreatment":
				{
					value = PaymentStreamRateTreatment;
					break;
				}
				case "PaymentStreamCapRate":
				{
					value = PaymentStreamCapRate;
					break;
				}
				case "PaymentStreamCapRateBuySide":
				{
					value = PaymentStreamCapRateBuySide;
					break;
				}
				case "PaymentStreamCapRateSellSide":
				{
					value = PaymentStreamCapRateSellSide;
					break;
				}
				case "PaymentStreamFloorRate":
				{
					value = PaymentStreamFloorRate;
					break;
				}
				case "PaymentStreamFloorRateBuySide":
				{
					value = PaymentStreamFloorRateBuySide;
					break;
				}
				case "PaymentStreamFloorRateSellSide":
				{
					value = PaymentStreamFloorRateSellSide;
					break;
				}
				case "PaymentStreamInitialRate":
				{
					value = PaymentStreamInitialRate;
					break;
				}
				case "PaymentStreamLastResetRate":
				{
					value = PaymentStreamLastResetRate;
					break;
				}
				case "PaymentStreamFinalRate":
				{
					value = PaymentStreamFinalRate;
					break;
				}
				case "PaymentStreamFinalRateRoundingDirection":
				{
					value = PaymentStreamFinalRateRoundingDirection;
					break;
				}
				case "PaymentStreamFinalRatePrecision":
				{
					value = PaymentStreamFinalRatePrecision;
					break;
				}
				case "PaymentStreamAveragingMethod":
				{
					value = PaymentStreamAveragingMethod;
					break;
				}
				case "PaymentStreamNegativeRateTreatment":
				{
					value = PaymentStreamNegativeRateTreatment;
					break;
				}
				case "PaymentStreamCalculationLagPeriod":
				{
					value = PaymentStreamCalculationLagPeriod;
					break;
				}
				case "PaymentStreamCalculationLagUnit":
				{
					value = PaymentStreamCalculationLagUnit;
					break;
				}
				case "PaymentStreamFirstObservationDateUnadjusted":
				{
					value = PaymentStreamFirstObservationDateUnadjusted;
					break;
				}
				case "PaymentStreamFirstObservationDateRelativeTo":
				{
					value = PaymentStreamFirstObservationDateRelativeTo;
					break;
				}
				case "PaymentStreamFirstObservationDateOffsetDayType":
				{
					value = PaymentStreamFirstObservationDateOffsetDayType;
					break;
				}
				case "PaymentStreamFirstObservationDateOffsetPeriod":
				{
					value = PaymentStreamFirstObservationDateOffsetPeriod;
					break;
				}
				case "PaymentStreamFirstObservationDateOffsetUnit":
				{
					value = PaymentStreamFirstObservationDateOffsetUnit;
					break;
				}
				case "PaymentStreamFirstObservationDateAdjusted":
				{
					value = PaymentStreamFirstObservationDateAdjusted;
					break;
				}
				case "PaymentStreamPricingDayType":
				{
					value = PaymentStreamPricingDayType;
					break;
				}
				case "PaymentStreamPricingDayDistribution":
				{
					value = PaymentStreamPricingDayDistribution;
					break;
				}
				case "PaymentStreamPricingDayCount":
				{
					value = PaymentStreamPricingDayCount;
					break;
				}
				case "PaymentStreamPricingBusinessCalendar":
				{
					value = PaymentStreamPricingBusinessCalendar;
					break;
				}
				case "PaymentStreamPricingBusinessDayConvention":
				{
					value = PaymentStreamPricingBusinessDayConvention;
					break;
				}
				case "PaymentStreamPricingBusinessCenterGrp":
				{
					value = PaymentStreamPricingBusinessCenterGrp;
					break;
				}
				case "PaymentStreamPricingDayGrp":
				{
					value = PaymentStreamPricingDayGrp;
					break;
				}
				case "PaymentStreamPricingDateGrp":
				{
					value = PaymentStreamPricingDateGrp;
					break;
				}
				case "PaymentStreamInflationLagPeriod":
				{
					value = PaymentStreamInflationLagPeriod;
					break;
				}
				case "PaymentStreamInflationLagUnit":
				{
					value = PaymentStreamInflationLagUnit;
					break;
				}
				case "PaymentStreamInflationLagDayType":
				{
					value = PaymentStreamInflationLagDayType;
					break;
				}
				case "PaymentStreamInflationInterpolationMethod":
				{
					value = PaymentStreamInflationInterpolationMethod;
					break;
				}
				case "PaymentStreamInflationIndexSource":
				{
					value = PaymentStreamInflationIndexSource;
					break;
				}
				case "PaymentStreamInflationPublicationSource":
				{
					value = PaymentStreamInflationPublicationSource;
					break;
				}
				case "PaymentStreamInflationInitialIndexLevel":
				{
					value = PaymentStreamInflationInitialIndexLevel;
					break;
				}
				case "PaymentStreamInflationFallbackBondApplicable":
				{
					value = PaymentStreamInflationFallbackBondApplicable;
					break;
				}
				case "PaymentStreamFRADiscounting":
				{
					value = PaymentStreamFRADiscounting;
					break;
				}
				case "PaymentStreamUnderlierRefID":
				{
					value = PaymentStreamUnderlierRefID;
					break;
				}
				case "PaymentStreamFormula":
				{
					value = PaymentStreamFormula;
					break;
				}
				case "DividendConditions":
				{
					value = DividendConditions;
					break;
				}
				case "ReturnRateNotionalReset":
				{
					value = ReturnRateNotionalReset;
					break;
				}
				case "ReturnRateGrp":
				{
					value = ReturnRateGrp;
					break;
				}
				case "PaymentStreamLinkInitialLevel":
				{
					value = PaymentStreamLinkInitialLevel;
					break;
				}
				case "PaymentStreamLinkClosingLevelIndicator":
				{
					value = PaymentStreamLinkClosingLevelIndicator;
					break;
				}
				case "PaymentStreamLinkExpiringLevelIndicator":
				{
					value = PaymentStreamLinkExpiringLevelIndicator;
					break;
				}
				case "PaymentStreamLinkEstimatedTradingDays":
				{
					value = PaymentStreamLinkEstimatedTradingDays;
					break;
				}
				case "PaymentStreamLinkStrikePrice":
				{
					value = PaymentStreamLinkStrikePrice;
					break;
				}
				case "PaymentStreamLinkStrikePriceType":
				{
					value = PaymentStreamLinkStrikePriceType;
					break;
				}
				case "PaymentStreamLinkMaximumBoundary":
				{
					value = PaymentStreamLinkMaximumBoundary;
					break;
				}
				case "PaymentStreamLinkMinimumBoundary":
				{
					value = PaymentStreamLinkMinimumBoundary;
					break;
				}
				case "PaymentStreamLinkNumberOfDataSeries":
				{
					value = PaymentStreamLinkNumberOfDataSeries;
					break;
				}
				case "PaymentStreamVarianceUnadjustedCap":
				{
					value = PaymentStreamVarianceUnadjustedCap;
					break;
				}
				case "PaymentStreamRealizedVarianceMethod":
				{
					value = PaymentStreamRealizedVarianceMethod;
					break;
				}
				case "PaymentStreamDaysAdjustmentIndicator":
				{
					value = PaymentStreamDaysAdjustmentIndicator;
					break;
				}
				case "PaymentStreamNearestExchangeContractRefID":
				{
					value = PaymentStreamNearestExchangeContractRefID;
					break;
				}
				case "PaymentStreamVegaNotionalAmount":
				{
					value = PaymentStreamVegaNotionalAmount;
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
			PaymentStreamRateIndex = null;
			PaymentStreamRateIndexSource = null;
			PaymentStreamRateIndexID = null;
			PaymentStreamRateIndexIDSource = null;
			PaymentStreamRateIndexCurveUnit = null;
			PaymentStreamRateIndexCurvePeriod = null;
			PaymentStreamRateIndex2 = null;
			PaymentStreamRateIndex2Source = null;
			PaymentStreamRateIndex2ID = null;
			PaymentStreamRateIndex2IDSource = null;
			PaymentStreamRateIndex2CurvePeriod = null;
			PaymentStreamRateIndex2CurveUnit = null;
			PaymentStreamRateIndexLocation = null;
			PaymentStreamRateIndexLevel = null;
			PaymentStreamRateIndexUnitOfMeasure = null;
			PaymentStreamSettlLevel = null;
			PaymentStreamReferenceLevel = null;
			PaymentStreamReferenceLevelUnitOfMeasure = null;
			PaymentStreamReferenceLevelEqualsZeroIndicator = null;
			PaymentStreamRateMultiplier = null;
			PaymentStreamRateSpread = null;
			PaymentStreamRateSpreadCurrency = null;
			PaymentStreamRateSpreadUnitOfMeasure = null;
			PaymentStreamRateConversionFactor = null;
			PaymentStreamRateSpreadType = null;
			PaymentStreamRateSpreadPositionType = null;
			PaymentStreamRateTreatment = null;
			PaymentStreamCapRate = null;
			PaymentStreamCapRateBuySide = null;
			PaymentStreamCapRateSellSide = null;
			PaymentStreamFloorRate = null;
			PaymentStreamFloorRateBuySide = null;
			PaymentStreamFloorRateSellSide = null;
			PaymentStreamInitialRate = null;
			PaymentStreamLastResetRate = null;
			PaymentStreamFinalRate = null;
			PaymentStreamFinalRateRoundingDirection = null;
			PaymentStreamFinalRatePrecision = null;
			PaymentStreamAveragingMethod = null;
			PaymentStreamNegativeRateTreatment = null;
			PaymentStreamCalculationLagPeriod = null;
			PaymentStreamCalculationLagUnit = null;
			PaymentStreamFirstObservationDateUnadjusted = null;
			PaymentStreamFirstObservationDateRelativeTo = null;
			PaymentStreamFirstObservationDateOffsetDayType = null;
			PaymentStreamFirstObservationDateOffsetPeriod = null;
			PaymentStreamFirstObservationDateOffsetUnit = null;
			PaymentStreamFirstObservationDateAdjusted = null;
			PaymentStreamPricingDayType = null;
			PaymentStreamPricingDayDistribution = null;
			PaymentStreamPricingDayCount = null;
			PaymentStreamPricingBusinessCalendar = null;
			PaymentStreamPricingBusinessDayConvention = null;
			((IFixReset?)PaymentStreamPricingBusinessCenterGrp)?.Reset();
			((IFixReset?)PaymentStreamPricingDayGrp)?.Reset();
			((IFixReset?)PaymentStreamPricingDateGrp)?.Reset();
			PaymentStreamInflationLagPeriod = null;
			PaymentStreamInflationLagUnit = null;
			PaymentStreamInflationLagDayType = null;
			PaymentStreamInflationInterpolationMethod = null;
			PaymentStreamInflationIndexSource = null;
			PaymentStreamInflationPublicationSource = null;
			PaymentStreamInflationInitialIndexLevel = null;
			PaymentStreamInflationFallbackBondApplicable = null;
			PaymentStreamFRADiscounting = null;
			PaymentStreamUnderlierRefID = null;
			((IFixReset?)PaymentStreamFormula)?.Reset();
			((IFixReset?)DividendConditions)?.Reset();
			ReturnRateNotionalReset = null;
			((IFixReset?)ReturnRateGrp)?.Reset();
			PaymentStreamLinkInitialLevel = null;
			PaymentStreamLinkClosingLevelIndicator = null;
			PaymentStreamLinkExpiringLevelIndicator = null;
			PaymentStreamLinkEstimatedTradingDays = null;
			PaymentStreamLinkStrikePrice = null;
			PaymentStreamLinkStrikePriceType = null;
			PaymentStreamLinkMaximumBoundary = null;
			PaymentStreamLinkMinimumBoundary = null;
			PaymentStreamLinkNumberOfDataSeries = null;
			PaymentStreamVarianceUnadjustedCap = null;
			PaymentStreamRealizedVarianceMethod = null;
			PaymentStreamDaysAdjustmentIndicator = null;
			PaymentStreamNearestExchangeContractRefID = null;
			PaymentStreamVegaNotionalAmount = null;
		}
	}
}
