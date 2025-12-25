using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegStreamCalculationPeriodDates : IFixComponent
	{
		[TagDetails(Tag = 41641, Type = TagType.String, Offset = 0, Required = false)]
		public string? LegStreamCalculationPeriodDatesXID {get; set;}
		
		[TagDetails(Tag = 41642, Type = TagType.String, Offset = 1, Required = false)]
		public string? LegStreamCalculationPeriodDatesXIDRef {get; set;}
		
		[TagDetails(Tag = 40265, Type = TagType.Int, Offset = 2, Required = false)]
		public int? LegStreamCalculationPeriodBusinessDayConvention {get; set;}
		
		[Component(Offset = 3, Required = false)]
		public LegStreamCalculationPeriodBusinessCenterGrp? LegStreamCalculationPeriodBusinessCenterGrp {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public LegStreamCalculationPeriodDateGrp? LegStreamCalculationPeriodDateGrp {get; set;}
		
		[TagDetails(Tag = 40267, Type = TagType.LocalDate, Offset = 5, Required = false)]
		public DateOnly? LegStreamFirstPeriodStartDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40268, Type = TagType.Int, Offset = 6, Required = false)]
		public int? LegStreamFirstPeriodStartDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 7, Required = false)]
		public LegStreamFirstPeriodStartDateBusinessCenterGrp? LegStreamFirstPeriodStartDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40270, Type = TagType.LocalDate, Offset = 8, Required = false)]
		public DateOnly? LegStreamFirstPeriodStartDateAdjusted {get; set;}
		
		[TagDetails(Tag = 40271, Type = TagType.LocalDate, Offset = 9, Required = false)]
		public DateOnly? LegStreamFirstRegularPeriodStartDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40272, Type = TagType.LocalDate, Offset = 10, Required = false)]
		public DateOnly? LegStreamFirstCompoundingPeriodEndDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40273, Type = TagType.LocalDate, Offset = 11, Required = false)]
		public DateOnly? LegStreamLastRegularPeriodEndDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40274, Type = TagType.Int, Offset = 12, Required = false)]
		public int? LegStreamCalculationFrequencyPeriod {get; set;}
		
		[TagDetails(Tag = 40275, Type = TagType.String, Offset = 13, Required = false)]
		public string? LegStreamCalculationFrequencyUnit {get; set;}
		
		[TagDetails(Tag = 40276, Type = TagType.String, Offset = 14, Required = false)]
		public string? LegStreamCalculationRollConvention {get; set;}
		
		[TagDetails(Tag = 41643, Type = TagType.Boolean, Offset = 15, Required = false)]
		public bool? LegStreamCalculationBalanceOfFirstPeriod {get; set;}
		
		[TagDetails(Tag = 41644, Type = TagType.Int, Offset = 16, Required = false)]
		public int? LegStreamCalculationCorrectionPeriod {get; set;}
		
		[TagDetails(Tag = 41645, Type = TagType.String, Offset = 17, Required = false)]
		public string? LegStreamCalculationCorrectionUnit {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegStreamCalculationPeriodDatesXID is not null) writer.WriteString(41641, LegStreamCalculationPeriodDatesXID);
			if (LegStreamCalculationPeriodDatesXIDRef is not null) writer.WriteString(41642, LegStreamCalculationPeriodDatesXIDRef);
			if (LegStreamCalculationPeriodBusinessDayConvention is not null) writer.WriteWholeNumber(40265, LegStreamCalculationPeriodBusinessDayConvention.Value);
			if (LegStreamCalculationPeriodBusinessCenterGrp is not null) ((IFixEncoder)LegStreamCalculationPeriodBusinessCenterGrp).Encode(writer);
			if (LegStreamCalculationPeriodDateGrp is not null) ((IFixEncoder)LegStreamCalculationPeriodDateGrp).Encode(writer);
			if (LegStreamFirstPeriodStartDateUnadjusted is not null) writer.WriteLocalDateOnly(40267, LegStreamFirstPeriodStartDateUnadjusted.Value);
			if (LegStreamFirstPeriodStartDateBusinessDayConvention is not null) writer.WriteWholeNumber(40268, LegStreamFirstPeriodStartDateBusinessDayConvention.Value);
			if (LegStreamFirstPeriodStartDateBusinessCenterGrp is not null) ((IFixEncoder)LegStreamFirstPeriodStartDateBusinessCenterGrp).Encode(writer);
			if (LegStreamFirstPeriodStartDateAdjusted is not null) writer.WriteLocalDateOnly(40270, LegStreamFirstPeriodStartDateAdjusted.Value);
			if (LegStreamFirstRegularPeriodStartDateUnadjusted is not null) writer.WriteLocalDateOnly(40271, LegStreamFirstRegularPeriodStartDateUnadjusted.Value);
			if (LegStreamFirstCompoundingPeriodEndDateUnadjusted is not null) writer.WriteLocalDateOnly(40272, LegStreamFirstCompoundingPeriodEndDateUnadjusted.Value);
			if (LegStreamLastRegularPeriodEndDateUnadjusted is not null) writer.WriteLocalDateOnly(40273, LegStreamLastRegularPeriodEndDateUnadjusted.Value);
			if (LegStreamCalculationFrequencyPeriod is not null) writer.WriteWholeNumber(40274, LegStreamCalculationFrequencyPeriod.Value);
			if (LegStreamCalculationFrequencyUnit is not null) writer.WriteString(40275, LegStreamCalculationFrequencyUnit);
			if (LegStreamCalculationRollConvention is not null) writer.WriteString(40276, LegStreamCalculationRollConvention);
			if (LegStreamCalculationBalanceOfFirstPeriod is not null) writer.WriteBoolean(41643, LegStreamCalculationBalanceOfFirstPeriod.Value);
			if (LegStreamCalculationCorrectionPeriod is not null) writer.WriteWholeNumber(41644, LegStreamCalculationCorrectionPeriod.Value);
			if (LegStreamCalculationCorrectionUnit is not null) writer.WriteString(41645, LegStreamCalculationCorrectionUnit);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegStreamCalculationPeriodDatesXID = view.GetString(41641);
			LegStreamCalculationPeriodDatesXIDRef = view.GetString(41642);
			LegStreamCalculationPeriodBusinessDayConvention = view.GetInt32(40265);
			if (view.GetView("LegStreamCalculationPeriodBusinessCenterGrp") is IMessageView viewLegStreamCalculationPeriodBusinessCenterGrp)
			{
				LegStreamCalculationPeriodBusinessCenterGrp = new();
				((IFixParser)LegStreamCalculationPeriodBusinessCenterGrp).Parse(viewLegStreamCalculationPeriodBusinessCenterGrp);
			}
			if (view.GetView("LegStreamCalculationPeriodDateGrp") is IMessageView viewLegStreamCalculationPeriodDateGrp)
			{
				LegStreamCalculationPeriodDateGrp = new();
				((IFixParser)LegStreamCalculationPeriodDateGrp).Parse(viewLegStreamCalculationPeriodDateGrp);
			}
			LegStreamFirstPeriodStartDateUnadjusted = view.GetDateOnly(40267);
			LegStreamFirstPeriodStartDateBusinessDayConvention = view.GetInt32(40268);
			if (view.GetView("LegStreamFirstPeriodStartDateBusinessCenterGrp") is IMessageView viewLegStreamFirstPeriodStartDateBusinessCenterGrp)
			{
				LegStreamFirstPeriodStartDateBusinessCenterGrp = new();
				((IFixParser)LegStreamFirstPeriodStartDateBusinessCenterGrp).Parse(viewLegStreamFirstPeriodStartDateBusinessCenterGrp);
			}
			LegStreamFirstPeriodStartDateAdjusted = view.GetDateOnly(40270);
			LegStreamFirstRegularPeriodStartDateUnadjusted = view.GetDateOnly(40271);
			LegStreamFirstCompoundingPeriodEndDateUnadjusted = view.GetDateOnly(40272);
			LegStreamLastRegularPeriodEndDateUnadjusted = view.GetDateOnly(40273);
			LegStreamCalculationFrequencyPeriod = view.GetInt32(40274);
			LegStreamCalculationFrequencyUnit = view.GetString(40275);
			LegStreamCalculationRollConvention = view.GetString(40276);
			LegStreamCalculationBalanceOfFirstPeriod = view.GetBool(41643);
			LegStreamCalculationCorrectionPeriod = view.GetInt32(41644);
			LegStreamCalculationCorrectionUnit = view.GetString(41645);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegStreamCalculationPeriodDatesXID":
				{
					value = LegStreamCalculationPeriodDatesXID;
					break;
				}
				case "LegStreamCalculationPeriodDatesXIDRef":
				{
					value = LegStreamCalculationPeriodDatesXIDRef;
					break;
				}
				case "LegStreamCalculationPeriodBusinessDayConvention":
				{
					value = LegStreamCalculationPeriodBusinessDayConvention;
					break;
				}
				case "LegStreamCalculationPeriodBusinessCenterGrp":
				{
					value = LegStreamCalculationPeriodBusinessCenterGrp;
					break;
				}
				case "LegStreamCalculationPeriodDateGrp":
				{
					value = LegStreamCalculationPeriodDateGrp;
					break;
				}
				case "LegStreamFirstPeriodStartDateUnadjusted":
				{
					value = LegStreamFirstPeriodStartDateUnadjusted;
					break;
				}
				case "LegStreamFirstPeriodStartDateBusinessDayConvention":
				{
					value = LegStreamFirstPeriodStartDateBusinessDayConvention;
					break;
				}
				case "LegStreamFirstPeriodStartDateBusinessCenterGrp":
				{
					value = LegStreamFirstPeriodStartDateBusinessCenterGrp;
					break;
				}
				case "LegStreamFirstPeriodStartDateAdjusted":
				{
					value = LegStreamFirstPeriodStartDateAdjusted;
					break;
				}
				case "LegStreamFirstRegularPeriodStartDateUnadjusted":
				{
					value = LegStreamFirstRegularPeriodStartDateUnadjusted;
					break;
				}
				case "LegStreamFirstCompoundingPeriodEndDateUnadjusted":
				{
					value = LegStreamFirstCompoundingPeriodEndDateUnadjusted;
					break;
				}
				case "LegStreamLastRegularPeriodEndDateUnadjusted":
				{
					value = LegStreamLastRegularPeriodEndDateUnadjusted;
					break;
				}
				case "LegStreamCalculationFrequencyPeriod":
				{
					value = LegStreamCalculationFrequencyPeriod;
					break;
				}
				case "LegStreamCalculationFrequencyUnit":
				{
					value = LegStreamCalculationFrequencyUnit;
					break;
				}
				case "LegStreamCalculationRollConvention":
				{
					value = LegStreamCalculationRollConvention;
					break;
				}
				case "LegStreamCalculationBalanceOfFirstPeriod":
				{
					value = LegStreamCalculationBalanceOfFirstPeriod;
					break;
				}
				case "LegStreamCalculationCorrectionPeriod":
				{
					value = LegStreamCalculationCorrectionPeriod;
					break;
				}
				case "LegStreamCalculationCorrectionUnit":
				{
					value = LegStreamCalculationCorrectionUnit;
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
			LegStreamCalculationPeriodDatesXID = null;
			LegStreamCalculationPeriodDatesXIDRef = null;
			LegStreamCalculationPeriodBusinessDayConvention = null;
			((IFixReset?)LegStreamCalculationPeriodBusinessCenterGrp)?.Reset();
			((IFixReset?)LegStreamCalculationPeriodDateGrp)?.Reset();
			LegStreamFirstPeriodStartDateUnadjusted = null;
			LegStreamFirstPeriodStartDateBusinessDayConvention = null;
			((IFixReset?)LegStreamFirstPeriodStartDateBusinessCenterGrp)?.Reset();
			LegStreamFirstPeriodStartDateAdjusted = null;
			LegStreamFirstRegularPeriodStartDateUnadjusted = null;
			LegStreamFirstCompoundingPeriodEndDateUnadjusted = null;
			LegStreamLastRegularPeriodEndDateUnadjusted = null;
			LegStreamCalculationFrequencyPeriod = null;
			LegStreamCalculationFrequencyUnit = null;
			LegStreamCalculationRollConvention = null;
			LegStreamCalculationBalanceOfFirstPeriod = null;
			LegStreamCalculationCorrectionPeriod = null;
			LegStreamCalculationCorrectionUnit = null;
		}
	}
}
