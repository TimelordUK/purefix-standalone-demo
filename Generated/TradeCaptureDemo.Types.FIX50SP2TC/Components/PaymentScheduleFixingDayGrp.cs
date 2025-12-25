using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentScheduleFixingDayGrp : IFixComponent
	{
		public sealed partial class NoPaymentScheduleFixingDays : IFixGroup
		{
			[TagDetails(Tag = 41162, Type = TagType.Int, Offset = 0, Required = false)]
			public int? PaymentScheduleFixingDayOfWeek {get; set;}
			
			[TagDetails(Tag = 41163, Type = TagType.Int, Offset = 1, Required = false)]
			public int? PaymentScheduleFixingDayNumber {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PaymentScheduleFixingDayOfWeek is not null) writer.WriteWholeNumber(41162, PaymentScheduleFixingDayOfWeek.Value);
				if (PaymentScheduleFixingDayNumber is not null) writer.WriteWholeNumber(41163, PaymentScheduleFixingDayNumber.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PaymentScheduleFixingDayOfWeek = view.GetInt32(41162);
				PaymentScheduleFixingDayNumber = view.GetInt32(41163);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PaymentScheduleFixingDayOfWeek":
					{
						value = PaymentScheduleFixingDayOfWeek;
						break;
					}
					case "PaymentScheduleFixingDayNumber":
					{
						value = PaymentScheduleFixingDayNumber;
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
				PaymentScheduleFixingDayOfWeek = null;
				PaymentScheduleFixingDayNumber = null;
			}
		}
		[Group(NoOfTag = 41161, Offset = 0, Required = false)]
		public NoPaymentScheduleFixingDays[]? PaymentScheduleFixingDays {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentScheduleFixingDays is not null && PaymentScheduleFixingDays.Length != 0)
			{
				writer.WriteWholeNumber(41161, PaymentScheduleFixingDays.Length);
				for (int i = 0; i < PaymentScheduleFixingDays.Length; i++)
				{
					((IFixEncoder)PaymentScheduleFixingDays[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPaymentScheduleFixingDays") is IMessageView viewNoPaymentScheduleFixingDays)
			{
				var count = viewNoPaymentScheduleFixingDays.GroupCount();
				PaymentScheduleFixingDays = new NoPaymentScheduleFixingDays[count];
				for (int i = 0; i < count; i++)
				{
					PaymentScheduleFixingDays[i] = new();
					((IFixParser)PaymentScheduleFixingDays[i]).Parse(viewNoPaymentScheduleFixingDays.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPaymentScheduleFixingDays":
				{
					value = PaymentScheduleFixingDays;
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
			PaymentScheduleFixingDays = null;
		}
	}
}
