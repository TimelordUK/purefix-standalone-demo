using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class SecurityRejectReasonValues
	{
		public const int InvalidInstrumentRequested = 1;
		public const int InstrumentAlreadyExists = 2;
		public const int RequestTypeNotSupported = 3;
		public const int SystemUnavailableForInstrumentCreation = 4;
		public const int IneligibleInstrumentGroup = 5;
		public const int InstrumentIdUnavailable = 6;
		public const int InvalidOrMissingDataOnOptionLeg = 7;
		public const int InvalidOrMissingDataOnFutureLeg = 8;
		public const int InvalidOrMissingDataOnFxLeg = 10;
		public const int InvalidLegPriceSpecified = 11;
		public const int InvalidInstrumentStructureSpecified = 12;
	}
}
