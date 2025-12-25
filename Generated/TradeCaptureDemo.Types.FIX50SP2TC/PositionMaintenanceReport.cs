using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("AM", FixVersion.FIX50SP2)]
	public sealed partial class PositionMaintenanceReport : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 721, Type = TagType.String, Offset = 1, Required = true)]
		public string? PosMaintRptID {get; set;}
		
		[TagDetails(Tag = 709, Type = TagType.Int, Offset = 2, Required = true)]
		public int? PosTransType {get; set;}
		
		[TagDetails(Tag = 2618, Type = TagType.String, Offset = 3, Required = false)]
		public string? PositionID {get; set;}
		
		[TagDetails(Tag = 710, Type = TagType.String, Offset = 4, Required = false)]
		public string? PosReqID {get; set;}
		
		[TagDetails(Tag = 712, Type = TagType.Int, Offset = 5, Required = true)]
		public int? PosMaintAction {get; set;}
		
		[TagDetails(Tag = 713, Type = TagType.String, Offset = 6, Required = false)]
		public string? OrigPosReqRefID {get; set;}
		
		[TagDetails(Tag = 722, Type = TagType.Int, Offset = 7, Required = false)]
		public int? PosMaintStatus {get; set;}
		
		[TagDetails(Tag = 723, Type = TagType.Int, Offset = 8, Required = false)]
		public int? PosMaintResult {get; set;}
		
		[TagDetails(Tag = 715, Type = TagType.LocalDate, Offset = 9, Required = true)]
		public DateOnly? ClearingBusinessDate {get; set;}
		
		[TagDetails(Tag = 2084, Type = TagType.LocalDate, Offset = 10, Required = false)]
		public DateOnly? PreviousClearingBusinessDate {get; set;}
		
		[TagDetails(Tag = 2085, Type = TagType.LocalDate, Offset = 11, Required = false)]
		public DateOnly? ValuationDate {get; set;}
		
		[TagDetails(Tag = 2086, Type = TagType.String, Offset = 12, Required = false)]
		public string? ValuationTime {get; set;}
		
		[TagDetails(Tag = 2087, Type = TagType.String, Offset = 13, Required = false)]
		public string? ValuationBusinessCenter {get; set;}
		
		[TagDetails(Tag = 1592, Type = TagType.Float, Offset = 14, Required = false)]
		public double? DiscountFactor {get; set;}
		
		[TagDetails(Tag = 1328, Type = TagType.String, Offset = 15, Required = false)]
		public string? RejectText {get; set;}
		
		[TagDetails(Tag = 1664, Type = TagType.Length, Offset = 16, Required = false)]
		public int? EncodedRejectTextLen {get; set;}
		
		[TagDetails(Tag = 1665, Type = TagType.RawData, Offset = 17, Required = false)]
		public byte[]? EncodedRejectText {get; set;}
		
		[TagDetails(Tag = 716, Type = TagType.String, Offset = 18, Required = false)]
		public string? SettlSessID {get; set;}
		
		[TagDetails(Tag = 717, Type = TagType.String, Offset = 19, Required = false)]
		public string? SettlSessSubID {get; set;}
		
		[TagDetails(Tag = 1832, Type = TagType.Int, Offset = 20, Required = false)]
		public int? ClearedIndicator {get; set;}
		
		[TagDetails(Tag = 1833, Type = TagType.Int, Offset = 21, Required = false)]
		public int? ContractRefPosType {get; set;}
		
		[TagDetails(Tag = 1834, Type = TagType.Int, Offset = 22, Required = false)]
		public int? PositionCapacity {get; set;}
		
		[TagDetails(Tag = 2101, Type = TagType.Boolean, Offset = 23, Required = false)]
		public bool? TerminatedIndicator {get; set;}
		
		[TagDetails(Tag = 979, Type = TagType.String, Offset = 24, Required = false)]
		public string? InputSource {get; set;}
		
		[Component(Offset = 25, Required = false)]
		public Parties? Parties {get; set;}
		
		[TagDetails(Tag = 1, Type = TagType.String, Offset = 26, Required = false)]
		public string? Account {get; set;}
		
		[TagDetails(Tag = 660, Type = TagType.Int, Offset = 27, Required = false)]
		public int? AcctIDSource {get; set;}
		
		[TagDetails(Tag = 581, Type = TagType.Int, Offset = 28, Required = false)]
		public int? AccountType {get; set;}
		
		[TagDetails(Tag = 714, Type = TagType.String, Offset = 29, Required = false)]
		public string? PosMaintRptRefID {get; set;}
		
		[Component(Offset = 30, Required = true)]
		public Instrument? Instrument {get; set;}
		
		[TagDetails(Tag = 15, Type = TagType.String, Offset = 31, Required = false)]
		public string? Currency {get; set;}
		
		[TagDetails(Tag = 2897, Type = TagType.String, Offset = 32, Required = false)]
		public string? CurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 64, Type = TagType.LocalDate, Offset = 33, Required = false)]
		public DateOnly? SettlDate {get; set;}
		
		[TagDetails(Tag = 120, Type = TagType.String, Offset = 34, Required = false)]
		public string? SettlCurrency {get; set;}
		
		[TagDetails(Tag = 2899, Type = TagType.String, Offset = 35, Required = false)]
		public string? SettlCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 719, Type = TagType.Boolean, Offset = 36, Required = false)]
		public bool? ContraryInstructionIndicator {get; set;}
		
		[TagDetails(Tag = 720, Type = TagType.Boolean, Offset = 37, Required = false)]
		public bool? PriorSpreadIndicator {get; set;}
		
		[Component(Offset = 38, Required = false)]
		public InstrmtLegGrp? InstrmtLegGrp {get; set;}
		
		[Component(Offset = 39, Required = false)]
		public RelatedInstrumentGrp? RelatedInstrumentGrp {get; set;}
		
		[Component(Offset = 40, Required = false)]
		public UndInstrmtGrp? UndInstrmtGrp {get; set;}
		
		[Component(Offset = 41, Required = false)]
		public TrdgSesGrp? TrdgSesGrp {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 42, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[Component(Offset = 43, Required = false)]
		public PositionQty? PositionQty {get; set;}
		
		[Component(Offset = 44, Required = false)]
		public PositionAmountData? PositionAmountData {get; set;}
		
		[Component(Offset = 45, Required = false)]
		public RegulatoryTradeIDGrp? RegulatoryTradeIDGrp {get; set;}
		
		[Component(Offset = 46, Required = false)]
		public PaymentGrp? PaymentGrp {get; set;}
		
		[TagDetails(Tag = 718, Type = TagType.Int, Offset = 47, Required = false)]
		public int? AdjustmentType {get; set;}
		
		[TagDetails(Tag = 834, Type = TagType.Float, Offset = 48, Required = false)]
		public double? ThresholdAmount {get; set;}
		
		[Component(Offset = 49, Required = false)]
		public RelatedTradeGrp? RelatedTradeGrp {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 50, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 51, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 52, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 53, Required = true)]
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
			if (PosMaintRptID is not null) writer.WriteString(721, PosMaintRptID);
			if (PosTransType is not null) writer.WriteWholeNumber(709, PosTransType.Value);
			if (PositionID is not null) writer.WriteString(2618, PositionID);
			if (PosReqID is not null) writer.WriteString(710, PosReqID);
			if (PosMaintAction is not null) writer.WriteWholeNumber(712, PosMaintAction.Value);
			if (OrigPosReqRefID is not null) writer.WriteString(713, OrigPosReqRefID);
			if (PosMaintStatus is not null) writer.WriteWholeNumber(722, PosMaintStatus.Value);
			if (PosMaintResult is not null) writer.WriteWholeNumber(723, PosMaintResult.Value);
			if (ClearingBusinessDate is not null) writer.WriteLocalDateOnly(715, ClearingBusinessDate.Value);
			if (PreviousClearingBusinessDate is not null) writer.WriteLocalDateOnly(2084, PreviousClearingBusinessDate.Value);
			if (ValuationDate is not null) writer.WriteLocalDateOnly(2085, ValuationDate.Value);
			if (ValuationTime is not null) writer.WriteString(2086, ValuationTime);
			if (ValuationBusinessCenter is not null) writer.WriteString(2087, ValuationBusinessCenter);
			if (DiscountFactor is not null) writer.WriteNumber(1592, DiscountFactor.Value);
			if (RejectText is not null) writer.WriteString(1328, RejectText);
			if (EncodedRejectTextLen is not null) writer.WriteWholeNumber(1664, EncodedRejectTextLen.Value);
			if (EncodedRejectText is not null) writer.WriteBuffer(1665, EncodedRejectText);
			if (SettlSessID is not null) writer.WriteString(716, SettlSessID);
			if (SettlSessSubID is not null) writer.WriteString(717, SettlSessSubID);
			if (ClearedIndicator is not null) writer.WriteWholeNumber(1832, ClearedIndicator.Value);
			if (ContractRefPosType is not null) writer.WriteWholeNumber(1833, ContractRefPosType.Value);
			if (PositionCapacity is not null) writer.WriteWholeNumber(1834, PositionCapacity.Value);
			if (TerminatedIndicator is not null) writer.WriteBoolean(2101, TerminatedIndicator.Value);
			if (InputSource is not null) writer.WriteString(979, InputSource);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (Account is not null) writer.WriteString(1, Account);
			if (AcctIDSource is not null) writer.WriteWholeNumber(660, AcctIDSource.Value);
			if (AccountType is not null) writer.WriteWholeNumber(581, AccountType.Value);
			if (PosMaintRptRefID is not null) writer.WriteString(714, PosMaintRptRefID);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (Currency is not null) writer.WriteString(15, Currency);
			if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
			if (SettlDate is not null) writer.WriteLocalDateOnly(64, SettlDate.Value);
			if (SettlCurrency is not null) writer.WriteString(120, SettlCurrency);
			if (SettlCurrencyCodeSource is not null) writer.WriteString(2899, SettlCurrencyCodeSource);
			if (ContraryInstructionIndicator is not null) writer.WriteBoolean(719, ContraryInstructionIndicator.Value);
			if (PriorSpreadIndicator is not null) writer.WriteBoolean(720, PriorSpreadIndicator.Value);
			if (InstrmtLegGrp is not null) ((IFixEncoder)InstrmtLegGrp).Encode(writer);
			if (RelatedInstrumentGrp is not null) ((IFixEncoder)RelatedInstrumentGrp).Encode(writer);
			if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
			if (TrdgSesGrp is not null) ((IFixEncoder)TrdgSesGrp).Encode(writer);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (PositionQty is not null) ((IFixEncoder)PositionQty).Encode(writer);
			if (PositionAmountData is not null) ((IFixEncoder)PositionAmountData).Encode(writer);
			if (RegulatoryTradeIDGrp is not null) ((IFixEncoder)RegulatoryTradeIDGrp).Encode(writer);
			if (PaymentGrp is not null) ((IFixEncoder)PaymentGrp).Encode(writer);
			if (AdjustmentType is not null) writer.WriteWholeNumber(718, AdjustmentType.Value);
			if (ThresholdAmount is not null) writer.WriteNumber(834, ThresholdAmount.Value);
			if (RelatedTradeGrp is not null) ((IFixEncoder)RelatedTradeGrp).Encode(writer);
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
			PosMaintRptID = view.GetString(721);
			PosTransType = view.GetInt32(709);
			PositionID = view.GetString(2618);
			PosReqID = view.GetString(710);
			PosMaintAction = view.GetInt32(712);
			OrigPosReqRefID = view.GetString(713);
			PosMaintStatus = view.GetInt32(722);
			PosMaintResult = view.GetInt32(723);
			ClearingBusinessDate = view.GetDateOnly(715);
			PreviousClearingBusinessDate = view.GetDateOnly(2084);
			ValuationDate = view.GetDateOnly(2085);
			ValuationTime = view.GetString(2086);
			ValuationBusinessCenter = view.GetString(2087);
			DiscountFactor = view.GetDouble(1592);
			RejectText = view.GetString(1328);
			EncodedRejectTextLen = view.GetInt32(1664);
			EncodedRejectText = view.GetByteArray(1665);
			SettlSessID = view.GetString(716);
			SettlSessSubID = view.GetString(717);
			ClearedIndicator = view.GetInt32(1832);
			ContractRefPosType = view.GetInt32(1833);
			PositionCapacity = view.GetInt32(1834);
			TerminatedIndicator = view.GetBool(2101);
			InputSource = view.GetString(979);
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			Account = view.GetString(1);
			AcctIDSource = view.GetInt32(660);
			AccountType = view.GetInt32(581);
			PosMaintRptRefID = view.GetString(714);
			if (view.GetView("Instrument") is IMessageView viewInstrument)
			{
				Instrument = new();
				((IFixParser)Instrument).Parse(viewInstrument);
			}
			Currency = view.GetString(15);
			CurrencyCodeSource = view.GetString(2897);
			SettlDate = view.GetDateOnly(64);
			SettlCurrency = view.GetString(120);
			SettlCurrencyCodeSource = view.GetString(2899);
			ContraryInstructionIndicator = view.GetBool(719);
			PriorSpreadIndicator = view.GetBool(720);
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
			if (view.GetView("UndInstrmtGrp") is IMessageView viewUndInstrmtGrp)
			{
				UndInstrmtGrp = new();
				((IFixParser)UndInstrmtGrp).Parse(viewUndInstrmtGrp);
			}
			if (view.GetView("TrdgSesGrp") is IMessageView viewTrdgSesGrp)
			{
				TrdgSesGrp = new();
				((IFixParser)TrdgSesGrp).Parse(viewTrdgSesGrp);
			}
			TransactTime = view.GetDateTime(60);
			if (view.GetView("PositionQty") is IMessageView viewPositionQty)
			{
				PositionQty = new();
				((IFixParser)PositionQty).Parse(viewPositionQty);
			}
			if (view.GetView("PositionAmountData") is IMessageView viewPositionAmountData)
			{
				PositionAmountData = new();
				((IFixParser)PositionAmountData).Parse(viewPositionAmountData);
			}
			if (view.GetView("RegulatoryTradeIDGrp") is IMessageView viewRegulatoryTradeIDGrp)
			{
				RegulatoryTradeIDGrp = new();
				((IFixParser)RegulatoryTradeIDGrp).Parse(viewRegulatoryTradeIDGrp);
			}
			if (view.GetView("PaymentGrp") is IMessageView viewPaymentGrp)
			{
				PaymentGrp = new();
				((IFixParser)PaymentGrp).Parse(viewPaymentGrp);
			}
			AdjustmentType = view.GetInt32(718);
			ThresholdAmount = view.GetDouble(834);
			if (view.GetView("RelatedTradeGrp") is IMessageView viewRelatedTradeGrp)
			{
				RelatedTradeGrp = new();
				((IFixParser)RelatedTradeGrp).Parse(viewRelatedTradeGrp);
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
				case "PosMaintRptID":
				{
					value = PosMaintRptID;
					break;
				}
				case "PosTransType":
				{
					value = PosTransType;
					break;
				}
				case "PositionID":
				{
					value = PositionID;
					break;
				}
				case "PosReqID":
				{
					value = PosReqID;
					break;
				}
				case "PosMaintAction":
				{
					value = PosMaintAction;
					break;
				}
				case "OrigPosReqRefID":
				{
					value = OrigPosReqRefID;
					break;
				}
				case "PosMaintStatus":
				{
					value = PosMaintStatus;
					break;
				}
				case "PosMaintResult":
				{
					value = PosMaintResult;
					break;
				}
				case "ClearingBusinessDate":
				{
					value = ClearingBusinessDate;
					break;
				}
				case "PreviousClearingBusinessDate":
				{
					value = PreviousClearingBusinessDate;
					break;
				}
				case "ValuationDate":
				{
					value = ValuationDate;
					break;
				}
				case "ValuationTime":
				{
					value = ValuationTime;
					break;
				}
				case "ValuationBusinessCenter":
				{
					value = ValuationBusinessCenter;
					break;
				}
				case "DiscountFactor":
				{
					value = DiscountFactor;
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
				case "ClearedIndicator":
				{
					value = ClearedIndicator;
					break;
				}
				case "ContractRefPosType":
				{
					value = ContractRefPosType;
					break;
				}
				case "PositionCapacity":
				{
					value = PositionCapacity;
					break;
				}
				case "TerminatedIndicator":
				{
					value = TerminatedIndicator;
					break;
				}
				case "InputSource":
				{
					value = InputSource;
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
				case "PosMaintRptRefID":
				{
					value = PosMaintRptRefID;
					break;
				}
				case "Instrument":
				{
					value = Instrument;
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
				case "SettlDate":
				{
					value = SettlDate;
					break;
				}
				case "SettlCurrency":
				{
					value = SettlCurrency;
					break;
				}
				case "SettlCurrencyCodeSource":
				{
					value = SettlCurrencyCodeSource;
					break;
				}
				case "ContraryInstructionIndicator":
				{
					value = ContraryInstructionIndicator;
					break;
				}
				case "PriorSpreadIndicator":
				{
					value = PriorSpreadIndicator;
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
				case "UndInstrmtGrp":
				{
					value = UndInstrmtGrp;
					break;
				}
				case "TrdgSesGrp":
				{
					value = TrdgSesGrp;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "PositionQty":
				{
					value = PositionQty;
					break;
				}
				case "PositionAmountData":
				{
					value = PositionAmountData;
					break;
				}
				case "RegulatoryTradeIDGrp":
				{
					value = RegulatoryTradeIDGrp;
					break;
				}
				case "PaymentGrp":
				{
					value = PaymentGrp;
					break;
				}
				case "AdjustmentType":
				{
					value = AdjustmentType;
					break;
				}
				case "ThresholdAmount":
				{
					value = ThresholdAmount;
					break;
				}
				case "RelatedTradeGrp":
				{
					value = RelatedTradeGrp;
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
			PosMaintRptID = null;
			PosTransType = null;
			PositionID = null;
			PosReqID = null;
			PosMaintAction = null;
			OrigPosReqRefID = null;
			PosMaintStatus = null;
			PosMaintResult = null;
			ClearingBusinessDate = null;
			PreviousClearingBusinessDate = null;
			ValuationDate = null;
			ValuationTime = null;
			ValuationBusinessCenter = null;
			DiscountFactor = null;
			RejectText = null;
			EncodedRejectTextLen = null;
			EncodedRejectText = null;
			SettlSessID = null;
			SettlSessSubID = null;
			ClearedIndicator = null;
			ContractRefPosType = null;
			PositionCapacity = null;
			TerminatedIndicator = null;
			InputSource = null;
			((IFixReset?)Parties)?.Reset();
			Account = null;
			AcctIDSource = null;
			AccountType = null;
			PosMaintRptRefID = null;
			((IFixReset?)Instrument)?.Reset();
			Currency = null;
			CurrencyCodeSource = null;
			SettlDate = null;
			SettlCurrency = null;
			SettlCurrencyCodeSource = null;
			ContraryInstructionIndicator = null;
			PriorSpreadIndicator = null;
			((IFixReset?)InstrmtLegGrp)?.Reset();
			((IFixReset?)RelatedInstrumentGrp)?.Reset();
			((IFixReset?)UndInstrmtGrp)?.Reset();
			((IFixReset?)TrdgSesGrp)?.Reset();
			TransactTime = null;
			((IFixReset?)PositionQty)?.Reset();
			((IFixReset?)PositionAmountData)?.Reset();
			((IFixReset?)RegulatoryTradeIDGrp)?.Reset();
			((IFixReset?)PaymentGrp)?.Reset();
			AdjustmentType = null;
			ThresholdAmount = null;
			((IFixReset?)RelatedTradeGrp)?.Reset();
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
