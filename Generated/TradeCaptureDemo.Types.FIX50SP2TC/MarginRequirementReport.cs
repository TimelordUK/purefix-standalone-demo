using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("CJ", FixVersion.FIX50SP2)]
	public sealed partial class MarginRequirementReport : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public ApplicationSequenceControl? ApplicationSequenceControl {get; set;}
		
		[TagDetails(Tag = 1642, Type = TagType.String, Offset = 2, Required = true)]
		public string? MarginReqmtRptID {get; set;}
		
		[TagDetails(Tag = 1635, Type = TagType.String, Offset = 3, Required = false)]
		public string? MarginReqmtInqID {get; set;}
		
		[TagDetails(Tag = 1638, Type = TagType.Int, Offset = 4, Required = true)]
		public int? MarginReqmtRptType {get; set;}
		
		[TagDetails(Tag = 911, Type = TagType.Int, Offset = 5, Required = false)]
		public int? TotNumReports {get; set;}
		
		[TagDetails(Tag = 912, Type = TagType.Boolean, Offset = 6, Required = false)]
		public bool? LastRptRequested {get; set;}
		
		[TagDetails(Tag = 325, Type = TagType.Boolean, Offset = 7, Required = false)]
		public bool? UnsolicitedIndicator {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public Parties? Parties {get; set;}
		
		[TagDetails(Tag = 1934, Type = TagType.Int, Offset = 9, Required = false)]
		public int? RegulatoryReportType {get; set;}
		
		[TagDetails(Tag = 2869, Type = TagType.LocalDate, Offset = 10, Required = false)]
		public DateOnly? RegulatoryReportTypeBusinessDate {get; set;}
		
		[Component(Offset = 11, Required = false)]
		public TrdRegTimestamps? TrdRegTimestamps {get; set;}
		
		[TagDetails(Tag = 715, Type = TagType.LocalDate, Offset = 12, Required = false)]
		public DateOnly? ClearingBusinessDate {get; set;}
		
		[TagDetails(Tag = 2870, Type = TagType.String, Offset = 13, Required = false)]
		public string? ClearingPortfolioID {get; set;}
		
		[TagDetails(Tag = 716, Type = TagType.String, Offset = 14, Required = false)]
		public string? SettlSessID {get; set;}
		
		[TagDetails(Tag = 717, Type = TagType.String, Offset = 15, Required = false)]
		public string? SettlSessSubID {get; set;}
		
		[TagDetails(Tag = 1639, Type = TagType.String, Offset = 16, Required = false)]
		public string? MarginClass {get; set;}
		
		[TagDetails(Tag = 15, Type = TagType.String, Offset = 17, Required = false)]
		public string? Currency {get; set;}
		
		[TagDetails(Tag = 2897, Type = TagType.String, Offset = 18, Required = false)]
		public string? CurrencyCodeSource {get; set;}
		
		[Component(Offset = 19, Required = false)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 20, Required = true)]
		public MarginAmount? MarginAmount {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 21, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 22, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 23, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 24, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 25, Required = true)]
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
			if (MarginReqmtRptID is not null) writer.WriteString(1642, MarginReqmtRptID);
			if (MarginReqmtInqID is not null) writer.WriteString(1635, MarginReqmtInqID);
			if (MarginReqmtRptType is not null) writer.WriteWholeNumber(1638, MarginReqmtRptType.Value);
			if (TotNumReports is not null) writer.WriteWholeNumber(911, TotNumReports.Value);
			if (LastRptRequested is not null) writer.WriteBoolean(912, LastRptRequested.Value);
			if (UnsolicitedIndicator is not null) writer.WriteBoolean(325, UnsolicitedIndicator.Value);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (RegulatoryReportType is not null) writer.WriteWholeNumber(1934, RegulatoryReportType.Value);
			if (RegulatoryReportTypeBusinessDate is not null) writer.WriteLocalDateOnly(2869, RegulatoryReportTypeBusinessDate.Value);
			if (TrdRegTimestamps is not null) ((IFixEncoder)TrdRegTimestamps).Encode(writer);
			if (ClearingBusinessDate is not null) writer.WriteLocalDateOnly(715, ClearingBusinessDate.Value);
			if (ClearingPortfolioID is not null) writer.WriteString(2870, ClearingPortfolioID);
			if (SettlSessID is not null) writer.WriteString(716, SettlSessID);
			if (SettlSessSubID is not null) writer.WriteString(717, SettlSessSubID);
			if (MarginClass is not null) writer.WriteString(1639, MarginClass);
			if (Currency is not null) writer.WriteString(15, Currency);
			if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (MarginAmount is not null) ((IFixEncoder)MarginAmount).Encode(writer);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
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
			MarginReqmtRptID = view.GetString(1642);
			MarginReqmtInqID = view.GetString(1635);
			MarginReqmtRptType = view.GetInt32(1638);
			TotNumReports = view.GetInt32(911);
			LastRptRequested = view.GetBool(912);
			UnsolicitedIndicator = view.GetBool(325);
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			RegulatoryReportType = view.GetInt32(1934);
			RegulatoryReportTypeBusinessDate = view.GetDateOnly(2869);
			if (view.GetView("TrdRegTimestamps") is IMessageView viewTrdRegTimestamps)
			{
				TrdRegTimestamps = new();
				((IFixParser)TrdRegTimestamps).Parse(viewTrdRegTimestamps);
			}
			ClearingBusinessDate = view.GetDateOnly(715);
			ClearingPortfolioID = view.GetString(2870);
			SettlSessID = view.GetString(716);
			SettlSessSubID = view.GetString(717);
			MarginClass = view.GetString(1639);
			Currency = view.GetString(15);
			CurrencyCodeSource = view.GetString(2897);
			if (view.GetView("Instrument") is IMessageView viewInstrument)
			{
				Instrument = new();
				((IFixParser)Instrument).Parse(viewInstrument);
			}
			if (view.GetView("MarginAmount") is IMessageView viewMarginAmount)
			{
				MarginAmount = new();
				((IFixParser)MarginAmount).Parse(viewMarginAmount);
			}
			TransactTime = view.GetDateTime(60);
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
				case "MarginReqmtRptID":
				{
					value = MarginReqmtRptID;
					break;
				}
				case "MarginReqmtInqID":
				{
					value = MarginReqmtInqID;
					break;
				}
				case "MarginReqmtRptType":
				{
					value = MarginReqmtRptType;
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
				case "UnsolicitedIndicator":
				{
					value = UnsolicitedIndicator;
					break;
				}
				case "Parties":
				{
					value = Parties;
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
				case "TrdRegTimestamps":
				{
					value = TrdRegTimestamps;
					break;
				}
				case "ClearingBusinessDate":
				{
					value = ClearingBusinessDate;
					break;
				}
				case "ClearingPortfolioID":
				{
					value = ClearingPortfolioID;
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
				case "MarginClass":
				{
					value = MarginClass;
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
				case "Instrument":
				{
					value = Instrument;
					break;
				}
				case "MarginAmount":
				{
					value = MarginAmount;
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
			MarginReqmtRptID = null;
			MarginReqmtInqID = null;
			MarginReqmtRptType = null;
			TotNumReports = null;
			LastRptRequested = null;
			UnsolicitedIndicator = null;
			((IFixReset?)Parties)?.Reset();
			RegulatoryReportType = null;
			RegulatoryReportTypeBusinessDate = null;
			((IFixReset?)TrdRegTimestamps)?.Reset();
			ClearingBusinessDate = null;
			ClearingPortfolioID = null;
			SettlSessID = null;
			SettlSessSubID = null;
			MarginClass = null;
			Currency = null;
			CurrencyCodeSource = null;
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)MarginAmount)?.Reset();
			TransactTime = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
