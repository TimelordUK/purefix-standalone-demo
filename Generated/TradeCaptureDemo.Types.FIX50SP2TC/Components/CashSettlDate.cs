using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class CashSettlDate : IFixComponent
	{
		[TagDetails(Tag = 42207, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? CashSettlDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42208, Type = TagType.Int, Offset = 1, Required = false)]
		public int? CashSettlDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public CashSettlDateBusinessCenterGrp? CashSettlDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 42209, Type = TagType.Int, Offset = 3, Required = false)]
		public int? CashSettlDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42210, Type = TagType.Int, Offset = 4, Required = false)]
		public int? CashSettlDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42211, Type = TagType.String, Offset = 5, Required = false)]
		public string? CashSettlDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42212, Type = TagType.Int, Offset = 6, Required = false)]
		public int? CashSettlDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42213, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? CashSettlDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (CashSettlDateUnadjusted is not null) writer.WriteLocalDateOnly(42207, CashSettlDateUnadjusted.Value);
			if (CashSettlDateBusinessDayConvention is not null) writer.WriteWholeNumber(42208, CashSettlDateBusinessDayConvention.Value);
			if (CashSettlDateBusinessCenterGrp is not null) ((IFixEncoder)CashSettlDateBusinessCenterGrp).Encode(writer);
			if (CashSettlDateRelativeTo is not null) writer.WriteWholeNumber(42209, CashSettlDateRelativeTo.Value);
			if (CashSettlDateOffsetPeriod is not null) writer.WriteWholeNumber(42210, CashSettlDateOffsetPeriod.Value);
			if (CashSettlDateOffsetUnit is not null) writer.WriteString(42211, CashSettlDateOffsetUnit);
			if (CashSettlDateOffsetDayType is not null) writer.WriteWholeNumber(42212, CashSettlDateOffsetDayType.Value);
			if (CashSettlDateAdjusted is not null) writer.WriteLocalDateOnly(42213, CashSettlDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			CashSettlDateUnadjusted = view.GetDateOnly(42207);
			CashSettlDateBusinessDayConvention = view.GetInt32(42208);
			if (view.GetView("CashSettlDateBusinessCenterGrp") is IMessageView viewCashSettlDateBusinessCenterGrp)
			{
				CashSettlDateBusinessCenterGrp = new();
				((IFixParser)CashSettlDateBusinessCenterGrp).Parse(viewCashSettlDateBusinessCenterGrp);
			}
			CashSettlDateRelativeTo = view.GetInt32(42209);
			CashSettlDateOffsetPeriod = view.GetInt32(42210);
			CashSettlDateOffsetUnit = view.GetString(42211);
			CashSettlDateOffsetDayType = view.GetInt32(42212);
			CashSettlDateAdjusted = view.GetDateOnly(42213);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "CashSettlDateUnadjusted":
				{
					value = CashSettlDateUnadjusted;
					break;
				}
				case "CashSettlDateBusinessDayConvention":
				{
					value = CashSettlDateBusinessDayConvention;
					break;
				}
				case "CashSettlDateBusinessCenterGrp":
				{
					value = CashSettlDateBusinessCenterGrp;
					break;
				}
				case "CashSettlDateRelativeTo":
				{
					value = CashSettlDateRelativeTo;
					break;
				}
				case "CashSettlDateOffsetPeriod":
				{
					value = CashSettlDateOffsetPeriod;
					break;
				}
				case "CashSettlDateOffsetUnit":
				{
					value = CashSettlDateOffsetUnit;
					break;
				}
				case "CashSettlDateOffsetDayType":
				{
					value = CashSettlDateOffsetDayType;
					break;
				}
				case "CashSettlDateAdjusted":
				{
					value = CashSettlDateAdjusted;
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
			CashSettlDateUnadjusted = null;
			CashSettlDateBusinessDayConvention = null;
			((IFixReset?)CashSettlDateBusinessCenterGrp)?.Reset();
			CashSettlDateRelativeTo = null;
			CashSettlDateOffsetPeriod = null;
			CashSettlDateOffsetUnit = null;
			CashSettlDateOffsetDayType = null;
			CashSettlDateAdjusted = null;
		}
	}
}
