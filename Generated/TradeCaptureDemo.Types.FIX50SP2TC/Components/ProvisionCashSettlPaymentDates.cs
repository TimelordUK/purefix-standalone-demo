using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ProvisionCashSettlPaymentDates : IFixComponent
	{
		[TagDetails(Tag = 40163, Type = TagType.Int, Offset = 0, Required = false)]
		public int? ProvisionCashSettlPaymentDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public ProvisionCashSettlPaymentDateBusinessCenterGrp? ProvisionCashSettlPaymentDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40165, Type = TagType.Int, Offset = 2, Required = false)]
		public int? ProvisionCashSettlPaymentDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40166, Type = TagType.Int, Offset = 3, Required = false)]
		public int? ProvisionCashSettlPaymentDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40167, Type = TagType.String, Offset = 4, Required = false)]
		public string? ProvisionCashSettlPaymentDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40168, Type = TagType.Int, Offset = 5, Required = false)]
		public int? ProvisionCashSettlPaymentDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 40169, Type = TagType.LocalDate, Offset = 6, Required = false)]
		public DateOnly? ProvisionCashSettlPaymentDateRangeFirst {get; set;}
		
		[TagDetails(Tag = 40170, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? ProvisionCashSettlPaymentDateRangeLast {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public ProvisionCashSettlPaymentFixedDateGrp? ProvisionCashSettlPaymentFixedDateGrp {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ProvisionCashSettlPaymentDateBusinessDayConvention is not null) writer.WriteWholeNumber(40163, ProvisionCashSettlPaymentDateBusinessDayConvention.Value);
			if (ProvisionCashSettlPaymentDateBusinessCenterGrp is not null) ((IFixEncoder)ProvisionCashSettlPaymentDateBusinessCenterGrp).Encode(writer);
			if (ProvisionCashSettlPaymentDateRelativeTo is not null) writer.WriteWholeNumber(40165, ProvisionCashSettlPaymentDateRelativeTo.Value);
			if (ProvisionCashSettlPaymentDateOffsetPeriod is not null) writer.WriteWholeNumber(40166, ProvisionCashSettlPaymentDateOffsetPeriod.Value);
			if (ProvisionCashSettlPaymentDateOffsetUnit is not null) writer.WriteString(40167, ProvisionCashSettlPaymentDateOffsetUnit);
			if (ProvisionCashSettlPaymentDateOffsetDayType is not null) writer.WriteWholeNumber(40168, ProvisionCashSettlPaymentDateOffsetDayType.Value);
			if (ProvisionCashSettlPaymentDateRangeFirst is not null) writer.WriteLocalDateOnly(40169, ProvisionCashSettlPaymentDateRangeFirst.Value);
			if (ProvisionCashSettlPaymentDateRangeLast is not null) writer.WriteLocalDateOnly(40170, ProvisionCashSettlPaymentDateRangeLast.Value);
			if (ProvisionCashSettlPaymentFixedDateGrp is not null) ((IFixEncoder)ProvisionCashSettlPaymentFixedDateGrp).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			ProvisionCashSettlPaymentDateBusinessDayConvention = view.GetInt32(40163);
			if (view.GetView("ProvisionCashSettlPaymentDateBusinessCenterGrp") is IMessageView viewProvisionCashSettlPaymentDateBusinessCenterGrp)
			{
				ProvisionCashSettlPaymentDateBusinessCenterGrp = new();
				((IFixParser)ProvisionCashSettlPaymentDateBusinessCenterGrp).Parse(viewProvisionCashSettlPaymentDateBusinessCenterGrp);
			}
			ProvisionCashSettlPaymentDateRelativeTo = view.GetInt32(40165);
			ProvisionCashSettlPaymentDateOffsetPeriod = view.GetInt32(40166);
			ProvisionCashSettlPaymentDateOffsetUnit = view.GetString(40167);
			ProvisionCashSettlPaymentDateOffsetDayType = view.GetInt32(40168);
			ProvisionCashSettlPaymentDateRangeFirst = view.GetDateOnly(40169);
			ProvisionCashSettlPaymentDateRangeLast = view.GetDateOnly(40170);
			if (view.GetView("ProvisionCashSettlPaymentFixedDateGrp") is IMessageView viewProvisionCashSettlPaymentFixedDateGrp)
			{
				ProvisionCashSettlPaymentFixedDateGrp = new();
				((IFixParser)ProvisionCashSettlPaymentFixedDateGrp).Parse(viewProvisionCashSettlPaymentFixedDateGrp);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "ProvisionCashSettlPaymentDateBusinessDayConvention":
				{
					value = ProvisionCashSettlPaymentDateBusinessDayConvention;
					break;
				}
				case "ProvisionCashSettlPaymentDateBusinessCenterGrp":
				{
					value = ProvisionCashSettlPaymentDateBusinessCenterGrp;
					break;
				}
				case "ProvisionCashSettlPaymentDateRelativeTo":
				{
					value = ProvisionCashSettlPaymentDateRelativeTo;
					break;
				}
				case "ProvisionCashSettlPaymentDateOffsetPeriod":
				{
					value = ProvisionCashSettlPaymentDateOffsetPeriod;
					break;
				}
				case "ProvisionCashSettlPaymentDateOffsetUnit":
				{
					value = ProvisionCashSettlPaymentDateOffsetUnit;
					break;
				}
				case "ProvisionCashSettlPaymentDateOffsetDayType":
				{
					value = ProvisionCashSettlPaymentDateOffsetDayType;
					break;
				}
				case "ProvisionCashSettlPaymentDateRangeFirst":
				{
					value = ProvisionCashSettlPaymentDateRangeFirst;
					break;
				}
				case "ProvisionCashSettlPaymentDateRangeLast":
				{
					value = ProvisionCashSettlPaymentDateRangeLast;
					break;
				}
				case "ProvisionCashSettlPaymentFixedDateGrp":
				{
					value = ProvisionCashSettlPaymentFixedDateGrp;
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
			ProvisionCashSettlPaymentDateBusinessDayConvention = null;
			((IFixReset?)ProvisionCashSettlPaymentDateBusinessCenterGrp)?.Reset();
			ProvisionCashSettlPaymentDateRelativeTo = null;
			ProvisionCashSettlPaymentDateOffsetPeriod = null;
			ProvisionCashSettlPaymentDateOffsetUnit = null;
			ProvisionCashSettlPaymentDateOffsetDayType = null;
			ProvisionCashSettlPaymentDateRangeFirst = null;
			ProvisionCashSettlPaymentDateRangeLast = null;
			((IFixReset?)ProvisionCashSettlPaymentFixedDateGrp)?.Reset();
		}
	}
}
