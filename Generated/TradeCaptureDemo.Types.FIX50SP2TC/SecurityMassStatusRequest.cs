using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("CN", FixVersion.FIX50SP2)]
	public sealed partial class SecurityMassStatusRequest : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 324, Type = TagType.String, Offset = 1, Required = true)]
		public string? SecurityStatusReqID {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public InstrumentScope? InstrumentScope {get; set;}
		
		[TagDetails(Tag = 263, Type = TagType.String, Offset = 3, Required = true)]
		public string? SubscriptionRequestType {get; set;}
		
		[TagDetails(Tag = 1465, Type = TagType.String, Offset = 4, Required = false)]
		public string? SecurityListID {get; set;}
		
		[TagDetails(Tag = 1301, Type = TagType.String, Offset = 5, Required = false)]
		public string? MarketID {get; set;}
		
		[TagDetails(Tag = 1300, Type = TagType.String, Offset = 6, Required = false)]
		public string? MarketSegmentID {get; set;}
		
		[TagDetails(Tag = 336, Type = TagType.String, Offset = 7, Required = false)]
		public string? TradingSessionID {get; set;}
		
		[TagDetails(Tag = 625, Type = TagType.String, Offset = 8, Required = false)]
		public string? TradingSessionSubID {get; set;}
		
		[Component(Offset = 9, Required = true)]
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
			if (SecurityStatusReqID is not null) writer.WriteString(324, SecurityStatusReqID);
			if (InstrumentScope is not null) ((IFixEncoder)InstrumentScope).Encode(writer);
			if (SubscriptionRequestType is not null) writer.WriteString(263, SubscriptionRequestType);
			if (SecurityListID is not null) writer.WriteString(1465, SecurityListID);
			if (MarketID is not null) writer.WriteString(1301, MarketID);
			if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
			if (TradingSessionID is not null) writer.WriteString(336, TradingSessionID);
			if (TradingSessionSubID is not null) writer.WriteString(625, TradingSessionSubID);
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
			SecurityStatusReqID = view.GetString(324);
			if (view.GetView("InstrumentScope") is IMessageView viewInstrumentScope)
			{
				InstrumentScope = new();
				((IFixParser)InstrumentScope).Parse(viewInstrumentScope);
			}
			SubscriptionRequestType = view.GetString(263);
			SecurityListID = view.GetString(1465);
			MarketID = view.GetString(1301);
			MarketSegmentID = view.GetString(1300);
			TradingSessionID = view.GetString(336);
			TradingSessionSubID = view.GetString(625);
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
				case "SecurityStatusReqID":
				{
					value = SecurityStatusReqID;
					break;
				}
				case "InstrumentScope":
				{
					value = InstrumentScope;
					break;
				}
				case "SubscriptionRequestType":
				{
					value = SubscriptionRequestType;
					break;
				}
				case "SecurityListID":
				{
					value = SecurityListID;
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
			SecurityStatusReqID = null;
			((IFixReset?)InstrumentScope)?.Reset();
			SubscriptionRequestType = null;
			SecurityListID = null;
			MarketID = null;
			MarketSegmentID = null;
			TradingSessionID = null;
			TradingSessionSubID = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
