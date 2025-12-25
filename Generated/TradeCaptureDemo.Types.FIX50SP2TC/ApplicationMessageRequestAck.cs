using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("BX", FixVersion.FIX50SP2)]
	public sealed partial class ApplicationMessageRequestAck : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 1353, Type = TagType.String, Offset = 1, Required = true)]
		public string? ApplResponseID {get; set;}
		
		[TagDetails(Tag = 1346, Type = TagType.String, Offset = 2, Required = false)]
		public string? ApplReqID {get; set;}
		
		[TagDetails(Tag = 1347, Type = TagType.Int, Offset = 3, Required = false)]
		public int? ApplReqType {get; set;}
		
		[TagDetails(Tag = 1348, Type = TagType.Int, Offset = 4, Required = false)]
		public int? ApplResponseType {get; set;}
		
		[TagDetails(Tag = 1349, Type = TagType.Int, Offset = 5, Required = false)]
		public int? ApplTotalMessageCount {get; set;}
		
		[Component(Offset = 6, Required = false)]
		public ApplIDRequestAckGrp? ApplIDRequestAckGrp {get; set;}
		
		[Component(Offset = 7, Required = false)]
		public Parties? Parties {get; set;}
		
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
			if (ApplResponseID is not null) writer.WriteString(1353, ApplResponseID);
			if (ApplReqID is not null) writer.WriteString(1346, ApplReqID);
			if (ApplReqType is not null) writer.WriteWholeNumber(1347, ApplReqType.Value);
			if (ApplResponseType is not null) writer.WriteWholeNumber(1348, ApplResponseType.Value);
			if (ApplTotalMessageCount is not null) writer.WriteWholeNumber(1349, ApplTotalMessageCount.Value);
			if (ApplIDRequestAckGrp is not null) ((IFixEncoder)ApplIDRequestAckGrp).Encode(writer);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
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
			ApplResponseID = view.GetString(1353);
			ApplReqID = view.GetString(1346);
			ApplReqType = view.GetInt32(1347);
			ApplResponseType = view.GetInt32(1348);
			ApplTotalMessageCount = view.GetInt32(1349);
			if (view.GetView("ApplIDRequestAckGrp") is IMessageView viewApplIDRequestAckGrp)
			{
				ApplIDRequestAckGrp = new();
				((IFixParser)ApplIDRequestAckGrp).Parse(viewApplIDRequestAckGrp);
			}
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
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
				case "ApplResponseID":
				{
					value = ApplResponseID;
					break;
				}
				case "ApplReqID":
				{
					value = ApplReqID;
					break;
				}
				case "ApplReqType":
				{
					value = ApplReqType;
					break;
				}
				case "ApplResponseType":
				{
					value = ApplResponseType;
					break;
				}
				case "ApplTotalMessageCount":
				{
					value = ApplTotalMessageCount;
					break;
				}
				case "ApplIDRequestAckGrp":
				{
					value = ApplIDRequestAckGrp;
					break;
				}
				case "Parties":
				{
					value = Parties;
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
			ApplResponseID = null;
			ApplReqID = null;
			ApplReqType = null;
			ApplResponseType = null;
			ApplTotalMessageCount = null;
			((IFixReset?)ApplIDRequestAckGrp)?.Reset();
			((IFixReset?)Parties)?.Reset();
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
