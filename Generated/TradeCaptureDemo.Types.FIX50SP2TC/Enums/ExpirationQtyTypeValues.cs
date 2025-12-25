using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class ExpirationQtyTypeValues
	{
		public const int AutoExercise = 1;
		public const int NonAutoExercise = 2;
		public const int FinalWillBeExercised = 3;
		public const int ContraryIntention = 4;
		public const int Difference = 5;
	}
}
