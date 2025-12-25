using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingProvisionCashSettlPaymentDates : IFixComponent
	{
		[TagDetails(Tag = 42092, Type = TagType.Int, Offset = 0, Required = false)]
		public int? UnderlyingProvisionCashSettlPaymentDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public UnderlyingProvisionCashSettlPaymentDateBusinessCenterGrp? UnderlyingProvisionCashSettlPaymentDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 42093, Type = TagType.Int, Offset = 2, Required = false)]
		public int? UnderlyingProvisionCashSettlPaymentDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42094, Type = TagType.Int, Offset = 3, Required = false)]
		public int? UnderlyingProvisionCashSettlPaymentDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42095, Type = TagType.String, Offset = 4, Required = false)]
		public string? UnderlyingProvisionCashSettlPaymentDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42096, Type = TagType.Int, Offset = 5, Required = false)]
		public int? UnderlyingProvisionCashSettlPaymentDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42097, Type = TagType.LocalDate, Offset = 6, Required = false)]
		public DateOnly? UnderlyingProvisionCashSettlPaymentDateRangeFirst {get; set;}
		
		[TagDetails(Tag = 42098, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? UnderlyingProvisionCashSettlPaymentDateRangeLast {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public UnderlyingProvisionCashSettlPaymentFixedDateGrp? UnderlyingProvisionCashSettlPaymentFixedDateGrp {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingProvisionCashSettlPaymentDateBusinessDayConvention is not null) writer.WriteWholeNumber(42092, UnderlyingProvisionCashSettlPaymentDateBusinessDayConvention.Value);
			if (UnderlyingProvisionCashSettlPaymentDateBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingProvisionCashSettlPaymentDateBusinessCenterGrp).Encode(writer);
			if (UnderlyingProvisionCashSettlPaymentDateRelativeTo is not null) writer.WriteWholeNumber(42093, UnderlyingProvisionCashSettlPaymentDateRelativeTo.Value);
			if (UnderlyingProvisionCashSettlPaymentDateOffsetPeriod is not null) writer.WriteWholeNumber(42094, UnderlyingProvisionCashSettlPaymentDateOffsetPeriod.Value);
			if (UnderlyingProvisionCashSettlPaymentDateOffsetUnit is not null) writer.WriteString(42095, UnderlyingProvisionCashSettlPaymentDateOffsetUnit);
			if (UnderlyingProvisionCashSettlPaymentDateOffsetDayType is not null) writer.WriteWholeNumber(42096, UnderlyingProvisionCashSettlPaymentDateOffsetDayType.Value);
			if (UnderlyingProvisionCashSettlPaymentDateRangeFirst is not null) writer.WriteLocalDateOnly(42097, UnderlyingProvisionCashSettlPaymentDateRangeFirst.Value);
			if (UnderlyingProvisionCashSettlPaymentDateRangeLast is not null) writer.WriteLocalDateOnly(42098, UnderlyingProvisionCashSettlPaymentDateRangeLast.Value);
			if (UnderlyingProvisionCashSettlPaymentFixedDateGrp is not null) ((IFixEncoder)UnderlyingProvisionCashSettlPaymentFixedDateGrp).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingProvisionCashSettlPaymentDateBusinessDayConvention = view.GetInt32(42092);
			if (view.GetView("UnderlyingProvisionCashSettlPaymentDateBusinessCenterGrp") is IMessageView viewUnderlyingProvisionCashSettlPaymentDateBusinessCenterGrp)
			{
				UnderlyingProvisionCashSettlPaymentDateBusinessCenterGrp = new();
				((IFixParser)UnderlyingProvisionCashSettlPaymentDateBusinessCenterGrp).Parse(viewUnderlyingProvisionCashSettlPaymentDateBusinessCenterGrp);
			}
			UnderlyingProvisionCashSettlPaymentDateRelativeTo = view.GetInt32(42093);
			UnderlyingProvisionCashSettlPaymentDateOffsetPeriod = view.GetInt32(42094);
			UnderlyingProvisionCashSettlPaymentDateOffsetUnit = view.GetString(42095);
			UnderlyingProvisionCashSettlPaymentDateOffsetDayType = view.GetInt32(42096);
			UnderlyingProvisionCashSettlPaymentDateRangeFirst = view.GetDateOnly(42097);
			UnderlyingProvisionCashSettlPaymentDateRangeLast = view.GetDateOnly(42098);
			if (view.GetView("UnderlyingProvisionCashSettlPaymentFixedDateGrp") is IMessageView viewUnderlyingProvisionCashSettlPaymentFixedDateGrp)
			{
				UnderlyingProvisionCashSettlPaymentFixedDateGrp = new();
				((IFixParser)UnderlyingProvisionCashSettlPaymentFixedDateGrp).Parse(viewUnderlyingProvisionCashSettlPaymentFixedDateGrp);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingProvisionCashSettlPaymentDateBusinessDayConvention":
				{
					value = UnderlyingProvisionCashSettlPaymentDateBusinessDayConvention;
					break;
				}
				case "UnderlyingProvisionCashSettlPaymentDateBusinessCenterGrp":
				{
					value = UnderlyingProvisionCashSettlPaymentDateBusinessCenterGrp;
					break;
				}
				case "UnderlyingProvisionCashSettlPaymentDateRelativeTo":
				{
					value = UnderlyingProvisionCashSettlPaymentDateRelativeTo;
					break;
				}
				case "UnderlyingProvisionCashSettlPaymentDateOffsetPeriod":
				{
					value = UnderlyingProvisionCashSettlPaymentDateOffsetPeriod;
					break;
				}
				case "UnderlyingProvisionCashSettlPaymentDateOffsetUnit":
				{
					value = UnderlyingProvisionCashSettlPaymentDateOffsetUnit;
					break;
				}
				case "UnderlyingProvisionCashSettlPaymentDateOffsetDayType":
				{
					value = UnderlyingProvisionCashSettlPaymentDateOffsetDayType;
					break;
				}
				case "UnderlyingProvisionCashSettlPaymentDateRangeFirst":
				{
					value = UnderlyingProvisionCashSettlPaymentDateRangeFirst;
					break;
				}
				case "UnderlyingProvisionCashSettlPaymentDateRangeLast":
				{
					value = UnderlyingProvisionCashSettlPaymentDateRangeLast;
					break;
				}
				case "UnderlyingProvisionCashSettlPaymentFixedDateGrp":
				{
					value = UnderlyingProvisionCashSettlPaymentFixedDateGrp;
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
			UnderlyingProvisionCashSettlPaymentDateBusinessDayConvention = null;
			((IFixReset?)UnderlyingProvisionCashSettlPaymentDateBusinessCenterGrp)?.Reset();
			UnderlyingProvisionCashSettlPaymentDateRelativeTo = null;
			UnderlyingProvisionCashSettlPaymentDateOffsetPeriod = null;
			UnderlyingProvisionCashSettlPaymentDateOffsetUnit = null;
			UnderlyingProvisionCashSettlPaymentDateOffsetDayType = null;
			UnderlyingProvisionCashSettlPaymentDateRangeFirst = null;
			UnderlyingProvisionCashSettlPaymentDateRangeLast = null;
			((IFixReset?)UnderlyingProvisionCashSettlPaymentFixedDateGrp)?.Reset();
		}
	}
}
