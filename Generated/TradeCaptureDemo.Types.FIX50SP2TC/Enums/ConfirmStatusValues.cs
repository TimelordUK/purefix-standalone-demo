using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class ConfirmStatusValues
	{
		public const int Received = 1;
		public const int MismatchedAccount = 2;
		public const int MissingSettlementInstructions = 3;
		public const int Confirmed = 4;
		public const int RequestRejected = 5;
	}
}
