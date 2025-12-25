using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class AllocCancReplaceReasonValues
	{
		public const int OriginalDetailsIncomplete = 1;
		public const int ChangeInUnderlyingOrderDetails = 2;
		public const int CancelledByGiveupFirm = 3;
		public const int Other = 99;
	}
}
