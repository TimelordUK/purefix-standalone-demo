using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStreamCompoundingEndDate : IFixComponent
	{
		[TagDetails(Tag = 42421, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? LegPaymentStreamCompoundingEndDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42422, Type = TagType.Int, Offset = 1, Required = false)]
		public int? LegPaymentStreamCompoundingEndDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42423, Type = TagType.Int, Offset = 2, Required = false)]
		public int? LegPaymentStreamCompoundingEndDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42424, Type = TagType.String, Offset = 3, Required = false)]
		public string? LegPaymentStreamCompoundingEndDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42425, Type = TagType.Int, Offset = 4, Required = false)]
		public int? LegPaymentStreamCompoundingEndDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42426, Type = TagType.LocalDate, Offset = 5, Required = false)]
		public DateOnly? LegPaymentStreamCompoundingEndDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStreamCompoundingEndDateUnadjusted is not null) writer.WriteLocalDateOnly(42421, LegPaymentStreamCompoundingEndDateUnadjusted.Value);
			if (LegPaymentStreamCompoundingEndDateRelativeTo is not null) writer.WriteWholeNumber(42422, LegPaymentStreamCompoundingEndDateRelativeTo.Value);
			if (LegPaymentStreamCompoundingEndDateOffsetPeriod is not null) writer.WriteWholeNumber(42423, LegPaymentStreamCompoundingEndDateOffsetPeriod.Value);
			if (LegPaymentStreamCompoundingEndDateOffsetUnit is not null) writer.WriteString(42424, LegPaymentStreamCompoundingEndDateOffsetUnit);
			if (LegPaymentStreamCompoundingEndDateOffsetDayType is not null) writer.WriteWholeNumber(42425, LegPaymentStreamCompoundingEndDateOffsetDayType.Value);
			if (LegPaymentStreamCompoundingEndDateAdjusted is not null) writer.WriteLocalDateOnly(42426, LegPaymentStreamCompoundingEndDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegPaymentStreamCompoundingEndDateUnadjusted = view.GetDateOnly(42421);
			LegPaymentStreamCompoundingEndDateRelativeTo = view.GetInt32(42422);
			LegPaymentStreamCompoundingEndDateOffsetPeriod = view.GetInt32(42423);
			LegPaymentStreamCompoundingEndDateOffsetUnit = view.GetString(42424);
			LegPaymentStreamCompoundingEndDateOffsetDayType = view.GetInt32(42425);
			LegPaymentStreamCompoundingEndDateAdjusted = view.GetDateOnly(42426);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegPaymentStreamCompoundingEndDateUnadjusted":
				{
					value = LegPaymentStreamCompoundingEndDateUnadjusted;
					break;
				}
				case "LegPaymentStreamCompoundingEndDateRelativeTo":
				{
					value = LegPaymentStreamCompoundingEndDateRelativeTo;
					break;
				}
				case "LegPaymentStreamCompoundingEndDateOffsetPeriod":
				{
					value = LegPaymentStreamCompoundingEndDateOffsetPeriod;
					break;
				}
				case "LegPaymentStreamCompoundingEndDateOffsetUnit":
				{
					value = LegPaymentStreamCompoundingEndDateOffsetUnit;
					break;
				}
				case "LegPaymentStreamCompoundingEndDateOffsetDayType":
				{
					value = LegPaymentStreamCompoundingEndDateOffsetDayType;
					break;
				}
				case "LegPaymentStreamCompoundingEndDateAdjusted":
				{
					value = LegPaymentStreamCompoundingEndDateAdjusted;
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
			LegPaymentStreamCompoundingEndDateUnadjusted = null;
			LegPaymentStreamCompoundingEndDateRelativeTo = null;
			LegPaymentStreamCompoundingEndDateOffsetPeriod = null;
			LegPaymentStreamCompoundingEndDateOffsetUnit = null;
			LegPaymentStreamCompoundingEndDateOffsetDayType = null;
			LegPaymentStreamCompoundingEndDateAdjusted = null;
		}
	}
}
