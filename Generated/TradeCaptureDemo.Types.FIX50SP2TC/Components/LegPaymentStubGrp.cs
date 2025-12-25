using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStubGrp : IFixComponent
	{
		public sealed partial class NoLegPaymentStubs : IFixGroup
		{
			[TagDetails(Tag = 40419, Type = TagType.Int, Offset = 0, Required = false)]
			public int? LegPaymentStubType {get; set;}
			
			[TagDetails(Tag = 40420, Type = TagType.Int, Offset = 1, Required = false)]
			public int? LegPaymentStubLength {get; set;}
			
			[Component(Offset = 2, Required = false)]
			public LegPaymentStubStartDate? LegPaymentStubStartDate {get; set;}
			
			[Component(Offset = 3, Required = false)]
			public LegPaymentStubEndDate? LegPaymentStubEndDate {get; set;}
			
			[TagDetails(Tag = 40421, Type = TagType.Float, Offset = 4, Required = false)]
			public double? LegPaymentStubRate {get; set;}
			
			[TagDetails(Tag = 40422, Type = TagType.Float, Offset = 5, Required = false)]
			public double? LegPaymentStubFixedAmount {get; set;}
			
			[TagDetails(Tag = 40423, Type = TagType.String, Offset = 6, Required = false)]
			public string? LegPaymentStubFixedCurrency {get; set;}
			
			[TagDetails(Tag = 40424, Type = TagType.String, Offset = 7, Required = false)]
			public string? LegPaymentStubIndex {get; set;}
			
			[TagDetails(Tag = 40425, Type = TagType.Int, Offset = 8, Required = false)]
			public int? LegPaymentStubIndexSource {get; set;}
			
			[TagDetails(Tag = 40426, Type = TagType.Int, Offset = 9, Required = false)]
			public int? LegPaymentStubIndexCurvePeriod {get; set;}
			
			[TagDetails(Tag = 40427, Type = TagType.String, Offset = 10, Required = false)]
			public string? LegPaymentStubIndexCurveUnit {get; set;}
			
			[TagDetails(Tag = 40428, Type = TagType.Float, Offset = 11, Required = false)]
			public double? LegPaymentStubIndexRateMultiplier {get; set;}
			
			[TagDetails(Tag = 40429, Type = TagType.Float, Offset = 12, Required = false)]
			public double? LegPaymentStubIndexRateSpread {get; set;}
			
			[TagDetails(Tag = 40430, Type = TagType.Int, Offset = 13, Required = false)]
			public int? LegPaymentStubIndexRateSpreadPositionType {get; set;}
			
			[TagDetails(Tag = 40431, Type = TagType.Int, Offset = 14, Required = false)]
			public int? LegPaymentStubIndexRateTreatment {get; set;}
			
			[TagDetails(Tag = 40432, Type = TagType.Float, Offset = 15, Required = false)]
			public double? LegPaymentStubIndexCapRate {get; set;}
			
			[TagDetails(Tag = 40433, Type = TagType.Int, Offset = 16, Required = false)]
			public int? LegPaymentStubIndexCapRateBuySide {get; set;}
			
			[TagDetails(Tag = 40434, Type = TagType.Int, Offset = 17, Required = false)]
			public int? LegPaymentStubIndexCapRateSellSide {get; set;}
			
			[TagDetails(Tag = 40435, Type = TagType.Float, Offset = 18, Required = false)]
			public double? LegPaymentStubIndexFloorRate {get; set;}
			
			[TagDetails(Tag = 40436, Type = TagType.Int, Offset = 19, Required = false)]
			public int? LegPaymentStubIndexFloorRateBuySide {get; set;}
			
			[TagDetails(Tag = 40437, Type = TagType.Int, Offset = 20, Required = false)]
			public int? LegPaymentStubIndexFloorRateSellSide {get; set;}
			
			[TagDetails(Tag = 40438, Type = TagType.String, Offset = 21, Required = false)]
			public string? LegPaymentStubIndex2 {get; set;}
			
			[TagDetails(Tag = 40439, Type = TagType.Int, Offset = 22, Required = false)]
			public int? LegPaymentStubIndex2Source {get; set;}
			
			[TagDetails(Tag = 40440, Type = TagType.Int, Offset = 23, Required = false)]
			public int? LegPaymentStubIndex2CurvePeriod {get; set;}
			
			[TagDetails(Tag = 40441, Type = TagType.String, Offset = 24, Required = false)]
			public string? LegPaymentStubIndex2CurveUnit {get; set;}
			
			[TagDetails(Tag = 40442, Type = TagType.Float, Offset = 25, Required = false)]
			public double? LegPaymentStubIndex2RateMultiplier {get; set;}
			
			[TagDetails(Tag = 40443, Type = TagType.Float, Offset = 26, Required = false)]
			public double? LegPaymentStubIndex2RateSpread {get; set;}
			
			[TagDetails(Tag = 40444, Type = TagType.Int, Offset = 27, Required = false)]
			public int? LegPaymentStubIndex2RateSpreadPositionType {get; set;}
			
			[TagDetails(Tag = 40445, Type = TagType.Int, Offset = 28, Required = false)]
			public int? LegPaymentStubIndex2RateTreatment {get; set;}
			
			[TagDetails(Tag = 40446, Type = TagType.Float, Offset = 29, Required = false)]
			public double? LegPaymentStubIndex2CapRate {get; set;}
			
			[TagDetails(Tag = 40447, Type = TagType.Float, Offset = 30, Required = false)]
			public double? LegPaymentStubIndex2FloorRate {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegPaymentStubType is not null) writer.WriteWholeNumber(40419, LegPaymentStubType.Value);
				if (LegPaymentStubLength is not null) writer.WriteWholeNumber(40420, LegPaymentStubLength.Value);
				if (LegPaymentStubStartDate is not null) ((IFixEncoder)LegPaymentStubStartDate).Encode(writer);
				if (LegPaymentStubEndDate is not null) ((IFixEncoder)LegPaymentStubEndDate).Encode(writer);
				if (LegPaymentStubRate is not null) writer.WriteNumber(40421, LegPaymentStubRate.Value);
				if (LegPaymentStubFixedAmount is not null) writer.WriteNumber(40422, LegPaymentStubFixedAmount.Value);
				if (LegPaymentStubFixedCurrency is not null) writer.WriteString(40423, LegPaymentStubFixedCurrency);
				if (LegPaymentStubIndex is not null) writer.WriteString(40424, LegPaymentStubIndex);
				if (LegPaymentStubIndexSource is not null) writer.WriteWholeNumber(40425, LegPaymentStubIndexSource.Value);
				if (LegPaymentStubIndexCurvePeriod is not null) writer.WriteWholeNumber(40426, LegPaymentStubIndexCurvePeriod.Value);
				if (LegPaymentStubIndexCurveUnit is not null) writer.WriteString(40427, LegPaymentStubIndexCurveUnit);
				if (LegPaymentStubIndexRateMultiplier is not null) writer.WriteNumber(40428, LegPaymentStubIndexRateMultiplier.Value);
				if (LegPaymentStubIndexRateSpread is not null) writer.WriteNumber(40429, LegPaymentStubIndexRateSpread.Value);
				if (LegPaymentStubIndexRateSpreadPositionType is not null) writer.WriteWholeNumber(40430, LegPaymentStubIndexRateSpreadPositionType.Value);
				if (LegPaymentStubIndexRateTreatment is not null) writer.WriteWholeNumber(40431, LegPaymentStubIndexRateTreatment.Value);
				if (LegPaymentStubIndexCapRate is not null) writer.WriteNumber(40432, LegPaymentStubIndexCapRate.Value);
				if (LegPaymentStubIndexCapRateBuySide is not null) writer.WriteWholeNumber(40433, LegPaymentStubIndexCapRateBuySide.Value);
				if (LegPaymentStubIndexCapRateSellSide is not null) writer.WriteWholeNumber(40434, LegPaymentStubIndexCapRateSellSide.Value);
				if (LegPaymentStubIndexFloorRate is not null) writer.WriteNumber(40435, LegPaymentStubIndexFloorRate.Value);
				if (LegPaymentStubIndexFloorRateBuySide is not null) writer.WriteWholeNumber(40436, LegPaymentStubIndexFloorRateBuySide.Value);
				if (LegPaymentStubIndexFloorRateSellSide is not null) writer.WriteWholeNumber(40437, LegPaymentStubIndexFloorRateSellSide.Value);
				if (LegPaymentStubIndex2 is not null) writer.WriteString(40438, LegPaymentStubIndex2);
				if (LegPaymentStubIndex2Source is not null) writer.WriteWholeNumber(40439, LegPaymentStubIndex2Source.Value);
				if (LegPaymentStubIndex2CurvePeriod is not null) writer.WriteWholeNumber(40440, LegPaymentStubIndex2CurvePeriod.Value);
				if (LegPaymentStubIndex2CurveUnit is not null) writer.WriteString(40441, LegPaymentStubIndex2CurveUnit);
				if (LegPaymentStubIndex2RateMultiplier is not null) writer.WriteNumber(40442, LegPaymentStubIndex2RateMultiplier.Value);
				if (LegPaymentStubIndex2RateSpread is not null) writer.WriteNumber(40443, LegPaymentStubIndex2RateSpread.Value);
				if (LegPaymentStubIndex2RateSpreadPositionType is not null) writer.WriteWholeNumber(40444, LegPaymentStubIndex2RateSpreadPositionType.Value);
				if (LegPaymentStubIndex2RateTreatment is not null) writer.WriteWholeNumber(40445, LegPaymentStubIndex2RateTreatment.Value);
				if (LegPaymentStubIndex2CapRate is not null) writer.WriteNumber(40446, LegPaymentStubIndex2CapRate.Value);
				if (LegPaymentStubIndex2FloorRate is not null) writer.WriteNumber(40447, LegPaymentStubIndex2FloorRate.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegPaymentStubType = view.GetInt32(40419);
				LegPaymentStubLength = view.GetInt32(40420);
				if (view.GetView("LegPaymentStubStartDate") is IMessageView viewLegPaymentStubStartDate)
				{
					LegPaymentStubStartDate = new();
					((IFixParser)LegPaymentStubStartDate).Parse(viewLegPaymentStubStartDate);
				}
				if (view.GetView("LegPaymentStubEndDate") is IMessageView viewLegPaymentStubEndDate)
				{
					LegPaymentStubEndDate = new();
					((IFixParser)LegPaymentStubEndDate).Parse(viewLegPaymentStubEndDate);
				}
				LegPaymentStubRate = view.GetDouble(40421);
				LegPaymentStubFixedAmount = view.GetDouble(40422);
				LegPaymentStubFixedCurrency = view.GetString(40423);
				LegPaymentStubIndex = view.GetString(40424);
				LegPaymentStubIndexSource = view.GetInt32(40425);
				LegPaymentStubIndexCurvePeriod = view.GetInt32(40426);
				LegPaymentStubIndexCurveUnit = view.GetString(40427);
				LegPaymentStubIndexRateMultiplier = view.GetDouble(40428);
				LegPaymentStubIndexRateSpread = view.GetDouble(40429);
				LegPaymentStubIndexRateSpreadPositionType = view.GetInt32(40430);
				LegPaymentStubIndexRateTreatment = view.GetInt32(40431);
				LegPaymentStubIndexCapRate = view.GetDouble(40432);
				LegPaymentStubIndexCapRateBuySide = view.GetInt32(40433);
				LegPaymentStubIndexCapRateSellSide = view.GetInt32(40434);
				LegPaymentStubIndexFloorRate = view.GetDouble(40435);
				LegPaymentStubIndexFloorRateBuySide = view.GetInt32(40436);
				LegPaymentStubIndexFloorRateSellSide = view.GetInt32(40437);
				LegPaymentStubIndex2 = view.GetString(40438);
				LegPaymentStubIndex2Source = view.GetInt32(40439);
				LegPaymentStubIndex2CurvePeriod = view.GetInt32(40440);
				LegPaymentStubIndex2CurveUnit = view.GetString(40441);
				LegPaymentStubIndex2RateMultiplier = view.GetDouble(40442);
				LegPaymentStubIndex2RateSpread = view.GetDouble(40443);
				LegPaymentStubIndex2RateSpreadPositionType = view.GetInt32(40444);
				LegPaymentStubIndex2RateTreatment = view.GetInt32(40445);
				LegPaymentStubIndex2CapRate = view.GetDouble(40446);
				LegPaymentStubIndex2FloorRate = view.GetDouble(40447);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegPaymentStubType":
					{
						value = LegPaymentStubType;
						break;
					}
					case "LegPaymentStubLength":
					{
						value = LegPaymentStubLength;
						break;
					}
					case "LegPaymentStubStartDate":
					{
						value = LegPaymentStubStartDate;
						break;
					}
					case "LegPaymentStubEndDate":
					{
						value = LegPaymentStubEndDate;
						break;
					}
					case "LegPaymentStubRate":
					{
						value = LegPaymentStubRate;
						break;
					}
					case "LegPaymentStubFixedAmount":
					{
						value = LegPaymentStubFixedAmount;
						break;
					}
					case "LegPaymentStubFixedCurrency":
					{
						value = LegPaymentStubFixedCurrency;
						break;
					}
					case "LegPaymentStubIndex":
					{
						value = LegPaymentStubIndex;
						break;
					}
					case "LegPaymentStubIndexSource":
					{
						value = LegPaymentStubIndexSource;
						break;
					}
					case "LegPaymentStubIndexCurvePeriod":
					{
						value = LegPaymentStubIndexCurvePeriod;
						break;
					}
					case "LegPaymentStubIndexCurveUnit":
					{
						value = LegPaymentStubIndexCurveUnit;
						break;
					}
					case "LegPaymentStubIndexRateMultiplier":
					{
						value = LegPaymentStubIndexRateMultiplier;
						break;
					}
					case "LegPaymentStubIndexRateSpread":
					{
						value = LegPaymentStubIndexRateSpread;
						break;
					}
					case "LegPaymentStubIndexRateSpreadPositionType":
					{
						value = LegPaymentStubIndexRateSpreadPositionType;
						break;
					}
					case "LegPaymentStubIndexRateTreatment":
					{
						value = LegPaymentStubIndexRateTreatment;
						break;
					}
					case "LegPaymentStubIndexCapRate":
					{
						value = LegPaymentStubIndexCapRate;
						break;
					}
					case "LegPaymentStubIndexCapRateBuySide":
					{
						value = LegPaymentStubIndexCapRateBuySide;
						break;
					}
					case "LegPaymentStubIndexCapRateSellSide":
					{
						value = LegPaymentStubIndexCapRateSellSide;
						break;
					}
					case "LegPaymentStubIndexFloorRate":
					{
						value = LegPaymentStubIndexFloorRate;
						break;
					}
					case "LegPaymentStubIndexFloorRateBuySide":
					{
						value = LegPaymentStubIndexFloorRateBuySide;
						break;
					}
					case "LegPaymentStubIndexFloorRateSellSide":
					{
						value = LegPaymentStubIndexFloorRateSellSide;
						break;
					}
					case "LegPaymentStubIndex2":
					{
						value = LegPaymentStubIndex2;
						break;
					}
					case "LegPaymentStubIndex2Source":
					{
						value = LegPaymentStubIndex2Source;
						break;
					}
					case "LegPaymentStubIndex2CurvePeriod":
					{
						value = LegPaymentStubIndex2CurvePeriod;
						break;
					}
					case "LegPaymentStubIndex2CurveUnit":
					{
						value = LegPaymentStubIndex2CurveUnit;
						break;
					}
					case "LegPaymentStubIndex2RateMultiplier":
					{
						value = LegPaymentStubIndex2RateMultiplier;
						break;
					}
					case "LegPaymentStubIndex2RateSpread":
					{
						value = LegPaymentStubIndex2RateSpread;
						break;
					}
					case "LegPaymentStubIndex2RateSpreadPositionType":
					{
						value = LegPaymentStubIndex2RateSpreadPositionType;
						break;
					}
					case "LegPaymentStubIndex2RateTreatment":
					{
						value = LegPaymentStubIndex2RateTreatment;
						break;
					}
					case "LegPaymentStubIndex2CapRate":
					{
						value = LegPaymentStubIndex2CapRate;
						break;
					}
					case "LegPaymentStubIndex2FloorRate":
					{
						value = LegPaymentStubIndex2FloorRate;
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
				LegPaymentStubType = null;
				LegPaymentStubLength = null;
				((IFixReset?)LegPaymentStubStartDate)?.Reset();
				((IFixReset?)LegPaymentStubEndDate)?.Reset();
				LegPaymentStubRate = null;
				LegPaymentStubFixedAmount = null;
				LegPaymentStubFixedCurrency = null;
				LegPaymentStubIndex = null;
				LegPaymentStubIndexSource = null;
				LegPaymentStubIndexCurvePeriod = null;
				LegPaymentStubIndexCurveUnit = null;
				LegPaymentStubIndexRateMultiplier = null;
				LegPaymentStubIndexRateSpread = null;
				LegPaymentStubIndexRateSpreadPositionType = null;
				LegPaymentStubIndexRateTreatment = null;
				LegPaymentStubIndexCapRate = null;
				LegPaymentStubIndexCapRateBuySide = null;
				LegPaymentStubIndexCapRateSellSide = null;
				LegPaymentStubIndexFloorRate = null;
				LegPaymentStubIndexFloorRateBuySide = null;
				LegPaymentStubIndexFloorRateSellSide = null;
				LegPaymentStubIndex2 = null;
				LegPaymentStubIndex2Source = null;
				LegPaymentStubIndex2CurvePeriod = null;
				LegPaymentStubIndex2CurveUnit = null;
				LegPaymentStubIndex2RateMultiplier = null;
				LegPaymentStubIndex2RateSpread = null;
				LegPaymentStubIndex2RateSpreadPositionType = null;
				LegPaymentStubIndex2RateTreatment = null;
				LegPaymentStubIndex2CapRate = null;
				LegPaymentStubIndex2FloorRate = null;
			}
		}
		[Group(NoOfTag = 40418, Offset = 0, Required = false)]
		public NoLegPaymentStubs[]? LegPaymentStubs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStubs is not null && LegPaymentStubs.Length != 0)
			{
				writer.WriteWholeNumber(40418, LegPaymentStubs.Length);
				for (int i = 0; i < LegPaymentStubs.Length; i++)
				{
					((IFixEncoder)LegPaymentStubs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegPaymentStubs") is IMessageView viewNoLegPaymentStubs)
			{
				var count = viewNoLegPaymentStubs.GroupCount();
				LegPaymentStubs = new NoLegPaymentStubs[count];
				for (int i = 0; i < count; i++)
				{
					LegPaymentStubs[i] = new();
					((IFixParser)LegPaymentStubs[i]).Parse(viewNoLegPaymentStubs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegPaymentStubs":
				{
					value = LegPaymentStubs;
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
			LegPaymentStubs = null;
		}
	}
}
