using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStreamFixedRate : IFixComponent
	{
		[TagDetails(Tag = 40784, Type = TagType.Float, Offset = 0, Required = false)]
		public double? PaymentStreamRate {get; set;}
		
		[TagDetails(Tag = 40785, Type = TagType.Float, Offset = 1, Required = false)]
		public double? PaymentStreamFixedAmount {get; set;}
		
		[TagDetails(Tag = 40786, Type = TagType.String, Offset = 2, Required = false)]
		public string? PaymentStreamRateOrAmountCurrency {get; set;}
		
		[TagDetails(Tag = 41187, Type = TagType.String, Offset = 3, Required = false)]
		public string? PaymentStreamFixedAmountUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 41188, Type = TagType.Float, Offset = 4, Required = false)]
		public double? PaymentStreamTotalFixedAmount {get; set;}
		
		[TagDetails(Tag = 40787, Type = TagType.Float, Offset = 5, Required = false)]
		public double? PaymentStreamFutureValueNotional {get; set;}
		
		[TagDetails(Tag = 40788, Type = TagType.LocalDate, Offset = 6, Required = false)]
		public DateOnly? PaymentStreamFutureValueDateAdjusted {get; set;}
		
		[TagDetails(Tag = 41189, Type = TagType.Float, Offset = 7, Required = false)]
		public double? PaymentStreamWorldScaleRate {get; set;}
		
		[TagDetails(Tag = 41190, Type = TagType.Float, Offset = 8, Required = false)]
		public double? PaymentStreamContractPrice {get; set;}
		
		[TagDetails(Tag = 41191, Type = TagType.String, Offset = 9, Required = false)]
		public string? PaymentStreamContractPriceCurrency {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStreamRate is not null) writer.WriteNumber(40784, PaymentStreamRate.Value);
			if (PaymentStreamFixedAmount is not null) writer.WriteNumber(40785, PaymentStreamFixedAmount.Value);
			if (PaymentStreamRateOrAmountCurrency is not null) writer.WriteString(40786, PaymentStreamRateOrAmountCurrency);
			if (PaymentStreamFixedAmountUnitOfMeasure is not null) writer.WriteString(41187, PaymentStreamFixedAmountUnitOfMeasure);
			if (PaymentStreamTotalFixedAmount is not null) writer.WriteNumber(41188, PaymentStreamTotalFixedAmount.Value);
			if (PaymentStreamFutureValueNotional is not null) writer.WriteNumber(40787, PaymentStreamFutureValueNotional.Value);
			if (PaymentStreamFutureValueDateAdjusted is not null) writer.WriteLocalDateOnly(40788, PaymentStreamFutureValueDateAdjusted.Value);
			if (PaymentStreamWorldScaleRate is not null) writer.WriteNumber(41189, PaymentStreamWorldScaleRate.Value);
			if (PaymentStreamContractPrice is not null) writer.WriteNumber(41190, PaymentStreamContractPrice.Value);
			if (PaymentStreamContractPriceCurrency is not null) writer.WriteString(41191, PaymentStreamContractPriceCurrency);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			PaymentStreamRate = view.GetDouble(40784);
			PaymentStreamFixedAmount = view.GetDouble(40785);
			PaymentStreamRateOrAmountCurrency = view.GetString(40786);
			PaymentStreamFixedAmountUnitOfMeasure = view.GetString(41187);
			PaymentStreamTotalFixedAmount = view.GetDouble(41188);
			PaymentStreamFutureValueNotional = view.GetDouble(40787);
			PaymentStreamFutureValueDateAdjusted = view.GetDateOnly(40788);
			PaymentStreamWorldScaleRate = view.GetDouble(41189);
			PaymentStreamContractPrice = view.GetDouble(41190);
			PaymentStreamContractPriceCurrency = view.GetString(41191);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "PaymentStreamRate":
				{
					value = PaymentStreamRate;
					break;
				}
				case "PaymentStreamFixedAmount":
				{
					value = PaymentStreamFixedAmount;
					break;
				}
				case "PaymentStreamRateOrAmountCurrency":
				{
					value = PaymentStreamRateOrAmountCurrency;
					break;
				}
				case "PaymentStreamFixedAmountUnitOfMeasure":
				{
					value = PaymentStreamFixedAmountUnitOfMeasure;
					break;
				}
				case "PaymentStreamTotalFixedAmount":
				{
					value = PaymentStreamTotalFixedAmount;
					break;
				}
				case "PaymentStreamFutureValueNotional":
				{
					value = PaymentStreamFutureValueNotional;
					break;
				}
				case "PaymentStreamFutureValueDateAdjusted":
				{
					value = PaymentStreamFutureValueDateAdjusted;
					break;
				}
				case "PaymentStreamWorldScaleRate":
				{
					value = PaymentStreamWorldScaleRate;
					break;
				}
				case "PaymentStreamContractPrice":
				{
					value = PaymentStreamContractPrice;
					break;
				}
				case "PaymentStreamContractPriceCurrency":
				{
					value = PaymentStreamContractPriceCurrency;
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
			PaymentStreamRate = null;
			PaymentStreamFixedAmount = null;
			PaymentStreamRateOrAmountCurrency = null;
			PaymentStreamFixedAmountUnitOfMeasure = null;
			PaymentStreamTotalFixedAmount = null;
			PaymentStreamFutureValueNotional = null;
			PaymentStreamFutureValueDateAdjusted = null;
			PaymentStreamWorldScaleRate = null;
			PaymentStreamContractPrice = null;
			PaymentStreamContractPriceCurrency = null;
		}
	}
}
