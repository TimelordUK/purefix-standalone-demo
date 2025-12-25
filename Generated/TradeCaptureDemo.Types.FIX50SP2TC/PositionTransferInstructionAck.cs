using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("DM", FixVersion.FIX50SP2)]
	public sealed partial class PositionTransferInstructionAck : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 2436, Type = TagType.String, Offset = 1, Required = true)]
		public string? TransferInstructionID {get; set;}
		
		[TagDetails(Tag = 2437, Type = TagType.String, Offset = 2, Required = false)]
		public string? TransferID {get; set;}
		
		[TagDetails(Tag = 2439, Type = TagType.Int, Offset = 3, Required = false)]
		public int? TransferTransType {get; set;}
		
		[TagDetails(Tag = 2440, Type = TagType.Int, Offset = 4, Required = false)]
		public int? TransferType {get; set;}
		
		[TagDetails(Tag = 2442, Type = TagType.Int, Offset = 5, Required = false)]
		public int? TransferStatus {get; set;}
		
		[TagDetails(Tag = 2443, Type = TagType.Int, Offset = 6, Required = false)]
		public int? TransferRejectReason {get; set;}
		
		[TagDetails(Tag = 2441, Type = TagType.Int, Offset = 7, Required = false)]
		public int? TransferScope {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public Parties? Parties {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public TargetParties? TargetParties {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 10, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 1328, Type = TagType.String, Offset = 11, Required = false)]
		public string? RejectText {get; set;}
		
		[TagDetails(Tag = 1664, Type = TagType.Length, Offset = 12, Required = false)]
		public int? EncodedRejectTextLen {get; set;}
		
		[TagDetails(Tag = 1665, Type = TagType.RawData, Offset = 13, Required = false)]
		public byte[]? EncodedRejectText {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 14, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 15, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 16, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 17, Required = true)]
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
			if (TransferInstructionID is not null) writer.WriteString(2436, TransferInstructionID);
			if (TransferID is not null) writer.WriteString(2437, TransferID);
			if (TransferTransType is not null) writer.WriteWholeNumber(2439, TransferTransType.Value);
			if (TransferType is not null) writer.WriteWholeNumber(2440, TransferType.Value);
			if (TransferStatus is not null) writer.WriteWholeNumber(2442, TransferStatus.Value);
			if (TransferRejectReason is not null) writer.WriteWholeNumber(2443, TransferRejectReason.Value);
			if (TransferScope is not null) writer.WriteWholeNumber(2441, TransferScope.Value);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (TargetParties is not null) ((IFixEncoder)TargetParties).Encode(writer);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (RejectText is not null) writer.WriteString(1328, RejectText);
			if (EncodedRejectTextLen is not null) writer.WriteWholeNumber(1664, EncodedRejectTextLen.Value);
			if (EncodedRejectText is not null) writer.WriteBuffer(1665, EncodedRejectText);
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
			TransferInstructionID = view.GetString(2436);
			TransferID = view.GetString(2437);
			TransferTransType = view.GetInt32(2439);
			TransferType = view.GetInt32(2440);
			TransferStatus = view.GetInt32(2442);
			TransferRejectReason = view.GetInt32(2443);
			TransferScope = view.GetInt32(2441);
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			if (view.GetView("TargetParties") is IMessageView viewTargetParties)
			{
				TargetParties = new();
				((IFixParser)TargetParties).Parse(viewTargetParties);
			}
			TransactTime = view.GetDateTime(60);
			RejectText = view.GetString(1328);
			EncodedRejectTextLen = view.GetInt32(1664);
			EncodedRejectText = view.GetByteArray(1665);
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
				case "TransferInstructionID":
				{
					value = TransferInstructionID;
					break;
				}
				case "TransferID":
				{
					value = TransferID;
					break;
				}
				case "TransferTransType":
				{
					value = TransferTransType;
					break;
				}
				case "TransferType":
				{
					value = TransferType;
					break;
				}
				case "TransferStatus":
				{
					value = TransferStatus;
					break;
				}
				case "TransferRejectReason":
				{
					value = TransferRejectReason;
					break;
				}
				case "TransferScope":
				{
					value = TransferScope;
					break;
				}
				case "Parties":
				{
					value = Parties;
					break;
				}
				case "TargetParties":
				{
					value = TargetParties;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "RejectText":
				{
					value = RejectText;
					break;
				}
				case "EncodedRejectTextLen":
				{
					value = EncodedRejectTextLen;
					break;
				}
				case "EncodedRejectText":
				{
					value = EncodedRejectText;
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
			TransferInstructionID = null;
			TransferID = null;
			TransferTransType = null;
			TransferType = null;
			TransferStatus = null;
			TransferRejectReason = null;
			TransferScope = null;
			((IFixReset?)Parties)?.Reset();
			((IFixReset?)TargetParties)?.Reset();
			TransactTime = null;
			RejectText = null;
			EncodedRejectTextLen = null;
			EncodedRejectText = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
