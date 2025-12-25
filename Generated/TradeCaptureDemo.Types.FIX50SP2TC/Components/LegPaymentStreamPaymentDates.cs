using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStreamPaymentDates : IFixComponent
	{
		[TagDetails(Tag = 40292, Type = TagType.Int, Offset = 0, Required = false)]
		public int? LegPaymentStreamPaymentDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public LegPaymentStreamPaymentDateBusinessCenterGrp? LegPaymentStreamPaymentDateBusinessCenterGrp {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public LegPaymentStreamPaymentDateGrp? LegPaymentStreamPaymentDateGrp {get; set;}
		
		[TagDetails(Tag = 40294, Type = TagType.Int, Offset = 3, Required = false)]
		public int? LegPaymentStreamPaymentFrequencyPeriod {get; set;}
		
		[TagDetails(Tag = 40295, Type = TagType.String, Offset = 4, Required = false)]
		public string? LegPaymentStreamPaymentFrequencyUnit {get; set;}
		
		[TagDetails(Tag = 40296, Type = TagType.String, Offset = 5, Required = false)]
		public string? LegPaymentStreamPaymentRollConvention {get; set;}
		
		[TagDetails(Tag = 40297, Type = TagType.LocalDate, Offset = 6, Required = false)]
		public DateOnly? LegPaymentStreamFirstPaymentDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40298, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? LegPaymentStreamLastRegularPaymentDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40299, Type = TagType.Int, Offset = 8, Required = false)]
		public int? LegPaymentStreamPaymentDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40300, Type = TagType.Int, Offset = 9, Required = false)]
		public int? LegPaymentStreamPaymentDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40301, Type = TagType.String, Offset = 10, Required = false)]
		public string? LegPaymentStreamPaymentDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40302, Type = TagType.Int, Offset = 11, Required = false)]
		public int? LegPaymentStreamPaymentDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 41592, Type = TagType.Boolean, Offset = 12, Required = false)]
		public bool? LegPaymentStreamMasterAgreementPaymentDatesIndicator {get; set;}
		
		[Component(Offset = 13, Required = false)]
		public LegPaymentStreamFinalPricePaymentDate? LegPaymentStreamFinalPricePaymentDate {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStreamPaymentDateBusinessDayConvention is not null) writer.WriteWholeNumber(40292, LegPaymentStreamPaymentDateBusinessDayConvention.Value);
			if (LegPaymentStreamPaymentDateBusinessCenterGrp is not null) ((IFixEncoder)LegPaymentStreamPaymentDateBusinessCenterGrp).Encode(writer);
			if (LegPaymentStreamPaymentDateGrp is not null) ((IFixEncoder)LegPaymentStreamPaymentDateGrp).Encode(writer);
			if (LegPaymentStreamPaymentFrequencyPeriod is not null) writer.WriteWholeNumber(40294, LegPaymentStreamPaymentFrequencyPeriod.Value);
			if (LegPaymentStreamPaymentFrequencyUnit is not null) writer.WriteString(40295, LegPaymentStreamPaymentFrequencyUnit);
			if (LegPaymentStreamPaymentRollConvention is not null) writer.WriteString(40296, LegPaymentStreamPaymentRollConvention);
			if (LegPaymentStreamFirstPaymentDateUnadjusted is not null) writer.WriteLocalDateOnly(40297, LegPaymentStreamFirstPaymentDateUnadjusted.Value);
			if (LegPaymentStreamLastRegularPaymentDateUnadjusted is not null) writer.WriteLocalDateOnly(40298, LegPaymentStreamLastRegularPaymentDateUnadjusted.Value);
			if (LegPaymentStreamPaymentDateRelativeTo is not null) writer.WriteWholeNumber(40299, LegPaymentStreamPaymentDateRelativeTo.Value);
			if (LegPaymentStreamPaymentDateOffsetPeriod is not null) writer.WriteWholeNumber(40300, LegPaymentStreamPaymentDateOffsetPeriod.Value);
			if (LegPaymentStreamPaymentDateOffsetUnit is not null) writer.WriteString(40301, LegPaymentStreamPaymentDateOffsetUnit);
			if (LegPaymentStreamPaymentDateOffsetDayType is not null) writer.WriteWholeNumber(40302, LegPaymentStreamPaymentDateOffsetDayType.Value);
			if (LegPaymentStreamMasterAgreementPaymentDatesIndicator is not null) writer.WriteBoolean(41592, LegPaymentStreamMasterAgreementPaymentDatesIndicator.Value);
			if (LegPaymentStreamFinalPricePaymentDate is not null) ((IFixEncoder)LegPaymentStreamFinalPricePaymentDate).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegPaymentStreamPaymentDateBusinessDayConvention = view.GetInt32(40292);
			if (view.GetView("LegPaymentStreamPaymentDateBusinessCenterGrp") is IMessageView viewLegPaymentStreamPaymentDateBusinessCenterGrp)
			{
				LegPaymentStreamPaymentDateBusinessCenterGrp = new();
				((IFixParser)LegPaymentStreamPaymentDateBusinessCenterGrp).Parse(viewLegPaymentStreamPaymentDateBusinessCenterGrp);
			}
			if (view.GetView("LegPaymentStreamPaymentDateGrp") is IMessageView viewLegPaymentStreamPaymentDateGrp)
			{
				LegPaymentStreamPaymentDateGrp = new();
				((IFixParser)LegPaymentStreamPaymentDateGrp).Parse(viewLegPaymentStreamPaymentDateGrp);
			}
			LegPaymentStreamPaymentFrequencyPeriod = view.GetInt32(40294);
			LegPaymentStreamPaymentFrequencyUnit = view.GetString(40295);
			LegPaymentStreamPaymentRollConvention = view.GetString(40296);
			LegPaymentStreamFirstPaymentDateUnadjusted = view.GetDateOnly(40297);
			LegPaymentStreamLastRegularPaymentDateUnadjusted = view.GetDateOnly(40298);
			LegPaymentStreamPaymentDateRelativeTo = view.GetInt32(40299);
			LegPaymentStreamPaymentDateOffsetPeriod = view.GetInt32(40300);
			LegPaymentStreamPaymentDateOffsetUnit = view.GetString(40301);
			LegPaymentStreamPaymentDateOffsetDayType = view.GetInt32(40302);
			LegPaymentStreamMasterAgreementPaymentDatesIndicator = view.GetBool(41592);
			if (view.GetView("LegPaymentStreamFinalPricePaymentDate") is IMessageView viewLegPaymentStreamFinalPricePaymentDate)
			{
				LegPaymentStreamFinalPricePaymentDate = new();
				((IFixParser)LegPaymentStreamFinalPricePaymentDate).Parse(viewLegPaymentStreamFinalPricePaymentDate);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegPaymentStreamPaymentDateBusinessDayConvention":
				{
					value = LegPaymentStreamPaymentDateBusinessDayConvention;
					break;
				}
				case "LegPaymentStreamPaymentDateBusinessCenterGrp":
				{
					value = LegPaymentStreamPaymentDateBusinessCenterGrp;
					break;
				}
				case "LegPaymentStreamPaymentDateGrp":
				{
					value = LegPaymentStreamPaymentDateGrp;
					break;
				}
				case "LegPaymentStreamPaymentFrequencyPeriod":
				{
					value = LegPaymentStreamPaymentFrequencyPeriod;
					break;
				}
				case "LegPaymentStreamPaymentFrequencyUnit":
				{
					value = LegPaymentStreamPaymentFrequencyUnit;
					break;
				}
				case "LegPaymentStreamPaymentRollConvention":
				{
					value = LegPaymentStreamPaymentRollConvention;
					break;
				}
				case "LegPaymentStreamFirstPaymentDateUnadjusted":
				{
					value = LegPaymentStreamFirstPaymentDateUnadjusted;
					break;
				}
				case "LegPaymentStreamLastRegularPaymentDateUnadjusted":
				{
					value = LegPaymentStreamLastRegularPaymentDateUnadjusted;
					break;
				}
				case "LegPaymentStreamPaymentDateRelativeTo":
				{
					value = LegPaymentStreamPaymentDateRelativeTo;
					break;
				}
				case "LegPaymentStreamPaymentDateOffsetPeriod":
				{
					value = LegPaymentStreamPaymentDateOffsetPeriod;
					break;
				}
				case "LegPaymentStreamPaymentDateOffsetUnit":
				{
					value = LegPaymentStreamPaymentDateOffsetUnit;
					break;
				}
				case "LegPaymentStreamPaymentDateOffsetDayType":
				{
					value = LegPaymentStreamPaymentDateOffsetDayType;
					break;
				}
				case "LegPaymentStreamMasterAgreementPaymentDatesIndicator":
				{
					value = LegPaymentStreamMasterAgreementPaymentDatesIndicator;
					break;
				}
				case "LegPaymentStreamFinalPricePaymentDate":
				{
					value = LegPaymentStreamFinalPricePaymentDate;
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
			LegPaymentStreamPaymentDateBusinessDayConvention = null;
			((IFixReset?)LegPaymentStreamPaymentDateBusinessCenterGrp)?.Reset();
			((IFixReset?)LegPaymentStreamPaymentDateGrp)?.Reset();
			LegPaymentStreamPaymentFrequencyPeriod = null;
			LegPaymentStreamPaymentFrequencyUnit = null;
			LegPaymentStreamPaymentRollConvention = null;
			LegPaymentStreamFirstPaymentDateUnadjusted = null;
			LegPaymentStreamLastRegularPaymentDateUnadjusted = null;
			LegPaymentStreamPaymentDateRelativeTo = null;
			LegPaymentStreamPaymentDateOffsetPeriod = null;
			LegPaymentStreamPaymentDateOffsetUnit = null;
			LegPaymentStreamPaymentDateOffsetDayType = null;
			LegPaymentStreamMasterAgreementPaymentDatesIndicator = null;
			((IFixReset?)LegPaymentStreamFinalPricePaymentDate)?.Reset();
		}
	}
}
