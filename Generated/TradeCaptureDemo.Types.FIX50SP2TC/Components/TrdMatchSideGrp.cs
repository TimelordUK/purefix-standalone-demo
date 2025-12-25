using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class TrdMatchSideGrp : IFixComponent
	{
		public sealed partial class NoTrdMatchSides : IFixGroup
		{
			[TagDetails(Tag = 54, Type = TagType.String, Offset = 0, Required = false)]
			public string? Side {get; set;}
			
			[TagDetails(Tag = 1427, Type = TagType.String, Offset = 1, Required = false)]
			public string? SideExecID {get; set;}
			
			[TagDetails(Tag = 1900, Type = TagType.String, Offset = 2, Required = false)]
			public string? SideExecRefID {get; set;}
			
			[TagDetails(Tag = 1506, Type = TagType.String, Offset = 3, Required = false)]
			public string? SideTradeID {get; set;}
			
			[TagDetails(Tag = 1005, Type = TagType.String, Offset = 4, Required = false)]
			public string? SideTradeReportID {get; set;}
			
			[TagDetails(Tag = 1428, Type = TagType.Int, Offset = 5, Required = false)]
			public int? OrderDelay {get; set;}
			
			[TagDetails(Tag = 1429, Type = TagType.Int, Offset = 6, Required = false)]
			public int? OrderDelayUnit {get; set;}
			
			[TagDetails(Tag = 1009, Type = TagType.Float, Offset = 7, Required = false)]
			public double? SideLastQty {get; set;}
			
			[TagDetails(Tag = 1597, Type = TagType.Float, Offset = 8, Required = false)]
			public double? SideClearingTradePrice {get; set;}
			
			[TagDetails(Tag = 1599, Type = TagType.Float, Offset = 9, Required = false)]
			public double? SidePriceDifferential {get; set;}
			
			[TagDetails(Tag = 1598, Type = TagType.Int, Offset = 10, Required = false)]
			public int? SideClearingTradePriceType {get; set;}
			
			[TagDetails(Tag = 1006, Type = TagType.String, Offset = 11, Required = false)]
			public string? SideFillStationCd {get; set;}
			
			[TagDetails(Tag = 1007, Type = TagType.String, Offset = 12, Required = false)]
			public string? SideReasonCd {get; set;}
			
			[TagDetails(Tag = 1008, Type = TagType.Int, Offset = 13, Required = false)]
			public int? SideTrdSubType {get; set;}
			
			[TagDetails(Tag = 430, Type = TagType.Int, Offset = 14, Required = false)]
			public int? NetGrossInd {get; set;}
			
			[TagDetails(Tag = 1154, Type = TagType.String, Offset = 15, Required = false)]
			public string? SideCurrency {get; set;}
			
			[TagDetails(Tag = 2901, Type = TagType.String, Offset = 16, Required = false)]
			public string? SideCurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 1155, Type = TagType.String, Offset = 17, Required = false)]
			public string? SideSettlCurrency {get; set;}
			
			[TagDetails(Tag = 2902, Type = TagType.String, Offset = 18, Required = false)]
			public string? SideSettlCurrencyCodeSource {get; set;}
			
			[Component(Offset = 19, Required = false)]
			public Parties? Parties {get; set;}
			
			[TagDetails(Tag = 578, Type = TagType.String, Offset = 20, Required = false)]
			public string? TradeInputSource {get; set;}
			
			[TagDetails(Tag = 579, Type = TagType.String, Offset = 21, Required = false)]
			public string? TradeInputDevice {get; set;}
			
			[TagDetails(Tag = 376, Type = TagType.String, Offset = 22, Required = false)]
			public string? ComplianceID {get; set;}
			
			[TagDetails(Tag = 2404, Type = TagType.String, Offset = 23, Required = false)]
			public string? ComplianceText {get; set;}
			
			[TagDetails(Tag = 2351, Type = TagType.Length, Offset = 24, Required = false)]
			public int? EncodedComplianceTextLen {get; set;}
			
			[TagDetails(Tag = 2352, Type = TagType.RawData, Offset = 25, Required = false)]
			public byte[]? EncodedComplianceText {get; set;}
			
			[TagDetails(Tag = 377, Type = TagType.Boolean, Offset = 26, Required = false)]
			public bool? SolicitedFlag {get; set;}
			
			[TagDetails(Tag = 582, Type = TagType.Int, Offset = 27, Required = false)]
			public int? CustOrderCapacity {get; set;}
			
			[TagDetails(Tag = 943, Type = TagType.String, Offset = 28, Required = false)]
			public string? TimeBracket {get; set;}
			
			[TagDetails(Tag = 77, Type = TagType.String, Offset = 29, Required = false)]
			public string? PositionEffect {get; set;}
			
			[TagDetails(Tag = 825, Type = TagType.String, Offset = 30, Required = false)]
			public string? ExchangeRule {get; set;}
			
			[TagDetails(Tag = 826, Type = TagType.Int, Offset = 31, Required = false)]
			public int? TradeAllocIndicator {get; set;}
			
			[TagDetails(Tag = 591, Type = TagType.String, Offset = 32, Required = false)]
			public string? PreallocMethod {get; set;}
			
			[TagDetails(Tag = 70, Type = TagType.String, Offset = 33, Required = false)]
			public string? AllocID {get; set;}
			
			[Component(Offset = 34, Required = false)]
			public TrdAllocGrp? TrdAllocGrp {get; set;}
			
			[TagDetails(Tag = 1072, Type = TagType.Float, Offset = 35, Required = false)]
			public double? SideGrossTradeAmt {get; set;}
			
			[TagDetails(Tag = 1057, Type = TagType.Boolean, Offset = 36, Required = false)]
			public bool? AggressorIndicator {get; set;}
			
			[TagDetails(Tag = 1139, Type = TagType.String, Offset = 37, Required = false)]
			public string? ExchangeSpecialInstructions {get; set;}
			
			[TagDetails(Tag = 1690, Type = TagType.Int, Offset = 38, Required = false)]
			public int? SideShortSaleExemptionReason {get; set;}
			
			[TagDetails(Tag = 1115, Type = TagType.String, Offset = 39, Required = false)]
			public string? OrderCategory {get; set;}
			
			[TagDetails(Tag = 819, Type = TagType.Int, Offset = 40, Required = false)]
			public int? AvgPxIndicator {get; set;}
			
			[TagDetails(Tag = 1731, Type = TagType.String, Offset = 41, Required = false)]
			public string? AvgPxGroupID {get; set;}
			
			[TagDetails(Tag = 1898, Type = TagType.String, Offset = 42, Required = false)]
			public string? SideMarketSegmentID {get; set;}
			
			[TagDetails(Tag = 1899, Type = TagType.String, Offset = 43, Required = false)]
			public string? SideVenueType {get; set;}
			
			[TagDetails(Tag = 635, Type = TagType.String, Offset = 44, Required = false)]
			public string? ClearingFeeIndicator {get; set;}
			
			[Component(Offset = 45, Required = false)]
			public TradeReportOrderDetail? TradeReportOrderDetail {get; set;}
			
			[Component(Offset = 46, Required = false)]
			public TrdInstrmtLegExecGrp? TrdInstrmtLegExecGrp {get; set;}
			
			[TagDetails(Tag = 1031, Type = TagType.String, Offset = 47, Required = false)]
			public string? CustOrderHandlingInst {get; set;}
			
			[TagDetails(Tag = 1032, Type = TagType.Int, Offset = 48, Required = false)]
			public int? OrderHandlingInstSource {get; set;}
			
			[TagDetails(Tag = 58, Type = TagType.String, Offset = 49, Required = false)]
			public string? Text {get; set;}
			
			[TagDetails(Tag = 354, Type = TagType.Length, Offset = 50, Required = false)]
			public int? EncodedTextLen {get; set;}
			
			[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 51, Required = false)]
			public byte[]? EncodedText {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (Side is not null) writer.WriteString(54, Side);
				if (SideExecID is not null) writer.WriteString(1427, SideExecID);
				if (SideExecRefID is not null) writer.WriteString(1900, SideExecRefID);
				if (SideTradeID is not null) writer.WriteString(1506, SideTradeID);
				if (SideTradeReportID is not null) writer.WriteString(1005, SideTradeReportID);
				if (OrderDelay is not null) writer.WriteWholeNumber(1428, OrderDelay.Value);
				if (OrderDelayUnit is not null) writer.WriteWholeNumber(1429, OrderDelayUnit.Value);
				if (SideLastQty is not null) writer.WriteNumber(1009, SideLastQty.Value);
				if (SideClearingTradePrice is not null) writer.WriteNumber(1597, SideClearingTradePrice.Value);
				if (SidePriceDifferential is not null) writer.WriteNumber(1599, SidePriceDifferential.Value);
				if (SideClearingTradePriceType is not null) writer.WriteWholeNumber(1598, SideClearingTradePriceType.Value);
				if (SideFillStationCd is not null) writer.WriteString(1006, SideFillStationCd);
				if (SideReasonCd is not null) writer.WriteString(1007, SideReasonCd);
				if (SideTrdSubType is not null) writer.WriteWholeNumber(1008, SideTrdSubType.Value);
				if (NetGrossInd is not null) writer.WriteWholeNumber(430, NetGrossInd.Value);
				if (SideCurrency is not null) writer.WriteString(1154, SideCurrency);
				if (SideCurrencyCodeSource is not null) writer.WriteString(2901, SideCurrencyCodeSource);
				if (SideSettlCurrency is not null) writer.WriteString(1155, SideSettlCurrency);
				if (SideSettlCurrencyCodeSource is not null) writer.WriteString(2902, SideSettlCurrencyCodeSource);
				if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
				if (TradeInputSource is not null) writer.WriteString(578, TradeInputSource);
				if (TradeInputDevice is not null) writer.WriteString(579, TradeInputDevice);
				if (ComplianceID is not null) writer.WriteString(376, ComplianceID);
				if (ComplianceText is not null) writer.WriteString(2404, ComplianceText);
				if (EncodedComplianceTextLen is not null) writer.WriteWholeNumber(2351, EncodedComplianceTextLen.Value);
				if (EncodedComplianceText is not null) writer.WriteBuffer(2352, EncodedComplianceText);
				if (SolicitedFlag is not null) writer.WriteBoolean(377, SolicitedFlag.Value);
				if (CustOrderCapacity is not null) writer.WriteWholeNumber(582, CustOrderCapacity.Value);
				if (TimeBracket is not null) writer.WriteString(943, TimeBracket);
				if (PositionEffect is not null) writer.WriteString(77, PositionEffect);
				if (ExchangeRule is not null) writer.WriteString(825, ExchangeRule);
				if (TradeAllocIndicator is not null) writer.WriteWholeNumber(826, TradeAllocIndicator.Value);
				if (PreallocMethod is not null) writer.WriteString(591, PreallocMethod);
				if (AllocID is not null) writer.WriteString(70, AllocID);
				if (TrdAllocGrp is not null) ((IFixEncoder)TrdAllocGrp).Encode(writer);
				if (SideGrossTradeAmt is not null) writer.WriteNumber(1072, SideGrossTradeAmt.Value);
				if (AggressorIndicator is not null) writer.WriteBoolean(1057, AggressorIndicator.Value);
				if (ExchangeSpecialInstructions is not null) writer.WriteString(1139, ExchangeSpecialInstructions);
				if (SideShortSaleExemptionReason is not null) writer.WriteWholeNumber(1690, SideShortSaleExemptionReason.Value);
				if (OrderCategory is not null) writer.WriteString(1115, OrderCategory);
				if (AvgPxIndicator is not null) writer.WriteWholeNumber(819, AvgPxIndicator.Value);
				if (AvgPxGroupID is not null) writer.WriteString(1731, AvgPxGroupID);
				if (SideMarketSegmentID is not null) writer.WriteString(1898, SideMarketSegmentID);
				if (SideVenueType is not null) writer.WriteString(1899, SideVenueType);
				if (ClearingFeeIndicator is not null) writer.WriteString(635, ClearingFeeIndicator);
				if (TradeReportOrderDetail is not null) ((IFixEncoder)TradeReportOrderDetail).Encode(writer);
				if (TrdInstrmtLegExecGrp is not null) ((IFixEncoder)TrdInstrmtLegExecGrp).Encode(writer);
				if (CustOrderHandlingInst is not null) writer.WriteString(1031, CustOrderHandlingInst);
				if (OrderHandlingInstSource is not null) writer.WriteWholeNumber(1032, OrderHandlingInstSource.Value);
				if (Text is not null) writer.WriteString(58, Text);
				if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
				if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				Side = view.GetString(54);
				SideExecID = view.GetString(1427);
				SideExecRefID = view.GetString(1900);
				SideTradeID = view.GetString(1506);
				SideTradeReportID = view.GetString(1005);
				OrderDelay = view.GetInt32(1428);
				OrderDelayUnit = view.GetInt32(1429);
				SideLastQty = view.GetDouble(1009);
				SideClearingTradePrice = view.GetDouble(1597);
				SidePriceDifferential = view.GetDouble(1599);
				SideClearingTradePriceType = view.GetInt32(1598);
				SideFillStationCd = view.GetString(1006);
				SideReasonCd = view.GetString(1007);
				SideTrdSubType = view.GetInt32(1008);
				NetGrossInd = view.GetInt32(430);
				SideCurrency = view.GetString(1154);
				SideCurrencyCodeSource = view.GetString(2901);
				SideSettlCurrency = view.GetString(1155);
				SideSettlCurrencyCodeSource = view.GetString(2902);
				if (view.GetView("Parties") is IMessageView viewParties)
				{
					Parties = new();
					((IFixParser)Parties).Parse(viewParties);
				}
				TradeInputSource = view.GetString(578);
				TradeInputDevice = view.GetString(579);
				ComplianceID = view.GetString(376);
				ComplianceText = view.GetString(2404);
				EncodedComplianceTextLen = view.GetInt32(2351);
				EncodedComplianceText = view.GetByteArray(2352);
				SolicitedFlag = view.GetBool(377);
				CustOrderCapacity = view.GetInt32(582);
				TimeBracket = view.GetString(943);
				PositionEffect = view.GetString(77);
				ExchangeRule = view.GetString(825);
				TradeAllocIndicator = view.GetInt32(826);
				PreallocMethod = view.GetString(591);
				AllocID = view.GetString(70);
				if (view.GetView("TrdAllocGrp") is IMessageView viewTrdAllocGrp)
				{
					TrdAllocGrp = new();
					((IFixParser)TrdAllocGrp).Parse(viewTrdAllocGrp);
				}
				SideGrossTradeAmt = view.GetDouble(1072);
				AggressorIndicator = view.GetBool(1057);
				ExchangeSpecialInstructions = view.GetString(1139);
				SideShortSaleExemptionReason = view.GetInt32(1690);
				OrderCategory = view.GetString(1115);
				AvgPxIndicator = view.GetInt32(819);
				AvgPxGroupID = view.GetString(1731);
				SideMarketSegmentID = view.GetString(1898);
				SideVenueType = view.GetString(1899);
				ClearingFeeIndicator = view.GetString(635);
				if (view.GetView("TradeReportOrderDetail") is IMessageView viewTradeReportOrderDetail)
				{
					TradeReportOrderDetail = new();
					((IFixParser)TradeReportOrderDetail).Parse(viewTradeReportOrderDetail);
				}
				if (view.GetView("TrdInstrmtLegExecGrp") is IMessageView viewTrdInstrmtLegExecGrp)
				{
					TrdInstrmtLegExecGrp = new();
					((IFixParser)TrdInstrmtLegExecGrp).Parse(viewTrdInstrmtLegExecGrp);
				}
				CustOrderHandlingInst = view.GetString(1031);
				OrderHandlingInstSource = view.GetInt32(1032);
				Text = view.GetString(58);
				EncodedTextLen = view.GetInt32(354);
				EncodedText = view.GetByteArray(355);
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
					case "SideExecID":
					{
						value = SideExecID;
						break;
					}
					case "SideExecRefID":
					{
						value = SideExecRefID;
						break;
					}
					case "SideTradeID":
					{
						value = SideTradeID;
						break;
					}
					case "SideTradeReportID":
					{
						value = SideTradeReportID;
						break;
					}
					case "OrderDelay":
					{
						value = OrderDelay;
						break;
					}
					case "OrderDelayUnit":
					{
						value = OrderDelayUnit;
						break;
					}
					case "SideLastQty":
					{
						value = SideLastQty;
						break;
					}
					case "SideClearingTradePrice":
					{
						value = SideClearingTradePrice;
						break;
					}
					case "SidePriceDifferential":
					{
						value = SidePriceDifferential;
						break;
					}
					case "SideClearingTradePriceType":
					{
						value = SideClearingTradePriceType;
						break;
					}
					case "SideFillStationCd":
					{
						value = SideFillStationCd;
						break;
					}
					case "SideReasonCd":
					{
						value = SideReasonCd;
						break;
					}
					case "SideTrdSubType":
					{
						value = SideTrdSubType;
						break;
					}
					case "NetGrossInd":
					{
						value = NetGrossInd;
						break;
					}
					case "SideCurrency":
					{
						value = SideCurrency;
						break;
					}
					case "SideCurrencyCodeSource":
					{
						value = SideCurrencyCodeSource;
						break;
					}
					case "SideSettlCurrency":
					{
						value = SideSettlCurrency;
						break;
					}
					case "SideSettlCurrencyCodeSource":
					{
						value = SideSettlCurrencyCodeSource;
						break;
					}
					case "Parties":
					{
						value = Parties;
						break;
					}
					case "TradeInputSource":
					{
						value = TradeInputSource;
						break;
					}
					case "TradeInputDevice":
					{
						value = TradeInputDevice;
						break;
					}
					case "ComplianceID":
					{
						value = ComplianceID;
						break;
					}
					case "ComplianceText":
					{
						value = ComplianceText;
						break;
					}
					case "EncodedComplianceTextLen":
					{
						value = EncodedComplianceTextLen;
						break;
					}
					case "EncodedComplianceText":
					{
						value = EncodedComplianceText;
						break;
					}
					case "SolicitedFlag":
					{
						value = SolicitedFlag;
						break;
					}
					case "CustOrderCapacity":
					{
						value = CustOrderCapacity;
						break;
					}
					case "TimeBracket":
					{
						value = TimeBracket;
						break;
					}
					case "PositionEffect":
					{
						value = PositionEffect;
						break;
					}
					case "ExchangeRule":
					{
						value = ExchangeRule;
						break;
					}
					case "TradeAllocIndicator":
					{
						value = TradeAllocIndicator;
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
					case "TrdAllocGrp":
					{
						value = TrdAllocGrp;
						break;
					}
					case "SideGrossTradeAmt":
					{
						value = SideGrossTradeAmt;
						break;
					}
					case "AggressorIndicator":
					{
						value = AggressorIndicator;
						break;
					}
					case "ExchangeSpecialInstructions":
					{
						value = ExchangeSpecialInstructions;
						break;
					}
					case "SideShortSaleExemptionReason":
					{
						value = SideShortSaleExemptionReason;
						break;
					}
					case "OrderCategory":
					{
						value = OrderCategory;
						break;
					}
					case "AvgPxIndicator":
					{
						value = AvgPxIndicator;
						break;
					}
					case "AvgPxGroupID":
					{
						value = AvgPxGroupID;
						break;
					}
					case "SideMarketSegmentID":
					{
						value = SideMarketSegmentID;
						break;
					}
					case "SideVenueType":
					{
						value = SideVenueType;
						break;
					}
					case "ClearingFeeIndicator":
					{
						value = ClearingFeeIndicator;
						break;
					}
					case "TradeReportOrderDetail":
					{
						value = TradeReportOrderDetail;
						break;
					}
					case "TrdInstrmtLegExecGrp":
					{
						value = TrdInstrmtLegExecGrp;
						break;
					}
					case "CustOrderHandlingInst":
					{
						value = CustOrderHandlingInst;
						break;
					}
					case "OrderHandlingInstSource":
					{
						value = OrderHandlingInstSource;
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
				Side = null;
				SideExecID = null;
				SideExecRefID = null;
				SideTradeID = null;
				SideTradeReportID = null;
				OrderDelay = null;
				OrderDelayUnit = null;
				SideLastQty = null;
				SideClearingTradePrice = null;
				SidePriceDifferential = null;
				SideClearingTradePriceType = null;
				SideFillStationCd = null;
				SideReasonCd = null;
				SideTrdSubType = null;
				NetGrossInd = null;
				SideCurrency = null;
				SideCurrencyCodeSource = null;
				SideSettlCurrency = null;
				SideSettlCurrencyCodeSource = null;
				((IFixReset?)Parties)?.Reset();
				TradeInputSource = null;
				TradeInputDevice = null;
				ComplianceID = null;
				ComplianceText = null;
				EncodedComplianceTextLen = null;
				EncodedComplianceText = null;
				SolicitedFlag = null;
				CustOrderCapacity = null;
				TimeBracket = null;
				PositionEffect = null;
				ExchangeRule = null;
				TradeAllocIndicator = null;
				PreallocMethod = null;
				AllocID = null;
				((IFixReset?)TrdAllocGrp)?.Reset();
				SideGrossTradeAmt = null;
				AggressorIndicator = null;
				ExchangeSpecialInstructions = null;
				SideShortSaleExemptionReason = null;
				OrderCategory = null;
				AvgPxIndicator = null;
				AvgPxGroupID = null;
				SideMarketSegmentID = null;
				SideVenueType = null;
				ClearingFeeIndicator = null;
				((IFixReset?)TradeReportOrderDetail)?.Reset();
				((IFixReset?)TrdInstrmtLegExecGrp)?.Reset();
				CustOrderHandlingInst = null;
				OrderHandlingInstSource = null;
				Text = null;
				EncodedTextLen = null;
				EncodedText = null;
			}
		}
		[Group(NoOfTag = 1890, Offset = 0, Required = false)]
		public NoTrdMatchSides[]? TrdMatchSides {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (TrdMatchSides is not null && TrdMatchSides.Length != 0)
			{
				writer.WriteWholeNumber(1890, TrdMatchSides.Length);
				for (int i = 0; i < TrdMatchSides.Length; i++)
				{
					((IFixEncoder)TrdMatchSides[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoTrdMatchSides") is IMessageView viewNoTrdMatchSides)
			{
				var count = viewNoTrdMatchSides.GroupCount();
				TrdMatchSides = new NoTrdMatchSides[count];
				for (int i = 0; i < count; i++)
				{
					TrdMatchSides[i] = new();
					((IFixParser)TrdMatchSides[i]).Parse(viewNoTrdMatchSides.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoTrdMatchSides":
				{
					value = TrdMatchSides;
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
			TrdMatchSides = null;
		}
	}
}
