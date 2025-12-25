using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class SettlMethodElectionDate : IFixComponent
	{
		[TagDetails(Tag = 42777, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? SettlMethodElectionDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42778, Type = TagType.Int, Offset = 1, Required = false)]
		public int? SettlMethodElectionDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public SettlMethodElectionDateBusinessCenterGrp? SettlMethodElectionDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 42779, Type = TagType.Int, Offset = 3, Required = false)]
		public int? SettlMethodElectionDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42780, Type = TagType.Int, Offset = 4, Required = false)]
		public int? SettlMethodElectionDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42781, Type = TagType.String, Offset = 5, Required = false)]
		public string? SettlMethodElectionDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42782, Type = TagType.Int, Offset = 6, Required = false)]
		public int? SettlMethodElectionDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42783, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? SettlMethodElectionDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (SettlMethodElectionDateUnadjusted is not null) writer.WriteLocalDateOnly(42777, SettlMethodElectionDateUnadjusted.Value);
			if (SettlMethodElectionDateBusinessDayConvention is not null) writer.WriteWholeNumber(42778, SettlMethodElectionDateBusinessDayConvention.Value);
			if (SettlMethodElectionDateBusinessCenterGrp is not null) ((IFixEncoder)SettlMethodElectionDateBusinessCenterGrp).Encode(writer);
			if (SettlMethodElectionDateRelativeTo is not null) writer.WriteWholeNumber(42779, SettlMethodElectionDateRelativeTo.Value);
			if (SettlMethodElectionDateOffsetPeriod is not null) writer.WriteWholeNumber(42780, SettlMethodElectionDateOffsetPeriod.Value);
			if (SettlMethodElectionDateOffsetUnit is not null) writer.WriteString(42781, SettlMethodElectionDateOffsetUnit);
			if (SettlMethodElectionDateOffsetDayType is not null) writer.WriteWholeNumber(42782, SettlMethodElectionDateOffsetDayType.Value);
			if (SettlMethodElectionDateAdjusted is not null) writer.WriteLocalDateOnly(42783, SettlMethodElectionDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			SettlMethodElectionDateUnadjusted = view.GetDateOnly(42777);
			SettlMethodElectionDateBusinessDayConvention = view.GetInt32(42778);
			if (view.GetView("SettlMethodElectionDateBusinessCenterGrp") is IMessageView viewSettlMethodElectionDateBusinessCenterGrp)
			{
				SettlMethodElectionDateBusinessCenterGrp = new();
				((IFixParser)SettlMethodElectionDateBusinessCenterGrp).Parse(viewSettlMethodElectionDateBusinessCenterGrp);
			}
			SettlMethodElectionDateRelativeTo = view.GetInt32(42779);
			SettlMethodElectionDateOffsetPeriod = view.GetInt32(42780);
			SettlMethodElectionDateOffsetUnit = view.GetString(42781);
			SettlMethodElectionDateOffsetDayType = view.GetInt32(42782);
			SettlMethodElectionDateAdjusted = view.GetDateOnly(42783);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "SettlMethodElectionDateUnadjusted":
				{
					value = SettlMethodElectionDateUnadjusted;
					break;
				}
				case "SettlMethodElectionDateBusinessDayConvention":
				{
					value = SettlMethodElectionDateBusinessDayConvention;
					break;
				}
				case "SettlMethodElectionDateBusinessCenterGrp":
				{
					value = SettlMethodElectionDateBusinessCenterGrp;
					break;
				}
				case "SettlMethodElectionDateRelativeTo":
				{
					value = SettlMethodElectionDateRelativeTo;
					break;
				}
				case "SettlMethodElectionDateOffsetPeriod":
				{
					value = SettlMethodElectionDateOffsetPeriod;
					break;
				}
				case "SettlMethodElectionDateOffsetUnit":
				{
					value = SettlMethodElectionDateOffsetUnit;
					break;
				}
				case "SettlMethodElectionDateOffsetDayType":
				{
					value = SettlMethodElectionDateOffsetDayType;
					break;
				}
				case "SettlMethodElectionDateAdjusted":
				{
					value = SettlMethodElectionDateAdjusted;
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
			SettlMethodElectionDateUnadjusted = null;
			SettlMethodElectionDateBusinessDayConvention = null;
			((IFixReset?)SettlMethodElectionDateBusinessCenterGrp)?.Reset();
			SettlMethodElectionDateRelativeTo = null;
			SettlMethodElectionDateOffsetPeriod = null;
			SettlMethodElectionDateOffsetUnit = null;
			SettlMethodElectionDateOffsetDayType = null;
			SettlMethodElectionDateAdjusted = null;
		}
	}
}
