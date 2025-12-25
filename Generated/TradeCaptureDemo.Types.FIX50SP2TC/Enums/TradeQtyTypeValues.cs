using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class TradeQtyTypeValues
	{
		public const int ClearedQuantity = 0;
		public const int LongSideClaimedQuantity = 1;
		public const int ShortSideClaimedQuantity = 2;
		public const int LongSideRejectedQuantity = 3;
		public const int ShortSideRejectedQuantity = 4;
		public const int PendingQuantity = 5;
		public const int TransactionQuantity = 6;
		public const int RemainingQuantity = 7;
		public const int PreviousRemainingQuantity = 8;
	}
}
