using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("k", FixVersion.FIX50SP2)]
	public sealed partial class BidRequest : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 390, Type = TagType.String, Offset = 1, Required = false)]
		public string? BidID {get; set;}
		
		[TagDetails(Tag = 391, Type = TagType.String, Offset = 2, Required = true)]
		public string? ClientBidID {get; set;}
		
		[TagDetails(Tag = 374, Type = TagType.String, Offset = 3, Required = true)]
		public string? BidRequestTransType {get; set;}
		
		[TagDetails(Tag = 392, Type = TagType.String, Offset = 4, Required = false)]
		public string? ListName {get; set;}
		
		[TagDetails(Tag = 393, Type = TagType.Int, Offset = 5, Required = true)]
		public int? TotNoRelatedSym {get; set;}
		
		[TagDetails(Tag = 394, Type = TagType.Int, Offset = 6, Required = true)]
		public int? BidType {get; set;}
		
		[TagDetails(Tag = 395, Type = TagType.Int, Offset = 7, Required = false)]
		public int? NumTickets {get; set;}
		
		[TagDetails(Tag = 15, Type = TagType.String, Offset = 8, Required = false)]
		public string? Currency {get; set;}
		
		[TagDetails(Tag = 2897, Type = TagType.String, Offset = 9, Required = false)]
		public string? CurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 396, Type = TagType.Float, Offset = 10, Required = false)]
		public double? SideValue1 {get; set;}
		
		[TagDetails(Tag = 397, Type = TagType.Float, Offset = 11, Required = false)]
		public double? SideValue2 {get; set;}
		
		[Component(Offset = 12, Required = false)]
		public BidDescReqGrp? BidDescReqGrp {get; set;}
		
		[Component(Offset = 13, Required = false)]
		public BidCompReqGrp? BidCompReqGrp {get; set;}
		
		[TagDetails(Tag = 409, Type = TagType.Int, Offset = 14, Required = false)]
		public int? LiquidityIndType {get; set;}
		
		[TagDetails(Tag = 410, Type = TagType.Float, Offset = 15, Required = false)]
		public double? WtAverageLiquidity {get; set;}
		
		[TagDetails(Tag = 411, Type = TagType.Boolean, Offset = 16, Required = false)]
		public bool? ExchangeForPhysical {get; set;}
		
		[TagDetails(Tag = 412, Type = TagType.Float, Offset = 17, Required = false)]
		public double? OutMainCntryUIndex {get; set;}
		
		[TagDetails(Tag = 413, Type = TagType.Float, Offset = 18, Required = false)]
		public double? CrossPercent {get; set;}
		
		[TagDetails(Tag = 414, Type = TagType.Int, Offset = 19, Required = false)]
		public int? ProgRptReqs {get; set;}
		
		[TagDetails(Tag = 415, Type = TagType.Int, Offset = 20, Required = false)]
		public int? ProgPeriodInterval {get; set;}
		
		[TagDetails(Tag = 416, Type = TagType.Int, Offset = 21, Required = false)]
		public int? IncTaxInd {get; set;}
		
		[TagDetails(Tag = 121, Type = TagType.Boolean, Offset = 22, Required = false)]
		public bool? ForexReq {get; set;}
		
		[TagDetails(Tag = 417, Type = TagType.Int, Offset = 23, Required = false)]
		public int? NumBidders {get; set;}
		
		[TagDetails(Tag = 75, Type = TagType.LocalDate, Offset = 24, Required = false)]
		public DateOnly? TradeDate {get; set;}
		
		[TagDetails(Tag = 418, Type = TagType.String, Offset = 25, Required = true)]
		public string? BidTradeType {get; set;}
		
		[TagDetails(Tag = 419, Type = TagType.String, Offset = 26, Required = true)]
		public string? BasisPxType {get; set;}
		
		[TagDetails(Tag = 443, Type = TagType.UtcTimestamp, Offset = 27, Required = false)]
		public DateTime? StrikeTime {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 28, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 29, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 30, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 31, Required = true)]
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
			if (BidID is not null) writer.WriteString(390, BidID);
			if (ClientBidID is not null) writer.WriteString(391, ClientBidID);
			if (BidRequestTransType is not null) writer.WriteString(374, BidRequestTransType);
			if (ListName is not null) writer.WriteString(392, ListName);
			if (TotNoRelatedSym is not null) writer.WriteWholeNumber(393, TotNoRelatedSym.Value);
			if (BidType is not null) writer.WriteWholeNumber(394, BidType.Value);
			if (NumTickets is not null) writer.WriteWholeNumber(395, NumTickets.Value);
			if (Currency is not null) writer.WriteString(15, Currency);
			if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
			if (SideValue1 is not null) writer.WriteNumber(396, SideValue1.Value);
			if (SideValue2 is not null) writer.WriteNumber(397, SideValue2.Value);
			if (BidDescReqGrp is not null) ((IFixEncoder)BidDescReqGrp).Encode(writer);
			if (BidCompReqGrp is not null) ((IFixEncoder)BidCompReqGrp).Encode(writer);
			if (LiquidityIndType is not null) writer.WriteWholeNumber(409, LiquidityIndType.Value);
			if (WtAverageLiquidity is not null) writer.WriteNumber(410, WtAverageLiquidity.Value);
			if (ExchangeForPhysical is not null) writer.WriteBoolean(411, ExchangeForPhysical.Value);
			if (OutMainCntryUIndex is not null) writer.WriteNumber(412, OutMainCntryUIndex.Value);
			if (CrossPercent is not null) writer.WriteNumber(413, CrossPercent.Value);
			if (ProgRptReqs is not null) writer.WriteWholeNumber(414, ProgRptReqs.Value);
			if (ProgPeriodInterval is not null) writer.WriteWholeNumber(415, ProgPeriodInterval.Value);
			if (IncTaxInd is not null) writer.WriteWholeNumber(416, IncTaxInd.Value);
			if (ForexReq is not null) writer.WriteBoolean(121, ForexReq.Value);
			if (NumBidders is not null) writer.WriteWholeNumber(417, NumBidders.Value);
			if (TradeDate is not null) writer.WriteLocalDateOnly(75, TradeDate.Value);
			if (BidTradeType is not null) writer.WriteString(418, BidTradeType);
			if (BasisPxType is not null) writer.WriteString(419, BasisPxType);
			if (StrikeTime is not null) writer.WriteUtcTimeStamp(443, StrikeTime.Value);
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
			BidID = view.GetString(390);
			ClientBidID = view.GetString(391);
			BidRequestTransType = view.GetString(374);
			ListName = view.GetString(392);
			TotNoRelatedSym = view.GetInt32(393);
			BidType = view.GetInt32(394);
			NumTickets = view.GetInt32(395);
			Currency = view.GetString(15);
			CurrencyCodeSource = view.GetString(2897);
			SideValue1 = view.GetDouble(396);
			SideValue2 = view.GetDouble(397);
			if (view.GetView("BidDescReqGrp") is IMessageView viewBidDescReqGrp)
			{
				BidDescReqGrp = new();
				((IFixParser)BidDescReqGrp).Parse(viewBidDescReqGrp);
			}
			if (view.GetView("BidCompReqGrp") is IMessageView viewBidCompReqGrp)
			{
				BidCompReqGrp = new();
				((IFixParser)BidCompReqGrp).Parse(viewBidCompReqGrp);
			}
			LiquidityIndType = view.GetInt32(409);
			WtAverageLiquidity = view.GetDouble(410);
			ExchangeForPhysical = view.GetBool(411);
			OutMainCntryUIndex = view.GetDouble(412);
			CrossPercent = view.GetDouble(413);
			ProgRptReqs = view.GetInt32(414);
			ProgPeriodInterval = view.GetInt32(415);
			IncTaxInd = view.GetInt32(416);
			ForexReq = view.GetBool(121);
			NumBidders = view.GetInt32(417);
			TradeDate = view.GetDateOnly(75);
			BidTradeType = view.GetString(418);
			BasisPxType = view.GetString(419);
			StrikeTime = view.GetDateTime(443);
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
				case "BidID":
				{
					value = BidID;
					break;
				}
				case "ClientBidID":
				{
					value = ClientBidID;
					break;
				}
				case "BidRequestTransType":
				{
					value = BidRequestTransType;
					break;
				}
				case "ListName":
				{
					value = ListName;
					break;
				}
				case "TotNoRelatedSym":
				{
					value = TotNoRelatedSym;
					break;
				}
				case "BidType":
				{
					value = BidType;
					break;
				}
				case "NumTickets":
				{
					value = NumTickets;
					break;
				}
				case "Currency":
				{
					value = Currency;
					break;
				}
				case "CurrencyCodeSource":
				{
					value = CurrencyCodeSource;
					break;
				}
				case "SideValue1":
				{
					value = SideValue1;
					break;
				}
				case "SideValue2":
				{
					value = SideValue2;
					break;
				}
				case "BidDescReqGrp":
				{
					value = BidDescReqGrp;
					break;
				}
				case "BidCompReqGrp":
				{
					value = BidCompReqGrp;
					break;
				}
				case "LiquidityIndType":
				{
					value = LiquidityIndType;
					break;
				}
				case "WtAverageLiquidity":
				{
					value = WtAverageLiquidity;
					break;
				}
				case "ExchangeForPhysical":
				{
					value = ExchangeForPhysical;
					break;
				}
				case "OutMainCntryUIndex":
				{
					value = OutMainCntryUIndex;
					break;
				}
				case "CrossPercent":
				{
					value = CrossPercent;
					break;
				}
				case "ProgRptReqs":
				{
					value = ProgRptReqs;
					break;
				}
				case "ProgPeriodInterval":
				{
					value = ProgPeriodInterval;
					break;
				}
				case "IncTaxInd":
				{
					value = IncTaxInd;
					break;
				}
				case "ForexReq":
				{
					value = ForexReq;
					break;
				}
				case "NumBidders":
				{
					value = NumBidders;
					break;
				}
				case "TradeDate":
				{
					value = TradeDate;
					break;
				}
				case "BidTradeType":
				{
					value = BidTradeType;
					break;
				}
				case "BasisPxType":
				{
					value = BasisPxType;
					break;
				}
				case "StrikeTime":
				{
					value = StrikeTime;
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
			BidID = null;
			ClientBidID = null;
			BidRequestTransType = null;
			ListName = null;
			TotNoRelatedSym = null;
			BidType = null;
			NumTickets = null;
			Currency = null;
			CurrencyCodeSource = null;
			SideValue1 = null;
			SideValue2 = null;
			((IFixReset?)BidDescReqGrp)?.Reset();
			((IFixReset?)BidCompReqGrp)?.Reset();
			LiquidityIndType = null;
			WtAverageLiquidity = null;
			ExchangeForPhysical = null;
			OutMainCntryUIndex = null;
			CrossPercent = null;
			ProgRptReqs = null;
			ProgPeriodInterval = null;
			IncTaxInd = null;
			ForexReq = null;
			NumBidders = null;
			TradeDate = null;
			BidTradeType = null;
			BasisPxType = null;
			StrikeTime = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
