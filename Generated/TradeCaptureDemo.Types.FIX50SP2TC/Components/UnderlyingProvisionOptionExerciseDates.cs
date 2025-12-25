using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingProvisionOptionExerciseDates : IFixComponent
	{
		[TagDetails(Tag = 42115, Type = TagType.Int, Offset = 0, Required = false)]
		public int? UnderlyingProvisionOptionExerciseBusinessDayConvention {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public UnderlyingProvisionOptionExerciseBusinessCenterGrp? UnderlyingProvisionOptionExerciseBusinessCenterGrp {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public UnderlyingProvisionOptionExerciseFixedDateGrp? UnderlyingProvisionOptionExerciseFixedDateGrp {get; set;}
		
		[TagDetails(Tag = 42116, Type = TagType.Int, Offset = 3, Required = false)]
		public int? UnderlyingProvisionOptionExerciseEarliestDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42117, Type = TagType.String, Offset = 4, Required = false)]
		public string? UnderlyingProvisionOptionExerciseEarliestDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42118, Type = TagType.Int, Offset = 5, Required = false)]
		public int? UnderlyingProvisionOptionExerciseFrequencyPeriod {get; set;}
		
		[TagDetails(Tag = 42119, Type = TagType.String, Offset = 6, Required = false)]
		public string? UnderlyingProvisionOptionExerciseFrequencyUnit {get; set;}
		
		[TagDetails(Tag = 42120, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? UnderlyingProvisionOptionExerciseStartDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42121, Type = TagType.Int, Offset = 8, Required = false)]
		public int? UnderlyingProvisionOptionExerciseStartDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42122, Type = TagType.Int, Offset = 9, Required = false)]
		public int? UnderlyingProvisionOptionExerciseStartDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42123, Type = TagType.String, Offset = 10, Required = false)]
		public string? UnderlyingProvisionOptionExerciseStartDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42124, Type = TagType.Int, Offset = 11, Required = false)]
		public int? UnderlyingProvisionOptionExerciseStartDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42125, Type = TagType.LocalDate, Offset = 12, Required = false)]
		public DateOnly? UnderlyingProvisionOptionExerciseStartDateAdjusted {get; set;}
		
		[TagDetails(Tag = 42126, Type = TagType.Int, Offset = 13, Required = false)]
		public int? UnderlyingProvisionOptionExercisePeriodSkip {get; set;}
		
		[TagDetails(Tag = 42127, Type = TagType.LocalDate, Offset = 14, Required = false)]
		public DateOnly? UnderlyingProvisionOptionExerciseBoundsFirstDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42128, Type = TagType.LocalDate, Offset = 15, Required = false)]
		public DateOnly? UnderlyingProvisionOptionExerciseBoundsLastDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42129, Type = TagType.String, Offset = 16, Required = false)]
		public string? UnderlyingProvisionOptionExerciseEarliestTime {get; set;}
		
		[TagDetails(Tag = 42130, Type = TagType.String, Offset = 17, Required = false)]
		public string? UnderlyingProvisionOptionExerciseEarliestTimeBusinessCenter {get; set;}
		
		[TagDetails(Tag = 42131, Type = TagType.String, Offset = 18, Required = false)]
		public string? UnderlyingProvisionOptionExerciseLatestTime {get; set;}
		
		[TagDetails(Tag = 42132, Type = TagType.String, Offset = 19, Required = false)]
		public string? UnderlyingProvisionOptionExerciseLatestTimeBusinessCenter {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingProvisionOptionExerciseBusinessDayConvention is not null) writer.WriteWholeNumber(42115, UnderlyingProvisionOptionExerciseBusinessDayConvention.Value);
			if (UnderlyingProvisionOptionExerciseBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingProvisionOptionExerciseBusinessCenterGrp).Encode(writer);
			if (UnderlyingProvisionOptionExerciseFixedDateGrp is not null) ((IFixEncoder)UnderlyingProvisionOptionExerciseFixedDateGrp).Encode(writer);
			if (UnderlyingProvisionOptionExerciseEarliestDateOffsetPeriod is not null) writer.WriteWholeNumber(42116, UnderlyingProvisionOptionExerciseEarliestDateOffsetPeriod.Value);
			if (UnderlyingProvisionOptionExerciseEarliestDateOffsetUnit is not null) writer.WriteString(42117, UnderlyingProvisionOptionExerciseEarliestDateOffsetUnit);
			if (UnderlyingProvisionOptionExerciseFrequencyPeriod is not null) writer.WriteWholeNumber(42118, UnderlyingProvisionOptionExerciseFrequencyPeriod.Value);
			if (UnderlyingProvisionOptionExerciseFrequencyUnit is not null) writer.WriteString(42119, UnderlyingProvisionOptionExerciseFrequencyUnit);
			if (UnderlyingProvisionOptionExerciseStartDateUnadjusted is not null) writer.WriteLocalDateOnly(42120, UnderlyingProvisionOptionExerciseStartDateUnadjusted.Value);
			if (UnderlyingProvisionOptionExerciseStartDateRelativeTo is not null) writer.WriteWholeNumber(42121, UnderlyingProvisionOptionExerciseStartDateRelativeTo.Value);
			if (UnderlyingProvisionOptionExerciseStartDateOffsetPeriod is not null) writer.WriteWholeNumber(42122, UnderlyingProvisionOptionExerciseStartDateOffsetPeriod.Value);
			if (UnderlyingProvisionOptionExerciseStartDateOffsetUnit is not null) writer.WriteString(42123, UnderlyingProvisionOptionExerciseStartDateOffsetUnit);
			if (UnderlyingProvisionOptionExerciseStartDateOffsetDayType is not null) writer.WriteWholeNumber(42124, UnderlyingProvisionOptionExerciseStartDateOffsetDayType.Value);
			if (UnderlyingProvisionOptionExerciseStartDateAdjusted is not null) writer.WriteLocalDateOnly(42125, UnderlyingProvisionOptionExerciseStartDateAdjusted.Value);
			if (UnderlyingProvisionOptionExercisePeriodSkip is not null) writer.WriteWholeNumber(42126, UnderlyingProvisionOptionExercisePeriodSkip.Value);
			if (UnderlyingProvisionOptionExerciseBoundsFirstDateUnadjusted is not null) writer.WriteLocalDateOnly(42127, UnderlyingProvisionOptionExerciseBoundsFirstDateUnadjusted.Value);
			if (UnderlyingProvisionOptionExerciseBoundsLastDateUnadjusted is not null) writer.WriteLocalDateOnly(42128, UnderlyingProvisionOptionExerciseBoundsLastDateUnadjusted.Value);
			if (UnderlyingProvisionOptionExerciseEarliestTime is not null) writer.WriteString(42129, UnderlyingProvisionOptionExerciseEarliestTime);
			if (UnderlyingProvisionOptionExerciseEarliestTimeBusinessCenter is not null) writer.WriteString(42130, UnderlyingProvisionOptionExerciseEarliestTimeBusinessCenter);
			if (UnderlyingProvisionOptionExerciseLatestTime is not null) writer.WriteString(42131, UnderlyingProvisionOptionExerciseLatestTime);
			if (UnderlyingProvisionOptionExerciseLatestTimeBusinessCenter is not null) writer.WriteString(42132, UnderlyingProvisionOptionExerciseLatestTimeBusinessCenter);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingProvisionOptionExerciseBusinessDayConvention = view.GetInt32(42115);
			if (view.GetView("UnderlyingProvisionOptionExerciseBusinessCenterGrp") is IMessageView viewUnderlyingProvisionOptionExerciseBusinessCenterGrp)
			{
				UnderlyingProvisionOptionExerciseBusinessCenterGrp = new();
				((IFixParser)UnderlyingProvisionOptionExerciseBusinessCenterGrp).Parse(viewUnderlyingProvisionOptionExerciseBusinessCenterGrp);
			}
			if (view.GetView("UnderlyingProvisionOptionExerciseFixedDateGrp") is IMessageView viewUnderlyingProvisionOptionExerciseFixedDateGrp)
			{
				UnderlyingProvisionOptionExerciseFixedDateGrp = new();
				((IFixParser)UnderlyingProvisionOptionExerciseFixedDateGrp).Parse(viewUnderlyingProvisionOptionExerciseFixedDateGrp);
			}
			UnderlyingProvisionOptionExerciseEarliestDateOffsetPeriod = view.GetInt32(42116);
			UnderlyingProvisionOptionExerciseEarliestDateOffsetUnit = view.GetString(42117);
			UnderlyingProvisionOptionExerciseFrequencyPeriod = view.GetInt32(42118);
			UnderlyingProvisionOptionExerciseFrequencyUnit = view.GetString(42119);
			UnderlyingProvisionOptionExerciseStartDateUnadjusted = view.GetDateOnly(42120);
			UnderlyingProvisionOptionExerciseStartDateRelativeTo = view.GetInt32(42121);
			UnderlyingProvisionOptionExerciseStartDateOffsetPeriod = view.GetInt32(42122);
			UnderlyingProvisionOptionExerciseStartDateOffsetUnit = view.GetString(42123);
			UnderlyingProvisionOptionExerciseStartDateOffsetDayType = view.GetInt32(42124);
			UnderlyingProvisionOptionExerciseStartDateAdjusted = view.GetDateOnly(42125);
			UnderlyingProvisionOptionExercisePeriodSkip = view.GetInt32(42126);
			UnderlyingProvisionOptionExerciseBoundsFirstDateUnadjusted = view.GetDateOnly(42127);
			UnderlyingProvisionOptionExerciseBoundsLastDateUnadjusted = view.GetDateOnly(42128);
			UnderlyingProvisionOptionExerciseEarliestTime = view.GetString(42129);
			UnderlyingProvisionOptionExerciseEarliestTimeBusinessCenter = view.GetString(42130);
			UnderlyingProvisionOptionExerciseLatestTime = view.GetString(42131);
			UnderlyingProvisionOptionExerciseLatestTimeBusinessCenter = view.GetString(42132);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingProvisionOptionExerciseBusinessDayConvention":
				{
					value = UnderlyingProvisionOptionExerciseBusinessDayConvention;
					break;
				}
				case "UnderlyingProvisionOptionExerciseBusinessCenterGrp":
				{
					value = UnderlyingProvisionOptionExerciseBusinessCenterGrp;
					break;
				}
				case "UnderlyingProvisionOptionExerciseFixedDateGrp":
				{
					value = UnderlyingProvisionOptionExerciseFixedDateGrp;
					break;
				}
				case "UnderlyingProvisionOptionExerciseEarliestDateOffsetPeriod":
				{
					value = UnderlyingProvisionOptionExerciseEarliestDateOffsetPeriod;
					break;
				}
				case "UnderlyingProvisionOptionExerciseEarliestDateOffsetUnit":
				{
					value = UnderlyingProvisionOptionExerciseEarliestDateOffsetUnit;
					break;
				}
				case "UnderlyingProvisionOptionExerciseFrequencyPeriod":
				{
					value = UnderlyingProvisionOptionExerciseFrequencyPeriod;
					break;
				}
				case "UnderlyingProvisionOptionExerciseFrequencyUnit":
				{
					value = UnderlyingProvisionOptionExerciseFrequencyUnit;
					break;
				}
				case "UnderlyingProvisionOptionExerciseStartDateUnadjusted":
				{
					value = UnderlyingProvisionOptionExerciseStartDateUnadjusted;
					break;
				}
				case "UnderlyingProvisionOptionExerciseStartDateRelativeTo":
				{
					value = UnderlyingProvisionOptionExerciseStartDateRelativeTo;
					break;
				}
				case "UnderlyingProvisionOptionExerciseStartDateOffsetPeriod":
				{
					value = UnderlyingProvisionOptionExerciseStartDateOffsetPeriod;
					break;
				}
				case "UnderlyingProvisionOptionExerciseStartDateOffsetUnit":
				{
					value = UnderlyingProvisionOptionExerciseStartDateOffsetUnit;
					break;
				}
				case "UnderlyingProvisionOptionExerciseStartDateOffsetDayType":
				{
					value = UnderlyingProvisionOptionExerciseStartDateOffsetDayType;
					break;
				}
				case "UnderlyingProvisionOptionExerciseStartDateAdjusted":
				{
					value = UnderlyingProvisionOptionExerciseStartDateAdjusted;
					break;
				}
				case "UnderlyingProvisionOptionExercisePeriodSkip":
				{
					value = UnderlyingProvisionOptionExercisePeriodSkip;
					break;
				}
				case "UnderlyingProvisionOptionExerciseBoundsFirstDateUnadjusted":
				{
					value = UnderlyingProvisionOptionExerciseBoundsFirstDateUnadjusted;
					break;
				}
				case "UnderlyingProvisionOptionExerciseBoundsLastDateUnadjusted":
				{
					value = UnderlyingProvisionOptionExerciseBoundsLastDateUnadjusted;
					break;
				}
				case "UnderlyingProvisionOptionExerciseEarliestTime":
				{
					value = UnderlyingProvisionOptionExerciseEarliestTime;
					break;
				}
				case "UnderlyingProvisionOptionExerciseEarliestTimeBusinessCenter":
				{
					value = UnderlyingProvisionOptionExerciseEarliestTimeBusinessCenter;
					break;
				}
				case "UnderlyingProvisionOptionExerciseLatestTime":
				{
					value = UnderlyingProvisionOptionExerciseLatestTime;
					break;
				}
				case "UnderlyingProvisionOptionExerciseLatestTimeBusinessCenter":
				{
					value = UnderlyingProvisionOptionExerciseLatestTimeBusinessCenter;
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
			UnderlyingProvisionOptionExerciseBusinessDayConvention = null;
			((IFixReset?)UnderlyingProvisionOptionExerciseBusinessCenterGrp)?.Reset();
			((IFixReset?)UnderlyingProvisionOptionExerciseFixedDateGrp)?.Reset();
			UnderlyingProvisionOptionExerciseEarliestDateOffsetPeriod = null;
			UnderlyingProvisionOptionExerciseEarliestDateOffsetUnit = null;
			UnderlyingProvisionOptionExerciseFrequencyPeriod = null;
			UnderlyingProvisionOptionExerciseFrequencyUnit = null;
			UnderlyingProvisionOptionExerciseStartDateUnadjusted = null;
			UnderlyingProvisionOptionExerciseStartDateRelativeTo = null;
			UnderlyingProvisionOptionExerciseStartDateOffsetPeriod = null;
			UnderlyingProvisionOptionExerciseStartDateOffsetUnit = null;
			UnderlyingProvisionOptionExerciseStartDateOffsetDayType = null;
			UnderlyingProvisionOptionExerciseStartDateAdjusted = null;
			UnderlyingProvisionOptionExercisePeriodSkip = null;
			UnderlyingProvisionOptionExerciseBoundsFirstDateUnadjusted = null;
			UnderlyingProvisionOptionExerciseBoundsLastDateUnadjusted = null;
			UnderlyingProvisionOptionExerciseEarliestTime = null;
			UnderlyingProvisionOptionExerciseEarliestTimeBusinessCenter = null;
			UnderlyingProvisionOptionExerciseLatestTime = null;
			UnderlyingProvisionOptionExerciseLatestTimeBusinessCenter = null;
		}
	}
}
