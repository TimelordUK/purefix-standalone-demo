using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PriceLimits : IFixComponent
	{
		[TagDetails(Tag = 1306, Type = TagType.Int, Offset = 0, Required = false)]
		public int? PriceLimitType {get; set;}
		
		[TagDetails(Tag = 1148, Type = TagType.Float, Offset = 1, Required = false)]
		public double? LowLimitPrice {get; set;}
		
		[TagDetails(Tag = 1149, Type = TagType.Float, Offset = 2, Required = false)]
		public double? HighLimitPrice {get; set;}
		
		[TagDetails(Tag = 1150, Type = TagType.Float, Offset = 3, Required = false)]
		public double? TradingReferencePrice {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PriceLimitType is not null) writer.WriteWholeNumber(1306, PriceLimitType.Value);
			if (LowLimitPrice is not null) writer.WriteNumber(1148, LowLimitPrice.Value);
			if (HighLimitPrice is not null) writer.WriteNumber(1149, HighLimitPrice.Value);
			if (TradingReferencePrice is not null) writer.WriteNumber(1150, TradingReferencePrice.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			PriceLimitType = view.GetInt32(1306);
			LowLimitPrice = view.GetDouble(1148);
			HighLimitPrice = view.GetDouble(1149);
			TradingReferencePrice = view.GetDouble(1150);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "PriceLimitType":
				{
					value = PriceLimitType;
					break;
				}
				case "LowLimitPrice":
				{
					value = LowLimitPrice;
					break;
				}
				case "HighLimitPrice":
				{
					value = HighLimitPrice;
					break;
				}
				case "TradingReferencePrice":
				{
					value = TradingReferencePrice;
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
			PriceLimitType = null;
			LowLimitPrice = null;
			HighLimitPrice = null;
			TradingReferencePrice = null;
		}
	}
}
