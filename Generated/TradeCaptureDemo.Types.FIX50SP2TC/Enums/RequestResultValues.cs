using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class RequestResultValues
	{
		public const int ValidRequest = 0;
		public const int InvalidOrUnsupportedRequest = 1;
		public const int NoDataFound = 2;
		public const int NotAuthorized = 3;
		public const int DataTemporarilyUnavailable = 4;
		public const int RequestForDataNotSupported = 5;
		public const int Other = 99;
	}
}
