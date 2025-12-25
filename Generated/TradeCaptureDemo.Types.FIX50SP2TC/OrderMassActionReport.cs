using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("BZ", FixVersion.FIX50SP2)]
	public sealed partial class OrderMassActionReport : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 11, Type = TagType.String, Offset = 1, Required = false)]
		public string? ClOrdID {get; set;}
		
		[TagDetails(Tag = 526, Type = TagType.String, Offset = 2, Required = false)]
		public string? SecondaryClOrdID {get; set;}
		
		[TagDetails(Tag = 1369, Type = TagType.String, Offset = 3, Required = true)]
		public string? MassActionReportID {get; set;}
		
		[TagDetails(Tag = 1373, Type = TagType.Int, Offset = 4, Required = true)]
		public int? MassActionType {get; set;}
		
		[TagDetails(Tag = 1374, Type = TagType.Int, Offset = 5, Required = true)]
		public int? MassActionScope {get; set;}
		
		[TagDetails(Tag = 2675, Type = TagType.Int, Offset = 6, Required = false)]
		public int? MassActionReason {get; set;}
		
		[TagDetails(Tag = 1375, Type = TagType.Int, Offset = 7, Required = true)]
		public int? MassActionResponse {get; set;}
		
		[TagDetails(Tag = 1376, Type = TagType.Int, Offset = 8, Required = false)]
		public int? MassActionRejectReason {get; set;}
		
		[TagDetails(Tag = 533, Type = TagType.Int, Offset = 9, Required = false)]
		public int? TotalAffectedOrders {get; set;}
		
		[TagDetails(Tag = 2678, Type = TagType.Int, Offset = 10, Required = false)]
		public int? TotalNotAffectedOrders {get; set;}
		
		[TagDetails(Tag = 893, Type = TagType.Boolean, Offset = 11, Required = false)]
		public bool? LastFragment {get; set;}
		
		[Component(Offset = 12, Required = false)]
		public AffectedOrdGrp? AffectedOrdGrp {get; set;}
		
		[Component(Offset = 13, Required = false)]
		public NotAffectedOrdGrp? NotAffectedOrdGrp {get; set;}
		
		[Component(Offset = 14, Required = false)]
		public AffectedMarketSegmentGrp? AffectedMarketSegmentGrp {get; set;}
		
		[Component(Offset = 15, Required = false)]
		public NotAffectedMarketSegmentGrp? NotAffectedMarketSegmentGrp {get; set;}
		
		[TagDetails(Tag = 1301, Type = TagType.String, Offset = 16, Required = false)]
		public string? MarketID {get; set;}
		
		[TagDetails(Tag = 1300, Type = TagType.String, Offset = 17, Required = false)]
		public string? MarketSegmentID {get; set;}
		
		[Component(Offset = 18, Required = false)]
		public TargetMarketSegmentGrp? TargetMarketSegmentGrp {get; set;}
		
		[TagDetails(Tag = 336, Type = TagType.String, Offset = 19, Required = false)]
		public string? TradingSessionID {get; set;}
		
		[TagDetails(Tag = 625, Type = TagType.String, Offset = 20, Required = false)]
		public string? TradingSessionSubID {get; set;}
		
		[Component(Offset = 21, Required = false)]
		public Parties? Parties {get; set;}
		
		[Component(Offset = 22, Required = false)]
		public TargetParties? TargetParties {get; set;}
		
		[Component(Offset = 23, Required = false)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 24, Required = false)]
		public UnderlyingInstrument? UnderlyingInstrument {get; set;}
		
		[TagDetails(Tag = 54, Type = TagType.String, Offset = 25, Required = false)]
		public string? Side {get; set;}
		
		[TagDetails(Tag = 44, Type = TagType.Float, Offset = 26, Required = false)]
		public double? Price {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 27, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 376, Type = TagType.String, Offset = 28, Required = false)]
		public string? ComplianceID {get; set;}
		
		[TagDetails(Tag = 2404, Type = TagType.String, Offset = 29, Required = false)]
		public string? ComplianceText {get; set;}
		
		[TagDetails(Tag = 2351, Type = TagType.Length, Offset = 30, Required = false)]
		public int? EncodedComplianceTextLen {get; set;}
		
		[TagDetails(Tag = 2352, Type = TagType.RawData, Offset = 31, Required = false)]
		public byte[]? EncodedComplianceText {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 32, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 33, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 34, Required = false)]
		public byte[]? EncodedText {get; set;}
		
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
			if (ClOrdID is not null) writer.WriteString(11, ClOrdID);
			if (SecondaryClOrdID is not null) writer.WriteString(526, SecondaryClOrdID);
			if (MassActionReportID is not null) writer.WriteString(1369, MassActionReportID);
			if (MassActionType is not null) writer.WriteWholeNumber(1373, MassActionType.Value);
			if (MassActionScope is not null) writer.WriteWholeNumber(1374, MassActionScope.Value);
			if (MassActionReason is not null) writer.WriteWholeNumber(2675, MassActionReason.Value);
			if (MassActionResponse is not null) writer.WriteWholeNumber(1375, MassActionResponse.Value);
			if (MassActionRejectReason is not null) writer.WriteWholeNumber(1376, MassActionRejectReason.Value);
			if (TotalAffectedOrders is not null) writer.WriteWholeNumber(533, TotalAffectedOrders.Value);
			if (TotalNotAffectedOrders is not null) writer.WriteWholeNumber(2678, TotalNotAffectedOrders.Value);
			if (LastFragment is not null) writer.WriteBoolean(893, LastFragment.Value);
			if (AffectedOrdGrp is not null) ((IFixEncoder)AffectedOrdGrp).Encode(writer);
			if (NotAffectedOrdGrp is not null) ((IFixEncoder)NotAffectedOrdGrp).Encode(writer);
			if (AffectedMarketSegmentGrp is not null) ((IFixEncoder)AffectedMarketSegmentGrp).Encode(writer);
			if (NotAffectedMarketSegmentGrp is not null) ((IFixEncoder)NotAffectedMarketSegmentGrp).Encode(writer);
			if (MarketID is not null) writer.WriteString(1301, MarketID);
			if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
			if (TargetMarketSegmentGrp is not null) ((IFixEncoder)TargetMarketSegmentGrp).Encode(writer);
			if (TradingSessionID is not null) writer.WriteString(336, TradingSessionID);
			if (TradingSessionSubID is not null) writer.WriteString(625, TradingSessionSubID);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (TargetParties is not null) ((IFixEncoder)TargetParties).Encode(writer);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (UnderlyingInstrument is not null) ((IFixEncoder)UnderlyingInstrument).Encode(writer);
			if (Side is not null) writer.WriteString(54, Side);
			if (Price is not null) writer.WriteNumber(44, Price.Value);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (ComplianceID is not null) writer.WriteString(376, ComplianceID);
			if (ComplianceText is not null) writer.WriteString(2404, ComplianceText);
			if (EncodedComplianceTextLen is not null) writer.WriteWholeNumber(2351, EncodedComplianceTextLen.Value);
			if (EncodedComplianceText is not null) writer.WriteBuffer(2352, EncodedComplianceText);
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
			MassActionReportID = view.GetString(1369);
			MassActionType = view.GetInt32(1373);
			MassActionScope = view.GetInt32(1374);
			MassActionReason = view.GetInt32(2675);
			MassActionResponse = view.GetInt32(1375);
			MassActionRejectReason = view.GetInt32(1376);
			TotalAffectedOrders = view.GetInt32(533);
			TotalNotAffectedOrders = view.GetInt32(2678);
			LastFragment = view.GetBool(893);
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
			if (view.GetView("AffectedMarketSegmentGrp") is IMessageView viewAffectedMarketSegmentGrp)
			{
				AffectedMarketSegmentGrp = new();
				((IFixParser)AffectedMarketSegmentGrp).Parse(viewAffectedMarketSegmentGrp);
			}
			if (view.GetView("NotAffectedMarketSegmentGrp") is IMessageView viewNotAffectedMarketSegmentGrp)
			{
				NotAffectedMarketSegmentGrp = new();
				((IFixParser)NotAffectedMarketSegmentGrp).Parse(viewNotAffectedMarketSegmentGrp);
			}
			MarketID = view.GetString(1301);
			MarketSegmentID = view.GetString(1300);
			if (view.GetView("TargetMarketSegmentGrp") is IMessageView viewTargetMarketSegmentGrp)
			{
				TargetMarketSegmentGrp = new();
				((IFixParser)TargetMarketSegmentGrp).Parse(viewTargetMarketSegmentGrp);
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
			Side = view.GetString(54);
			Price = view.GetDouble(44);
			TransactTime = view.GetDateTime(60);
			ComplianceID = view.GetString(376);
			ComplianceText = view.GetString(2404);
			EncodedComplianceTextLen = view.GetInt32(2351);
			EncodedComplianceText = view.GetByteArray(2352);
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
				case "MassActionReportID":
				{
					value = MassActionReportID;
					break;
				}
				case "MassActionType":
				{
					value = MassActionType;
					break;
				}
				case "MassActionScope":
				{
					value = MassActionScope;
					break;
				}
				case "MassActionReason":
				{
					value = MassActionReason;
					break;
				}
				case "MassActionResponse":
				{
					value = MassActionResponse;
					break;
				}
				case "MassActionRejectReason":
				{
					value = MassActionRejectReason;
					break;
				}
				case "TotalAffectedOrders":
				{
					value = TotalAffectedOrders;
					break;
				}
				case "TotalNotAffectedOrders":
				{
					value = TotalNotAffectedOrders;
					break;
				}
				case "LastFragment":
				{
					value = LastFragment;
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
				case "AffectedMarketSegmentGrp":
				{
					value = AffectedMarketSegmentGrp;
					break;
				}
				case "NotAffectedMarketSegmentGrp":
				{
					value = NotAffectedMarketSegmentGrp;
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
				case "TargetMarketSegmentGrp":
				{
					value = TargetMarketSegmentGrp;
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
				case "Side":
				{
					value = Side;
					break;
				}
				case "Price":
				{
					value = Price;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "ComplianceID":
				{
					value = ComplianceID;
					break;
				}
				case "ComplianceText":
				{
					value = ComplianceText;
					break;
				}
				case "EncodedComplianceTextLen":
				{
					value = EncodedComplianceTextLen;
					break;
				}
				case "EncodedComplianceText":
				{
					value = EncodedComplianceText;
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
			MassActionReportID = null;
			MassActionType = null;
			MassActionScope = null;
			MassActionReason = null;
			MassActionResponse = null;
			MassActionRejectReason = null;
			TotalAffectedOrders = null;
			TotalNotAffectedOrders = null;
			LastFragment = null;
			((IFixReset?)AffectedOrdGrp)?.Reset();
			((IFixReset?)NotAffectedOrdGrp)?.Reset();
			((IFixReset?)AffectedMarketSegmentGrp)?.Reset();
			((IFixReset?)NotAffectedMarketSegmentGrp)?.Reset();
			MarketID = null;
			MarketSegmentID = null;
			((IFixReset?)TargetMarketSegmentGrp)?.Reset();
			TradingSessionID = null;
			TradingSessionSubID = null;
			((IFixReset?)Parties)?.Reset();
			((IFixReset?)TargetParties)?.Reset();
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)UnderlyingInstrument)?.Reset();
			Side = null;
			Price = null;
			TransactTime = null;
			ComplianceID = null;
			ComplianceText = null;
			EncodedComplianceTextLen = null;
			EncodedComplianceText = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
