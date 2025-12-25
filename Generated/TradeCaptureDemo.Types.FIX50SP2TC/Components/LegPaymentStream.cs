using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStream : IFixComponent
	{
		[TagDetails(Tag = 40279, Type = TagType.Int, Offset = 0, Required = false)]
		public int? LegPaymentStreamType {get; set;}
		
		[TagDetails(Tag = 40280, Type = TagType.Int, Offset = 1, Required = false)]
		public int? LegPaymentStreamMarketRate {get; set;}
		
		[TagDetails(Tag = 40281, Type = TagType.Boolean, Offset = 2, Required = false)]
		public bool? LegPaymentStreamDelayIndicator {get; set;}
		
		[TagDetails(Tag = 42399, Type = TagType.Boolean, Offset = 3, Required = false)]
		public bool? LegPaymentStreamCashSettlIndicator {get; set;}
		
		[TagDetails(Tag = 40282, Type = TagType.String, Offset = 4, Required = false)]
		public string? LegPaymentStreamSettlCurrency {get; set;}
		
		[TagDetails(Tag = 40283, Type = TagType.Int, Offset = 5, Required = false)]
		public int? LegPaymentStreamDayCount {get; set;}
		
		[TagDetails(Tag = 43108, Type = TagType.String, Offset = 6, Required = false)]
		public string? LegPaymentStreamOtherDayCount {get; set;}
		
		[TagDetails(Tag = 40284, Type = TagType.Int, Offset = 7, Required = false)]
		public int? LegPaymentStreamAccrualDays {get; set;}
		
		[TagDetails(Tag = 40285, Type = TagType.Int, Offset = 8, Required = false)]
		public int? LegPaymentStreamDiscountType {get; set;}
		
		[TagDetails(Tag = 40286, Type = TagType.Float, Offset = 9, Required = false)]
		public double? LegPaymentStreamDiscountRate {get; set;}
		
		[TagDetails(Tag = 40287, Type = TagType.Int, Offset = 10, Required = false)]
		public int? LegPaymentStreamDiscountRateDayCount {get; set;}
		
		[TagDetails(Tag = 40288, Type = TagType.Int, Offset = 11, Required = false)]
		public int? LegPaymentStreamCompoundingMethod {get; set;}
		
		[TagDetails(Tag = 42400, Type = TagType.String, Offset = 12, Required = false)]
		public string? LegPaymentStreamCompoundingXIDRef {get; set;}
		
		[TagDetails(Tag = 42401, Type = TagType.Float, Offset = 13, Required = false)]
		public double? LegPaymentStreamCompoundingSpread {get; set;}
		
		[TagDetails(Tag = 42402, Type = TagType.Int, Offset = 14, Required = false)]
		public int? LegPaymentStreamInterpolationMethod {get; set;}
		
		[TagDetails(Tag = 42403, Type = TagType.Int, Offset = 15, Required = false)]
		public int? LegPaymentStreamInterpolationPeriod {get; set;}
		
		[TagDetails(Tag = 40289, Type = TagType.Boolean, Offset = 16, Required = false)]
		public bool? LegPaymentStreamInitialPrincipalExchangeIndicator {get; set;}
		
		[TagDetails(Tag = 40290, Type = TagType.Boolean, Offset = 17, Required = false)]
		public bool? LegPaymentStreamInterimPrincipalExchangeIndicator {get; set;}
		
		[TagDetails(Tag = 40291, Type = TagType.Boolean, Offset = 18, Required = false)]
		public bool? LegPaymentStreamFinalPrincipalExchangeIndicator {get; set;}
		
		[TagDetails(Tag = 41549, Type = TagType.Boolean, Offset = 19, Required = false)]
		public bool? LegPaymentStreamFlatRateIndicator {get; set;}
		
		[TagDetails(Tag = 41550, Type = TagType.Float, Offset = 20, Required = false)]
		public double? LegPaymentStreamFlatRateAmount {get; set;}
		
		[TagDetails(Tag = 41551, Type = TagType.String, Offset = 21, Required = false)]
		public string? LegPaymentStreamFlatRateCurrency {get; set;}
		
		[TagDetails(Tag = 41552, Type = TagType.Float, Offset = 22, Required = false)]
		public double? LegStreamMaximumPaymentAmount {get; set;}
		
		[TagDetails(Tag = 41553, Type = TagType.String, Offset = 23, Required = false)]
		public string? LegStreamMaximumPaymentCurrency {get; set;}
		
		[TagDetails(Tag = 41554, Type = TagType.Float, Offset = 24, Required = false)]
		public double? LegStreamMaximumTransactionAmount {get; set;}
		
		[TagDetails(Tag = 41555, Type = TagType.String, Offset = 25, Required = false)]
		public string? LegStreamMaximumTransactionCurrency {get; set;}
		
		[Component(Offset = 26, Required = false)]
		public LegPaymentStreamPaymentDates? LegPaymentStreamPaymentDates {get; set;}
		
		[Component(Offset = 27, Required = false)]
		public LegPaymentStreamResetDates? LegPaymentStreamResetDates {get; set;}
		
		[Component(Offset = 28, Required = false)]
		public LegPaymentStreamFixedRate? LegPaymentStreamFixedRate {get; set;}
		
		[Component(Offset = 29, Required = false)]
		public LegPaymentStreamFloatingRate? LegPaymentStreamFloatingRate {get; set;}
		
		[TagDetails(Tag = 42404, Type = TagType.Float, Offset = 30, Required = false)]
		public double? LegPaymentStreamCompoundingFixedRate {get; set;}
		
		[Component(Offset = 31, Required = false)]
		public LegPaymentStreamCompoundingFloatingRate? LegPaymentStreamCompoundingFloatingRate {get; set;}
		
		[Component(Offset = 32, Required = false)]
		public LegPaymentStreamCompoundingDates? LegPaymentStreamCompoundingDates {get; set;}
		
		[Component(Offset = 33, Required = false)]
		public LegPaymentStreamNonDeliverableSettlTerms? LegPaymentStreamNonDeliverableSettlTerms {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStreamType is not null) writer.WriteWholeNumber(40279, LegPaymentStreamType.Value);
			if (LegPaymentStreamMarketRate is not null) writer.WriteWholeNumber(40280, LegPaymentStreamMarketRate.Value);
			if (LegPaymentStreamDelayIndicator is not null) writer.WriteBoolean(40281, LegPaymentStreamDelayIndicator.Value);
			if (LegPaymentStreamCashSettlIndicator is not null) writer.WriteBoolean(42399, LegPaymentStreamCashSettlIndicator.Value);
			if (LegPaymentStreamSettlCurrency is not null) writer.WriteString(40282, LegPaymentStreamSettlCurrency);
			if (LegPaymentStreamDayCount is not null) writer.WriteWholeNumber(40283, LegPaymentStreamDayCount.Value);
			if (LegPaymentStreamOtherDayCount is not null) writer.WriteString(43108, LegPaymentStreamOtherDayCount);
			if (LegPaymentStreamAccrualDays is not null) writer.WriteWholeNumber(40284, LegPaymentStreamAccrualDays.Value);
			if (LegPaymentStreamDiscountType is not null) writer.WriteWholeNumber(40285, LegPaymentStreamDiscountType.Value);
			if (LegPaymentStreamDiscountRate is not null) writer.WriteNumber(40286, LegPaymentStreamDiscountRate.Value);
			if (LegPaymentStreamDiscountRateDayCount is not null) writer.WriteWholeNumber(40287, LegPaymentStreamDiscountRateDayCount.Value);
			if (LegPaymentStreamCompoundingMethod is not null) writer.WriteWholeNumber(40288, LegPaymentStreamCompoundingMethod.Value);
			if (LegPaymentStreamCompoundingXIDRef is not null) writer.WriteString(42400, LegPaymentStreamCompoundingXIDRef);
			if (LegPaymentStreamCompoundingSpread is not null) writer.WriteNumber(42401, LegPaymentStreamCompoundingSpread.Value);
			if (LegPaymentStreamInterpolationMethod is not null) writer.WriteWholeNumber(42402, LegPaymentStreamInterpolationMethod.Value);
			if (LegPaymentStreamInterpolationPeriod is not null) writer.WriteWholeNumber(42403, LegPaymentStreamInterpolationPeriod.Value);
			if (LegPaymentStreamInitialPrincipalExchangeIndicator is not null) writer.WriteBoolean(40289, LegPaymentStreamInitialPrincipalExchangeIndicator.Value);
			if (LegPaymentStreamInterimPrincipalExchangeIndicator is not null) writer.WriteBoolean(40290, LegPaymentStreamInterimPrincipalExchangeIndicator.Value);
			if (LegPaymentStreamFinalPrincipalExchangeIndicator is not null) writer.WriteBoolean(40291, LegPaymentStreamFinalPrincipalExchangeIndicator.Value);
			if (LegPaymentStreamFlatRateIndicator is not null) writer.WriteBoolean(41549, LegPaymentStreamFlatRateIndicator.Value);
			if (LegPaymentStreamFlatRateAmount is not null) writer.WriteNumber(41550, LegPaymentStreamFlatRateAmount.Value);
			if (LegPaymentStreamFlatRateCurrency is not null) writer.WriteString(41551, LegPaymentStreamFlatRateCurrency);
			if (LegStreamMaximumPaymentAmount is not null) writer.WriteNumber(41552, LegStreamMaximumPaymentAmount.Value);
			if (LegStreamMaximumPaymentCurrency is not null) writer.WriteString(41553, LegStreamMaximumPaymentCurrency);
			if (LegStreamMaximumTransactionAmount is not null) writer.WriteNumber(41554, LegStreamMaximumTransactionAmount.Value);
			if (LegStreamMaximumTransactionCurrency is not null) writer.WriteString(41555, LegStreamMaximumTransactionCurrency);
			if (LegPaymentStreamPaymentDates is not null) ((IFixEncoder)LegPaymentStreamPaymentDates).Encode(writer);
			if (LegPaymentStreamResetDates is not null) ((IFixEncoder)LegPaymentStreamResetDates).Encode(writer);
			if (LegPaymentStreamFixedRate is not null) ((IFixEncoder)LegPaymentStreamFixedRate).Encode(writer);
			if (LegPaymentStreamFloatingRate is not null) ((IFixEncoder)LegPaymentStreamFloatingRate).Encode(writer);
			if (LegPaymentStreamCompoundingFixedRate is not null) writer.WriteNumber(42404, LegPaymentStreamCompoundingFixedRate.Value);
			if (LegPaymentStreamCompoundingFloatingRate is not null) ((IFixEncoder)LegPaymentStreamCompoundingFloatingRate).Encode(writer);
			if (LegPaymentStreamCompoundingDates is not null) ((IFixEncoder)LegPaymentStreamCompoundingDates).Encode(writer);
			if (LegPaymentStreamNonDeliverableSettlTerms is not null) ((IFixEncoder)LegPaymentStreamNonDeliverableSettlTerms).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegPaymentStreamType = view.GetInt32(40279);
			LegPaymentStreamMarketRate = view.GetInt32(40280);
			LegPaymentStreamDelayIndicator = view.GetBool(40281);
			LegPaymentStreamCashSettlIndicator = view.GetBool(42399);
			LegPaymentStreamSettlCurrency = view.GetString(40282);
			LegPaymentStreamDayCount = view.GetInt32(40283);
			LegPaymentStreamOtherDayCount = view.GetString(43108);
			LegPaymentStreamAccrualDays = view.GetInt32(40284);
			LegPaymentStreamDiscountType = view.GetInt32(40285);
			LegPaymentStreamDiscountRate = view.GetDouble(40286);
			LegPaymentStreamDiscountRateDayCount = view.GetInt32(40287);
			LegPaymentStreamCompoundingMethod = view.GetInt32(40288);
			LegPaymentStreamCompoundingXIDRef = view.GetString(42400);
			LegPaymentStreamCompoundingSpread = view.GetDouble(42401);
			LegPaymentStreamInterpolationMethod = view.GetInt32(42402);
			LegPaymentStreamInterpolationPeriod = view.GetInt32(42403);
			LegPaymentStreamInitialPrincipalExchangeIndicator = view.GetBool(40289);
			LegPaymentStreamInterimPrincipalExchangeIndicator = view.GetBool(40290);
			LegPaymentStreamFinalPrincipalExchangeIndicator = view.GetBool(40291);
			LegPaymentStreamFlatRateIndicator = view.GetBool(41549);
			LegPaymentStreamFlatRateAmount = view.GetDouble(41550);
			LegPaymentStreamFlatRateCurrency = view.GetString(41551);
			LegStreamMaximumPaymentAmount = view.GetDouble(41552);
			LegStreamMaximumPaymentCurrency = view.GetString(41553);
			LegStreamMaximumTransactionAmount = view.GetDouble(41554);
			LegStreamMaximumTransactionCurrency = view.GetString(41555);
			if (view.GetView("LegPaymentStreamPaymentDates") is IMessageView viewLegPaymentStreamPaymentDates)
			{
				LegPaymentStreamPaymentDates = new();
				((IFixParser)LegPaymentStreamPaymentDates).Parse(viewLegPaymentStreamPaymentDates);
			}
			if (view.GetView("LegPaymentStreamResetDates") is IMessageView viewLegPaymentStreamResetDates)
			{
				LegPaymentStreamResetDates = new();
				((IFixParser)LegPaymentStreamResetDates).Parse(viewLegPaymentStreamResetDates);
			}
			if (view.GetView("LegPaymentStreamFixedRate") is IMessageView viewLegPaymentStreamFixedRate)
			{
				LegPaymentStreamFixedRate = new();
				((IFixParser)LegPaymentStreamFixedRate).Parse(viewLegPaymentStreamFixedRate);
			}
			if (view.GetView("LegPaymentStreamFloatingRate") is IMessageView viewLegPaymentStreamFloatingRate)
			{
				LegPaymentStreamFloatingRate = new();
				((IFixParser)LegPaymentStreamFloatingRate).Parse(viewLegPaymentStreamFloatingRate);
			}
			LegPaymentStreamCompoundingFixedRate = view.GetDouble(42404);
			if (view.GetView("LegPaymentStreamCompoundingFloatingRate") is IMessageView viewLegPaymentStreamCompoundingFloatingRate)
			{
				LegPaymentStreamCompoundingFloatingRate = new();
				((IFixParser)LegPaymentStreamCompoundingFloatingRate).Parse(viewLegPaymentStreamCompoundingFloatingRate);
			}
			if (view.GetView("LegPaymentStreamCompoundingDates") is IMessageView viewLegPaymentStreamCompoundingDates)
			{
				LegPaymentStreamCompoundingDates = new();
				((IFixParser)LegPaymentStreamCompoundingDates).Parse(viewLegPaymentStreamCompoundingDates);
			}
			if (view.GetView("LegPaymentStreamNonDeliverableSettlTerms") is IMessageView viewLegPaymentStreamNonDeliverableSettlTerms)
			{
				LegPaymentStreamNonDeliverableSettlTerms = new();
				((IFixParser)LegPaymentStreamNonDeliverableSettlTerms).Parse(viewLegPaymentStreamNonDeliverableSettlTerms);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegPaymentStreamType":
				{
					value = LegPaymentStreamType;
					break;
				}
				case "LegPaymentStreamMarketRate":
				{
					value = LegPaymentStreamMarketRate;
					break;
				}
				case "LegPaymentStreamDelayIndicator":
				{
					value = LegPaymentStreamDelayIndicator;
					break;
				}
				case "LegPaymentStreamCashSettlIndicator":
				{
					value = LegPaymentStreamCashSettlIndicator;
					break;
				}
				case "LegPaymentStreamSettlCurrency":
				{
					value = LegPaymentStreamSettlCurrency;
					break;
				}
				case "LegPaymentStreamDayCount":
				{
					value = LegPaymentStreamDayCount;
					break;
				}
				case "LegPaymentStreamOtherDayCount":
				{
					value = LegPaymentStreamOtherDayCount;
					break;
				}
				case "LegPaymentStreamAccrualDays":
				{
					value = LegPaymentStreamAccrualDays;
					break;
				}
				case "LegPaymentStreamDiscountType":
				{
					value = LegPaymentStreamDiscountType;
					break;
				}
				case "LegPaymentStreamDiscountRate":
				{
					value = LegPaymentStreamDiscountRate;
					break;
				}
				case "LegPaymentStreamDiscountRateDayCount":
				{
					value = LegPaymentStreamDiscountRateDayCount;
					break;
				}
				case "LegPaymentStreamCompoundingMethod":
				{
					value = LegPaymentStreamCompoundingMethod;
					break;
				}
				case "LegPaymentStreamCompoundingXIDRef":
				{
					value = LegPaymentStreamCompoundingXIDRef;
					break;
				}
				case "LegPaymentStreamCompoundingSpread":
				{
					value = LegPaymentStreamCompoundingSpread;
					break;
				}
				case "LegPaymentStreamInterpolationMethod":
				{
					value = LegPaymentStreamInterpolationMethod;
					break;
				}
				case "LegPaymentStreamInterpolationPeriod":
				{
					value = LegPaymentStreamInterpolationPeriod;
					break;
				}
				case "LegPaymentStreamInitialPrincipalExchangeIndicator":
				{
					value = LegPaymentStreamInitialPrincipalExchangeIndicator;
					break;
				}
				case "LegPaymentStreamInterimPrincipalExchangeIndicator":
				{
					value = LegPaymentStreamInterimPrincipalExchangeIndicator;
					break;
				}
				case "LegPaymentStreamFinalPrincipalExchangeIndicator":
				{
					value = LegPaymentStreamFinalPrincipalExchangeIndicator;
					break;
				}
				case "LegPaymentStreamFlatRateIndicator":
				{
					value = LegPaymentStreamFlatRateIndicator;
					break;
				}
				case "LegPaymentStreamFlatRateAmount":
				{
					value = LegPaymentStreamFlatRateAmount;
					break;
				}
				case "LegPaymentStreamFlatRateCurrency":
				{
					value = LegPaymentStreamFlatRateCurrency;
					break;
				}
				case "LegStreamMaximumPaymentAmount":
				{
					value = LegStreamMaximumPaymentAmount;
					break;
				}
				case "LegStreamMaximumPaymentCurrency":
				{
					value = LegStreamMaximumPaymentCurrency;
					break;
				}
				case "LegStreamMaximumTransactionAmount":
				{
					value = LegStreamMaximumTransactionAmount;
					break;
				}
				case "LegStreamMaximumTransactionCurrency":
				{
					value = LegStreamMaximumTransactionCurrency;
					break;
				}
				case "LegPaymentStreamPaymentDates":
				{
					value = LegPaymentStreamPaymentDates;
					break;
				}
				case "LegPaymentStreamResetDates":
				{
					value = LegPaymentStreamResetDates;
					break;
				}
				case "LegPaymentStreamFixedRate":
				{
					value = LegPaymentStreamFixedRate;
					break;
				}
				case "LegPaymentStreamFloatingRate":
				{
					value = LegPaymentStreamFloatingRate;
					break;
				}
				case "LegPaymentStreamCompoundingFixedRate":
				{
					value = LegPaymentStreamCompoundingFixedRate;
					break;
				}
				case "LegPaymentStreamCompoundingFloatingRate":
				{
					value = LegPaymentStreamCompoundingFloatingRate;
					break;
				}
				case "LegPaymentStreamCompoundingDates":
				{
					value = LegPaymentStreamCompoundingDates;
					break;
				}
				case "LegPaymentStreamNonDeliverableSettlTerms":
				{
					value = LegPaymentStreamNonDeliverableSettlTerms;
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
			LegPaymentStreamType = null;
			LegPaymentStreamMarketRate = null;
			LegPaymentStreamDelayIndicator = null;
			LegPaymentStreamCashSettlIndicator = null;
			LegPaymentStreamSettlCurrency = null;
			LegPaymentStreamDayCount = null;
			LegPaymentStreamOtherDayCount = null;
			LegPaymentStreamAccrualDays = null;
			LegPaymentStreamDiscountType = null;
			LegPaymentStreamDiscountRate = null;
			LegPaymentStreamDiscountRateDayCount = null;
			LegPaymentStreamCompoundingMethod = null;
			LegPaymentStreamCompoundingXIDRef = null;
			LegPaymentStreamCompoundingSpread = null;
			LegPaymentStreamInterpolationMethod = null;
			LegPaymentStreamInterpolationPeriod = null;
			LegPaymentStreamInitialPrincipalExchangeIndicator = null;
			LegPaymentStreamInterimPrincipalExchangeIndicator = null;
			LegPaymentStreamFinalPrincipalExchangeIndicator = null;
			LegPaymentStreamFlatRateIndicator = null;
			LegPaymentStreamFlatRateAmount = null;
			LegPaymentStreamFlatRateCurrency = null;
			LegStreamMaximumPaymentAmount = null;
			LegStreamMaximumPaymentCurrency = null;
			LegStreamMaximumTransactionAmount = null;
			LegStreamMaximumTransactionCurrency = null;
			((IFixReset?)LegPaymentStreamPaymentDates)?.Reset();
			((IFixReset?)LegPaymentStreamResetDates)?.Reset();
			((IFixReset?)LegPaymentStreamFixedRate)?.Reset();
			((IFixReset?)LegPaymentStreamFloatingRate)?.Reset();
			LegPaymentStreamCompoundingFixedRate = null;
			((IFixReset?)LegPaymentStreamCompoundingFloatingRate)?.Reset();
			((IFixReset?)LegPaymentStreamCompoundingDates)?.Reset();
			((IFixReset?)LegPaymentStreamNonDeliverableSettlTerms)?.Reset();
		}
	}
}
