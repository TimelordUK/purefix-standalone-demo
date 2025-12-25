using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStreamFinalPricePaymentDate : IFixComponent
	{
		[TagDetails(Tag = 42453, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? LegPaymentStreamFinalPricePaymentDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42454, Type = TagType.Int, Offset = 1, Required = false)]
		public int? LegPaymentStreamFinalPricePaymentDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42455, Type = TagType.Int, Offset = 2, Required = false)]
		public int? LegPaymentStreamFinalPricePaymentDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42456, Type = TagType.String, Offset = 3, Required = false)]
		public string? LegPaymentStreamFinalPricePaymentDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42457, Type = TagType.Int, Offset = 4, Required = false)]
		public int? LegPaymentStreamFinalPricePaymentDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42458, Type = TagType.LocalDate, Offset = 5, Required = false)]
		public DateOnly? LegPaymentStreamFinalPricePaymentDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStreamFinalPricePaymentDateUnadjusted is not null) writer.WriteLocalDateOnly(42453, LegPaymentStreamFinalPricePaymentDateUnadjusted.Value);
			if (LegPaymentStreamFinalPricePaymentDateRelativeTo is not null) writer.WriteWholeNumber(42454, LegPaymentStreamFinalPricePaymentDateRelativeTo.Value);
			if (LegPaymentStreamFinalPricePaymentDateOffsetPeriod is not null) writer.WriteWholeNumber(42455, LegPaymentStreamFinalPricePaymentDateOffsetPeriod.Value);
			if (LegPaymentStreamFinalPricePaymentDateOffsetUnit is not null) writer.WriteString(42456, LegPaymentStreamFinalPricePaymentDateOffsetUnit);
			if (LegPaymentStreamFinalPricePaymentDateOffsetDayType is not null) writer.WriteWholeNumber(42457, LegPaymentStreamFinalPricePaymentDateOffsetDayType.Value);
			if (LegPaymentStreamFinalPricePaymentDateAdjusted is not null) writer.WriteLocalDateOnly(42458, LegPaymentStreamFinalPricePaymentDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegPaymentStreamFinalPricePaymentDateUnadjusted = view.GetDateOnly(42453);
			LegPaymentStreamFinalPricePaymentDateRelativeTo = view.GetInt32(42454);
			LegPaymentStreamFinalPricePaymentDateOffsetPeriod = view.GetInt32(42455);
			LegPaymentStreamFinalPricePaymentDateOffsetUnit = view.GetString(42456);
			LegPaymentStreamFinalPricePaymentDateOffsetDayType = view.GetInt32(42457);
			LegPaymentStreamFinalPricePaymentDateAdjusted = view.GetDateOnly(42458);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegPaymentStreamFinalPricePaymentDateUnadjusted":
				{
					value = LegPaymentStreamFinalPricePaymentDateUnadjusted;
					break;
				}
				case "LegPaymentStreamFinalPricePaymentDateRelativeTo":
				{
					value = LegPaymentStreamFinalPricePaymentDateRelativeTo;
					break;
				}
				case "LegPaymentStreamFinalPricePaymentDateOffsetPeriod":
				{
					value = LegPaymentStreamFinalPricePaymentDateOffsetPeriod;
					break;
				}
				case "LegPaymentStreamFinalPricePaymentDateOffsetUnit":
				{
					value = LegPaymentStreamFinalPricePaymentDateOffsetUnit;
					break;
				}
				case "LegPaymentStreamFinalPricePaymentDateOffsetDayType":
				{
					value = LegPaymentStreamFinalPricePaymentDateOffsetDayType;
					break;
				}
				case "LegPaymentStreamFinalPricePaymentDateAdjusted":
				{
					value = LegPaymentStreamFinalPricePaymentDateAdjusted;
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
			LegPaymentStreamFinalPricePaymentDateUnadjusted = null;
			LegPaymentStreamFinalPricePaymentDateRelativeTo = null;
			LegPaymentStreamFinalPricePaymentDateOffsetPeriod = null;
			LegPaymentStreamFinalPricePaymentDateOffsetUnit = null;
			LegPaymentStreamFinalPricePaymentDateOffsetDayType = null;
			LegPaymentStreamFinalPricePaymentDateAdjusted = null;
		}
	}
}
