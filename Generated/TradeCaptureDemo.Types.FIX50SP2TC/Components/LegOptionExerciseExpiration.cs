using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegOptionExerciseExpiration : IFixComponent
	{
		[TagDetails(Tag = 41517, Type = TagType.Int, Offset = 0, Required = false)]
		public int? LegOptionExerciseExpirationDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public LegOptionExerciseExpirationDateBusinessCenterGrp? LegOptionExerciseExpirationDateBusinessCenterGrp {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public LegOptionExerciseExpirationDateGrp? LegOptionExerciseExpirationDateGrp {get; set;}
		
		[TagDetails(Tag = 41518, Type = TagType.Int, Offset = 3, Required = false)]
		public int? LegOptionExerciseExpirationDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 41519, Type = TagType.Int, Offset = 4, Required = false)]
		public int? LegOptionExerciseExpirationDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 41520, Type = TagType.String, Offset = 5, Required = false)]
		public string? LegOptionExerciseExpirationDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 41521, Type = TagType.Int, Offset = 6, Required = false)]
		public int? LegOptionExerciseExpirationFrequencyPeriod {get; set;}
		
		[TagDetails(Tag = 41522, Type = TagType.String, Offset = 7, Required = false)]
		public string? LegOptionExerciseExpirationFrequencyUnit {get; set;}
		
		[TagDetails(Tag = 41523, Type = TagType.String, Offset = 8, Required = false)]
		public string? LegOptionExerciseExpirationRollConvention {get; set;}
		
		[TagDetails(Tag = 41524, Type = TagType.Int, Offset = 9, Required = false)]
		public int? LegOptionExerciseExpirationDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 41525, Type = TagType.String, Offset = 10, Required = false)]
		public string? LegOptionExerciseExpirationTime {get; set;}
		
		[TagDetails(Tag = 41526, Type = TagType.String, Offset = 11, Required = false)]
		public string? LegOptionExerciseExpirationTimeBusinessCenter {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegOptionExerciseExpirationDateBusinessDayConvention is not null) writer.WriteWholeNumber(41517, LegOptionExerciseExpirationDateBusinessDayConvention.Value);
			if (LegOptionExerciseExpirationDateBusinessCenterGrp is not null) ((IFixEncoder)LegOptionExerciseExpirationDateBusinessCenterGrp).Encode(writer);
			if (LegOptionExerciseExpirationDateGrp is not null) ((IFixEncoder)LegOptionExerciseExpirationDateGrp).Encode(writer);
			if (LegOptionExerciseExpirationDateRelativeTo is not null) writer.WriteWholeNumber(41518, LegOptionExerciseExpirationDateRelativeTo.Value);
			if (LegOptionExerciseExpirationDateOffsetPeriod is not null) writer.WriteWholeNumber(41519, LegOptionExerciseExpirationDateOffsetPeriod.Value);
			if (LegOptionExerciseExpirationDateOffsetUnit is not null) writer.WriteString(41520, LegOptionExerciseExpirationDateOffsetUnit);
			if (LegOptionExerciseExpirationFrequencyPeriod is not null) writer.WriteWholeNumber(41521, LegOptionExerciseExpirationFrequencyPeriod.Value);
			if (LegOptionExerciseExpirationFrequencyUnit is not null) writer.WriteString(41522, LegOptionExerciseExpirationFrequencyUnit);
			if (LegOptionExerciseExpirationRollConvention is not null) writer.WriteString(41523, LegOptionExerciseExpirationRollConvention);
			if (LegOptionExerciseExpirationDateOffsetDayType is not null) writer.WriteWholeNumber(41524, LegOptionExerciseExpirationDateOffsetDayType.Value);
			if (LegOptionExerciseExpirationTime is not null) writer.WriteString(41525, LegOptionExerciseExpirationTime);
			if (LegOptionExerciseExpirationTimeBusinessCenter is not null) writer.WriteString(41526, LegOptionExerciseExpirationTimeBusinessCenter);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegOptionExerciseExpirationDateBusinessDayConvention = view.GetInt32(41517);
			if (view.GetView("LegOptionExerciseExpirationDateBusinessCenterGrp") is IMessageView viewLegOptionExerciseExpirationDateBusinessCenterGrp)
			{
				LegOptionExerciseExpirationDateBusinessCenterGrp = new();
				((IFixParser)LegOptionExerciseExpirationDateBusinessCenterGrp).Parse(viewLegOptionExerciseExpirationDateBusinessCenterGrp);
			}
			if (view.GetView("LegOptionExerciseExpirationDateGrp") is IMessageView viewLegOptionExerciseExpirationDateGrp)
			{
				LegOptionExerciseExpirationDateGrp = new();
				((IFixParser)LegOptionExerciseExpirationDateGrp).Parse(viewLegOptionExerciseExpirationDateGrp);
			}
			LegOptionExerciseExpirationDateRelativeTo = view.GetInt32(41518);
			LegOptionExerciseExpirationDateOffsetPeriod = view.GetInt32(41519);
			LegOptionExerciseExpirationDateOffsetUnit = view.GetString(41520);
			LegOptionExerciseExpirationFrequencyPeriod = view.GetInt32(41521);
			LegOptionExerciseExpirationFrequencyUnit = view.GetString(41522);
			LegOptionExerciseExpirationRollConvention = view.GetString(41523);
			LegOptionExerciseExpirationDateOffsetDayType = view.GetInt32(41524);
			LegOptionExerciseExpirationTime = view.GetString(41525);
			LegOptionExerciseExpirationTimeBusinessCenter = view.GetString(41526);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegOptionExerciseExpirationDateBusinessDayConvention":
				{
					value = LegOptionExerciseExpirationDateBusinessDayConvention;
					break;
				}
				case "LegOptionExerciseExpirationDateBusinessCenterGrp":
				{
					value = LegOptionExerciseExpirationDateBusinessCenterGrp;
					break;
				}
				case "LegOptionExerciseExpirationDateGrp":
				{
					value = LegOptionExerciseExpirationDateGrp;
					break;
				}
				case "LegOptionExerciseExpirationDateRelativeTo":
				{
					value = LegOptionExerciseExpirationDateRelativeTo;
					break;
				}
				case "LegOptionExerciseExpirationDateOffsetPeriod":
				{
					value = LegOptionExerciseExpirationDateOffsetPeriod;
					break;
				}
				case "LegOptionExerciseExpirationDateOffsetUnit":
				{
					value = LegOptionExerciseExpirationDateOffsetUnit;
					break;
				}
				case "LegOptionExerciseExpirationFrequencyPeriod":
				{
					value = LegOptionExerciseExpirationFrequencyPeriod;
					break;
				}
				case "LegOptionExerciseExpirationFrequencyUnit":
				{
					value = LegOptionExerciseExpirationFrequencyUnit;
					break;
				}
				case "LegOptionExerciseExpirationRollConvention":
				{
					value = LegOptionExerciseExpirationRollConvention;
					break;
				}
				case "LegOptionExerciseExpirationDateOffsetDayType":
				{
					value = LegOptionExerciseExpirationDateOffsetDayType;
					break;
				}
				case "LegOptionExerciseExpirationTime":
				{
					value = LegOptionExerciseExpirationTime;
					break;
				}
				case "LegOptionExerciseExpirationTimeBusinessCenter":
				{
					value = LegOptionExerciseExpirationTimeBusinessCenter;
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
			LegOptionExerciseExpirationDateBusinessDayConvention = null;
			((IFixReset?)LegOptionExerciseExpirationDateBusinessCenterGrp)?.Reset();
			((IFixReset?)LegOptionExerciseExpirationDateGrp)?.Reset();
			LegOptionExerciseExpirationDateRelativeTo = null;
			LegOptionExerciseExpirationDateOffsetPeriod = null;
			LegOptionExerciseExpirationDateOffsetUnit = null;
			LegOptionExerciseExpirationFrequencyPeriod = null;
			LegOptionExerciseExpirationFrequencyUnit = null;
			LegOptionExerciseExpirationRollConvention = null;
			LegOptionExerciseExpirationDateOffsetDayType = null;
			LegOptionExerciseExpirationTime = null;
			LegOptionExerciseExpirationTimeBusinessCenter = null;
		}
	}
}
