using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class SecurityRequestResultValues
	{
		public const int ValidRequest = 0;
		public const int InvalidOrUnsupportedRequest = 1;
		public const int NoInstrumentsFound = 2;
		public const int NotAuthorizedToRetrieveInstrumentData = 3;
		public const int InstrumentDataTemporarilyUnavailable = 4;
		public const int RequestForInstrumentDataNotSupported = 5;
	}
}
