using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStubEndDate : IFixComponent
	{
		[TagDetails(Tag = 42488, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? LegPaymentStubEndDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42489, Type = TagType.Int, Offset = 1, Required = false)]
		public int? LegPaymentStubEndDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public LegPaymentStubEndDateBusinessCenterGrp? LegPaymentStubEndDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 42490, Type = TagType.Int, Offset = 3, Required = false)]
		public int? LegPaymentStubEndDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42491, Type = TagType.Int, Offset = 4, Required = false)]
		public int? LegPaymentStubEndDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42492, Type = TagType.String, Offset = 5, Required = false)]
		public string? LegPaymentStubEndDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42493, Type = TagType.Int, Offset = 6, Required = false)]
		public int? LegPaymentStubEndDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42494, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? LegPaymentStubEndDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStubEndDateUnadjusted is not null) writer.WriteLocalDateOnly(42488, LegPaymentStubEndDateUnadjusted.Value);
			if (LegPaymentStubEndDateBusinessDayConvention is not null) writer.WriteWholeNumber(42489, LegPaymentStubEndDateBusinessDayConvention.Value);
			if (LegPaymentStubEndDateBusinessCenterGrp is not null) ((IFixEncoder)LegPaymentStubEndDateBusinessCenterGrp).Encode(writer);
			if (LegPaymentStubEndDateRelativeTo is not null) writer.WriteWholeNumber(42490, LegPaymentStubEndDateRelativeTo.Value);
			if (LegPaymentStubEndDateOffsetPeriod is not null) writer.WriteWholeNumber(42491, LegPaymentStubEndDateOffsetPeriod.Value);
			if (LegPaymentStubEndDateOffsetUnit is not null) writer.WriteString(42492, LegPaymentStubEndDateOffsetUnit);
			if (LegPaymentStubEndDateOffsetDayType is not null) writer.WriteWholeNumber(42493, LegPaymentStubEndDateOffsetDayType.Value);
			if (LegPaymentStubEndDateAdjusted is not null) writer.WriteLocalDateOnly(42494, LegPaymentStubEndDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegPaymentStubEndDateUnadjusted = view.GetDateOnly(42488);
			LegPaymentStubEndDateBusinessDayConvention = view.GetInt32(42489);
			if (view.GetView("LegPaymentStubEndDateBusinessCenterGrp") is IMessageView viewLegPaymentStubEndDateBusinessCenterGrp)
			{
				LegPaymentStubEndDateBusinessCenterGrp = new();
				((IFixParser)LegPaymentStubEndDateBusinessCenterGrp).Parse(viewLegPaymentStubEndDateBusinessCenterGrp);
			}
			LegPaymentStubEndDateRelativeTo = view.GetInt32(42490);
			LegPaymentStubEndDateOffsetPeriod = view.GetInt32(42491);
			LegPaymentStubEndDateOffsetUnit = view.GetString(42492);
			LegPaymentStubEndDateOffsetDayType = view.GetInt32(42493);
			LegPaymentStubEndDateAdjusted = view.GetDateOnly(42494);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegPaymentStubEndDateUnadjusted":
				{
					value = LegPaymentStubEndDateUnadjusted;
					break;
				}
				case "LegPaymentStubEndDateBusinessDayConvention":
				{
					value = LegPaymentStubEndDateBusinessDayConvention;
					break;
				}
				case "LegPaymentStubEndDateBusinessCenterGrp":
				{
					value = LegPaymentStubEndDateBusinessCenterGrp;
					break;
				}
				case "LegPaymentStubEndDateRelativeTo":
				{
					value = LegPaymentStubEndDateRelativeTo;
					break;
				}
				case "LegPaymentStubEndDateOffsetPeriod":
				{
					value = LegPaymentStubEndDateOffsetPeriod;
					break;
				}
				case "LegPaymentStubEndDateOffsetUnit":
				{
					value = LegPaymentStubEndDateOffsetUnit;
					break;
				}
				case "LegPaymentStubEndDateOffsetDayType":
				{
					value = LegPaymentStubEndDateOffsetDayType;
					break;
				}
				case "LegPaymentStubEndDateAdjusted":
				{
					value = LegPaymentStubEndDateAdjusted;
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
			LegPaymentStubEndDateUnadjusted = null;
			LegPaymentStubEndDateBusinessDayConvention = null;
			((IFixReset?)LegPaymentStubEndDateBusinessCenterGrp)?.Reset();
			LegPaymentStubEndDateRelativeTo = null;
			LegPaymentStubEndDateOffsetPeriod = null;
			LegPaymentStubEndDateOffsetUnit = null;
			LegPaymentStubEndDateOffsetDayType = null;
			LegPaymentStubEndDateAdjusted = null;
		}
	}
}
