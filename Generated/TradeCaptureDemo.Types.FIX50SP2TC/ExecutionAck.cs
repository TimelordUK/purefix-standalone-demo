using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("BN", FixVersion.FIX50SP2)]
	public sealed partial class ExecutionAck : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 37, Type = TagType.String, Offset = 1, Required = true)]
		public string? OrderID {get; set;}
		
		[TagDetails(Tag = 198, Type = TagType.String, Offset = 2, Required = false)]
		public string? SecondaryOrderID {get; set;}
		
		[TagDetails(Tag = 11, Type = TagType.String, Offset = 3, Required = false)]
		public string? ClOrdID {get; set;}
		
		[TagDetails(Tag = 1036, Type = TagType.String, Offset = 4, Required = true)]
		public string? ExecAckStatus {get; set;}
		
		[TagDetails(Tag = 17, Type = TagType.String, Offset = 5, Required = true)]
		public string? ExecID {get; set;}
		
		[TagDetails(Tag = 127, Type = TagType.String, Offset = 6, Required = false)]
		public string? DKReason {get; set;}
		
		[Component(Offset = 7, Required = true)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public UndInstrmtGrp? UndInstrmtGrp {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public InstrmtLegGrp? InstrmtLegGrp {get; set;}
		
		[TagDetails(Tag = 54, Type = TagType.String, Offset = 10, Required = true)]
		public string? Side {get; set;}
		
		[Component(Offset = 11, Required = false)]
		public OrderQtyData? OrderQtyData {get; set;}
		
		[TagDetails(Tag = 32, Type = TagType.Float, Offset = 12, Required = false)]
		public double? LastQty {get; set;}
		
		[TagDetails(Tag = 31, Type = TagType.Float, Offset = 13, Required = false)]
		public double? LastPx {get; set;}
		
		[TagDetails(Tag = 423, Type = TagType.Int, Offset = 14, Required = false)]
		public int? PriceType {get; set;}
		
		[Component(Offset = 15, Required = false)]
		public PriceQualifierGrp? PriceQualifierGrp {get; set;}
		
		[TagDetails(Tag = 669, Type = TagType.Float, Offset = 16, Required = false)]
		public double? LastParPx {get; set;}
		
		[TagDetails(Tag = 14, Type = TagType.Float, Offset = 17, Required = false)]
		public double? CumQty {get; set;}
		
		[TagDetails(Tag = 6, Type = TagType.Float, Offset = 18, Required = false)]
		public double? AvgPx {get; set;}
		
		[Component(Offset = 19, Required = false)]
		public RegulatoryTradeIDGrp? RegulatoryTradeIDGrp {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 20, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 21, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 22, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 23, Required = true)]
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
			if (SecondaryOrderID is not null) writer.WriteString(198, SecondaryOrderID);
			if (ClOrdID is not null) writer.WriteString(11, ClOrdID);
			if (ExecAckStatus is not null) writer.WriteString(1036, ExecAckStatus);
			if (ExecID is not null) writer.WriteString(17, ExecID);
			if (DKReason is not null) writer.WriteString(127, DKReason);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
			if (InstrmtLegGrp is not null) ((IFixEncoder)InstrmtLegGrp).Encode(writer);
			if (Side is not null) writer.WriteString(54, Side);
			if (OrderQtyData is not null) ((IFixEncoder)OrderQtyData).Encode(writer);
			if (LastQty is not null) writer.WriteNumber(32, LastQty.Value);
			if (LastPx is not null) writer.WriteNumber(31, LastPx.Value);
			if (PriceType is not null) writer.WriteWholeNumber(423, PriceType.Value);
			if (PriceQualifierGrp is not null) ((IFixEncoder)PriceQualifierGrp).Encode(writer);
			if (LastParPx is not null) writer.WriteNumber(669, LastParPx.Value);
			if (CumQty is not null) writer.WriteNumber(14, CumQty.Value);
			if (AvgPx is not null) writer.WriteNumber(6, AvgPx.Value);
			if (RegulatoryTradeIDGrp is not null) ((IFixEncoder)RegulatoryTradeIDGrp).Encode(writer);
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
			OrderID = view.GetString(37);
			SecondaryOrderID = view.GetString(198);
			ClOrdID = view.GetString(11);
			ExecAckStatus = view.GetString(1036);
			ExecID = view.GetString(17);
			DKReason = view.GetString(127);
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
			Side = view.GetString(54);
			if (view.GetView("OrderQtyData") is IMessageView viewOrderQtyData)
			{
				OrderQtyData = new();
				((IFixParser)OrderQtyData).Parse(viewOrderQtyData);
			}
			LastQty = view.GetDouble(32);
			LastPx = view.GetDouble(31);
			PriceType = view.GetInt32(423);
			if (view.GetView("PriceQualifierGrp") is IMessageView viewPriceQualifierGrp)
			{
				PriceQualifierGrp = new();
				((IFixParser)PriceQualifierGrp).Parse(viewPriceQualifierGrp);
			}
			LastParPx = view.GetDouble(669);
			CumQty = view.GetDouble(14);
			AvgPx = view.GetDouble(6);
			if (view.GetView("RegulatoryTradeIDGrp") is IMessageView viewRegulatoryTradeIDGrp)
			{
				RegulatoryTradeIDGrp = new();
				((IFixParser)RegulatoryTradeIDGrp).Parse(viewRegulatoryTradeIDGrp);
			}
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
				case "OrderID":
				{
					value = OrderID;
					break;
				}
				case "SecondaryOrderID":
				{
					value = SecondaryOrderID;
					break;
				}
				case "ClOrdID":
				{
					value = ClOrdID;
					break;
				}
				case "ExecAckStatus":
				{
					value = ExecAckStatus;
					break;
				}
				case "ExecID":
				{
					value = ExecID;
					break;
				}
				case "DKReason":
				{
					value = DKReason;
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
				case "Side":
				{
					value = Side;
					break;
				}
				case "OrderQtyData":
				{
					value = OrderQtyData;
					break;
				}
				case "LastQty":
				{
					value = LastQty;
					break;
				}
				case "LastPx":
				{
					value = LastPx;
					break;
				}
				case "PriceType":
				{
					value = PriceType;
					break;
				}
				case "PriceQualifierGrp":
				{
					value = PriceQualifierGrp;
					break;
				}
				case "LastParPx":
				{
					value = LastParPx;
					break;
				}
				case "CumQty":
				{
					value = CumQty;
					break;
				}
				case "AvgPx":
				{
					value = AvgPx;
					break;
				}
				case "RegulatoryTradeIDGrp":
				{
					value = RegulatoryTradeIDGrp;
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
			OrderID = null;
			SecondaryOrderID = null;
			ClOrdID = null;
			ExecAckStatus = null;
			ExecID = null;
			DKReason = null;
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)UndInstrmtGrp)?.Reset();
			((IFixReset?)InstrmtLegGrp)?.Reset();
			Side = null;
			((IFixReset?)OrderQtyData)?.Reset();
			LastQty = null;
			LastPx = null;
			PriceType = null;
			((IFixReset?)PriceQualifierGrp)?.Reset();
			LastParPx = null;
			CumQty = null;
			AvgPx = null;
			((IFixReset?)RegulatoryTradeIDGrp)?.Reset();
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
