using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStreamCompoundingDates : IFixComponent
	{
		[TagDetails(Tag = 42408, Type = TagType.Int, Offset = 0, Required = false)]
		public int? LegPaymentStreamCompoundingDatesBusinessDayConvention {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public LegPaymentStreamCompoundingDatesBusinessCenterGrp? LegPaymentStreamCompoundingDatesBusinessCenterGrp {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public LegPaymentStreamCompoundingDateGrp? LegPaymentStreamCompoundingDateGrp {get; set;}
		
		[TagDetails(Tag = 42409, Type = TagType.Int, Offset = 3, Required = false)]
		public int? LegPaymentStreamCompoundingDatesRelativeTo {get; set;}
		
		[TagDetails(Tag = 42410, Type = TagType.Int, Offset = 4, Required = false)]
		public int? LegPaymentStreamCompoundingDatesOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42411, Type = TagType.String, Offset = 5, Required = false)]
		public string? LegPaymentStreamCompoundingDatesOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42412, Type = TagType.Int, Offset = 6, Required = false)]
		public int? LegPaymentStreamCompoundingDatesOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42413, Type = TagType.Int, Offset = 7, Required = false)]
		public int? LegPaymentStreamCompoundingPeriodSkip {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public LegPaymentStreamCompoundingStartDate? LegPaymentStreamCompoundingStartDate {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public LegPaymentStreamCompoundingEndDate? LegPaymentStreamCompoundingEndDate {get; set;}
		
		[TagDetails(Tag = 42414, Type = TagType.Int, Offset = 10, Required = false)]
		public int? LegPaymentStreamCompoundingFrequencyPeriod {get; set;}
		
		[TagDetails(Tag = 42415, Type = TagType.String, Offset = 11, Required = false)]
		public string? LegPaymentStreamCompoundingFrequencyUnit {get; set;}
		
		[TagDetails(Tag = 42416, Type = TagType.String, Offset = 12, Required = false)]
		public string? LegPaymentStreamCompoundingRollConvention {get; set;}
		
		[TagDetails(Tag = 42417, Type = TagType.LocalDate, Offset = 13, Required = false)]
		public DateOnly? LegPaymentStreamBoundsFirstDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42418, Type = TagType.LocalDate, Offset = 14, Required = false)]
		public DateOnly? LegPaymentStreamBoundsLastDateUnadjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStreamCompoundingDatesBusinessDayConvention is not null) writer.WriteWholeNumber(42408, LegPaymentStreamCompoundingDatesBusinessDayConvention.Value);
			if (LegPaymentStreamCompoundingDatesBusinessCenterGrp is not null) ((IFixEncoder)LegPaymentStreamCompoundingDatesBusinessCenterGrp).Encode(writer);
			if (LegPaymentStreamCompoundingDateGrp is not null) ((IFixEncoder)LegPaymentStreamCompoundingDateGrp).Encode(writer);
			if (LegPaymentStreamCompoundingDatesRelativeTo is not null) writer.WriteWholeNumber(42409, LegPaymentStreamCompoundingDatesRelativeTo.Value);
			if (LegPaymentStreamCompoundingDatesOffsetPeriod is not null) writer.WriteWholeNumber(42410, LegPaymentStreamCompoundingDatesOffsetPeriod.Value);
			if (LegPaymentStreamCompoundingDatesOffsetUnit is not null) writer.WriteString(42411, LegPaymentStreamCompoundingDatesOffsetUnit);
			if (LegPaymentStreamCompoundingDatesOffsetDayType is not null) writer.WriteWholeNumber(42412, LegPaymentStreamCompoundingDatesOffsetDayType.Value);
			if (LegPaymentStreamCompoundingPeriodSkip is not null) writer.WriteWholeNumber(42413, LegPaymentStreamCompoundingPeriodSkip.Value);
			if (LegPaymentStreamCompoundingStartDate is not null) ((IFixEncoder)LegPaymentStreamCompoundingStartDate).Encode(writer);
			if (LegPaymentStreamCompoundingEndDate is not null) ((IFixEncoder)LegPaymentStreamCompoundingEndDate).Encode(writer);
			if (LegPaymentStreamCompoundingFrequencyPeriod is not null) writer.WriteWholeNumber(42414, LegPaymentStreamCompoundingFrequencyPeriod.Value);
			if (LegPaymentStreamCompoundingFrequencyUnit is not null) writer.WriteString(42415, LegPaymentStreamCompoundingFrequencyUnit);
			if (LegPaymentStreamCompoundingRollConvention is not null) writer.WriteString(42416, LegPaymentStreamCompoundingRollConvention);
			if (LegPaymentStreamBoundsFirstDateUnadjusted is not null) writer.WriteLocalDateOnly(42417, LegPaymentStreamBoundsFirstDateUnadjusted.Value);
			if (LegPaymentStreamBoundsLastDateUnadjusted is not null) writer.WriteLocalDateOnly(42418, LegPaymentStreamBoundsLastDateUnadjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegPaymentStreamCompoundingDatesBusinessDayConvention = view.GetInt32(42408);
			if (view.GetView("LegPaymentStreamCompoundingDatesBusinessCenterGrp") is IMessageView viewLegPaymentStreamCompoundingDatesBusinessCenterGrp)
			{
				LegPaymentStreamCompoundingDatesBusinessCenterGrp = new();
				((IFixParser)LegPaymentStreamCompoundingDatesBusinessCenterGrp).Parse(viewLegPaymentStreamCompoundingDatesBusinessCenterGrp);
			}
			if (view.GetView("LegPaymentStreamCompoundingDateGrp") is IMessageView viewLegPaymentStreamCompoundingDateGrp)
			{
				LegPaymentStreamCompoundingDateGrp = new();
				((IFixParser)LegPaymentStreamCompoundingDateGrp).Parse(viewLegPaymentStreamCompoundingDateGrp);
			}
			LegPaymentStreamCompoundingDatesRelativeTo = view.GetInt32(42409);
			LegPaymentStreamCompoundingDatesOffsetPeriod = view.GetInt32(42410);
			LegPaymentStreamCompoundingDatesOffsetUnit = view.GetString(42411);
			LegPaymentStreamCompoundingDatesOffsetDayType = view.GetInt32(42412);
			LegPaymentStreamCompoundingPeriodSkip = view.GetInt32(42413);
			if (view.GetView("LegPaymentStreamCompoundingStartDate") is IMessageView viewLegPaymentStreamCompoundingStartDate)
			{
				LegPaymentStreamCompoundingStartDate = new();
				((IFixParser)LegPaymentStreamCompoundingStartDate).Parse(viewLegPaymentStreamCompoundingStartDate);
			}
			if (view.GetView("LegPaymentStreamCompoundingEndDate") is IMessageView viewLegPaymentStreamCompoundingEndDate)
			{
				LegPaymentStreamCompoundingEndDate = new();
				((IFixParser)LegPaymentStreamCompoundingEndDate).Parse(viewLegPaymentStreamCompoundingEndDate);
			}
			LegPaymentStreamCompoundingFrequencyPeriod = view.GetInt32(42414);
			LegPaymentStreamCompoundingFrequencyUnit = view.GetString(42415);
			LegPaymentStreamCompoundingRollConvention = view.GetString(42416);
			LegPaymentStreamBoundsFirstDateUnadjusted = view.GetDateOnly(42417);
			LegPaymentStreamBoundsLastDateUnadjusted = view.GetDateOnly(42418);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegPaymentStreamCompoundingDatesBusinessDayConvention":
				{
					value = LegPaymentStreamCompoundingDatesBusinessDayConvention;
					break;
				}
				case "LegPaymentStreamCompoundingDatesBusinessCenterGrp":
				{
					value = LegPaymentStreamCompoundingDatesBusinessCenterGrp;
					break;
				}
				case "LegPaymentStreamCompoundingDateGrp":
				{
					value = LegPaymentStreamCompoundingDateGrp;
					break;
				}
				case "LegPaymentStreamCompoundingDatesRelativeTo":
				{
					value = LegPaymentStreamCompoundingDatesRelativeTo;
					break;
				}
				case "LegPaymentStreamCompoundingDatesOffsetPeriod":
				{
					value = LegPaymentStreamCompoundingDatesOffsetPeriod;
					break;
				}
				case "LegPaymentStreamCompoundingDatesOffsetUnit":
				{
					value = LegPaymentStreamCompoundingDatesOffsetUnit;
					break;
				}
				case "LegPaymentStreamCompoundingDatesOffsetDayType":
				{
					value = LegPaymentStreamCompoundingDatesOffsetDayType;
					break;
				}
				case "LegPaymentStreamCompoundingPeriodSkip":
				{
					value = LegPaymentStreamCompoundingPeriodSkip;
					break;
				}
				case "LegPaymentStreamCompoundingStartDate":
				{
					value = LegPaymentStreamCompoundingStartDate;
					break;
				}
				case "LegPaymentStreamCompoundingEndDate":
				{
					value = LegPaymentStreamCompoundingEndDate;
					break;
				}
				case "LegPaymentStreamCompoundingFrequencyPeriod":
				{
					value = LegPaymentStreamCompoundingFrequencyPeriod;
					break;
				}
				case "LegPaymentStreamCompoundingFrequencyUnit":
				{
					value = LegPaymentStreamCompoundingFrequencyUnit;
					break;
				}
				case "LegPaymentStreamCompoundingRollConvention":
				{
					value = LegPaymentStreamCompoundingRollConvention;
					break;
				}
				case "LegPaymentStreamBoundsFirstDateUnadjusted":
				{
					value = LegPaymentStreamBoundsFirstDateUnadjusted;
					break;
				}
				case "LegPaymentStreamBoundsLastDateUnadjusted":
				{
					value = LegPaymentStreamBoundsLastDateUnadjusted;
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
			LegPaymentStreamCompoundingDatesBusinessDayConvention = null;
			((IFixReset?)LegPaymentStreamCompoundingDatesBusinessCenterGrp)?.Reset();
			((IFixReset?)LegPaymentStreamCompoundingDateGrp)?.Reset();
			LegPaymentStreamCompoundingDatesRelativeTo = null;
			LegPaymentStreamCompoundingDatesOffsetPeriod = null;
			LegPaymentStreamCompoundingDatesOffsetUnit = null;
			LegPaymentStreamCompoundingDatesOffsetDayType = null;
			LegPaymentStreamCompoundingPeriodSkip = null;
			((IFixReset?)LegPaymentStreamCompoundingStartDate)?.Reset();
			((IFixReset?)LegPaymentStreamCompoundingEndDate)?.Reset();
			LegPaymentStreamCompoundingFrequencyPeriod = null;
			LegPaymentStreamCompoundingFrequencyUnit = null;
			LegPaymentStreamCompoundingRollConvention = null;
			LegPaymentStreamBoundsFirstDateUnadjusted = null;
			LegPaymentStreamBoundsLastDateUnadjusted = null;
		}
	}
}
