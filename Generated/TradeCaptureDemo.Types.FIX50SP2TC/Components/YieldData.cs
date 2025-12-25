using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class YieldData : IFixComponent
	{
		[TagDetails(Tag = 235, Type = TagType.String, Offset = 0, Required = false)]
		public string? YieldType {get; set;}
		
		[TagDetails(Tag = 236, Type = TagType.Float, Offset = 1, Required = false)]
		public double? Yield {get; set;}
		
		[TagDetails(Tag = 701, Type = TagType.LocalDate, Offset = 2, Required = false)]
		public DateOnly? YieldCalcDate {get; set;}
		
		[TagDetails(Tag = 696, Type = TagType.LocalDate, Offset = 3, Required = false)]
		public DateOnly? YieldRedemptionDate {get; set;}
		
		[TagDetails(Tag = 697, Type = TagType.Float, Offset = 4, Required = false)]
		public double? YieldRedemptionPrice {get; set;}
		
		[TagDetails(Tag = 698, Type = TagType.Int, Offset = 5, Required = false)]
		public int? YieldRedemptionPriceType {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (YieldType is not null) writer.WriteString(235, YieldType);
			if (Yield is not null) writer.WriteNumber(236, Yield.Value);
			if (YieldCalcDate is not null) writer.WriteLocalDateOnly(701, YieldCalcDate.Value);
			if (YieldRedemptionDate is not null) writer.WriteLocalDateOnly(696, YieldRedemptionDate.Value);
			if (YieldRedemptionPrice is not null) writer.WriteNumber(697, YieldRedemptionPrice.Value);
			if (YieldRedemptionPriceType is not null) writer.WriteWholeNumber(698, YieldRedemptionPriceType.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			YieldType = view.GetString(235);
			Yield = view.GetDouble(236);
			YieldCalcDate = view.GetDateOnly(701);
			YieldRedemptionDate = view.GetDateOnly(696);
			YieldRedemptionPrice = view.GetDouble(697);
			YieldRedemptionPriceType = view.GetInt32(698);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "YieldType":
				{
					value = YieldType;
					break;
				}
				case "Yield":
				{
					value = Yield;
					break;
				}
				case "YieldCalcDate":
				{
					value = YieldCalcDate;
					break;
				}
				case "YieldRedemptionDate":
				{
					value = YieldRedemptionDate;
					break;
				}
				case "YieldRedemptionPrice":
				{
					value = YieldRedemptionPrice;
					break;
				}
				case "YieldRedemptionPriceType":
				{
					value = YieldRedemptionPriceType;
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
			YieldType = null;
			Yield = null;
			YieldCalcDate = null;
			YieldRedemptionDate = null;
			YieldRedemptionPrice = null;
			YieldRedemptionPriceType = null;
		}
	}
}
