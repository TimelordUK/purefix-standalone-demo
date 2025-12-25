using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStreamPricingDateGrp : IFixComponent
	{
		public sealed partial class NoPaymentStreamPricingDates : IFixGroup
		{
			[TagDetails(Tag = 41225, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? PaymentStreamPricingDate {get; set;}
			
			[TagDetails(Tag = 41226, Type = TagType.Int, Offset = 1, Required = false)]
			public int? PaymentStreamPricingDateType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PaymentStreamPricingDate is not null) writer.WriteLocalDateOnly(41225, PaymentStreamPricingDate.Value);
				if (PaymentStreamPricingDateType is not null) writer.WriteWholeNumber(41226, PaymentStreamPricingDateType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PaymentStreamPricingDate = view.GetDateOnly(41225);
				PaymentStreamPricingDateType = view.GetInt32(41226);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PaymentStreamPricingDate":
					{
						value = PaymentStreamPricingDate;
						break;
					}
					case "PaymentStreamPricingDateType":
					{
						value = PaymentStreamPricingDateType;
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
				PaymentStreamPricingDate = null;
				PaymentStreamPricingDateType = null;
			}
		}
		[Group(NoOfTag = 41224, Offset = 0, Required = false)]
		public NoPaymentStreamPricingDates[]? PaymentStreamPricingDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStreamPricingDates is not null && PaymentStreamPricingDates.Length != 0)
			{
				writer.WriteWholeNumber(41224, PaymentStreamPricingDates.Length);
				for (int i = 0; i < PaymentStreamPricingDates.Length; i++)
				{
					((IFixEncoder)PaymentStreamPricingDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPaymentStreamPricingDates") is IMessageView viewNoPaymentStreamPricingDates)
			{
				var count = viewNoPaymentStreamPricingDates.GroupCount();
				PaymentStreamPricingDates = new NoPaymentStreamPricingDates[count];
				for (int i = 0; i < count; i++)
				{
					PaymentStreamPricingDates[i] = new();
					((IFixParser)PaymentStreamPricingDates[i]).Parse(viewNoPaymentStreamPricingDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPaymentStreamPricingDates":
				{
					value = PaymentStreamPricingDates;
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
			PaymentStreamPricingDates = null;
		}
	}
}
