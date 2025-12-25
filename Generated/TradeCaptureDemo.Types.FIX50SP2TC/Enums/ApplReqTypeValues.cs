using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class ApplReqTypeValues
	{
		public const int Retransmission = 0;
		public const int Subscription = 1;
		public const int RequestLastSeqNum = 2;
		public const int RequestApplications = 3;
		public const int Unsubscribe = 4;
		public const int CancelRetransmission = 5;
		public const int CancelRetransmissionUnsubscribe = 6;
	}
}
