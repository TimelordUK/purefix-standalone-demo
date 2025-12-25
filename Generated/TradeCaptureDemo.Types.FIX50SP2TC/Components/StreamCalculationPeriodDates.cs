using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class StreamCalculationPeriodDates : IFixComponent
	{
		[TagDetails(Tag = 41244, Type = TagType.String, Offset = 0, Required = false)]
		public string? StreamCalculationPeriodDatesXID {get; set;}
		
		[TagDetails(Tag = 41245, Type = TagType.String, Offset = 1, Required = false)]
		public string? StreamCalculationPeriodDatesXIDRef {get; set;}
		
		[TagDetails(Tag = 40073, Type = TagType.Int, Offset = 2, Required = false)]
		public int? StreamCalculationPeriodBusinessDayConvention {get; set;}
		
		[Component(Offset = 3, Required = false)]
		public StreamCalculationPeriodBusinessCenterGrp? StreamCalculationPeriodBusinessCenterGrp {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public StreamCalculationPeriodDateGrp? StreamCalculationPeriodDateGrp {get; set;}
		
		[TagDetails(Tag = 40075, Type = TagType.LocalDate, Offset = 5, Required = false)]
		public DateOnly? StreamFirstPeriodStartDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40076, Type = TagType.Int, Offset = 6, Required = false)]
		public int? StreamFirstPeriodStartDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 7, Required = false)]
		public StreamFirstPeriodStartDateBusinessCenterGrp? StreamFirstPeriodStartDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40078, Type = TagType.LocalDate, Offset = 8, Required = false)]
		public DateOnly? StreamFirstPeriodStartDateAdjusted {get; set;}
		
		[TagDetails(Tag = 40079, Type = TagType.LocalDate, Offset = 9, Required = false)]
		public DateOnly? StreamFirstRegularPeriodStartDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40080, Type = TagType.LocalDate, Offset = 10, Required = false)]
		public DateOnly? StreamFirstCompoundingPeriodEndDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40081, Type = TagType.LocalDate, Offset = 11, Required = false)]
		public DateOnly? StreamLastRegularPeriodEndDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40082, Type = TagType.Int, Offset = 12, Required = false)]
		public int? StreamCalculationFrequencyPeriod {get; set;}
		
		[TagDetails(Tag = 40083, Type = TagType.String, Offset = 13, Required = false)]
		public string? StreamCalculationFrequencyUnit {get; set;}
		
		[TagDetails(Tag = 40084, Type = TagType.String, Offset = 14, Required = false)]
		public string? StreamCalculationRollConvention {get; set;}
		
		[TagDetails(Tag = 41246, Type = TagType.Boolean, Offset = 15, Required = false)]
		public bool? StreamCalculationBalanceOfFirstPeriod {get; set;}
		
		[TagDetails(Tag = 41247, Type = TagType.Int, Offset = 16, Required = false)]
		public int? StreamCalculationCorrectionPeriod {get; set;}
		
		[TagDetails(Tag = 41248, Type = TagType.String, Offset = 17, Required = false)]
		public string? StreamCalculationCorrectionUnit {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (StreamCalculationPeriodDatesXID is not null) writer.WriteString(41244, StreamCalculationPeriodDatesXID);
			if (StreamCalculationPeriodDatesXIDRef is not null) writer.WriteString(41245, StreamCalculationPeriodDatesXIDRef);
			if (StreamCalculationPeriodBusinessDayConvention is not null) writer.WriteWholeNumber(40073, StreamCalculationPeriodBusinessDayConvention.Value);
			if (StreamCalculationPeriodBusinessCenterGrp is not null) ((IFixEncoder)StreamCalculationPeriodBusinessCenterGrp).Encode(writer);
			if (StreamCalculationPeriodDateGrp is not null) ((IFixEncoder)StreamCalculationPeriodDateGrp).Encode(writer);
			if (StreamFirstPeriodStartDateUnadjusted is not null) writer.WriteLocalDateOnly(40075, StreamFirstPeriodStartDateUnadjusted.Value);
			if (StreamFirstPeriodStartDateBusinessDayConvention is not null) writer.WriteWholeNumber(40076, StreamFirstPeriodStartDateBusinessDayConvention.Value);
			if (StreamFirstPeriodStartDateBusinessCenterGrp is not null) ((IFixEncoder)StreamFirstPeriodStartDateBusinessCenterGrp).Encode(writer);
			if (StreamFirstPeriodStartDateAdjusted is not null) writer.WriteLocalDateOnly(40078, StreamFirstPeriodStartDateAdjusted.Value);
			if (StreamFirstRegularPeriodStartDateUnadjusted is not null) writer.WriteLocalDateOnly(40079, StreamFirstRegularPeriodStartDateUnadjusted.Value);
			if (StreamFirstCompoundingPeriodEndDateUnadjusted is not null) writer.WriteLocalDateOnly(40080, StreamFirstCompoundingPeriodEndDateUnadjusted.Value);
			if (StreamLastRegularPeriodEndDateUnadjusted is not null) writer.WriteLocalDateOnly(40081, StreamLastRegularPeriodEndDateUnadjusted.Value);
			if (StreamCalculationFrequencyPeriod is not null) writer.WriteWholeNumber(40082, StreamCalculationFrequencyPeriod.Value);
			if (StreamCalculationFrequencyUnit is not null) writer.WriteString(40083, StreamCalculationFrequencyUnit);
			if (StreamCalculationRollConvention is not null) writer.WriteString(40084, StreamCalculationRollConvention);
			if (StreamCalculationBalanceOfFirstPeriod is not null) writer.WriteBoolean(41246, StreamCalculationBalanceOfFirstPeriod.Value);
			if (StreamCalculationCorrectionPeriod is not null) writer.WriteWholeNumber(41247, StreamCalculationCorrectionPeriod.Value);
			if (StreamCalculationCorrectionUnit is not null) writer.WriteString(41248, StreamCalculationCorrectionUnit);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			StreamCalculationPeriodDatesXID = view.GetString(41244);
			StreamCalculationPeriodDatesXIDRef = view.GetString(41245);
			StreamCalculationPeriodBusinessDayConvention = view.GetInt32(40073);
			if (view.GetView("StreamCalculationPeriodBusinessCenterGrp") is IMessageView viewStreamCalculationPeriodBusinessCenterGrp)
			{
				StreamCalculationPeriodBusinessCenterGrp = new();
				((IFixParser)StreamCalculationPeriodBusinessCenterGrp).Parse(viewStreamCalculationPeriodBusinessCenterGrp);
			}
			if (view.GetView("StreamCalculationPeriodDateGrp") is IMessageView viewStreamCalculationPeriodDateGrp)
			{
				StreamCalculationPeriodDateGrp = new();
				((IFixParser)StreamCalculationPeriodDateGrp).Parse(viewStreamCalculationPeriodDateGrp);
			}
			StreamFirstPeriodStartDateUnadjusted = view.GetDateOnly(40075);
			StreamFirstPeriodStartDateBusinessDayConvention = view.GetInt32(40076);
			if (view.GetView("StreamFirstPeriodStartDateBusinessCenterGrp") is IMessageView viewStreamFirstPeriodStartDateBusinessCenterGrp)
			{
				StreamFirstPeriodStartDateBusinessCenterGrp = new();
				((IFixParser)StreamFirstPeriodStartDateBusinessCenterGrp).Parse(viewStreamFirstPeriodStartDateBusinessCenterGrp);
			}
			StreamFirstPeriodStartDateAdjusted = view.GetDateOnly(40078);
			StreamFirstRegularPeriodStartDateUnadjusted = view.GetDateOnly(40079);
			StreamFirstCompoundingPeriodEndDateUnadjusted = view.GetDateOnly(40080);
			StreamLastRegularPeriodEndDateUnadjusted = view.GetDateOnly(40081);
			StreamCalculationFrequencyPeriod = view.GetInt32(40082);
			StreamCalculationFrequencyUnit = view.GetString(40083);
			StreamCalculationRollConvention = view.GetString(40084);
			StreamCalculationBalanceOfFirstPeriod = view.GetBool(41246);
			StreamCalculationCorrectionPeriod = view.GetInt32(41247);
			StreamCalculationCorrectionUnit = view.GetString(41248);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "StreamCalculationPeriodDatesXID":
				{
					value = StreamCalculationPeriodDatesXID;
					break;
				}
				case "StreamCalculationPeriodDatesXIDRef":
				{
					value = StreamCalculationPeriodDatesXIDRef;
					break;
				}
				case "StreamCalculationPeriodBusinessDayConvention":
				{
					value = StreamCalculationPeriodBusinessDayConvention;
					break;
				}
				case "StreamCalculationPeriodBusinessCenterGrp":
				{
					value = StreamCalculationPeriodBusinessCenterGrp;
					break;
				}
				case "StreamCalculationPeriodDateGrp":
				{
					value = StreamCalculationPeriodDateGrp;
					break;
				}
				case "StreamFirstPeriodStartDateUnadjusted":
				{
					value = StreamFirstPeriodStartDateUnadjusted;
					break;
				}
				case "StreamFirstPeriodStartDateBusinessDayConvention":
				{
					value = StreamFirstPeriodStartDateBusinessDayConvention;
					break;
				}
				case "StreamFirstPeriodStartDateBusinessCenterGrp":
				{
					value = StreamFirstPeriodStartDateBusinessCenterGrp;
					break;
				}
				case "StreamFirstPeriodStartDateAdjusted":
				{
					value = StreamFirstPeriodStartDateAdjusted;
					break;
				}
				case "StreamFirstRegularPeriodStartDateUnadjusted":
				{
					value = StreamFirstRegularPeriodStartDateUnadjusted;
					break;
				}
				case "StreamFirstCompoundingPeriodEndDateUnadjusted":
				{
					value = StreamFirstCompoundingPeriodEndDateUnadjusted;
					break;
				}
				case "StreamLastRegularPeriodEndDateUnadjusted":
				{
					value = StreamLastRegularPeriodEndDateUnadjusted;
					break;
				}
				case "StreamCalculationFrequencyPeriod":
				{
					value = StreamCalculationFrequencyPeriod;
					break;
				}
				case "StreamCalculationFrequencyUnit":
				{
					value = StreamCalculationFrequencyUnit;
					break;
				}
				case "StreamCalculationRollConvention":
				{
					value = StreamCalculationRollConvention;
					break;
				}
				case "StreamCalculationBalanceOfFirstPeriod":
				{
					value = StreamCalculationBalanceOfFirstPeriod;
					break;
				}
				case "StreamCalculationCorrectionPeriod":
				{
					value = StreamCalculationCorrectionPeriod;
					break;
				}
				case "StreamCalculationCorrectionUnit":
				{
					value = StreamCalculationCorrectionUnit;
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
			StreamCalculationPeriodDatesXID = null;
			StreamCalculationPeriodDatesXIDRef = null;
			StreamCalculationPeriodBusinessDayConvention = null;
			((IFixReset?)StreamCalculationPeriodBusinessCenterGrp)?.Reset();
			((IFixReset?)StreamCalculationPeriodDateGrp)?.Reset();
			StreamFirstPeriodStartDateUnadjusted = null;
			StreamFirstPeriodStartDateBusinessDayConvention = null;
			((IFixReset?)StreamFirstPeriodStartDateBusinessCenterGrp)?.Reset();
			StreamFirstPeriodStartDateAdjusted = null;
			StreamFirstRegularPeriodStartDateUnadjusted = null;
			StreamFirstCompoundingPeriodEndDateUnadjusted = null;
			StreamLastRegularPeriodEndDateUnadjusted = null;
			StreamCalculationFrequencyPeriod = null;
			StreamCalculationFrequencyUnit = null;
			StreamCalculationRollConvention = null;
			StreamCalculationBalanceOfFirstPeriod = null;
			StreamCalculationCorrectionPeriod = null;
			StreamCalculationCorrectionUnit = null;
		}
	}
}
