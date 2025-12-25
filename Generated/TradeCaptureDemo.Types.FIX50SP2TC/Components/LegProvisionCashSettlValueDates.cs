using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegProvisionCashSettlValueDates : IFixComponent
	{
		[TagDetails(Tag = 40524, Type = TagType.String, Offset = 0, Required = false)]
		public string? LegProvisionCashSettlValueTime {get; set;}
		
		[TagDetails(Tag = 40525, Type = TagType.String, Offset = 1, Required = false)]
		public string? LegProvisionCashSettlValueTimeBusinessCenter {get; set;}
		
		[TagDetails(Tag = 40526, Type = TagType.Int, Offset = 2, Required = false)]
		public int? LegProvisionCashSettlValueDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 3, Required = false)]
		public LegProvisionCashSettlValueDateBusinessCenterGrp? LegProvisionCashSettlValueDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40528, Type = TagType.Int, Offset = 4, Required = false)]
		public int? LegProvisionCashSettlValueDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40529, Type = TagType.Int, Offset = 5, Required = false)]
		public int? LegProvisionCashSettlValueDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40530, Type = TagType.String, Offset = 6, Required = false)]
		public string? LegProvisionCashSettlValueDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40531, Type = TagType.Int, Offset = 7, Required = false)]
		public int? LegProvisionCashSettlValueDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 40532, Type = TagType.LocalDate, Offset = 8, Required = false)]
		public DateOnly? LegProvisionCashSettlValueDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegProvisionCashSettlValueTime is not null) writer.WriteString(40524, LegProvisionCashSettlValueTime);
			if (LegProvisionCashSettlValueTimeBusinessCenter is not null) writer.WriteString(40525, LegProvisionCashSettlValueTimeBusinessCenter);
			if (LegProvisionCashSettlValueDateBusinessDayConvention is not null) writer.WriteWholeNumber(40526, LegProvisionCashSettlValueDateBusinessDayConvention.Value);
			if (LegProvisionCashSettlValueDateBusinessCenterGrp is not null) ((IFixEncoder)LegProvisionCashSettlValueDateBusinessCenterGrp).Encode(writer);
			if (LegProvisionCashSettlValueDateRelativeTo is not null) writer.WriteWholeNumber(40528, LegProvisionCashSettlValueDateRelativeTo.Value);
			if (LegProvisionCashSettlValueDateOffsetPeriod is not null) writer.WriteWholeNumber(40529, LegProvisionCashSettlValueDateOffsetPeriod.Value);
			if (LegProvisionCashSettlValueDateOffsetUnit is not null) writer.WriteString(40530, LegProvisionCashSettlValueDateOffsetUnit);
			if (LegProvisionCashSettlValueDateOffsetDayType is not null) writer.WriteWholeNumber(40531, LegProvisionCashSettlValueDateOffsetDayType.Value);
			if (LegProvisionCashSettlValueDateAdjusted is not null) writer.WriteLocalDateOnly(40532, LegProvisionCashSettlValueDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegProvisionCashSettlValueTime = view.GetString(40524);
			LegProvisionCashSettlValueTimeBusinessCenter = view.GetString(40525);
			LegProvisionCashSettlValueDateBusinessDayConvention = view.GetInt32(40526);
			if (view.GetView("LegProvisionCashSettlValueDateBusinessCenterGrp") is IMessageView viewLegProvisionCashSettlValueDateBusinessCenterGrp)
			{
				LegProvisionCashSettlValueDateBusinessCenterGrp = new();
				((IFixParser)LegProvisionCashSettlValueDateBusinessCenterGrp).Parse(viewLegProvisionCashSettlValueDateBusinessCenterGrp);
			}
			LegProvisionCashSettlValueDateRelativeTo = view.GetInt32(40528);
			LegProvisionCashSettlValueDateOffsetPeriod = view.GetInt32(40529);
			LegProvisionCashSettlValueDateOffsetUnit = view.GetString(40530);
			LegProvisionCashSettlValueDateOffsetDayType = view.GetInt32(40531);
			LegProvisionCashSettlValueDateAdjusted = view.GetDateOnly(40532);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegProvisionCashSettlValueTime":
				{
					value = LegProvisionCashSettlValueTime;
					break;
				}
				case "LegProvisionCashSettlValueTimeBusinessCenter":
				{
					value = LegProvisionCashSettlValueTimeBusinessCenter;
					break;
				}
				case "LegProvisionCashSettlValueDateBusinessDayConvention":
				{
					value = LegProvisionCashSettlValueDateBusinessDayConvention;
					break;
				}
				case "LegProvisionCashSettlValueDateBusinessCenterGrp":
				{
					value = LegProvisionCashSettlValueDateBusinessCenterGrp;
					break;
				}
				case "LegProvisionCashSettlValueDateRelativeTo":
				{
					value = LegProvisionCashSettlValueDateRelativeTo;
					break;
				}
				case "LegProvisionCashSettlValueDateOffsetPeriod":
				{
					value = LegProvisionCashSettlValueDateOffsetPeriod;
					break;
				}
				case "LegProvisionCashSettlValueDateOffsetUnit":
				{
					value = LegProvisionCashSettlValueDateOffsetUnit;
					break;
				}
				case "LegProvisionCashSettlValueDateOffsetDayType":
				{
					value = LegProvisionCashSettlValueDateOffsetDayType;
					break;
				}
				case "LegProvisionCashSettlValueDateAdjusted":
				{
					value = LegProvisionCashSettlValueDateAdjusted;
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
			LegProvisionCashSettlValueTime = null;
			LegProvisionCashSettlValueTimeBusinessCenter = null;
			LegProvisionCashSettlValueDateBusinessDayConvention = null;
			((IFixReset?)LegProvisionCashSettlValueDateBusinessCenterGrp)?.Reset();
			LegProvisionCashSettlValueDateRelativeTo = null;
			LegProvisionCashSettlValueDateOffsetPeriod = null;
			LegProvisionCashSettlValueDateOffsetUnit = null;
			LegProvisionCashSettlValueDateOffsetDayType = null;
			LegProvisionCashSettlValueDateAdjusted = null;
		}
	}
}
