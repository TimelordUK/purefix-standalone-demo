using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStubEndDate : IFixComponent
	{
		[TagDetails(Tag = 42689, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? PaymentStubEndDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42690, Type = TagType.Int, Offset = 1, Required = false)]
		public int? PaymentStubEndDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public PaymentStubEndDateBusinessCenterGrp? PaymentStubEndDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 42691, Type = TagType.Int, Offset = 3, Required = false)]
		public int? PaymentStubEndDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42692, Type = TagType.Int, Offset = 4, Required = false)]
		public int? PaymentStubEndDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42693, Type = TagType.String, Offset = 5, Required = false)]
		public string? PaymentStubEndDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42694, Type = TagType.Int, Offset = 6, Required = false)]
		public int? PaymentStubEndDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42695, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? PaymentStubEndDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStubEndDateUnadjusted is not null) writer.WriteLocalDateOnly(42689, PaymentStubEndDateUnadjusted.Value);
			if (PaymentStubEndDateBusinessDayConvention is not null) writer.WriteWholeNumber(42690, PaymentStubEndDateBusinessDayConvention.Value);
			if (PaymentStubEndDateBusinessCenterGrp is not null) ((IFixEncoder)PaymentStubEndDateBusinessCenterGrp).Encode(writer);
			if (PaymentStubEndDateRelativeTo is not null) writer.WriteWholeNumber(42691, PaymentStubEndDateRelativeTo.Value);
			if (PaymentStubEndDateOffsetPeriod is not null) writer.WriteWholeNumber(42692, PaymentStubEndDateOffsetPeriod.Value);
			if (PaymentStubEndDateOffsetUnit is not null) writer.WriteString(42693, PaymentStubEndDateOffsetUnit);
			if (PaymentStubEndDateOffsetDayType is not null) writer.WriteWholeNumber(42694, PaymentStubEndDateOffsetDayType.Value);
			if (PaymentStubEndDateAdjusted is not null) writer.WriteLocalDateOnly(42695, PaymentStubEndDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			PaymentStubEndDateUnadjusted = view.GetDateOnly(42689);
			PaymentStubEndDateBusinessDayConvention = view.GetInt32(42690);
			if (view.GetView("PaymentStubEndDateBusinessCenterGrp") is IMessageView viewPaymentStubEndDateBusinessCenterGrp)
			{
				PaymentStubEndDateBusinessCenterGrp = new();
				((IFixParser)PaymentStubEndDateBusinessCenterGrp).Parse(viewPaymentStubEndDateBusinessCenterGrp);
			}
			PaymentStubEndDateRelativeTo = view.GetInt32(42691);
			PaymentStubEndDateOffsetPeriod = view.GetInt32(42692);
			PaymentStubEndDateOffsetUnit = view.GetString(42693);
			PaymentStubEndDateOffsetDayType = view.GetInt32(42694);
			PaymentStubEndDateAdjusted = view.GetDateOnly(42695);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "PaymentStubEndDateUnadjusted":
				{
					value = PaymentStubEndDateUnadjusted;
					break;
				}
				case "PaymentStubEndDateBusinessDayConvention":
				{
					value = PaymentStubEndDateBusinessDayConvention;
					break;
				}
				case "PaymentStubEndDateBusinessCenterGrp":
				{
					value = PaymentStubEndDateBusinessCenterGrp;
					break;
				}
				case "PaymentStubEndDateRelativeTo":
				{
					value = PaymentStubEndDateRelativeTo;
					break;
				}
				case "PaymentStubEndDateOffsetPeriod":
				{
					value = PaymentStubEndDateOffsetPeriod;
					break;
				}
				case "PaymentStubEndDateOffsetUnit":
				{
					value = PaymentStubEndDateOffsetUnit;
					break;
				}
				case "PaymentStubEndDateOffsetDayType":
				{
					value = PaymentStubEndDateOffsetDayType;
					break;
				}
				case "PaymentStubEndDateAdjusted":
				{
					value = PaymentStubEndDateAdjusted;
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
			PaymentStubEndDateUnadjusted = null;
			PaymentStubEndDateBusinessDayConvention = null;
			((IFixReset?)PaymentStubEndDateBusinessCenterGrp)?.Reset();
			PaymentStubEndDateRelativeTo = null;
			PaymentStubEndDateOffsetPeriod = null;
			PaymentStubEndDateOffsetUnit = null;
			PaymentStubEndDateOffsetDayType = null;
			PaymentStubEndDateAdjusted = null;
		}
	}
}
