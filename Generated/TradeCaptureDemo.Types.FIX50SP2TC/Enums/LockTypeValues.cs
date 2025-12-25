using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class LockTypeValues
	{
		public const int NotLocked = 0;
		public const int AwayMarketNetter = 1;
		public const int ThreeTickLocked = 2;
		public const int LockedByMarketMaker = 3;
		public const int DirectedOrderLock = 4;
		public const int MultilegLock = 5;
		public const int MarketOrderLock = 6;
		public const int PreAssignmentLock = 7;
	}
}
