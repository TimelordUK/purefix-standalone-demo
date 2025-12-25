using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class TriggeredValues
	{
		public const int NotTriggered = 0;
		public const int Triggered = 1;
		public const int StopOrderTriggered = 2;
		public const int OcoOrderTriggered = 3;
		public const int OtoOrderTriggered = 4;
		public const int OuoOrderTriggered = 5;
	}
}
