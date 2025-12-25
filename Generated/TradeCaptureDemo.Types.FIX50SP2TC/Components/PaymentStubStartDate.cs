using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStubStartDate : IFixComponent
	{
		[TagDetails(Tag = 42698, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? PaymentStubStartDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42699, Type = TagType.Int, Offset = 1, Required = false)]
		public int? PaymentStubStartDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public PaymentStubStartDateBusinessCenterGrp? PaymentStubStartDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 42700, Type = TagType.Int, Offset = 3, Required = false)]
		public int? PaymentStubStartDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42701, Type = TagType.Int, Offset = 4, Required = false)]
		public int? PaymentStubStartDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42702, Type = TagType.String, Offset = 5, Required = false)]
		public string? PaymentStubStartDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42703, Type = TagType.Int, Offset = 6, Required = false)]
		public int? PaymentStubStartDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42704, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? PaymentStubStartDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStubStartDateUnadjusted is not null) writer.WriteLocalDateOnly(42698, PaymentStubStartDateUnadjusted.Value);
			if (PaymentStubStartDateBusinessDayConvention is not null) writer.WriteWholeNumber(42699, PaymentStubStartDateBusinessDayConvention.Value);
			if (PaymentStubStartDateBusinessCenterGrp is not null) ((IFixEncoder)PaymentStubStartDateBusinessCenterGrp).Encode(writer);
			if (PaymentStubStartDateRelativeTo is not null) writer.WriteWholeNumber(42700, PaymentStubStartDateRelativeTo.Value);
			if (PaymentStubStartDateOffsetPeriod is not null) writer.WriteWholeNumber(42701, PaymentStubStartDateOffsetPeriod.Value);
			if (PaymentStubStartDateOffsetUnit is not null) writer.WriteString(42702, PaymentStubStartDateOffsetUnit);
			if (PaymentStubStartDateOffsetDayType is not null) writer.WriteWholeNumber(42703, PaymentStubStartDateOffsetDayType.Value);
			if (PaymentStubStartDateAdjusted is not null) writer.WriteLocalDateOnly(42704, PaymentStubStartDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			PaymentStubStartDateUnadjusted = view.GetDateOnly(42698);
			PaymentStubStartDateBusinessDayConvention = view.GetInt32(42699);
			if (view.GetView("PaymentStubStartDateBusinessCenterGrp") is IMessageView viewPaymentStubStartDateBusinessCenterGrp)
			{
				PaymentStubStartDateBusinessCenterGrp = new();
				((IFixParser)PaymentStubStartDateBusinessCenterGrp).Parse(viewPaymentStubStartDateBusinessCenterGrp);
			}
			PaymentStubStartDateRelativeTo = view.GetInt32(42700);
			PaymentStubStartDateOffsetPeriod = view.GetInt32(42701);
			PaymentStubStartDateOffsetUnit = view.GetString(42702);
			PaymentStubStartDateOffsetDayType = view.GetInt32(42703);
			PaymentStubStartDateAdjusted = view.GetDateOnly(42704);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "PaymentStubStartDateUnadjusted":
				{
					value = PaymentStubStartDateUnadjusted;
					break;
				}
				case "PaymentStubStartDateBusinessDayConvention":
				{
					value = PaymentStubStartDateBusinessDayConvention;
					break;
				}
				case "PaymentStubStartDateBusinessCenterGrp":
				{
					value = PaymentStubStartDateBusinessCenterGrp;
					break;
				}
				case "PaymentStubStartDateRelativeTo":
				{
					value = PaymentStubStartDateRelativeTo;
					break;
				}
				case "PaymentStubStartDateOffsetPeriod":
				{
					value = PaymentStubStartDateOffsetPeriod;
					break;
				}
				case "PaymentStubStartDateOffsetUnit":
				{
					value = PaymentStubStartDateOffsetUnit;
					break;
				}
				case "PaymentStubStartDateOffsetDayType":
				{
					value = PaymentStubStartDateOffsetDayType;
					break;
				}
				case "PaymentStubStartDateAdjusted":
				{
					value = PaymentStubStartDateAdjusted;
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
			PaymentStubStartDateUnadjusted = null;
			PaymentStubStartDateBusinessDayConvention = null;
			((IFixReset?)PaymentStubStartDateBusinessCenterGrp)?.Reset();
			PaymentStubStartDateRelativeTo = null;
			PaymentStubStartDateOffsetPeriod = null;
			PaymentStubStartDateOffsetUnit = null;
			PaymentStubStartDateOffsetDayType = null;
			PaymentStubStartDateAdjusted = null;
		}
	}
}
