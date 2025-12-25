using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStream : IFixComponent
	{
		[TagDetails(Tag = 40568, Type = TagType.Int, Offset = 0, Required = false)]
		public int? UnderlyingPaymentStreamType {get; set;}
		
		[TagDetails(Tag = 40569, Type = TagType.Int, Offset = 1, Required = false)]
		public int? UnderlyingPaymentStreamMarketRate {get; set;}
		
		[TagDetails(Tag = 40570, Type = TagType.Boolean, Offset = 2, Required = false)]
		public bool? UnderlyingPaymentStreamDelayIndicator {get; set;}
		
		[TagDetails(Tag = 42895, Type = TagType.Boolean, Offset = 3, Required = false)]
		public bool? UnderlyingPaymentStreamCashSettlIndicator {get; set;}
		
		[TagDetails(Tag = 40571, Type = TagType.String, Offset = 4, Required = false)]
		public string? UnderlyingPaymentStreamSettlCurrency {get; set;}
		
		[TagDetails(Tag = 40572, Type = TagType.Int, Offset = 5, Required = false)]
		public int? UnderlyingPaymentStreamDayCount {get; set;}
		
		[TagDetails(Tag = 43107, Type = TagType.String, Offset = 6, Required = false)]
		public string? UnderlyingPaymentStreamOtherDayCount {get; set;}
		
		[TagDetails(Tag = 40573, Type = TagType.Int, Offset = 7, Required = false)]
		public int? UnderlyingPaymentStreamAccrualDays {get; set;}
		
		[TagDetails(Tag = 40574, Type = TagType.Int, Offset = 8, Required = false)]
		public int? UnderlyingPaymentStreamDiscountType {get; set;}
		
		[TagDetails(Tag = 40575, Type = TagType.Float, Offset = 9, Required = false)]
		public double? UnderlyingPaymentStreamDiscountRate {get; set;}
		
		[TagDetails(Tag = 40576, Type = TagType.Int, Offset = 10, Required = false)]
		public int? UnderlyingPaymentStreamDiscountRateDayCount {get; set;}
		
		[TagDetails(Tag = 40577, Type = TagType.Int, Offset = 11, Required = false)]
		public int? UnderlyingPaymentStreamCompoundingMethod {get; set;}
		
		[TagDetails(Tag = 42896, Type = TagType.String, Offset = 12, Required = false)]
		public string? UnderlyingPaymentStreamCompoundingXIDRef {get; set;}
		
		[TagDetails(Tag = 42897, Type = TagType.Float, Offset = 13, Required = false)]
		public double? UnderlyingPaymentStreamCompoundingSpread {get; set;}
		
		[TagDetails(Tag = 42898, Type = TagType.Int, Offset = 14, Required = false)]
		public int? UnderlyingPaymentStreamInterpolationMethod {get; set;}
		
		[TagDetails(Tag = 42899, Type = TagType.Int, Offset = 15, Required = false)]
		public int? UnderlyingPaymentStreamInterpolationPeriod {get; set;}
		
		[TagDetails(Tag = 40578, Type = TagType.Boolean, Offset = 16, Required = false)]
		public bool? UnderlyingPaymentStreamInitialPrincipalExchangeIndicator {get; set;}
		
		[TagDetails(Tag = 40579, Type = TagType.Boolean, Offset = 17, Required = false)]
		public bool? UnderlyingPaymentStreamInterimPrincipalExchangeIndicator {get; set;}
		
		[TagDetails(Tag = 40580, Type = TagType.Boolean, Offset = 18, Required = false)]
		public bool? UnderlyingPaymentStreamFinalPrincipalExchangeIndicator {get; set;}
		
		[TagDetails(Tag = 41897, Type = TagType.Boolean, Offset = 19, Required = false)]
		public bool? UnderlyingPaymentStreamFlatRateIndicator {get; set;}
		
		[TagDetails(Tag = 41898, Type = TagType.Float, Offset = 20, Required = false)]
		public double? UnderlyingPaymentStreamFlatRateAmount {get; set;}
		
		[TagDetails(Tag = 41899, Type = TagType.String, Offset = 21, Required = false)]
		public string? UnderlyingPaymentStreamFlatRateCurrency {get; set;}
		
		[TagDetails(Tag = 41900, Type = TagType.Float, Offset = 22, Required = false)]
		public double? UnderlyingPaymentStreamMaximumPaymentAmount {get; set;}
		
		[TagDetails(Tag = 41901, Type = TagType.String, Offset = 23, Required = false)]
		public string? UnderlyingPaymentStreamMaximumPaymentCurrency {get; set;}
		
		[TagDetails(Tag = 41902, Type = TagType.Float, Offset = 24, Required = false)]
		public double? UnderlyingPaymentStreamMaximumTransactionAmount {get; set;}
		
		[TagDetails(Tag = 41903, Type = TagType.String, Offset = 25, Required = false)]
		public string? UnderlyingPaymentStreamMaximumTransactionCurrency {get; set;}
		
		[Component(Offset = 26, Required = false)]
		public UnderlyingPaymentStreamPaymentDates? UnderlyingPaymentStreamPaymentDates {get; set;}
		
		[Component(Offset = 27, Required = false)]
		public UnderlyingPaymentStreamResetDates? UnderlyingPaymentStreamResetDates {get; set;}
		
		[Component(Offset = 28, Required = false)]
		public UnderlyingPaymentStreamFixedRate? UnderlyingPaymentStreamFixedRate {get; set;}
		
		[Component(Offset = 29, Required = false)]
		public UnderlyingPaymentStreamFloatingRate? UnderlyingPaymentStreamFloatingRate {get; set;}
		
		[TagDetails(Tag = 42900, Type = TagType.Float, Offset = 30, Required = false)]
		public double? UnderlyingPaymentStreamCompoundingFixedRate {get; set;}
		
		[Component(Offset = 31, Required = false)]
		public UnderlyingPaymentStreamCompoundingFloatingRate? UnderlyingPaymentStreamCompoundingFloatingRate {get; set;}
		
		[Component(Offset = 32, Required = false)]
		public UnderlyingPaymentStreamCompoundingDates? UnderlyingPaymentStreamCompoundingDates {get; set;}
		
		[Component(Offset = 33, Required = false)]
		public UnderlyingPaymentStreamNonDeliverableSettlTerms? UnderlyingPaymentStreamNonDeliverableSettlTerms {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStreamType is not null) writer.WriteWholeNumber(40568, UnderlyingPaymentStreamType.Value);
			if (UnderlyingPaymentStreamMarketRate is not null) writer.WriteWholeNumber(40569, UnderlyingPaymentStreamMarketRate.Value);
			if (UnderlyingPaymentStreamDelayIndicator is not null) writer.WriteBoolean(40570, UnderlyingPaymentStreamDelayIndicator.Value);
			if (UnderlyingPaymentStreamCashSettlIndicator is not null) writer.WriteBoolean(42895, UnderlyingPaymentStreamCashSettlIndicator.Value);
			if (UnderlyingPaymentStreamSettlCurrency is not null) writer.WriteString(40571, UnderlyingPaymentStreamSettlCurrency);
			if (UnderlyingPaymentStreamDayCount is not null) writer.WriteWholeNumber(40572, UnderlyingPaymentStreamDayCount.Value);
			if (UnderlyingPaymentStreamOtherDayCount is not null) writer.WriteString(43107, UnderlyingPaymentStreamOtherDayCount);
			if (UnderlyingPaymentStreamAccrualDays is not null) writer.WriteWholeNumber(40573, UnderlyingPaymentStreamAccrualDays.Value);
			if (UnderlyingPaymentStreamDiscountType is not null) writer.WriteWholeNumber(40574, UnderlyingPaymentStreamDiscountType.Value);
			if (UnderlyingPaymentStreamDiscountRate is not null) writer.WriteNumber(40575, UnderlyingPaymentStreamDiscountRate.Value);
			if (UnderlyingPaymentStreamDiscountRateDayCount is not null) writer.WriteWholeNumber(40576, UnderlyingPaymentStreamDiscountRateDayCount.Value);
			if (UnderlyingPaymentStreamCompoundingMethod is not null) writer.WriteWholeNumber(40577, UnderlyingPaymentStreamCompoundingMethod.Value);
			if (UnderlyingPaymentStreamCompoundingXIDRef is not null) writer.WriteString(42896, UnderlyingPaymentStreamCompoundingXIDRef);
			if (UnderlyingPaymentStreamCompoundingSpread is not null) writer.WriteNumber(42897, UnderlyingPaymentStreamCompoundingSpread.Value);
			if (UnderlyingPaymentStreamInterpolationMethod is not null) writer.WriteWholeNumber(42898, UnderlyingPaymentStreamInterpolationMethod.Value);
			if (UnderlyingPaymentStreamInterpolationPeriod is not null) writer.WriteWholeNumber(42899, UnderlyingPaymentStreamInterpolationPeriod.Value);
			if (UnderlyingPaymentStreamInitialPrincipalExchangeIndicator is not null) writer.WriteBoolean(40578, UnderlyingPaymentStreamInitialPrincipalExchangeIndicator.Value);
			if (UnderlyingPaymentStreamInterimPrincipalExchangeIndicator is not null) writer.WriteBoolean(40579, UnderlyingPaymentStreamInterimPrincipalExchangeIndicator.Value);
			if (UnderlyingPaymentStreamFinalPrincipalExchangeIndicator is not null) writer.WriteBoolean(40580, UnderlyingPaymentStreamFinalPrincipalExchangeIndicator.Value);
			if (UnderlyingPaymentStreamFlatRateIndicator is not null) writer.WriteBoolean(41897, UnderlyingPaymentStreamFlatRateIndicator.Value);
			if (UnderlyingPaymentStreamFlatRateAmount is not null) writer.WriteNumber(41898, UnderlyingPaymentStreamFlatRateAmount.Value);
			if (UnderlyingPaymentStreamFlatRateCurrency is not null) writer.WriteString(41899, UnderlyingPaymentStreamFlatRateCurrency);
			if (UnderlyingPaymentStreamMaximumPaymentAmount is not null) writer.WriteNumber(41900, UnderlyingPaymentStreamMaximumPaymentAmount.Value);
			if (UnderlyingPaymentStreamMaximumPaymentCurrency is not null) writer.WriteString(41901, UnderlyingPaymentStreamMaximumPaymentCurrency);
			if (UnderlyingPaymentStreamMaximumTransactionAmount is not null) writer.WriteNumber(41902, UnderlyingPaymentStreamMaximumTransactionAmount.Value);
			if (UnderlyingPaymentStreamMaximumTransactionCurrency is not null) writer.WriteString(41903, UnderlyingPaymentStreamMaximumTransactionCurrency);
			if (UnderlyingPaymentStreamPaymentDates is not null) ((IFixEncoder)UnderlyingPaymentStreamPaymentDates).Encode(writer);
			if (UnderlyingPaymentStreamResetDates is not null) ((IFixEncoder)UnderlyingPaymentStreamResetDates).Encode(writer);
			if (UnderlyingPaymentStreamFixedRate is not null) ((IFixEncoder)UnderlyingPaymentStreamFixedRate).Encode(writer);
			if (UnderlyingPaymentStreamFloatingRate is not null) ((IFixEncoder)UnderlyingPaymentStreamFloatingRate).Encode(writer);
			if (UnderlyingPaymentStreamCompoundingFixedRate is not null) writer.WriteNumber(42900, UnderlyingPaymentStreamCompoundingFixedRate.Value);
			if (UnderlyingPaymentStreamCompoundingFloatingRate is not null) ((IFixEncoder)UnderlyingPaymentStreamCompoundingFloatingRate).Encode(writer);
			if (UnderlyingPaymentStreamCompoundingDates is not null) ((IFixEncoder)UnderlyingPaymentStreamCompoundingDates).Encode(writer);
			if (UnderlyingPaymentStreamNonDeliverableSettlTerms is not null) ((IFixEncoder)UnderlyingPaymentStreamNonDeliverableSettlTerms).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingPaymentStreamType = view.GetInt32(40568);
			UnderlyingPaymentStreamMarketRate = view.GetInt32(40569);
			UnderlyingPaymentStreamDelayIndicator = view.GetBool(40570);
			UnderlyingPaymentStreamCashSettlIndicator = view.GetBool(42895);
			UnderlyingPaymentStreamSettlCurrency = view.GetString(40571);
			UnderlyingPaymentStreamDayCount = view.GetInt32(40572);
			UnderlyingPaymentStreamOtherDayCount = view.GetString(43107);
			UnderlyingPaymentStreamAccrualDays = view.GetInt32(40573);
			UnderlyingPaymentStreamDiscountType = view.GetInt32(40574);
			UnderlyingPaymentStreamDiscountRate = view.GetDouble(40575);
			UnderlyingPaymentStreamDiscountRateDayCount = view.GetInt32(40576);
			UnderlyingPaymentStreamCompoundingMethod = view.GetInt32(40577);
			UnderlyingPaymentStreamCompoundingXIDRef = view.GetString(42896);
			UnderlyingPaymentStreamCompoundingSpread = view.GetDouble(42897);
			UnderlyingPaymentStreamInterpolationMethod = view.GetInt32(42898);
			UnderlyingPaymentStreamInterpolationPeriod = view.GetInt32(42899);
			UnderlyingPaymentStreamInitialPrincipalExchangeIndicator = view.GetBool(40578);
			UnderlyingPaymentStreamInterimPrincipalExchangeIndicator = view.GetBool(40579);
			UnderlyingPaymentStreamFinalPrincipalExchangeIndicator = view.GetBool(40580);
			UnderlyingPaymentStreamFlatRateIndicator = view.GetBool(41897);
			UnderlyingPaymentStreamFlatRateAmount = view.GetDouble(41898);
			UnderlyingPaymentStreamFlatRateCurrency = view.GetString(41899);
			UnderlyingPaymentStreamMaximumPaymentAmount = view.GetDouble(41900);
			UnderlyingPaymentStreamMaximumPaymentCurrency = view.GetString(41901);
			UnderlyingPaymentStreamMaximumTransactionAmount = view.GetDouble(41902);
			UnderlyingPaymentStreamMaximumTransactionCurrency = view.GetString(41903);
			if (view.GetView("UnderlyingPaymentStreamPaymentDates") is IMessageView viewUnderlyingPaymentStreamPaymentDates)
			{
				UnderlyingPaymentStreamPaymentDates = new();
				((IFixParser)UnderlyingPaymentStreamPaymentDates).Parse(viewUnderlyingPaymentStreamPaymentDates);
			}
			if (view.GetView("UnderlyingPaymentStreamResetDates") is IMessageView viewUnderlyingPaymentStreamResetDates)
			{
				UnderlyingPaymentStreamResetDates = new();
				((IFixParser)UnderlyingPaymentStreamResetDates).Parse(viewUnderlyingPaymentStreamResetDates);
			}
			if (view.GetView("UnderlyingPaymentStreamFixedRate") is IMessageView viewUnderlyingPaymentStreamFixedRate)
			{
				UnderlyingPaymentStreamFixedRate = new();
				((IFixParser)UnderlyingPaymentStreamFixedRate).Parse(viewUnderlyingPaymentStreamFixedRate);
			}
			if (view.GetView("UnderlyingPaymentStreamFloatingRate") is IMessageView viewUnderlyingPaymentStreamFloatingRate)
			{
				UnderlyingPaymentStreamFloatingRate = new();
				((IFixParser)UnderlyingPaymentStreamFloatingRate).Parse(viewUnderlyingPaymentStreamFloatingRate);
			}
			UnderlyingPaymentStreamCompoundingFixedRate = view.GetDouble(42900);
			if (view.GetView("UnderlyingPaymentStreamCompoundingFloatingRate") is IMessageView viewUnderlyingPaymentStreamCompoundingFloatingRate)
			{
				UnderlyingPaymentStreamCompoundingFloatingRate = new();
				((IFixParser)UnderlyingPaymentStreamCompoundingFloatingRate).Parse(viewUnderlyingPaymentStreamCompoundingFloatingRate);
			}
			if (view.GetView("UnderlyingPaymentStreamCompoundingDates") is IMessageView viewUnderlyingPaymentStreamCompoundingDates)
			{
				UnderlyingPaymentStreamCompoundingDates = new();
				((IFixParser)UnderlyingPaymentStreamCompoundingDates).Parse(viewUnderlyingPaymentStreamCompoundingDates);
			}
			if (view.GetView("UnderlyingPaymentStreamNonDeliverableSettlTerms") is IMessageView viewUnderlyingPaymentStreamNonDeliverableSettlTerms)
			{
				UnderlyingPaymentStreamNonDeliverableSettlTerms = new();
				((IFixParser)UnderlyingPaymentStreamNonDeliverableSettlTerms).Parse(viewUnderlyingPaymentStreamNonDeliverableSettlTerms);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingPaymentStreamType":
				{
					value = UnderlyingPaymentStreamType;
					break;
				}
				case "UnderlyingPaymentStreamMarketRate":
				{
					value = UnderlyingPaymentStreamMarketRate;
					break;
				}
				case "UnderlyingPaymentStreamDelayIndicator":
				{
					value = UnderlyingPaymentStreamDelayIndicator;
					break;
				}
				case "UnderlyingPaymentStreamCashSettlIndicator":
				{
					value = UnderlyingPaymentStreamCashSettlIndicator;
					break;
				}
				case "UnderlyingPaymentStreamSettlCurrency":
				{
					value = UnderlyingPaymentStreamSettlCurrency;
					break;
				}
				case "UnderlyingPaymentStreamDayCount":
				{
					value = UnderlyingPaymentStreamDayCount;
					break;
				}
				case "UnderlyingPaymentStreamOtherDayCount":
				{
					value = UnderlyingPaymentStreamOtherDayCount;
					break;
				}
				case "UnderlyingPaymentStreamAccrualDays":
				{
					value = UnderlyingPaymentStreamAccrualDays;
					break;
				}
				case "UnderlyingPaymentStreamDiscountType":
				{
					value = UnderlyingPaymentStreamDiscountType;
					break;
				}
				case "UnderlyingPaymentStreamDiscountRate":
				{
					value = UnderlyingPaymentStreamDiscountRate;
					break;
				}
				case "UnderlyingPaymentStreamDiscountRateDayCount":
				{
					value = UnderlyingPaymentStreamDiscountRateDayCount;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingMethod":
				{
					value = UnderlyingPaymentStreamCompoundingMethod;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingXIDRef":
				{
					value = UnderlyingPaymentStreamCompoundingXIDRef;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingSpread":
				{
					value = UnderlyingPaymentStreamCompoundingSpread;
					break;
				}
				case "UnderlyingPaymentStreamInterpolationMethod":
				{
					value = UnderlyingPaymentStreamInterpolationMethod;
					break;
				}
				case "UnderlyingPaymentStreamInterpolationPeriod":
				{
					value = UnderlyingPaymentStreamInterpolationPeriod;
					break;
				}
				case "UnderlyingPaymentStreamInitialPrincipalExchangeIndicator":
				{
					value = UnderlyingPaymentStreamInitialPrincipalExchangeIndicator;
					break;
				}
				case "UnderlyingPaymentStreamInterimPrincipalExchangeIndicator":
				{
					value = UnderlyingPaymentStreamInterimPrincipalExchangeIndicator;
					break;
				}
				case "UnderlyingPaymentStreamFinalPrincipalExchangeIndicator":
				{
					value = UnderlyingPaymentStreamFinalPrincipalExchangeIndicator;
					break;
				}
				case "UnderlyingPaymentStreamFlatRateIndicator":
				{
					value = UnderlyingPaymentStreamFlatRateIndicator;
					break;
				}
				case "UnderlyingPaymentStreamFlatRateAmount":
				{
					value = UnderlyingPaymentStreamFlatRateAmount;
					break;
				}
				case "UnderlyingPaymentStreamFlatRateCurrency":
				{
					value = UnderlyingPaymentStreamFlatRateCurrency;
					break;
				}
				case "UnderlyingPaymentStreamMaximumPaymentAmount":
				{
					value = UnderlyingPaymentStreamMaximumPaymentAmount;
					break;
				}
				case "UnderlyingPaymentStreamMaximumPaymentCurrency":
				{
					value = UnderlyingPaymentStreamMaximumPaymentCurrency;
					break;
				}
				case "UnderlyingPaymentStreamMaximumTransactionAmount":
				{
					value = UnderlyingPaymentStreamMaximumTransactionAmount;
					break;
				}
				case "UnderlyingPaymentStreamMaximumTransactionCurrency":
				{
					value = UnderlyingPaymentStreamMaximumTransactionCurrency;
					break;
				}
				case "UnderlyingPaymentStreamPaymentDates":
				{
					value = UnderlyingPaymentStreamPaymentDates;
					break;
				}
				case "UnderlyingPaymentStreamResetDates":
				{
					value = UnderlyingPaymentStreamResetDates;
					break;
				}
				case "UnderlyingPaymentStreamFixedRate":
				{
					value = UnderlyingPaymentStreamFixedRate;
					break;
				}
				case "UnderlyingPaymentStreamFloatingRate":
				{
					value = UnderlyingPaymentStreamFloatingRate;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingFixedRate":
				{
					value = UnderlyingPaymentStreamCompoundingFixedRate;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingFloatingRate":
				{
					value = UnderlyingPaymentStreamCompoundingFloatingRate;
					break;
				}
				case "UnderlyingPaymentStreamCompoundingDates":
				{
					value = UnderlyingPaymentStreamCompoundingDates;
					break;
				}
				case "UnderlyingPaymentStreamNonDeliverableSettlTerms":
				{
					value = UnderlyingPaymentStreamNonDeliverableSettlTerms;
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
			UnderlyingPaymentStreamType = null;
			UnderlyingPaymentStreamMarketRate = null;
			UnderlyingPaymentStreamDelayIndicator = null;
			UnderlyingPaymentStreamCashSettlIndicator = null;
			UnderlyingPaymentStreamSettlCurrency = null;
			UnderlyingPaymentStreamDayCount = null;
			UnderlyingPaymentStreamOtherDayCount = null;
			UnderlyingPaymentStreamAccrualDays = null;
			UnderlyingPaymentStreamDiscountType = null;
			UnderlyingPaymentStreamDiscountRate = null;
			UnderlyingPaymentStreamDiscountRateDayCount = null;
			UnderlyingPaymentStreamCompoundingMethod = null;
			UnderlyingPaymentStreamCompoundingXIDRef = null;
			UnderlyingPaymentStreamCompoundingSpread = null;
			UnderlyingPaymentStreamInterpolationMethod = null;
			UnderlyingPaymentStreamInterpolationPeriod = null;
			UnderlyingPaymentStreamInitialPrincipalExchangeIndicator = null;
			UnderlyingPaymentStreamInterimPrincipalExchangeIndicator = null;
			UnderlyingPaymentStreamFinalPrincipalExchangeIndicator = null;
			UnderlyingPaymentStreamFlatRateIndicator = null;
			UnderlyingPaymentStreamFlatRateAmount = null;
			UnderlyingPaymentStreamFlatRateCurrency = null;
			UnderlyingPaymentStreamMaximumPaymentAmount = null;
			UnderlyingPaymentStreamMaximumPaymentCurrency = null;
			UnderlyingPaymentStreamMaximumTransactionAmount = null;
			UnderlyingPaymentStreamMaximumTransactionCurrency = null;
			((IFixReset?)UnderlyingPaymentStreamPaymentDates)?.Reset();
			((IFixReset?)UnderlyingPaymentStreamResetDates)?.Reset();
			((IFixReset?)UnderlyingPaymentStreamFixedRate)?.Reset();
			((IFixReset?)UnderlyingPaymentStreamFloatingRate)?.Reset();
			UnderlyingPaymentStreamCompoundingFixedRate = null;
			((IFixReset?)UnderlyingPaymentStreamCompoundingFloatingRate)?.Reset();
			((IFixReset?)UnderlyingPaymentStreamCompoundingDates)?.Reset();
			((IFixReset?)UnderlyingPaymentStreamNonDeliverableSettlTerms)?.Reset();
		}
	}
}
