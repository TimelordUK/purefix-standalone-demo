using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("BI", FixVersion.FIX50SP2)]
	public sealed partial class TradingSessionListRequest : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 335, Type = TagType.String, Offset = 1, Required = true)]
		public string? TradSesReqID {get; set;}
		
		[TagDetails(Tag = 1301, Type = TagType.String, Offset = 2, Required = false)]
		public string? MarketID {get; set;}
		
		[TagDetails(Tag = 1300, Type = TagType.String, Offset = 3, Required = false)]
		public string? MarketSegmentID {get; set;}
		
		[TagDetails(Tag = 336, Type = TagType.String, Offset = 4, Required = false)]
		public string? TradingSessionID {get; set;}
		
		[TagDetails(Tag = 625, Type = TagType.String, Offset = 5, Required = false)]
		public string? TradingSessionSubID {get; set;}
		
		[TagDetails(Tag = 207, Type = TagType.String, Offset = 6, Required = false)]
		public string? SecurityExchange {get; set;}
		
		[TagDetails(Tag = 338, Type = TagType.Int, Offset = 7, Required = false)]
		public int? TradSesMethod {get; set;}
		
		[TagDetails(Tag = 339, Type = TagType.Int, Offset = 8, Required = false)]
		public int? TradSesMode {get; set;}
		
		[TagDetails(Tag = 263, Type = TagType.String, Offset = 9, Required = true)]
		public string? SubscriptionRequestType {get; set;}
		
		[Component(Offset = 10, Required = true)]
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
			if (TradSesReqID is not null) writer.WriteString(335, TradSesReqID);
			if (MarketID is not null) writer.WriteString(1301, MarketID);
			if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
			if (TradingSessionID is not null) writer.WriteString(336, TradingSessionID);
			if (TradingSessionSubID is not null) writer.WriteString(625, TradingSessionSubID);
			if (SecurityExchange is not null) writer.WriteString(207, SecurityExchange);
			if (TradSesMethod is not null) writer.WriteWholeNumber(338, TradSesMethod.Value);
			if (TradSesMode is not null) writer.WriteWholeNumber(339, TradSesMode.Value);
			if (SubscriptionRequestType is not null) writer.WriteString(263, SubscriptionRequestType);
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
			TradSesReqID = view.GetString(335);
			MarketID = view.GetString(1301);
			MarketSegmentID = view.GetString(1300);
			TradingSessionID = view.GetString(336);
			TradingSessionSubID = view.GetString(625);
			SecurityExchange = view.GetString(207);
			TradSesMethod = view.GetInt32(338);
			TradSesMode = view.GetInt32(339);
			SubscriptionRequestType = view.GetString(263);
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
				case "TradSesReqID":
				{
					value = TradSesReqID;
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
				case "SecurityExchange":
				{
					value = SecurityExchange;
					break;
				}
				case "TradSesMethod":
				{
					value = TradSesMethod;
					break;
				}
				case "TradSesMode":
				{
					value = TradSesMode;
					break;
				}
				case "SubscriptionRequestType":
				{
					value = SubscriptionRequestType;
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
			TradSesReqID = null;
			MarketID = null;
			MarketSegmentID = null;
			TradingSessionID = null;
			TradingSessionSubID = null;
			SecurityExchange = null;
			TradSesMethod = null;
			TradSesMode = null;
			SubscriptionRequestType = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
