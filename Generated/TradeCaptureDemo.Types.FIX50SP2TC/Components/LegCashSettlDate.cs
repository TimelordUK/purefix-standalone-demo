using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegCashSettlDate : IFixComponent
	{
		[TagDetails(Tag = 42299, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? LegCashSettlDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42300, Type = TagType.Int, Offset = 1, Required = false)]
		public int? LegCashSettlDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public LegCashSettlDateBusinessCenterGrp? LegCashSettlDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 42301, Type = TagType.Int, Offset = 3, Required = false)]
		public int? LegCashSettlDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42302, Type = TagType.Int, Offset = 4, Required = false)]
		public int? LegCashSettlDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42303, Type = TagType.String, Offset = 5, Required = false)]
		public string? LegCashSettlDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42304, Type = TagType.Int, Offset = 6, Required = false)]
		public int? LegCashSettlDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42305, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? LegCashSettlDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegCashSettlDateUnadjusted is not null) writer.WriteLocalDateOnly(42299, LegCashSettlDateUnadjusted.Value);
			if (LegCashSettlDateBusinessDayConvention is not null) writer.WriteWholeNumber(42300, LegCashSettlDateBusinessDayConvention.Value);
			if (LegCashSettlDateBusinessCenterGrp is not null) ((IFixEncoder)LegCashSettlDateBusinessCenterGrp).Encode(writer);
			if (LegCashSettlDateRelativeTo is not null) writer.WriteWholeNumber(42301, LegCashSettlDateRelativeTo.Value);
			if (LegCashSettlDateOffsetPeriod is not null) writer.WriteWholeNumber(42302, LegCashSettlDateOffsetPeriod.Value);
			if (LegCashSettlDateOffsetUnit is not null) writer.WriteString(42303, LegCashSettlDateOffsetUnit);
			if (LegCashSettlDateOffsetDayType is not null) writer.WriteWholeNumber(42304, LegCashSettlDateOffsetDayType.Value);
			if (LegCashSettlDateAdjusted is not null) writer.WriteLocalDateOnly(42305, LegCashSettlDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegCashSettlDateUnadjusted = view.GetDateOnly(42299);
			LegCashSettlDateBusinessDayConvention = view.GetInt32(42300);
			if (view.GetView("LegCashSettlDateBusinessCenterGrp") is IMessageView viewLegCashSettlDateBusinessCenterGrp)
			{
				LegCashSettlDateBusinessCenterGrp = new();
				((IFixParser)LegCashSettlDateBusinessCenterGrp).Parse(viewLegCashSettlDateBusinessCenterGrp);
			}
			LegCashSettlDateRelativeTo = view.GetInt32(42301);
			LegCashSettlDateOffsetPeriod = view.GetInt32(42302);
			LegCashSettlDateOffsetUnit = view.GetString(42303);
			LegCashSettlDateOffsetDayType = view.GetInt32(42304);
			LegCashSettlDateAdjusted = view.GetDateOnly(42305);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegCashSettlDateUnadjusted":
				{
					value = LegCashSettlDateUnadjusted;
					break;
				}
				case "LegCashSettlDateBusinessDayConvention":
				{
					value = LegCashSettlDateBusinessDayConvention;
					break;
				}
				case "LegCashSettlDateBusinessCenterGrp":
				{
					value = LegCashSettlDateBusinessCenterGrp;
					break;
				}
				case "LegCashSettlDateRelativeTo":
				{
					value = LegCashSettlDateRelativeTo;
					break;
				}
				case "LegCashSettlDateOffsetPeriod":
				{
					value = LegCashSettlDateOffsetPeriod;
					break;
				}
				case "LegCashSettlDateOffsetUnit":
				{
					value = LegCashSettlDateOffsetUnit;
					break;
				}
				case "LegCashSettlDateOffsetDayType":
				{
					value = LegCashSettlDateOffsetDayType;
					break;
				}
				case "LegCashSettlDateAdjusted":
				{
					value = LegCashSettlDateAdjusted;
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
			LegCashSettlDateUnadjusted = null;
			LegCashSettlDateBusinessDayConvention = null;
			((IFixReset?)LegCashSettlDateBusinessCenterGrp)?.Reset();
			LegCashSettlDateRelativeTo = null;
			LegCashSettlDateOffsetPeriod = null;
			LegCashSettlDateOffsetUnit = null;
			LegCashSettlDateOffsetDayType = null;
			LegCashSettlDateAdjusted = null;
		}
	}
}
