using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStreamFixingDateGrp : IFixComponent
	{
		public sealed partial class NoPaymentStreamFixingDates : IFixGroup
		{
			[TagDetails(Tag = 42661, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? PaymentStreamFixingDate {get; set;}
			
			[TagDetails(Tag = 42662, Type = TagType.Int, Offset = 1, Required = false)]
			public int? PaymentStreamFixingDateType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PaymentStreamFixingDate is not null) writer.WriteLocalDateOnly(42661, PaymentStreamFixingDate.Value);
				if (PaymentStreamFixingDateType is not null) writer.WriteWholeNumber(42662, PaymentStreamFixingDateType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PaymentStreamFixingDate = view.GetDateOnly(42661);
				PaymentStreamFixingDateType = view.GetInt32(42662);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PaymentStreamFixingDate":
					{
						value = PaymentStreamFixingDate;
						break;
					}
					case "PaymentStreamFixingDateType":
					{
						value = PaymentStreamFixingDateType;
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
				PaymentStreamFixingDate = null;
				PaymentStreamFixingDateType = null;
			}
		}
		[Group(NoOfTag = 42660, Offset = 0, Required = false)]
		public NoPaymentStreamFixingDates[]? PaymentStreamFixingDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStreamFixingDates is not null && PaymentStreamFixingDates.Length != 0)
			{
				writer.WriteWholeNumber(42660, PaymentStreamFixingDates.Length);
				for (int i = 0; i < PaymentStreamFixingDates.Length; i++)
				{
					((IFixEncoder)PaymentStreamFixingDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPaymentStreamFixingDates") is IMessageView viewNoPaymentStreamFixingDates)
			{
				var count = viewNoPaymentStreamFixingDates.GroupCount();
				PaymentStreamFixingDates = new NoPaymentStreamFixingDates[count];
				for (int i = 0; i < count; i++)
				{
					PaymentStreamFixingDates[i] = new();
					((IFixParser)PaymentStreamFixingDates[i]).Parse(viewNoPaymentStreamFixingDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPaymentStreamFixingDates":
				{
					value = PaymentStreamFixingDates;
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
			PaymentStreamFixingDates = null;
		}
	}
}
