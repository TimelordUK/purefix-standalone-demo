using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class ShortSaleRestrictionValues
	{
		public const int NoRestrictions = 0;
		public const int SecurityNotShortable = 1;
		public const int SecurityNotShortableAtOrBelowBestBid = 2;
		public const int SecurityNotShortableWithoutPreBorrow = 3;
	}
}
