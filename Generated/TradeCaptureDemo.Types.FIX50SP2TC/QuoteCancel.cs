using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("Z", FixVersion.FIX50SP2)]
	public sealed partial class QuoteCancel : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 131, Type = TagType.String, Offset = 1, Required = false)]
		public string? QuoteReqID {get; set;}
		
		[TagDetails(Tag = 117, Type = TagType.String, Offset = 2, Required = false)]
		public string? QuoteID {get; set;}
		
		[TagDetails(Tag = 1751, Type = TagType.String, Offset = 3, Required = false)]
		public string? SecondaryQuoteID {get; set;}
		
		[TagDetails(Tag = 1166, Type = TagType.String, Offset = 4, Required = false)]
		public string? QuoteMsgID {get; set;}
		
		[TagDetails(Tag = 298, Type = TagType.Int, Offset = 5, Required = true)]
		public int? QuoteCancelType {get; set;}
		
		[TagDetails(Tag = 537, Type = TagType.Int, Offset = 6, Required = false)]
		public int? QuoteType {get; set;}
		
		[TagDetails(Tag = 301, Type = TagType.Int, Offset = 7, Required = false)]
		public int? QuoteResponseLevel {get; set;}
		
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
		
		[TagDetails(Tag = 336, Type = TagType.String, Offset = 13, Required = false)]
		public string? TradingSessionID {get; set;}
		
		[TagDetails(Tag = 625, Type = TagType.String, Offset = 14, Required = false)]
		public string? TradingSessionSubID {get; set;}
		
		[Component(Offset = 15, Required = false)]
		public QuotCxlEntriesGrp? QuotCxlEntriesGrp {get; set;}
		
		[Component(Offset = 16, Required = true)]
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
			if (SecondaryQuoteID is not null) writer.WriteString(1751, SecondaryQuoteID);
			if (QuoteMsgID is not null) writer.WriteString(1166, QuoteMsgID);
			if (QuoteCancelType is not null) writer.WriteWholeNumber(298, QuoteCancelType.Value);
			if (QuoteType is not null) writer.WriteWholeNumber(537, QuoteType.Value);
			if (QuoteResponseLevel is not null) writer.WriteWholeNumber(301, QuoteResponseLevel.Value);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (TargetParties is not null) ((IFixEncoder)TargetParties).Encode(writer);
			if (Account is not null) writer.WriteString(1, Account);
			if (AcctIDSource is not null) writer.WriteWholeNumber(660, AcctIDSource.Value);
			if (AccountType is not null) writer.WriteWholeNumber(581, AccountType.Value);
			if (TradingSessionID is not null) writer.WriteString(336, TradingSessionID);
			if (TradingSessionSubID is not null) writer.WriteString(625, TradingSessionSubID);
			if (QuotCxlEntriesGrp is not null) ((IFixEncoder)QuotCxlEntriesGrp).Encode(writer);
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
			SecondaryQuoteID = view.GetString(1751);
			QuoteMsgID = view.GetString(1166);
			QuoteCancelType = view.GetInt32(298);
			QuoteType = view.GetInt32(537);
			QuoteResponseLevel = view.GetInt32(301);
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
			TradingSessionID = view.GetString(336);
			TradingSessionSubID = view.GetString(625);
			if (view.GetView("QuotCxlEntriesGrp") is IMessageView viewQuotCxlEntriesGrp)
			{
				QuotCxlEntriesGrp = new();
				((IFixParser)QuotCxlEntriesGrp).Parse(viewQuotCxlEntriesGrp);
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
				case "SecondaryQuoteID":
				{
					value = SecondaryQuoteID;
					break;
				}
				case "QuoteMsgID":
				{
					value = QuoteMsgID;
					break;
				}
				case "QuoteCancelType":
				{
					value = QuoteCancelType;
					break;
				}
				case "QuoteType":
				{
					value = QuoteType;
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
				case "TradingSessionID":
				{
					value = TradingSessionID;
					break;
				}
				case "TradingSessionSubID":
				{
					value = TradingSessionSubID;
					break;
				}
				case "QuotCxlEntriesGrp":
				{
					value = QuotCxlEntriesGrp;
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
			SecondaryQuoteID = null;
			QuoteMsgID = null;
			QuoteCancelType = null;
			QuoteType = null;
			QuoteResponseLevel = null;
			((IFixReset?)Parties)?.Reset();
			((IFixReset?)TargetParties)?.Reset();
			Account = null;
			AcctIDSource = null;
			AccountType = null;
			TradingSessionID = null;
			TradingSessionSubID = null;
			((IFixReset?)QuotCxlEntriesGrp)?.Reset();
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
