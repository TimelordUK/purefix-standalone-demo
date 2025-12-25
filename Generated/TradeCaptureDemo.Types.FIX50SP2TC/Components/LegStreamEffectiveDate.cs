using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegStreamEffectiveDate : IFixComponent
	{
		[TagDetails(Tag = 40249, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? LegStreamEffectiveDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40250, Type = TagType.Int, Offset = 1, Required = false)]
		public int? LegStreamEffectiveDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public LegStreamEffectiveDateBusinessCenterGrp? LegStreamEffectiveDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40252, Type = TagType.Int, Offset = 3, Required = false)]
		public int? LegStreamEffectiveDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40253, Type = TagType.Int, Offset = 4, Required = false)]
		public int? LegStreamEffectiveDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40254, Type = TagType.String, Offset = 5, Required = false)]
		public string? LegStreamEffectiveDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40255, Type = TagType.Int, Offset = 6, Required = false)]
		public int? LegStreamEffectiveDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 40256, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? LegStreamEffectiveDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegStreamEffectiveDateUnadjusted is not null) writer.WriteLocalDateOnly(40249, LegStreamEffectiveDateUnadjusted.Value);
			if (LegStreamEffectiveDateBusinessDayConvention is not null) writer.WriteWholeNumber(40250, LegStreamEffectiveDateBusinessDayConvention.Value);
			if (LegStreamEffectiveDateBusinessCenterGrp is not null) ((IFixEncoder)LegStreamEffectiveDateBusinessCenterGrp).Encode(writer);
			if (LegStreamEffectiveDateRelativeTo is not null) writer.WriteWholeNumber(40252, LegStreamEffectiveDateRelativeTo.Value);
			if (LegStreamEffectiveDateOffsetPeriod is not null) writer.WriteWholeNumber(40253, LegStreamEffectiveDateOffsetPeriod.Value);
			if (LegStreamEffectiveDateOffsetUnit is not null) writer.WriteString(40254, LegStreamEffectiveDateOffsetUnit);
			if (LegStreamEffectiveDateOffsetDayType is not null) writer.WriteWholeNumber(40255, LegStreamEffectiveDateOffsetDayType.Value);
			if (LegStreamEffectiveDateAdjusted is not null) writer.WriteLocalDateOnly(40256, LegStreamEffectiveDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegStreamEffectiveDateUnadjusted = view.GetDateOnly(40249);
			LegStreamEffectiveDateBusinessDayConvention = view.GetInt32(40250);
			if (view.GetView("LegStreamEffectiveDateBusinessCenterGrp") is IMessageView viewLegStreamEffectiveDateBusinessCenterGrp)
			{
				LegStreamEffectiveDateBusinessCenterGrp = new();
				((IFixParser)LegStreamEffectiveDateBusinessCenterGrp).Parse(viewLegStreamEffectiveDateBusinessCenterGrp);
			}
			LegStreamEffectiveDateRelativeTo = view.GetInt32(40252);
			LegStreamEffectiveDateOffsetPeriod = view.GetInt32(40253);
			LegStreamEffectiveDateOffsetUnit = view.GetString(40254);
			LegStreamEffectiveDateOffsetDayType = view.GetInt32(40255);
			LegStreamEffectiveDateAdjusted = view.GetDateOnly(40256);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegStreamEffectiveDateUnadjusted":
				{
					value = LegStreamEffectiveDateUnadjusted;
					break;
				}
				case "LegStreamEffectiveDateBusinessDayConvention":
				{
					value = LegStreamEffectiveDateBusinessDayConvention;
					break;
				}
				case "LegStreamEffectiveDateBusinessCenterGrp":
				{
					value = LegStreamEffectiveDateBusinessCenterGrp;
					break;
				}
				case "LegStreamEffectiveDateRelativeTo":
				{
					value = LegStreamEffectiveDateRelativeTo;
					break;
				}
				case "LegStreamEffectiveDateOffsetPeriod":
				{
					value = LegStreamEffectiveDateOffsetPeriod;
					break;
				}
				case "LegStreamEffectiveDateOffsetUnit":
				{
					value = LegStreamEffectiveDateOffsetUnit;
					break;
				}
				case "LegStreamEffectiveDateOffsetDayType":
				{
					value = LegStreamEffectiveDateOffsetDayType;
					break;
				}
				case "LegStreamEffectiveDateAdjusted":
				{
					value = LegStreamEffectiveDateAdjusted;
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
			LegStreamEffectiveDateUnadjusted = null;
			LegStreamEffectiveDateBusinessDayConvention = null;
			((IFixReset?)LegStreamEffectiveDateBusinessCenterGrp)?.Reset();
			LegStreamEffectiveDateRelativeTo = null;
			LegStreamEffectiveDateOffsetPeriod = null;
			LegStreamEffectiveDateOffsetUnit = null;
			LegStreamEffectiveDateOffsetDayType = null;
			LegStreamEffectiveDateAdjusted = null;
		}
	}
}
