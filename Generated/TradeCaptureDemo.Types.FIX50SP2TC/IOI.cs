using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("6", FixVersion.FIX50SP2)]
	public sealed partial class IOI : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public ApplicationSequenceControl? ApplicationSequenceControl {get; set;}
		
		[TagDetails(Tag = 23, Type = TagType.String, Offset = 2, Required = true)]
		public string? IOIID {get; set;}
		
		[TagDetails(Tag = 28, Type = TagType.String, Offset = 3, Required = true)]
		public string? IOITransType {get; set;}
		
		[TagDetails(Tag = 26, Type = TagType.String, Offset = 4, Required = false)]
		public string? IOIRefID {get; set;}
		
		[Component(Offset = 5, Required = true)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 6, Required = false)]
		public InstrumentExtension? InstrumentExtension {get; set;}
		
		[Component(Offset = 7, Required = false)]
		public Parties? Parties {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public FinancingDetails? FinancingDetails {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public UndInstrmtGrp? UndInstrmtGrp {get; set;}
		
		[Component(Offset = 10, Required = false)]
		public RelatedInstrumentGrp? RelatedInstrumentGrp {get; set;}
		
		[TagDetails(Tag = 54, Type = TagType.String, Offset = 11, Required = true)]
		public string? Side {get; set;}
		
		[TagDetails(Tag = 854, Type = TagType.Int, Offset = 12, Required = false)]
		public int? QtyType {get; set;}
		
		[Component(Offset = 13, Required = false)]
		public OrderQtyData? OrderQtyData {get; set;}
		
		[TagDetails(Tag = 27, Type = TagType.String, Offset = 14, Required = true)]
		public string? IOIQty {get; set;}
		
		[TagDetails(Tag = 15, Type = TagType.String, Offset = 15, Required = false)]
		public string? Currency {get; set;}
		
		[TagDetails(Tag = 2897, Type = TagType.String, Offset = 16, Required = false)]
		public string? CurrencyCodeSource {get; set;}
		
		[Component(Offset = 17, Required = false)]
		public Stipulations? Stipulations {get; set;}
		
		[Component(Offset = 18, Required = false)]
		public InstrmtLegIOIGrp? InstrmtLegIOIGrp {get; set;}
		
		[TagDetails(Tag = 423, Type = TagType.Int, Offset = 19, Required = false)]
		public int? PriceType {get; set;}
		
		[Component(Offset = 20, Required = false)]
		public PriceQualifierGrp? PriceQualifierGrp {get; set;}
		
		[TagDetails(Tag = 44, Type = TagType.Float, Offset = 21, Required = false)]
		public double? Price {get; set;}
		
		[TagDetails(Tag = 62, Type = TagType.UtcTimestamp, Offset = 22, Required = false)]
		public DateTime? ValidUntilTime {get; set;}
		
		[TagDetails(Tag = 25, Type = TagType.String, Offset = 23, Required = false)]
		public string? IOIQltyInd {get; set;}
		
		[TagDetails(Tag = 130, Type = TagType.Boolean, Offset = 24, Required = false)]
		public bool? IOINaturalFlag {get; set;}
		
		[Component(Offset = 25, Required = false)]
		public IOIQualGrp? IOIQualGrp {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 26, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 27, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 28, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 29, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 149, Type = TagType.String, Offset = 30, Required = false)]
		public string? URLLink {get; set;}
		
		[Component(Offset = 31, Required = false)]
		public RoutingGrp? RoutingGrp {get; set;}
		
		[Component(Offset = 32, Required = false)]
		public SpreadOrBenchmarkCurveData? SpreadOrBenchmarkCurveData {get; set;}
		
		[Component(Offset = 33, Required = false)]
		public RelativeValueGrp? RelativeValueGrp {get; set;}
		
		[Component(Offset = 34, Required = false)]
		public YieldData? YieldData {get; set;}
		
		[Component(Offset = 35, Required = true)]
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
			if (IOIID is not null) writer.WriteString(23, IOIID);
			if (IOITransType is not null) writer.WriteString(28, IOITransType);
			if (IOIRefID is not null) writer.WriteString(26, IOIRefID);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (InstrumentExtension is not null) ((IFixEncoder)InstrumentExtension).Encode(writer);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (FinancingDetails is not null) ((IFixEncoder)FinancingDetails).Encode(writer);
			if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
			if (RelatedInstrumentGrp is not null) ((IFixEncoder)RelatedInstrumentGrp).Encode(writer);
			if (Side is not null) writer.WriteString(54, Side);
			if (QtyType is not null) writer.WriteWholeNumber(854, QtyType.Value);
			if (OrderQtyData is not null) ((IFixEncoder)OrderQtyData).Encode(writer);
			if (IOIQty is not null) writer.WriteString(27, IOIQty);
			if (Currency is not null) writer.WriteString(15, Currency);
			if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
			if (Stipulations is not null) ((IFixEncoder)Stipulations).Encode(writer);
			if (InstrmtLegIOIGrp is not null) ((IFixEncoder)InstrmtLegIOIGrp).Encode(writer);
			if (PriceType is not null) writer.WriteWholeNumber(423, PriceType.Value);
			if (PriceQualifierGrp is not null) ((IFixEncoder)PriceQualifierGrp).Encode(writer);
			if (Price is not null) writer.WriteNumber(44, Price.Value);
			if (ValidUntilTime is not null) writer.WriteUtcTimeStamp(62, ValidUntilTime.Value);
			if (IOIQltyInd is not null) writer.WriteString(25, IOIQltyInd);
			if (IOINaturalFlag is not null) writer.WriteBoolean(130, IOINaturalFlag.Value);
			if (IOIQualGrp is not null) ((IFixEncoder)IOIQualGrp).Encode(writer);
			if (Text is not null) writer.WriteString(58, Text);
			if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
			if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (URLLink is not null) writer.WriteString(149, URLLink);
			if (RoutingGrp is not null) ((IFixEncoder)RoutingGrp).Encode(writer);
			if (SpreadOrBenchmarkCurveData is not null) ((IFixEncoder)SpreadOrBenchmarkCurveData).Encode(writer);
			if (RelativeValueGrp is not null) ((IFixEncoder)RelativeValueGrp).Encode(writer);
			if (YieldData is not null) ((IFixEncoder)YieldData).Encode(writer);
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
			IOIID = view.GetString(23);
			IOITransType = view.GetString(28);
			IOIRefID = view.GetString(26);
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
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
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
			if (view.GetView("RelatedInstrumentGrp") is IMessageView viewRelatedInstrumentGrp)
			{
				RelatedInstrumentGrp = new();
				((IFixParser)RelatedInstrumentGrp).Parse(viewRelatedInstrumentGrp);
			}
			Side = view.GetString(54);
			QtyType = view.GetInt32(854);
			if (view.GetView("OrderQtyData") is IMessageView viewOrderQtyData)
			{
				OrderQtyData = new();
				((IFixParser)OrderQtyData).Parse(viewOrderQtyData);
			}
			IOIQty = view.GetString(27);
			Currency = view.GetString(15);
			CurrencyCodeSource = view.GetString(2897);
			if (view.GetView("Stipulations") is IMessageView viewStipulations)
			{
				Stipulations = new();
				((IFixParser)Stipulations).Parse(viewStipulations);
			}
			if (view.GetView("InstrmtLegIOIGrp") is IMessageView viewInstrmtLegIOIGrp)
			{
				InstrmtLegIOIGrp = new();
				((IFixParser)InstrmtLegIOIGrp).Parse(viewInstrmtLegIOIGrp);
			}
			PriceType = view.GetInt32(423);
			if (view.GetView("PriceQualifierGrp") is IMessageView viewPriceQualifierGrp)
			{
				PriceQualifierGrp = new();
				((IFixParser)PriceQualifierGrp).Parse(viewPriceQualifierGrp);
			}
			Price = view.GetDouble(44);
			ValidUntilTime = view.GetDateTime(62);
			IOIQltyInd = view.GetString(25);
			IOINaturalFlag = view.GetBool(130);
			if (view.GetView("IOIQualGrp") is IMessageView viewIOIQualGrp)
			{
				IOIQualGrp = new();
				((IFixParser)IOIQualGrp).Parse(viewIOIQualGrp);
			}
			Text = view.GetString(58);
			EncodedTextLen = view.GetInt32(354);
			EncodedText = view.GetByteArray(355);
			TransactTime = view.GetDateTime(60);
			URLLink = view.GetString(149);
			if (view.GetView("RoutingGrp") is IMessageView viewRoutingGrp)
			{
				RoutingGrp = new();
				((IFixParser)RoutingGrp).Parse(viewRoutingGrp);
			}
			if (view.GetView("SpreadOrBenchmarkCurveData") is IMessageView viewSpreadOrBenchmarkCurveData)
			{
				SpreadOrBenchmarkCurveData = new();
				((IFixParser)SpreadOrBenchmarkCurveData).Parse(viewSpreadOrBenchmarkCurveData);
			}
			if (view.GetView("RelativeValueGrp") is IMessageView viewRelativeValueGrp)
			{
				RelativeValueGrp = new();
				((IFixParser)RelativeValueGrp).Parse(viewRelativeValueGrp);
			}
			if (view.GetView("YieldData") is IMessageView viewYieldData)
			{
				YieldData = new();
				((IFixParser)YieldData).Parse(viewYieldData);
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
				case "ApplicationSequenceControl":
				{
					value = ApplicationSequenceControl;
					break;
				}
				case "IOIID":
				{
					value = IOIID;
					break;
				}
				case "IOITransType":
				{
					value = IOITransType;
					break;
				}
				case "IOIRefID":
				{
					value = IOIRefID;
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
				case "Parties":
				{
					value = Parties;
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
				case "RelatedInstrumentGrp":
				{
					value = RelatedInstrumentGrp;
					break;
				}
				case "Side":
				{
					value = Side;
					break;
				}
				case "QtyType":
				{
					value = QtyType;
					break;
				}
				case "OrderQtyData":
				{
					value = OrderQtyData;
					break;
				}
				case "IOIQty":
				{
					value = IOIQty;
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
				case "InstrmtLegIOIGrp":
				{
					value = InstrmtLegIOIGrp;
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
				case "Price":
				{
					value = Price;
					break;
				}
				case "ValidUntilTime":
				{
					value = ValidUntilTime;
					break;
				}
				case "IOIQltyInd":
				{
					value = IOIQltyInd;
					break;
				}
				case "IOINaturalFlag":
				{
					value = IOINaturalFlag;
					break;
				}
				case "IOIQualGrp":
				{
					value = IOIQualGrp;
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
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "URLLink":
				{
					value = URLLink;
					break;
				}
				case "RoutingGrp":
				{
					value = RoutingGrp;
					break;
				}
				case "SpreadOrBenchmarkCurveData":
				{
					value = SpreadOrBenchmarkCurveData;
					break;
				}
				case "RelativeValueGrp":
				{
					value = RelativeValueGrp;
					break;
				}
				case "YieldData":
				{
					value = YieldData;
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
			IOIID = null;
			IOITransType = null;
			IOIRefID = null;
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)InstrumentExtension)?.Reset();
			((IFixReset?)Parties)?.Reset();
			((IFixReset?)FinancingDetails)?.Reset();
			((IFixReset?)UndInstrmtGrp)?.Reset();
			((IFixReset?)RelatedInstrumentGrp)?.Reset();
			Side = null;
			QtyType = null;
			((IFixReset?)OrderQtyData)?.Reset();
			IOIQty = null;
			Currency = null;
			CurrencyCodeSource = null;
			((IFixReset?)Stipulations)?.Reset();
			((IFixReset?)InstrmtLegIOIGrp)?.Reset();
			PriceType = null;
			((IFixReset?)PriceQualifierGrp)?.Reset();
			Price = null;
			ValidUntilTime = null;
			IOIQltyInd = null;
			IOINaturalFlag = null;
			((IFixReset?)IOIQualGrp)?.Reset();
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			TransactTime = null;
			URLLink = null;
			((IFixReset?)RoutingGrp)?.Reset();
			((IFixReset?)SpreadOrBenchmarkCurveData)?.Reset();
			((IFixReset?)RelativeValueGrp)?.Reset();
			((IFixReset?)YieldData)?.Reset();
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
