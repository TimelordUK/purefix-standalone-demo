using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class NetworkRequestTypeValues
	{
		public const int Snapshot = 1;
		public const int Subscribe = 2;
		public const int StopSubscribing = 4;
		public const int LevelOfDetail = 8;
	}
}
