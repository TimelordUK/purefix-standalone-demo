using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegDividendAccrualPaymentDate : IFixComponent
	{
		[TagDetails(Tag = 42330, Type = TagType.Int, Offset = 0, Required = false)]
		public int? LegDividendAccrualPaymentDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42331, Type = TagType.Int, Offset = 1, Required = false)]
		public int? LegDividendAccrualPaymentDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42332, Type = TagType.String, Offset = 2, Required = false)]
		public string? LegDividendAccrualPaymentDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42333, Type = TagType.Int, Offset = 3, Required = false)]
		public int? LegDividendAccrualPaymentDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42334, Type = TagType.LocalDate, Offset = 4, Required = false)]
		public DateOnly? LegDividendAccrualPaymentDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42335, Type = TagType.Int, Offset = 5, Required = false)]
		public int? LegDividendAccrualPaymentDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 6, Required = false)]
		public LegDividendAccrualPaymentDateBusinessCenterGrp? LegDividendAccrualPaymentDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 42336, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? LegDividendAccrualPaymentDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegDividendAccrualPaymentDateRelativeTo is not null) writer.WriteWholeNumber(42330, LegDividendAccrualPaymentDateRelativeTo.Value);
			if (LegDividendAccrualPaymentDateOffsetPeriod is not null) writer.WriteWholeNumber(42331, LegDividendAccrualPaymentDateOffsetPeriod.Value);
			if (LegDividendAccrualPaymentDateOffsetUnit is not null) writer.WriteString(42332, LegDividendAccrualPaymentDateOffsetUnit);
			if (LegDividendAccrualPaymentDateOffsetDayType is not null) writer.WriteWholeNumber(42333, LegDividendAccrualPaymentDateOffsetDayType.Value);
			if (LegDividendAccrualPaymentDateUnadjusted is not null) writer.WriteLocalDateOnly(42334, LegDividendAccrualPaymentDateUnadjusted.Value);
			if (LegDividendAccrualPaymentDateBusinessDayConvention is not null) writer.WriteWholeNumber(42335, LegDividendAccrualPaymentDateBusinessDayConvention.Value);
			if (LegDividendAccrualPaymentDateBusinessCenterGrp is not null) ((IFixEncoder)LegDividendAccrualPaymentDateBusinessCenterGrp).Encode(writer);
			if (LegDividendAccrualPaymentDateAdjusted is not null) writer.WriteLocalDateOnly(42336, LegDividendAccrualPaymentDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegDividendAccrualPaymentDateRelativeTo = view.GetInt32(42330);
			LegDividendAccrualPaymentDateOffsetPeriod = view.GetInt32(42331);
			LegDividendAccrualPaymentDateOffsetUnit = view.GetString(42332);
			LegDividendAccrualPaymentDateOffsetDayType = view.GetInt32(42333);
			LegDividendAccrualPaymentDateUnadjusted = view.GetDateOnly(42334);
			LegDividendAccrualPaymentDateBusinessDayConvention = view.GetInt32(42335);
			if (view.GetView("LegDividendAccrualPaymentDateBusinessCenterGrp") is IMessageView viewLegDividendAccrualPaymentDateBusinessCenterGrp)
			{
				LegDividendAccrualPaymentDateBusinessCenterGrp = new();
				((IFixParser)LegDividendAccrualPaymentDateBusinessCenterGrp).Parse(viewLegDividendAccrualPaymentDateBusinessCenterGrp);
			}
			LegDividendAccrualPaymentDateAdjusted = view.GetDateOnly(42336);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegDividendAccrualPaymentDateRelativeTo":
				{
					value = LegDividendAccrualPaymentDateRelativeTo;
					break;
				}
				case "LegDividendAccrualPaymentDateOffsetPeriod":
				{
					value = LegDividendAccrualPaymentDateOffsetPeriod;
					break;
				}
				case "LegDividendAccrualPaymentDateOffsetUnit":
				{
					value = LegDividendAccrualPaymentDateOffsetUnit;
					break;
				}
				case "LegDividendAccrualPaymentDateOffsetDayType":
				{
					value = LegDividendAccrualPaymentDateOffsetDayType;
					break;
				}
				case "LegDividendAccrualPaymentDateUnadjusted":
				{
					value = LegDividendAccrualPaymentDateUnadjusted;
					break;
				}
				case "LegDividendAccrualPaymentDateBusinessDayConvention":
				{
					value = LegDividendAccrualPaymentDateBusinessDayConvention;
					break;
				}
				case "LegDividendAccrualPaymentDateBusinessCenterGrp":
				{
					value = LegDividendAccrualPaymentDateBusinessCenterGrp;
					break;
				}
				case "LegDividendAccrualPaymentDateAdjusted":
				{
					value = LegDividendAccrualPaymentDateAdjusted;
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
			LegDividendAccrualPaymentDateRelativeTo = null;
			LegDividendAccrualPaymentDateOffsetPeriod = null;
			LegDividendAccrualPaymentDateOffsetUnit = null;
			LegDividendAccrualPaymentDateOffsetDayType = null;
			LegDividendAccrualPaymentDateUnadjusted = null;
			LegDividendAccrualPaymentDateBusinessDayConvention = null;
			((IFixReset?)LegDividendAccrualPaymentDateBusinessCenterGrp)?.Reset();
			LegDividendAccrualPaymentDateAdjusted = null;
		}
	}
}
