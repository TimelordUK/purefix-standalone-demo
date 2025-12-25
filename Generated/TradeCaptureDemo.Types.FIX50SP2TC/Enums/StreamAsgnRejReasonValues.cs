using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class StreamAsgnRejReasonValues
	{
		public const int UnknownClient = 0;
		public const int ExceedsMaximumSize = 1;
		public const int UnknownOrInvalidCurrencyPair = 2;
		public const int NoAvailableStream = 3;
		public const int Other = 99;
	}
}
