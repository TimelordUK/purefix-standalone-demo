using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStubGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingPaymentStubs : IFixGroup
		{
			[TagDetails(Tag = 40709, Type = TagType.Int, Offset = 0, Required = false)]
			public int? UnderlyingPaymentStubType {get; set;}
			
			[TagDetails(Tag = 40710, Type = TagType.Int, Offset = 1, Required = false)]
			public int? UnderlyingPaymentStubLength {get; set;}
			
			[Component(Offset = 2, Required = false)]
			public UnderlyingPaymentStubStartDate? UnderlyingPaymentStubStartDate {get; set;}
			
			[Component(Offset = 3, Required = false)]
			public UnderlyingPaymentStubEndDate? UnderlyingPaymentStubEndDate {get; set;}
			
			[TagDetails(Tag = 40711, Type = TagType.Float, Offset = 4, Required = false)]
			public double? UnderlyingPaymentStubRate {get; set;}
			
			[TagDetails(Tag = 40712, Type = TagType.Float, Offset = 5, Required = false)]
			public double? UnderlyingPaymentStubFixedAmount {get; set;}
			
			[TagDetails(Tag = 40713, Type = TagType.String, Offset = 6, Required = false)]
			public string? UnderlyingPaymentStubFixedCurrency {get; set;}
			
			[TagDetails(Tag = 40714, Type = TagType.String, Offset = 7, Required = false)]
			public string? UnderlyingPaymentStubIndex {get; set;}
			
			[TagDetails(Tag = 40715, Type = TagType.Int, Offset = 8, Required = false)]
			public int? UnderlyingPaymentStubIndexSource {get; set;}
			
			[TagDetails(Tag = 40716, Type = TagType.Int, Offset = 9, Required = false)]
			public int? UnderlyingPaymentStubIndexCurvePeriod {get; set;}
			
			[TagDetails(Tag = 40717, Type = TagType.String, Offset = 10, Required = false)]
			public string? UnderlyingPaymentStubIndexCurveUnit {get; set;}
			
			[TagDetails(Tag = 40718, Type = TagType.Float, Offset = 11, Required = false)]
			public double? UnderlyingPaymentStubIndexRateMultiplier {get; set;}
			
			[TagDetails(Tag = 40719, Type = TagType.Float, Offset = 12, Required = false)]
			public double? UnderlyingPaymentStubIndexRateSpread {get; set;}
			
			[TagDetails(Tag = 40720, Type = TagType.Int, Offset = 13, Required = false)]
			public int? UnderlyingPaymentStubIndexRateSpreadPositionType {get; set;}
			
			[TagDetails(Tag = 40721, Type = TagType.Int, Offset = 14, Required = false)]
			public int? UnderlyingPaymentStubIndexRateTreatment {get; set;}
			
			[TagDetails(Tag = 40722, Type = TagType.Float, Offset = 15, Required = false)]
			public double? UnderlyingPaymentStubIndexCapRate {get; set;}
			
			[TagDetails(Tag = 40723, Type = TagType.Int, Offset = 16, Required = false)]
			public int? UnderlyingPaymentStubIndexCapRateBuySide {get; set;}
			
			[TagDetails(Tag = 40724, Type = TagType.Int, Offset = 17, Required = false)]
			public int? UnderlyingPaymentStubIndexCapRateSellSide {get; set;}
			
			[TagDetails(Tag = 40725, Type = TagType.Float, Offset = 18, Required = false)]
			public double? UnderlyingPaymentStubIndexFloorRate {get; set;}
			
			[TagDetails(Tag = 40726, Type = TagType.Int, Offset = 19, Required = false)]
			public int? UnderlyingPaymentStubIndexFloorRateBuySide {get; set;}
			
			[TagDetails(Tag = 40727, Type = TagType.Int, Offset = 20, Required = false)]
			public int? UnderlyingPaymentStubIndexFloorRateSellSide {get; set;}
			
			[TagDetails(Tag = 40728, Type = TagType.String, Offset = 21, Required = false)]
			public string? UnderlyingPaymentStubIndex2 {get; set;}
			
			[TagDetails(Tag = 40729, Type = TagType.Int, Offset = 22, Required = false)]
			public int? UnderlyingPaymentStubIndex2Source {get; set;}
			
			[TagDetails(Tag = 40730, Type = TagType.Int, Offset = 23, Required = false)]
			public int? UnderlyingPaymentStubIndex2CurvePeriod {get; set;}
			
			[TagDetails(Tag = 40731, Type = TagType.String, Offset = 24, Required = false)]
			public string? UnderlyingPaymentStubIndex2CurveUnit {get; set;}
			
			[TagDetails(Tag = 40732, Type = TagType.Float, Offset = 25, Required = false)]
			public double? UnderlyingPaymentStubIndex2RateMultiplier {get; set;}
			
			[TagDetails(Tag = 40733, Type = TagType.Float, Offset = 26, Required = false)]
			public double? UnderlyingPaymentStubIndex2RateSpread {get; set;}
			
			[TagDetails(Tag = 40734, Type = TagType.Int, Offset = 27, Required = false)]
			public int? UnderlyingPaymentStubIndex2RateSpreadPositionType {get; set;}
			
			[TagDetails(Tag = 40735, Type = TagType.Int, Offset = 28, Required = false)]
			public int? UnderlyingPaymentStubIndex2RateTreatment {get; set;}
			
			[TagDetails(Tag = 40736, Type = TagType.Float, Offset = 29, Required = false)]
			public double? UnderlyingPaymentStubIndex2CapRate {get; set;}
			
			[TagDetails(Tag = 40737, Type = TagType.Float, Offset = 30, Required = false)]
			public double? UnderlyingPaymentStubIndex2FloorRate {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingPaymentStubType is not null) writer.WriteWholeNumber(40709, UnderlyingPaymentStubType.Value);
				if (UnderlyingPaymentStubLength is not null) writer.WriteWholeNumber(40710, UnderlyingPaymentStubLength.Value);
				if (UnderlyingPaymentStubStartDate is not null) ((IFixEncoder)UnderlyingPaymentStubStartDate).Encode(writer);
				if (UnderlyingPaymentStubEndDate is not null) ((IFixEncoder)UnderlyingPaymentStubEndDate).Encode(writer);
				if (UnderlyingPaymentStubRate is not null) writer.WriteNumber(40711, UnderlyingPaymentStubRate.Value);
				if (UnderlyingPaymentStubFixedAmount is not null) writer.WriteNumber(40712, UnderlyingPaymentStubFixedAmount.Value);
				if (UnderlyingPaymentStubFixedCurrency is not null) writer.WriteString(40713, UnderlyingPaymentStubFixedCurrency);
				if (UnderlyingPaymentStubIndex is not null) writer.WriteString(40714, UnderlyingPaymentStubIndex);
				if (UnderlyingPaymentStubIndexSource is not null) writer.WriteWholeNumber(40715, UnderlyingPaymentStubIndexSource.Value);
				if (UnderlyingPaymentStubIndexCurvePeriod is not null) writer.WriteWholeNumber(40716, UnderlyingPaymentStubIndexCurvePeriod.Value);
				if (UnderlyingPaymentStubIndexCurveUnit is not null) writer.WriteString(40717, UnderlyingPaymentStubIndexCurveUnit);
				if (UnderlyingPaymentStubIndexRateMultiplier is not null) writer.WriteNumber(40718, UnderlyingPaymentStubIndexRateMultiplier.Value);
				if (UnderlyingPaymentStubIndexRateSpread is not null) writer.WriteNumber(40719, UnderlyingPaymentStubIndexRateSpread.Value);
				if (UnderlyingPaymentStubIndexRateSpreadPositionType is not null) writer.WriteWholeNumber(40720, UnderlyingPaymentStubIndexRateSpreadPositionType.Value);
				if (UnderlyingPaymentStubIndexRateTreatment is not null) writer.WriteWholeNumber(40721, UnderlyingPaymentStubIndexRateTreatment.Value);
				if (UnderlyingPaymentStubIndexCapRate is not null) writer.WriteNumber(40722, UnderlyingPaymentStubIndexCapRate.Value);
				if (UnderlyingPaymentStubIndexCapRateBuySide is not null) writer.WriteWholeNumber(40723, UnderlyingPaymentStubIndexCapRateBuySide.Value);
				if (UnderlyingPaymentStubIndexCapRateSellSide is not null) writer.WriteWholeNumber(40724, UnderlyingPaymentStubIndexCapRateSellSide.Value);
				if (UnderlyingPaymentStubIndexFloorRate is not null) writer.WriteNumber(40725, UnderlyingPaymentStubIndexFloorRate.Value);
				if (UnderlyingPaymentStubIndexFloorRateBuySide is not null) writer.WriteWholeNumber(40726, UnderlyingPaymentStubIndexFloorRateBuySide.Value);
				if (UnderlyingPaymentStubIndexFloorRateSellSide is not null) writer.WriteWholeNumber(40727, UnderlyingPaymentStubIndexFloorRateSellSide.Value);
				if (UnderlyingPaymentStubIndex2 is not null) writer.WriteString(40728, UnderlyingPaymentStubIndex2);
				if (UnderlyingPaymentStubIndex2Source is not null) writer.WriteWholeNumber(40729, UnderlyingPaymentStubIndex2Source.Value);
				if (UnderlyingPaymentStubIndex2CurvePeriod is not null) writer.WriteWholeNumber(40730, UnderlyingPaymentStubIndex2CurvePeriod.Value);
				if (UnderlyingPaymentStubIndex2CurveUnit is not null) writer.WriteString(40731, UnderlyingPaymentStubIndex2CurveUnit);
				if (UnderlyingPaymentStubIndex2RateMultiplier is not null) writer.WriteNumber(40732, UnderlyingPaymentStubIndex2RateMultiplier.Value);
				if (UnderlyingPaymentStubIndex2RateSpread is not null) writer.WriteNumber(40733, UnderlyingPaymentStubIndex2RateSpread.Value);
				if (UnderlyingPaymentStubIndex2RateSpreadPositionType is not null) writer.WriteWholeNumber(40734, UnderlyingPaymentStubIndex2RateSpreadPositionType.Value);
				if (UnderlyingPaymentStubIndex2RateTreatment is not null) writer.WriteWholeNumber(40735, UnderlyingPaymentStubIndex2RateTreatment.Value);
				if (UnderlyingPaymentStubIndex2CapRate is not null) writer.WriteNumber(40736, UnderlyingPaymentStubIndex2CapRate.Value);
				if (UnderlyingPaymentStubIndex2FloorRate is not null) writer.WriteNumber(40737, UnderlyingPaymentStubIndex2FloorRate.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingPaymentStubType = view.GetInt32(40709);
				UnderlyingPaymentStubLength = view.GetInt32(40710);
				if (view.GetView("UnderlyingPaymentStubStartDate") is IMessageView viewUnderlyingPaymentStubStartDate)
				{
					UnderlyingPaymentStubStartDate = new();
					((IFixParser)UnderlyingPaymentStubStartDate).Parse(viewUnderlyingPaymentStubStartDate);
				}
				if (view.GetView("UnderlyingPaymentStubEndDate") is IMessageView viewUnderlyingPaymentStubEndDate)
				{
					UnderlyingPaymentStubEndDate = new();
					((IFixParser)UnderlyingPaymentStubEndDate).Parse(viewUnderlyingPaymentStubEndDate);
				}
				UnderlyingPaymentStubRate = view.GetDouble(40711);
				UnderlyingPaymentStubFixedAmount = view.GetDouble(40712);
				UnderlyingPaymentStubFixedCurrency = view.GetString(40713);
				UnderlyingPaymentStubIndex = view.GetString(40714);
				UnderlyingPaymentStubIndexSource = view.GetInt32(40715);
				UnderlyingPaymentStubIndexCurvePeriod = view.GetInt32(40716);
				UnderlyingPaymentStubIndexCurveUnit = view.GetString(40717);
				UnderlyingPaymentStubIndexRateMultiplier = view.GetDouble(40718);
				UnderlyingPaymentStubIndexRateSpread = view.GetDouble(40719);
				UnderlyingPaymentStubIndexRateSpreadPositionType = view.GetInt32(40720);
				UnderlyingPaymentStubIndexRateTreatment = view.GetInt32(40721);
				UnderlyingPaymentStubIndexCapRate = view.GetDouble(40722);
				UnderlyingPaymentStubIndexCapRateBuySide = view.GetInt32(40723);
				UnderlyingPaymentStubIndexCapRateSellSide = view.GetInt32(40724);
				UnderlyingPaymentStubIndexFloorRate = view.GetDouble(40725);
				UnderlyingPaymentStubIndexFloorRateBuySide = view.GetInt32(40726);
				UnderlyingPaymentStubIndexFloorRateSellSide = view.GetInt32(40727);
				UnderlyingPaymentStubIndex2 = view.GetString(40728);
				UnderlyingPaymentStubIndex2Source = view.GetInt32(40729);
				UnderlyingPaymentStubIndex2CurvePeriod = view.GetInt32(40730);
				UnderlyingPaymentStubIndex2CurveUnit = view.GetString(40731);
				UnderlyingPaymentStubIndex2RateMultiplier = view.GetDouble(40732);
				UnderlyingPaymentStubIndex2RateSpread = view.GetDouble(40733);
				UnderlyingPaymentStubIndex2RateSpreadPositionType = view.GetInt32(40734);
				UnderlyingPaymentStubIndex2RateTreatment = view.GetInt32(40735);
				UnderlyingPaymentStubIndex2CapRate = view.GetDouble(40736);
				UnderlyingPaymentStubIndex2FloorRate = view.GetDouble(40737);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingPaymentStubType":
					{
						value = UnderlyingPaymentStubType;
						break;
					}
					case "UnderlyingPaymentStubLength":
					{
						value = UnderlyingPaymentStubLength;
						break;
					}
					case "UnderlyingPaymentStubStartDate":
					{
						value = UnderlyingPaymentStubStartDate;
						break;
					}
					case "UnderlyingPaymentStubEndDate":
					{
						value = UnderlyingPaymentStubEndDate;
						break;
					}
					case "UnderlyingPaymentStubRate":
					{
						value = UnderlyingPaymentStubRate;
						break;
					}
					case "UnderlyingPaymentStubFixedAmount":
					{
						value = UnderlyingPaymentStubFixedAmount;
						break;
					}
					case "UnderlyingPaymentStubFixedCurrency":
					{
						value = UnderlyingPaymentStubFixedCurrency;
						break;
					}
					case "UnderlyingPaymentStubIndex":
					{
						value = UnderlyingPaymentStubIndex;
						break;
					}
					case "UnderlyingPaymentStubIndexSource":
					{
						value = UnderlyingPaymentStubIndexSource;
						break;
					}
					case "UnderlyingPaymentStubIndexCurvePeriod":
					{
						value = UnderlyingPaymentStubIndexCurvePeriod;
						break;
					}
					case "UnderlyingPaymentStubIndexCurveUnit":
					{
						value = UnderlyingPaymentStubIndexCurveUnit;
						break;
					}
					case "UnderlyingPaymentStubIndexRateMultiplier":
					{
						value = UnderlyingPaymentStubIndexRateMultiplier;
						break;
					}
					case "UnderlyingPaymentStubIndexRateSpread":
					{
						value = UnderlyingPaymentStubIndexRateSpread;
						break;
					}
					case "UnderlyingPaymentStubIndexRateSpreadPositionType":
					{
						value = UnderlyingPaymentStubIndexRateSpreadPositionType;
						break;
					}
					case "UnderlyingPaymentStubIndexRateTreatment":
					{
						value = UnderlyingPaymentStubIndexRateTreatment;
						break;
					}
					case "UnderlyingPaymentStubIndexCapRate":
					{
						value = UnderlyingPaymentStubIndexCapRate;
						break;
					}
					case "UnderlyingPaymentStubIndexCapRateBuySide":
					{
						value = UnderlyingPaymentStubIndexCapRateBuySide;
						break;
					}
					case "UnderlyingPaymentStubIndexCapRateSellSide":
					{
						value = UnderlyingPaymentStubIndexCapRateSellSide;
						break;
					}
					case "UnderlyingPaymentStubIndexFloorRate":
					{
						value = UnderlyingPaymentStubIndexFloorRate;
						break;
					}
					case "UnderlyingPaymentStubIndexFloorRateBuySide":
					{
						value = UnderlyingPaymentStubIndexFloorRateBuySide;
						break;
					}
					case "UnderlyingPaymentStubIndexFloorRateSellSide":
					{
						value = UnderlyingPaymentStubIndexFloorRateSellSide;
						break;
					}
					case "UnderlyingPaymentStubIndex2":
					{
						value = UnderlyingPaymentStubIndex2;
						break;
					}
					case "UnderlyingPaymentStubIndex2Source":
					{
						value = UnderlyingPaymentStubIndex2Source;
						break;
					}
					case "UnderlyingPaymentStubIndex2CurvePeriod":
					{
						value = UnderlyingPaymentStubIndex2CurvePeriod;
						break;
					}
					case "UnderlyingPaymentStubIndex2CurveUnit":
					{
						value = UnderlyingPaymentStubIndex2CurveUnit;
						break;
					}
					case "UnderlyingPaymentStubIndex2RateMultiplier":
					{
						value = UnderlyingPaymentStubIndex2RateMultiplier;
						break;
					}
					case "UnderlyingPaymentStubIndex2RateSpread":
					{
						value = UnderlyingPaymentStubIndex2RateSpread;
						break;
					}
					case "UnderlyingPaymentStubIndex2RateSpreadPositionType":
					{
						value = UnderlyingPaymentStubIndex2RateSpreadPositionType;
						break;
					}
					case "UnderlyingPaymentStubIndex2RateTreatment":
					{
						value = UnderlyingPaymentStubIndex2RateTreatment;
						break;
					}
					case "UnderlyingPaymentStubIndex2CapRate":
					{
						value = UnderlyingPaymentStubIndex2CapRate;
						break;
					}
					case "UnderlyingPaymentStubIndex2FloorRate":
					{
						value = UnderlyingPaymentStubIndex2FloorRate;
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
				UnderlyingPaymentStubType = null;
				UnderlyingPaymentStubLength = null;
				((IFixReset?)UnderlyingPaymentStubStartDate)?.Reset();
				((IFixReset?)UnderlyingPaymentStubEndDate)?.Reset();
				UnderlyingPaymentStubRate = null;
				UnderlyingPaymentStubFixedAmount = null;
				UnderlyingPaymentStubFixedCurrency = null;
				UnderlyingPaymentStubIndex = null;
				UnderlyingPaymentStubIndexSource = null;
				UnderlyingPaymentStubIndexCurvePeriod = null;
				UnderlyingPaymentStubIndexCurveUnit = null;
				UnderlyingPaymentStubIndexRateMultiplier = null;
				UnderlyingPaymentStubIndexRateSpread = null;
				UnderlyingPaymentStubIndexRateSpreadPositionType = null;
				UnderlyingPaymentStubIndexRateTreatment = null;
				UnderlyingPaymentStubIndexCapRate = null;
				UnderlyingPaymentStubIndexCapRateBuySide = null;
				UnderlyingPaymentStubIndexCapRateSellSide = null;
				UnderlyingPaymentStubIndexFloorRate = null;
				UnderlyingPaymentStubIndexFloorRateBuySide = null;
				UnderlyingPaymentStubIndexFloorRateSellSide = null;
				UnderlyingPaymentStubIndex2 = null;
				UnderlyingPaymentStubIndex2Source = null;
				UnderlyingPaymentStubIndex2CurvePeriod = null;
				UnderlyingPaymentStubIndex2CurveUnit = null;
				UnderlyingPaymentStubIndex2RateMultiplier = null;
				UnderlyingPaymentStubIndex2RateSpread = null;
				UnderlyingPaymentStubIndex2RateSpreadPositionType = null;
				UnderlyingPaymentStubIndex2RateTreatment = null;
				UnderlyingPaymentStubIndex2CapRate = null;
				UnderlyingPaymentStubIndex2FloorRate = null;
			}
		}
		[Group(NoOfTag = 40708, Offset = 0, Required = false)]
		public NoUnderlyingPaymentStubs[]? UnderlyingPaymentStubs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStubs is not null && UnderlyingPaymentStubs.Length != 0)
			{
				writer.WriteWholeNumber(40708, UnderlyingPaymentStubs.Length);
				for (int i = 0; i < UnderlyingPaymentStubs.Length; i++)
				{
					((IFixEncoder)UnderlyingPaymentStubs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingPaymentStubs") is IMessageView viewNoUnderlyingPaymentStubs)
			{
				var count = viewNoUnderlyingPaymentStubs.GroupCount();
				UnderlyingPaymentStubs = new NoUnderlyingPaymentStubs[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingPaymentStubs[i] = new();
					((IFixParser)UnderlyingPaymentStubs[i]).Parse(viewNoUnderlyingPaymentStubs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingPaymentStubs":
				{
					value = UnderlyingPaymentStubs;
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
			UnderlyingPaymentStubs = null;
		}
	}
}
