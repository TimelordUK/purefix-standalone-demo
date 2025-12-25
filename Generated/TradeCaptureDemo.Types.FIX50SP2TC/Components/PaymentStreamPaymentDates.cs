using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStreamPaymentDates : IFixComponent
	{
		[TagDetails(Tag = 40751, Type = TagType.Int, Offset = 0, Required = false)]
		public int? PaymentStreamPaymentDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public PaymentStreamPaymentDateBusinessCenterGrp? PaymentStreamPaymentDateBusinessCenterGrp {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public PaymentStreamPaymentDateGrp? PaymentStreamPaymentDateGrp {get; set;}
		
		[TagDetails(Tag = 40753, Type = TagType.Int, Offset = 3, Required = false)]
		public int? PaymentStreamPaymentFrequencyPeriod {get; set;}
		
		[TagDetails(Tag = 40754, Type = TagType.String, Offset = 4, Required = false)]
		public string? PaymentStreamPaymentFrequencyUnit {get; set;}
		
		[TagDetails(Tag = 40755, Type = TagType.String, Offset = 5, Required = false)]
		public string? PaymentStreamPaymentRollConvention {get; set;}
		
		[TagDetails(Tag = 40756, Type = TagType.LocalDate, Offset = 6, Required = false)]
		public DateOnly? PaymentStreamFirstPaymentDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40757, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? PaymentStreamLastRegularPaymentDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40758, Type = TagType.Int, Offset = 8, Required = false)]
		public int? PaymentStreamPaymentDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40759, Type = TagType.Int, Offset = 9, Required = false)]
		public int? PaymentStreamPaymentDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40760, Type = TagType.String, Offset = 10, Required = false)]
		public string? PaymentStreamPaymentDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40920, Type = TagType.Int, Offset = 11, Required = false)]
		public int? PaymentStreamPaymentDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 41223, Type = TagType.Boolean, Offset = 12, Required = false)]
		public bool? PaymentStreamMasterAgreementPaymentDatesIndicator {get; set;}
		
		[Component(Offset = 13, Required = false)]
		public PaymentStreamFinalPricePaymentDate? PaymentStreamFinalPricePaymentDate {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStreamPaymentDateBusinessDayConvention is not null) writer.WriteWholeNumber(40751, PaymentStreamPaymentDateBusinessDayConvention.Value);
			if (PaymentStreamPaymentDateBusinessCenterGrp is not null) ((IFixEncoder)PaymentStreamPaymentDateBusinessCenterGrp).Encode(writer);
			if (PaymentStreamPaymentDateGrp is not null) ((IFixEncoder)PaymentStreamPaymentDateGrp).Encode(writer);
			if (PaymentStreamPaymentFrequencyPeriod is not null) writer.WriteWholeNumber(40753, PaymentStreamPaymentFrequencyPeriod.Value);
			if (PaymentStreamPaymentFrequencyUnit is not null) writer.WriteString(40754, PaymentStreamPaymentFrequencyUnit);
			if (PaymentStreamPaymentRollConvention is not null) writer.WriteString(40755, PaymentStreamPaymentRollConvention);
			if (PaymentStreamFirstPaymentDateUnadjusted is not null) writer.WriteLocalDateOnly(40756, PaymentStreamFirstPaymentDateUnadjusted.Value);
			if (PaymentStreamLastRegularPaymentDateUnadjusted is not null) writer.WriteLocalDateOnly(40757, PaymentStreamLastRegularPaymentDateUnadjusted.Value);
			if (PaymentStreamPaymentDateRelativeTo is not null) writer.WriteWholeNumber(40758, PaymentStreamPaymentDateRelativeTo.Value);
			if (PaymentStreamPaymentDateOffsetPeriod is not null) writer.WriteWholeNumber(40759, PaymentStreamPaymentDateOffsetPeriod.Value);
			if (PaymentStreamPaymentDateOffsetUnit is not null) writer.WriteString(40760, PaymentStreamPaymentDateOffsetUnit);
			if (PaymentStreamPaymentDateOffsetDayType is not null) writer.WriteWholeNumber(40920, PaymentStreamPaymentDateOffsetDayType.Value);
			if (PaymentStreamMasterAgreementPaymentDatesIndicator is not null) writer.WriteBoolean(41223, PaymentStreamMasterAgreementPaymentDatesIndicator.Value);
			if (PaymentStreamFinalPricePaymentDate is not null) ((IFixEncoder)PaymentStreamFinalPricePaymentDate).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			PaymentStreamPaymentDateBusinessDayConvention = view.GetInt32(40751);
			if (view.GetView("PaymentStreamPaymentDateBusinessCenterGrp") is IMessageView viewPaymentStreamPaymentDateBusinessCenterGrp)
			{
				PaymentStreamPaymentDateBusinessCenterGrp = new();
				((IFixParser)PaymentStreamPaymentDateBusinessCenterGrp).Parse(viewPaymentStreamPaymentDateBusinessCenterGrp);
			}
			if (view.GetView("PaymentStreamPaymentDateGrp") is IMessageView viewPaymentStreamPaymentDateGrp)
			{
				PaymentStreamPaymentDateGrp = new();
				((IFixParser)PaymentStreamPaymentDateGrp).Parse(viewPaymentStreamPaymentDateGrp);
			}
			PaymentStreamPaymentFrequencyPeriod = view.GetInt32(40753);
			PaymentStreamPaymentFrequencyUnit = view.GetString(40754);
			PaymentStreamPaymentRollConvention = view.GetString(40755);
			PaymentStreamFirstPaymentDateUnadjusted = view.GetDateOnly(40756);
			PaymentStreamLastRegularPaymentDateUnadjusted = view.GetDateOnly(40757);
			PaymentStreamPaymentDateRelativeTo = view.GetInt32(40758);
			PaymentStreamPaymentDateOffsetPeriod = view.GetInt32(40759);
			PaymentStreamPaymentDateOffsetUnit = view.GetString(40760);
			PaymentStreamPaymentDateOffsetDayType = view.GetInt32(40920);
			PaymentStreamMasterAgreementPaymentDatesIndicator = view.GetBool(41223);
			if (view.GetView("PaymentStreamFinalPricePaymentDate") is IMessageView viewPaymentStreamFinalPricePaymentDate)
			{
				PaymentStreamFinalPricePaymentDate = new();
				((IFixParser)PaymentStreamFinalPricePaymentDate).Parse(viewPaymentStreamFinalPricePaymentDate);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "PaymentStreamPaymentDateBusinessDayConvention":
				{
					value = PaymentStreamPaymentDateBusinessDayConvention;
					break;
				}
				case "PaymentStreamPaymentDateBusinessCenterGrp":
				{
					value = PaymentStreamPaymentDateBusinessCenterGrp;
					break;
				}
				case "PaymentStreamPaymentDateGrp":
				{
					value = PaymentStreamPaymentDateGrp;
					break;
				}
				case "PaymentStreamPaymentFrequencyPeriod":
				{
					value = PaymentStreamPaymentFrequencyPeriod;
					break;
				}
				case "PaymentStreamPaymentFrequencyUnit":
				{
					value = PaymentStreamPaymentFrequencyUnit;
					break;
				}
				case "PaymentStreamPaymentRollConvention":
				{
					value = PaymentStreamPaymentRollConvention;
					break;
				}
				case "PaymentStreamFirstPaymentDateUnadjusted":
				{
					value = PaymentStreamFirstPaymentDateUnadjusted;
					break;
				}
				case "PaymentStreamLastRegularPaymentDateUnadjusted":
				{
					value = PaymentStreamLastRegularPaymentDateUnadjusted;
					break;
				}
				case "PaymentStreamPaymentDateRelativeTo":
				{
					value = PaymentStreamPaymentDateRelativeTo;
					break;
				}
				case "PaymentStreamPaymentDateOffsetPeriod":
				{
					value = PaymentStreamPaymentDateOffsetPeriod;
					break;
				}
				case "PaymentStreamPaymentDateOffsetUnit":
				{
					value = PaymentStreamPaymentDateOffsetUnit;
					break;
				}
				case "PaymentStreamPaymentDateOffsetDayType":
				{
					value = PaymentStreamPaymentDateOffsetDayType;
					break;
				}
				case "PaymentStreamMasterAgreementPaymentDatesIndicator":
				{
					value = PaymentStreamMasterAgreementPaymentDatesIndicator;
					break;
				}
				case "PaymentStreamFinalPricePaymentDate":
				{
					value = PaymentStreamFinalPricePaymentDate;
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
			PaymentStreamPaymentDateBusinessDayConvention = null;
			((IFixReset?)PaymentStreamPaymentDateBusinessCenterGrp)?.Reset();
			((IFixReset?)PaymentStreamPaymentDateGrp)?.Reset();
			PaymentStreamPaymentFrequencyPeriod = null;
			PaymentStreamPaymentFrequencyUnit = null;
			PaymentStreamPaymentRollConvention = null;
			PaymentStreamFirstPaymentDateUnadjusted = null;
			PaymentStreamLastRegularPaymentDateUnadjusted = null;
			PaymentStreamPaymentDateRelativeTo = null;
			PaymentStreamPaymentDateOffsetPeriod = null;
			PaymentStreamPaymentDateOffsetUnit = null;
			PaymentStreamPaymentDateOffsetDayType = null;
			PaymentStreamMasterAgreementPaymentDatesIndicator = null;
			((IFixReset?)PaymentStreamFinalPricePaymentDate)?.Reset();
		}
	}
}
