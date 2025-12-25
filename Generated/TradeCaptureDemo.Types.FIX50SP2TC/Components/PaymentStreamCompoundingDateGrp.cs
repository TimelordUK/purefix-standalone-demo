using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStreamCompoundingDateGrp : IFixComponent
	{
		public sealed partial class NoPaymentStreamCompoundingDates : IFixGroup
		{
			[TagDetails(Tag = 42607, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? PaymentStreamCompoundingDate {get; set;}
			
			[TagDetails(Tag = 42608, Type = TagType.Int, Offset = 1, Required = false)]
			public int? PaymentStreamCompoundingDateType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PaymentStreamCompoundingDate is not null) writer.WriteLocalDateOnly(42607, PaymentStreamCompoundingDate.Value);
				if (PaymentStreamCompoundingDateType is not null) writer.WriteWholeNumber(42608, PaymentStreamCompoundingDateType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PaymentStreamCompoundingDate = view.GetDateOnly(42607);
				PaymentStreamCompoundingDateType = view.GetInt32(42608);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PaymentStreamCompoundingDate":
					{
						value = PaymentStreamCompoundingDate;
						break;
					}
					case "PaymentStreamCompoundingDateType":
					{
						value = PaymentStreamCompoundingDateType;
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
				PaymentStreamCompoundingDate = null;
				PaymentStreamCompoundingDateType = null;
			}
		}
		[Group(NoOfTag = 42606, Offset = 0, Required = false)]
		public NoPaymentStreamCompoundingDates[]? PaymentStreamCompoundingDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStreamCompoundingDates is not null && PaymentStreamCompoundingDates.Length != 0)
			{
				writer.WriteWholeNumber(42606, PaymentStreamCompoundingDates.Length);
				for (int i = 0; i < PaymentStreamCompoundingDates.Length; i++)
				{
					((IFixEncoder)PaymentStreamCompoundingDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPaymentStreamCompoundingDates") is IMessageView viewNoPaymentStreamCompoundingDates)
			{
				var count = viewNoPaymentStreamCompoundingDates.GroupCount();
				PaymentStreamCompoundingDates = new NoPaymentStreamCompoundingDates[count];
				for (int i = 0; i < count; i++)
				{
					PaymentStreamCompoundingDates[i] = new();
					((IFixParser)PaymentStreamCompoundingDates[i]).Parse(viewNoPaymentStreamCompoundingDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPaymentStreamCompoundingDates":
				{
					value = PaymentStreamCompoundingDates;
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
			PaymentStreamCompoundingDates = null;
		}
	}
}
