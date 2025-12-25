using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class BaseTradingRules : IFixComponent
	{
		[Component(Offset = 0, Required = false)]
		public TickRules? TickRules {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public LotTypeRules? LotTypeRules {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public PriceLimits? PriceLimits {get; set;}
		
		[Component(Offset = 3, Required = false)]
		public PriceRangeRuleGrp? PriceRangeRuleGrp {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public QuoteSizeRuleGrp? QuoteSizeRuleGrp {get; set;}
		
		[TagDetails(Tag = 827, Type = TagType.Int, Offset = 5, Required = false)]
		public int? ExpirationCycle {get; set;}
		
		[TagDetails(Tag = 1786, Type = TagType.Int, Offset = 6, Required = false)]
		public int? TradeVolType {get; set;}
		
		[TagDetails(Tag = 562, Type = TagType.Float, Offset = 7, Required = false)]
		public double? MinTradeVol {get; set;}
		
		[TagDetails(Tag = 1140, Type = TagType.Float, Offset = 8, Required = false)]
		public double? MaxTradeVol {get; set;}
		
		[TagDetails(Tag = 1143, Type = TagType.Float, Offset = 9, Required = false)]
		public double? MaxPriceVariation {get; set;}
		
		[TagDetails(Tag = 1144, Type = TagType.Int, Offset = 10, Required = false)]
		public int? ImpliedMarketIndicator {get; set;}
		
		[TagDetails(Tag = 1245, Type = TagType.String, Offset = 11, Required = false)]
		public string? TradingCurrency {get; set;}
		
		[TagDetails(Tag = 2934, Type = TagType.String, Offset = 12, Required = false)]
		public string? TradingCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 561, Type = TagType.Float, Offset = 13, Required = false)]
		public double? RoundLot {get; set;}
		
		[TagDetails(Tag = 1377, Type = TagType.Int, Offset = 14, Required = false)]
		public int? MultilegModel {get; set;}
		
		[TagDetails(Tag = 1378, Type = TagType.Int, Offset = 15, Required = false)]
		public int? MultilegPriceMethod {get; set;}
		
		[TagDetails(Tag = 423, Type = TagType.Int, Offset = 16, Required = false)]
		public int? PriceType {get; set;}
		
		[TagDetails(Tag = 2557, Type = TagType.Float, Offset = 17, Required = false)]
		public double? FastMarketPercentage {get; set;}
		
		[TagDetails(Tag = 2559, Type = TagType.Boolean, Offset = 18, Required = false)]
		public bool? QuoteSideIndicator {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (TickRules is not null) ((IFixEncoder)TickRules).Encode(writer);
			if (LotTypeRules is not null) ((IFixEncoder)LotTypeRules).Encode(writer);
			if (PriceLimits is not null) ((IFixEncoder)PriceLimits).Encode(writer);
			if (PriceRangeRuleGrp is not null) ((IFixEncoder)PriceRangeRuleGrp).Encode(writer);
			if (QuoteSizeRuleGrp is not null) ((IFixEncoder)QuoteSizeRuleGrp).Encode(writer);
			if (ExpirationCycle is not null) writer.WriteWholeNumber(827, ExpirationCycle.Value);
			if (TradeVolType is not null) writer.WriteWholeNumber(1786, TradeVolType.Value);
			if (MinTradeVol is not null) writer.WriteNumber(562, MinTradeVol.Value);
			if (MaxTradeVol is not null) writer.WriteNumber(1140, MaxTradeVol.Value);
			if (MaxPriceVariation is not null) writer.WriteNumber(1143, MaxPriceVariation.Value);
			if (ImpliedMarketIndicator is not null) writer.WriteWholeNumber(1144, ImpliedMarketIndicator.Value);
			if (TradingCurrency is not null) writer.WriteString(1245, TradingCurrency);
			if (TradingCurrencyCodeSource is not null) writer.WriteString(2934, TradingCurrencyCodeSource);
			if (RoundLot is not null) writer.WriteNumber(561, RoundLot.Value);
			if (MultilegModel is not null) writer.WriteWholeNumber(1377, MultilegModel.Value);
			if (MultilegPriceMethod is not null) writer.WriteWholeNumber(1378, MultilegPriceMethod.Value);
			if (PriceType is not null) writer.WriteWholeNumber(423, PriceType.Value);
			if (FastMarketPercentage is not null) writer.WriteNumber(2557, FastMarketPercentage.Value);
			if (QuoteSideIndicator is not null) writer.WriteBoolean(2559, QuoteSideIndicator.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("TickRules") is IMessageView viewTickRules)
			{
				TickRules = new();
				((IFixParser)TickRules).Parse(viewTickRules);
			}
			if (view.GetView("LotTypeRules") is IMessageView viewLotTypeRules)
			{
				LotTypeRules = new();
				((IFixParser)LotTypeRules).Parse(viewLotTypeRules);
			}
			if (view.GetView("PriceLimits") is IMessageView viewPriceLimits)
			{
				PriceLimits = new();
				((IFixParser)PriceLimits).Parse(viewPriceLimits);
			}
			if (view.GetView("PriceRangeRuleGrp") is IMessageView viewPriceRangeRuleGrp)
			{
				PriceRangeRuleGrp = new();
				((IFixParser)PriceRangeRuleGrp).Parse(viewPriceRangeRuleGrp);
			}
			if (view.GetView("QuoteSizeRuleGrp") is IMessageView viewQuoteSizeRuleGrp)
			{
				QuoteSizeRuleGrp = new();
				((IFixParser)QuoteSizeRuleGrp).Parse(viewQuoteSizeRuleGrp);
			}
			ExpirationCycle = view.GetInt32(827);
			TradeVolType = view.GetInt32(1786);
			MinTradeVol = view.GetDouble(562);
			MaxTradeVol = view.GetDouble(1140);
			MaxPriceVariation = view.GetDouble(1143);
			ImpliedMarketIndicator = view.GetInt32(1144);
			TradingCurrency = view.GetString(1245);
			TradingCurrencyCodeSource = view.GetString(2934);
			RoundLot = view.GetDouble(561);
			MultilegModel = view.GetInt32(1377);
			MultilegPriceMethod = view.GetInt32(1378);
			PriceType = view.GetInt32(423);
			FastMarketPercentage = view.GetDouble(2557);
			QuoteSideIndicator = view.GetBool(2559);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "TickRules":
				{
					value = TickRules;
					break;
				}
				case "LotTypeRules":
				{
					value = LotTypeRules;
					break;
				}
				case "PriceLimits":
				{
					value = PriceLimits;
					break;
				}
				case "PriceRangeRuleGrp":
				{
					value = PriceRangeRuleGrp;
					break;
				}
				case "QuoteSizeRuleGrp":
				{
					value = QuoteSizeRuleGrp;
					break;
				}
				case "ExpirationCycle":
				{
					value = ExpirationCycle;
					break;
				}
				case "TradeVolType":
				{
					value = TradeVolType;
					break;
				}
				case "MinTradeVol":
				{
					value = MinTradeVol;
					break;
				}
				case "MaxTradeVol":
				{
					value = MaxTradeVol;
					break;
				}
				case "MaxPriceVariation":
				{
					value = MaxPriceVariation;
					break;
				}
				case "ImpliedMarketIndicator":
				{
					value = ImpliedMarketIndicator;
					break;
				}
				case "TradingCurrency":
				{
					value = TradingCurrency;
					break;
				}
				case "TradingCurrencyCodeSource":
				{
					value = TradingCurrencyCodeSource;
					break;
				}
				case "RoundLot":
				{
					value = RoundLot;
					break;
				}
				case "MultilegModel":
				{
					value = MultilegModel;
					break;
				}
				case "MultilegPriceMethod":
				{
					value = MultilegPriceMethod;
					break;
				}
				case "PriceType":
				{
					value = PriceType;
					break;
				}
				case "FastMarketPercentage":
				{
					value = FastMarketPercentage;
					break;
				}
				case "QuoteSideIndicator":
				{
					value = QuoteSideIndicator;
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
			((IFixReset?)TickRules)?.Reset();
			((IFixReset?)LotTypeRules)?.Reset();
			((IFixReset?)PriceLimits)?.Reset();
			((IFixReset?)PriceRangeRuleGrp)?.Reset();
			((IFixReset?)QuoteSizeRuleGrp)?.Reset();
			ExpirationCycle = null;
			TradeVolType = null;
			MinTradeVol = null;
			MaxTradeVol = null;
			MaxPriceVariation = null;
			ImpliedMarketIndicator = null;
			TradingCurrency = null;
			TradingCurrencyCodeSource = null;
			RoundLot = null;
			MultilegModel = null;
			MultilegPriceMethod = null;
			PriceType = null;
			FastMarketPercentage = null;
			QuoteSideIndicator = null;
		}
	}
}
