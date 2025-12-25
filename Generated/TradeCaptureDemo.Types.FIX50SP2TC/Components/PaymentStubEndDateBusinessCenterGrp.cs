using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStubEndDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoPaymentStubEndDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42697, Type = TagType.String, Offset = 0, Required = false)]
			public string? PaymentStubEndDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PaymentStubEndDateBusinessCenter is not null) writer.WriteString(42697, PaymentStubEndDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PaymentStubEndDateBusinessCenter = view.GetString(42697);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PaymentStubEndDateBusinessCenter":
					{
						value = PaymentStubEndDateBusinessCenter;
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
				PaymentStubEndDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42696, Offset = 0, Required = false)]
		public NoPaymentStubEndDateBusinessCenters[]? PaymentStubEndDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStubEndDateBusinessCenters is not null && PaymentStubEndDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42696, PaymentStubEndDateBusinessCenters.Length);
				for (int i = 0; i < PaymentStubEndDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)PaymentStubEndDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPaymentStubEndDateBusinessCenters") is IMessageView viewNoPaymentStubEndDateBusinessCenters)
			{
				var count = viewNoPaymentStubEndDateBusinessCenters.GroupCount();
				PaymentStubEndDateBusinessCenters = new NoPaymentStubEndDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					PaymentStubEndDateBusinessCenters[i] = new();
					((IFixParser)PaymentStubEndDateBusinessCenters[i]).Parse(viewNoPaymentStubEndDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPaymentStubEndDateBusinessCenters":
				{
					value = PaymentStubEndDateBusinessCenters;
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
			PaymentStubEndDateBusinessCenters = null;
		}
	}
}
