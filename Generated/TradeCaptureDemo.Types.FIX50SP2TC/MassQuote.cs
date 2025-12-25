using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("i", FixVersion.FIX50SP2)]
	public sealed partial class MassQuote : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 131, Type = TagType.String, Offset = 1, Required = false)]
		public string? QuoteReqID {get; set;}
		
		[TagDetails(Tag = 117, Type = TagType.String, Offset = 2, Required = true)]
		public string? QuoteID {get; set;}
		
		[TagDetails(Tag = 537, Type = TagType.Int, Offset = 3, Required = false)]
		public int? QuoteType {get; set;}
		
		[TagDetails(Tag = 2403, Type = TagType.Int, Offset = 4, Required = false)]
		public int? QuoteModelType {get; set;}
		
		[TagDetails(Tag = 301, Type = TagType.Int, Offset = 5, Required = false)]
		public int? QuoteResponseLevel {get; set;}
		
		[Component(Offset = 6, Required = false)]
		public Parties? Parties {get; set;}
		
		[TagDetails(Tag = 1, Type = TagType.String, Offset = 7, Required = false)]
		public string? Account {get; set;}
		
		[TagDetails(Tag = 660, Type = TagType.Int, Offset = 8, Required = false)]
		public int? AcctIDSource {get; set;}
		
		[TagDetails(Tag = 581, Type = TagType.Int, Offset = 9, Required = false)]
		public int? AccountType {get; set;}
		
		[TagDetails(Tag = 293, Type = TagType.Float, Offset = 10, Required = false)]
		public double? DefBidSize {get; set;}
		
		[TagDetails(Tag = 294, Type = TagType.Float, Offset = 11, Required = false)]
		public double? DefOfferSize {get; set;}
		
		[Component(Offset = 12, Required = true)]
		public QuotSetGrp? QuotSetGrp {get; set;}
		
		[TagDetails(Tag = 2362, Type = TagType.String, Offset = 13, Required = false)]
		public string? SelfMatchPreventionID {get; set;}
		
		[TagDetails(Tag = 2964, Type = TagType.Int, Offset = 14, Required = false)]
		public int? SelfMatchPreventionInstruction {get; set;}
		
		[TagDetails(Tag = 1685, Type = TagType.Int, Offset = 15, Required = false)]
		public int? ThrottleInst {get; set;}
		
		[TagDetails(Tag = 376, Type = TagType.String, Offset = 16, Required = false)]
		public string? ComplianceID {get; set;}
		
		[TagDetails(Tag = 2404, Type = TagType.String, Offset = 17, Required = false)]
		public string? ComplianceText {get; set;}
		
		[TagDetails(Tag = 2351, Type = TagType.Length, Offset = 18, Required = false)]
		public int? EncodedComplianceTextLen {get; set;}
		
		[TagDetails(Tag = 2352, Type = TagType.RawData, Offset = 19, Required = false)]
		public byte[]? EncodedComplianceText {get; set;}
		
		[Component(Offset = 20, Required = true)]
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
			if (QuoteType is not null) writer.WriteWholeNumber(537, QuoteType.Value);
			if (QuoteModelType is not null) writer.WriteWholeNumber(2403, QuoteModelType.Value);
			if (QuoteResponseLevel is not null) writer.WriteWholeNumber(301, QuoteResponseLevel.Value);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (Account is not null) writer.WriteString(1, Account);
			if (AcctIDSource is not null) writer.WriteWholeNumber(660, AcctIDSource.Value);
			if (AccountType is not null) writer.WriteWholeNumber(581, AccountType.Value);
			if (DefBidSize is not null) writer.WriteNumber(293, DefBidSize.Value);
			if (DefOfferSize is not null) writer.WriteNumber(294, DefOfferSize.Value);
			if (QuotSetGrp is not null) ((IFixEncoder)QuotSetGrp).Encode(writer);
			if (SelfMatchPreventionID is not null) writer.WriteString(2362, SelfMatchPreventionID);
			if (SelfMatchPreventionInstruction is not null) writer.WriteWholeNumber(2964, SelfMatchPreventionInstruction.Value);
			if (ThrottleInst is not null) writer.WriteWholeNumber(1685, ThrottleInst.Value);
			if (ComplianceID is not null) writer.WriteString(376, ComplianceID);
			if (ComplianceText is not null) writer.WriteString(2404, ComplianceText);
			if (EncodedComplianceTextLen is not null) writer.WriteWholeNumber(2351, EncodedComplianceTextLen.Value);
			if (EncodedComplianceText is not null) writer.WriteBuffer(2352, EncodedComplianceText);
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
			QuoteType = view.GetInt32(537);
			QuoteModelType = view.GetInt32(2403);
			QuoteResponseLevel = view.GetInt32(301);
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			Account = view.GetString(1);
			AcctIDSource = view.GetInt32(660);
			AccountType = view.GetInt32(581);
			DefBidSize = view.GetDouble(293);
			DefOfferSize = view.GetDouble(294);
			if (view.GetView("QuotSetGrp") is IMessageView viewQuotSetGrp)
			{
				QuotSetGrp = new();
				((IFixParser)QuotSetGrp).Parse(viewQuotSetGrp);
			}
			SelfMatchPreventionID = view.GetString(2362);
			SelfMatchPreventionInstruction = view.GetInt32(2964);
			ThrottleInst = view.GetInt32(1685);
			ComplianceID = view.GetString(376);
			ComplianceText = view.GetString(2404);
			EncodedComplianceTextLen = view.GetInt32(2351);
			EncodedComplianceText = view.GetByteArray(2352);
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
				case "QuoteType":
				{
					value = QuoteType;
					break;
				}
				case "QuoteModelType":
				{
					value = QuoteModelType;
					break;
				}
				case "QuoteResponseLevel":
				{
					value = QuoteResponseLevel;
					break;
				}
				case "Parties":
				{
					value = Parties;
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
				case "DefBidSize":
				{
					value = DefBidSize;
					break;
				}
				case "DefOfferSize":
				{
					value = DefOfferSize;
					break;
				}
				case "QuotSetGrp":
				{
					value = QuotSetGrp;
					break;
				}
				case "SelfMatchPreventionID":
				{
					value = SelfMatchPreventionID;
					break;
				}
				case "SelfMatchPreventionInstruction":
				{
					value = SelfMatchPreventionInstruction;
					break;
				}
				case "ThrottleInst":
				{
					value = ThrottleInst;
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
			QuoteType = null;
			QuoteModelType = null;
			QuoteResponseLevel = null;
			((IFixReset?)Parties)?.Reset();
			Account = null;
			AcctIDSource = null;
			AccountType = null;
			DefBidSize = null;
			DefOfferSize = null;
			((IFixReset?)QuotSetGrp)?.Reset();
			SelfMatchPreventionID = null;
			SelfMatchPreventionInstruction = null;
			ThrottleInst = null;
			ComplianceID = null;
			ComplianceText = null;
			EncodedComplianceTextLen = null;
			EncodedComplianceText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
