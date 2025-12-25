using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class TradeAllocIndicatorValues
	{
		public const int AllocationNotRequired = 0;
		public const int AllocationRequired = 1;
		public const int UseAllocationProvidedWithTheTrade = 2;
		public const int AllocationGiveUpExecutor = 3;
		public const int AllocationFromExecutor = 4;
		public const int AllocationToClaimAccount = 5;
		public const int TradeSplit = 6;
	}
}
