using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStreamPaymentDateGrp : IFixComponent
	{
		public sealed partial class NoPaymentStreamPaymentDates : IFixGroup
		{
			[TagDetails(Tag = 41221, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? PaymentStreamPaymentDate {get; set;}
			
			[TagDetails(Tag = 41222, Type = TagType.Int, Offset = 1, Required = false)]
			public int? PaymentStreamPaymentDateType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PaymentStreamPaymentDate is not null) writer.WriteLocalDateOnly(41221, PaymentStreamPaymentDate.Value);
				if (PaymentStreamPaymentDateType is not null) writer.WriteWholeNumber(41222, PaymentStreamPaymentDateType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PaymentStreamPaymentDate = view.GetDateOnly(41221);
				PaymentStreamPaymentDateType = view.GetInt32(41222);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PaymentStreamPaymentDate":
					{
						value = PaymentStreamPaymentDate;
						break;
					}
					case "PaymentStreamPaymentDateType":
					{
						value = PaymentStreamPaymentDateType;
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
				PaymentStreamPaymentDate = null;
				PaymentStreamPaymentDateType = null;
			}
		}
		[Group(NoOfTag = 41220, Offset = 0, Required = false)]
		public NoPaymentStreamPaymentDates[]? PaymentStreamPaymentDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStreamPaymentDates is not null && PaymentStreamPaymentDates.Length != 0)
			{
				writer.WriteWholeNumber(41220, PaymentStreamPaymentDates.Length);
				for (int i = 0; i < PaymentStreamPaymentDates.Length; i++)
				{
					((IFixEncoder)PaymentStreamPaymentDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPaymentStreamPaymentDates") is IMessageView viewNoPaymentStreamPaymentDates)
			{
				var count = viewNoPaymentStreamPaymentDates.GroupCount();
				PaymentStreamPaymentDates = new NoPaymentStreamPaymentDates[count];
				for (int i = 0; i < count; i++)
				{
					PaymentStreamPaymentDates[i] = new();
					((IFixParser)PaymentStreamPaymentDates[i]).Parse(viewNoPaymentStreamPaymentDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPaymentStreamPaymentDates":
				{
					value = PaymentStreamPaymentDates;
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
			PaymentStreamPaymentDates = null;
		}
	}
}
