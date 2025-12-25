using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class TransferStatusValues
	{
		public const int Received = 0;
		public const int RejectedByIntermediary = 1;
		public const int AcceptPending = 2;
		public const int Accepted = 3;
		public const int Declined = 4;
		public const int Cancelled = 5;
	}
}
