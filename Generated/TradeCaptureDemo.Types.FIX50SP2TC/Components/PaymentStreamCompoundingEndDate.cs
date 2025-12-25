using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStreamCompoundingEndDate : IFixComponent
	{
		[TagDetails(Tag = 42622, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? PaymentStreamCompoundingEndDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42623, Type = TagType.Int, Offset = 1, Required = false)]
		public int? PaymentStreamCompoundingEndDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42624, Type = TagType.Int, Offset = 2, Required = false)]
		public int? PaymentStreamCompoundingEndDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42625, Type = TagType.String, Offset = 3, Required = false)]
		public string? PaymentStreamCompoundingEndDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42626, Type = TagType.Int, Offset = 4, Required = false)]
		public int? PaymentStreamCompoundingEndDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42627, Type = TagType.LocalDate, Offset = 5, Required = false)]
		public DateOnly? PaymentStreamCompoundingEndDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStreamCompoundingEndDateUnadjusted is not null) writer.WriteLocalDateOnly(42622, PaymentStreamCompoundingEndDateUnadjusted.Value);
			if (PaymentStreamCompoundingEndDateRelativeTo is not null) writer.WriteWholeNumber(42623, PaymentStreamCompoundingEndDateRelativeTo.Value);
			if (PaymentStreamCompoundingEndDateOffsetPeriod is not null) writer.WriteWholeNumber(42624, PaymentStreamCompoundingEndDateOffsetPeriod.Value);
			if (PaymentStreamCompoundingEndDateOffsetUnit is not null) writer.WriteString(42625, PaymentStreamCompoundingEndDateOffsetUnit);
			if (PaymentStreamCompoundingEndDateOffsetDayType is not null) writer.WriteWholeNumber(42626, PaymentStreamCompoundingEndDateOffsetDayType.Value);
			if (PaymentStreamCompoundingEndDateAdjusted is not null) writer.WriteLocalDateOnly(42627, PaymentStreamCompoundingEndDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			PaymentStreamCompoundingEndDateUnadjusted = view.GetDateOnly(42622);
			PaymentStreamCompoundingEndDateRelativeTo = view.GetInt32(42623);
			PaymentStreamCompoundingEndDateOffsetPeriod = view.GetInt32(42624);
			PaymentStreamCompoundingEndDateOffsetUnit = view.GetString(42625);
			PaymentStreamCompoundingEndDateOffsetDayType = view.GetInt32(42626);
			PaymentStreamCompoundingEndDateAdjusted = view.GetDateOnly(42627);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "PaymentStreamCompoundingEndDateUnadjusted":
				{
					value = PaymentStreamCompoundingEndDateUnadjusted;
					break;
				}
				case "PaymentStreamCompoundingEndDateRelativeTo":
				{
					value = PaymentStreamCompoundingEndDateRelativeTo;
					break;
				}
				case "PaymentStreamCompoundingEndDateOffsetPeriod":
				{
					value = PaymentStreamCompoundingEndDateOffsetPeriod;
					break;
				}
				case "PaymentStreamCompoundingEndDateOffsetUnit":
				{
					value = PaymentStreamCompoundingEndDateOffsetUnit;
					break;
				}
				case "PaymentStreamCompoundingEndDateOffsetDayType":
				{
					value = PaymentStreamCompoundingEndDateOffsetDayType;
					break;
				}
				case "PaymentStreamCompoundingEndDateAdjusted":
				{
					value = PaymentStreamCompoundingEndDateAdjusted;
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
			PaymentStreamCompoundingEndDateUnadjusted = null;
			PaymentStreamCompoundingEndDateRelativeTo = null;
			PaymentStreamCompoundingEndDateOffsetPeriod = null;
			PaymentStreamCompoundingEndDateOffsetUnit = null;
			PaymentStreamCompoundingEndDateOffsetDayType = null;
			PaymentStreamCompoundingEndDateAdjusted = null;
		}
	}
}
