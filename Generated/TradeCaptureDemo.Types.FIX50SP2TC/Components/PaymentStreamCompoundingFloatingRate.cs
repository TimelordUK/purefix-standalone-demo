using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStreamCompoundingFloatingRate : IFixComponent
	{
		[TagDetails(Tag = 42628, Type = TagType.String, Offset = 0, Required = false)]
		public string? PaymentStreamCompoundingRateIndex {get; set;}
		
		[TagDetails(Tag = 42629, Type = TagType.Int, Offset = 1, Required = false)]
		public int? PaymentStreamCompoundingRateIndexCurvePeriod {get; set;}
		
		[TagDetails(Tag = 42630, Type = TagType.String, Offset = 2, Required = false)]
		public string? PaymentStreamCompoundingRateIndexCurveUnit {get; set;}
		
		[TagDetails(Tag = 42631, Type = TagType.Float, Offset = 3, Required = false)]
		public double? PaymentStreamCompoundingRateMultiplier {get; set;}
		
		[TagDetails(Tag = 42632, Type = TagType.Float, Offset = 4, Required = false)]
		public double? PaymentStreamCompoundingRateSpread {get; set;}
		
		[TagDetails(Tag = 42633, Type = TagType.Int, Offset = 5, Required = false)]
		public int? PaymentStreamCompoundingRateSpreadPositionType {get; set;}
		
		[TagDetails(Tag = 42634, Type = TagType.Int, Offset = 6, Required = false)]
		public int? PaymentStreamCompoundingRateTreatment {get; set;}
		
		[TagDetails(Tag = 42635, Type = TagType.Float, Offset = 7, Required = false)]
		public double? PaymentStreamCompoundingCapRate {get; set;}
		
		[TagDetails(Tag = 42636, Type = TagType.Int, Offset = 8, Required = false)]
		public int? PaymentStreamCompoundingCapRateBuySide {get; set;}
		
		[TagDetails(Tag = 42637, Type = TagType.Int, Offset = 9, Required = false)]
		public int? PaymentStreamCompoundingCapRateSellSide {get; set;}
		
		[TagDetails(Tag = 42638, Type = TagType.Float, Offset = 10, Required = false)]
		public double? PaymentStreamCompoundingFloorRate {get; set;}
		
		[TagDetails(Tag = 42639, Type = TagType.Int, Offset = 11, Required = false)]
		public int? PaymentStreamCompoundingFloorRateBuySide {get; set;}
		
		[TagDetails(Tag = 42640, Type = TagType.Int, Offset = 12, Required = false)]
		public int? PaymentStreamCompoundingFloorRateSellSide {get; set;}
		
		[TagDetails(Tag = 42641, Type = TagType.Float, Offset = 13, Required = false)]
		public double? PaymentStreamCompoundingInitialRate {get; set;}
		
		[TagDetails(Tag = 42642, Type = TagType.String, Offset = 14, Required = false)]
		public string? PaymentStreamCompoundingFinalRateRoundingDirection {get; set;}
		
		[TagDetails(Tag = 42643, Type = TagType.Int, Offset = 15, Required = false)]
		public int? PaymentStreamCompoundingFinalRatePrecision {get; set;}
		
		[TagDetails(Tag = 42644, Type = TagType.Int, Offset = 16, Required = false)]
		public int? PaymentStreamCompoundingAveragingMethod {get; set;}
		
		[TagDetails(Tag = 42645, Type = TagType.Int, Offset = 17, Required = false)]
		public int? PaymentStreamCompoundingNegativeRateTreatment {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStreamCompoundingRateIndex is not null) writer.WriteString(42628, PaymentStreamCompoundingRateIndex);
			if (PaymentStreamCompoundingRateIndexCurvePeriod is not null) writer.WriteWholeNumber(42629, PaymentStreamCompoundingRateIndexCurvePeriod.Value);
			if (PaymentStreamCompoundingRateIndexCurveUnit is not null) writer.WriteString(42630, PaymentStreamCompoundingRateIndexCurveUnit);
			if (PaymentStreamCompoundingRateMultiplier is not null) writer.WriteNumber(42631, PaymentStreamCompoundingRateMultiplier.Value);
			if (PaymentStreamCompoundingRateSpread is not null) writer.WriteNumber(42632, PaymentStreamCompoundingRateSpread.Value);
			if (PaymentStreamCompoundingRateSpreadPositionType is not null) writer.WriteWholeNumber(42633, PaymentStreamCompoundingRateSpreadPositionType.Value);
			if (PaymentStreamCompoundingRateTreatment is not null) writer.WriteWholeNumber(42634, PaymentStreamCompoundingRateTreatment.Value);
			if (PaymentStreamCompoundingCapRate is not null) writer.WriteNumber(42635, PaymentStreamCompoundingCapRate.Value);
			if (PaymentStreamCompoundingCapRateBuySide is not null) writer.WriteWholeNumber(42636, PaymentStreamCompoundingCapRateBuySide.Value);
			if (PaymentStreamCompoundingCapRateSellSide is not null) writer.WriteWholeNumber(42637, PaymentStreamCompoundingCapRateSellSide.Value);
			if (PaymentStreamCompoundingFloorRate is not null) writer.WriteNumber(42638, PaymentStreamCompoundingFloorRate.Value);
			if (PaymentStreamCompoundingFloorRateBuySide is not null) writer.WriteWholeNumber(42639, PaymentStreamCompoundingFloorRateBuySide.Value);
			if (PaymentStreamCompoundingFloorRateSellSide is not null) writer.WriteWholeNumber(42640, PaymentStreamCompoundingFloorRateSellSide.Value);
			if (PaymentStreamCompoundingInitialRate is not null) writer.WriteNumber(42641, PaymentStreamCompoundingInitialRate.Value);
			if (PaymentStreamCompoundingFinalRateRoundingDirection is not null) writer.WriteString(42642, PaymentStreamCompoundingFinalRateRoundingDirection);
			if (PaymentStreamCompoundingFinalRatePrecision is not null) writer.WriteWholeNumber(42643, PaymentStreamCompoundingFinalRatePrecision.Value);
			if (PaymentStreamCompoundingAveragingMethod is not null) writer.WriteWholeNumber(42644, PaymentStreamCompoundingAveragingMethod.Value);
			if (PaymentStreamCompoundingNegativeRateTreatment is not null) writer.WriteWholeNumber(42645, PaymentStreamCompoundingNegativeRateTreatment.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			PaymentStreamCompoundingRateIndex = view.GetString(42628);
			PaymentStreamCompoundingRateIndexCurvePeriod = view.GetInt32(42629);
			PaymentStreamCompoundingRateIndexCurveUnit = view.GetString(42630);
			PaymentStreamCompoundingRateMultiplier = view.GetDouble(42631);
			PaymentStreamCompoundingRateSpread = view.GetDouble(42632);
			PaymentStreamCompoundingRateSpreadPositionType = view.GetInt32(42633);
			PaymentStreamCompoundingRateTreatment = view.GetInt32(42634);
			PaymentStreamCompoundingCapRate = view.GetDouble(42635);
			PaymentStreamCompoundingCapRateBuySide = view.GetInt32(42636);
			PaymentStreamCompoundingCapRateSellSide = view.GetInt32(42637);
			PaymentStreamCompoundingFloorRate = view.GetDouble(42638);
			PaymentStreamCompoundingFloorRateBuySide = view.GetInt32(42639);
			PaymentStreamCompoundingFloorRateSellSide = view.GetInt32(42640);
			PaymentStreamCompoundingInitialRate = view.GetDouble(42641);
			PaymentStreamCompoundingFinalRateRoundingDirection = view.GetString(42642);
			PaymentStreamCompoundingFinalRatePrecision = view.GetInt32(42643);
			PaymentStreamCompoundingAveragingMethod = view.GetInt32(42644);
			PaymentStreamCompoundingNegativeRateTreatment = view.GetInt32(42645);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "PaymentStreamCompoundingRateIndex":
				{
					value = PaymentStreamCompoundingRateIndex;
					break;
				}
				case "PaymentStreamCompoundingRateIndexCurvePeriod":
				{
					value = PaymentStreamCompoundingRateIndexCurvePeriod;
					break;
				}
				case "PaymentStreamCompoundingRateIndexCurveUnit":
				{
					value = PaymentStreamCompoundingRateIndexCurveUnit;
					break;
				}
				case "PaymentStreamCompoundingRateMultiplier":
				{
					value = PaymentStreamCompoundingRateMultiplier;
					break;
				}
				case "PaymentStreamCompoundingRateSpread":
				{
					value = PaymentStreamCompoundingRateSpread;
					break;
				}
				case "PaymentStreamCompoundingRateSpreadPositionType":
				{
					value = PaymentStreamCompoundingRateSpreadPositionType;
					break;
				}
				case "PaymentStreamCompoundingRateTreatment":
				{
					value = PaymentStreamCompoundingRateTreatment;
					break;
				}
				case "PaymentStreamCompoundingCapRate":
				{
					value = PaymentStreamCompoundingCapRate;
					break;
				}
				case "PaymentStreamCompoundingCapRateBuySide":
				{
					value = PaymentStreamCompoundingCapRateBuySide;
					break;
				}
				case "PaymentStreamCompoundingCapRateSellSide":
				{
					value = PaymentStreamCompoundingCapRateSellSide;
					break;
				}
				case "PaymentStreamCompoundingFloorRate":
				{
					value = PaymentStreamCompoundingFloorRate;
					break;
				}
				case "PaymentStreamCompoundingFloorRateBuySide":
				{
					value = PaymentStreamCompoundingFloorRateBuySide;
					break;
				}
				case "PaymentStreamCompoundingFloorRateSellSide":
				{
					value = PaymentStreamCompoundingFloorRateSellSide;
					break;
				}
				case "PaymentStreamCompoundingInitialRate":
				{
					value = PaymentStreamCompoundingInitialRate;
					break;
				}
				case "PaymentStreamCompoundingFinalRateRoundingDirection":
				{
					value = PaymentStreamCompoundingFinalRateRoundingDirection;
					break;
				}
				case "PaymentStreamCompoundingFinalRatePrecision":
				{
					value = PaymentStreamCompoundingFinalRatePrecision;
					break;
				}
				case "PaymentStreamCompoundingAveragingMethod":
				{
					value = PaymentStreamCompoundingAveragingMethod;
					break;
				}
				case "PaymentStreamCompoundingNegativeRateTreatment":
				{
					value = PaymentStreamCompoundingNegativeRateTreatment;
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
			PaymentStreamCompoundingRateIndex = null;
			PaymentStreamCompoundingRateIndexCurvePeriod = null;
			PaymentStreamCompoundingRateIndexCurveUnit = null;
			PaymentStreamCompoundingRateMultiplier = null;
			PaymentStreamCompoundingRateSpread = null;
			PaymentStreamCompoundingRateSpreadPositionType = null;
			PaymentStreamCompoundingRateTreatment = null;
			PaymentStreamCompoundingCapRate = null;
			PaymentStreamCompoundingCapRateBuySide = null;
			PaymentStreamCompoundingCapRateSellSide = null;
			PaymentStreamCompoundingFloorRate = null;
			PaymentStreamCompoundingFloorRateBuySide = null;
			PaymentStreamCompoundingFloorRateSellSide = null;
			PaymentStreamCompoundingInitialRate = null;
			PaymentStreamCompoundingFinalRateRoundingDirection = null;
			PaymentStreamCompoundingFinalRatePrecision = null;
			PaymentStreamCompoundingAveragingMethod = null;
			PaymentStreamCompoundingNegativeRateTreatment = null;
		}
	}
}
