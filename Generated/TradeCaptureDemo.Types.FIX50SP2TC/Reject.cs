using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("3", FixVersion.FIX50SP2)]
	public sealed partial class Reject : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 45, Type = TagType.Int, Offset = 1, Required = true)]
		public int? RefSeqNum {get; set;}
		
		[TagDetails(Tag = 371, Type = TagType.Int, Offset = 2, Required = false)]
		public int? RefTagID {get; set;}
		
		[TagDetails(Tag = 372, Type = TagType.String, Offset = 3, Required = false)]
		public string? RefMsgType {get; set;}
		
		[TagDetails(Tag = 373, Type = TagType.Int, Offset = 4, Required = false)]
		public int? SessionRejectReason {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 5, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 6, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 7, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 8, Required = true)]
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
			if (RefSeqNum is not null) writer.WriteWholeNumber(45, RefSeqNum.Value);
			if (RefTagID is not null) writer.WriteWholeNumber(371, RefTagID.Value);
			if (RefMsgType is not null) writer.WriteString(372, RefMsgType);
			if (SessionRejectReason is not null) writer.WriteWholeNumber(373, SessionRejectReason.Value);
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
			RefSeqNum = view.GetInt32(45);
			RefTagID = view.GetInt32(371);
			RefMsgType = view.GetString(372);
			SessionRejectReason = view.GetInt32(373);
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
				case "RefSeqNum":
				{
					value = RefSeqNum;
					break;
				}
				case "RefTagID":
				{
					value = RefTagID;
					break;
				}
				case "RefMsgType":
				{
					value = RefMsgType;
					break;
				}
				case "SessionRejectReason":
				{
					value = SessionRejectReason;
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
			RefSeqNum = null;
			RefTagID = null;
			RefMsgType = null;
			SessionRejectReason = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
