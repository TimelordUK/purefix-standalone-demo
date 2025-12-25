using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class TrdRegPublicationTypeValues
	{
		public const int PreTradeTransparencyWaiver = 0;
		public const int PostTradeDeferral = 1;
		public const int ExemptFromPublication = 2;
		public const int OrderLevelPublicationToSubscribers = 3;
		public const int PriceLevelPublicationToSubscribers = 4;
		public const int OrderLevelPublicationToThePublic = 5;
		public const int PublicationInternalToExecutionVenue = 6;
	}
}
