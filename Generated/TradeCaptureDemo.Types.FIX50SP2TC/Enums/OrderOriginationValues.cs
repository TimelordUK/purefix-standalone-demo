using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class OrderOriginationValues
	{
		public const int OrderReceivedFromCustomer = 1;
		public const int OrderReceivedFromWithinFirm = 2;
		public const int OrderReceivedFromAnotherBrokerDealer = 3;
		public const int OrderReceivedFromCustomerOrWithFirm = 4;
		public const int OrderReceivedFromDirectAccessCustomer = 5;
		public const int OrderReceivedFromForeignDealerEquivalent = 6;
		public const int OrderReceivedFromExecutionOnlyService = 7;
	}
}
