using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegDividendAccrualFloatingRate : IFixComponent
	{
		[TagDetails(Tag = 42312, Type = TagType.String, Offset = 0, Required = false)]
		public string? LegDividendFloatingRateIndex {get; set;}
		
		[TagDetails(Tag = 42313, Type = TagType.Int, Offset = 1, Required = false)]
		public int? LegDividendFloatingRateIndexCurvePeriod {get; set;}
		
		[TagDetails(Tag = 42314, Type = TagType.String, Offset = 2, Required = false)]
		public string? LegDividendFloatingRateIndexCurveUnit {get; set;}
		
		[TagDetails(Tag = 42315, Type = TagType.Float, Offset = 3, Required = false)]
		public double? LegDividendFloatingRateMultiplier {get; set;}
		
		[TagDetails(Tag = 42316, Type = TagType.Float, Offset = 4, Required = false)]
		public double? LegDividendFloatingRateSpread {get; set;}
		
		[TagDetails(Tag = 42317, Type = TagType.Int, Offset = 5, Required = false)]
		public int? LegDividendFloatingRateSpreadPositionType {get; set;}
		
		[TagDetails(Tag = 42318, Type = TagType.Int, Offset = 6, Required = false)]
		public int? LegDividendFloatingRateTreatment {get; set;}
		
		[TagDetails(Tag = 42319, Type = TagType.Float, Offset = 7, Required = false)]
		public double? LegDividendCapRate {get; set;}
		
		[TagDetails(Tag = 42320, Type = TagType.Int, Offset = 8, Required = false)]
		public int? LegDividendCapRateBuySide {get; set;}
		
		[TagDetails(Tag = 42321, Type = TagType.Int, Offset = 9, Required = false)]
		public int? LegDividendCapRateSellSide {get; set;}
		
		[TagDetails(Tag = 42322, Type = TagType.Float, Offset = 10, Required = false)]
		public double? LegDividendFloorRate {get; set;}
		
		[TagDetails(Tag = 42323, Type = TagType.Int, Offset = 11, Required = false)]
		public int? LegDividendFloorRateBuySide {get; set;}
		
		[TagDetails(Tag = 42324, Type = TagType.Int, Offset = 12, Required = false)]
		public int? LegDividendFloorRateSellSide {get; set;}
		
		[TagDetails(Tag = 42325, Type = TagType.Float, Offset = 13, Required = false)]
		public double? LegDividendInitialRate {get; set;}
		
		[TagDetails(Tag = 42326, Type = TagType.String, Offset = 14, Required = false)]
		public string? LegDividendFinalRateRoundingDirection {get; set;}
		
		[TagDetails(Tag = 42327, Type = TagType.Int, Offset = 15, Required = false)]
		public int? LegDividendFinalRatePrecision {get; set;}
		
		[TagDetails(Tag = 42328, Type = TagType.Int, Offset = 16, Required = false)]
		public int? LegDividendAveragingMethod {get; set;}
		
		[TagDetails(Tag = 42329, Type = TagType.Int, Offset = 17, Required = false)]
		public int? LegDividendNegativeRateTreatment {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegDividendFloatingRateIndex is not null) writer.WriteString(42312, LegDividendFloatingRateIndex);
			if (LegDividendFloatingRateIndexCurvePeriod is not null) writer.WriteWholeNumber(42313, LegDividendFloatingRateIndexCurvePeriod.Value);
			if (LegDividendFloatingRateIndexCurveUnit is not null) writer.WriteString(42314, LegDividendFloatingRateIndexCurveUnit);
			if (LegDividendFloatingRateMultiplier is not null) writer.WriteNumber(42315, LegDividendFloatingRateMultiplier.Value);
			if (LegDividendFloatingRateSpread is not null) writer.WriteNumber(42316, LegDividendFloatingRateSpread.Value);
			if (LegDividendFloatingRateSpreadPositionType is not null) writer.WriteWholeNumber(42317, LegDividendFloatingRateSpreadPositionType.Value);
			if (LegDividendFloatingRateTreatment is not null) writer.WriteWholeNumber(42318, LegDividendFloatingRateTreatment.Value);
			if (LegDividendCapRate is not null) writer.WriteNumber(42319, LegDividendCapRate.Value);
			if (LegDividendCapRateBuySide is not null) writer.WriteWholeNumber(42320, LegDividendCapRateBuySide.Value);
			if (LegDividendCapRateSellSide is not null) writer.WriteWholeNumber(42321, LegDividendCapRateSellSide.Value);
			if (LegDividendFloorRate is not null) writer.WriteNumber(42322, LegDividendFloorRate.Value);
			if (LegDividendFloorRateBuySide is not null) writer.WriteWholeNumber(42323, LegDividendFloorRateBuySide.Value);
			if (LegDividendFloorRateSellSide is not null) writer.WriteWholeNumber(42324, LegDividendFloorRateSellSide.Value);
			if (LegDividendInitialRate is not null) writer.WriteNumber(42325, LegDividendInitialRate.Value);
			if (LegDividendFinalRateRoundingDirection is not null) writer.WriteString(42326, LegDividendFinalRateRoundingDirection);
			if (LegDividendFinalRatePrecision is not null) writer.WriteWholeNumber(42327, LegDividendFinalRatePrecision.Value);
			if (LegDividendAveragingMethod is not null) writer.WriteWholeNumber(42328, LegDividendAveragingMethod.Value);
			if (LegDividendNegativeRateTreatment is not null) writer.WriteWholeNumber(42329, LegDividendNegativeRateTreatment.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegDividendFloatingRateIndex = view.GetString(42312);
			LegDividendFloatingRateIndexCurvePeriod = view.GetInt32(42313);
			LegDividendFloatingRateIndexCurveUnit = view.GetString(42314);
			LegDividendFloatingRateMultiplier = view.GetDouble(42315);
			LegDividendFloatingRateSpread = view.GetDouble(42316);
			LegDividendFloatingRateSpreadPositionType = view.GetInt32(42317);
			LegDividendFloatingRateTreatment = view.GetInt32(42318);
			LegDividendCapRate = view.GetDouble(42319);
			LegDividendCapRateBuySide = view.GetInt32(42320);
			LegDividendCapRateSellSide = view.GetInt32(42321);
			LegDividendFloorRate = view.GetDouble(42322);
			LegDividendFloorRateBuySide = view.GetInt32(42323);
			LegDividendFloorRateSellSide = view.GetInt32(42324);
			LegDividendInitialRate = view.GetDouble(42325);
			LegDividendFinalRateRoundingDirection = view.GetString(42326);
			LegDividendFinalRatePrecision = view.GetInt32(42327);
			LegDividendAveragingMethod = view.GetInt32(42328);
			LegDividendNegativeRateTreatment = view.GetInt32(42329);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegDividendFloatingRateIndex":
				{
					value = LegDividendFloatingRateIndex;
					break;
				}
				case "LegDividendFloatingRateIndexCurvePeriod":
				{
					value = LegDividendFloatingRateIndexCurvePeriod;
					break;
				}
				case "LegDividendFloatingRateIndexCurveUnit":
				{
					value = LegDividendFloatingRateIndexCurveUnit;
					break;
				}
				case "LegDividendFloatingRateMultiplier":
				{
					value = LegDividendFloatingRateMultiplier;
					break;
				}
				case "LegDividendFloatingRateSpread":
				{
					value = LegDividendFloatingRateSpread;
					break;
				}
				case "LegDividendFloatingRateSpreadPositionType":
				{
					value = LegDividendFloatingRateSpreadPositionType;
					break;
				}
				case "LegDividendFloatingRateTreatment":
				{
					value = LegDividendFloatingRateTreatment;
					break;
				}
				case "LegDividendCapRate":
				{
					value = LegDividendCapRate;
					break;
				}
				case "LegDividendCapRateBuySide":
				{
					value = LegDividendCapRateBuySide;
					break;
				}
				case "LegDividendCapRateSellSide":
				{
					value = LegDividendCapRateSellSide;
					break;
				}
				case "LegDividendFloorRate":
				{
					value = LegDividendFloorRate;
					break;
				}
				case "LegDividendFloorRateBuySide":
				{
					value = LegDividendFloorRateBuySide;
					break;
				}
				case "LegDividendFloorRateSellSide":
				{
					value = LegDividendFloorRateSellSide;
					break;
				}
				case "LegDividendInitialRate":
				{
					value = LegDividendInitialRate;
					break;
				}
				case "LegDividendFinalRateRoundingDirection":
				{
					value = LegDividendFinalRateRoundingDirection;
					break;
				}
				case "LegDividendFinalRatePrecision":
				{
					value = LegDividendFinalRatePrecision;
					break;
				}
				case "LegDividendAveragingMethod":
				{
					value = LegDividendAveragingMethod;
					break;
				}
				case "LegDividendNegativeRateTreatment":
				{
					value = LegDividendNegativeRateTreatment;
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
			LegDividendFloatingRateIndex = null;
			LegDividendFloatingRateIndexCurvePeriod = null;
			LegDividendFloatingRateIndexCurveUnit = null;
			LegDividendFloatingRateMultiplier = null;
			LegDividendFloatingRateSpread = null;
			LegDividendFloatingRateSpreadPositionType = null;
			LegDividendFloatingRateTreatment = null;
			LegDividendCapRate = null;
			LegDividendCapRateBuySide = null;
			LegDividendCapRateSellSide = null;
			LegDividendFloorRate = null;
			LegDividendFloorRateBuySide = null;
			LegDividendFloorRateSellSide = null;
			LegDividendInitialRate = null;
			LegDividendFinalRateRoundingDirection = null;
			LegDividendFinalRatePrecision = null;
			LegDividendAveragingMethod = null;
			LegDividendNegativeRateTreatment = null;
		}
	}
}
