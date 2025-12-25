using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStreamPricingBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoPaymentStreamPricingBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 41193, Type = TagType.String, Offset = 0, Required = false)]
			public string? PaymentStreamPricingBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PaymentStreamPricingBusinessCenter is not null) writer.WriteString(41193, PaymentStreamPricingBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PaymentStreamPricingBusinessCenter = view.GetString(41193);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PaymentStreamPricingBusinessCenter":
					{
						value = PaymentStreamPricingBusinessCenter;
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
				PaymentStreamPricingBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 41192, Offset = 0, Required = false)]
		public NoPaymentStreamPricingBusinessCenters[]? PaymentStreamPricingBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStreamPricingBusinessCenters is not null && PaymentStreamPricingBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(41192, PaymentStreamPricingBusinessCenters.Length);
				for (int i = 0; i < PaymentStreamPricingBusinessCenters.Length; i++)
				{
					((IFixEncoder)PaymentStreamPricingBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPaymentStreamPricingBusinessCenters") is IMessageView viewNoPaymentStreamPricingBusinessCenters)
			{
				var count = viewNoPaymentStreamPricingBusinessCenters.GroupCount();
				PaymentStreamPricingBusinessCenters = new NoPaymentStreamPricingBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					PaymentStreamPricingBusinessCenters[i] = new();
					((IFixParser)PaymentStreamPricingBusinessCenters[i]).Parse(viewNoPaymentStreamPricingBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPaymentStreamPricingBusinessCenters":
				{
					value = PaymentStreamPricingBusinessCenters;
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
			PaymentStreamPricingBusinessCenters = null;
		}
	}
}
