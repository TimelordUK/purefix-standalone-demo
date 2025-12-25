using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("A", FixVersion.FIX50SP2)]
	public sealed partial class Logon : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 98, Type = TagType.Int, Offset = 1, Required = true)]
		public int? EncryptMethod {get; set;}
		
		[TagDetails(Tag = 108, Type = TagType.Int, Offset = 2, Required = true)]
		public int? HeartBtInt {get; set;}
		
		[TagDetails(Tag = 95, Type = TagType.Length, Offset = 3, Required = false)]
		public int? RawDataLength {get; set;}
		
		[TagDetails(Tag = 96, Type = TagType.RawData, Offset = 4, Required = false)]
		public byte[]? RawData {get; set;}
		
		[TagDetails(Tag = 141, Type = TagType.Boolean, Offset = 5, Required = false)]
		public bool? ResetSeqNumFlag {get; set;}
		
		[TagDetails(Tag = 789, Type = TagType.Int, Offset = 6, Required = false)]
		public int? NextExpectedMsgSeqNum {get; set;}
		
		[TagDetails(Tag = 383, Type = TagType.Length, Offset = 7, Required = false)]
		public int? MaxMessageSize {get; set;}
		
		public sealed partial class NoMsgTypes : IFixGroup
		{
			[TagDetails(Tag = 372, Type = TagType.String, Offset = 0, Required = false)]
			public string? RefMsgType {get; set;}
			
			[TagDetails(Tag = 385, Type = TagType.String, Offset = 1, Required = false)]
			public string? MsgDirection {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (RefMsgType is not null) writer.WriteString(372, RefMsgType);
				if (MsgDirection is not null) writer.WriteString(385, MsgDirection);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				RefMsgType = view.GetString(372);
				MsgDirection = view.GetString(385);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "RefMsgType":
					{
						value = RefMsgType;
						break;
					}
					case "MsgDirection":
					{
						value = MsgDirection;
						break;
					}
					default:
					{
						return false;
					}
				}
				return true;
			}
			
			void IFixReset.Reset()
			{
				RefMsgType = null;
				MsgDirection = null;
			}
		}
		[Group(NoOfTag = 384, Offset = 8, Required = false)]
		public NoMsgTypes[]? MsgTypes {get; set;}
		
		[TagDetails(Tag = 464, Type = TagType.Boolean, Offset = 9, Required = false)]
		public bool? TestMessageIndicator {get; set;}
		
		[TagDetails(Tag = 553, Type = TagType.String, Offset = 10, Required = false)]
		public string? Username {get; set;}
		
		[TagDetails(Tag = 554, Type = TagType.String, Offset = 11, Required = false)]
		public string? Password {get; set;}
		
		[TagDetails(Tag = 925, Type = TagType.String, Offset = 12, Required = false)]
		public string? NewPassword {get; set;}
		
		[TagDetails(Tag = 1400, Type = TagType.Int, Offset = 13, Required = false)]
		public int? EncryptedPasswordMethod {get; set;}
		
		[TagDetails(Tag = 1401, Type = TagType.Length, Offset = 14, Required = false)]
		public int? EncryptedPasswordLen {get; set;}
		
		[TagDetails(Tag = 1402, Type = TagType.RawData, Offset = 15, Required = false)]
		public byte[]? EncryptedPassword {get; set;}
		
		[TagDetails(Tag = 1403, Type = TagType.Length, Offset = 16, Required = false)]
		public int? EncryptedNewPasswordLen {get; set;}
		
		[TagDetails(Tag = 1404, Type = TagType.RawData, Offset = 17, Required = false)]
		public byte[]? EncryptedNewPassword {get; set;}
		
		[TagDetails(Tag = 1409, Type = TagType.Int, Offset = 18, Required = false)]
		public int? SessionStatus {get; set;}
		
		[TagDetails(Tag = 1137, Type = TagType.String, Offset = 19, Required = false)]
		public string? DefaultApplVerID {get; set;}
		
		[TagDetails(Tag = 1407, Type = TagType.Int, Offset = 20, Required = false)]
		public int? DefaultApplExtID {get; set;}
		
		[TagDetails(Tag = 1408, Type = TagType.String, Offset = 21, Required = false)]
		public string? DefaultCstmApplVerID {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 22, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 23, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 24, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 25, Required = true)]
		public StandardTrailer? StandardTrailer {get; set;}
		
		
		IStandardHeader? IFixMessage.StandardHeader => StandardHeader;
		
		IStandardTrailer? IFixMessage.StandardTrailer => StandardTrailer;
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return (!config.CheckStandardHeader || (StandardHeader is not null && ((IFixValidator)StandardHeader).IsValid(in config))) && (!config.CheckStandardTrailer || (StandardTrailer is not null && ((IFixValidator)StandardTrailer).IsValid(in config)));
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (StandardHeader is not null) ((IFixEncoder)StandardHeader).Encode(writer);
			if (EncryptMethod is not null) writer.WriteWholeNumber(98, EncryptMethod.Value);
			if (HeartBtInt is not null) writer.WriteWholeNumber(108, HeartBtInt.Value);
			if (RawDataLength is not null) writer.WriteWholeNumber(95, RawDataLength.Value);
			if (RawData is not null) writer.WriteBuffer(96, RawData);
			if (ResetSeqNumFlag is not null) writer.WriteBoolean(141, ResetSeqNumFlag.Value);
			if (NextExpectedMsgSeqNum is not null) writer.WriteWholeNumber(789, NextExpectedMsgSeqNum.Value);
			if (MaxMessageSize is not null) writer.WriteWholeNumber(383, MaxMessageSize.Value);
			if (MsgTypes is not null && MsgTypes.Length != 0)
			{
				writer.WriteWholeNumber(384, MsgTypes.Length);
				for (int i = 0; i < MsgTypes.Length; i++)
				{
					((IFixEncoder)MsgTypes[i]).Encode(writer);
				}
			}
			if (TestMessageIndicator is not null) writer.WriteBoolean(464, TestMessageIndicator.Value);
			if (Username is not null) writer.WriteString(553, Username);
			if (Password is not null) writer.WriteString(554, Password);
			if (NewPassword is not null) writer.WriteString(925, NewPassword);
			if (EncryptedPasswordMethod is not null) writer.WriteWholeNumber(1400, EncryptedPasswordMethod.Value);
			if (EncryptedPasswordLen is not null) writer.WriteWholeNumber(1401, EncryptedPasswordLen.Value);
			if (EncryptedPassword is not null) writer.WriteBuffer(1402, EncryptedPassword);
			if (EncryptedNewPasswordLen is not null) writer.WriteWholeNumber(1403, EncryptedNewPasswordLen.Value);
			if (EncryptedNewPassword is not null) writer.WriteBuffer(1404, EncryptedNewPassword);
			if (SessionStatus is not null) writer.WriteWholeNumber(1409, SessionStatus.Value);
			if (DefaultApplVerID is not null) writer.WriteString(1137, DefaultApplVerID);
			if (DefaultApplExtID is not null) writer.WriteWholeNumber(1407, DefaultApplExtID.Value);
			if (DefaultCstmApplVerID is not null) writer.WriteString(1408, DefaultCstmApplVerID);
			if (Text is not null) writer.WriteString(58, Text);
			if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
			if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
			if (StandardTrailer is not null) ((IFixEncoder)StandardTrailer).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("StandardHeader") is IMessageView viewStandardHeader)
			{
				StandardHeader = new();
				((IFixParser)StandardHeader).Parse(viewStandardHeader);
			}
			EncryptMethod = view.GetInt32(98);
			HeartBtInt = view.GetInt32(108);
			RawDataLength = view.GetInt32(95);
			RawData = view.GetByteArray(96);
			ResetSeqNumFlag = view.GetBool(141);
			NextExpectedMsgSeqNum = view.GetInt32(789);
			MaxMessageSize = view.GetInt32(383);
			if (view.GetView("NoMsgTypes") is IMessageView viewNoMsgTypes)
			{
				var count = viewNoMsgTypes.GroupCount();
				MsgTypes = new NoMsgTypes[count];
				for (int i = 0; i < count; i++)
				{
					MsgTypes[i] = new();
					((IFixParser)MsgTypes[i]).Parse(viewNoMsgTypes.GetGroupInstance(i));
				}
			}
			TestMessageIndicator = view.GetBool(464);
			Username = view.GetString(553);
			Password = view.GetString(554);
			NewPassword = view.GetString(925);
			EncryptedPasswordMethod = view.GetInt32(1400);
			EncryptedPasswordLen = view.GetInt32(1401);
			EncryptedPassword = view.GetByteArray(1402);
			EncryptedNewPasswordLen = view.GetInt32(1403);
			EncryptedNewPassword = view.GetByteArray(1404);
			SessionStatus = view.GetInt32(1409);
			DefaultApplVerID = view.GetString(1137);
			DefaultApplExtID = view.GetInt32(1407);
			DefaultCstmApplVerID = view.GetString(1408);
			Text = view.GetString(58);
			EncodedTextLen = view.GetInt32(354);
			EncodedText = view.GetByteArray(355);
			if (view.GetView("StandardTrailer") is IMessageView viewStandardTrailer)
			{
				StandardTrailer = new();
				((IFixParser)StandardTrailer).Parse(viewStandardTrailer);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "StandardHeader":
				{
					value = StandardHeader;
					break;
				}
				case "EncryptMethod":
				{
					value = EncryptMethod;
					break;
				}
				case "HeartBtInt":
				{
					value = HeartBtInt;
					break;
				}
				case "RawDataLength":
				{
					value = RawDataLength;
					break;
				}
				case "RawData":
				{
					value = RawData;
					break;
				}
				case "ResetSeqNumFlag":
				{
					value = ResetSeqNumFlag;
					break;
				}
				case "NextExpectedMsgSeqNum":
				{
					value = NextExpectedMsgSeqNum;
					break;
				}
				case "MaxMessageSize":
				{
					value = MaxMessageSize;
					break;
				}
				case "NoMsgTypes":
				{
					value = MsgTypes;
					break;
				}
				case "TestMessageIndicator":
				{
					value = TestMessageIndicator;
					break;
				}
				case "Username":
				{
					value = Username;
					break;
				}
				case "Password":
				{
					value = Password;
					break;
				}
				case "NewPassword":
				{
					value = NewPassword;
					break;
				}
				case "EncryptedPasswordMethod":
				{
					value = EncryptedPasswordMethod;
					break;
				}
				case "EncryptedPasswordLen":
				{
					value = EncryptedPasswordLen;
					break;
				}
				case "EncryptedPassword":
				{
					value = EncryptedPassword;
					break;
				}
				case "EncryptedNewPasswordLen":
				{
					value = EncryptedNewPasswordLen;
					break;
				}
				case "EncryptedNewPassword":
				{
					value = EncryptedNewPassword;
					break;
				}
				case "SessionStatus":
				{
					value = SessionStatus;
					break;
				}
				case "DefaultApplVerID":
				{
					value = DefaultApplVerID;
					break;
				}
				case "DefaultApplExtID":
				{
					value = DefaultApplExtID;
					break;
				}
				case "DefaultCstmApplVerID":
				{
					value = DefaultCstmApplVerID;
					break;
				}
				case "Text":
				{
					value = Text;
					break;
				}
				case "EncodedTextLen":
				{
					value = EncodedTextLen;
					break;
				}
				case "EncodedText":
				{
					value = EncodedText;
					break;
				}
				case "StandardTrailer":
				{
					value = StandardTrailer;
					break;
				}
				default:
				{
					return false;
				}
			}
			return true;
		}
		
		void IFixReset.Reset()
		{
			((IFixReset?)StandardHeader)?.Reset();
			EncryptMethod = null;
			HeartBtInt = null;
			RawDataLength = null;
			RawData = null;
			ResetSeqNumFlag = null;
			NextExpectedMsgSeqNum = null;
			MaxMessageSize = null;
			MsgTypes = null;
			TestMessageIndicator = null;
			Username = null;
			Password = null;
			NewPassword = null;
			EncryptedPasswordMethod = null;
			EncryptedPasswordLen = null;
			EncryptedPassword = null;
			EncryptedNewPasswordLen = null;
			EncryptedNewPassword = null;
			SessionStatus = null;
			DefaultApplVerID = null;
			DefaultApplExtID = null;
			DefaultCstmApplVerID = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
