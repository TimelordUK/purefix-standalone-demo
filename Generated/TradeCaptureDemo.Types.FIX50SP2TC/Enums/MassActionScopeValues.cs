using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class MassActionScopeValues
	{
		public const int AllOrdersForASecurity = 1;
		public const int AllOrdersForAnUnderlyingSecurity = 2;
		public const int AllOrdersForAProduct = 3;
		public const int AllOrdersForAcfiCode = 4;
		public const int AllOrdersForASecurityType = 5;
		public const int AllOrdersForATradingSession = 6;
		public const int AllOrders = 7;
		public const int AllOrdersForAMarket = 8;
		public const int AllOrdersForAMarketSegment = 9;
		public const int AllOrdersForASecurityGroup = 10;
		public const int CancelForSecurityIssuer = 11;
		public const int CancelForIssuerOfUnderlyingSecurity = 12;
	}
}
