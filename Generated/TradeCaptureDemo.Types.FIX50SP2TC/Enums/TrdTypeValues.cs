using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class TrdTypeValues
	{
		public const int RegularTrade = 0;
		public const int BlockTrade = 1;
		public const int Efp = 2;
		public const int Transfer = 3;
		public const int LateTrade = 4;
		public const int TTrade = 5;
		public const int WeightedAveragePriceTrade = 6;
		public const int BunchedTrade = 7;
		public const int LateBunchedTrade = 8;
		public const int PriorReferencePriceTrade = 9;
		public const int AfterHoursTrade = 10;
		public const int ExchangeForRisk = 11;
		public const int ExchangeForSwap = 12;
		public const int ExchangeOfFuturesFor = 13;
		public const int ExchangeOfOptionsForOptions = 14;
		public const int TradingAtSettlement = 15;
		public const int AllOrNone = 16;
		public const int FuturesLargeOrderExecution = 17;
		public const int ExchangeOfFuturesForFutures = 18;
		public const int OptionInterimTrade = 19;
		public const int OptionCabinetTrade = 20;
		public const int PrivatelyNegotiatedTrades = 22;
		public const int SubstitutionOfFuturesForForwards = 23;
		public const int NonStandardSettlement = 48;
		public const int DerivativeRelatedTransaction = 49;
		public const int PortfolioTrade = 50;
		public const int VolumeWeightedAverageTrade = 51;
		public const int ExchangeGrantedTrade = 52;
		public const int RepurchaseAgreement = 53;
		public const int Otc = 54;
		public const int ExchangeBasisFacility = 55;
		public const int OpeningTrade = 56;
		public const int NettedTrade = 57;
		public const int BlockSwapTrade = 58;
		public const int CreditEventTrade = 59;
		public const int SuccessionEventTrade = 60;
		public const int GiveUpGiveInTrade = 61;
		public const int DarkTrade = 62;
		public const int TechnicalTrade = 63;
		public const int Benchmark = 64;
		public const int PackageTrade = 65;
		public const int RollTrade = 66;
		public const int ErrorTrade = 24;
		public const int SpecialCumDividend = 25;
		public const int SpecialExDividend = 26;
		public const int SpecialCumCoupon = 27;
		public const int SpecialExCoupon = 28;
		public const int CashSettlement = 29;
		public const int SpecialPrice = 30;
		public const int GuaranteedDelivery = 31;
		public const int SpecialCumRights = 32;
		public const int SpecialExRights = 33;
		public const int SpecialCumCapitalRepayments = 34;
		public const int SpecialExCapitalRepayments = 35;
		public const int SpecialCumBonus = 36;
		public const int SpecialExBonus = 37;
		public const int LargeTrade = 38;
		public const int WorkedPrincipalTrade = 39;
		public const int BlockTrades = 40;
		public const int NameChange = 41;
		public const int PortfolioTransfer = 42;
		public const int ProrogationBuy = 43;
		public const int ProrogationSell = 44;
		public const int OptionExercise = 45;
		public const int DeltaNeutralTransaction = 46;
		public const int FinancingTransaction = 47;
	}
}
