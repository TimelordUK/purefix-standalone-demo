using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStreamCompoundingDatesBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoPaymentStreamCompoundingDatesBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42621, Type = TagType.String, Offset = 0, Required = false)]
			public string? PaymentStreamCompoundingDatesBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PaymentStreamCompoundingDatesBusinessCenter is not null) writer.WriteString(42621, PaymentStreamCompoundingDatesBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PaymentStreamCompoundingDatesBusinessCenter = view.GetString(42621);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PaymentStreamCompoundingDatesBusinessCenter":
					{
						value = PaymentStreamCompoundingDatesBusinessCenter;
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
				PaymentStreamCompoundingDatesBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42620, Offset = 0, Required = false)]
		public NoPaymentStreamCompoundingDatesBusinessCenters[]? PaymentStreamCompoundingDatesBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStreamCompoundingDatesBusinessCenters is not null && PaymentStreamCompoundingDatesBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42620, PaymentStreamCompoundingDatesBusinessCenters.Length);
				for (int i = 0; i < PaymentStreamCompoundingDatesBusinessCenters.Length; i++)
				{
					((IFixEncoder)PaymentStreamCompoundingDatesBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPaymentStreamCompoundingDatesBusinessCenters") is IMessageView viewNoPaymentStreamCompoundingDatesBusinessCenters)
			{
				var count = viewNoPaymentStreamCompoundingDatesBusinessCenters.GroupCount();
				PaymentStreamCompoundingDatesBusinessCenters = new NoPaymentStreamCompoundingDatesBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					PaymentStreamCompoundingDatesBusinessCenters[i] = new();
					((IFixParser)PaymentStreamCompoundingDatesBusinessCenters[i]).Parse(viewNoPaymentStreamCompoundingDatesBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPaymentStreamCompoundingDatesBusinessCenters":
				{
					value = PaymentStreamCompoundingDatesBusinessCenters;
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
			PaymentStreamCompoundingDatesBusinessCenters = null;
		}
	}
}
