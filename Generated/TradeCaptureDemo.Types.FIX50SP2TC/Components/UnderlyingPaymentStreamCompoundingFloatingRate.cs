using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStreamCompoundingFloatingRate : IFixComponent
	{
		[TagDetails(Tag = 42923, Type = TagType.String, Offset = 0, Required = false)]
		public string? UnderlyingPaymentStreamCompoundingRateIndex {get; set;}
		
		[TagDetails(Tag = 42924, Type = TagType.Int, Offset = 1, Required = false)]
		public int? UnderlyingPaymentStreamCompoundingRateIndexCurvePeriod {get; set;}
		
		[TagDetails(Tag = 42925, Type = TagType.String, Offset = 2, Required = false)]
		public string? UnderlyingPaymentStreamCompoundingRateIndexCurveUnit {get; set;}
		
		[TagDetails(Tag = 42926, Type = TagType.Float, Offset = 3, Required = false)]
		public double? UnderlyingPaymentStreamCompoundingRateMultiplier {get; set;}
		
		[TagDetails(Tag = 42927, Type = TagType.Float, Offset = 4, Required = false)]
		public double? UnderlyingPaymentStreamCompoundingRateSpread {get; set;}
		
		[TagDetails(Tag = 42928, Type = TagType.Int, Offset = 5, Required = false)]
		public int? UnderlyingPaymentStreamCompoundingRateSpreadPositionType {get; set;}
		
		[TagDetails(Tag = 42929, Type = TagType.Int, Offset = 6, Required = false)]
		public int? UnderlyingPaymentStreamCompoundingRateTreatment {get; set;}
		
		[TagDetails(Tag = 42930, Type = TagType.Float, Offset = 7, Required = false)]
		public double? UnderlyingPaymentStreamCompoundingCapRate {get; set;}
		
		[TagDetails(Tag = 42931, Type = TagType.Int, Offset = 8, Required = false)]
		public int? UnderlyingPaymentStreamCompoundingCapRateBuySide {get; set;}
		
		[TagDetails(Tag = 42932, Type = TagType.Int, Offset = 9, Required = false)]
		public int? UnderlyingPaymentStreamCompoundingCapRateSellSide {get; set;}
		
		[TagDetails(Tag = 42933, Type = TagType.Float, Offset = 10, Required = false)]
		public double? UnderlyingPaymentStreamCompoundingFloorRate {get; set;}
		
		[TagDetails(Tag = 42934, Type = TagType.Int, Offset = 11, Required = false)]
		public int? UnderlyingPaymentStreamCompoundingFloorRateBuySide {get; set;}
		
		[TagDetails(Tag = 42935, Type = TagType.Int, Offset = 12, Required = false)]
		public int? UnderlyingPaymentStreamCompoundingFloorRateSellSide {get; set;}
		
		[TagDetails(Tag = 42936, Type = TagType.Float, Offset = 13, Required = false)]
		public double? UnderlyingPaymentStreamCompoundingInitialRate {get; set;}
		
		[TagDetails(Tag = 42937, Type = TagType.String, Offset = 14, Required = false)]
		public string? UnderlyingPaymentStreamCompoundingFinalRateRoundingDirection {get; set;}
		
		[TagDetails(Tag = 42938, Type = TagType.Int, Offset = 15, Required = false)]
		public int? UnderlyingPaymentStreamCompoundingFinalRatePrecision {get; set;}
		
		[TagDetails(Tag = 42939, Type = TagType.Int, Offset = 16, Required = false)]
		public int? UnderlyingPaymentStreamCompoundingAveragingMethod {get; set;}
		
		[TagDetails(Tag = 42940, Type = TagType.Int, Offset = 17, Required = false)]
		public int? UnderlyingPaymentStreamCompoundingNegativeRateTreatment {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStreamCompoundingRateIndex is not null) writer.WriteString(42923, UnderlyingPaymentStreamCompoundingRateIndex);
			if (UnderlyingPaymentStreamCompoundingRateIndexCurvePeriod is not null) writer.WriteWholeNumber(42924, UnderlyingPaymentStreamCompoundingRateIndexCurvePeriod.Value);
			if (UnderlyingPaymentStreamCompoundingRateIndexCurveUnit is not null) writer.WriteString(42925, UnderlyingPaymentStreamCompoundingRateIndexCurveUnit);
			if (UnderlyingPaymentStreamCompoundingRateMultiplier is not null) writer.WriteNumber(42926, UnderlyingPaymentStreamCompoundingRateMultiplier.Value);
			if (UnderlyingPaymentStreamCompoundingRateSpread is not null) writer.WriteNumber(42927, UnderlyingPaymentStreamCompoundingRateSpread.Value);
			if (UnderlyingPaymentStreamCompoundingRateSpreadPositionType is not null) writer.WriteWholeNumber(42928, UnderlyingPaymentStreamCompoundingRateSpreadPositionType.Value);
			if (UnderlyingPaymentStreamCompoundingRateTreatment is not null) writer.WriteWholeNumber(42929, UnderlyingPaymentStreamCompoundingRateTreatment.Value);
			if (UnderlyingPaymentStreamCompoundingCapRate is not null) writer.WriteNumber(42930, UnderlyingPaymentStreamCompoundingCapRate.Value);
			if (UnderlyingPaymentStreamCompoundingCapRateBuySide is not null) writer.WriteWholeNumber(42931, UnderlyingPaymentStreamCompoundingCapRateBuySide.Value);
			if (UnderlyingPaymentStreamCompoundingCapRateSellSide is not null) writer.WriteWholeNumber(42932, UnderlyingPaymentStreamCompoundingCapRateSellSide.Value);
			if (UnderlyingPaymentStreamCompoundingFloorRate is not null) writer.WriteNumber(42933, UnderlyingPaymentStreamCompoundingFloorRate.Value);
			if (UnderlyingPaymentStreamCompoundingFloorRateBuySide is not null) writer.WriteWholeNumber(42934, UnderlyingPaymentStreamCompoundingFloorRateBuySide.Value);
			if (UnderlyingPaymentStreamCompoundingFloorRateSellSide is not null) writer.WriteWholeNumber(42935, UnderlyingPaymentStreamCompoundingFloorRateSellSide.Value);
			if (UnderlyingPaymentStreamCompoundingInitialRate is not null) writer.WriteNumber(42936, UnderlyingPaymentStreamCompoundingInitialRate.Value);
			if (UnderlyingPaymentStreamCompoundingFinalRateRoundingDirection is not null) writer.WriteString(42937, UnderlyingPaymentStreamCompoundingFinalRateRoundingDirection);
			if (UnderlyingPaymentStreamCompoundingFinalRatePrecision is not null) writer.WriteWholeNumber(42938, UnderlyingPaymentStreamCompoundingFinalRatePrecision.Value);
			if (UnderlyingPaymentStreamCompoundingAveragingMethod is not null) writer.WriteWholeNumber(42939, UnderlyingPaymentStreamCompoundingAveragingMethod.Value);
			if (UnderlyingPaymentStreamCompoundingNegativeRateTreatment is not null) writer.WriteWholeNumber(42940, UnderlyingPaymentStreamCompoundingNegativeRateTreatment.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingPaymentStreamCompoundingRateIndex = view.GetString(42923);
			UnderlyingPaymentStreamCompoundingRateIndexCurvePeriod = view.GetInt32(42924);
			UnderlyingPaymentStreamCompoundingRateIndexCurveUnit = view.GetString(42925);
			UnderlyingPaymentStreamCompoundingRateMultiplier = view.GetDouble(42926);
			UnderlyingPaymentStreamCompoundingRateSpread = view.GetDouble(42927);
			UnderlyingPaymentStreamCompoundingRateSpreadPositionType = view.GetInt32(42928);
			UnderlyingPaymentStreamCompoundingRateTreatment = view.GetInt32(42929);
			UnderlyingPaymentStreamCompoundingCapRate = view.GetDouble(42930);
			UnderlyingPaymentStreamCompoundingCapRateBuySide = view.GetInt32(42931);
			UnderlyingPaymentStreamCompoundingCapRateSellSide = view.GetInt32(42932);
			UnderlyingPaymentStreamCompoundingFloorRate = view.GetDouble(42933);
			UnderlyingPaymentStreamCompoundingFloorRateBuySide = view.GetInt32(42934);
			UnderlyingPaymentStreamCompoundingFloorRateSellSide = view.GetInt32(42935);
			UnderlyingPaymentStreamCompoundingInitialRate = view.GetDouble(42936);
			UnderlyingPaymentStreamCompoundingFinalRateRoundingDirection = view.GetString(42937);
			UnderlyingPaymentStreamCompoundingFinalRatePrecision = view.GetInt32(42938);
			UnderlyingPaymentStreamCompoundingAveragingMethod = view.GetInt32(42939);
			UnderlyingPaymentStreamCompoundingNegativeRateTreatment = view.GetInt32(42940);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingPaymentStreamCompoundingRateIndex":
				{
					value = UnderlyingPaymentStreamCompoundingRateIndex;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingRateIndexCurvePeriod":
				{
					value = UnderlyingPaymentStreamCompoundingRateIndexCurvePeriod;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingRateIndexCurveUnit":
				{
					value = UnderlyingPaymentStreamCompoundingRateIndexCurveUnit;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingRateMultiplier":
				{
					value = UnderlyingPaymentStreamCompoundingRateMultiplier;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingRateSpread":
				{
					value = UnderlyingPaymentStreamCompoundingRateSpread;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingRateSpreadPositionType":
				{
					value = UnderlyingPaymentStreamCompoundingRateSpreadPositionType;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingRateTreatment":
				{
					value = UnderlyingPaymentStreamCompoundingRateTreatment;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingCapRate":
				{
					value = UnderlyingPaymentStreamCompoundingCapRate;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingCapRateBuySide":
				{
					value = UnderlyingPaymentStreamCompoundingCapRateBuySide;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingCapRateSellSide":
				{
					value = UnderlyingPaymentStreamCompoundingCapRateSellSide;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingFloorRate":
				{
					value = UnderlyingPaymentStreamCompoundingFloorRate;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingFloorRateBuySide":
				{
					value = UnderlyingPaymentStreamCompoundingFloorRateBuySide;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingFloorRateSellSide":
				{
					value = UnderlyingPaymentStreamCompoundingFloorRateSellSide;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingInitialRate":
				{
					value = UnderlyingPaymentStreamCompoundingInitialRate;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingFinalRateRoundingDirection":
				{
					value = UnderlyingPaymentStreamCompoundingFinalRateRoundingDirection;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingFinalRatePrecision":
				{
					value = UnderlyingPaymentStreamCompoundingFinalRatePrecision;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingAveragingMethod":
				{
					value = UnderlyingPaymentStreamCompoundingAveragingMethod;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingNegativeRateTreatment":
				{
					value = UnderlyingPaymentStreamCompoundingNegativeRateTreatment;
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
			UnderlyingPaymentStreamCompoundingRateIndex = null;
			UnderlyingPaymentStreamCompoundingRateIndexCurvePeriod = null;
			UnderlyingPaymentStreamCompoundingRateIndexCurveUnit = null;
			UnderlyingPaymentStreamCompoundingRateMultiplier = null;
			UnderlyingPaymentStreamCompoundingRateSpread = null;
			UnderlyingPaymentStreamCompoundingRateSpreadPositionType = null;
			UnderlyingPaymentStreamCompoundingRateTreatment = null;
			UnderlyingPaymentStreamCompoundingCapRate = null;
			UnderlyingPaymentStreamCompoundingCapRateBuySide = null;
			UnderlyingPaymentStreamCompoundingCapRateSellSide = null;
			UnderlyingPaymentStreamCompoundingFloorRate = null;
			UnderlyingPaymentStreamCompoundingFloorRateBuySide = null;
			UnderlyingPaymentStreamCompoundingFloorRateSellSide = null;
			UnderlyingPaymentStreamCompoundingInitialRate = null;
			UnderlyingPaymentStreamCompoundingFinalRateRoundingDirection = null;
			UnderlyingPaymentStreamCompoundingFinalRatePrecision = null;
			UnderlyingPaymentStreamCompoundingAveragingMethod = null;
			UnderlyingPaymentStreamCompoundingNegativeRateTreatment = null;
		}
	}
}
