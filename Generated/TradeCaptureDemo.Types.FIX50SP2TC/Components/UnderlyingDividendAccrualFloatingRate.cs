using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingDividendAccrualFloatingRate : IFixComponent
	{
		[TagDetails(Tag = 42801, Type = TagType.String, Offset = 0, Required = false)]
		public string? UnderlyingDividendFloatingRateIndex {get; set;}
		
		[TagDetails(Tag = 42802, Type = TagType.Int, Offset = 1, Required = false)]
		public int? UnderlyingDividendFloatingRateIndexCurvePeriod {get; set;}
		
		[TagDetails(Tag = 42803, Type = TagType.String, Offset = 2, Required = false)]
		public string? UnderlyingDividendFloatingRateIndexCurveUnit {get; set;}
		
		[TagDetails(Tag = 42804, Type = TagType.Float, Offset = 3, Required = false)]
		public double? UnderlyingDividendFloatingRateMultiplier {get; set;}
		
		[TagDetails(Tag = 42805, Type = TagType.Float, Offset = 4, Required = false)]
		public double? UnderlyingDividendFloatingRateSpread {get; set;}
		
		[TagDetails(Tag = 42806, Type = TagType.Int, Offset = 5, Required = false)]
		public int? UnderlyingDividendFloatingRateSpreadPositionType {get; set;}
		
		[TagDetails(Tag = 42807, Type = TagType.Int, Offset = 6, Required = false)]
		public int? UnderlyingDividendFloatingRateTreatment {get; set;}
		
		[TagDetails(Tag = 42808, Type = TagType.Float, Offset = 7, Required = false)]
		public double? UnderlyingDividendCapRate {get; set;}
		
		[TagDetails(Tag = 42809, Type = TagType.Int, Offset = 8, Required = false)]
		public int? UnderlyingDividendCapRateBuySide {get; set;}
		
		[TagDetails(Tag = 42810, Type = TagType.Int, Offset = 9, Required = false)]
		public int? UnderlyingDividendCapRateSellSide {get; set;}
		
		[TagDetails(Tag = 42811, Type = TagType.Float, Offset = 10, Required = false)]
		public double? UnderlyingDividendFloorRate {get; set;}
		
		[TagDetails(Tag = 42812, Type = TagType.Int, Offset = 11, Required = false)]
		public int? UnderlyingDividendFloorRateBuySide {get; set;}
		
		[TagDetails(Tag = 42813, Type = TagType.Int, Offset = 12, Required = false)]
		public int? UnderlyingDividendFloorRateSellSide {get; set;}
		
		[TagDetails(Tag = 42814, Type = TagType.Float, Offset = 13, Required = false)]
		public double? UnderlyingDividendInitialRate {get; set;}
		
		[TagDetails(Tag = 42815, Type = TagType.String, Offset = 14, Required = false)]
		public string? UnderlyingDividendFinalRateRoundingDirection {get; set;}
		
		[TagDetails(Tag = 42816, Type = TagType.Int, Offset = 15, Required = false)]
		public int? UnderlyingDividendFinalRatePrecision {get; set;}
		
		[TagDetails(Tag = 42817, Type = TagType.Int, Offset = 16, Required = false)]
		public int? UnderlyingDividendAveragingMethod {get; set;}
		
		[TagDetails(Tag = 42818, Type = TagType.Int, Offset = 17, Required = false)]
		public int? UnderlyingDividendNegativeRateTreatment {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingDividendFloatingRateIndex is not null) writer.WriteString(42801, UnderlyingDividendFloatingRateIndex);
			if (UnderlyingDividendFloatingRateIndexCurvePeriod is not null) writer.WriteWholeNumber(42802, UnderlyingDividendFloatingRateIndexCurvePeriod.Value);
			if (UnderlyingDividendFloatingRateIndexCurveUnit is not null) writer.WriteString(42803, UnderlyingDividendFloatingRateIndexCurveUnit);
			if (UnderlyingDividendFloatingRateMultiplier is not null) writer.WriteNumber(42804, UnderlyingDividendFloatingRateMultiplier.Value);
			if (UnderlyingDividendFloatingRateSpread is not null) writer.WriteNumber(42805, UnderlyingDividendFloatingRateSpread.Value);
			if (UnderlyingDividendFloatingRateSpreadPositionType is not null) writer.WriteWholeNumber(42806, UnderlyingDividendFloatingRateSpreadPositionType.Value);
			if (UnderlyingDividendFloatingRateTreatment is not null) writer.WriteWholeNumber(42807, UnderlyingDividendFloatingRateTreatment.Value);
			if (UnderlyingDividendCapRate is not null) writer.WriteNumber(42808, UnderlyingDividendCapRate.Value);
			if (UnderlyingDividendCapRateBuySide is not null) writer.WriteWholeNumber(42809, UnderlyingDividendCapRateBuySide.Value);
			if (UnderlyingDividendCapRateSellSide is not null) writer.WriteWholeNumber(42810, UnderlyingDividendCapRateSellSide.Value);
			if (UnderlyingDividendFloorRate is not null) writer.WriteNumber(42811, UnderlyingDividendFloorRate.Value);
			if (UnderlyingDividendFloorRateBuySide is not null) writer.WriteWholeNumber(42812, UnderlyingDividendFloorRateBuySide.Value);
			if (UnderlyingDividendFloorRateSellSide is not null) writer.WriteWholeNumber(42813, UnderlyingDividendFloorRateSellSide.Value);
			if (UnderlyingDividendInitialRate is not null) writer.WriteNumber(42814, UnderlyingDividendInitialRate.Value);
			if (UnderlyingDividendFinalRateRoundingDirection is not null) writer.WriteString(42815, UnderlyingDividendFinalRateRoundingDirection);
			if (UnderlyingDividendFinalRatePrecision is not null) writer.WriteWholeNumber(42816, UnderlyingDividendFinalRatePrecision.Value);
			if (UnderlyingDividendAveragingMethod is not null) writer.WriteWholeNumber(42817, UnderlyingDividendAveragingMethod.Value);
			if (UnderlyingDividendNegativeRateTreatment is not null) writer.WriteWholeNumber(42818, UnderlyingDividendNegativeRateTreatment.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingDividendFloatingRateIndex = view.GetString(42801);
			UnderlyingDividendFloatingRateIndexCurvePeriod = view.GetInt32(42802);
			UnderlyingDividendFloatingRateIndexCurveUnit = view.GetString(42803);
			UnderlyingDividendFloatingRateMultiplier = view.GetDouble(42804);
			UnderlyingDividendFloatingRateSpread = view.GetDouble(42805);
			UnderlyingDividendFloatingRateSpreadPositionType = view.GetInt32(42806);
			UnderlyingDividendFloatingRateTreatment = view.GetInt32(42807);
			UnderlyingDividendCapRate = view.GetDouble(42808);
			UnderlyingDividendCapRateBuySide = view.GetInt32(42809);
			UnderlyingDividendCapRateSellSide = view.GetInt32(42810);
			UnderlyingDividendFloorRate = view.GetDouble(42811);
			UnderlyingDividendFloorRateBuySide = view.GetInt32(42812);
			UnderlyingDividendFloorRateSellSide = view.GetInt32(42813);
			UnderlyingDividendInitialRate = view.GetDouble(42814);
			UnderlyingDividendFinalRateRoundingDirection = view.GetString(42815);
			UnderlyingDividendFinalRatePrecision = view.GetInt32(42816);
			UnderlyingDividendAveragingMethod = view.GetInt32(42817);
			UnderlyingDividendNegativeRateTreatment = view.GetInt32(42818);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingDividendFloatingRateIndex":
				{
					value = UnderlyingDividendFloatingRateIndex;
					break;
				}
				case "UnderlyingDividendFloatingRateIndexCurvePeriod":
				{
					value = UnderlyingDividendFloatingRateIndexCurvePeriod;
					break;
				}
				case "UnderlyingDividendFloatingRateIndexCurveUnit":
				{
					value = UnderlyingDividendFloatingRateIndexCurveUnit;
					break;
				}
				case "UnderlyingDividendFloatingRateMultiplier":
				{
					value = UnderlyingDividendFloatingRateMultiplier;
					break;
				}
				case "UnderlyingDividendFloatingRateSpread":
				{
					value = UnderlyingDividendFloatingRateSpread;
					break;
				}
				case "UnderlyingDividendFloatingRateSpreadPositionType":
				{
					value = UnderlyingDividendFloatingRateSpreadPositionType;
					break;
				}
				case "UnderlyingDividendFloatingRateTreatment":
				{
					value = UnderlyingDividendFloatingRateTreatment;
					break;
				}
				case "UnderlyingDividendCapRate":
				{
					value = UnderlyingDividendCapRate;
					break;
				}
				case "UnderlyingDividendCapRateBuySide":
				{
					value = UnderlyingDividendCapRateBuySide;
					break;
				}
				case "UnderlyingDividendCapRateSellSide":
				{
					value = UnderlyingDividendCapRateSellSide;
					break;
				}
				case "UnderlyingDividendFloorRate":
				{
					value = UnderlyingDividendFloorRate;
					break;
				}
				case "UnderlyingDividendFloorRateBuySide":
				{
					value = UnderlyingDividendFloorRateBuySide;
					break;
				}
				case "UnderlyingDividendFloorRateSellSide":
				{
					value = UnderlyingDividendFloorRateSellSide;
					break;
				}
				case "UnderlyingDividendInitialRate":
				{
					value = UnderlyingDividendInitialRate;
					break;
				}
				case "UnderlyingDividendFinalRateRoundingDirection":
				{
					value = UnderlyingDividendFinalRateRoundingDirection;
					break;
				}
				case "UnderlyingDividendFinalRatePrecision":
				{
					value = UnderlyingDividendFinalRatePrecision;
					break;
				}
				case "UnderlyingDividendAveragingMethod":
				{
					value = UnderlyingDividendAveragingMethod;
					break;
				}
				case "UnderlyingDividendNegativeRateTreatment":
				{
					value = UnderlyingDividendNegativeRateTreatment;
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
			UnderlyingDividendFloatingRateIndex = null;
			UnderlyingDividendFloatingRateIndexCurvePeriod = null;
			UnderlyingDividendFloatingRateIndexCurveUnit = null;
			UnderlyingDividendFloatingRateMultiplier = null;
			UnderlyingDividendFloatingRateSpread = null;
			UnderlyingDividendFloatingRateSpreadPositionType = null;
			UnderlyingDividendFloatingRateTreatment = null;
			UnderlyingDividendCapRate = null;
			UnderlyingDividendCapRateBuySide = null;
			UnderlyingDividendCapRateSellSide = null;
			UnderlyingDividendFloorRate = null;
			UnderlyingDividendFloorRateBuySide = null;
			UnderlyingDividendFloorRateSellSide = null;
			UnderlyingDividendInitialRate = null;
			UnderlyingDividendFinalRateRoundingDirection = null;
			UnderlyingDividendFinalRatePrecision = null;
			UnderlyingDividendAveragingMethod = null;
			UnderlyingDividendNegativeRateTreatment = null;
		}
	}
}
