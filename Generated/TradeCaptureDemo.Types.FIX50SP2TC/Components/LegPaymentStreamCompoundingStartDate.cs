using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStreamCompoundingStartDate : IFixComponent
	{
		[TagDetails(Tag = 42445, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? LegPaymentStreamCompoundingStartDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42446, Type = TagType.Int, Offset = 1, Required = false)]
		public int? LegPaymentStreamCompoundingStartDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42447, Type = TagType.Int, Offset = 2, Required = false)]
		public int? LegPaymentStreamCompoundingStartDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42448, Type = TagType.String, Offset = 3, Required = false)]
		public string? LegPaymentStreamCompoundingStartDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42449, Type = TagType.Int, Offset = 4, Required = false)]
		public int? LegPaymentStreamCompoundingStartDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42450, Type = TagType.LocalDate, Offset = 5, Required = false)]
		public DateOnly? LegPaymentStreamCompoundingStartDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStreamCompoundingStartDateUnadjusted is not null) writer.WriteLocalDateOnly(42445, LegPaymentStreamCompoundingStartDateUnadjusted.Value);
			if (LegPaymentStreamCompoundingStartDateRelativeTo is not null) writer.WriteWholeNumber(42446, LegPaymentStreamCompoundingStartDateRelativeTo.Value);
			if (LegPaymentStreamCompoundingStartDateOffsetPeriod is not null) writer.WriteWholeNumber(42447, LegPaymentStreamCompoundingStartDateOffsetPeriod.Value);
			if (LegPaymentStreamCompoundingStartDateOffsetUnit is not null) writer.WriteString(42448, LegPaymentStreamCompoundingStartDateOffsetUnit);
			if (LegPaymentStreamCompoundingStartDateOffsetDayType is not null) writer.WriteWholeNumber(42449, LegPaymentStreamCompoundingStartDateOffsetDayType.Value);
			if (LegPaymentStreamCompoundingStartDateAdjusted is not null) writer.WriteLocalDateOnly(42450, LegPaymentStreamCompoundingStartDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegPaymentStreamCompoundingStartDateUnadjusted = view.GetDateOnly(42445);
			LegPaymentStreamCompoundingStartDateRelativeTo = view.GetInt32(42446);
			LegPaymentStreamCompoundingStartDateOffsetPeriod = view.GetInt32(42447);
			LegPaymentStreamCompoundingStartDateOffsetUnit = view.GetString(42448);
			LegPaymentStreamCompoundingStartDateOffsetDayType = view.GetInt32(42449);
			LegPaymentStreamCompoundingStartDateAdjusted = view.GetDateOnly(42450);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegPaymentStreamCompoundingStartDateUnadjusted":
				{
					value = LegPaymentStreamCompoundingStartDateUnadjusted;
					break;
				}
				case "LegPaymentStreamCompoundingStartDateRelativeTo":
				{
					value = LegPaymentStreamCompoundingStartDateRelativeTo;
					break;
				}
				case "LegPaymentStreamCompoundingStartDateOffsetPeriod":
				{
					value = LegPaymentStreamCompoundingStartDateOffsetPeriod;
					break;
				}
				case "LegPaymentStreamCompoundingStartDateOffsetUnit":
				{
					value = LegPaymentStreamCompoundingStartDateOffsetUnit;
					break;
				}
				case "LegPaymentStreamCompoundingStartDateOffsetDayType":
				{
					value = LegPaymentStreamCompoundingStartDateOffsetDayType;
					break;
				}
				case "LegPaymentStreamCompoundingStartDateAdjusted":
				{
					value = LegPaymentStreamCompoundingStartDateAdjusted;
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
			LegPaymentStreamCompoundingStartDateUnadjusted = null;
			LegPaymentStreamCompoundingStartDateRelativeTo = null;
			LegPaymentStreamCompoundingStartDateOffsetPeriod = null;
			LegPaymentStreamCompoundingStartDateOffsetUnit = null;
			LegPaymentStreamCompoundingStartDateOffsetDayType = null;
			LegPaymentStreamCompoundingStartDateAdjusted = null;
		}
	}
}
