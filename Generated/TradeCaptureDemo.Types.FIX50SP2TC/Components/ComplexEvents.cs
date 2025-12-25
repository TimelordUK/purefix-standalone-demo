using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ComplexEvents : IFixComponent
	{
		public sealed partial class NoComplexEvents : IFixGroup
		{
			[TagDetails(Tag = 1484, Type = TagType.Int, Offset = 0, Required = false)]
			public int? ComplexEventType {get; set;}
			
			[TagDetails(Tag = 2117, Type = TagType.Int, Offset = 1, Required = false)]
			public int? ComplexOptPayoutPaySide {get; set;}
			
			[TagDetails(Tag = 2118, Type = TagType.Int, Offset = 2, Required = false)]
			public int? ComplexOptPayoutReceiveSide {get; set;}
			
			[TagDetails(Tag = 2119, Type = TagType.String, Offset = 3, Required = false)]
			public string? ComplexOptPayoutUnderlier {get; set;}
			
			[TagDetails(Tag = 1485, Type = TagType.Float, Offset = 4, Required = false)]
			public double? ComplexOptPayoutAmount {get; set;}
			
			[TagDetails(Tag = 2120, Type = TagType.Float, Offset = 5, Required = false)]
			public double? ComplexOptPayoutPercentage {get; set;}
			
			[TagDetails(Tag = 2121, Type = TagType.Int, Offset = 6, Required = false)]
			public int? ComplexOptPayoutTime {get; set;}
			
			[TagDetails(Tag = 2122, Type = TagType.String, Offset = 7, Required = false)]
			public string? ComplexOptPayoutCurrency {get; set;}
			
			[TagDetails(Tag = 2941, Type = TagType.String, Offset = 8, Required = false)]
			public string? ComplexOptPayoutCurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 1486, Type = TagType.Float, Offset = 9, Required = false)]
			public double? ComplexEventPrice {get; set;}
			
			[TagDetails(Tag = 2123, Type = TagType.Float, Offset = 10, Required = false)]
			public double? ComplexEventPricePercentage {get; set;}
			
			[TagDetails(Tag = 1487, Type = TagType.Int, Offset = 11, Required = false)]
			public int? ComplexEventPriceBoundaryMethod {get; set;}
			
			[TagDetails(Tag = 1488, Type = TagType.Float, Offset = 12, Required = false)]
			public double? ComplexEventPriceBoundaryPrecision {get; set;}
			
			[TagDetails(Tag = 1489, Type = TagType.Int, Offset = 13, Required = false)]
			public int? ComplexEventPriceTimeType {get; set;}
			
			[TagDetails(Tag = 1490, Type = TagType.Int, Offset = 14, Required = false)]
			public int? ComplexEventCondition {get; set;}
			
			[Component(Offset = 15, Required = false)]
			public ComplexEventDates? ComplexEventDates {get; set;}
			
			[TagDetails(Tag = 2124, Type = TagType.String, Offset = 16, Required = false)]
			public string? ComplexEventCurrencyOne {get; set;}
			
			[TagDetails(Tag = 2942, Type = TagType.String, Offset = 17, Required = false)]
			public string? ComplexEventCurrencyOneCodeSource {get; set;}
			
			[TagDetails(Tag = 2125, Type = TagType.String, Offset = 18, Required = false)]
			public string? ComplexEventCurrencyTwo {get; set;}
			
			[TagDetails(Tag = 2943, Type = TagType.String, Offset = 19, Required = false)]
			public string? ComplexEventCurrencyTwoCodeSource {get; set;}
			
			[TagDetails(Tag = 2126, Type = TagType.Int, Offset = 20, Required = false)]
			public int? ComplexEventQuoteBasis {get; set;}
			
			[TagDetails(Tag = 2127, Type = TagType.Float, Offset = 21, Required = false)]
			public double? ComplexEventFixedFXRate {get; set;}
			
			[TagDetails(Tag = 2407, Type = TagType.Float, Offset = 22, Required = false)]
			public double? ComplexEventSpotRate {get; set;}
			
			[TagDetails(Tag = 2408, Type = TagType.Float, Offset = 23, Required = false)]
			public double? ComplexEventForwardPoints {get; set;}
			
			[TagDetails(Tag = 2128, Type = TagType.String, Offset = 24, Required = false)]
			public string? ComplexEventDeterminationMethod {get; set;}
			
			[TagDetails(Tag = 2129, Type = TagType.Int, Offset = 25, Required = false)]
			public int? ComplexEventCalculationAgent {get; set;}
			
			[TagDetails(Tag = 2130, Type = TagType.Float, Offset = 26, Required = false)]
			public double? ComplexEventStrikePrice {get; set;}
			
			[TagDetails(Tag = 2131, Type = TagType.Float, Offset = 27, Required = false)]
			public double? ComplexEventStrikeFactor {get; set;}
			
			[TagDetails(Tag = 2132, Type = TagType.Int, Offset = 28, Required = false)]
			public int? ComplexEventStrikeNumberOfOptions {get; set;}
			
			[Component(Offset = 29, Required = false)]
			public ComplexEventRateSourceGrp? ComplexEventRateSourceGrp {get; set;}
			
			[Component(Offset = 30, Required = false)]
			public ComplexEventRelativeDate? ComplexEventRelativeDate {get; set;}
			
			[Component(Offset = 31, Required = false)]
			public ComplexEventPeriodGrp? ComplexEventPeriodGrp {get; set;}
			
			[TagDetails(Tag = 2133, Type = TagType.String, Offset = 32, Required = false)]
			public string? ComplexEventCreditEventsXIDRef {get; set;}
			
			[TagDetails(Tag = 2134, Type = TagType.Int, Offset = 33, Required = false)]
			public int? ComplexEventCreditEventNotifyingParty {get; set;}
			
			[TagDetails(Tag = 2135, Type = TagType.String, Offset = 34, Required = false)]
			public string? ComplexEventCreditEventBusinessCenter {get; set;}
			
			[TagDetails(Tag = 2136, Type = TagType.Boolean, Offset = 35, Required = false)]
			public bool? ComplexEventCreditEventStandardSources {get; set;}
			
			[TagDetails(Tag = 2137, Type = TagType.Int, Offset = 36, Required = false)]
			public int? ComplexEventCreditEventMinimumSources {get; set;}
			
			[Component(Offset = 37, Required = false)]
			public ComplexEventCreditEventSourceGrp? ComplexEventCreditEventSourceGrp {get; set;}
			
			[Component(Offset = 38, Required = false)]
			public ComplexEventCreditEventGrp? ComplexEventCreditEventGrp {get; set;}
			
			[TagDetails(Tag = 2597, Type = TagType.Boolean, Offset = 39, Required = false)]
			public bool? ComplexEventFuturesPriceValuation {get; set;}
			
			[TagDetails(Tag = 2598, Type = TagType.Boolean, Offset = 40, Required = false)]
			public bool? ComplexEventOptionsPriceValuation {get; set;}
			
			[TagDetails(Tag = 2599, Type = TagType.Int, Offset = 41, Required = false)]
			public int? ComplexEventPVFinalPriceElectionFallback {get; set;}
			
			[TagDetails(Tag = 2138, Type = TagType.String, Offset = 42, Required = false)]
			public string? ComplexEventXID {get; set;}
			
			[TagDetails(Tag = 2139, Type = TagType.String, Offset = 43, Required = false)]
			public string? ComplexEventXIDRef {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ComplexEventType is not null) writer.WriteWholeNumber(1484, ComplexEventType.Value);
				if (ComplexOptPayoutPaySide is not null) writer.WriteWholeNumber(2117, ComplexOptPayoutPaySide.Value);
				if (ComplexOptPayoutReceiveSide is not null) writer.WriteWholeNumber(2118, ComplexOptPayoutReceiveSide.Value);
				if (ComplexOptPayoutUnderlier is not null) writer.WriteString(2119, ComplexOptPayoutUnderlier);
				if (ComplexOptPayoutAmount is not null) writer.WriteNumber(1485, ComplexOptPayoutAmount.Value);
				if (ComplexOptPayoutPercentage is not null) writer.WriteNumber(2120, ComplexOptPayoutPercentage.Value);
				if (ComplexOptPayoutTime is not null) writer.WriteWholeNumber(2121, ComplexOptPayoutTime.Value);
				if (ComplexOptPayoutCurrency is not null) writer.WriteString(2122, ComplexOptPayoutCurrency);
				if (ComplexOptPayoutCurrencyCodeSource is not null) writer.WriteString(2941, ComplexOptPayoutCurrencyCodeSource);
				if (ComplexEventPrice is not null) writer.WriteNumber(1486, ComplexEventPrice.Value);
				if (ComplexEventPricePercentage is not null) writer.WriteNumber(2123, ComplexEventPricePercentage.Value);
				if (ComplexEventPriceBoundaryMethod is not null) writer.WriteWholeNumber(1487, ComplexEventPriceBoundaryMethod.Value);
				if (ComplexEventPriceBoundaryPrecision is not null) writer.WriteNumber(1488, ComplexEventPriceBoundaryPrecision.Value);
				if (ComplexEventPriceTimeType is not null) writer.WriteWholeNumber(1489, ComplexEventPriceTimeType.Value);
				if (ComplexEventCondition is not null) writer.WriteWholeNumber(1490, ComplexEventCondition.Value);
				if (ComplexEventDates is not null) ((IFixEncoder)ComplexEventDates).Encode(writer);
				if (ComplexEventCurrencyOne is not null) writer.WriteString(2124, ComplexEventCurrencyOne);
				if (ComplexEventCurrencyOneCodeSource is not null) writer.WriteString(2942, ComplexEventCurrencyOneCodeSource);
				if (ComplexEventCurrencyTwo is not null) writer.WriteString(2125, ComplexEventCurrencyTwo);
				if (ComplexEventCurrencyTwoCodeSource is not null) writer.WriteString(2943, ComplexEventCurrencyTwoCodeSource);
				if (ComplexEventQuoteBasis is not null) writer.WriteWholeNumber(2126, ComplexEventQuoteBasis.Value);
				if (ComplexEventFixedFXRate is not null) writer.WriteNumber(2127, ComplexEventFixedFXRate.Value);
				if (ComplexEventSpotRate is not null) writer.WriteNumber(2407, ComplexEventSpotRate.Value);
				if (ComplexEventForwardPoints is not null) writer.WriteNumber(2408, ComplexEventForwardPoints.Value);
				if (ComplexEventDeterminationMethod is not null) writer.WriteString(2128, ComplexEventDeterminationMethod);
				if (ComplexEventCalculationAgent is not null) writer.WriteWholeNumber(2129, ComplexEventCalculationAgent.Value);
				if (ComplexEventStrikePrice is not null) writer.WriteNumber(2130, ComplexEventStrikePrice.Value);
				if (ComplexEventStrikeFactor is not null) writer.WriteNumber(2131, ComplexEventStrikeFactor.Value);
				if (ComplexEventStrikeNumberOfOptions is not null) writer.WriteWholeNumber(2132, ComplexEventStrikeNumberOfOptions.Value);
				if (ComplexEventRateSourceGrp is not null) ((IFixEncoder)ComplexEventRateSourceGrp).Encode(writer);
				if (ComplexEventRelativeDate is not null) ((IFixEncoder)ComplexEventRelativeDate).Encode(writer);
				if (ComplexEventPeriodGrp is not null) ((IFixEncoder)ComplexEventPeriodGrp).Encode(writer);
				if (ComplexEventCreditEventsXIDRef is not null) writer.WriteString(2133, ComplexEventCreditEventsXIDRef);
				if (ComplexEventCreditEventNotifyingParty is not null) writer.WriteWholeNumber(2134, ComplexEventCreditEventNotifyingParty.Value);
				if (ComplexEventCreditEventBusinessCenter is not null) writer.WriteString(2135, ComplexEventCreditEventBusinessCenter);
				if (ComplexEventCreditEventStandardSources is not null) writer.WriteBoolean(2136, ComplexEventCreditEventStandardSources.Value);
				if (ComplexEventCreditEventMinimumSources is not null) writer.WriteWholeNumber(2137, ComplexEventCreditEventMinimumSources.Value);
				if (ComplexEventCreditEventSourceGrp is not null) ((IFixEncoder)ComplexEventCreditEventSourceGrp).Encode(writer);
				if (ComplexEventCreditEventGrp is not null) ((IFixEncoder)ComplexEventCreditEventGrp).Encode(writer);
				if (ComplexEventFuturesPriceValuation is not null) writer.WriteBoolean(2597, ComplexEventFuturesPriceValuation.Value);
				if (ComplexEventOptionsPriceValuation is not null) writer.WriteBoolean(2598, ComplexEventOptionsPriceValuation.Value);
				if (ComplexEventPVFinalPriceElectionFallback is not null) writer.WriteWholeNumber(2599, ComplexEventPVFinalPriceElectionFallback.Value);
				if (ComplexEventXID is not null) writer.WriteString(2138, ComplexEventXID);
				if (ComplexEventXIDRef is not null) writer.WriteString(2139, ComplexEventXIDRef);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ComplexEventType = view.GetInt32(1484);
				ComplexOptPayoutPaySide = view.GetInt32(2117);
				ComplexOptPayoutReceiveSide = view.GetInt32(2118);
				ComplexOptPayoutUnderlier = view.GetString(2119);
				ComplexOptPayoutAmount = view.GetDouble(1485);
				ComplexOptPayoutPercentage = view.GetDouble(2120);
				ComplexOptPayoutTime = view.GetInt32(2121);
				ComplexOptPayoutCurrency = view.GetString(2122);
				ComplexOptPayoutCurrencyCodeSource = view.GetString(2941);
				ComplexEventPrice = view.GetDouble(1486);
				ComplexEventPricePercentage = view.GetDouble(2123);
				ComplexEventPriceBoundaryMethod = view.GetInt32(1487);
				ComplexEventPriceBoundaryPrecision = view.GetDouble(1488);
				ComplexEventPriceTimeType = view.GetInt32(1489);
				ComplexEventCondition = view.GetInt32(1490);
				if (view.GetView("ComplexEventDates") is IMessageView viewComplexEventDates)
				{
					ComplexEventDates = new();
					((IFixParser)ComplexEventDates).Parse(viewComplexEventDates);
				}
				ComplexEventCurrencyOne = view.GetString(2124);
				ComplexEventCurrencyOneCodeSource = view.GetString(2942);
				ComplexEventCurrencyTwo = view.GetString(2125);
				ComplexEventCurrencyTwoCodeSource = view.GetString(2943);
				ComplexEventQuoteBasis = view.GetInt32(2126);
				ComplexEventFixedFXRate = view.GetDouble(2127);
				ComplexEventSpotRate = view.GetDouble(2407);
				ComplexEventForwardPoints = view.GetDouble(2408);
				ComplexEventDeterminationMethod = view.GetString(2128);
				ComplexEventCalculationAgent = view.GetInt32(2129);
				ComplexEventStrikePrice = view.GetDouble(2130);
				ComplexEventStrikeFactor = view.GetDouble(2131);
				ComplexEventStrikeNumberOfOptions = view.GetInt32(2132);
				if (view.GetView("ComplexEventRateSourceGrp") is IMessageView viewComplexEventRateSourceGrp)
				{
					ComplexEventRateSourceGrp = new();
					((IFixParser)ComplexEventRateSourceGrp).Parse(viewComplexEventRateSourceGrp);
				}
				if (view.GetView("ComplexEventRelativeDate") is IMessageView viewComplexEventRelativeDate)
				{
					ComplexEventRelativeDate = new();
					((IFixParser)ComplexEventRelativeDate).Parse(viewComplexEventRelativeDate);
				}
				if (view.GetView("ComplexEventPeriodGrp") is IMessageView viewComplexEventPeriodGrp)
				{
					ComplexEventPeriodGrp = new();
					((IFixParser)ComplexEventPeriodGrp).Parse(viewComplexEventPeriodGrp);
				}
				ComplexEventCreditEventsXIDRef = view.GetString(2133);
				ComplexEventCreditEventNotifyingParty = view.GetInt32(2134);
				ComplexEventCreditEventBusinessCenter = view.GetString(2135);
				ComplexEventCreditEventStandardSources = view.GetBool(2136);
				ComplexEventCreditEventMinimumSources = view.GetInt32(2137);
				if (view.GetView("ComplexEventCreditEventSourceGrp") is IMessageView viewComplexEventCreditEventSourceGrp)
				{
					ComplexEventCreditEventSourceGrp = new();
					((IFixParser)ComplexEventCreditEventSourceGrp).Parse(viewComplexEventCreditEventSourceGrp);
				}
				if (view.GetView("ComplexEventCreditEventGrp") is IMessageView viewComplexEventCreditEventGrp)
				{
					ComplexEventCreditEventGrp = new();
					((IFixParser)ComplexEventCreditEventGrp).Parse(viewComplexEventCreditEventGrp);
				}
				ComplexEventFuturesPriceValuation = view.GetBool(2597);
				ComplexEventOptionsPriceValuation = view.GetBool(2598);
				ComplexEventPVFinalPriceElectionFallback = view.GetInt32(2599);
				ComplexEventXID = view.GetString(2138);
				ComplexEventXIDRef = view.GetString(2139);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ComplexEventType":
					{
						value = ComplexEventType;
						break;
					}
					case "ComplexOptPayoutPaySide":
					{
						value = ComplexOptPayoutPaySide;
						break;
					}
					case "ComplexOptPayoutReceiveSide":
					{
						value = ComplexOptPayoutReceiveSide;
						break;
					}
					case "ComplexOptPayoutUnderlier":
					{
						value = ComplexOptPayoutUnderlier;
						break;
					}
					case "ComplexOptPayoutAmount":
					{
						value = ComplexOptPayoutAmount;
						break;
					}
					case "ComplexOptPayoutPercentage":
					{
						value = ComplexOptPayoutPercentage;
						break;
					}
					case "ComplexOptPayoutTime":
					{
						value = ComplexOptPayoutTime;
						break;
					}
					case "ComplexOptPayoutCurrency":
					{
						value = ComplexOptPayoutCurrency;
						break;
					}
					case "ComplexOptPayoutCurrencyCodeSource":
					{
						value = ComplexOptPayoutCurrencyCodeSource;
						break;
					}
					case "ComplexEventPrice":
					{
						value = ComplexEventPrice;
						break;
					}
					case "ComplexEventPricePercentage":
					{
						value = ComplexEventPricePercentage;
						break;
					}
					case "ComplexEventPriceBoundaryMethod":
					{
						value = ComplexEventPriceBoundaryMethod;
						break;
					}
					case "ComplexEventPriceBoundaryPrecision":
					{
						value = ComplexEventPriceBoundaryPrecision;
						break;
					}
					case "ComplexEventPriceTimeType":
					{
						value = ComplexEventPriceTimeType;
						break;
					}
					case "ComplexEventCondition":
					{
						value = ComplexEventCondition;
						break;
					}
					case "ComplexEventDates":
					{
						value = ComplexEventDates;
						break;
					}
					case "ComplexEventCurrencyOne":
					{
						value = ComplexEventCurrencyOne;
						break;
					}
					case "ComplexEventCurrencyOneCodeSource":
					{
						value = ComplexEventCurrencyOneCodeSource;
						break;
					}
					case "ComplexEventCurrencyTwo":
					{
						value = ComplexEventCurrencyTwo;
						break;
					}
					case "ComplexEventCurrencyTwoCodeSource":
					{
						value = ComplexEventCurrencyTwoCodeSource;
						break;
					}
					case "ComplexEventQuoteBasis":
					{
						value = ComplexEventQuoteBasis;
						break;
					}
					case "ComplexEventFixedFXRate":
					{
						value = ComplexEventFixedFXRate;
						break;
					}
					case "ComplexEventSpotRate":
					{
						value = ComplexEventSpotRate;
						break;
					}
					case "ComplexEventForwardPoints":
					{
						value = ComplexEventForwardPoints;
						break;
					}
					case "ComplexEventDeterminationMethod":
					{
						value = ComplexEventDeterminationMethod;
						break;
					}
					case "ComplexEventCalculationAgent":
					{
						value = ComplexEventCalculationAgent;
						break;
					}
					case "ComplexEventStrikePrice":
					{
						value = ComplexEventStrikePrice;
						break;
					}
					case "ComplexEventStrikeFactor":
					{
						value = ComplexEventStrikeFactor;
						break;
					}
					case "ComplexEventStrikeNumberOfOptions":
					{
						value = ComplexEventStrikeNumberOfOptions;
						break;
					}
					case "ComplexEventRateSourceGrp":
					{
						value = ComplexEventRateSourceGrp;
						break;
					}
					case "ComplexEventRelativeDate":
					{
						value = ComplexEventRelativeDate;
						break;
					}
					case "ComplexEventPeriodGrp":
					{
						value = ComplexEventPeriodGrp;
						break;
					}
					case "ComplexEventCreditEventsXIDRef":
					{
						value = ComplexEventCreditEventsXIDRef;
						break;
					}
					case "ComplexEventCreditEventNotifyingParty":
					{
						value = ComplexEventCreditEventNotifyingParty;
						break;
					}
					case "ComplexEventCreditEventBusinessCenter":
					{
						value = ComplexEventCreditEventBusinessCenter;
						break;
					}
					case "ComplexEventCreditEventStandardSources":
					{
						value = ComplexEventCreditEventStandardSources;
						break;
					}
					case "ComplexEventCreditEventMinimumSources":
					{
						value = ComplexEventCreditEventMinimumSources;
						break;
					}
					case "ComplexEventCreditEventSourceGrp":
					{
						value = ComplexEventCreditEventSourceGrp;
						break;
					}
					case "ComplexEventCreditEventGrp":
					{
						value = ComplexEventCreditEventGrp;
						break;
					}
					case "ComplexEventFuturesPriceValuation":
					{
						value = ComplexEventFuturesPriceValuation;
						break;
					}
					case "ComplexEventOptionsPriceValuation":
					{
						value = ComplexEventOptionsPriceValuation;
						break;
					}
					case "ComplexEventPVFinalPriceElectionFallback":
					{
						value = ComplexEventPVFinalPriceElectionFallback;
						break;
					}
					case "ComplexEventXID":
					{
						value = ComplexEventXID;
						break;
					}
					case "ComplexEventXIDRef":
					{
						value = ComplexEventXIDRef;
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
				ComplexEventType = null;
				ComplexOptPayoutPaySide = null;
				ComplexOptPayoutReceiveSide = null;
				ComplexOptPayoutUnderlier = null;
				ComplexOptPayoutAmount = null;
				ComplexOptPayoutPercentage = null;
				ComplexOptPayoutTime = null;
				ComplexOptPayoutCurrency = null;
				ComplexOptPayoutCurrencyCodeSource = null;
				ComplexEventPrice = null;
				ComplexEventPricePercentage = null;
				ComplexEventPriceBoundaryMethod = null;
				ComplexEventPriceBoundaryPrecision = null;
				ComplexEventPriceTimeType = null;
				ComplexEventCondition = null;
				((IFixReset?)ComplexEventDates)?.Reset();
				ComplexEventCurrencyOne = null;
				ComplexEventCurrencyOneCodeSource = null;
				ComplexEventCurrencyTwo = null;
				ComplexEventCurrencyTwoCodeSource = null;
				ComplexEventQuoteBasis = null;
				ComplexEventFixedFXRate = null;
				ComplexEventSpotRate = null;
				ComplexEventForwardPoints = null;
				ComplexEventDeterminationMethod = null;
				ComplexEventCalculationAgent = null;
				ComplexEventStrikePrice = null;
				ComplexEventStrikeFactor = null;
				ComplexEventStrikeNumberOfOptions = null;
				((IFixReset?)ComplexEventRateSourceGrp)?.Reset();
				((IFixReset?)ComplexEventRelativeDate)?.Reset();
				((IFixReset?)ComplexEventPeriodGrp)?.Reset();
				ComplexEventCreditEventsXIDRef = null;
				ComplexEventCreditEventNotifyingParty = null;
				ComplexEventCreditEventBusinessCenter = null;
				ComplexEventCreditEventStandardSources = null;
				ComplexEventCreditEventMinimumSources = null;
				((IFixReset?)ComplexEventCreditEventSourceGrp)?.Reset();
				((IFixReset?)ComplexEventCreditEventGrp)?.Reset();
				ComplexEventFuturesPriceValuation = null;
				ComplexEventOptionsPriceValuation = null;
				ComplexEventPVFinalPriceElectionFallback = null;
				ComplexEventXID = null;
				ComplexEventXIDRef = null;
			}
		}
		[Group(NoOfTag = 1483, Offset = 0, Required = false)]
		public NoComplexEvents[]? ComplexEventsItems {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ComplexEventsItems is not null && ComplexEventsItems.Length != 0)
			{
				writer.WriteWholeNumber(1483, ComplexEventsItems.Length);
				for (int i = 0; i < ComplexEventsItems.Length; i++)
				{
					((IFixEncoder)ComplexEventsItems[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoComplexEvents") is IMessageView viewNoComplexEvents)
			{
				var count = viewNoComplexEvents.GroupCount();
				ComplexEventsItems = new NoComplexEvents[count];
				for (int i = 0; i < count; i++)
				{
					ComplexEventsItems[i] = new();
					((IFixParser)ComplexEventsItems[i]).Parse(viewNoComplexEvents.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoComplexEvents":
				{
					value = ComplexEventsItems;
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
			ComplexEventsItems = null;
		}
	}
}
