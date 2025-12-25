using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ProvisionOptionExerciseDates : IFixComponent
	{
		[TagDetails(Tag = 40123, Type = TagType.Int, Offset = 0, Required = false)]
		public int? ProvisionOptionExerciseBusinessDayConvention {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public ProvisionOptionExerciseBusinessCenterGrp? ProvisionOptionExerciseBusinessCenterGrp {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public ProvisionOptionExerciseFixedDateGrp? ProvisionOptionExerciseFixedDateGrp {get; set;}
		
		[TagDetails(Tag = 40125, Type = TagType.Int, Offset = 3, Required = false)]
		public int? ProvisionOptionExerciseEarliestDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40126, Type = TagType.String, Offset = 4, Required = false)]
		public string? ProvisionOptionExerciseEarliestDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40127, Type = TagType.Int, Offset = 5, Required = false)]
		public int? ProvisionOptionExerciseFrequencyPeriod {get; set;}
		
		[TagDetails(Tag = 40128, Type = TagType.String, Offset = 6, Required = false)]
		public string? ProvisionOptionExerciseFrequencyUnit {get; set;}
		
		[TagDetails(Tag = 40129, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? ProvisionOptionExerciseStartDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40130, Type = TagType.Int, Offset = 8, Required = false)]
		public int? ProvisionOptionExerciseStartDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40131, Type = TagType.Int, Offset = 9, Required = false)]
		public int? ProvisionOptionExerciseStartDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40132, Type = TagType.String, Offset = 10, Required = false)]
		public string? ProvisionOptionExerciseStartDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40133, Type = TagType.Int, Offset = 11, Required = false)]
		public int? ProvisionOptionExerciseStartDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 40134, Type = TagType.LocalDate, Offset = 12, Required = false)]
		public DateOnly? ProvisionOptionExerciseStartDateAdjusted {get; set;}
		
		[TagDetails(Tag = 40135, Type = TagType.Int, Offset = 13, Required = false)]
		public int? ProvisionOptionExercisePeriodSkip {get; set;}
		
		[TagDetails(Tag = 40136, Type = TagType.LocalDate, Offset = 14, Required = false)]
		public DateOnly? ProvisionOptionExerciseBoundsFirstDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40137, Type = TagType.LocalDate, Offset = 15, Required = false)]
		public DateOnly? ProvisionOptionExerciseBoundsLastDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40138, Type = TagType.String, Offset = 16, Required = false)]
		public string? ProvisionOptionExerciseEarliestTime {get; set;}
		
		[TagDetails(Tag = 40139, Type = TagType.String, Offset = 17, Required = false)]
		public string? ProvisionOptionExerciseEarliestTimeBusinessCenter {get; set;}
		
		[TagDetails(Tag = 40140, Type = TagType.String, Offset = 18, Required = false)]
		public string? ProvisionOptionExerciseLatestTime {get; set;}
		
		[TagDetails(Tag = 40141, Type = TagType.String, Offset = 19, Required = false)]
		public string? ProvisionOptionExerciseLatestTimeBusinessCenter {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ProvisionOptionExerciseBusinessDayConvention is not null) writer.WriteWholeNumber(40123, ProvisionOptionExerciseBusinessDayConvention.Value);
			if (ProvisionOptionExerciseBusinessCenterGrp is not null) ((IFixEncoder)ProvisionOptionExerciseBusinessCenterGrp).Encode(writer);
			if (ProvisionOptionExerciseFixedDateGrp is not null) ((IFixEncoder)ProvisionOptionExerciseFixedDateGrp).Encode(writer);
			if (ProvisionOptionExerciseEarliestDateOffsetPeriod is not null) writer.WriteWholeNumber(40125, ProvisionOptionExerciseEarliestDateOffsetPeriod.Value);
			if (ProvisionOptionExerciseEarliestDateOffsetUnit is not null) writer.WriteString(40126, ProvisionOptionExerciseEarliestDateOffsetUnit);
			if (ProvisionOptionExerciseFrequencyPeriod is not null) writer.WriteWholeNumber(40127, ProvisionOptionExerciseFrequencyPeriod.Value);
			if (ProvisionOptionExerciseFrequencyUnit is not null) writer.WriteString(40128, ProvisionOptionExerciseFrequencyUnit);
			if (ProvisionOptionExerciseStartDateUnadjusted is not null) writer.WriteLocalDateOnly(40129, ProvisionOptionExerciseStartDateUnadjusted.Value);
			if (ProvisionOptionExerciseStartDateRelativeTo is not null) writer.WriteWholeNumber(40130, ProvisionOptionExerciseStartDateRelativeTo.Value);
			if (ProvisionOptionExerciseStartDateOffsetPeriod is not null) writer.WriteWholeNumber(40131, ProvisionOptionExerciseStartDateOffsetPeriod.Value);
			if (ProvisionOptionExerciseStartDateOffsetUnit is not null) writer.WriteString(40132, ProvisionOptionExerciseStartDateOffsetUnit);
			if (ProvisionOptionExerciseStartDateOffsetDayType is not null) writer.WriteWholeNumber(40133, ProvisionOptionExerciseStartDateOffsetDayType.Value);
			if (ProvisionOptionExerciseStartDateAdjusted is not null) writer.WriteLocalDateOnly(40134, ProvisionOptionExerciseStartDateAdjusted.Value);
			if (ProvisionOptionExercisePeriodSkip is not null) writer.WriteWholeNumber(40135, ProvisionOptionExercisePeriodSkip.Value);
			if (ProvisionOptionExerciseBoundsFirstDateUnadjusted is not null) writer.WriteLocalDateOnly(40136, ProvisionOptionExerciseBoundsFirstDateUnadjusted.Value);
			if (ProvisionOptionExerciseBoundsLastDateUnadjusted is not null) writer.WriteLocalDateOnly(40137, ProvisionOptionExerciseBoundsLastDateUnadjusted.Value);
			if (ProvisionOptionExerciseEarliestTime is not null) writer.WriteString(40138, ProvisionOptionExerciseEarliestTime);
			if (ProvisionOptionExerciseEarliestTimeBusinessCenter is not null) writer.WriteString(40139, ProvisionOptionExerciseEarliestTimeBusinessCenter);
			if (ProvisionOptionExerciseLatestTime is not null) writer.WriteString(40140, ProvisionOptionExerciseLatestTime);
			if (ProvisionOptionExerciseLatestTimeBusinessCenter is not null) writer.WriteString(40141, ProvisionOptionExerciseLatestTimeBusinessCenter);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			ProvisionOptionExerciseBusinessDayConvention = view.GetInt32(40123);
			if (view.GetView("ProvisionOptionExerciseBusinessCenterGrp") is IMessageView viewProvisionOptionExerciseBusinessCenterGrp)
			{
				ProvisionOptionExerciseBusinessCenterGrp = new();
				((IFixParser)ProvisionOptionExerciseBusinessCenterGrp).Parse(viewProvisionOptionExerciseBusinessCenterGrp);
			}
			if (view.GetView("ProvisionOptionExerciseFixedDateGrp") is IMessageView viewProvisionOptionExerciseFixedDateGrp)
			{
				ProvisionOptionExerciseFixedDateGrp = new();
				((IFixParser)ProvisionOptionExerciseFixedDateGrp).Parse(viewProvisionOptionExerciseFixedDateGrp);
			}
			ProvisionOptionExerciseEarliestDateOffsetPeriod = view.GetInt32(40125);
			ProvisionOptionExerciseEarliestDateOffsetUnit = view.GetString(40126);
			ProvisionOptionExerciseFrequencyPeriod = view.GetInt32(40127);
			ProvisionOptionExerciseFrequencyUnit = view.GetString(40128);
			ProvisionOptionExerciseStartDateUnadjusted = view.GetDateOnly(40129);
			ProvisionOptionExerciseStartDateRelativeTo = view.GetInt32(40130);
			ProvisionOptionExerciseStartDateOffsetPeriod = view.GetInt32(40131);
			ProvisionOptionExerciseStartDateOffsetUnit = view.GetString(40132);
			ProvisionOptionExerciseStartDateOffsetDayType = view.GetInt32(40133);
			ProvisionOptionExerciseStartDateAdjusted = view.GetDateOnly(40134);
			ProvisionOptionExercisePeriodSkip = view.GetInt32(40135);
			ProvisionOptionExerciseBoundsFirstDateUnadjusted = view.GetDateOnly(40136);
			ProvisionOptionExerciseBoundsLastDateUnadjusted = view.GetDateOnly(40137);
			ProvisionOptionExerciseEarliestTime = view.GetString(40138);
			ProvisionOptionExerciseEarliestTimeBusinessCenter = view.GetString(40139);
			ProvisionOptionExerciseLatestTime = view.GetString(40140);
			ProvisionOptionExerciseLatestTimeBusinessCenter = view.GetString(40141);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "ProvisionOptionExerciseBusinessDayConvention":
				{
					value = ProvisionOptionExerciseBusinessDayConvention;
					break;
				}
				case "ProvisionOptionExerciseBusinessCenterGrp":
				{
					value = ProvisionOptionExerciseBusinessCenterGrp;
					break;
				}
				case "ProvisionOptionExerciseFixedDateGrp":
				{
					value = ProvisionOptionExerciseFixedDateGrp;
					break;
				}
				case "ProvisionOptionExerciseEarliestDateOffsetPeriod":
				{
					value = ProvisionOptionExerciseEarliestDateOffsetPeriod;
					break;
				}
				case "ProvisionOptionExerciseEarliestDateOffsetUnit":
				{
					value = ProvisionOptionExerciseEarliestDateOffsetUnit;
					break;
				}
				case "ProvisionOptionExerciseFrequencyPeriod":
				{
					value = ProvisionOptionExerciseFrequencyPeriod;
					break;
				}
				case "ProvisionOptionExerciseFrequencyUnit":
				{
					value = ProvisionOptionExerciseFrequencyUnit;
					break;
				}
				case "ProvisionOptionExerciseStartDateUnadjusted":
				{
					value = ProvisionOptionExerciseStartDateUnadjusted;
					break;
				}
				case "ProvisionOptionExerciseStartDateRelativeTo":
				{
					value = ProvisionOptionExerciseStartDateRelativeTo;
					break;
				}
				case "ProvisionOptionExerciseStartDateOffsetPeriod":
				{
					value = ProvisionOptionExerciseStartDateOffsetPeriod;
					break;
				}
				case "ProvisionOptionExerciseStartDateOffsetUnit":
				{
					value = ProvisionOptionExerciseStartDateOffsetUnit;
					break;
				}
				case "ProvisionOptionExerciseStartDateOffsetDayType":
				{
					value = ProvisionOptionExerciseStartDateOffsetDayType;
					break;
				}
				case "ProvisionOptionExerciseStartDateAdjusted":
				{
					value = ProvisionOptionExerciseStartDateAdjusted;
					break;
				}
				case "ProvisionOptionExercisePeriodSkip":
				{
					value = ProvisionOptionExercisePeriodSkip;
					break;
				}
				case "ProvisionOptionExerciseBoundsFirstDateUnadjusted":
				{
					value = ProvisionOptionExerciseBoundsFirstDateUnadjusted;
					break;
				}
				case "ProvisionOptionExerciseBoundsLastDateUnadjusted":
				{
					value = ProvisionOptionExerciseBoundsLastDateUnadjusted;
					break;
				}
				case "ProvisionOptionExerciseEarliestTime":
				{
					value = ProvisionOptionExerciseEarliestTime;
					break;
				}
				case "ProvisionOptionExerciseEarliestTimeBusinessCenter":
				{
					value = ProvisionOptionExerciseEarliestTimeBusinessCenter;
					break;
				}
				case "ProvisionOptionExerciseLatestTime":
				{
					value = ProvisionOptionExerciseLatestTime;
					break;
				}
				case "ProvisionOptionExerciseLatestTimeBusinessCenter":
				{
					value = ProvisionOptionExerciseLatestTimeBusinessCenter;
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
			ProvisionOptionExerciseBusinessDayConvention = null;
			((IFixReset?)ProvisionOptionExerciseBusinessCenterGrp)?.Reset();
			((IFixReset?)ProvisionOptionExerciseFixedDateGrp)?.Reset();
			ProvisionOptionExerciseEarliestDateOffsetPeriod = null;
			ProvisionOptionExerciseEarliestDateOffsetUnit = null;
			ProvisionOptionExerciseFrequencyPeriod = null;
			ProvisionOptionExerciseFrequencyUnit = null;
			ProvisionOptionExerciseStartDateUnadjusted = null;
			ProvisionOptionExerciseStartDateRelativeTo = null;
			ProvisionOptionExerciseStartDateOffsetPeriod = null;
			ProvisionOptionExerciseStartDateOffsetUnit = null;
			ProvisionOptionExerciseStartDateOffsetDayType = null;
			ProvisionOptionExerciseStartDateAdjusted = null;
			ProvisionOptionExercisePeriodSkip = null;
			ProvisionOptionExerciseBoundsFirstDateUnadjusted = null;
			ProvisionOptionExerciseBoundsLastDateUnadjusted = null;
			ProvisionOptionExerciseEarliestTime = null;
			ProvisionOptionExerciseEarliestTimeBusinessCenter = null;
			ProvisionOptionExerciseLatestTime = null;
			ProvisionOptionExerciseLatestTimeBusinessCenter = null;
		}
	}
}
