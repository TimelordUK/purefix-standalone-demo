using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class SecondaryPriceLimits : IFixComponent
	{
		[TagDetails(Tag = 1305, Type = TagType.Int, Offset = 0, Required = false)]
		public int? SecondaryPriceLimitType {get; set;}
		
		[TagDetails(Tag = 1221, Type = TagType.Float, Offset = 1, Required = false)]
		public double? SecondaryLowLimitPrice {get; set;}
		
		[TagDetails(Tag = 1230, Type = TagType.Float, Offset = 2, Required = false)]
		public double? SecondaryHighLimitPrice {get; set;}
		
		[TagDetails(Tag = 1240, Type = TagType.Float, Offset = 3, Required = false)]
		public double? SecondaryTradingReferencePrice {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (SecondaryPriceLimitType is not null) writer.WriteWholeNumber(1305, SecondaryPriceLimitType.Value);
			if (SecondaryLowLimitPrice is not null) writer.WriteNumber(1221, SecondaryLowLimitPrice.Value);
			if (SecondaryHighLimitPrice is not null) writer.WriteNumber(1230, SecondaryHighLimitPrice.Value);
			if (SecondaryTradingReferencePrice is not null) writer.WriteNumber(1240, SecondaryTradingReferencePrice.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			SecondaryPriceLimitType = view.GetInt32(1305);
			SecondaryLowLimitPrice = view.GetDouble(1221);
			SecondaryHighLimitPrice = view.GetDouble(1230);
			SecondaryTradingReferencePrice = view.GetDouble(1240);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "SecondaryPriceLimitType":
				{
					value = SecondaryPriceLimitType;
					break;
				}
				case "SecondaryLowLimitPrice":
				{
					value = SecondaryLowLimitPrice;
					break;
				}
				case "SecondaryHighLimitPrice":
				{
					value = SecondaryHighLimitPrice;
					break;
				}
				case "SecondaryTradingReferencePrice":
				{
					value = SecondaryTradingReferencePrice;
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
			SecondaryPriceLimitType = null;
			SecondaryLowLimitPrice = null;
			SecondaryHighLimitPrice = null;
			SecondaryTradingReferencePrice = null;
		}
	}
}
