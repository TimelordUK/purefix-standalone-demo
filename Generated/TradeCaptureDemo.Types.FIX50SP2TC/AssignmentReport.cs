using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("AW", FixVersion.FIX50SP2)]
	public sealed partial class AssignmentReport : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public ApplicationSequenceControl? ApplicationSequenceControl {get; set;}
		
		[TagDetails(Tag = 833, Type = TagType.String, Offset = 2, Required = true)]
		public string? AsgnRptID {get; set;}
		
		[TagDetails(Tag = 710, Type = TagType.String, Offset = 3, Required = false)]
		public string? PosReqID {get; set;}
		
		[TagDetails(Tag = 832, Type = TagType.Int, Offset = 4, Required = false)]
		public int? TotNumAssignmentReports {get; set;}
		
		[TagDetails(Tag = 912, Type = TagType.Boolean, Offset = 5, Required = false)]
		public bool? LastRptRequested {get; set;}
		
		[Component(Offset = 6, Required = true)]
		public Parties? Parties {get; set;}
		
		[TagDetails(Tag = 1, Type = TagType.String, Offset = 7, Required = false)]
		public string? Account {get; set;}
		
		[TagDetails(Tag = 581, Type = TagType.Int, Offset = 8, Required = false)]
		public int? AccountType {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public Instrument? Instrument {get; set;}
		
		[TagDetails(Tag = 15, Type = TagType.String, Offset = 10, Required = false)]
		public string? Currency {get; set;}
		
		[TagDetails(Tag = 2897, Type = TagType.String, Offset = 11, Required = false)]
		public string? CurrencyCodeSource {get; set;}
		
		[Component(Offset = 12, Required = false)]
		public InstrmtLegGrp? InstrmtLegGrp {get; set;}
		
		[Component(Offset = 13, Required = false)]
		public UndInstrmtGrp? UndInstrmtGrp {get; set;}
		
		[Component(Offset = 14, Required = false)]
		public PositionQty? PositionQty {get; set;}
		
		[Component(Offset = 15, Required = false)]
		public PositionAmountData? PositionAmountData {get; set;}
		
		[TagDetails(Tag = 834, Type = TagType.Float, Offset = 16, Required = false)]
		public double? ThresholdAmount {get; set;}
		
		[TagDetails(Tag = 730, Type = TagType.Float, Offset = 17, Required = false)]
		public double? SettlPrice {get; set;}
		
		[TagDetails(Tag = 731, Type = TagType.Int, Offset = 18, Required = false)]
		public int? SettlPriceType {get; set;}
		
		[TagDetails(Tag = 732, Type = TagType.Float, Offset = 19, Required = false)]
		public double? UnderlyingSettlPrice {get; set;}
		
		[TagDetails(Tag = 734, Type = TagType.Float, Offset = 20, Required = false)]
		public double? PriorSettlPrice {get; set;}
		
		[TagDetails(Tag = 1595, Type = TagType.Float, Offset = 21, Required = false)]
		public double? PositionContingentPrice {get; set;}
		
		[TagDetails(Tag = 432, Type = TagType.LocalDate, Offset = 22, Required = false)]
		public DateOnly? ExpireDate {get; set;}
		
		[TagDetails(Tag = 744, Type = TagType.String, Offset = 23, Required = false)]
		public string? AssignmentMethod {get; set;}
		
		[TagDetails(Tag = 745, Type = TagType.Float, Offset = 24, Required = false)]
		public double? AssignmentUnit {get; set;}
		
		[TagDetails(Tag = 746, Type = TagType.Float, Offset = 25, Required = false)]
		public double? OpenInterest {get; set;}
		
		[TagDetails(Tag = 747, Type = TagType.String, Offset = 26, Required = false)]
		public string? ExerciseMethod {get; set;}
		
		[TagDetails(Tag = 716, Type = TagType.String, Offset = 27, Required = false)]
		public string? SettlSessID {get; set;}
		
		[TagDetails(Tag = 717, Type = TagType.String, Offset = 28, Required = false)]
		public string? SettlSessSubID {get; set;}
		
		[TagDetails(Tag = 715, Type = TagType.LocalDate, Offset = 29, Required = true)]
		public DateOnly? ClearingBusinessDate {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 30, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 31, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 32, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 33, Required = true)]
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
			if (AsgnRptID is not null) writer.WriteString(833, AsgnRptID);
			if (PosReqID is not null) writer.WriteString(710, PosReqID);
			if (TotNumAssignmentReports is not null) writer.WriteWholeNumber(832, TotNumAssignmentReports.Value);
			if (LastRptRequested is not null) writer.WriteBoolean(912, LastRptRequested.Value);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (Account is not null) writer.WriteString(1, Account);
			if (AccountType is not null) writer.WriteWholeNumber(581, AccountType.Value);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (Currency is not null) writer.WriteString(15, Currency);
			if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
			if (InstrmtLegGrp is not null) ((IFixEncoder)InstrmtLegGrp).Encode(writer);
			if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
			if (PositionQty is not null) ((IFixEncoder)PositionQty).Encode(writer);
			if (PositionAmountData is not null) ((IFixEncoder)PositionAmountData).Encode(writer);
			if (ThresholdAmount is not null) writer.WriteNumber(834, ThresholdAmount.Value);
			if (SettlPrice is not null) writer.WriteNumber(730, SettlPrice.Value);
			if (SettlPriceType is not null) writer.WriteWholeNumber(731, SettlPriceType.Value);
			if (UnderlyingSettlPrice is not null) writer.WriteNumber(732, UnderlyingSettlPrice.Value);
			if (PriorSettlPrice is not null) writer.WriteNumber(734, PriorSettlPrice.Value);
			if (PositionContingentPrice is not null) writer.WriteNumber(1595, PositionContingentPrice.Value);
			if (ExpireDate is not null) writer.WriteLocalDateOnly(432, ExpireDate.Value);
			if (AssignmentMethod is not null) writer.WriteString(744, AssignmentMethod);
			if (AssignmentUnit is not null) writer.WriteNumber(745, AssignmentUnit.Value);
			if (OpenInterest is not null) writer.WriteNumber(746, OpenInterest.Value);
			if (ExerciseMethod is not null) writer.WriteString(747, ExerciseMethod);
			if (SettlSessID is not null) writer.WriteString(716, SettlSessID);
			if (SettlSessSubID is not null) writer.WriteString(717, SettlSessSubID);
			if (ClearingBusinessDate is not null) writer.WriteLocalDateOnly(715, ClearingBusinessDate.Value);
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
			AsgnRptID = view.GetString(833);
			PosReqID = view.GetString(710);
			TotNumAssignmentReports = view.GetInt32(832);
			LastRptRequested = view.GetBool(912);
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			Account = view.GetString(1);
			AccountType = view.GetInt32(581);
			if (view.GetView("Instrument") is IMessageView viewInstrument)
			{
				Instrument = new();
				((IFixParser)Instrument).Parse(viewInstrument);
			}
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
			ThresholdAmount = view.GetDouble(834);
			SettlPrice = view.GetDouble(730);
			SettlPriceType = view.GetInt32(731);
			UnderlyingSettlPrice = view.GetDouble(732);
			PriorSettlPrice = view.GetDouble(734);
			PositionContingentPrice = view.GetDouble(1595);
			ExpireDate = view.GetDateOnly(432);
			AssignmentMethod = view.GetString(744);
			AssignmentUnit = view.GetDouble(745);
			OpenInterest = view.GetDouble(746);
			ExerciseMethod = view.GetString(747);
			SettlSessID = view.GetString(716);
			SettlSessSubID = view.GetString(717);
			ClearingBusinessDate = view.GetDateOnly(715);
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
				case "AsgnRptID":
				{
					value = AsgnRptID;
					break;
				}
				case "PosReqID":
				{
					value = PosReqID;
					break;
				}
				case "TotNumAssignmentReports":
				{
					value = TotNumAssignmentReports;
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
				case "ThresholdAmount":
				{
					value = ThresholdAmount;
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
				case "UnderlyingSettlPrice":
				{
					value = UnderlyingSettlPrice;
					break;
				}
				case "PriorSettlPrice":
				{
					value = PriorSettlPrice;
					break;
				}
				case "PositionContingentPrice":
				{
					value = PositionContingentPrice;
					break;
				}
				case "ExpireDate":
				{
					value = ExpireDate;
					break;
				}
				case "AssignmentMethod":
				{
					value = AssignmentMethod;
					break;
				}
				case "AssignmentUnit":
				{
					value = AssignmentUnit;
					break;
				}
				case "OpenInterest":
				{
					value = OpenInterest;
					break;
				}
				case "ExerciseMethod":
				{
					value = ExerciseMethod;
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
				case "ClearingBusinessDate":
				{
					value = ClearingBusinessDate;
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
			AsgnRptID = null;
			PosReqID = null;
			TotNumAssignmentReports = null;
			LastRptRequested = null;
			((IFixReset?)Parties)?.Reset();
			Account = null;
			AccountType = null;
			((IFixReset?)Instrument)?.Reset();
			Currency = null;
			CurrencyCodeSource = null;
			((IFixReset?)InstrmtLegGrp)?.Reset();
			((IFixReset?)UndInstrmtGrp)?.Reset();
			((IFixReset?)PositionQty)?.Reset();
			((IFixReset?)PositionAmountData)?.Reset();
			ThresholdAmount = null;
			SettlPrice = null;
			SettlPriceType = null;
			UnderlyingSettlPrice = null;
			PriorSettlPrice = null;
			PositionContingentPrice = null;
			ExpireDate = null;
			AssignmentMethod = null;
			AssignmentUnit = null;
			OpenInterest = null;
			ExerciseMethod = null;
			SettlSessID = null;
			SettlSessSubID = null;
			ClearingBusinessDate = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
