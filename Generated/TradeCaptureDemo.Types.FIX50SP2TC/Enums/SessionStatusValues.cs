using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class SessionStatusValues
	{
		public const int SessionActive = 0;
		public const int SessionPasswordChanged = 1;
		public const int SessionPasswordDueToExpire = 2;
		public const int NewSessionPasswordDoesNotComplyWithPolicy = 3;
		public const int SessionLogoutComplete = 4;
		public const int InvalidUsernameOrPassword = 5;
		public const int AccountLocked = 6;
		public const int LogonsAreNotAllowedAtThisTime = 7;
		public const int PasswordExpired = 8;
		public const int ReceivedMsgSeqNumTooLow = 9;
		public const int ReceivedNextExpectedMsgSeqNumTooHigh = 10;
	}
}
