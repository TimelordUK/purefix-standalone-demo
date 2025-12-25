using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStreamCompoundingDates : IFixComponent
	{
		[TagDetails(Tag = 42904, Type = TagType.Int, Offset = 0, Required = false)]
		public int? UnderlyingPaymentStreamCompoundingDatesBusinessDayConvention {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public UnderlyingPaymentStreamCompoundingDatesBusinessCenterGrp? UnderlyingPaymentStreamCompoundingDatesBusinessCenterGrp {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public UnderlyingPaymentStreamCompoundingDateGrp? UnderlyingPaymentStreamCompoundingDateGrp {get; set;}
		
		[TagDetails(Tag = 42905, Type = TagType.Int, Offset = 3, Required = false)]
		public int? UnderlyingPaymentStreamCompoundingDatesRelativeTo {get; set;}
		
		[TagDetails(Tag = 42906, Type = TagType.Int, Offset = 4, Required = false)]
		public int? UnderlyingPaymentStreamCompoundingDatesOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42907, Type = TagType.String, Offset = 5, Required = false)]
		public string? UnderlyingPaymentStreamCompoundingDatesOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42908, Type = TagType.Int, Offset = 6, Required = false)]
		public int? UnderlyingPaymentStreamCompoundingDatesOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42909, Type = TagType.Int, Offset = 7, Required = false)]
		public int? UnderlyingPaymentStreamCompoundingPeriodSkip {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public UnderlyingPaymentStreamCompoundingStartDate? UnderlyingPaymentStreamCompoundingStartDate {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public UnderlyingPaymentStreamCompoundingEndDate? UnderlyingPaymentStreamCompoundingEndDate {get; set;}
		
		[TagDetails(Tag = 42910, Type = TagType.Int, Offset = 10, Required = false)]
		public int? UnderlyingPaymentStreamCompoundingFrequencyPeriod {get; set;}
		
		[TagDetails(Tag = 42911, Type = TagType.String, Offset = 11, Required = false)]
		public string? UnderlyingPaymentStreamCompoundingFrequencyUnit {get; set;}
		
		[TagDetails(Tag = 42912, Type = TagType.String, Offset = 12, Required = false)]
		public string? UnderlyingPaymentStreamCompoundingRollConvention {get; set;}
		
		[TagDetails(Tag = 42913, Type = TagType.LocalDate, Offset = 13, Required = false)]
		public DateOnly? UnderlyingPaymentStreamBoundsFirstDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42914, Type = TagType.LocalDate, Offset = 14, Required = false)]
		public DateOnly? UnderlyingPaymentStreamBoundsLastDateUnadjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStreamCompoundingDatesBusinessDayConvention is not null) writer.WriteWholeNumber(42904, UnderlyingPaymentStreamCompoundingDatesBusinessDayConvention.Value);
			if (UnderlyingPaymentStreamCompoundingDatesBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingPaymentStreamCompoundingDatesBusinessCenterGrp).Encode(writer);
			if (UnderlyingPaymentStreamCompoundingDateGrp is not null) ((IFixEncoder)UnderlyingPaymentStreamCompoundingDateGrp).Encode(writer);
			if (UnderlyingPaymentStreamCompoundingDatesRelativeTo is not null) writer.WriteWholeNumber(42905, UnderlyingPaymentStreamCompoundingDatesRelativeTo.Value);
			if (UnderlyingPaymentStreamCompoundingDatesOffsetPeriod is not null) writer.WriteWholeNumber(42906, UnderlyingPaymentStreamCompoundingDatesOffsetPeriod.Value);
			if (UnderlyingPaymentStreamCompoundingDatesOffsetUnit is not null) writer.WriteString(42907, UnderlyingPaymentStreamCompoundingDatesOffsetUnit);
			if (UnderlyingPaymentStreamCompoundingDatesOffsetDayType is not null) writer.WriteWholeNumber(42908, UnderlyingPaymentStreamCompoundingDatesOffsetDayType.Value);
			if (UnderlyingPaymentStreamCompoundingPeriodSkip is not null) writer.WriteWholeNumber(42909, UnderlyingPaymentStreamCompoundingPeriodSkip.Value);
			if (UnderlyingPaymentStreamCompoundingStartDate is not null) ((IFixEncoder)UnderlyingPaymentStreamCompoundingStartDate).Encode(writer);
			if (UnderlyingPaymentStreamCompoundingEndDate is not null) ((IFixEncoder)UnderlyingPaymentStreamCompoundingEndDate).Encode(writer);
			if (UnderlyingPaymentStreamCompoundingFrequencyPeriod is not null) writer.WriteWholeNumber(42910, UnderlyingPaymentStreamCompoundingFrequencyPeriod.Value);
			if (UnderlyingPaymentStreamCompoundingFrequencyUnit is not null) writer.WriteString(42911, UnderlyingPaymentStreamCompoundingFrequencyUnit);
			if (UnderlyingPaymentStreamCompoundingRollConvention is not null) writer.WriteString(42912, UnderlyingPaymentStreamCompoundingRollConvention);
			if (UnderlyingPaymentStreamBoundsFirstDateUnadjusted is not null) writer.WriteLocalDateOnly(42913, UnderlyingPaymentStreamBoundsFirstDateUnadjusted.Value);
			if (UnderlyingPaymentStreamBoundsLastDateUnadjusted is not null) writer.WriteLocalDateOnly(42914, UnderlyingPaymentStreamBoundsLastDateUnadjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingPaymentStreamCompoundingDatesBusinessDayConvention = view.GetInt32(42904);
			if (view.GetView("UnderlyingPaymentStreamCompoundingDatesBusinessCenterGrp") is IMessageView viewUnderlyingPaymentStreamCompoundingDatesBusinessCenterGrp)
			{
				UnderlyingPaymentStreamCompoundingDatesBusinessCenterGrp = new();
				((IFixParser)UnderlyingPaymentStreamCompoundingDatesBusinessCenterGrp).Parse(viewUnderlyingPaymentStreamCompoundingDatesBusinessCenterGrp);
			}
			if (view.GetView("UnderlyingPaymentStreamCompoundingDateGrp") is IMessageView viewUnderlyingPaymentStreamCompoundingDateGrp)
			{
				UnderlyingPaymentStreamCompoundingDateGrp = new();
				((IFixParser)UnderlyingPaymentStreamCompoundingDateGrp).Parse(viewUnderlyingPaymentStreamCompoundingDateGrp);
			}
			UnderlyingPaymentStreamCompoundingDatesRelativeTo = view.GetInt32(42905);
			UnderlyingPaymentStreamCompoundingDatesOffsetPeriod = view.GetInt32(42906);
			UnderlyingPaymentStreamCompoundingDatesOffsetUnit = view.GetString(42907);
			UnderlyingPaymentStreamCompoundingDatesOffsetDayType = view.GetInt32(42908);
			UnderlyingPaymentStreamCompoundingPeriodSkip = view.GetInt32(42909);
			if (view.GetView("UnderlyingPaymentStreamCompoundingStartDate") is IMessageView viewUnderlyingPaymentStreamCompoundingStartDate)
			{
				UnderlyingPaymentStreamCompoundingStartDate = new();
				((IFixParser)UnderlyingPaymentStreamCompoundingStartDate).Parse(viewUnderlyingPaymentStreamCompoundingStartDate);
			}
			if (view.GetView("UnderlyingPaymentStreamCompoundingEndDate") is IMessageView viewUnderlyingPaymentStreamCompoundingEndDate)
			{
				UnderlyingPaymentStreamCompoundingEndDate = new();
				((IFixParser)UnderlyingPaymentStreamCompoundingEndDate).Parse(viewUnderlyingPaymentStreamCompoundingEndDate);
			}
			UnderlyingPaymentStreamCompoundingFrequencyPeriod = view.GetInt32(42910);
			UnderlyingPaymentStreamCompoundingFrequencyUnit = view.GetString(42911);
			UnderlyingPaymentStreamCompoundingRollConvention = view.GetString(42912);
			UnderlyingPaymentStreamBoundsFirstDateUnadjusted = view.GetDateOnly(42913);
			UnderlyingPaymentStreamBoundsLastDateUnadjusted = view.GetDateOnly(42914);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingPaymentStreamCompoundingDatesBusinessDayConvention":
				{
					value = UnderlyingPaymentStreamCompoundingDatesBusinessDayConvention;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingDatesBusinessCenterGrp":
				{
					value = UnderlyingPaymentStreamCompoundingDatesBusinessCenterGrp;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingDateGrp":
				{
					value = UnderlyingPaymentStreamCompoundingDateGrp;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingDatesRelativeTo":
				{
					value = UnderlyingPaymentStreamCompoundingDatesRelativeTo;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingDatesOffsetPeriod":
				{
					value = UnderlyingPaymentStreamCompoundingDatesOffsetPeriod;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingDatesOffsetUnit":
				{
					value = UnderlyingPaymentStreamCompoundingDatesOffsetUnit;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingDatesOffsetDayType":
				{
					value = UnderlyingPaymentStreamCompoundingDatesOffsetDayType;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingPeriodSkip":
				{
					value = UnderlyingPaymentStreamCompoundingPeriodSkip;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingStartDate":
				{
					value = UnderlyingPaymentStreamCompoundingStartDate;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingEndDate":
				{
					value = UnderlyingPaymentStreamCompoundingEndDate;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingFrequencyPeriod":
				{
					value = UnderlyingPaymentStreamCompoundingFrequencyPeriod;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingFrequencyUnit":
				{
					value = UnderlyingPaymentStreamCompoundingFrequencyUnit;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingRollConvention":
				{
					value = UnderlyingPaymentStreamCompoundingRollConvention;
					break;
				}
				case "UnderlyingPaymentStreamBoundsFirstDateUnadjusted":
				{
					value = UnderlyingPaymentStreamBoundsFirstDateUnadjusted;
					break;
				}
				case "UnderlyingPaymentStreamBoundsLastDateUnadjusted":
				{
					value = UnderlyingPaymentStreamBoundsLastDateUnadjusted;
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
			UnderlyingPaymentStreamCompoundingDatesBusinessDayConvention = null;
			((IFixReset?)UnderlyingPaymentStreamCompoundingDatesBusinessCenterGrp)?.Reset();
			((IFixReset?)UnderlyingPaymentStreamCompoundingDateGrp)?.Reset();
			UnderlyingPaymentStreamCompoundingDatesRelativeTo = null;
			UnderlyingPaymentStreamCompoundingDatesOffsetPeriod = null;
			UnderlyingPaymentStreamCompoundingDatesOffsetUnit = null;
			UnderlyingPaymentStreamCompoundingDatesOffsetDayType = null;
			UnderlyingPaymentStreamCompoundingPeriodSkip = null;
			((IFixReset?)UnderlyingPaymentStreamCompoundingStartDate)?.Reset();
			((IFixReset?)UnderlyingPaymentStreamCompoundingEndDate)?.Reset();
			UnderlyingPaymentStreamCompoundingFrequencyPeriod = null;
			UnderlyingPaymentStreamCompoundingFrequencyUnit = null;
			UnderlyingPaymentStreamCompoundingRollConvention = null;
			UnderlyingPaymentStreamBoundsFirstDateUnadjusted = null;
			UnderlyingPaymentStreamBoundsLastDateUnadjusted = null;
		}
	}
}
