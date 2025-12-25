using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStream : IFixComponent
	{
		[TagDetails(Tag = 40738, Type = TagType.Int, Offset = 0, Required = false)]
		public int? PaymentStreamType {get; set;}
		
		[TagDetails(Tag = 40739, Type = TagType.Int, Offset = 1, Required = false)]
		public int? PaymentStreamMarketRate {get; set;}
		
		[TagDetails(Tag = 40740, Type = TagType.Boolean, Offset = 2, Required = false)]
		public bool? PaymentStreamDelayIndicator {get; set;}
		
		[TagDetails(Tag = 42600, Type = TagType.Boolean, Offset = 3, Required = false)]
		public bool? PaymentStreamCashSettlIndicator {get; set;}
		
		[TagDetails(Tag = 40741, Type = TagType.String, Offset = 4, Required = false)]
		public string? PaymentStreamSettlCurrency {get; set;}
		
		[TagDetails(Tag = 40742, Type = TagType.Int, Offset = 5, Required = false)]
		public int? PaymentStreamDayCount {get; set;}
		
		[TagDetails(Tag = 43106, Type = TagType.String, Offset = 6, Required = false)]
		public string? PaymentStreamOtherDayCount {get; set;}
		
		[TagDetails(Tag = 40743, Type = TagType.Int, Offset = 7, Required = false)]
		public int? PaymentStreamAccrualDays {get; set;}
		
		[TagDetails(Tag = 40744, Type = TagType.Int, Offset = 8, Required = false)]
		public int? PaymentStreamDiscountType {get; set;}
		
		[TagDetails(Tag = 40745, Type = TagType.Float, Offset = 9, Required = false)]
		public double? PaymentStreamDiscountRate {get; set;}
		
		[TagDetails(Tag = 40746, Type = TagType.Int, Offset = 10, Required = false)]
		public int? PaymentStreamDiscountRateDayCount {get; set;}
		
		[TagDetails(Tag = 40747, Type = TagType.Int, Offset = 11, Required = false)]
		public int? PaymentStreamCompoundingMethod {get; set;}
		
		[TagDetails(Tag = 42601, Type = TagType.String, Offset = 12, Required = false)]
		public string? PaymentStreamCompoundingXIDRef {get; set;}
		
		[TagDetails(Tag = 42602, Type = TagType.Float, Offset = 13, Required = false)]
		public double? PaymentStreamCompoundingSpread {get; set;}
		
		[TagDetails(Tag = 42603, Type = TagType.Int, Offset = 14, Required = false)]
		public int? PaymentStreamInterpolationMethod {get; set;}
		
		[TagDetails(Tag = 42604, Type = TagType.Int, Offset = 15, Required = false)]
		public int? PaymentStreamInterpolationPeriod {get; set;}
		
		[TagDetails(Tag = 40748, Type = TagType.Boolean, Offset = 16, Required = false)]
		public bool? PaymentStreamInitialPrincipalExchangeIndicator {get; set;}
		
		[TagDetails(Tag = 40749, Type = TagType.Boolean, Offset = 17, Required = false)]
		public bool? PaymentStreamInterimPrincipalExchangeIndicator {get; set;}
		
		[TagDetails(Tag = 40750, Type = TagType.Boolean, Offset = 18, Required = false)]
		public bool? PaymentStreamFinalPrincipalExchangeIndicator {get; set;}
		
		[TagDetails(Tag = 41180, Type = TagType.Boolean, Offset = 19, Required = false)]
		public bool? PaymentStreamFlatRateIndicator {get; set;}
		
		[TagDetails(Tag = 41181, Type = TagType.Float, Offset = 20, Required = false)]
		public double? PaymentStreamFlatRateAmount {get; set;}
		
		[TagDetails(Tag = 41182, Type = TagType.String, Offset = 21, Required = false)]
		public string? PaymentStreamFlatRateCurrency {get; set;}
		
		[TagDetails(Tag = 41183, Type = TagType.Float, Offset = 22, Required = false)]
		public double? PaymentStreamMaximumPaymentAmount {get; set;}
		
		[TagDetails(Tag = 41184, Type = TagType.String, Offset = 23, Required = false)]
		public string? PaymentStreamMaximumPaymentCurrency {get; set;}
		
		[TagDetails(Tag = 41185, Type = TagType.Float, Offset = 24, Required = false)]
		public double? PaymentStreamMaximumTransactionAmount {get; set;}
		
		[TagDetails(Tag = 41186, Type = TagType.String, Offset = 25, Required = false)]
		public string? PaymentStreamMaximumTransactionCurrency {get; set;}
		
		[Component(Offset = 26, Required = false)]
		public PaymentStreamPaymentDates? PaymentStreamPaymentDates {get; set;}
		
		[Component(Offset = 27, Required = false)]
		public PaymentStreamResetDates? PaymentStreamResetDates {get; set;}
		
		[Component(Offset = 28, Required = false)]
		public PaymentStreamFixedRate? PaymentStreamFixedRate {get; set;}
		
		[Component(Offset = 29, Required = false)]
		public PaymentStreamFloatingRate? PaymentStreamFloatingRate {get; set;}
		
		[TagDetails(Tag = 42605, Type = TagType.Float, Offset = 30, Required = false)]
		public double? PaymentStreamCompoundingFixedRate {get; set;}
		
		[Component(Offset = 31, Required = false)]
		public PaymentStreamCompoundingFloatingRate? PaymentStreamCompoundingFloatingRate {get; set;}
		
		[Component(Offset = 32, Required = false)]
		public PaymentStreamCompoundingDates? PaymentStreamCompoundingDates {get; set;}
		
		[Component(Offset = 33, Required = false)]
		public PaymentStreamNonDeliverableSettlTerms? PaymentStreamNonDeliverableSettlTerms {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStreamType is not null) writer.WriteWholeNumber(40738, PaymentStreamType.Value);
			if (PaymentStreamMarketRate is not null) writer.WriteWholeNumber(40739, PaymentStreamMarketRate.Value);
			if (PaymentStreamDelayIndicator is not null) writer.WriteBoolean(40740, PaymentStreamDelayIndicator.Value);
			if (PaymentStreamCashSettlIndicator is not null) writer.WriteBoolean(42600, PaymentStreamCashSettlIndicator.Value);
			if (PaymentStreamSettlCurrency is not null) writer.WriteString(40741, PaymentStreamSettlCurrency);
			if (PaymentStreamDayCount is not null) writer.WriteWholeNumber(40742, PaymentStreamDayCount.Value);
			if (PaymentStreamOtherDayCount is not null) writer.WriteString(43106, PaymentStreamOtherDayCount);
			if (PaymentStreamAccrualDays is not null) writer.WriteWholeNumber(40743, PaymentStreamAccrualDays.Value);
			if (PaymentStreamDiscountType is not null) writer.WriteWholeNumber(40744, PaymentStreamDiscountType.Value);
			if (PaymentStreamDiscountRate is not null) writer.WriteNumber(40745, PaymentStreamDiscountRate.Value);
			if (PaymentStreamDiscountRateDayCount is not null) writer.WriteWholeNumber(40746, PaymentStreamDiscountRateDayCount.Value);
			if (PaymentStreamCompoundingMethod is not null) writer.WriteWholeNumber(40747, PaymentStreamCompoundingMethod.Value);
			if (PaymentStreamCompoundingXIDRef is not null) writer.WriteString(42601, PaymentStreamCompoundingXIDRef);
			if (PaymentStreamCompoundingSpread is not null) writer.WriteNumber(42602, PaymentStreamCompoundingSpread.Value);
			if (PaymentStreamInterpolationMethod is not null) writer.WriteWholeNumber(42603, PaymentStreamInterpolationMethod.Value);
			if (PaymentStreamInterpolationPeriod is not null) writer.WriteWholeNumber(42604, PaymentStreamInterpolationPeriod.Value);
			if (PaymentStreamInitialPrincipalExchangeIndicator is not null) writer.WriteBoolean(40748, PaymentStreamInitialPrincipalExchangeIndicator.Value);
			if (PaymentStreamInterimPrincipalExchangeIndicator is not null) writer.WriteBoolean(40749, PaymentStreamInterimPrincipalExchangeIndicator.Value);
			if (PaymentStreamFinalPrincipalExchangeIndicator is not null) writer.WriteBoolean(40750, PaymentStreamFinalPrincipalExchangeIndicator.Value);
			if (PaymentStreamFlatRateIndicator is not null) writer.WriteBoolean(41180, PaymentStreamFlatRateIndicator.Value);
			if (PaymentStreamFlatRateAmount is not null) writer.WriteNumber(41181, PaymentStreamFlatRateAmount.Value);
			if (PaymentStreamFlatRateCurrency is not null) writer.WriteString(41182, PaymentStreamFlatRateCurrency);
			if (PaymentStreamMaximumPaymentAmount is not null) writer.WriteNumber(41183, PaymentStreamMaximumPaymentAmount.Value);
			if (PaymentStreamMaximumPaymentCurrency is not null) writer.WriteString(41184, PaymentStreamMaximumPaymentCurrency);
			if (PaymentStreamMaximumTransactionAmount is not null) writer.WriteNumber(41185, PaymentStreamMaximumTransactionAmount.Value);
			if (PaymentStreamMaximumTransactionCurrency is not null) writer.WriteString(41186, PaymentStreamMaximumTransactionCurrency);
			if (PaymentStreamPaymentDates is not null) ((IFixEncoder)PaymentStreamPaymentDates).Encode(writer);
			if (PaymentStreamResetDates is not null) ((IFixEncoder)PaymentStreamResetDates).Encode(writer);
			if (PaymentStreamFixedRate is not null) ((IFixEncoder)PaymentStreamFixedRate).Encode(writer);
			if (PaymentStreamFloatingRate is not null) ((IFixEncoder)PaymentStreamFloatingRate).Encode(writer);
			if (PaymentStreamCompoundingFixedRate is not null) writer.WriteNumber(42605, PaymentStreamCompoundingFixedRate.Value);
			if (PaymentStreamCompoundingFloatingRate is not null) ((IFixEncoder)PaymentStreamCompoundingFloatingRate).Encode(writer);
			if (PaymentStreamCompoundingDates is not null) ((IFixEncoder)PaymentStreamCompoundingDates).Encode(writer);
			if (PaymentStreamNonDeliverableSettlTerms is not null) ((IFixEncoder)PaymentStreamNonDeliverableSettlTerms).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			PaymentStreamType = view.GetInt32(40738);
			PaymentStreamMarketRate = view.GetInt32(40739);
			PaymentStreamDelayIndicator = view.GetBool(40740);
			PaymentStreamCashSettlIndicator = view.GetBool(42600);
			PaymentStreamSettlCurrency = view.GetString(40741);
			PaymentStreamDayCount = view.GetInt32(40742);
			PaymentStreamOtherDayCount = view.GetString(43106);
			PaymentStreamAccrualDays = view.GetInt32(40743);
			PaymentStreamDiscountType = view.GetInt32(40744);
			PaymentStreamDiscountRate = view.GetDouble(40745);
			PaymentStreamDiscountRateDayCount = view.GetInt32(40746);
			PaymentStreamCompoundingMethod = view.GetInt32(40747);
			PaymentStreamCompoundingXIDRef = view.GetString(42601);
			PaymentStreamCompoundingSpread = view.GetDouble(42602);
			PaymentStreamInterpolationMethod = view.GetInt32(42603);
			PaymentStreamInterpolationPeriod = view.GetInt32(42604);
			PaymentStreamInitialPrincipalExchangeIndicator = view.GetBool(40748);
			PaymentStreamInterimPrincipalExchangeIndicator = view.GetBool(40749);
			PaymentStreamFinalPrincipalExchangeIndicator = view.GetBool(40750);
			PaymentStreamFlatRateIndicator = view.GetBool(41180);
			PaymentStreamFlatRateAmount = view.GetDouble(41181);
			PaymentStreamFlatRateCurrency = view.GetString(41182);
			PaymentStreamMaximumPaymentAmount = view.GetDouble(41183);
			PaymentStreamMaximumPaymentCurrency = view.GetString(41184);
			PaymentStreamMaximumTransactionAmount = view.GetDouble(41185);
			PaymentStreamMaximumTransactionCurrency = view.GetString(41186);
			if (view.GetView("PaymentStreamPaymentDates") is IMessageView viewPaymentStreamPaymentDates)
			{
				PaymentStreamPaymentDates = new();
				((IFixParser)PaymentStreamPaymentDates).Parse(viewPaymentStreamPaymentDates);
			}
			if (view.GetView("PaymentStreamResetDates") is IMessageView viewPaymentStreamResetDates)
			{
				PaymentStreamResetDates = new();
				((IFixParser)PaymentStreamResetDates).Parse(viewPaymentStreamResetDates);
			}
			if (view.GetView("PaymentStreamFixedRate") is IMessageView viewPaymentStreamFixedRate)
			{
				PaymentStreamFixedRate = new();
				((IFixParser)PaymentStreamFixedRate).Parse(viewPaymentStreamFixedRate);
			}
			if (view.GetView("PaymentStreamFloatingRate") is IMessageView viewPaymentStreamFloatingRate)
			{
				PaymentStreamFloatingRate = new();
				((IFixParser)PaymentStreamFloatingRate).Parse(viewPaymentStreamFloatingRate);
			}
			PaymentStreamCompoundingFixedRate = view.GetDouble(42605);
			if (view.GetView("PaymentStreamCompoundingFloatingRate") is IMessageView viewPaymentStreamCompoundingFloatingRate)
			{
				PaymentStreamCompoundingFloatingRate = new();
				((IFixParser)PaymentStreamCompoundingFloatingRate).Parse(viewPaymentStreamCompoundingFloatingRate);
			}
			if (view.GetView("PaymentStreamCompoundingDates") is IMessageView viewPaymentStreamCompoundingDates)
			{
				PaymentStreamCompoundingDates = new();
				((IFixParser)PaymentStreamCompoundingDates).Parse(viewPaymentStreamCompoundingDates);
			}
			if (view.GetView("PaymentStreamNonDeliverableSettlTerms") is IMessageView viewPaymentStreamNonDeliverableSettlTerms)
			{
				PaymentStreamNonDeliverableSettlTerms = new();
				((IFixParser)PaymentStreamNonDeliverableSettlTerms).Parse(viewPaymentStreamNonDeliverableSettlTerms);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "PaymentStreamType":
				{
					value = PaymentStreamType;
					break;
				}
				case "PaymentStreamMarketRate":
				{
					value = PaymentStreamMarketRate;
					break;
				}
				case "PaymentStreamDelayIndicator":
				{
					value = PaymentStreamDelayIndicator;
					break;
				}
				case "PaymentStreamCashSettlIndicator":
				{
					value = PaymentStreamCashSettlIndicator;
					break;
				}
				case "PaymentStreamSettlCurrency":
				{
					value = PaymentStreamSettlCurrency;
					break;
				}
				case "PaymentStreamDayCount":
				{
					value = PaymentStreamDayCount;
					break;
				}
				case "PaymentStreamOtherDayCount":
				{
					value = PaymentStreamOtherDayCount;
					break;
				}
				case "PaymentStreamAccrualDays":
				{
					value = PaymentStreamAccrualDays;
					break;
				}
				case "PaymentStreamDiscountType":
				{
					value = PaymentStreamDiscountType;
					break;
				}
				case "PaymentStreamDiscountRate":
				{
					value = PaymentStreamDiscountRate;
					break;
				}
				case "PaymentStreamDiscountRateDayCount":
				{
					value = PaymentStreamDiscountRateDayCount;
					break;
				}
				case "PaymentStreamCompoundingMethod":
				{
					value = PaymentStreamCompoundingMethod;
					break;
				}
				case "PaymentStreamCompoundingXIDRef":
				{
					value = PaymentStreamCompoundingXIDRef;
					break;
				}
				case "PaymentStreamCompoundingSpread":
				{
					value = PaymentStreamCompoundingSpread;
					break;
				}
				case "PaymentStreamInterpolationMethod":
				{
					value = PaymentStreamInterpolationMethod;
					break;
				}
				case "PaymentStreamInterpolationPeriod":
				{
					value = PaymentStreamInterpolationPeriod;
					break;
				}
				case "PaymentStreamInitialPrincipalExchangeIndicator":
				{
					value = PaymentStreamInitialPrincipalExchangeIndicator;
					break;
				}
				case "PaymentStreamInterimPrincipalExchangeIndicator":
				{
					value = PaymentStreamInterimPrincipalExchangeIndicator;
					break;
				}
				case "PaymentStreamFinalPrincipalExchangeIndicator":
				{
					value = PaymentStreamFinalPrincipalExchangeIndicator;
					break;
				}
				case "PaymentStreamFlatRateIndicator":
				{
					value = PaymentStreamFlatRateIndicator;
					break;
				}
				case "PaymentStreamFlatRateAmount":
				{
					value = PaymentStreamFlatRateAmount;
					break;
				}
				case "PaymentStreamFlatRateCurrency":
				{
					value = PaymentStreamFlatRateCurrency;
					break;
				}
				case "PaymentStreamMaximumPaymentAmount":
				{
					value = PaymentStreamMaximumPaymentAmount;
					break;
				}
				case "PaymentStreamMaximumPaymentCurrency":
				{
					value = PaymentStreamMaximumPaymentCurrency;
					break;
				}
				case "PaymentStreamMaximumTransactionAmount":
				{
					value = PaymentStreamMaximumTransactionAmount;
					break;
				}
				case "PaymentStreamMaximumTransactionCurrency":
				{
					value = PaymentStreamMaximumTransactionCurrency;
					break;
				}
				case "PaymentStreamPaymentDates":
				{
					value = PaymentStreamPaymentDates;
					break;
				}
				case "PaymentStreamResetDates":
				{
					value = PaymentStreamResetDates;
					break;
				}
				case "PaymentStreamFixedRate":
				{
					value = PaymentStreamFixedRate;
					break;
				}
				case "PaymentStreamFloatingRate":
				{
					value = PaymentStreamFloatingRate;
					break;
				}
				case "PaymentStreamCompoundingFixedRate":
				{
					value = PaymentStreamCompoundingFixedRate;
					break;
				}
				case "PaymentStreamCompoundingFloatingRate":
				{
					value = PaymentStreamCompoundingFloatingRate;
					break;
				}
				case "PaymentStreamCompoundingDates":
				{
					value = PaymentStreamCompoundingDates;
					break;
				}
				case "PaymentStreamNonDeliverableSettlTerms":
				{
					value = PaymentStreamNonDeliverableSettlTerms;
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
			PaymentStreamType = null;
			PaymentStreamMarketRate = null;
			PaymentStreamDelayIndicator = null;
			PaymentStreamCashSettlIndicator = null;
			PaymentStreamSettlCurrency = null;
			PaymentStreamDayCount = null;
			PaymentStreamOtherDayCount = null;
			PaymentStreamAccrualDays = null;
			PaymentStreamDiscountType = null;
			PaymentStreamDiscountRate = null;
			PaymentStreamDiscountRateDayCount = null;
			PaymentStreamCompoundingMethod = null;
			PaymentStreamCompoundingXIDRef = null;
			PaymentStreamCompoundingSpread = null;
			PaymentStreamInterpolationMethod = null;
			PaymentStreamInterpolationPeriod = null;
			PaymentStreamInitialPrincipalExchangeIndicator = null;
			PaymentStreamInterimPrincipalExchangeIndicator = null;
			PaymentStreamFinalPrincipalExchangeIndicator = null;
			PaymentStreamFlatRateIndicator = null;
			PaymentStreamFlatRateAmount = null;
			PaymentStreamFlatRateCurrency = null;
			PaymentStreamMaximumPaymentAmount = null;
			PaymentStreamMaximumPaymentCurrency = null;
			PaymentStreamMaximumTransactionAmount = null;
			PaymentStreamMaximumTransactionCurrency = null;
			((IFixReset?)PaymentStreamPaymentDates)?.Reset();
			((IFixReset?)PaymentStreamResetDates)?.Reset();
			((IFixReset?)PaymentStreamFixedRate)?.Reset();
			((IFixReset?)PaymentStreamFloatingRate)?.Reset();
			PaymentStreamCompoundingFixedRate = null;
			((IFixReset?)PaymentStreamCompoundingFloatingRate)?.Reset();
			((IFixReset?)PaymentStreamCompoundingDates)?.Reset();
			((IFixReset?)PaymentStreamNonDeliverableSettlTerms)?.Reset();
		}
	}
}
