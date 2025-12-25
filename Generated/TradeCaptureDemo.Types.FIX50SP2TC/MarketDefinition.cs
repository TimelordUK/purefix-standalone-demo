using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("BU", FixVersion.FIX50SP2)]
	public sealed partial class MarketDefinition : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public ApplicationSequenceControl? ApplicationSequenceControl {get; set;}
		
		[TagDetails(Tag = 1394, Type = TagType.String, Offset = 2, Required = true)]
		public string? MarketReportID {get; set;}
		
		[TagDetails(Tag = 1393, Type = TagType.String, Offset = 3, Required = false)]
		public string? MarketReqID {get; set;}
		
		[TagDetails(Tag = 1301, Type = TagType.String, Offset = 4, Required = true)]
		public string? MarketID {get; set;}
		
		[TagDetails(Tag = 1300, Type = TagType.String, Offset = 5, Required = false)]
		public string? MarketSegmentID {get; set;}
		
		[TagDetails(Tag = 1396, Type = TagType.String, Offset = 6, Required = false)]
		public string? MarketSegmentDesc {get; set;}
		
		[TagDetails(Tag = 1397, Type = TagType.Length, Offset = 7, Required = false)]
		public int? EncodedMktSegmDescLen {get; set;}
		
		[TagDetails(Tag = 1398, Type = TagType.RawData, Offset = 8, Required = false)]
		public byte[]? EncodedMktSegmDesc {get; set;}
		
		[TagDetails(Tag = 1325, Type = TagType.String, Offset = 9, Required = false)]
		public string? ParentMktSegmID {get; set;}
		
		[TagDetails(Tag = 2542, Type = TagType.Int, Offset = 10, Required = false)]
		public int? MarketSegmentStatus {get; set;}
		
		[TagDetails(Tag = 2543, Type = TagType.Int, Offset = 11, Required = false)]
		public int? MarketSegmentType {get; set;}
		
		[TagDetails(Tag = 2544, Type = TagType.Int, Offset = 12, Required = false)]
		public int? MarketSegmentSubType {get; set;}
		
		[Component(Offset = 13, Required = false)]
		public InstrumentScopeGrp? InstrumentScopeGrp {get; set;}
		
		[Component(Offset = 14, Required = false)]
		public RelatedMarketSegmentGrp? RelatedMarketSegmentGrp {get; set;}
		
		[TagDetails(Tag = 15, Type = TagType.String, Offset = 15, Required = false)]
		public string? Currency {get; set;}
		
		[TagDetails(Tag = 2897, Type = TagType.String, Offset = 16, Required = false)]
		public string? CurrencyCodeSource {get; set;}
		
		[Component(Offset = 17, Required = false)]
		public BaseTradingRules? BaseTradingRules {get; set;}
		
		[Component(Offset = 18, Required = false)]
		public OrdTypeRules? OrdTypeRules {get; set;}
		
		[Component(Offset = 19, Required = false)]
		public TimeInForceRules? TimeInForceRules {get; set;}
		
		[Component(Offset = 20, Required = false)]
		public ExecInstRules? ExecInstRules {get; set;}
		
		[Component(Offset = 21, Required = false)]
		public AuctionTypeRuleGrp? AuctionTypeRuleGrp {get; set;}
		
		[Component(Offset = 22, Required = false)]
		public MarketDataFeedTypes? MarketDataFeedTypes {get; set;}
		
		[Component(Offset = 23, Required = false)]
		public MatchRules? MatchRules {get; set;}
		
		[Component(Offset = 24, Required = false)]
		public FlexProductEligibilityGrp? FlexProductEligibilityGrp {get; set;}
		
		[Component(Offset = 25, Required = false)]
		public Parties? Parties {get; set;}
		
		[Component(Offset = 26, Required = false)]
		public MiscFeesGrp? MiscFeesGrp {get; set;}
		
		[TagDetails(Tag = 2400, Type = TagType.LocalDate, Offset = 27, Required = false)]
		public DateOnly? EffectiveBusinessDate {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 28, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 29, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 30, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 31, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 32, Required = true)]
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
			if (MarketReportID is not null) writer.WriteString(1394, MarketReportID);
			if (MarketReqID is not null) writer.WriteString(1393, MarketReqID);
			if (MarketID is not null) writer.WriteString(1301, MarketID);
			if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
			if (MarketSegmentDesc is not null) writer.WriteString(1396, MarketSegmentDesc);
			if (EncodedMktSegmDescLen is not null) writer.WriteWholeNumber(1397, EncodedMktSegmDescLen.Value);
			if (EncodedMktSegmDesc is not null) writer.WriteBuffer(1398, EncodedMktSegmDesc);
			if (ParentMktSegmID is not null) writer.WriteString(1325, ParentMktSegmID);
			if (MarketSegmentStatus is not null) writer.WriteWholeNumber(2542, MarketSegmentStatus.Value);
			if (MarketSegmentType is not null) writer.WriteWholeNumber(2543, MarketSegmentType.Value);
			if (MarketSegmentSubType is not null) writer.WriteWholeNumber(2544, MarketSegmentSubType.Value);
			if (InstrumentScopeGrp is not null) ((IFixEncoder)InstrumentScopeGrp).Encode(writer);
			if (RelatedMarketSegmentGrp is not null) ((IFixEncoder)RelatedMarketSegmentGrp).Encode(writer);
			if (Currency is not null) writer.WriteString(15, Currency);
			if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
			if (BaseTradingRules is not null) ((IFixEncoder)BaseTradingRules).Encode(writer);
			if (OrdTypeRules is not null) ((IFixEncoder)OrdTypeRules).Encode(writer);
			if (TimeInForceRules is not null) ((IFixEncoder)TimeInForceRules).Encode(writer);
			if (ExecInstRules is not null) ((IFixEncoder)ExecInstRules).Encode(writer);
			if (AuctionTypeRuleGrp is not null) ((IFixEncoder)AuctionTypeRuleGrp).Encode(writer);
			if (MarketDataFeedTypes is not null) ((IFixEncoder)MarketDataFeedTypes).Encode(writer);
			if (MatchRules is not null) ((IFixEncoder)MatchRules).Encode(writer);
			if (FlexProductEligibilityGrp is not null) ((IFixEncoder)FlexProductEligibilityGrp).Encode(writer);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (MiscFeesGrp is not null) ((IFixEncoder)MiscFeesGrp).Encode(writer);
			if (EffectiveBusinessDate is not null) writer.WriteLocalDateOnly(2400, EffectiveBusinessDate.Value);
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
			MarketReportID = view.GetString(1394);
			MarketReqID = view.GetString(1393);
			MarketID = view.GetString(1301);
			MarketSegmentID = view.GetString(1300);
			MarketSegmentDesc = view.GetString(1396);
			EncodedMktSegmDescLen = view.GetInt32(1397);
			EncodedMktSegmDesc = view.GetByteArray(1398);
			ParentMktSegmID = view.GetString(1325);
			MarketSegmentStatus = view.GetInt32(2542);
			MarketSegmentType = view.GetInt32(2543);
			MarketSegmentSubType = view.GetInt32(2544);
			if (view.GetView("InstrumentScopeGrp") is IMessageView viewInstrumentScopeGrp)
			{
				InstrumentScopeGrp = new();
				((IFixParser)InstrumentScopeGrp).Parse(viewInstrumentScopeGrp);
			}
			if (view.GetView("RelatedMarketSegmentGrp") is IMessageView viewRelatedMarketSegmentGrp)
			{
				RelatedMarketSegmentGrp = new();
				((IFixParser)RelatedMarketSegmentGrp).Parse(viewRelatedMarketSegmentGrp);
			}
			Currency = view.GetString(15);
			CurrencyCodeSource = view.GetString(2897);
			if (view.GetView("BaseTradingRules") is IMessageView viewBaseTradingRules)
			{
				BaseTradingRules = new();
				((IFixParser)BaseTradingRules).Parse(viewBaseTradingRules);
			}
			if (view.GetView("OrdTypeRules") is IMessageView viewOrdTypeRules)
			{
				OrdTypeRules = new();
				((IFixParser)OrdTypeRules).Parse(viewOrdTypeRules);
			}
			if (view.GetView("TimeInForceRules") is IMessageView viewTimeInForceRules)
			{
				TimeInForceRules = new();
				((IFixParser)TimeInForceRules).Parse(viewTimeInForceRules);
			}
			if (view.GetView("ExecInstRules") is IMessageView viewExecInstRules)
			{
				ExecInstRules = new();
				((IFixParser)ExecInstRules).Parse(viewExecInstRules);
			}
			if (view.GetView("AuctionTypeRuleGrp") is IMessageView viewAuctionTypeRuleGrp)
			{
				AuctionTypeRuleGrp = new();
				((IFixParser)AuctionTypeRuleGrp).Parse(viewAuctionTypeRuleGrp);
			}
			if (view.GetView("MarketDataFeedTypes") is IMessageView viewMarketDataFeedTypes)
			{
				MarketDataFeedTypes = new();
				((IFixParser)MarketDataFeedTypes).Parse(viewMarketDataFeedTypes);
			}
			if (view.GetView("MatchRules") is IMessageView viewMatchRules)
			{
				MatchRules = new();
				((IFixParser)MatchRules).Parse(viewMatchRules);
			}
			if (view.GetView("FlexProductEligibilityGrp") is IMessageView viewFlexProductEligibilityGrp)
			{
				FlexProductEligibilityGrp = new();
				((IFixParser)FlexProductEligibilityGrp).Parse(viewFlexProductEligibilityGrp);
			}
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			if (view.GetView("MiscFeesGrp") is IMessageView viewMiscFeesGrp)
			{
				MiscFeesGrp = new();
				((IFixParser)MiscFeesGrp).Parse(viewMiscFeesGrp);
			}
			EffectiveBusinessDate = view.GetDateOnly(2400);
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
				case "MarketReportID":
				{
					value = MarketReportID;
					break;
				}
				case "MarketReqID":
				{
					value = MarketReqID;
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
				case "MarketSegmentDesc":
				{
					value = MarketSegmentDesc;
					break;
				}
				case "EncodedMktSegmDescLen":
				{
					value = EncodedMktSegmDescLen;
					break;
				}
				case "EncodedMktSegmDesc":
				{
					value = EncodedMktSegmDesc;
					break;
				}
				case "ParentMktSegmID":
				{
					value = ParentMktSegmID;
					break;
				}
				case "MarketSegmentStatus":
				{
					value = MarketSegmentStatus;
					break;
				}
				case "MarketSegmentType":
				{
					value = MarketSegmentType;
					break;
				}
				case "MarketSegmentSubType":
				{
					value = MarketSegmentSubType;
					break;
				}
				case "InstrumentScopeGrp":
				{
					value = InstrumentScopeGrp;
					break;
				}
				case "RelatedMarketSegmentGrp":
				{
					value = RelatedMarketSegmentGrp;
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
				case "BaseTradingRules":
				{
					value = BaseTradingRules;
					break;
				}
				case "OrdTypeRules":
				{
					value = OrdTypeRules;
					break;
				}
				case "TimeInForceRules":
				{
					value = TimeInForceRules;
					break;
				}
				case "ExecInstRules":
				{
					value = ExecInstRules;
					break;
				}
				case "AuctionTypeRuleGrp":
				{
					value = AuctionTypeRuleGrp;
					break;
				}
				case "MarketDataFeedTypes":
				{
					value = MarketDataFeedTypes;
					break;
				}
				case "MatchRules":
				{
					value = MatchRules;
					break;
				}
				case "FlexProductEligibilityGrp":
				{
					value = FlexProductEligibilityGrp;
					break;
				}
				case "Parties":
				{
					value = Parties;
					break;
				}
				case "MiscFeesGrp":
				{
					value = MiscFeesGrp;
					break;
				}
				case "EffectiveBusinessDate":
				{
					value = EffectiveBusinessDate;
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
			MarketReportID = null;
			MarketReqID = null;
			MarketID = null;
			MarketSegmentID = null;
			MarketSegmentDesc = null;
			EncodedMktSegmDescLen = null;
			EncodedMktSegmDesc = null;
			ParentMktSegmID = null;
			MarketSegmentStatus = null;
			MarketSegmentType = null;
			MarketSegmentSubType = null;
			((IFixReset?)InstrumentScopeGrp)?.Reset();
			((IFixReset?)RelatedMarketSegmentGrp)?.Reset();
			Currency = null;
			CurrencyCodeSource = null;
			((IFixReset?)BaseTradingRules)?.Reset();
			((IFixReset?)OrdTypeRules)?.Reset();
			((IFixReset?)TimeInForceRules)?.Reset();
			((IFixReset?)ExecInstRules)?.Reset();
			((IFixReset?)AuctionTypeRuleGrp)?.Reset();
			((IFixReset?)MarketDataFeedTypes)?.Reset();
			((IFixReset?)MatchRules)?.Reset();
			((IFixReset?)FlexProductEligibilityGrp)?.Reset();
			((IFixReset?)Parties)?.Reset();
			((IFixReset?)MiscFeesGrp)?.Reset();
			EffectiveBusinessDate = null;
			TransactTime = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
