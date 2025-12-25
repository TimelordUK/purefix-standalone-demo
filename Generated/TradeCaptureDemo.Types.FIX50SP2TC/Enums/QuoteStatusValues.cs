using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class QuoteStatusValues
	{
		public const int Accepted = 0;
		public const int CancelForSymbol = 1;
		public const int CanceledForSecurityType = 2;
		public const int CanceledForUnderlying = 3;
		public const int CanceledAll = 4;
		public const int Rejected = 5;
		public const int RemovedFromMarket = 6;
		public const int Expired = 7;
		public const int Query = 8;
		public const int QuoteNotFound = 9;
		public const int Pending = 10;
		public const int Pass = 11;
		public const int LockedMarketWarning = 12;
		public const int CrossMarketWarning = 13;
		public const int CanceledDueToLockMarket = 14;
		public const int CanceledDueToCrossMarket = 15;
		public const int Active = 16;
		public const int Canceled = 17;
		public const int UnsolicitedQuoteReplenishment = 18;
		public const int PendingEndTrade = 19;
		public const int TooLateToEnd = 20;
		public const int Traded = 21;
		public const int TradedAndRemoved = 22;
		public const int ContractTerminates = 23;
	}
}
