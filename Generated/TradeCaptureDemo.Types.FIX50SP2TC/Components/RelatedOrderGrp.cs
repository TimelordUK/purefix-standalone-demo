using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class RelatedOrderGrp : IFixComponent
	{
		public sealed partial class NoOrders : IFixGroup
		{
			[TagDetails(Tag = 2887, Type = TagType.String, Offset = 0, Required = false)]
			public string? RelatedOrderID {get; set;}
			
			[TagDetails(Tag = 2888, Type = TagType.Int, Offset = 1, Required = false)]
			public int? RelatedOrderIDSource {get; set;}
			
			[TagDetails(Tag = 2836, Type = TagType.UtcTimestamp, Offset = 2, Required = false)]
			public DateTime? RelatedOrderTime {get; set;}
			
			[TagDetails(Tag = 2889, Type = TagType.Float, Offset = 3, Required = false)]
			public double? RelatedOrderQty {get; set;}
			
			[TagDetails(Tag = 2890, Type = TagType.Int, Offset = 4, Required = false)]
			public int? OrderRelationship {get; set;}
			
			[TagDetails(Tag = 2835, Type = TagType.String, Offset = 5, Required = false)]
			public string? OrderOriginationFirmID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (RelatedOrderID is not null) writer.WriteString(2887, RelatedOrderID);
				if (RelatedOrderIDSource is not null) writer.WriteWholeNumber(2888, RelatedOrderIDSource.Value);
				if (RelatedOrderTime is not null) writer.WriteUtcTimeStamp(2836, RelatedOrderTime.Value);
				if (RelatedOrderQty is not null) writer.WriteNumber(2889, RelatedOrderQty.Value);
				if (OrderRelationship is not null) writer.WriteWholeNumber(2890, OrderRelationship.Value);
				if (OrderOriginationFirmID is not null) writer.WriteString(2835, OrderOriginationFirmID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				RelatedOrderID = view.GetString(2887);
				RelatedOrderIDSource = view.GetInt32(2888);
				RelatedOrderTime = view.GetDateTime(2836);
				RelatedOrderQty = view.GetDouble(2889);
				OrderRelationship = view.GetInt32(2890);
				OrderOriginationFirmID = view.GetString(2835);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "RelatedOrderID":
					{
						value = RelatedOrderID;
						break;
					}
					case "RelatedOrderIDSource":
					{
						value = RelatedOrderIDSource;
						break;
					}
					case "RelatedOrderTime":
					{
						value = RelatedOrderTime;
						break;
					}
					case "RelatedOrderQty":
					{
						value = RelatedOrderQty;
						break;
					}
					case "OrderRelationship":
					{
						value = OrderRelationship;
						break;
					}
					case "OrderOriginationFirmID":
					{
						value = OrderOriginationFirmID;
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
				RelatedOrderID = null;
				RelatedOrderIDSource = null;
				RelatedOrderTime = null;
				RelatedOrderQty = null;
				OrderRelationship = null;
				OrderOriginationFirmID = null;
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
