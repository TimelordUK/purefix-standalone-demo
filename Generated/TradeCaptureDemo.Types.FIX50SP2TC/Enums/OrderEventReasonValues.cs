using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class OrderEventReasonValues
	{
		public const int AddOrderRequest = 1;
		public const int ModifyOrderRequest = 2;
		public const int DeleteOrderRequest = 3;
		public const int OrderEnteredOob = 4;
		public const int OrderModifiedOob = 5;
		public const int OrderDeletedOob = 6;
		public const int OrderActivatedOrTriggered = 7;
		public const int OrderExpired = 8;
		public const int ReserveOrderRefreshed = 9;
		public const int AwayMarketBetter = 10;
		public const int CorporateAction = 11;
		public const int StartOfDay = 12;
		public const int EndOfDay = 13;
	}
}
