using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class OptionExerciseExpiration : IFixComponent
	{
		[TagDetails(Tag = 41142, Type = TagType.Int, Offset = 0, Required = false)]
		public int? OptionExerciseExpirationDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public OptionExerciseExpirationDateBusinessCenterGrp? OptionExerciseExpirationDateBusinessCenterGrp {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public OptionExerciseExpirationDateGrp? OptionExerciseExpirationDateGrp {get; set;}
		
		[TagDetails(Tag = 41143, Type = TagType.Int, Offset = 3, Required = false)]
		public int? OptionExerciseExpirationDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 41144, Type = TagType.Int, Offset = 4, Required = false)]
		public int? OptionExerciseExpirationDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 41145, Type = TagType.String, Offset = 5, Required = false)]
		public string? OptionExerciseExpirationDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 41146, Type = TagType.Int, Offset = 6, Required = false)]
		public int? OptionExerciseExpirationFrequencyPeriod {get; set;}
		
		[TagDetails(Tag = 41147, Type = TagType.String, Offset = 7, Required = false)]
		public string? OptionExerciseExpirationFrequencyUnit {get; set;}
		
		[TagDetails(Tag = 41148, Type = TagType.String, Offset = 8, Required = false)]
		public string? OptionExerciseExpirationRollConvention {get; set;}
		
		[TagDetails(Tag = 41149, Type = TagType.Int, Offset = 9, Required = false)]
		public int? OptionExerciseExpirationDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 41150, Type = TagType.String, Offset = 10, Required = false)]
		public string? OptionExerciseExpirationTime {get; set;}
		
		[TagDetails(Tag = 41151, Type = TagType.String, Offset = 11, Required = false)]
		public string? OptionExerciseExpirationTimeBusinessCenter {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (OptionExerciseExpirationDateBusinessDayConvention is not null) writer.WriteWholeNumber(41142, OptionExerciseExpirationDateBusinessDayConvention.Value);
			if (OptionExerciseExpirationDateBusinessCenterGrp is not null) ((IFixEncoder)OptionExerciseExpirationDateBusinessCenterGrp).Encode(writer);
			if (OptionExerciseExpirationDateGrp is not null) ((IFixEncoder)OptionExerciseExpirationDateGrp).Encode(writer);
			if (OptionExerciseExpirationDateRelativeTo is not null) writer.WriteWholeNumber(41143, OptionExerciseExpirationDateRelativeTo.Value);
			if (OptionExerciseExpirationDateOffsetPeriod is not null) writer.WriteWholeNumber(41144, OptionExerciseExpirationDateOffsetPeriod.Value);
			if (OptionExerciseExpirationDateOffsetUnit is not null) writer.WriteString(41145, OptionExerciseExpirationDateOffsetUnit);
			if (OptionExerciseExpirationFrequencyPeriod is not null) writer.WriteWholeNumber(41146, OptionExerciseExpirationFrequencyPeriod.Value);
			if (OptionExerciseExpirationFrequencyUnit is not null) writer.WriteString(41147, OptionExerciseExpirationFrequencyUnit);
			if (OptionExerciseExpirationRollConvention is not null) writer.WriteString(41148, OptionExerciseExpirationRollConvention);
			if (OptionExerciseExpirationDateOffsetDayType is not null) writer.WriteWholeNumber(41149, OptionExerciseExpirationDateOffsetDayType.Value);
			if (OptionExerciseExpirationTime is not null) writer.WriteString(41150, OptionExerciseExpirationTime);
			if (OptionExerciseExpirationTimeBusinessCenter is not null) writer.WriteString(41151, OptionExerciseExpirationTimeBusinessCenter);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			OptionExerciseExpirationDateBusinessDayConvention = view.GetInt32(41142);
			if (view.GetView("OptionExerciseExpirationDateBusinessCenterGrp") is IMessageView viewOptionExerciseExpirationDateBusinessCenterGrp)
			{
				OptionExerciseExpirationDateBusinessCenterGrp = new();
				((IFixParser)OptionExerciseExpirationDateBusinessCenterGrp).Parse(viewOptionExerciseExpirationDateBusinessCenterGrp);
			}
			if (view.GetView("OptionExerciseExpirationDateGrp") is IMessageView viewOptionExerciseExpirationDateGrp)
			{
				OptionExerciseExpirationDateGrp = new();
				((IFixParser)OptionExerciseExpirationDateGrp).Parse(viewOptionExerciseExpirationDateGrp);
			}
			OptionExerciseExpirationDateRelativeTo = view.GetInt32(41143);
			OptionExerciseExpirationDateOffsetPeriod = view.GetInt32(41144);
			OptionExerciseExpirationDateOffsetUnit = view.GetString(41145);
			OptionExerciseExpirationFrequencyPeriod = view.GetInt32(41146);
			OptionExerciseExpirationFrequencyUnit = view.GetString(41147);
			OptionExerciseExpirationRollConvention = view.GetString(41148);
			OptionExerciseExpirationDateOffsetDayType = view.GetInt32(41149);
			OptionExerciseExpirationTime = view.GetString(41150);
			OptionExerciseExpirationTimeBusinessCenter = view.GetString(41151);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "OptionExerciseExpirationDateBusinessDayConvention":
				{
					value = OptionExerciseExpirationDateBusinessDayConvention;
					break;
				}
				case "OptionExerciseExpirationDateBusinessCenterGrp":
				{
					value = OptionExerciseExpirationDateBusinessCenterGrp;
					break;
				}
				case "OptionExerciseExpirationDateGrp":
				{
					value = OptionExerciseExpirationDateGrp;
					break;
				}
				case "OptionExerciseExpirationDateRelativeTo":
				{
					value = OptionExerciseExpirationDateRelativeTo;
					break;
				}
				case "OptionExerciseExpirationDateOffsetPeriod":
				{
					value = OptionExerciseExpirationDateOffsetPeriod;
					break;
				}
				case "OptionExerciseExpirationDateOffsetUnit":
				{
					value = OptionExerciseExpirationDateOffsetUnit;
					break;
				}
				case "OptionExerciseExpirationFrequencyPeriod":
				{
					value = OptionExerciseExpirationFrequencyPeriod;
					break;
				}
				case "OptionExerciseExpirationFrequencyUnit":
				{
					value = OptionExerciseExpirationFrequencyUnit;
					break;
				}
				case "OptionExerciseExpirationRollConvention":
				{
					value = OptionExerciseExpirationRollConvention;
					break;
				}
				case "OptionExerciseExpirationDateOffsetDayType":
				{
					value = OptionExerciseExpirationDateOffsetDayType;
					break;
				}
				case "OptionExerciseExpirationTime":
				{
					value = OptionExerciseExpirationTime;
					break;
				}
				case "OptionExerciseExpirationTimeBusinessCenter":
				{
					value = OptionExerciseExpirationTimeBusinessCenter;
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
			OptionExerciseExpirationDateBusinessDayConvention = null;
			((IFixReset?)OptionExerciseExpirationDateBusinessCenterGrp)?.Reset();
			((IFixReset?)OptionExerciseExpirationDateGrp)?.Reset();
			OptionExerciseExpirationDateRelativeTo = null;
			OptionExerciseExpirationDateOffsetPeriod = null;
			OptionExerciseExpirationDateOffsetUnit = null;
			OptionExerciseExpirationFrequencyPeriod = null;
			OptionExerciseExpirationFrequencyUnit = null;
			OptionExerciseExpirationRollConvention = null;
			OptionExerciseExpirationDateOffsetDayType = null;
			OptionExerciseExpirationTime = null;
			OptionExerciseExpirationTimeBusinessCenter = null;
		}
	}
}
