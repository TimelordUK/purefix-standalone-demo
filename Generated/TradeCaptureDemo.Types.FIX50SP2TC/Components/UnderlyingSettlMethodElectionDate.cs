using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingSettlMethodElectionDate : IFixComponent
	{
		[TagDetails(Tag = 43076, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? UnderlyingSettlMethodElectionDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 43077, Type = TagType.Int, Offset = 1, Required = false)]
		public int? UnderlyingSettlMethodElectionDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public UnderlyingSettlMethodElectionDateBusinessCenterGrp? UnderlyingSettlMethodElectionDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 43078, Type = TagType.Int, Offset = 3, Required = false)]
		public int? UnderlyingSettlMethodElectionDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 43079, Type = TagType.Int, Offset = 4, Required = false)]
		public int? UnderlyingSettlMethodElectionDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 43080, Type = TagType.String, Offset = 5, Required = false)]
		public string? UnderlyingSettlMethodElectionDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 43081, Type = TagType.Int, Offset = 6, Required = false)]
		public int? UnderlyingSettlMethodElectionDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 43082, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? UnderlyingSettlMethodElectionDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingSettlMethodElectionDateUnadjusted is not null) writer.WriteLocalDateOnly(43076, UnderlyingSettlMethodElectionDateUnadjusted.Value);
			if (UnderlyingSettlMethodElectionDateBusinessDayConvention is not null) writer.WriteWholeNumber(43077, UnderlyingSettlMethodElectionDateBusinessDayConvention.Value);
			if (UnderlyingSettlMethodElectionDateBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingSettlMethodElectionDateBusinessCenterGrp).Encode(writer);
			if (UnderlyingSettlMethodElectionDateRelativeTo is not null) writer.WriteWholeNumber(43078, UnderlyingSettlMethodElectionDateRelativeTo.Value);
			if (UnderlyingSettlMethodElectionDateOffsetPeriod is not null) writer.WriteWholeNumber(43079, UnderlyingSettlMethodElectionDateOffsetPeriod.Value);
			if (UnderlyingSettlMethodElectionDateOffsetUnit is not null) writer.WriteString(43080, UnderlyingSettlMethodElectionDateOffsetUnit);
			if (UnderlyingSettlMethodElectionDateOffsetDayType is not null) writer.WriteWholeNumber(43081, UnderlyingSettlMethodElectionDateOffsetDayType.Value);
			if (UnderlyingSettlMethodElectionDateAdjusted is not null) writer.WriteLocalDateOnly(43082, UnderlyingSettlMethodElectionDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingSettlMethodElectionDateUnadjusted = view.GetDateOnly(43076);
			UnderlyingSettlMethodElectionDateBusinessDayConvention = view.GetInt32(43077);
			if (view.GetView("UnderlyingSettlMethodElectionDateBusinessCenterGrp") is IMessageView viewUnderlyingSettlMethodElectionDateBusinessCenterGrp)
			{
				UnderlyingSettlMethodElectionDateBusinessCenterGrp = new();
				((IFixParser)UnderlyingSettlMethodElectionDateBusinessCenterGrp).Parse(viewUnderlyingSettlMethodElectionDateBusinessCenterGrp);
			}
			UnderlyingSettlMethodElectionDateRelativeTo = view.GetInt32(43078);
			UnderlyingSettlMethodElectionDateOffsetPeriod = view.GetInt32(43079);
			UnderlyingSettlMethodElectionDateOffsetUnit = view.GetString(43080);
			UnderlyingSettlMethodElectionDateOffsetDayType = view.GetInt32(43081);
			UnderlyingSettlMethodElectionDateAdjusted = view.GetDateOnly(43082);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingSettlMethodElectionDateUnadjusted":
				{
					value = UnderlyingSettlMethodElectionDateUnadjusted;
					break;
				}
				case "UnderlyingSettlMethodElectionDateBusinessDayConvention":
				{
					value = UnderlyingSettlMethodElectionDateBusinessDayConvention;
					break;
				}
				case "UnderlyingSettlMethodElectionDateBusinessCenterGrp":
				{
					value = UnderlyingSettlMethodElectionDateBusinessCenterGrp;
					break;
				}
				case "UnderlyingSettlMethodElectionDateRelativeTo":
				{
					value = UnderlyingSettlMethodElectionDateRelativeTo;
					break;
				}
				case "UnderlyingSettlMethodElectionDateOffsetPeriod":
				{
					value = UnderlyingSettlMethodElectionDateOffsetPeriod;
					break;
				}
				case "UnderlyingSettlMethodElectionDateOffsetUnit":
				{
					value = UnderlyingSettlMethodElectionDateOffsetUnit;
					break;
				}
				case "UnderlyingSettlMethodElectionDateOffsetDayType":
				{
					value = UnderlyingSettlMethodElectionDateOffsetDayType;
					break;
				}
				case "UnderlyingSettlMethodElectionDateAdjusted":
				{
					value = UnderlyingSettlMethodElectionDateAdjusted;
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
			UnderlyingSettlMethodElectionDateUnadjusted = null;
			UnderlyingSettlMethodElectionDateBusinessDayConvention = null;
			((IFixReset?)UnderlyingSettlMethodElectionDateBusinessCenterGrp)?.Reset();
			UnderlyingSettlMethodElectionDateRelativeTo = null;
			UnderlyingSettlMethodElectionDateOffsetPeriod = null;
			UnderlyingSettlMethodElectionDateOffsetUnit = null;
			UnderlyingSettlMethodElectionDateOffsetDayType = null;
			UnderlyingSettlMethodElectionDateAdjusted = null;
		}
	}
}
