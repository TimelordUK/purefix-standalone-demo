using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingProvisionCashSettlValueDates : IFixComponent
	{
		[TagDetails(Tag = 42104, Type = TagType.String, Offset = 0, Required = false)]
		public string? UnderlyingProvisionCashSettlValueTime {get; set;}
		
		[TagDetails(Tag = 42105, Type = TagType.String, Offset = 1, Required = false)]
		public string? UnderlyingProvisionCashSettlValueTimeBusinessCenter {get; set;}
		
		[TagDetails(Tag = 42106, Type = TagType.Int, Offset = 2, Required = false)]
		public int? UnderlyingProvisionCashSettlValueDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 3, Required = false)]
		public UnderlyingProvisionCashSettlValueDateBusinessCenterGrp? UnderlyingProvisionCashSettlValueDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 42107, Type = TagType.Int, Offset = 4, Required = false)]
		public int? UnderlyingProvisionCashSettlValueDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42108, Type = TagType.Int, Offset = 5, Required = false)]
		public int? UnderlyingProvisionCashSettlValueDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42109, Type = TagType.String, Offset = 6, Required = false)]
		public string? UnderlyingProvisionCashSettlValueDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42110, Type = TagType.Int, Offset = 7, Required = false)]
		public int? UnderlyingProvisionCashSettlValueDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42111, Type = TagType.LocalDate, Offset = 8, Required = false)]
		public DateOnly? UnderlyingProvisionCashSettlValueDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingProvisionCashSettlValueTime is not null) writer.WriteString(42104, UnderlyingProvisionCashSettlValueTime);
			if (UnderlyingProvisionCashSettlValueTimeBusinessCenter is not null) writer.WriteString(42105, UnderlyingProvisionCashSettlValueTimeBusinessCenter);
			if (UnderlyingProvisionCashSettlValueDateBusinessDayConvention is not null) writer.WriteWholeNumber(42106, UnderlyingProvisionCashSettlValueDateBusinessDayConvention.Value);
			if (UnderlyingProvisionCashSettlValueDateBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingProvisionCashSettlValueDateBusinessCenterGrp).Encode(writer);
			if (UnderlyingProvisionCashSettlValueDateRelativeTo is not null) writer.WriteWholeNumber(42107, UnderlyingProvisionCashSettlValueDateRelativeTo.Value);
			if (UnderlyingProvisionCashSettlValueDateOffsetPeriod is not null) writer.WriteWholeNumber(42108, UnderlyingProvisionCashSettlValueDateOffsetPeriod.Value);
			if (UnderlyingProvisionCashSettlValueDateOffsetUnit is not null) writer.WriteString(42109, UnderlyingProvisionCashSettlValueDateOffsetUnit);
			if (UnderlyingProvisionCashSettlValueDateOffsetDayType is not null) writer.WriteWholeNumber(42110, UnderlyingProvisionCashSettlValueDateOffsetDayType.Value);
			if (UnderlyingProvisionCashSettlValueDateAdjusted is not null) writer.WriteLocalDateOnly(42111, UnderlyingProvisionCashSettlValueDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingProvisionCashSettlValueTime = view.GetString(42104);
			UnderlyingProvisionCashSettlValueTimeBusinessCenter = view.GetString(42105);
			UnderlyingProvisionCashSettlValueDateBusinessDayConvention = view.GetInt32(42106);
			if (view.GetView("UnderlyingProvisionCashSettlValueDateBusinessCenterGrp") is IMessageView viewUnderlyingProvisionCashSettlValueDateBusinessCenterGrp)
			{
				UnderlyingProvisionCashSettlValueDateBusinessCenterGrp = new();
				((IFixParser)UnderlyingProvisionCashSettlValueDateBusinessCenterGrp).Parse(viewUnderlyingProvisionCashSettlValueDateBusinessCenterGrp);
			}
			UnderlyingProvisionCashSettlValueDateRelativeTo = view.GetInt32(42107);
			UnderlyingProvisionCashSettlValueDateOffsetPeriod = view.GetInt32(42108);
			UnderlyingProvisionCashSettlValueDateOffsetUnit = view.GetString(42109);
			UnderlyingProvisionCashSettlValueDateOffsetDayType = view.GetInt32(42110);
			UnderlyingProvisionCashSettlValueDateAdjusted = view.GetDateOnly(42111);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingProvisionCashSettlValueTime":
				{
					value = UnderlyingProvisionCashSettlValueTime;
					break;
				}
				case "UnderlyingProvisionCashSettlValueTimeBusinessCenter":
				{
					value = UnderlyingProvisionCashSettlValueTimeBusinessCenter;
					break;
				}
				case "UnderlyingProvisionCashSettlValueDateBusinessDayConvention":
				{
					value = UnderlyingProvisionCashSettlValueDateBusinessDayConvention;
					break;
				}
				case "UnderlyingProvisionCashSettlValueDateBusinessCenterGrp":
				{
					value = UnderlyingProvisionCashSettlValueDateBusinessCenterGrp;
					break;
				}
				case "UnderlyingProvisionCashSettlValueDateRelativeTo":
				{
					value = UnderlyingProvisionCashSettlValueDateRelativeTo;
					break;
				}
				case "UnderlyingProvisionCashSettlValueDateOffsetPeriod":
				{
					value = UnderlyingProvisionCashSettlValueDateOffsetPeriod;
					break;
				}
				case "UnderlyingProvisionCashSettlValueDateOffsetUnit":
				{
					value = UnderlyingProvisionCashSettlValueDateOffsetUnit;
					break;
				}
				case "UnderlyingProvisionCashSettlValueDateOffsetDayType":
				{
					value = UnderlyingProvisionCashSettlValueDateOffsetDayType;
					break;
				}
				case "UnderlyingProvisionCashSettlValueDateAdjusted":
				{
					value = UnderlyingProvisionCashSettlValueDateAdjusted;
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
			UnderlyingProvisionCashSettlValueTime = null;
			UnderlyingProvisionCashSettlValueTimeBusinessCenter = null;
			UnderlyingProvisionCashSettlValueDateBusinessDayConvention = null;
			((IFixReset?)UnderlyingProvisionCashSettlValueDateBusinessCenterGrp)?.Reset();
			UnderlyingProvisionCashSettlValueDateRelativeTo = null;
			UnderlyingProvisionCashSettlValueDateOffsetPeriod = null;
			UnderlyingProvisionCashSettlValueDateOffsetUnit = null;
			UnderlyingProvisionCashSettlValueDateOffsetDayType = null;
			UnderlyingProvisionCashSettlValueDateAdjusted = null;
		}
	}
}
