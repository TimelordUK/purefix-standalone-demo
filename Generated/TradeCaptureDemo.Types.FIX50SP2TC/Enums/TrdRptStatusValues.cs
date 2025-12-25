using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class TrdRptStatusValues
	{
		public const int Accepted = 0;
		public const int Rejected = 1;
		public const int Cancelled = 2;
		public const int AcceptedWithErrors = 3;
		public const int PendingNew = 4;
		public const int PendingCancel = 5;
		public const int PendingReplace = 6;
		public const int Terminated = 7;
		public const int PendingVerification = 8;
		public const int DeemedVerified = 9;
		public const int Verified = 10;
		public const int Disputed = 11;
	}
}
