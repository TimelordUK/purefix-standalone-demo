using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentScheduleInterimExchangeDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingPaymentScheduleInterimExchangeDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40699, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingPaymentScheduleInterimExchangeDatesBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingPaymentScheduleInterimExchangeDatesBusinessCenter is not null) writer.WriteString(40699, UnderlyingPaymentScheduleInterimExchangeDatesBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingPaymentScheduleInterimExchangeDatesBusinessCenter = view.GetString(40699);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingPaymentScheduleInterimExchangeDatesBusinessCenter":
					{
						value = UnderlyingPaymentScheduleInterimExchangeDatesBusinessCenter;
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
				UnderlyingPaymentScheduleInterimExchangeDatesBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40967, Offset = 0, Required = false)]
		public NoUnderlyingPaymentScheduleInterimExchangeDateBusinessCenters[]? UnderlyingPaymentScheduleInterimExchangeDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentScheduleInterimExchangeDateBusinessCenters is not null && UnderlyingPaymentScheduleInterimExchangeDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40967, UnderlyingPaymentScheduleInterimExchangeDateBusinessCenters.Length);
				for (int i = 0; i < UnderlyingPaymentScheduleInterimExchangeDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingPaymentScheduleInterimExchangeDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingPaymentScheduleInterimExchangeDateBusinessCenters") is IMessageView viewNoUnderlyingPaymentScheduleInterimExchangeDateBusinessCenters)
			{
				var count = viewNoUnderlyingPaymentScheduleInterimExchangeDateBusinessCenters.GroupCount();
				UnderlyingPaymentScheduleInterimExchangeDateBusinessCenters = new NoUnderlyingPaymentScheduleInterimExchangeDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingPaymentScheduleInterimExchangeDateBusinessCenters[i] = new();
					((IFixParser)UnderlyingPaymentScheduleInterimExchangeDateBusinessCenters[i]).Parse(viewNoUnderlyingPaymentScheduleInterimExchangeDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingPaymentScheduleInterimExchangeDateBusinessCenters":
				{
					value = UnderlyingPaymentScheduleInterimExchangeDateBusinessCenters;
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
			UnderlyingPaymentScheduleInterimExchangeDateBusinessCenters = null;
		}
	}
}
