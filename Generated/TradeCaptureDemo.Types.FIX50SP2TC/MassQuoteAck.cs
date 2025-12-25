using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("b", FixVersion.FIX50SP2)]
	public sealed partial class MassQuoteAck : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 131, Type = TagType.String, Offset = 1, Required = false)]
		public string? QuoteReqID {get; set;}
		
		[TagDetails(Tag = 117, Type = TagType.String, Offset = 2, Required = false)]
		public string? QuoteID {get; set;}
		
		[TagDetails(Tag = 297, Type = TagType.Int, Offset = 3, Required = true)]
		public int? QuoteStatus {get; set;}
		
		[TagDetails(Tag = 300, Type = TagType.Int, Offset = 4, Required = false)]
		public int? QuoteRejectReason {get; set;}
		
		[TagDetails(Tag = 301, Type = TagType.Int, Offset = 5, Required = false)]
		public int? QuoteResponseLevel {get; set;}
		
		[TagDetails(Tag = 537, Type = TagType.Int, Offset = 6, Required = false)]
		public int? QuoteType {get; set;}
		
		[TagDetails(Tag = 298, Type = TagType.Int, Offset = 7, Required = false)]
		public int? QuoteCancelType {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public Parties? Parties {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public TargetParties? TargetParties {get; set;}
		
		[TagDetails(Tag = 1, Type = TagType.String, Offset = 10, Required = false)]
		public string? Account {get; set;}
		
		[TagDetails(Tag = 660, Type = TagType.Int, Offset = 11, Required = false)]
		public int? AcctIDSource {get; set;}
		
		[TagDetails(Tag = 581, Type = TagType.Int, Offset = 12, Required = false)]
		public int? AccountType {get; set;}
		
		[TagDetails(Tag = 376, Type = TagType.String, Offset = 13, Required = false)]
		public string? ComplianceID {get; set;}
		
		[TagDetails(Tag = 2404, Type = TagType.String, Offset = 14, Required = false)]
		public string? ComplianceText {get; set;}
		
		[TagDetails(Tag = 2351, Type = TagType.Length, Offset = 15, Required = false)]
		public int? EncodedComplianceTextLen {get; set;}
		
		[TagDetails(Tag = 2352, Type = TagType.RawData, Offset = 16, Required = false)]
		public byte[]? EncodedComplianceText {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 17, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 18, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 19, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 20, Required = false)]
		public QuotSetAckGrp? QuotSetAckGrp {get; set;}
		
		[Component(Offset = 21, Required = false)]
		public ThrottleResponse? ThrottleResponse {get; set;}
		
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
			if (QuoteReqID is not null) writer.WriteString(131, QuoteReqID);
			if (QuoteID is not null) writer.WriteString(117, QuoteID);
			if (QuoteStatus is not null) writer.WriteWholeNumber(297, QuoteStatus.Value);
			if (QuoteRejectReason is not null) writer.WriteWholeNumber(300, QuoteRejectReason.Value);
			if (QuoteResponseLevel is not null) writer.WriteWholeNumber(301, QuoteResponseLevel.Value);
			if (QuoteType is not null) writer.WriteWholeNumber(537, QuoteType.Value);
			if (QuoteCancelType is not null) writer.WriteWholeNumber(298, QuoteCancelType.Value);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (TargetParties is not null) ((IFixEncoder)TargetParties).Encode(writer);
			if (Account is not null) writer.WriteString(1, Account);
			if (AcctIDSource is not null) writer.WriteWholeNumber(660, AcctIDSource.Value);
			if (AccountType is not null) writer.WriteWholeNumber(581, AccountType.Value);
			if (ComplianceID is not null) writer.WriteString(376, ComplianceID);
			if (ComplianceText is not null) writer.WriteString(2404, ComplianceText);
			if (EncodedComplianceTextLen is not null) writer.WriteWholeNumber(2351, EncodedComplianceTextLen.Value);
			if (EncodedComplianceText is not null) writer.WriteBuffer(2352, EncodedComplianceText);
			if (Text is not null) writer.WriteString(58, Text);
			if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
			if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
			if (QuotSetAckGrp is not null) ((IFixEncoder)QuotSetAckGrp).Encode(writer);
			if (ThrottleResponse is not null) ((IFixEncoder)ThrottleResponse).Encode(writer);
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
			QuoteID = view.GetString(117);
			QuoteStatus = view.GetInt32(297);
			QuoteRejectReason = view.GetInt32(300);
			QuoteResponseLevel = view.GetInt32(301);
			QuoteType = view.GetInt32(537);
			QuoteCancelType = view.GetInt32(298);
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
			Account = view.GetString(1);
			AcctIDSource = view.GetInt32(660);
			AccountType = view.GetInt32(581);
			ComplianceID = view.GetString(376);
			ComplianceText = view.GetString(2404);
			EncodedComplianceTextLen = view.GetInt32(2351);
			EncodedComplianceText = view.GetByteArray(2352);
			Text = view.GetString(58);
			EncodedTextLen = view.GetInt32(354);
			EncodedText = view.GetByteArray(355);
			if (view.GetView("QuotSetAckGrp") is IMessageView viewQuotSetAckGrp)
			{
				QuotSetAckGrp = new();
				((IFixParser)QuotSetAckGrp).Parse(viewQuotSetAckGrp);
			}
			if (view.GetView("ThrottleResponse") is IMessageView viewThrottleResponse)
			{
				ThrottleResponse = new();
				((IFixParser)ThrottleResponse).Parse(viewThrottleResponse);
			}
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
				case "QuoteID":
				{
					value = QuoteID;
					break;
				}
				case "QuoteStatus":
				{
					value = QuoteStatus;
					break;
				}
				case "QuoteRejectReason":
				{
					value = QuoteRejectReason;
					break;
				}
				case "QuoteResponseLevel":
				{
					value = QuoteResponseLevel;
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
				case "Account":
				{
					value = Account;
					break;
				}
				case "AcctIDSource":
				{
					value = AcctIDSource;
					break;
				}
				case "AccountType":
				{
					value = AccountType;
					break;
				}
				case "ComplianceID":
				{
					value = ComplianceID;
					break;
				}
				case "ComplianceText":
				{
					value = ComplianceText;
					break;
				}
				case "EncodedComplianceTextLen":
				{
					value = EncodedComplianceTextLen;
					break;
				}
				case "EncodedComplianceText":
				{
					value = EncodedComplianceText;
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
				case "QuotSetAckGrp":
				{
					value = QuotSetAckGrp;
					break;
				}
				case "ThrottleResponse":
				{
					value = ThrottleResponse;
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
			QuoteID = null;
			QuoteStatus = null;
			QuoteRejectReason = null;
			QuoteResponseLevel = null;
			QuoteType = null;
			QuoteCancelType = null;
			((IFixReset?)Parties)?.Reset();
			((IFixReset?)TargetParties)?.Reset();
			Account = null;
			AcctIDSource = null;
			AccountType = null;
			ComplianceID = null;
			ComplianceText = null;
			EncodedComplianceTextLen = null;
			EncodedComplianceText = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)QuotSetAckGrp)?.Reset();
			((IFixReset?)ThrottleResponse)?.Reset();
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
