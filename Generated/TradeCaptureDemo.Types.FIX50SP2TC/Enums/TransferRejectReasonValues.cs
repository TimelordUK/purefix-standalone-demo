using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class TransferRejectReasonValues
	{
		public const int Success = 0;
		public const int InvalidParty = 1;
		public const int UnknownInstrument = 2;
		public const int UnauthorizedToSubmitXfer = 3;
		public const int UnknownPosition = 4;
		public const int Other = 99;
	}
}
