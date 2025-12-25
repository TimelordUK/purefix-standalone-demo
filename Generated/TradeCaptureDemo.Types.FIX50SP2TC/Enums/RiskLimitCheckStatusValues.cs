using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class RiskLimitCheckStatusValues
	{
		public const int Accepted = 0;
		public const int Rejected = 1;
		public const int ClaimRequired = 2;
		public const int PreDefinedLimitCheckSucceeded = 3;
		public const int PreDefinedLimitCheckFailed = 4;
		public const int PreDefinedAutoAcceptRuleInvoked = 5;
		public const int PreDefinedAutoRejectRuleInvoked = 6;
		public const int AcceptedByClearingFirm = 7;
		public const int RejectedByClearingFirm = 8;
		public const int Pending = 9;
		public const int AcceptedByCreditHub = 10;
		public const int RejectedByCreditHub = 11;
		public const int PendingCreditHubCheck = 12;
		public const int AcceptedByExecVenue = 13;
		public const int RejectedByExecVenue = 14;
	}
}
