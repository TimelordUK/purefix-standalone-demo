using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingCashSettlDate : IFixComponent
	{
		[TagDetails(Tag = 42790, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? UnderlyingCashSettlDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42791, Type = TagType.Int, Offset = 1, Required = false)]
		public int? UnderlyingCashSettlDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public UnderlyingCashSettlDateBusinessCenterGrp? UnderlyingCashSettlDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 42792, Type = TagType.Int, Offset = 3, Required = false)]
		public int? UnderlyingCashSettlDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42793, Type = TagType.Int, Offset = 4, Required = false)]
		public int? UnderlyingCashSettlDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42794, Type = TagType.String, Offset = 5, Required = false)]
		public string? UnderlyingCashSettlDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42795, Type = TagType.Int, Offset = 6, Required = false)]
		public int? UnderlyingCashSettlDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42796, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? UnderlyingCashSettlDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingCashSettlDateUnadjusted is not null) writer.WriteLocalDateOnly(42790, UnderlyingCashSettlDateUnadjusted.Value);
			if (UnderlyingCashSettlDateBusinessDayConvention is not null) writer.WriteWholeNumber(42791, UnderlyingCashSettlDateBusinessDayConvention.Value);
			if (UnderlyingCashSettlDateBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingCashSettlDateBusinessCenterGrp).Encode(writer);
			if (UnderlyingCashSettlDateRelativeTo is not null) writer.WriteWholeNumber(42792, UnderlyingCashSettlDateRelativeTo.Value);
			if (UnderlyingCashSettlDateOffsetPeriod is not null) writer.WriteWholeNumber(42793, UnderlyingCashSettlDateOffsetPeriod.Value);
			if (UnderlyingCashSettlDateOffsetUnit is not null) writer.WriteString(42794, UnderlyingCashSettlDateOffsetUnit);
			if (UnderlyingCashSettlDateOffsetDayType is not null) writer.WriteWholeNumber(42795, UnderlyingCashSettlDateOffsetDayType.Value);
			if (UnderlyingCashSettlDateAdjusted is not null) writer.WriteLocalDateOnly(42796, UnderlyingCashSettlDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingCashSettlDateUnadjusted = view.GetDateOnly(42790);
			UnderlyingCashSettlDateBusinessDayConvention = view.GetInt32(42791);
			if (view.GetView("UnderlyingCashSettlDateBusinessCenterGrp") is IMessageView viewUnderlyingCashSettlDateBusinessCenterGrp)
			{
				UnderlyingCashSettlDateBusinessCenterGrp = new();
				((IFixParser)UnderlyingCashSettlDateBusinessCenterGrp).Parse(viewUnderlyingCashSettlDateBusinessCenterGrp);
			}
			UnderlyingCashSettlDateRelativeTo = view.GetInt32(42792);
			UnderlyingCashSettlDateOffsetPeriod = view.GetInt32(42793);
			UnderlyingCashSettlDateOffsetUnit = view.GetString(42794);
			UnderlyingCashSettlDateOffsetDayType = view.GetInt32(42795);
			UnderlyingCashSettlDateAdjusted = view.GetDateOnly(42796);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingCashSettlDateUnadjusted":
				{
					value = UnderlyingCashSettlDateUnadjusted;
					break;
				}
				case "UnderlyingCashSettlDateBusinessDayConvention":
				{
					value = UnderlyingCashSettlDateBusinessDayConvention;
					break;
				}
				case "UnderlyingCashSettlDateBusinessCenterGrp":
				{
					value = UnderlyingCashSettlDateBusinessCenterGrp;
					break;
				}
				case "UnderlyingCashSettlDateRelativeTo":
				{
					value = UnderlyingCashSettlDateRelativeTo;
					break;
				}
				case "UnderlyingCashSettlDateOffsetPeriod":
				{
					value = UnderlyingCashSettlDateOffsetPeriod;
					break;
				}
				case "UnderlyingCashSettlDateOffsetUnit":
				{
					value = UnderlyingCashSettlDateOffsetUnit;
					break;
				}
				case "UnderlyingCashSettlDateOffsetDayType":
				{
					value = UnderlyingCashSettlDateOffsetDayType;
					break;
				}
				case "UnderlyingCashSettlDateAdjusted":
				{
					value = UnderlyingCashSettlDateAdjusted;
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
			UnderlyingCashSettlDateUnadjusted = null;
			UnderlyingCashSettlDateBusinessDayConvention = null;
			((IFixReset?)UnderlyingCashSettlDateBusinessCenterGrp)?.Reset();
			UnderlyingCashSettlDateRelativeTo = null;
			UnderlyingCashSettlDateOffsetPeriod = null;
			UnderlyingCashSettlDateOffsetUnit = null;
			UnderlyingCashSettlDateOffsetDayType = null;
			UnderlyingCashSettlDateAdjusted = null;
		}
	}
}
