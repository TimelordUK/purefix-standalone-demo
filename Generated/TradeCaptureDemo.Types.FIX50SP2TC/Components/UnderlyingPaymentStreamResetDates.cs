using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStreamResetDates : IFixComponent
	{
		[TagDetails(Tag = 40592, Type = TagType.Int, Offset = 0, Required = false)]
		public int? UnderlyingPaymentStreamResetDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40593, Type = TagType.Int, Offset = 1, Required = false)]
		public int? UnderlyingPaymentStreamResetDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public UnderlyingPaymentStreamResetDateBusinessCenterGrp? UnderlyingPaymentStreamResetDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40595, Type = TagType.Int, Offset = 3, Required = false)]
		public int? UnderlyingPaymentStreamResetFrequencyPeriod {get; set;}
		
		[TagDetails(Tag = 40596, Type = TagType.String, Offset = 4, Required = false)]
		public string? UnderlyingPaymentStreamResetFrequencyUnit {get; set;}
		
		[TagDetails(Tag = 40597, Type = TagType.String, Offset = 5, Required = false)]
		public string? UnderlyingPaymentStreamResetWeeklyRollConvention {get; set;}
		
		[TagDetails(Tag = 40598, Type = TagType.Int, Offset = 6, Required = false)]
		public int? UnderlyingPaymentStreamInitialFixingDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40599, Type = TagType.Int, Offset = 7, Required = false)]
		public int? UnderlyingPaymentStreamInitialFixingDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public UnderlyingPaymentStreamInitialFixingDateBusinessCenterGrp? UnderlyingPaymentStreamInitialFixingDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40601, Type = TagType.Int, Offset = 9, Required = false)]
		public int? UnderlyingPaymentStreamInitialFixingDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40602, Type = TagType.String, Offset = 10, Required = false)]
		public string? UnderlyingPaymentStreamInitialFixingDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40603, Type = TagType.Int, Offset = 11, Required = false)]
		public int? UnderlyingPaymentStreamInitialFixingDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 40604, Type = TagType.LocalDate, Offset = 12, Required = false)]
		public DateOnly? UnderlyingPaymentStreamInitialFixingDateAdjusted {get; set;}
		
		[TagDetails(Tag = 40605, Type = TagType.Int, Offset = 13, Required = false)]
		public int? UnderlyingPaymentStreamFixingDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40606, Type = TagType.Int, Offset = 14, Required = false)]
		public int? UnderlyingPaymentStreamFixingDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 15, Required = false)]
		public UnderlyingPaymentStreamFixingDateBusinessCenterGrp? UnderlyingPaymentStreamFixingDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40608, Type = TagType.Int, Offset = 16, Required = false)]
		public int? UnderlyingPaymentStreamFixingDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40609, Type = TagType.String, Offset = 17, Required = false)]
		public string? UnderlyingPaymentStreamFixingDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40610, Type = TagType.Int, Offset = 18, Required = false)]
		public int? UnderlyingPaymentStreamFixingDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 40611, Type = TagType.LocalDate, Offset = 19, Required = false)]
		public DateOnly? UnderlyingPaymentStreamFixingDateAdjusted {get; set;}
		
		[TagDetails(Tag = 40612, Type = TagType.Int, Offset = 20, Required = false)]
		public int? UnderlyingPaymentStreamRateCutoffDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40613, Type = TagType.String, Offset = 21, Required = false)]
		public string? UnderlyingPaymentStreamRateCutoffDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40614, Type = TagType.Int, Offset = 22, Required = false)]
		public int? UnderlyingPaymentStreamRateCutoffDateOffsetDayType {get; set;}
		
		[Component(Offset = 23, Required = false)]
		public UnderlyingPaymentStreamFixingDateGrp? UnderlyingPaymentStreamFixingDateGrp {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStreamResetDateRelativeTo is not null) writer.WriteWholeNumber(40592, UnderlyingPaymentStreamResetDateRelativeTo.Value);
			if (UnderlyingPaymentStreamResetDateBusinessDayConvention is not null) writer.WriteWholeNumber(40593, UnderlyingPaymentStreamResetDateBusinessDayConvention.Value);
			if (UnderlyingPaymentStreamResetDateBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingPaymentStreamResetDateBusinessCenterGrp).Encode(writer);
			if (UnderlyingPaymentStreamResetFrequencyPeriod is not null) writer.WriteWholeNumber(40595, UnderlyingPaymentStreamResetFrequencyPeriod.Value);
			if (UnderlyingPaymentStreamResetFrequencyUnit is not null) writer.WriteString(40596, UnderlyingPaymentStreamResetFrequencyUnit);
			if (UnderlyingPaymentStreamResetWeeklyRollConvention is not null) writer.WriteString(40597, UnderlyingPaymentStreamResetWeeklyRollConvention);
			if (UnderlyingPaymentStreamInitialFixingDateRelativeTo is not null) writer.WriteWholeNumber(40598, UnderlyingPaymentStreamInitialFixingDateRelativeTo.Value);
			if (UnderlyingPaymentStreamInitialFixingDateBusinessDayConvention is not null) writer.WriteWholeNumber(40599, UnderlyingPaymentStreamInitialFixingDateBusinessDayConvention.Value);
			if (UnderlyingPaymentStreamInitialFixingDateBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingPaymentStreamInitialFixingDateBusinessCenterGrp).Encode(writer);
			if (UnderlyingPaymentStreamInitialFixingDateOffsetPeriod is not null) writer.WriteWholeNumber(40601, UnderlyingPaymentStreamInitialFixingDateOffsetPeriod.Value);
			if (UnderlyingPaymentStreamInitialFixingDateOffsetUnit is not null) writer.WriteString(40602, UnderlyingPaymentStreamInitialFixingDateOffsetUnit);
			if (UnderlyingPaymentStreamInitialFixingDateOffsetDayType is not null) writer.WriteWholeNumber(40603, UnderlyingPaymentStreamInitialFixingDateOffsetDayType.Value);
			if (UnderlyingPaymentStreamInitialFixingDateAdjusted is not null) writer.WriteLocalDateOnly(40604, UnderlyingPaymentStreamInitialFixingDateAdjusted.Value);
			if (UnderlyingPaymentStreamFixingDateRelativeTo is not null) writer.WriteWholeNumber(40605, UnderlyingPaymentStreamFixingDateRelativeTo.Value);
			if (UnderlyingPaymentStreamFixingDateBusinessDayConvention is not null) writer.WriteWholeNumber(40606, UnderlyingPaymentStreamFixingDateBusinessDayConvention.Value);
			if (UnderlyingPaymentStreamFixingDateBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingPaymentStreamFixingDateBusinessCenterGrp).Encode(writer);
			if (UnderlyingPaymentStreamFixingDateOffsetPeriod is not null) writer.WriteWholeNumber(40608, UnderlyingPaymentStreamFixingDateOffsetPeriod.Value);
			if (UnderlyingPaymentStreamFixingDateOffsetUnit is not null) writer.WriteString(40609, UnderlyingPaymentStreamFixingDateOffsetUnit);
			if (UnderlyingPaymentStreamFixingDateOffsetDayType is not null) writer.WriteWholeNumber(40610, UnderlyingPaymentStreamFixingDateOffsetDayType.Value);
			if (UnderlyingPaymentStreamFixingDateAdjusted is not null) writer.WriteLocalDateOnly(40611, UnderlyingPaymentStreamFixingDateAdjusted.Value);
			if (UnderlyingPaymentStreamRateCutoffDateOffsetPeriod is not null) writer.WriteWholeNumber(40612, UnderlyingPaymentStreamRateCutoffDateOffsetPeriod.Value);
			if (UnderlyingPaymentStreamRateCutoffDateOffsetUnit is not null) writer.WriteString(40613, UnderlyingPaymentStreamRateCutoffDateOffsetUnit);
			if (UnderlyingPaymentStreamRateCutoffDateOffsetDayType is not null) writer.WriteWholeNumber(40614, UnderlyingPaymentStreamRateCutoffDateOffsetDayType.Value);
			if (UnderlyingPaymentStreamFixingDateGrp is not null) ((IFixEncoder)UnderlyingPaymentStreamFixingDateGrp).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingPaymentStreamResetDateRelativeTo = view.GetInt32(40592);
			UnderlyingPaymentStreamResetDateBusinessDayConvention = view.GetInt32(40593);
			if (view.GetView("UnderlyingPaymentStreamResetDateBusinessCenterGrp") is IMessageView viewUnderlyingPaymentStreamResetDateBusinessCenterGrp)
			{
				UnderlyingPaymentStreamResetDateBusinessCenterGrp = new();
				((IFixParser)UnderlyingPaymentStreamResetDateBusinessCenterGrp).Parse(viewUnderlyingPaymentStreamResetDateBusinessCenterGrp);
			}
			UnderlyingPaymentStreamResetFrequencyPeriod = view.GetInt32(40595);
			UnderlyingPaymentStreamResetFrequencyUnit = view.GetString(40596);
			UnderlyingPaymentStreamResetWeeklyRollConvention = view.GetString(40597);
			UnderlyingPaymentStreamInitialFixingDateRelativeTo = view.GetInt32(40598);
			UnderlyingPaymentStreamInitialFixingDateBusinessDayConvention = view.GetInt32(40599);
			if (view.GetView("UnderlyingPaymentStreamInitialFixingDateBusinessCenterGrp") is IMessageView viewUnderlyingPaymentStreamInitialFixingDateBusinessCenterGrp)
			{
				UnderlyingPaymentStreamInitialFixingDateBusinessCenterGrp = new();
				((IFixParser)UnderlyingPaymentStreamInitialFixingDateBusinessCenterGrp).Parse(viewUnderlyingPaymentStreamInitialFixingDateBusinessCenterGrp);
			}
			UnderlyingPaymentStreamInitialFixingDateOffsetPeriod = view.GetInt32(40601);
			UnderlyingPaymentStreamInitialFixingDateOffsetUnit = view.GetString(40602);
			UnderlyingPaymentStreamInitialFixingDateOffsetDayType = view.GetInt32(40603);
			UnderlyingPaymentStreamInitialFixingDateAdjusted = view.GetDateOnly(40604);
			UnderlyingPaymentStreamFixingDateRelativeTo = view.GetInt32(40605);
			UnderlyingPaymentStreamFixingDateBusinessDayConvention = view.GetInt32(40606);
			if (view.GetView("UnderlyingPaymentStreamFixingDateBusinessCenterGrp") is IMessageView viewUnderlyingPaymentStreamFixingDateBusinessCenterGrp)
			{
				UnderlyingPaymentStreamFixingDateBusinessCenterGrp = new();
				((IFixParser)UnderlyingPaymentStreamFixingDateBusinessCenterGrp).Parse(viewUnderlyingPaymentStreamFixingDateBusinessCenterGrp);
			}
			UnderlyingPaymentStreamFixingDateOffsetPeriod = view.GetInt32(40608);
			UnderlyingPaymentStreamFixingDateOffsetUnit = view.GetString(40609);
			UnderlyingPaymentStreamFixingDateOffsetDayType = view.GetInt32(40610);
			UnderlyingPaymentStreamFixingDateAdjusted = view.GetDateOnly(40611);
			UnderlyingPaymentStreamRateCutoffDateOffsetPeriod = view.GetInt32(40612);
			UnderlyingPaymentStreamRateCutoffDateOffsetUnit = view.GetString(40613);
			UnderlyingPaymentStreamRateCutoffDateOffsetDayType = view.GetInt32(40614);
			if (view.GetView("UnderlyingPaymentStreamFixingDateGrp") is IMessageView viewUnderlyingPaymentStreamFixingDateGrp)
			{
				UnderlyingPaymentStreamFixingDateGrp = new();
				((IFixParser)UnderlyingPaymentStreamFixingDateGrp).Parse(viewUnderlyingPaymentStreamFixingDateGrp);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingPaymentStreamResetDateRelativeTo":
				{
					value = UnderlyingPaymentStreamResetDateRelativeTo;
					break;
				}
				case "UnderlyingPaymentStreamResetDateBusinessDayConvention":
				{
					value = UnderlyingPaymentStreamResetDateBusinessDayConvention;
					break;
				}
				case "UnderlyingPaymentStreamResetDateBusinessCenterGrp":
				{
					value = UnderlyingPaymentStreamResetDateBusinessCenterGrp;
					break;
				}
				case "UnderlyingPaymentStreamResetFrequencyPeriod":
				{
					value = UnderlyingPaymentStreamResetFrequencyPeriod;
					break;
				}
				case "UnderlyingPaymentStreamResetFrequencyUnit":
				{
					value = UnderlyingPaymentStreamResetFrequencyUnit;
					break;
				}
				case "UnderlyingPaymentStreamResetWeeklyRollConvention":
				{
					value = UnderlyingPaymentStreamResetWeeklyRollConvention;
					break;
				}
				case "UnderlyingPaymentStreamInitialFixingDateRelativeTo":
				{
					value = UnderlyingPaymentStreamInitialFixingDateRelativeTo;
					break;
				}
				case "UnderlyingPaymentStreamInitialFixingDateBusinessDayConvention":
				{
					value = UnderlyingPaymentStreamInitialFixingDateBusinessDayConvention;
					break;
				}
				case "UnderlyingPaymentStreamInitialFixingDateBusinessCenterGrp":
				{
					value = UnderlyingPaymentStreamInitialFixingDateBusinessCenterGrp;
					break;
				}
				case "UnderlyingPaymentStreamInitialFixingDateOffsetPeriod":
				{
					value = UnderlyingPaymentStreamInitialFixingDateOffsetPeriod;
					break;
				}
				case "UnderlyingPaymentStreamInitialFixingDateOffsetUnit":
				{
					value = UnderlyingPaymentStreamInitialFixingDateOffsetUnit;
					break;
				}
				case "UnderlyingPaymentStreamInitialFixingDateOffsetDayType":
				{
					value = UnderlyingPaymentStreamInitialFixingDateOffsetDayType;
					break;
				}
				case "UnderlyingPaymentStreamInitialFixingDateAdjusted":
				{
					value = UnderlyingPaymentStreamInitialFixingDateAdjusted;
					break;
				}
				case "UnderlyingPaymentStreamFixingDateRelativeTo":
				{
					value = UnderlyingPaymentStreamFixingDateRelativeTo;
					break;
				}
				case "UnderlyingPaymentStreamFixingDateBusinessDayConvention":
				{
					value = UnderlyingPaymentStreamFixingDateBusinessDayConvention;
					break;
				}
				case "UnderlyingPaymentStreamFixingDateBusinessCenterGrp":
				{
					value = UnderlyingPaymentStreamFixingDateBusinessCenterGrp;
					break;
				}
				case "UnderlyingPaymentStreamFixingDateOffsetPeriod":
				{
					value = UnderlyingPaymentStreamFixingDateOffsetPeriod;
					break;
				}
				case "UnderlyingPaymentStreamFixingDateOffsetUnit":
				{
					value = UnderlyingPaymentStreamFixingDateOffsetUnit;
					break;
				}
				case "UnderlyingPaymentStreamFixingDateOffsetDayType":
				{
					value = UnderlyingPaymentStreamFixingDateOffsetDayType;
					break;
				}
				case "UnderlyingPaymentStreamFixingDateAdjusted":
				{
					value = UnderlyingPaymentStreamFixingDateAdjusted;
					break;
				}
				case "UnderlyingPaymentStreamRateCutoffDateOffsetPeriod":
				{
					value = UnderlyingPaymentStreamRateCutoffDateOffsetPeriod;
					break;
				}
				case "UnderlyingPaymentStreamRateCutoffDateOffsetUnit":
				{
					value = UnderlyingPaymentStreamRateCutoffDateOffsetUnit;
					break;
				}
				case "UnderlyingPaymentStreamRateCutoffDateOffsetDayType":
				{
					value = UnderlyingPaymentStreamRateCutoffDateOffsetDayType;
					break;
				}
				case "UnderlyingPaymentStreamFixingDateGrp":
				{
					value = UnderlyingPaymentStreamFixingDateGrp;
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
			UnderlyingPaymentStreamResetDateRelativeTo = null;
			UnderlyingPaymentStreamResetDateBusinessDayConvention = null;
			((IFixReset?)UnderlyingPaymentStreamResetDateBusinessCenterGrp)?.Reset();
			UnderlyingPaymentStreamResetFrequencyPeriod = null;
			UnderlyingPaymentStreamResetFrequencyUnit = null;
			UnderlyingPaymentStreamResetWeeklyRollConvention = null;
			UnderlyingPaymentStreamInitialFixingDateRelativeTo = null;
			UnderlyingPaymentStreamInitialFixingDateBusinessDayConvention = null;
			((IFixReset?)UnderlyingPaymentStreamInitialFixingDateBusinessCenterGrp)?.Reset();
			UnderlyingPaymentStreamInitialFixingDateOffsetPeriod = null;
			UnderlyingPaymentStreamInitialFixingDateOffsetUnit = null;
			UnderlyingPaymentStreamInitialFixingDateOffsetDayType = null;
			UnderlyingPaymentStreamInitialFixingDateAdjusted = null;
			UnderlyingPaymentStreamFixingDateRelativeTo = null;
			UnderlyingPaymentStreamFixingDateBusinessDayConvention = null;
			((IFixReset?)UnderlyingPaymentStreamFixingDateBusinessCenterGrp)?.Reset();
			UnderlyingPaymentStreamFixingDateOffsetPeriod = null;
			UnderlyingPaymentStreamFixingDateOffsetUnit = null;
			UnderlyingPaymentStreamFixingDateOffsetDayType = null;
			UnderlyingPaymentStreamFixingDateAdjusted = null;
			UnderlyingPaymentStreamRateCutoffDateOffsetPeriod = null;
			UnderlyingPaymentStreamRateCutoffDateOffsetUnit = null;
			UnderlyingPaymentStreamRateCutoffDateOffsetDayType = null;
			((IFixReset?)UnderlyingPaymentStreamFixingDateGrp)?.Reset();
		}
	}
}
