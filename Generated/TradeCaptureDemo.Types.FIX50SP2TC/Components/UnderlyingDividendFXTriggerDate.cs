using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingDividendFXTriggerDate : IFixComponent
	{
		[TagDetails(Tag = 42846, Type = TagType.Int, Offset = 0, Required = false)]
		public int? UnderlyingDividendFXTriggerDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42847, Type = TagType.Int, Offset = 1, Required = false)]
		public int? UnderlyingDividendFXTriggerDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42848, Type = TagType.String, Offset = 2, Required = false)]
		public string? UnderlyingDividendFXTriggerDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42849, Type = TagType.Int, Offset = 3, Required = false)]
		public int? UnderlyingDividendFXTriggerDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42850, Type = TagType.LocalDate, Offset = 4, Required = false)]
		public DateOnly? UnderlyingDividendFXTriggerDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42851, Type = TagType.Int, Offset = 5, Required = false)]
		public int? UnderlyingDividendFXTriggerDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 6, Required = false)]
		public UnderlyingDividendFXTriggerDateBusinessCenterGrp? UnderlyingDividendFXTriggerDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 42852, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? UnderlyingDividendFXTriggerDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingDividendFXTriggerDateRelativeTo is not null) writer.WriteWholeNumber(42846, UnderlyingDividendFXTriggerDateRelativeTo.Value);
			if (UnderlyingDividendFXTriggerDateOffsetPeriod is not null) writer.WriteWholeNumber(42847, UnderlyingDividendFXTriggerDateOffsetPeriod.Value);
			if (UnderlyingDividendFXTriggerDateOffsetUnit is not null) writer.WriteString(42848, UnderlyingDividendFXTriggerDateOffsetUnit);
			if (UnderlyingDividendFXTriggerDateOffsetDayType is not null) writer.WriteWholeNumber(42849, UnderlyingDividendFXTriggerDateOffsetDayType.Value);
			if (UnderlyingDividendFXTriggerDateUnadjusted is not null) writer.WriteLocalDateOnly(42850, UnderlyingDividendFXTriggerDateUnadjusted.Value);
			if (UnderlyingDividendFXTriggerDateBusinessDayConvention is not null) writer.WriteWholeNumber(42851, UnderlyingDividendFXTriggerDateBusinessDayConvention.Value);
			if (UnderlyingDividendFXTriggerDateBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingDividendFXTriggerDateBusinessCenterGrp).Encode(writer);
			if (UnderlyingDividendFXTriggerDateAdjusted is not null) writer.WriteLocalDateOnly(42852, UnderlyingDividendFXTriggerDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingDividendFXTriggerDateRelativeTo = view.GetInt32(42846);
			UnderlyingDividendFXTriggerDateOffsetPeriod = view.GetInt32(42847);
			UnderlyingDividendFXTriggerDateOffsetUnit = view.GetString(42848);
			UnderlyingDividendFXTriggerDateOffsetDayType = view.GetInt32(42849);
			UnderlyingDividendFXTriggerDateUnadjusted = view.GetDateOnly(42850);
			UnderlyingDividendFXTriggerDateBusinessDayConvention = view.GetInt32(42851);
			if (view.GetView("UnderlyingDividendFXTriggerDateBusinessCenterGrp") is IMessageView viewUnderlyingDividendFXTriggerDateBusinessCenterGrp)
			{
				UnderlyingDividendFXTriggerDateBusinessCenterGrp = new();
				((IFixParser)UnderlyingDividendFXTriggerDateBusinessCenterGrp).Parse(viewUnderlyingDividendFXTriggerDateBusinessCenterGrp);
			}
			UnderlyingDividendFXTriggerDateAdjusted = view.GetDateOnly(42852);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingDividendFXTriggerDateRelativeTo":
				{
					value = UnderlyingDividendFXTriggerDateRelativeTo;
					break;
				}
				case "UnderlyingDividendFXTriggerDateOffsetPeriod":
				{
					value = UnderlyingDividendFXTriggerDateOffsetPeriod;
					break;
				}
				case "UnderlyingDividendFXTriggerDateOffsetUnit":
				{
					value = UnderlyingDividendFXTriggerDateOffsetUnit;
					break;
				}
				case "UnderlyingDividendFXTriggerDateOffsetDayType":
				{
					value = UnderlyingDividendFXTriggerDateOffsetDayType;
					break;
				}
				case "UnderlyingDividendFXTriggerDateUnadjusted":
				{
					value = UnderlyingDividendFXTriggerDateUnadjusted;
					break;
				}
				case "UnderlyingDividendFXTriggerDateBusinessDayConvention":
				{
					value = UnderlyingDividendFXTriggerDateBusinessDayConvention;
					break;
				}
				case "UnderlyingDividendFXTriggerDateBusinessCenterGrp":
				{
					value = UnderlyingDividendFXTriggerDateBusinessCenterGrp;
					break;
				}
				case "UnderlyingDividendFXTriggerDateAdjusted":
				{
					value = UnderlyingDividendFXTriggerDateAdjusted;
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
			UnderlyingDividendFXTriggerDateRelativeTo = null;
			UnderlyingDividendFXTriggerDateOffsetPeriod = null;
			UnderlyingDividendFXTriggerDateOffsetUnit = null;
			UnderlyingDividendFXTriggerDateOffsetDayType = null;
			UnderlyingDividendFXTriggerDateUnadjusted = null;
			UnderlyingDividendFXTriggerDateBusinessDayConvention = null;
			((IFixReset?)UnderlyingDividendFXTriggerDateBusinessCenterGrp)?.Reset();
			UnderlyingDividendFXTriggerDateAdjusted = null;
		}
	}
}
