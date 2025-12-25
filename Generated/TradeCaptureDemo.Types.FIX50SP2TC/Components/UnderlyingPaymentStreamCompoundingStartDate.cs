using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStreamCompoundingStartDate : IFixComponent
	{
		[TagDetails(Tag = 42941, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? UnderlyingPaymentStreamCompoundingStartDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42942, Type = TagType.Int, Offset = 1, Required = false)]
		public int? UnderlyingPaymentStreamCompoundingStartDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42943, Type = TagType.Int, Offset = 2, Required = false)]
		public int? UnderlyingPaymentStreamCompoundingStartDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42944, Type = TagType.String, Offset = 3, Required = false)]
		public string? UnderlyingPaymentStreamCompoundingStartDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42945, Type = TagType.Int, Offset = 4, Required = false)]
		public int? UnderlyingPaymentStreamCompoundingStartDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42946, Type = TagType.LocalDate, Offset = 5, Required = false)]
		public DateOnly? UnderlyingPaymentStreamCompoundingStartDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStreamCompoundingStartDateUnadjusted is not null) writer.WriteLocalDateOnly(42941, UnderlyingPaymentStreamCompoundingStartDateUnadjusted.Value);
			if (UnderlyingPaymentStreamCompoundingStartDateRelativeTo is not null) writer.WriteWholeNumber(42942, UnderlyingPaymentStreamCompoundingStartDateRelativeTo.Value);
			if (UnderlyingPaymentStreamCompoundingStartDateOffsetPeriod is not null) writer.WriteWholeNumber(42943, UnderlyingPaymentStreamCompoundingStartDateOffsetPeriod.Value);
			if (UnderlyingPaymentStreamCompoundingStartDateOffsetUnit is not null) writer.WriteString(42944, UnderlyingPaymentStreamCompoundingStartDateOffsetUnit);
			if (UnderlyingPaymentStreamCompoundingStartDateOffsetDayType is not null) writer.WriteWholeNumber(42945, UnderlyingPaymentStreamCompoundingStartDateOffsetDayType.Value);
			if (UnderlyingPaymentStreamCompoundingStartDateAdjusted is not null) writer.WriteLocalDateOnly(42946, UnderlyingPaymentStreamCompoundingStartDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingPaymentStreamCompoundingStartDateUnadjusted = view.GetDateOnly(42941);
			UnderlyingPaymentStreamCompoundingStartDateRelativeTo = view.GetInt32(42942);
			UnderlyingPaymentStreamCompoundingStartDateOffsetPeriod = view.GetInt32(42943);
			UnderlyingPaymentStreamCompoundingStartDateOffsetUnit = view.GetString(42944);
			UnderlyingPaymentStreamCompoundingStartDateOffsetDayType = view.GetInt32(42945);
			UnderlyingPaymentStreamCompoundingStartDateAdjusted = view.GetDateOnly(42946);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingPaymentStreamCompoundingStartDateUnadjusted":
				{
					value = UnderlyingPaymentStreamCompoundingStartDateUnadjusted;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingStartDateRelativeTo":
				{
					value = UnderlyingPaymentStreamCompoundingStartDateRelativeTo;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingStartDateOffsetPeriod":
				{
					value = UnderlyingPaymentStreamCompoundingStartDateOffsetPeriod;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingStartDateOffsetUnit":
				{
					value = UnderlyingPaymentStreamCompoundingStartDateOffsetUnit;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingStartDateOffsetDayType":
				{
					value = UnderlyingPaymentStreamCompoundingStartDateOffsetDayType;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingStartDateAdjusted":
				{
					value = UnderlyingPaymentStreamCompoundingStartDateAdjusted;
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
			UnderlyingPaymentStreamCompoundingStartDateUnadjusted = null;
			UnderlyingPaymentStreamCompoundingStartDateRelativeTo = null;
			UnderlyingPaymentStreamCompoundingStartDateOffsetPeriod = null;
			UnderlyingPaymentStreamCompoundingStartDateOffsetUnit = null;
			UnderlyingPaymentStreamCompoundingStartDateOffsetDayType = null;
			UnderlyingPaymentStreamCompoundingStartDateAdjusted = null;
		}
	}
}
