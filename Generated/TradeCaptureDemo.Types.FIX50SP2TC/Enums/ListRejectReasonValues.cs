using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class ListRejectReasonValues
	{
		public const int BrokerCredit = 0;
		public const int ExchangeClosed = 2;
		public const int TooLateToEnter = 4;
		public const int UnknownOrder = 5;
		public const int DuplicateOrder = 6;
		public const int UnsupportedOrderCharacteristic = 11;
		public const int Other = 99;
	}
}
