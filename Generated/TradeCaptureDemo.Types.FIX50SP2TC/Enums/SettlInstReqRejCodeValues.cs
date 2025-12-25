using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class SettlInstReqRejCodeValues
	{
		public const int UnableToProcessRequest = 0;
		public const int UnknownAccount = 1;
		public const int NoMatchingSettlementInstructionsFound = 2;
		public const int Other = 99;
	}
}
