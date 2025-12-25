using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class CollateralAmountGrp : IFixComponent
	{
		public sealed partial class NoCollateralAmounts : IFixGroup
		{
			[TagDetails(Tag = 1704, Type = TagType.Float, Offset = 0, Required = false)]
			public double? CurrentCollateralAmount {get; set;}
			
			[TagDetails(Tag = 1705, Type = TagType.String, Offset = 1, Required = false)]
			public string? CollateralCurrency {get; set;}
			
			[TagDetails(Tag = 2929, Type = TagType.String, Offset = 2, Required = false)]
			public string? CollateralCurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 2632, Type = TagType.Int, Offset = 3, Required = false)]
			public int? CollateralAmountType {get; set;}
			
			[TagDetails(Tag = 2090, Type = TagType.Float, Offset = 4, Required = false)]
			public double? CollateralFXRate {get; set;}
			
			[TagDetails(Tag = 2091, Type = TagType.String, Offset = 5, Required = false)]
			public string? CollateralFXRateCalc {get; set;}
			
			[TagDetails(Tag = 1706, Type = TagType.String, Offset = 6, Required = false)]
			public string? CollateralType {get; set;}
			
			[TagDetails(Tag = 2092, Type = TagType.String, Offset = 7, Required = false)]
			public string? CollateralAmountMarketSegmentID {get; set;}
			
			[TagDetails(Tag = 2093, Type = TagType.String, Offset = 8, Required = false)]
			public string? CollateralAmountMarketID {get; set;}
			
			[TagDetails(Tag = 1902, Type = TagType.Boolean, Offset = 9, Required = false)]
			public bool? HaircutIndicator {get; set;}
			
			[TagDetails(Tag = 2350, Type = TagType.String, Offset = 10, Required = false)]
			public string? CollateralPortfolioID {get; set;}
			
			[TagDetails(Tag = 2690, Type = TagType.Float, Offset = 11, Required = false)]
			public double? CollateralPercentOverage {get; set;}
			
			[TagDetails(Tag = 2689, Type = TagType.Float, Offset = 12, Required = false)]
			public double? CollateralMarketPrice {get; set;}
			
			[TagDetails(Tag = 2840, Type = TagType.Float, Offset = 13, Required = false)]
			public double? CollateralReinvestmentRate {get; set;}
			
			[Component(Offset = 14, Required = false)]
			public CollateralReinvestmentGrp? CollateralReinvestmentGrp {get; set;}
			
			[TagDetails(Tag = 2841, Type = TagType.String, Offset = 15, Required = false)]
			public string? UnderlyingRefID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (CurrentCollateralAmount is not null) writer.WriteNumber(1704, CurrentCollateralAmount.Value);
				if (CollateralCurrency is not null) writer.WriteString(1705, CollateralCurrency);
				if (CollateralCurrencyCodeSource is not null) writer.WriteString(2929, CollateralCurrencyCodeSource);
				if (CollateralAmountType is not null) writer.WriteWholeNumber(2632, CollateralAmountType.Value);
				if (CollateralFXRate is not null) writer.WriteNumber(2090, CollateralFXRate.Value);
				if (CollateralFXRateCalc is not null) writer.WriteString(2091, CollateralFXRateCalc);
				if (CollateralType is not null) writer.WriteString(1706, CollateralType);
				if (CollateralAmountMarketSegmentID is not null) writer.WriteString(2092, CollateralAmountMarketSegmentID);
				if (CollateralAmountMarketID is not null) writer.WriteString(2093, CollateralAmountMarketID);
				if (HaircutIndicator is not null) writer.WriteBoolean(1902, HaircutIndicator.Value);
				if (CollateralPortfolioID is not null) writer.WriteString(2350, CollateralPortfolioID);
				if (CollateralPercentOverage is not null) writer.WriteNumber(2690, CollateralPercentOverage.Value);
				if (CollateralMarketPrice is not null) writer.WriteNumber(2689, CollateralMarketPrice.Value);
				if (CollateralReinvestmentRate is not null) writer.WriteNumber(2840, CollateralReinvestmentRate.Value);
				if (CollateralReinvestmentGrp is not null) ((IFixEncoder)CollateralReinvestmentGrp).Encode(writer);
				if (UnderlyingRefID is not null) writer.WriteString(2841, UnderlyingRefID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				CurrentCollateralAmount = view.GetDouble(1704);
				CollateralCurrency = view.GetString(1705);
				CollateralCurrencyCodeSource = view.GetString(2929);
				CollateralAmountType = view.GetInt32(2632);
				CollateralFXRate = view.GetDouble(2090);
				CollateralFXRateCalc = view.GetString(2091);
				CollateralType = view.GetString(1706);
				CollateralAmountMarketSegmentID = view.GetString(2092);
				CollateralAmountMarketID = view.GetString(2093);
				HaircutIndicator = view.GetBool(1902);
				CollateralPortfolioID = view.GetString(2350);
				CollateralPercentOverage = view.GetDouble(2690);
				CollateralMarketPrice = view.GetDouble(2689);
				CollateralReinvestmentRate = view.GetDouble(2840);
				if (view.GetView("CollateralReinvestmentGrp") is IMessageView viewCollateralReinvestmentGrp)
				{
					CollateralReinvestmentGrp = new();
					((IFixParser)CollateralReinvestmentGrp).Parse(viewCollateralReinvestmentGrp);
				}
				UnderlyingRefID = view.GetString(2841);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "CurrentCollateralAmount":
					{
						value = CurrentCollateralAmount;
						break;
					}
					case "CollateralCurrency":
					{
						value = CollateralCurrency;
						break;
					}
					case "CollateralCurrencyCodeSource":
					{
						value = CollateralCurrencyCodeSource;
						break;
					}
					case "CollateralAmountType":
					{
						value = CollateralAmountType;
						break;
					}
					case "CollateralFXRate":
					{
						value = CollateralFXRate;
						break;
					}
					case "CollateralFXRateCalc":
					{
						value = CollateralFXRateCalc;
						break;
					}
					case "CollateralType":
					{
						value = CollateralType;
						break;
					}
					case "CollateralAmountMarketSegmentID":
					{
						value = CollateralAmountMarketSegmentID;
						break;
					}
					case "CollateralAmountMarketID":
					{
						value = CollateralAmountMarketID;
						break;
					}
					case "HaircutIndicator":
					{
						value = HaircutIndicator;
						break;
					}
					case "CollateralPortfolioID":
					{
						value = CollateralPortfolioID;
						break;
					}
					case "CollateralPercentOverage":
					{
						value = CollateralPercentOverage;
						break;
					}
					case "CollateralMarketPrice":
					{
						value = CollateralMarketPrice;
						break;
					}
					case "CollateralReinvestmentRate":
					{
						value = CollateralReinvestmentRate;
						break;
					}
					case "CollateralReinvestmentGrp":
					{
						value = CollateralReinvestmentGrp;
						break;
					}
					case "UnderlyingRefID":
					{
						value = UnderlyingRefID;
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
				CurrentCollateralAmount = null;
				CollateralCurrency = null;
				CollateralCurrencyCodeSource = null;
				CollateralAmountType = null;
				CollateralFXRate = null;
				CollateralFXRateCalc = null;
				CollateralType = null;
				CollateralAmountMarketSegmentID = null;
				CollateralAmountMarketID = null;
				HaircutIndicator = null;
				CollateralPortfolioID = null;
				CollateralPercentOverage = null;
				CollateralMarketPrice = null;
				CollateralReinvestmentRate = null;
				((IFixReset?)CollateralReinvestmentGrp)?.Reset();
				UnderlyingRefID = null;
			}
		}
		[Group(NoOfTag = 1703, Offset = 0, Required = false)]
		public NoCollateralAmounts[]? CollateralAmounts {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (CollateralAmounts is not null && CollateralAmounts.Length != 0)
			{
				writer.WriteWholeNumber(1703, CollateralAmounts.Length);
				for (int i = 0; i < CollateralAmounts.Length; i++)
				{
					((IFixEncoder)CollateralAmounts[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoCollateralAmounts") is IMessageView viewNoCollateralAmounts)
			{
				var count = viewNoCollateralAmounts.GroupCount();
				CollateralAmounts = new NoCollateralAmounts[count];
				for (int i = 0; i < count; i++)
				{
					CollateralAmounts[i] = new();
					((IFixParser)CollateralAmounts[i]).Parse(viewNoCollateralAmounts.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoCollateralAmounts":
				{
					value = CollateralAmounts;
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
			CollateralAmounts = null;
		}
	}
}
