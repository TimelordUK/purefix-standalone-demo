using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ProvisionCashSettlValueDates : IFixComponent
	{
		[TagDetails(Tag = 40114, Type = TagType.String, Offset = 0, Required = false)]
		public string? ProvisionCashSettlValueTime {get; set;}
		
		[TagDetails(Tag = 40115, Type = TagType.String, Offset = 1, Required = false)]
		public string? ProvisionCashSettlValueTimeBusinessCenter {get; set;}
		
		[TagDetails(Tag = 40116, Type = TagType.Int, Offset = 2, Required = false)]
		public int? ProvisionCashSettlValueDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 3, Required = false)]
		public ProvisionCashSettlValueDateBusinessCenterGrp? ProvisionCashSettlValueDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40118, Type = TagType.Int, Offset = 4, Required = false)]
		public int? ProvisionCashSettlValueDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40119, Type = TagType.Int, Offset = 5, Required = false)]
		public int? ProvisionCashSettlValueDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40120, Type = TagType.String, Offset = 6, Required = false)]
		public string? ProvisionCashSettlValueDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40121, Type = TagType.Int, Offset = 7, Required = false)]
		public int? ProvisionCashSettlValueDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 40122, Type = TagType.LocalDate, Offset = 8, Required = false)]
		public DateOnly? ProvisionCashSettlValueDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ProvisionCashSettlValueTime is not null) writer.WriteString(40114, ProvisionCashSettlValueTime);
			if (ProvisionCashSettlValueTimeBusinessCenter is not null) writer.WriteString(40115, ProvisionCashSettlValueTimeBusinessCenter);
			if (ProvisionCashSettlValueDateBusinessDayConvention is not null) writer.WriteWholeNumber(40116, ProvisionCashSettlValueDateBusinessDayConvention.Value);
			if (ProvisionCashSettlValueDateBusinessCenterGrp is not null) ((IFixEncoder)ProvisionCashSettlValueDateBusinessCenterGrp).Encode(writer);
			if (ProvisionCashSettlValueDateRelativeTo is not null) writer.WriteWholeNumber(40118, ProvisionCashSettlValueDateRelativeTo.Value);
			if (ProvisionCashSettlValueDateOffsetPeriod is not null) writer.WriteWholeNumber(40119, ProvisionCashSettlValueDateOffsetPeriod.Value);
			if (ProvisionCashSettlValueDateOffsetUnit is not null) writer.WriteString(40120, ProvisionCashSettlValueDateOffsetUnit);
			if (ProvisionCashSettlValueDateOffsetDayType is not null) writer.WriteWholeNumber(40121, ProvisionCashSettlValueDateOffsetDayType.Value);
			if (ProvisionCashSettlValueDateAdjusted is not null) writer.WriteLocalDateOnly(40122, ProvisionCashSettlValueDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			ProvisionCashSettlValueTime = view.GetString(40114);
			ProvisionCashSettlValueTimeBusinessCenter = view.GetString(40115);
			ProvisionCashSettlValueDateBusinessDayConvention = view.GetInt32(40116);
			if (view.GetView("ProvisionCashSettlValueDateBusinessCenterGrp") is IMessageView viewProvisionCashSettlValueDateBusinessCenterGrp)
			{
				ProvisionCashSettlValueDateBusinessCenterGrp = new();
				((IFixParser)ProvisionCashSettlValueDateBusinessCenterGrp).Parse(viewProvisionCashSettlValueDateBusinessCenterGrp);
			}
			ProvisionCashSettlValueDateRelativeTo = view.GetInt32(40118);
			ProvisionCashSettlValueDateOffsetPeriod = view.GetInt32(40119);
			ProvisionCashSettlValueDateOffsetUnit = view.GetString(40120);
			ProvisionCashSettlValueDateOffsetDayType = view.GetInt32(40121);
			ProvisionCashSettlValueDateAdjusted = view.GetDateOnly(40122);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "ProvisionCashSettlValueTime":
				{
					value = ProvisionCashSettlValueTime;
					break;
				}
				case "ProvisionCashSettlValueTimeBusinessCenter":
				{
					value = ProvisionCashSettlValueTimeBusinessCenter;
					break;
				}
				case "ProvisionCashSettlValueDateBusinessDayConvention":
				{
					value = ProvisionCashSettlValueDateBusinessDayConvention;
					break;
				}
				case "ProvisionCashSettlValueDateBusinessCenterGrp":
				{
					value = ProvisionCashSettlValueDateBusinessCenterGrp;
					break;
				}
				case "ProvisionCashSettlValueDateRelativeTo":
				{
					value = ProvisionCashSettlValueDateRelativeTo;
					break;
				}
				case "ProvisionCashSettlValueDateOffsetPeriod":
				{
					value = ProvisionCashSettlValueDateOffsetPeriod;
					break;
				}
				case "ProvisionCashSettlValueDateOffsetUnit":
				{
					value = ProvisionCashSettlValueDateOffsetUnit;
					break;
				}
				case "ProvisionCashSettlValueDateOffsetDayType":
				{
					value = ProvisionCashSettlValueDateOffsetDayType;
					break;
				}
				case "ProvisionCashSettlValueDateAdjusted":
				{
					value = ProvisionCashSettlValueDateAdjusted;
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
			ProvisionCashSettlValueTime = null;
			ProvisionCashSettlValueTimeBusinessCenter = null;
			ProvisionCashSettlValueDateBusinessDayConvention = null;
			((IFixReset?)ProvisionCashSettlValueDateBusinessCenterGrp)?.Reset();
			ProvisionCashSettlValueDateRelativeTo = null;
			ProvisionCashSettlValueDateOffsetPeriod = null;
			ProvisionCashSettlValueDateOffsetUnit = null;
			ProvisionCashSettlValueDateOffsetDayType = null;
			ProvisionCashSettlValueDateAdjusted = null;
		}
	}
}
