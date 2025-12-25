using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStreamPricingDayGrp : IFixComponent
	{
		public sealed partial class NoPaymentStreamPricingDays : IFixGroup
		{
			[TagDetails(Tag = 41228, Type = TagType.Int, Offset = 0, Required = false)]
			public int? PaymentStreamPricingDayOfWeek {get; set;}
			
			[TagDetails(Tag = 41229, Type = TagType.Int, Offset = 1, Required = false)]
			public int? PaymentStreamPricingDayNumber {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PaymentStreamPricingDayOfWeek is not null) writer.WriteWholeNumber(41228, PaymentStreamPricingDayOfWeek.Value);
				if (PaymentStreamPricingDayNumber is not null) writer.WriteWholeNumber(41229, PaymentStreamPricingDayNumber.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PaymentStreamPricingDayOfWeek = view.GetInt32(41228);
				PaymentStreamPricingDayNumber = view.GetInt32(41229);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PaymentStreamPricingDayOfWeek":
					{
						value = PaymentStreamPricingDayOfWeek;
						break;
					}
					case "PaymentStreamPricingDayNumber":
					{
						value = PaymentStreamPricingDayNumber;
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
				PaymentStreamPricingDayOfWeek = null;
				PaymentStreamPricingDayNumber = null;
			}
		}
		[Group(NoOfTag = 41227, Offset = 0, Required = false)]
		public NoPaymentStreamPricingDays[]? PaymentStreamPricingDays {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStreamPricingDays is not null && PaymentStreamPricingDays.Length != 0)
			{
				writer.WriteWholeNumber(41227, PaymentStreamPricingDays.Length);
				for (int i = 0; i < PaymentStreamPricingDays.Length; i++)
				{
					((IFixEncoder)PaymentStreamPricingDays[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPaymentStreamPricingDays") is IMessageView viewNoPaymentStreamPricingDays)
			{
				var count = viewNoPaymentStreamPricingDays.GroupCount();
				PaymentStreamPricingDays = new NoPaymentStreamPricingDays[count];
				for (int i = 0; i < count; i++)
				{
					PaymentStreamPricingDays[i] = new();
					((IFixParser)PaymentStreamPricingDays[i]).Parse(viewNoPaymentStreamPricingDays.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPaymentStreamPricingDays":
				{
					value = PaymentStreamPricingDays;
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
			PaymentStreamPricingDays = null;
		}
	}
}
