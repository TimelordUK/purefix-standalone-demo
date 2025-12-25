using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("BA", FixVersion.FIX50SP2)]
	public sealed partial class CollateralReport : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 908, Type = TagType.String, Offset = 1, Required = true)]
		public string? CollRptID {get; set;}
		
		[TagDetails(Tag = 909, Type = TagType.String, Offset = 2, Required = false)]
		public string? CollInquiryID {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 3, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 1043, Type = TagType.Int, Offset = 4, Required = false)]
		public int? CollApplType {get; set;}
		
		[TagDetails(Tag = 291, Type = TagType.String, Offset = 5, Required = false)]
		public string? FinancialStatus {get; set;}
		
		[TagDetails(Tag = 910, Type = TagType.Int, Offset = 6, Required = true)]
		public int? CollStatus {get; set;}
		
		[TagDetails(Tag = 911, Type = TagType.Int, Offset = 7, Required = false)]
		public int? TotNumReports {get; set;}
		
		[TagDetails(Tag = 912, Type = TagType.Boolean, Offset = 8, Required = false)]
		public bool? LastRptRequested {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public Parties? Parties {get; set;}
		
		[TagDetails(Tag = 1, Type = TagType.String, Offset = 10, Required = false)]
		public string? Account {get; set;}
		
		[TagDetails(Tag = 581, Type = TagType.Int, Offset = 11, Required = false)]
		public int? AccountType {get; set;}
		
		[TagDetails(Tag = 11, Type = TagType.String, Offset = 12, Required = false)]
		public string? ClOrdID {get; set;}
		
		[TagDetails(Tag = 37, Type = TagType.String, Offset = 13, Required = false)]
		public string? OrderID {get; set;}
		
		[TagDetails(Tag = 198, Type = TagType.String, Offset = 14, Required = false)]
		public string? SecondaryOrderID {get; set;}
		
		[TagDetails(Tag = 526, Type = TagType.String, Offset = 15, Required = false)]
		public string? SecondaryClOrdID {get; set;}
		
		[Component(Offset = 16, Required = false)]
		public ExecCollGrp? ExecCollGrp {get; set;}
		
		[Component(Offset = 17, Required = false)]
		public TrdCollGrp? TrdCollGrp {get; set;}
		
		[Component(Offset = 18, Required = false)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 19, Required = false)]
		public FinancingDetails? FinancingDetails {get; set;}
		
		[TagDetails(Tag = 64, Type = TagType.LocalDate, Offset = 20, Required = false)]
		public DateOnly? SettlDate {get; set;}
		
		[TagDetails(Tag = 53, Type = TagType.Float, Offset = 21, Required = false)]
		public double? Quantity {get; set;}
		
		[TagDetails(Tag = 854, Type = TagType.Int, Offset = 22, Required = false)]
		public int? QtyType {get; set;}
		
		[TagDetails(Tag = 15, Type = TagType.String, Offset = 23, Required = false)]
		public string? Currency {get; set;}
		
		[TagDetails(Tag = 2897, Type = TagType.String, Offset = 24, Required = false)]
		public string? CurrencyCodeSource {get; set;}
		
		[Component(Offset = 25, Required = false)]
		public InstrmtLegGrp? InstrmtLegGrp {get; set;}
		
		[Component(Offset = 26, Required = false)]
		public UndInstrmtGrp? UndInstrmtGrp {get; set;}
		
		[TagDetails(Tag = 899, Type = TagType.Float, Offset = 27, Required = false)]
		public double? MarginExcess {get; set;}
		
		[TagDetails(Tag = 900, Type = TagType.Float, Offset = 28, Required = false)]
		public double? TotalNetValue {get; set;}
		
		[TagDetails(Tag = 901, Type = TagType.Float, Offset = 29, Required = false)]
		public double? CashOutstanding {get; set;}
		
		[Component(Offset = 30, Required = false)]
		public CollateralAmountGrp? CollateralAmountGrp {get; set;}
		
		[TagDetails(Tag = 2868, Type = TagType.LocalDate, Offset = 31, Required = false)]
		public DateOnly? CollateralizationValueDate {get; set;}
		
		[TagDetails(Tag = 1936, Type = TagType.Int, Offset = 32, Required = false)]
		public int? TradeCollateralization {get; set;}
		
		[Component(Offset = 33, Required = false)]
		public RegulatoryTradeIDGrp? RegulatoryTradeIDGrp {get; set;}
		
		[Component(Offset = 34, Required = false)]
		public TrdRegTimestamps? TrdRegTimestamps {get; set;}
		
		[TagDetails(Tag = 54, Type = TagType.String, Offset = 35, Required = false)]
		public string? Side {get; set;}
		
		[Component(Offset = 36, Required = false)]
		public MiscFeesGrp? MiscFeesGrp {get; set;}
		
		[TagDetails(Tag = 44, Type = TagType.Float, Offset = 37, Required = false)]
		public double? Price {get; set;}
		
		[TagDetails(Tag = 423, Type = TagType.Int, Offset = 38, Required = false)]
		public int? PriceType {get; set;}
		
		[TagDetails(Tag = 159, Type = TagType.Float, Offset = 39, Required = false)]
		public double? AccruedInterestAmt {get; set;}
		
		[TagDetails(Tag = 920, Type = TagType.Float, Offset = 40, Required = false)]
		public double? EndAccruedInterestAmt {get; set;}
		
		[TagDetails(Tag = 921, Type = TagType.Float, Offset = 41, Required = false)]
		public double? StartCash {get; set;}
		
		[TagDetails(Tag = 922, Type = TagType.Float, Offset = 42, Required = false)]
		public double? EndCash {get; set;}
		
		[Component(Offset = 43, Required = false)]
		public SpreadOrBenchmarkCurveData? SpreadOrBenchmarkCurveData {get; set;}
		
		[Component(Offset = 44, Required = false)]
		public Stipulations? Stipulations {get; set;}
		
		[Component(Offset = 45, Required = false)]
		public SettlInstructionsData? SettlInstructionsData {get; set;}
		
		[TagDetails(Tag = 336, Type = TagType.String, Offset = 46, Required = false)]
		public string? TradingSessionID {get; set;}
		
		[TagDetails(Tag = 625, Type = TagType.String, Offset = 47, Required = false)]
		public string? TradingSessionSubID {get; set;}
		
		[TagDetails(Tag = 716, Type = TagType.String, Offset = 48, Required = false)]
		public string? SettlSessID {get; set;}
		
		[TagDetails(Tag = 717, Type = TagType.String, Offset = 49, Required = false)]
		public string? SettlSessSubID {get; set;}
		
		[TagDetails(Tag = 1934, Type = TagType.Int, Offset = 50, Required = false)]
		public int? RegulatoryReportType {get; set;}
		
		[TagDetails(Tag = 2869, Type = TagType.LocalDate, Offset = 51, Required = false)]
		public DateOnly? RegulatoryReportTypeBusinessDate {get; set;}
		
		[TagDetails(Tag = 715, Type = TagType.LocalDate, Offset = 52, Required = false)]
		public DateOnly? ClearingBusinessDate {get; set;}
		
		[TagDetails(Tag = 2486, Type = TagType.String, Offset = 53, Required = false)]
		public string? WireReference {get; set;}
		
		[TagDetails(Tag = 75, Type = TagType.LocalDate, Offset = 54, Required = false)]
		public DateOnly? TradeDate {get; set;}
		
		[TagDetails(Tag = 2485, Type = TagType.String, Offset = 55, Required = false)]
		public string? TransactionID {get; set;}
		
		[TagDetails(Tag = 2484, Type = TagType.String, Offset = 56, Required = false)]
		public string? FirmTransactionID {get; set;}
		
		[Component(Offset = 57, Required = false)]
		public FundingSourceGrp? FundingSourceGrp {get; set;}
		
		[Component(Offset = 58, Required = false)]
		public TransactionAttributeGrp? TransactionAttributeGrp {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 59, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 60, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 61, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 62, Required = true)]
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
			if (CollRptID is not null) writer.WriteString(908, CollRptID);
			if (CollInquiryID is not null) writer.WriteString(909, CollInquiryID);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (CollApplType is not null) writer.WriteWholeNumber(1043, CollApplType.Value);
			if (FinancialStatus is not null) writer.WriteString(291, FinancialStatus);
			if (CollStatus is not null) writer.WriteWholeNumber(910, CollStatus.Value);
			if (TotNumReports is not null) writer.WriteWholeNumber(911, TotNumReports.Value);
			if (LastRptRequested is not null) writer.WriteBoolean(912, LastRptRequested.Value);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (Account is not null) writer.WriteString(1, Account);
			if (AccountType is not null) writer.WriteWholeNumber(581, AccountType.Value);
			if (ClOrdID is not null) writer.WriteString(11, ClOrdID);
			if (OrderID is not null) writer.WriteString(37, OrderID);
			if (SecondaryOrderID is not null) writer.WriteString(198, SecondaryOrderID);
			if (SecondaryClOrdID is not null) writer.WriteString(526, SecondaryClOrdID);
			if (ExecCollGrp is not null) ((IFixEncoder)ExecCollGrp).Encode(writer);
			if (TrdCollGrp is not null) ((IFixEncoder)TrdCollGrp).Encode(writer);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (FinancingDetails is not null) ((IFixEncoder)FinancingDetails).Encode(writer);
			if (SettlDate is not null) writer.WriteLocalDateOnly(64, SettlDate.Value);
			if (Quantity is not null) writer.WriteNumber(53, Quantity.Value);
			if (QtyType is not null) writer.WriteWholeNumber(854, QtyType.Value);
			if (Currency is not null) writer.WriteString(15, Currency);
			if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
			if (InstrmtLegGrp is not null) ((IFixEncoder)InstrmtLegGrp).Encode(writer);
			if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
			if (MarginExcess is not null) writer.WriteNumber(899, MarginExcess.Value);
			if (TotalNetValue is not null) writer.WriteNumber(900, TotalNetValue.Value);
			if (CashOutstanding is not null) writer.WriteNumber(901, CashOutstanding.Value);
			if (CollateralAmountGrp is not null) ((IFixEncoder)CollateralAmountGrp).Encode(writer);
			if (CollateralizationValueDate is not null) writer.WriteLocalDateOnly(2868, CollateralizationValueDate.Value);
			if (TradeCollateralization is not null) writer.WriteWholeNumber(1936, TradeCollateralization.Value);
			if (RegulatoryTradeIDGrp is not null) ((IFixEncoder)RegulatoryTradeIDGrp).Encode(writer);
			if (TrdRegTimestamps is not null) ((IFixEncoder)TrdRegTimestamps).Encode(writer);
			if (Side is not null) writer.WriteString(54, Side);
			if (MiscFeesGrp is not null) ((IFixEncoder)MiscFeesGrp).Encode(writer);
			if (Price is not null) writer.WriteNumber(44, Price.Value);
			if (PriceType is not null) writer.WriteWholeNumber(423, PriceType.Value);
			if (AccruedInterestAmt is not null) writer.WriteNumber(159, AccruedInterestAmt.Value);
			if (EndAccruedInterestAmt is not null) writer.WriteNumber(920, EndAccruedInterestAmt.Value);
			if (StartCash is not null) writer.WriteNumber(921, StartCash.Value);
			if (EndCash is not null) writer.WriteNumber(922, EndCash.Value);
			if (SpreadOrBenchmarkCurveData is not null) ((IFixEncoder)SpreadOrBenchmarkCurveData).Encode(writer);
			if (Stipulations is not null) ((IFixEncoder)Stipulations).Encode(writer);
			if (SettlInstructionsData is not null) ((IFixEncoder)SettlInstructionsData).Encode(writer);
			if (TradingSessionID is not null) writer.WriteString(336, TradingSessionID);
			if (TradingSessionSubID is not null) writer.WriteString(625, TradingSessionSubID);
			if (SettlSessID is not null) writer.WriteString(716, SettlSessID);
			if (SettlSessSubID is not null) writer.WriteString(717, SettlSessSubID);
			if (RegulatoryReportType is not null) writer.WriteWholeNumber(1934, RegulatoryReportType.Value);
			if (RegulatoryReportTypeBusinessDate is not null) writer.WriteLocalDateOnly(2869, RegulatoryReportTypeBusinessDate.Value);
			if (ClearingBusinessDate is not null) writer.WriteLocalDateOnly(715, ClearingBusinessDate.Value);
			if (WireReference is not null) writer.WriteString(2486, WireReference);
			if (TradeDate is not null) writer.WriteLocalDateOnly(75, TradeDate.Value);
			if (TransactionID is not null) writer.WriteString(2485, TransactionID);
			if (FirmTransactionID is not null) writer.WriteString(2484, FirmTransactionID);
			if (FundingSourceGrp is not null) ((IFixEncoder)FundingSourceGrp).Encode(writer);
			if (TransactionAttributeGrp is not null) ((IFixEncoder)TransactionAttributeGrp).Encode(writer);
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
			CollRptID = view.GetString(908);
			CollInquiryID = view.GetString(909);
			TransactTime = view.GetDateTime(60);
			CollApplType = view.GetInt32(1043);
			FinancialStatus = view.GetString(291);
			CollStatus = view.GetInt32(910);
			TotNumReports = view.GetInt32(911);
			LastRptRequested = view.GetBool(912);
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			Account = view.GetString(1);
			AccountType = view.GetInt32(581);
			ClOrdID = view.GetString(11);
			OrderID = view.GetString(37);
			SecondaryOrderID = view.GetString(198);
			SecondaryClOrdID = view.GetString(526);
			if (view.GetView("ExecCollGrp") is IMessageView viewExecCollGrp)
			{
				ExecCollGrp = new();
				((IFixParser)ExecCollGrp).Parse(viewExecCollGrp);
			}
			if (view.GetView("TrdCollGrp") is IMessageView viewTrdCollGrp)
			{
				TrdCollGrp = new();
				((IFixParser)TrdCollGrp).Parse(viewTrdCollGrp);
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
			SettlDate = view.GetDateOnly(64);
			Quantity = view.GetDouble(53);
			QtyType = view.GetInt32(854);
			Currency = view.GetString(15);
			CurrencyCodeSource = view.GetString(2897);
			if (view.GetView("InstrmtLegGrp") is IMessageView viewInstrmtLegGrp)
			{
				InstrmtLegGrp = new();
				((IFixParser)InstrmtLegGrp).Parse(viewInstrmtLegGrp);
			}
			if (view.GetView("UndInstrmtGrp") is IMessageView viewUndInstrmtGrp)
			{
				UndInstrmtGrp = new();
				((IFixParser)UndInstrmtGrp).Parse(viewUndInstrmtGrp);
			}
			MarginExcess = view.GetDouble(899);
			TotalNetValue = view.GetDouble(900);
			CashOutstanding = view.GetDouble(901);
			if (view.GetView("CollateralAmountGrp") is IMessageView viewCollateralAmountGrp)
			{
				CollateralAmountGrp = new();
				((IFixParser)CollateralAmountGrp).Parse(viewCollateralAmountGrp);
			}
			CollateralizationValueDate = view.GetDateOnly(2868);
			TradeCollateralization = view.GetInt32(1936);
			if (view.GetView("RegulatoryTradeIDGrp") is IMessageView viewRegulatoryTradeIDGrp)
			{
				RegulatoryTradeIDGrp = new();
				((IFixParser)RegulatoryTradeIDGrp).Parse(viewRegulatoryTradeIDGrp);
			}
			if (view.GetView("TrdRegTimestamps") is IMessageView viewTrdRegTimestamps)
			{
				TrdRegTimestamps = new();
				((IFixParser)TrdRegTimestamps).Parse(viewTrdRegTimestamps);
			}
			Side = view.GetString(54);
			if (view.GetView("MiscFeesGrp") is IMessageView viewMiscFeesGrp)
			{
				MiscFeesGrp = new();
				((IFixParser)MiscFeesGrp).Parse(viewMiscFeesGrp);
			}
			Price = view.GetDouble(44);
			PriceType = view.GetInt32(423);
			AccruedInterestAmt = view.GetDouble(159);
			EndAccruedInterestAmt = view.GetDouble(920);
			StartCash = view.GetDouble(921);
			EndCash = view.GetDouble(922);
			if (view.GetView("SpreadOrBenchmarkCurveData") is IMessageView viewSpreadOrBenchmarkCurveData)
			{
				SpreadOrBenchmarkCurveData = new();
				((IFixParser)SpreadOrBenchmarkCurveData).Parse(viewSpreadOrBenchmarkCurveData);
			}
			if (view.GetView("Stipulations") is IMessageView viewStipulations)
			{
				Stipulations = new();
				((IFixParser)Stipulations).Parse(viewStipulations);
			}
			if (view.GetView("SettlInstructionsData") is IMessageView viewSettlInstructionsData)
			{
				SettlInstructionsData = new();
				((IFixParser)SettlInstructionsData).Parse(viewSettlInstructionsData);
			}
			TradingSessionID = view.GetString(336);
			TradingSessionSubID = view.GetString(625);
			SettlSessID = view.GetString(716);
			SettlSessSubID = view.GetString(717);
			RegulatoryReportType = view.GetInt32(1934);
			RegulatoryReportTypeBusinessDate = view.GetDateOnly(2869);
			ClearingBusinessDate = view.GetDateOnly(715);
			WireReference = view.GetString(2486);
			TradeDate = view.GetDateOnly(75);
			TransactionID = view.GetString(2485);
			FirmTransactionID = view.GetString(2484);
			if (view.GetView("FundingSourceGrp") is IMessageView viewFundingSourceGrp)
			{
				FundingSourceGrp = new();
				((IFixParser)FundingSourceGrp).Parse(viewFundingSourceGrp);
			}
			if (view.GetView("TransactionAttributeGrp") is IMessageView viewTransactionAttributeGrp)
			{
				TransactionAttributeGrp = new();
				((IFixParser)TransactionAttributeGrp).Parse(viewTransactionAttributeGrp);
			}
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
				case "CollRptID":
				{
					value = CollRptID;
					break;
				}
				case "CollInquiryID":
				{
					value = CollInquiryID;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "CollApplType":
				{
					value = CollApplType;
					break;
				}
				case "FinancialStatus":
				{
					value = FinancialStatus;
					break;
				}
				case "CollStatus":
				{
					value = CollStatus;
					break;
				}
				case "TotNumReports":
				{
					value = TotNumReports;
					break;
				}
				case "LastRptRequested":
				{
					value = LastRptRequested;
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
				case "AccountType":
				{
					value = AccountType;
					break;
				}
				case "ClOrdID":
				{
					value = ClOrdID;
					break;
				}
				case "OrderID":
				{
					value = OrderID;
					break;
				}
				case "SecondaryOrderID":
				{
					value = SecondaryOrderID;
					break;
				}
				case "SecondaryClOrdID":
				{
					value = SecondaryClOrdID;
					break;
				}
				case "ExecCollGrp":
				{
					value = ExecCollGrp;
					break;
				}
				case "TrdCollGrp":
				{
					value = TrdCollGrp;
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
				case "SettlDate":
				{
					value = SettlDate;
					break;
				}
				case "Quantity":
				{
					value = Quantity;
					break;
				}
				case "QtyType":
				{
					value = QtyType;
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
				case "InstrmtLegGrp":
				{
					value = InstrmtLegGrp;
					break;
				}
				case "UndInstrmtGrp":
				{
					value = UndInstrmtGrp;
					break;
				}
				case "MarginExcess":
				{
					value = MarginExcess;
					break;
				}
				case "TotalNetValue":
				{
					value = TotalNetValue;
					break;
				}
				case "CashOutstanding":
				{
					value = CashOutstanding;
					break;
				}
				case "CollateralAmountGrp":
				{
					value = CollateralAmountGrp;
					break;
				}
				case "CollateralizationValueDate":
				{
					value = CollateralizationValueDate;
					break;
				}
				case "TradeCollateralization":
				{
					value = TradeCollateralization;
					break;
				}
				case "RegulatoryTradeIDGrp":
				{
					value = RegulatoryTradeIDGrp;
					break;
				}
				case "TrdRegTimestamps":
				{
					value = TrdRegTimestamps;
					break;
				}
				case "Side":
				{
					value = Side;
					break;
				}
				case "MiscFeesGrp":
				{
					value = MiscFeesGrp;
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
				case "AccruedInterestAmt":
				{
					value = AccruedInterestAmt;
					break;
				}
				case "EndAccruedInterestAmt":
				{
					value = EndAccruedInterestAmt;
					break;
				}
				case "StartCash":
				{
					value = StartCash;
					break;
				}
				case "EndCash":
				{
					value = EndCash;
					break;
				}
				case "SpreadOrBenchmarkCurveData":
				{
					value = SpreadOrBenchmarkCurveData;
					break;
				}
				case "Stipulations":
				{
					value = Stipulations;
					break;
				}
				case "SettlInstructionsData":
				{
					value = SettlInstructionsData;
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
				case "SettlSessID":
				{
					value = SettlSessID;
					break;
				}
				case "SettlSessSubID":
				{
					value = SettlSessSubID;
					break;
				}
				case "RegulatoryReportType":
				{
					value = RegulatoryReportType;
					break;
				}
				case "RegulatoryReportTypeBusinessDate":
				{
					value = RegulatoryReportTypeBusinessDate;
					break;
				}
				case "ClearingBusinessDate":
				{
					value = ClearingBusinessDate;
					break;
				}
				case "WireReference":
				{
					value = WireReference;
					break;
				}
				case "TradeDate":
				{
					value = TradeDate;
					break;
				}
				case "TransactionID":
				{
					value = TransactionID;
					break;
				}
				case "FirmTransactionID":
				{
					value = FirmTransactionID;
					break;
				}
				case "FundingSourceGrp":
				{
					value = FundingSourceGrp;
					break;
				}
				case "TransactionAttributeGrp":
				{
					value = TransactionAttributeGrp;
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
			CollRptID = null;
			CollInquiryID = null;
			TransactTime = null;
			CollApplType = null;
			FinancialStatus = null;
			CollStatus = null;
			TotNumReports = null;
			LastRptRequested = null;
			((IFixReset?)Parties)?.Reset();
			Account = null;
			AccountType = null;
			ClOrdID = null;
			OrderID = null;
			SecondaryOrderID = null;
			SecondaryClOrdID = null;
			((IFixReset?)ExecCollGrp)?.Reset();
			((IFixReset?)TrdCollGrp)?.Reset();
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)FinancingDetails)?.Reset();
			SettlDate = null;
			Quantity = null;
			QtyType = null;
			Currency = null;
			CurrencyCodeSource = null;
			((IFixReset?)InstrmtLegGrp)?.Reset();
			((IFixReset?)UndInstrmtGrp)?.Reset();
			MarginExcess = null;
			TotalNetValue = null;
			CashOutstanding = null;
			((IFixReset?)CollateralAmountGrp)?.Reset();
			CollateralizationValueDate = null;
			TradeCollateralization = null;
			((IFixReset?)RegulatoryTradeIDGrp)?.Reset();
			((IFixReset?)TrdRegTimestamps)?.Reset();
			Side = null;
			((IFixReset?)MiscFeesGrp)?.Reset();
			Price = null;
			PriceType = null;
			AccruedInterestAmt = null;
			EndAccruedInterestAmt = null;
			StartCash = null;
			EndCash = null;
			((IFixReset?)SpreadOrBenchmarkCurveData)?.Reset();
			((IFixReset?)Stipulations)?.Reset();
			((IFixReset?)SettlInstructionsData)?.Reset();
			TradingSessionID = null;
			TradingSessionSubID = null;
			SettlSessID = null;
			SettlSessSubID = null;
			RegulatoryReportType = null;
			RegulatoryReportTypeBusinessDate = null;
			ClearingBusinessDate = null;
			WireReference = null;
			TradeDate = null;
			TransactionID = null;
			FirmTransactionID = null;
			((IFixReset?)FundingSourceGrp)?.Reset();
			((IFixReset?)TransactionAttributeGrp)?.Reset();
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
