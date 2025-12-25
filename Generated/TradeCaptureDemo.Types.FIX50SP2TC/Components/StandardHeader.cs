using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class StandardHeader : IFixComponent, IStandardHeader
	{
		[TagDetails(Tag = 8, Type = TagType.String, Offset = 0, Required = true)]
		public string? BeginString {get; set;}
		
		[TagDetails(Tag = 9, Type = TagType.Length, Offset = 1, Required = true)]
		public int? BodyLength {get; set;}
		
		[TagDetails(Tag = 35, Type = TagType.String, Offset = 2, Required = true)]
		public string? MsgType {get; set;}
		
		[TagDetails(Tag = 49, Type = TagType.String, Offset = 3, Required = true)]
		public string? SenderCompID {get; set;}
		
		[TagDetails(Tag = 56, Type = TagType.String, Offset = 4, Required = true)]
		public string? TargetCompID {get; set;}
		
		[TagDetails(Tag = 115, Type = TagType.String, Offset = 5, Required = false)]
		public string? OnBehalfOfCompID {get; set;}
		
		[TagDetails(Tag = 128, Type = TagType.String, Offset = 6, Required = false)]
		public string? DeliverToCompID {get; set;}
		
		[TagDetails(Tag = 90, Type = TagType.Length, Offset = 7, Required = false)]
		public int? SecureDataLen {get; set;}
		
		[TagDetails(Tag = 91, Type = TagType.RawData, Offset = 8, Required = false)]
		public byte[]? SecureData {get; set;}
		
		[TagDetails(Tag = 34, Type = TagType.Int, Offset = 9, Required = true)]
		public int? MsgSeqNum {get; set;}
		
		[TagDetails(Tag = 50, Type = TagType.String, Offset = 10, Required = false)]
		public string? SenderSubID {get; set;}
		
		[TagDetails(Tag = 142, Type = TagType.String, Offset = 11, Required = false)]
		public string? SenderLocationID {get; set;}
		
		[TagDetails(Tag = 57, Type = TagType.String, Offset = 12, Required = false)]
		public string? TargetSubID {get; set;}
		
		[TagDetails(Tag = 143, Type = TagType.String, Offset = 13, Required = false)]
		public string? TargetLocationID {get; set;}
		
		[TagDetails(Tag = 116, Type = TagType.String, Offset = 14, Required = false)]
		public string? OnBehalfOfSubID {get; set;}
		
		[TagDetails(Tag = 144, Type = TagType.String, Offset = 15, Required = false)]
		public string? OnBehalfOfLocationID {get; set;}
		
		[TagDetails(Tag = 129, Type = TagType.String, Offset = 16, Required = false)]
		public string? DeliverToSubID {get; set;}
		
		[TagDetails(Tag = 145, Type = TagType.String, Offset = 17, Required = false)]
		public string? DeliverToLocationID {get; set;}
		
		[TagDetails(Tag = 43, Type = TagType.Boolean, Offset = 18, Required = false)]
		public bool? PossDupFlag {get; set;}
		
		[TagDetails(Tag = 97, Type = TagType.Boolean, Offset = 19, Required = false)]
		public bool? PossResend {get; set;}
		
		[TagDetails(Tag = 52, Type = TagType.UtcTimestamp, Offset = 20, Required = true)]
		public DateTime? SendingTime {get; set;}
		
		[TagDetails(Tag = 122, Type = TagType.UtcTimestamp, Offset = 21, Required = false)]
		public DateTime? OrigSendingTime {get; set;}
		
		[TagDetails(Tag = 212, Type = TagType.Length, Offset = 22, Required = false)]
		public int? XmlDataLen {get; set;}
		
		[TagDetails(Tag = 213, Type = TagType.String, Offset = 23, Required = false)]
		public string? XmlData {get; set;}
		
		[TagDetails(Tag = 347, Type = TagType.String, Offset = 24, Required = false)]
		public string? MessageEncoding {get; set;}
		
		[TagDetails(Tag = 369, Type = TagType.Int, Offset = 25, Required = false)]
		public int? LastMsgSeqNumProcessed {get; set;}
		
		[Component(Offset = 26, Required = false)]
		public Hop? Hop {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (BeginString is not null) writer.WriteString(8, BeginString);
			if (BodyLength is not null) writer.WriteWholeNumber(9, BodyLength.Value);
			if (MsgType is not null) writer.WriteString(35, MsgType);
			if (SenderCompID is not null) writer.WriteString(49, SenderCompID);
			if (TargetCompID is not null) writer.WriteString(56, TargetCompID);
			if (OnBehalfOfCompID is not null) writer.WriteString(115, OnBehalfOfCompID);
			if (DeliverToCompID is not null) writer.WriteString(128, DeliverToCompID);
			if (SecureDataLen is not null) writer.WriteWholeNumber(90, SecureDataLen.Value);
			if (SecureData is not null) writer.WriteBuffer(91, SecureData);
			if (MsgSeqNum is not null) writer.WriteWholeNumber(34, MsgSeqNum.Value);
			if (SenderSubID is not null) writer.WriteString(50, SenderSubID);
			if (SenderLocationID is not null) writer.WriteString(142, SenderLocationID);
			if (TargetSubID is not null) writer.WriteString(57, TargetSubID);
			if (TargetLocationID is not null) writer.WriteString(143, TargetLocationID);
			if (OnBehalfOfSubID is not null) writer.WriteString(116, OnBehalfOfSubID);
			if (OnBehalfOfLocationID is not null) writer.WriteString(144, OnBehalfOfLocationID);
			if (DeliverToSubID is not null) writer.WriteString(129, DeliverToSubID);
			if (DeliverToLocationID is not null) writer.WriteString(145, DeliverToLocationID);
			if (PossDupFlag is not null) writer.WriteBoolean(43, PossDupFlag.Value);
			if (PossResend is not null) writer.WriteBoolean(97, PossResend.Value);
			if (SendingTime is not null) writer.WriteUtcTimeStamp(52, SendingTime.Value);
			if (OrigSendingTime is not null) writer.WriteUtcTimeStamp(122, OrigSendingTime.Value);
			if (XmlDataLen is not null) writer.WriteWholeNumber(212, XmlDataLen.Value);
			if (XmlData is not null) writer.WriteString(213, XmlData);
			if (MessageEncoding is not null) writer.WriteString(347, MessageEncoding);
			if (LastMsgSeqNumProcessed is not null) writer.WriteWholeNumber(369, LastMsgSeqNumProcessed.Value);
			if (Hop is not null) ((IFixEncoder)Hop).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			BeginString = view.GetString(8);
			BodyLength = view.GetInt32(9);
			MsgType = view.GetString(35);
			SenderCompID = view.GetString(49);
			TargetCompID = view.GetString(56);
			OnBehalfOfCompID = view.GetString(115);
			DeliverToCompID = view.GetString(128);
			SecureDataLen = view.GetInt32(90);
			SecureData = view.GetByteArray(91);
			MsgSeqNum = view.GetInt32(34);
			SenderSubID = view.GetString(50);
			SenderLocationID = view.GetString(142);
			TargetSubID = view.GetString(57);
			TargetLocationID = view.GetString(143);
			OnBehalfOfSubID = view.GetString(116);
			OnBehalfOfLocationID = view.GetString(144);
			DeliverToSubID = view.GetString(129);
			DeliverToLocationID = view.GetString(145);
			PossDupFlag = view.GetBool(43);
			PossResend = view.GetBool(97);
			SendingTime = view.GetDateTime(52);
			OrigSendingTime = view.GetDateTime(122);
			XmlDataLen = view.GetInt32(212);
			XmlData = view.GetString(213);
			MessageEncoding = view.GetString(347);
			LastMsgSeqNumProcessed = view.GetInt32(369);
			if (view.GetView("Hop") is IMessageView viewHop)
			{
				Hop = new();
				((IFixParser)Hop).Parse(viewHop);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "BeginString":
				{
					value = BeginString;
					break;
				}
				case "BodyLength":
				{
					value = BodyLength;
					break;
				}
				case "MsgType":
				{
					value = MsgType;
					break;
				}
				case "SenderCompID":
				{
					value = SenderCompID;
					break;
				}
				case "TargetCompID":
				{
					value = TargetCompID;
					break;
				}
				case "OnBehalfOfCompID":
				{
					value = OnBehalfOfCompID;
					break;
				}
				case "DeliverToCompID":
				{
					value = DeliverToCompID;
					break;
				}
				case "SecureDataLen":
				{
					value = SecureDataLen;
					break;
				}
				case "SecureData":
				{
					value = SecureData;
					break;
				}
				case "MsgSeqNum":
				{
					value = MsgSeqNum;
					break;
				}
				case "SenderSubID":
				{
					value = SenderSubID;
					break;
				}
				case "SenderLocationID":
				{
					value = SenderLocationID;
					break;
				}
				case "TargetSubID":
				{
					value = TargetSubID;
					break;
				}
				case "TargetLocationID":
				{
					value = TargetLocationID;
					break;
				}
				case "OnBehalfOfSubID":
				{
					value = OnBehalfOfSubID;
					break;
				}
				case "OnBehalfOfLocationID":
				{
					value = OnBehalfOfLocationID;
					break;
				}
				case "DeliverToSubID":
				{
					value = DeliverToSubID;
					break;
				}
				case "DeliverToLocationID":
				{
					value = DeliverToLocationID;
					break;
				}
				case "PossDupFlag":
				{
					value = PossDupFlag;
					break;
				}
				case "PossResend":
				{
					value = PossResend;
					break;
				}
				case "SendingTime":
				{
					value = SendingTime;
					break;
				}
				case "OrigSendingTime":
				{
					value = OrigSendingTime;
					break;
				}
				case "XmlDataLen":
				{
					value = XmlDataLen;
					break;
				}
				case "XmlData":
				{
					value = XmlData;
					break;
				}
				case "MessageEncoding":
				{
					value = MessageEncoding;
					break;
				}
				case "LastMsgSeqNumProcessed":
				{
					value = LastMsgSeqNumProcessed;
					break;
				}
				case "Hop":
				{
					value = Hop;
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
			BeginString = null;
			BodyLength = null;
			MsgType = null;
			SenderCompID = null;
			TargetCompID = null;
			OnBehalfOfCompID = null;
			DeliverToCompID = null;
			SecureDataLen = null;
			SecureData = null;
			MsgSeqNum = null;
			SenderSubID = null;
			SenderLocationID = null;
			TargetSubID = null;
			TargetLocationID = null;
			OnBehalfOfSubID = null;
			OnBehalfOfLocationID = null;
			DeliverToSubID = null;
			DeliverToLocationID = null;
			PossDupFlag = null;
			PossResend = null;
			SendingTime = null;
			OrigSendingTime = null;
			XmlDataLen = null;
			XmlData = null;
			MessageEncoding = null;
			LastMsgSeqNumProcessed = null;
			((IFixReset?)Hop)?.Reset();
		}
	}
}
