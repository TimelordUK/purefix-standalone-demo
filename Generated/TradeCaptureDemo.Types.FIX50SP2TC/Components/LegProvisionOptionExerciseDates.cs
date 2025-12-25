using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegProvisionOptionExerciseDates : IFixComponent
	{
		[TagDetails(Tag = 40476, Type = TagType.Int, Offset = 0, Required = false)]
		public int? LegProvisionOptionExerciseBusinessDayConvention {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public LegProvisionOptionExerciseBusinessCenterGrp? LegProvisionOptionExerciseBusinessCenterGrp {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public LegProvisionOptionExerciseFixedDateGrp? LegProvisionOptionExerciseFixedDateGrp {get; set;}
		
		[TagDetails(Tag = 40478, Type = TagType.Int, Offset = 3, Required = false)]
		public int? LegProvisionOptionExerciseEarliestDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40479, Type = TagType.String, Offset = 4, Required = false)]
		public string? LegProvisionOptionExerciseEarliestDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40480, Type = TagType.Int, Offset = 5, Required = false)]
		public int? LegProvisionOptionExerciseFrequencyPeriod {get; set;}
		
		[TagDetails(Tag = 40481, Type = TagType.String, Offset = 6, Required = false)]
		public string? LegProvisionOptionExerciseFrequencyUnit {get; set;}
		
		[TagDetails(Tag = 40482, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? LegProvisionOptionExerciseStartDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40483, Type = TagType.Int, Offset = 8, Required = false)]
		public int? LegProvisionOptionExerciseStartDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40484, Type = TagType.Int, Offset = 9, Required = false)]
		public int? LegProvisionOptionExerciseStartDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40485, Type = TagType.String, Offset = 10, Required = false)]
		public string? LegProvisionOptionExerciseStartDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40486, Type = TagType.Int, Offset = 11, Required = false)]
		public int? LegProvisionOptionExerciseStartDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 40487, Type = TagType.LocalDate, Offset = 12, Required = false)]
		public DateOnly? LegProvisionOptionExerciseStartDateAdjusted {get; set;}
		
		[TagDetails(Tag = 40488, Type = TagType.Int, Offset = 13, Required = false)]
		public int? LegProvisionOptionExercisePeriodSkip {get; set;}
		
		[TagDetails(Tag = 40489, Type = TagType.LocalDate, Offset = 14, Required = false)]
		public DateOnly? LegProvisionOptionExerciseBoundsFirstDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40490, Type = TagType.LocalDate, Offset = 15, Required = false)]
		public DateOnly? LegProvisionOptionExerciseBoundsLastDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40491, Type = TagType.String, Offset = 16, Required = false)]
		public string? LegProvisionOptionExerciseEarliestTime {get; set;}
		
		[TagDetails(Tag = 40492, Type = TagType.String, Offset = 17, Required = false)]
		public string? LegProvisionOptionExerciseEarliestTimeBusinessCenter {get; set;}
		
		[TagDetails(Tag = 40493, Type = TagType.String, Offset = 18, Required = false)]
		public string? LegProvisionOptionExerciseLatestTime {get; set;}
		
		[TagDetails(Tag = 40494, Type = TagType.String, Offset = 19, Required = false)]
		public string? LegProvisionOptionExerciseLatestTimeBusinessCenter {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegProvisionOptionExerciseBusinessDayConvention is not null) writer.WriteWholeNumber(40476, LegProvisionOptionExerciseBusinessDayConvention.Value);
			if (LegProvisionOptionExerciseBusinessCenterGrp is not null) ((IFixEncoder)LegProvisionOptionExerciseBusinessCenterGrp).Encode(writer);
			if (LegProvisionOptionExerciseFixedDateGrp is not null) ((IFixEncoder)LegProvisionOptionExerciseFixedDateGrp).Encode(writer);
			if (LegProvisionOptionExerciseEarliestDateOffsetPeriod is not null) writer.WriteWholeNumber(40478, LegProvisionOptionExerciseEarliestDateOffsetPeriod.Value);
			if (LegProvisionOptionExerciseEarliestDateOffsetUnit is not null) writer.WriteString(40479, LegProvisionOptionExerciseEarliestDateOffsetUnit);
			if (LegProvisionOptionExerciseFrequencyPeriod is not null) writer.WriteWholeNumber(40480, LegProvisionOptionExerciseFrequencyPeriod.Value);
			if (LegProvisionOptionExerciseFrequencyUnit is not null) writer.WriteString(40481, LegProvisionOptionExerciseFrequencyUnit);
			if (LegProvisionOptionExerciseStartDateUnadjusted is not null) writer.WriteLocalDateOnly(40482, LegProvisionOptionExerciseStartDateUnadjusted.Value);
			if (LegProvisionOptionExerciseStartDateRelativeTo is not null) writer.WriteWholeNumber(40483, LegProvisionOptionExerciseStartDateRelativeTo.Value);
			if (LegProvisionOptionExerciseStartDateOffsetPeriod is not null) writer.WriteWholeNumber(40484, LegProvisionOptionExerciseStartDateOffsetPeriod.Value);
			if (LegProvisionOptionExerciseStartDateOffsetUnit is not null) writer.WriteString(40485, LegProvisionOptionExerciseStartDateOffsetUnit);
			if (LegProvisionOptionExerciseStartDateOffsetDayType is not null) writer.WriteWholeNumber(40486, LegProvisionOptionExerciseStartDateOffsetDayType.Value);
			if (LegProvisionOptionExerciseStartDateAdjusted is not null) writer.WriteLocalDateOnly(40487, LegProvisionOptionExerciseStartDateAdjusted.Value);
			if (LegProvisionOptionExercisePeriodSkip is not null) writer.WriteWholeNumber(40488, LegProvisionOptionExercisePeriodSkip.Value);
			if (LegProvisionOptionExerciseBoundsFirstDateUnadjusted is not null) writer.WriteLocalDateOnly(40489, LegProvisionOptionExerciseBoundsFirstDateUnadjusted.Value);
			if (LegProvisionOptionExerciseBoundsLastDateUnadjusted is not null) writer.WriteLocalDateOnly(40490, LegProvisionOptionExerciseBoundsLastDateUnadjusted.Value);
			if (LegProvisionOptionExerciseEarliestTime is not null) writer.WriteString(40491, LegProvisionOptionExerciseEarliestTime);
			if (LegProvisionOptionExerciseEarliestTimeBusinessCenter is not null) writer.WriteString(40492, LegProvisionOptionExerciseEarliestTimeBusinessCenter);
			if (LegProvisionOptionExerciseLatestTime is not null) writer.WriteString(40493, LegProvisionOptionExerciseLatestTime);
			if (LegProvisionOptionExerciseLatestTimeBusinessCenter is not null) writer.WriteString(40494, LegProvisionOptionExerciseLatestTimeBusinessCenter);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegProvisionOptionExerciseBusinessDayConvention = view.GetInt32(40476);
			if (view.GetView("LegProvisionOptionExerciseBusinessCenterGrp") is IMessageView viewLegProvisionOptionExerciseBusinessCenterGrp)
			{
				LegProvisionOptionExerciseBusinessCenterGrp = new();
				((IFixParser)LegProvisionOptionExerciseBusinessCenterGrp).Parse(viewLegProvisionOptionExerciseBusinessCenterGrp);
			}
			if (view.GetView("LegProvisionOptionExerciseFixedDateGrp") is IMessageView viewLegProvisionOptionExerciseFixedDateGrp)
			{
				LegProvisionOptionExerciseFixedDateGrp = new();
				((IFixParser)LegProvisionOptionExerciseFixedDateGrp).Parse(viewLegProvisionOptionExerciseFixedDateGrp);
			}
			LegProvisionOptionExerciseEarliestDateOffsetPeriod = view.GetInt32(40478);
			LegProvisionOptionExerciseEarliestDateOffsetUnit = view.GetString(40479);
			LegProvisionOptionExerciseFrequencyPeriod = view.GetInt32(40480);
			LegProvisionOptionExerciseFrequencyUnit = view.GetString(40481);
			LegProvisionOptionExerciseStartDateUnadjusted = view.GetDateOnly(40482);
			LegProvisionOptionExerciseStartDateRelativeTo = view.GetInt32(40483);
			LegProvisionOptionExerciseStartDateOffsetPeriod = view.GetInt32(40484);
			LegProvisionOptionExerciseStartDateOffsetUnit = view.GetString(40485);
			LegProvisionOptionExerciseStartDateOffsetDayType = view.GetInt32(40486);
			LegProvisionOptionExerciseStartDateAdjusted = view.GetDateOnly(40487);
			LegProvisionOptionExercisePeriodSkip = view.GetInt32(40488);
			LegProvisionOptionExerciseBoundsFirstDateUnadjusted = view.GetDateOnly(40489);
			LegProvisionOptionExerciseBoundsLastDateUnadjusted = view.GetDateOnly(40490);
			LegProvisionOptionExerciseEarliestTime = view.GetString(40491);
			LegProvisionOptionExerciseEarliestTimeBusinessCenter = view.GetString(40492);
			LegProvisionOptionExerciseLatestTime = view.GetString(40493);
			LegProvisionOptionExerciseLatestTimeBusinessCenter = view.GetString(40494);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegProvisionOptionExerciseBusinessDayConvention":
				{
					value = LegProvisionOptionExerciseBusinessDayConvention;
					break;
				}
				case "LegProvisionOptionExerciseBusinessCenterGrp":
				{
					value = LegProvisionOptionExerciseBusinessCenterGrp;
					break;
				}
				case "LegProvisionOptionExerciseFixedDateGrp":
				{
					value = LegProvisionOptionExerciseFixedDateGrp;
					break;
				}
				case "LegProvisionOptionExerciseEarliestDateOffsetPeriod":
				{
					value = LegProvisionOptionExerciseEarliestDateOffsetPeriod;
					break;
				}
				case "LegProvisionOptionExerciseEarliestDateOffsetUnit":
				{
					value = LegProvisionOptionExerciseEarliestDateOffsetUnit;
					break;
				}
				case "LegProvisionOptionExerciseFrequencyPeriod":
				{
					value = LegProvisionOptionExerciseFrequencyPeriod;
					break;
				}
				case "LegProvisionOptionExerciseFrequencyUnit":
				{
					value = LegProvisionOptionExerciseFrequencyUnit;
					break;
				}
				case "LegProvisionOptionExerciseStartDateUnadjusted":
				{
					value = LegProvisionOptionExerciseStartDateUnadjusted;
					break;
				}
				case "LegProvisionOptionExerciseStartDateRelativeTo":
				{
					value = LegProvisionOptionExerciseStartDateRelativeTo;
					break;
				}
				case "LegProvisionOptionExerciseStartDateOffsetPeriod":
				{
					value = LegProvisionOptionExerciseStartDateOffsetPeriod;
					break;
				}
				case "LegProvisionOptionExerciseStartDateOffsetUnit":
				{
					value = LegProvisionOptionExerciseStartDateOffsetUnit;
					break;
				}
				case "LegProvisionOptionExerciseStartDateOffsetDayType":
				{
					value = LegProvisionOptionExerciseStartDateOffsetDayType;
					break;
				}
				case "LegProvisionOptionExerciseStartDateAdjusted":
				{
					value = LegProvisionOptionExerciseStartDateAdjusted;
					break;
				}
				case "LegProvisionOptionExercisePeriodSkip":
				{
					value = LegProvisionOptionExercisePeriodSkip;
					break;
				}
				case "LegProvisionOptionExerciseBoundsFirstDateUnadjusted":
				{
					value = LegProvisionOptionExerciseBoundsFirstDateUnadjusted;
					break;
				}
				case "LegProvisionOptionExerciseBoundsLastDateUnadjusted":
				{
					value = LegProvisionOptionExerciseBoundsLastDateUnadjusted;
					break;
				}
				case "LegProvisionOptionExerciseEarliestTime":
				{
					value = LegProvisionOptionExerciseEarliestTime;
					break;
				}
				case "LegProvisionOptionExerciseEarliestTimeBusinessCenter":
				{
					value = LegProvisionOptionExerciseEarliestTimeBusinessCenter;
					break;
				}
				case "LegProvisionOptionExerciseLatestTime":
				{
					value = LegProvisionOptionExerciseLatestTime;
					break;
				}
				case "LegProvisionOptionExerciseLatestTimeBusinessCenter":
				{
					value = LegProvisionOptionExerciseLatestTimeBusinessCenter;
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
			LegProvisionOptionExerciseBusinessDayConvention = null;
			((IFixReset?)LegProvisionOptionExerciseBusinessCenterGrp)?.Reset();
			((IFixReset?)LegProvisionOptionExerciseFixedDateGrp)?.Reset();
			LegProvisionOptionExerciseEarliestDateOffsetPeriod = null;
			LegProvisionOptionExerciseEarliestDateOffsetUnit = null;
			LegProvisionOptionExerciseFrequencyPeriod = null;
			LegProvisionOptionExerciseFrequencyUnit = null;
			LegProvisionOptionExerciseStartDateUnadjusted = null;
			LegProvisionOptionExerciseStartDateRelativeTo = null;
			LegProvisionOptionExerciseStartDateOffsetPeriod = null;
			LegProvisionOptionExerciseStartDateOffsetUnit = null;
			LegProvisionOptionExerciseStartDateOffsetDayType = null;
			LegProvisionOptionExerciseStartDateAdjusted = null;
			LegProvisionOptionExercisePeriodSkip = null;
			LegProvisionOptionExerciseBoundsFirstDateUnadjusted = null;
			LegProvisionOptionExerciseBoundsLastDateUnadjusted = null;
			LegProvisionOptionExerciseEarliestTime = null;
			LegProvisionOptionExerciseEarliestTimeBusinessCenter = null;
			LegProvisionOptionExerciseLatestTime = null;
			LegProvisionOptionExerciseLatestTimeBusinessCenter = null;
		}
	}
}
