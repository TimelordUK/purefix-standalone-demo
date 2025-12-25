using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class SecurityTradingEventValues
	{
		public const int OrderImbalance = 1;
		public const int TradingResumes = 2;
		public const int PriceVolatilityInterruption = 3;
		public const int ChangeOfTradingSession = 4;
		public const int ChangeOfTradingSubsession = 5;
		public const int ChangeOfSecurityTradingStatus = 6;
		public const int ChangeOfBookType = 7;
		public const int ChangeOfMarketDepth = 8;
		public const int CorporateAction = 9;
	}
}
