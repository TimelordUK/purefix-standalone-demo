using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class TradSesStatusValues
	{
		public const int Unknown = 0;
		public const int Halted = 1;
		public const int Open = 2;
		public const int Closed = 3;
		public const int PreOpen = 4;
		public const int PreClose = 5;
		public const int RequestRejected = 6;
	}
}
