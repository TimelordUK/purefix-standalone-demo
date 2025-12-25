using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class MassActionRejectReasonValues
	{
		public const int MassActionNotSupported = 0;
		public const int InvalidOrUnknownSecurity = 1;
		public const int InvalidOrUnknownUnderlyingSecurity = 2;
		public const int InvalidOrUnknownProduct = 3;
		public const int InvalidOrUnknownCfiCode = 4;
		public const int InvalidOrUnknownSecurityType = 5;
		public const int InvalidOrUnknownTradingSession = 6;
		public const int InvalidOrUnknownMarket = 7;
		public const int InvalidOrUnknownMarketSegment = 8;
		public const int InvalidOrUnknownSecurityGroup = 9;
		public const int InvalidOrUnknownSecurityIssuer = 10;
		public const int InvalidOrUnknownIssuerOfUnderlyingSecurity = 11;
		public const int Other = 99;
	}
}
