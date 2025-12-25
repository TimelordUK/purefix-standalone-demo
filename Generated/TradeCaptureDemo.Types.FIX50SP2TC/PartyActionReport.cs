using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("DI", FixVersion.FIX50SP2)]
	public sealed partial class PartyActionReport : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 2400, Type = TagType.LocalDate, Offset = 1, Required = false)]
		public DateOnly? EffectiveBusinessDate {get; set;}
		
		[TagDetails(Tag = 2328, Type = TagType.String, Offset = 2, Required = false)]
		public string? PartyActionRequestID {get; set;}
		
		[TagDetails(Tag = 2331, Type = TagType.String, Offset = 3, Required = true)]
		public string? PartyActionReportID {get; set;}
		
		[TagDetails(Tag = 2329, Type = TagType.Int, Offset = 4, Required = true)]
		public int? PartyActionType {get; set;}
		
		[TagDetails(Tag = 2332, Type = TagType.Int, Offset = 5, Required = true)]
		public int? PartyActionResponse {get; set;}
		
		[TagDetails(Tag = 2333, Type = TagType.Int, Offset = 6, Required = false)]
		public int? PartyActionRejectReason {get; set;}
		
		[TagDetails(Tag = 2330, Type = TagType.Boolean, Offset = 7, Required = false)]
		public bool? ApplTestMessageIndicator {get; set;}
		
		[TagDetails(Tag = 1328, Type = TagType.String, Offset = 8, Required = false)]
		public string? RejectText {get; set;}
		
		[TagDetails(Tag = 1664, Type = TagType.Length, Offset = 9, Required = false)]
		public int? EncodedRejectTextLen {get; set;}
		
		[TagDetails(Tag = 1665, Type = TagType.RawData, Offset = 10, Required = false)]
		public byte[]? EncodedRejectText {get; set;}
		
		[TagDetails(Tag = 1301, Type = TagType.String, Offset = 11, Required = false)]
		public string? MarketID {get; set;}
		
		[TagDetails(Tag = 1300, Type = TagType.String, Offset = 12, Required = false)]
		public string? MarketSegmentID {get; set;}
		
		[Component(Offset = 13, Required = false)]
		public InstrumentScope? InstrumentScope {get; set;}
		
		[Component(Offset = 14, Required = false)]
		public RequestingPartyGrp? RequestingPartyGrp {get; set;}
		
		[Component(Offset = 15, Required = true)]
		public Parties? Parties {get; set;}
		
		[Component(Offset = 16, Required = false)]
		public RelatedPartyDetailGrp? RelatedPartyDetailGrp {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 17, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 18, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 19, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 20, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[TagDetails(Tag = 797, Type = TagType.Boolean, Offset = 21, Required = false)]
		public bool? CopyMsgIndicator {get; set;}
		
		[Component(Offset = 22, Required = true)]
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
			if (EffectiveBusinessDate is not null) writer.WriteLocalDateOnly(2400, EffectiveBusinessDate.Value);
			if (PartyActionRequestID is not null) writer.WriteString(2328, PartyActionRequestID);
			if (PartyActionReportID is not null) writer.WriteString(2331, PartyActionReportID);
			if (PartyActionType is not null) writer.WriteWholeNumber(2329, PartyActionType.Value);
			if (PartyActionResponse is not null) writer.WriteWholeNumber(2332, PartyActionResponse.Value);
			if (PartyActionRejectReason is not null) writer.WriteWholeNumber(2333, PartyActionRejectReason.Value);
			if (ApplTestMessageIndicator is not null) writer.WriteBoolean(2330, ApplTestMessageIndicator.Value);
			if (RejectText is not null) writer.WriteString(1328, RejectText);
			if (EncodedRejectTextLen is not null) writer.WriteWholeNumber(1664, EncodedRejectTextLen.Value);
			if (EncodedRejectText is not null) writer.WriteBuffer(1665, EncodedRejectText);
			if (MarketID is not null) writer.WriteString(1301, MarketID);
			if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
			if (InstrumentScope is not null) ((IFixEncoder)InstrumentScope).Encode(writer);
			if (RequestingPartyGrp is not null) ((IFixEncoder)RequestingPartyGrp).Encode(writer);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (RelatedPartyDetailGrp is not null) ((IFixEncoder)RelatedPartyDetailGrp).Encode(writer);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (Text is not null) writer.WriteString(58, Text);
			if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
			if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
			if (CopyMsgIndicator is not null) writer.WriteBoolean(797, CopyMsgIndicator.Value);
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
			EffectiveBusinessDate = view.GetDateOnly(2400);
			PartyActionRequestID = view.GetString(2328);
			PartyActionReportID = view.GetString(2331);
			PartyActionType = view.GetInt32(2329);
			PartyActionResponse = view.GetInt32(2332);
			PartyActionRejectReason = view.GetInt32(2333);
			ApplTestMessageIndicator = view.GetBool(2330);
			RejectText = view.GetString(1328);
			EncodedRejectTextLen = view.GetInt32(1664);
			EncodedRejectText = view.GetByteArray(1665);
			MarketID = view.GetString(1301);
			MarketSegmentID = view.GetString(1300);
			if (view.GetView("InstrumentScope") is IMessageView viewInstrumentScope)
			{
				InstrumentScope = new();
				((IFixParser)InstrumentScope).Parse(viewInstrumentScope);
			}
			if (view.GetView("RequestingPartyGrp") is IMessageView viewRequestingPartyGrp)
			{
				RequestingPartyGrp = new();
				((IFixParser)RequestingPartyGrp).Parse(viewRequestingPartyGrp);
			}
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			if (view.GetView("RelatedPartyDetailGrp") is IMessageView viewRelatedPartyDetailGrp)
			{
				RelatedPartyDetailGrp = new();
				((IFixParser)RelatedPartyDetailGrp).Parse(viewRelatedPartyDetailGrp);
			}
			TransactTime = view.GetDateTime(60);
			Text = view.GetString(58);
			EncodedTextLen = view.GetInt32(354);
			EncodedText = view.GetByteArray(355);
			CopyMsgIndicator = view.GetBool(797);
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
				case "EffectiveBusinessDate":
				{
					value = EffectiveBusinessDate;
					break;
				}
				case "PartyActionRequestID":
				{
					value = PartyActionRequestID;
					break;
				}
				case "PartyActionReportID":
				{
					value = PartyActionReportID;
					break;
				}
				case "PartyActionType":
				{
					value = PartyActionType;
					break;
				}
				case "PartyActionResponse":
				{
					value = PartyActionResponse;
					break;
				}
				case "PartyActionRejectReason":
				{
					value = PartyActionRejectReason;
					break;
				}
				case "ApplTestMessageIndicator":
				{
					value = ApplTestMessageIndicator;
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
				case "MarketID":
				{
					value = MarketID;
					break;
				}
				case "MarketSegmentID":
				{
					value = MarketSegmentID;
					break;
				}
				case "InstrumentScope":
				{
					value = InstrumentScope;
					break;
				}
				case "RequestingPartyGrp":
				{
					value = RequestingPartyGrp;
					break;
				}
				case "Parties":
				{
					value = Parties;
					break;
				}
				case "RelatedPartyDetailGrp":
				{
					value = RelatedPartyDetailGrp;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
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
				case "CopyMsgIndicator":
				{
					value = CopyMsgIndicator;
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
			EffectiveBusinessDate = null;
			PartyActionRequestID = null;
			PartyActionReportID = null;
			PartyActionType = null;
			PartyActionResponse = null;
			PartyActionRejectReason = null;
			ApplTestMessageIndicator = null;
			RejectText = null;
			EncodedRejectTextLen = null;
			EncodedRejectText = null;
			MarketID = null;
			MarketSegmentID = null;
			((IFixReset?)InstrumentScope)?.Reset();
			((IFixReset?)RequestingPartyGrp)?.Reset();
			((IFixReset?)Parties)?.Reset();
			((IFixReset?)RelatedPartyDetailGrp)?.Reset();
			TransactTime = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			CopyMsgIndicator = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
