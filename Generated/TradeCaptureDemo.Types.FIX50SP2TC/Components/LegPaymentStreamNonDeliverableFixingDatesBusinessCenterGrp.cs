using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegPaymentStreamNonDeliverableFixingDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40361, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegPaymentStreamNonDeliverableFixingDatesBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegPaymentStreamNonDeliverableFixingDatesBusinessCenter is not null) writer.WriteString(40361, LegPaymentStreamNonDeliverableFixingDatesBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegPaymentStreamNonDeliverableFixingDatesBusinessCenter = view.GetString(40361);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegPaymentStreamNonDeliverableFixingDatesBusinessCenter":
					{
						value = LegPaymentStreamNonDeliverableFixingDatesBusinessCenter;
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
				LegPaymentStreamNonDeliverableFixingDatesBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40929, Offset = 0, Required = false)]
		public NoLegPaymentStreamNonDeliverableFixingDateBusinessCenters[]? LegPaymentStreamNonDeliverableFixingDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStreamNonDeliverableFixingDateBusinessCenters is not null && LegPaymentStreamNonDeliverableFixingDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40929, LegPaymentStreamNonDeliverableFixingDateBusinessCenters.Length);
				for (int i = 0; i < LegPaymentStreamNonDeliverableFixingDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegPaymentStreamNonDeliverableFixingDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegPaymentStreamNonDeliverableFixingDateBusinessCenters") is IMessageView viewNoLegPaymentStreamNonDeliverableFixingDateBusinessCenters)
			{
				var count = viewNoLegPaymentStreamNonDeliverableFixingDateBusinessCenters.GroupCount();
				LegPaymentStreamNonDeliverableFixingDateBusinessCenters = new NoLegPaymentStreamNonDeliverableFixingDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegPaymentStreamNonDeliverableFixingDateBusinessCenters[i] = new();
					((IFixParser)LegPaymentStreamNonDeliverableFixingDateBusinessCenters[i]).Parse(viewNoLegPaymentStreamNonDeliverableFixingDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegPaymentStreamNonDeliverableFixingDateBusinessCenters":
				{
					value = LegPaymentStreamNonDeliverableFixingDateBusinessCenters;
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
			LegPaymentStreamNonDeliverableFixingDateBusinessCenters = null;
		}
	}
}
