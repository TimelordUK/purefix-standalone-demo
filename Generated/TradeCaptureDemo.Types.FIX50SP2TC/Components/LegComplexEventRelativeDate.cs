using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegComplexEventRelativeDate : IFixComponent
	{
		[TagDetails(Tag = 41389, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? LegComplexEventDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 41390, Type = TagType.Int, Offset = 1, Required = false)]
		public int? LegComplexEventDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 41391, Type = TagType.Int, Offset = 2, Required = false)]
		public int? LegComplexEventDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 41392, Type = TagType.String, Offset = 3, Required = false)]
		public string? LegComplexEventDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 41393, Type = TagType.Int, Offset = 4, Required = false)]
		public int? LegComplexEventDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 41394, Type = TagType.Int, Offset = 5, Required = false)]
		public int? LegComplexEventDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 6, Required = false)]
		public LegComplexEventDateBusinessCenterGrp? LegComplexEventDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 41395, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? LegComplexEventDateAdjusted {get; set;}
		
		[TagDetails(Tag = 41396, Type = TagType.String, Offset = 8, Required = false)]
		public string? LegComplexEventFixingTime {get; set;}
		
		[TagDetails(Tag = 41397, Type = TagType.String, Offset = 9, Required = false)]
		public string? LegComplexEventFixingTimeBusinessCenter {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegComplexEventDateUnadjusted is not null) writer.WriteLocalDateOnly(41389, LegComplexEventDateUnadjusted.Value);
			if (LegComplexEventDateRelativeTo is not null) writer.WriteWholeNumber(41390, LegComplexEventDateRelativeTo.Value);
			if (LegComplexEventDateOffsetPeriod is not null) writer.WriteWholeNumber(41391, LegComplexEventDateOffsetPeriod.Value);
			if (LegComplexEventDateOffsetUnit is not null) writer.WriteString(41392, LegComplexEventDateOffsetUnit);
			if (LegComplexEventDateOffsetDayType is not null) writer.WriteWholeNumber(41393, LegComplexEventDateOffsetDayType.Value);
			if (LegComplexEventDateBusinessDayConvention is not null) writer.WriteWholeNumber(41394, LegComplexEventDateBusinessDayConvention.Value);
			if (LegComplexEventDateBusinessCenterGrp is not null) ((IFixEncoder)LegComplexEventDateBusinessCenterGrp).Encode(writer);
			if (LegComplexEventDateAdjusted is not null) writer.WriteLocalDateOnly(41395, LegComplexEventDateAdjusted.Value);
			if (LegComplexEventFixingTime is not null) writer.WriteString(41396, LegComplexEventFixingTime);
			if (LegComplexEventFixingTimeBusinessCenter is not null) writer.WriteString(41397, LegComplexEventFixingTimeBusinessCenter);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegComplexEventDateUnadjusted = view.GetDateOnly(41389);
			LegComplexEventDateRelativeTo = view.GetInt32(41390);
			LegComplexEventDateOffsetPeriod = view.GetInt32(41391);
			LegComplexEventDateOffsetUnit = view.GetString(41392);
			LegComplexEventDateOffsetDayType = view.GetInt32(41393);
			LegComplexEventDateBusinessDayConvention = view.GetInt32(41394);
			if (view.GetView("LegComplexEventDateBusinessCenterGrp") is IMessageView viewLegComplexEventDateBusinessCenterGrp)
			{
				LegComplexEventDateBusinessCenterGrp = new();
				((IFixParser)LegComplexEventDateBusinessCenterGrp).Parse(viewLegComplexEventDateBusinessCenterGrp);
			}
			LegComplexEventDateAdjusted = view.GetDateOnly(41395);
			LegComplexEventFixingTime = view.GetString(41396);
			LegComplexEventFixingTimeBusinessCenter = view.GetString(41397);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegComplexEventDateUnadjusted":
				{
					value = LegComplexEventDateUnadjusted;
					break;
				}
				case "LegComplexEventDateRelativeTo":
				{
					value = LegComplexEventDateRelativeTo;
					break;
				}
				case "LegComplexEventDateOffsetPeriod":
				{
					value = LegComplexEventDateOffsetPeriod;
					break;
				}
				case "LegComplexEventDateOffsetUnit":
				{
					value = LegComplexEventDateOffsetUnit;
					break;
				}
				case "LegComplexEventDateOffsetDayType":
				{
					value = LegComplexEventDateOffsetDayType;
					break;
				}
				case "LegComplexEventDateBusinessDayConvention":
				{
					value = LegComplexEventDateBusinessDayConvention;
					break;
				}
				case "LegComplexEventDateBusinessCenterGrp":
				{
					value = LegComplexEventDateBusinessCenterGrp;
					break;
				}
				case "LegComplexEventDateAdjusted":
				{
					value = LegComplexEventDateAdjusted;
					break;
				}
				case "LegComplexEventFixingTime":
				{
					value = LegComplexEventFixingTime;
					break;
				}
				case "LegComplexEventFixingTimeBusinessCenter":
				{
					value = LegComplexEventFixingTimeBusinessCenter;
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
			LegComplexEventDateUnadjusted = null;
			LegComplexEventDateRelativeTo = null;
			LegComplexEventDateOffsetPeriod = null;
			LegComplexEventDateOffsetUnit = null;
			LegComplexEventDateOffsetDayType = null;
			LegComplexEventDateBusinessDayConvention = null;
			((IFixReset?)LegComplexEventDateBusinessCenterGrp)?.Reset();
			LegComplexEventDateAdjusted = null;
			LegComplexEventFixingTime = null;
			LegComplexEventFixingTimeBusinessCenter = null;
		}
	}
}
