using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("DJ", FixVersion.FIX50SP2)]
	public sealed partial class MassOrder : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 2423, Type = TagType.String, Offset = 1, Required = true)]
		public string? MassOrderRequestID {get; set;}
		
		[TagDetails(Tag = 2427, Type = TagType.Int, Offset = 2, Required = false)]
		public int? OrderResponseLevel {get; set;}
		
		[TagDetails(Tag = 1301, Type = TagType.String, Offset = 3, Required = false)]
		public string? MarketID {get; set;}
		
		[TagDetails(Tag = 1300, Type = TagType.String, Offset = 4, Required = false)]
		public string? MarketSegmentID {get; set;}
		
		[Component(Offset = 5, Required = false)]
		public Parties? Parties {get; set;}
		
		[TagDetails(Tag = 1815, Type = TagType.Int, Offset = 6, Required = false)]
		public int? TradingCapacity {get; set;}
		
		[TagDetails(Tag = 1816, Type = TagType.Int, Offset = 7, Required = false)]
		public int? ClearingAccountType {get; set;}
		
		[TagDetails(Tag = 1, Type = TagType.String, Offset = 8, Required = false)]
		public string? Account {get; set;}
		
		[TagDetails(Tag = 660, Type = TagType.Int, Offset = 9, Required = false)]
		public int? AcctIDSource {get; set;}
		
		[TagDetails(Tag = 581, Type = TagType.Int, Offset = 10, Required = false)]
		public int? AccountType {get; set;}
		
		[TagDetails(Tag = 528, Type = TagType.String, Offset = 11, Required = false)]
		public string? OrderCapacity {get; set;}
		
		[TagDetails(Tag = 529, Type = TagType.String, Offset = 12, Required = false)]
		public string? OrderRestrictions {get; set;}
		
		[TagDetails(Tag = 582, Type = TagType.Int, Offset = 13, Required = false)]
		public int? CustOrderCapacity {get; set;}
		
		[TagDetails(Tag = 1028, Type = TagType.Boolean, Offset = 14, Required = false)]
		public bool? ManualOrderIndicator {get; set;}
		
		[TagDetails(Tag = 1031, Type = TagType.String, Offset = 15, Required = false)]
		public string? CustOrderHandlingInst {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 16, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 17, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 18, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 19, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[TagDetails(Tag = 1685, Type = TagType.Int, Offset = 20, Required = false)]
		public int? ThrottleInst {get; set;}
		
		[TagDetails(Tag = 2432, Type = TagType.Int, Offset = 21, Required = false)]
		public int? TotNoOrderEntries {get; set;}
		
		[TagDetails(Tag = 893, Type = TagType.Boolean, Offset = 22, Required = false)]
		public bool? LastFragment {get; set;}
		
		[Component(Offset = 23, Required = true)]
		public OrderEntryGrp? OrderEntryGrp {get; set;}
		
		[Component(Offset = 24, Required = true)]
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
			if (MassOrderRequestID is not null) writer.WriteString(2423, MassOrderRequestID);
			if (OrderResponseLevel is not null) writer.WriteWholeNumber(2427, OrderResponseLevel.Value);
			if (MarketID is not null) writer.WriteString(1301, MarketID);
			if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (TradingCapacity is not null) writer.WriteWholeNumber(1815, TradingCapacity.Value);
			if (ClearingAccountType is not null) writer.WriteWholeNumber(1816, ClearingAccountType.Value);
			if (Account is not null) writer.WriteString(1, Account);
			if (AcctIDSource is not null) writer.WriteWholeNumber(660, AcctIDSource.Value);
			if (AccountType is not null) writer.WriteWholeNumber(581, AccountType.Value);
			if (OrderCapacity is not null) writer.WriteString(528, OrderCapacity);
			if (OrderRestrictions is not null) writer.WriteString(529, OrderRestrictions);
			if (CustOrderCapacity is not null) writer.WriteWholeNumber(582, CustOrderCapacity.Value);
			if (ManualOrderIndicator is not null) writer.WriteBoolean(1028, ManualOrderIndicator.Value);
			if (CustOrderHandlingInst is not null) writer.WriteString(1031, CustOrderHandlingInst);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (Text is not null) writer.WriteString(58, Text);
			if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
			if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
			if (ThrottleInst is not null) writer.WriteWholeNumber(1685, ThrottleInst.Value);
			if (TotNoOrderEntries is not null) writer.WriteWholeNumber(2432, TotNoOrderEntries.Value);
			if (LastFragment is not null) writer.WriteBoolean(893, LastFragment.Value);
			if (OrderEntryGrp is not null) ((IFixEncoder)OrderEntryGrp).Encode(writer);
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
			MassOrderRequestID = view.GetString(2423);
			OrderResponseLevel = view.GetInt32(2427);
			MarketID = view.GetString(1301);
			MarketSegmentID = view.GetString(1300);
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			TradingCapacity = view.GetInt32(1815);
			ClearingAccountType = view.GetInt32(1816);
			Account = view.GetString(1);
			AcctIDSource = view.GetInt32(660);
			AccountType = view.GetInt32(581);
			OrderCapacity = view.GetString(528);
			OrderRestrictions = view.GetString(529);
			CustOrderCapacity = view.GetInt32(582);
			ManualOrderIndicator = view.GetBool(1028);
			CustOrderHandlingInst = view.GetString(1031);
			TransactTime = view.GetDateTime(60);
			Text = view.GetString(58);
			EncodedTextLen = view.GetInt32(354);
			EncodedText = view.GetByteArray(355);
			ThrottleInst = view.GetInt32(1685);
			TotNoOrderEntries = view.GetInt32(2432);
			LastFragment = view.GetBool(893);
			if (view.GetView("OrderEntryGrp") is IMessageView viewOrderEntryGrp)
			{
				OrderEntryGrp = new();
				((IFixParser)OrderEntryGrp).Parse(viewOrderEntryGrp);
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
				case "MassOrderRequestID":
				{
					value = MassOrderRequestID;
					break;
				}
				case "OrderResponseLevel":
				{
					value = OrderResponseLevel;
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
				case "Parties":
				{
					value = Parties;
					break;
				}
				case "TradingCapacity":
				{
					value = TradingCapacity;
					break;
				}
				case "ClearingAccountType":
				{
					value = ClearingAccountType;
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
				case "OrderCapacity":
				{
					value = OrderCapacity;
					break;
				}
				case "OrderRestrictions":
				{
					value = OrderRestrictions;
					break;
				}
				case "CustOrderCapacity":
				{
					value = CustOrderCapacity;
					break;
				}
				case "ManualOrderIndicator":
				{
					value = ManualOrderIndicator;
					break;
				}
				case "CustOrderHandlingInst":
				{
					value = CustOrderHandlingInst;
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
				case "ThrottleInst":
				{
					value = ThrottleInst;
					break;
				}
				case "TotNoOrderEntries":
				{
					value = TotNoOrderEntries;
					break;
				}
				case "LastFragment":
				{
					value = LastFragment;
					break;
				}
				case "OrderEntryGrp":
				{
					value = OrderEntryGrp;
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
			MassOrderRequestID = null;
			OrderResponseLevel = null;
			MarketID = null;
			MarketSegmentID = null;
			((IFixReset?)Parties)?.Reset();
			TradingCapacity = null;
			ClearingAccountType = null;
			Account = null;
			AcctIDSource = null;
			AccountType = null;
			OrderCapacity = null;
			OrderRestrictions = null;
			CustOrderCapacity = null;
			ManualOrderIndicator = null;
			CustOrderHandlingInst = null;
			TransactTime = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			ThrottleInst = null;
			TotNoOrderEntries = null;
			LastFragment = null;
			((IFixReset?)OrderEntryGrp)?.Reset();
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
