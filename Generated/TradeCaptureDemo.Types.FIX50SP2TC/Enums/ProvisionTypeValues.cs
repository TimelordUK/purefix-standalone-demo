using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class ProvisionTypeValues
	{
		public const int MandatoryEarlyTermination = 0;
		public const int OptionalEarlyTermination = 1;
		public const int Cancelable = 2;
		public const int Extendable = 3;
		public const int MutualEarlyTermination = 4;
		public const int Evergreen = 5;
		public const int Callable = 6;
		public const int Puttable = 7;
	}
}
