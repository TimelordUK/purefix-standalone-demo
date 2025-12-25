using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStreamResetDates : IFixComponent
	{
		[TagDetails(Tag = 40303, Type = TagType.Int, Offset = 0, Required = false)]
		public int? LegPaymentStreamResetDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40304, Type = TagType.Int, Offset = 1, Required = false)]
		public int? LegPaymentStreamResetDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public LegPaymentStreamResetDateBusinessCenterGrp? LegPaymentStreamResetDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40306, Type = TagType.Int, Offset = 3, Required = false)]
		public int? LegPaymentStreamResetFrequencyPeriod {get; set;}
		
		[TagDetails(Tag = 40307, Type = TagType.String, Offset = 4, Required = false)]
		public string? LegPaymentStreamResetFrequencyUnit {get; set;}
		
		[TagDetails(Tag = 40308, Type = TagType.String, Offset = 5, Required = false)]
		public string? LegPaymentStreamResetWeeklyRollConvention {get; set;}
		
		[TagDetails(Tag = 40309, Type = TagType.Int, Offset = 6, Required = false)]
		public int? LegPaymentStreamInitialFixingDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40310, Type = TagType.Int, Offset = 7, Required = false)]
		public int? LegPaymentStreamInitialFixingDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public LegPaymentStreamInitialFixingDateBusinessCenterGrp? LegPaymentStreamInitialFixingDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40312, Type = TagType.Int, Offset = 9, Required = false)]
		public int? LegPaymentStreamInitialFixingDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40313, Type = TagType.String, Offset = 10, Required = false)]
		public string? LegPaymentStreamInitialFixingDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40314, Type = TagType.Int, Offset = 11, Required = false)]
		public int? LegPaymentStreamInitialFixingDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 40315, Type = TagType.LocalDate, Offset = 12, Required = false)]
		public DateOnly? LegPaymentStreamInitialFixingDateAdjusted {get; set;}
		
		[TagDetails(Tag = 40316, Type = TagType.Int, Offset = 13, Required = false)]
		public int? LegPaymentStreamFixingDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40317, Type = TagType.Int, Offset = 14, Required = false)]
		public int? LegPaymentStreamFixingDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 15, Required = false)]
		public LegPaymentStreamFixingDateBusinessCenterGrp? LegPaymentStreamFixingDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40319, Type = TagType.Int, Offset = 16, Required = false)]
		public int? LegPaymentStreamFixingDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40320, Type = TagType.String, Offset = 17, Required = false)]
		public string? LegPaymentStreamFixingDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40321, Type = TagType.Int, Offset = 18, Required = false)]
		public int? LegPaymentStreamFixingDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 40322, Type = TagType.LocalDate, Offset = 19, Required = false)]
		public DateOnly? LegPaymentStreamFixingDateAdjusted {get; set;}
		
		[TagDetails(Tag = 40323, Type = TagType.Int, Offset = 20, Required = false)]
		public int? LegPaymentStreamRateCutoffDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40324, Type = TagType.String, Offset = 21, Required = false)]
		public string? LegPaymentStreamRateCutoffDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40325, Type = TagType.Int, Offset = 22, Required = false)]
		public int? LegPaymentStreamRateCutoffDateOffsetDayType {get; set;}
		
		[Component(Offset = 23, Required = false)]
		public LegPaymentStreamFixingDateGrp? LegPaymentStreamFixingDateGrp {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStreamResetDateRelativeTo is not null) writer.WriteWholeNumber(40303, LegPaymentStreamResetDateRelativeTo.Value);
			if (LegPaymentStreamResetDateBusinessDayConvention is not null) writer.WriteWholeNumber(40304, LegPaymentStreamResetDateBusinessDayConvention.Value);
			if (LegPaymentStreamResetDateBusinessCenterGrp is not null) ((IFixEncoder)LegPaymentStreamResetDateBusinessCenterGrp).Encode(writer);
			if (LegPaymentStreamResetFrequencyPeriod is not null) writer.WriteWholeNumber(40306, LegPaymentStreamResetFrequencyPeriod.Value);
			if (LegPaymentStreamResetFrequencyUnit is not null) writer.WriteString(40307, LegPaymentStreamResetFrequencyUnit);
			if (LegPaymentStreamResetWeeklyRollConvention is not null) writer.WriteString(40308, LegPaymentStreamResetWeeklyRollConvention);
			if (LegPaymentStreamInitialFixingDateRelativeTo is not null) writer.WriteWholeNumber(40309, LegPaymentStreamInitialFixingDateRelativeTo.Value);
			if (LegPaymentStreamInitialFixingDateBusinessDayConvention is not null) writer.WriteWholeNumber(40310, LegPaymentStreamInitialFixingDateBusinessDayConvention.Value);
			if (LegPaymentStreamInitialFixingDateBusinessCenterGrp is not null) ((IFixEncoder)LegPaymentStreamInitialFixingDateBusinessCenterGrp).Encode(writer);
			if (LegPaymentStreamInitialFixingDateOffsetPeriod is not null) writer.WriteWholeNumber(40312, LegPaymentStreamInitialFixingDateOffsetPeriod.Value);
			if (LegPaymentStreamInitialFixingDateOffsetUnit is not null) writer.WriteString(40313, LegPaymentStreamInitialFixingDateOffsetUnit);
			if (LegPaymentStreamInitialFixingDateOffsetDayType is not null) writer.WriteWholeNumber(40314, LegPaymentStreamInitialFixingDateOffsetDayType.Value);
			if (LegPaymentStreamInitialFixingDateAdjusted is not null) writer.WriteLocalDateOnly(40315, LegPaymentStreamInitialFixingDateAdjusted.Value);
			if (LegPaymentStreamFixingDateRelativeTo is not null) writer.WriteWholeNumber(40316, LegPaymentStreamFixingDateRelativeTo.Value);
			if (LegPaymentStreamFixingDateBusinessDayConvention is not null) writer.WriteWholeNumber(40317, LegPaymentStreamFixingDateBusinessDayConvention.Value);
			if (LegPaymentStreamFixingDateBusinessCenterGrp is not null) ((IFixEncoder)LegPaymentStreamFixingDateBusinessCenterGrp).Encode(writer);
			if (LegPaymentStreamFixingDateOffsetPeriod is not null) writer.WriteWholeNumber(40319, LegPaymentStreamFixingDateOffsetPeriod.Value);
			if (LegPaymentStreamFixingDateOffsetUnit is not null) writer.WriteString(40320, LegPaymentStreamFixingDateOffsetUnit);
			if (LegPaymentStreamFixingDateOffsetDayType is not null) writer.WriteWholeNumber(40321, LegPaymentStreamFixingDateOffsetDayType.Value);
			if (LegPaymentStreamFixingDateAdjusted is not null) writer.WriteLocalDateOnly(40322, LegPaymentStreamFixingDateAdjusted.Value);
			if (LegPaymentStreamRateCutoffDateOffsetPeriod is not null) writer.WriteWholeNumber(40323, LegPaymentStreamRateCutoffDateOffsetPeriod.Value);
			if (LegPaymentStreamRateCutoffDateOffsetUnit is not null) writer.WriteString(40324, LegPaymentStreamRateCutoffDateOffsetUnit);
			if (LegPaymentStreamRateCutoffDateOffsetDayType is not null) writer.WriteWholeNumber(40325, LegPaymentStreamRateCutoffDateOffsetDayType.Value);
			if (LegPaymentStreamFixingDateGrp is not null) ((IFixEncoder)LegPaymentStreamFixingDateGrp).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegPaymentStreamResetDateRelativeTo = view.GetInt32(40303);
			LegPaymentStreamResetDateBusinessDayConvention = view.GetInt32(40304);
			if (view.GetView("LegPaymentStreamResetDateBusinessCenterGrp") is IMessageView viewLegPaymentStreamResetDateBusinessCenterGrp)
			{
				LegPaymentStreamResetDateBusinessCenterGrp = new();
				((IFixParser)LegPaymentStreamResetDateBusinessCenterGrp).Parse(viewLegPaymentStreamResetDateBusinessCenterGrp);
			}
			LegPaymentStreamResetFrequencyPeriod = view.GetInt32(40306);
			LegPaymentStreamResetFrequencyUnit = view.GetString(40307);
			LegPaymentStreamResetWeeklyRollConvention = view.GetString(40308);
			LegPaymentStreamInitialFixingDateRelativeTo = view.GetInt32(40309);
			LegPaymentStreamInitialFixingDateBusinessDayConvention = view.GetInt32(40310);
			if (view.GetView("LegPaymentStreamInitialFixingDateBusinessCenterGrp") is IMessageView viewLegPaymentStreamInitialFixingDateBusinessCenterGrp)
			{
				LegPaymentStreamInitialFixingDateBusinessCenterGrp = new();
				((IFixParser)LegPaymentStreamInitialFixingDateBusinessCenterGrp).Parse(viewLegPaymentStreamInitialFixingDateBusinessCenterGrp);
			}
			LegPaymentStreamInitialFixingDateOffsetPeriod = view.GetInt32(40312);
			LegPaymentStreamInitialFixingDateOffsetUnit = view.GetString(40313);
			LegPaymentStreamInitialFixingDateOffsetDayType = view.GetInt32(40314);
			LegPaymentStreamInitialFixingDateAdjusted = view.GetDateOnly(40315);
			LegPaymentStreamFixingDateRelativeTo = view.GetInt32(40316);
			LegPaymentStreamFixingDateBusinessDayConvention = view.GetInt32(40317);
			if (view.GetView("LegPaymentStreamFixingDateBusinessCenterGrp") is IMessageView viewLegPaymentStreamFixingDateBusinessCenterGrp)
			{
				LegPaymentStreamFixingDateBusinessCenterGrp = new();
				((IFixParser)LegPaymentStreamFixingDateBusinessCenterGrp).Parse(viewLegPaymentStreamFixingDateBusinessCenterGrp);
			}
			LegPaymentStreamFixingDateOffsetPeriod = view.GetInt32(40319);
			LegPaymentStreamFixingDateOffsetUnit = view.GetString(40320);
			LegPaymentStreamFixingDateOffsetDayType = view.GetInt32(40321);
			LegPaymentStreamFixingDateAdjusted = view.GetDateOnly(40322);
			LegPaymentStreamRateCutoffDateOffsetPeriod = view.GetInt32(40323);
			LegPaymentStreamRateCutoffDateOffsetUnit = view.GetString(40324);
			LegPaymentStreamRateCutoffDateOffsetDayType = view.GetInt32(40325);
			if (view.GetView("LegPaymentStreamFixingDateGrp") is IMessageView viewLegPaymentStreamFixingDateGrp)
			{
				LegPaymentStreamFixingDateGrp = new();
				((IFixParser)LegPaymentStreamFixingDateGrp).Parse(viewLegPaymentStreamFixingDateGrp);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegPaymentStreamResetDateRelativeTo":
				{
					value = LegPaymentStreamResetDateRelativeTo;
					break;
				}
				case "LegPaymentStreamResetDateBusinessDayConvention":
				{
					value = LegPaymentStreamResetDateBusinessDayConvention;
					break;
				}
				case "LegPaymentStreamResetDateBusinessCenterGrp":
				{
					value = LegPaymentStreamResetDateBusinessCenterGrp;
					break;
				}
				case "LegPaymentStreamResetFrequencyPeriod":
				{
					value = LegPaymentStreamResetFrequencyPeriod;
					break;
				}
				case "LegPaymentStreamResetFrequencyUnit":
				{
					value = LegPaymentStreamResetFrequencyUnit;
					break;
				}
				case "LegPaymentStreamResetWeeklyRollConvention":
				{
					value = LegPaymentStreamResetWeeklyRollConvention;
					break;
				}
				case "LegPaymentStreamInitialFixingDateRelativeTo":
				{
					value = LegPaymentStreamInitialFixingDateRelativeTo;
					break;
				}
				case "LegPaymentStreamInitialFixingDateBusinessDayConvention":
				{
					value = LegPaymentStreamInitialFixingDateBusinessDayConvention;
					break;
				}
				case "LegPaymentStreamInitialFixingDateBusinessCenterGrp":
				{
					value = LegPaymentStreamInitialFixingDateBusinessCenterGrp;
					break;
				}
				case "LegPaymentStreamInitialFixingDateOffsetPeriod":
				{
					value = LegPaymentStreamInitialFixingDateOffsetPeriod;
					break;
				}
				case "LegPaymentStreamInitialFixingDateOffsetUnit":
				{
					value = LegPaymentStreamInitialFixingDateOffsetUnit;
					break;
				}
				case "LegPaymentStreamInitialFixingDateOffsetDayType":
				{
					value = LegPaymentStreamInitialFixingDateOffsetDayType;
					break;
				}
				case "LegPaymentStreamInitialFixingDateAdjusted":
				{
					value = LegPaymentStreamInitialFixingDateAdjusted;
					break;
				}
				case "LegPaymentStreamFixingDateRelativeTo":
				{
					value = LegPaymentStreamFixingDateRelativeTo;
					break;
				}
				case "LegPaymentStreamFixingDateBusinessDayConvention":
				{
					value = LegPaymentStreamFixingDateBusinessDayConvention;
					break;
				}
				case "LegPaymentStreamFixingDateBusinessCenterGrp":
				{
					value = LegPaymentStreamFixingDateBusinessCenterGrp;
					break;
				}
				case "LegPaymentStreamFixingDateOffsetPeriod":
				{
					value = LegPaymentStreamFixingDateOffsetPeriod;
					break;
				}
				case "LegPaymentStreamFixingDateOffsetUnit":
				{
					value = LegPaymentStreamFixingDateOffsetUnit;
					break;
				}
				case "LegPaymentStreamFixingDateOffsetDayType":
				{
					value = LegPaymentStreamFixingDateOffsetDayType;
					break;
				}
				case "LegPaymentStreamFixingDateAdjusted":
				{
					value = LegPaymentStreamFixingDateAdjusted;
					break;
				}
				case "LegPaymentStreamRateCutoffDateOffsetPeriod":
				{
					value = LegPaymentStreamRateCutoffDateOffsetPeriod;
					break;
				}
				case "LegPaymentStreamRateCutoffDateOffsetUnit":
				{
					value = LegPaymentStreamRateCutoffDateOffsetUnit;
					break;
				}
				case "LegPaymentStreamRateCutoffDateOffsetDayType":
				{
					value = LegPaymentStreamRateCutoffDateOffsetDayType;
					break;
				}
				case "LegPaymentStreamFixingDateGrp":
				{
					value = LegPaymentStreamFixingDateGrp;
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
			LegPaymentStreamResetDateRelativeTo = null;
			LegPaymentStreamResetDateBusinessDayConvention = null;
			((IFixReset?)LegPaymentStreamResetDateBusinessCenterGrp)?.Reset();
			LegPaymentStreamResetFrequencyPeriod = null;
			LegPaymentStreamResetFrequencyUnit = null;
			LegPaymentStreamResetWeeklyRollConvention = null;
			LegPaymentStreamInitialFixingDateRelativeTo = null;
			LegPaymentStreamInitialFixingDateBusinessDayConvention = null;
			((IFixReset?)LegPaymentStreamInitialFixingDateBusinessCenterGrp)?.Reset();
			LegPaymentStreamInitialFixingDateOffsetPeriod = null;
			LegPaymentStreamInitialFixingDateOffsetUnit = null;
			LegPaymentStreamInitialFixingDateOffsetDayType = null;
			LegPaymentStreamInitialFixingDateAdjusted = null;
			LegPaymentStreamFixingDateRelativeTo = null;
			LegPaymentStreamFixingDateBusinessDayConvention = null;
			((IFixReset?)LegPaymentStreamFixingDateBusinessCenterGrp)?.Reset();
			LegPaymentStreamFixingDateOffsetPeriod = null;
			LegPaymentStreamFixingDateOffsetUnit = null;
			LegPaymentStreamFixingDateOffsetDayType = null;
			LegPaymentStreamFixingDateAdjusted = null;
			LegPaymentStreamRateCutoffDateOffsetPeriod = null;
			LegPaymentStreamRateCutoffDateOffsetUnit = null;
			LegPaymentStreamRateCutoffDateOffsetDayType = null;
			((IFixReset?)LegPaymentStreamFixingDateGrp)?.Reset();
		}
	}
}
