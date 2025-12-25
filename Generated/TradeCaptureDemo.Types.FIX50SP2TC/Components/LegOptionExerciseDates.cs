using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegOptionExerciseDates : IFixComponent
	{
		[TagDetails(Tag = 41493, Type = TagType.Int, Offset = 0, Required = false)]
		public int? LegOptionExerciseBusinessDayConvention {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public LegOptionExerciseBusinessCenterGrp? LegOptionExerciseBusinessCenterGrp {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public LegOptionExerciseDateGrp? LegOptionExerciseDateGrp {get; set;}
		
		[TagDetails(Tag = 41494, Type = TagType.Int, Offset = 3, Required = false)]
		public int? LegOptionExerciseEarliestDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 41495, Type = TagType.Int, Offset = 4, Required = false)]
		public int? LegOptionExerciseEarliestDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 41496, Type = TagType.String, Offset = 5, Required = false)]
		public string? LegOptionExerciseEarliestDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 41497, Type = TagType.Int, Offset = 6, Required = false)]
		public int? LegOptionExerciseFrequencyPeriod {get; set;}
		
		[TagDetails(Tag = 41498, Type = TagType.String, Offset = 7, Required = false)]
		public string? LegOptionExerciseFrequencyUnit {get; set;}
		
		[TagDetails(Tag = 41499, Type = TagType.LocalDate, Offset = 8, Required = false)]
		public DateOnly? LegOptionExerciseStartDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 41500, Type = TagType.Int, Offset = 9, Required = false)]
		public int? LegOptionExerciseStartDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 41501, Type = TagType.Int, Offset = 10, Required = false)]
		public int? LegOptionExerciseStartDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 41502, Type = TagType.String, Offset = 11, Required = false)]
		public string? LegOptionExerciseStartDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 41503, Type = TagType.Int, Offset = 12, Required = false)]
		public int? LegOptionExerciseStartDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 41504, Type = TagType.LocalDate, Offset = 13, Required = false)]
		public DateOnly? LegOptionExerciseStartDateAdjusted {get; set;}
		
		[TagDetails(Tag = 41505, Type = TagType.Int, Offset = 14, Required = false)]
		public int? LegOptionExerciseSkip {get; set;}
		
		[TagDetails(Tag = 41506, Type = TagType.LocalDate, Offset = 15, Required = false)]
		public DateOnly? LegOptionExerciseNominationDeadline {get; set;}
		
		[TagDetails(Tag = 41507, Type = TagType.LocalDate, Offset = 16, Required = false)]
		public DateOnly? LegOptionExerciseFirstDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 41508, Type = TagType.LocalDate, Offset = 17, Required = false)]
		public DateOnly? LegOptionExerciseLastDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 41509, Type = TagType.String, Offset = 18, Required = false)]
		public string? LegOptionExerciseEarliestTime {get; set;}
		
		[TagDetails(Tag = 41510, Type = TagType.String, Offset = 19, Required = false)]
		public string? LegOptionExerciseLatestTime {get; set;}
		
		[TagDetails(Tag = 41511, Type = TagType.String, Offset = 20, Required = false)]
		public string? LegOptionExerciseTimeBusinessCenter {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegOptionExerciseBusinessDayConvention is not null) writer.WriteWholeNumber(41493, LegOptionExerciseBusinessDayConvention.Value);
			if (LegOptionExerciseBusinessCenterGrp is not null) ((IFixEncoder)LegOptionExerciseBusinessCenterGrp).Encode(writer);
			if (LegOptionExerciseDateGrp is not null) ((IFixEncoder)LegOptionExerciseDateGrp).Encode(writer);
			if (LegOptionExerciseEarliestDateOffsetDayType is not null) writer.WriteWholeNumber(41494, LegOptionExerciseEarliestDateOffsetDayType.Value);
			if (LegOptionExerciseEarliestDateOffsetPeriod is not null) writer.WriteWholeNumber(41495, LegOptionExerciseEarliestDateOffsetPeriod.Value);
			if (LegOptionExerciseEarliestDateOffsetUnit is not null) writer.WriteString(41496, LegOptionExerciseEarliestDateOffsetUnit);
			if (LegOptionExerciseFrequencyPeriod is not null) writer.WriteWholeNumber(41497, LegOptionExerciseFrequencyPeriod.Value);
			if (LegOptionExerciseFrequencyUnit is not null) writer.WriteString(41498, LegOptionExerciseFrequencyUnit);
			if (LegOptionExerciseStartDateUnadjusted is not null) writer.WriteLocalDateOnly(41499, LegOptionExerciseStartDateUnadjusted.Value);
			if (LegOptionExerciseStartDateRelativeTo is not null) writer.WriteWholeNumber(41500, LegOptionExerciseStartDateRelativeTo.Value);
			if (LegOptionExerciseStartDateOffsetPeriod is not null) writer.WriteWholeNumber(41501, LegOptionExerciseStartDateOffsetPeriod.Value);
			if (LegOptionExerciseStartDateOffsetUnit is not null) writer.WriteString(41502, LegOptionExerciseStartDateOffsetUnit);
			if (LegOptionExerciseStartDateOffsetDayType is not null) writer.WriteWholeNumber(41503, LegOptionExerciseStartDateOffsetDayType.Value);
			if (LegOptionExerciseStartDateAdjusted is not null) writer.WriteLocalDateOnly(41504, LegOptionExerciseStartDateAdjusted.Value);
			if (LegOptionExerciseSkip is not null) writer.WriteWholeNumber(41505, LegOptionExerciseSkip.Value);
			if (LegOptionExerciseNominationDeadline is not null) writer.WriteLocalDateOnly(41506, LegOptionExerciseNominationDeadline.Value);
			if (LegOptionExerciseFirstDateUnadjusted is not null) writer.WriteLocalDateOnly(41507, LegOptionExerciseFirstDateUnadjusted.Value);
			if (LegOptionExerciseLastDateUnadjusted is not null) writer.WriteLocalDateOnly(41508, LegOptionExerciseLastDateUnadjusted.Value);
			if (LegOptionExerciseEarliestTime is not null) writer.WriteString(41509, LegOptionExerciseEarliestTime);
			if (LegOptionExerciseLatestTime is not null) writer.WriteString(41510, LegOptionExerciseLatestTime);
			if (LegOptionExerciseTimeBusinessCenter is not null) writer.WriteString(41511, LegOptionExerciseTimeBusinessCenter);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegOptionExerciseBusinessDayConvention = view.GetInt32(41493);
			if (view.GetView("LegOptionExerciseBusinessCenterGrp") is IMessageView viewLegOptionExerciseBusinessCenterGrp)
			{
				LegOptionExerciseBusinessCenterGrp = new();
				((IFixParser)LegOptionExerciseBusinessCenterGrp).Parse(viewLegOptionExerciseBusinessCenterGrp);
			}
			if (view.GetView("LegOptionExerciseDateGrp") is IMessageView viewLegOptionExerciseDateGrp)
			{
				LegOptionExerciseDateGrp = new();
				((IFixParser)LegOptionExerciseDateGrp).Parse(viewLegOptionExerciseDateGrp);
			}
			LegOptionExerciseEarliestDateOffsetDayType = view.GetInt32(41494);
			LegOptionExerciseEarliestDateOffsetPeriod = view.GetInt32(41495);
			LegOptionExerciseEarliestDateOffsetUnit = view.GetString(41496);
			LegOptionExerciseFrequencyPeriod = view.GetInt32(41497);
			LegOptionExerciseFrequencyUnit = view.GetString(41498);
			LegOptionExerciseStartDateUnadjusted = view.GetDateOnly(41499);
			LegOptionExerciseStartDateRelativeTo = view.GetInt32(41500);
			LegOptionExerciseStartDateOffsetPeriod = view.GetInt32(41501);
			LegOptionExerciseStartDateOffsetUnit = view.GetString(41502);
			LegOptionExerciseStartDateOffsetDayType = view.GetInt32(41503);
			LegOptionExerciseStartDateAdjusted = view.GetDateOnly(41504);
			LegOptionExerciseSkip = view.GetInt32(41505);
			LegOptionExerciseNominationDeadline = view.GetDateOnly(41506);
			LegOptionExerciseFirstDateUnadjusted = view.GetDateOnly(41507);
			LegOptionExerciseLastDateUnadjusted = view.GetDateOnly(41508);
			LegOptionExerciseEarliestTime = view.GetString(41509);
			LegOptionExerciseLatestTime = view.GetString(41510);
			LegOptionExerciseTimeBusinessCenter = view.GetString(41511);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegOptionExerciseBusinessDayConvention":
				{
					value = LegOptionExerciseBusinessDayConvention;
					break;
				}
				case "LegOptionExerciseBusinessCenterGrp":
				{
					value = LegOptionExerciseBusinessCenterGrp;
					break;
				}
				case "LegOptionExerciseDateGrp":
				{
					value = LegOptionExerciseDateGrp;
					break;
				}
				case "LegOptionExerciseEarliestDateOffsetDayType":
				{
					value = LegOptionExerciseEarliestDateOffsetDayType;
					break;
				}
				case "LegOptionExerciseEarliestDateOffsetPeriod":
				{
					value = LegOptionExerciseEarliestDateOffsetPeriod;
					break;
				}
				case "LegOptionExerciseEarliestDateOffsetUnit":
				{
					value = LegOptionExerciseEarliestDateOffsetUnit;
					break;
				}
				case "LegOptionExerciseFrequencyPeriod":
				{
					value = LegOptionExerciseFrequencyPeriod;
					break;
				}
				case "LegOptionExerciseFrequencyUnit":
				{
					value = LegOptionExerciseFrequencyUnit;
					break;
				}
				case "LegOptionExerciseStartDateUnadjusted":
				{
					value = LegOptionExerciseStartDateUnadjusted;
					break;
				}
				case "LegOptionExerciseStartDateRelativeTo":
				{
					value = LegOptionExerciseStartDateRelativeTo;
					break;
				}
				case "LegOptionExerciseStartDateOffsetPeriod":
				{
					value = LegOptionExerciseStartDateOffsetPeriod;
					break;
				}
				case "LegOptionExerciseStartDateOffsetUnit":
				{
					value = LegOptionExerciseStartDateOffsetUnit;
					break;
				}
				case "LegOptionExerciseStartDateOffsetDayType":
				{
					value = LegOptionExerciseStartDateOffsetDayType;
					break;
				}
				case "LegOptionExerciseStartDateAdjusted":
				{
					value = LegOptionExerciseStartDateAdjusted;
					break;
				}
				case "LegOptionExerciseSkip":
				{
					value = LegOptionExerciseSkip;
					break;
				}
				case "LegOptionExerciseNominationDeadline":
				{
					value = LegOptionExerciseNominationDeadline;
					break;
				}
				case "LegOptionExerciseFirstDateUnadjusted":
				{
					value = LegOptionExerciseFirstDateUnadjusted;
					break;
				}
				case "LegOptionExerciseLastDateUnadjusted":
				{
					value = LegOptionExerciseLastDateUnadjusted;
					break;
				}
				case "LegOptionExerciseEarliestTime":
				{
					value = LegOptionExerciseEarliestTime;
					break;
				}
				case "LegOptionExerciseLatestTime":
				{
					value = LegOptionExerciseLatestTime;
					break;
				}
				case "LegOptionExerciseTimeBusinessCenter":
				{
					value = LegOptionExerciseTimeBusinessCenter;
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
			LegOptionExerciseBusinessDayConvention = null;
			((IFixReset?)LegOptionExerciseBusinessCenterGrp)?.Reset();
			((IFixReset?)LegOptionExerciseDateGrp)?.Reset();
			LegOptionExerciseEarliestDateOffsetDayType = null;
			LegOptionExerciseEarliestDateOffsetPeriod = null;
			LegOptionExerciseEarliestDateOffsetUnit = null;
			LegOptionExerciseFrequencyPeriod = null;
			LegOptionExerciseFrequencyUnit = null;
			LegOptionExerciseStartDateUnadjusted = null;
			LegOptionExerciseStartDateRelativeTo = null;
			LegOptionExerciseStartDateOffsetPeriod = null;
			LegOptionExerciseStartDateOffsetUnit = null;
			LegOptionExerciseStartDateOffsetDayType = null;
			LegOptionExerciseStartDateAdjusted = null;
			LegOptionExerciseSkip = null;
			LegOptionExerciseNominationDeadline = null;
			LegOptionExerciseFirstDateUnadjusted = null;
			LegOptionExerciseLastDateUnadjusted = null;
			LegOptionExerciseEarliestTime = null;
			LegOptionExerciseLatestTime = null;
			LegOptionExerciseTimeBusinessCenter = null;
		}
	}
}
