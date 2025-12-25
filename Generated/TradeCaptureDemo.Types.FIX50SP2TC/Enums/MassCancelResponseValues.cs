using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class MassCancelResponseValues
	{
		public const string CancelRequestRejected = "0";
		public const string CancelOrdersForASecurity = "1";
		public const string CancelOrdersForAnUnderlyingSecurity = "2";
		public const string CancelOrdersForAProduct = "3";
		public const string CancelOrdersForAcfiCode = "4";
		public const string CancelOrdersForASecurityType = "5";
		public const string CancelOrdersForATradingSession = "6";
		public const string CancelAllOrders = "7";
		public const string CancelOrdersForAMarket = "8";
		public const string CancelOrdersForAMarketSegment = "9";
		public const string CancelOrdersForASecurityGroup = "A";
		public const string CancelOrdersForASecuritiesIssuer = "B";
		public const string CancelOrdersForIssuerOfUnderlyingSecurity = "C";
	}
}
