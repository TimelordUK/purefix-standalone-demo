using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("f", FixVersion.FIX50SP2)]
	public sealed partial class SecurityStatus : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public ApplicationSequenceControl? ApplicationSequenceControl {get; set;}
		
		[TagDetails(Tag = 324, Type = TagType.String, Offset = 2, Required = false)]
		public string? SecurityStatusReqID {get; set;}
		
		[Component(Offset = 3, Required = true)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public InstrumentExtension? InstrumentExtension {get; set;}
		
		[Component(Offset = 5, Required = false)]
		public FinancingDetails? FinancingDetails {get; set;}
		
		[Component(Offset = 6, Required = false)]
		public UndInstrmtGrp? UndInstrmtGrp {get; set;}
		
		[Component(Offset = 7, Required = false)]
		public InstrmtLegGrp? InstrmtLegGrp {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public RelatedInstrumentGrp? RelatedInstrumentGrp {get; set;}
		
		[TagDetails(Tag = 15, Type = TagType.String, Offset = 9, Required = false)]
		public string? Currency {get; set;}
		
		[TagDetails(Tag = 2897, Type = TagType.String, Offset = 10, Required = false)]
		public string? CurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 1301, Type = TagType.String, Offset = 11, Required = false)]
		public string? MarketID {get; set;}
		
		[TagDetails(Tag = 1300, Type = TagType.String, Offset = 12, Required = false)]
		public string? MarketSegmentID {get; set;}
		
		[TagDetails(Tag = 75, Type = TagType.LocalDate, Offset = 13, Required = false)]
		public DateOnly? TradeDate {get; set;}
		
		[TagDetails(Tag = 336, Type = TagType.String, Offset = 14, Required = false)]
		public string? TradingSessionID {get; set;}
		
		[TagDetails(Tag = 625, Type = TagType.String, Offset = 15, Required = false)]
		public string? TradingSessionSubID {get; set;}
		
		[TagDetails(Tag = 325, Type = TagType.Boolean, Offset = 16, Required = false)]
		public bool? UnsolicitedIndicator {get; set;}
		
		[TagDetails(Tag = 326, Type = TagType.Int, Offset = 17, Required = false)]
		public int? SecurityTradingStatus {get; set;}
		
		[TagDetails(Tag = 1655, Type = TagType.Int, Offset = 18, Required = false)]
		public int? MarketMakerActivity {get; set;}
		
		[TagDetails(Tag = 2447, Type = TagType.Boolean, Offset = 19, Required = false)]
		public bool? FastMarketIndicator {get; set;}
		
		[TagDetails(Tag = 1174, Type = TagType.Int, Offset = 20, Required = false)]
		public int? SecurityTradingEvent {get; set;}
		
		[TagDetails(Tag = 2116, Type = TagType.UtcTimestamp, Offset = 21, Required = false)]
		public DateTime? NextAuctionTime {get; set;}
		
		[TagDetails(Tag = 291, Type = TagType.String, Offset = 22, Required = false)]
		public string? FinancialStatus {get; set;}
		
		[TagDetails(Tag = 292, Type = TagType.String, Offset = 23, Required = false)]
		public string? CorporateAction {get; set;}
		
		[TagDetails(Tag = 327, Type = TagType.Int, Offset = 24, Required = false)]
		public int? HaltReasonInt {get; set;}
		
		[TagDetails(Tag = 328, Type = TagType.Boolean, Offset = 25, Required = false)]
		public bool? InViewOfCommon {get; set;}
		
		[TagDetails(Tag = 329, Type = TagType.Boolean, Offset = 26, Required = false)]
		public bool? DueToRelated {get; set;}
		
		[TagDetails(Tag = 1021, Type = TagType.Int, Offset = 27, Required = false)]
		public int? MDBookType {get; set;}
		
		[TagDetails(Tag = 264, Type = TagType.Int, Offset = 28, Required = false)]
		public int? MarketDepth {get; set;}
		
		[TagDetails(Tag = 330, Type = TagType.Float, Offset = 29, Required = false)]
		public double? BuyVolume {get; set;}
		
		[TagDetails(Tag = 331, Type = TagType.Float, Offset = 30, Required = false)]
		public double? SellVolume {get; set;}
		
		[TagDetails(Tag = 332, Type = TagType.Float, Offset = 31, Required = false)]
		public double? HighPx {get; set;}
		
		[TagDetails(Tag = 333, Type = TagType.Float, Offset = 32, Required = false)]
		public double? LowPx {get; set;}
		
		[TagDetails(Tag = 31, Type = TagType.Float, Offset = 33, Required = false)]
		public double? LastPx {get; set;}
		
		[Component(Offset = 34, Required = false)]
		public ClearingPriceParametersGrp? ClearingPriceParametersGrp {get; set;}
		
		[TagDetails(Tag = 730, Type = TagType.Float, Offset = 35, Required = false)]
		public double? SettlPrice {get; set;}
		
		[TagDetails(Tag = 731, Type = TagType.Int, Offset = 36, Required = false)]
		public int? SettlPriceType {get; set;}
		
		[TagDetails(Tag = 2451, Type = TagType.Int, Offset = 37, Required = false)]
		public int? SettlPriceDeterminationMethod {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 38, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 334, Type = TagType.Int, Offset = 39, Required = false)]
		public int? Adjustment {get; set;}
		
		[TagDetails(Tag = 1025, Type = TagType.Float, Offset = 40, Required = false)]
		public double? FirstPx {get; set;}
		
		[TagDetails(Tag = 2448, Type = TagType.Boolean, Offset = 41, Required = false)]
		public bool? LinkageHandlingIndicator {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 42, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 43, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 44, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 45, Required = true)]
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
			if (ApplicationSequenceControl is not null) ((IFixEncoder)ApplicationSequenceControl).Encode(writer);
			if (SecurityStatusReqID is not null) writer.WriteString(324, SecurityStatusReqID);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (InstrumentExtension is not null) ((IFixEncoder)InstrumentExtension).Encode(writer);
			if (FinancingDetails is not null) ((IFixEncoder)FinancingDetails).Encode(writer);
			if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
			if (InstrmtLegGrp is not null) ((IFixEncoder)InstrmtLegGrp).Encode(writer);
			if (RelatedInstrumentGrp is not null) ((IFixEncoder)RelatedInstrumentGrp).Encode(writer);
			if (Currency is not null) writer.WriteString(15, Currency);
			if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
			if (MarketID is not null) writer.WriteString(1301, MarketID);
			if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
			if (TradeDate is not null) writer.WriteLocalDateOnly(75, TradeDate.Value);
			if (TradingSessionID is not null) writer.WriteString(336, TradingSessionID);
			if (TradingSessionSubID is not null) writer.WriteString(625, TradingSessionSubID);
			if (UnsolicitedIndicator is not null) writer.WriteBoolean(325, UnsolicitedIndicator.Value);
			if (SecurityTradingStatus is not null) writer.WriteWholeNumber(326, SecurityTradingStatus.Value);
			if (MarketMakerActivity is not null) writer.WriteWholeNumber(1655, MarketMakerActivity.Value);
			if (FastMarketIndicator is not null) writer.WriteBoolean(2447, FastMarketIndicator.Value);
			if (SecurityTradingEvent is not null) writer.WriteWholeNumber(1174, SecurityTradingEvent.Value);
			if (NextAuctionTime is not null) writer.WriteUtcTimeStamp(2116, NextAuctionTime.Value);
			if (FinancialStatus is not null) writer.WriteString(291, FinancialStatus);
			if (CorporateAction is not null) writer.WriteString(292, CorporateAction);
			if (HaltReasonInt is not null) writer.WriteWholeNumber(327, HaltReasonInt.Value);
			if (InViewOfCommon is not null) writer.WriteBoolean(328, InViewOfCommon.Value);
			if (DueToRelated is not null) writer.WriteBoolean(329, DueToRelated.Value);
			if (MDBookType is not null) writer.WriteWholeNumber(1021, MDBookType.Value);
			if (MarketDepth is not null) writer.WriteWholeNumber(264, MarketDepth.Value);
			if (BuyVolume is not null) writer.WriteNumber(330, BuyVolume.Value);
			if (SellVolume is not null) writer.WriteNumber(331, SellVolume.Value);
			if (HighPx is not null) writer.WriteNumber(332, HighPx.Value);
			if (LowPx is not null) writer.WriteNumber(333, LowPx.Value);
			if (LastPx is not null) writer.WriteNumber(31, LastPx.Value);
			if (ClearingPriceParametersGrp is not null) ((IFixEncoder)ClearingPriceParametersGrp).Encode(writer);
			if (SettlPrice is not null) writer.WriteNumber(730, SettlPrice.Value);
			if (SettlPriceType is not null) writer.WriteWholeNumber(731, SettlPriceType.Value);
			if (SettlPriceDeterminationMethod is not null) writer.WriteWholeNumber(2451, SettlPriceDeterminationMethod.Value);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (Adjustment is not null) writer.WriteWholeNumber(334, Adjustment.Value);
			if (FirstPx is not null) writer.WriteNumber(1025, FirstPx.Value);
			if (LinkageHandlingIndicator is not null) writer.WriteBoolean(2448, LinkageHandlingIndicator.Value);
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
			if (view.GetView("ApplicationSequenceControl") is IMessageView viewApplicationSequenceControl)
			{
				ApplicationSequenceControl = new();
				((IFixParser)ApplicationSequenceControl).Parse(viewApplicationSequenceControl);
			}
			SecurityStatusReqID = view.GetString(324);
			if (view.GetView("Instrument") is IMessageView viewInstrument)
			{
				Instrument = new();
				((IFixParser)Instrument).Parse(viewInstrument);
			}
			if (view.GetView("InstrumentExtension") is IMessageView viewInstrumentExtension)
			{
				InstrumentExtension = new();
				((IFixParser)InstrumentExtension).Parse(viewInstrumentExtension);
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
			if (view.GetView("InstrmtLegGrp") is IMessageView viewInstrmtLegGrp)
			{
				InstrmtLegGrp = new();
				((IFixParser)InstrmtLegGrp).Parse(viewInstrmtLegGrp);
			}
			if (view.GetView("RelatedInstrumentGrp") is IMessageView viewRelatedInstrumentGrp)
			{
				RelatedInstrumentGrp = new();
				((IFixParser)RelatedInstrumentGrp).Parse(viewRelatedInstrumentGrp);
			}
			Currency = view.GetString(15);
			CurrencyCodeSource = view.GetString(2897);
			MarketID = view.GetString(1301);
			MarketSegmentID = view.GetString(1300);
			TradeDate = view.GetDateOnly(75);
			TradingSessionID = view.GetString(336);
			TradingSessionSubID = view.GetString(625);
			UnsolicitedIndicator = view.GetBool(325);
			SecurityTradingStatus = view.GetInt32(326);
			MarketMakerActivity = view.GetInt32(1655);
			FastMarketIndicator = view.GetBool(2447);
			SecurityTradingEvent = view.GetInt32(1174);
			NextAuctionTime = view.GetDateTime(2116);
			FinancialStatus = view.GetString(291);
			CorporateAction = view.GetString(292);
			HaltReasonInt = view.GetInt32(327);
			InViewOfCommon = view.GetBool(328);
			DueToRelated = view.GetBool(329);
			MDBookType = view.GetInt32(1021);
			MarketDepth = view.GetInt32(264);
			BuyVolume = view.GetDouble(330);
			SellVolume = view.GetDouble(331);
			HighPx = view.GetDouble(332);
			LowPx = view.GetDouble(333);
			LastPx = view.GetDouble(31);
			if (view.GetView("ClearingPriceParametersGrp") is IMessageView viewClearingPriceParametersGrp)
			{
				ClearingPriceParametersGrp = new();
				((IFixParser)ClearingPriceParametersGrp).Parse(viewClearingPriceParametersGrp);
			}
			SettlPrice = view.GetDouble(730);
			SettlPriceType = view.GetInt32(731);
			SettlPriceDeterminationMethod = view.GetInt32(2451);
			TransactTime = view.GetDateTime(60);
			Adjustment = view.GetInt32(334);
			FirstPx = view.GetDouble(1025);
			LinkageHandlingIndicator = view.GetBool(2448);
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
				case "ApplicationSequenceControl":
				{
					value = ApplicationSequenceControl;
					break;
				}
				case "SecurityStatusReqID":
				{
					value = SecurityStatusReqID;
					break;
				}
				case "Instrument":
				{
					value = Instrument;
					break;
				}
				case "InstrumentExtension":
				{
					value = InstrumentExtension;
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
				case "InstrmtLegGrp":
				{
					value = InstrmtLegGrp;
					break;
				}
				case "RelatedInstrumentGrp":
				{
					value = RelatedInstrumentGrp;
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
				case "TradeDate":
				{
					value = TradeDate;
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
				case "UnsolicitedIndicator":
				{
					value = UnsolicitedIndicator;
					break;
				}
				case "SecurityTradingStatus":
				{
					value = SecurityTradingStatus;
					break;
				}
				case "MarketMakerActivity":
				{
					value = MarketMakerActivity;
					break;
				}
				case "FastMarketIndicator":
				{
					value = FastMarketIndicator;
					break;
				}
				case "SecurityTradingEvent":
				{
					value = SecurityTradingEvent;
					break;
				}
				case "NextAuctionTime":
				{
					value = NextAuctionTime;
					break;
				}
				case "FinancialStatus":
				{
					value = FinancialStatus;
					break;
				}
				case "CorporateAction":
				{
					value = CorporateAction;
					break;
				}
				case "HaltReasonInt":
				{
					value = HaltReasonInt;
					break;
				}
				case "InViewOfCommon":
				{
					value = InViewOfCommon;
					break;
				}
				case "DueToRelated":
				{
					value = DueToRelated;
					break;
				}
				case "MDBookType":
				{
					value = MDBookType;
					break;
				}
				case "MarketDepth":
				{
					value = MarketDepth;
					break;
				}
				case "BuyVolume":
				{
					value = BuyVolume;
					break;
				}
				case "SellVolume":
				{
					value = SellVolume;
					break;
				}
				case "HighPx":
				{
					value = HighPx;
					break;
				}
				case "LowPx":
				{
					value = LowPx;
					break;
				}
				case "LastPx":
				{
					value = LastPx;
					break;
				}
				case "ClearingPriceParametersGrp":
				{
					value = ClearingPriceParametersGrp;
					break;
				}
				case "SettlPrice":
				{
					value = SettlPrice;
					break;
				}
				case "SettlPriceType":
				{
					value = SettlPriceType;
					break;
				}
				case "SettlPriceDeterminationMethod":
				{
					value = SettlPriceDeterminationMethod;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "Adjustment":
				{
					value = Adjustment;
					break;
				}
				case "FirstPx":
				{
					value = FirstPx;
					break;
				}
				case "LinkageHandlingIndicator":
				{
					value = LinkageHandlingIndicator;
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
			((IFixReset?)ApplicationSequenceControl)?.Reset();
			SecurityStatusReqID = null;
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)InstrumentExtension)?.Reset();
			((IFixReset?)FinancingDetails)?.Reset();
			((IFixReset?)UndInstrmtGrp)?.Reset();
			((IFixReset?)InstrmtLegGrp)?.Reset();
			((IFixReset?)RelatedInstrumentGrp)?.Reset();
			Currency = null;
			CurrencyCodeSource = null;
			MarketID = null;
			MarketSegmentID = null;
			TradeDate = null;
			TradingSessionID = null;
			TradingSessionSubID = null;
			UnsolicitedIndicator = null;
			SecurityTradingStatus = null;
			MarketMakerActivity = null;
			FastMarketIndicator = null;
			SecurityTradingEvent = null;
			NextAuctionTime = null;
			FinancialStatus = null;
			CorporateAction = null;
			HaltReasonInt = null;
			InViewOfCommon = null;
			DueToRelated = null;
			MDBookType = null;
			MarketDepth = null;
			BuyVolume = null;
			SellVolume = null;
			HighPx = null;
			LowPx = null;
			LastPx = null;
			((IFixReset?)ClearingPriceParametersGrp)?.Reset();
			SettlPrice = null;
			SettlPriceType = null;
			SettlPriceDeterminationMethod = null;
			TransactTime = null;
			Adjustment = null;
			FirstPx = null;
			LinkageHandlingIndicator = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
