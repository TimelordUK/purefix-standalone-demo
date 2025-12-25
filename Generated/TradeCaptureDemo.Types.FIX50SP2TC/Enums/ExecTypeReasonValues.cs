using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class ExecTypeReasonValues
	{
		public const int OrdAddedOnRequest = 1;
		public const int OrdReplacedOnRequest = 2;
		public const int OrdCxldOnRequest = 3;
		public const int UnsolicitedOrdCxl = 4;
		public const int NonRestingOrdAddedOnRequest = 5;
		public const int OrdReplacedWithNonRestingOrdOnRequest = 6;
		public const int TriggerOrdReplacedOnRequest = 7;
		public const int SuspendedOrdReplacedOnRequest = 8;
		public const int SuspendedOrdCxldOnRequest = 9;
		public const int OrdCxlPending = 10;
		public const int PendingCxlExecuted = 11;
		public const int RestingOrdTriggered = 12;
		public const int SuspendedOrdActivated = 13;
		public const int ActiveOrdSuspended = 14;
		public const int OrdExpired = 15;
	}
}
