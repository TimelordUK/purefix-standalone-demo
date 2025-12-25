using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegProvisionCashSettlPaymentDates : IFixComponent
	{
		[TagDetails(Tag = 40516, Type = TagType.Int, Offset = 0, Required = false)]
		public int? LegProvisionCashSettlPaymentDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public LegProvisionCashSettlPaymentDateBusinessCenterGrp? LegProvisionCashSettlPaymentDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40518, Type = TagType.Int, Offset = 2, Required = false)]
		public int? LegProvisionCashSettlPaymentDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40519, Type = TagType.Int, Offset = 3, Required = false)]
		public int? LegProvisionCashSettlPaymentDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40520, Type = TagType.String, Offset = 4, Required = false)]
		public string? LegProvisionCashSettlPaymentDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40521, Type = TagType.Int, Offset = 5, Required = false)]
		public int? LegProvisionCashSettlPaymentDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 40522, Type = TagType.LocalDate, Offset = 6, Required = false)]
		public DateOnly? LegProvisionCashSettlPaymentDateRangeFirst {get; set;}
		
		[TagDetails(Tag = 40523, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? LegProvisionCashSettlPaymentDateRangeLast {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public LegProvisionCashSettlPaymentFixedDateGrp? LegProvisionCashSettlPaymentFixedDateGrp {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegProvisionCashSettlPaymentDateBusinessDayConvention is not null) writer.WriteWholeNumber(40516, LegProvisionCashSettlPaymentDateBusinessDayConvention.Value);
			if (LegProvisionCashSettlPaymentDateBusinessCenterGrp is not null) ((IFixEncoder)LegProvisionCashSettlPaymentDateBusinessCenterGrp).Encode(writer);
			if (LegProvisionCashSettlPaymentDateRelativeTo is not null) writer.WriteWholeNumber(40518, LegProvisionCashSettlPaymentDateRelativeTo.Value);
			if (LegProvisionCashSettlPaymentDateOffsetPeriod is not null) writer.WriteWholeNumber(40519, LegProvisionCashSettlPaymentDateOffsetPeriod.Value);
			if (LegProvisionCashSettlPaymentDateOffsetUnit is not null) writer.WriteString(40520, LegProvisionCashSettlPaymentDateOffsetUnit);
			if (LegProvisionCashSettlPaymentDateOffsetDayType is not null) writer.WriteWholeNumber(40521, LegProvisionCashSettlPaymentDateOffsetDayType.Value);
			if (LegProvisionCashSettlPaymentDateRangeFirst is not null) writer.WriteLocalDateOnly(40522, LegProvisionCashSettlPaymentDateRangeFirst.Value);
			if (LegProvisionCashSettlPaymentDateRangeLast is not null) writer.WriteLocalDateOnly(40523, LegProvisionCashSettlPaymentDateRangeLast.Value);
			if (LegProvisionCashSettlPaymentFixedDateGrp is not null) ((IFixEncoder)LegProvisionCashSettlPaymentFixedDateGrp).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegProvisionCashSettlPaymentDateBusinessDayConvention = view.GetInt32(40516);
			if (view.GetView("LegProvisionCashSettlPaymentDateBusinessCenterGrp") is IMessageView viewLegProvisionCashSettlPaymentDateBusinessCenterGrp)
			{
				LegProvisionCashSettlPaymentDateBusinessCenterGrp = new();
				((IFixParser)LegProvisionCashSettlPaymentDateBusinessCenterGrp).Parse(viewLegProvisionCashSettlPaymentDateBusinessCenterGrp);
			}
			LegProvisionCashSettlPaymentDateRelativeTo = view.GetInt32(40518);
			LegProvisionCashSettlPaymentDateOffsetPeriod = view.GetInt32(40519);
			LegProvisionCashSettlPaymentDateOffsetUnit = view.GetString(40520);
			LegProvisionCashSettlPaymentDateOffsetDayType = view.GetInt32(40521);
			LegProvisionCashSettlPaymentDateRangeFirst = view.GetDateOnly(40522);
			LegProvisionCashSettlPaymentDateRangeLast = view.GetDateOnly(40523);
			if (view.GetView("LegProvisionCashSettlPaymentFixedDateGrp") is IMessageView viewLegProvisionCashSettlPaymentFixedDateGrp)
			{
				LegProvisionCashSettlPaymentFixedDateGrp = new();
				((IFixParser)LegProvisionCashSettlPaymentFixedDateGrp).Parse(viewLegProvisionCashSettlPaymentFixedDateGrp);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegProvisionCashSettlPaymentDateBusinessDayConvention":
				{
					value = LegProvisionCashSettlPaymentDateBusinessDayConvention;
					break;
				}
				case "LegProvisionCashSettlPaymentDateBusinessCenterGrp":
				{
					value = LegProvisionCashSettlPaymentDateBusinessCenterGrp;
					break;
				}
				case "LegProvisionCashSettlPaymentDateRelativeTo":
				{
					value = LegProvisionCashSettlPaymentDateRelativeTo;
					break;
				}
				case "LegProvisionCashSettlPaymentDateOffsetPeriod":
				{
					value = LegProvisionCashSettlPaymentDateOffsetPeriod;
					break;
				}
				case "LegProvisionCashSettlPaymentDateOffsetUnit":
				{
					value = LegProvisionCashSettlPaymentDateOffsetUnit;
					break;
				}
				case "LegProvisionCashSettlPaymentDateOffsetDayType":
				{
					value = LegProvisionCashSettlPaymentDateOffsetDayType;
					break;
				}
				case "LegProvisionCashSettlPaymentDateRangeFirst":
				{
					value = LegProvisionCashSettlPaymentDateRangeFirst;
					break;
				}
				case "LegProvisionCashSettlPaymentDateRangeLast":
				{
					value = LegProvisionCashSettlPaymentDateRangeLast;
					break;
				}
				case "LegProvisionCashSettlPaymentFixedDateGrp":
				{
					value = LegProvisionCashSettlPaymentFixedDateGrp;
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
			LegProvisionCashSettlPaymentDateBusinessDayConvention = null;
			((IFixReset?)LegProvisionCashSettlPaymentDateBusinessCenterGrp)?.Reset();
			LegProvisionCashSettlPaymentDateRelativeTo = null;
			LegProvisionCashSettlPaymentDateOffsetPeriod = null;
			LegProvisionCashSettlPaymentDateOffsetUnit = null;
			LegProvisionCashSettlPaymentDateOffsetDayType = null;
			LegProvisionCashSettlPaymentDateRangeFirst = null;
			LegProvisionCashSettlPaymentDateRangeLast = null;
			((IFixReset?)LegProvisionCashSettlPaymentFixedDateGrp)?.Reset();
		}
	}
}
