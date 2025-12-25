using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingOptionExerciseDates : IFixComponent
	{
		[TagDetails(Tag = 41822, Type = TagType.Int, Offset = 0, Required = false)]
		public int? UnderlyingOptionExerciseBusinessDayConvention {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public UnderlyingOptionExerciseBusinessCenterGrp? UnderlyingOptionExerciseBusinessCenterGrp {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public UnderlyingOptionExerciseDateGrp? UnderlyingOptionExerciseDateGrp {get; set;}
		
		[TagDetails(Tag = 41823, Type = TagType.Int, Offset = 3, Required = false)]
		public int? UnderlyingOptionExerciseEarliestDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 41824, Type = TagType.Int, Offset = 4, Required = false)]
		public int? UnderlyingOptionExerciseEarliestDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 41825, Type = TagType.String, Offset = 5, Required = false)]
		public string? UnderlyingOptionExerciseEarliestDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 41826, Type = TagType.Int, Offset = 6, Required = false)]
		public int? UnderlyingOptionExerciseFrequencyPeriod {get; set;}
		
		[TagDetails(Tag = 41827, Type = TagType.String, Offset = 7, Required = false)]
		public string? UnderlyingOptionExerciseFrequencyUnit {get; set;}
		
		[TagDetails(Tag = 41828, Type = TagType.LocalDate, Offset = 8, Required = false)]
		public DateOnly? UnderlyingOptionExerciseStartDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 41829, Type = TagType.Int, Offset = 9, Required = false)]
		public int? UnderlyingOptionExerciseStartDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 41830, Type = TagType.Int, Offset = 10, Required = false)]
		public int? UnderlyingOptionExerciseStartDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 41831, Type = TagType.String, Offset = 11, Required = false)]
		public string? UnderlyingOptionExerciseStartDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 41832, Type = TagType.Int, Offset = 12, Required = false)]
		public int? UnderlyingOptionExerciseStartDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 41833, Type = TagType.LocalDate, Offset = 13, Required = false)]
		public DateOnly? UnderlyingOptionExerciseStartDateAdjusted {get; set;}
		
		[TagDetails(Tag = 41834, Type = TagType.Int, Offset = 14, Required = false)]
		public int? UnderlyingOptionExerciseSkip {get; set;}
		
		[TagDetails(Tag = 41835, Type = TagType.LocalDate, Offset = 15, Required = false)]
		public DateOnly? UnderlyingOptionExerciseNominationDeadline {get; set;}
		
		[TagDetails(Tag = 41836, Type = TagType.LocalDate, Offset = 16, Required = false)]
		public DateOnly? UnderlyingOptionExerciseFirstDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 41837, Type = TagType.LocalDate, Offset = 17, Required = false)]
		public DateOnly? UnderlyingOptionExerciseLastDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 41838, Type = TagType.String, Offset = 18, Required = false)]
		public string? UnderlyingOptionExerciseEarliestTime {get; set;}
		
		[TagDetails(Tag = 41839, Type = TagType.String, Offset = 19, Required = false)]
		public string? UnderlyingOptionExerciseLatestTime {get; set;}
		
		[TagDetails(Tag = 41840, Type = TagType.String, Offset = 20, Required = false)]
		public string? UnderlyingOptionExerciseTimeBusinessCenter {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingOptionExerciseBusinessDayConvention is not null) writer.WriteWholeNumber(41822, UnderlyingOptionExerciseBusinessDayConvention.Value);
			if (UnderlyingOptionExerciseBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingOptionExerciseBusinessCenterGrp).Encode(writer);
			if (UnderlyingOptionExerciseDateGrp is not null) ((IFixEncoder)UnderlyingOptionExerciseDateGrp).Encode(writer);
			if (UnderlyingOptionExerciseEarliestDateOffsetDayType is not null) writer.WriteWholeNumber(41823, UnderlyingOptionExerciseEarliestDateOffsetDayType.Value);
			if (UnderlyingOptionExerciseEarliestDateOffsetPeriod is not null) writer.WriteWholeNumber(41824, UnderlyingOptionExerciseEarliestDateOffsetPeriod.Value);
			if (UnderlyingOptionExerciseEarliestDateOffsetUnit is not null) writer.WriteString(41825, UnderlyingOptionExerciseEarliestDateOffsetUnit);
			if (UnderlyingOptionExerciseFrequencyPeriod is not null) writer.WriteWholeNumber(41826, UnderlyingOptionExerciseFrequencyPeriod.Value);
			if (UnderlyingOptionExerciseFrequencyUnit is not null) writer.WriteString(41827, UnderlyingOptionExerciseFrequencyUnit);
			if (UnderlyingOptionExerciseStartDateUnadjusted is not null) writer.WriteLocalDateOnly(41828, UnderlyingOptionExerciseStartDateUnadjusted.Value);
			if (UnderlyingOptionExerciseStartDateRelativeTo is not null) writer.WriteWholeNumber(41829, UnderlyingOptionExerciseStartDateRelativeTo.Value);
			if (UnderlyingOptionExerciseStartDateOffsetPeriod is not null) writer.WriteWholeNumber(41830, UnderlyingOptionExerciseStartDateOffsetPeriod.Value);
			if (UnderlyingOptionExerciseStartDateOffsetUnit is not null) writer.WriteString(41831, UnderlyingOptionExerciseStartDateOffsetUnit);
			if (UnderlyingOptionExerciseStartDateOffsetDayType is not null) writer.WriteWholeNumber(41832, UnderlyingOptionExerciseStartDateOffsetDayType.Value);
			if (UnderlyingOptionExerciseStartDateAdjusted is not null) writer.WriteLocalDateOnly(41833, UnderlyingOptionExerciseStartDateAdjusted.Value);
			if (UnderlyingOptionExerciseSkip is not null) writer.WriteWholeNumber(41834, UnderlyingOptionExerciseSkip.Value);
			if (UnderlyingOptionExerciseNominationDeadline is not null) writer.WriteLocalDateOnly(41835, UnderlyingOptionExerciseNominationDeadline.Value);
			if (UnderlyingOptionExerciseFirstDateUnadjusted is not null) writer.WriteLocalDateOnly(41836, UnderlyingOptionExerciseFirstDateUnadjusted.Value);
			if (UnderlyingOptionExerciseLastDateUnadjusted is not null) writer.WriteLocalDateOnly(41837, UnderlyingOptionExerciseLastDateUnadjusted.Value);
			if (UnderlyingOptionExerciseEarliestTime is not null) writer.WriteString(41838, UnderlyingOptionExerciseEarliestTime);
			if (UnderlyingOptionExerciseLatestTime is not null) writer.WriteString(41839, UnderlyingOptionExerciseLatestTime);
			if (UnderlyingOptionExerciseTimeBusinessCenter is not null) writer.WriteString(41840, UnderlyingOptionExerciseTimeBusinessCenter);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingOptionExerciseBusinessDayConvention = view.GetInt32(41822);
			if (view.GetView("UnderlyingOptionExerciseBusinessCenterGrp") is IMessageView viewUnderlyingOptionExerciseBusinessCenterGrp)
			{
				UnderlyingOptionExerciseBusinessCenterGrp = new();
				((IFixParser)UnderlyingOptionExerciseBusinessCenterGrp).Parse(viewUnderlyingOptionExerciseBusinessCenterGrp);
			}
			if (view.GetView("UnderlyingOptionExerciseDateGrp") is IMessageView viewUnderlyingOptionExerciseDateGrp)
			{
				UnderlyingOptionExerciseDateGrp = new();
				((IFixParser)UnderlyingOptionExerciseDateGrp).Parse(viewUnderlyingOptionExerciseDateGrp);
			}
			UnderlyingOptionExerciseEarliestDateOffsetDayType = view.GetInt32(41823);
			UnderlyingOptionExerciseEarliestDateOffsetPeriod = view.GetInt32(41824);
			UnderlyingOptionExerciseEarliestDateOffsetUnit = view.GetString(41825);
			UnderlyingOptionExerciseFrequencyPeriod = view.GetInt32(41826);
			UnderlyingOptionExerciseFrequencyUnit = view.GetString(41827);
			UnderlyingOptionExerciseStartDateUnadjusted = view.GetDateOnly(41828);
			UnderlyingOptionExerciseStartDateRelativeTo = view.GetInt32(41829);
			UnderlyingOptionExerciseStartDateOffsetPeriod = view.GetInt32(41830);
			UnderlyingOptionExerciseStartDateOffsetUnit = view.GetString(41831);
			UnderlyingOptionExerciseStartDateOffsetDayType = view.GetInt32(41832);
			UnderlyingOptionExerciseStartDateAdjusted = view.GetDateOnly(41833);
			UnderlyingOptionExerciseSkip = view.GetInt32(41834);
			UnderlyingOptionExerciseNominationDeadline = view.GetDateOnly(41835);
			UnderlyingOptionExerciseFirstDateUnadjusted = view.GetDateOnly(41836);
			UnderlyingOptionExerciseLastDateUnadjusted = view.GetDateOnly(41837);
			UnderlyingOptionExerciseEarliestTime = view.GetString(41838);
			UnderlyingOptionExerciseLatestTime = view.GetString(41839);
			UnderlyingOptionExerciseTimeBusinessCenter = view.GetString(41840);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingOptionExerciseBusinessDayConvention":
				{
					value = UnderlyingOptionExerciseBusinessDayConvention;
					break;
				}
				case "UnderlyingOptionExerciseBusinessCenterGrp":
				{
					value = UnderlyingOptionExerciseBusinessCenterGrp;
					break;
				}
				case "UnderlyingOptionExerciseDateGrp":
				{
					value = UnderlyingOptionExerciseDateGrp;
					break;
				}
				case "UnderlyingOptionExerciseEarliestDateOffsetDayType":
				{
					value = UnderlyingOptionExerciseEarliestDateOffsetDayType;
					break;
				}
				case "UnderlyingOptionExerciseEarliestDateOffsetPeriod":
				{
					value = UnderlyingOptionExerciseEarliestDateOffsetPeriod;
					break;
				}
				case "UnderlyingOptionExerciseEarliestDateOffsetUnit":
				{
					value = UnderlyingOptionExerciseEarliestDateOffsetUnit;
					break;
				}
				case "UnderlyingOptionExerciseFrequencyPeriod":
				{
					value = UnderlyingOptionExerciseFrequencyPeriod;
					break;
				}
				case "UnderlyingOptionExerciseFrequencyUnit":
				{
					value = UnderlyingOptionExerciseFrequencyUnit;
					break;
				}
				case "UnderlyingOptionExerciseStartDateUnadjusted":
				{
					value = UnderlyingOptionExerciseStartDateUnadjusted;
					break;
				}
				case "UnderlyingOptionExerciseStartDateRelativeTo":
				{
					value = UnderlyingOptionExerciseStartDateRelativeTo;
					break;
				}
				case "UnderlyingOptionExerciseStartDateOffsetPeriod":
				{
					value = UnderlyingOptionExerciseStartDateOffsetPeriod;
					break;
				}
				case "UnderlyingOptionExerciseStartDateOffsetUnit":
				{
					value = UnderlyingOptionExerciseStartDateOffsetUnit;
					break;
				}
				case "UnderlyingOptionExerciseStartDateOffsetDayType":
				{
					value = UnderlyingOptionExerciseStartDateOffsetDayType;
					break;
				}
				case "UnderlyingOptionExerciseStartDateAdjusted":
				{
					value = UnderlyingOptionExerciseStartDateAdjusted;
					break;
				}
				case "UnderlyingOptionExerciseSkip":
				{
					value = UnderlyingOptionExerciseSkip;
					break;
				}
				case "UnderlyingOptionExerciseNominationDeadline":
				{
					value = UnderlyingOptionExerciseNominationDeadline;
					break;
				}
				case "UnderlyingOptionExerciseFirstDateUnadjusted":
				{
					value = UnderlyingOptionExerciseFirstDateUnadjusted;
					break;
				}
				case "UnderlyingOptionExerciseLastDateUnadjusted":
				{
					value = UnderlyingOptionExerciseLastDateUnadjusted;
					break;
				}
				case "UnderlyingOptionExerciseEarliestTime":
				{
					value = UnderlyingOptionExerciseEarliestTime;
					break;
				}
				case "UnderlyingOptionExerciseLatestTime":
				{
					value = UnderlyingOptionExerciseLatestTime;
					break;
				}
				case "UnderlyingOptionExerciseTimeBusinessCenter":
				{
					value = UnderlyingOptionExerciseTimeBusinessCenter;
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
			UnderlyingOptionExerciseBusinessDayConvention = null;
			((IFixReset?)UnderlyingOptionExerciseBusinessCenterGrp)?.Reset();
			((IFixReset?)UnderlyingOptionExerciseDateGrp)?.Reset();
			UnderlyingOptionExerciseEarliestDateOffsetDayType = null;
			UnderlyingOptionExerciseEarliestDateOffsetPeriod = null;
			UnderlyingOptionExerciseEarliestDateOffsetUnit = null;
			UnderlyingOptionExerciseFrequencyPeriod = null;
			UnderlyingOptionExerciseFrequencyUnit = null;
			UnderlyingOptionExerciseStartDateUnadjusted = null;
			UnderlyingOptionExerciseStartDateRelativeTo = null;
			UnderlyingOptionExerciseStartDateOffsetPeriod = null;
			UnderlyingOptionExerciseStartDateOffsetUnit = null;
			UnderlyingOptionExerciseStartDateOffsetDayType = null;
			UnderlyingOptionExerciseStartDateAdjusted = null;
			UnderlyingOptionExerciseSkip = null;
			UnderlyingOptionExerciseNominationDeadline = null;
			UnderlyingOptionExerciseFirstDateUnadjusted = null;
			UnderlyingOptionExerciseLastDateUnadjusted = null;
			UnderlyingOptionExerciseEarliestTime = null;
			UnderlyingOptionExerciseLatestTime = null;
			UnderlyingOptionExerciseTimeBusinessCenter = null;
		}
	}
}
