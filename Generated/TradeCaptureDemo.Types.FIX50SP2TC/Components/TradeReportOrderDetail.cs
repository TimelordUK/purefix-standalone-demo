using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class TradeReportOrderDetail : IFixComponent
	{
		[TagDetails(Tag = 37, Type = TagType.String, Offset = 0, Required = false)]
		public string? OrderID {get; set;}
		
		[TagDetails(Tag = 198, Type = TagType.String, Offset = 1, Required = false)]
		public string? SecondaryOrderID {get; set;}
		
		[TagDetails(Tag = 11, Type = TagType.String, Offset = 2, Required = false)]
		public string? ClOrdID {get; set;}
		
		[TagDetails(Tag = 526, Type = TagType.String, Offset = 3, Required = false)]
		public string? SecondaryClOrdID {get; set;}
		
		[TagDetails(Tag = 66, Type = TagType.String, Offset = 4, Required = false)]
		public string? ListID {get; set;}
		
		[TagDetails(Tag = 1080, Type = TagType.String, Offset = 5, Required = false)]
		public string? RefOrderID {get; set;}
		
		[TagDetails(Tag = 1081, Type = TagType.String, Offset = 6, Required = false)]
		public string? RefOrderIDSource {get; set;}
		
		[TagDetails(Tag = 1431, Type = TagType.Int, Offset = 7, Required = false)]
		public int? RefOrdIDReason {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public RelatedOrderGrp? RelatedOrderGrp {get; set;}
		
		[TagDetails(Tag = 1091, Type = TagType.Boolean, Offset = 9, Required = false)]
		public bool? PreTradeAnonymity {get; set;}
		
		[TagDetails(Tag = 40, Type = TagType.String, Offset = 10, Required = false)]
		public string? OrdType {get; set;}
		
		[TagDetails(Tag = 44, Type = TagType.Float, Offset = 11, Required = false)]
		public double? Price {get; set;}
		
		[TagDetails(Tag = 99, Type = TagType.Float, Offset = 12, Required = false)]
		public double? StopPx {get; set;}
		
		[TagDetails(Tag = 18, Type = TagType.String, Offset = 13, Required = false)]
		public string? ExecInst {get; set;}
		
		[TagDetails(Tag = 39, Type = TagType.String, Offset = 14, Required = false)]
		public string? OrdStatus {get; set;}
		
		[Component(Offset = 15, Required = false)]
		public OrderQtyData? OrderQtyData {get; set;}
		
		[TagDetails(Tag = 151, Type = TagType.Float, Offset = 16, Required = false)]
		public double? LeavesQty {get; set;}
		
		[TagDetails(Tag = 14, Type = TagType.Float, Offset = 17, Required = false)]
		public double? CumQty {get; set;}
		
		[TagDetails(Tag = 59, Type = TagType.String, Offset = 18, Required = false)]
		public string? TimeInForce {get; set;}
		
		[TagDetails(Tag = 126, Type = TagType.UtcTimestamp, Offset = 19, Required = false)]
		public DateTime? ExpireTime {get; set;}
		
		[Component(Offset = 20, Required = false)]
		public MatchingInstructions? MatchingInstructions {get; set;}
		
		[TagDetails(Tag = 2362, Type = TagType.String, Offset = 21, Required = false)]
		public string? SelfMatchPreventionID {get; set;}
		
		[TagDetails(Tag = 2964, Type = TagType.Int, Offset = 22, Required = false)]
		public int? SelfMatchPreventionInstruction {get; set;}
		
		[TagDetails(Tag = 1629, Type = TagType.Int, Offset = 23, Required = false)]
		public int? ExposureDuration {get; set;}
		
		[TagDetails(Tag = 1916, Type = TagType.Int, Offset = 24, Required = false)]
		public int? ExposureDurationUnit {get; set;}
		
		[Component(Offset = 25, Required = false)]
		public DisplayInstruction? DisplayInstruction {get; set;}
		
		[TagDetails(Tag = 528, Type = TagType.String, Offset = 26, Required = false)]
		public string? OrderCapacity {get; set;}
		
		[TagDetails(Tag = 529, Type = TagType.String, Offset = 27, Required = false)]
		public string? OrderRestrictions {get; set;}
		
		[TagDetails(Tag = 775, Type = TagType.Int, Offset = 28, Required = false)]
		public int? BookingType {get; set;}
		
		[TagDetails(Tag = 1432, Type = TagType.Int, Offset = 29, Required = false)]
		public int? OrigCustOrderCapacity {get; set;}
		
		[TagDetails(Tag = 1724, Type = TagType.Int, Offset = 30, Required = false)]
		public int? OrderOrigination {get; set;}
		
		[Component(Offset = 31, Required = false)]
		public OrderAttributeGrp? OrderAttributeGrp {get; set;}
		
		[TagDetails(Tag = 2704, Type = TagType.Int, Offset = 32, Required = false)]
		public int? ExDestinationType {get; set;}
		
		[TagDetails(Tag = 821, Type = TagType.String, Offset = 33, Required = false)]
		public string? OrderInputDevice {get; set;}
		
		[TagDetails(Tag = 1093, Type = TagType.String, Offset = 34, Required = false)]
		public string? LotType {get; set;}
		
		[TagDetails(Tag = 483, Type = TagType.UtcTimestamp, Offset = 35, Required = false)]
		public DateTime? TransBkdTime {get; set;}
		
		[TagDetails(Tag = 586, Type = TagType.UtcTimestamp, Offset = 36, Required = false)]
		public DateTime? OrigOrdModTime {get; set;}
		
		[TagDetails(Tag = 2766, Type = TagType.Float, Offset = 37, Required = false)]
		public double? OrderPercentOfTotalVolume {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (OrderID is not null) writer.WriteString(37, OrderID);
			if (SecondaryOrderID is not null) writer.WriteString(198, SecondaryOrderID);
			if (ClOrdID is not null) writer.WriteString(11, ClOrdID);
			if (SecondaryClOrdID is not null) writer.WriteString(526, SecondaryClOrdID);
			if (ListID is not null) writer.WriteString(66, ListID);
			if (RefOrderID is not null) writer.WriteString(1080, RefOrderID);
			if (RefOrderIDSource is not null) writer.WriteString(1081, RefOrderIDSource);
			if (RefOrdIDReason is not null) writer.WriteWholeNumber(1431, RefOrdIDReason.Value);
			if (RelatedOrderGrp is not null) ((IFixEncoder)RelatedOrderGrp).Encode(writer);
			if (PreTradeAnonymity is not null) writer.WriteBoolean(1091, PreTradeAnonymity.Value);
			if (OrdType is not null) writer.WriteString(40, OrdType);
			if (Price is not null) writer.WriteNumber(44, Price.Value);
			if (StopPx is not null) writer.WriteNumber(99, StopPx.Value);
			if (ExecInst is not null) writer.WriteString(18, ExecInst);
			if (OrdStatus is not null) writer.WriteString(39, OrdStatus);
			if (OrderQtyData is not null) ((IFixEncoder)OrderQtyData).Encode(writer);
			if (LeavesQty is not null) writer.WriteNumber(151, LeavesQty.Value);
			if (CumQty is not null) writer.WriteNumber(14, CumQty.Value);
			if (TimeInForce is not null) writer.WriteString(59, TimeInForce);
			if (ExpireTime is not null) writer.WriteUtcTimeStamp(126, ExpireTime.Value);
			if (MatchingInstructions is not null) ((IFixEncoder)MatchingInstructions).Encode(writer);
			if (SelfMatchPreventionID is not null) writer.WriteString(2362, SelfMatchPreventionID);
			if (SelfMatchPreventionInstruction is not null) writer.WriteWholeNumber(2964, SelfMatchPreventionInstruction.Value);
			if (ExposureDuration is not null) writer.WriteWholeNumber(1629, ExposureDuration.Value);
			if (ExposureDurationUnit is not null) writer.WriteWholeNumber(1916, ExposureDurationUnit.Value);
			if (DisplayInstruction is not null) ((IFixEncoder)DisplayInstruction).Encode(writer);
			if (OrderCapacity is not null) writer.WriteString(528, OrderCapacity);
			if (OrderRestrictions is not null) writer.WriteString(529, OrderRestrictions);
			if (BookingType is not null) writer.WriteWholeNumber(775, BookingType.Value);
			if (OrigCustOrderCapacity is not null) writer.WriteWholeNumber(1432, OrigCustOrderCapacity.Value);
			if (OrderOrigination is not null) writer.WriteWholeNumber(1724, OrderOrigination.Value);
			if (OrderAttributeGrp is not null) ((IFixEncoder)OrderAttributeGrp).Encode(writer);
			if (ExDestinationType is not null) writer.WriteWholeNumber(2704, ExDestinationType.Value);
			if (OrderInputDevice is not null) writer.WriteString(821, OrderInputDevice);
			if (LotType is not null) writer.WriteString(1093, LotType);
			if (TransBkdTime is not null) writer.WriteUtcTimeStamp(483, TransBkdTime.Value);
			if (OrigOrdModTime is not null) writer.WriteUtcTimeStamp(586, OrigOrdModTime.Value);
			if (OrderPercentOfTotalVolume is not null) writer.WriteNumber(2766, OrderPercentOfTotalVolume.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			OrderID = view.GetString(37);
			SecondaryOrderID = view.GetString(198);
			ClOrdID = view.GetString(11);
			SecondaryClOrdID = view.GetString(526);
			ListID = view.GetString(66);
			RefOrderID = view.GetString(1080);
			RefOrderIDSource = view.GetString(1081);
			RefOrdIDReason = view.GetInt32(1431);
			if (view.GetView("RelatedOrderGrp") is IMessageView viewRelatedOrderGrp)
			{
				RelatedOrderGrp = new();
				((IFixParser)RelatedOrderGrp).Parse(viewRelatedOrderGrp);
			}
			PreTradeAnonymity = view.GetBool(1091);
			OrdType = view.GetString(40);
			Price = view.GetDouble(44);
			StopPx = view.GetDouble(99);
			ExecInst = view.GetString(18);
			OrdStatus = view.GetString(39);
			if (view.GetView("OrderQtyData") is IMessageView viewOrderQtyData)
			{
				OrderQtyData = new();
				((IFixParser)OrderQtyData).Parse(viewOrderQtyData);
			}
			LeavesQty = view.GetDouble(151);
			CumQty = view.GetDouble(14);
			TimeInForce = view.GetString(59);
			ExpireTime = view.GetDateTime(126);
			if (view.GetView("MatchingInstructions") is IMessageView viewMatchingInstructions)
			{
				MatchingInstructions = new();
				((IFixParser)MatchingInstructions).Parse(viewMatchingInstructions);
			}
			SelfMatchPreventionID = view.GetString(2362);
			SelfMatchPreventionInstruction = view.GetInt32(2964);
			ExposureDuration = view.GetInt32(1629);
			ExposureDurationUnit = view.GetInt32(1916);
			if (view.GetView("DisplayInstruction") is IMessageView viewDisplayInstruction)
			{
				DisplayInstruction = new();
				((IFixParser)DisplayInstruction).Parse(viewDisplayInstruction);
			}
			OrderCapacity = view.GetString(528);
			OrderRestrictions = view.GetString(529);
			BookingType = view.GetInt32(775);
			OrigCustOrderCapacity = view.GetInt32(1432);
			OrderOrigination = view.GetInt32(1724);
			if (view.GetView("OrderAttributeGrp") is IMessageView viewOrderAttributeGrp)
			{
				OrderAttributeGrp = new();
				((IFixParser)OrderAttributeGrp).Parse(viewOrderAttributeGrp);
			}
			ExDestinationType = view.GetInt32(2704);
			OrderInputDevice = view.GetString(821);
			LotType = view.GetString(1093);
			TransBkdTime = view.GetDateTime(483);
			OrigOrdModTime = view.GetDateTime(586);
			OrderPercentOfTotalVolume = view.GetDouble(2766);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
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
				case "SecondaryClOrdID":
				{
					value = SecondaryClOrdID;
					break;
				}
				case "ListID":
				{
					value = ListID;
					break;
				}
				case "RefOrderID":
				{
					value = RefOrderID;
					break;
				}
				case "RefOrderIDSource":
				{
					value = RefOrderIDSource;
					break;
				}
				case "RefOrdIDReason":
				{
					value = RefOrdIDReason;
					break;
				}
				case "RelatedOrderGrp":
				{
					value = RelatedOrderGrp;
					break;
				}
				case "PreTradeAnonymity":
				{
					value = PreTradeAnonymity;
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
				case "StopPx":
				{
					value = StopPx;
					break;
				}
				case "ExecInst":
				{
					value = ExecInst;
					break;
				}
				case "OrdStatus":
				{
					value = OrdStatus;
					break;
				}
				case "OrderQtyData":
				{
					value = OrderQtyData;
					break;
				}
				case "LeavesQty":
				{
					value = LeavesQty;
					break;
				}
				case "CumQty":
				{
					value = CumQty;
					break;
				}
				case "TimeInForce":
				{
					value = TimeInForce;
					break;
				}
				case "ExpireTime":
				{
					value = ExpireTime;
					break;
				}
				case "MatchingInstructions":
				{
					value = MatchingInstructions;
					break;
				}
				case "SelfMatchPreventionID":
				{
					value = SelfMatchPreventionID;
					break;
				}
				case "SelfMatchPreventionInstruction":
				{
					value = SelfMatchPreventionInstruction;
					break;
				}
				case "ExposureDuration":
				{
					value = ExposureDuration;
					break;
				}
				case "ExposureDurationUnit":
				{
					value = ExposureDurationUnit;
					break;
				}
				case "DisplayInstruction":
				{
					value = DisplayInstruction;
					break;
				}
				case "OrderCapacity":
				{
					value = OrderCapacity;
					break;
				}
				case "OrderRestrictions":
				{
					value = OrderRestrictions;
					break;
				}
				case "BookingType":
				{
					value = BookingType;
					break;
				}
				case "OrigCustOrderCapacity":
				{
					value = OrigCustOrderCapacity;
					break;
				}
				case "OrderOrigination":
				{
					value = OrderOrigination;
					break;
				}
				case "OrderAttributeGrp":
				{
					value = OrderAttributeGrp;
					break;
				}
				case "ExDestinationType":
				{
					value = ExDestinationType;
					break;
				}
				case "OrderInputDevice":
				{
					value = OrderInputDevice;
					break;
				}
				case "LotType":
				{
					value = LotType;
					break;
				}
				case "TransBkdTime":
				{
					value = TransBkdTime;
					break;
				}
				case "OrigOrdModTime":
				{
					value = OrigOrdModTime;
					break;
				}
				case "OrderPercentOfTotalVolume":
				{
					value = OrderPercentOfTotalVolume;
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
			OrderID = null;
			SecondaryOrderID = null;
			ClOrdID = null;
			SecondaryClOrdID = null;
			ListID = null;
			RefOrderID = null;
			RefOrderIDSource = null;
			RefOrdIDReason = null;
			((IFixReset?)RelatedOrderGrp)?.Reset();
			PreTradeAnonymity = null;
			OrdType = null;
			Price = null;
			StopPx = null;
			ExecInst = null;
			OrdStatus = null;
			((IFixReset?)OrderQtyData)?.Reset();
			LeavesQty = null;
			CumQty = null;
			TimeInForce = null;
			ExpireTime = null;
			((IFixReset?)MatchingInstructions)?.Reset();
			SelfMatchPreventionID = null;
			SelfMatchPreventionInstruction = null;
			ExposureDuration = null;
			ExposureDurationUnit = null;
			((IFixReset?)DisplayInstruction)?.Reset();
			OrderCapacity = null;
			OrderRestrictions = null;
			BookingType = null;
			OrigCustOrderCapacity = null;
			OrderOrigination = null;
			((IFixReset?)OrderAttributeGrp)?.Reset();
			ExDestinationType = null;
			OrderInputDevice = null;
			LotType = null;
			TransBkdTime = null;
			OrigOrdModTime = null;
			OrderPercentOfTotalVolume = null;
		}
	}
}
