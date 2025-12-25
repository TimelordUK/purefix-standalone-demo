using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class MarginReqmtInqResultValues
	{
		public const int Successful = 0;
		public const int InvalidOrUnknownInstrument = 1;
		public const int InvalidOrUnknownMarginClass = 2;
		public const int InvalidParties = 3;
		public const int InvalidTransportTypeReq = 4;
		public const int InvalidDestinationReq = 5;
		public const int NoMarginReqFound = 6;
		public const int MarginReqInquiryQualifierNotSupported = 7;
		public const int UnauthorizedForMarginReqInquiry = 8;
		public const int Other = 99;
	}
}
