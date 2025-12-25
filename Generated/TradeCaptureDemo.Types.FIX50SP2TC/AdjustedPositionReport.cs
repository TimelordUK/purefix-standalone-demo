using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("BL", FixVersion.FIX50SP2)]
	public sealed partial class AdjustedPositionReport : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 721, Type = TagType.String, Offset = 1, Required = true)]
		public string? PosMaintRptID {get; set;}
		
		[TagDetails(Tag = 724, Type = TagType.Int, Offset = 2, Required = false)]
		public int? PosReqType {get; set;}
		
		[TagDetails(Tag = 715, Type = TagType.LocalDate, Offset = 3, Required = true)]
		public DateOnly? ClearingBusinessDate {get; set;}
		
		[TagDetails(Tag = 716, Type = TagType.String, Offset = 4, Required = false)]
		public string? SettlSessID {get; set;}
		
		[TagDetails(Tag = 714, Type = TagType.String, Offset = 5, Required = false)]
		public string? PosMaintRptRefID {get; set;}
		
		[Component(Offset = 6, Required = true)]
		public Parties? Parties {get; set;}
		
		[Component(Offset = 7, Required = true)]
		public PositionQty? PositionQty {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public InstrmtGrp? InstrmtGrp {get; set;}
		
		[TagDetails(Tag = 730, Type = TagType.Float, Offset = 9, Required = false)]
		public double? SettlPrice {get; set;}
		
		[TagDetails(Tag = 734, Type = TagType.Float, Offset = 10, Required = false)]
		public double? PriorSettlPrice {get; set;}
		
		[Component(Offset = 11, Required = true)]
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
			if (PosMaintRptID is not null) writer.WriteString(721, PosMaintRptID);
			if (PosReqType is not null) writer.WriteWholeNumber(724, PosReqType.Value);
			if (ClearingBusinessDate is not null) writer.WriteLocalDateOnly(715, ClearingBusinessDate.Value);
			if (SettlSessID is not null) writer.WriteString(716, SettlSessID);
			if (PosMaintRptRefID is not null) writer.WriteString(714, PosMaintRptRefID);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (PositionQty is not null) ((IFixEncoder)PositionQty).Encode(writer);
			if (InstrmtGrp is not null) ((IFixEncoder)InstrmtGrp).Encode(writer);
			if (SettlPrice is not null) writer.WriteNumber(730, SettlPrice.Value);
			if (PriorSettlPrice is not null) writer.WriteNumber(734, PriorSettlPrice.Value);
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
			PosMaintRptID = view.GetString(721);
			PosReqType = view.GetInt32(724);
			ClearingBusinessDate = view.GetDateOnly(715);
			SettlSessID = view.GetString(716);
			PosMaintRptRefID = view.GetString(714);
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			if (view.GetView("PositionQty") is IMessageView viewPositionQty)
			{
				PositionQty = new();
				((IFixParser)PositionQty).Parse(viewPositionQty);
			}
			if (view.GetView("InstrmtGrp") is IMessageView viewInstrmtGrp)
			{
				InstrmtGrp = new();
				((IFixParser)InstrmtGrp).Parse(viewInstrmtGrp);
			}
			SettlPrice = view.GetDouble(730);
			PriorSettlPrice = view.GetDouble(734);
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
				case "PosMaintRptID":
				{
					value = PosMaintRptID;
					break;
				}
				case "PosReqType":
				{
					value = PosReqType;
					break;
				}
				case "ClearingBusinessDate":
				{
					value = ClearingBusinessDate;
					break;
				}
				case "SettlSessID":
				{
					value = SettlSessID;
					break;
				}
				case "PosMaintRptRefID":
				{
					value = PosMaintRptRefID;
					break;
				}
				case "Parties":
				{
					value = Parties;
					break;
				}
				case "PositionQty":
				{
					value = PositionQty;
					break;
				}
				case "InstrmtGrp":
				{
					value = InstrmtGrp;
					break;
				}
				case "SettlPrice":
				{
					value = SettlPrice;
					break;
				}
				case "PriorSettlPrice":
				{
					value = PriorSettlPrice;
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
			PosMaintRptID = null;
			PosReqType = null;
			ClearingBusinessDate = null;
			SettlSessID = null;
			PosMaintRptRefID = null;
			((IFixReset?)Parties)?.Reset();
			((IFixReset?)PositionQty)?.Reset();
			((IFixReset?)InstrmtGrp)?.Reset();
			SettlPrice = null;
			PriorSettlPrice = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
