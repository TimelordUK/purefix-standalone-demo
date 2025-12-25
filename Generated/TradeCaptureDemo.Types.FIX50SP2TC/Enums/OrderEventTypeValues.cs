using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class OrderEventTypeValues
	{
		public const int Added = 1;
		public const int Modified = 2;
		public const int Deleted = 3;
		public const int PartiallyFilled = 4;
		public const int Filled = 5;
		public const int Suspended = 6;
		public const int Released = 7;
		public const int Restated = 8;
		public const int Locked = 9;
		public const int Triggered = 10;
		public const int Activated = 11;
	}
}
