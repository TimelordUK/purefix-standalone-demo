using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStreamPaymentDates : IFixComponent
	{
		[TagDetails(Tag = 40581, Type = TagType.Int, Offset = 0, Required = false)]
		public int? UnderlyingPaymentStreamPaymentDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public UnderlyingPaymentStreamPaymentDateBusinessCenterGrp? UnderlyingPaymentStreamPaymentDateBusinessCenterGrp {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public UnderlyingPaymentStreamPaymentDateGrp? UnderlyingPaymentStreamPaymentDateGrp {get; set;}
		
		[TagDetails(Tag = 40583, Type = TagType.Int, Offset = 3, Required = false)]
		public int? UnderlyingPaymentStreamPaymentFrequencyPeriod {get; set;}
		
		[TagDetails(Tag = 40584, Type = TagType.String, Offset = 4, Required = false)]
		public string? UnderlyingPaymentStreamPaymentFrequencyUnit {get; set;}
		
		[TagDetails(Tag = 40585, Type = TagType.String, Offset = 5, Required = false)]
		public string? UnderlyingPaymentStreamPaymentRollConvention {get; set;}
		
		[TagDetails(Tag = 40586, Type = TagType.LocalDate, Offset = 6, Required = false)]
		public DateOnly? UnderlyingPaymentStreamFirstPaymentDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40587, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? UnderlyingPaymentStreamLastRegularPaymentDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40588, Type = TagType.Int, Offset = 8, Required = false)]
		public int? UnderlyingPaymentStreamPaymentDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40589, Type = TagType.Int, Offset = 9, Required = false)]
		public int? UnderlyingPaymentStreamPaymentDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40590, Type = TagType.String, Offset = 10, Required = false)]
		public string? UnderlyingPaymentStreamPaymentDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40591, Type = TagType.Int, Offset = 11, Required = false)]
		public int? UnderlyingPaymentStreamPaymentDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 41940, Type = TagType.Boolean, Offset = 12, Required = false)]
		public bool? UnderlyingPaymentStreamMasterAgreementPaymentDatesIndicator {get; set;}
		
		[Component(Offset = 13, Required = false)]
		public UnderlyingPaymentStreamFinalPricePaymentDate? UnderlyingPaymentStreamFinalPricePaymentDate {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStreamPaymentDateBusinessDayConvention is not null) writer.WriteWholeNumber(40581, UnderlyingPaymentStreamPaymentDateBusinessDayConvention.Value);
			if (UnderlyingPaymentStreamPaymentDateBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingPaymentStreamPaymentDateBusinessCenterGrp).Encode(writer);
			if (UnderlyingPaymentStreamPaymentDateGrp is not null) ((IFixEncoder)UnderlyingPaymentStreamPaymentDateGrp).Encode(writer);
			if (UnderlyingPaymentStreamPaymentFrequencyPeriod is not null) writer.WriteWholeNumber(40583, UnderlyingPaymentStreamPaymentFrequencyPeriod.Value);
			if (UnderlyingPaymentStreamPaymentFrequencyUnit is not null) writer.WriteString(40584, UnderlyingPaymentStreamPaymentFrequencyUnit);
			if (UnderlyingPaymentStreamPaymentRollConvention is not null) writer.WriteString(40585, UnderlyingPaymentStreamPaymentRollConvention);
			if (UnderlyingPaymentStreamFirstPaymentDateUnadjusted is not null) writer.WriteLocalDateOnly(40586, UnderlyingPaymentStreamFirstPaymentDateUnadjusted.Value);
			if (UnderlyingPaymentStreamLastRegularPaymentDateUnadjusted is not null) writer.WriteLocalDateOnly(40587, UnderlyingPaymentStreamLastRegularPaymentDateUnadjusted.Value);
			if (UnderlyingPaymentStreamPaymentDateRelativeTo is not null) writer.WriteWholeNumber(40588, UnderlyingPaymentStreamPaymentDateRelativeTo.Value);
			if (UnderlyingPaymentStreamPaymentDateOffsetPeriod is not null) writer.WriteWholeNumber(40589, UnderlyingPaymentStreamPaymentDateOffsetPeriod.Value);
			if (UnderlyingPaymentStreamPaymentDateOffsetUnit is not null) writer.WriteString(40590, UnderlyingPaymentStreamPaymentDateOffsetUnit);
			if (UnderlyingPaymentStreamPaymentDateOffsetDayType is not null) writer.WriteWholeNumber(40591, UnderlyingPaymentStreamPaymentDateOffsetDayType.Value);
			if (UnderlyingPaymentStreamMasterAgreementPaymentDatesIndicator is not null) writer.WriteBoolean(41940, UnderlyingPaymentStreamMasterAgreementPaymentDatesIndicator.Value);
			if (UnderlyingPaymentStreamFinalPricePaymentDate is not null) ((IFixEncoder)UnderlyingPaymentStreamFinalPricePaymentDate).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingPaymentStreamPaymentDateBusinessDayConvention = view.GetInt32(40581);
			if (view.GetView("UnderlyingPaymentStreamPaymentDateBusinessCenterGrp") is IMessageView viewUnderlyingPaymentStreamPaymentDateBusinessCenterGrp)
			{
				UnderlyingPaymentStreamPaymentDateBusinessCenterGrp = new();
				((IFixParser)UnderlyingPaymentStreamPaymentDateBusinessCenterGrp).Parse(viewUnderlyingPaymentStreamPaymentDateBusinessCenterGrp);
			}
			if (view.GetView("UnderlyingPaymentStreamPaymentDateGrp") is IMessageView viewUnderlyingPaymentStreamPaymentDateGrp)
			{
				UnderlyingPaymentStreamPaymentDateGrp = new();
				((IFixParser)UnderlyingPaymentStreamPaymentDateGrp).Parse(viewUnderlyingPaymentStreamPaymentDateGrp);
			}
			UnderlyingPaymentStreamPaymentFrequencyPeriod = view.GetInt32(40583);
			UnderlyingPaymentStreamPaymentFrequencyUnit = view.GetString(40584);
			UnderlyingPaymentStreamPaymentRollConvention = view.GetString(40585);
			UnderlyingPaymentStreamFirstPaymentDateUnadjusted = view.GetDateOnly(40586);
			UnderlyingPaymentStreamLastRegularPaymentDateUnadjusted = view.GetDateOnly(40587);
			UnderlyingPaymentStreamPaymentDateRelativeTo = view.GetInt32(40588);
			UnderlyingPaymentStreamPaymentDateOffsetPeriod = view.GetInt32(40589);
			UnderlyingPaymentStreamPaymentDateOffsetUnit = view.GetString(40590);
			UnderlyingPaymentStreamPaymentDateOffsetDayType = view.GetInt32(40591);
			UnderlyingPaymentStreamMasterAgreementPaymentDatesIndicator = view.GetBool(41940);
			if (view.GetView("UnderlyingPaymentStreamFinalPricePaymentDate") is IMessageView viewUnderlyingPaymentStreamFinalPricePaymentDate)
			{
				UnderlyingPaymentStreamFinalPricePaymentDate = new();
				((IFixParser)UnderlyingPaymentStreamFinalPricePaymentDate).Parse(viewUnderlyingPaymentStreamFinalPricePaymentDate);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingPaymentStreamPaymentDateBusinessDayConvention":
				{
					value = UnderlyingPaymentStreamPaymentDateBusinessDayConvention;
					break;
				}
				case "UnderlyingPaymentStreamPaymentDateBusinessCenterGrp":
				{
					value = UnderlyingPaymentStreamPaymentDateBusinessCenterGrp;
					break;
				}
				case "UnderlyingPaymentStreamPaymentDateGrp":
				{
					value = UnderlyingPaymentStreamPaymentDateGrp;
					break;
				}
				case "UnderlyingPaymentStreamPaymentFrequencyPeriod":
				{
					value = UnderlyingPaymentStreamPaymentFrequencyPeriod;
					break;
				}
				case "UnderlyingPaymentStreamPaymentFrequencyUnit":
				{
					value = UnderlyingPaymentStreamPaymentFrequencyUnit;
					break;
				}
				case "UnderlyingPaymentStreamPaymentRollConvention":
				{
					value = UnderlyingPaymentStreamPaymentRollConvention;
					break;
				}
				case "UnderlyingPaymentStreamFirstPaymentDateUnadjusted":
				{
					value = UnderlyingPaymentStreamFirstPaymentDateUnadjusted;
					break;
				}
				case "UnderlyingPaymentStreamLastRegularPaymentDateUnadjusted":
				{
					value = UnderlyingPaymentStreamLastRegularPaymentDateUnadjusted;
					break;
				}
				case "UnderlyingPaymentStreamPaymentDateRelativeTo":
				{
					value = UnderlyingPaymentStreamPaymentDateRelativeTo;
					break;
				}
				case "UnderlyingPaymentStreamPaymentDateOffsetPeriod":
				{
					value = UnderlyingPaymentStreamPaymentDateOffsetPeriod;
					break;
				}
				case "UnderlyingPaymentStreamPaymentDateOffsetUnit":
				{
					value = UnderlyingPaymentStreamPaymentDateOffsetUnit;
					break;
				}
				case "UnderlyingPaymentStreamPaymentDateOffsetDayType":
				{
					value = UnderlyingPaymentStreamPaymentDateOffsetDayType;
					break;
				}
				case "UnderlyingPaymentStreamMasterAgreementPaymentDatesIndicator":
				{
					value = UnderlyingPaymentStreamMasterAgreementPaymentDatesIndicator;
					break;
				}
				case "UnderlyingPaymentStreamFinalPricePaymentDate":
				{
					value = UnderlyingPaymentStreamFinalPricePaymentDate;
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
			UnderlyingPaymentStreamPaymentDateBusinessDayConvention = null;
			((IFixReset?)UnderlyingPaymentStreamPaymentDateBusinessCenterGrp)?.Reset();
			((IFixReset?)UnderlyingPaymentStreamPaymentDateGrp)?.Reset();
			UnderlyingPaymentStreamPaymentFrequencyPeriod = null;
			UnderlyingPaymentStreamPaymentFrequencyUnit = null;
			UnderlyingPaymentStreamPaymentRollConvention = null;
			UnderlyingPaymentStreamFirstPaymentDateUnadjusted = null;
			UnderlyingPaymentStreamLastRegularPaymentDateUnadjusted = null;
			UnderlyingPaymentStreamPaymentDateRelativeTo = null;
			UnderlyingPaymentStreamPaymentDateOffsetPeriod = null;
			UnderlyingPaymentStreamPaymentDateOffsetUnit = null;
			UnderlyingPaymentStreamPaymentDateOffsetDayType = null;
			UnderlyingPaymentStreamMasterAgreementPaymentDatesIndicator = null;
			((IFixReset?)UnderlyingPaymentStreamFinalPricePaymentDate)?.Reset();
		}
	}
}
