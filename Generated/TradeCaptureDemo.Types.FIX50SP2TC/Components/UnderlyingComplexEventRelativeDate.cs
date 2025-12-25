using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingComplexEventRelativeDate : IFixComponent
	{
		[TagDetails(Tag = 41739, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? UnderlyingComplexEventDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 41740, Type = TagType.Int, Offset = 1, Required = false)]
		public int? UnderlyingComplexEventDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 41741, Type = TagType.Int, Offset = 2, Required = false)]
		public int? UnderlyingComplexEventDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 41742, Type = TagType.String, Offset = 3, Required = false)]
		public string? UnderlyingComplexEventDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 41743, Type = TagType.Int, Offset = 4, Required = false)]
		public int? UnderlyingComplexEventDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 41744, Type = TagType.Int, Offset = 5, Required = false)]
		public int? UnderlyingComplexEventDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 6, Required = false)]
		public UnderlyingComplexEventDateBusinessCenterGrp? UnderlyingComplexEventDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 41745, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? UnderlyingComplexEventDateAdjusted {get; set;}
		
		[TagDetails(Tag = 41746, Type = TagType.String, Offset = 8, Required = false)]
		public string? UnderlyingComplexEventFixingTime {get; set;}
		
		[TagDetails(Tag = 41747, Type = TagType.String, Offset = 9, Required = false)]
		public string? UnderlyingComplexEventFixingTimeBusinessCenter {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingComplexEventDateUnadjusted is not null) writer.WriteLocalDateOnly(41739, UnderlyingComplexEventDateUnadjusted.Value);
			if (UnderlyingComplexEventDateRelativeTo is not null) writer.WriteWholeNumber(41740, UnderlyingComplexEventDateRelativeTo.Value);
			if (UnderlyingComplexEventDateOffsetPeriod is not null) writer.WriteWholeNumber(41741, UnderlyingComplexEventDateOffsetPeriod.Value);
			if (UnderlyingComplexEventDateOffsetUnit is not null) writer.WriteString(41742, UnderlyingComplexEventDateOffsetUnit);
			if (UnderlyingComplexEventDateOffsetDayType is not null) writer.WriteWholeNumber(41743, UnderlyingComplexEventDateOffsetDayType.Value);
			if (UnderlyingComplexEventDateBusinessDayConvention is not null) writer.WriteWholeNumber(41744, UnderlyingComplexEventDateBusinessDayConvention.Value);
			if (UnderlyingComplexEventDateBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingComplexEventDateBusinessCenterGrp).Encode(writer);
			if (UnderlyingComplexEventDateAdjusted is not null) writer.WriteLocalDateOnly(41745, UnderlyingComplexEventDateAdjusted.Value);
			if (UnderlyingComplexEventFixingTime is not null) writer.WriteString(41746, UnderlyingComplexEventFixingTime);
			if (UnderlyingComplexEventFixingTimeBusinessCenter is not null) writer.WriteString(41747, UnderlyingComplexEventFixingTimeBusinessCenter);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingComplexEventDateUnadjusted = view.GetDateOnly(41739);
			UnderlyingComplexEventDateRelativeTo = view.GetInt32(41740);
			UnderlyingComplexEventDateOffsetPeriod = view.GetInt32(41741);
			UnderlyingComplexEventDateOffsetUnit = view.GetString(41742);
			UnderlyingComplexEventDateOffsetDayType = view.GetInt32(41743);
			UnderlyingComplexEventDateBusinessDayConvention = view.GetInt32(41744);
			if (view.GetView("UnderlyingComplexEventDateBusinessCenterGrp") is IMessageView viewUnderlyingComplexEventDateBusinessCenterGrp)
			{
				UnderlyingComplexEventDateBusinessCenterGrp = new();
				((IFixParser)UnderlyingComplexEventDateBusinessCenterGrp).Parse(viewUnderlyingComplexEventDateBusinessCenterGrp);
			}
			UnderlyingComplexEventDateAdjusted = view.GetDateOnly(41745);
			UnderlyingComplexEventFixingTime = view.GetString(41746);
			UnderlyingComplexEventFixingTimeBusinessCenter = view.GetString(41747);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingComplexEventDateUnadjusted":
				{
					value = UnderlyingComplexEventDateUnadjusted;
					break;
				}
				case "UnderlyingComplexEventDateRelativeTo":
				{
					value = UnderlyingComplexEventDateRelativeTo;
					break;
				}
				case "UnderlyingComplexEventDateOffsetPeriod":
				{
					value = UnderlyingComplexEventDateOffsetPeriod;
					break;
				}
				case "UnderlyingComplexEventDateOffsetUnit":
				{
					value = UnderlyingComplexEventDateOffsetUnit;
					break;
				}
				case "UnderlyingComplexEventDateOffsetDayType":
				{
					value = UnderlyingComplexEventDateOffsetDayType;
					break;
				}
				case "UnderlyingComplexEventDateBusinessDayConvention":
				{
					value = UnderlyingComplexEventDateBusinessDayConvention;
					break;
				}
				case "UnderlyingComplexEventDateBusinessCenterGrp":
				{
					value = UnderlyingComplexEventDateBusinessCenterGrp;
					break;
				}
				case "UnderlyingComplexEventDateAdjusted":
				{
					value = UnderlyingComplexEventDateAdjusted;
					break;
				}
				case "UnderlyingComplexEventFixingTime":
				{
					value = UnderlyingComplexEventFixingTime;
					break;
				}
				case "UnderlyingComplexEventFixingTimeBusinessCenter":
				{
					value = UnderlyingComplexEventFixingTimeBusinessCenter;
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
			UnderlyingComplexEventDateUnadjusted = null;
			UnderlyingComplexEventDateRelativeTo = null;
			UnderlyingComplexEventDateOffsetPeriod = null;
			UnderlyingComplexEventDateOffsetUnit = null;
			UnderlyingComplexEventDateOffsetDayType = null;
			UnderlyingComplexEventDateBusinessDayConvention = null;
			((IFixReset?)UnderlyingComplexEventDateBusinessCenterGrp)?.Reset();
			UnderlyingComplexEventDateAdjusted = null;
			UnderlyingComplexEventFixingTime = null;
			UnderlyingComplexEventFixingTimeBusinessCenter = null;
		}
	}
}
