using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class OrderAggregationGrp : IFixComponent
	{
		public sealed partial class NoOrders : IFixGroup
		{
			[TagDetails(Tag = 11, Type = TagType.String, Offset = 0, Required = false)]
			public string? ClOrdID {get; set;}
			
			[TagDetails(Tag = 37, Type = TagType.String, Offset = 1, Required = false)]
			public string? OrderID {get; set;}
			
			[TagDetails(Tag = 38, Type = TagType.Float, Offset = 2, Required = false)]
			public double? OrderQty {get; set;}
			
			[TagDetails(Tag = 799, Type = TagType.Float, Offset = 3, Required = false)]
			public double? OrderAvgPx {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ClOrdID is not null) writer.WriteString(11, ClOrdID);
				if (OrderID is not null) writer.WriteString(37, OrderID);
				if (OrderQty is not null) writer.WriteNumber(38, OrderQty.Value);
				if (OrderAvgPx is not null) writer.WriteNumber(799, OrderAvgPx.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ClOrdID = view.GetString(11);
				OrderID = view.GetString(37);
				OrderQty = view.GetDouble(38);
				OrderAvgPx = view.GetDouble(799);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ClOrdID":
					{
						value = ClOrdID;
						break;
					}
					case "OrderID":
					{
						value = OrderID;
						break;
					}
					case "OrderQty":
					{
						value = OrderQty;
						break;
					}
					case "OrderAvgPx":
					{
						value = OrderAvgPx;
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
				ClOrdID = null;
				OrderID = null;
				OrderQty = null;
				OrderAvgPx = null;
			}
		}
		[Group(NoOfTag = 73, Offset = 0, Required = false)]
		public NoOrders[]? Orders {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Orders is not null && Orders.Length != 0)
			{
				writer.WriteWholeNumber(73, Orders.Length);
				for (int i = 0; i < Orders.Length; i++)
				{
					((IFixEncoder)Orders[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoOrders") is IMessageView viewNoOrders)
			{
				var count = viewNoOrders.GroupCount();
				Orders = new NoOrders[count];
				for (int i = 0; i < count; i++)
				{
					Orders[i] = new();
					((IFixParser)Orders[i]).Parse(viewNoOrders.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoOrders":
				{
					value = Orders;
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
			Orders = null;
		}
	}
}
