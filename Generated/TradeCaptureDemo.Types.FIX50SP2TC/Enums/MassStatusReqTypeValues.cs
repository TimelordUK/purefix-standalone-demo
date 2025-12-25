using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class MassStatusReqTypeValues
	{
		public const int StatusForOrdersForASecurity = 1;
		public const int StatusForOrdersForAnUnderlyingSecurity = 2;
		public const int StatusForOrdersForAProduct = 3;
		public const int StatusForOrdersForAcfiCode = 4;
		public const int StatusForOrdersForASecurityType = 5;
		public const int StatusForOrdersForATradingSession = 6;
		public const int StatusForAllOrders = 7;
		public const int StatusForOrdersForAPartyId = 8;
		public const int StatusForSecurityIssuer = 9;
		public const int StatusForIssuerOfUnderlyingSecurity = 10;
	}
}
