using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class BusinessRejectReasonValues
	{
		public const int Other = 0;
		public const int UnknownId = 1;
		public const int UnknownSecurity = 2;
		public const int UnsupportedMessageType = 3;
		public const int ApplicationNotAvailable = 4;
		public const int ConditionallyRequiredFieldMissing = 5;
		public const int NotAuthorized = 6;
		public const int DeliverToFirmNotAvailableAtThisTime = 7;
		public const int ThrottleLimitExceeded = 8;
		public const int ThrottleLimitExceededSessionDisconnected = 9;
		public const int ThrottledMessagesRejectedOnRequest = 10;
		public const int InvalidPriceIncrement = 18;
	}
}
