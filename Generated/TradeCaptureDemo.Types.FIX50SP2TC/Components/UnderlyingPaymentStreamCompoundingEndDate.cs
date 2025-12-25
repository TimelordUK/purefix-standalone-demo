using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStreamCompoundingEndDate : IFixComponent
	{
		[TagDetails(Tag = 42917, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? UnderlyingPaymentStreamCompoundingEndDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42918, Type = TagType.Int, Offset = 1, Required = false)]
		public int? UnderlyingPaymentStreamCompoundingEndDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42919, Type = TagType.Int, Offset = 2, Required = false)]
		public int? UnderlyingPaymentStreamCompoundingEndDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42920, Type = TagType.String, Offset = 3, Required = false)]
		public string? UnderlyingPaymentStreamCompoundingEndDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42921, Type = TagType.Int, Offset = 4, Required = false)]
		public int? UnderlyingPaymentStreamCompoundingEndDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42922, Type = TagType.LocalDate, Offset = 5, Required = false)]
		public DateOnly? UnderlyingPaymentStreamCompoundingEndDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStreamCompoundingEndDateUnadjusted is not null) writer.WriteLocalDateOnly(42917, UnderlyingPaymentStreamCompoundingEndDateUnadjusted.Value);
			if (UnderlyingPaymentStreamCompoundingEndDateRelativeTo is not null) writer.WriteWholeNumber(42918, UnderlyingPaymentStreamCompoundingEndDateRelativeTo.Value);
			if (UnderlyingPaymentStreamCompoundingEndDateOffsetPeriod is not null) writer.WriteWholeNumber(42919, UnderlyingPaymentStreamCompoundingEndDateOffsetPeriod.Value);
			if (UnderlyingPaymentStreamCompoundingEndDateOffsetUnit is not null) writer.WriteString(42920, UnderlyingPaymentStreamCompoundingEndDateOffsetUnit);
			if (UnderlyingPaymentStreamCompoundingEndDateOffsetDayType is not null) writer.WriteWholeNumber(42921, UnderlyingPaymentStreamCompoundingEndDateOffsetDayType.Value);
			if (UnderlyingPaymentStreamCompoundingEndDateAdjusted is not null) writer.WriteLocalDateOnly(42922, UnderlyingPaymentStreamCompoundingEndDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingPaymentStreamCompoundingEndDateUnadjusted = view.GetDateOnly(42917);
			UnderlyingPaymentStreamCompoundingEndDateRelativeTo = view.GetInt32(42918);
			UnderlyingPaymentStreamCompoundingEndDateOffsetPeriod = view.GetInt32(42919);
			UnderlyingPaymentStreamCompoundingEndDateOffsetUnit = view.GetString(42920);
			UnderlyingPaymentStreamCompoundingEndDateOffsetDayType = view.GetInt32(42921);
			UnderlyingPaymentStreamCompoundingEndDateAdjusted = view.GetDateOnly(42922);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingPaymentStreamCompoundingEndDateUnadjusted":
				{
					value = UnderlyingPaymentStreamCompoundingEndDateUnadjusted;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingEndDateRelativeTo":
				{
					value = UnderlyingPaymentStreamCompoundingEndDateRelativeTo;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingEndDateOffsetPeriod":
				{
					value = UnderlyingPaymentStreamCompoundingEndDateOffsetPeriod;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingEndDateOffsetUnit":
				{
					value = UnderlyingPaymentStreamCompoundingEndDateOffsetUnit;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingEndDateOffsetDayType":
				{
					value = UnderlyingPaymentStreamCompoundingEndDateOffsetDayType;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingEndDateAdjusted":
				{
					value = UnderlyingPaymentStreamCompoundingEndDateAdjusted;
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
			UnderlyingPaymentStreamCompoundingEndDateUnadjusted = null;
			UnderlyingPaymentStreamCompoundingEndDateRelativeTo = null;
			UnderlyingPaymentStreamCompoundingEndDateOffsetPeriod = null;
			UnderlyingPaymentStreamCompoundingEndDateOffsetUnit = null;
			UnderlyingPaymentStreamCompoundingEndDateOffsetDayType = null;
			UnderlyingPaymentStreamCompoundingEndDateAdjusted = null;
		}
	}
}
