using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStreamCompoundingStartDate : IFixComponent
	{
		[TagDetails(Tag = 42646, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? PaymentStreamCompoundingStartDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42647, Type = TagType.Int, Offset = 1, Required = false)]
		public int? PaymentStreamCompoundingStartDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42648, Type = TagType.Int, Offset = 2, Required = false)]
		public int? PaymentStreamCompoundingStartDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42649, Type = TagType.String, Offset = 3, Required = false)]
		public string? PaymentStreamCompoundingStartDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42650, Type = TagType.Int, Offset = 4, Required = false)]
		public int? PaymentStreamCompoundingStartDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42651, Type = TagType.LocalDate, Offset = 5, Required = false)]
		public DateOnly? PaymentStreamCompoundingStartDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStreamCompoundingStartDateUnadjusted is not null) writer.WriteLocalDateOnly(42646, PaymentStreamCompoundingStartDateUnadjusted.Value);
			if (PaymentStreamCompoundingStartDateRelativeTo is not null) writer.WriteWholeNumber(42647, PaymentStreamCompoundingStartDateRelativeTo.Value);
			if (PaymentStreamCompoundingStartDateOffsetPeriod is not null) writer.WriteWholeNumber(42648, PaymentStreamCompoundingStartDateOffsetPeriod.Value);
			if (PaymentStreamCompoundingStartDateOffsetUnit is not null) writer.WriteString(42649, PaymentStreamCompoundingStartDateOffsetUnit);
			if (PaymentStreamCompoundingStartDateOffsetDayType is not null) writer.WriteWholeNumber(42650, PaymentStreamCompoundingStartDateOffsetDayType.Value);
			if (PaymentStreamCompoundingStartDateAdjusted is not null) writer.WriteLocalDateOnly(42651, PaymentStreamCompoundingStartDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			PaymentStreamCompoundingStartDateUnadjusted = view.GetDateOnly(42646);
			PaymentStreamCompoundingStartDateRelativeTo = view.GetInt32(42647);
			PaymentStreamCompoundingStartDateOffsetPeriod = view.GetInt32(42648);
			PaymentStreamCompoundingStartDateOffsetUnit = view.GetString(42649);
			PaymentStreamCompoundingStartDateOffsetDayType = view.GetInt32(42650);
			PaymentStreamCompoundingStartDateAdjusted = view.GetDateOnly(42651);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "PaymentStreamCompoundingStartDateUnadjusted":
				{
					value = PaymentStreamCompoundingStartDateUnadjusted;
					break;
				}
				case "PaymentStreamCompoundingStartDateRelativeTo":
				{
					value = PaymentStreamCompoundingStartDateRelativeTo;
					break;
				}
				case "PaymentStreamCompoundingStartDateOffsetPeriod":
				{
					value = PaymentStreamCompoundingStartDateOffsetPeriod;
					break;
				}
				case "PaymentStreamCompoundingStartDateOffsetUnit":
				{
					value = PaymentStreamCompoundingStartDateOffsetUnit;
					break;
				}
				case "PaymentStreamCompoundingStartDateOffsetDayType":
				{
					value = PaymentStreamCompoundingStartDateOffsetDayType;
					break;
				}
				case "PaymentStreamCompoundingStartDateAdjusted":
				{
					value = PaymentStreamCompoundingStartDateAdjusted;
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
			PaymentStreamCompoundingStartDateUnadjusted = null;
			PaymentStreamCompoundingStartDateRelativeTo = null;
			PaymentStreamCompoundingStartDateOffsetPeriod = null;
			PaymentStreamCompoundingStartDateOffsetUnit = null;
			PaymentStreamCompoundingStartDateOffsetDayType = null;
			PaymentStreamCompoundingStartDateAdjusted = null;
		}
	}
}
