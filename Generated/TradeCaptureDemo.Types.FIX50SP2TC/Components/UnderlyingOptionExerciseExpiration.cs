using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingOptionExerciseExpiration : IFixComponent
	{
		[TagDetails(Tag = 41846, Type = TagType.Int, Offset = 0, Required = false)]
		public int? UnderlyingOptionExerciseExpirationDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public UnderlyingOptionExerciseExpirationDateBusinessCenterGrp? UnderlyingOptionExerciseExpirationDateBusinessCenterGrp {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public UnderlyingOptionExerciseExpirationDateGrp? UnderlyingOptionExerciseExpirationDateGrp {get; set;}
		
		[TagDetails(Tag = 41847, Type = TagType.Int, Offset = 3, Required = false)]
		public int? UnderlyingOptionExerciseExpirationDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 41848, Type = TagType.Int, Offset = 4, Required = false)]
		public int? UnderlyingOptionExerciseExpirationDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 41849, Type = TagType.String, Offset = 5, Required = false)]
		public string? UnderlyingOptionExerciseExpirationDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 41850, Type = TagType.Int, Offset = 6, Required = false)]
		public int? UnderlyingOptionExerciseExpirationFrequencyPeriod {get; set;}
		
		[TagDetails(Tag = 41851, Type = TagType.String, Offset = 7, Required = false)]
		public string? UnderlyingOptionExerciseExpirationFrequencyUnit {get; set;}
		
		[TagDetails(Tag = 41852, Type = TagType.String, Offset = 8, Required = false)]
		public string? UnderlyingOptionExerciseExpirationRollConvention {get; set;}
		
		[TagDetails(Tag = 41853, Type = TagType.Int, Offset = 9, Required = false)]
		public int? UnderlyingOptionExerciseExpirationDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 41854, Type = TagType.String, Offset = 10, Required = false)]
		public string? UnderlyingOptionExerciseExpirationTime {get; set;}
		
		[TagDetails(Tag = 41855, Type = TagType.String, Offset = 11, Required = false)]
		public string? UnderlyingOptionExerciseExpirationTimeBusinessCenter {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingOptionExerciseExpirationDateBusinessDayConvention is not null) writer.WriteWholeNumber(41846, UnderlyingOptionExerciseExpirationDateBusinessDayConvention.Value);
			if (UnderlyingOptionExerciseExpirationDateBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingOptionExerciseExpirationDateBusinessCenterGrp).Encode(writer);
			if (UnderlyingOptionExerciseExpirationDateGrp is not null) ((IFixEncoder)UnderlyingOptionExerciseExpirationDateGrp).Encode(writer);
			if (UnderlyingOptionExerciseExpirationDateRelativeTo is not null) writer.WriteWholeNumber(41847, UnderlyingOptionExerciseExpirationDateRelativeTo.Value);
			if (UnderlyingOptionExerciseExpirationDateOffsetPeriod is not null) writer.WriteWholeNumber(41848, UnderlyingOptionExerciseExpirationDateOffsetPeriod.Value);
			if (UnderlyingOptionExerciseExpirationDateOffsetUnit is not null) writer.WriteString(41849, UnderlyingOptionExerciseExpirationDateOffsetUnit);
			if (UnderlyingOptionExerciseExpirationFrequencyPeriod is not null) writer.WriteWholeNumber(41850, UnderlyingOptionExerciseExpirationFrequencyPeriod.Value);
			if (UnderlyingOptionExerciseExpirationFrequencyUnit is not null) writer.WriteString(41851, UnderlyingOptionExerciseExpirationFrequencyUnit);
			if (UnderlyingOptionExerciseExpirationRollConvention is not null) writer.WriteString(41852, UnderlyingOptionExerciseExpirationRollConvention);
			if (UnderlyingOptionExerciseExpirationDateOffsetDayType is not null) writer.WriteWholeNumber(41853, UnderlyingOptionExerciseExpirationDateOffsetDayType.Value);
			if (UnderlyingOptionExerciseExpirationTime is not null) writer.WriteString(41854, UnderlyingOptionExerciseExpirationTime);
			if (UnderlyingOptionExerciseExpirationTimeBusinessCenter is not null) writer.WriteString(41855, UnderlyingOptionExerciseExpirationTimeBusinessCenter);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingOptionExerciseExpirationDateBusinessDayConvention = view.GetInt32(41846);
			if (view.GetView("UnderlyingOptionExerciseExpirationDateBusinessCenterGrp") is IMessageView viewUnderlyingOptionExerciseExpirationDateBusinessCenterGrp)
			{
				UnderlyingOptionExerciseExpirationDateBusinessCenterGrp = new();
				((IFixParser)UnderlyingOptionExerciseExpirationDateBusinessCenterGrp).Parse(viewUnderlyingOptionExerciseExpirationDateBusinessCenterGrp);
			}
			if (view.GetView("UnderlyingOptionExerciseExpirationDateGrp") is IMessageView viewUnderlyingOptionExerciseExpirationDateGrp)
			{
				UnderlyingOptionExerciseExpirationDateGrp = new();
				((IFixParser)UnderlyingOptionExerciseExpirationDateGrp).Parse(viewUnderlyingOptionExerciseExpirationDateGrp);
			}
			UnderlyingOptionExerciseExpirationDateRelativeTo = view.GetInt32(41847);
			UnderlyingOptionExerciseExpirationDateOffsetPeriod = view.GetInt32(41848);
			UnderlyingOptionExerciseExpirationDateOffsetUnit = view.GetString(41849);
			UnderlyingOptionExerciseExpirationFrequencyPeriod = view.GetInt32(41850);
			UnderlyingOptionExerciseExpirationFrequencyUnit = view.GetString(41851);
			UnderlyingOptionExerciseExpirationRollConvention = view.GetString(41852);
			UnderlyingOptionExerciseExpirationDateOffsetDayType = view.GetInt32(41853);
			UnderlyingOptionExerciseExpirationTime = view.GetString(41854);
			UnderlyingOptionExerciseExpirationTimeBusinessCenter = view.GetString(41855);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingOptionExerciseExpirationDateBusinessDayConvention":
				{
					value = UnderlyingOptionExerciseExpirationDateBusinessDayConvention;
					break;
				}
				case "UnderlyingOptionExerciseExpirationDateBusinessCenterGrp":
				{
					value = UnderlyingOptionExerciseExpirationDateBusinessCenterGrp;
					break;
				}
				case "UnderlyingOptionExerciseExpirationDateGrp":
				{
					value = UnderlyingOptionExerciseExpirationDateGrp;
					break;
				}
				case "UnderlyingOptionExerciseExpirationDateRelativeTo":
				{
					value = UnderlyingOptionExerciseExpirationDateRelativeTo;
					break;
				}
				case "UnderlyingOptionExerciseExpirationDateOffsetPeriod":
				{
					value = UnderlyingOptionExerciseExpirationDateOffsetPeriod;
					break;
				}
				case "UnderlyingOptionExerciseExpirationDateOffsetUnit":
				{
					value = UnderlyingOptionExerciseExpirationDateOffsetUnit;
					break;
				}
				case "UnderlyingOptionExerciseExpirationFrequencyPeriod":
				{
					value = UnderlyingOptionExerciseExpirationFrequencyPeriod;
					break;
				}
				case "UnderlyingOptionExerciseExpirationFrequencyUnit":
				{
					value = UnderlyingOptionExerciseExpirationFrequencyUnit;
					break;
				}
				case "UnderlyingOptionExerciseExpirationRollConvention":
				{
					value = UnderlyingOptionExerciseExpirationRollConvention;
					break;
				}
				case "UnderlyingOptionExerciseExpirationDateOffsetDayType":
				{
					value = UnderlyingOptionExerciseExpirationDateOffsetDayType;
					break;
				}
				case "UnderlyingOptionExerciseExpirationTime":
				{
					value = UnderlyingOptionExerciseExpirationTime;
					break;
				}
				case "UnderlyingOptionExerciseExpirationTimeBusinessCenter":
				{
					value = UnderlyingOptionExerciseExpirationTimeBusinessCenter;
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
			UnderlyingOptionExerciseExpirationDateBusinessDayConvention = null;
			((IFixReset?)UnderlyingOptionExerciseExpirationDateBusinessCenterGrp)?.Reset();
			((IFixReset?)UnderlyingOptionExerciseExpirationDateGrp)?.Reset();
			UnderlyingOptionExerciseExpirationDateRelativeTo = null;
			UnderlyingOptionExerciseExpirationDateOffsetPeriod = null;
			UnderlyingOptionExerciseExpirationDateOffsetUnit = null;
			UnderlyingOptionExerciseExpirationFrequencyPeriod = null;
			UnderlyingOptionExerciseExpirationFrequencyUnit = null;
			UnderlyingOptionExerciseExpirationRollConvention = null;
			UnderlyingOptionExerciseExpirationDateOffsetDayType = null;
			UnderlyingOptionExerciseExpirationTime = null;
			UnderlyingOptionExerciseExpirationTimeBusinessCenter = null;
		}
	}
}
