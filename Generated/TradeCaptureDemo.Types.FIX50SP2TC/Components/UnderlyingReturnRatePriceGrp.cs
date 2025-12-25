using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingReturnRatePriceGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingReturnRatePrices : IFixGroup
		{
			[TagDetails(Tag = 43065, Type = TagType.Int, Offset = 0, Required = false)]
			public int? UnderlyingReturnRatePriceBasis {get; set;}
			
			[TagDetails(Tag = 43066, Type = TagType.Float, Offset = 1, Required = false)]
			public double? UnderlyingReturnRatePrice {get; set;}
			
			[TagDetails(Tag = 43067, Type = TagType.String, Offset = 2, Required = false)]
			public string? UnderlyingReturnRatePriceCurrency {get; set;}
			
			[TagDetails(Tag = 43068, Type = TagType.Int, Offset = 3, Required = false)]
			public int? UnderlyingReturnRatePriceType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingReturnRatePriceBasis is not null) writer.WriteWholeNumber(43065, UnderlyingReturnRatePriceBasis.Value);
				if (UnderlyingReturnRatePrice is not null) writer.WriteNumber(43066, UnderlyingReturnRatePrice.Value);
				if (UnderlyingReturnRatePriceCurrency is not null) writer.WriteString(43067, UnderlyingReturnRatePriceCurrency);
				if (UnderlyingReturnRatePriceType is not null) writer.WriteWholeNumber(43068, UnderlyingReturnRatePriceType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingReturnRatePriceBasis = view.GetInt32(43065);
				UnderlyingReturnRatePrice = view.GetDouble(43066);
				UnderlyingReturnRatePriceCurrency = view.GetString(43067);
				UnderlyingReturnRatePriceType = view.GetInt32(43068);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingReturnRatePriceBasis":
					{
						value = UnderlyingReturnRatePriceBasis;
						break;
					}
					case "UnderlyingReturnRatePrice":
					{
						value = UnderlyingReturnRatePrice;
						break;
					}
					case "UnderlyingReturnRatePriceCurrency":
					{
						value = UnderlyingReturnRatePriceCurrency;
						break;
					}
					case "UnderlyingReturnRatePriceType":
					{
						value = UnderlyingReturnRatePriceType;
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
				UnderlyingReturnRatePriceBasis = null;
				UnderlyingReturnRatePrice = null;
				UnderlyingReturnRatePriceCurrency = null;
				UnderlyingReturnRatePriceType = null;
			}
		}
		[Group(NoOfTag = 43064, Offset = 0, Required = false)]
		public NoUnderlyingReturnRatePrices[]? UnderlyingReturnRatePrices {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingReturnRatePrices is not null && UnderlyingReturnRatePrices.Length != 0)
			{
				writer.WriteWholeNumber(43064, UnderlyingReturnRatePrices.Length);
				for (int i = 0; i < UnderlyingReturnRatePrices.Length; i++)
				{
					((IFixEncoder)UnderlyingReturnRatePrices[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingReturnRatePrices") is IMessageView viewNoUnderlyingReturnRatePrices)
			{
				var count = viewNoUnderlyingReturnRatePrices.GroupCount();
				UnderlyingReturnRatePrices = new NoUnderlyingReturnRatePrices[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingReturnRatePrices[i] = new();
					((IFixParser)UnderlyingReturnRatePrices[i]).Parse(viewNoUnderlyingReturnRatePrices.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingReturnRatePrices":
				{
					value = UnderlyingReturnRatePrices;
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
			UnderlyingReturnRatePrices = null;
		}
	}
}
