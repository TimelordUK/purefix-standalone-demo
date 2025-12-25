using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("F", FixVersion.FIX50SP2)]
	public sealed partial class OrderCancelRequest : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 2422, Type = TagType.Int, Offset = 1, Required = false)]
		public int? OrderRequestID {get; set;}
		
		[TagDetails(Tag = 41, Type = TagType.String, Offset = 2, Required = false)]
		public string? OrigClOrdID {get; set;}
		
		[TagDetails(Tag = 37, Type = TagType.String, Offset = 3, Required = false)]
		public string? OrderID {get; set;}
		
		[TagDetails(Tag = 11, Type = TagType.String, Offset = 4, Required = true)]
		public string? ClOrdID {get; set;}
		
		[TagDetails(Tag = 526, Type = TagType.String, Offset = 5, Required = false)]
		public string? SecondaryClOrdID {get; set;}
		
		[TagDetails(Tag = 583, Type = TagType.String, Offset = 6, Required = false)]
		public string? ClOrdLinkID {get; set;}
		
		[TagDetails(Tag = 66, Type = TagType.String, Offset = 7, Required = false)]
		public string? ListID {get; set;}
		
		[TagDetails(Tag = 586, Type = TagType.UtcTimestamp, Offset = 8, Required = false)]
		public DateTime? OrigOrdModTime {get; set;}
		
		[TagDetails(Tag = 1, Type = TagType.String, Offset = 9, Required = false)]
		public string? Account {get; set;}
		
		[TagDetails(Tag = 660, Type = TagType.Int, Offset = 10, Required = false)]
		public int? AcctIDSource {get; set;}
		
		[TagDetails(Tag = 581, Type = TagType.Int, Offset = 11, Required = false)]
		public int? AccountType {get; set;}
		
		[Component(Offset = 12, Required = false)]
		public Parties? Parties {get; set;}
		
		[Component(Offset = 13, Required = true)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 14, Required = false)]
		public FinancingDetails? FinancingDetails {get; set;}
		
		[Component(Offset = 15, Required = false)]
		public UndInstrmtGrp? UndInstrmtGrp {get; set;}
		
		[TagDetails(Tag = 1300, Type = TagType.String, Offset = 16, Required = false)]
		public string? MarketSegmentID {get; set;}
		
		[TagDetails(Tag = 100, Type = TagType.String, Offset = 17, Required = false)]
		public string? ExDestination {get; set;}
		
		[TagDetails(Tag = 1133, Type = TagType.String, Offset = 18, Required = false)]
		public string? ExDestinationIDSource {get; set;}
		
		[TagDetails(Tag = 54, Type = TagType.String, Offset = 19, Required = true)]
		public string? Side {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 20, Required = true)]
		public DateTime? TransactTime {get; set;}
		
		[Component(Offset = 21, Required = false)]
		public OrderQtyData? OrderQtyData {get; set;}
		
		[TagDetails(Tag = 376, Type = TagType.String, Offset = 22, Required = false)]
		public string? ComplianceID {get; set;}
		
		[TagDetails(Tag = 2404, Type = TagType.String, Offset = 23, Required = false)]
		public string? ComplianceText {get; set;}
		
		[TagDetails(Tag = 2351, Type = TagType.Length, Offset = 24, Required = false)]
		public int? EncodedComplianceTextLen {get; set;}
		
		[TagDetails(Tag = 2352, Type = TagType.RawData, Offset = 25, Required = false)]
		public byte[]? EncodedComplianceText {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 26, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 27, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 28, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 29, Required = true)]
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
			if (OrderRequestID is not null) writer.WriteWholeNumber(2422, OrderRequestID.Value);
			if (OrigClOrdID is not null) writer.WriteString(41, OrigClOrdID);
			if (OrderID is not null) writer.WriteString(37, OrderID);
			if (ClOrdID is not null) writer.WriteString(11, ClOrdID);
			if (SecondaryClOrdID is not null) writer.WriteString(526, SecondaryClOrdID);
			if (ClOrdLinkID is not null) writer.WriteString(583, ClOrdLinkID);
			if (ListID is not null) writer.WriteString(66, ListID);
			if (OrigOrdModTime is not null) writer.WriteUtcTimeStamp(586, OrigOrdModTime.Value);
			if (Account is not null) writer.WriteString(1, Account);
			if (AcctIDSource is not null) writer.WriteWholeNumber(660, AcctIDSource.Value);
			if (AccountType is not null) writer.WriteWholeNumber(581, AccountType.Value);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (FinancingDetails is not null) ((IFixEncoder)FinancingDetails).Encode(writer);
			if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
			if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
			if (ExDestination is not null) writer.WriteString(100, ExDestination);
			if (ExDestinationIDSource is not null) writer.WriteString(1133, ExDestinationIDSource);
			if (Side is not null) writer.WriteString(54, Side);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (OrderQtyData is not null) ((IFixEncoder)OrderQtyData).Encode(writer);
			if (ComplianceID is not null) writer.WriteString(376, ComplianceID);
			if (ComplianceText is not null) writer.WriteString(2404, ComplianceText);
			if (EncodedComplianceTextLen is not null) writer.WriteWholeNumber(2351, EncodedComplianceTextLen.Value);
			if (EncodedComplianceText is not null) writer.WriteBuffer(2352, EncodedComplianceText);
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
			OrderRequestID = view.GetInt32(2422);
			OrigClOrdID = view.GetString(41);
			OrderID = view.GetString(37);
			ClOrdID = view.GetString(11);
			SecondaryClOrdID = view.GetString(526);
			ClOrdLinkID = view.GetString(583);
			ListID = view.GetString(66);
			OrigOrdModTime = view.GetDateTime(586);
			Account = view.GetString(1);
			AcctIDSource = view.GetInt32(660);
			AccountType = view.GetInt32(581);
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			if (view.GetView("Instrument") is IMessageView viewInstrument)
			{
				Instrument = new();
				((IFixParser)Instrument).Parse(viewInstrument);
			}
			if (view.GetView("FinancingDetails") is IMessageView viewFinancingDetails)
			{
				FinancingDetails = new();
				((IFixParser)FinancingDetails).Parse(viewFinancingDetails);
			}
			if (view.GetView("UndInstrmtGrp") is IMessageView viewUndInstrmtGrp)
			{
				UndInstrmtGrp = new();
				((IFixParser)UndInstrmtGrp).Parse(viewUndInstrmtGrp);
			}
			MarketSegmentID = view.GetString(1300);
			ExDestination = view.GetString(100);
			ExDestinationIDSource = view.GetString(1133);
			Side = view.GetString(54);
			TransactTime = view.GetDateTime(60);
			if (view.GetView("OrderQtyData") is IMessageView viewOrderQtyData)
			{
				OrderQtyData = new();
				((IFixParser)OrderQtyData).Parse(viewOrderQtyData);
			}
			ComplianceID = view.GetString(376);
			ComplianceText = view.GetString(2404);
			EncodedComplianceTextLen = view.GetInt32(2351);
			EncodedComplianceText = view.GetByteArray(2352);
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
				case "OrderRequestID":
				{
					value = OrderRequestID;
					break;
				}
				case "OrigClOrdID":
				{
					value = OrigClOrdID;
					break;
				}
				case "OrderID":
				{
					value = OrderID;
					break;
				}
				case "ClOrdID":
				{
					value = ClOrdID;
					break;
				}
				case "SecondaryClOrdID":
				{
					value = SecondaryClOrdID;
					break;
				}
				case "ClOrdLinkID":
				{
					value = ClOrdLinkID;
					break;
				}
				case "ListID":
				{
					value = ListID;
					break;
				}
				case "OrigOrdModTime":
				{
					value = OrigOrdModTime;
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
				case "Parties":
				{
					value = Parties;
					break;
				}
				case "Instrument":
				{
					value = Instrument;
					break;
				}
				case "FinancingDetails":
				{
					value = FinancingDetails;
					break;
				}
				case "UndInstrmtGrp":
				{
					value = UndInstrmtGrp;
					break;
				}
				case "MarketSegmentID":
				{
					value = MarketSegmentID;
					break;
				}
				case "ExDestination":
				{
					value = ExDestination;
					break;
				}
				case "ExDestinationIDSource":
				{
					value = ExDestinationIDSource;
					break;
				}
				case "Side":
				{
					value = Side;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "OrderQtyData":
				{
					value = OrderQtyData;
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
			OrderRequestID = null;
			OrigClOrdID = null;
			OrderID = null;
			ClOrdID = null;
			SecondaryClOrdID = null;
			ClOrdLinkID = null;
			ListID = null;
			OrigOrdModTime = null;
			Account = null;
			AcctIDSource = null;
			AccountType = null;
			((IFixReset?)Parties)?.Reset();
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)FinancingDetails)?.Reset();
			((IFixReset?)UndInstrmtGrp)?.Reset();
			MarketSegmentID = null;
			ExDestination = null;
			ExDestinationIDSource = null;
			Side = null;
			TransactTime = null;
			((IFixReset?)OrderQtyData)?.Reset();
			ComplianceID = null;
			ComplianceText = null;
			EncodedComplianceTextLen = null;
			EncodedComplianceText = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
