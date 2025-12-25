using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class AccountTypeValues
	{
		public const int CarriedCustomerSide = 1;
		public const int CarriedNonCustomerSide = 2;
		public const int HouseTrader = 3;
		public const int FloorTrader = 4;
		public const int CarriedNonCustomerSideCrossMargined = 6;
		public const int HouseTraderCrossMargined = 7;
		public const int JointBackOfficeAccount = 8;
		public const int EquitiesSpecialist = 9;
		public const int OptionsMarketMaker = 10;
		public const int OptionsFirmAccount = 11;
		public const int AccountCustomerNonCustomerOrders = 12;
		public const int AccountOrdersMultipleCustomers = 13;
	}
}
