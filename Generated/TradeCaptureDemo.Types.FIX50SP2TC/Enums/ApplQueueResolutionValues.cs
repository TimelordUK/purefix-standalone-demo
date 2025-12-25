using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class ApplQueueResolutionValues
	{
		public const int NoActionTaken = 0;
		public const int QueueFlushed = 1;
		public const int OverlayLast = 2;
		public const int EndSession = 3;
	}
}
