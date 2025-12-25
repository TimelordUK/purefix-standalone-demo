using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStreamNonDeliverableSettlTerms : IFixComponent
	{
		[TagDetails(Tag = 40359, Type = TagType.String, Offset = 0, Required = false)]
		public string? LegPaymentStreamNonDeliverableRefCurrency {get; set;}
		
		[TagDetails(Tag = 40360, Type = TagType.Int, Offset = 1, Required = false)]
		public int? LegPaymentStreamNonDeliverableFixingDatesBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public LegPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp? LegPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40362, Type = TagType.Int, Offset = 3, Required = false)]
		public int? LegPaymentStreamNonDeliverableFixingDatesRelativeTo {get; set;}
		
		[TagDetails(Tag = 40363, Type = TagType.Int, Offset = 4, Required = false)]
		public int? LegPaymentStreamNonDeliverableFixingDatesOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40364, Type = TagType.String, Offset = 5, Required = false)]
		public string? LegPaymentStreamNonDeliverableFixingDatesOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40365, Type = TagType.Int, Offset = 6, Required = false)]
		public int? LegPaymentStreamNonDeliverableFixingDatesOffsetDayType {get; set;}
		
		[Component(Offset = 7, Required = false)]
		public LegPaymentStreamNonDeliverableSettlRateSource? LegPaymentStreamNonDeliverableSettlRateSource {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public LegPaymentStreamNonDeliverableFixingDateGrp? LegPaymentStreamNonDeliverableFixingDateGrp {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public LegSettlRateDisruptionFallbackGrp? LegSettlRateDisruptionFallbackGrp {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStreamNonDeliverableRefCurrency is not null) writer.WriteString(40359, LegPaymentStreamNonDeliverableRefCurrency);
			if (LegPaymentStreamNonDeliverableFixingDatesBusinessDayConvention is not null) writer.WriteWholeNumber(40360, LegPaymentStreamNonDeliverableFixingDatesBusinessDayConvention.Value);
			if (LegPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp is not null) ((IFixEncoder)LegPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp).Encode(writer);
			if (LegPaymentStreamNonDeliverableFixingDatesRelativeTo is not null) writer.WriteWholeNumber(40362, LegPaymentStreamNonDeliverableFixingDatesRelativeTo.Value);
			if (LegPaymentStreamNonDeliverableFixingDatesOffsetPeriod is not null) writer.WriteWholeNumber(40363, LegPaymentStreamNonDeliverableFixingDatesOffsetPeriod.Value);
			if (LegPaymentStreamNonDeliverableFixingDatesOffsetUnit is not null) writer.WriteString(40364, LegPaymentStreamNonDeliverableFixingDatesOffsetUnit);
			if (LegPaymentStreamNonDeliverableFixingDatesOffsetDayType is not null) writer.WriteWholeNumber(40365, LegPaymentStreamNonDeliverableFixingDatesOffsetDayType.Value);
			if (LegPaymentStreamNonDeliverableSettlRateSource is not null) ((IFixEncoder)LegPaymentStreamNonDeliverableSettlRateSource).Encode(writer);
			if (LegPaymentStreamNonDeliverableFixingDateGrp is not null) ((IFixEncoder)LegPaymentStreamNonDeliverableFixingDateGrp).Encode(writer);
			if (LegSettlRateDisruptionFallbackGrp is not null) ((IFixEncoder)LegSettlRateDisruptionFallbackGrp).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegPaymentStreamNonDeliverableRefCurrency = view.GetString(40359);
			LegPaymentStreamNonDeliverableFixingDatesBusinessDayConvention = view.GetInt32(40360);
			if (view.GetView("LegPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp") is IMessageView viewLegPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp)
			{
				LegPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp = new();
				((IFixParser)LegPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp).Parse(viewLegPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp);
			}
			LegPaymentStreamNonDeliverableFixingDatesRelativeTo = view.GetInt32(40362);
			LegPaymentStreamNonDeliverableFixingDatesOffsetPeriod = view.GetInt32(40363);
			LegPaymentStreamNonDeliverableFixingDatesOffsetUnit = view.GetString(40364);
			LegPaymentStreamNonDeliverableFixingDatesOffsetDayType = view.GetInt32(40365);
			if (view.GetView("LegPaymentStreamNonDeliverableSettlRateSource") is IMessageView viewLegPaymentStreamNonDeliverableSettlRateSource)
			{
				LegPaymentStreamNonDeliverableSettlRateSource = new();
				((IFixParser)LegPaymentStreamNonDeliverableSettlRateSource).Parse(viewLegPaymentStreamNonDeliverableSettlRateSource);
			}
			if (view.GetView("LegPaymentStreamNonDeliverableFixingDateGrp") is IMessageView viewLegPaymentStreamNonDeliverableFixingDateGrp)
			{
				LegPaymentStreamNonDeliverableFixingDateGrp = new();
				((IFixParser)LegPaymentStreamNonDeliverableFixingDateGrp).Parse(viewLegPaymentStreamNonDeliverableFixingDateGrp);
			}
			if (view.GetView("LegSettlRateDisruptionFallbackGrp") is IMessageView viewLegSettlRateDisruptionFallbackGrp)
			{
				LegSettlRateDisruptionFallbackGrp = new();
				((IFixParser)LegSettlRateDisruptionFallbackGrp).Parse(viewLegSettlRateDisruptionFallbackGrp);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegPaymentStreamNonDeliverableRefCurrency":
				{
					value = LegPaymentStreamNonDeliverableRefCurrency;
					break;
				}
				case "LegPaymentStreamNonDeliverableFixingDatesBusinessDayConvention":
				{
					value = LegPaymentStreamNonDeliverableFixingDatesBusinessDayConvention;
					break;
				}
				case "LegPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp":
				{
					value = LegPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp;
					break;
				}
				case "LegPaymentStreamNonDeliverableFixingDatesRelativeTo":
				{
					value = LegPaymentStreamNonDeliverableFixingDatesRelativeTo;
					break;
				}
				case "LegPaymentStreamNonDeliverableFixingDatesOffsetPeriod":
				{
					value = LegPaymentStreamNonDeliverableFixingDatesOffsetPeriod;
					break;
				}
				case "LegPaymentStreamNonDeliverableFixingDatesOffsetUnit":
				{
					value = LegPaymentStreamNonDeliverableFixingDatesOffsetUnit;
					break;
				}
				case "LegPaymentStreamNonDeliverableFixingDatesOffsetDayType":
				{
					value = LegPaymentStreamNonDeliverableFixingDatesOffsetDayType;
					break;
				}
				case "LegPaymentStreamNonDeliverableSettlRateSource":
				{
					value = LegPaymentStreamNonDeliverableSettlRateSource;
					break;
				}
				case "LegPaymentStreamNonDeliverableFixingDateGrp":
				{
					value = LegPaymentStreamNonDeliverableFixingDateGrp;
					break;
				}
				case "LegSettlRateDisruptionFallbackGrp":
				{
					value = LegSettlRateDisruptionFallbackGrp;
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
			LegPaymentStreamNonDeliverableRefCurrency = null;
			LegPaymentStreamNonDeliverableFixingDatesBusinessDayConvention = null;
			((IFixReset?)LegPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp)?.Reset();
			LegPaymentStreamNonDeliverableFixingDatesRelativeTo = null;
			LegPaymentStreamNonDeliverableFixingDatesOffsetPeriod = null;
			LegPaymentStreamNonDeliverableFixingDatesOffsetUnit = null;
			LegPaymentStreamNonDeliverableFixingDatesOffsetDayType = null;
			((IFixReset?)LegPaymentStreamNonDeliverableSettlRateSource)?.Reset();
			((IFixReset?)LegPaymentStreamNonDeliverableFixingDateGrp)?.Reset();
			((IFixReset?)LegSettlRateDisruptionFallbackGrp)?.Reset();
		}
	}
}
