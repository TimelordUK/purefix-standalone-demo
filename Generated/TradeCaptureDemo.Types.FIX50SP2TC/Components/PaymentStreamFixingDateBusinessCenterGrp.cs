using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStreamFixingDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoPaymentStreamFixingDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40776, Type = TagType.String, Offset = 0, Required = false)]
			public string? PaymentStreamFixingDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PaymentStreamFixingDateBusinessCenter is not null) writer.WriteString(40776, PaymentStreamFixingDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PaymentStreamFixingDateBusinessCenter = view.GetString(40776);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PaymentStreamFixingDateBusinessCenter":
					{
						value = PaymentStreamFixingDateBusinessCenter;
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
				PaymentStreamFixingDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40950, Offset = 0, Required = false)]
		public NoPaymentStreamFixingDateBusinessCenters[]? PaymentStreamFixingDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStreamFixingDateBusinessCenters is not null && PaymentStreamFixingDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40950, PaymentStreamFixingDateBusinessCenters.Length);
				for (int i = 0; i < PaymentStreamFixingDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)PaymentStreamFixingDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPaymentStreamFixingDateBusinessCenters") is IMessageView viewNoPaymentStreamFixingDateBusinessCenters)
			{
				var count = viewNoPaymentStreamFixingDateBusinessCenters.GroupCount();
				PaymentStreamFixingDateBusinessCenters = new NoPaymentStreamFixingDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					PaymentStreamFixingDateBusinessCenters[i] = new();
					((IFixParser)PaymentStreamFixingDateBusinessCenters[i]).Parse(viewNoPaymentStreamFixingDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPaymentStreamFixingDateBusinessCenters":
				{
					value = PaymentStreamFixingDateBusinessCenters;
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
			PaymentStreamFixingDateBusinessCenters = null;
		}
	}
}
