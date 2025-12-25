using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class SessionRejectReasonValues
	{
		public const int InvalidTagNumber = 0;
		public const int RequiredTagMissing = 1;
		public const int TagNotDefinedForThisMessageType = 2;
		public const int UndefinedTag = 3;
		public const int TagSpecifiedWithoutAValue = 4;
		public const int ValueIsIncorrect = 5;
		public const int IncorrectDataFormatForValue = 6;
		public const int DecryptionProblem = 7;
		public const int SignatureProblem = 8;
		public const int CompIdProblem = 9;
		public const int SendingTimeAccuracyProblem = 10;
		public const int InvalidMsgType = 11;
		public const int XmlValidationError = 12;
		public const int TagAppearsMoreThanOnce = 13;
		public const int TagSpecifiedOutOfRequiredOrder = 14;
		public const int RepeatingGroupFieldsOutOfOrder = 15;
		public const int IncorrectNumInGroupCountForRepeatingGroup = 16;
		public const int NonDataValueIncludesFieldDelimiter = 17;
		public const int InvalidUnsupportedApplVer = 18;
		public const int Other = 99;
	}
}
