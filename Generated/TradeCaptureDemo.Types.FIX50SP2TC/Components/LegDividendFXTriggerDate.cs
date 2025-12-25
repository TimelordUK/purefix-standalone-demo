using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegDividendFXTriggerDate : IFixComponent
	{
		[TagDetails(Tag = 42357, Type = TagType.Int, Offset = 0, Required = false)]
		public int? LegDividendFXTriggerDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42358, Type = TagType.Int, Offset = 1, Required = false)]
		public int? LegDividendFXTriggerDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42359, Type = TagType.String, Offset = 2, Required = false)]
		public string? LegDividendFXTriggerDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42360, Type = TagType.Int, Offset = 3, Required = false)]
		public int? LegDividendFXTriggerDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42361, Type = TagType.LocalDate, Offset = 4, Required = false)]
		public DateOnly? LegDividendFXTriggerDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42362, Type = TagType.Int, Offset = 5, Required = false)]
		public int? LegDividendFXTriggerDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 6, Required = false)]
		public LegDividendFXTriggerDateBusinessCenterGrp? LegDividendFXTriggerDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 42363, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? LegDividendFXTriggerDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegDividendFXTriggerDateRelativeTo is not null) writer.WriteWholeNumber(42357, LegDividendFXTriggerDateRelativeTo.Value);
			if (LegDividendFXTriggerDateOffsetPeriod is not null) writer.WriteWholeNumber(42358, LegDividendFXTriggerDateOffsetPeriod.Value);
			if (LegDividendFXTriggerDateOffsetUnit is not null) writer.WriteString(42359, LegDividendFXTriggerDateOffsetUnit);
			if (LegDividendFXTriggerDateOffsetDayType is not null) writer.WriteWholeNumber(42360, LegDividendFXTriggerDateOffsetDayType.Value);
			if (LegDividendFXTriggerDateUnadjusted is not null) writer.WriteLocalDateOnly(42361, LegDividendFXTriggerDateUnadjusted.Value);
			if (LegDividendFXTriggerDateBusinessDayConvention is not null) writer.WriteWholeNumber(42362, LegDividendFXTriggerDateBusinessDayConvention.Value);
			if (LegDividendFXTriggerDateBusinessCenterGrp is not null) ((IFixEncoder)LegDividendFXTriggerDateBusinessCenterGrp).Encode(writer);
			if (LegDividendFXTriggerDateAdjusted is not null) writer.WriteLocalDateOnly(42363, LegDividendFXTriggerDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegDividendFXTriggerDateRelativeTo = view.GetInt32(42357);
			LegDividendFXTriggerDateOffsetPeriod = view.GetInt32(42358);
			LegDividendFXTriggerDateOffsetUnit = view.GetString(42359);
			LegDividendFXTriggerDateOffsetDayType = view.GetInt32(42360);
			LegDividendFXTriggerDateUnadjusted = view.GetDateOnly(42361);
			LegDividendFXTriggerDateBusinessDayConvention = view.GetInt32(42362);
			if (view.GetView("LegDividendFXTriggerDateBusinessCenterGrp") is IMessageView viewLegDividendFXTriggerDateBusinessCenterGrp)
			{
				LegDividendFXTriggerDateBusinessCenterGrp = new();
				((IFixParser)LegDividendFXTriggerDateBusinessCenterGrp).Parse(viewLegDividendFXTriggerDateBusinessCenterGrp);
			}
			LegDividendFXTriggerDateAdjusted = view.GetDateOnly(42363);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegDividendFXTriggerDateRelativeTo":
				{
					value = LegDividendFXTriggerDateRelativeTo;
					break;
				}
				case "LegDividendFXTriggerDateOffsetPeriod":
				{
					value = LegDividendFXTriggerDateOffsetPeriod;
					break;
				}
				case "LegDividendFXTriggerDateOffsetUnit":
				{
					value = LegDividendFXTriggerDateOffsetUnit;
					break;
				}
				case "LegDividendFXTriggerDateOffsetDayType":
				{
					value = LegDividendFXTriggerDateOffsetDayType;
					break;
				}
				case "LegDividendFXTriggerDateUnadjusted":
				{
					value = LegDividendFXTriggerDateUnadjusted;
					break;
				}
				case "LegDividendFXTriggerDateBusinessDayConvention":
				{
					value = LegDividendFXTriggerDateBusinessDayConvention;
					break;
				}
				case "LegDividendFXTriggerDateBusinessCenterGrp":
				{
					value = LegDividendFXTriggerDateBusinessCenterGrp;
					break;
				}
				case "LegDividendFXTriggerDateAdjusted":
				{
					value = LegDividendFXTriggerDateAdjusted;
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
			LegDividendFXTriggerDateRelativeTo = null;
			LegDividendFXTriggerDateOffsetPeriod = null;
			LegDividendFXTriggerDateOffsetUnit = null;
			LegDividendFXTriggerDateOffsetDayType = null;
			LegDividendFXTriggerDateUnadjusted = null;
			LegDividendFXTriggerDateBusinessDayConvention = null;
			((IFixReset?)LegDividendFXTriggerDateBusinessCenterGrp)?.Reset();
			LegDividendFXTriggerDateAdjusted = null;
		}
	}
}
