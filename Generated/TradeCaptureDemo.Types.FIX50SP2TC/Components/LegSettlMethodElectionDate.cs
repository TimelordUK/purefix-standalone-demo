using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegSettlMethodElectionDate : IFixComponent
	{
		[TagDetails(Tag = 42574, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? LegSettlMethodElectionDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42575, Type = TagType.Int, Offset = 1, Required = false)]
		public int? LegSettlMethodElectionDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public LegSettlMethodElectionDateBusinessCenterGrp? LegSettlMethodElectionDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 42576, Type = TagType.Int, Offset = 3, Required = false)]
		public int? LegSettlMethodElectionDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42577, Type = TagType.Int, Offset = 4, Required = false)]
		public int? LegSettlMethodElectionDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42578, Type = TagType.String, Offset = 5, Required = false)]
		public string? LegSettlMethodElectionDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42579, Type = TagType.Int, Offset = 6, Required = false)]
		public int? LegSettlMethodElectionDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42580, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? LegSettlMethodElectionDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegSettlMethodElectionDateUnadjusted is not null) writer.WriteLocalDateOnly(42574, LegSettlMethodElectionDateUnadjusted.Value);
			if (LegSettlMethodElectionDateBusinessDayConvention is not null) writer.WriteWholeNumber(42575, LegSettlMethodElectionDateBusinessDayConvention.Value);
			if (LegSettlMethodElectionDateBusinessCenterGrp is not null) ((IFixEncoder)LegSettlMethodElectionDateBusinessCenterGrp).Encode(writer);
			if (LegSettlMethodElectionDateRelativeTo is not null) writer.WriteWholeNumber(42576, LegSettlMethodElectionDateRelativeTo.Value);
			if (LegSettlMethodElectionDateOffsetPeriod is not null) writer.WriteWholeNumber(42577, LegSettlMethodElectionDateOffsetPeriod.Value);
			if (LegSettlMethodElectionDateOffsetUnit is not null) writer.WriteString(42578, LegSettlMethodElectionDateOffsetUnit);
			if (LegSettlMethodElectionDateOffsetDayType is not null) writer.WriteWholeNumber(42579, LegSettlMethodElectionDateOffsetDayType.Value);
			if (LegSettlMethodElectionDateAdjusted is not null) writer.WriteLocalDateOnly(42580, LegSettlMethodElectionDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegSettlMethodElectionDateUnadjusted = view.GetDateOnly(42574);
			LegSettlMethodElectionDateBusinessDayConvention = view.GetInt32(42575);
			if (view.GetView("LegSettlMethodElectionDateBusinessCenterGrp") is IMessageView viewLegSettlMethodElectionDateBusinessCenterGrp)
			{
				LegSettlMethodElectionDateBusinessCenterGrp = new();
				((IFixParser)LegSettlMethodElectionDateBusinessCenterGrp).Parse(viewLegSettlMethodElectionDateBusinessCenterGrp);
			}
			LegSettlMethodElectionDateRelativeTo = view.GetInt32(42576);
			LegSettlMethodElectionDateOffsetPeriod = view.GetInt32(42577);
			LegSettlMethodElectionDateOffsetUnit = view.GetString(42578);
			LegSettlMethodElectionDateOffsetDayType = view.GetInt32(42579);
			LegSettlMethodElectionDateAdjusted = view.GetDateOnly(42580);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegSettlMethodElectionDateUnadjusted":
				{
					value = LegSettlMethodElectionDateUnadjusted;
					break;
				}
				case "LegSettlMethodElectionDateBusinessDayConvention":
				{
					value = LegSettlMethodElectionDateBusinessDayConvention;
					break;
				}
				case "LegSettlMethodElectionDateBusinessCenterGrp":
				{
					value = LegSettlMethodElectionDateBusinessCenterGrp;
					break;
				}
				case "LegSettlMethodElectionDateRelativeTo":
				{
					value = LegSettlMethodElectionDateRelativeTo;
					break;
				}
				case "LegSettlMethodElectionDateOffsetPeriod":
				{
					value = LegSettlMethodElectionDateOffsetPeriod;
					break;
				}
				case "LegSettlMethodElectionDateOffsetUnit":
				{
					value = LegSettlMethodElectionDateOffsetUnit;
					break;
				}
				case "LegSettlMethodElectionDateOffsetDayType":
				{
					value = LegSettlMethodElectionDateOffsetDayType;
					break;
				}
				case "LegSettlMethodElectionDateAdjusted":
				{
					value = LegSettlMethodElectionDateAdjusted;
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
			LegSettlMethodElectionDateUnadjusted = null;
			LegSettlMethodElectionDateBusinessDayConvention = null;
			((IFixReset?)LegSettlMethodElectionDateBusinessCenterGrp)?.Reset();
			LegSettlMethodElectionDateRelativeTo = null;
			LegSettlMethodElectionDateOffsetPeriod = null;
			LegSettlMethodElectionDateOffsetUnit = null;
			LegSettlMethodElectionDateOffsetDayType = null;
			LegSettlMethodElectionDateAdjusted = null;
		}
	}
}
