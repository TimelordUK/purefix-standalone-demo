using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ReturnRatePriceGrp : IFixComponent
	{
		public sealed partial class NoReturnRatePrices : IFixGroup
		{
			[TagDetails(Tag = 42766, Type = TagType.Int, Offset = 0, Required = false)]
			public int? ReturnRatePriceBasis {get; set;}
			
			[TagDetails(Tag = 42767, Type = TagType.Float, Offset = 1, Required = false)]
			public double? ReturnRatePrice {get; set;}
			
			[TagDetails(Tag = 42768, Type = TagType.String, Offset = 2, Required = false)]
			public string? ReturnRatePriceCurrency {get; set;}
			
			[TagDetails(Tag = 42769, Type = TagType.Int, Offset = 3, Required = false)]
			public int? ReturnRatePriceType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ReturnRatePriceBasis is not null) writer.WriteWholeNumber(42766, ReturnRatePriceBasis.Value);
				if (ReturnRatePrice is not null) writer.WriteNumber(42767, ReturnRatePrice.Value);
				if (ReturnRatePriceCurrency is not null) writer.WriteString(42768, ReturnRatePriceCurrency);
				if (ReturnRatePriceType is not null) writer.WriteWholeNumber(42769, ReturnRatePriceType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ReturnRatePriceBasis = view.GetInt32(42766);
				ReturnRatePrice = view.GetDouble(42767);
				ReturnRatePriceCurrency = view.GetString(42768);
				ReturnRatePriceType = view.GetInt32(42769);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ReturnRatePriceBasis":
					{
						value = ReturnRatePriceBasis;
						break;
					}
					case "ReturnRatePrice":
					{
						value = ReturnRatePrice;
						break;
					}
					case "ReturnRatePriceCurrency":
					{
						value = ReturnRatePriceCurrency;
						break;
					}
					case "ReturnRatePriceType":
					{
						value = ReturnRatePriceType;
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
				ReturnRatePriceBasis = null;
				ReturnRatePrice = null;
				ReturnRatePriceCurrency = null;
				ReturnRatePriceType = null;
			}
		}
		[Group(NoOfTag = 42765, Offset = 0, Required = false)]
		public NoReturnRatePrices[]? ReturnRatePrices {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ReturnRatePrices is not null && ReturnRatePrices.Length != 0)
			{
				writer.WriteWholeNumber(42765, ReturnRatePrices.Length);
				for (int i = 0; i < ReturnRatePrices.Length; i++)
				{
					((IFixEncoder)ReturnRatePrices[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoReturnRatePrices") is IMessageView viewNoReturnRatePrices)
			{
				var count = viewNoReturnRatePrices.GroupCount();
				ReturnRatePrices = new NoReturnRatePrices[count];
				for (int i = 0; i < count; i++)
				{
					ReturnRatePrices[i] = new();
					((IFixParser)ReturnRatePrices[i]).Parse(viewNoReturnRatePrices.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoReturnRatePrices":
				{
					value = ReturnRatePrices;
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
			ReturnRatePrices = null;
		}
	}
}
