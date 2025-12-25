using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class OrdTypeValues
	{
		public const string Market = "1";
		public const string Limit = "2";
		public const string Stop = "3";
		public const string StopLimit = "4";
		public const string MarketOnClose = "5";
		public const string WithOrWithout = "6";
		public const string LimitOrBetter = "7";
		public const string LimitWithOrWithout = "8";
		public const string OnBasis = "9";
		public const string OnClose = "A";
		public const string LimitOnClose = "B";
		public const string ForexMarket = "C";
		public const string PreviouslyQuoted = "D";
		public const string PreviouslyIndicated = "E";
		public const string ForexLimit = "F";
		public const string ForexSwap = "G";
		public const string ForexPreviouslyQuoted = "H";
		public const string Funari = "I";
		public const string MarketIfTouched = "J";
		public const string MarketWithLeftOverAsLimit = "K";
		public const string PreviousFundValuationPoint = "L";
		public const string NextFundValuationPoint = "M";
		public const string Pegged = "P";
		public const string CounterOrderSelection = "Q";
		public const string StopOnBidOrOffer = "R";
		public const string StopLimitOnBidOrOffer = "S";
	}
}
