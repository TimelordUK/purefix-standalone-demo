using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingDividendAccrualPaymentDate : IFixComponent
	{
		[TagDetails(Tag = 42819, Type = TagType.Int, Offset = 0, Required = false)]
		public int? UnderlyingDividendAccrualPaymentDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42820, Type = TagType.Int, Offset = 1, Required = false)]
		public int? UnderlyingDividendAccrualPaymentDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42821, Type = TagType.String, Offset = 2, Required = false)]
		public string? UnderlyingDividendAccrualPaymentDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42822, Type = TagType.Int, Offset = 3, Required = false)]
		public int? UnderlyingDividendAccrualPaymentDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42823, Type = TagType.LocalDate, Offset = 4, Required = false)]
		public DateOnly? UnderlyingDividendAccrualPaymentDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42824, Type = TagType.Int, Offset = 5, Required = false)]
		public int? UnderlyingDividendAccrualPaymentDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 6, Required = false)]
		public UnderlyingDividendAccrualPaymentDateBusinessCenterGrp? UnderlyingDividendAccrualPaymentDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 42825, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? UnderlyingDividendAccrualPaymentDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingDividendAccrualPaymentDateRelativeTo is not null) writer.WriteWholeNumber(42819, UnderlyingDividendAccrualPaymentDateRelativeTo.Value);
			if (UnderlyingDividendAccrualPaymentDateOffsetPeriod is not null) writer.WriteWholeNumber(42820, UnderlyingDividendAccrualPaymentDateOffsetPeriod.Value);
			if (UnderlyingDividendAccrualPaymentDateOffsetUnit is not null) writer.WriteString(42821, UnderlyingDividendAccrualPaymentDateOffsetUnit);
			if (UnderlyingDividendAccrualPaymentDateOffsetDayType is not null) writer.WriteWholeNumber(42822, UnderlyingDividendAccrualPaymentDateOffsetDayType.Value);
			if (UnderlyingDividendAccrualPaymentDateUnadjusted is not null) writer.WriteLocalDateOnly(42823, UnderlyingDividendAccrualPaymentDateUnadjusted.Value);
			if (UnderlyingDividendAccrualPaymentDateBusinessDayConvention is not null) writer.WriteWholeNumber(42824, UnderlyingDividendAccrualPaymentDateBusinessDayConvention.Value);
			if (UnderlyingDividendAccrualPaymentDateBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingDividendAccrualPaymentDateBusinessCenterGrp).Encode(writer);
			if (UnderlyingDividendAccrualPaymentDateAdjusted is not null) writer.WriteLocalDateOnly(42825, UnderlyingDividendAccrualPaymentDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingDividendAccrualPaymentDateRelativeTo = view.GetInt32(42819);
			UnderlyingDividendAccrualPaymentDateOffsetPeriod = view.GetInt32(42820);
			UnderlyingDividendAccrualPaymentDateOffsetUnit = view.GetString(42821);
			UnderlyingDividendAccrualPaymentDateOffsetDayType = view.GetInt32(42822);
			UnderlyingDividendAccrualPaymentDateUnadjusted = view.GetDateOnly(42823);
			UnderlyingDividendAccrualPaymentDateBusinessDayConvention = view.GetInt32(42824);
			if (view.GetView("UnderlyingDividendAccrualPaymentDateBusinessCenterGrp") is IMessageView viewUnderlyingDividendAccrualPaymentDateBusinessCenterGrp)
			{
				UnderlyingDividendAccrualPaymentDateBusinessCenterGrp = new();
				((IFixParser)UnderlyingDividendAccrualPaymentDateBusinessCenterGrp).Parse(viewUnderlyingDividendAccrualPaymentDateBusinessCenterGrp);
			}
			UnderlyingDividendAccrualPaymentDateAdjusted = view.GetDateOnly(42825);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingDividendAccrualPaymentDateRelativeTo":
				{
					value = UnderlyingDividendAccrualPaymentDateRelativeTo;
					break;
				}
				case "UnderlyingDividendAccrualPaymentDateOffsetPeriod":
				{
					value = UnderlyingDividendAccrualPaymentDateOffsetPeriod;
					break;
				}
				case "UnderlyingDividendAccrualPaymentDateOffsetUnit":
				{
					value = UnderlyingDividendAccrualPaymentDateOffsetUnit;
					break;
				}
				case "UnderlyingDividendAccrualPaymentDateOffsetDayType":
				{
					value = UnderlyingDividendAccrualPaymentDateOffsetDayType;
					break;
				}
				case "UnderlyingDividendAccrualPaymentDateUnadjusted":
				{
					value = UnderlyingDividendAccrualPaymentDateUnadjusted;
					break;
				}
				case "UnderlyingDividendAccrualPaymentDateBusinessDayConvention":
				{
					value = UnderlyingDividendAccrualPaymentDateBusinessDayConvention;
					break;
				}
				case "UnderlyingDividendAccrualPaymentDateBusinessCenterGrp":
				{
					value = UnderlyingDividendAccrualPaymentDateBusinessCenterGrp;
					break;
				}
				case "UnderlyingDividendAccrualPaymentDateAdjusted":
				{
					value = UnderlyingDividendAccrualPaymentDateAdjusted;
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
			UnderlyingDividendAccrualPaymentDateRelativeTo = null;
			UnderlyingDividendAccrualPaymentDateOffsetPeriod = null;
			UnderlyingDividendAccrualPaymentDateOffsetUnit = null;
			UnderlyingDividendAccrualPaymentDateOffsetDayType = null;
			UnderlyingDividendAccrualPaymentDateUnadjusted = null;
			UnderlyingDividendAccrualPaymentDateBusinessDayConvention = null;
			((IFixReset?)UnderlyingDividendAccrualPaymentDateBusinessCenterGrp)?.Reset();
			UnderlyingDividendAccrualPaymentDateAdjusted = null;
		}
	}
}
