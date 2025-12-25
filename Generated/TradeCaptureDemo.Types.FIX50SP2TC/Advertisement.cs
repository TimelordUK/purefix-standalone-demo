using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("7", FixVersion.FIX50SP2)]
	public sealed partial class Advertisement : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 2, Type = TagType.String, Offset = 1, Required = true)]
		public string? AdvId {get; set;}
		
		[TagDetails(Tag = 5, Type = TagType.String, Offset = 2, Required = true)]
		public string? AdvTransType {get; set;}
		
		[TagDetails(Tag = 3, Type = TagType.String, Offset = 3, Required = false)]
		public string? AdvRefID {get; set;}
		
		[Component(Offset = 4, Required = true)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 5, Required = false)]
		public InstrumentExtension? InstrumentExtension {get; set;}
		
		[Component(Offset = 6, Required = false)]
		public FinancingDetails? FinancingDetails {get; set;}
		
		[Component(Offset = 7, Required = false)]
		public InstrmtLegGrp? InstrmtLegGrp {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public UndInstrmtGrp? UndInstrmtGrp {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public RelatedInstrumentGrp? RelatedInstrumentGrp {get; set;}
		
		[TagDetails(Tag = 4, Type = TagType.String, Offset = 10, Required = true)]
		public string? AdvSide {get; set;}
		
		[TagDetails(Tag = 53, Type = TagType.Float, Offset = 11, Required = true)]
		public double? Quantity {get; set;}
		
		[TagDetails(Tag = 854, Type = TagType.Int, Offset = 12, Required = false)]
		public int? QtyType {get; set;}
		
		[TagDetails(Tag = 44, Type = TagType.Float, Offset = 13, Required = false)]
		public double? Price {get; set;}
		
		[TagDetails(Tag = 15, Type = TagType.String, Offset = 14, Required = false)]
		public string? Currency {get; set;}
		
		[TagDetails(Tag = 2897, Type = TagType.String, Offset = 15, Required = false)]
		public string? CurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 75, Type = TagType.LocalDate, Offset = 16, Required = false)]
		public DateOnly? TradeDate {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 17, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 18, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 19, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 20, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[TagDetails(Tag = 149, Type = TagType.String, Offset = 21, Required = false)]
		public string? URLLink {get; set;}
		
		[TagDetails(Tag = 30, Type = TagType.String, Offset = 22, Required = false)]
		public string? LastMkt {get; set;}
		
		[TagDetails(Tag = 336, Type = TagType.String, Offset = 23, Required = false)]
		public string? TradingSessionID {get; set;}
		
		[TagDetails(Tag = 625, Type = TagType.String, Offset = 24, Required = false)]
		public string? TradingSessionSubID {get; set;}
		
		[Component(Offset = 25, Required = false)]
		public RoutingGrp? RoutingGrp {get; set;}
		
		[Component(Offset = 26, Required = true)]
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
			if (AdvId is not null) writer.WriteString(2, AdvId);
			if (AdvTransType is not null) writer.WriteString(5, AdvTransType);
			if (AdvRefID is not null) writer.WriteString(3, AdvRefID);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (InstrumentExtension is not null) ((IFixEncoder)InstrumentExtension).Encode(writer);
			if (FinancingDetails is not null) ((IFixEncoder)FinancingDetails).Encode(writer);
			if (InstrmtLegGrp is not null) ((IFixEncoder)InstrmtLegGrp).Encode(writer);
			if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
			if (RelatedInstrumentGrp is not null) ((IFixEncoder)RelatedInstrumentGrp).Encode(writer);
			if (AdvSide is not null) writer.WriteString(4, AdvSide);
			if (Quantity is not null) writer.WriteNumber(53, Quantity.Value);
			if (QtyType is not null) writer.WriteWholeNumber(854, QtyType.Value);
			if (Price is not null) writer.WriteNumber(44, Price.Value);
			if (Currency is not null) writer.WriteString(15, Currency);
			if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
			if (TradeDate is not null) writer.WriteLocalDateOnly(75, TradeDate.Value);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (Text is not null) writer.WriteString(58, Text);
			if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
			if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
			if (URLLink is not null) writer.WriteString(149, URLLink);
			if (LastMkt is not null) writer.WriteString(30, LastMkt);
			if (TradingSessionID is not null) writer.WriteString(336, TradingSessionID);
			if (TradingSessionSubID is not null) writer.WriteString(625, TradingSessionSubID);
			if (RoutingGrp is not null) ((IFixEncoder)RoutingGrp).Encode(writer);
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
			AdvId = view.GetString(2);
			AdvTransType = view.GetString(5);
			AdvRefID = view.GetString(3);
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
			if (view.GetView("RelatedInstrumentGrp") is IMessageView viewRelatedInstrumentGrp)
			{
				RelatedInstrumentGrp = new();
				((IFixParser)RelatedInstrumentGrp).Parse(viewRelatedInstrumentGrp);
			}
			AdvSide = view.GetString(4);
			Quantity = view.GetDouble(53);
			QtyType = view.GetInt32(854);
			Price = view.GetDouble(44);
			Currency = view.GetString(15);
			CurrencyCodeSource = view.GetString(2897);
			TradeDate = view.GetDateOnly(75);
			TransactTime = view.GetDateTime(60);
			Text = view.GetString(58);
			EncodedTextLen = view.GetInt32(354);
			EncodedText = view.GetByteArray(355);
			URLLink = view.GetString(149);
			LastMkt = view.GetString(30);
			TradingSessionID = view.GetString(336);
			TradingSessionSubID = view.GetString(625);
			if (view.GetView("RoutingGrp") is IMessageView viewRoutingGrp)
			{
				RoutingGrp = new();
				((IFixParser)RoutingGrp).Parse(viewRoutingGrp);
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
				case "AdvId":
				{
					value = AdvId;
					break;
				}
				case "AdvTransType":
				{
					value = AdvTransType;
					break;
				}
				case "AdvRefID":
				{
					value = AdvRefID;
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
				case "RelatedInstrumentGrp":
				{
					value = RelatedInstrumentGrp;
					break;
				}
				case "AdvSide":
				{
					value = AdvSide;
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
				case "Price":
				{
					value = Price;
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
				case "TradeDate":
				{
					value = TradeDate;
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
				case "URLLink":
				{
					value = URLLink;
					break;
				}
				case "LastMkt":
				{
					value = LastMkt;
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
				case "RoutingGrp":
				{
					value = RoutingGrp;
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
			AdvId = null;
			AdvTransType = null;
			AdvRefID = null;
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)InstrumentExtension)?.Reset();
			((IFixReset?)FinancingDetails)?.Reset();
			((IFixReset?)InstrmtLegGrp)?.Reset();
			((IFixReset?)UndInstrmtGrp)?.Reset();
			((IFixReset?)RelatedInstrumentGrp)?.Reset();
			AdvSide = null;
			Quantity = null;
			QtyType = null;
			Price = null;
			Currency = null;
			CurrencyCodeSource = null;
			TradeDate = null;
			TransactTime = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			URLLink = null;
			LastMkt = null;
			TradingSessionID = null;
			TradingSessionSubID = null;
			((IFixReset?)RoutingGrp)?.Reset();
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
