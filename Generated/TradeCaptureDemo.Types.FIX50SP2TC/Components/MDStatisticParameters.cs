using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class MDStatisticParameters : IFixComponent
	{
		[TagDetails(Tag = 2456, Type = TagType.Int, Offset = 0, Required = true)]
		public int? MDStatisticType {get; set;}
		
		[TagDetails(Tag = 2457, Type = TagType.Int, Offset = 1, Required = true)]
		public int? MDStatisticScope {get; set;}
		
		[TagDetails(Tag = 2458, Type = TagType.Int, Offset = 2, Required = false)]
		public int? MDStatisticSubScope {get; set;}
		
		[TagDetails(Tag = 2459, Type = TagType.Int, Offset = 3, Required = false)]
		public int? MDStatisticScopeType {get; set;}
		
		[TagDetails(Tag = 2454, Type = TagType.String, Offset = 4, Required = false)]
		public string? MDStatisticName {get; set;}
		
		[TagDetails(Tag = 2455, Type = TagType.String, Offset = 5, Required = false)]
		public string? MDStatisticDesc {get; set;}
		
		[TagDetails(Tag = 2481, Type = TagType.Length, Offset = 6, Required = false)]
		public int? EncodedMDStatisticDescLen {get; set;}
		
		[TagDetails(Tag = 2482, Type = TagType.RawData, Offset = 7, Required = false)]
		public byte[]? EncodedMDStatisticDesc {get; set;}
		
		[TagDetails(Tag = 264, Type = TagType.Int, Offset = 8, Required = false)]
		public int? MarketDepth {get; set;}
		
		[TagDetails(Tag = 2460, Type = TagType.Int, Offset = 9, Required = false)]
		public int? MDStatisticFrequencyPeriod {get; set;}
		
		[TagDetails(Tag = 2461, Type = TagType.Int, Offset = 10, Required = false)]
		public int? MDStatisticFrequencyUnit {get; set;}
		
		[TagDetails(Tag = 2462, Type = TagType.Int, Offset = 11, Required = false)]
		public int? MDStatisticDelayPeriod {get; set;}
		
		[TagDetails(Tag = 2463, Type = TagType.Int, Offset = 12, Required = false)]
		public int? MDStatisticDelayUnit {get; set;}
		
		[TagDetails(Tag = 2464, Type = TagType.Int, Offset = 13, Required = true)]
		public int? MDStatisticIntervalType {get; set;}
		
		[TagDetails(Tag = 2465, Type = TagType.String, Offset = 14, Required = false)]
		public string? MDStatisticIntervalTypeUnit {get; set;}
		
		[TagDetails(Tag = 2466, Type = TagType.Int, Offset = 15, Required = false)]
		public int? MDStatisticIntervalPeriod {get; set;}
		
		[TagDetails(Tag = 2467, Type = TagType.Int, Offset = 16, Required = false)]
		public int? MDStatisticIntervalUnit {get; set;}
		
		[TagDetails(Tag = 2468, Type = TagType.UtcTimestamp, Offset = 17, Required = false)]
		public DateTime? MDStatisticStartDate {get; set;}
		
		[TagDetails(Tag = 2469, Type = TagType.UtcTimestamp, Offset = 18, Required = false)]
		public DateTime? MDStatisticEndDate {get; set;}
		
		[TagDetails(Tag = 2470, Type = TagType.UtcTimeOnly, Offset = 19, Required = false)]
		public TimeOnly? MDStatisticStartTime {get; set;}
		
		[TagDetails(Tag = 2471, Type = TagType.UtcTimeOnly, Offset = 20, Required = false)]
		public TimeOnly? MDStatisticEndTime {get; set;}
		
		[TagDetails(Tag = 2472, Type = TagType.Int, Offset = 21, Required = false)]
		public int? MDStatisticRatioType {get; set;}
		
		[Component(Offset = 22, Required = false)]
		public NestedParties? NestedParties {get; set;}
		
		[TagDetails(Tag = 2584, Type = TagType.Int, Offset = 23, Required = false)]
		public int? AnnualTradingBusinessDays {get; set;}
		
		[TagDetails(Tag = 1815, Type = TagType.Int, Offset = 24, Required = false)]
		public int? TradingCapacity {get; set;}
		
		[TagDetails(Tag = 40, Type = TagType.String, Offset = 25, Required = false)]
		public string? OrdType {get; set;}
		
		[TagDetails(Tag = 59, Type = TagType.String, Offset = 26, Required = false)]
		public string? TimeInForce {get; set;}
		
		[TagDetails(Tag = 276, Type = TagType.String, Offset = 27, Required = false)]
		public string? QuoteCondition {get; set;}
		
		[TagDetails(Tag = 277, Type = TagType.String, Offset = 28, Required = false)]
		public string? TradeCondition {get; set;}
		
		[TagDetails(Tag = 54, Type = TagType.String, Offset = 29, Required = false)]
		public string? Side {get; set;}
		
		[TagDetails(Tag = 578, Type = TagType.String, Offset = 30, Required = false)]
		public string? TradeInputSource {get; set;}
		
		[TagDetails(Tag = 336, Type = TagType.String, Offset = 31, Required = false)]
		public string? TradingSessionID {get; set;}
		
		[TagDetails(Tag = 625, Type = TagType.String, Offset = 32, Required = false)]
		public string? TradingSessionSubID {get; set;}
		
		[TagDetails(Tag = 1024, Type = TagType.Int, Offset = 33, Required = false)]
		public int? MDOriginType {get; set;}
		
		[TagDetails(Tag = 2711, Type = TagType.Int, Offset = 34, Required = false)]
		public int? MDValueTier {get; set;}
		
		[TagDetails(Tag = 338, Type = TagType.Int, Offset = 35, Required = false)]
		public int? TradSesMethod {get; set;}
		
		[TagDetails(Tag = 1022, Type = TagType.String, Offset = 36, Required = false)]
		public string? MDFeedType {get; set;}
		
		[TagDetails(Tag = 1629, Type = TagType.Int, Offset = 37, Required = false)]
		public int? ExposureDuration {get; set;}
		
		[TagDetails(Tag = 1916, Type = TagType.Int, Offset = 38, Required = false)]
		public int? ExposureDurationUnit {get; set;}
		
		[TagDetails(Tag = 1057, Type = TagType.Boolean, Offset = 39, Required = false)]
		public bool? AggressorIndicator {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (MDStatisticType is not null) writer.WriteWholeNumber(2456, MDStatisticType.Value);
			if (MDStatisticScope is not null) writer.WriteWholeNumber(2457, MDStatisticScope.Value);
			if (MDStatisticSubScope is not null) writer.WriteWholeNumber(2458, MDStatisticSubScope.Value);
			if (MDStatisticScopeType is not null) writer.WriteWholeNumber(2459, MDStatisticScopeType.Value);
			if (MDStatisticName is not null) writer.WriteString(2454, MDStatisticName);
			if (MDStatisticDesc is not null) writer.WriteString(2455, MDStatisticDesc);
			if (EncodedMDStatisticDescLen is not null) writer.WriteWholeNumber(2481, EncodedMDStatisticDescLen.Value);
			if (EncodedMDStatisticDesc is not null) writer.WriteBuffer(2482, EncodedMDStatisticDesc);
			if (MarketDepth is not null) writer.WriteWholeNumber(264, MarketDepth.Value);
			if (MDStatisticFrequencyPeriod is not null) writer.WriteWholeNumber(2460, MDStatisticFrequencyPeriod.Value);
			if (MDStatisticFrequencyUnit is not null) writer.WriteWholeNumber(2461, MDStatisticFrequencyUnit.Value);
			if (MDStatisticDelayPeriod is not null) writer.WriteWholeNumber(2462, MDStatisticDelayPeriod.Value);
			if (MDStatisticDelayUnit is not null) writer.WriteWholeNumber(2463, MDStatisticDelayUnit.Value);
			if (MDStatisticIntervalType is not null) writer.WriteWholeNumber(2464, MDStatisticIntervalType.Value);
			if (MDStatisticIntervalTypeUnit is not null) writer.WriteString(2465, MDStatisticIntervalTypeUnit);
			if (MDStatisticIntervalPeriod is not null) writer.WriteWholeNumber(2466, MDStatisticIntervalPeriod.Value);
			if (MDStatisticIntervalUnit is not null) writer.WriteWholeNumber(2467, MDStatisticIntervalUnit.Value);
			if (MDStatisticStartDate is not null) writer.WriteUtcTimeStamp(2468, MDStatisticStartDate.Value);
			if (MDStatisticEndDate is not null) writer.WriteUtcTimeStamp(2469, MDStatisticEndDate.Value);
			if (MDStatisticStartTime is not null) writer.WriteTimeOnly(2470, MDStatisticStartTime.Value);
			if (MDStatisticEndTime is not null) writer.WriteTimeOnly(2471, MDStatisticEndTime.Value);
			if (MDStatisticRatioType is not null) writer.WriteWholeNumber(2472, MDStatisticRatioType.Value);
			if (NestedParties is not null) ((IFixEncoder)NestedParties).Encode(writer);
			if (AnnualTradingBusinessDays is not null) writer.WriteWholeNumber(2584, AnnualTradingBusinessDays.Value);
			if (TradingCapacity is not null) writer.WriteWholeNumber(1815, TradingCapacity.Value);
			if (OrdType is not null) writer.WriteString(40, OrdType);
			if (TimeInForce is not null) writer.WriteString(59, TimeInForce);
			if (QuoteCondition is not null) writer.WriteString(276, QuoteCondition);
			if (TradeCondition is not null) writer.WriteString(277, TradeCondition);
			if (Side is not null) writer.WriteString(54, Side);
			if (TradeInputSource is not null) writer.WriteString(578, TradeInputSource);
			if (TradingSessionID is not null) writer.WriteString(336, TradingSessionID);
			if (TradingSessionSubID is not null) writer.WriteString(625, TradingSessionSubID);
			if (MDOriginType is not null) writer.WriteWholeNumber(1024, MDOriginType.Value);
			if (MDValueTier is not null) writer.WriteWholeNumber(2711, MDValueTier.Value);
			if (TradSesMethod is not null) writer.WriteWholeNumber(338, TradSesMethod.Value);
			if (MDFeedType is not null) writer.WriteString(1022, MDFeedType);
			if (ExposureDuration is not null) writer.WriteWholeNumber(1629, ExposureDuration.Value);
			if (ExposureDurationUnit is not null) writer.WriteWholeNumber(1916, ExposureDurationUnit.Value);
			if (AggressorIndicator is not null) writer.WriteBoolean(1057, AggressorIndicator.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			MDStatisticType = view.GetInt32(2456);
			MDStatisticScope = view.GetInt32(2457);
			MDStatisticSubScope = view.GetInt32(2458);
			MDStatisticScopeType = view.GetInt32(2459);
			MDStatisticName = view.GetString(2454);
			MDStatisticDesc = view.GetString(2455);
			EncodedMDStatisticDescLen = view.GetInt32(2481);
			EncodedMDStatisticDesc = view.GetByteArray(2482);
			MarketDepth = view.GetInt32(264);
			MDStatisticFrequencyPeriod = view.GetInt32(2460);
			MDStatisticFrequencyUnit = view.GetInt32(2461);
			MDStatisticDelayPeriod = view.GetInt32(2462);
			MDStatisticDelayUnit = view.GetInt32(2463);
			MDStatisticIntervalType = view.GetInt32(2464);
			MDStatisticIntervalTypeUnit = view.GetString(2465);
			MDStatisticIntervalPeriod = view.GetInt32(2466);
			MDStatisticIntervalUnit = view.GetInt32(2467);
			MDStatisticStartDate = view.GetDateTime(2468);
			MDStatisticEndDate = view.GetDateTime(2469);
			MDStatisticStartTime = view.GetTimeOnly(2470);
			MDStatisticEndTime = view.GetTimeOnly(2471);
			MDStatisticRatioType = view.GetInt32(2472);
			if (view.GetView("NestedParties") is IMessageView viewNestedParties)
			{
				NestedParties = new();
				((IFixParser)NestedParties).Parse(viewNestedParties);
			}
			AnnualTradingBusinessDays = view.GetInt32(2584);
			TradingCapacity = view.GetInt32(1815);
			OrdType = view.GetString(40);
			TimeInForce = view.GetString(59);
			QuoteCondition = view.GetString(276);
			TradeCondition = view.GetString(277);
			Side = view.GetString(54);
			TradeInputSource = view.GetString(578);
			TradingSessionID = view.GetString(336);
			TradingSessionSubID = view.GetString(625);
			MDOriginType = view.GetInt32(1024);
			MDValueTier = view.GetInt32(2711);
			TradSesMethod = view.GetInt32(338);
			MDFeedType = view.GetString(1022);
			ExposureDuration = view.GetInt32(1629);
			ExposureDurationUnit = view.GetInt32(1916);
			AggressorIndicator = view.GetBool(1057);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "MDStatisticType":
				{
					value = MDStatisticType;
					break;
				}
				case "MDStatisticScope":
				{
					value = MDStatisticScope;
					break;
				}
				case "MDStatisticSubScope":
				{
					value = MDStatisticSubScope;
					break;
				}
				case "MDStatisticScopeType":
				{
					value = MDStatisticScopeType;
					break;
				}
				case "MDStatisticName":
				{
					value = MDStatisticName;
					break;
				}
				case "MDStatisticDesc":
				{
					value = MDStatisticDesc;
					break;
				}
				case "EncodedMDStatisticDescLen":
				{
					value = EncodedMDStatisticDescLen;
					break;
				}
				case "EncodedMDStatisticDesc":
				{
					value = EncodedMDStatisticDesc;
					break;
				}
				case "MarketDepth":
				{
					value = MarketDepth;
					break;
				}
				case "MDStatisticFrequencyPeriod":
				{
					value = MDStatisticFrequencyPeriod;
					break;
				}
				case "MDStatisticFrequencyUnit":
				{
					value = MDStatisticFrequencyUnit;
					break;
				}
				case "MDStatisticDelayPeriod":
				{
					value = MDStatisticDelayPeriod;
					break;
				}
				case "MDStatisticDelayUnit":
				{
					value = MDStatisticDelayUnit;
					break;
				}
				case "MDStatisticIntervalType":
				{
					value = MDStatisticIntervalType;
					break;
				}
				case "MDStatisticIntervalTypeUnit":
				{
					value = MDStatisticIntervalTypeUnit;
					break;
				}
				case "MDStatisticIntervalPeriod":
				{
					value = MDStatisticIntervalPeriod;
					break;
				}
				case "MDStatisticIntervalUnit":
				{
					value = MDStatisticIntervalUnit;
					break;
				}
				case "MDStatisticStartDate":
				{
					value = MDStatisticStartDate;
					break;
				}
				case "MDStatisticEndDate":
				{
					value = MDStatisticEndDate;
					break;
				}
				case "MDStatisticStartTime":
				{
					value = MDStatisticStartTime;
					break;
				}
				case "MDStatisticEndTime":
				{
					value = MDStatisticEndTime;
					break;
				}
				case "MDStatisticRatioType":
				{
					value = MDStatisticRatioType;
					break;
				}
				case "NestedParties":
				{
					value = NestedParties;
					break;
				}
				case "AnnualTradingBusinessDays":
				{
					value = AnnualTradingBusinessDays;
					break;
				}
				case "TradingCapacity":
				{
					value = TradingCapacity;
					break;
				}
				case "OrdType":
				{
					value = OrdType;
					break;
				}
				case "TimeInForce":
				{
					value = TimeInForce;
					break;
				}
				case "QuoteCondition":
				{
					value = QuoteCondition;
					break;
				}
				case "TradeCondition":
				{
					value = TradeCondition;
					break;
				}
				case "Side":
				{
					value = Side;
					break;
				}
				case "TradeInputSource":
				{
					value = TradeInputSource;
					break;
				}
				case "TradingSessionID":
				{
					value = TradingSessionID;
					break;
				}
				case "TradingSessionSubID":
				{
					value = TradingSessionSubID;
					break;
				}
				case "MDOriginType":
				{
					value = MDOriginType;
					break;
				}
				case "MDValueTier":
				{
					value = MDValueTier;
					break;
				}
				case "TradSesMethod":
				{
					value = TradSesMethod;
					break;
				}
				case "MDFeedType":
				{
					value = MDFeedType;
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
				case "AggressorIndicator":
				{
					value = AggressorIndicator;
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
			MDStatisticType = null;
			MDStatisticScope = null;
			MDStatisticSubScope = null;
			MDStatisticScopeType = null;
			MDStatisticName = null;
			MDStatisticDesc = null;
			EncodedMDStatisticDescLen = null;
			EncodedMDStatisticDesc = null;
			MarketDepth = null;
			MDStatisticFrequencyPeriod = null;
			MDStatisticFrequencyUnit = null;
			MDStatisticDelayPeriod = null;
			MDStatisticDelayUnit = null;
			MDStatisticIntervalType = null;
			MDStatisticIntervalTypeUnit = null;
			MDStatisticIntervalPeriod = null;
			MDStatisticIntervalUnit = null;
			MDStatisticStartDate = null;
			MDStatisticEndDate = null;
			MDStatisticStartTime = null;
			MDStatisticEndTime = null;
			MDStatisticRatioType = null;
			((IFixReset?)NestedParties)?.Reset();
			AnnualTradingBusinessDays = null;
			TradingCapacity = null;
			OrdType = null;
			TimeInForce = null;
			QuoteCondition = null;
			TradeCondition = null;
			Side = null;
			TradeInputSource = null;
			TradingSessionID = null;
			TradingSessionSubID = null;
			MDOriginType = null;
			MDValueTier = null;
			TradSesMethod = null;
			MDFeedType = null;
			ExposureDuration = null;
			ExposureDurationUnit = null;
			AggressorIndicator = null;
		}
	}
}
