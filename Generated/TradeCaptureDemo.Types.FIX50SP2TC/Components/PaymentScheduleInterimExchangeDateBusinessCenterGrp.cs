using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentScheduleInterimExchangeDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoPaymentScheduleInterimExchangeDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40863, Type = TagType.String, Offset = 0, Required = false)]
			public string? PaymentScheduleInterimExchangeDatesBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PaymentScheduleInterimExchangeDatesBusinessCenter is not null) writer.WriteString(40863, PaymentScheduleInterimExchangeDatesBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PaymentScheduleInterimExchangeDatesBusinessCenter = view.GetString(40863);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PaymentScheduleInterimExchangeDatesBusinessCenter":
					{
						value = PaymentScheduleInterimExchangeDatesBusinessCenter;
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
				PaymentScheduleInterimExchangeDatesBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40945, Offset = 0, Required = false)]
		public NoPaymentScheduleInterimExchangeDateBusinessCenters[]? PaymentScheduleInterimExchangeDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentScheduleInterimExchangeDateBusinessCenters is not null && PaymentScheduleInterimExchangeDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40945, PaymentScheduleInterimExchangeDateBusinessCenters.Length);
				for (int i = 0; i < PaymentScheduleInterimExchangeDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)PaymentScheduleInterimExchangeDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPaymentScheduleInterimExchangeDateBusinessCenters") is IMessageView viewNoPaymentScheduleInterimExchangeDateBusinessCenters)
			{
				var count = viewNoPaymentScheduleInterimExchangeDateBusinessCenters.GroupCount();
				PaymentScheduleInterimExchangeDateBusinessCenters = new NoPaymentScheduleInterimExchangeDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					PaymentScheduleInterimExchangeDateBusinessCenters[i] = new();
					((IFixParser)PaymentScheduleInterimExchangeDateBusinessCenters[i]).Parse(viewNoPaymentScheduleInterimExchangeDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPaymentScheduleInterimExchangeDateBusinessCenters":
				{
					value = PaymentScheduleInterimExchangeDateBusinessCenters;
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
			PaymentScheduleInterimExchangeDateBusinessCenters = null;
		}
	}
}
