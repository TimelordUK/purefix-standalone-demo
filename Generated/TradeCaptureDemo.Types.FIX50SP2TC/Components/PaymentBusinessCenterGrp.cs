using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoPaymentBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40221, Type = TagType.String, Offset = 0, Required = false)]
			public string? PaymentBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PaymentBusinessCenter is not null) writer.WriteString(40221, PaymentBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PaymentBusinessCenter = view.GetString(40221);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PaymentBusinessCenter":
					{
						value = PaymentBusinessCenter;
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
				PaymentBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40944, Offset = 0, Required = false)]
		public NoPaymentBusinessCenters[]? PaymentBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentBusinessCenters is not null && PaymentBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40944, PaymentBusinessCenters.Length);
				for (int i = 0; i < PaymentBusinessCenters.Length; i++)
				{
					((IFixEncoder)PaymentBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPaymentBusinessCenters") is IMessageView viewNoPaymentBusinessCenters)
			{
				var count = viewNoPaymentBusinessCenters.GroupCount();
				PaymentBusinessCenters = new NoPaymentBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					PaymentBusinessCenters[i] = new();
					((IFixParser)PaymentBusinessCenters[i]).Parse(viewNoPaymentBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPaymentBusinessCenters":
				{
					value = PaymentBusinessCenters;
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
			PaymentBusinessCenters = null;
		}
	}
}
