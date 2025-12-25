using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("AJ", FixVersion.FIX50SP2)]
	public sealed partial class QuoteResponse : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 693, Type = TagType.String, Offset = 1, Required = true)]
		public string? QuoteRespID {get; set;}
		
		[TagDetails(Tag = 117, Type = TagType.String, Offset = 2, Required = false)]
		public string? QuoteID {get; set;}
		
		[TagDetails(Tag = 1166, Type = TagType.String, Offset = 3, Required = false)]
		public string? QuoteMsgID {get; set;}
		
		[TagDetails(Tag = 131, Type = TagType.String, Offset = 4, Required = false)]
		public string? QuoteReqID {get; set;}
		
		[TagDetails(Tag = 694, Type = TagType.Int, Offset = 5, Required = true)]
		public int? QuoteRespType {get; set;}
		
		[TagDetails(Tag = 11, Type = TagType.String, Offset = 6, Required = false)]
		public string? ClOrdID {get; set;}
		
		[TagDetails(Tag = 528, Type = TagType.String, Offset = 7, Required = false)]
		public string? OrderCapacity {get; set;}
		
		[TagDetails(Tag = 529, Type = TagType.String, Offset = 8, Required = false)]
		public string? OrderRestrictions {get; set;}
		
		[TagDetails(Tag = 23, Type = TagType.String, Offset = 9, Required = false)]
		public string? IOIID {get; set;}
		
		[TagDetails(Tag = 537, Type = TagType.Int, Offset = 10, Required = false)]
		public int? QuoteType {get; set;}
		
		[TagDetails(Tag = 1091, Type = TagType.Boolean, Offset = 11, Required = false)]
		public bool? PreTradeAnonymity {get; set;}
		
		[Component(Offset = 12, Required = false)]
		public QuotQualGrp? QuotQualGrp {get; set;}
		
		[TagDetails(Tag = 828, Type = TagType.Int, Offset = 13, Required = false)]
		public int? TrdType {get; set;}
		
		[TagDetails(Tag = 2347, Type = TagType.Int, Offset = 14, Required = false)]
		public int? RegulatoryTransactionType {get; set;}
		
		[TagDetails(Tag = 2115, Type = TagType.Int, Offset = 15, Required = false)]
		public int? NegotiationMethod {get; set;}
		
		[Component(Offset = 16, Required = false)]
		public Parties? Parties {get; set;}
		
		[TagDetails(Tag = 336, Type = TagType.String, Offset = 17, Required = false)]
		public string? TradingSessionID {get; set;}
		
		[TagDetails(Tag = 625, Type = TagType.String, Offset = 18, Required = false)]
		public string? TradingSessionSubID {get; set;}
		
		[Component(Offset = 19, Required = true)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 20, Required = false)]
		public FinancingDetails? FinancingDetails {get; set;}
		
		[Component(Offset = 21, Required = false)]
		public UndInstrmtGrp? UndInstrmtGrp {get; set;}
		
		[TagDetails(Tag = 54, Type = TagType.String, Offset = 22, Required = false)]
		public string? Side {get; set;}
		
		[Component(Offset = 23, Required = false)]
		public OrderQtyData? OrderQtyData {get; set;}
		
		[TagDetails(Tag = 110, Type = TagType.Float, Offset = 24, Required = false)]
		public double? MinQty {get; set;}
		
		[TagDetails(Tag = 63, Type = TagType.String, Offset = 25, Required = false)]
		public string? SettlType {get; set;}
		
		[TagDetails(Tag = 64, Type = TagType.LocalDate, Offset = 26, Required = false)]
		public DateOnly? SettlDate {get; set;}
		
		[TagDetails(Tag = 2878, Type = TagType.LocalDate, Offset = 27, Required = false)]
		public DateOnly? TerminationDate {get; set;}
		
		[TagDetails(Tag = 193, Type = TagType.LocalDate, Offset = 28, Required = false)]
		public DateOnly? SettlDate2 {get; set;}
		
		[TagDetails(Tag = 192, Type = TagType.Float, Offset = 29, Required = false)]
		public double? OrderQty2 {get; set;}
		
		[TagDetails(Tag = 15, Type = TagType.String, Offset = 30, Required = false)]
		public string? Currency {get; set;}
		
		[TagDetails(Tag = 2897, Type = TagType.String, Offset = 31, Required = false)]
		public string? CurrencyCodeSource {get; set;}
		
		[Component(Offset = 32, Required = false)]
		public Stipulations? Stipulations {get; set;}
		
		[TagDetails(Tag = 1, Type = TagType.String, Offset = 33, Required = false)]
		public string? Account {get; set;}
		
		[TagDetails(Tag = 660, Type = TagType.Int, Offset = 34, Required = false)]
		public int? AcctIDSource {get; set;}
		
		[TagDetails(Tag = 581, Type = TagType.Int, Offset = 35, Required = false)]
		public int? AccountType {get; set;}
		
		[Component(Offset = 36, Required = false)]
		public LegQuotGrp? LegQuotGrp {get; set;}
		
		[TagDetails(Tag = 132, Type = TagType.Float, Offset = 37, Required = false)]
		public double? BidPx {get; set;}
		
		[TagDetails(Tag = 133, Type = TagType.Float, Offset = 38, Required = false)]
		public double? OfferPx {get; set;}
		
		[TagDetails(Tag = 645, Type = TagType.Float, Offset = 39, Required = false)]
		public double? MktBidPx {get; set;}
		
		[TagDetails(Tag = 646, Type = TagType.Float, Offset = 40, Required = false)]
		public double? MktOfferPx {get; set;}
		
		[TagDetails(Tag = 647, Type = TagType.Float, Offset = 41, Required = false)]
		public double? MinBidSize {get; set;}
		
		[TagDetails(Tag = 134, Type = TagType.Float, Offset = 42, Required = false)]
		public double? BidSize {get; set;}
		
		[TagDetails(Tag = 648, Type = TagType.Float, Offset = 43, Required = false)]
		public double? MinOfferSize {get; set;}
		
		[TagDetails(Tag = 135, Type = TagType.Float, Offset = 44, Required = false)]
		public double? OfferSize {get; set;}
		
		[TagDetails(Tag = 62, Type = TagType.UtcTimestamp, Offset = 45, Required = false)]
		public DateTime? ValidUntilTime {get; set;}
		
		[TagDetails(Tag = 188, Type = TagType.Float, Offset = 46, Required = false)]
		public double? BidSpotRate {get; set;}
		
		[TagDetails(Tag = 190, Type = TagType.Float, Offset = 47, Required = false)]
		public double? OfferSpotRate {get; set;}
		
		[TagDetails(Tag = 189, Type = TagType.Float, Offset = 48, Required = false)]
		public double? BidForwardPoints {get; set;}
		
		[TagDetails(Tag = 191, Type = TagType.Float, Offset = 49, Required = false)]
		public double? OfferForwardPoints {get; set;}
		
		[TagDetails(Tag = 631, Type = TagType.Float, Offset = 50, Required = false)]
		public double? MidPx {get; set;}
		
		[TagDetails(Tag = 632, Type = TagType.Float, Offset = 51, Required = false)]
		public double? BidYield {get; set;}
		
		[TagDetails(Tag = 633, Type = TagType.Float, Offset = 52, Required = false)]
		public double? MidYield {get; set;}
		
		[TagDetails(Tag = 634, Type = TagType.Float, Offset = 53, Required = false)]
		public double? OfferYield {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 54, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 40, Type = TagType.String, Offset = 55, Required = false)]
		public string? OrdType {get; set;}
		
		[TagDetails(Tag = 642, Type = TagType.Float, Offset = 56, Required = false)]
		public double? BidForwardPoints2 {get; set;}
		
		[TagDetails(Tag = 643, Type = TagType.Float, Offset = 57, Required = false)]
		public double? OfferForwardPoints2 {get; set;}
		
		[TagDetails(Tag = 656, Type = TagType.Float, Offset = 58, Required = false)]
		public double? SettlCurrBidFxRate {get; set;}
		
		[TagDetails(Tag = 657, Type = TagType.Float, Offset = 59, Required = false)]
		public double? SettlCurrOfferFxRate {get; set;}
		
		[TagDetails(Tag = 156, Type = TagType.String, Offset = 60, Required = false)]
		public string? SettlCurrFxRateCalc {get; set;}
		
		[Component(Offset = 61, Required = false)]
		public CommissionData? CommissionData {get; set;}
		
		[TagDetails(Tag = 582, Type = TagType.Int, Offset = 62, Required = false)]
		public int? CustOrderCapacity {get; set;}
		
		[TagDetails(Tag = 100, Type = TagType.String, Offset = 63, Required = false)]
		public string? ExDestination {get; set;}
		
		[TagDetails(Tag = 1133, Type = TagType.String, Offset = 64, Required = false)]
		public string? ExDestinationIDSource {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 65, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 66, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 67, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[TagDetails(Tag = 44, Type = TagType.Float, Offset = 68, Required = false)]
		public double? Price {get; set;}
		
		[TagDetails(Tag = 423, Type = TagType.Int, Offset = 69, Required = false)]
		public int? PriceType {get; set;}
		
		[Component(Offset = 70, Required = false)]
		public PriceQualifierGrp? PriceQualifierGrp {get; set;}
		
		[TagDetails(Tag = 1917, Type = TagType.Float, Offset = 71, Required = false)]
		public double? CoverPrice {get; set;}
		
		[Component(Offset = 72, Required = false)]
		public SpreadOrBenchmarkCurveData? SpreadOrBenchmarkCurveData {get; set;}
		
		[Component(Offset = 73, Required = false)]
		public YieldData? YieldData {get; set;}
		
		[TagDetails(Tag = 1937, Type = TagType.Int, Offset = 74, Required = false)]
		public int? TradeContinuation {get; set;}
		
		[TagDetails(Tag = 2374, Type = TagType.String, Offset = 75, Required = false)]
		public string? TradeContinuationText {get; set;}
		
		[TagDetails(Tag = 2372, Type = TagType.Length, Offset = 76, Required = false)]
		public int? EncodedTradeContinuationTextLen {get; set;}
		
		[TagDetails(Tag = 2371, Type = TagType.RawData, Offset = 77, Required = false)]
		public byte[]? EncodedTradeContinuationText {get; set;}
		
		[TagDetails(Tag = 443, Type = TagType.UtcTimestamp, Offset = 78, Required = false)]
		public DateTime? StrikeTime {get; set;}
		
		[Component(Offset = 79, Required = true)]
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
			if (QuoteRespID is not null) writer.WriteString(693, QuoteRespID);
			if (QuoteID is not null) writer.WriteString(117, QuoteID);
			if (QuoteMsgID is not null) writer.WriteString(1166, QuoteMsgID);
			if (QuoteReqID is not null) writer.WriteString(131, QuoteReqID);
			if (QuoteRespType is not null) writer.WriteWholeNumber(694, QuoteRespType.Value);
			if (ClOrdID is not null) writer.WriteString(11, ClOrdID);
			if (OrderCapacity is not null) writer.WriteString(528, OrderCapacity);
			if (OrderRestrictions is not null) writer.WriteString(529, OrderRestrictions);
			if (IOIID is not null) writer.WriteString(23, IOIID);
			if (QuoteType is not null) writer.WriteWholeNumber(537, QuoteType.Value);
			if (PreTradeAnonymity is not null) writer.WriteBoolean(1091, PreTradeAnonymity.Value);
			if (QuotQualGrp is not null) ((IFixEncoder)QuotQualGrp).Encode(writer);
			if (TrdType is not null) writer.WriteWholeNumber(828, TrdType.Value);
			if (RegulatoryTransactionType is not null) writer.WriteWholeNumber(2347, RegulatoryTransactionType.Value);
			if (NegotiationMethod is not null) writer.WriteWholeNumber(2115, NegotiationMethod.Value);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (TradingSessionID is not null) writer.WriteString(336, TradingSessionID);
			if (TradingSessionSubID is not null) writer.WriteString(625, TradingSessionSubID);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (FinancingDetails is not null) ((IFixEncoder)FinancingDetails).Encode(writer);
			if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
			if (Side is not null) writer.WriteString(54, Side);
			if (OrderQtyData is not null) ((IFixEncoder)OrderQtyData).Encode(writer);
			if (MinQty is not null) writer.WriteNumber(110, MinQty.Value);
			if (SettlType is not null) writer.WriteString(63, SettlType);
			if (SettlDate is not null) writer.WriteLocalDateOnly(64, SettlDate.Value);
			if (TerminationDate is not null) writer.WriteLocalDateOnly(2878, TerminationDate.Value);
			if (SettlDate2 is not null) writer.WriteLocalDateOnly(193, SettlDate2.Value);
			if (OrderQty2 is not null) writer.WriteNumber(192, OrderQty2.Value);
			if (Currency is not null) writer.WriteString(15, Currency);
			if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
			if (Stipulations is not null) ((IFixEncoder)Stipulations).Encode(writer);
			if (Account is not null) writer.WriteString(1, Account);
			if (AcctIDSource is not null) writer.WriteWholeNumber(660, AcctIDSource.Value);
			if (AccountType is not null) writer.WriteWholeNumber(581, AccountType.Value);
			if (LegQuotGrp is not null) ((IFixEncoder)LegQuotGrp).Encode(writer);
			if (BidPx is not null) writer.WriteNumber(132, BidPx.Value);
			if (OfferPx is not null) writer.WriteNumber(133, OfferPx.Value);
			if (MktBidPx is not null) writer.WriteNumber(645, MktBidPx.Value);
			if (MktOfferPx is not null) writer.WriteNumber(646, MktOfferPx.Value);
			if (MinBidSize is not null) writer.WriteNumber(647, MinBidSize.Value);
			if (BidSize is not null) writer.WriteNumber(134, BidSize.Value);
			if (MinOfferSize is not null) writer.WriteNumber(648, MinOfferSize.Value);
			if (OfferSize is not null) writer.WriteNumber(135, OfferSize.Value);
			if (ValidUntilTime is not null) writer.WriteUtcTimeStamp(62, ValidUntilTime.Value);
			if (BidSpotRate is not null) writer.WriteNumber(188, BidSpotRate.Value);
			if (OfferSpotRate is not null) writer.WriteNumber(190, OfferSpotRate.Value);
			if (BidForwardPoints is not null) writer.WriteNumber(189, BidForwardPoints.Value);
			if (OfferForwardPoints is not null) writer.WriteNumber(191, OfferForwardPoints.Value);
			if (MidPx is not null) writer.WriteNumber(631, MidPx.Value);
			if (BidYield is not null) writer.WriteNumber(632, BidYield.Value);
			if (MidYield is not null) writer.WriteNumber(633, MidYield.Value);
			if (OfferYield is not null) writer.WriteNumber(634, OfferYield.Value);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (OrdType is not null) writer.WriteString(40, OrdType);
			if (BidForwardPoints2 is not null) writer.WriteNumber(642, BidForwardPoints2.Value);
			if (OfferForwardPoints2 is not null) writer.WriteNumber(643, OfferForwardPoints2.Value);
			if (SettlCurrBidFxRate is not null) writer.WriteNumber(656, SettlCurrBidFxRate.Value);
			if (SettlCurrOfferFxRate is not null) writer.WriteNumber(657, SettlCurrOfferFxRate.Value);
			if (SettlCurrFxRateCalc is not null) writer.WriteString(156, SettlCurrFxRateCalc);
			if (CommissionData is not null) ((IFixEncoder)CommissionData).Encode(writer);
			if (CustOrderCapacity is not null) writer.WriteWholeNumber(582, CustOrderCapacity.Value);
			if (ExDestination is not null) writer.WriteString(100, ExDestination);
			if (ExDestinationIDSource is not null) writer.WriteString(1133, ExDestinationIDSource);
			if (Text is not null) writer.WriteString(58, Text);
			if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
			if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
			if (Price is not null) writer.WriteNumber(44, Price.Value);
			if (PriceType is not null) writer.WriteWholeNumber(423, PriceType.Value);
			if (PriceQualifierGrp is not null) ((IFixEncoder)PriceQualifierGrp).Encode(writer);
			if (CoverPrice is not null) writer.WriteNumber(1917, CoverPrice.Value);
			if (SpreadOrBenchmarkCurveData is not null) ((IFixEncoder)SpreadOrBenchmarkCurveData).Encode(writer);
			if (YieldData is not null) ((IFixEncoder)YieldData).Encode(writer);
			if (TradeContinuation is not null) writer.WriteWholeNumber(1937, TradeContinuation.Value);
			if (TradeContinuationText is not null) writer.WriteString(2374, TradeContinuationText);
			if (EncodedTradeContinuationTextLen is not null) writer.WriteWholeNumber(2372, EncodedTradeContinuationTextLen.Value);
			if (EncodedTradeContinuationText is not null) writer.WriteBuffer(2371, EncodedTradeContinuationText);
			if (StrikeTime is not null) writer.WriteUtcTimeStamp(443, StrikeTime.Value);
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
			QuoteRespID = view.GetString(693);
			QuoteID = view.GetString(117);
			QuoteMsgID = view.GetString(1166);
			QuoteReqID = view.GetString(131);
			QuoteRespType = view.GetInt32(694);
			ClOrdID = view.GetString(11);
			OrderCapacity = view.GetString(528);
			OrderRestrictions = view.GetString(529);
			IOIID = view.GetString(23);
			QuoteType = view.GetInt32(537);
			PreTradeAnonymity = view.GetBool(1091);
			if (view.GetView("QuotQualGrp") is IMessageView viewQuotQualGrp)
			{
				QuotQualGrp = new();
				((IFixParser)QuotQualGrp).Parse(viewQuotQualGrp);
			}
			TrdType = view.GetInt32(828);
			RegulatoryTransactionType = view.GetInt32(2347);
			NegotiationMethod = view.GetInt32(2115);
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			TradingSessionID = view.GetString(336);
			TradingSessionSubID = view.GetString(625);
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
			Side = view.GetString(54);
			if (view.GetView("OrderQtyData") is IMessageView viewOrderQtyData)
			{
				OrderQtyData = new();
				((IFixParser)OrderQtyData).Parse(viewOrderQtyData);
			}
			MinQty = view.GetDouble(110);
			SettlType = view.GetString(63);
			SettlDate = view.GetDateOnly(64);
			TerminationDate = view.GetDateOnly(2878);
			SettlDate2 = view.GetDateOnly(193);
			OrderQty2 = view.GetDouble(192);
			Currency = view.GetString(15);
			CurrencyCodeSource = view.GetString(2897);
			if (view.GetView("Stipulations") is IMessageView viewStipulations)
			{
				Stipulations = new();
				((IFixParser)Stipulations).Parse(viewStipulations);
			}
			Account = view.GetString(1);
			AcctIDSource = view.GetInt32(660);
			AccountType = view.GetInt32(581);
			if (view.GetView("LegQuotGrp") is IMessageView viewLegQuotGrp)
			{
				LegQuotGrp = new();
				((IFixParser)LegQuotGrp).Parse(viewLegQuotGrp);
			}
			BidPx = view.GetDouble(132);
			OfferPx = view.GetDouble(133);
			MktBidPx = view.GetDouble(645);
			MktOfferPx = view.GetDouble(646);
			MinBidSize = view.GetDouble(647);
			BidSize = view.GetDouble(134);
			MinOfferSize = view.GetDouble(648);
			OfferSize = view.GetDouble(135);
			ValidUntilTime = view.GetDateTime(62);
			BidSpotRate = view.GetDouble(188);
			OfferSpotRate = view.GetDouble(190);
			BidForwardPoints = view.GetDouble(189);
			OfferForwardPoints = view.GetDouble(191);
			MidPx = view.GetDouble(631);
			BidYield = view.GetDouble(632);
			MidYield = view.GetDouble(633);
			OfferYield = view.GetDouble(634);
			TransactTime = view.GetDateTime(60);
			OrdType = view.GetString(40);
			BidForwardPoints2 = view.GetDouble(642);
			OfferForwardPoints2 = view.GetDouble(643);
			SettlCurrBidFxRate = view.GetDouble(656);
			SettlCurrOfferFxRate = view.GetDouble(657);
			SettlCurrFxRateCalc = view.GetString(156);
			if (view.GetView("CommissionData") is IMessageView viewCommissionData)
			{
				CommissionData = new();
				((IFixParser)CommissionData).Parse(viewCommissionData);
			}
			CustOrderCapacity = view.GetInt32(582);
			ExDestination = view.GetString(100);
			ExDestinationIDSource = view.GetString(1133);
			Text = view.GetString(58);
			EncodedTextLen = view.GetInt32(354);
			EncodedText = view.GetByteArray(355);
			Price = view.GetDouble(44);
			PriceType = view.GetInt32(423);
			if (view.GetView("PriceQualifierGrp") is IMessageView viewPriceQualifierGrp)
			{
				PriceQualifierGrp = new();
				((IFixParser)PriceQualifierGrp).Parse(viewPriceQualifierGrp);
			}
			CoverPrice = view.GetDouble(1917);
			if (view.GetView("SpreadOrBenchmarkCurveData") is IMessageView viewSpreadOrBenchmarkCurveData)
			{
				SpreadOrBenchmarkCurveData = new();
				((IFixParser)SpreadOrBenchmarkCurveData).Parse(viewSpreadOrBenchmarkCurveData);
			}
			if (view.GetView("YieldData") is IMessageView viewYieldData)
			{
				YieldData = new();
				((IFixParser)YieldData).Parse(viewYieldData);
			}
			TradeContinuation = view.GetInt32(1937);
			TradeContinuationText = view.GetString(2374);
			EncodedTradeContinuationTextLen = view.GetInt32(2372);
			EncodedTradeContinuationText = view.GetByteArray(2371);
			StrikeTime = view.GetDateTime(443);
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
				case "QuoteRespID":
				{
					value = QuoteRespID;
					break;
				}
				case "QuoteID":
				{
					value = QuoteID;
					break;
				}
				case "QuoteMsgID":
				{
					value = QuoteMsgID;
					break;
				}
				case "QuoteReqID":
				{
					value = QuoteReqID;
					break;
				}
				case "QuoteRespType":
				{
					value = QuoteRespType;
					break;
				}
				case "ClOrdID":
				{
					value = ClOrdID;
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
				case "IOIID":
				{
					value = IOIID;
					break;
				}
				case "QuoteType":
				{
					value = QuoteType;
					break;
				}
				case "PreTradeAnonymity":
				{
					value = PreTradeAnonymity;
					break;
				}
				case "QuotQualGrp":
				{
					value = QuotQualGrp;
					break;
				}
				case "TrdType":
				{
					value = TrdType;
					break;
				}
				case "RegulatoryTransactionType":
				{
					value = RegulatoryTransactionType;
					break;
				}
				case "NegotiationMethod":
				{
					value = NegotiationMethod;
					break;
				}
				case "Parties":
				{
					value = Parties;
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
				case "Side":
				{
					value = Side;
					break;
				}
				case "OrderQtyData":
				{
					value = OrderQtyData;
					break;
				}
				case "MinQty":
				{
					value = MinQty;
					break;
				}
				case "SettlType":
				{
					value = SettlType;
					break;
				}
				case "SettlDate":
				{
					value = SettlDate;
					break;
				}
				case "TerminationDate":
				{
					value = TerminationDate;
					break;
				}
				case "SettlDate2":
				{
					value = SettlDate2;
					break;
				}
				case "OrderQty2":
				{
					value = OrderQty2;
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
				case "Stipulations":
				{
					value = Stipulations;
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
				case "LegQuotGrp":
				{
					value = LegQuotGrp;
					break;
				}
				case "BidPx":
				{
					value = BidPx;
					break;
				}
				case "OfferPx":
				{
					value = OfferPx;
					break;
				}
				case "MktBidPx":
				{
					value = MktBidPx;
					break;
				}
				case "MktOfferPx":
				{
					value = MktOfferPx;
					break;
				}
				case "MinBidSize":
				{
					value = MinBidSize;
					break;
				}
				case "BidSize":
				{
					value = BidSize;
					break;
				}
				case "MinOfferSize":
				{
					value = MinOfferSize;
					break;
				}
				case "OfferSize":
				{
					value = OfferSize;
					break;
				}
				case "ValidUntilTime":
				{
					value = ValidUntilTime;
					break;
				}
				case "BidSpotRate":
				{
					value = BidSpotRate;
					break;
				}
				case "OfferSpotRate":
				{
					value = OfferSpotRate;
					break;
				}
				case "BidForwardPoints":
				{
					value = BidForwardPoints;
					break;
				}
				case "OfferForwardPoints":
				{
					value = OfferForwardPoints;
					break;
				}
				case "MidPx":
				{
					value = MidPx;
					break;
				}
				case "BidYield":
				{
					value = BidYield;
					break;
				}
				case "MidYield":
				{
					value = MidYield;
					break;
				}
				case "OfferYield":
				{
					value = OfferYield;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "OrdType":
				{
					value = OrdType;
					break;
				}
				case "BidForwardPoints2":
				{
					value = BidForwardPoints2;
					break;
				}
				case "OfferForwardPoints2":
				{
					value = OfferForwardPoints2;
					break;
				}
				case "SettlCurrBidFxRate":
				{
					value = SettlCurrBidFxRate;
					break;
				}
				case "SettlCurrOfferFxRate":
				{
					value = SettlCurrOfferFxRate;
					break;
				}
				case "SettlCurrFxRateCalc":
				{
					value = SettlCurrFxRateCalc;
					break;
				}
				case "CommissionData":
				{
					value = CommissionData;
					break;
				}
				case "CustOrderCapacity":
				{
					value = CustOrderCapacity;
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
				case "Price":
				{
					value = Price;
					break;
				}
				case "PriceType":
				{
					value = PriceType;
					break;
				}
				case "PriceQualifierGrp":
				{
					value = PriceQualifierGrp;
					break;
				}
				case "CoverPrice":
				{
					value = CoverPrice;
					break;
				}
				case "SpreadOrBenchmarkCurveData":
				{
					value = SpreadOrBenchmarkCurveData;
					break;
				}
				case "YieldData":
				{
					value = YieldData;
					break;
				}
				case "TradeContinuation":
				{
					value = TradeContinuation;
					break;
				}
				case "TradeContinuationText":
				{
					value = TradeContinuationText;
					break;
				}
				case "EncodedTradeContinuationTextLen":
				{
					value = EncodedTradeContinuationTextLen;
					break;
				}
				case "EncodedTradeContinuationText":
				{
					value = EncodedTradeContinuationText;
					break;
				}
				case "StrikeTime":
				{
					value = StrikeTime;
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
			QuoteRespID = null;
			QuoteID = null;
			QuoteMsgID = null;
			QuoteReqID = null;
			QuoteRespType = null;
			ClOrdID = null;
			OrderCapacity = null;
			OrderRestrictions = null;
			IOIID = null;
			QuoteType = null;
			PreTradeAnonymity = null;
			((IFixReset?)QuotQualGrp)?.Reset();
			TrdType = null;
			RegulatoryTransactionType = null;
			NegotiationMethod = null;
			((IFixReset?)Parties)?.Reset();
			TradingSessionID = null;
			TradingSessionSubID = null;
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)FinancingDetails)?.Reset();
			((IFixReset?)UndInstrmtGrp)?.Reset();
			Side = null;
			((IFixReset?)OrderQtyData)?.Reset();
			MinQty = null;
			SettlType = null;
			SettlDate = null;
			TerminationDate = null;
			SettlDate2 = null;
			OrderQty2 = null;
			Currency = null;
			CurrencyCodeSource = null;
			((IFixReset?)Stipulations)?.Reset();
			Account = null;
			AcctIDSource = null;
			AccountType = null;
			((IFixReset?)LegQuotGrp)?.Reset();
			BidPx = null;
			OfferPx = null;
			MktBidPx = null;
			MktOfferPx = null;
			MinBidSize = null;
			BidSize = null;
			MinOfferSize = null;
			OfferSize = null;
			ValidUntilTime = null;
			BidSpotRate = null;
			OfferSpotRate = null;
			BidForwardPoints = null;
			OfferForwardPoints = null;
			MidPx = null;
			BidYield = null;
			MidYield = null;
			OfferYield = null;
			TransactTime = null;
			OrdType = null;
			BidForwardPoints2 = null;
			OfferForwardPoints2 = null;
			SettlCurrBidFxRate = null;
			SettlCurrOfferFxRate = null;
			SettlCurrFxRateCalc = null;
			((IFixReset?)CommissionData)?.Reset();
			CustOrderCapacity = null;
			ExDestination = null;
			ExDestinationIDSource = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			Price = null;
			PriceType = null;
			((IFixReset?)PriceQualifierGrp)?.Reset();
			CoverPrice = null;
			((IFixReset?)SpreadOrBenchmarkCurveData)?.Reset();
			((IFixReset?)YieldData)?.Reset();
			TradeContinuation = null;
			TradeContinuationText = null;
			EncodedTradeContinuationTextLen = null;
			EncodedTradeContinuationText = null;
			StrikeTime = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
