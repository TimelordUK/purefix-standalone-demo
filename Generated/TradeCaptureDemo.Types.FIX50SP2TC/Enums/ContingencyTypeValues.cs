using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class ContingencyTypeValues
	{
		public const int OneCancelsTheOther = 1;
		public const int OneTriggersTheOther = 2;
		public const int OneUpdatesTheOtherAbsolute = 3;
		public const int OneUpdatesTheOtherProportional = 4;
		public const int BidAndOffer = 5;
		public const int BidAndOfferOco = 6;
	}
}
