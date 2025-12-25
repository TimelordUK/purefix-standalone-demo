using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStreamNonDeliverableSettlTerms : IFixComponent
	{
		[TagDetails(Tag = 40817, Type = TagType.String, Offset = 0, Required = false)]
		public string? PaymentStreamNonDeliverableRefCurrency {get; set;}
		
		[TagDetails(Tag = 40818, Type = TagType.Int, Offset = 1, Required = false)]
		public int? PaymentStreamNonDeliverableFixingDatesBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public PaymentStreamNonDeliverableFixingDatesBusinessCenterGrp? PaymentStreamNonDeliverableFixingDatesBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40820, Type = TagType.Int, Offset = 3, Required = false)]
		public int? PaymentStreamNonDeliverableFixingDatesRelativeTo {get; set;}
		
		[TagDetails(Tag = 40821, Type = TagType.Int, Offset = 4, Required = false)]
		public int? PaymentStreamNonDeliverableFixingDatesOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40822, Type = TagType.String, Offset = 5, Required = false)]
		public string? PaymentStreamNonDeliverableFixingDatesOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40823, Type = TagType.Int, Offset = 6, Required = false)]
		public int? PaymentStreamNonDeliverableFixingDatesOffsetDayType {get; set;}
		
		[Component(Offset = 7, Required = false)]
		public PaymentStreamNonDeliverableSettlRateSource? PaymentStreamNonDeliverableSettlRateSource {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public PaymentStreamNonDeliverableFixingDateGrp? PaymentStreamNonDeliverableFixingDateGrp {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public SettlRateDisruptionFallbackGrp? SettlRateDisruptionFallbackGrp {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStreamNonDeliverableRefCurrency is not null) writer.WriteString(40817, PaymentStreamNonDeliverableRefCurrency);
			if (PaymentStreamNonDeliverableFixingDatesBusinessDayConvention is not null) writer.WriteWholeNumber(40818, PaymentStreamNonDeliverableFixingDatesBusinessDayConvention.Value);
			if (PaymentStreamNonDeliverableFixingDatesBusinessCenterGrp is not null) ((IFixEncoder)PaymentStreamNonDeliverableFixingDatesBusinessCenterGrp).Encode(writer);
			if (PaymentStreamNonDeliverableFixingDatesRelativeTo is not null) writer.WriteWholeNumber(40820, PaymentStreamNonDeliverableFixingDatesRelativeTo.Value);
			if (PaymentStreamNonDeliverableFixingDatesOffsetPeriod is not null) writer.WriteWholeNumber(40821, PaymentStreamNonDeliverableFixingDatesOffsetPeriod.Value);
			if (PaymentStreamNonDeliverableFixingDatesOffsetUnit is not null) writer.WriteString(40822, PaymentStreamNonDeliverableFixingDatesOffsetUnit);
			if (PaymentStreamNonDeliverableFixingDatesOffsetDayType is not null) writer.WriteWholeNumber(40823, PaymentStreamNonDeliverableFixingDatesOffsetDayType.Value);
			if (PaymentStreamNonDeliverableSettlRateSource is not null) ((IFixEncoder)PaymentStreamNonDeliverableSettlRateSource).Encode(writer);
			if (PaymentStreamNonDeliverableFixingDateGrp is not null) ((IFixEncoder)PaymentStreamNonDeliverableFixingDateGrp).Encode(writer);
			if (SettlRateDisruptionFallbackGrp is not null) ((IFixEncoder)SettlRateDisruptionFallbackGrp).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			PaymentStreamNonDeliverableRefCurrency = view.GetString(40817);
			PaymentStreamNonDeliverableFixingDatesBusinessDayConvention = view.GetInt32(40818);
			if (view.GetView("PaymentStreamNonDeliverableFixingDatesBusinessCenterGrp") is IMessageView viewPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp)
			{
				PaymentStreamNonDeliverableFixingDatesBusinessCenterGrp = new();
				((IFixParser)PaymentStreamNonDeliverableFixingDatesBusinessCenterGrp).Parse(viewPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp);
			}
			PaymentStreamNonDeliverableFixingDatesRelativeTo = view.GetInt32(40820);
			PaymentStreamNonDeliverableFixingDatesOffsetPeriod = view.GetInt32(40821);
			PaymentStreamNonDeliverableFixingDatesOffsetUnit = view.GetString(40822);
			PaymentStreamNonDeliverableFixingDatesOffsetDayType = view.GetInt32(40823);
			if (view.GetView("PaymentStreamNonDeliverableSettlRateSource") is IMessageView viewPaymentStreamNonDeliverableSettlRateSource)
			{
				PaymentStreamNonDeliverableSettlRateSource = new();
				((IFixParser)PaymentStreamNonDeliverableSettlRateSource).Parse(viewPaymentStreamNonDeliverableSettlRateSource);
			}
			if (view.GetView("PaymentStreamNonDeliverableFixingDateGrp") is IMessageView viewPaymentStreamNonDeliverableFixingDateGrp)
			{
				PaymentStreamNonDeliverableFixingDateGrp = new();
				((IFixParser)PaymentStreamNonDeliverableFixingDateGrp).Parse(viewPaymentStreamNonDeliverableFixingDateGrp);
			}
			if (view.GetView("SettlRateDisruptionFallbackGrp") is IMessageView viewSettlRateDisruptionFallbackGrp)
			{
				SettlRateDisruptionFallbackGrp = new();
				((IFixParser)SettlRateDisruptionFallbackGrp).Parse(viewSettlRateDisruptionFallbackGrp);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "PaymentStreamNonDeliverableRefCurrency":
				{
					value = PaymentStreamNonDeliverableRefCurrency;
					break;
				}
				case "PaymentStreamNonDeliverableFixingDatesBusinessDayConvention":
				{
					value = PaymentStreamNonDeliverableFixingDatesBusinessDayConvention;
					break;
				}
				case "PaymentStreamNonDeliverableFixingDatesBusinessCenterGrp":
				{
					value = PaymentStreamNonDeliverableFixingDatesBusinessCenterGrp;
					break;
				}
				case "PaymentStreamNonDeliverableFixingDatesRelativeTo":
				{
					value = PaymentStreamNonDeliverableFixingDatesRelativeTo;
					break;
				}
				case "PaymentStreamNonDeliverableFixingDatesOffsetPeriod":
				{
					value = PaymentStreamNonDeliverableFixingDatesOffsetPeriod;
					break;
				}
				case "PaymentStreamNonDeliverableFixingDatesOffsetUnit":
				{
					value = PaymentStreamNonDeliverableFixingDatesOffsetUnit;
					break;
				}
				case "PaymentStreamNonDeliverableFixingDatesOffsetDayType":
				{
					value = PaymentStreamNonDeliverableFixingDatesOffsetDayType;
					break;
				}
				case "PaymentStreamNonDeliverableSettlRateSource":
				{
					value = PaymentStreamNonDeliverableSettlRateSource;
					break;
				}
				case "PaymentStreamNonDeliverableFixingDateGrp":
				{
					value = PaymentStreamNonDeliverableFixingDateGrp;
					break;
				}
				case "SettlRateDisruptionFallbackGrp":
				{
					value = SettlRateDisruptionFallbackGrp;
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
			PaymentStreamNonDeliverableRefCurrency = null;
			PaymentStreamNonDeliverableFixingDatesBusinessDayConvention = null;
			((IFixReset?)PaymentStreamNonDeliverableFixingDatesBusinessCenterGrp)?.Reset();
			PaymentStreamNonDeliverableFixingDatesRelativeTo = null;
			PaymentStreamNonDeliverableFixingDatesOffsetPeriod = null;
			PaymentStreamNonDeliverableFixingDatesOffsetUnit = null;
			PaymentStreamNonDeliverableFixingDatesOffsetDayType = null;
			((IFixReset?)PaymentStreamNonDeliverableSettlRateSource)?.Reset();
			((IFixReset?)PaymentStreamNonDeliverableFixingDateGrp)?.Reset();
			((IFixReset?)SettlRateDisruptionFallbackGrp)?.Reset();
		}
	}
}
