using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class DividendFXTriggerDate : IFixComponent
	{
		[TagDetails(Tag = 42265, Type = TagType.Int, Offset = 0, Required = false)]
		public int? DividendFXTriggerDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42266, Type = TagType.Int, Offset = 1, Required = false)]
		public int? DividendFXTriggerDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42267, Type = TagType.String, Offset = 2, Required = false)]
		public string? DividendFXTriggerDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42268, Type = TagType.Int, Offset = 3, Required = false)]
		public int? DividendFXTriggerDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42269, Type = TagType.LocalDate, Offset = 4, Required = false)]
		public DateOnly? DividendFXTriggerDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42270, Type = TagType.Int, Offset = 5, Required = false)]
		public int? DividendFXTriggerDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 6, Required = false)]
		public DividendFXTriggerDateBusinessCenterGrp? DividendFXTriggerDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 42271, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? DividendFXTriggerDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (DividendFXTriggerDateRelativeTo is not null) writer.WriteWholeNumber(42265, DividendFXTriggerDateRelativeTo.Value);
			if (DividendFXTriggerDateOffsetPeriod is not null) writer.WriteWholeNumber(42266, DividendFXTriggerDateOffsetPeriod.Value);
			if (DividendFXTriggerDateOffsetUnit is not null) writer.WriteString(42267, DividendFXTriggerDateOffsetUnit);
			if (DividendFXTriggerDateOffsetDayType is not null) writer.WriteWholeNumber(42268, DividendFXTriggerDateOffsetDayType.Value);
			if (DividendFXTriggerDateUnadjusted is not null) writer.WriteLocalDateOnly(42269, DividendFXTriggerDateUnadjusted.Value);
			if (DividendFXTriggerDateBusinessDayConvention is not null) writer.WriteWholeNumber(42270, DividendFXTriggerDateBusinessDayConvention.Value);
			if (DividendFXTriggerDateBusinessCenterGrp is not null) ((IFixEncoder)DividendFXTriggerDateBusinessCenterGrp).Encode(writer);
			if (DividendFXTriggerDateAdjusted is not null) writer.WriteLocalDateOnly(42271, DividendFXTriggerDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			DividendFXTriggerDateRelativeTo = view.GetInt32(42265);
			DividendFXTriggerDateOffsetPeriod = view.GetInt32(42266);
			DividendFXTriggerDateOffsetUnit = view.GetString(42267);
			DividendFXTriggerDateOffsetDayType = view.GetInt32(42268);
			DividendFXTriggerDateUnadjusted = view.GetDateOnly(42269);
			DividendFXTriggerDateBusinessDayConvention = view.GetInt32(42270);
			if (view.GetView("DividendFXTriggerDateBusinessCenterGrp") is IMessageView viewDividendFXTriggerDateBusinessCenterGrp)
			{
				DividendFXTriggerDateBusinessCenterGrp = new();
				((IFixParser)DividendFXTriggerDateBusinessCenterGrp).Parse(viewDividendFXTriggerDateBusinessCenterGrp);
			}
			DividendFXTriggerDateAdjusted = view.GetDateOnly(42271);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "DividendFXTriggerDateRelativeTo":
				{
					value = DividendFXTriggerDateRelativeTo;
					break;
				}
				case "DividendFXTriggerDateOffsetPeriod":
				{
					value = DividendFXTriggerDateOffsetPeriod;
					break;
				}
				case "DividendFXTriggerDateOffsetUnit":
				{
					value = DividendFXTriggerDateOffsetUnit;
					break;
				}
				case "DividendFXTriggerDateOffsetDayType":
				{
					value = DividendFXTriggerDateOffsetDayType;
					break;
				}
				case "DividendFXTriggerDateUnadjusted":
				{
					value = DividendFXTriggerDateUnadjusted;
					break;
				}
				case "DividendFXTriggerDateBusinessDayConvention":
				{
					value = DividendFXTriggerDateBusinessDayConvention;
					break;
				}
				case "DividendFXTriggerDateBusinessCenterGrp":
				{
					value = DividendFXTriggerDateBusinessCenterGrp;
					break;
				}
				case "DividendFXTriggerDateAdjusted":
				{
					value = DividendFXTriggerDateAdjusted;
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
			DividendFXTriggerDateRelativeTo = null;
			DividendFXTriggerDateOffsetPeriod = null;
			DividendFXTriggerDateOffsetUnit = null;
			DividendFXTriggerDateOffsetDayType = null;
			DividendFXTriggerDateUnadjusted = null;
			DividendFXTriggerDateBusinessDayConvention = null;
			((IFixReset?)DividendFXTriggerDateBusinessCenterGrp)?.Reset();
			DividendFXTriggerDateAdjusted = null;
		}
	}
}
