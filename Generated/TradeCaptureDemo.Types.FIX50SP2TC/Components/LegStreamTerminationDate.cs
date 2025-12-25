using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegStreamTerminationDate : IFixComponent
	{
		[TagDetails(Tag = 40257, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? LegStreamTerminationDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40258, Type = TagType.Int, Offset = 1, Required = false)]
		public int? LegStreamTerminationDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public LegStreamTerminationDateBusinessCenterGrp? LegStreamTerminationDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40260, Type = TagType.Int, Offset = 3, Required = false)]
		public int? LegStreamTerminationDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40261, Type = TagType.Int, Offset = 4, Required = false)]
		public int? LegStreamTerminationDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40262, Type = TagType.String, Offset = 5, Required = false)]
		public string? LegStreamTerminationDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40263, Type = TagType.Int, Offset = 6, Required = false)]
		public int? LegStreamTerminationDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 40264, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? LegStreamTerminationDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegStreamTerminationDateUnadjusted is not null) writer.WriteLocalDateOnly(40257, LegStreamTerminationDateUnadjusted.Value);
			if (LegStreamTerminationDateBusinessDayConvention is not null) writer.WriteWholeNumber(40258, LegStreamTerminationDateBusinessDayConvention.Value);
			if (LegStreamTerminationDateBusinessCenterGrp is not null) ((IFixEncoder)LegStreamTerminationDateBusinessCenterGrp).Encode(writer);
			if (LegStreamTerminationDateRelativeTo is not null) writer.WriteWholeNumber(40260, LegStreamTerminationDateRelativeTo.Value);
			if (LegStreamTerminationDateOffsetPeriod is not null) writer.WriteWholeNumber(40261, LegStreamTerminationDateOffsetPeriod.Value);
			if (LegStreamTerminationDateOffsetUnit is not null) writer.WriteString(40262, LegStreamTerminationDateOffsetUnit);
			if (LegStreamTerminationDateOffsetDayType is not null) writer.WriteWholeNumber(40263, LegStreamTerminationDateOffsetDayType.Value);
			if (LegStreamTerminationDateAdjusted is not null) writer.WriteLocalDateOnly(40264, LegStreamTerminationDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegStreamTerminationDateUnadjusted = view.GetDateOnly(40257);
			LegStreamTerminationDateBusinessDayConvention = view.GetInt32(40258);
			if (view.GetView("LegStreamTerminationDateBusinessCenterGrp") is IMessageView viewLegStreamTerminationDateBusinessCenterGrp)
			{
				LegStreamTerminationDateBusinessCenterGrp = new();
				((IFixParser)LegStreamTerminationDateBusinessCenterGrp).Parse(viewLegStreamTerminationDateBusinessCenterGrp);
			}
			LegStreamTerminationDateRelativeTo = view.GetInt32(40260);
			LegStreamTerminationDateOffsetPeriod = view.GetInt32(40261);
			LegStreamTerminationDateOffsetUnit = view.GetString(40262);
			LegStreamTerminationDateOffsetDayType = view.GetInt32(40263);
			LegStreamTerminationDateAdjusted = view.GetDateOnly(40264);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegStreamTerminationDateUnadjusted":
				{
					value = LegStreamTerminationDateUnadjusted;
					break;
				}
				case "LegStreamTerminationDateBusinessDayConvention":
				{
					value = LegStreamTerminationDateBusinessDayConvention;
					break;
				}
				case "LegStreamTerminationDateBusinessCenterGrp":
				{
					value = LegStreamTerminationDateBusinessCenterGrp;
					break;
				}
				case "LegStreamTerminationDateRelativeTo":
				{
					value = LegStreamTerminationDateRelativeTo;
					break;
				}
				case "LegStreamTerminationDateOffsetPeriod":
				{
					value = LegStreamTerminationDateOffsetPeriod;
					break;
				}
				case "LegStreamTerminationDateOffsetUnit":
				{
					value = LegStreamTerminationDateOffsetUnit;
					break;
				}
				case "LegStreamTerminationDateOffsetDayType":
				{
					value = LegStreamTerminationDateOffsetDayType;
					break;
				}
				case "LegStreamTerminationDateAdjusted":
				{
					value = LegStreamTerminationDateAdjusted;
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
			LegStreamTerminationDateUnadjusted = null;
			LegStreamTerminationDateBusinessDayConvention = null;
			((IFixReset?)LegStreamTerminationDateBusinessCenterGrp)?.Reset();
			LegStreamTerminationDateRelativeTo = null;
			LegStreamTerminationDateOffsetPeriod = null;
			LegStreamTerminationDateOffsetUnit = null;
			LegStreamTerminationDateOffsetDayType = null;
			LegStreamTerminationDateAdjusted = null;
		}
	}
}
