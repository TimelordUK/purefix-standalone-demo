using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStubStartDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoPaymentStubStartDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42706, Type = TagType.String, Offset = 0, Required = false)]
			public string? PaymentStubStartDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PaymentStubStartDateBusinessCenter is not null) writer.WriteString(42706, PaymentStubStartDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PaymentStubStartDateBusinessCenter = view.GetString(42706);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PaymentStubStartDateBusinessCenter":
					{
						value = PaymentStubStartDateBusinessCenter;
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
				PaymentStubStartDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42705, Offset = 0, Required = false)]
		public NoPaymentStubStartDateBusinessCenters[]? PaymentStubStartDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStubStartDateBusinessCenters is not null && PaymentStubStartDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42705, PaymentStubStartDateBusinessCenters.Length);
				for (int i = 0; i < PaymentStubStartDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)PaymentStubStartDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPaymentStubStartDateBusinessCenters") is IMessageView viewNoPaymentStubStartDateBusinessCenters)
			{
				var count = viewNoPaymentStubStartDateBusinessCenters.GroupCount();
				PaymentStubStartDateBusinessCenters = new NoPaymentStubStartDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					PaymentStubStartDateBusinessCenters[i] = new();
					((IFixParser)PaymentStubStartDateBusinessCenters[i]).Parse(viewNoPaymentStubStartDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPaymentStubStartDateBusinessCenters":
				{
					value = PaymentStubStartDateBusinessCenters;
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
			PaymentStubStartDateBusinessCenters = null;
		}
	}
}
