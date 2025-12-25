using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class SideCrossOrdModGrp : IFixComponent
	{
		public sealed partial class NoSides : IFixGroup
		{
			[TagDetails(Tag = 54, Type = TagType.String, Offset = 0, Required = true)]
			public string? Side {get; set;}
			
			[TagDetails(Tag = 2102, Type = TagType.Boolean, Offset = 1, Required = false)]
			public bool? ShortMarkingExemptIndicator {get; set;}
			
			[TagDetails(Tag = 41, Type = TagType.String, Offset = 2, Required = false)]
			public string? OrigClOrdID {get; set;}
			
			[TagDetails(Tag = 11, Type = TagType.String, Offset = 3, Required = true)]
			public string? ClOrdID {get; set;}
			
			[TagDetails(Tag = 526, Type = TagType.String, Offset = 4, Required = false)]
			public string? SecondaryClOrdID {get; set;}
			
			[TagDetails(Tag = 583, Type = TagType.String, Offset = 5, Required = false)]
			public string? ClOrdLinkID {get; set;}
			
			[TagDetails(Tag = 586, Type = TagType.UtcTimestamp, Offset = 6, Required = false)]
			public DateTime? OrigOrdModTime {get; set;}
			
			[Component(Offset = 7, Required = false)]
			public Parties? Parties {get; set;}
			
			[Component(Offset = 8, Required = false)]
			public SideCrossLegGrp? SideCrossLegGrp {get; set;}
			
			[TagDetails(Tag = 1690, Type = TagType.Int, Offset = 9, Required = false)]
			public int? SideShortSaleExemptionReason {get; set;}
			
			[TagDetails(Tag = 229, Type = TagType.LocalDate, Offset = 10, Required = false)]
			public DateOnly? TradeOriginationDate {get; set;}
			
			[TagDetails(Tag = 75, Type = TagType.LocalDate, Offset = 11, Required = false)]
			public DateOnly? TradeDate {get; set;}
			
			[TagDetails(Tag = 1, Type = TagType.String, Offset = 12, Required = false)]
			public string? Account {get; set;}
			
			[TagDetails(Tag = 660, Type = TagType.Int, Offset = 13, Required = false)]
			public int? AcctIDSource {get; set;}
			
			[TagDetails(Tag = 581, Type = TagType.Int, Offset = 14, Required = false)]
			public int? AccountType {get; set;}
			
			[TagDetails(Tag = 589, Type = TagType.String, Offset = 15, Required = false)]
			public string? DayBookingInst {get; set;}
			
			[TagDetails(Tag = 590, Type = TagType.String, Offset = 16, Required = false)]
			public string? BookingUnit {get; set;}
			
			[TagDetails(Tag = 591, Type = TagType.String, Offset = 17, Required = false)]
			public string? PreallocMethod {get; set;}
			
			[TagDetails(Tag = 70, Type = TagType.String, Offset = 18, Required = false)]
			public string? AllocID {get; set;}
			
			[Component(Offset = 19, Required = false)]
			public PreAllocGrp? PreAllocGrp {get; set;}
			
			[TagDetails(Tag = 854, Type = TagType.Int, Offset = 20, Required = false)]
			public int? QtyType {get; set;}
			
			[Component(Offset = 21, Required = true)]
			public OrderQtyData? OrderQtyData {get; set;}
			
			[Component(Offset = 22, Required = false)]
			public CommissionData? CommissionData {get; set;}
			
			[Component(Offset = 23, Required = false)]
			public CommissionDataGrp? CommissionDataGrp {get; set;}
			
			[TagDetails(Tag = 528, Type = TagType.String, Offset = 24, Required = false)]
			public string? OrderCapacity {get; set;}
			
			[TagDetails(Tag = 529, Type = TagType.String, Offset = 25, Required = false)]
			public string? OrderRestrictions {get; set;}
			
			[TagDetails(Tag = 1724, Type = TagType.Int, Offset = 26, Required = false)]
			public int? OrderOrigination {get; set;}
			
			[TagDetails(Tag = 1725, Type = TagType.String, Offset = 27, Required = false)]
			public string? OriginatingDeptID {get; set;}
			
			[TagDetails(Tag = 1726, Type = TagType.String, Offset = 28, Required = false)]
			public string? ReceivingDeptID {get; set;}
			
			[TagDetails(Tag = 2883, Type = TagType.Int, Offset = 29, Required = false)]
			public int? RoutingArrangmentIndicator {get; set;}
			
			[TagDetails(Tag = 1091, Type = TagType.Boolean, Offset = 30, Required = false)]
			public bool? PreTradeAnonymity {get; set;}
			
			[TagDetails(Tag = 582, Type = TagType.Int, Offset = 31, Required = false)]
			public int? CustOrderCapacity {get; set;}
			
			[TagDetails(Tag = 121, Type = TagType.Boolean, Offset = 32, Required = false)]
			public bool? ForexReq {get; set;}
			
			[TagDetails(Tag = 120, Type = TagType.String, Offset = 33, Required = false)]
			public string? SettlCurrency {get; set;}
			
			[TagDetails(Tag = 2899, Type = TagType.String, Offset = 34, Required = false)]
			public string? SettlCurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 775, Type = TagType.Int, Offset = 35, Required = false)]
			public int? BookingType {get; set;}
			
			[TagDetails(Tag = 58, Type = TagType.String, Offset = 36, Required = false)]
			public string? Text {get; set;}
			
			[TagDetails(Tag = 354, Type = TagType.Length, Offset = 37, Required = false)]
			public int? EncodedTextLen {get; set;}
			
			[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 38, Required = false)]
			public byte[]? EncodedText {get; set;}
			
			[TagDetails(Tag = 1816, Type = TagType.Int, Offset = 39, Required = false)]
			public int? ClearingAccountType {get; set;}
			
			[TagDetails(Tag = 77, Type = TagType.String, Offset = 40, Required = false)]
			public string? PositionEffect {get; set;}
			
			[TagDetails(Tag = 203, Type = TagType.Int, Offset = 41, Required = false)]
			public int? CoveredOrUncovered {get; set;}
			
			[TagDetails(Tag = 544, Type = TagType.String, Offset = 42, Required = false)]
			public string? CashMargin {get; set;}
			
			[TagDetails(Tag = 635, Type = TagType.String, Offset = 43, Required = false)]
			public string? ClearingFeeIndicator {get; set;}
			
			[TagDetails(Tag = 377, Type = TagType.Boolean, Offset = 44, Required = false)]
			public bool? SolicitedFlag {get; set;}
			
			[TagDetails(Tag = 659, Type = TagType.String, Offset = 45, Required = false)]
			public string? SideComplianceID {get; set;}
			
			[TagDetails(Tag = 962, Type = TagType.UtcTimestamp, Offset = 46, Required = false)]
			public DateTime? SideTimeInForce {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (Side is not null) writer.WriteString(54, Side);
				if (ShortMarkingExemptIndicator is not null) writer.WriteBoolean(2102, ShortMarkingExemptIndicator.Value);
				if (OrigClOrdID is not null) writer.WriteString(41, OrigClOrdID);
				if (ClOrdID is not null) writer.WriteString(11, ClOrdID);
				if (SecondaryClOrdID is not null) writer.WriteString(526, SecondaryClOrdID);
				if (ClOrdLinkID is not null) writer.WriteString(583, ClOrdLinkID);
				if (OrigOrdModTime is not null) writer.WriteUtcTimeStamp(586, OrigOrdModTime.Value);
				if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
				if (SideCrossLegGrp is not null) ((IFixEncoder)SideCrossLegGrp).Encode(writer);
				if (SideShortSaleExemptionReason is not null) writer.WriteWholeNumber(1690, SideShortSaleExemptionReason.Value);
				if (TradeOriginationDate is not null) writer.WriteLocalDateOnly(229, TradeOriginationDate.Value);
				if (TradeDate is not null) writer.WriteLocalDateOnly(75, TradeDate.Value);
				if (Account is not null) writer.WriteString(1, Account);
				if (AcctIDSource is not null) writer.WriteWholeNumber(660, AcctIDSource.Value);
				if (AccountType is not null) writer.WriteWholeNumber(581, AccountType.Value);
				if (DayBookingInst is not null) writer.WriteString(589, DayBookingInst);
				if (BookingUnit is not null) writer.WriteString(590, BookingUnit);
				if (PreallocMethod is not null) writer.WriteString(591, PreallocMethod);
				if (AllocID is not null) writer.WriteString(70, AllocID);
				if (PreAllocGrp is not null) ((IFixEncoder)PreAllocGrp).Encode(writer);
				if (QtyType is not null) writer.WriteWholeNumber(854, QtyType.Value);
				if (OrderQtyData is not null) ((IFixEncoder)OrderQtyData).Encode(writer);
				if (CommissionData is not null) ((IFixEncoder)CommissionData).Encode(writer);
				if (CommissionDataGrp is not null) ((IFixEncoder)CommissionDataGrp).Encode(writer);
				if (OrderCapacity is not null) writer.WriteString(528, OrderCapacity);
				if (OrderRestrictions is not null) writer.WriteString(529, OrderRestrictions);
				if (OrderOrigination is not null) writer.WriteWholeNumber(1724, OrderOrigination.Value);
				if (OriginatingDeptID is not null) writer.WriteString(1725, OriginatingDeptID);
				if (ReceivingDeptID is not null) writer.WriteString(1726, ReceivingDeptID);
				if (RoutingArrangmentIndicator is not null) writer.WriteWholeNumber(2883, RoutingArrangmentIndicator.Value);
				if (PreTradeAnonymity is not null) writer.WriteBoolean(1091, PreTradeAnonymity.Value);
				if (CustOrderCapacity is not null) writer.WriteWholeNumber(582, CustOrderCapacity.Value);
				if (ForexReq is not null) writer.WriteBoolean(121, ForexReq.Value);
				if (SettlCurrency is not null) writer.WriteString(120, SettlCurrency);
				if (SettlCurrencyCodeSource is not null) writer.WriteString(2899, SettlCurrencyCodeSource);
				if (BookingType is not null) writer.WriteWholeNumber(775, BookingType.Value);
				if (Text is not null) writer.WriteString(58, Text);
				if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
				if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
				if (ClearingAccountType is not null) writer.WriteWholeNumber(1816, ClearingAccountType.Value);
				if (PositionEffect is not null) writer.WriteString(77, PositionEffect);
				if (CoveredOrUncovered is not null) writer.WriteWholeNumber(203, CoveredOrUncovered.Value);
				if (CashMargin is not null) writer.WriteString(544, CashMargin);
				if (ClearingFeeIndicator is not null) writer.WriteString(635, ClearingFeeIndicator);
				if (SolicitedFlag is not null) writer.WriteBoolean(377, SolicitedFlag.Value);
				if (SideComplianceID is not null) writer.WriteString(659, SideComplianceID);
				if (SideTimeInForce is not null) writer.WriteUtcTimeStamp(962, SideTimeInForce.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				Side = view.GetString(54);
				ShortMarkingExemptIndicator = view.GetBool(2102);
				OrigClOrdID = view.GetString(41);
				ClOrdID = view.GetString(11);
				SecondaryClOrdID = view.GetString(526);
				ClOrdLinkID = view.GetString(583);
				OrigOrdModTime = view.GetDateTime(586);
				if (view.GetView("Parties") is IMessageView viewParties)
				{
					Parties = new();
					((IFixParser)Parties).Parse(viewParties);
				}
				if (view.GetView("SideCrossLegGrp") is IMessageView viewSideCrossLegGrp)
				{
					SideCrossLegGrp = new();
					((IFixParser)SideCrossLegGrp).Parse(viewSideCrossLegGrp);
				}
				SideShortSaleExemptionReason = view.GetInt32(1690);
				TradeOriginationDate = view.GetDateOnly(229);
				TradeDate = view.GetDateOnly(75);
				Account = view.GetString(1);
				AcctIDSource = view.GetInt32(660);
				AccountType = view.GetInt32(581);
				DayBookingInst = view.GetString(589);
				BookingUnit = view.GetString(590);
				PreallocMethod = view.GetString(591);
				AllocID = view.GetString(70);
				if (view.GetView("PreAllocGrp") is IMessageView viewPreAllocGrp)
				{
					PreAllocGrp = new();
					((IFixParser)PreAllocGrp).Parse(viewPreAllocGrp);
				}
				QtyType = view.GetInt32(854);
				if (view.GetView("OrderQtyData") is IMessageView viewOrderQtyData)
				{
					OrderQtyData = new();
					((IFixParser)OrderQtyData).Parse(viewOrderQtyData);
				}
				if (view.GetView("CommissionData") is IMessageView viewCommissionData)
				{
					CommissionData = new();
					((IFixParser)CommissionData).Parse(viewCommissionData);
				}
				if (view.GetView("CommissionDataGrp") is IMessageView viewCommissionDataGrp)
				{
					CommissionDataGrp = new();
					((IFixParser)CommissionDataGrp).Parse(viewCommissionDataGrp);
				}
				OrderCapacity = view.GetString(528);
				OrderRestrictions = view.GetString(529);
				OrderOrigination = view.GetInt32(1724);
				OriginatingDeptID = view.GetString(1725);
				ReceivingDeptID = view.GetString(1726);
				RoutingArrangmentIndicator = view.GetInt32(2883);
				PreTradeAnonymity = view.GetBool(1091);
				CustOrderCapacity = view.GetInt32(582);
				ForexReq = view.GetBool(121);
				SettlCurrency = view.GetString(120);
				SettlCurrencyCodeSource = view.GetString(2899);
				BookingType = view.GetInt32(775);
				Text = view.GetString(58);
				EncodedTextLen = view.GetInt32(354);
				EncodedText = view.GetByteArray(355);
				ClearingAccountType = view.GetInt32(1816);
				PositionEffect = view.GetString(77);
				CoveredOrUncovered = view.GetInt32(203);
				CashMargin = view.GetString(544);
				ClearingFeeIndicator = view.GetString(635);
				SolicitedFlag = view.GetBool(377);
				SideComplianceID = view.GetString(659);
				SideTimeInForce = view.GetDateTime(962);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "Side":
					{
						value = Side;
						break;
					}
					case "ShortMarkingExemptIndicator":
					{
						value = ShortMarkingExemptIndicator;
						break;
					}
					case "OrigClOrdID":
					{
						value = OrigClOrdID;
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
					case "ClOrdLinkID":
					{
						value = ClOrdLinkID;
						break;
					}
					case "OrigOrdModTime":
					{
						value = OrigOrdModTime;
						break;
					}
					case "Parties":
					{
						value = Parties;
						break;
					}
					case "SideCrossLegGrp":
					{
						value = SideCrossLegGrp;
						break;
					}
					case "SideShortSaleExemptionReason":
					{
						value = SideShortSaleExemptionReason;
						break;
					}
					case "TradeOriginationDate":
					{
						value = TradeOriginationDate;
						break;
					}
					case "TradeDate":
					{
						value = TradeDate;
						break;
					}
					case "Account":
					{
						value = Account;
						break;
					}
					case "AcctIDSource":
					{
						value = AcctIDSource;
						break;
					}
					case "AccountType":
					{
						value = AccountType;
						break;
					}
					case "DayBookingInst":
					{
						value = DayBookingInst;
						break;
					}
					case "BookingUnit":
					{
						value = BookingUnit;
						break;
					}
					case "PreallocMethod":
					{
						value = PreallocMethod;
						break;
					}
					case "AllocID":
					{
						value = AllocID;
						break;
					}
					case "PreAllocGrp":
					{
						value = PreAllocGrp;
						break;
					}
					case "QtyType":
					{
						value = QtyType;
						break;
					}
					case "OrderQtyData":
					{
						value = OrderQtyData;
						break;
					}
					case "CommissionData":
					{
						value = CommissionData;
						break;
					}
					case "CommissionDataGrp":
					{
						value = CommissionDataGrp;
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
					case "OrderOrigination":
					{
						value = OrderOrigination;
						break;
					}
					case "OriginatingDeptID":
					{
						value = OriginatingDeptID;
						break;
					}
					case "ReceivingDeptID":
					{
						value = ReceivingDeptID;
						break;
					}
					case "RoutingArrangmentIndicator":
					{
						value = RoutingArrangmentIndicator;
						break;
					}
					case "PreTradeAnonymity":
					{
						value = PreTradeAnonymity;
						break;
					}
					case "CustOrderCapacity":
					{
						value = CustOrderCapacity;
						break;
					}
					case "ForexReq":
					{
						value = ForexReq;
						break;
					}
					case "SettlCurrency":
					{
						value = SettlCurrency;
						break;
					}
					case "SettlCurrencyCodeSource":
					{
						value = SettlCurrencyCodeSource;
						break;
					}
					case "BookingType":
					{
						value = BookingType;
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
					case "ClearingAccountType":
					{
						value = ClearingAccountType;
						break;
					}
					case "PositionEffect":
					{
						value = PositionEffect;
						break;
					}
					case "CoveredOrUncovered":
					{
						value = CoveredOrUncovered;
						break;
					}
					case "CashMargin":
					{
						value = CashMargin;
						break;
					}
					case "ClearingFeeIndicator":
					{
						value = ClearingFeeIndicator;
						break;
					}
					case "SolicitedFlag":
					{
						value = SolicitedFlag;
						break;
					}
					case "SideComplianceID":
					{
						value = SideComplianceID;
						break;
					}
					case "SideTimeInForce":
					{
						value = SideTimeInForce;
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
				Side = null;
				ShortMarkingExemptIndicator = null;
				OrigClOrdID = null;
				ClOrdID = null;
				SecondaryClOrdID = null;
				ClOrdLinkID = null;
				OrigOrdModTime = null;
				((IFixReset?)Parties)?.Reset();
				((IFixReset?)SideCrossLegGrp)?.Reset();
				SideShortSaleExemptionReason = null;
				TradeOriginationDate = null;
				TradeDate = null;
				Account = null;
				AcctIDSource = null;
				AccountType = null;
				DayBookingInst = null;
				BookingUnit = null;
				PreallocMethod = null;
				AllocID = null;
				((IFixReset?)PreAllocGrp)?.Reset();
				QtyType = null;
				((IFixReset?)OrderQtyData)?.Reset();
				((IFixReset?)CommissionData)?.Reset();
				((IFixReset?)CommissionDataGrp)?.Reset();
				OrderCapacity = null;
				OrderRestrictions = null;
				OrderOrigination = null;
				OriginatingDeptID = null;
				ReceivingDeptID = null;
				RoutingArrangmentIndicator = null;
				PreTradeAnonymity = null;
				CustOrderCapacity = null;
				ForexReq = null;
				SettlCurrency = null;
				SettlCurrencyCodeSource = null;
				BookingType = null;
				Text = null;
				EncodedTextLen = null;
				EncodedText = null;
				ClearingAccountType = null;
				PositionEffect = null;
				CoveredOrUncovered = null;
				CashMargin = null;
				ClearingFeeIndicator = null;
				SolicitedFlag = null;
				SideComplianceID = null;
				SideTimeInForce = null;
			}
		}
		[Group(NoOfTag = 552, Offset = 0, Required = false)]
		public NoSides[]? Sides {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Sides is not null && Sides.Length != 0)
			{
				writer.WriteWholeNumber(552, Sides.Length);
				for (int i = 0; i < Sides.Length; i++)
				{
					((IFixEncoder)Sides[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoSides") is IMessageView viewNoSides)
			{
				var count = viewNoSides.GroupCount();
				Sides = new NoSides[count];
				for (int i = 0; i < count; i++)
				{
					Sides[i] = new();
					((IFixParser)Sides[i]).Parse(viewNoSides.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoSides":
				{
					value = Sides;
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
			Sides = null;
		}
	}
}
