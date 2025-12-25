using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentScheduleFixingDayGrp : IFixComponent
	{
		public sealed partial class NoLegPaymentScheduleFixingDays : IFixGroup
		{
			[TagDetails(Tag = 41531, Type = TagType.Int, Offset = 0, Required = false)]
			public int? LegPaymentScheduleFixingDayOfWeek {get; set;}
			
			[TagDetails(Tag = 41532, Type = TagType.Int, Offset = 1, Required = false)]
			public int? LegPaymentScheduleFixingDayNumber {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegPaymentScheduleFixingDayOfWeek is not null) writer.WriteWholeNumber(41531, LegPaymentScheduleFixingDayOfWeek.Value);
				if (LegPaymentScheduleFixingDayNumber is not null) writer.WriteWholeNumber(41532, LegPaymentScheduleFixingDayNumber.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegPaymentScheduleFixingDayOfWeek = view.GetInt32(41531);
				LegPaymentScheduleFixingDayNumber = view.GetInt32(41532);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegPaymentScheduleFixingDayOfWeek":
					{
						value = LegPaymentScheduleFixingDayOfWeek;
						break;
					}
					case "LegPaymentScheduleFixingDayNumber":
					{
						value = LegPaymentScheduleFixingDayNumber;
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
				LegPaymentScheduleFixingDayOfWeek = null;
				LegPaymentScheduleFixingDayNumber = null;
			}
		}
		[Group(NoOfTag = 41530, Offset = 0, Required = false)]
		public NoLegPaymentScheduleFixingDays[]? LegPaymentScheduleFixingDays {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentScheduleFixingDays is not null && LegPaymentScheduleFixingDays.Length != 0)
			{
				writer.WriteWholeNumber(41530, LegPaymentScheduleFixingDays.Length);
				for (int i = 0; i < LegPaymentScheduleFixingDays.Length; i++)
				{
					((IFixEncoder)LegPaymentScheduleFixingDays[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegPaymentScheduleFixingDays") is IMessageView viewNoLegPaymentScheduleFixingDays)
			{
				var count = viewNoLegPaymentScheduleFixingDays.GroupCount();
				LegPaymentScheduleFixingDays = new NoLegPaymentScheduleFixingDays[count];
				for (int i = 0; i < count; i++)
				{
					LegPaymentScheduleFixingDays[i] = new();
					((IFixParser)LegPaymentScheduleFixingDays[i]).Parse(viewNoLegPaymentScheduleFixingDays.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegPaymentScheduleFixingDays":
				{
					value = LegPaymentScheduleFixingDays;
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
			LegPaymentScheduleFixingDays = null;
		}
	}
}
