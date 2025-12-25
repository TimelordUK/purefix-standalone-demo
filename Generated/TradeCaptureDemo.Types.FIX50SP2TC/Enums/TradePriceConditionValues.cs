using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class TradePriceConditionValues
	{
		public const int SpecialCumDividend = 0;
		public const int SpecialCumRights = 1;
		public const int SpecialExDividend = 2;
		public const int SpecialExRights = 3;
		public const int SpecialCumCoupon = 4;
		public const int SpecialCumCapitalRepayments = 5;
		public const int SpecialExCoupon = 6;
		public const int SpecialExCapitalRepayments = 7;
		public const int CashSettlement = 8;
		public const int SpecialCumBonus = 9;
		public const int SpecialPrice = 10;
		public const int SpecialExBonus = 11;
		public const int GuaranteedDelivery = 12;
		public const int SpecialDividend = 13;
		public const int PriceImprovement = 14;
		public const int NonPriceFormingTrade = 15;
		public const int TradeExemptedFromTradingObligation = 16;
		public const int PricePending = 17;
		public const int PriceNotApplicable = 18;
	}
}
