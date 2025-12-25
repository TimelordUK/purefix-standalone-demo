using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("CA", FixVersion.FIX50SP2)]
	public sealed partial class OrderMassActionRequest : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 11, Type = TagType.String, Offset = 1, Required = true)]
		public string? ClOrdID {get; set;}
		
		[TagDetails(Tag = 526, Type = TagType.String, Offset = 2, Required = false)]
		public string? SecondaryClOrdID {get; set;}
		
		[TagDetails(Tag = 1373, Type = TagType.Int, Offset = 3, Required = true)]
		public int? MassActionType {get; set;}
		
		[TagDetails(Tag = 1374, Type = TagType.Int, Offset = 4, Required = true)]
		public int? MassActionScope {get; set;}
		
		[TagDetails(Tag = 2675, Type = TagType.Int, Offset = 5, Required = false)]
		public int? MassActionReason {get; set;}
		
		[TagDetails(Tag = 1301, Type = TagType.String, Offset = 6, Required = false)]
		public string? MarketID {get; set;}
		
		[TagDetails(Tag = 1300, Type = TagType.String, Offset = 7, Required = false)]
		public string? MarketSegmentID {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public TargetMarketSegmentGrp? TargetMarketSegmentGrp {get; set;}
		
		[TagDetails(Tag = 336, Type = TagType.String, Offset = 9, Required = false)]
		public string? TradingSessionID {get; set;}
		
		[TagDetails(Tag = 625, Type = TagType.String, Offset = 10, Required = false)]
		public string? TradingSessionSubID {get; set;}
		
		[Component(Offset = 11, Required = false)]
		public Parties? Parties {get; set;}
		
		[Component(Offset = 12, Required = false)]
		public TargetParties? TargetParties {get; set;}
		
		[Component(Offset = 13, Required = false)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 14, Required = false)]
		public UnderlyingInstrument? UnderlyingInstrument {get; set;}
		
		[TagDetails(Tag = 54, Type = TagType.String, Offset = 15, Required = false)]
		public string? Side {get; set;}
		
		[TagDetails(Tag = 44, Type = TagType.Float, Offset = 16, Required = false)]
		public double? Price {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 17, Required = true)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 376, Type = TagType.String, Offset = 18, Required = false)]
		public string? ComplianceID {get; set;}
		
		[TagDetails(Tag = 2404, Type = TagType.String, Offset = 19, Required = false)]
		public string? ComplianceText {get; set;}
		
		[TagDetails(Tag = 2351, Type = TagType.Length, Offset = 20, Required = false)]
		public int? EncodedComplianceTextLen {get; set;}
		
		[TagDetails(Tag = 2352, Type = TagType.RawData, Offset = 21, Required = false)]
		public byte[]? EncodedComplianceText {get; set;}
		
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
			if (MassActionType is not null) writer.WriteWholeNumber(1373, MassActionType.Value);
			if (MassActionScope is not null) writer.WriteWholeNumber(1374, MassActionScope.Value);
			if (MassActionReason is not null) writer.WriteWholeNumber(2675, MassActionReason.Value);
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
			MassActionType = view.GetInt32(1373);
			MassActionScope = view.GetInt32(1374);
			MassActionReason = view.GetInt32(2675);
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
			MassActionType = null;
			MassActionScope = null;
			MassActionReason = null;
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
