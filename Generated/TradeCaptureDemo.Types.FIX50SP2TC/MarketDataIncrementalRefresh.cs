using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("X", FixVersion.FIX50SP2)]
	public sealed partial class MarketDataIncrementalRefresh : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public ApplicationSequenceControl? ApplicationSequenceControl {get; set;}
		
		[TagDetails(Tag = 1021, Type = TagType.Int, Offset = 2, Required = false)]
		public int? MDBookType {get; set;}
		
		[TagDetails(Tag = 1022, Type = TagType.String, Offset = 3, Required = false)]
		public string? MDFeedType {get; set;}
		
		[TagDetails(Tag = 1683, Type = TagType.String, Offset = 4, Required = false)]
		public string? MDSubFeedType {get; set;}
		
		[TagDetails(Tag = 75, Type = TagType.LocalDate, Offset = 5, Required = false)]
		public DateOnly? TradeDate {get; set;}
		
		[TagDetails(Tag = 262, Type = TagType.String, Offset = 6, Required = false)]
		public string? MDReqID {get; set;}
		
		[TagDetails(Tag = 1301, Type = TagType.String, Offset = 7, Required = false)]
		public string? MarketID {get; set;}
		
		[TagDetails(Tag = 1300, Type = TagType.String, Offset = 8, Required = false)]
		public string? MarketSegmentID {get; set;}
		
		[Component(Offset = 9, Required = true)]
		public MDIncGrp? MDIncGrp {get; set;}
		
		[TagDetails(Tag = 813, Type = TagType.Int, Offset = 10, Required = false)]
		public int? ApplQueueDepth {get; set;}
		
		[TagDetails(Tag = 814, Type = TagType.Int, Offset = 11, Required = false)]
		public int? ApplQueueResolution {get; set;}
		
		[Component(Offset = 12, Required = false)]
		public RoutingGrp? RoutingGrp {get; set;}
		
		[Component(Offset = 13, Required = true)]
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
			if (MDBookType is not null) writer.WriteWholeNumber(1021, MDBookType.Value);
			if (MDFeedType is not null) writer.WriteString(1022, MDFeedType);
			if (MDSubFeedType is not null) writer.WriteString(1683, MDSubFeedType);
			if (TradeDate is not null) writer.WriteLocalDateOnly(75, TradeDate.Value);
			if (MDReqID is not null) writer.WriteString(262, MDReqID);
			if (MarketID is not null) writer.WriteString(1301, MarketID);
			if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
			if (MDIncGrp is not null) ((IFixEncoder)MDIncGrp).Encode(writer);
			if (ApplQueueDepth is not null) writer.WriteWholeNumber(813, ApplQueueDepth.Value);
			if (ApplQueueResolution is not null) writer.WriteWholeNumber(814, ApplQueueResolution.Value);
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
			if (view.GetView("ApplicationSequenceControl") is IMessageView viewApplicationSequenceControl)
			{
				ApplicationSequenceControl = new();
				((IFixParser)ApplicationSequenceControl).Parse(viewApplicationSequenceControl);
			}
			MDBookType = view.GetInt32(1021);
			MDFeedType = view.GetString(1022);
			MDSubFeedType = view.GetString(1683);
			TradeDate = view.GetDateOnly(75);
			MDReqID = view.GetString(262);
			MarketID = view.GetString(1301);
			MarketSegmentID = view.GetString(1300);
			if (view.GetView("MDIncGrp") is IMessageView viewMDIncGrp)
			{
				MDIncGrp = new();
				((IFixParser)MDIncGrp).Parse(viewMDIncGrp);
			}
			ApplQueueDepth = view.GetInt32(813);
			ApplQueueResolution = view.GetInt32(814);
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
				case "ApplicationSequenceControl":
				{
					value = ApplicationSequenceControl;
					break;
				}
				case "MDBookType":
				{
					value = MDBookType;
					break;
				}
				case "MDFeedType":
				{
					value = MDFeedType;
					break;
				}
				case "MDSubFeedType":
				{
					value = MDSubFeedType;
					break;
				}
				case "TradeDate":
				{
					value = TradeDate;
					break;
				}
				case "MDReqID":
				{
					value = MDReqID;
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
				case "MDIncGrp":
				{
					value = MDIncGrp;
					break;
				}
				case "ApplQueueDepth":
				{
					value = ApplQueueDepth;
					break;
				}
				case "ApplQueueResolution":
				{
					value = ApplQueueResolution;
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
			((IFixReset?)ApplicationSequenceControl)?.Reset();
			MDBookType = null;
			MDFeedType = null;
			MDSubFeedType = null;
			TradeDate = null;
			MDReqID = null;
			MarketID = null;
			MarketSegmentID = null;
			((IFixReset?)MDIncGrp)?.Reset();
			ApplQueueDepth = null;
			ApplQueueResolution = null;
			((IFixReset?)RoutingGrp)?.Reset();
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
