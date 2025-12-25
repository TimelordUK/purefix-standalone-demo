using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("DF", FixVersion.FIX50SP2)]
	public sealed partial class PartyRiskLimitCheckRequest : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 2318, Type = TagType.String, Offset = 1, Required = false)]
		public string? RiskLimitCheckRequestID {get; set;}
		
		[TagDetails(Tag = 2319, Type = TagType.String, Offset = 2, Required = false)]
		public string? RiskLimitCheckID {get; set;}
		
		[TagDetails(Tag = 2320, Type = TagType.Int, Offset = 3, Required = true)]
		public int? RiskLimitCheckTransType {get; set;}
		
		[TagDetails(Tag = 2321, Type = TagType.Int, Offset = 4, Required = true)]
		public int? RiskLimitCheckType {get; set;}
		
		[TagDetails(Tag = 2322, Type = TagType.Int, Offset = 5, Required = false)]
		public int? RiskLimitCheckRequestRefID {get; set;}
		
		[TagDetails(Tag = 1080, Type = TagType.String, Offset = 6, Required = false)]
		public string? RefOrderID {get; set;}
		
		[TagDetails(Tag = 1081, Type = TagType.String, Offset = 7, Required = false)]
		public string? RefOrderIDSource {get; set;}
		
		[TagDetails(Tag = 2323, Type = TagType.Int, Offset = 8, Required = false)]
		public int? RiskLimitCheckRequestType {get; set;}
		
		[TagDetails(Tag = 2324, Type = TagType.Float, Offset = 9, Required = false)]
		public double? RiskLimitCheckAmount {get; set;}
		
		[TagDetails(Tag = 15, Type = TagType.String, Offset = 10, Required = false)]
		public string? Currency {get; set;}
		
		[TagDetails(Tag = 2897, Type = TagType.String, Offset = 11, Required = false)]
		public string? CurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 1670, Type = TagType.String, Offset = 12, Required = false)]
		public string? RiskLimitID {get; set;}
		
		[Component(Offset = 13, Required = false)]
		public RequestingPartyGrp? RequestingPartyGrp {get; set;}
		
		[Component(Offset = 14, Required = false)]
		public Parties? Parties {get; set;}
		
		[Component(Offset = 15, Required = false)]
		public RelatedPartyDetailGrp? RelatedPartyDetailGrp {get; set;}
		
		[Component(Offset = 16, Required = false)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 17, Required = false)]
		public LegOrdGrp? LegOrdGrp {get; set;}
		
		[Component(Offset = 18, Required = false)]
		public UndInstrmtGrp? UndInstrmtGrp {get; set;}
		
		[TagDetails(Tag = 54, Type = TagType.String, Offset = 19, Required = false)]
		public string? Side {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 20, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 21, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 22, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 23, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 24, Required = true)]
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
			if (RiskLimitCheckRequestID is not null) writer.WriteString(2318, RiskLimitCheckRequestID);
			if (RiskLimitCheckID is not null) writer.WriteString(2319, RiskLimitCheckID);
			if (RiskLimitCheckTransType is not null) writer.WriteWholeNumber(2320, RiskLimitCheckTransType.Value);
			if (RiskLimitCheckType is not null) writer.WriteWholeNumber(2321, RiskLimitCheckType.Value);
			if (RiskLimitCheckRequestRefID is not null) writer.WriteWholeNumber(2322, RiskLimitCheckRequestRefID.Value);
			if (RefOrderID is not null) writer.WriteString(1080, RefOrderID);
			if (RefOrderIDSource is not null) writer.WriteString(1081, RefOrderIDSource);
			if (RiskLimitCheckRequestType is not null) writer.WriteWholeNumber(2323, RiskLimitCheckRequestType.Value);
			if (RiskLimitCheckAmount is not null) writer.WriteNumber(2324, RiskLimitCheckAmount.Value);
			if (Currency is not null) writer.WriteString(15, Currency);
			if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
			if (RiskLimitID is not null) writer.WriteString(1670, RiskLimitID);
			if (RequestingPartyGrp is not null) ((IFixEncoder)RequestingPartyGrp).Encode(writer);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (RelatedPartyDetailGrp is not null) ((IFixEncoder)RelatedPartyDetailGrp).Encode(writer);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (LegOrdGrp is not null) ((IFixEncoder)LegOrdGrp).Encode(writer);
			if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
			if (Side is not null) writer.WriteString(54, Side);
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
			RiskLimitCheckRequestID = view.GetString(2318);
			RiskLimitCheckID = view.GetString(2319);
			RiskLimitCheckTransType = view.GetInt32(2320);
			RiskLimitCheckType = view.GetInt32(2321);
			RiskLimitCheckRequestRefID = view.GetInt32(2322);
			RefOrderID = view.GetString(1080);
			RefOrderIDSource = view.GetString(1081);
			RiskLimitCheckRequestType = view.GetInt32(2323);
			RiskLimitCheckAmount = view.GetDouble(2324);
			Currency = view.GetString(15);
			CurrencyCodeSource = view.GetString(2897);
			RiskLimitID = view.GetString(1670);
			if (view.GetView("RequestingPartyGrp") is IMessageView viewRequestingPartyGrp)
			{
				RequestingPartyGrp = new();
				((IFixParser)RequestingPartyGrp).Parse(viewRequestingPartyGrp);
			}
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			if (view.GetView("RelatedPartyDetailGrp") is IMessageView viewRelatedPartyDetailGrp)
			{
				RelatedPartyDetailGrp = new();
				((IFixParser)RelatedPartyDetailGrp).Parse(viewRelatedPartyDetailGrp);
			}
			if (view.GetView("Instrument") is IMessageView viewInstrument)
			{
				Instrument = new();
				((IFixParser)Instrument).Parse(viewInstrument);
			}
			if (view.GetView("LegOrdGrp") is IMessageView viewLegOrdGrp)
			{
				LegOrdGrp = new();
				((IFixParser)LegOrdGrp).Parse(viewLegOrdGrp);
			}
			if (view.GetView("UndInstrmtGrp") is IMessageView viewUndInstrmtGrp)
			{
				UndInstrmtGrp = new();
				((IFixParser)UndInstrmtGrp).Parse(viewUndInstrmtGrp);
			}
			Side = view.GetString(54);
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
				case "RiskLimitCheckRequestID":
				{
					value = RiskLimitCheckRequestID;
					break;
				}
				case "RiskLimitCheckID":
				{
					value = RiskLimitCheckID;
					break;
				}
				case "RiskLimitCheckTransType":
				{
					value = RiskLimitCheckTransType;
					break;
				}
				case "RiskLimitCheckType":
				{
					value = RiskLimitCheckType;
					break;
				}
				case "RiskLimitCheckRequestRefID":
				{
					value = RiskLimitCheckRequestRefID;
					break;
				}
				case "RefOrderID":
				{
					value = RefOrderID;
					break;
				}
				case "RefOrderIDSource":
				{
					value = RefOrderIDSource;
					break;
				}
				case "RiskLimitCheckRequestType":
				{
					value = RiskLimitCheckRequestType;
					break;
				}
				case "RiskLimitCheckAmount":
				{
					value = RiskLimitCheckAmount;
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
				case "RiskLimitID":
				{
					value = RiskLimitID;
					break;
				}
				case "RequestingPartyGrp":
				{
					value = RequestingPartyGrp;
					break;
				}
				case "Parties":
				{
					value = Parties;
					break;
				}
				case "RelatedPartyDetailGrp":
				{
					value = RelatedPartyDetailGrp;
					break;
				}
				case "Instrument":
				{
					value = Instrument;
					break;
				}
				case "LegOrdGrp":
				{
					value = LegOrdGrp;
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
			RiskLimitCheckRequestID = null;
			RiskLimitCheckID = null;
			RiskLimitCheckTransType = null;
			RiskLimitCheckType = null;
			RiskLimitCheckRequestRefID = null;
			RefOrderID = null;
			RefOrderIDSource = null;
			RiskLimitCheckRequestType = null;
			RiskLimitCheckAmount = null;
			Currency = null;
			CurrencyCodeSource = null;
			RiskLimitID = null;
			((IFixReset?)RequestingPartyGrp)?.Reset();
			((IFixReset?)Parties)?.Reset();
			((IFixReset?)RelatedPartyDetailGrp)?.Reset();
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)LegOrdGrp)?.Reset();
			((IFixReset?)UndInstrmtGrp)?.Reset();
			Side = null;
			TransactTime = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
