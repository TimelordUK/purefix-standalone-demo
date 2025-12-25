using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegReturnRatePriceGrp : IFixComponent
	{
		public sealed partial class NoLegReturnRatePrices : IFixGroup
		{
			[TagDetails(Tag = 42565, Type = TagType.Int, Offset = 0, Required = false)]
			public int? LegReturnRatePriceBasis {get; set;}
			
			[TagDetails(Tag = 42566, Type = TagType.Float, Offset = 1, Required = false)]
			public double? LegReturnRatePrice {get; set;}
			
			[TagDetails(Tag = 42567, Type = TagType.String, Offset = 2, Required = false)]
			public string? LegReturnRatePriceCurrency {get; set;}
			
			[TagDetails(Tag = 42568, Type = TagType.Int, Offset = 3, Required = false)]
			public int? LegReturnRatePriceType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegReturnRatePriceBasis is not null) writer.WriteWholeNumber(42565, LegReturnRatePriceBasis.Value);
				if (LegReturnRatePrice is not null) writer.WriteNumber(42566, LegReturnRatePrice.Value);
				if (LegReturnRatePriceCurrency is not null) writer.WriteString(42567, LegReturnRatePriceCurrency);
				if (LegReturnRatePriceType is not null) writer.WriteWholeNumber(42568, LegReturnRatePriceType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegReturnRatePriceBasis = view.GetInt32(42565);
				LegReturnRatePrice = view.GetDouble(42566);
				LegReturnRatePriceCurrency = view.GetString(42567);
				LegReturnRatePriceType = view.GetInt32(42568);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegReturnRatePriceBasis":
					{
						value = LegReturnRatePriceBasis;
						break;
					}
					case "LegReturnRatePrice":
					{
						value = LegReturnRatePrice;
						break;
					}
					case "LegReturnRatePriceCurrency":
					{
						value = LegReturnRatePriceCurrency;
						break;
					}
					case "LegReturnRatePriceType":
					{
						value = LegReturnRatePriceType;
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
				LegReturnRatePriceBasis = null;
				LegReturnRatePrice = null;
				LegReturnRatePriceCurrency = null;
				LegReturnRatePriceType = null;
			}
		}
		[Group(NoOfTag = 42564, Offset = 0, Required = false)]
		public NoLegReturnRatePrices[]? LegReturnRatePrices {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegReturnRatePrices is not null && LegReturnRatePrices.Length != 0)
			{
				writer.WriteWholeNumber(42564, LegReturnRatePrices.Length);
				for (int i = 0; i < LegReturnRatePrices.Length; i++)
				{
					((IFixEncoder)LegReturnRatePrices[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegReturnRatePrices") is IMessageView viewNoLegReturnRatePrices)
			{
				var count = viewNoLegReturnRatePrices.GroupCount();
				LegReturnRatePrices = new NoLegReturnRatePrices[count];
				for (int i = 0; i < count; i++)
				{
					LegReturnRatePrices[i] = new();
					((IFixParser)LegReturnRatePrices[i]).Parse(viewNoLegReturnRatePrices.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegReturnRatePrices":
				{
					value = LegReturnRatePrices;
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
			LegReturnRatePrices = null;
		}
	}
}
