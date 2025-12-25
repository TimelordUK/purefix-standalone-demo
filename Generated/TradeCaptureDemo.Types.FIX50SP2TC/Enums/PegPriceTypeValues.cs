using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class PegPriceTypeValues
	{
		public const int LastPeg = 1;
		public const int MidPricePeg = 2;
		public const int OpeningPeg = 3;
		public const int MarketPeg = 4;
		public const int PrimaryPeg = 5;
		public const int PegToVwap = 7;
		public const int TrailingStopPeg = 8;
		public const int PegToLimitPrice = 9;
		public const int ShortSaleMinPricePeg = 10;
	}
}
