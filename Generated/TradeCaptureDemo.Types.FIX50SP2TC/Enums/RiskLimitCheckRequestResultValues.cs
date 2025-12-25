using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class RiskLimitCheckRequestResultValues
	{
		public const int Successful = 0;
		public const int InvalidParty = 1;
		public const int ReqExceedsCreditLimit = 2;
		public const int ReqExceedsClipSizeLimit = 3;
		public const int ReqExceedsMaxNotional = 4;
		public const int Other = 99;
	}
}
