using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("B", FixVersion.FIX50SP2)]
	public sealed partial class News : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public ApplicationSequenceControl? ApplicationSequenceControl {get; set;}
		
		[TagDetails(Tag = 1472, Type = TagType.String, Offset = 2, Required = false)]
		public string? NewsID {get; set;}
		
		[Component(Offset = 3, Required = false)]
		public NewsRefGrp? NewsRefGrp {get; set;}
		
		[TagDetails(Tag = 1473, Type = TagType.Int, Offset = 4, Required = false)]
		public int? NewsCategory {get; set;}
		
		[TagDetails(Tag = 1474, Type = TagType.String, Offset = 5, Required = false)]
		public string? LanguageCode {get; set;}
		
		[TagDetails(Tag = 42, Type = TagType.UtcTimestamp, Offset = 6, Required = false)]
		public DateTime? OrigTime {get; set;}
		
		[TagDetails(Tag = 61, Type = TagType.String, Offset = 7, Required = false)]
		public string? Urgency {get; set;}
		
		[TagDetails(Tag = 148, Type = TagType.String, Offset = 8, Required = true)]
		public string? Headline {get; set;}
		
		[TagDetails(Tag = 358, Type = TagType.Length, Offset = 9, Required = false)]
		public int? EncodedHeadlineLen {get; set;}
		
		[TagDetails(Tag = 359, Type = TagType.RawData, Offset = 10, Required = false)]
		public byte[]? EncodedHeadline {get; set;}
		
		[Component(Offset = 11, Required = false)]
		public RoutingGrp? RoutingGrp {get; set;}
		
		[TagDetails(Tag = 1301, Type = TagType.String, Offset = 12, Required = false)]
		public string? MarketID {get; set;}
		
		[TagDetails(Tag = 1300, Type = TagType.String, Offset = 13, Required = false)]
		public string? MarketSegmentID {get; set;}
		
		[Component(Offset = 14, Required = false)]
		public InstrmtGrp? InstrmtGrp {get; set;}
		
		[Component(Offset = 15, Required = false)]
		public InstrmtLegGrp? InstrmtLegGrp {get; set;}
		
		[Component(Offset = 16, Required = false)]
		public UndInstrmtGrp? UndInstrmtGrp {get; set;}
		
		[Component(Offset = 17, Required = true)]
		public LinesOfTextGrp? LinesOfTextGrp {get; set;}
		
		[TagDetails(Tag = 149, Type = TagType.String, Offset = 18, Required = false)]
		public string? URLLink {get; set;}
		
		[TagDetails(Tag = 95, Type = TagType.Length, Offset = 19, Required = false)]
		public int? RawDataLength {get; set;}
		
		[TagDetails(Tag = 96, Type = TagType.RawData, Offset = 20, Required = false)]
		public byte[]? RawData {get; set;}
		
		[Component(Offset = 21, Required = true)]
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
			if (NewsID is not null) writer.WriteString(1472, NewsID);
			if (NewsRefGrp is not null) ((IFixEncoder)NewsRefGrp).Encode(writer);
			if (NewsCategory is not null) writer.WriteWholeNumber(1473, NewsCategory.Value);
			if (LanguageCode is not null) writer.WriteString(1474, LanguageCode);
			if (OrigTime is not null) writer.WriteUtcTimeStamp(42, OrigTime.Value);
			if (Urgency is not null) writer.WriteString(61, Urgency);
			if (Headline is not null) writer.WriteString(148, Headline);
			if (EncodedHeadlineLen is not null) writer.WriteWholeNumber(358, EncodedHeadlineLen.Value);
			if (EncodedHeadline is not null) writer.WriteBuffer(359, EncodedHeadline);
			if (RoutingGrp is not null) ((IFixEncoder)RoutingGrp).Encode(writer);
			if (MarketID is not null) writer.WriteString(1301, MarketID);
			if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
			if (InstrmtGrp is not null) ((IFixEncoder)InstrmtGrp).Encode(writer);
			if (InstrmtLegGrp is not null) ((IFixEncoder)InstrmtLegGrp).Encode(writer);
			if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
			if (LinesOfTextGrp is not null) ((IFixEncoder)LinesOfTextGrp).Encode(writer);
			if (URLLink is not null) writer.WriteString(149, URLLink);
			if (RawDataLength is not null) writer.WriteWholeNumber(95, RawDataLength.Value);
			if (RawData is not null) writer.WriteBuffer(96, RawData);
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
			NewsID = view.GetString(1472);
			if (view.GetView("NewsRefGrp") is IMessageView viewNewsRefGrp)
			{
				NewsRefGrp = new();
				((IFixParser)NewsRefGrp).Parse(viewNewsRefGrp);
			}
			NewsCategory = view.GetInt32(1473);
			LanguageCode = view.GetString(1474);
			OrigTime = view.GetDateTime(42);
			Urgency = view.GetString(61);
			Headline = view.GetString(148);
			EncodedHeadlineLen = view.GetInt32(358);
			EncodedHeadline = view.GetByteArray(359);
			if (view.GetView("RoutingGrp") is IMessageView viewRoutingGrp)
			{
				RoutingGrp = new();
				((IFixParser)RoutingGrp).Parse(viewRoutingGrp);
			}
			MarketID = view.GetString(1301);
			MarketSegmentID = view.GetString(1300);
			if (view.GetView("InstrmtGrp") is IMessageView viewInstrmtGrp)
			{
				InstrmtGrp = new();
				((IFixParser)InstrmtGrp).Parse(viewInstrmtGrp);
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
			if (view.GetView("LinesOfTextGrp") is IMessageView viewLinesOfTextGrp)
			{
				LinesOfTextGrp = new();
				((IFixParser)LinesOfTextGrp).Parse(viewLinesOfTextGrp);
			}
			URLLink = view.GetString(149);
			RawDataLength = view.GetInt32(95);
			RawData = view.GetByteArray(96);
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
				case "NewsID":
				{
					value = NewsID;
					break;
				}
				case "NewsRefGrp":
				{
					value = NewsRefGrp;
					break;
				}
				case "NewsCategory":
				{
					value = NewsCategory;
					break;
				}
				case "LanguageCode":
				{
					value = LanguageCode;
					break;
				}
				case "OrigTime":
				{
					value = OrigTime;
					break;
				}
				case "Urgency":
				{
					value = Urgency;
					break;
				}
				case "Headline":
				{
					value = Headline;
					break;
				}
				case "EncodedHeadlineLen":
				{
					value = EncodedHeadlineLen;
					break;
				}
				case "EncodedHeadline":
				{
					value = EncodedHeadline;
					break;
				}
				case "RoutingGrp":
				{
					value = RoutingGrp;
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
				case "InstrmtGrp":
				{
					value = InstrmtGrp;
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
				case "LinesOfTextGrp":
				{
					value = LinesOfTextGrp;
					break;
				}
				case "URLLink":
				{
					value = URLLink;
					break;
				}
				case "RawDataLength":
				{
					value = RawDataLength;
					break;
				}
				case "RawData":
				{
					value = RawData;
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
			NewsID = null;
			((IFixReset?)NewsRefGrp)?.Reset();
			NewsCategory = null;
			LanguageCode = null;
			OrigTime = null;
			Urgency = null;
			Headline = null;
			EncodedHeadlineLen = null;
			EncodedHeadline = null;
			((IFixReset?)RoutingGrp)?.Reset();
			MarketID = null;
			MarketSegmentID = null;
			((IFixReset?)InstrmtGrp)?.Reset();
			((IFixReset?)InstrmtLegGrp)?.Reset();
			((IFixReset?)UndInstrmtGrp)?.Reset();
			((IFixReset?)LinesOfTextGrp)?.Reset();
			URLLink = null;
			RawDataLength = null;
			RawData = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
