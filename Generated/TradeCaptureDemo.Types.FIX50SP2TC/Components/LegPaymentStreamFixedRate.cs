using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStreamFixedRate : IFixComponent
	{
		[TagDetails(Tag = 40326, Type = TagType.Float, Offset = 0, Required = false)]
		public double? LegPaymentStreamRate {get; set;}
		
		[TagDetails(Tag = 40327, Type = TagType.Float, Offset = 1, Required = false)]
		public double? LegPaymentStreamFixedAmount {get; set;}
		
		[TagDetails(Tag = 40328, Type = TagType.String, Offset = 2, Required = false)]
		public string? LegPaymentStreamRateOrAmountCurrency {get; set;}
		
		[TagDetails(Tag = 41556, Type = TagType.String, Offset = 3, Required = false)]
		public string? LegPaymentStreamFixedAmountUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 41557, Type = TagType.Float, Offset = 4, Required = false)]
		public double? LegPaymentStreamTotalFixedAmount {get; set;}
		
		[TagDetails(Tag = 40329, Type = TagType.Float, Offset = 5, Required = false)]
		public double? LegPaymentStreamFutureValueNotional {get; set;}
		
		[TagDetails(Tag = 40330, Type = TagType.LocalDate, Offset = 6, Required = false)]
		public DateOnly? LegPaymentStreamFutureValueDateAdjusted {get; set;}
		
		[TagDetails(Tag = 41558, Type = TagType.Float, Offset = 7, Required = false)]
		public double? LegPaymentStreamWorldScaleRate {get; set;}
		
		[TagDetails(Tag = 41559, Type = TagType.Float, Offset = 8, Required = false)]
		public double? LegPaymentStreamContractPrice {get; set;}
		
		[TagDetails(Tag = 41560, Type = TagType.String, Offset = 9, Required = false)]
		public string? LegPaymentStreamContractPriceCurrency {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStreamRate is not null) writer.WriteNumber(40326, LegPaymentStreamRate.Value);
			if (LegPaymentStreamFixedAmount is not null) writer.WriteNumber(40327, LegPaymentStreamFixedAmount.Value);
			if (LegPaymentStreamRateOrAmountCurrency is not null) writer.WriteString(40328, LegPaymentStreamRateOrAmountCurrency);
			if (LegPaymentStreamFixedAmountUnitOfMeasure is not null) writer.WriteString(41556, LegPaymentStreamFixedAmountUnitOfMeasure);
			if (LegPaymentStreamTotalFixedAmount is not null) writer.WriteNumber(41557, LegPaymentStreamTotalFixedAmount.Value);
			if (LegPaymentStreamFutureValueNotional is not null) writer.WriteNumber(40329, LegPaymentStreamFutureValueNotional.Value);
			if (LegPaymentStreamFutureValueDateAdjusted is not null) writer.WriteLocalDateOnly(40330, LegPaymentStreamFutureValueDateAdjusted.Value);
			if (LegPaymentStreamWorldScaleRate is not null) writer.WriteNumber(41558, LegPaymentStreamWorldScaleRate.Value);
			if (LegPaymentStreamContractPrice is not null) writer.WriteNumber(41559, LegPaymentStreamContractPrice.Value);
			if (LegPaymentStreamContractPriceCurrency is not null) writer.WriteString(41560, LegPaymentStreamContractPriceCurrency);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegPaymentStreamRate = view.GetDouble(40326);
			LegPaymentStreamFixedAmount = view.GetDouble(40327);
			LegPaymentStreamRateOrAmountCurrency = view.GetString(40328);
			LegPaymentStreamFixedAmountUnitOfMeasure = view.GetString(41556);
			LegPaymentStreamTotalFixedAmount = view.GetDouble(41557);
			LegPaymentStreamFutureValueNotional = view.GetDouble(40329);
			LegPaymentStreamFutureValueDateAdjusted = view.GetDateOnly(40330);
			LegPaymentStreamWorldScaleRate = view.GetDouble(41558);
			LegPaymentStreamContractPrice = view.GetDouble(41559);
			LegPaymentStreamContractPriceCurrency = view.GetString(41560);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegPaymentStreamRate":
				{
					value = LegPaymentStreamRate;
					break;
				}
				case "LegPaymentStreamFixedAmount":
				{
					value = LegPaymentStreamFixedAmount;
					break;
				}
				case "LegPaymentStreamRateOrAmountCurrency":
				{
					value = LegPaymentStreamRateOrAmountCurrency;
					break;
				}
				case "LegPaymentStreamFixedAmountUnitOfMeasure":
				{
					value = LegPaymentStreamFixedAmountUnitOfMeasure;
					break;
				}
				case "LegPaymentStreamTotalFixedAmount":
				{
					value = LegPaymentStreamTotalFixedAmount;
					break;
				}
				case "LegPaymentStreamFutureValueNotional":
				{
					value = LegPaymentStreamFutureValueNotional;
					break;
				}
				case "LegPaymentStreamFutureValueDateAdjusted":
				{
					value = LegPaymentStreamFutureValueDateAdjusted;
					break;
				}
				case "LegPaymentStreamWorldScaleRate":
				{
					value = LegPaymentStreamWorldScaleRate;
					break;
				}
				case "LegPaymentStreamContractPrice":
				{
					value = LegPaymentStreamContractPrice;
					break;
				}
				case "LegPaymentStreamContractPriceCurrency":
				{
					value = LegPaymentStreamContractPriceCurrency;
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
			LegPaymentStreamRate = null;
			LegPaymentStreamFixedAmount = null;
			LegPaymentStreamRateOrAmountCurrency = null;
			LegPaymentStreamFixedAmountUnitOfMeasure = null;
			LegPaymentStreamTotalFixedAmount = null;
			LegPaymentStreamFutureValueNotional = null;
			LegPaymentStreamFutureValueDateAdjusted = null;
			LegPaymentStreamWorldScaleRate = null;
			LegPaymentStreamContractPrice = null;
			LegPaymentStreamContractPriceCurrency = null;
		}
	}
}
