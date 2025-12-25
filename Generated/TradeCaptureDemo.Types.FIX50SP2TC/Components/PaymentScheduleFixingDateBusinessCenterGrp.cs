using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentScheduleFixingDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoPaymentScheduleFixingDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40854, Type = TagType.String, Offset = 0, Required = false)]
			public string? PaymentScheduleFixingDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PaymentScheduleFixingDateBusinessCenter is not null) writer.WriteString(40854, PaymentScheduleFixingDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PaymentScheduleFixingDateBusinessCenter = view.GetString(40854);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PaymentScheduleFixingDateBusinessCenter":
					{
						value = PaymentScheduleFixingDateBusinessCenter;
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
				PaymentScheduleFixingDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40977, Offset = 0, Required = false)]
		public NoPaymentScheduleFixingDateBusinessCenters[]? PaymentScheduleFixingDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentScheduleFixingDateBusinessCenters is not null && PaymentScheduleFixingDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40977, PaymentScheduleFixingDateBusinessCenters.Length);
				for (int i = 0; i < PaymentScheduleFixingDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)PaymentScheduleFixingDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPaymentScheduleFixingDateBusinessCenters") is IMessageView viewNoPaymentScheduleFixingDateBusinessCenters)
			{
				var count = viewNoPaymentScheduleFixingDateBusinessCenters.GroupCount();
				PaymentScheduleFixingDateBusinessCenters = new NoPaymentScheduleFixingDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					PaymentScheduleFixingDateBusinessCenters[i] = new();
					((IFixParser)PaymentScheduleFixingDateBusinessCenters[i]).Parse(viewNoPaymentScheduleFixingDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPaymentScheduleFixingDateBusinessCenters":
				{
					value = PaymentScheduleFixingDateBusinessCenters;
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
			PaymentScheduleFixingDateBusinessCenters = null;
		}
	}
}
