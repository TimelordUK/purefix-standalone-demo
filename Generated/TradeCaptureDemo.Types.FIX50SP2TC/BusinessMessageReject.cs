using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("j", FixVersion.FIX50SP2)]
	public sealed partial class BusinessMessageReject : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 45, Type = TagType.Int, Offset = 1, Required = false)]
		public int? RefSeqNum {get; set;}
		
		[TagDetails(Tag = 372, Type = TagType.String, Offset = 2, Required = true)]
		public string? RefMsgType {get; set;}
		
		[TagDetails(Tag = 1130, Type = TagType.String, Offset = 3, Required = false)]
		public string? RefApplVerID {get; set;}
		
		[TagDetails(Tag = 1406, Type = TagType.Int, Offset = 4, Required = false)]
		public int? RefApplExtID {get; set;}
		
		[TagDetails(Tag = 1131, Type = TagType.String, Offset = 5, Required = false)]
		public string? RefCstmApplVerID {get; set;}
		
		[TagDetails(Tag = 379, Type = TagType.String, Offset = 6, Required = false)]
		public string? BusinessRejectRefID {get; set;}
		
		[TagDetails(Tag = 380, Type = TagType.Int, Offset = 7, Required = true)]
		public int? BusinessRejectReason {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 8, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 9, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 10, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 11, Required = true)]
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
			if (RefMsgType is not null) writer.WriteString(372, RefMsgType);
			if (RefApplVerID is not null) writer.WriteString(1130, RefApplVerID);
			if (RefApplExtID is not null) writer.WriteWholeNumber(1406, RefApplExtID.Value);
			if (RefCstmApplVerID is not null) writer.WriteString(1131, RefCstmApplVerID);
			if (BusinessRejectRefID is not null) writer.WriteString(379, BusinessRejectRefID);
			if (BusinessRejectReason is not null) writer.WriteWholeNumber(380, BusinessRejectReason.Value);
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
			RefMsgType = view.GetString(372);
			RefApplVerID = view.GetString(1130);
			RefApplExtID = view.GetInt32(1406);
			RefCstmApplVerID = view.GetString(1131);
			BusinessRejectRefID = view.GetString(379);
			BusinessRejectReason = view.GetInt32(380);
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
				case "RefMsgType":
				{
					value = RefMsgType;
					break;
				}
				case "RefApplVerID":
				{
					value = RefApplVerID;
					break;
				}
				case "RefApplExtID":
				{
					value = RefApplExtID;
					break;
				}
				case "RefCstmApplVerID":
				{
					value = RefCstmApplVerID;
					break;
				}
				case "BusinessRejectRefID":
				{
					value = BusinessRejectRefID;
					break;
				}
				case "BusinessRejectReason":
				{
					value = BusinessRejectReason;
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
			RefMsgType = null;
			RefApplVerID = null;
			RefApplExtID = null;
			RefCstmApplVerID = null;
			BusinessRejectRefID = null;
			BusinessRejectReason = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
