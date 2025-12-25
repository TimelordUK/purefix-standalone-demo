using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStreamResetDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoPaymentStreamResetDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40763, Type = TagType.String, Offset = 0, Required = false)]
			public string? PaymentStreamResetDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PaymentStreamResetDateBusinessCenter is not null) writer.WriteString(40763, PaymentStreamResetDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PaymentStreamResetDateBusinessCenter = view.GetString(40763);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PaymentStreamResetDateBusinessCenter":
					{
						value = PaymentStreamResetDateBusinessCenter;
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
				PaymentStreamResetDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40948, Offset = 0, Required = false)]
		public NoPaymentStreamResetDateBusinessCenters[]? PaymentStreamResetDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStreamResetDateBusinessCenters is not null && PaymentStreamResetDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40948, PaymentStreamResetDateBusinessCenters.Length);
				for (int i = 0; i < PaymentStreamResetDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)PaymentStreamResetDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPaymentStreamResetDateBusinessCenters") is IMessageView viewNoPaymentStreamResetDateBusinessCenters)
			{
				var count = viewNoPaymentStreamResetDateBusinessCenters.GroupCount();
				PaymentStreamResetDateBusinessCenters = new NoPaymentStreamResetDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					PaymentStreamResetDateBusinessCenters[i] = new();
					((IFixParser)PaymentStreamResetDateBusinessCenters[i]).Parse(viewNoPaymentStreamResetDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPaymentStreamResetDateBusinessCenters":
				{
					value = PaymentStreamResetDateBusinessCenters;
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
			PaymentStreamResetDateBusinessCenters = null;
		}
	}
}
