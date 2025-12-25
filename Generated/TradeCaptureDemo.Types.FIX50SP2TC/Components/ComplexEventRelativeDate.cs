using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ComplexEventRelativeDate : IFixComponent
	{
		[TagDetails(Tag = 41020, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? ComplexEventDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 41021, Type = TagType.Int, Offset = 1, Required = false)]
		public int? ComplexEventDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 41022, Type = TagType.Int, Offset = 2, Required = false)]
		public int? ComplexEventDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 41023, Type = TagType.String, Offset = 3, Required = false)]
		public string? ComplexEventDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 41024, Type = TagType.Int, Offset = 4, Required = false)]
		public int? ComplexEventDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 41025, Type = TagType.Int, Offset = 5, Required = false)]
		public int? ComplexEventDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 6, Required = false)]
		public ComplexEventDateBusinessCenterGrp? ComplexEventDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 41026, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? ComplexEventDateAdjusted {get; set;}
		
		[TagDetails(Tag = 41027, Type = TagType.String, Offset = 8, Required = false)]
		public string? ComplexEventFixingTime {get; set;}
		
		[TagDetails(Tag = 41028, Type = TagType.String, Offset = 9, Required = false)]
		public string? ComplexEventFixingTimeBusinessCenter {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ComplexEventDateUnadjusted is not null) writer.WriteLocalDateOnly(41020, ComplexEventDateUnadjusted.Value);
			if (ComplexEventDateRelativeTo is not null) writer.WriteWholeNumber(41021, ComplexEventDateRelativeTo.Value);
			if (ComplexEventDateOffsetPeriod is not null) writer.WriteWholeNumber(41022, ComplexEventDateOffsetPeriod.Value);
			if (ComplexEventDateOffsetUnit is not null) writer.WriteString(41023, ComplexEventDateOffsetUnit);
			if (ComplexEventDateOffsetDayType is not null) writer.WriteWholeNumber(41024, ComplexEventDateOffsetDayType.Value);
			if (ComplexEventDateBusinessDayConvention is not null) writer.WriteWholeNumber(41025, ComplexEventDateBusinessDayConvention.Value);
			if (ComplexEventDateBusinessCenterGrp is not null) ((IFixEncoder)ComplexEventDateBusinessCenterGrp).Encode(writer);
			if (ComplexEventDateAdjusted is not null) writer.WriteLocalDateOnly(41026, ComplexEventDateAdjusted.Value);
			if (ComplexEventFixingTime is not null) writer.WriteString(41027, ComplexEventFixingTime);
			if (ComplexEventFixingTimeBusinessCenter is not null) writer.WriteString(41028, ComplexEventFixingTimeBusinessCenter);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			ComplexEventDateUnadjusted = view.GetDateOnly(41020);
			ComplexEventDateRelativeTo = view.GetInt32(41021);
			ComplexEventDateOffsetPeriod = view.GetInt32(41022);
			ComplexEventDateOffsetUnit = view.GetString(41023);
			ComplexEventDateOffsetDayType = view.GetInt32(41024);
			ComplexEventDateBusinessDayConvention = view.GetInt32(41025);
			if (view.GetView("ComplexEventDateBusinessCenterGrp") is IMessageView viewComplexEventDateBusinessCenterGrp)
			{
				ComplexEventDateBusinessCenterGrp = new();
				((IFixParser)ComplexEventDateBusinessCenterGrp).Parse(viewComplexEventDateBusinessCenterGrp);
			}
			ComplexEventDateAdjusted = view.GetDateOnly(41026);
			ComplexEventFixingTime = view.GetString(41027);
			ComplexEventFixingTimeBusinessCenter = view.GetString(41028);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "ComplexEventDateUnadjusted":
				{
					value = ComplexEventDateUnadjusted;
					break;
				}
				case "ComplexEventDateRelativeTo":
				{
					value = ComplexEventDateRelativeTo;
					break;
				}
				case "ComplexEventDateOffsetPeriod":
				{
					value = ComplexEventDateOffsetPeriod;
					break;
				}
				case "ComplexEventDateOffsetUnit":
				{
					value = ComplexEventDateOffsetUnit;
					break;
				}
				case "ComplexEventDateOffsetDayType":
				{
					value = ComplexEventDateOffsetDayType;
					break;
				}
				case "ComplexEventDateBusinessDayConvention":
				{
					value = ComplexEventDateBusinessDayConvention;
					break;
				}
				case "ComplexEventDateBusinessCenterGrp":
				{
					value = ComplexEventDateBusinessCenterGrp;
					break;
				}
				case "ComplexEventDateAdjusted":
				{
					value = ComplexEventDateAdjusted;
					break;
				}
				case "ComplexEventFixingTime":
				{
					value = ComplexEventFixingTime;
					break;
				}
				case "ComplexEventFixingTimeBusinessCenter":
				{
					value = ComplexEventFixingTimeBusinessCenter;
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
			ComplexEventDateUnadjusted = null;
			ComplexEventDateRelativeTo = null;
			ComplexEventDateOffsetPeriod = null;
			ComplexEventDateOffsetUnit = null;
			ComplexEventDateOffsetDayType = null;
			ComplexEventDateBusinessDayConvention = null;
			((IFixReset?)ComplexEventDateBusinessCenterGrp)?.Reset();
			ComplexEventDateAdjusted = null;
			ComplexEventFixingTime = null;
			ComplexEventFixingTimeBusinessCenter = null;
		}
	}
}
