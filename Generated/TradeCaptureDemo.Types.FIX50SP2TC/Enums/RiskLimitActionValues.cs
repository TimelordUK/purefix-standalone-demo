using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class RiskLimitActionValues
	{
		public const int QueueInbound = 0;
		public const int QueueOutbound = 1;
		public const int Reject = 2;
		public const int Disconnect = 3;
		public const int Warning = 4;
		public const int PingCreditCheckWithRevalidation = 5;
		public const int PingCreditCheckNoRevalidation = 6;
		public const int PushCreditCheckWithRevalidation = 7;
		public const int PushCreditCheckNoRevalidation = 8;
		public const int Suspend = 9;
		public const int HaltTrading = 10;
	}
}
