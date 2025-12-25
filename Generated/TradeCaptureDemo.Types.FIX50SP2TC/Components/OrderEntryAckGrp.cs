using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class OrderEntryAckGrp : IFixComponent
	{
		public sealed partial class NoOrderEntries : IFixGroup
		{
			[TagDetails(Tag = 39, Type = TagType.String, Offset = 0, Required = false)]
			public string? OrdStatus {get; set;}
			
			[TagDetails(Tag = 150, Type = TagType.String, Offset = 1, Required = false)]
			public string? ExecType {get; set;}
			
			[TagDetails(Tag = 2431, Type = TagType.Int, Offset = 2, Required = false)]
			public int? ExecTypeReason {get; set;}
			
			[TagDetails(Tag = 2429, Type = TagType.String, Offset = 3, Required = false)]
			public string? OrderEntryAction {get; set;}
			
			[TagDetails(Tag = 2430, Type = TagType.Int, Offset = 4, Required = false)]
			public int? OrderEntryID {get; set;}
			
			[TagDetails(Tag = 11, Type = TagType.String, Offset = 5, Required = false)]
			public string? ClOrdID {get; set;}
			
			[TagDetails(Tag = 41, Type = TagType.String, Offset = 6, Required = false)]
			public string? OrigClOrdID {get; set;}
			
			[TagDetails(Tag = 37, Type = TagType.String, Offset = 7, Required = false)]
			public string? OrderID {get; set;}
			
			[TagDetails(Tag = 103, Type = TagType.Int, Offset = 8, Required = false)]
			public int? OrdRejReason {get; set;}
			
			[TagDetails(Tag = 14, Type = TagType.Float, Offset = 9, Required = false)]
			public double? CumQty {get; set;}
			
			[TagDetails(Tag = 151, Type = TagType.Float, Offset = 10, Required = false)]
			public double? LeavesQty {get; set;}
			
			[TagDetails(Tag = 84, Type = TagType.Float, Offset = 11, Required = false)]
			public double? CxlQty {get; set;}
			
			[TagDetails(Tag = 40, Type = TagType.String, Offset = 12, Required = false)]
			public string? OrdType {get; set;}
			
			[TagDetails(Tag = 44, Type = TagType.Float, Offset = 13, Required = false)]
			public double? Price {get; set;}
			
			[TagDetails(Tag = 54, Type = TagType.String, Offset = 14, Required = false)]
			public string? Side {get; set;}
			
			[TagDetails(Tag = 59, Type = TagType.String, Offset = 15, Required = false)]
			public string? TimeInForce {get; set;}
			
			[Component(Offset = 16, Required = false)]
			public OrderQtyData? OrderQtyData {get; set;}
			
			[Component(Offset = 17, Required = false)]
			public Instrument? Instrument {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (OrdStatus is not null) writer.WriteString(39, OrdStatus);
				if (ExecType is not null) writer.WriteString(150, ExecType);
				if (ExecTypeReason is not null) writer.WriteWholeNumber(2431, ExecTypeReason.Value);
				if (OrderEntryAction is not null) writer.WriteString(2429, OrderEntryAction);
				if (OrderEntryID is not null) writer.WriteWholeNumber(2430, OrderEntryID.Value);
				if (ClOrdID is not null) writer.WriteString(11, ClOrdID);
				if (OrigClOrdID is not null) writer.WriteString(41, OrigClOrdID);
				if (OrderID is not null) writer.WriteString(37, OrderID);
				if (OrdRejReason is not null) writer.WriteWholeNumber(103, OrdRejReason.Value);
				if (CumQty is not null) writer.WriteNumber(14, CumQty.Value);
				if (LeavesQty is not null) writer.WriteNumber(151, LeavesQty.Value);
				if (CxlQty is not null) writer.WriteNumber(84, CxlQty.Value);
				if (OrdType is not null) writer.WriteString(40, OrdType);
				if (Price is not null) writer.WriteNumber(44, Price.Value);
				if (Side is not null) writer.WriteString(54, Side);
				if (TimeInForce is not null) writer.WriteString(59, TimeInForce);
				if (OrderQtyData is not null) ((IFixEncoder)OrderQtyData).Encode(writer);
				if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				OrdStatus = view.GetString(39);
				ExecType = view.GetString(150);
				ExecTypeReason = view.GetInt32(2431);
				OrderEntryAction = view.GetString(2429);
				OrderEntryID = view.GetInt32(2430);
				ClOrdID = view.GetString(11);
				OrigClOrdID = view.GetString(41);
				OrderID = view.GetString(37);
				OrdRejReason = view.GetInt32(103);
				CumQty = view.GetDouble(14);
				LeavesQty = view.GetDouble(151);
				CxlQty = view.GetDouble(84);
				OrdType = view.GetString(40);
				Price = view.GetDouble(44);
				Side = view.GetString(54);
				TimeInForce = view.GetString(59);
				if (view.GetView("OrderQtyData") is IMessageView viewOrderQtyData)
				{
					OrderQtyData = new();
					((IFixParser)OrderQtyData).Parse(viewOrderQtyData);
				}
				if (view.GetView("Instrument") is IMessageView viewInstrument)
				{
					Instrument = new();
					((IFixParser)Instrument).Parse(viewInstrument);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "OrdStatus":
					{
						value = OrdStatus;
						break;
					}
					case "ExecType":
					{
						value = ExecType;
						break;
					}
					case "ExecTypeReason":
					{
						value = ExecTypeReason;
						break;
					}
					case "OrderEntryAction":
					{
						value = OrderEntryAction;
						break;
					}
					case "OrderEntryID":
					{
						value = OrderEntryID;
						break;
					}
					case "ClOrdID":
					{
						value = ClOrdID;
						break;
					}
					case "OrigClOrdID":
					{
						value = OrigClOrdID;
						break;
					}
					case "OrderID":
					{
						value = OrderID;
						break;
					}
					case "OrdRejReason":
					{
						value = OrdRejReason;
						break;
					}
					case "CumQty":
					{
						value = CumQty;
						break;
					}
					case "LeavesQty":
					{
						value = LeavesQty;
						break;
					}
					case "CxlQty":
					{
						value = CxlQty;
						break;
					}
					case "OrdType":
					{
						value = OrdType;
						break;
					}
					case "Price":
					{
						value = Price;
						break;
					}
					case "Side":
					{
						value = Side;
						break;
					}
					case "TimeInForce":
					{
						value = TimeInForce;
						break;
					}
					case "OrderQtyData":
					{
						value = OrderQtyData;
						break;
					}
					case "Instrument":
					{
						value = Instrument;
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
				OrdStatus = null;
				ExecType = null;
				ExecTypeReason = null;
				OrderEntryAction = null;
				OrderEntryID = null;
				ClOrdID = null;
				OrigClOrdID = null;
				OrderID = null;
				OrdRejReason = null;
				CumQty = null;
				LeavesQty = null;
				CxlQty = null;
				OrdType = null;
				Price = null;
				Side = null;
				TimeInForce = null;
				((IFixReset?)OrderQtyData)?.Reset();
				((IFixReset?)Instrument)?.Reset();
			}
		}
		[Group(NoOfTag = 2428, Offset = 0, Required = false)]
		public NoOrderEntries[]? OrderEntries {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (OrderEntries is not null && OrderEntries.Length != 0)
			{
				writer.WriteWholeNumber(2428, OrderEntries.Length);
				for (int i = 0; i < OrderEntries.Length; i++)
				{
					((IFixEncoder)OrderEntries[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoOrderEntries") is IMessageView viewNoOrderEntries)
			{
				var count = viewNoOrderEntries.GroupCount();
				OrderEntries = new NoOrderEntries[count];
				for (int i = 0; i < count; i++)
				{
					OrderEntries[i] = new();
					((IFixParser)OrderEntries[i]).Parse(viewNoOrderEntries.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoOrderEntries":
				{
					value = OrderEntries;
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
			OrderEntries = null;
		}
	}
}
