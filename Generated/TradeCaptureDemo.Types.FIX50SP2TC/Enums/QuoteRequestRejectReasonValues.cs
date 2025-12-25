using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class QuoteRequestRejectReasonValues
	{
		public const int UnknownSymbol = 1;
		public const int Exchange = 2;
		public const int QuoteRequestExceedsLimit = 3;
		public const int TooLateToEnter = 4;
		public const int InvalidPrice = 5;
		public const int NotAuthorizedToRequestQuote = 6;
		public const int NoMatchForInquiry = 7;
		public const int NoMarketForInstrument = 8;
		public const int NoInventory = 9;
		public const int Pass = 10;
		public const int InsufficientCredit = 11;
		public const int ExceededClipSizeLimit = 12;
		public const int ExceededMaxNotionalOrderAmt = 13;
		public const int ExceededDv01Pv01Limit = 14;
		public const int ExceededCs01Limit = 15;
		public const int Other = 99;
	}
}
