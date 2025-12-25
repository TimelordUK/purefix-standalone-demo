using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class UserStatusValues
	{
		public const int LoggedIn = 1;
		public const int NotLoggedIn = 2;
		public const int UserNotRecognised = 3;
		public const int PasswordIncorrect = 4;
		public const int PasswordChanged = 5;
		public const int Other = 6;
		public const int ForcedUserLogoutByExchange = 7;
		public const int SessionShutdownWarning = 8;
		public const int ThrottleParametersChanged = 9;
	}
}
