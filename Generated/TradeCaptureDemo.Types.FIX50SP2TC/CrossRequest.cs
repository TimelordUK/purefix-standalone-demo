using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("DS", FixVersion.FIX50SP2)]
	public sealed partial class CrossRequest : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 2672, Type = TagType.String, Offset = 1, Required = true)]
		public string? CrossRequestID {get; set;}
		
		[TagDetails(Tag = 1301, Type = TagType.String, Offset = 2, Required = false)]
		public string? MarketID {get; set;}
		
		[TagDetails(Tag = 1300, Type = TagType.String, Offset = 3, Required = false)]
		public string? MarketSegmentID {get; set;}
		
		[Component(Offset = 4, Required = true)]
		public Instrument? Instrument {get; set;}
		
		[TagDetails(Tag = 38, Type = TagType.Float, Offset = 5, Required = false)]
		public double? OrderQty {get; set;}
		
		[TagDetails(Tag = 376, Type = TagType.String, Offset = 6, Required = false)]
		public string? ComplianceID {get; set;}
		
		[TagDetails(Tag = 2404, Type = TagType.String, Offset = 7, Required = false)]
		public string? ComplianceText {get; set;}
		
		[Component(Offset = 8, Required = true)]
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
			if (CrossRequestID is not null) writer.WriteString(2672, CrossRequestID);
			if (MarketID is not null) writer.WriteString(1301, MarketID);
			if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (OrderQty is not null) writer.WriteNumber(38, OrderQty.Value);
			if (ComplianceID is not null) writer.WriteString(376, ComplianceID);
			if (ComplianceText is not null) writer.WriteString(2404, ComplianceText);
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
			CrossRequestID = view.GetString(2672);
			MarketID = view.GetString(1301);
			MarketSegmentID = view.GetString(1300);
			if (view.GetView("Instrument") is IMessageView viewInstrument)
			{
				Instrument = new();
				((IFixParser)Instrument).Parse(viewInstrument);
			}
			OrderQty = view.GetDouble(38);
			ComplianceID = view.GetString(376);
			ComplianceText = view.GetString(2404);
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
				case "CrossRequestID":
				{
					value = CrossRequestID;
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
				case "Instrument":
				{
					value = Instrument;
					break;
				}
				case "OrderQty":
				{
					value = OrderQty;
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
			CrossRequestID = null;
			MarketID = null;
			MarketSegmentID = null;
			((IFixReset?)Instrument)?.Reset();
			OrderQty = null;
			ComplianceID = null;
			ComplianceText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
