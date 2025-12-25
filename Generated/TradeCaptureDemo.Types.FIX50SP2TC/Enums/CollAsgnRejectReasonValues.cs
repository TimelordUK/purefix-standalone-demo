using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class CollAsgnRejectReasonValues
	{
		public const int UnknownDeal = 0;
		public const int UnknownOrInvalidInstrument = 1;
		public const int UnauthorizedTransaction = 2;
		public const int InsufficientCollateral = 3;
		public const int InvalidTypeOfCollateral = 4;
		public const int ExcessiveSubstitution = 5;
		public const int Other = 99;
	}
}
