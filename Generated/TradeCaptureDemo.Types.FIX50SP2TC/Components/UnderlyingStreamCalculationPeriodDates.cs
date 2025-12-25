using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingStreamCalculationPeriodDates : IFixComponent
	{
		[TagDetails(Tag = 41957, Type = TagType.String, Offset = 0, Required = false)]
		public string? UnderlyingStreamCalculationPeriodDatesXID {get; set;}
		
		[TagDetails(Tag = 41958, Type = TagType.String, Offset = 1, Required = false)]
		public string? UnderlyingStreamCalculationPeriodDatesXIDRef {get; set;}
		
		[TagDetails(Tag = 40556, Type = TagType.Int, Offset = 2, Required = false)]
		public int? UnderlyingStreamCalculationPeriodBusinessDayConvention {get; set;}
		
		[Component(Offset = 3, Required = false)]
		public UnderlyingStreamCalculationPeriodBusinessCenterGrp? UnderlyingStreamCalculationPeriodBusinessCenterGrp {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public UnderlyingStreamCalculationPeriodDateGrp? UnderlyingStreamCalculationPeriodDateGrp {get; set;}
		
		[TagDetails(Tag = 40558, Type = TagType.LocalDate, Offset = 5, Required = false)]
		public DateOnly? UnderlyingStreamFirstPeriodStartDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40559, Type = TagType.Int, Offset = 6, Required = false)]
		public int? UnderlyingStreamFirstPeriodStartDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 7, Required = false)]
		public UnderlyingStreamFirstPeriodStartDateBusinessCenterGrp? UnderlyingStreamFirstPeriodStartDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40561, Type = TagType.LocalDate, Offset = 8, Required = false)]
		public DateOnly? UnderlyingStreamFirstPeriodStartDateAdjusted {get; set;}
		
		[TagDetails(Tag = 40562, Type = TagType.LocalDate, Offset = 9, Required = false)]
		public DateOnly? UnderlyingStreamFirstRegularPeriodStartDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40563, Type = TagType.LocalDate, Offset = 10, Required = false)]
		public DateOnly? UnderlyingStreamFirstCompoundingPeriodEndDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40564, Type = TagType.LocalDate, Offset = 11, Required = false)]
		public DateOnly? UnderlyingStreamLastRegularPeriodEndDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40565, Type = TagType.Int, Offset = 12, Required = false)]
		public int? UnderlyingStreamCalculationFrequencyPeriod {get; set;}
		
		[TagDetails(Tag = 40566, Type = TagType.String, Offset = 13, Required = false)]
		public string? UnderlyingStreamCalculationFrequencyUnit {get; set;}
		
		[TagDetails(Tag = 40567, Type = TagType.String, Offset = 14, Required = false)]
		public string? UnderlyingStreamCalculationRollConvention {get; set;}
		
		[TagDetails(Tag = 41959, Type = TagType.Boolean, Offset = 15, Required = false)]
		public bool? UnderlyingStreamCalculationBalanceOfFirstPeriod {get; set;}
		
		[TagDetails(Tag = 41960, Type = TagType.Int, Offset = 16, Required = false)]
		public int? UnderlyingStreamCalculationCorrectionPeriod {get; set;}
		
		[TagDetails(Tag = 41961, Type = TagType.String, Offset = 17, Required = false)]
		public string? UnderlyingStreamCalculationCorrectionUnit {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingStreamCalculationPeriodDatesXID is not null) writer.WriteString(41957, UnderlyingStreamCalculationPeriodDatesXID);
			if (UnderlyingStreamCalculationPeriodDatesXIDRef is not null) writer.WriteString(41958, UnderlyingStreamCalculationPeriodDatesXIDRef);
			if (UnderlyingStreamCalculationPeriodBusinessDayConvention is not null) writer.WriteWholeNumber(40556, UnderlyingStreamCalculationPeriodBusinessDayConvention.Value);
			if (UnderlyingStreamCalculationPeriodBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingStreamCalculationPeriodBusinessCenterGrp).Encode(writer);
			if (UnderlyingStreamCalculationPeriodDateGrp is not null) ((IFixEncoder)UnderlyingStreamCalculationPeriodDateGrp).Encode(writer);
			if (UnderlyingStreamFirstPeriodStartDateUnadjusted is not null) writer.WriteLocalDateOnly(40558, UnderlyingStreamFirstPeriodStartDateUnadjusted.Value);
			if (UnderlyingStreamFirstPeriodStartDateBusinessDayConvention is not null) writer.WriteWholeNumber(40559, UnderlyingStreamFirstPeriodStartDateBusinessDayConvention.Value);
			if (UnderlyingStreamFirstPeriodStartDateBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingStreamFirstPeriodStartDateBusinessCenterGrp).Encode(writer);
			if (UnderlyingStreamFirstPeriodStartDateAdjusted is not null) writer.WriteLocalDateOnly(40561, UnderlyingStreamFirstPeriodStartDateAdjusted.Value);
			if (UnderlyingStreamFirstRegularPeriodStartDateUnadjusted is not null) writer.WriteLocalDateOnly(40562, UnderlyingStreamFirstRegularPeriodStartDateUnadjusted.Value);
			if (UnderlyingStreamFirstCompoundingPeriodEndDateUnadjusted is not null) writer.WriteLocalDateOnly(40563, UnderlyingStreamFirstCompoundingPeriodEndDateUnadjusted.Value);
			if (UnderlyingStreamLastRegularPeriodEndDateUnadjusted is not null) writer.WriteLocalDateOnly(40564, UnderlyingStreamLastRegularPeriodEndDateUnadjusted.Value);
			if (UnderlyingStreamCalculationFrequencyPeriod is not null) writer.WriteWholeNumber(40565, UnderlyingStreamCalculationFrequencyPeriod.Value);
			if (UnderlyingStreamCalculationFrequencyUnit is not null) writer.WriteString(40566, UnderlyingStreamCalculationFrequencyUnit);
			if (UnderlyingStreamCalculationRollConvention is not null) writer.WriteString(40567, UnderlyingStreamCalculationRollConvention);
			if (UnderlyingStreamCalculationBalanceOfFirstPeriod is not null) writer.WriteBoolean(41959, UnderlyingStreamCalculationBalanceOfFirstPeriod.Value);
			if (UnderlyingStreamCalculationCorrectionPeriod is not null) writer.WriteWholeNumber(41960, UnderlyingStreamCalculationCorrectionPeriod.Value);
			if (UnderlyingStreamCalculationCorrectionUnit is not null) writer.WriteString(41961, UnderlyingStreamCalculationCorrectionUnit);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingStreamCalculationPeriodDatesXID = view.GetString(41957);
			UnderlyingStreamCalculationPeriodDatesXIDRef = view.GetString(41958);
			UnderlyingStreamCalculationPeriodBusinessDayConvention = view.GetInt32(40556);
			if (view.GetView("UnderlyingStreamCalculationPeriodBusinessCenterGrp") is IMessageView viewUnderlyingStreamCalculationPeriodBusinessCenterGrp)
			{
				UnderlyingStreamCalculationPeriodBusinessCenterGrp = new();
				((IFixParser)UnderlyingStreamCalculationPeriodBusinessCenterGrp).Parse(viewUnderlyingStreamCalculationPeriodBusinessCenterGrp);
			}
			if (view.GetView("UnderlyingStreamCalculationPeriodDateGrp") is IMessageView viewUnderlyingStreamCalculationPeriodDateGrp)
			{
				UnderlyingStreamCalculationPeriodDateGrp = new();
				((IFixParser)UnderlyingStreamCalculationPeriodDateGrp).Parse(viewUnderlyingStreamCalculationPeriodDateGrp);
			}
			UnderlyingStreamFirstPeriodStartDateUnadjusted = view.GetDateOnly(40558);
			UnderlyingStreamFirstPeriodStartDateBusinessDayConvention = view.GetInt32(40559);
			if (view.GetView("UnderlyingStreamFirstPeriodStartDateBusinessCenterGrp") is IMessageView viewUnderlyingStreamFirstPeriodStartDateBusinessCenterGrp)
			{
				UnderlyingStreamFirstPeriodStartDateBusinessCenterGrp = new();
				((IFixParser)UnderlyingStreamFirstPeriodStartDateBusinessCenterGrp).Parse(viewUnderlyingStreamFirstPeriodStartDateBusinessCenterGrp);
			}
			UnderlyingStreamFirstPeriodStartDateAdjusted = view.GetDateOnly(40561);
			UnderlyingStreamFirstRegularPeriodStartDateUnadjusted = view.GetDateOnly(40562);
			UnderlyingStreamFirstCompoundingPeriodEndDateUnadjusted = view.GetDateOnly(40563);
			UnderlyingStreamLastRegularPeriodEndDateUnadjusted = view.GetDateOnly(40564);
			UnderlyingStreamCalculationFrequencyPeriod = view.GetInt32(40565);
			UnderlyingStreamCalculationFrequencyUnit = view.GetString(40566);
			UnderlyingStreamCalculationRollConvention = view.GetString(40567);
			UnderlyingStreamCalculationBalanceOfFirstPeriod = view.GetBool(41959);
			UnderlyingStreamCalculationCorrectionPeriod = view.GetInt32(41960);
			UnderlyingStreamCalculationCorrectionUnit = view.GetString(41961);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingStreamCalculationPeriodDatesXID":
				{
					value = UnderlyingStreamCalculationPeriodDatesXID;
					break;
				}
				case "UnderlyingStreamCalculationPeriodDatesXIDRef":
				{
					value = UnderlyingStreamCalculationPeriodDatesXIDRef;
					break;
				}
				case "UnderlyingStreamCalculationPeriodBusinessDayConvention":
				{
					value = UnderlyingStreamCalculationPeriodBusinessDayConvention;
					break;
				}
				case "UnderlyingStreamCalculationPeriodBusinessCenterGrp":
				{
					value = UnderlyingStreamCalculationPeriodBusinessCenterGrp;
					break;
				}
				case "UnderlyingStreamCalculationPeriodDateGrp":
				{
					value = UnderlyingStreamCalculationPeriodDateGrp;
					break;
				}
				case "UnderlyingStreamFirstPeriodStartDateUnadjusted":
				{
					value = UnderlyingStreamFirstPeriodStartDateUnadjusted;
					break;
				}
				case "UnderlyingStreamFirstPeriodStartDateBusinessDayConvention":
				{
					value = UnderlyingStreamFirstPeriodStartDateBusinessDayConvention;
					break;
				}
				case "UnderlyingStreamFirstPeriodStartDateBusinessCenterGrp":
				{
					value = UnderlyingStreamFirstPeriodStartDateBusinessCenterGrp;
					break;
				}
				case "UnderlyingStreamFirstPeriodStartDateAdjusted":
				{
					value = UnderlyingStreamFirstPeriodStartDateAdjusted;
					break;
				}
				case "UnderlyingStreamFirstRegularPeriodStartDateUnadjusted":
				{
					value = UnderlyingStreamFirstRegularPeriodStartDateUnadjusted;
					break;
				}
				case "UnderlyingStreamFirstCompoundingPeriodEndDateUnadjusted":
				{
					value = UnderlyingStreamFirstCompoundingPeriodEndDateUnadjusted;
					break;
				}
				case "UnderlyingStreamLastRegularPeriodEndDateUnadjusted":
				{
					value = UnderlyingStreamLastRegularPeriodEndDateUnadjusted;
					break;
				}
				case "UnderlyingStreamCalculationFrequencyPeriod":
				{
					value = UnderlyingStreamCalculationFrequencyPeriod;
					break;
				}
				case "UnderlyingStreamCalculationFrequencyUnit":
				{
					value = UnderlyingStreamCalculationFrequencyUnit;
					break;
				}
				case "UnderlyingStreamCalculationRollConvention":
				{
					value = UnderlyingStreamCalculationRollConvention;
					break;
				}
				case "UnderlyingStreamCalculationBalanceOfFirstPeriod":
				{
					value = UnderlyingStreamCalculationBalanceOfFirstPeriod;
					break;
				}
				case "UnderlyingStreamCalculationCorrectionPeriod":
				{
					value = UnderlyingStreamCalculationCorrectionPeriod;
					break;
				}
				case "UnderlyingStreamCalculationCorrectionUnit":
				{
					value = UnderlyingStreamCalculationCorrectionUnit;
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
			UnderlyingStreamCalculationPeriodDatesXID = null;
			UnderlyingStreamCalculationPeriodDatesXIDRef = null;
			UnderlyingStreamCalculationPeriodBusinessDayConvention = null;
			((IFixReset?)UnderlyingStreamCalculationPeriodBusinessCenterGrp)?.Reset();
			((IFixReset?)UnderlyingStreamCalculationPeriodDateGrp)?.Reset();
			UnderlyingStreamFirstPeriodStartDateUnadjusted = null;
			UnderlyingStreamFirstPeriodStartDateBusinessDayConvention = null;
			((IFixReset?)UnderlyingStreamFirstPeriodStartDateBusinessCenterGrp)?.Reset();
			UnderlyingStreamFirstPeriodStartDateAdjusted = null;
			UnderlyingStreamFirstRegularPeriodStartDateUnadjusted = null;
			UnderlyingStreamFirstCompoundingPeriodEndDateUnadjusted = null;
			UnderlyingStreamLastRegularPeriodEndDateUnadjusted = null;
			UnderlyingStreamCalculationFrequencyPeriod = null;
			UnderlyingStreamCalculationFrequencyUnit = null;
			UnderlyingStreamCalculationRollConvention = null;
			UnderlyingStreamCalculationBalanceOfFirstPeriod = null;
			UnderlyingStreamCalculationCorrectionPeriod = null;
			UnderlyingStreamCalculationCorrectionUnit = null;
		}
	}
}
