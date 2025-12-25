using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentScheduleGrp : IFixComponent
	{
		public sealed partial class NoPaymentSchedules : IFixGroup
		{
			[TagDetails(Tag = 40829, Type = TagType.Int, Offset = 0, Required = false)]
			public int? PaymentScheduleType {get; set;}
			
			[TagDetails(Tag = 41164, Type = TagType.String, Offset = 1, Required = false)]
			public string? PaymentScheduleXID {get; set;}
			
			[TagDetails(Tag = 41165, Type = TagType.String, Offset = 2, Required = false)]
			public string? PaymentScheduleXIDRef {get; set;}
			
			[TagDetails(Tag = 40830, Type = TagType.Int, Offset = 3, Required = false)]
			public int? PaymentScheduleStubType {get; set;}
			
			[TagDetails(Tag = 40831, Type = TagType.LocalDate, Offset = 4, Required = false)]
			public DateOnly? PaymentScheduleStartDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 40832, Type = TagType.LocalDate, Offset = 5, Required = false)]
			public DateOnly? PaymentScheduleEndDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 40833, Type = TagType.Int, Offset = 6, Required = false)]
			public int? PaymentSchedulePaySide {get; set;}
			
			[TagDetails(Tag = 40834, Type = TagType.Int, Offset = 7, Required = false)]
			public int? PaymentScheduleReceiveSide {get; set;}
			
			[TagDetails(Tag = 40835, Type = TagType.Float, Offset = 8, Required = false)]
			public double? PaymentScheduleNotional {get; set;}
			
			[TagDetails(Tag = 40836, Type = TagType.String, Offset = 9, Required = false)]
			public string? PaymentScheduleCurrency {get; set;}
			
			[TagDetails(Tag = 40837, Type = TagType.Float, Offset = 10, Required = false)]
			public double? PaymentScheduleRate {get; set;}
			
			[TagDetails(Tag = 40838, Type = TagType.Float, Offset = 11, Required = false)]
			public double? PaymentScheduleRateMultiplier {get; set;}
			
			[TagDetails(Tag = 40839, Type = TagType.Float, Offset = 12, Required = false)]
			public double? PaymentScheduleRateSpread {get; set;}
			
			[TagDetails(Tag = 41166, Type = TagType.String, Offset = 13, Required = false)]
			public string? PaymentScheduleRateCurrency {get; set;}
			
			[TagDetails(Tag = 41167, Type = TagType.String, Offset = 14, Required = false)]
			public string? PaymentScheduleRateUnitOfMeasure {get; set;}
			
			[TagDetails(Tag = 41168, Type = TagType.Float, Offset = 15, Required = false)]
			public double? PaymentScheduleRateConversionFactor {get; set;}
			
			[TagDetails(Tag = 41169, Type = TagType.Int, Offset = 16, Required = false)]
			public int? PaymentScheduleRateSpreadType {get; set;}
			
			[TagDetails(Tag = 40840, Type = TagType.Int, Offset = 17, Required = false)]
			public int? PaymentScheduleRateSpreadPositionType {get; set;}
			
			[TagDetails(Tag = 40841, Type = TagType.Int, Offset = 18, Required = false)]
			public int? PaymentScheduleRateTreatment {get; set;}
			
			[TagDetails(Tag = 40842, Type = TagType.Float, Offset = 19, Required = false)]
			public double? PaymentScheduleFixedAmount {get; set;}
			
			[TagDetails(Tag = 40843, Type = TagType.String, Offset = 20, Required = false)]
			public string? PaymentScheduleFixedCurrency {get; set;}
			
			[TagDetails(Tag = 41170, Type = TagType.Float, Offset = 21, Required = false)]
			public double? PaymentScheduleSettlPeriodPrice {get; set;}
			
			[TagDetails(Tag = 41171, Type = TagType.String, Offset = 22, Required = false)]
			public string? PaymentScheduleSettlPeriodPriceCurrency {get; set;}
			
			[TagDetails(Tag = 41172, Type = TagType.String, Offset = 23, Required = false)]
			public string? PaymentScheduleSettlPeriodPriceUnitOfMeasure {get; set;}
			
			[TagDetails(Tag = 41173, Type = TagType.String, Offset = 24, Required = false)]
			public string? PaymentScheduleStepUnitOfMeasure {get; set;}
			
			[TagDetails(Tag = 40844, Type = TagType.Int, Offset = 25, Required = false)]
			public int? PaymentScheduleStepFrequencyPeriod {get; set;}
			
			[TagDetails(Tag = 40845, Type = TagType.String, Offset = 26, Required = false)]
			public string? PaymentScheduleStepFrequencyUnit {get; set;}
			
			[TagDetails(Tag = 40846, Type = TagType.Float, Offset = 27, Required = false)]
			public double? PaymentScheduleStepOffsetValue {get; set;}
			
			[TagDetails(Tag = 40847, Type = TagType.Float, Offset = 28, Required = false)]
			public double? PaymentScheduleStepRate {get; set;}
			
			[TagDetails(Tag = 40848, Type = TagType.Float, Offset = 29, Required = false)]
			public double? PaymentScheduleStepOffsetRate {get; set;}
			
			[TagDetails(Tag = 40849, Type = TagType.Int, Offset = 30, Required = false)]
			public int? PaymentScheduleStepRelativeTo {get; set;}
			
			[Component(Offset = 31, Required = false)]
			public PaymentScheduleRateSourceGrp? PaymentScheduleRateSourceGrp {get; set;}
			
			[TagDetails(Tag = 40850, Type = TagType.LocalDate, Offset = 32, Required = false)]
			public DateOnly? PaymentScheduleFixingDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 40851, Type = TagType.Float, Offset = 33, Required = false)]
			public double? PaymentScheduleWeight {get; set;}
			
			[TagDetails(Tag = 40852, Type = TagType.Int, Offset = 34, Required = false)]
			public int? PaymentScheduleFixingDateRelativeTo {get; set;}
			
			[TagDetails(Tag = 40853, Type = TagType.Int, Offset = 35, Required = false)]
			public int? PaymentScheduleFixingDateBusinessDayConvention {get; set;}
			
			[Component(Offset = 36, Required = false)]
			public PaymentScheduleFixingDateBusinessCenterGrp? PaymentScheduleFixingDateBusinessCenterGrp {get; set;}
			
			[TagDetails(Tag = 40855, Type = TagType.Int, Offset = 37, Required = false)]
			public int? PaymentScheduleFixingDateOffsetPeriod {get; set;}
			
			[TagDetails(Tag = 40856, Type = TagType.String, Offset = 38, Required = false)]
			public string? PaymentScheduleFixingDateOffsetUnit {get; set;}
			
			[TagDetails(Tag = 40857, Type = TagType.Int, Offset = 39, Required = false)]
			public int? PaymentScheduleFixingDateOffsetDayType {get; set;}
			
			[TagDetails(Tag = 41174, Type = TagType.Int, Offset = 40, Required = false)]
			public int? PaymentScheduleFixingDayDistribution {get; set;}
			
			[TagDetails(Tag = 41175, Type = TagType.Int, Offset = 41, Required = false)]
			public int? PaymentScheduleFixingDayCount {get; set;}
			
			[TagDetails(Tag = 40858, Type = TagType.LocalDate, Offset = 42, Required = false)]
			public DateOnly? PaymentScheduleFixingDateAdjusted {get; set;}
			
			[Component(Offset = 43, Required = false)]
			public PaymentScheduleFixingDayGrp? PaymentScheduleFixingDayGrp {get; set;}
			
			[TagDetails(Tag = 41176, Type = TagType.Int, Offset = 44, Required = false)]
			public int? PaymentScheduleFixingLagPeriod {get; set;}
			
			[TagDetails(Tag = 41177, Type = TagType.String, Offset = 45, Required = false)]
			public string? PaymentScheduleFixingLagUnit {get; set;}
			
			[TagDetails(Tag = 41178, Type = TagType.Int, Offset = 46, Required = false)]
			public int? PaymentScheduleFixingFirstObservationDateOffsetPeriod {get; set;}
			
			[TagDetails(Tag = 41179, Type = TagType.String, Offset = 47, Required = false)]
			public string? PaymentScheduleFixingFirstObservationDateOffsetUnit {get; set;}
			
			[TagDetails(Tag = 40859, Type = TagType.String, Offset = 48, Required = false)]
			public string? PaymentScheduleFixingTime {get; set;}
			
			[TagDetails(Tag = 40860, Type = TagType.String, Offset = 49, Required = false)]
			public string? PaymentScheduleFixingTimeBusinessCenter {get; set;}
			
			[TagDetails(Tag = 40861, Type = TagType.Int, Offset = 50, Required = false)]
			public int? PaymentScheduleInterimExchangePaymentDateRelativeTo {get; set;}
			
			[TagDetails(Tag = 40862, Type = TagType.Int, Offset = 51, Required = false)]
			public int? PaymentScheduleInterimExchangeDatesBusinessDayConvention {get; set;}
			
			[Component(Offset = 52, Required = false)]
			public PaymentScheduleInterimExchangeDateBusinessCenterGrp? PaymentScheduleInterimExchangeDateBusinessCenterGrp {get; set;}
			
			[TagDetails(Tag = 40864, Type = TagType.Int, Offset = 53, Required = false)]
			public int? PaymentScheduleInterimExchangeDatesOffsetPeriod {get; set;}
			
			[TagDetails(Tag = 40865, Type = TagType.String, Offset = 54, Required = false)]
			public string? PaymentScheduleInterimExchangeDatesOffsetUnit {get; set;}
			
			[TagDetails(Tag = 40866, Type = TagType.Int, Offset = 55, Required = false)]
			public int? PaymentScheduleInterimExchangeDatesOffsetDayType {get; set;}
			
			[TagDetails(Tag = 40867, Type = TagType.LocalDate, Offset = 56, Required = false)]
			public DateOnly? PaymentScheduleInterimExchangeDateAdjusted {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PaymentScheduleType is not null) writer.WriteWholeNumber(40829, PaymentScheduleType.Value);
				if (PaymentScheduleXID is not null) writer.WriteString(41164, PaymentScheduleXID);
				if (PaymentScheduleXIDRef is not null) writer.WriteString(41165, PaymentScheduleXIDRef);
				if (PaymentScheduleStubType is not null) writer.WriteWholeNumber(40830, PaymentScheduleStubType.Value);
				if (PaymentScheduleStartDateUnadjusted is not null) writer.WriteLocalDateOnly(40831, PaymentScheduleStartDateUnadjusted.Value);
				if (PaymentScheduleEndDateUnadjusted is not null) writer.WriteLocalDateOnly(40832, PaymentScheduleEndDateUnadjusted.Value);
				if (PaymentSchedulePaySide is not null) writer.WriteWholeNumber(40833, PaymentSchedulePaySide.Value);
				if (PaymentScheduleReceiveSide is not null) writer.WriteWholeNumber(40834, PaymentScheduleReceiveSide.Value);
				if (PaymentScheduleNotional is not null) writer.WriteNumber(40835, PaymentScheduleNotional.Value);
				if (PaymentScheduleCurrency is not null) writer.WriteString(40836, PaymentScheduleCurrency);
				if (PaymentScheduleRate is not null) writer.WriteNumber(40837, PaymentScheduleRate.Value);
				if (PaymentScheduleRateMultiplier is not null) writer.WriteNumber(40838, PaymentScheduleRateMultiplier.Value);
				if (PaymentScheduleRateSpread is not null) writer.WriteNumber(40839, PaymentScheduleRateSpread.Value);
				if (PaymentScheduleRateCurrency is not null) writer.WriteString(41166, PaymentScheduleRateCurrency);
				if (PaymentScheduleRateUnitOfMeasure is not null) writer.WriteString(41167, PaymentScheduleRateUnitOfMeasure);
				if (PaymentScheduleRateConversionFactor is not null) writer.WriteNumber(41168, PaymentScheduleRateConversionFactor.Value);
				if (PaymentScheduleRateSpreadType is not null) writer.WriteWholeNumber(41169, PaymentScheduleRateSpreadType.Value);
				if (PaymentScheduleRateSpreadPositionType is not null) writer.WriteWholeNumber(40840, PaymentScheduleRateSpreadPositionType.Value);
				if (PaymentScheduleRateTreatment is not null) writer.WriteWholeNumber(40841, PaymentScheduleRateTreatment.Value);
				if (PaymentScheduleFixedAmount is not null) writer.WriteNumber(40842, PaymentScheduleFixedAmount.Value);
				if (PaymentScheduleFixedCurrency is not null) writer.WriteString(40843, PaymentScheduleFixedCurrency);
				if (PaymentScheduleSettlPeriodPrice is not null) writer.WriteNumber(41170, PaymentScheduleSettlPeriodPrice.Value);
				if (PaymentScheduleSettlPeriodPriceCurrency is not null) writer.WriteString(41171, PaymentScheduleSettlPeriodPriceCurrency);
				if (PaymentScheduleSettlPeriodPriceUnitOfMeasure is not null) writer.WriteString(41172, PaymentScheduleSettlPeriodPriceUnitOfMeasure);
				if (PaymentScheduleStepUnitOfMeasure is not null) writer.WriteString(41173, PaymentScheduleStepUnitOfMeasure);
				if (PaymentScheduleStepFrequencyPeriod is not null) writer.WriteWholeNumber(40844, PaymentScheduleStepFrequencyPeriod.Value);
				if (PaymentScheduleStepFrequencyUnit is not null) writer.WriteString(40845, PaymentScheduleStepFrequencyUnit);
				if (PaymentScheduleStepOffsetValue is not null) writer.WriteNumber(40846, PaymentScheduleStepOffsetValue.Value);
				if (PaymentScheduleStepRate is not null) writer.WriteNumber(40847, PaymentScheduleStepRate.Value);
				if (PaymentScheduleStepOffsetRate is not null) writer.WriteNumber(40848, PaymentScheduleStepOffsetRate.Value);
				if (PaymentScheduleStepRelativeTo is not null) writer.WriteWholeNumber(40849, PaymentScheduleStepRelativeTo.Value);
				if (PaymentScheduleRateSourceGrp is not null) ((IFixEncoder)PaymentScheduleRateSourceGrp).Encode(writer);
				if (PaymentScheduleFixingDateUnadjusted is not null) writer.WriteLocalDateOnly(40850, PaymentScheduleFixingDateUnadjusted.Value);
				if (PaymentScheduleWeight is not null) writer.WriteNumber(40851, PaymentScheduleWeight.Value);
				if (PaymentScheduleFixingDateRelativeTo is not null) writer.WriteWholeNumber(40852, PaymentScheduleFixingDateRelativeTo.Value);
				if (PaymentScheduleFixingDateBusinessDayConvention is not null) writer.WriteWholeNumber(40853, PaymentScheduleFixingDateBusinessDayConvention.Value);
				if (PaymentScheduleFixingDateBusinessCenterGrp is not null) ((IFixEncoder)PaymentScheduleFixingDateBusinessCenterGrp).Encode(writer);
				if (PaymentScheduleFixingDateOffsetPeriod is not null) writer.WriteWholeNumber(40855, PaymentScheduleFixingDateOffsetPeriod.Value);
				if (PaymentScheduleFixingDateOffsetUnit is not null) writer.WriteString(40856, PaymentScheduleFixingDateOffsetUnit);
				if (PaymentScheduleFixingDateOffsetDayType is not null) writer.WriteWholeNumber(40857, PaymentScheduleFixingDateOffsetDayType.Value);
				if (PaymentScheduleFixingDayDistribution is not null) writer.WriteWholeNumber(41174, PaymentScheduleFixingDayDistribution.Value);
				if (PaymentScheduleFixingDayCount is not null) writer.WriteWholeNumber(41175, PaymentScheduleFixingDayCount.Value);
				if (PaymentScheduleFixingDateAdjusted is not null) writer.WriteLocalDateOnly(40858, PaymentScheduleFixingDateAdjusted.Value);
				if (PaymentScheduleFixingDayGrp is not null) ((IFixEncoder)PaymentScheduleFixingDayGrp).Encode(writer);
				if (PaymentScheduleFixingLagPeriod is not null) writer.WriteWholeNumber(41176, PaymentScheduleFixingLagPeriod.Value);
				if (PaymentScheduleFixingLagUnit is not null) writer.WriteString(41177, PaymentScheduleFixingLagUnit);
				if (PaymentScheduleFixingFirstObservationDateOffsetPeriod is not null) writer.WriteWholeNumber(41178, PaymentScheduleFixingFirstObservationDateOffsetPeriod.Value);
				if (PaymentScheduleFixingFirstObservationDateOffsetUnit is not null) writer.WriteString(41179, PaymentScheduleFixingFirstObservationDateOffsetUnit);
				if (PaymentScheduleFixingTime is not null) writer.WriteString(40859, PaymentScheduleFixingTime);
				if (PaymentScheduleFixingTimeBusinessCenter is not null) writer.WriteString(40860, PaymentScheduleFixingTimeBusinessCenter);
				if (PaymentScheduleInterimExchangePaymentDateRelativeTo is not null) writer.WriteWholeNumber(40861, PaymentScheduleInterimExchangePaymentDateRelativeTo.Value);
				if (PaymentScheduleInterimExchangeDatesBusinessDayConvention is not null) writer.WriteWholeNumber(40862, PaymentScheduleInterimExchangeDatesBusinessDayConvention.Value);
				if (PaymentScheduleInterimExchangeDateBusinessCenterGrp is not null) ((IFixEncoder)PaymentScheduleInterimExchangeDateBusinessCenterGrp).Encode(writer);
				if (PaymentScheduleInterimExchangeDatesOffsetPeriod is not null) writer.WriteWholeNumber(40864, PaymentScheduleInterimExchangeDatesOffsetPeriod.Value);
				if (PaymentScheduleInterimExchangeDatesOffsetUnit is not null) writer.WriteString(40865, PaymentScheduleInterimExchangeDatesOffsetUnit);
				if (PaymentScheduleInterimExchangeDatesOffsetDayType is not null) writer.WriteWholeNumber(40866, PaymentScheduleInterimExchangeDatesOffsetDayType.Value);
				if (PaymentScheduleInterimExchangeDateAdjusted is not null) writer.WriteLocalDateOnly(40867, PaymentScheduleInterimExchangeDateAdjusted.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PaymentScheduleType = view.GetInt32(40829);
				PaymentScheduleXID = view.GetString(41164);
				PaymentScheduleXIDRef = view.GetString(41165);
				PaymentScheduleStubType = view.GetInt32(40830);
				PaymentScheduleStartDateUnadjusted = view.GetDateOnly(40831);
				PaymentScheduleEndDateUnadjusted = view.GetDateOnly(40832);
				PaymentSchedulePaySide = view.GetInt32(40833);
				PaymentScheduleReceiveSide = view.GetInt32(40834);
				PaymentScheduleNotional = view.GetDouble(40835);
				PaymentScheduleCurrency = view.GetString(40836);
				PaymentScheduleRate = view.GetDouble(40837);
				PaymentScheduleRateMultiplier = view.GetDouble(40838);
				PaymentScheduleRateSpread = view.GetDouble(40839);
				PaymentScheduleRateCurrency = view.GetString(41166);
				PaymentScheduleRateUnitOfMeasure = view.GetString(41167);
				PaymentScheduleRateConversionFactor = view.GetDouble(41168);
				PaymentScheduleRateSpreadType = view.GetInt32(41169);
				PaymentScheduleRateSpreadPositionType = view.GetInt32(40840);
				PaymentScheduleRateTreatment = view.GetInt32(40841);
				PaymentScheduleFixedAmount = view.GetDouble(40842);
				PaymentScheduleFixedCurrency = view.GetString(40843);
				PaymentScheduleSettlPeriodPrice = view.GetDouble(41170);
				PaymentScheduleSettlPeriodPriceCurrency = view.GetString(41171);
				PaymentScheduleSettlPeriodPriceUnitOfMeasure = view.GetString(41172);
				PaymentScheduleStepUnitOfMeasure = view.GetString(41173);
				PaymentScheduleStepFrequencyPeriod = view.GetInt32(40844);
				PaymentScheduleStepFrequencyUnit = view.GetString(40845);
				PaymentScheduleStepOffsetValue = view.GetDouble(40846);
				PaymentScheduleStepRate = view.GetDouble(40847);
				PaymentScheduleStepOffsetRate = view.GetDouble(40848);
				PaymentScheduleStepRelativeTo = view.GetInt32(40849);
				if (view.GetView("PaymentScheduleRateSourceGrp") is IMessageView viewPaymentScheduleRateSourceGrp)
				{
					PaymentScheduleRateSourceGrp = new();
					((IFixParser)PaymentScheduleRateSourceGrp).Parse(viewPaymentScheduleRateSourceGrp);
				}
				PaymentScheduleFixingDateUnadjusted = view.GetDateOnly(40850);
				PaymentScheduleWeight = view.GetDouble(40851);
				PaymentScheduleFixingDateRelativeTo = view.GetInt32(40852);
				PaymentScheduleFixingDateBusinessDayConvention = view.GetInt32(40853);
				if (view.GetView("PaymentScheduleFixingDateBusinessCenterGrp") is IMessageView viewPaymentScheduleFixingDateBusinessCenterGrp)
				{
					PaymentScheduleFixingDateBusinessCenterGrp = new();
					((IFixParser)PaymentScheduleFixingDateBusinessCenterGrp).Parse(viewPaymentScheduleFixingDateBusinessCenterGrp);
				}
				PaymentScheduleFixingDateOffsetPeriod = view.GetInt32(40855);
				PaymentScheduleFixingDateOffsetUnit = view.GetString(40856);
				PaymentScheduleFixingDateOffsetDayType = view.GetInt32(40857);
				PaymentScheduleFixingDayDistribution = view.GetInt32(41174);
				PaymentScheduleFixingDayCount = view.GetInt32(41175);
				PaymentScheduleFixingDateAdjusted = view.GetDateOnly(40858);
				if (view.GetView("PaymentScheduleFixingDayGrp") is IMessageView viewPaymentScheduleFixingDayGrp)
				{
					PaymentScheduleFixingDayGrp = new();
					((IFixParser)PaymentScheduleFixingDayGrp).Parse(viewPaymentScheduleFixingDayGrp);
				}
				PaymentScheduleFixingLagPeriod = view.GetInt32(41176);
				PaymentScheduleFixingLagUnit = view.GetString(41177);
				PaymentScheduleFixingFirstObservationDateOffsetPeriod = view.GetInt32(41178);
				PaymentScheduleFixingFirstObservationDateOffsetUnit = view.GetString(41179);
				PaymentScheduleFixingTime = view.GetString(40859);
				PaymentScheduleFixingTimeBusinessCenter = view.GetString(40860);
				PaymentScheduleInterimExchangePaymentDateRelativeTo = view.GetInt32(40861);
				PaymentScheduleInterimExchangeDatesBusinessDayConvention = view.GetInt32(40862);
				if (view.GetView("PaymentScheduleInterimExchangeDateBusinessCenterGrp") is IMessageView viewPaymentScheduleInterimExchangeDateBusinessCenterGrp)
				{
					PaymentScheduleInterimExchangeDateBusinessCenterGrp = new();
					((IFixParser)PaymentScheduleInterimExchangeDateBusinessCenterGrp).Parse(viewPaymentScheduleInterimExchangeDateBusinessCenterGrp);
				}
				PaymentScheduleInterimExchangeDatesOffsetPeriod = view.GetInt32(40864);
				PaymentScheduleInterimExchangeDatesOffsetUnit = view.GetString(40865);
				PaymentScheduleInterimExchangeDatesOffsetDayType = view.GetInt32(40866);
				PaymentScheduleInterimExchangeDateAdjusted = view.GetDateOnly(40867);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PaymentScheduleType":
					{
						value = PaymentScheduleType;
						break;
					}
					case "PaymentScheduleXID":
					{
						value = PaymentScheduleXID;
						break;
					}
					case "PaymentScheduleXIDRef":
					{
						value = PaymentScheduleXIDRef;
						break;
					}
					case "PaymentScheduleStubType":
					{
						value = PaymentScheduleStubType;
						break;
					}
					case "PaymentScheduleStartDateUnadjusted":
					{
						value = PaymentScheduleStartDateUnadjusted;
						break;
					}
					case "PaymentScheduleEndDateUnadjusted":
					{
						value = PaymentScheduleEndDateUnadjusted;
						break;
					}
					case "PaymentSchedulePaySide":
					{
						value = PaymentSchedulePaySide;
						break;
					}
					case "PaymentScheduleReceiveSide":
					{
						value = PaymentScheduleReceiveSide;
						break;
					}
					case "PaymentScheduleNotional":
					{
						value = PaymentScheduleNotional;
						break;
					}
					case "PaymentScheduleCurrency":
					{
						value = PaymentScheduleCurrency;
						break;
					}
					case "PaymentScheduleRate":
					{
						value = PaymentScheduleRate;
						break;
					}
					case "PaymentScheduleRateMultiplier":
					{
						value = PaymentScheduleRateMultiplier;
						break;
					}
					case "PaymentScheduleRateSpread":
					{
						value = PaymentScheduleRateSpread;
						break;
					}
					case "PaymentScheduleRateCurrency":
					{
						value = PaymentScheduleRateCurrency;
						break;
					}
					case "PaymentScheduleRateUnitOfMeasure":
					{
						value = PaymentScheduleRateUnitOfMeasure;
						break;
					}
					case "PaymentScheduleRateConversionFactor":
					{
						value = PaymentScheduleRateConversionFactor;
						break;
					}
					case "PaymentScheduleRateSpreadType":
					{
						value = PaymentScheduleRateSpreadType;
						break;
					}
					case "PaymentScheduleRateSpreadPositionType":
					{
						value = PaymentScheduleRateSpreadPositionType;
						break;
					}
					case "PaymentScheduleRateTreatment":
					{
						value = PaymentScheduleRateTreatment;
						break;
					}
					case "PaymentScheduleFixedAmount":
					{
						value = PaymentScheduleFixedAmount;
						break;
					}
					case "PaymentScheduleFixedCurrency":
					{
						value = PaymentScheduleFixedCurrency;
						break;
					}
					case "PaymentScheduleSettlPeriodPrice":
					{
						value = PaymentScheduleSettlPeriodPrice;
						break;
					}
					case "PaymentScheduleSettlPeriodPriceCurrency":
					{
						value = PaymentScheduleSettlPeriodPriceCurrency;
						break;
					}
					case "PaymentScheduleSettlPeriodPriceUnitOfMeasure":
					{
						value = PaymentScheduleSettlPeriodPriceUnitOfMeasure;
						break;
					}
					case "PaymentScheduleStepUnitOfMeasure":
					{
						value = PaymentScheduleStepUnitOfMeasure;
						break;
					}
					case "PaymentScheduleStepFrequencyPeriod":
					{
						value = PaymentScheduleStepFrequencyPeriod;
						break;
					}
					case "PaymentScheduleStepFrequencyUnit":
					{
						value = PaymentScheduleStepFrequencyUnit;
						break;
					}
					case "PaymentScheduleStepOffsetValue":
					{
						value = PaymentScheduleStepOffsetValue;
						break;
					}
					case "PaymentScheduleStepRate":
					{
						value = PaymentScheduleStepRate;
						break;
					}
					case "PaymentScheduleStepOffsetRate":
					{
						value = PaymentScheduleStepOffsetRate;
						break;
					}
					case "PaymentScheduleStepRelativeTo":
					{
						value = PaymentScheduleStepRelativeTo;
						break;
					}
					case "PaymentScheduleRateSourceGrp":
					{
						value = PaymentScheduleRateSourceGrp;
						break;
					}
					case "PaymentScheduleFixingDateUnadjusted":
					{
						value = PaymentScheduleFixingDateUnadjusted;
						break;
					}
					case "PaymentScheduleWeight":
					{
						value = PaymentScheduleWeight;
						break;
					}
					case "PaymentScheduleFixingDateRelativeTo":
					{
						value = PaymentScheduleFixingDateRelativeTo;
						break;
					}
					case "PaymentScheduleFixingDateBusinessDayConvention":
					{
						value = PaymentScheduleFixingDateBusinessDayConvention;
						break;
					}
					case "PaymentScheduleFixingDateBusinessCenterGrp":
					{
						value = PaymentScheduleFixingDateBusinessCenterGrp;
						break;
					}
					case "PaymentScheduleFixingDateOffsetPeriod":
					{
						value = PaymentScheduleFixingDateOffsetPeriod;
						break;
					}
					case "PaymentScheduleFixingDateOffsetUnit":
					{
						value = PaymentScheduleFixingDateOffsetUnit;
						break;
					}
					case "PaymentScheduleFixingDateOffsetDayType":
					{
						value = PaymentScheduleFixingDateOffsetDayType;
						break;
					}
					case "PaymentScheduleFixingDayDistribution":
					{
						value = PaymentScheduleFixingDayDistribution;
						break;
					}
					case "PaymentScheduleFixingDayCount":
					{
						value = PaymentScheduleFixingDayCount;
						break;
					}
					case "PaymentScheduleFixingDateAdjusted":
					{
						value = PaymentScheduleFixingDateAdjusted;
						break;
					}
					case "PaymentScheduleFixingDayGrp":
					{
						value = PaymentScheduleFixingDayGrp;
						break;
					}
					case "PaymentScheduleFixingLagPeriod":
					{
						value = PaymentScheduleFixingLagPeriod;
						break;
					}
					case "PaymentScheduleFixingLagUnit":
					{
						value = PaymentScheduleFixingLagUnit;
						break;
					}
					case "PaymentScheduleFixingFirstObservationDateOffsetPeriod":
					{
						value = PaymentScheduleFixingFirstObservationDateOffsetPeriod;
						break;
					}
					case "PaymentScheduleFixingFirstObservationDateOffsetUnit":
					{
						value = PaymentScheduleFixingFirstObservationDateOffsetUnit;
						break;
					}
					case "PaymentScheduleFixingTime":
					{
						value = PaymentScheduleFixingTime;
						break;
					}
					case "PaymentScheduleFixingTimeBusinessCenter":
					{
						value = PaymentScheduleFixingTimeBusinessCenter;
						break;
					}
					case "PaymentScheduleInterimExchangePaymentDateRelativeTo":
					{
						value = PaymentScheduleInterimExchangePaymentDateRelativeTo;
						break;
					}
					case "PaymentScheduleInterimExchangeDatesBusinessDayConvention":
					{
						value = PaymentScheduleInterimExchangeDatesBusinessDayConvention;
						break;
					}
					case "PaymentScheduleInterimExchangeDateBusinessCenterGrp":
					{
						value = PaymentScheduleInterimExchangeDateBusinessCenterGrp;
						break;
					}
					case "PaymentScheduleInterimExchangeDatesOffsetPeriod":
					{
						value = PaymentScheduleInterimExchangeDatesOffsetPeriod;
						break;
					}
					case "PaymentScheduleInterimExchangeDatesOffsetUnit":
					{
						value = PaymentScheduleInterimExchangeDatesOffsetUnit;
						break;
					}
					case "PaymentScheduleInterimExchangeDatesOffsetDayType":
					{
						value = PaymentScheduleInterimExchangeDatesOffsetDayType;
						break;
					}
					case "PaymentScheduleInterimExchangeDateAdjusted":
					{
						value = PaymentScheduleInterimExchangeDateAdjusted;
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
				PaymentScheduleType = null;
				PaymentScheduleXID = null;
				PaymentScheduleXIDRef = null;
				PaymentScheduleStubType = null;
				PaymentScheduleStartDateUnadjusted = null;
				PaymentScheduleEndDateUnadjusted = null;
				PaymentSchedulePaySide = null;
				PaymentScheduleReceiveSide = null;
				PaymentScheduleNotional = null;
				PaymentScheduleCurrency = null;
				PaymentScheduleRate = null;
				PaymentScheduleRateMultiplier = null;
				PaymentScheduleRateSpread = null;
				PaymentScheduleRateCurrency = null;
				PaymentScheduleRateUnitOfMeasure = null;
				PaymentScheduleRateConversionFactor = null;
				PaymentScheduleRateSpreadType = null;
				PaymentScheduleRateSpreadPositionType = null;
				PaymentScheduleRateTreatment = null;
				PaymentScheduleFixedAmount = null;
				PaymentScheduleFixedCurrency = null;
				PaymentScheduleSettlPeriodPrice = null;
				PaymentScheduleSettlPeriodPriceCurrency = null;
				PaymentScheduleSettlPeriodPriceUnitOfMeasure = null;
				PaymentScheduleStepUnitOfMeasure = null;
				PaymentScheduleStepFrequencyPeriod = null;
				PaymentScheduleStepFrequencyUnit = null;
				PaymentScheduleStepOffsetValue = null;
				PaymentScheduleStepRate = null;
				PaymentScheduleStepOffsetRate = null;
				PaymentScheduleStepRelativeTo = null;
				((IFixReset?)PaymentScheduleRateSourceGrp)?.Reset();
				PaymentScheduleFixingDateUnadjusted = null;
				PaymentScheduleWeight = null;
				PaymentScheduleFixingDateRelativeTo = null;
				PaymentScheduleFixingDateBusinessDayConvention = null;
				((IFixReset?)PaymentScheduleFixingDateBusinessCenterGrp)?.Reset();
				PaymentScheduleFixingDateOffsetPeriod = null;
				PaymentScheduleFixingDateOffsetUnit = null;
				PaymentScheduleFixingDateOffsetDayType = null;
				PaymentScheduleFixingDayDistribution = null;
				PaymentScheduleFixingDayCount = null;
				PaymentScheduleFixingDateAdjusted = null;
				((IFixReset?)PaymentScheduleFixingDayGrp)?.Reset();
				PaymentScheduleFixingLagPeriod = null;
				PaymentScheduleFixingLagUnit = null;
				PaymentScheduleFixingFirstObservationDateOffsetPeriod = null;
				PaymentScheduleFixingFirstObservationDateOffsetUnit = null;
				PaymentScheduleFixingTime = null;
				PaymentScheduleFixingTimeBusinessCenter = null;
				PaymentScheduleInterimExchangePaymentDateRelativeTo = null;
				PaymentScheduleInterimExchangeDatesBusinessDayConvention = null;
				((IFixReset?)PaymentScheduleInterimExchangeDateBusinessCenterGrp)?.Reset();
				PaymentScheduleInterimExchangeDatesOffsetPeriod = null;
				PaymentScheduleInterimExchangeDatesOffsetUnit = null;
				PaymentScheduleInterimExchangeDatesOffsetDayType = null;
				PaymentScheduleInterimExchangeDateAdjusted = null;
			}
		}
		[Group(NoOfTag = 40828, Offset = 0, Required = false)]
		public NoPaymentSchedules[]? PaymentSchedules {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentSchedules is not null && PaymentSchedules.Length != 0)
			{
				writer.WriteWholeNumber(40828, PaymentSchedules.Length);
				for (int i = 0; i < PaymentSchedules.Length; i++)
				{
					((IFixEncoder)PaymentSchedules[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPaymentSchedules") is IMessageView viewNoPaymentSchedules)
			{
				var count = viewNoPaymentSchedules.GroupCount();
				PaymentSchedules = new NoPaymentSchedules[count];
				for (int i = 0; i < count; i++)
				{
					PaymentSchedules[i] = new();
					((IFixParser)PaymentSchedules[i]).Parse(viewNoPaymentSchedules.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPaymentSchedules":
				{
					value = PaymentSchedules;
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
			PaymentSchedules = null;
		}
	}
}
