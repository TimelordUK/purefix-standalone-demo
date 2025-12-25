using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class OrderEventGrp : IFixComponent
	{
		public sealed partial class NoOrderEvents : IFixGroup
		{
			[TagDetails(Tag = 1796, Type = TagType.Int, Offset = 0, Required = false)]
			public int? OrderEventType {get; set;}
			
			[TagDetails(Tag = 1797, Type = TagType.String, Offset = 1, Required = false)]
			public string? OrderEventExecID {get; set;}
			
			[TagDetails(Tag = 1798, Type = TagType.Int, Offset = 2, Required = false)]
			public int? OrderEventReason {get; set;}
			
			[TagDetails(Tag = 1799, Type = TagType.Float, Offset = 3, Required = false)]
			public double? OrderEventPx {get; set;}
			
			[TagDetails(Tag = 1800, Type = TagType.Float, Offset = 4, Required = false)]
			public double? OrderEventQty {get; set;}
			
			[TagDetails(Tag = 1801, Type = TagType.Int, Offset = 5, Required = false)]
			public int? OrderEventLiquidityIndicator {get; set;}
			
			[TagDetails(Tag = 1802, Type = TagType.String, Offset = 6, Required = false)]
			public string? OrderEventText {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (OrderEventType is not null) writer.WriteWholeNumber(1796, OrderEventType.Value);
				if (OrderEventExecID is not null) writer.WriteString(1797, OrderEventExecID);
				if (OrderEventReason is not null) writer.WriteWholeNumber(1798, OrderEventReason.Value);
				if (OrderEventPx is not null) writer.WriteNumber(1799, OrderEventPx.Value);
				if (OrderEventQty is not null) writer.WriteNumber(1800, OrderEventQty.Value);
				if (OrderEventLiquidityIndicator is not null) writer.WriteWholeNumber(1801, OrderEventLiquidityIndicator.Value);
				if (OrderEventText is not null) writer.WriteString(1802, OrderEventText);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				OrderEventType = view.GetInt32(1796);
				OrderEventExecID = view.GetString(1797);
				OrderEventReason = view.GetInt32(1798);
				OrderEventPx = view.GetDouble(1799);
				OrderEventQty = view.GetDouble(1800);
				OrderEventLiquidityIndicator = view.GetInt32(1801);
				OrderEventText = view.GetString(1802);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "OrderEventType":
					{
						value = OrderEventType;
						break;
					}
					case "OrderEventExecID":
					{
						value = OrderEventExecID;
						break;
					}
					case "OrderEventReason":
					{
						value = OrderEventReason;
						break;
					}
					case "OrderEventPx":
					{
						value = OrderEventPx;
						break;
					}
					case "OrderEventQty":
					{
						value = OrderEventQty;
						break;
					}
					case "OrderEventLiquidityIndicator":
					{
						value = OrderEventLiquidityIndicator;
						break;
					}
					case "OrderEventText":
					{
						value = OrderEventText;
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
				OrderEventType = null;
				OrderEventExecID = null;
				OrderEventReason = null;
				OrderEventPx = null;
				OrderEventQty = null;
				OrderEventLiquidityIndicator = null;
				OrderEventText = null;
			}
		}
		[Group(NoOfTag = 1795, Offset = 0, Required = false)]
		public NoOrderEvents[]? OrderEvents {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (OrderEvents is not null && OrderEvents.Length != 0)
			{
				writer.WriteWholeNumber(1795, OrderEvents.Length);
				for (int i = 0; i < OrderEvents.Length; i++)
				{
					((IFixEncoder)OrderEvents[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoOrderEvents") is IMessageView viewNoOrderEvents)
			{
				var count = viewNoOrderEvents.GroupCount();
				OrderEvents = new NoOrderEvents[count];
				for (int i = 0; i < count; i++)
				{
					OrderEvents[i] = new();
					((IFixParser)OrderEvents[i]).Parse(viewNoOrderEvents.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoOrderEvents":
				{
					value = OrderEvents;
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
			OrderEvents = null;
		}
	}
}
