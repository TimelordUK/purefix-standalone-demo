using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("CW", FixVersion.FIX50SP2)]
	public sealed partial class QuoteAck : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 117, Type = TagType.String, Offset = 1, Required = false)]
		public string? QuoteID {get; set;}
		
		[TagDetails(Tag = 1166, Type = TagType.String, Offset = 2, Required = false)]
		public string? QuoteMsgID {get; set;}
		
		[TagDetails(Tag = 131, Type = TagType.String, Offset = 3, Required = false)]
		public string? QuoteReqID {get; set;}
		
		[TagDetails(Tag = 537, Type = TagType.Int, Offset = 4, Required = false)]
		public int? QuoteType {get; set;}
		
		[TagDetails(Tag = 298, Type = TagType.Int, Offset = 5, Required = false)]
		public int? QuoteCancelType {get; set;}
		
		[TagDetails(Tag = 1751, Type = TagType.String, Offset = 6, Required = false)]
		public string? SecondaryQuoteID {get; set;}
		
		[TagDetails(Tag = 1865, Type = TagType.Int, Offset = 7, Required = true)]
		public int? QuoteAckStatus {get; set;}
		
		[TagDetails(Tag = 300, Type = TagType.Int, Offset = 8, Required = false)]
		public int? QuoteRejectReason {get; set;}
		
		[TagDetails(Tag = 1328, Type = TagType.String, Offset = 9, Required = false)]
		public string? RejectText {get; set;}
		
		[TagDetails(Tag = 1664, Type = TagType.Length, Offset = 10, Required = false)]
		public int? EncodedRejectTextLen {get; set;}
		
		[TagDetails(Tag = 1665, Type = TagType.RawData, Offset = 11, Required = false)]
		public byte[]? EncodedRejectText {get; set;}
		
		[Component(Offset = 12, Required = false)]
		public Parties? Parties {get; set;}
		
		[Component(Offset = 13, Required = false)]
		public QuoteAttributeGrp? QuoteAttributeGrp {get; set;}
		
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
			if (QuoteID is not null) writer.WriteString(117, QuoteID);
			if (QuoteMsgID is not null) writer.WriteString(1166, QuoteMsgID);
			if (QuoteReqID is not null) writer.WriteString(131, QuoteReqID);
			if (QuoteType is not null) writer.WriteWholeNumber(537, QuoteType.Value);
			if (QuoteCancelType is not null) writer.WriteWholeNumber(298, QuoteCancelType.Value);
			if (SecondaryQuoteID is not null) writer.WriteString(1751, SecondaryQuoteID);
			if (QuoteAckStatus is not null) writer.WriteWholeNumber(1865, QuoteAckStatus.Value);
			if (QuoteRejectReason is not null) writer.WriteWholeNumber(300, QuoteRejectReason.Value);
			if (RejectText is not null) writer.WriteString(1328, RejectText);
			if (EncodedRejectTextLen is not null) writer.WriteWholeNumber(1664, EncodedRejectTextLen.Value);
			if (EncodedRejectText is not null) writer.WriteBuffer(1665, EncodedRejectText);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (QuoteAttributeGrp is not null) ((IFixEncoder)QuoteAttributeGrp).Encode(writer);
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
			QuoteID = view.GetString(117);
			QuoteMsgID = view.GetString(1166);
			QuoteReqID = view.GetString(131);
			QuoteType = view.GetInt32(537);
			QuoteCancelType = view.GetInt32(298);
			SecondaryQuoteID = view.GetString(1751);
			QuoteAckStatus = view.GetInt32(1865);
			QuoteRejectReason = view.GetInt32(300);
			RejectText = view.GetString(1328);
			EncodedRejectTextLen = view.GetInt32(1664);
			EncodedRejectText = view.GetByteArray(1665);
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			if (view.GetView("QuoteAttributeGrp") is IMessageView viewQuoteAttributeGrp)
			{
				QuoteAttributeGrp = new();
				((IFixParser)QuoteAttributeGrp).Parse(viewQuoteAttributeGrp);
			}
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
				case "QuoteID":
				{
					value = QuoteID;
					break;
				}
				case "QuoteMsgID":
				{
					value = QuoteMsgID;
					break;
				}
				case "QuoteReqID":
				{
					value = QuoteReqID;
					break;
				}
				case "QuoteType":
				{
					value = QuoteType;
					break;
				}
				case "QuoteCancelType":
				{
					value = QuoteCancelType;
					break;
				}
				case "SecondaryQuoteID":
				{
					value = SecondaryQuoteID;
					break;
				}
				case "QuoteAckStatus":
				{
					value = QuoteAckStatus;
					break;
				}
				case "QuoteRejectReason":
				{
					value = QuoteRejectReason;
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
				case "Parties":
				{
					value = Parties;
					break;
				}
				case "QuoteAttributeGrp":
				{
					value = QuoteAttributeGrp;
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
			QuoteID = null;
			QuoteMsgID = null;
			QuoteReqID = null;
			QuoteType = null;
			QuoteCancelType = null;
			SecondaryQuoteID = null;
			QuoteAckStatus = null;
			QuoteRejectReason = null;
			RejectText = null;
			EncodedRejectTextLen = null;
			EncodedRejectText = null;
			((IFixReset?)Parties)?.Reset();
			((IFixReset?)QuoteAttributeGrp)?.Reset();
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
