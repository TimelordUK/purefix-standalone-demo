using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStreamCompoundingFloatingRate : IFixComponent
	{
		[TagDetails(Tag = 42427, Type = TagType.String, Offset = 0, Required = false)]
		public string? LegPaymentStreamCompoundingRateIndex {get; set;}
		
		[TagDetails(Tag = 42428, Type = TagType.Int, Offset = 1, Required = false)]
		public int? LegPaymentStreamCompoundingRateIndexCurvePeriod {get; set;}
		
		[TagDetails(Tag = 42429, Type = TagType.String, Offset = 2, Required = false)]
		public string? LegPaymentStreamCompoundingRateIndexCurveUnit {get; set;}
		
		[TagDetails(Tag = 42430, Type = TagType.Float, Offset = 3, Required = false)]
		public double? LegPaymentStreamCompoundingRateMultiplier {get; set;}
		
		[TagDetails(Tag = 42431, Type = TagType.Float, Offset = 4, Required = false)]
		public double? LegPaymentStreamCompoundingRateSpread {get; set;}
		
		[TagDetails(Tag = 42432, Type = TagType.Int, Offset = 5, Required = false)]
		public int? LegPaymentStreamCompoundingRateSpreadPositionType {get; set;}
		
		[TagDetails(Tag = 42433, Type = TagType.Int, Offset = 6, Required = false)]
		public int? LegPaymentStreamCompoundingRateTreatment {get; set;}
		
		[TagDetails(Tag = 42434, Type = TagType.Float, Offset = 7, Required = false)]
		public double? LegPaymentStreamCompoundingCapRate {get; set;}
		
		[TagDetails(Tag = 42435, Type = TagType.Int, Offset = 8, Required = false)]
		public int? LegPaymentStreamCompoundingCapRateBuySide {get; set;}
		
		[TagDetails(Tag = 42436, Type = TagType.Int, Offset = 9, Required = false)]
		public int? LegPaymentStreamCompoundingCapRateSellSide {get; set;}
		
		[TagDetails(Tag = 42437, Type = TagType.Float, Offset = 10, Required = false)]
		public double? LegPaymentStreamCompoundingFloorRate {get; set;}
		
		[TagDetails(Tag = 42438, Type = TagType.Int, Offset = 11, Required = false)]
		public int? LegPaymentStreamCompoundingFloorRateBuySide {get; set;}
		
		[TagDetails(Tag = 42439, Type = TagType.Int, Offset = 12, Required = false)]
		public int? LegPaymentStreamCompoundingFloorRateSellSide {get; set;}
		
		[TagDetails(Tag = 42440, Type = TagType.Float, Offset = 13, Required = false)]
		public double? LegPaymentStreamCompoundingInitialRate {get; set;}
		
		[TagDetails(Tag = 42441, Type = TagType.String, Offset = 14, Required = false)]
		public string? LegPaymentStreamCompoundingFinalRateRoundingDirection {get; set;}
		
		[TagDetails(Tag = 42442, Type = TagType.Int, Offset = 15, Required = false)]
		public int? LegPaymentStreamCompoundingFinalRatePrecision {get; set;}
		
		[TagDetails(Tag = 42443, Type = TagType.Int, Offset = 16, Required = false)]
		public int? LegPaymentStreamCompoundingAveragingMethod {get; set;}
		
		[TagDetails(Tag = 42444, Type = TagType.Int, Offset = 17, Required = false)]
		public int? LegPaymentStreamCompoundingNegativeRateTreatment {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStreamCompoundingRateIndex is not null) writer.WriteString(42427, LegPaymentStreamCompoundingRateIndex);
			if (LegPaymentStreamCompoundingRateIndexCurvePeriod is not null) writer.WriteWholeNumber(42428, LegPaymentStreamCompoundingRateIndexCurvePeriod.Value);
			if (LegPaymentStreamCompoundingRateIndexCurveUnit is not null) writer.WriteString(42429, LegPaymentStreamCompoundingRateIndexCurveUnit);
			if (LegPaymentStreamCompoundingRateMultiplier is not null) writer.WriteNumber(42430, LegPaymentStreamCompoundingRateMultiplier.Value);
			if (LegPaymentStreamCompoundingRateSpread is not null) writer.WriteNumber(42431, LegPaymentStreamCompoundingRateSpread.Value);
			if (LegPaymentStreamCompoundingRateSpreadPositionType is not null) writer.WriteWholeNumber(42432, LegPaymentStreamCompoundingRateSpreadPositionType.Value);
			if (LegPaymentStreamCompoundingRateTreatment is not null) writer.WriteWholeNumber(42433, LegPaymentStreamCompoundingRateTreatment.Value);
			if (LegPaymentStreamCompoundingCapRate is not null) writer.WriteNumber(42434, LegPaymentStreamCompoundingCapRate.Value);
			if (LegPaymentStreamCompoundingCapRateBuySide is not null) writer.WriteWholeNumber(42435, LegPaymentStreamCompoundingCapRateBuySide.Value);
			if (LegPaymentStreamCompoundingCapRateSellSide is not null) writer.WriteWholeNumber(42436, LegPaymentStreamCompoundingCapRateSellSide.Value);
			if (LegPaymentStreamCompoundingFloorRate is not null) writer.WriteNumber(42437, LegPaymentStreamCompoundingFloorRate.Value);
			if (LegPaymentStreamCompoundingFloorRateBuySide is not null) writer.WriteWholeNumber(42438, LegPaymentStreamCompoundingFloorRateBuySide.Value);
			if (LegPaymentStreamCompoundingFloorRateSellSide is not null) writer.WriteWholeNumber(42439, LegPaymentStreamCompoundingFloorRateSellSide.Value);
			if (LegPaymentStreamCompoundingInitialRate is not null) writer.WriteNumber(42440, LegPaymentStreamCompoundingInitialRate.Value);
			if (LegPaymentStreamCompoundingFinalRateRoundingDirection is not null) writer.WriteString(42441, LegPaymentStreamCompoundingFinalRateRoundingDirection);
			if (LegPaymentStreamCompoundingFinalRatePrecision is not null) writer.WriteWholeNumber(42442, LegPaymentStreamCompoundingFinalRatePrecision.Value);
			if (LegPaymentStreamCompoundingAveragingMethod is not null) writer.WriteWholeNumber(42443, LegPaymentStreamCompoundingAveragingMethod.Value);
			if (LegPaymentStreamCompoundingNegativeRateTreatment is not null) writer.WriteWholeNumber(42444, LegPaymentStreamCompoundingNegativeRateTreatment.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegPaymentStreamCompoundingRateIndex = view.GetString(42427);
			LegPaymentStreamCompoundingRateIndexCurvePeriod = view.GetInt32(42428);
			LegPaymentStreamCompoundingRateIndexCurveUnit = view.GetString(42429);
			LegPaymentStreamCompoundingRateMultiplier = view.GetDouble(42430);
			LegPaymentStreamCompoundingRateSpread = view.GetDouble(42431);
			LegPaymentStreamCompoundingRateSpreadPositionType = view.GetInt32(42432);
			LegPaymentStreamCompoundingRateTreatment = view.GetInt32(42433);
			LegPaymentStreamCompoundingCapRate = view.GetDouble(42434);
			LegPaymentStreamCompoundingCapRateBuySide = view.GetInt32(42435);
			LegPaymentStreamCompoundingCapRateSellSide = view.GetInt32(42436);
			LegPaymentStreamCompoundingFloorRate = view.GetDouble(42437);
			LegPaymentStreamCompoundingFloorRateBuySide = view.GetInt32(42438);
			LegPaymentStreamCompoundingFloorRateSellSide = view.GetInt32(42439);
			LegPaymentStreamCompoundingInitialRate = view.GetDouble(42440);
			LegPaymentStreamCompoundingFinalRateRoundingDirection = view.GetString(42441);
			LegPaymentStreamCompoundingFinalRatePrecision = view.GetInt32(42442);
			LegPaymentStreamCompoundingAveragingMethod = view.GetInt32(42443);
			LegPaymentStreamCompoundingNegativeRateTreatment = view.GetInt32(42444);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegPaymentStreamCompoundingRateIndex":
				{
					value = LegPaymentStreamCompoundingRateIndex;
					break;
				}
				case "LegPaymentStreamCompoundingRateIndexCurvePeriod":
				{
					value = LegPaymentStreamCompoundingRateIndexCurvePeriod;
					break;
				}
				case "LegPaymentStreamCompoundingRateIndexCurveUnit":
				{
					value = LegPaymentStreamCompoundingRateIndexCurveUnit;
					break;
				}
				case "LegPaymentStreamCompoundingRateMultiplier":
				{
					value = LegPaymentStreamCompoundingRateMultiplier;
					break;
				}
				case "LegPaymentStreamCompoundingRateSpread":
				{
					value = LegPaymentStreamCompoundingRateSpread;
					break;
				}
				case "LegPaymentStreamCompoundingRateSpreadPositionType":
				{
					value = LegPaymentStreamCompoundingRateSpreadPositionType;
					break;
				}
				case "LegPaymentStreamCompoundingRateTreatment":
				{
					value = LegPaymentStreamCompoundingRateTreatment;
					break;
				}
				case "LegPaymentStreamCompoundingCapRate":
				{
					value = LegPaymentStreamCompoundingCapRate;
					break;
				}
				case "LegPaymentStreamCompoundingCapRateBuySide":
				{
					value = LegPaymentStreamCompoundingCapRateBuySide;
					break;
				}
				case "LegPaymentStreamCompoundingCapRateSellSide":
				{
					value = LegPaymentStreamCompoundingCapRateSellSide;
					break;
				}
				case "LegPaymentStreamCompoundingFloorRate":
				{
					value = LegPaymentStreamCompoundingFloorRate;
					break;
				}
				case "LegPaymentStreamCompoundingFloorRateBuySide":
				{
					value = LegPaymentStreamCompoundingFloorRateBuySide;
					break;
				}
				case "LegPaymentStreamCompoundingFloorRateSellSide":
				{
					value = LegPaymentStreamCompoundingFloorRateSellSide;
					break;
				}
				case "LegPaymentStreamCompoundingInitialRate":
				{
					value = LegPaymentStreamCompoundingInitialRate;
					break;
				}
				case "LegPaymentStreamCompoundingFinalRateRoundingDirection":
				{
					value = LegPaymentStreamCompoundingFinalRateRoundingDirection;
					break;
				}
				case "LegPaymentStreamCompoundingFinalRatePrecision":
				{
					value = LegPaymentStreamCompoundingFinalRatePrecision;
					break;
				}
				case "LegPaymentStreamCompoundingAveragingMethod":
				{
					value = LegPaymentStreamCompoundingAveragingMethod;
					break;
				}
				case "LegPaymentStreamCompoundingNegativeRateTreatment":
				{
					value = LegPaymentStreamCompoundingNegativeRateTreatment;
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
			LegPaymentStreamCompoundingRateIndex = null;
			LegPaymentStreamCompoundingRateIndexCurvePeriod = null;
			LegPaymentStreamCompoundingRateIndexCurveUnit = null;
			LegPaymentStreamCompoundingRateMultiplier = null;
			LegPaymentStreamCompoundingRateSpread = null;
			LegPaymentStreamCompoundingRateSpreadPositionType = null;
			LegPaymentStreamCompoundingRateTreatment = null;
			LegPaymentStreamCompoundingCapRate = null;
			LegPaymentStreamCompoundingCapRateBuySide = null;
			LegPaymentStreamCompoundingCapRateSellSide = null;
			LegPaymentStreamCompoundingFloorRate = null;
			LegPaymentStreamCompoundingFloorRateBuySide = null;
			LegPaymentStreamCompoundingFloorRateSellSide = null;
			LegPaymentStreamCompoundingInitialRate = null;
			LegPaymentStreamCompoundingFinalRateRoundingDirection = null;
			LegPaymentStreamCompoundingFinalRatePrecision = null;
			LegPaymentStreamCompoundingAveragingMethod = null;
			LegPaymentStreamCompoundingNegativeRateTreatment = null;
		}
	}
}
