using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class CollInquiryResultValues
	{
		public const int Successful = 0;
		public const int InvalidOrUnknownInstrument = 1;
		public const int InvalidOrUnknownCollateralType = 2;
		public const int InvalidParties = 3;
		public const int InvalidTransportTypeRequested = 4;
		public const int InvalidDestinationRequested = 5;
		public const int NoCollateralFoundForTheTradeSpecified = 6;
		public const int NoCollateralFoundForTheOrderSpecified = 7;
		public const int CollateralInquiryTypeNotSupported = 8;
		public const int UnauthorizedForCollateralInquiry = 9;
		public const int Other = 99;
	}
}
