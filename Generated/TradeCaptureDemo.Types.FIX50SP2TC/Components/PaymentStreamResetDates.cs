using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStreamResetDates : IFixComponent
	{
		[TagDetails(Tag = 40761, Type = TagType.Int, Offset = 0, Required = false)]
		public int? PaymentStreamResetDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40762, Type = TagType.Int, Offset = 1, Required = false)]
		public int? PaymentStreamResetDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public PaymentStreamResetDateBusinessCenterGrp? PaymentStreamResetDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40764, Type = TagType.Int, Offset = 3, Required = false)]
		public int? PaymentStreamResetFrequencyPeriod {get; set;}
		
		[TagDetails(Tag = 40765, Type = TagType.String, Offset = 4, Required = false)]
		public string? PaymentStreamResetFrequencyUnit {get; set;}
		
		[TagDetails(Tag = 40766, Type = TagType.String, Offset = 5, Required = false)]
		public string? PaymentStreamResetWeeklyRollConvention {get; set;}
		
		[TagDetails(Tag = 40767, Type = TagType.Int, Offset = 6, Required = false)]
		public int? PaymentStreamInitialFixingDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40768, Type = TagType.Int, Offset = 7, Required = false)]
		public int? PaymentStreamInitialFixingDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public PaymentStreamInitialFixingDateBusinessCenterGrp? PaymentStreamInitialFixingDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40770, Type = TagType.Int, Offset = 9, Required = false)]
		public int? PaymentStreamInitialFixingDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40771, Type = TagType.String, Offset = 10, Required = false)]
		public string? PaymentStreamInitialFixingDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40772, Type = TagType.Int, Offset = 11, Required = false)]
		public int? PaymentStreamInitialFixingDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 40773, Type = TagType.LocalDate, Offset = 12, Required = false)]
		public DateOnly? PaymentStreamInitialFixingDateAdjusted {get; set;}
		
		[TagDetails(Tag = 40774, Type = TagType.Int, Offset = 13, Required = false)]
		public int? PaymentStreamFixingDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40775, Type = TagType.Int, Offset = 14, Required = false)]
		public int? PaymentStreamFixingDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 15, Required = false)]
		public PaymentStreamFixingDateBusinessCenterGrp? PaymentStreamFixingDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40777, Type = TagType.Int, Offset = 16, Required = false)]
		public int? PaymentStreamFixingDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40778, Type = TagType.String, Offset = 17, Required = false)]
		public string? PaymentStreamFixingDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40779, Type = TagType.Int, Offset = 18, Required = false)]
		public int? PaymentStreamFixingDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 40780, Type = TagType.LocalDate, Offset = 19, Required = false)]
		public DateOnly? PaymentStreamFixingDateAdjusted {get; set;}
		
		[TagDetails(Tag = 40781, Type = TagType.Int, Offset = 20, Required = false)]
		public int? PaymentStreamRateCutoffDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40782, Type = TagType.String, Offset = 21, Required = false)]
		public string? PaymentStreamRateCutoffDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40783, Type = TagType.Int, Offset = 22, Required = false)]
		public int? PaymentStreamRateCutoffDateOffsetDayType {get; set;}
		
		[Component(Offset = 23, Required = false)]
		public PaymentStreamFixingDateGrp? PaymentStreamFixingDateGrp {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStreamResetDateRelativeTo is not null) writer.WriteWholeNumber(40761, PaymentStreamResetDateRelativeTo.Value);
			if (PaymentStreamResetDateBusinessDayConvention is not null) writer.WriteWholeNumber(40762, PaymentStreamResetDateBusinessDayConvention.Value);
			if (PaymentStreamResetDateBusinessCenterGrp is not null) ((IFixEncoder)PaymentStreamResetDateBusinessCenterGrp).Encode(writer);
			if (PaymentStreamResetFrequencyPeriod is not null) writer.WriteWholeNumber(40764, PaymentStreamResetFrequencyPeriod.Value);
			if (PaymentStreamResetFrequencyUnit is not null) writer.WriteString(40765, PaymentStreamResetFrequencyUnit);
			if (PaymentStreamResetWeeklyRollConvention is not null) writer.WriteString(40766, PaymentStreamResetWeeklyRollConvention);
			if (PaymentStreamInitialFixingDateRelativeTo is not null) writer.WriteWholeNumber(40767, PaymentStreamInitialFixingDateRelativeTo.Value);
			if (PaymentStreamInitialFixingDateBusinessDayConvention is not null) writer.WriteWholeNumber(40768, PaymentStreamInitialFixingDateBusinessDayConvention.Value);
			if (PaymentStreamInitialFixingDateBusinessCenterGrp is not null) ((IFixEncoder)PaymentStreamInitialFixingDateBusinessCenterGrp).Encode(writer);
			if (PaymentStreamInitialFixingDateOffsetPeriod is not null) writer.WriteWholeNumber(40770, PaymentStreamInitialFixingDateOffsetPeriod.Value);
			if (PaymentStreamInitialFixingDateOffsetUnit is not null) writer.WriteString(40771, PaymentStreamInitialFixingDateOffsetUnit);
			if (PaymentStreamInitialFixingDateOffsetDayType is not null) writer.WriteWholeNumber(40772, PaymentStreamInitialFixingDateOffsetDayType.Value);
			if (PaymentStreamInitialFixingDateAdjusted is not null) writer.WriteLocalDateOnly(40773, PaymentStreamInitialFixingDateAdjusted.Value);
			if (PaymentStreamFixingDateRelativeTo is not null) writer.WriteWholeNumber(40774, PaymentStreamFixingDateRelativeTo.Value);
			if (PaymentStreamFixingDateBusinessDayConvention is not null) writer.WriteWholeNumber(40775, PaymentStreamFixingDateBusinessDayConvention.Value);
			if (PaymentStreamFixingDateBusinessCenterGrp is not null) ((IFixEncoder)PaymentStreamFixingDateBusinessCenterGrp).Encode(writer);
			if (PaymentStreamFixingDateOffsetPeriod is not null) writer.WriteWholeNumber(40777, PaymentStreamFixingDateOffsetPeriod.Value);
			if (PaymentStreamFixingDateOffsetUnit is not null) writer.WriteString(40778, PaymentStreamFixingDateOffsetUnit);
			if (PaymentStreamFixingDateOffsetDayType is not null) writer.WriteWholeNumber(40779, PaymentStreamFixingDateOffsetDayType.Value);
			if (PaymentStreamFixingDateAdjusted is not null) writer.WriteLocalDateOnly(40780, PaymentStreamFixingDateAdjusted.Value);
			if (PaymentStreamRateCutoffDateOffsetPeriod is not null) writer.WriteWholeNumber(40781, PaymentStreamRateCutoffDateOffsetPeriod.Value);
			if (PaymentStreamRateCutoffDateOffsetUnit is not null) writer.WriteString(40782, PaymentStreamRateCutoffDateOffsetUnit);
			if (PaymentStreamRateCutoffDateOffsetDayType is not null) writer.WriteWholeNumber(40783, PaymentStreamRateCutoffDateOffsetDayType.Value);
			if (PaymentStreamFixingDateGrp is not null) ((IFixEncoder)PaymentStreamFixingDateGrp).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			PaymentStreamResetDateRelativeTo = view.GetInt32(40761);
			PaymentStreamResetDateBusinessDayConvention = view.GetInt32(40762);
			if (view.GetView("PaymentStreamResetDateBusinessCenterGrp") is IMessageView viewPaymentStreamResetDateBusinessCenterGrp)
			{
				PaymentStreamResetDateBusinessCenterGrp = new();
				((IFixParser)PaymentStreamResetDateBusinessCenterGrp).Parse(viewPaymentStreamResetDateBusinessCenterGrp);
			}
			PaymentStreamResetFrequencyPeriod = view.GetInt32(40764);
			PaymentStreamResetFrequencyUnit = view.GetString(40765);
			PaymentStreamResetWeeklyRollConvention = view.GetString(40766);
			PaymentStreamInitialFixingDateRelativeTo = view.GetInt32(40767);
			PaymentStreamInitialFixingDateBusinessDayConvention = view.GetInt32(40768);
			if (view.GetView("PaymentStreamInitialFixingDateBusinessCenterGrp") is IMessageView viewPaymentStreamInitialFixingDateBusinessCenterGrp)
			{
				PaymentStreamInitialFixingDateBusinessCenterGrp = new();
				((IFixParser)PaymentStreamInitialFixingDateBusinessCenterGrp).Parse(viewPaymentStreamInitialFixingDateBusinessCenterGrp);
			}
			PaymentStreamInitialFixingDateOffsetPeriod = view.GetInt32(40770);
			PaymentStreamInitialFixingDateOffsetUnit = view.GetString(40771);
			PaymentStreamInitialFixingDateOffsetDayType = view.GetInt32(40772);
			PaymentStreamInitialFixingDateAdjusted = view.GetDateOnly(40773);
			PaymentStreamFixingDateRelativeTo = view.GetInt32(40774);
			PaymentStreamFixingDateBusinessDayConvention = view.GetInt32(40775);
			if (view.GetView("PaymentStreamFixingDateBusinessCenterGrp") is IMessageView viewPaymentStreamFixingDateBusinessCenterGrp)
			{
				PaymentStreamFixingDateBusinessCenterGrp = new();
				((IFixParser)PaymentStreamFixingDateBusinessCenterGrp).Parse(viewPaymentStreamFixingDateBusinessCenterGrp);
			}
			PaymentStreamFixingDateOffsetPeriod = view.GetInt32(40777);
			PaymentStreamFixingDateOffsetUnit = view.GetString(40778);
			PaymentStreamFixingDateOffsetDayType = view.GetInt32(40779);
			PaymentStreamFixingDateAdjusted = view.GetDateOnly(40780);
			PaymentStreamRateCutoffDateOffsetPeriod = view.GetInt32(40781);
			PaymentStreamRateCutoffDateOffsetUnit = view.GetString(40782);
			PaymentStreamRateCutoffDateOffsetDayType = view.GetInt32(40783);
			if (view.GetView("PaymentStreamFixingDateGrp") is IMessageView viewPaymentStreamFixingDateGrp)
			{
				PaymentStreamFixingDateGrp = new();
				((IFixParser)PaymentStreamFixingDateGrp).Parse(viewPaymentStreamFixingDateGrp);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "PaymentStreamResetDateRelativeTo":
				{
					value = PaymentStreamResetDateRelativeTo;
					break;
				}
				case "PaymentStreamResetDateBusinessDayConvention":
				{
					value = PaymentStreamResetDateBusinessDayConvention;
					break;
				}
				case "PaymentStreamResetDateBusinessCenterGrp":
				{
					value = PaymentStreamResetDateBusinessCenterGrp;
					break;
				}
				case "PaymentStreamResetFrequencyPeriod":
				{
					value = PaymentStreamResetFrequencyPeriod;
					break;
				}
				case "PaymentStreamResetFrequencyUnit":
				{
					value = PaymentStreamResetFrequencyUnit;
					break;
				}
				case "PaymentStreamResetWeeklyRollConvention":
				{
					value = PaymentStreamResetWeeklyRollConvention;
					break;
				}
				case "PaymentStreamInitialFixingDateRelativeTo":
				{
					value = PaymentStreamInitialFixingDateRelativeTo;
					break;
				}
				case "PaymentStreamInitialFixingDateBusinessDayConvention":
				{
					value = PaymentStreamInitialFixingDateBusinessDayConvention;
					break;
				}
				case "PaymentStreamInitialFixingDateBusinessCenterGrp":
				{
					value = PaymentStreamInitialFixingDateBusinessCenterGrp;
					break;
				}
				case "PaymentStreamInitialFixingDateOffsetPeriod":
				{
					value = PaymentStreamInitialFixingDateOffsetPeriod;
					break;
				}
				case "PaymentStreamInitialFixingDateOffsetUnit":
				{
					value = PaymentStreamInitialFixingDateOffsetUnit;
					break;
				}
				case "PaymentStreamInitialFixingDateOffsetDayType":
				{
					value = PaymentStreamInitialFixingDateOffsetDayType;
					break;
				}
				case "PaymentStreamInitialFixingDateAdjusted":
				{
					value = PaymentStreamInitialFixingDateAdjusted;
					break;
				}
				case "PaymentStreamFixingDateRelativeTo":
				{
					value = PaymentStreamFixingDateRelativeTo;
					break;
				}
				case "PaymentStreamFixingDateBusinessDayConvention":
				{
					value = PaymentStreamFixingDateBusinessDayConvention;
					break;
				}
				case "PaymentStreamFixingDateBusinessCenterGrp":
				{
					value = PaymentStreamFixingDateBusinessCenterGrp;
					break;
				}
				case "PaymentStreamFixingDateOffsetPeriod":
				{
					value = PaymentStreamFixingDateOffsetPeriod;
					break;
				}
				case "PaymentStreamFixingDateOffsetUnit":
				{
					value = PaymentStreamFixingDateOffsetUnit;
					break;
				}
				case "PaymentStreamFixingDateOffsetDayType":
				{
					value = PaymentStreamFixingDateOffsetDayType;
					break;
				}
				case "PaymentStreamFixingDateAdjusted":
				{
					value = PaymentStreamFixingDateAdjusted;
					break;
				}
				case "PaymentStreamRateCutoffDateOffsetPeriod":
				{
					value = PaymentStreamRateCutoffDateOffsetPeriod;
					break;
				}
				case "PaymentStreamRateCutoffDateOffsetUnit":
				{
					value = PaymentStreamRateCutoffDateOffsetUnit;
					break;
				}
				case "PaymentStreamRateCutoffDateOffsetDayType":
				{
					value = PaymentStreamRateCutoffDateOffsetDayType;
					break;
				}
				case "PaymentStreamFixingDateGrp":
				{
					value = PaymentStreamFixingDateGrp;
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
			PaymentStreamResetDateRelativeTo = null;
			PaymentStreamResetDateBusinessDayConvention = null;
			((IFixReset?)PaymentStreamResetDateBusinessCenterGrp)?.Reset();
			PaymentStreamResetFrequencyPeriod = null;
			PaymentStreamResetFrequencyUnit = null;
			PaymentStreamResetWeeklyRollConvention = null;
			PaymentStreamInitialFixingDateRelativeTo = null;
			PaymentStreamInitialFixingDateBusinessDayConvention = null;
			((IFixReset?)PaymentStreamInitialFixingDateBusinessCenterGrp)?.Reset();
			PaymentStreamInitialFixingDateOffsetPeriod = null;
			PaymentStreamInitialFixingDateOffsetUnit = null;
			PaymentStreamInitialFixingDateOffsetDayType = null;
			PaymentStreamInitialFixingDateAdjusted = null;
			PaymentStreamFixingDateRelativeTo = null;
			PaymentStreamFixingDateBusinessDayConvention = null;
			((IFixReset?)PaymentStreamFixingDateBusinessCenterGrp)?.Reset();
			PaymentStreamFixingDateOffsetPeriod = null;
			PaymentStreamFixingDateOffsetUnit = null;
			PaymentStreamFixingDateOffsetDayType = null;
			PaymentStreamFixingDateAdjusted = null;
			PaymentStreamRateCutoffDateOffsetPeriod = null;
			PaymentStreamRateCutoffDateOffsetUnit = null;
			PaymentStreamRateCutoffDateOffsetDayType = null;
			((IFixReset?)PaymentStreamFixingDateGrp)?.Reset();
		}
	}
}
