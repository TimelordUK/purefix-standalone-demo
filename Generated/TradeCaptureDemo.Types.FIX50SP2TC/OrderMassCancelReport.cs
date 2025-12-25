using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("r", FixVersion.FIX50SP2)]
	public sealed partial class OrderMassCancelReport : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 11, Type = TagType.String, Offset = 1, Required = false)]
		public string? ClOrdID {get; set;}
		
		[TagDetails(Tag = 526, Type = TagType.String, Offset = 2, Required = false)]
		public string? SecondaryClOrdID {get; set;}
		
		[TagDetails(Tag = 37, Type = TagType.String, Offset = 3, Required = true)]
		public string? OrderID {get; set;}
		
		[TagDetails(Tag = 1369, Type = TagType.String, Offset = 4, Required = true)]
		public string? MassActionReportID {get; set;}
		
		[TagDetails(Tag = 198, Type = TagType.String, Offset = 5, Required = false)]
		public string? SecondaryOrderID {get; set;}
		
		[TagDetails(Tag = 530, Type = TagType.String, Offset = 6, Required = true)]
		public string? MassCancelRequestType {get; set;}
		
		[TagDetails(Tag = 531, Type = TagType.String, Offset = 7, Required = true)]
		public string? MassCancelResponse {get; set;}
		
		[TagDetails(Tag = 532, Type = TagType.Int, Offset = 8, Required = false)]
		public int? MassCancelRejectReason {get; set;}
		
		[TagDetails(Tag = 533, Type = TagType.Int, Offset = 9, Required = false)]
		public int? TotalAffectedOrders {get; set;}
		
		[Component(Offset = 10, Required = false)]
		public AffectedOrdGrp? AffectedOrdGrp {get; set;}
		
		[Component(Offset = 11, Required = false)]
		public NotAffectedOrdGrp? NotAffectedOrdGrp {get; set;}
		
		[TagDetails(Tag = 336, Type = TagType.String, Offset = 12, Required = false)]
		public string? TradingSessionID {get; set;}
		
		[TagDetails(Tag = 625, Type = TagType.String, Offset = 13, Required = false)]
		public string? TradingSessionSubID {get; set;}
		
		[Component(Offset = 14, Required = false)]
		public Parties? Parties {get; set;}
		
		[Component(Offset = 15, Required = false)]
		public TargetParties? TargetParties {get; set;}
		
		[Component(Offset = 16, Required = false)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 17, Required = false)]
		public UnderlyingInstrument? UnderlyingInstrument {get; set;}
		
		[TagDetails(Tag = 1301, Type = TagType.String, Offset = 18, Required = false)]
		public string? MarketID {get; set;}
		
		[TagDetails(Tag = 1300, Type = TagType.String, Offset = 19, Required = false)]
		public string? MarketSegmentID {get; set;}
		
		[TagDetails(Tag = 54, Type = TagType.String, Offset = 20, Required = false)]
		public string? Side {get; set;}
		
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
			if (ClOrdID is not null) writer.WriteString(11, ClOrdID);
			if (SecondaryClOrdID is not null) writer.WriteString(526, SecondaryClOrdID);
			if (OrderID is not null) writer.WriteString(37, OrderID);
			if (MassActionReportID is not null) writer.WriteString(1369, MassActionReportID);
			if (SecondaryOrderID is not null) writer.WriteString(198, SecondaryOrderID);
			if (MassCancelRequestType is not null) writer.WriteString(530, MassCancelRequestType);
			if (MassCancelResponse is not null) writer.WriteString(531, MassCancelResponse);
			if (MassCancelRejectReason is not null) writer.WriteWholeNumber(532, MassCancelRejectReason.Value);
			if (TotalAffectedOrders is not null) writer.WriteWholeNumber(533, TotalAffectedOrders.Value);
			if (AffectedOrdGrp is not null) ((IFixEncoder)AffectedOrdGrp).Encode(writer);
			if (NotAffectedOrdGrp is not null) ((IFixEncoder)NotAffectedOrdGrp).Encode(writer);
			if (TradingSessionID is not null) writer.WriteString(336, TradingSessionID);
			if (TradingSessionSubID is not null) writer.WriteString(625, TradingSessionSubID);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (TargetParties is not null) ((IFixEncoder)TargetParties).Encode(writer);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (UnderlyingInstrument is not null) ((IFixEncoder)UnderlyingInstrument).Encode(writer);
			if (MarketID is not null) writer.WriteString(1301, MarketID);
			if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
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
			ClOrdID = view.GetString(11);
			SecondaryClOrdID = view.GetString(526);
			OrderID = view.GetString(37);
			MassActionReportID = view.GetString(1369);
			SecondaryOrderID = view.GetString(198);
			MassCancelRequestType = view.GetString(530);
			MassCancelResponse = view.GetString(531);
			MassCancelRejectReason = view.GetInt32(532);
			TotalAffectedOrders = view.GetInt32(533);
			if (view.GetView("AffectedOrdGrp") is IMessageView viewAffectedOrdGrp)
			{
				AffectedOrdGrp = new();
				((IFixParser)AffectedOrdGrp).Parse(viewAffectedOrdGrp);
			}
			if (view.GetView("NotAffectedOrdGrp") is IMessageView viewNotAffectedOrdGrp)
			{
				NotAffectedOrdGrp = new();
				((IFixParser)NotAffectedOrdGrp).Parse(viewNotAffectedOrdGrp);
			}
			TradingSessionID = view.GetString(336);
			TradingSessionSubID = view.GetString(625);
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
			if (view.GetView("Instrument") is IMessageView viewInstrument)
			{
				Instrument = new();
				((IFixParser)Instrument).Parse(viewInstrument);
			}
			if (view.GetView("UnderlyingInstrument") is IMessageView viewUnderlyingInstrument)
			{
				UnderlyingInstrument = new();
				((IFixParser)UnderlyingInstrument).Parse(viewUnderlyingInstrument);
			}
			MarketID = view.GetString(1301);
			MarketSegmentID = view.GetString(1300);
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
				case "ClOrdID":
				{
					value = ClOrdID;
					break;
				}
				case "SecondaryClOrdID":
				{
					value = SecondaryClOrdID;
					break;
				}
				case "OrderID":
				{
					value = OrderID;
					break;
				}
				case "MassActionReportID":
				{
					value = MassActionReportID;
					break;
				}
				case "SecondaryOrderID":
				{
					value = SecondaryOrderID;
					break;
				}
				case "MassCancelRequestType":
				{
					value = MassCancelRequestType;
					break;
				}
				case "MassCancelResponse":
				{
					value = MassCancelResponse;
					break;
				}
				case "MassCancelRejectReason":
				{
					value = MassCancelRejectReason;
					break;
				}
				case "TotalAffectedOrders":
				{
					value = TotalAffectedOrders;
					break;
				}
				case "AffectedOrdGrp":
				{
					value = AffectedOrdGrp;
					break;
				}
				case "NotAffectedOrdGrp":
				{
					value = NotAffectedOrdGrp;
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
				case "Instrument":
				{
					value = Instrument;
					break;
				}
				case "UnderlyingInstrument":
				{
					value = UnderlyingInstrument;
					break;
				}
				case "MarketID":
				{
					value = MarketID;
					break;
				}
				case "MarketSegmentID":
				{
					value = MarketSegmentID;
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
			ClOrdID = null;
			SecondaryClOrdID = null;
			OrderID = null;
			MassActionReportID = null;
			SecondaryOrderID = null;
			MassCancelRequestType = null;
			MassCancelResponse = null;
			MassCancelRejectReason = null;
			TotalAffectedOrders = null;
			((IFixReset?)AffectedOrdGrp)?.Reset();
			((IFixReset?)NotAffectedOrdGrp)?.Reset();
			TradingSessionID = null;
			TradingSessionSubID = null;
			((IFixReset?)Parties)?.Reset();
			((IFixReset?)TargetParties)?.Reset();
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)UnderlyingInstrument)?.Reset();
			MarketID = null;
			MarketSegmentID = null;
			Side = null;
			TransactTime = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
