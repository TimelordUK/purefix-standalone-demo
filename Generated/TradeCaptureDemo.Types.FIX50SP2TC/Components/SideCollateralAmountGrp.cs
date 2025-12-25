using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class SideCollateralAmountGrp : IFixComponent
	{
		public sealed partial class NoSideCollateralAmounts : IFixGroup
		{
			[TagDetails(Tag = 2702, Type = TagType.Float, Offset = 0, Required = false)]
			public double? SideCurrentCollateralAmount {get; set;}
			
			[TagDetails(Tag = 2695, Type = TagType.String, Offset = 1, Required = false)]
			public string? SideCollateralCurrency {get; set;}
			
			[TagDetails(Tag = 2930, Type = TagType.String, Offset = 2, Required = false)]
			public string? SideCollateralCurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 2694, Type = TagType.Int, Offset = 3, Required = false)]
			public int? SideCollateralAmountType {get; set;}
			
			[TagDetails(Tag = 2696, Type = TagType.Float, Offset = 4, Required = false)]
			public double? SideCollateralFXRate {get; set;}
			
			[TagDetails(Tag = 2697, Type = TagType.String, Offset = 5, Required = false)]
			public string? SideCollateralFXRateCalc {get; set;}
			
			[TagDetails(Tag = 2701, Type = TagType.String, Offset = 6, Required = false)]
			public string? SideCollateralType {get; set;}
			
			[TagDetails(Tag = 2693, Type = TagType.String, Offset = 7, Required = false)]
			public string? SideCollateralAmountMarketSegmentID {get; set;}
			
			[TagDetails(Tag = 2692, Type = TagType.String, Offset = 8, Required = false)]
			public string? SideCollateralAmountMarketID {get; set;}
			
			[TagDetails(Tag = 2703, Type = TagType.Boolean, Offset = 9, Required = false)]
			public bool? SideHaircutIndicator {get; set;}
			
			[TagDetails(Tag = 2700, Type = TagType.String, Offset = 10, Required = false)]
			public string? SideCollateralPortfolioID {get; set;}
			
			[TagDetails(Tag = 2699, Type = TagType.Float, Offset = 11, Required = false)]
			public double? SideCollateralPercentOverage {get; set;}
			
			[TagDetails(Tag = 2698, Type = TagType.Float, Offset = 12, Required = false)]
			public double? SideCollateralMarketPrice {get; set;}
			
			[TagDetails(Tag = 2862, Type = TagType.Float, Offset = 13, Required = false)]
			public double? SideCollateralReinvestmentRate {get; set;}
			
			[Component(Offset = 14, Required = false)]
			public SideCollateralReinvestmentGrp? SideCollateralReinvestmentGrp {get; set;}
			
			[TagDetails(Tag = 2863, Type = TagType.String, Offset = 15, Required = false)]
			public string? SideUnderlyingRefID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (SideCurrentCollateralAmount is not null) writer.WriteNumber(2702, SideCurrentCollateralAmount.Value);
				if (SideCollateralCurrency is not null) writer.WriteString(2695, SideCollateralCurrency);
				if (SideCollateralCurrencyCodeSource is not null) writer.WriteString(2930, SideCollateralCurrencyCodeSource);
				if (SideCollateralAmountType is not null) writer.WriteWholeNumber(2694, SideCollateralAmountType.Value);
				if (SideCollateralFXRate is not null) writer.WriteNumber(2696, SideCollateralFXRate.Value);
				if (SideCollateralFXRateCalc is not null) writer.WriteString(2697, SideCollateralFXRateCalc);
				if (SideCollateralType is not null) writer.WriteString(2701, SideCollateralType);
				if (SideCollateralAmountMarketSegmentID is not null) writer.WriteString(2693, SideCollateralAmountMarketSegmentID);
				if (SideCollateralAmountMarketID is not null) writer.WriteString(2692, SideCollateralAmountMarketID);
				if (SideHaircutIndicator is not null) writer.WriteBoolean(2703, SideHaircutIndicator.Value);
				if (SideCollateralPortfolioID is not null) writer.WriteString(2700, SideCollateralPortfolioID);
				if (SideCollateralPercentOverage is not null) writer.WriteNumber(2699, SideCollateralPercentOverage.Value);
				if (SideCollateralMarketPrice is not null) writer.WriteNumber(2698, SideCollateralMarketPrice.Value);
				if (SideCollateralReinvestmentRate is not null) writer.WriteNumber(2862, SideCollateralReinvestmentRate.Value);
				if (SideCollateralReinvestmentGrp is not null) ((IFixEncoder)SideCollateralReinvestmentGrp).Encode(writer);
				if (SideUnderlyingRefID is not null) writer.WriteString(2863, SideUnderlyingRefID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				SideCurrentCollateralAmount = view.GetDouble(2702);
				SideCollateralCurrency = view.GetString(2695);
				SideCollateralCurrencyCodeSource = view.GetString(2930);
				SideCollateralAmountType = view.GetInt32(2694);
				SideCollateralFXRate = view.GetDouble(2696);
				SideCollateralFXRateCalc = view.GetString(2697);
				SideCollateralType = view.GetString(2701);
				SideCollateralAmountMarketSegmentID = view.GetString(2693);
				SideCollateralAmountMarketID = view.GetString(2692);
				SideHaircutIndicator = view.GetBool(2703);
				SideCollateralPortfolioID = view.GetString(2700);
				SideCollateralPercentOverage = view.GetDouble(2699);
				SideCollateralMarketPrice = view.GetDouble(2698);
				SideCollateralReinvestmentRate = view.GetDouble(2862);
				if (view.GetView("SideCollateralReinvestmentGrp") is IMessageView viewSideCollateralReinvestmentGrp)
				{
					SideCollateralReinvestmentGrp = new();
					((IFixParser)SideCollateralReinvestmentGrp).Parse(viewSideCollateralReinvestmentGrp);
				}
				SideUnderlyingRefID = view.GetString(2863);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "SideCurrentCollateralAmount":
					{
						value = SideCurrentCollateralAmount;
						break;
					}
					case "SideCollateralCurrency":
					{
						value = SideCollateralCurrency;
						break;
					}
					case "SideCollateralCurrencyCodeSource":
					{
						value = SideCollateralCurrencyCodeSource;
						break;
					}
					case "SideCollateralAmountType":
					{
						value = SideCollateralAmountType;
						break;
					}
					case "SideCollateralFXRate":
					{
						value = SideCollateralFXRate;
						break;
					}
					case "SideCollateralFXRateCalc":
					{
						value = SideCollateralFXRateCalc;
						break;
					}
					case "SideCollateralType":
					{
						value = SideCollateralType;
						break;
					}
					case "SideCollateralAmountMarketSegmentID":
					{
						value = SideCollateralAmountMarketSegmentID;
						break;
					}
					case "SideCollateralAmountMarketID":
					{
						value = SideCollateralAmountMarketID;
						break;
					}
					case "SideHaircutIndicator":
					{
						value = SideHaircutIndicator;
						break;
					}
					case "SideCollateralPortfolioID":
					{
						value = SideCollateralPortfolioID;
						break;
					}
					case "SideCollateralPercentOverage":
					{
						value = SideCollateralPercentOverage;
						break;
					}
					case "SideCollateralMarketPrice":
					{
						value = SideCollateralMarketPrice;
						break;
					}
					case "SideCollateralReinvestmentRate":
					{
						value = SideCollateralReinvestmentRate;
						break;
					}
					case "SideCollateralReinvestmentGrp":
					{
						value = SideCollateralReinvestmentGrp;
						break;
					}
					case "SideUnderlyingRefID":
					{
						value = SideUnderlyingRefID;
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
				SideCurrentCollateralAmount = null;
				SideCollateralCurrency = null;
				SideCollateralCurrencyCodeSource = null;
				SideCollateralAmountType = null;
				SideCollateralFXRate = null;
				SideCollateralFXRateCalc = null;
				SideCollateralType = null;
				SideCollateralAmountMarketSegmentID = null;
				SideCollateralAmountMarketID = null;
				SideHaircutIndicator = null;
				SideCollateralPortfolioID = null;
				SideCollateralPercentOverage = null;
				SideCollateralMarketPrice = null;
				SideCollateralReinvestmentRate = null;
				((IFixReset?)SideCollateralReinvestmentGrp)?.Reset();
				SideUnderlyingRefID = null;
			}
		}
		[Group(NoOfTag = 2691, Offset = 0, Required = false)]
		public NoSideCollateralAmounts[]? SideCollateralAmounts {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (SideCollateralAmounts is not null && SideCollateralAmounts.Length != 0)
			{
				writer.WriteWholeNumber(2691, SideCollateralAmounts.Length);
				for (int i = 0; i < SideCollateralAmounts.Length; i++)
				{
					((IFixEncoder)SideCollateralAmounts[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoSideCollateralAmounts") is IMessageView viewNoSideCollateralAmounts)
			{
				var count = viewNoSideCollateralAmounts.GroupCount();
				SideCollateralAmounts = new NoSideCollateralAmounts[count];
				for (int i = 0; i < count; i++)
				{
					SideCollateralAmounts[i] = new();
					((IFixParser)SideCollateralAmounts[i]).Parse(viewNoSideCollateralAmounts.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoSideCollateralAmounts":
				{
					value = SideCollateralAmounts;
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
			SideCollateralAmounts = null;
		}
	}
}
