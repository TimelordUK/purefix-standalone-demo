using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStubStartDate : IFixComponent
	{
		[TagDetails(Tag = 42497, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? LegPaymentStubStartDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42498, Type = TagType.Int, Offset = 1, Required = false)]
		public int? LegPaymentStubStartDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public LegPaymentStubStartDateBusinessCenterGrp? LegPaymentStubStartDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 42499, Type = TagType.Int, Offset = 3, Required = false)]
		public int? LegPaymentStubStartDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42500, Type = TagType.Int, Offset = 4, Required = false)]
		public int? LegPaymentStubStartDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42501, Type = TagType.String, Offset = 5, Required = false)]
		public string? LegPaymentStubStartDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42502, Type = TagType.Int, Offset = 6, Required = false)]
		public int? LegPaymentStubStartDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42503, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? LegPaymentStubStartDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStubStartDateUnadjusted is not null) writer.WriteLocalDateOnly(42497, LegPaymentStubStartDateUnadjusted.Value);
			if (LegPaymentStubStartDateBusinessDayConvention is not null) writer.WriteWholeNumber(42498, LegPaymentStubStartDateBusinessDayConvention.Value);
			if (LegPaymentStubStartDateBusinessCenterGrp is not null) ((IFixEncoder)LegPaymentStubStartDateBusinessCenterGrp).Encode(writer);
			if (LegPaymentStubStartDateRelativeTo is not null) writer.WriteWholeNumber(42499, LegPaymentStubStartDateRelativeTo.Value);
			if (LegPaymentStubStartDateOffsetPeriod is not null) writer.WriteWholeNumber(42500, LegPaymentStubStartDateOffsetPeriod.Value);
			if (LegPaymentStubStartDateOffsetUnit is not null) writer.WriteString(42501, LegPaymentStubStartDateOffsetUnit);
			if (LegPaymentStubStartDateOffsetDayType is not null) writer.WriteWholeNumber(42502, LegPaymentStubStartDateOffsetDayType.Value);
			if (LegPaymentStubStartDateAdjusted is not null) writer.WriteLocalDateOnly(42503, LegPaymentStubStartDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegPaymentStubStartDateUnadjusted = view.GetDateOnly(42497);
			LegPaymentStubStartDateBusinessDayConvention = view.GetInt32(42498);
			if (view.GetView("LegPaymentStubStartDateBusinessCenterGrp") is IMessageView viewLegPaymentStubStartDateBusinessCenterGrp)
			{
				LegPaymentStubStartDateBusinessCenterGrp = new();
				((IFixParser)LegPaymentStubStartDateBusinessCenterGrp).Parse(viewLegPaymentStubStartDateBusinessCenterGrp);
			}
			LegPaymentStubStartDateRelativeTo = view.GetInt32(42499);
			LegPaymentStubStartDateOffsetPeriod = view.GetInt32(42500);
			LegPaymentStubStartDateOffsetUnit = view.GetString(42501);
			LegPaymentStubStartDateOffsetDayType = view.GetInt32(42502);
			LegPaymentStubStartDateAdjusted = view.GetDateOnly(42503);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegPaymentStubStartDateUnadjusted":
				{
					value = LegPaymentStubStartDateUnadjusted;
					break;
				}
				case "LegPaymentStubStartDateBusinessDayConvention":
				{
					value = LegPaymentStubStartDateBusinessDayConvention;
					break;
				}
				case "LegPaymentStubStartDateBusinessCenterGrp":
				{
					value = LegPaymentStubStartDateBusinessCenterGrp;
					break;
				}
				case "LegPaymentStubStartDateRelativeTo":
				{
					value = LegPaymentStubStartDateRelativeTo;
					break;
				}
				case "LegPaymentStubStartDateOffsetPeriod":
				{
					value = LegPaymentStubStartDateOffsetPeriod;
					break;
				}
				case "LegPaymentStubStartDateOffsetUnit":
				{
					value = LegPaymentStubStartDateOffsetUnit;
					break;
				}
				case "LegPaymentStubStartDateOffsetDayType":
				{
					value = LegPaymentStubStartDateOffsetDayType;
					break;
				}
				case "LegPaymentStubStartDateAdjusted":
				{
					value = LegPaymentStubStartDateAdjusted;
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
			LegPaymentStubStartDateUnadjusted = null;
			LegPaymentStubStartDateBusinessDayConvention = null;
			((IFixReset?)LegPaymentStubStartDateBusinessCenterGrp)?.Reset();
			LegPaymentStubStartDateRelativeTo = null;
			LegPaymentStubStartDateOffsetPeriod = null;
			LegPaymentStubStartDateOffsetUnit = null;
			LegPaymentStubStartDateOffsetDayType = null;
			LegPaymentStubStartDateAdjusted = null;
		}
	}
}
