using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("AY", FixVersion.FIX50SP2)]
	public sealed partial class CollateralAssignment : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 902, Type = TagType.String, Offset = 1, Required = true)]
		public string? CollAsgnID {get; set;}
		
		[TagDetails(Tag = 894, Type = TagType.String, Offset = 2, Required = false)]
		public string? CollReqID {get; set;}
		
		[TagDetails(Tag = 895, Type = TagType.Int, Offset = 3, Required = true)]
		public int? CollAsgnReason {get; set;}
		
		[TagDetails(Tag = 903, Type = TagType.Int, Offset = 4, Required = true)]
		public int? CollAsgnTransType {get; set;}
		
		[TagDetails(Tag = 907, Type = TagType.String, Offset = 5, Required = false)]
		public string? CollAsgnRefID {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 6, Required = true)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 126, Type = TagType.UtcTimestamp, Offset = 7, Required = false)]
		public DateTime? ExpireTime {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public Parties? Parties {get; set;}
		
		[TagDetails(Tag = 1, Type = TagType.String, Offset = 9, Required = false)]
		public string? Account {get; set;}
		
		[TagDetails(Tag = 581, Type = TagType.Int, Offset = 10, Required = false)]
		public int? AccountType {get; set;}
		
		[TagDetails(Tag = 11, Type = TagType.String, Offset = 11, Required = false)]
		public string? ClOrdID {get; set;}
		
		[TagDetails(Tag = 37, Type = TagType.String, Offset = 12, Required = false)]
		public string? OrderID {get; set;}
		
		[TagDetails(Tag = 198, Type = TagType.String, Offset = 13, Required = false)]
		public string? SecondaryOrderID {get; set;}
		
		[TagDetails(Tag = 526, Type = TagType.String, Offset = 14, Required = false)]
		public string? SecondaryClOrdID {get; set;}
		
		[Component(Offset = 15, Required = false)]
		public ExecCollGrp? ExecCollGrp {get; set;}
		
		[Component(Offset = 16, Required = false)]
		public TrdCollGrp? TrdCollGrp {get; set;}
		
		[Component(Offset = 17, Required = false)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 18, Required = false)]
		public FinancingDetails? FinancingDetails {get; set;}
		
		[TagDetails(Tag = 64, Type = TagType.LocalDate, Offset = 19, Required = false)]
		public DateOnly? SettlDate {get; set;}
		
		[TagDetails(Tag = 53, Type = TagType.Float, Offset = 20, Required = false)]
		public double? Quantity {get; set;}
		
		[TagDetails(Tag = 854, Type = TagType.Int, Offset = 21, Required = false)]
		public int? QtyType {get; set;}
		
		[TagDetails(Tag = 15, Type = TagType.String, Offset = 22, Required = false)]
		public string? Currency {get; set;}
		
		[TagDetails(Tag = 2897, Type = TagType.String, Offset = 23, Required = false)]
		public string? CurrencyCodeSource {get; set;}
		
		[Component(Offset = 24, Required = false)]
		public InstrmtLegGrp? InstrmtLegGrp {get; set;}
		
		[Component(Offset = 25, Required = false)]
		public UndInstrmtCollGrp? UndInstrmtCollGrp {get; set;}
		
		[TagDetails(Tag = 899, Type = TagType.Float, Offset = 26, Required = false)]
		public double? MarginExcess {get; set;}
		
		[TagDetails(Tag = 900, Type = TagType.Float, Offset = 27, Required = false)]
		public double? TotalNetValue {get; set;}
		
		[TagDetails(Tag = 901, Type = TagType.Float, Offset = 28, Required = false)]
		public double? CashOutstanding {get; set;}
		
		[Component(Offset = 29, Required = false)]
		public TrdRegTimestamps? TrdRegTimestamps {get; set;}
		
		[TagDetails(Tag = 54, Type = TagType.String, Offset = 30, Required = false)]
		public string? Side {get; set;}
		
		[Component(Offset = 31, Required = false)]
		public MiscFeesGrp? MiscFeesGrp {get; set;}
		
		[TagDetails(Tag = 44, Type = TagType.Float, Offset = 32, Required = false)]
		public double? Price {get; set;}
		
		[TagDetails(Tag = 423, Type = TagType.Int, Offset = 33, Required = false)]
		public int? PriceType {get; set;}
		
		[TagDetails(Tag = 159, Type = TagType.Float, Offset = 34, Required = false)]
		public double? AccruedInterestAmt {get; set;}
		
		[TagDetails(Tag = 920, Type = TagType.Float, Offset = 35, Required = false)]
		public double? EndAccruedInterestAmt {get; set;}
		
		[TagDetails(Tag = 921, Type = TagType.Float, Offset = 36, Required = false)]
		public double? StartCash {get; set;}
		
		[TagDetails(Tag = 922, Type = TagType.Float, Offset = 37, Required = false)]
		public double? EndCash {get; set;}
		
		[Component(Offset = 38, Required = false)]
		public SpreadOrBenchmarkCurveData? SpreadOrBenchmarkCurveData {get; set;}
		
		[Component(Offset = 39, Required = false)]
		public Stipulations? Stipulations {get; set;}
		
		[Component(Offset = 40, Required = false)]
		public SettlInstructionsData? SettlInstructionsData {get; set;}
		
		[TagDetails(Tag = 336, Type = TagType.String, Offset = 41, Required = false)]
		public string? TradingSessionID {get; set;}
		
		[TagDetails(Tag = 625, Type = TagType.String, Offset = 42, Required = false)]
		public string? TradingSessionSubID {get; set;}
		
		[TagDetails(Tag = 716, Type = TagType.String, Offset = 43, Required = false)]
		public string? SettlSessID {get; set;}
		
		[TagDetails(Tag = 717, Type = TagType.String, Offset = 44, Required = false)]
		public string? SettlSessSubID {get; set;}
		
		[TagDetails(Tag = 2486, Type = TagType.String, Offset = 45, Required = false)]
		public string? WireReference {get; set;}
		
		[TagDetails(Tag = 75, Type = TagType.LocalDate, Offset = 46, Required = false)]
		public DateOnly? TradeDate {get; set;}
		
		[TagDetails(Tag = 2485, Type = TagType.String, Offset = 47, Required = false)]
		public string? TransactionID {get; set;}
		
		[TagDetails(Tag = 2484, Type = TagType.String, Offset = 48, Required = false)]
		public string? FirmTransactionID {get; set;}
		
		[TagDetails(Tag = 715, Type = TagType.LocalDate, Offset = 49, Required = false)]
		public DateOnly? ClearingBusinessDate {get; set;}
		
		[TagDetails(Tag = 2517, Type = TagType.String, Offset = 50, Required = false)]
		public string? CollateralRequestLinkID {get; set;}
		
		[TagDetails(Tag = 2519, Type = TagType.Int, Offset = 51, Required = false)]
		public int? TotNumCollateralRequests {get; set;}
		
		[TagDetails(Tag = 2518, Type = TagType.Int, Offset = 52, Required = false)]
		public int? CollateralRequestNumber {get; set;}
		
		[TagDetails(Tag = 2516, Type = TagType.String, Offset = 53, Required = false)]
		public string? CollateralRequestInstruction {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 54, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 55, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 56, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 57, Required = true)]
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
			if (CollAsgnID is not null) writer.WriteString(902, CollAsgnID);
			if (CollReqID is not null) writer.WriteString(894, CollReqID);
			if (CollAsgnReason is not null) writer.WriteWholeNumber(895, CollAsgnReason.Value);
			if (CollAsgnTransType is not null) writer.WriteWholeNumber(903, CollAsgnTransType.Value);
			if (CollAsgnRefID is not null) writer.WriteString(907, CollAsgnRefID);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (ExpireTime is not null) writer.WriteUtcTimeStamp(126, ExpireTime.Value);
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
			if (UndInstrmtCollGrp is not null) ((IFixEncoder)UndInstrmtCollGrp).Encode(writer);
			if (MarginExcess is not null) writer.WriteNumber(899, MarginExcess.Value);
			if (TotalNetValue is not null) writer.WriteNumber(900, TotalNetValue.Value);
			if (CashOutstanding is not null) writer.WriteNumber(901, CashOutstanding.Value);
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
			if (WireReference is not null) writer.WriteString(2486, WireReference);
			if (TradeDate is not null) writer.WriteLocalDateOnly(75, TradeDate.Value);
			if (TransactionID is not null) writer.WriteString(2485, TransactionID);
			if (FirmTransactionID is not null) writer.WriteString(2484, FirmTransactionID);
			if (ClearingBusinessDate is not null) writer.WriteLocalDateOnly(715, ClearingBusinessDate.Value);
			if (CollateralRequestLinkID is not null) writer.WriteString(2517, CollateralRequestLinkID);
			if (TotNumCollateralRequests is not null) writer.WriteWholeNumber(2519, TotNumCollateralRequests.Value);
			if (CollateralRequestNumber is not null) writer.WriteWholeNumber(2518, CollateralRequestNumber.Value);
			if (CollateralRequestInstruction is not null) writer.WriteString(2516, CollateralRequestInstruction);
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
			CollAsgnID = view.GetString(902);
			CollReqID = view.GetString(894);
			CollAsgnReason = view.GetInt32(895);
			CollAsgnTransType = view.GetInt32(903);
			CollAsgnRefID = view.GetString(907);
			TransactTime = view.GetDateTime(60);
			ExpireTime = view.GetDateTime(126);
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
			if (view.GetView("UndInstrmtCollGrp") is IMessageView viewUndInstrmtCollGrp)
			{
				UndInstrmtCollGrp = new();
				((IFixParser)UndInstrmtCollGrp).Parse(viewUndInstrmtCollGrp);
			}
			MarginExcess = view.GetDouble(899);
			TotalNetValue = view.GetDouble(900);
			CashOutstanding = view.GetDouble(901);
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
			WireReference = view.GetString(2486);
			TradeDate = view.GetDateOnly(75);
			TransactionID = view.GetString(2485);
			FirmTransactionID = view.GetString(2484);
			ClearingBusinessDate = view.GetDateOnly(715);
			CollateralRequestLinkID = view.GetString(2517);
			TotNumCollateralRequests = view.GetInt32(2519);
			CollateralRequestNumber = view.GetInt32(2518);
			CollateralRequestInstruction = view.GetString(2516);
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
				case "CollAsgnID":
				{
					value = CollAsgnID;
					break;
				}
				case "CollReqID":
				{
					value = CollReqID;
					break;
				}
				case "CollAsgnReason":
				{
					value = CollAsgnReason;
					break;
				}
				case "CollAsgnTransType":
				{
					value = CollAsgnTransType;
					break;
				}
				case "CollAsgnRefID":
				{
					value = CollAsgnRefID;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "ExpireTime":
				{
					value = ExpireTime;
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
				case "UndInstrmtCollGrp":
				{
					value = UndInstrmtCollGrp;
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
				case "ClearingBusinessDate":
				{
					value = ClearingBusinessDate;
					break;
				}
				case "CollateralRequestLinkID":
				{
					value = CollateralRequestLinkID;
					break;
				}
				case "TotNumCollateralRequests":
				{
					value = TotNumCollateralRequests;
					break;
				}
				case "CollateralRequestNumber":
				{
					value = CollateralRequestNumber;
					break;
				}
				case "CollateralRequestInstruction":
				{
					value = CollateralRequestInstruction;
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
			CollAsgnID = null;
			CollReqID = null;
			CollAsgnReason = null;
			CollAsgnTransType = null;
			CollAsgnRefID = null;
			TransactTime = null;
			ExpireTime = null;
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
			((IFixReset?)UndInstrmtCollGrp)?.Reset();
			MarginExcess = null;
			TotalNetValue = null;
			CashOutstanding = null;
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
			WireReference = null;
			TradeDate = null;
			TransactionID = null;
			FirmTransactionID = null;
			ClearingBusinessDate = null;
			CollateralRequestLinkID = null;
			TotNumCollateralRequests = null;
			CollateralRequestNumber = null;
			CollateralRequestInstruction = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
