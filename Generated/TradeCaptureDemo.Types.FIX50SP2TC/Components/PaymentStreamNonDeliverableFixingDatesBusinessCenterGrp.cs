using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStreamNonDeliverableFixingDatesBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoPaymentStreamNonDeliverableFixingDatesBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40819, Type = TagType.String, Offset = 0, Required = false)]
			public string? PaymentStreamNonDeliverableFixingDatesBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PaymentStreamNonDeliverableFixingDatesBusinessCenter is not null) writer.WriteString(40819, PaymentStreamNonDeliverableFixingDatesBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PaymentStreamNonDeliverableFixingDatesBusinessCenter = view.GetString(40819);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PaymentStreamNonDeliverableFixingDatesBusinessCenter":
					{
						value = PaymentStreamNonDeliverableFixingDatesBusinessCenter;
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
				PaymentStreamNonDeliverableFixingDatesBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40946, Offset = 0, Required = false)]
		public NoPaymentStreamNonDeliverableFixingDatesBusinessCenters[]? PaymentStreamNonDeliverableFixingDatesBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStreamNonDeliverableFixingDatesBusinessCenters is not null && PaymentStreamNonDeliverableFixingDatesBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40946, PaymentStreamNonDeliverableFixingDatesBusinessCenters.Length);
				for (int i = 0; i < PaymentStreamNonDeliverableFixingDatesBusinessCenters.Length; i++)
				{
					((IFixEncoder)PaymentStreamNonDeliverableFixingDatesBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPaymentStreamNonDeliverableFixingDatesBusinessCenters") is IMessageView viewNoPaymentStreamNonDeliverableFixingDatesBusinessCenters)
			{
				var count = viewNoPaymentStreamNonDeliverableFixingDatesBusinessCenters.GroupCount();
				PaymentStreamNonDeliverableFixingDatesBusinessCenters = new NoPaymentStreamNonDeliverableFixingDatesBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					PaymentStreamNonDeliverableFixingDatesBusinessCenters[i] = new();
					((IFixParser)PaymentStreamNonDeliverableFixingDatesBusinessCenters[i]).Parse(viewNoPaymentStreamNonDeliverableFixingDatesBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPaymentStreamNonDeliverableFixingDatesBusinessCenters":
				{
					value = PaymentStreamNonDeliverableFixingDatesBusinessCenters;
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
			PaymentStreamNonDeliverableFixingDatesBusinessCenters = null;
		}
	}
}
