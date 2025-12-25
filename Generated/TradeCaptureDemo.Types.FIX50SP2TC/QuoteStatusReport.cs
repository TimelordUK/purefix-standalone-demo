using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("AI", FixVersion.FIX50SP2)]
	public sealed partial class QuoteStatusReport : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 649, Type = TagType.String, Offset = 1, Required = false)]
		public string? QuoteStatusReqID {get; set;}
		
		[TagDetails(Tag = 131, Type = TagType.String, Offset = 2, Required = false)]
		public string? QuoteReqID {get; set;}
		
		[TagDetails(Tag = 117, Type = TagType.String, Offset = 3, Required = false)]
		public string? QuoteID {get; set;}
		
		[TagDetails(Tag = 390, Type = TagType.String, Offset = 4, Required = false)]
		public string? BidID {get; set;}
		
		[TagDetails(Tag = 1867, Type = TagType.String, Offset = 5, Required = false)]
		public string? OfferID {get; set;}
		
		[TagDetails(Tag = 1751, Type = TagType.String, Offset = 6, Required = false)]
		public string? SecondaryQuoteID {get; set;}
		
		[TagDetails(Tag = 1166, Type = TagType.String, Offset = 7, Required = false)]
		public string? QuoteMsgID {get; set;}
		
		[TagDetails(Tag = 693, Type = TagType.String, Offset = 8, Required = false)]
		public string? QuoteRespID {get; set;}
		
		[TagDetails(Tag = 537, Type = TagType.Int, Offset = 9, Required = false)]
		public int? QuoteType {get; set;}
		
		[TagDetails(Tag = 298, Type = TagType.Int, Offset = 10, Required = false)]
		public int? QuoteCancelType {get; set;}
		
		[Component(Offset = 11, Required = false)]
		public Parties? Parties {get; set;}
		
		[Component(Offset = 12, Required = false)]
		public TargetParties? TargetParties {get; set;}
		
		[TagDetails(Tag = 336, Type = TagType.String, Offset = 13, Required = false)]
		public string? TradingSessionID {get; set;}
		
		[TagDetails(Tag = 625, Type = TagType.String, Offset = 14, Required = false)]
		public string? TradingSessionSubID {get; set;}
		
		[Component(Offset = 15, Required = false)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 16, Required = false)]
		public FinancingDetails? FinancingDetails {get; set;}
		
		[Component(Offset = 17, Required = false)]
		public UndInstrmtGrp? UndInstrmtGrp {get; set;}
		
		[TagDetails(Tag = 54, Type = TagType.String, Offset = 18, Required = false)]
		public string? Side {get; set;}
		
		[Component(Offset = 19, Required = false)]
		public OrderQtyData? OrderQtyData {get; set;}
		
		[TagDetails(Tag = 63, Type = TagType.String, Offset = 20, Required = false)]
		public string? SettlType {get; set;}
		
		[TagDetails(Tag = 64, Type = TagType.LocalDate, Offset = 21, Required = false)]
		public DateOnly? SettlDate {get; set;}
		
		[TagDetails(Tag = 193, Type = TagType.LocalDate, Offset = 22, Required = false)]
		public DateOnly? SettlDate2 {get; set;}
		
		[TagDetails(Tag = 2878, Type = TagType.LocalDate, Offset = 23, Required = false)]
		public DateOnly? TerminationDate {get; set;}
		
		[TagDetails(Tag = 192, Type = TagType.Float, Offset = 24, Required = false)]
		public double? OrderQty2 {get; set;}
		
		[TagDetails(Tag = 15, Type = TagType.String, Offset = 25, Required = false)]
		public string? Currency {get; set;}
		
		[TagDetails(Tag = 2897, Type = TagType.String, Offset = 26, Required = false)]
		public string? CurrencyCodeSource {get; set;}
		
		[Component(Offset = 27, Required = false)]
		public Stipulations? Stipulations {get; set;}
		
		[TagDetails(Tag = 1, Type = TagType.String, Offset = 28, Required = false)]
		public string? Account {get; set;}
		
		[TagDetails(Tag = 660, Type = TagType.Int, Offset = 29, Required = false)]
		public int? AcctIDSource {get; set;}
		
		[TagDetails(Tag = 581, Type = TagType.Int, Offset = 30, Required = false)]
		public int? AccountType {get; set;}
		
		[Component(Offset = 31, Required = false)]
		public LegQuotStatGrp? LegQuotStatGrp {get; set;}
		
		[Component(Offset = 32, Required = false)]
		public QuotQualGrp? QuotQualGrp {get; set;}
		
		[Component(Offset = 33, Required = false)]
		public QuoteAttributeGrp? QuoteAttributeGrp {get; set;}
		
		[TagDetails(Tag = 2830, Type = TagType.String, Offset = 34, Required = false)]
		public string? EventInitiatorType {get; set;}
		
		[TagDetails(Tag = 2115, Type = TagType.Int, Offset = 35, Required = false)]
		public int? NegotiationMethod {get; set;}
		
		[TagDetails(Tag = 126, Type = TagType.UtcTimestamp, Offset = 36, Required = false)]
		public DateTime? ExpireTime {get; set;}
		
		[TagDetails(Tag = 44, Type = TagType.Float, Offset = 37, Required = false)]
		public double? Price {get; set;}
		
		[TagDetails(Tag = 423, Type = TagType.Int, Offset = 38, Required = false)]
		public int? PriceType {get; set;}
		
		[Component(Offset = 39, Required = false)]
		public PriceQualifierGrp? PriceQualifierGrp {get; set;}
		
		[Component(Offset = 40, Required = false)]
		public SpreadOrBenchmarkCurveData? SpreadOrBenchmarkCurveData {get; set;}
		
		[Component(Offset = 41, Required = false)]
		public YieldData? YieldData {get; set;}
		
		[TagDetails(Tag = 1747, Type = TagType.String, Offset = 42, Required = false)]
		public string? BidQuoteID {get; set;}
		
		[TagDetails(Tag = 1748, Type = TagType.String, Offset = 43, Required = false)]
		public string? OfferQuoteID {get; set;}
		
		[TagDetails(Tag = 1745, Type = TagType.String, Offset = 44, Required = false)]
		public string? BidMDEntryID {get; set;}
		
		[TagDetails(Tag = 1746, Type = TagType.String, Offset = 45, Required = false)]
		public string? OfferMDEntryID {get; set;}
		
		[TagDetails(Tag = 132, Type = TagType.Float, Offset = 46, Required = false)]
		public double? BidPx {get; set;}
		
		[TagDetails(Tag = 133, Type = TagType.Float, Offset = 47, Required = false)]
		public double? OfferPx {get; set;}
		
		[TagDetails(Tag = 645, Type = TagType.Float, Offset = 48, Required = false)]
		public double? MktBidPx {get; set;}
		
		[TagDetails(Tag = 646, Type = TagType.Float, Offset = 49, Required = false)]
		public double? MktOfferPx {get; set;}
		
		[TagDetails(Tag = 647, Type = TagType.Float, Offset = 50, Required = false)]
		public double? MinBidSize {get; set;}
		
		[TagDetails(Tag = 134, Type = TagType.Float, Offset = 51, Required = false)]
		public double? BidSize {get; set;}
		
		[TagDetails(Tag = 1749, Type = TagType.Float, Offset = 52, Required = false)]
		public double? TotalBidSize {get; set;}
		
		[TagDetails(Tag = 648, Type = TagType.Float, Offset = 53, Required = false)]
		public double? MinOfferSize {get; set;}
		
		[TagDetails(Tag = 135, Type = TagType.Float, Offset = 54, Required = false)]
		public double? OfferSize {get; set;}
		
		[TagDetails(Tag = 1750, Type = TagType.Float, Offset = 55, Required = false)]
		public double? TotalOfferSize {get; set;}
		
		[TagDetails(Tag = 110, Type = TagType.Float, Offset = 56, Required = false)]
		public double? MinQty {get; set;}
		
		[TagDetails(Tag = 62, Type = TagType.UtcTimestamp, Offset = 57, Required = false)]
		public DateTime? ValidUntilTime {get; set;}
		
		[TagDetails(Tag = 188, Type = TagType.Float, Offset = 58, Required = false)]
		public double? BidSpotRate {get; set;}
		
		[TagDetails(Tag = 190, Type = TagType.Float, Offset = 59, Required = false)]
		public double? OfferSpotRate {get; set;}
		
		[TagDetails(Tag = 189, Type = TagType.Float, Offset = 60, Required = false)]
		public double? BidForwardPoints {get; set;}
		
		[TagDetails(Tag = 191, Type = TagType.Float, Offset = 61, Required = false)]
		public double? OfferForwardPoints {get; set;}
		
		[TagDetails(Tag = 631, Type = TagType.Float, Offset = 62, Required = false)]
		public double? MidPx {get; set;}
		
		[TagDetails(Tag = 632, Type = TagType.Float, Offset = 63, Required = false)]
		public double? BidYield {get; set;}
		
		[TagDetails(Tag = 633, Type = TagType.Float, Offset = 64, Required = false)]
		public double? MidYield {get; set;}
		
		[TagDetails(Tag = 634, Type = TagType.Float, Offset = 65, Required = false)]
		public double? OfferYield {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 66, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[Component(Offset = 67, Required = false)]
		public TrdRegTimestamps? TrdRegTimestamps {get; set;}
		
		[TagDetails(Tag = 40, Type = TagType.String, Offset = 68, Required = false)]
		public string? OrdType {get; set;}
		
		[TagDetails(Tag = 642, Type = TagType.Float, Offset = 69, Required = false)]
		public double? BidForwardPoints2 {get; set;}
		
		[TagDetails(Tag = 643, Type = TagType.Float, Offset = 70, Required = false)]
		public double? OfferForwardPoints2 {get; set;}
		
		[TagDetails(Tag = 656, Type = TagType.Float, Offset = 71, Required = false)]
		public double? SettlCurrBidFxRate {get; set;}
		
		[TagDetails(Tag = 657, Type = TagType.Float, Offset = 72, Required = false)]
		public double? SettlCurrOfferFxRate {get; set;}
		
		[TagDetails(Tag = 156, Type = TagType.String, Offset = 73, Required = false)]
		public string? SettlCurrFxRateCalc {get; set;}
		
		[Component(Offset = 74, Required = false)]
		public CommissionData? CommissionData {get; set;}
		
		[TagDetails(Tag = 582, Type = TagType.Int, Offset = 75, Required = false)]
		public int? CustOrderCapacity {get; set;}
		
		[TagDetails(Tag = 100, Type = TagType.String, Offset = 76, Required = false)]
		public string? ExDestination {get; set;}
		
		[TagDetails(Tag = 1133, Type = TagType.String, Offset = 77, Required = false)]
		public string? ExDestinationIDSource {get; set;}
		
		[TagDetails(Tag = 775, Type = TagType.Int, Offset = 78, Required = false)]
		public int? BookingType {get; set;}
		
		[TagDetails(Tag = 528, Type = TagType.String, Offset = 79, Required = false)]
		public string? OrderCapacity {get; set;}
		
		[TagDetails(Tag = 529, Type = TagType.String, Offset = 80, Required = false)]
		public string? OrderRestrictions {get; set;}
		
		[TagDetails(Tag = 1934, Type = TagType.Int, Offset = 81, Required = false)]
		public int? RegulatoryReportType {get; set;}
		
		[TagDetails(Tag = 297, Type = TagType.Int, Offset = 82, Required = false)]
		public int? QuoteStatus {get; set;}
		
		[TagDetails(Tag = 300, Type = TagType.Int, Offset = 83, Required = false)]
		public int? QuoteRejectReason {get; set;}
		
		[TagDetails(Tag = 1328, Type = TagType.String, Offset = 84, Required = false)]
		public string? RejectText {get; set;}
		
		[TagDetails(Tag = 1664, Type = TagType.Length, Offset = 85, Required = false)]
		public int? EncodedRejectTextLen {get; set;}
		
		[TagDetails(Tag = 1665, Type = TagType.RawData, Offset = 86, Required = false)]
		public byte[]? EncodedRejectText {get; set;}
		
		[TagDetails(Tag = 1937, Type = TagType.Int, Offset = 87, Required = false)]
		public int? TradeContinuation {get; set;}
		
		[TagDetails(Tag = 2374, Type = TagType.String, Offset = 88, Required = false)]
		public string? TradeContinuationText {get; set;}
		
		[TagDetails(Tag = 2372, Type = TagType.Length, Offset = 89, Required = false)]
		public int? EncodedTradeContinuationTextLen {get; set;}
		
		[TagDetails(Tag = 2371, Type = TagType.RawData, Offset = 90, Required = false)]
		public byte[]? EncodedTradeContinuationText {get; set;}
		
		[Component(Offset = 91, Required = false)]
		public ThrottleResponse? ThrottleResponse {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 92, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 93, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 94, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[TagDetails(Tag = 443, Type = TagType.UtcTimestamp, Offset = 95, Required = false)]
		public DateTime? StrikeTime {get; set;}
		
		[Component(Offset = 96, Required = true)]
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
			if (QuoteStatusReqID is not null) writer.WriteString(649, QuoteStatusReqID);
			if (QuoteReqID is not null) writer.WriteString(131, QuoteReqID);
			if (QuoteID is not null) writer.WriteString(117, QuoteID);
			if (BidID is not null) writer.WriteString(390, BidID);
			if (OfferID is not null) writer.WriteString(1867, OfferID);
			if (SecondaryQuoteID is not null) writer.WriteString(1751, SecondaryQuoteID);
			if (QuoteMsgID is not null) writer.WriteString(1166, QuoteMsgID);
			if (QuoteRespID is not null) writer.WriteString(693, QuoteRespID);
			if (QuoteType is not null) writer.WriteWholeNumber(537, QuoteType.Value);
			if (QuoteCancelType is not null) writer.WriteWholeNumber(298, QuoteCancelType.Value);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (TargetParties is not null) ((IFixEncoder)TargetParties).Encode(writer);
			if (TradingSessionID is not null) writer.WriteString(336, TradingSessionID);
			if (TradingSessionSubID is not null) writer.WriteString(625, TradingSessionSubID);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (FinancingDetails is not null) ((IFixEncoder)FinancingDetails).Encode(writer);
			if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
			if (Side is not null) writer.WriteString(54, Side);
			if (OrderQtyData is not null) ((IFixEncoder)OrderQtyData).Encode(writer);
			if (SettlType is not null) writer.WriteString(63, SettlType);
			if (SettlDate is not null) writer.WriteLocalDateOnly(64, SettlDate.Value);
			if (SettlDate2 is not null) writer.WriteLocalDateOnly(193, SettlDate2.Value);
			if (TerminationDate is not null) writer.WriteLocalDateOnly(2878, TerminationDate.Value);
			if (OrderQty2 is not null) writer.WriteNumber(192, OrderQty2.Value);
			if (Currency is not null) writer.WriteString(15, Currency);
			if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
			if (Stipulations is not null) ((IFixEncoder)Stipulations).Encode(writer);
			if (Account is not null) writer.WriteString(1, Account);
			if (AcctIDSource is not null) writer.WriteWholeNumber(660, AcctIDSource.Value);
			if (AccountType is not null) writer.WriteWholeNumber(581, AccountType.Value);
			if (LegQuotStatGrp is not null) ((IFixEncoder)LegQuotStatGrp).Encode(writer);
			if (QuotQualGrp is not null) ((IFixEncoder)QuotQualGrp).Encode(writer);
			if (QuoteAttributeGrp is not null) ((IFixEncoder)QuoteAttributeGrp).Encode(writer);
			if (EventInitiatorType is not null) writer.WriteString(2830, EventInitiatorType);
			if (NegotiationMethod is not null) writer.WriteWholeNumber(2115, NegotiationMethod.Value);
			if (ExpireTime is not null) writer.WriteUtcTimeStamp(126, ExpireTime.Value);
			if (Price is not null) writer.WriteNumber(44, Price.Value);
			if (PriceType is not null) writer.WriteWholeNumber(423, PriceType.Value);
			if (PriceQualifierGrp is not null) ((IFixEncoder)PriceQualifierGrp).Encode(writer);
			if (SpreadOrBenchmarkCurveData is not null) ((IFixEncoder)SpreadOrBenchmarkCurveData).Encode(writer);
			if (YieldData is not null) ((IFixEncoder)YieldData).Encode(writer);
			if (BidQuoteID is not null) writer.WriteString(1747, BidQuoteID);
			if (OfferQuoteID is not null) writer.WriteString(1748, OfferQuoteID);
			if (BidMDEntryID is not null) writer.WriteString(1745, BidMDEntryID);
			if (OfferMDEntryID is not null) writer.WriteString(1746, OfferMDEntryID);
			if (BidPx is not null) writer.WriteNumber(132, BidPx.Value);
			if (OfferPx is not null) writer.WriteNumber(133, OfferPx.Value);
			if (MktBidPx is not null) writer.WriteNumber(645, MktBidPx.Value);
			if (MktOfferPx is not null) writer.WriteNumber(646, MktOfferPx.Value);
			if (MinBidSize is not null) writer.WriteNumber(647, MinBidSize.Value);
			if (BidSize is not null) writer.WriteNumber(134, BidSize.Value);
			if (TotalBidSize is not null) writer.WriteNumber(1749, TotalBidSize.Value);
			if (MinOfferSize is not null) writer.WriteNumber(648, MinOfferSize.Value);
			if (OfferSize is not null) writer.WriteNumber(135, OfferSize.Value);
			if (TotalOfferSize is not null) writer.WriteNumber(1750, TotalOfferSize.Value);
			if (MinQty is not null) writer.WriteNumber(110, MinQty.Value);
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
			if (TrdRegTimestamps is not null) ((IFixEncoder)TrdRegTimestamps).Encode(writer);
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
			if (BookingType is not null) writer.WriteWholeNumber(775, BookingType.Value);
			if (OrderCapacity is not null) writer.WriteString(528, OrderCapacity);
			if (OrderRestrictions is not null) writer.WriteString(529, OrderRestrictions);
			if (RegulatoryReportType is not null) writer.WriteWholeNumber(1934, RegulatoryReportType.Value);
			if (QuoteStatus is not null) writer.WriteWholeNumber(297, QuoteStatus.Value);
			if (QuoteRejectReason is not null) writer.WriteWholeNumber(300, QuoteRejectReason.Value);
			if (RejectText is not null) writer.WriteString(1328, RejectText);
			if (EncodedRejectTextLen is not null) writer.WriteWholeNumber(1664, EncodedRejectTextLen.Value);
			if (EncodedRejectText is not null) writer.WriteBuffer(1665, EncodedRejectText);
			if (TradeContinuation is not null) writer.WriteWholeNumber(1937, TradeContinuation.Value);
			if (TradeContinuationText is not null) writer.WriteString(2374, TradeContinuationText);
			if (EncodedTradeContinuationTextLen is not null) writer.WriteWholeNumber(2372, EncodedTradeContinuationTextLen.Value);
			if (EncodedTradeContinuationText is not null) writer.WriteBuffer(2371, EncodedTradeContinuationText);
			if (ThrottleResponse is not null) ((IFixEncoder)ThrottleResponse).Encode(writer);
			if (Text is not null) writer.WriteString(58, Text);
			if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
			if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
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
			QuoteStatusReqID = view.GetString(649);
			QuoteReqID = view.GetString(131);
			QuoteID = view.GetString(117);
			BidID = view.GetString(390);
			OfferID = view.GetString(1867);
			SecondaryQuoteID = view.GetString(1751);
			QuoteMsgID = view.GetString(1166);
			QuoteRespID = view.GetString(693);
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
			SettlType = view.GetString(63);
			SettlDate = view.GetDateOnly(64);
			SettlDate2 = view.GetDateOnly(193);
			TerminationDate = view.GetDateOnly(2878);
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
			if (view.GetView("LegQuotStatGrp") is IMessageView viewLegQuotStatGrp)
			{
				LegQuotStatGrp = new();
				((IFixParser)LegQuotStatGrp).Parse(viewLegQuotStatGrp);
			}
			if (view.GetView("QuotQualGrp") is IMessageView viewQuotQualGrp)
			{
				QuotQualGrp = new();
				((IFixParser)QuotQualGrp).Parse(viewQuotQualGrp);
			}
			if (view.GetView("QuoteAttributeGrp") is IMessageView viewQuoteAttributeGrp)
			{
				QuoteAttributeGrp = new();
				((IFixParser)QuoteAttributeGrp).Parse(viewQuoteAttributeGrp);
			}
			EventInitiatorType = view.GetString(2830);
			NegotiationMethod = view.GetInt32(2115);
			ExpireTime = view.GetDateTime(126);
			Price = view.GetDouble(44);
			PriceType = view.GetInt32(423);
			if (view.GetView("PriceQualifierGrp") is IMessageView viewPriceQualifierGrp)
			{
				PriceQualifierGrp = new();
				((IFixParser)PriceQualifierGrp).Parse(viewPriceQualifierGrp);
			}
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
			BidQuoteID = view.GetString(1747);
			OfferQuoteID = view.GetString(1748);
			BidMDEntryID = view.GetString(1745);
			OfferMDEntryID = view.GetString(1746);
			BidPx = view.GetDouble(132);
			OfferPx = view.GetDouble(133);
			MktBidPx = view.GetDouble(645);
			MktOfferPx = view.GetDouble(646);
			MinBidSize = view.GetDouble(647);
			BidSize = view.GetDouble(134);
			TotalBidSize = view.GetDouble(1749);
			MinOfferSize = view.GetDouble(648);
			OfferSize = view.GetDouble(135);
			TotalOfferSize = view.GetDouble(1750);
			MinQty = view.GetDouble(110);
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
			if (view.GetView("TrdRegTimestamps") is IMessageView viewTrdRegTimestamps)
			{
				TrdRegTimestamps = new();
				((IFixParser)TrdRegTimestamps).Parse(viewTrdRegTimestamps);
			}
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
			BookingType = view.GetInt32(775);
			OrderCapacity = view.GetString(528);
			OrderRestrictions = view.GetString(529);
			RegulatoryReportType = view.GetInt32(1934);
			QuoteStatus = view.GetInt32(297);
			QuoteRejectReason = view.GetInt32(300);
			RejectText = view.GetString(1328);
			EncodedRejectTextLen = view.GetInt32(1664);
			EncodedRejectText = view.GetByteArray(1665);
			TradeContinuation = view.GetInt32(1937);
			TradeContinuationText = view.GetString(2374);
			EncodedTradeContinuationTextLen = view.GetInt32(2372);
			EncodedTradeContinuationText = view.GetByteArray(2371);
			if (view.GetView("ThrottleResponse") is IMessageView viewThrottleResponse)
			{
				ThrottleResponse = new();
				((IFixParser)ThrottleResponse).Parse(viewThrottleResponse);
			}
			Text = view.GetString(58);
			EncodedTextLen = view.GetInt32(354);
			EncodedText = view.GetByteArray(355);
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
				case "QuoteStatusReqID":
				{
					value = QuoteStatusReqID;
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
				case "BidID":
				{
					value = BidID;
					break;
				}
				case "OfferID":
				{
					value = OfferID;
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
				case "QuoteRespID":
				{
					value = QuoteRespID;
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
				case "SettlDate2":
				{
					value = SettlDate2;
					break;
				}
				case "TerminationDate":
				{
					value = TerminationDate;
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
				case "LegQuotStatGrp":
				{
					value = LegQuotStatGrp;
					break;
				}
				case "QuotQualGrp":
				{
					value = QuotQualGrp;
					break;
				}
				case "QuoteAttributeGrp":
				{
					value = QuoteAttributeGrp;
					break;
				}
				case "EventInitiatorType":
				{
					value = EventInitiatorType;
					break;
				}
				case "NegotiationMethod":
				{
					value = NegotiationMethod;
					break;
				}
				case "ExpireTime":
				{
					value = ExpireTime;
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
				case "BidQuoteID":
				{
					value = BidQuoteID;
					break;
				}
				case "OfferQuoteID":
				{
					value = OfferQuoteID;
					break;
				}
				case "BidMDEntryID":
				{
					value = BidMDEntryID;
					break;
				}
				case "OfferMDEntryID":
				{
					value = OfferMDEntryID;
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
				case "TotalBidSize":
				{
					value = TotalBidSize;
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
				case "TotalOfferSize":
				{
					value = TotalOfferSize;
					break;
				}
				case "MinQty":
				{
					value = MinQty;
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
				case "TrdRegTimestamps":
				{
					value = TrdRegTimestamps;
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
				case "BookingType":
				{
					value = BookingType;
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
				case "RegulatoryReportType":
				{
					value = RegulatoryReportType;
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
				case "ThrottleResponse":
				{
					value = ThrottleResponse;
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
			QuoteStatusReqID = null;
			QuoteReqID = null;
			QuoteID = null;
			BidID = null;
			OfferID = null;
			SecondaryQuoteID = null;
			QuoteMsgID = null;
			QuoteRespID = null;
			QuoteType = null;
			QuoteCancelType = null;
			((IFixReset?)Parties)?.Reset();
			((IFixReset?)TargetParties)?.Reset();
			TradingSessionID = null;
			TradingSessionSubID = null;
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)FinancingDetails)?.Reset();
			((IFixReset?)UndInstrmtGrp)?.Reset();
			Side = null;
			((IFixReset?)OrderQtyData)?.Reset();
			SettlType = null;
			SettlDate = null;
			SettlDate2 = null;
			TerminationDate = null;
			OrderQty2 = null;
			Currency = null;
			CurrencyCodeSource = null;
			((IFixReset?)Stipulations)?.Reset();
			Account = null;
			AcctIDSource = null;
			AccountType = null;
			((IFixReset?)LegQuotStatGrp)?.Reset();
			((IFixReset?)QuotQualGrp)?.Reset();
			((IFixReset?)QuoteAttributeGrp)?.Reset();
			EventInitiatorType = null;
			NegotiationMethod = null;
			ExpireTime = null;
			Price = null;
			PriceType = null;
			((IFixReset?)PriceQualifierGrp)?.Reset();
			((IFixReset?)SpreadOrBenchmarkCurveData)?.Reset();
			((IFixReset?)YieldData)?.Reset();
			BidQuoteID = null;
			OfferQuoteID = null;
			BidMDEntryID = null;
			OfferMDEntryID = null;
			BidPx = null;
			OfferPx = null;
			MktBidPx = null;
			MktOfferPx = null;
			MinBidSize = null;
			BidSize = null;
			TotalBidSize = null;
			MinOfferSize = null;
			OfferSize = null;
			TotalOfferSize = null;
			MinQty = null;
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
			((IFixReset?)TrdRegTimestamps)?.Reset();
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
			BookingType = null;
			OrderCapacity = null;
			OrderRestrictions = null;
			RegulatoryReportType = null;
			QuoteStatus = null;
			QuoteRejectReason = null;
			RejectText = null;
			EncodedRejectTextLen = null;
			EncodedRejectText = null;
			TradeContinuation = null;
			TradeContinuationText = null;
			EncodedTradeContinuationTextLen = null;
			EncodedTradeContinuationText = null;
			((IFixReset?)ThrottleResponse)?.Reset();
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			StrikeTime = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
