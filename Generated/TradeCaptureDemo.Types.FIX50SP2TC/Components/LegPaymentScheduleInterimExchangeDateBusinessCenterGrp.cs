using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentScheduleInterimExchangeDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegPaymentScheduleInterimExchangeDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40409, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegPaymentScheduleInterimExchangeDatesBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegPaymentScheduleInterimExchangeDatesBusinessCenter is not null) writer.WriteString(40409, LegPaymentScheduleInterimExchangeDatesBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegPaymentScheduleInterimExchangeDatesBusinessCenter = view.GetString(40409);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegPaymentScheduleInterimExchangeDatesBusinessCenter":
					{
						value = LegPaymentScheduleInterimExchangeDatesBusinessCenter;
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
				LegPaymentScheduleInterimExchangeDatesBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40928, Offset = 0, Required = false)]
		public NoLegPaymentScheduleInterimExchangeDateBusinessCenters[]? LegPaymentScheduleInterimExchangeDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentScheduleInterimExchangeDateBusinessCenters is not null && LegPaymentScheduleInterimExchangeDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40928, LegPaymentScheduleInterimExchangeDateBusinessCenters.Length);
				for (int i = 0; i < LegPaymentScheduleInterimExchangeDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegPaymentScheduleInterimExchangeDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegPaymentScheduleInterimExchangeDateBusinessCenters") is IMessageView viewNoLegPaymentScheduleInterimExchangeDateBusinessCenters)
			{
				var count = viewNoLegPaymentScheduleInterimExchangeDateBusinessCenters.GroupCount();
				LegPaymentScheduleInterimExchangeDateBusinessCenters = new NoLegPaymentScheduleInterimExchangeDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegPaymentScheduleInterimExchangeDateBusinessCenters[i] = new();
					((IFixParser)LegPaymentScheduleInterimExchangeDateBusinessCenters[i]).Parse(viewNoLegPaymentScheduleInterimExchangeDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegPaymentScheduleInterimExchangeDateBusinessCenters":
				{
					value = LegPaymentScheduleInterimExchangeDateBusinessCenters;
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
			LegPaymentScheduleInterimExchangeDateBusinessCenters = null;
		}
	}
}
