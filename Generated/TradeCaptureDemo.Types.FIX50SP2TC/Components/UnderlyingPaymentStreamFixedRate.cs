using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStreamFixedRate : IFixComponent
	{
		[TagDetails(Tag = 40615, Type = TagType.Float, Offset = 0, Required = false)]
		public double? UnderlyingPaymentStreamRate {get; set;}
		
		[TagDetails(Tag = 40616, Type = TagType.Float, Offset = 1, Required = false)]
		public double? UnderlyingPaymentStreamFixedAmount {get; set;}
		
		[TagDetails(Tag = 40617, Type = TagType.String, Offset = 2, Required = false)]
		public string? UnderlyingPaymentStreamRateOrAmountCurrency {get; set;}
		
		[TagDetails(Tag = 41904, Type = TagType.String, Offset = 3, Required = false)]
		public string? UnderlyingPaymentStreamFixedAmountUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 41905, Type = TagType.Float, Offset = 4, Required = false)]
		public double? UnderlyingPaymentStreamTotalFixedAmount {get; set;}
		
		[TagDetails(Tag = 40618, Type = TagType.Float, Offset = 5, Required = false)]
		public double? UnderlyingPaymentStreamFutureValueNotional {get; set;}
		
		[TagDetails(Tag = 40619, Type = TagType.LocalDate, Offset = 6, Required = false)]
		public DateOnly? UnderlyingPaymentStreamFutureValueDateAdjusted {get; set;}
		
		[TagDetails(Tag = 41906, Type = TagType.Float, Offset = 7, Required = false)]
		public double? UnderlyingPaymentStreamWorldScaleRate {get; set;}
		
		[TagDetails(Tag = 41907, Type = TagType.Float, Offset = 8, Required = false)]
		public double? UnderlyingPaymentStreamContractPrice {get; set;}
		
		[TagDetails(Tag = 41908, Type = TagType.String, Offset = 9, Required = false)]
		public string? UnderlyingPaymentStreamContractPriceCurrency {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStreamRate is not null) writer.WriteNumber(40615, UnderlyingPaymentStreamRate.Value);
			if (UnderlyingPaymentStreamFixedAmount is not null) writer.WriteNumber(40616, UnderlyingPaymentStreamFixedAmount.Value);
			if (UnderlyingPaymentStreamRateOrAmountCurrency is not null) writer.WriteString(40617, UnderlyingPaymentStreamRateOrAmountCurrency);
			if (UnderlyingPaymentStreamFixedAmountUnitOfMeasure is not null) writer.WriteString(41904, UnderlyingPaymentStreamFixedAmountUnitOfMeasure);
			if (UnderlyingPaymentStreamTotalFixedAmount is not null) writer.WriteNumber(41905, UnderlyingPaymentStreamTotalFixedAmount.Value);
			if (UnderlyingPaymentStreamFutureValueNotional is not null) writer.WriteNumber(40618, UnderlyingPaymentStreamFutureValueNotional.Value);
			if (UnderlyingPaymentStreamFutureValueDateAdjusted is not null) writer.WriteLocalDateOnly(40619, UnderlyingPaymentStreamFutureValueDateAdjusted.Value);
			if (UnderlyingPaymentStreamWorldScaleRate is not null) writer.WriteNumber(41906, UnderlyingPaymentStreamWorldScaleRate.Value);
			if (UnderlyingPaymentStreamContractPrice is not null) writer.WriteNumber(41907, UnderlyingPaymentStreamContractPrice.Value);
			if (UnderlyingPaymentStreamContractPriceCurrency is not null) writer.WriteString(41908, UnderlyingPaymentStreamContractPriceCurrency);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingPaymentStreamRate = view.GetDouble(40615);
			UnderlyingPaymentStreamFixedAmount = view.GetDouble(40616);
			UnderlyingPaymentStreamRateOrAmountCurrency = view.GetString(40617);
			UnderlyingPaymentStreamFixedAmountUnitOfMeasure = view.GetString(41904);
			UnderlyingPaymentStreamTotalFixedAmount = view.GetDouble(41905);
			UnderlyingPaymentStreamFutureValueNotional = view.GetDouble(40618);
			UnderlyingPaymentStreamFutureValueDateAdjusted = view.GetDateOnly(40619);
			UnderlyingPaymentStreamWorldScaleRate = view.GetDouble(41906);
			UnderlyingPaymentStreamContractPrice = view.GetDouble(41907);
			UnderlyingPaymentStreamContractPriceCurrency = view.GetString(41908);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingPaymentStreamRate":
				{
					value = UnderlyingPaymentStreamRate;
					break;
				}
				case "UnderlyingPaymentStreamFixedAmount":
				{
					value = UnderlyingPaymentStreamFixedAmount;
					break;
				}
				case "UnderlyingPaymentStreamRateOrAmountCurrency":
				{
					value = UnderlyingPaymentStreamRateOrAmountCurrency;
					break;
				}
				case "UnderlyingPaymentStreamFixedAmountUnitOfMeasure":
				{
					value = UnderlyingPaymentStreamFixedAmountUnitOfMeasure;
					break;
				}
				case "UnderlyingPaymentStreamTotalFixedAmount":
				{
					value = UnderlyingPaymentStreamTotalFixedAmount;
					break;
				}
				case "UnderlyingPaymentStreamFutureValueNotional":
				{
					value = UnderlyingPaymentStreamFutureValueNotional;
					break;
				}
				case "UnderlyingPaymentStreamFutureValueDateAdjusted":
				{
					value = UnderlyingPaymentStreamFutureValueDateAdjusted;
					break;
				}
				case "UnderlyingPaymentStreamWorldScaleRate":
				{
					value = UnderlyingPaymentStreamWorldScaleRate;
					break;
				}
				case "UnderlyingPaymentStreamContractPrice":
				{
					value = UnderlyingPaymentStreamContractPrice;
					break;
				}
				case "UnderlyingPaymentStreamContractPriceCurrency":
				{
					value = UnderlyingPaymentStreamContractPriceCurrency;
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
			UnderlyingPaymentStreamRate = null;
			UnderlyingPaymentStreamFixedAmount = null;
			UnderlyingPaymentStreamRateOrAmountCurrency = null;
			UnderlyingPaymentStreamFixedAmountUnitOfMeasure = null;
			UnderlyingPaymentStreamTotalFixedAmount = null;
			UnderlyingPaymentStreamFutureValueNotional = null;
			UnderlyingPaymentStreamFutureValueDateAdjusted = null;
			UnderlyingPaymentStreamWorldScaleRate = null;
			UnderlyingPaymentStreamContractPrice = null;
			UnderlyingPaymentStreamContractPriceCurrency = null;
		}
	}
}
