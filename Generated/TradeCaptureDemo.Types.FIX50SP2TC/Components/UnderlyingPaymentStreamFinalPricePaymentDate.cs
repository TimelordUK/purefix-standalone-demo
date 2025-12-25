using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStreamFinalPricePaymentDate : IFixComponent
	{
		[TagDetails(Tag = 42949, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? UnderlyingPaymentStreamFinalPricePaymentDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42950, Type = TagType.Int, Offset = 1, Required = false)]
		public int? UnderlyingPaymentStreamFinalPricePaymentDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42951, Type = TagType.Int, Offset = 2, Required = false)]
		public int? UnderlyingPaymentStreamFinalPricePaymentDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42952, Type = TagType.String, Offset = 3, Required = false)]
		public string? UnderlyingPaymentStreamFinalPricePaymentDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42953, Type = TagType.Int, Offset = 4, Required = false)]
		public int? UnderlyingPaymentStreamFinalPricePaymentDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42954, Type = TagType.LocalDate, Offset = 5, Required = false)]
		public DateOnly? UnderlyingPaymentStreamFinalPricePaymentDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStreamFinalPricePaymentDateUnadjusted is not null) writer.WriteLocalDateOnly(42949, UnderlyingPaymentStreamFinalPricePaymentDateUnadjusted.Value);
			if (UnderlyingPaymentStreamFinalPricePaymentDateRelativeTo is not null) writer.WriteWholeNumber(42950, UnderlyingPaymentStreamFinalPricePaymentDateRelativeTo.Value);
			if (UnderlyingPaymentStreamFinalPricePaymentDateOffsetPeriod is not null) writer.WriteWholeNumber(42951, UnderlyingPaymentStreamFinalPricePaymentDateOffsetPeriod.Value);
			if (UnderlyingPaymentStreamFinalPricePaymentDateOffsetUnit is not null) writer.WriteString(42952, UnderlyingPaymentStreamFinalPricePaymentDateOffsetUnit);
			if (UnderlyingPaymentStreamFinalPricePaymentDateOffsetDayType is not null) writer.WriteWholeNumber(42953, UnderlyingPaymentStreamFinalPricePaymentDateOffsetDayType.Value);
			if (UnderlyingPaymentStreamFinalPricePaymentDateAdjusted is not null) writer.WriteLocalDateOnly(42954, UnderlyingPaymentStreamFinalPricePaymentDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingPaymentStreamFinalPricePaymentDateUnadjusted = view.GetDateOnly(42949);
			UnderlyingPaymentStreamFinalPricePaymentDateRelativeTo = view.GetInt32(42950);
			UnderlyingPaymentStreamFinalPricePaymentDateOffsetPeriod = view.GetInt32(42951);
			UnderlyingPaymentStreamFinalPricePaymentDateOffsetUnit = view.GetString(42952);
			UnderlyingPaymentStreamFinalPricePaymentDateOffsetDayType = view.GetInt32(42953);
			UnderlyingPaymentStreamFinalPricePaymentDateAdjusted = view.GetDateOnly(42954);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingPaymentStreamFinalPricePaymentDateUnadjusted":
				{
					value = UnderlyingPaymentStreamFinalPricePaymentDateUnadjusted;
					break;
				}
				case "UnderlyingPaymentStreamFinalPricePaymentDateRelativeTo":
				{
					value = UnderlyingPaymentStreamFinalPricePaymentDateRelativeTo;
					break;
				}
				case "UnderlyingPaymentStreamFinalPricePaymentDateOffsetPeriod":
				{
					value = UnderlyingPaymentStreamFinalPricePaymentDateOffsetPeriod;
					break;
				}
				case "UnderlyingPaymentStreamFinalPricePaymentDateOffsetUnit":
				{
					value = UnderlyingPaymentStreamFinalPricePaymentDateOffsetUnit;
					break;
				}
				case "UnderlyingPaymentStreamFinalPricePaymentDateOffsetDayType":
				{
					value = UnderlyingPaymentStreamFinalPricePaymentDateOffsetDayType;
					break;
				}
				case "UnderlyingPaymentStreamFinalPricePaymentDateAdjusted":
				{
					value = UnderlyingPaymentStreamFinalPricePaymentDateAdjusted;
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
			UnderlyingPaymentStreamFinalPricePaymentDateUnadjusted = null;
			UnderlyingPaymentStreamFinalPricePaymentDateRelativeTo = null;
			UnderlyingPaymentStreamFinalPricePaymentDateOffsetPeriod = null;
			UnderlyingPaymentStreamFinalPricePaymentDateOffsetUnit = null;
			UnderlyingPaymentStreamFinalPricePaymentDateOffsetDayType = null;
			UnderlyingPaymentStreamFinalPricePaymentDateAdjusted = null;
		}
	}
}
