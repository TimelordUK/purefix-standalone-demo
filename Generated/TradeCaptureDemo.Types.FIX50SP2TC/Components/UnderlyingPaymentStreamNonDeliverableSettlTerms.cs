using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStreamNonDeliverableSettlTerms : IFixComponent
	{
		[TagDetails(Tag = 40648, Type = TagType.String, Offset = 0, Required = false)]
		public string? UnderlyingPaymentStreamNonDeliverableRefCurrency {get; set;}
		
		[TagDetails(Tag = 40649, Type = TagType.Int, Offset = 1, Required = false)]
		public int? UnderlyingPaymentStreamNonDeliverableFixingDatesBizDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public UnderlyingPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp? UnderlyingPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40651, Type = TagType.Int, Offset = 3, Required = false)]
		public int? UnderlyingPaymentStreamNonDeliverableFixingDatesRelativeTo {get; set;}
		
		[TagDetails(Tag = 40652, Type = TagType.Int, Offset = 4, Required = false)]
		public int? UnderlyingPaymentStreamNonDeliverableFixingDatesOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40653, Type = TagType.String, Offset = 5, Required = false)]
		public string? UnderlyingPaymentStreamNonDeliverableFixingDatesOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40654, Type = TagType.Int, Offset = 6, Required = false)]
		public int? UnderlyingPaymentStreamNonDeliverableFixingDatesOffsetDayType {get; set;}
		
		[Component(Offset = 7, Required = false)]
		public UnderlyingPaymentStreamNonDeliverableSettlRateSource? UnderlyingPaymentStreamNonDeliverableSettlRateSource {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public UnderlyingPaymentStreamNonDeliverableFixingDateGrp? UnderlyingPaymentStreamNonDeliverableFixingDateGrp {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public UnderlyingSettlRateDisruptionFallbackGrp? UnderlyingSettlRateDisruptionFallbackGrp {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStreamNonDeliverableRefCurrency is not null) writer.WriteString(40648, UnderlyingPaymentStreamNonDeliverableRefCurrency);
			if (UnderlyingPaymentStreamNonDeliverableFixingDatesBizDayConvention is not null) writer.WriteWholeNumber(40649, UnderlyingPaymentStreamNonDeliverableFixingDatesBizDayConvention.Value);
			if (UnderlyingPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp).Encode(writer);
			if (UnderlyingPaymentStreamNonDeliverableFixingDatesRelativeTo is not null) writer.WriteWholeNumber(40651, UnderlyingPaymentStreamNonDeliverableFixingDatesRelativeTo.Value);
			if (UnderlyingPaymentStreamNonDeliverableFixingDatesOffsetPeriod is not null) writer.WriteWholeNumber(40652, UnderlyingPaymentStreamNonDeliverableFixingDatesOffsetPeriod.Value);
			if (UnderlyingPaymentStreamNonDeliverableFixingDatesOffsetUnit is not null) writer.WriteString(40653, UnderlyingPaymentStreamNonDeliverableFixingDatesOffsetUnit);
			if (UnderlyingPaymentStreamNonDeliverableFixingDatesOffsetDayType is not null) writer.WriteWholeNumber(40654, UnderlyingPaymentStreamNonDeliverableFixingDatesOffsetDayType.Value);
			if (UnderlyingPaymentStreamNonDeliverableSettlRateSource is not null) ((IFixEncoder)UnderlyingPaymentStreamNonDeliverableSettlRateSource).Encode(writer);
			if (UnderlyingPaymentStreamNonDeliverableFixingDateGrp is not null) ((IFixEncoder)UnderlyingPaymentStreamNonDeliverableFixingDateGrp).Encode(writer);
			if (UnderlyingSettlRateDisruptionFallbackGrp is not null) ((IFixEncoder)UnderlyingSettlRateDisruptionFallbackGrp).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingPaymentStreamNonDeliverableRefCurrency = view.GetString(40648);
			UnderlyingPaymentStreamNonDeliverableFixingDatesBizDayConvention = view.GetInt32(40649);
			if (view.GetView("UnderlyingPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp") is IMessageView viewUnderlyingPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp)
			{
				UnderlyingPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp = new();
				((IFixParser)UnderlyingPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp).Parse(viewUnderlyingPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp);
			}
			UnderlyingPaymentStreamNonDeliverableFixingDatesRelativeTo = view.GetInt32(40651);
			UnderlyingPaymentStreamNonDeliverableFixingDatesOffsetPeriod = view.GetInt32(40652);
			UnderlyingPaymentStreamNonDeliverableFixingDatesOffsetUnit = view.GetString(40653);
			UnderlyingPaymentStreamNonDeliverableFixingDatesOffsetDayType = view.GetInt32(40654);
			if (view.GetView("UnderlyingPaymentStreamNonDeliverableSettlRateSource") is IMessageView viewUnderlyingPaymentStreamNonDeliverableSettlRateSource)
			{
				UnderlyingPaymentStreamNonDeliverableSettlRateSource = new();
				((IFixParser)UnderlyingPaymentStreamNonDeliverableSettlRateSource).Parse(viewUnderlyingPaymentStreamNonDeliverableSettlRateSource);
			}
			if (view.GetView("UnderlyingPaymentStreamNonDeliverableFixingDateGrp") is IMessageView viewUnderlyingPaymentStreamNonDeliverableFixingDateGrp)
			{
				UnderlyingPaymentStreamNonDeliverableFixingDateGrp = new();
				((IFixParser)UnderlyingPaymentStreamNonDeliverableFixingDateGrp).Parse(viewUnderlyingPaymentStreamNonDeliverableFixingDateGrp);
			}
			if (view.GetView("UnderlyingSettlRateDisruptionFallbackGrp") is IMessageView viewUnderlyingSettlRateDisruptionFallbackGrp)
			{
				UnderlyingSettlRateDisruptionFallbackGrp = new();
				((IFixParser)UnderlyingSettlRateDisruptionFallbackGrp).Parse(viewUnderlyingSettlRateDisruptionFallbackGrp);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingPaymentStreamNonDeliverableRefCurrency":
				{
					value = UnderlyingPaymentStreamNonDeliverableRefCurrency;
					break;
				}
				case "UnderlyingPaymentStreamNonDeliverableFixingDatesBizDayConvention":
				{
					value = UnderlyingPaymentStreamNonDeliverableFixingDatesBizDayConvention;
					break;
				}
				case "UnderlyingPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp":
				{
					value = UnderlyingPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp;
					break;
				}
				case "UnderlyingPaymentStreamNonDeliverableFixingDatesRelativeTo":
				{
					value = UnderlyingPaymentStreamNonDeliverableFixingDatesRelativeTo;
					break;
				}
				case "UnderlyingPaymentStreamNonDeliverableFixingDatesOffsetPeriod":
				{
					value = UnderlyingPaymentStreamNonDeliverableFixingDatesOffsetPeriod;
					break;
				}
				case "UnderlyingPaymentStreamNonDeliverableFixingDatesOffsetUnit":
				{
					value = UnderlyingPaymentStreamNonDeliverableFixingDatesOffsetUnit;
					break;
				}
				case "UnderlyingPaymentStreamNonDeliverableFixingDatesOffsetDayType":
				{
					value = UnderlyingPaymentStreamNonDeliverableFixingDatesOffsetDayType;
					break;
				}
				case "UnderlyingPaymentStreamNonDeliverableSettlRateSource":
				{
					value = UnderlyingPaymentStreamNonDeliverableSettlRateSource;
					break;
				}
				case "UnderlyingPaymentStreamNonDeliverableFixingDateGrp":
				{
					value = UnderlyingPaymentStreamNonDeliverableFixingDateGrp;
					break;
				}
				case "UnderlyingSettlRateDisruptionFallbackGrp":
				{
					value = UnderlyingSettlRateDisruptionFallbackGrp;
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
			UnderlyingPaymentStreamNonDeliverableRefCurrency = null;
			UnderlyingPaymentStreamNonDeliverableFixingDatesBizDayConvention = null;
			((IFixReset?)UnderlyingPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp)?.Reset();
			UnderlyingPaymentStreamNonDeliverableFixingDatesRelativeTo = null;
			UnderlyingPaymentStreamNonDeliverableFixingDatesOffsetPeriod = null;
			UnderlyingPaymentStreamNonDeliverableFixingDatesOffsetUnit = null;
			UnderlyingPaymentStreamNonDeliverableFixingDatesOffsetDayType = null;
			((IFixReset?)UnderlyingPaymentStreamNonDeliverableSettlRateSource)?.Reset();
			((IFixReset?)UnderlyingPaymentStreamNonDeliverableFixingDateGrp)?.Reset();
			((IFixReset?)UnderlyingSettlRateDisruptionFallbackGrp)?.Reset();
		}
	}
}
