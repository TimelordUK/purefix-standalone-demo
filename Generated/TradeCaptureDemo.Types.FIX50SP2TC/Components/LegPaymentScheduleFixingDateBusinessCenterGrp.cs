using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentScheduleFixingDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegPaymentScheduleFixingDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40400, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegPaymentScheduleFixingDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegPaymentScheduleFixingDateBusinessCenter is not null) writer.WriteString(40400, LegPaymentScheduleFixingDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegPaymentScheduleFixingDateBusinessCenter = view.GetString(40400);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegPaymentScheduleFixingDateBusinessCenter":
					{
						value = LegPaymentScheduleFixingDateBusinessCenter;
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
				LegPaymentScheduleFixingDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40927, Offset = 0, Required = false)]
		public NoLegPaymentScheduleFixingDateBusinessCenters[]? LegPaymentScheduleFixingDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentScheduleFixingDateBusinessCenters is not null && LegPaymentScheduleFixingDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40927, LegPaymentScheduleFixingDateBusinessCenters.Length);
				for (int i = 0; i < LegPaymentScheduleFixingDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegPaymentScheduleFixingDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegPaymentScheduleFixingDateBusinessCenters") is IMessageView viewNoLegPaymentScheduleFixingDateBusinessCenters)
			{
				var count = viewNoLegPaymentScheduleFixingDateBusinessCenters.GroupCount();
				LegPaymentScheduleFixingDateBusinessCenters = new NoLegPaymentScheduleFixingDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegPaymentScheduleFixingDateBusinessCenters[i] = new();
					((IFixParser)LegPaymentScheduleFixingDateBusinessCenters[i]).Parse(viewNoLegPaymentScheduleFixingDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegPaymentScheduleFixingDateBusinessCenters":
				{
					value = LegPaymentScheduleFixingDateBusinessCenters;
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
			LegPaymentScheduleFixingDateBusinessCenters = null;
		}
	}
}
