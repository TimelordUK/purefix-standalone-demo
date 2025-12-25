using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("AG", FixVersion.FIX50SP2)]
	public sealed partial class QuoteRequestReject : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 131, Type = TagType.String, Offset = 1, Required = true)]
		public string? QuoteReqID {get; set;}
		
		[TagDetails(Tag = 644, Type = TagType.String, Offset = 2, Required = false)]
		public string? RFQReqID {get; set;}
		
		[TagDetails(Tag = 658, Type = TagType.Int, Offset = 3, Required = true)]
		public int? QuoteRequestRejectReason {get; set;}
		
		[TagDetails(Tag = 1171, Type = TagType.Boolean, Offset = 4, Required = false)]
		public bool? PrivateQuote {get; set;}
		
		[TagDetails(Tag = 1172, Type = TagType.Int, Offset = 5, Required = false)]
		public int? RespondentType {get; set;}
		
		[TagDetails(Tag = 1091, Type = TagType.Boolean, Offset = 6, Required = false)]
		public bool? PreTradeAnonymity {get; set;}
		
		[Component(Offset = 7, Required = false)]
		public RootParties? RootParties {get; set;}
		
		[Component(Offset = 8, Required = true)]
		public QuotReqRjctGrp? QuotReqRjctGrp {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 9, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 10, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 11, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 12, Required = true)]
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
			if (QuoteReqID is not null) writer.WriteString(131, QuoteReqID);
			if (RFQReqID is not null) writer.WriteString(644, RFQReqID);
			if (QuoteRequestRejectReason is not null) writer.WriteWholeNumber(658, QuoteRequestRejectReason.Value);
			if (PrivateQuote is not null) writer.WriteBoolean(1171, PrivateQuote.Value);
			if (RespondentType is not null) writer.WriteWholeNumber(1172, RespondentType.Value);
			if (PreTradeAnonymity is not null) writer.WriteBoolean(1091, PreTradeAnonymity.Value);
			if (RootParties is not null) ((IFixEncoder)RootParties).Encode(writer);
			if (QuotReqRjctGrp is not null) ((IFixEncoder)QuotReqRjctGrp).Encode(writer);
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
			QuoteReqID = view.GetString(131);
			RFQReqID = view.GetString(644);
			QuoteRequestRejectReason = view.GetInt32(658);
			PrivateQuote = view.GetBool(1171);
			RespondentType = view.GetInt32(1172);
			PreTradeAnonymity = view.GetBool(1091);
			if (view.GetView("RootParties") is IMessageView viewRootParties)
			{
				RootParties = new();
				((IFixParser)RootParties).Parse(viewRootParties);
			}
			if (view.GetView("QuotReqRjctGrp") is IMessageView viewQuotReqRjctGrp)
			{
				QuotReqRjctGrp = new();
				((IFixParser)QuotReqRjctGrp).Parse(viewQuotReqRjctGrp);
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
				case "QuoteReqID":
				{
					value = QuoteReqID;
					break;
				}
				case "RFQReqID":
				{
					value = RFQReqID;
					break;
				}
				case "QuoteRequestRejectReason":
				{
					value = QuoteRequestRejectReason;
					break;
				}
				case "PrivateQuote":
				{
					value = PrivateQuote;
					break;
				}
				case "RespondentType":
				{
					value = RespondentType;
					break;
				}
				case "PreTradeAnonymity":
				{
					value = PreTradeAnonymity;
					break;
				}
				case "RootParties":
				{
					value = RootParties;
					break;
				}
				case "QuotReqRjctGrp":
				{
					value = QuotReqRjctGrp;
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
			QuoteReqID = null;
			RFQReqID = null;
			QuoteRequestRejectReason = null;
			PrivateQuote = null;
			RespondentType = null;
			PreTradeAnonymity = null;
			((IFixReset?)RootParties)?.Reset();
			((IFixReset?)QuotReqRjctGrp)?.Reset();
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
