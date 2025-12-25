using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class AllocStatusValues
	{
		public const int Accepted = 0;
		public const int BlockLevelReject = 1;
		public const int AccountLevelReject = 2;
		public const int Received = 3;
		public const int Incomplete = 4;
		public const int RejectedByIntermediary = 5;
		public const int AllocationPending = 6;
		public const int Reversed = 7;
		public const int CancelledByIntermediary = 8;
		public const int Claimed = 9;
		public const int Refused = 10;
		public const int PendingGiveUpApproval = 11;
		public const int Cancelled = 12;
		public const int PendingTakeUpApproval = 13;
		public const int ReversalPending = 14;
	}
}
