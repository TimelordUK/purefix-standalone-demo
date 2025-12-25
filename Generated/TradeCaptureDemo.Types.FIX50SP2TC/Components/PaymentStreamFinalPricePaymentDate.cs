using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStreamFinalPricePaymentDate : IFixComponent
	{
		[TagDetails(Tag = 42654, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? PaymentStreamFinalPricePaymentDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42655, Type = TagType.Int, Offset = 1, Required = false)]
		public int? PaymentStreamFinalPricePaymentDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42656, Type = TagType.Int, Offset = 2, Required = false)]
		public int? PaymentStreamFinalPricePaymentDateOffsetfPeriod {get; set;}
		
		[TagDetails(Tag = 42657, Type = TagType.String, Offset = 3, Required = false)]
		public string? PaymentStreamFinalPricePaymentDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42658, Type = TagType.Int, Offset = 4, Required = false)]
		public int? PaymentStreamFinalPricePaymentDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42659, Type = TagType.LocalDate, Offset = 5, Required = false)]
		public DateOnly? PaymentStreamFinalPricePaymentDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStreamFinalPricePaymentDateUnadjusted is not null) writer.WriteLocalDateOnly(42654, PaymentStreamFinalPricePaymentDateUnadjusted.Value);
			if (PaymentStreamFinalPricePaymentDateRelativeTo is not null) writer.WriteWholeNumber(42655, PaymentStreamFinalPricePaymentDateRelativeTo.Value);
			if (PaymentStreamFinalPricePaymentDateOffsetfPeriod is not null) writer.WriteWholeNumber(42656, PaymentStreamFinalPricePaymentDateOffsetfPeriod.Value);
			if (PaymentStreamFinalPricePaymentDateOffsetUnit is not null) writer.WriteString(42657, PaymentStreamFinalPricePaymentDateOffsetUnit);
			if (PaymentStreamFinalPricePaymentDateOffsetDayType is not null) writer.WriteWholeNumber(42658, PaymentStreamFinalPricePaymentDateOffsetDayType.Value);
			if (PaymentStreamFinalPricePaymentDateAdjusted is not null) writer.WriteLocalDateOnly(42659, PaymentStreamFinalPricePaymentDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			PaymentStreamFinalPricePaymentDateUnadjusted = view.GetDateOnly(42654);
			PaymentStreamFinalPricePaymentDateRelativeTo = view.GetInt32(42655);
			PaymentStreamFinalPricePaymentDateOffsetfPeriod = view.GetInt32(42656);
			PaymentStreamFinalPricePaymentDateOffsetUnit = view.GetString(42657);
			PaymentStreamFinalPricePaymentDateOffsetDayType = view.GetInt32(42658);
			PaymentStreamFinalPricePaymentDateAdjusted = view.GetDateOnly(42659);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "PaymentStreamFinalPricePaymentDateUnadjusted":
				{
					value = PaymentStreamFinalPricePaymentDateUnadjusted;
					break;
				}
				case "PaymentStreamFinalPricePaymentDateRelativeTo":
				{
					value = PaymentStreamFinalPricePaymentDateRelativeTo;
					break;
				}
				case "PaymentStreamFinalPricePaymentDateOffsetfPeriod":
				{
					value = PaymentStreamFinalPricePaymentDateOffsetfPeriod;
					break;
				}
				case "PaymentStreamFinalPricePaymentDateOffsetUnit":
				{
					value = PaymentStreamFinalPricePaymentDateOffsetUnit;
					break;
				}
				case "PaymentStreamFinalPricePaymentDateOffsetDayType":
				{
					value = PaymentStreamFinalPricePaymentDateOffsetDayType;
					break;
				}
				case "PaymentStreamFinalPricePaymentDateAdjusted":
				{
					value = PaymentStreamFinalPricePaymentDateAdjusted;
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
			PaymentStreamFinalPricePaymentDateUnadjusted = null;
			PaymentStreamFinalPricePaymentDateRelativeTo = null;
			PaymentStreamFinalPricePaymentDateOffsetfPeriod = null;
			PaymentStreamFinalPricePaymentDateOffsetUnit = null;
			PaymentStreamFinalPricePaymentDateOffsetDayType = null;
			PaymentStreamFinalPricePaymentDateAdjusted = null;
		}
	}
}
