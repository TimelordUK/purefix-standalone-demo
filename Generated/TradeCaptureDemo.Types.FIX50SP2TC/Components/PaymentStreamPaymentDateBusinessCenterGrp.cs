using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStreamPaymentDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoPaymentStreamPaymentDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40752, Type = TagType.String, Offset = 0, Required = false)]
			public string? PaymentStreamPaymentDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PaymentStreamPaymentDateBusinessCenter is not null) writer.WriteString(40752, PaymentStreamPaymentDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PaymentStreamPaymentDateBusinessCenter = view.GetString(40752);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PaymentStreamPaymentDateBusinessCenter":
					{
						value = PaymentStreamPaymentDateBusinessCenter;
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
				PaymentStreamPaymentDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40947, Offset = 0, Required = false)]
		public NoPaymentStreamPaymentDateBusinessCenters[]? PaymentStreamPaymentDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStreamPaymentDateBusinessCenters is not null && PaymentStreamPaymentDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40947, PaymentStreamPaymentDateBusinessCenters.Length);
				for (int i = 0; i < PaymentStreamPaymentDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)PaymentStreamPaymentDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPaymentStreamPaymentDateBusinessCenters") is IMessageView viewNoPaymentStreamPaymentDateBusinessCenters)
			{
				var count = viewNoPaymentStreamPaymentDateBusinessCenters.GroupCount();
				PaymentStreamPaymentDateBusinessCenters = new NoPaymentStreamPaymentDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					PaymentStreamPaymentDateBusinessCenters[i] = new();
					((IFixParser)PaymentStreamPaymentDateBusinessCenters[i]).Parse(viewNoPaymentStreamPaymentDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPaymentStreamPaymentDateBusinessCenters":
				{
					value = PaymentStreamPaymentDateBusinessCenters;
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
			PaymentStreamPaymentDateBusinessCenters = null;
		}
	}
}
