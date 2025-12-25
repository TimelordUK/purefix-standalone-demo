using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("BT", FixVersion.FIX50SP2)]
	public sealed partial class MarketDefinitionRequest : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 1393, Type = TagType.String, Offset = 1, Required = true)]
		public string? MarketReqID {get; set;}
		
		[TagDetails(Tag = 263, Type = TagType.String, Offset = 2, Required = true)]
		public string? SubscriptionRequestType {get; set;}
		
		[TagDetails(Tag = 1301, Type = TagType.String, Offset = 3, Required = false)]
		public string? MarketID {get; set;}
		
		[TagDetails(Tag = 1300, Type = TagType.String, Offset = 4, Required = false)]
		public string? MarketSegmentID {get; set;}
		
		[TagDetails(Tag = 1325, Type = TagType.String, Offset = 5, Required = false)]
		public string? ParentMktSegmID {get; set;}
		
		[Component(Offset = 6, Required = true)]
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
			if (MarketReqID is not null) writer.WriteString(1393, MarketReqID);
			if (SubscriptionRequestType is not null) writer.WriteString(263, SubscriptionRequestType);
			if (MarketID is not null) writer.WriteString(1301, MarketID);
			if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
			if (ParentMktSegmID is not null) writer.WriteString(1325, ParentMktSegmID);
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
			MarketReqID = view.GetString(1393);
			SubscriptionRequestType = view.GetString(263);
			MarketID = view.GetString(1301);
			MarketSegmentID = view.GetString(1300);
			ParentMktSegmID = view.GetString(1325);
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
				case "MarketReqID":
				{
					value = MarketReqID;
					break;
				}
				case "SubscriptionRequestType":
				{
					value = SubscriptionRequestType;
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
				case "ParentMktSegmID":
				{
					value = ParentMktSegmID;
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
			MarketReqID = null;
			SubscriptionRequestType = null;
			MarketID = null;
			MarketSegmentID = null;
			ParentMktSegmID = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
