using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStubGrp : IFixComponent
	{
		public sealed partial class NoPaymentStubs : IFixGroup
		{
			[TagDetails(Tag = 40873, Type = TagType.Int, Offset = 0, Required = false)]
			public int? PaymentStubType {get; set;}
			
			[TagDetails(Tag = 40874, Type = TagType.Int, Offset = 1, Required = false)]
			public int? PaymentStubLength {get; set;}
			
			[Component(Offset = 2, Required = false)]
			public PaymentStubStartDate? PaymentStubStartDate {get; set;}
			
			[Component(Offset = 3, Required = false)]
			public PaymentStubEndDate? PaymentStubEndDate {get; set;}
			
			[TagDetails(Tag = 40875, Type = TagType.Float, Offset = 4, Required = false)]
			public double? PaymentStubRate {get; set;}
			
			[TagDetails(Tag = 40876, Type = TagType.Float, Offset = 5, Required = false)]
			public double? PaymentStubFixedAmount {get; set;}
			
			[TagDetails(Tag = 40877, Type = TagType.String, Offset = 6, Required = false)]
			public string? PaymentStubFixedCurrency {get; set;}
			
			[TagDetails(Tag = 40878, Type = TagType.String, Offset = 7, Required = false)]
			public string? PaymentStubIndex {get; set;}
			
			[TagDetails(Tag = 40879, Type = TagType.Int, Offset = 8, Required = false)]
			public int? PaymentStubIndexSource {get; set;}
			
			[TagDetails(Tag = 40880, Type = TagType.Int, Offset = 9, Required = false)]
			public int? PaymentStubIndexCurvePeriod {get; set;}
			
			[TagDetails(Tag = 40881, Type = TagType.String, Offset = 10, Required = false)]
			public string? PaymentStubIndexCurveUnit {get; set;}
			
			[TagDetails(Tag = 40882, Type = TagType.Float, Offset = 11, Required = false)]
			public double? PaymentStubIndexRateMultiplier {get; set;}
			
			[TagDetails(Tag = 40883, Type = TagType.Float, Offset = 12, Required = false)]
			public double? PaymentStubIndexRateSpread {get; set;}
			
			[TagDetails(Tag = 40884, Type = TagType.Int, Offset = 13, Required = false)]
			public int? PaymentStubIndexRateSpreadPositionType {get; set;}
			
			[TagDetails(Tag = 40885, Type = TagType.Int, Offset = 14, Required = false)]
			public int? PaymentStubIndexRateTreatment {get; set;}
			
			[TagDetails(Tag = 40886, Type = TagType.Float, Offset = 15, Required = false)]
			public double? PaymentStubIndexCapRate {get; set;}
			
			[TagDetails(Tag = 40887, Type = TagType.Int, Offset = 16, Required = false)]
			public int? PaymentStubIndexCapRateBuySide {get; set;}
			
			[TagDetails(Tag = 40888, Type = TagType.Int, Offset = 17, Required = false)]
			public int? PaymentStubIndexCapRateSellSide {get; set;}
			
			[TagDetails(Tag = 40889, Type = TagType.Float, Offset = 18, Required = false)]
			public double? PaymentStubIndexFloorRate {get; set;}
			
			[TagDetails(Tag = 40890, Type = TagType.Int, Offset = 19, Required = false)]
			public int? PaymentStubIndexFloorRateBuySide {get; set;}
			
			[TagDetails(Tag = 40891, Type = TagType.Int, Offset = 20, Required = false)]
			public int? PaymentStubIndexFloorRateSellSide {get; set;}
			
			[TagDetails(Tag = 40892, Type = TagType.String, Offset = 21, Required = false)]
			public string? PaymentStubIndex2 {get; set;}
			
			[TagDetails(Tag = 40893, Type = TagType.Int, Offset = 22, Required = false)]
			public int? PaymentStubIndex2Source {get; set;}
			
			[TagDetails(Tag = 40894, Type = TagType.Int, Offset = 23, Required = false)]
			public int? PaymentStubIndex2CurvePeriod {get; set;}
			
			[TagDetails(Tag = 40895, Type = TagType.String, Offset = 24, Required = false)]
			public string? PaymentStubIndex2CurveUnit {get; set;}
			
			[TagDetails(Tag = 40896, Type = TagType.Float, Offset = 25, Required = false)]
			public double? PaymentStubIndex2RateMultiplier {get; set;}
			
			[TagDetails(Tag = 40897, Type = TagType.Float, Offset = 26, Required = false)]
			public double? PaymentStubIndex2RateSpread {get; set;}
			
			[TagDetails(Tag = 40898, Type = TagType.Int, Offset = 27, Required = false)]
			public int? PaymentStubIndex2RateSpreadPositionType {get; set;}
			
			[TagDetails(Tag = 40899, Type = TagType.Int, Offset = 28, Required = false)]
			public int? PaymentStubIndex2RateTreatment {get; set;}
			
			[TagDetails(Tag = 40900, Type = TagType.Float, Offset = 29, Required = false)]
			public double? PaymentStubIndex2CapRate {get; set;}
			
			[TagDetails(Tag = 40901, Type = TagType.Float, Offset = 30, Required = false)]
			public double? PaymentStubIndex2FloorRate {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PaymentStubType is not null) writer.WriteWholeNumber(40873, PaymentStubType.Value);
				if (PaymentStubLength is not null) writer.WriteWholeNumber(40874, PaymentStubLength.Value);
				if (PaymentStubStartDate is not null) ((IFixEncoder)PaymentStubStartDate).Encode(writer);
				if (PaymentStubEndDate is not null) ((IFixEncoder)PaymentStubEndDate).Encode(writer);
				if (PaymentStubRate is not null) writer.WriteNumber(40875, PaymentStubRate.Value);
				if (PaymentStubFixedAmount is not null) writer.WriteNumber(40876, PaymentStubFixedAmount.Value);
				if (PaymentStubFixedCurrency is not null) writer.WriteString(40877, PaymentStubFixedCurrency);
				if (PaymentStubIndex is not null) writer.WriteString(40878, PaymentStubIndex);
				if (PaymentStubIndexSource is not null) writer.WriteWholeNumber(40879, PaymentStubIndexSource.Value);
				if (PaymentStubIndexCurvePeriod is not null) writer.WriteWholeNumber(40880, PaymentStubIndexCurvePeriod.Value);
				if (PaymentStubIndexCurveUnit is not null) writer.WriteString(40881, PaymentStubIndexCurveUnit);
				if (PaymentStubIndexRateMultiplier is not null) writer.WriteNumber(40882, PaymentStubIndexRateMultiplier.Value);
				if (PaymentStubIndexRateSpread is not null) writer.WriteNumber(40883, PaymentStubIndexRateSpread.Value);
				if (PaymentStubIndexRateSpreadPositionType is not null) writer.WriteWholeNumber(40884, PaymentStubIndexRateSpreadPositionType.Value);
				if (PaymentStubIndexRateTreatment is not null) writer.WriteWholeNumber(40885, PaymentStubIndexRateTreatment.Value);
				if (PaymentStubIndexCapRate is not null) writer.WriteNumber(40886, PaymentStubIndexCapRate.Value);
				if (PaymentStubIndexCapRateBuySide is not null) writer.WriteWholeNumber(40887, PaymentStubIndexCapRateBuySide.Value);
				if (PaymentStubIndexCapRateSellSide is not null) writer.WriteWholeNumber(40888, PaymentStubIndexCapRateSellSide.Value);
				if (PaymentStubIndexFloorRate is not null) writer.WriteNumber(40889, PaymentStubIndexFloorRate.Value);
				if (PaymentStubIndexFloorRateBuySide is not null) writer.WriteWholeNumber(40890, PaymentStubIndexFloorRateBuySide.Value);
				if (PaymentStubIndexFloorRateSellSide is not null) writer.WriteWholeNumber(40891, PaymentStubIndexFloorRateSellSide.Value);
				if (PaymentStubIndex2 is not null) writer.WriteString(40892, PaymentStubIndex2);
				if (PaymentStubIndex2Source is not null) writer.WriteWholeNumber(40893, PaymentStubIndex2Source.Value);
				if (PaymentStubIndex2CurvePeriod is not null) writer.WriteWholeNumber(40894, PaymentStubIndex2CurvePeriod.Value);
				if (PaymentStubIndex2CurveUnit is not null) writer.WriteString(40895, PaymentStubIndex2CurveUnit);
				if (PaymentStubIndex2RateMultiplier is not null) writer.WriteNumber(40896, PaymentStubIndex2RateMultiplier.Value);
				if (PaymentStubIndex2RateSpread is not null) writer.WriteNumber(40897, PaymentStubIndex2RateSpread.Value);
				if (PaymentStubIndex2RateSpreadPositionType is not null) writer.WriteWholeNumber(40898, PaymentStubIndex2RateSpreadPositionType.Value);
				if (PaymentStubIndex2RateTreatment is not null) writer.WriteWholeNumber(40899, PaymentStubIndex2RateTreatment.Value);
				if (PaymentStubIndex2CapRate is not null) writer.WriteNumber(40900, PaymentStubIndex2CapRate.Value);
				if (PaymentStubIndex2FloorRate is not null) writer.WriteNumber(40901, PaymentStubIndex2FloorRate.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PaymentStubType = view.GetInt32(40873);
				PaymentStubLength = view.GetInt32(40874);
				if (view.GetView("PaymentStubStartDate") is IMessageView viewPaymentStubStartDate)
				{
					PaymentStubStartDate = new();
					((IFixParser)PaymentStubStartDate).Parse(viewPaymentStubStartDate);
				}
				if (view.GetView("PaymentStubEndDate") is IMessageView viewPaymentStubEndDate)
				{
					PaymentStubEndDate = new();
					((IFixParser)PaymentStubEndDate).Parse(viewPaymentStubEndDate);
				}
				PaymentStubRate = view.GetDouble(40875);
				PaymentStubFixedAmount = view.GetDouble(40876);
				PaymentStubFixedCurrency = view.GetString(40877);
				PaymentStubIndex = view.GetString(40878);
				PaymentStubIndexSource = view.GetInt32(40879);
				PaymentStubIndexCurvePeriod = view.GetInt32(40880);
				PaymentStubIndexCurveUnit = view.GetString(40881);
				PaymentStubIndexRateMultiplier = view.GetDouble(40882);
				PaymentStubIndexRateSpread = view.GetDouble(40883);
				PaymentStubIndexRateSpreadPositionType = view.GetInt32(40884);
				PaymentStubIndexRateTreatment = view.GetInt32(40885);
				PaymentStubIndexCapRate = view.GetDouble(40886);
				PaymentStubIndexCapRateBuySide = view.GetInt32(40887);
				PaymentStubIndexCapRateSellSide = view.GetInt32(40888);
				PaymentStubIndexFloorRate = view.GetDouble(40889);
				PaymentStubIndexFloorRateBuySide = view.GetInt32(40890);
				PaymentStubIndexFloorRateSellSide = view.GetInt32(40891);
				PaymentStubIndex2 = view.GetString(40892);
				PaymentStubIndex2Source = view.GetInt32(40893);
				PaymentStubIndex2CurvePeriod = view.GetInt32(40894);
				PaymentStubIndex2CurveUnit = view.GetString(40895);
				PaymentStubIndex2RateMultiplier = view.GetDouble(40896);
				PaymentStubIndex2RateSpread = view.GetDouble(40897);
				PaymentStubIndex2RateSpreadPositionType = view.GetInt32(40898);
				PaymentStubIndex2RateTreatment = view.GetInt32(40899);
				PaymentStubIndex2CapRate = view.GetDouble(40900);
				PaymentStubIndex2FloorRate = view.GetDouble(40901);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PaymentStubType":
					{
						value = PaymentStubType;
						break;
					}
					case "PaymentStubLength":
					{
						value = PaymentStubLength;
						break;
					}
					case "PaymentStubStartDate":
					{
						value = PaymentStubStartDate;
						break;
					}
					case "PaymentStubEndDate":
					{
						value = PaymentStubEndDate;
						break;
					}
					case "PaymentStubRate":
					{
						value = PaymentStubRate;
						break;
					}
					case "PaymentStubFixedAmount":
					{
						value = PaymentStubFixedAmount;
						break;
					}
					case "PaymentStubFixedCurrency":
					{
						value = PaymentStubFixedCurrency;
						break;
					}
					case "PaymentStubIndex":
					{
						value = PaymentStubIndex;
						break;
					}
					case "PaymentStubIndexSource":
					{
						value = PaymentStubIndexSource;
						break;
					}
					case "PaymentStubIndexCurvePeriod":
					{
						value = PaymentStubIndexCurvePeriod;
						break;
					}
					case "PaymentStubIndexCurveUnit":
					{
						value = PaymentStubIndexCurveUnit;
						break;
					}
					case "PaymentStubIndexRateMultiplier":
					{
						value = PaymentStubIndexRateMultiplier;
						break;
					}
					case "PaymentStubIndexRateSpread":
					{
						value = PaymentStubIndexRateSpread;
						break;
					}
					case "PaymentStubIndexRateSpreadPositionType":
					{
						value = PaymentStubIndexRateSpreadPositionType;
						break;
					}
					case "PaymentStubIndexRateTreatment":
					{
						value = PaymentStubIndexRateTreatment;
						break;
					}
					case "PaymentStubIndexCapRate":
					{
						value = PaymentStubIndexCapRate;
						break;
					}
					case "PaymentStubIndexCapRateBuySide":
					{
						value = PaymentStubIndexCapRateBuySide;
						break;
					}
					case "PaymentStubIndexCapRateSellSide":
					{
						value = PaymentStubIndexCapRateSellSide;
						break;
					}
					case "PaymentStubIndexFloorRate":
					{
						value = PaymentStubIndexFloorRate;
						break;
					}
					case "PaymentStubIndexFloorRateBuySide":
					{
						value = PaymentStubIndexFloorRateBuySide;
						break;
					}
					case "PaymentStubIndexFloorRateSellSide":
					{
						value = PaymentStubIndexFloorRateSellSide;
						break;
					}
					case "PaymentStubIndex2":
					{
						value = PaymentStubIndex2;
						break;
					}
					case "PaymentStubIndex2Source":
					{
						value = PaymentStubIndex2Source;
						break;
					}
					case "PaymentStubIndex2CurvePeriod":
					{
						value = PaymentStubIndex2CurvePeriod;
						break;
					}
					case "PaymentStubIndex2CurveUnit":
					{
						value = PaymentStubIndex2CurveUnit;
						break;
					}
					case "PaymentStubIndex2RateMultiplier":
					{
						value = PaymentStubIndex2RateMultiplier;
						break;
					}
					case "PaymentStubIndex2RateSpread":
					{
						value = PaymentStubIndex2RateSpread;
						break;
					}
					case "PaymentStubIndex2RateSpreadPositionType":
					{
						value = PaymentStubIndex2RateSpreadPositionType;
						break;
					}
					case "PaymentStubIndex2RateTreatment":
					{
						value = PaymentStubIndex2RateTreatment;
						break;
					}
					case "PaymentStubIndex2CapRate":
					{
						value = PaymentStubIndex2CapRate;
						break;
					}
					case "PaymentStubIndex2FloorRate":
					{
						value = PaymentStubIndex2FloorRate;
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
				PaymentStubType = null;
				PaymentStubLength = null;
				((IFixReset?)PaymentStubStartDate)?.Reset();
				((IFixReset?)PaymentStubEndDate)?.Reset();
				PaymentStubRate = null;
				PaymentStubFixedAmount = null;
				PaymentStubFixedCurrency = null;
				PaymentStubIndex = null;
				PaymentStubIndexSource = null;
				PaymentStubIndexCurvePeriod = null;
				PaymentStubIndexCurveUnit = null;
				PaymentStubIndexRateMultiplier = null;
				PaymentStubIndexRateSpread = null;
				PaymentStubIndexRateSpreadPositionType = null;
				PaymentStubIndexRateTreatment = null;
				PaymentStubIndexCapRate = null;
				PaymentStubIndexCapRateBuySide = null;
				PaymentStubIndexCapRateSellSide = null;
				PaymentStubIndexFloorRate = null;
				PaymentStubIndexFloorRateBuySide = null;
				PaymentStubIndexFloorRateSellSide = null;
				PaymentStubIndex2 = null;
				PaymentStubIndex2Source = null;
				PaymentStubIndex2CurvePeriod = null;
				PaymentStubIndex2CurveUnit = null;
				PaymentStubIndex2RateMultiplier = null;
				PaymentStubIndex2RateSpread = null;
				PaymentStubIndex2RateSpreadPositionType = null;
				PaymentStubIndex2RateTreatment = null;
				PaymentStubIndex2CapRate = null;
				PaymentStubIndex2FloorRate = null;
			}
		}
		[Group(NoOfTag = 40872, Offset = 0, Required = false)]
		public NoPaymentStubs[]? PaymentStubs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStubs is not null && PaymentStubs.Length != 0)
			{
				writer.WriteWholeNumber(40872, PaymentStubs.Length);
				for (int i = 0; i < PaymentStubs.Length; i++)
				{
					((IFixEncoder)PaymentStubs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPaymentStubs") is IMessageView viewNoPaymentStubs)
			{
				var count = viewNoPaymentStubs.GroupCount();
				PaymentStubs = new NoPaymentStubs[count];
				for (int i = 0; i < count; i++)
				{
					PaymentStubs[i] = new();
					((IFixParser)PaymentStubs[i]).Parse(viewNoPaymentStubs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPaymentStubs":
				{
					value = PaymentStubs;
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
			PaymentStubs = null;
		}
	}
}
