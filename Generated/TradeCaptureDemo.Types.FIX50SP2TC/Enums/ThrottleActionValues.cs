using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class ThrottleActionValues
	{
		public const int QueueInbound = 0;
		public const int QueueOutbound = 1;
		public const int Reject = 2;
		public const int Disconnect = 3;
		public const int Warning = 4;
	}
}
