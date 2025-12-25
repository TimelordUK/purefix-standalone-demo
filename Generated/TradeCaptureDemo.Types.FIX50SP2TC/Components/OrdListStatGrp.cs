using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class OrdListStatGrp : IFixComponent
	{
		public sealed partial class NoOrders : IFixGroup
		{
			[TagDetails(Tag = 11, Type = TagType.String, Offset = 0, Required = false)]
			public string? ClOrdID {get; set;}
			
			[TagDetails(Tag = 37, Type = TagType.String, Offset = 1, Required = false)]
			public string? OrderID {get; set;}
			
			[TagDetails(Tag = 526, Type = TagType.String, Offset = 2, Required = false)]
			public string? SecondaryClOrdID {get; set;}
			
			[TagDetails(Tag = 14, Type = TagType.Float, Offset = 3, Required = true)]
			public double? CumQty {get; set;}
			
			[TagDetails(Tag = 39, Type = TagType.String, Offset = 4, Required = true)]
			public string? OrdStatus {get; set;}
			
			[TagDetails(Tag = 636, Type = TagType.Boolean, Offset = 5, Required = false)]
			public bool? WorkingIndicator {get; set;}
			
			[TagDetails(Tag = 151, Type = TagType.Float, Offset = 6, Required = true)]
			public double? LeavesQty {get; set;}
			
			[TagDetails(Tag = 84, Type = TagType.Float, Offset = 7, Required = true)]
			public double? CxlQty {get; set;}
			
			[TagDetails(Tag = 6, Type = TagType.Float, Offset = 8, Required = true)]
			public double? AvgPx {get; set;}
			
			[TagDetails(Tag = 103, Type = TagType.Int, Offset = 9, Required = false)]
			public int? OrdRejReason {get; set;}
			
			[TagDetails(Tag = 58, Type = TagType.String, Offset = 10, Required = false)]
			public string? Text {get; set;}
			
			[TagDetails(Tag = 354, Type = TagType.Length, Offset = 11, Required = false)]
			public int? EncodedTextLen {get; set;}
			
			[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 12, Required = false)]
			public byte[]? EncodedText {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ClOrdID is not null) writer.WriteString(11, ClOrdID);
				if (OrderID is not null) writer.WriteString(37, OrderID);
				if (SecondaryClOrdID is not null) writer.WriteString(526, SecondaryClOrdID);
				if (CumQty is not null) writer.WriteNumber(14, CumQty.Value);
				if (OrdStatus is not null) writer.WriteString(39, OrdStatus);
				if (WorkingIndicator is not null) writer.WriteBoolean(636, WorkingIndicator.Value);
				if (LeavesQty is not null) writer.WriteNumber(151, LeavesQty.Value);
				if (CxlQty is not null) writer.WriteNumber(84, CxlQty.Value);
				if (AvgPx is not null) writer.WriteNumber(6, AvgPx.Value);
				if (OrdRejReason is not null) writer.WriteWholeNumber(103, OrdRejReason.Value);
				if (Text is not null) writer.WriteString(58, Text);
				if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
				if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ClOrdID = view.GetString(11);
				OrderID = view.GetString(37);
				SecondaryClOrdID = view.GetString(526);
				CumQty = view.GetDouble(14);
				OrdStatus = view.GetString(39);
				WorkingIndicator = view.GetBool(636);
				LeavesQty = view.GetDouble(151);
				CxlQty = view.GetDouble(84);
				AvgPx = view.GetDouble(6);
				OrdRejReason = view.GetInt32(103);
				Text = view.GetString(58);
				EncodedTextLen = view.GetInt32(354);
				EncodedText = view.GetByteArray(355);
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
					case "SecondaryClOrdID":
					{
						value = SecondaryClOrdID;
						break;
					}
					case "CumQty":
					{
						value = CumQty;
						break;
					}
					case "OrdStatus":
					{
						value = OrdStatus;
						break;
					}
					case "WorkingIndicator":
					{
						value = WorkingIndicator;
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
					case "AvgPx":
					{
						value = AvgPx;
						break;
					}
					case "OrdRejReason":
					{
						value = OrdRejReason;
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
				SecondaryClOrdID = null;
				CumQty = null;
				OrdStatus = null;
				WorkingIndicator = null;
				LeavesQty = null;
				CxlQty = null;
				AvgPx = null;
				OrdRejReason = null;
				Text = null;
				EncodedTextLen = null;
				EncodedText = null;
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
