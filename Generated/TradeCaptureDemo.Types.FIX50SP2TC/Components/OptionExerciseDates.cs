using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class OptionExerciseDates : IFixComponent
	{
		[TagDetails(Tag = 41118, Type = TagType.Int, Offset = 0, Required = false)]
		public int? OptionExerciseBusinessDayConvention {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public OptionExerciseBusinessCenterGrp? OptionExerciseBusinessCenterGrp {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public OptionExerciseDateGrp? OptionExerciseDateGrp {get; set;}
		
		[TagDetails(Tag = 41119, Type = TagType.Int, Offset = 3, Required = false)]
		public int? OptionExerciseEarliestDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 41120, Type = TagType.Int, Offset = 4, Required = false)]
		public int? OptionExerciseEarliestDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 41121, Type = TagType.String, Offset = 5, Required = false)]
		public string? OptionExerciseEarliestDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 41122, Type = TagType.Int, Offset = 6, Required = false)]
		public int? OptionExerciseFrequencyPeriod {get; set;}
		
		[TagDetails(Tag = 41123, Type = TagType.String, Offset = 7, Required = false)]
		public string? OptionExerciseFrequencyUnit {get; set;}
		
		[TagDetails(Tag = 41124, Type = TagType.LocalDate, Offset = 8, Required = false)]
		public DateOnly? OptionExerciseStartDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 41125, Type = TagType.Int, Offset = 9, Required = false)]
		public int? OptionExerciseStartDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 41126, Type = TagType.Int, Offset = 10, Required = false)]
		public int? OptionExerciseStartDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 41127, Type = TagType.String, Offset = 11, Required = false)]
		public string? OptionExerciseStartDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 41128, Type = TagType.Int, Offset = 12, Required = false)]
		public int? OptionExerciseStartDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 41129, Type = TagType.LocalDate, Offset = 13, Required = false)]
		public DateOnly? OptionExerciseStartDateAdjusted {get; set;}
		
		[TagDetails(Tag = 41130, Type = TagType.Int, Offset = 14, Required = false)]
		public int? OptionExerciseSkip {get; set;}
		
		[TagDetails(Tag = 41131, Type = TagType.LocalDate, Offset = 15, Required = false)]
		public DateOnly? OptionExerciseNominationDeadline {get; set;}
		
		[TagDetails(Tag = 41132, Type = TagType.LocalDate, Offset = 16, Required = false)]
		public DateOnly? OptionExerciseFirstDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 41133, Type = TagType.LocalDate, Offset = 17, Required = false)]
		public DateOnly? OptionExerciseLastDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 41134, Type = TagType.String, Offset = 18, Required = false)]
		public string? OptionExerciseEarliestTime {get; set;}
		
		[TagDetails(Tag = 41135, Type = TagType.String, Offset = 19, Required = false)]
		public string? OptionExerciseLatestTime {get; set;}
		
		[TagDetails(Tag = 41136, Type = TagType.String, Offset = 20, Required = false)]
		public string? OptionExerciseTimeBusinessCenter {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (OptionExerciseBusinessDayConvention is not null) writer.WriteWholeNumber(41118, OptionExerciseBusinessDayConvention.Value);
			if (OptionExerciseBusinessCenterGrp is not null) ((IFixEncoder)OptionExerciseBusinessCenterGrp).Encode(writer);
			if (OptionExerciseDateGrp is not null) ((IFixEncoder)OptionExerciseDateGrp).Encode(writer);
			if (OptionExerciseEarliestDateOffsetDayType is not null) writer.WriteWholeNumber(41119, OptionExerciseEarliestDateOffsetDayType.Value);
			if (OptionExerciseEarliestDateOffsetPeriod is not null) writer.WriteWholeNumber(41120, OptionExerciseEarliestDateOffsetPeriod.Value);
			if (OptionExerciseEarliestDateOffsetUnit is not null) writer.WriteString(41121, OptionExerciseEarliestDateOffsetUnit);
			if (OptionExerciseFrequencyPeriod is not null) writer.WriteWholeNumber(41122, OptionExerciseFrequencyPeriod.Value);
			if (OptionExerciseFrequencyUnit is not null) writer.WriteString(41123, OptionExerciseFrequencyUnit);
			if (OptionExerciseStartDateUnadjusted is not null) writer.WriteLocalDateOnly(41124, OptionExerciseStartDateUnadjusted.Value);
			if (OptionExerciseStartDateRelativeTo is not null) writer.WriteWholeNumber(41125, OptionExerciseStartDateRelativeTo.Value);
			if (OptionExerciseStartDateOffsetPeriod is not null) writer.WriteWholeNumber(41126, OptionExerciseStartDateOffsetPeriod.Value);
			if (OptionExerciseStartDateOffsetUnit is not null) writer.WriteString(41127, OptionExerciseStartDateOffsetUnit);
			if (OptionExerciseStartDateOffsetDayType is not null) writer.WriteWholeNumber(41128, OptionExerciseStartDateOffsetDayType.Value);
			if (OptionExerciseStartDateAdjusted is not null) writer.WriteLocalDateOnly(41129, OptionExerciseStartDateAdjusted.Value);
			if (OptionExerciseSkip is not null) writer.WriteWholeNumber(41130, OptionExerciseSkip.Value);
			if (OptionExerciseNominationDeadline is not null) writer.WriteLocalDateOnly(41131, OptionExerciseNominationDeadline.Value);
			if (OptionExerciseFirstDateUnadjusted is not null) writer.WriteLocalDateOnly(41132, OptionExerciseFirstDateUnadjusted.Value);
			if (OptionExerciseLastDateUnadjusted is not null) writer.WriteLocalDateOnly(41133, OptionExerciseLastDateUnadjusted.Value);
			if (OptionExerciseEarliestTime is not null) writer.WriteString(41134, OptionExerciseEarliestTime);
			if (OptionExerciseLatestTime is not null) writer.WriteString(41135, OptionExerciseLatestTime);
			if (OptionExerciseTimeBusinessCenter is not null) writer.WriteString(41136, OptionExerciseTimeBusinessCenter);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			OptionExerciseBusinessDayConvention = view.GetInt32(41118);
			if (view.GetView("OptionExerciseBusinessCenterGrp") is IMessageView viewOptionExerciseBusinessCenterGrp)
			{
				OptionExerciseBusinessCenterGrp = new();
				((IFixParser)OptionExerciseBusinessCenterGrp).Parse(viewOptionExerciseBusinessCenterGrp);
			}
			if (view.GetView("OptionExerciseDateGrp") is IMessageView viewOptionExerciseDateGrp)
			{
				OptionExerciseDateGrp = new();
				((IFixParser)OptionExerciseDateGrp).Parse(viewOptionExerciseDateGrp);
			}
			OptionExerciseEarliestDateOffsetDayType = view.GetInt32(41119);
			OptionExerciseEarliestDateOffsetPeriod = view.GetInt32(41120);
			OptionExerciseEarliestDateOffsetUnit = view.GetString(41121);
			OptionExerciseFrequencyPeriod = view.GetInt32(41122);
			OptionExerciseFrequencyUnit = view.GetString(41123);
			OptionExerciseStartDateUnadjusted = view.GetDateOnly(41124);
			OptionExerciseStartDateRelativeTo = view.GetInt32(41125);
			OptionExerciseStartDateOffsetPeriod = view.GetInt32(41126);
			OptionExerciseStartDateOffsetUnit = view.GetString(41127);
			OptionExerciseStartDateOffsetDayType = view.GetInt32(41128);
			OptionExerciseStartDateAdjusted = view.GetDateOnly(41129);
			OptionExerciseSkip = view.GetInt32(41130);
			OptionExerciseNominationDeadline = view.GetDateOnly(41131);
			OptionExerciseFirstDateUnadjusted = view.GetDateOnly(41132);
			OptionExerciseLastDateUnadjusted = view.GetDateOnly(41133);
			OptionExerciseEarliestTime = view.GetString(41134);
			OptionExerciseLatestTime = view.GetString(41135);
			OptionExerciseTimeBusinessCenter = view.GetString(41136);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "OptionExerciseBusinessDayConvention":
				{
					value = OptionExerciseBusinessDayConvention;
					break;
				}
				case "OptionExerciseBusinessCenterGrp":
				{
					value = OptionExerciseBusinessCenterGrp;
					break;
				}
				case "OptionExerciseDateGrp":
				{
					value = OptionExerciseDateGrp;
					break;
				}
				case "OptionExerciseEarliestDateOffsetDayType":
				{
					value = OptionExerciseEarliestDateOffsetDayType;
					break;
				}
				case "OptionExerciseEarliestDateOffsetPeriod":
				{
					value = OptionExerciseEarliestDateOffsetPeriod;
					break;
				}
				case "OptionExerciseEarliestDateOffsetUnit":
				{
					value = OptionExerciseEarliestDateOffsetUnit;
					break;
				}
				case "OptionExerciseFrequencyPeriod":
				{
					value = OptionExerciseFrequencyPeriod;
					break;
				}
				case "OptionExerciseFrequencyUnit":
				{
					value = OptionExerciseFrequencyUnit;
					break;
				}
				case "OptionExerciseStartDateUnadjusted":
				{
					value = OptionExerciseStartDateUnadjusted;
					break;
				}
				case "OptionExerciseStartDateRelativeTo":
				{
					value = OptionExerciseStartDateRelativeTo;
					break;
				}
				case "OptionExerciseStartDateOffsetPeriod":
				{
					value = OptionExerciseStartDateOffsetPeriod;
					break;
				}
				case "OptionExerciseStartDateOffsetUnit":
				{
					value = OptionExerciseStartDateOffsetUnit;
					break;
				}
				case "OptionExerciseStartDateOffsetDayType":
				{
					value = OptionExerciseStartDateOffsetDayType;
					break;
				}
				case "OptionExerciseStartDateAdjusted":
				{
					value = OptionExerciseStartDateAdjusted;
					break;
				}
				case "OptionExerciseSkip":
				{
					value = OptionExerciseSkip;
					break;
				}
				case "OptionExerciseNominationDeadline":
				{
					value = OptionExerciseNominationDeadline;
					break;
				}
				case "OptionExerciseFirstDateUnadjusted":
				{
					value = OptionExerciseFirstDateUnadjusted;
					break;
				}
				case "OptionExerciseLastDateUnadjusted":
				{
					value = OptionExerciseLastDateUnadjusted;
					break;
				}
				case "OptionExerciseEarliestTime":
				{
					value = OptionExerciseEarliestTime;
					break;
				}
				case "OptionExerciseLatestTime":
				{
					value = OptionExerciseLatestTime;
					break;
				}
				case "OptionExerciseTimeBusinessCenter":
				{
					value = OptionExerciseTimeBusinessCenter;
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
			OptionExerciseBusinessDayConvention = null;
			((IFixReset?)OptionExerciseBusinessCenterGrp)?.Reset();
			((IFixReset?)OptionExerciseDateGrp)?.Reset();
			OptionExerciseEarliestDateOffsetDayType = null;
			OptionExerciseEarliestDateOffsetPeriod = null;
			OptionExerciseEarliestDateOffsetUnit = null;
			OptionExerciseFrequencyPeriod = null;
			OptionExerciseFrequencyUnit = null;
			OptionExerciseStartDateUnadjusted = null;
			OptionExerciseStartDateRelativeTo = null;
			OptionExerciseStartDateOffsetPeriod = null;
			OptionExerciseStartDateOffsetUnit = null;
			OptionExerciseStartDateOffsetDayType = null;
			OptionExerciseStartDateAdjusted = null;
			OptionExerciseSkip = null;
			OptionExerciseNominationDeadline = null;
			OptionExerciseFirstDateUnadjusted = null;
			OptionExerciseLastDateUnadjusted = null;
			OptionExerciseEarliestTime = null;
			OptionExerciseLatestTime = null;
			OptionExerciseTimeBusinessCenter = null;
		}
	}
}
