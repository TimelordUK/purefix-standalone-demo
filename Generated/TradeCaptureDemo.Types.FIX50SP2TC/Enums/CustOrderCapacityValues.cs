using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class CustOrderCapacityValues
	{
		public const int MemberTradingForTheirOwnAccount = 1;
		public const int ClearingFirmTradingForItsProprietaryAccount = 2;
		public const int MemberTradingForAnotherMember = 3;
		public const int AllOther = 4;
		public const int RetailCustomer = 5;
	}
}
