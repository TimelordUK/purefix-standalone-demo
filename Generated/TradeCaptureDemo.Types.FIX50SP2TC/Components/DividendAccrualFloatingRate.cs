using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class DividendAccrualFloatingRate : IFixComponent
	{
		[TagDetails(Tag = 42218, Type = TagType.String, Offset = 0, Required = false)]
		public string? DividendFloatingRateIndex {get; set;}
		
		[TagDetails(Tag = 42219, Type = TagType.Int, Offset = 1, Required = false)]
		public int? DividendFloatingRateIndexCurvePeriod {get; set;}
		
		[TagDetails(Tag = 42220, Type = TagType.String, Offset = 2, Required = false)]
		public string? DividendFloatingRateIndexCurveUnit {get; set;}
		
		[TagDetails(Tag = 42221, Type = TagType.Float, Offset = 3, Required = false)]
		public double? DividendFloatingRateMultiplier {get; set;}
		
		[TagDetails(Tag = 42222, Type = TagType.Float, Offset = 4, Required = false)]
		public double? DividendFloatingRateSpread {get; set;}
		
		[TagDetails(Tag = 42223, Type = TagType.Int, Offset = 5, Required = false)]
		public int? DividendFloatingRateSpreadPositionType {get; set;}
		
		[TagDetails(Tag = 42224, Type = TagType.Int, Offset = 6, Required = false)]
		public int? DividendFloatingRateTreatment {get; set;}
		
		[TagDetails(Tag = 42225, Type = TagType.Float, Offset = 7, Required = false)]
		public double? DividendCapRate {get; set;}
		
		[TagDetails(Tag = 42226, Type = TagType.Int, Offset = 8, Required = false)]
		public int? DividendCapRateBuySide {get; set;}
		
		[TagDetails(Tag = 42227, Type = TagType.Int, Offset = 9, Required = false)]
		public int? DividendCapRateSellSide {get; set;}
		
		[TagDetails(Tag = 42228, Type = TagType.Float, Offset = 10, Required = false)]
		public double? DividendFloorRate {get; set;}
		
		[TagDetails(Tag = 42229, Type = TagType.Int, Offset = 11, Required = false)]
		public int? DividendFloorRateBuySide {get; set;}
		
		[TagDetails(Tag = 42230, Type = TagType.Int, Offset = 12, Required = false)]
		public int? DividendFloorRateSellSide {get; set;}
		
		[TagDetails(Tag = 42231, Type = TagType.Float, Offset = 13, Required = false)]
		public double? DividendInitialRate {get; set;}
		
		[TagDetails(Tag = 42232, Type = TagType.String, Offset = 14, Required = false)]
		public string? DividendFinalRateRoundingDirection {get; set;}
		
		[TagDetails(Tag = 42233, Type = TagType.Int, Offset = 15, Required = false)]
		public int? DividendFinalRatePrecision {get; set;}
		
		[TagDetails(Tag = 42234, Type = TagType.Int, Offset = 16, Required = false)]
		public int? DividendAveragingMethod {get; set;}
		
		[TagDetails(Tag = 42235, Type = TagType.Int, Offset = 17, Required = false)]
		public int? DividendNegativeRateTreatment {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (DividendFloatingRateIndex is not null) writer.WriteString(42218, DividendFloatingRateIndex);
			if (DividendFloatingRateIndexCurvePeriod is not null) writer.WriteWholeNumber(42219, DividendFloatingRateIndexCurvePeriod.Value);
			if (DividendFloatingRateIndexCurveUnit is not null) writer.WriteString(42220, DividendFloatingRateIndexCurveUnit);
			if (DividendFloatingRateMultiplier is not null) writer.WriteNumber(42221, DividendFloatingRateMultiplier.Value);
			if (DividendFloatingRateSpread is not null) writer.WriteNumber(42222, DividendFloatingRateSpread.Value);
			if (DividendFloatingRateSpreadPositionType is not null) writer.WriteWholeNumber(42223, DividendFloatingRateSpreadPositionType.Value);
			if (DividendFloatingRateTreatment is not null) writer.WriteWholeNumber(42224, DividendFloatingRateTreatment.Value);
			if (DividendCapRate is not null) writer.WriteNumber(42225, DividendCapRate.Value);
			if (DividendCapRateBuySide is not null) writer.WriteWholeNumber(42226, DividendCapRateBuySide.Value);
			if (DividendCapRateSellSide is not null) writer.WriteWholeNumber(42227, DividendCapRateSellSide.Value);
			if (DividendFloorRate is not null) writer.WriteNumber(42228, DividendFloorRate.Value);
			if (DividendFloorRateBuySide is not null) writer.WriteWholeNumber(42229, DividendFloorRateBuySide.Value);
			if (DividendFloorRateSellSide is not null) writer.WriteWholeNumber(42230, DividendFloorRateSellSide.Value);
			if (DividendInitialRate is not null) writer.WriteNumber(42231, DividendInitialRate.Value);
			if (DividendFinalRateRoundingDirection is not null) writer.WriteString(42232, DividendFinalRateRoundingDirection);
			if (DividendFinalRatePrecision is not null) writer.WriteWholeNumber(42233, DividendFinalRatePrecision.Value);
			if (DividendAveragingMethod is not null) writer.WriteWholeNumber(42234, DividendAveragingMethod.Value);
			if (DividendNegativeRateTreatment is not null) writer.WriteWholeNumber(42235, DividendNegativeRateTreatment.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			DividendFloatingRateIndex = view.GetString(42218);
			DividendFloatingRateIndexCurvePeriod = view.GetInt32(42219);
			DividendFloatingRateIndexCurveUnit = view.GetString(42220);
			DividendFloatingRateMultiplier = view.GetDouble(42221);
			DividendFloatingRateSpread = view.GetDouble(42222);
			DividendFloatingRateSpreadPositionType = view.GetInt32(42223);
			DividendFloatingRateTreatment = view.GetInt32(42224);
			DividendCapRate = view.GetDouble(42225);
			DividendCapRateBuySide = view.GetInt32(42226);
			DividendCapRateSellSide = view.GetInt32(42227);
			DividendFloorRate = view.GetDouble(42228);
			DividendFloorRateBuySide = view.GetInt32(42229);
			DividendFloorRateSellSide = view.GetInt32(42230);
			DividendInitialRate = view.GetDouble(42231);
			DividendFinalRateRoundingDirection = view.GetString(42232);
			DividendFinalRatePrecision = view.GetInt32(42233);
			DividendAveragingMethod = view.GetInt32(42234);
			DividendNegativeRateTreatment = view.GetInt32(42235);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "DividendFloatingRateIndex":
				{
					value = DividendFloatingRateIndex;
					break;
				}
				case "DividendFloatingRateIndexCurvePeriod":
				{
					value = DividendFloatingRateIndexCurvePeriod;
					break;
				}
				case "DividendFloatingRateIndexCurveUnit":
				{
					value = DividendFloatingRateIndexCurveUnit;
					break;
				}
				case "DividendFloatingRateMultiplier":
				{
					value = DividendFloatingRateMultiplier;
					break;
				}
				case "DividendFloatingRateSpread":
				{
					value = DividendFloatingRateSpread;
					break;
				}
				case "DividendFloatingRateSpreadPositionType":
				{
					value = DividendFloatingRateSpreadPositionType;
					break;
				}
				case "DividendFloatingRateTreatment":
				{
					value = DividendFloatingRateTreatment;
					break;
				}
				case "DividendCapRate":
				{
					value = DividendCapRate;
					break;
				}
				case "DividendCapRateBuySide":
				{
					value = DividendCapRateBuySide;
					break;
				}
				case "DividendCapRateSellSide":
				{
					value = DividendCapRateSellSide;
					break;
				}
				case "DividendFloorRate":
				{
					value = DividendFloorRate;
					break;
				}
				case "DividendFloorRateBuySide":
				{
					value = DividendFloorRateBuySide;
					break;
				}
				case "DividendFloorRateSellSide":
				{
					value = DividendFloorRateSellSide;
					break;
				}
				case "DividendInitialRate":
				{
					value = DividendInitialRate;
					break;
				}
				case "DividendFinalRateRoundingDirection":
				{
					value = DividendFinalRateRoundingDirection;
					break;
				}
				case "DividendFinalRatePrecision":
				{
					value = DividendFinalRatePrecision;
					break;
				}
				case "DividendAveragingMethod":
				{
					value = DividendAveragingMethod;
					break;
				}
				case "DividendNegativeRateTreatment":
				{
					value = DividendNegativeRateTreatment;
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
			DividendFloatingRateIndex = null;
			DividendFloatingRateIndexCurvePeriod = null;
			DividendFloatingRateIndexCurveUnit = null;
			DividendFloatingRateMultiplier = null;
			DividendFloatingRateSpread = null;
			DividendFloatingRateSpreadPositionType = null;
			DividendFloatingRateTreatment = null;
			DividendCapRate = null;
			DividendCapRateBuySide = null;
			DividendCapRateSellSide = null;
			DividendFloorRate = null;
			DividendFloorRateBuySide = null;
			DividendFloorRateSellSide = null;
			DividendInitialRate = null;
			DividendFinalRateRoundingDirection = null;
			DividendFinalRatePrecision = null;
			DividendAveragingMethod = null;
			DividendNegativeRateTreatment = null;
		}
	}
}
