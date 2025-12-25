using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStreamCompoundingDates : IFixComponent
	{
		[TagDetails(Tag = 42609, Type = TagType.Int, Offset = 0, Required = false)]
		public int? PaymentStreamCompoundingDatesBusinessDayConvention {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public PaymentStreamCompoundingDatesBusinessCenterGrp? PaymentStreamCompoundingDatesBusinessCenterGrp {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public PaymentStreamCompoundingDateGrp? PaymentStreamCompoundingDateGrp {get; set;}
		
		[TagDetails(Tag = 42610, Type = TagType.Int, Offset = 3, Required = false)]
		public int? PaymentStreamCompoundingDatesRelativeTo {get; set;}
		
		[TagDetails(Tag = 42611, Type = TagType.Int, Offset = 4, Required = false)]
		public int? PaymentStreamCompoundingDatesOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42612, Type = TagType.String, Offset = 5, Required = false)]
		public string? PaymentStreamCompoundingDatesOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42613, Type = TagType.Int, Offset = 6, Required = false)]
		public int? PaymentStreamCompoundingDatesOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42614, Type = TagType.Int, Offset = 7, Required = false)]
		public int? PaymentStreamCompoundingPeriodSkip {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public PaymentStreamCompoundingStartDate? PaymentStreamCompoundingStartDate {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public PaymentStreamCompoundingEndDate? PaymentStreamCompoundingEndDate {get; set;}
		
		[TagDetails(Tag = 42615, Type = TagType.Int, Offset = 10, Required = false)]
		public int? PaymentStreamCompoundingFrequencyPeriod {get; set;}
		
		[TagDetails(Tag = 42616, Type = TagType.String, Offset = 11, Required = false)]
		public string? PaymentStreamCompoundingFrequencyUnit {get; set;}
		
		[TagDetails(Tag = 42617, Type = TagType.String, Offset = 12, Required = false)]
		public string? PaymentStreamCompoundingRollConvention {get; set;}
		
		[TagDetails(Tag = 42618, Type = TagType.LocalDate, Offset = 13, Required = false)]
		public DateOnly? PaymentStreamBoundsFirstDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42619, Type = TagType.LocalDate, Offset = 14, Required = false)]
		public DateOnly? PaymentStreamBoundsLastDateUnadjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStreamCompoundingDatesBusinessDayConvention is not null) writer.WriteWholeNumber(42609, PaymentStreamCompoundingDatesBusinessDayConvention.Value);
			if (PaymentStreamCompoundingDatesBusinessCenterGrp is not null) ((IFixEncoder)PaymentStreamCompoundingDatesBusinessCenterGrp).Encode(writer);
			if (PaymentStreamCompoundingDateGrp is not null) ((IFixEncoder)PaymentStreamCompoundingDateGrp).Encode(writer);
			if (PaymentStreamCompoundingDatesRelativeTo is not null) writer.WriteWholeNumber(42610, PaymentStreamCompoundingDatesRelativeTo.Value);
			if (PaymentStreamCompoundingDatesOffsetPeriod is not null) writer.WriteWholeNumber(42611, PaymentStreamCompoundingDatesOffsetPeriod.Value);
			if (PaymentStreamCompoundingDatesOffsetUnit is not null) writer.WriteString(42612, PaymentStreamCompoundingDatesOffsetUnit);
			if (PaymentStreamCompoundingDatesOffsetDayType is not null) writer.WriteWholeNumber(42613, PaymentStreamCompoundingDatesOffsetDayType.Value);
			if (PaymentStreamCompoundingPeriodSkip is not null) writer.WriteWholeNumber(42614, PaymentStreamCompoundingPeriodSkip.Value);
			if (PaymentStreamCompoundingStartDate is not null) ((IFixEncoder)PaymentStreamCompoundingStartDate).Encode(writer);
			if (PaymentStreamCompoundingEndDate is not null) ((IFixEncoder)PaymentStreamCompoundingEndDate).Encode(writer);
			if (PaymentStreamCompoundingFrequencyPeriod is not null) writer.WriteWholeNumber(42615, PaymentStreamCompoundingFrequencyPeriod.Value);
			if (PaymentStreamCompoundingFrequencyUnit is not null) writer.WriteString(42616, PaymentStreamCompoundingFrequencyUnit);
			if (PaymentStreamCompoundingRollConvention is not null) writer.WriteString(42617, PaymentStreamCompoundingRollConvention);
			if (PaymentStreamBoundsFirstDateUnadjusted is not null) writer.WriteLocalDateOnly(42618, PaymentStreamBoundsFirstDateUnadjusted.Value);
			if (PaymentStreamBoundsLastDateUnadjusted is not null) writer.WriteLocalDateOnly(42619, PaymentStreamBoundsLastDateUnadjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			PaymentStreamCompoundingDatesBusinessDayConvention = view.GetInt32(42609);
			if (view.GetView("PaymentStreamCompoundingDatesBusinessCenterGrp") is IMessageView viewPaymentStreamCompoundingDatesBusinessCenterGrp)
			{
				PaymentStreamCompoundingDatesBusinessCenterGrp = new();
				((IFixParser)PaymentStreamCompoundingDatesBusinessCenterGrp).Parse(viewPaymentStreamCompoundingDatesBusinessCenterGrp);
			}
			if (view.GetView("PaymentStreamCompoundingDateGrp") is IMessageView viewPaymentStreamCompoundingDateGrp)
			{
				PaymentStreamCompoundingDateGrp = new();
				((IFixParser)PaymentStreamCompoundingDateGrp).Parse(viewPaymentStreamCompoundingDateGrp);
			}
			PaymentStreamCompoundingDatesRelativeTo = view.GetInt32(42610);
			PaymentStreamCompoundingDatesOffsetPeriod = view.GetInt32(42611);
			PaymentStreamCompoundingDatesOffsetUnit = view.GetString(42612);
			PaymentStreamCompoundingDatesOffsetDayType = view.GetInt32(42613);
			PaymentStreamCompoundingPeriodSkip = view.GetInt32(42614);
			if (view.GetView("PaymentStreamCompoundingStartDate") is IMessageView viewPaymentStreamCompoundingStartDate)
			{
				PaymentStreamCompoundingStartDate = new();
				((IFixParser)PaymentStreamCompoundingStartDate).Parse(viewPaymentStreamCompoundingStartDate);
			}
			if (view.GetView("PaymentStreamCompoundingEndDate") is IMessageView viewPaymentStreamCompoundingEndDate)
			{
				PaymentStreamCompoundingEndDate = new();
				((IFixParser)PaymentStreamCompoundingEndDate).Parse(viewPaymentStreamCompoundingEndDate);
			}
			PaymentStreamCompoundingFrequencyPeriod = view.GetInt32(42615);
			PaymentStreamCompoundingFrequencyUnit = view.GetString(42616);
			PaymentStreamCompoundingRollConvention = view.GetString(42617);
			PaymentStreamBoundsFirstDateUnadjusted = view.GetDateOnly(42618);
			PaymentStreamBoundsLastDateUnadjusted = view.GetDateOnly(42619);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "PaymentStreamCompoundingDatesBusinessDayConvention":
				{
					value = PaymentStreamCompoundingDatesBusinessDayConvention;
					break;
				}
				case "PaymentStreamCompoundingDatesBusinessCenterGrp":
				{
					value = PaymentStreamCompoundingDatesBusinessCenterGrp;
					break;
				}
				case "PaymentStreamCompoundingDateGrp":
				{
					value = PaymentStreamCompoundingDateGrp;
					break;
				}
				case "PaymentStreamCompoundingDatesRelativeTo":
				{
					value = PaymentStreamCompoundingDatesRelativeTo;
					break;
				}
				case "PaymentStreamCompoundingDatesOffsetPeriod":
				{
					value = PaymentStreamCompoundingDatesOffsetPeriod;
					break;
				}
				case "PaymentStreamCompoundingDatesOffsetUnit":
				{
					value = PaymentStreamCompoundingDatesOffsetUnit;
					break;
				}
				case "PaymentStreamCompoundingDatesOffsetDayType":
				{
					value = PaymentStreamCompoundingDatesOffsetDayType;
					break;
				}
				case "PaymentStreamCompoundingPeriodSkip":
				{
					value = PaymentStreamCompoundingPeriodSkip;
					break;
				}
				case "PaymentStreamCompoundingStartDate":
				{
					value = PaymentStreamCompoundingStartDate;
					break;
				}
				case "PaymentStreamCompoundingEndDate":
				{
					value = PaymentStreamCompoundingEndDate;
					break;
				}
				case "PaymentStreamCompoundingFrequencyPeriod":
				{
					value = PaymentStreamCompoundingFrequencyPeriod;
					break;
				}
				case "PaymentStreamCompoundingFrequencyUnit":
				{
					value = PaymentStreamCompoundingFrequencyUnit;
					break;
				}
				case "PaymentStreamCompoundingRollConvention":
				{
					value = PaymentStreamCompoundingRollConvention;
					break;
				}
				case "PaymentStreamBoundsFirstDateUnadjusted":
				{
					value = PaymentStreamBoundsFirstDateUnadjusted;
					break;
				}
				case "PaymentStreamBoundsLastDateUnadjusted":
				{
					value = PaymentStreamBoundsLastDateUnadjusted;
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
			PaymentStreamCompoundingDatesBusinessDayConvention = null;
			((IFixReset?)PaymentStreamCompoundingDatesBusinessCenterGrp)?.Reset();
			((IFixReset?)PaymentStreamCompoundingDateGrp)?.Reset();
			PaymentStreamCompoundingDatesRelativeTo = null;
			PaymentStreamCompoundingDatesOffsetPeriod = null;
			PaymentStreamCompoundingDatesOffsetUnit = null;
			PaymentStreamCompoundingDatesOffsetDayType = null;
			PaymentStreamCompoundingPeriodSkip = null;
			((IFixReset?)PaymentStreamCompoundingStartDate)?.Reset();
			((IFixReset?)PaymentStreamCompoundingEndDate)?.Reset();
			PaymentStreamCompoundingFrequencyPeriod = null;
			PaymentStreamCompoundingFrequencyUnit = null;
			PaymentStreamCompoundingRollConvention = null;
			PaymentStreamBoundsFirstDateUnadjusted = null;
			PaymentStreamBoundsLastDateUnadjusted = null;
		}
	}
}
