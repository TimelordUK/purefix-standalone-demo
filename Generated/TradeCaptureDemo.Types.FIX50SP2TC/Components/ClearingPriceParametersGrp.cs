using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ClearingPriceParametersGrp : IFixComponent
	{
		public sealed partial class NoClearingPriceParameters : IFixGroup
		{
			[TagDetails(Tag = 2581, Type = TagType.Int, Offset = 0, Required = false)]
			public int? BusinessDayType {get; set;}
			
			[TagDetails(Tag = 2582, Type = TagType.Float, Offset = 1, Required = false)]
			public double? ClearingPriceOffset {get; set;}
			
			[TagDetails(Tag = 2583, Type = TagType.Float, Offset = 2, Required = false)]
			public double? VegaMultiplier {get; set;}
			
			[TagDetails(Tag = 2584, Type = TagType.Int, Offset = 3, Required = false)]
			public int? AnnualTradingBusinessDays {get; set;}
			
			[TagDetails(Tag = 2585, Type = TagType.Int, Offset = 4, Required = false)]
			public int? TotalTradingBusinessDays {get; set;}
			
			[TagDetails(Tag = 2586, Type = TagType.Int, Offset = 5, Required = false)]
			public int? TradingBusinessDays {get; set;}
			
			[TagDetails(Tag = 2588, Type = TagType.Float, Offset = 6, Required = false)]
			public double? StandardVariance {get; set;}
			
			[TagDetails(Tag = 2587, Type = TagType.Float, Offset = 7, Required = false)]
			public double? RealizedVariance {get; set;}
			
			[TagDetails(Tag = 2589, Type = TagType.Float, Offset = 8, Required = false)]
			public double? RelatedClosePrice {get; set;}
			
			[TagDetails(Tag = 1190, Type = TagType.Float, Offset = 9, Required = false)]
			public double? RiskFreeRate {get; set;}
			
			[TagDetails(Tag = 2590, Type = TagType.Float, Offset = 10, Required = false)]
			public double? OvernightInterestRate {get; set;}
			
			[TagDetails(Tag = 2591, Type = TagType.Float, Offset = 11, Required = false)]
			public double? AccumulatedReturnModifiedVariationMargin {get; set;}
			
			[TagDetails(Tag = 1592, Type = TagType.Float, Offset = 12, Required = false)]
			public double? DiscountFactor {get; set;}
			
			[TagDetails(Tag = 1188, Type = TagType.Float, Offset = 13, Required = false)]
			public double? Volatility {get; set;}
			
			[TagDetails(Tag = 2528, Type = TagType.Float, Offset = 14, Required = false)]
			public double? ClearingSettlPrice {get; set;}
			
			[TagDetails(Tag = 2592, Type = TagType.Int, Offset = 15, Required = false)]
			public int? CalculationMethod {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (BusinessDayType is not null) writer.WriteWholeNumber(2581, BusinessDayType.Value);
				if (ClearingPriceOffset is not null) writer.WriteNumber(2582, ClearingPriceOffset.Value);
				if (VegaMultiplier is not null) writer.WriteNumber(2583, VegaMultiplier.Value);
				if (AnnualTradingBusinessDays is not null) writer.WriteWholeNumber(2584, AnnualTradingBusinessDays.Value);
				if (TotalTradingBusinessDays is not null) writer.WriteWholeNumber(2585, TotalTradingBusinessDays.Value);
				if (TradingBusinessDays is not null) writer.WriteWholeNumber(2586, TradingBusinessDays.Value);
				if (StandardVariance is not null) writer.WriteNumber(2588, StandardVariance.Value);
				if (RealizedVariance is not null) writer.WriteNumber(2587, RealizedVariance.Value);
				if (RelatedClosePrice is not null) writer.WriteNumber(2589, RelatedClosePrice.Value);
				if (RiskFreeRate is not null) writer.WriteNumber(1190, RiskFreeRate.Value);
				if (OvernightInterestRate is not null) writer.WriteNumber(2590, OvernightInterestRate.Value);
				if (AccumulatedReturnModifiedVariationMargin is not null) writer.WriteNumber(2591, AccumulatedReturnModifiedVariationMargin.Value);
				if (DiscountFactor is not null) writer.WriteNumber(1592, DiscountFactor.Value);
				if (Volatility is not null) writer.WriteNumber(1188, Volatility.Value);
				if (ClearingSettlPrice is not null) writer.WriteNumber(2528, ClearingSettlPrice.Value);
				if (CalculationMethod is not null) writer.WriteWholeNumber(2592, CalculationMethod.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				BusinessDayType = view.GetInt32(2581);
				ClearingPriceOffset = view.GetDouble(2582);
				VegaMultiplier = view.GetDouble(2583);
				AnnualTradingBusinessDays = view.GetInt32(2584);
				TotalTradingBusinessDays = view.GetInt32(2585);
				TradingBusinessDays = view.GetInt32(2586);
				StandardVariance = view.GetDouble(2588);
				RealizedVariance = view.GetDouble(2587);
				RelatedClosePrice = view.GetDouble(2589);
				RiskFreeRate = view.GetDouble(1190);
				OvernightInterestRate = view.GetDouble(2590);
				AccumulatedReturnModifiedVariationMargin = view.GetDouble(2591);
				DiscountFactor = view.GetDouble(1592);
				Volatility = view.GetDouble(1188);
				ClearingSettlPrice = view.GetDouble(2528);
				CalculationMethod = view.GetInt32(2592);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "BusinessDayType":
					{
						value = BusinessDayType;
						break;
					}
					case "ClearingPriceOffset":
					{
						value = ClearingPriceOffset;
						break;
					}
					case "VegaMultiplier":
					{
						value = VegaMultiplier;
						break;
					}
					case "AnnualTradingBusinessDays":
					{
						value = AnnualTradingBusinessDays;
						break;
					}
					case "TotalTradingBusinessDays":
					{
						value = TotalTradingBusinessDays;
						break;
					}
					case "TradingBusinessDays":
					{
						value = TradingBusinessDays;
						break;
					}
					case "StandardVariance":
					{
						value = StandardVariance;
						break;
					}
					case "RealizedVariance":
					{
						value = RealizedVariance;
						break;
					}
					case "RelatedClosePrice":
					{
						value = RelatedClosePrice;
						break;
					}
					case "RiskFreeRate":
					{
						value = RiskFreeRate;
						break;
					}
					case "OvernightInterestRate":
					{
						value = OvernightInterestRate;
						break;
					}
					case "AccumulatedReturnModifiedVariationMargin":
					{
						value = AccumulatedReturnModifiedVariationMargin;
						break;
					}
					case "DiscountFactor":
					{
						value = DiscountFactor;
						break;
					}
					case "Volatility":
					{
						value = Volatility;
						break;
					}
					case "ClearingSettlPrice":
					{
						value = ClearingSettlPrice;
						break;
					}
					case "CalculationMethod":
					{
						value = CalculationMethod;
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
				BusinessDayType = null;
				ClearingPriceOffset = null;
				VegaMultiplier = null;
				AnnualTradingBusinessDays = null;
				TotalTradingBusinessDays = null;
				TradingBusinessDays = null;
				StandardVariance = null;
				RealizedVariance = null;
				RelatedClosePrice = null;
				RiskFreeRate = null;
				OvernightInterestRate = null;
				AccumulatedReturnModifiedVariationMargin = null;
				DiscountFactor = null;
				Volatility = null;
				ClearingSettlPrice = null;
				CalculationMethod = null;
			}
		}
		[Group(NoOfTag = 2580, Offset = 0, Required = false)]
		public NoClearingPriceParameters[]? ClearingPriceParameters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ClearingPriceParameters is not null && ClearingPriceParameters.Length != 0)
			{
				writer.WriteWholeNumber(2580, ClearingPriceParameters.Length);
				for (int i = 0; i < ClearingPriceParameters.Length; i++)
				{
					((IFixEncoder)ClearingPriceParameters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoClearingPriceParameters") is IMessageView viewNoClearingPriceParameters)
			{
				var count = viewNoClearingPriceParameters.GroupCount();
				ClearingPriceParameters = new NoClearingPriceParameters[count];
				for (int i = 0; i < count; i++)
				{
					ClearingPriceParameters[i] = new();
					((IFixParser)ClearingPriceParameters[i]).Parse(viewNoClearingPriceParameters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoClearingPriceParameters":
				{
					value = ClearingPriceParameters;
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
			ClearingPriceParameters = null;
		}
	}
}
