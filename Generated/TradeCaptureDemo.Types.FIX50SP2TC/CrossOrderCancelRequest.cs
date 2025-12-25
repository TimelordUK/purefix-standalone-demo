using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("u", FixVersion.FIX50SP2)]
	public sealed partial class CrossOrderCancelRequest : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 37, Type = TagType.String, Offset = 1, Required = false)]
		public string? OrderID {get; set;}
		
		[TagDetails(Tag = 2422, Type = TagType.Int, Offset = 2, Required = false)]
		public int? OrderRequestID {get; set;}
		
		[TagDetails(Tag = 548, Type = TagType.String, Offset = 3, Required = true)]
		public string? CrossID {get; set;}
		
		[TagDetails(Tag = 551, Type = TagType.String, Offset = 4, Required = true)]
		public string? OrigCrossID {get; set;}
		
		[TagDetails(Tag = 961, Type = TagType.String, Offset = 5, Required = false)]
		public string? HostCrossID {get; set;}
		
		[TagDetails(Tag = 549, Type = TagType.Int, Offset = 6, Required = true)]
		public int? CrossType {get; set;}
		
		[TagDetails(Tag = 550, Type = TagType.Int, Offset = 7, Required = true)]
		public int? CrossPrioritization {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public RootParties? RootParties {get; set;}
		
		[Component(Offset = 9, Required = true)]
		public SideCrossOrdCxlGrp? SideCrossOrdCxlGrp {get; set;}
		
		[Component(Offset = 10, Required = true)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 11, Required = false)]
		public UndInstrmtGrp? UndInstrmtGrp {get; set;}
		
		[Component(Offset = 12, Required = false)]
		public InstrmtLegGrp? InstrmtLegGrp {get; set;}
		
		[TagDetails(Tag = 1300, Type = TagType.String, Offset = 13, Required = false)]
		public string? MarketSegmentID {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 14, Required = true)]
		public DateTime? TransactTime {get; set;}
		
		[Component(Offset = 15, Required = true)]
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
			if (OrderID is not null) writer.WriteString(37, OrderID);
			if (OrderRequestID is not null) writer.WriteWholeNumber(2422, OrderRequestID.Value);
			if (CrossID is not null) writer.WriteString(548, CrossID);
			if (OrigCrossID is not null) writer.WriteString(551, OrigCrossID);
			if (HostCrossID is not null) writer.WriteString(961, HostCrossID);
			if (CrossType is not null) writer.WriteWholeNumber(549, CrossType.Value);
			if (CrossPrioritization is not null) writer.WriteWholeNumber(550, CrossPrioritization.Value);
			if (RootParties is not null) ((IFixEncoder)RootParties).Encode(writer);
			if (SideCrossOrdCxlGrp is not null) ((IFixEncoder)SideCrossOrdCxlGrp).Encode(writer);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
			if (InstrmtLegGrp is not null) ((IFixEncoder)InstrmtLegGrp).Encode(writer);
			if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
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
			OrderID = view.GetString(37);
			OrderRequestID = view.GetInt32(2422);
			CrossID = view.GetString(548);
			OrigCrossID = view.GetString(551);
			HostCrossID = view.GetString(961);
			CrossType = view.GetInt32(549);
			CrossPrioritization = view.GetInt32(550);
			if (view.GetView("RootParties") is IMessageView viewRootParties)
			{
				RootParties = new();
				((IFixParser)RootParties).Parse(viewRootParties);
			}
			if (view.GetView("SideCrossOrdCxlGrp") is IMessageView viewSideCrossOrdCxlGrp)
			{
				SideCrossOrdCxlGrp = new();
				((IFixParser)SideCrossOrdCxlGrp).Parse(viewSideCrossOrdCxlGrp);
			}
			if (view.GetView("Instrument") is IMessageView viewInstrument)
			{
				Instrument = new();
				((IFixParser)Instrument).Parse(viewInstrument);
			}
			if (view.GetView("UndInstrmtGrp") is IMessageView viewUndInstrmtGrp)
			{
				UndInstrmtGrp = new();
				((IFixParser)UndInstrmtGrp).Parse(viewUndInstrmtGrp);
			}
			if (view.GetView("InstrmtLegGrp") is IMessageView viewInstrmtLegGrp)
			{
				InstrmtLegGrp = new();
				((IFixParser)InstrmtLegGrp).Parse(viewInstrmtLegGrp);
			}
			MarketSegmentID = view.GetString(1300);
			TransactTime = view.GetDateTime(60);
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
				case "OrderID":
				{
					value = OrderID;
					break;
				}
				case "OrderRequestID":
				{
					value = OrderRequestID;
					break;
				}
				case "CrossID":
				{
					value = CrossID;
					break;
				}
				case "OrigCrossID":
				{
					value = OrigCrossID;
					break;
				}
				case "HostCrossID":
				{
					value = HostCrossID;
					break;
				}
				case "CrossType":
				{
					value = CrossType;
					break;
				}
				case "CrossPrioritization":
				{
					value = CrossPrioritization;
					break;
				}
				case "RootParties":
				{
					value = RootParties;
					break;
				}
				case "SideCrossOrdCxlGrp":
				{
					value = SideCrossOrdCxlGrp;
					break;
				}
				case "Instrument":
				{
					value = Instrument;
					break;
				}
				case "UndInstrmtGrp":
				{
					value = UndInstrmtGrp;
					break;
				}
				case "InstrmtLegGrp":
				{
					value = InstrmtLegGrp;
					break;
				}
				case "MarketSegmentID":
				{
					value = MarketSegmentID;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
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
			OrderID = null;
			OrderRequestID = null;
			CrossID = null;
			OrigCrossID = null;
			HostCrossID = null;
			CrossType = null;
			CrossPrioritization = null;
			((IFixReset?)RootParties)?.Reset();
			((IFixReset?)SideCrossOrdCxlGrp)?.Reset();
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)UndInstrmtGrp)?.Reset();
			((IFixReset?)InstrmtLegGrp)?.Reset();
			MarketSegmentID = null;
			TransactTime = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
