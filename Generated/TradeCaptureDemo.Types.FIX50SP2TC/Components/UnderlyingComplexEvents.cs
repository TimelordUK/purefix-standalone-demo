using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingComplexEvents : IFixComponent
	{
		public sealed partial class NoUnderlyingComplexEvents : IFixGroup
		{
			[TagDetails(Tag = 2046, Type = TagType.Int, Offset = 0, Required = false)]
			public int? UnderlyingComplexEventType {get; set;}
			
			[TagDetails(Tag = 2261, Type = TagType.Int, Offset = 1, Required = false)]
			public int? UnderlyingComplexOptPayoutPaySide {get; set;}
			
			[TagDetails(Tag = 2262, Type = TagType.Int, Offset = 2, Required = false)]
			public int? UnderlyingComplexOptPayoutReceiveSide {get; set;}
			
			[TagDetails(Tag = 2263, Type = TagType.String, Offset = 3, Required = false)]
			public string? UnderlyingComplexOptPayoutUnderlier {get; set;}
			
			[TagDetails(Tag = 2047, Type = TagType.Float, Offset = 4, Required = false)]
			public double? UnderlyingComplexOptPayoutAmount {get; set;}
			
			[TagDetails(Tag = 2264, Type = TagType.Float, Offset = 5, Required = false)]
			public double? UnderlyingComplexOptPayoutPercentage {get; set;}
			
			[TagDetails(Tag = 2265, Type = TagType.Int, Offset = 6, Required = false)]
			public int? UnderlyingComplexOptPayoutTime {get; set;}
			
			[TagDetails(Tag = 2266, Type = TagType.String, Offset = 7, Required = false)]
			public string? UnderlyingComplexOptPayoutCurrency {get; set;}
			
			[TagDetails(Tag = 2947, Type = TagType.String, Offset = 8, Required = false)]
			public string? UnderlyingComplexOptPayoutCurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 2048, Type = TagType.Float, Offset = 9, Required = false)]
			public double? UnderlyingComplexEventPrice {get; set;}
			
			[TagDetails(Tag = 2267, Type = TagType.Float, Offset = 10, Required = false)]
			public double? UnderlyingComplexEventPricePercentage {get; set;}
			
			[TagDetails(Tag = 2049, Type = TagType.Int, Offset = 11, Required = false)]
			public int? UnderlyingComplexEventPriceBoundaryMethod {get; set;}
			
			[TagDetails(Tag = 2050, Type = TagType.Float, Offset = 12, Required = false)]
			public double? UnderlyingComplexEventPriceBoundaryPrecision {get; set;}
			
			[TagDetails(Tag = 2051, Type = TagType.Int, Offset = 13, Required = false)]
			public int? UnderlyingComplexEventPriceTimeType {get; set;}
			
			[TagDetails(Tag = 2052, Type = TagType.Int, Offset = 14, Required = false)]
			public int? UnderlyingComplexEventCondition {get; set;}
			
			[Component(Offset = 15, Required = false)]
			public UnderlyingComplexEventDates? UnderlyingComplexEventDates {get; set;}
			
			[TagDetails(Tag = 2268, Type = TagType.String, Offset = 16, Required = false)]
			public string? UnderlyingComplexEventCurrencyOne {get; set;}
			
			[TagDetails(Tag = 2948, Type = TagType.String, Offset = 17, Required = false)]
			public string? UnderlyingComplexEventCurrencyOneCodeSource {get; set;}
			
			[TagDetails(Tag = 2269, Type = TagType.String, Offset = 18, Required = false)]
			public string? UnderlyingComplexEventCurrencyTwo {get; set;}
			
			[TagDetails(Tag = 2949, Type = TagType.String, Offset = 19, Required = false)]
			public string? UnderlyingComplexEventCurrencyTwoCodeSource {get; set;}
			
			[TagDetails(Tag = 2270, Type = TagType.Int, Offset = 20, Required = false)]
			public int? UnderlyingComplexEventQuoteBasis {get; set;}
			
			[TagDetails(Tag = 2271, Type = TagType.Float, Offset = 21, Required = false)]
			public double? UnderlyingComplexEventFixedFXRate {get; set;}
			
			[TagDetails(Tag = 2419, Type = TagType.Float, Offset = 22, Required = false)]
			public double? UnderlyingComplexEventSpotRate {get; set;}
			
			[TagDetails(Tag = 2420, Type = TagType.Float, Offset = 23, Required = false)]
			public double? UnderlyingComplexEventForwardPoints {get; set;}
			
			[TagDetails(Tag = 2272, Type = TagType.String, Offset = 24, Required = false)]
			public string? UnderlyingComplexEventDeterminationMethod {get; set;}
			
			[TagDetails(Tag = 2273, Type = TagType.Int, Offset = 25, Required = false)]
			public int? UnderlyingComplexEventCalculationAgent {get; set;}
			
			[TagDetails(Tag = 2274, Type = TagType.Float, Offset = 26, Required = false)]
			public double? UnderlyingComplexEventStrikePrice {get; set;}
			
			[TagDetails(Tag = 2275, Type = TagType.Float, Offset = 27, Required = false)]
			public double? UnderlyingComplexEventStrikeFactor {get; set;}
			
			[TagDetails(Tag = 2276, Type = TagType.Int, Offset = 28, Required = false)]
			public int? UnderlyingComplexEventStrikeNumberOfOptions {get; set;}
			
			[Component(Offset = 29, Required = false)]
			public UnderlyingComplexEventRateSourceGrp? UnderlyingComplexEventRateSourceGrp {get; set;}
			
			[Component(Offset = 30, Required = false)]
			public UnderlyingComplexEventRelativeDate? UnderlyingComplexEventRelativeDate {get; set;}
			
			[Component(Offset = 31, Required = false)]
			public UnderlyingComplexEventPeriodGrp? UnderlyingComplexEventPeriodGrp {get; set;}
			
			[TagDetails(Tag = 2277, Type = TagType.String, Offset = 32, Required = false)]
			public string? UnderlyingComplexEventCreditEventsXIDRef {get; set;}
			
			[TagDetails(Tag = 2278, Type = TagType.Int, Offset = 33, Required = false)]
			public int? UnderlyingComplexEventCreditEventNotifyingParty {get; set;}
			
			[TagDetails(Tag = 2279, Type = TagType.String, Offset = 34, Required = false)]
			public string? UnderlyingComplexEventCreditEventBusinessCenter {get; set;}
			
			[TagDetails(Tag = 2280, Type = TagType.Boolean, Offset = 35, Required = false)]
			public bool? UnderlyingComplexEventCreditEventStandardSources {get; set;}
			
			[TagDetails(Tag = 2281, Type = TagType.Int, Offset = 36, Required = false)]
			public int? UnderlyingComplexEventCreditEventMinimumSources {get; set;}
			
			[Component(Offset = 37, Required = false)]
			public UnderlyingComplexEventCreditEventSourceGrp? UnderlyingComplexEventCreditEventSourceGrp {get; set;}
			
			[Component(Offset = 38, Required = false)]
			public UnderlyingComplexEventCreditEventGrp? UnderlyingComplexEventCreditEventGrp {get; set;}
			
			[TagDetails(Tag = 2611, Type = TagType.Boolean, Offset = 39, Required = false)]
			public bool? UnderlyingComplexEventFuturesPriceValuation {get; set;}
			
			[TagDetails(Tag = 2612, Type = TagType.Boolean, Offset = 40, Required = false)]
			public bool? UnderlyingComplexEventOptionsPriceValuation {get; set;}
			
			[TagDetails(Tag = 2613, Type = TagType.Int, Offset = 41, Required = false)]
			public int? UnderlyingComplexEventPVFinalPriceElectionFallback {get; set;}
			
			[TagDetails(Tag = 2282, Type = TagType.String, Offset = 42, Required = false)]
			public string? UnderlyingComplexEventXID {get; set;}
			
			[TagDetails(Tag = 2283, Type = TagType.String, Offset = 43, Required = false)]
			public string? UnderlyingComplexEventXIDRef {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingComplexEventType is not null) writer.WriteWholeNumber(2046, UnderlyingComplexEventType.Value);
				if (UnderlyingComplexOptPayoutPaySide is not null) writer.WriteWholeNumber(2261, UnderlyingComplexOptPayoutPaySide.Value);
				if (UnderlyingComplexOptPayoutReceiveSide is not null) writer.WriteWholeNumber(2262, UnderlyingComplexOptPayoutReceiveSide.Value);
				if (UnderlyingComplexOptPayoutUnderlier is not null) writer.WriteString(2263, UnderlyingComplexOptPayoutUnderlier);
				if (UnderlyingComplexOptPayoutAmount is not null) writer.WriteNumber(2047, UnderlyingComplexOptPayoutAmount.Value);
				if (UnderlyingComplexOptPayoutPercentage is not null) writer.WriteNumber(2264, UnderlyingComplexOptPayoutPercentage.Value);
				if (UnderlyingComplexOptPayoutTime is not null) writer.WriteWholeNumber(2265, UnderlyingComplexOptPayoutTime.Value);
				if (UnderlyingComplexOptPayoutCurrency is not null) writer.WriteString(2266, UnderlyingComplexOptPayoutCurrency);
				if (UnderlyingComplexOptPayoutCurrencyCodeSource is not null) writer.WriteString(2947, UnderlyingComplexOptPayoutCurrencyCodeSource);
				if (UnderlyingComplexEventPrice is not null) writer.WriteNumber(2048, UnderlyingComplexEventPrice.Value);
				if (UnderlyingComplexEventPricePercentage is not null) writer.WriteNumber(2267, UnderlyingComplexEventPricePercentage.Value);
				if (UnderlyingComplexEventPriceBoundaryMethod is not null) writer.WriteWholeNumber(2049, UnderlyingComplexEventPriceBoundaryMethod.Value);
				if (UnderlyingComplexEventPriceBoundaryPrecision is not null) writer.WriteNumber(2050, UnderlyingComplexEventPriceBoundaryPrecision.Value);
				if (UnderlyingComplexEventPriceTimeType is not null) writer.WriteWholeNumber(2051, UnderlyingComplexEventPriceTimeType.Value);
				if (UnderlyingComplexEventCondition is not null) writer.WriteWholeNumber(2052, UnderlyingComplexEventCondition.Value);
				if (UnderlyingComplexEventDates is not null) ((IFixEncoder)UnderlyingComplexEventDates).Encode(writer);
				if (UnderlyingComplexEventCurrencyOne is not null) writer.WriteString(2268, UnderlyingComplexEventCurrencyOne);
				if (UnderlyingComplexEventCurrencyOneCodeSource is not null) writer.WriteString(2948, UnderlyingComplexEventCurrencyOneCodeSource);
				if (UnderlyingComplexEventCurrencyTwo is not null) writer.WriteString(2269, UnderlyingComplexEventCurrencyTwo);
				if (UnderlyingComplexEventCurrencyTwoCodeSource is not null) writer.WriteString(2949, UnderlyingComplexEventCurrencyTwoCodeSource);
				if (UnderlyingComplexEventQuoteBasis is not null) writer.WriteWholeNumber(2270, UnderlyingComplexEventQuoteBasis.Value);
				if (UnderlyingComplexEventFixedFXRate is not null) writer.WriteNumber(2271, UnderlyingComplexEventFixedFXRate.Value);
				if (UnderlyingComplexEventSpotRate is not null) writer.WriteNumber(2419, UnderlyingComplexEventSpotRate.Value);
				if (UnderlyingComplexEventForwardPoints is not null) writer.WriteNumber(2420, UnderlyingComplexEventForwardPoints.Value);
				if (UnderlyingComplexEventDeterminationMethod is not null) writer.WriteString(2272, UnderlyingComplexEventDeterminationMethod);
				if (UnderlyingComplexEventCalculationAgent is not null) writer.WriteWholeNumber(2273, UnderlyingComplexEventCalculationAgent.Value);
				if (UnderlyingComplexEventStrikePrice is not null) writer.WriteNumber(2274, UnderlyingComplexEventStrikePrice.Value);
				if (UnderlyingComplexEventStrikeFactor is not null) writer.WriteNumber(2275, UnderlyingComplexEventStrikeFactor.Value);
				if (UnderlyingComplexEventStrikeNumberOfOptions is not null) writer.WriteWholeNumber(2276, UnderlyingComplexEventStrikeNumberOfOptions.Value);
				if (UnderlyingComplexEventRateSourceGrp is not null) ((IFixEncoder)UnderlyingComplexEventRateSourceGrp).Encode(writer);
				if (UnderlyingComplexEventRelativeDate is not null) ((IFixEncoder)UnderlyingComplexEventRelativeDate).Encode(writer);
				if (UnderlyingComplexEventPeriodGrp is not null) ((IFixEncoder)UnderlyingComplexEventPeriodGrp).Encode(writer);
				if (UnderlyingComplexEventCreditEventsXIDRef is not null) writer.WriteString(2277, UnderlyingComplexEventCreditEventsXIDRef);
				if (UnderlyingComplexEventCreditEventNotifyingParty is not null) writer.WriteWholeNumber(2278, UnderlyingComplexEventCreditEventNotifyingParty.Value);
				if (UnderlyingComplexEventCreditEventBusinessCenter is not null) writer.WriteString(2279, UnderlyingComplexEventCreditEventBusinessCenter);
				if (UnderlyingComplexEventCreditEventStandardSources is not null) writer.WriteBoolean(2280, UnderlyingComplexEventCreditEventStandardSources.Value);
				if (UnderlyingComplexEventCreditEventMinimumSources is not null) writer.WriteWholeNumber(2281, UnderlyingComplexEventCreditEventMinimumSources.Value);
				if (UnderlyingComplexEventCreditEventSourceGrp is not null) ((IFixEncoder)UnderlyingComplexEventCreditEventSourceGrp).Encode(writer);
				if (UnderlyingComplexEventCreditEventGrp is not null) ((IFixEncoder)UnderlyingComplexEventCreditEventGrp).Encode(writer);
				if (UnderlyingComplexEventFuturesPriceValuation is not null) writer.WriteBoolean(2611, UnderlyingComplexEventFuturesPriceValuation.Value);
				if (UnderlyingComplexEventOptionsPriceValuation is not null) writer.WriteBoolean(2612, UnderlyingComplexEventOptionsPriceValuation.Value);
				if (UnderlyingComplexEventPVFinalPriceElectionFallback is not null) writer.WriteWholeNumber(2613, UnderlyingComplexEventPVFinalPriceElectionFallback.Value);
				if (UnderlyingComplexEventXID is not null) writer.WriteString(2282, UnderlyingComplexEventXID);
				if (UnderlyingComplexEventXIDRef is not null) writer.WriteString(2283, UnderlyingComplexEventXIDRef);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingComplexEventType = view.GetInt32(2046);
				UnderlyingComplexOptPayoutPaySide = view.GetInt32(2261);
				UnderlyingComplexOptPayoutReceiveSide = view.GetInt32(2262);
				UnderlyingComplexOptPayoutUnderlier = view.GetString(2263);
				UnderlyingComplexOptPayoutAmount = view.GetDouble(2047);
				UnderlyingComplexOptPayoutPercentage = view.GetDouble(2264);
				UnderlyingComplexOptPayoutTime = view.GetInt32(2265);
				UnderlyingComplexOptPayoutCurrency = view.GetString(2266);
				UnderlyingComplexOptPayoutCurrencyCodeSource = view.GetString(2947);
				UnderlyingComplexEventPrice = view.GetDouble(2048);
				UnderlyingComplexEventPricePercentage = view.GetDouble(2267);
				UnderlyingComplexEventPriceBoundaryMethod = view.GetInt32(2049);
				UnderlyingComplexEventPriceBoundaryPrecision = view.GetDouble(2050);
				UnderlyingComplexEventPriceTimeType = view.GetInt32(2051);
				UnderlyingComplexEventCondition = view.GetInt32(2052);
				if (view.GetView("UnderlyingComplexEventDates") is IMessageView viewUnderlyingComplexEventDates)
				{
					UnderlyingComplexEventDates = new();
					((IFixParser)UnderlyingComplexEventDates).Parse(viewUnderlyingComplexEventDates);
				}
				UnderlyingComplexEventCurrencyOne = view.GetString(2268);
				UnderlyingComplexEventCurrencyOneCodeSource = view.GetString(2948);
				UnderlyingComplexEventCurrencyTwo = view.GetString(2269);
				UnderlyingComplexEventCurrencyTwoCodeSource = view.GetString(2949);
				UnderlyingComplexEventQuoteBasis = view.GetInt32(2270);
				UnderlyingComplexEventFixedFXRate = view.GetDouble(2271);
				UnderlyingComplexEventSpotRate = view.GetDouble(2419);
				UnderlyingComplexEventForwardPoints = view.GetDouble(2420);
				UnderlyingComplexEventDeterminationMethod = view.GetString(2272);
				UnderlyingComplexEventCalculationAgent = view.GetInt32(2273);
				UnderlyingComplexEventStrikePrice = view.GetDouble(2274);
				UnderlyingComplexEventStrikeFactor = view.GetDouble(2275);
				UnderlyingComplexEventStrikeNumberOfOptions = view.GetInt32(2276);
				if (view.GetView("UnderlyingComplexEventRateSourceGrp") is IMessageView viewUnderlyingComplexEventRateSourceGrp)
				{
					UnderlyingComplexEventRateSourceGrp = new();
					((IFixParser)UnderlyingComplexEventRateSourceGrp).Parse(viewUnderlyingComplexEventRateSourceGrp);
				}
				if (view.GetView("UnderlyingComplexEventRelativeDate") is IMessageView viewUnderlyingComplexEventRelativeDate)
				{
					UnderlyingComplexEventRelativeDate = new();
					((IFixParser)UnderlyingComplexEventRelativeDate).Parse(viewUnderlyingComplexEventRelativeDate);
				}
				if (view.GetView("UnderlyingComplexEventPeriodGrp") is IMessageView viewUnderlyingComplexEventPeriodGrp)
				{
					UnderlyingComplexEventPeriodGrp = new();
					((IFixParser)UnderlyingComplexEventPeriodGrp).Parse(viewUnderlyingComplexEventPeriodGrp);
				}
				UnderlyingComplexEventCreditEventsXIDRef = view.GetString(2277);
				UnderlyingComplexEventCreditEventNotifyingParty = view.GetInt32(2278);
				UnderlyingComplexEventCreditEventBusinessCenter = view.GetString(2279);
				UnderlyingComplexEventCreditEventStandardSources = view.GetBool(2280);
				UnderlyingComplexEventCreditEventMinimumSources = view.GetInt32(2281);
				if (view.GetView("UnderlyingComplexEventCreditEventSourceGrp") is IMessageView viewUnderlyingComplexEventCreditEventSourceGrp)
				{
					UnderlyingComplexEventCreditEventSourceGrp = new();
					((IFixParser)UnderlyingComplexEventCreditEventSourceGrp).Parse(viewUnderlyingComplexEventCreditEventSourceGrp);
				}
				if (view.GetView("UnderlyingComplexEventCreditEventGrp") is IMessageView viewUnderlyingComplexEventCreditEventGrp)
				{
					UnderlyingComplexEventCreditEventGrp = new();
					((IFixParser)UnderlyingComplexEventCreditEventGrp).Parse(viewUnderlyingComplexEventCreditEventGrp);
				}
				UnderlyingComplexEventFuturesPriceValuation = view.GetBool(2611);
				UnderlyingComplexEventOptionsPriceValuation = view.GetBool(2612);
				UnderlyingComplexEventPVFinalPriceElectionFallback = view.GetInt32(2613);
				UnderlyingComplexEventXID = view.GetString(2282);
				UnderlyingComplexEventXIDRef = view.GetString(2283);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingComplexEventType":
					{
						value = UnderlyingComplexEventType;
						break;
					}
					case "UnderlyingComplexOptPayoutPaySide":
					{
						value = UnderlyingComplexOptPayoutPaySide;
						break;
					}
					case "UnderlyingComplexOptPayoutReceiveSide":
					{
						value = UnderlyingComplexOptPayoutReceiveSide;
						break;
					}
					case "UnderlyingComplexOptPayoutUnderlier":
					{
						value = UnderlyingComplexOptPayoutUnderlier;
						break;
					}
					case "UnderlyingComplexOptPayoutAmount":
					{
						value = UnderlyingComplexOptPayoutAmount;
						break;
					}
					case "UnderlyingComplexOptPayoutPercentage":
					{
						value = UnderlyingComplexOptPayoutPercentage;
						break;
					}
					case "UnderlyingComplexOptPayoutTime":
					{
						value = UnderlyingComplexOptPayoutTime;
						break;
					}
					case "UnderlyingComplexOptPayoutCurrency":
					{
						value = UnderlyingComplexOptPayoutCurrency;
						break;
					}
					case "UnderlyingComplexOptPayoutCurrencyCodeSource":
					{
						value = UnderlyingComplexOptPayoutCurrencyCodeSource;
						break;
					}
					case "UnderlyingComplexEventPrice":
					{
						value = UnderlyingComplexEventPrice;
						break;
					}
					case "UnderlyingComplexEventPricePercentage":
					{
						value = UnderlyingComplexEventPricePercentage;
						break;
					}
					case "UnderlyingComplexEventPriceBoundaryMethod":
					{
						value = UnderlyingComplexEventPriceBoundaryMethod;
						break;
					}
					case "UnderlyingComplexEventPriceBoundaryPrecision":
					{
						value = UnderlyingComplexEventPriceBoundaryPrecision;
						break;
					}
					case "UnderlyingComplexEventPriceTimeType":
					{
						value = UnderlyingComplexEventPriceTimeType;
						break;
					}
					case "UnderlyingComplexEventCondition":
					{
						value = UnderlyingComplexEventCondition;
						break;
					}
					case "UnderlyingComplexEventDates":
					{
						value = UnderlyingComplexEventDates;
						break;
					}
					case "UnderlyingComplexEventCurrencyOne":
					{
						value = UnderlyingComplexEventCurrencyOne;
						break;
					}
					case "UnderlyingComplexEventCurrencyOneCodeSource":
					{
						value = UnderlyingComplexEventCurrencyOneCodeSource;
						break;
					}
					case "UnderlyingComplexEventCurrencyTwo":
					{
						value = UnderlyingComplexEventCurrencyTwo;
						break;
					}
					case "UnderlyingComplexEventCurrencyTwoCodeSource":
					{
						value = UnderlyingComplexEventCurrencyTwoCodeSource;
						break;
					}
					case "UnderlyingComplexEventQuoteBasis":
					{
						value = UnderlyingComplexEventQuoteBasis;
						break;
					}
					case "UnderlyingComplexEventFixedFXRate":
					{
						value = UnderlyingComplexEventFixedFXRate;
						break;
					}
					case "UnderlyingComplexEventSpotRate":
					{
						value = UnderlyingComplexEventSpotRate;
						break;
					}
					case "UnderlyingComplexEventForwardPoints":
					{
						value = UnderlyingComplexEventForwardPoints;
						break;
					}
					case "UnderlyingComplexEventDeterminationMethod":
					{
						value = UnderlyingComplexEventDeterminationMethod;
						break;
					}
					case "UnderlyingComplexEventCalculationAgent":
					{
						value = UnderlyingComplexEventCalculationAgent;
						break;
					}
					case "UnderlyingComplexEventStrikePrice":
					{
						value = UnderlyingComplexEventStrikePrice;
						break;
					}
					case "UnderlyingComplexEventStrikeFactor":
					{
						value = UnderlyingComplexEventStrikeFactor;
						break;
					}
					case "UnderlyingComplexEventStrikeNumberOfOptions":
					{
						value = UnderlyingComplexEventStrikeNumberOfOptions;
						break;
					}
					case "UnderlyingComplexEventRateSourceGrp":
					{
						value = UnderlyingComplexEventRateSourceGrp;
						break;
					}
					case "UnderlyingComplexEventRelativeDate":
					{
						value = UnderlyingComplexEventRelativeDate;
						break;
					}
					case "UnderlyingComplexEventPeriodGrp":
					{
						value = UnderlyingComplexEventPeriodGrp;
						break;
					}
					case "UnderlyingComplexEventCreditEventsXIDRef":
					{
						value = UnderlyingComplexEventCreditEventsXIDRef;
						break;
					}
					case "UnderlyingComplexEventCreditEventNotifyingParty":
					{
						value = UnderlyingComplexEventCreditEventNotifyingParty;
						break;
					}
					case "UnderlyingComplexEventCreditEventBusinessCenter":
					{
						value = UnderlyingComplexEventCreditEventBusinessCenter;
						break;
					}
					case "UnderlyingComplexEventCreditEventStandardSources":
					{
						value = UnderlyingComplexEventCreditEventStandardSources;
						break;
					}
					case "UnderlyingComplexEventCreditEventMinimumSources":
					{
						value = UnderlyingComplexEventCreditEventMinimumSources;
						break;
					}
					case "UnderlyingComplexEventCreditEventSourceGrp":
					{
						value = UnderlyingComplexEventCreditEventSourceGrp;
						break;
					}
					case "UnderlyingComplexEventCreditEventGrp":
					{
						value = UnderlyingComplexEventCreditEventGrp;
						break;
					}
					case "UnderlyingComplexEventFuturesPriceValuation":
					{
						value = UnderlyingComplexEventFuturesPriceValuation;
						break;
					}
					case "UnderlyingComplexEventOptionsPriceValuation":
					{
						value = UnderlyingComplexEventOptionsPriceValuation;
						break;
					}
					case "UnderlyingComplexEventPVFinalPriceElectionFallback":
					{
						value = UnderlyingComplexEventPVFinalPriceElectionFallback;
						break;
					}
					case "UnderlyingComplexEventXID":
					{
						value = UnderlyingComplexEventXID;
						break;
					}
					case "UnderlyingComplexEventXIDRef":
					{
						value = UnderlyingComplexEventXIDRef;
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
				UnderlyingComplexEventType = null;
				UnderlyingComplexOptPayoutPaySide = null;
				UnderlyingComplexOptPayoutReceiveSide = null;
				UnderlyingComplexOptPayoutUnderlier = null;
				UnderlyingComplexOptPayoutAmount = null;
				UnderlyingComplexOptPayoutPercentage = null;
				UnderlyingComplexOptPayoutTime = null;
				UnderlyingComplexOptPayoutCurrency = null;
				UnderlyingComplexOptPayoutCurrencyCodeSource = null;
				UnderlyingComplexEventPrice = null;
				UnderlyingComplexEventPricePercentage = null;
				UnderlyingComplexEventPriceBoundaryMethod = null;
				UnderlyingComplexEventPriceBoundaryPrecision = null;
				UnderlyingComplexEventPriceTimeType = null;
				UnderlyingComplexEventCondition = null;
				((IFixReset?)UnderlyingComplexEventDates)?.Reset();
				UnderlyingComplexEventCurrencyOne = null;
				UnderlyingComplexEventCurrencyOneCodeSource = null;
				UnderlyingComplexEventCurrencyTwo = null;
				UnderlyingComplexEventCurrencyTwoCodeSource = null;
				UnderlyingComplexEventQuoteBasis = null;
				UnderlyingComplexEventFixedFXRate = null;
				UnderlyingComplexEventSpotRate = null;
				UnderlyingComplexEventForwardPoints = null;
				UnderlyingComplexEventDeterminationMethod = null;
				UnderlyingComplexEventCalculationAgent = null;
				UnderlyingComplexEventStrikePrice = null;
				UnderlyingComplexEventStrikeFactor = null;
				UnderlyingComplexEventStrikeNumberOfOptions = null;
				((IFixReset?)UnderlyingComplexEventRateSourceGrp)?.Reset();
				((IFixReset?)UnderlyingComplexEventRelativeDate)?.Reset();
				((IFixReset?)UnderlyingComplexEventPeriodGrp)?.Reset();
				UnderlyingComplexEventCreditEventsXIDRef = null;
				UnderlyingComplexEventCreditEventNotifyingParty = null;
				UnderlyingComplexEventCreditEventBusinessCenter = null;
				UnderlyingComplexEventCreditEventStandardSources = null;
				UnderlyingComplexEventCreditEventMinimumSources = null;
				((IFixReset?)UnderlyingComplexEventCreditEventSourceGrp)?.Reset();
				((IFixReset?)UnderlyingComplexEventCreditEventGrp)?.Reset();
				UnderlyingComplexEventFuturesPriceValuation = null;
				UnderlyingComplexEventOptionsPriceValuation = null;
				UnderlyingComplexEventPVFinalPriceElectionFallback = null;
				UnderlyingComplexEventXID = null;
				UnderlyingComplexEventXIDRef = null;
			}
		}
		[Group(NoOfTag = 2045, Offset = 0, Required = false)]
		public NoUnderlyingComplexEvents[]? UnderlyingComplexEventsItems {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingComplexEventsItems is not null && UnderlyingComplexEventsItems.Length != 0)
			{
				writer.WriteWholeNumber(2045, UnderlyingComplexEventsItems.Length);
				for (int i = 0; i < UnderlyingComplexEventsItems.Length; i++)
				{
					((IFixEncoder)UnderlyingComplexEventsItems[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingComplexEvents") is IMessageView viewNoUnderlyingComplexEvents)
			{
				var count = viewNoUnderlyingComplexEvents.GroupCount();
				UnderlyingComplexEventsItems = new NoUnderlyingComplexEvents[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingComplexEventsItems[i] = new();
					((IFixParser)UnderlyingComplexEventsItems[i]).Parse(viewNoUnderlyingComplexEvents.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingComplexEvents":
				{
					value = UnderlyingComplexEventsItems;
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
			UnderlyingComplexEventsItems = null;
		}
	}
}
