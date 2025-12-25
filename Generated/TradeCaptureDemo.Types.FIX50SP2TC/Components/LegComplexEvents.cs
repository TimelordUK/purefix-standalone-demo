using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegComplexEvents : IFixComponent
	{
		public sealed partial class NoLegComplexEvents : IFixGroup
		{
			[TagDetails(Tag = 2219, Type = TagType.Int, Offset = 0, Required = false)]
			public int? LegComplexEventType {get; set;}
			
			[TagDetails(Tag = 2220, Type = TagType.Int, Offset = 1, Required = false)]
			public int? LegComplexOptPayoutPaySide {get; set;}
			
			[TagDetails(Tag = 2221, Type = TagType.Int, Offset = 2, Required = false)]
			public int? LegComplexOptPayoutReceiveSide {get; set;}
			
			[TagDetails(Tag = 2222, Type = TagType.String, Offset = 3, Required = false)]
			public string? LegComplexOptPayoutUnderlier {get; set;}
			
			[TagDetails(Tag = 2223, Type = TagType.Float, Offset = 4, Required = false)]
			public double? LegComplexOptPayoutAmount {get; set;}
			
			[TagDetails(Tag = 2224, Type = TagType.Float, Offset = 5, Required = false)]
			public double? LegComplexOptPayoutPercentage {get; set;}
			
			[TagDetails(Tag = 2225, Type = TagType.Int, Offset = 6, Required = false)]
			public int? LegComplexOptPayoutTime {get; set;}
			
			[TagDetails(Tag = 2226, Type = TagType.String, Offset = 7, Required = false)]
			public string? LegComplexOptPayoutCurrency {get; set;}
			
			[TagDetails(Tag = 2944, Type = TagType.String, Offset = 8, Required = false)]
			public string? LegComplexOptPayoutCurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 2227, Type = TagType.Float, Offset = 9, Required = false)]
			public double? LegComplexEventPrice {get; set;}
			
			[TagDetails(Tag = 2228, Type = TagType.Float, Offset = 10, Required = false)]
			public double? LegComplexEventPricePercentage {get; set;}
			
			[TagDetails(Tag = 2229, Type = TagType.Int, Offset = 11, Required = false)]
			public int? LegComplexEventPriceBoundaryMethod {get; set;}
			
			[TagDetails(Tag = 2230, Type = TagType.Float, Offset = 12, Required = false)]
			public double? LegComplexEventPriceBoundaryPrecision {get; set;}
			
			[TagDetails(Tag = 2231, Type = TagType.Int, Offset = 13, Required = false)]
			public int? LegComplexEventPriceTimeType {get; set;}
			
			[TagDetails(Tag = 2232, Type = TagType.Int, Offset = 14, Required = false)]
			public int? LegComplexEventCondition {get; set;}
			
			[Component(Offset = 15, Required = false)]
			public LegComplexEventDates? LegComplexEventDates {get; set;}
			
			[TagDetails(Tag = 2233, Type = TagType.String, Offset = 16, Required = false)]
			public string? LegComplexEventCurrencyOne {get; set;}
			
			[TagDetails(Tag = 2945, Type = TagType.String, Offset = 17, Required = false)]
			public string? LegComplexEventCurrencyOneCodeSource {get; set;}
			
			[TagDetails(Tag = 2234, Type = TagType.String, Offset = 18, Required = false)]
			public string? LegComplexEventCurrencyTwo {get; set;}
			
			[TagDetails(Tag = 2946, Type = TagType.String, Offset = 19, Required = false)]
			public string? LegComplexEventCurrencyTwoCodeSource {get; set;}
			
			[TagDetails(Tag = 2235, Type = TagType.Int, Offset = 20, Required = false)]
			public int? LegComplexEventQuoteBasis {get; set;}
			
			[TagDetails(Tag = 2236, Type = TagType.Float, Offset = 21, Required = false)]
			public double? LegComplexEventFixedFXRate {get; set;}
			
			[TagDetails(Tag = 2409, Type = TagType.Float, Offset = 22, Required = false)]
			public double? LegComplexEventSpotRate {get; set;}
			
			[TagDetails(Tag = 2410, Type = TagType.Float, Offset = 23, Required = false)]
			public double? LegComplexEventForwardPoints {get; set;}
			
			[TagDetails(Tag = 2237, Type = TagType.String, Offset = 24, Required = false)]
			public string? LegComplexEventDeterminationMethod {get; set;}
			
			[TagDetails(Tag = 2238, Type = TagType.Int, Offset = 25, Required = false)]
			public int? LegComplexEventCalculationAgent {get; set;}
			
			[TagDetails(Tag = 2239, Type = TagType.Float, Offset = 26, Required = false)]
			public double? LegComplexEventStrikePrice {get; set;}
			
			[TagDetails(Tag = 2240, Type = TagType.Float, Offset = 27, Required = false)]
			public double? LegComplexEventStrikeFactor {get; set;}
			
			[TagDetails(Tag = 2241, Type = TagType.Int, Offset = 28, Required = false)]
			public int? LegComplexEventStrikeNumberOfOptions {get; set;}
			
			[Component(Offset = 29, Required = false)]
			public LegComplexEventRateSourceGrp? LegComplexEventRateSourceGrp {get; set;}
			
			[Component(Offset = 30, Required = false)]
			public LegComplexEventRelativeDate? LegComplexEventRelativeDate {get; set;}
			
			[Component(Offset = 31, Required = false)]
			public LegComplexEventPeriodGrp? LegComplexEventPeriodGrp {get; set;}
			
			[TagDetails(Tag = 2242, Type = TagType.String, Offset = 32, Required = false)]
			public string? LegComplexEventCreditEventsXIDRef {get; set;}
			
			[TagDetails(Tag = 2243, Type = TagType.Int, Offset = 33, Required = false)]
			public int? LegComplexEventCreditEventNotifyingParty {get; set;}
			
			[TagDetails(Tag = 2244, Type = TagType.String, Offset = 34, Required = false)]
			public string? LegComplexEventCreditEventBusinessCenter {get; set;}
			
			[TagDetails(Tag = 2245, Type = TagType.Boolean, Offset = 35, Required = false)]
			public bool? LegComplexEventCreditEventStandardSources {get; set;}
			
			[TagDetails(Tag = 2246, Type = TagType.Int, Offset = 36, Required = false)]
			public int? LegComplexEventCreditEventMinimumSources {get; set;}
			
			[Component(Offset = 37, Required = false)]
			public LegComplexEventCreditEventSourceGrp? LegComplexEventCreditEventSourceGrp {get; set;}
			
			[Component(Offset = 38, Required = false)]
			public LegComplexEventCreditEventGrp? LegComplexEventCreditEventGrp {get; set;}
			
			[TagDetails(Tag = 2608, Type = TagType.Boolean, Offset = 39, Required = false)]
			public bool? LegComplexEventFuturesPriceValuation {get; set;}
			
			[TagDetails(Tag = 2609, Type = TagType.Boolean, Offset = 40, Required = false)]
			public bool? LegComplexEventOptionsPriceValuation {get; set;}
			
			[TagDetails(Tag = 2610, Type = TagType.Int, Offset = 41, Required = false)]
			public int? LegComplexEventPVFinalPriceElectionFallback {get; set;}
			
			[TagDetails(Tag = 2248, Type = TagType.String, Offset = 42, Required = false)]
			public string? LegComplexEventXID {get; set;}
			
			[TagDetails(Tag = 2249, Type = TagType.String, Offset = 43, Required = false)]
			public string? LegComplexEventXIDRef {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegComplexEventType is not null) writer.WriteWholeNumber(2219, LegComplexEventType.Value);
				if (LegComplexOptPayoutPaySide is not null) writer.WriteWholeNumber(2220, LegComplexOptPayoutPaySide.Value);
				if (LegComplexOptPayoutReceiveSide is not null) writer.WriteWholeNumber(2221, LegComplexOptPayoutReceiveSide.Value);
				if (LegComplexOptPayoutUnderlier is not null) writer.WriteString(2222, LegComplexOptPayoutUnderlier);
				if (LegComplexOptPayoutAmount is not null) writer.WriteNumber(2223, LegComplexOptPayoutAmount.Value);
				if (LegComplexOptPayoutPercentage is not null) writer.WriteNumber(2224, LegComplexOptPayoutPercentage.Value);
				if (LegComplexOptPayoutTime is not null) writer.WriteWholeNumber(2225, LegComplexOptPayoutTime.Value);
				if (LegComplexOptPayoutCurrency is not null) writer.WriteString(2226, LegComplexOptPayoutCurrency);
				if (LegComplexOptPayoutCurrencyCodeSource is not null) writer.WriteString(2944, LegComplexOptPayoutCurrencyCodeSource);
				if (LegComplexEventPrice is not null) writer.WriteNumber(2227, LegComplexEventPrice.Value);
				if (LegComplexEventPricePercentage is not null) writer.WriteNumber(2228, LegComplexEventPricePercentage.Value);
				if (LegComplexEventPriceBoundaryMethod is not null) writer.WriteWholeNumber(2229, LegComplexEventPriceBoundaryMethod.Value);
				if (LegComplexEventPriceBoundaryPrecision is not null) writer.WriteNumber(2230, LegComplexEventPriceBoundaryPrecision.Value);
				if (LegComplexEventPriceTimeType is not null) writer.WriteWholeNumber(2231, LegComplexEventPriceTimeType.Value);
				if (LegComplexEventCondition is not null) writer.WriteWholeNumber(2232, LegComplexEventCondition.Value);
				if (LegComplexEventDates is not null) ((IFixEncoder)LegComplexEventDates).Encode(writer);
				if (LegComplexEventCurrencyOne is not null) writer.WriteString(2233, LegComplexEventCurrencyOne);
				if (LegComplexEventCurrencyOneCodeSource is not null) writer.WriteString(2945, LegComplexEventCurrencyOneCodeSource);
				if (LegComplexEventCurrencyTwo is not null) writer.WriteString(2234, LegComplexEventCurrencyTwo);
				if (LegComplexEventCurrencyTwoCodeSource is not null) writer.WriteString(2946, LegComplexEventCurrencyTwoCodeSource);
				if (LegComplexEventQuoteBasis is not null) writer.WriteWholeNumber(2235, LegComplexEventQuoteBasis.Value);
				if (LegComplexEventFixedFXRate is not null) writer.WriteNumber(2236, LegComplexEventFixedFXRate.Value);
				if (LegComplexEventSpotRate is not null) writer.WriteNumber(2409, LegComplexEventSpotRate.Value);
				if (LegComplexEventForwardPoints is not null) writer.WriteNumber(2410, LegComplexEventForwardPoints.Value);
				if (LegComplexEventDeterminationMethod is not null) writer.WriteString(2237, LegComplexEventDeterminationMethod);
				if (LegComplexEventCalculationAgent is not null) writer.WriteWholeNumber(2238, LegComplexEventCalculationAgent.Value);
				if (LegComplexEventStrikePrice is not null) writer.WriteNumber(2239, LegComplexEventStrikePrice.Value);
				if (LegComplexEventStrikeFactor is not null) writer.WriteNumber(2240, LegComplexEventStrikeFactor.Value);
				if (LegComplexEventStrikeNumberOfOptions is not null) writer.WriteWholeNumber(2241, LegComplexEventStrikeNumberOfOptions.Value);
				if (LegComplexEventRateSourceGrp is not null) ((IFixEncoder)LegComplexEventRateSourceGrp).Encode(writer);
				if (LegComplexEventRelativeDate is not null) ((IFixEncoder)LegComplexEventRelativeDate).Encode(writer);
				if (LegComplexEventPeriodGrp is not null) ((IFixEncoder)LegComplexEventPeriodGrp).Encode(writer);
				if (LegComplexEventCreditEventsXIDRef is not null) writer.WriteString(2242, LegComplexEventCreditEventsXIDRef);
				if (LegComplexEventCreditEventNotifyingParty is not null) writer.WriteWholeNumber(2243, LegComplexEventCreditEventNotifyingParty.Value);
				if (LegComplexEventCreditEventBusinessCenter is not null) writer.WriteString(2244, LegComplexEventCreditEventBusinessCenter);
				if (LegComplexEventCreditEventStandardSources is not null) writer.WriteBoolean(2245, LegComplexEventCreditEventStandardSources.Value);
				if (LegComplexEventCreditEventMinimumSources is not null) writer.WriteWholeNumber(2246, LegComplexEventCreditEventMinimumSources.Value);
				if (LegComplexEventCreditEventSourceGrp is not null) ((IFixEncoder)LegComplexEventCreditEventSourceGrp).Encode(writer);
				if (LegComplexEventCreditEventGrp is not null) ((IFixEncoder)LegComplexEventCreditEventGrp).Encode(writer);
				if (LegComplexEventFuturesPriceValuation is not null) writer.WriteBoolean(2608, LegComplexEventFuturesPriceValuation.Value);
				if (LegComplexEventOptionsPriceValuation is not null) writer.WriteBoolean(2609, LegComplexEventOptionsPriceValuation.Value);
				if (LegComplexEventPVFinalPriceElectionFallback is not null) writer.WriteWholeNumber(2610, LegComplexEventPVFinalPriceElectionFallback.Value);
				if (LegComplexEventXID is not null) writer.WriteString(2248, LegComplexEventXID);
				if (LegComplexEventXIDRef is not null) writer.WriteString(2249, LegComplexEventXIDRef);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegComplexEventType = view.GetInt32(2219);
				LegComplexOptPayoutPaySide = view.GetInt32(2220);
				LegComplexOptPayoutReceiveSide = view.GetInt32(2221);
				LegComplexOptPayoutUnderlier = view.GetString(2222);
				LegComplexOptPayoutAmount = view.GetDouble(2223);
				LegComplexOptPayoutPercentage = view.GetDouble(2224);
				LegComplexOptPayoutTime = view.GetInt32(2225);
				LegComplexOptPayoutCurrency = view.GetString(2226);
				LegComplexOptPayoutCurrencyCodeSource = view.GetString(2944);
				LegComplexEventPrice = view.GetDouble(2227);
				LegComplexEventPricePercentage = view.GetDouble(2228);
				LegComplexEventPriceBoundaryMethod = view.GetInt32(2229);
				LegComplexEventPriceBoundaryPrecision = view.GetDouble(2230);
				LegComplexEventPriceTimeType = view.GetInt32(2231);
				LegComplexEventCondition = view.GetInt32(2232);
				if (view.GetView("LegComplexEventDates") is IMessageView viewLegComplexEventDates)
				{
					LegComplexEventDates = new();
					((IFixParser)LegComplexEventDates).Parse(viewLegComplexEventDates);
				}
				LegComplexEventCurrencyOne = view.GetString(2233);
				LegComplexEventCurrencyOneCodeSource = view.GetString(2945);
				LegComplexEventCurrencyTwo = view.GetString(2234);
				LegComplexEventCurrencyTwoCodeSource = view.GetString(2946);
				LegComplexEventQuoteBasis = view.GetInt32(2235);
				LegComplexEventFixedFXRate = view.GetDouble(2236);
				LegComplexEventSpotRate = view.GetDouble(2409);
				LegComplexEventForwardPoints = view.GetDouble(2410);
				LegComplexEventDeterminationMethod = view.GetString(2237);
				LegComplexEventCalculationAgent = view.GetInt32(2238);
				LegComplexEventStrikePrice = view.GetDouble(2239);
				LegComplexEventStrikeFactor = view.GetDouble(2240);
				LegComplexEventStrikeNumberOfOptions = view.GetInt32(2241);
				if (view.GetView("LegComplexEventRateSourceGrp") is IMessageView viewLegComplexEventRateSourceGrp)
				{
					LegComplexEventRateSourceGrp = new();
					((IFixParser)LegComplexEventRateSourceGrp).Parse(viewLegComplexEventRateSourceGrp);
				}
				if (view.GetView("LegComplexEventRelativeDate") is IMessageView viewLegComplexEventRelativeDate)
				{
					LegComplexEventRelativeDate = new();
					((IFixParser)LegComplexEventRelativeDate).Parse(viewLegComplexEventRelativeDate);
				}
				if (view.GetView("LegComplexEventPeriodGrp") is IMessageView viewLegComplexEventPeriodGrp)
				{
					LegComplexEventPeriodGrp = new();
					((IFixParser)LegComplexEventPeriodGrp).Parse(viewLegComplexEventPeriodGrp);
				}
				LegComplexEventCreditEventsXIDRef = view.GetString(2242);
				LegComplexEventCreditEventNotifyingParty = view.GetInt32(2243);
				LegComplexEventCreditEventBusinessCenter = view.GetString(2244);
				LegComplexEventCreditEventStandardSources = view.GetBool(2245);
				LegComplexEventCreditEventMinimumSources = view.GetInt32(2246);
				if (view.GetView("LegComplexEventCreditEventSourceGrp") is IMessageView viewLegComplexEventCreditEventSourceGrp)
				{
					LegComplexEventCreditEventSourceGrp = new();
					((IFixParser)LegComplexEventCreditEventSourceGrp).Parse(viewLegComplexEventCreditEventSourceGrp);
				}
				if (view.GetView("LegComplexEventCreditEventGrp") is IMessageView viewLegComplexEventCreditEventGrp)
				{
					LegComplexEventCreditEventGrp = new();
					((IFixParser)LegComplexEventCreditEventGrp).Parse(viewLegComplexEventCreditEventGrp);
				}
				LegComplexEventFuturesPriceValuation = view.GetBool(2608);
				LegComplexEventOptionsPriceValuation = view.GetBool(2609);
				LegComplexEventPVFinalPriceElectionFallback = view.GetInt32(2610);
				LegComplexEventXID = view.GetString(2248);
				LegComplexEventXIDRef = view.GetString(2249);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegComplexEventType":
					{
						value = LegComplexEventType;
						break;
					}
					case "LegComplexOptPayoutPaySide":
					{
						value = LegComplexOptPayoutPaySide;
						break;
					}
					case "LegComplexOptPayoutReceiveSide":
					{
						value = LegComplexOptPayoutReceiveSide;
						break;
					}
					case "LegComplexOptPayoutUnderlier":
					{
						value = LegComplexOptPayoutUnderlier;
						break;
					}
					case "LegComplexOptPayoutAmount":
					{
						value = LegComplexOptPayoutAmount;
						break;
					}
					case "LegComplexOptPayoutPercentage":
					{
						value = LegComplexOptPayoutPercentage;
						break;
					}
					case "LegComplexOptPayoutTime":
					{
						value = LegComplexOptPayoutTime;
						break;
					}
					case "LegComplexOptPayoutCurrency":
					{
						value = LegComplexOptPayoutCurrency;
						break;
					}
					case "LegComplexOptPayoutCurrencyCodeSource":
					{
						value = LegComplexOptPayoutCurrencyCodeSource;
						break;
					}
					case "LegComplexEventPrice":
					{
						value = LegComplexEventPrice;
						break;
					}
					case "LegComplexEventPricePercentage":
					{
						value = LegComplexEventPricePercentage;
						break;
					}
					case "LegComplexEventPriceBoundaryMethod":
					{
						value = LegComplexEventPriceBoundaryMethod;
						break;
					}
					case "LegComplexEventPriceBoundaryPrecision":
					{
						value = LegComplexEventPriceBoundaryPrecision;
						break;
					}
					case "LegComplexEventPriceTimeType":
					{
						value = LegComplexEventPriceTimeType;
						break;
					}
					case "LegComplexEventCondition":
					{
						value = LegComplexEventCondition;
						break;
					}
					case "LegComplexEventDates":
					{
						value = LegComplexEventDates;
						break;
					}
					case "LegComplexEventCurrencyOne":
					{
						value = LegComplexEventCurrencyOne;
						break;
					}
					case "LegComplexEventCurrencyOneCodeSource":
					{
						value = LegComplexEventCurrencyOneCodeSource;
						break;
					}
					case "LegComplexEventCurrencyTwo":
					{
						value = LegComplexEventCurrencyTwo;
						break;
					}
					case "LegComplexEventCurrencyTwoCodeSource":
					{
						value = LegComplexEventCurrencyTwoCodeSource;
						break;
					}
					case "LegComplexEventQuoteBasis":
					{
						value = LegComplexEventQuoteBasis;
						break;
					}
					case "LegComplexEventFixedFXRate":
					{
						value = LegComplexEventFixedFXRate;
						break;
					}
					case "LegComplexEventSpotRate":
					{
						value = LegComplexEventSpotRate;
						break;
					}
					case "LegComplexEventForwardPoints":
					{
						value = LegComplexEventForwardPoints;
						break;
					}
					case "LegComplexEventDeterminationMethod":
					{
						value = LegComplexEventDeterminationMethod;
						break;
					}
					case "LegComplexEventCalculationAgent":
					{
						value = LegComplexEventCalculationAgent;
						break;
					}
					case "LegComplexEventStrikePrice":
					{
						value = LegComplexEventStrikePrice;
						break;
					}
					case "LegComplexEventStrikeFactor":
					{
						value = LegComplexEventStrikeFactor;
						break;
					}
					case "LegComplexEventStrikeNumberOfOptions":
					{
						value = LegComplexEventStrikeNumberOfOptions;
						break;
					}
					case "LegComplexEventRateSourceGrp":
					{
						value = LegComplexEventRateSourceGrp;
						break;
					}
					case "LegComplexEventRelativeDate":
					{
						value = LegComplexEventRelativeDate;
						break;
					}
					case "LegComplexEventPeriodGrp":
					{
						value = LegComplexEventPeriodGrp;
						break;
					}
					case "LegComplexEventCreditEventsXIDRef":
					{
						value = LegComplexEventCreditEventsXIDRef;
						break;
					}
					case "LegComplexEventCreditEventNotifyingParty":
					{
						value = LegComplexEventCreditEventNotifyingParty;
						break;
					}
					case "LegComplexEventCreditEventBusinessCenter":
					{
						value = LegComplexEventCreditEventBusinessCenter;
						break;
					}
					case "LegComplexEventCreditEventStandardSources":
					{
						value = LegComplexEventCreditEventStandardSources;
						break;
					}
					case "LegComplexEventCreditEventMinimumSources":
					{
						value = LegComplexEventCreditEventMinimumSources;
						break;
					}
					case "LegComplexEventCreditEventSourceGrp":
					{
						value = LegComplexEventCreditEventSourceGrp;
						break;
					}
					case "LegComplexEventCreditEventGrp":
					{
						value = LegComplexEventCreditEventGrp;
						break;
					}
					case "LegComplexEventFuturesPriceValuation":
					{
						value = LegComplexEventFuturesPriceValuation;
						break;
					}
					case "LegComplexEventOptionsPriceValuation":
					{
						value = LegComplexEventOptionsPriceValuation;
						break;
					}
					case "LegComplexEventPVFinalPriceElectionFallback":
					{
						value = LegComplexEventPVFinalPriceElectionFallback;
						break;
					}
					case "LegComplexEventXID":
					{
						value = LegComplexEventXID;
						break;
					}
					case "LegComplexEventXIDRef":
					{
						value = LegComplexEventXIDRef;
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
				LegComplexEventType = null;
				LegComplexOptPayoutPaySide = null;
				LegComplexOptPayoutReceiveSide = null;
				LegComplexOptPayoutUnderlier = null;
				LegComplexOptPayoutAmount = null;
				LegComplexOptPayoutPercentage = null;
				LegComplexOptPayoutTime = null;
				LegComplexOptPayoutCurrency = null;
				LegComplexOptPayoutCurrencyCodeSource = null;
				LegComplexEventPrice = null;
				LegComplexEventPricePercentage = null;
				LegComplexEventPriceBoundaryMethod = null;
				LegComplexEventPriceBoundaryPrecision = null;
				LegComplexEventPriceTimeType = null;
				LegComplexEventCondition = null;
				((IFixReset?)LegComplexEventDates)?.Reset();
				LegComplexEventCurrencyOne = null;
				LegComplexEventCurrencyOneCodeSource = null;
				LegComplexEventCurrencyTwo = null;
				LegComplexEventCurrencyTwoCodeSource = null;
				LegComplexEventQuoteBasis = null;
				LegComplexEventFixedFXRate = null;
				LegComplexEventSpotRate = null;
				LegComplexEventForwardPoints = null;
				LegComplexEventDeterminationMethod = null;
				LegComplexEventCalculationAgent = null;
				LegComplexEventStrikePrice = null;
				LegComplexEventStrikeFactor = null;
				LegComplexEventStrikeNumberOfOptions = null;
				((IFixReset?)LegComplexEventRateSourceGrp)?.Reset();
				((IFixReset?)LegComplexEventRelativeDate)?.Reset();
				((IFixReset?)LegComplexEventPeriodGrp)?.Reset();
				LegComplexEventCreditEventsXIDRef = null;
				LegComplexEventCreditEventNotifyingParty = null;
				LegComplexEventCreditEventBusinessCenter = null;
				LegComplexEventCreditEventStandardSources = null;
				LegComplexEventCreditEventMinimumSources = null;
				((IFixReset?)LegComplexEventCreditEventSourceGrp)?.Reset();
				((IFixReset?)LegComplexEventCreditEventGrp)?.Reset();
				LegComplexEventFuturesPriceValuation = null;
				LegComplexEventOptionsPriceValuation = null;
				LegComplexEventPVFinalPriceElectionFallback = null;
				LegComplexEventXID = null;
				LegComplexEventXIDRef = null;
			}
		}
		[Group(NoOfTag = 2218, Offset = 0, Required = false)]
		public NoLegComplexEvents[]? LegComplexEventsItems {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegComplexEventsItems is not null && LegComplexEventsItems.Length != 0)
			{
				writer.WriteWholeNumber(2218, LegComplexEventsItems.Length);
				for (int i = 0; i < LegComplexEventsItems.Length; i++)
				{
					((IFixEncoder)LegComplexEventsItems[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegComplexEvents") is IMessageView viewNoLegComplexEvents)
			{
				var count = viewNoLegComplexEvents.GroupCount();
				LegComplexEventsItems = new NoLegComplexEvents[count];
				for (int i = 0; i < count; i++)
				{
					LegComplexEventsItems[i] = new();
					((IFixParser)LegComplexEventsItems[i]).Parse(viewNoLegComplexEvents.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegComplexEvents":
				{
					value = LegComplexEventsItems;
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
			LegComplexEventsItems = null;
		}
	}
}
