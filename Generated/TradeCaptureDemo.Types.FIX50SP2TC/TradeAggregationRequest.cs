using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("DW", FixVersion.FIX50SP2)]
	public sealed partial class TradeAggregationRequest : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 2786, Type = TagType.String, Offset = 1, Required = true)]
		public string? TradeAggregationRequestID {get; set;}
		
		[TagDetails(Tag = 2787, Type = TagType.String, Offset = 2, Required = false)]
		public string? TradeAggregationRequestRefID {get; set;}
		
		[TagDetails(Tag = 2788, Type = TagType.Int, Offset = 3, Required = true)]
		public int? TradeAggregationTransType {get; set;}
		
		[TagDetails(Tag = 2789, Type = TagType.Float, Offset = 4, Required = false)]
		public double? AggregatedQty {get; set;}
		
		[TagDetails(Tag = 15, Type = TagType.String, Offset = 5, Required = false)]
		public string? Currency {get; set;}
		
		[TagDetails(Tag = 2897, Type = TagType.String, Offset = 6, Required = false)]
		public string? CurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 6, Type = TagType.Float, Offset = 7, Required = false)]
		public double? AvgPx {get; set;}
		
		[TagDetails(Tag = 54, Type = TagType.String, Offset = 8, Required = true)]
		public string? Side {get; set;}
		
		[TagDetails(Tag = 2349, Type = TagType.Int, Offset = 9, Required = false)]
		public int? PricePrecision {get; set;}
		
		[Component(Offset = 10, Required = false)]
		public OrderAggregationGrp? OrderAggregationGrp {get; set;}
		
		[Component(Offset = 11, Required = false)]
		public ExecutionAggregationGrp? ExecutionAggregationGrp {get; set;}
		
		[TagDetails(Tag = 1, Type = TagType.String, Offset = 12, Required = false)]
		public string? Account {get; set;}
		
		[Component(Offset = 13, Required = true)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 14, Required = false)]
		public Parties? Parties {get; set;}
		
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
			if (TradeAggregationRequestID is not null) writer.WriteString(2786, TradeAggregationRequestID);
			if (TradeAggregationRequestRefID is not null) writer.WriteString(2787, TradeAggregationRequestRefID);
			if (TradeAggregationTransType is not null) writer.WriteWholeNumber(2788, TradeAggregationTransType.Value);
			if (AggregatedQty is not null) writer.WriteNumber(2789, AggregatedQty.Value);
			if (Currency is not null) writer.WriteString(15, Currency);
			if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
			if (AvgPx is not null) writer.WriteNumber(6, AvgPx.Value);
			if (Side is not null) writer.WriteString(54, Side);
			if (PricePrecision is not null) writer.WriteWholeNumber(2349, PricePrecision.Value);
			if (OrderAggregationGrp is not null) ((IFixEncoder)OrderAggregationGrp).Encode(writer);
			if (ExecutionAggregationGrp is not null) ((IFixEncoder)ExecutionAggregationGrp).Encode(writer);
			if (Account is not null) writer.WriteString(1, Account);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
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
			TradeAggregationRequestID = view.GetString(2786);
			TradeAggregationRequestRefID = view.GetString(2787);
			TradeAggregationTransType = view.GetInt32(2788);
			AggregatedQty = view.GetDouble(2789);
			Currency = view.GetString(15);
			CurrencyCodeSource = view.GetString(2897);
			AvgPx = view.GetDouble(6);
			Side = view.GetString(54);
			PricePrecision = view.GetInt32(2349);
			if (view.GetView("OrderAggregationGrp") is IMessageView viewOrderAggregationGrp)
			{
				OrderAggregationGrp = new();
				((IFixParser)OrderAggregationGrp).Parse(viewOrderAggregationGrp);
			}
			if (view.GetView("ExecutionAggregationGrp") is IMessageView viewExecutionAggregationGrp)
			{
				ExecutionAggregationGrp = new();
				((IFixParser)ExecutionAggregationGrp).Parse(viewExecutionAggregationGrp);
			}
			Account = view.GetString(1);
			if (view.GetView("Instrument") is IMessageView viewInstrument)
			{
				Instrument = new();
				((IFixParser)Instrument).Parse(viewInstrument);
			}
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
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
				case "TradeAggregationRequestID":
				{
					value = TradeAggregationRequestID;
					break;
				}
				case "TradeAggregationRequestRefID":
				{
					value = TradeAggregationRequestRefID;
					break;
				}
				case "TradeAggregationTransType":
				{
					value = TradeAggregationTransType;
					break;
				}
				case "AggregatedQty":
				{
					value = AggregatedQty;
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
				case "AvgPx":
				{
					value = AvgPx;
					break;
				}
				case "Side":
				{
					value = Side;
					break;
				}
				case "PricePrecision":
				{
					value = PricePrecision;
					break;
				}
				case "OrderAggregationGrp":
				{
					value = OrderAggregationGrp;
					break;
				}
				case "ExecutionAggregationGrp":
				{
					value = ExecutionAggregationGrp;
					break;
				}
				case "Account":
				{
					value = Account;
					break;
				}
				case "Instrument":
				{
					value = Instrument;
					break;
				}
				case "Parties":
				{
					value = Parties;
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
			TradeAggregationRequestID = null;
			TradeAggregationRequestRefID = null;
			TradeAggregationTransType = null;
			AggregatedQty = null;
			Currency = null;
			CurrencyCodeSource = null;
			AvgPx = null;
			Side = null;
			PricePrecision = null;
			((IFixReset?)OrderAggregationGrp)?.Reset();
			((IFixReset?)ExecutionAggregationGrp)?.Reset();
			Account = null;
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)Parties)?.Reset();
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
