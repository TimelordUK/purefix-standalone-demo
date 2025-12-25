using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentScheduleGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingPaymentSchedules : IFixGroup
		{
			[TagDetails(Tag = 40665, Type = TagType.Int, Offset = 0, Required = false)]
			public int? UnderlyingPaymentScheduleType {get; set;}
			
			[TagDetails(Tag = 41881, Type = TagType.String, Offset = 1, Required = false)]
			public string? UnderlyingPaymentScheduleXID {get; set;}
			
			[TagDetails(Tag = 41882, Type = TagType.String, Offset = 2, Required = false)]
			public string? UnderlyingPaymentScheduleXIDRef {get; set;}
			
			[TagDetails(Tag = 40666, Type = TagType.Int, Offset = 3, Required = false)]
			public int? UnderlyingPaymentScheduleStubType {get; set;}
			
			[TagDetails(Tag = 40667, Type = TagType.LocalDate, Offset = 4, Required = false)]
			public DateOnly? UnderlyingPaymentScheduleStartDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 40668, Type = TagType.LocalDate, Offset = 5, Required = false)]
			public DateOnly? UnderlyingPaymentScheduleEndDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 40669, Type = TagType.Int, Offset = 6, Required = false)]
			public int? UnderlyingPaymentSchedulePaySide {get; set;}
			
			[TagDetails(Tag = 40670, Type = TagType.Int, Offset = 7, Required = false)]
			public int? UnderlyingPaymentScheduleReceiveSide {get; set;}
			
			[TagDetails(Tag = 40671, Type = TagType.Float, Offset = 8, Required = false)]
			public double? UnderlyingPaymentScheduleNotional {get; set;}
			
			[TagDetails(Tag = 40672, Type = TagType.String, Offset = 9, Required = false)]
			public string? UnderlyingPaymentScheduleCurrency {get; set;}
			
			[TagDetails(Tag = 40673, Type = TagType.Float, Offset = 10, Required = false)]
			public double? UnderlyingPaymentScheduleRate {get; set;}
			
			[TagDetails(Tag = 40674, Type = TagType.Float, Offset = 11, Required = false)]
			public double? UnderlyingPaymentScheduleRateMultiplier {get; set;}
			
			[TagDetails(Tag = 40675, Type = TagType.Float, Offset = 12, Required = false)]
			public double? UnderlyingPaymentScheduleRateSpread {get; set;}
			
			[TagDetails(Tag = 41883, Type = TagType.String, Offset = 13, Required = false)]
			public string? UnderlyingPaymentScheduleRateCurrency {get; set;}
			
			[TagDetails(Tag = 41884, Type = TagType.String, Offset = 14, Required = false)]
			public string? UnderlyingPaymentScheduleRateUnitOfMeasure {get; set;}
			
			[TagDetails(Tag = 41885, Type = TagType.Float, Offset = 15, Required = false)]
			public double? UnderlyingPaymentScheduleRateConversionFactor {get; set;}
			
			[TagDetails(Tag = 41886, Type = TagType.Int, Offset = 16, Required = false)]
			public int? UnderlyingPaymentScheduleRateSpreadType {get; set;}
			
			[TagDetails(Tag = 40676, Type = TagType.Int, Offset = 17, Required = false)]
			public int? UnderlyingPaymentScheduleRateSpreadPositionType {get; set;}
			
			[TagDetails(Tag = 40677, Type = TagType.Int, Offset = 18, Required = false)]
			public int? UnderlyingPaymentScheduleRateTreatment {get; set;}
			
			[TagDetails(Tag = 40678, Type = TagType.Float, Offset = 19, Required = false)]
			public double? UnderlyingPaymentScheduleFixedAmount {get; set;}
			
			[TagDetails(Tag = 40679, Type = TagType.String, Offset = 20, Required = false)]
			public string? UnderlyingPaymentScheduleFixedCurrency {get; set;}
			
			[TagDetails(Tag = 41887, Type = TagType.Float, Offset = 21, Required = false)]
			public double? UnderlyingPaymentScheduleSettlPeriodPrice {get; set;}
			
			[TagDetails(Tag = 41888, Type = TagType.String, Offset = 22, Required = false)]
			public string? UnderlyingPaymentScheduleSettlPeriodPriceCurrency {get; set;}
			
			[TagDetails(Tag = 41889, Type = TagType.String, Offset = 23, Required = false)]
			public string? UnderlyingPaymentScheduleSettlPeriodPriceUnitOfMeasure {get; set;}
			
			[TagDetails(Tag = 41890, Type = TagType.String, Offset = 24, Required = false)]
			public string? UnderlyingPaymentScheduleStepUnitOfMeasure {get; set;}
			
			[TagDetails(Tag = 40680, Type = TagType.Int, Offset = 25, Required = false)]
			public int? UnderlyingPaymentScheduleStepFrequencyPeriod {get; set;}
			
			[TagDetails(Tag = 40681, Type = TagType.String, Offset = 26, Required = false)]
			public string? UnderlyingPaymentScheduleStepFrequencyUnit {get; set;}
			
			[TagDetails(Tag = 40682, Type = TagType.Float, Offset = 27, Required = false)]
			public double? UnderlyingPaymentScheduleStepOffsetValue {get; set;}
			
			[TagDetails(Tag = 40683, Type = TagType.Float, Offset = 28, Required = false)]
			public double? UnderlyingPaymentScheduleStepRate {get; set;}
			
			[TagDetails(Tag = 40684, Type = TagType.Float, Offset = 29, Required = false)]
			public double? UnderlyingPaymentScheduleStepOffsetRate {get; set;}
			
			[TagDetails(Tag = 40685, Type = TagType.Int, Offset = 30, Required = false)]
			public int? UnderlyingPaymentScheduleStepRelativeTo {get; set;}
			
			[Component(Offset = 31, Required = false)]
			public UnderlyingPaymentScheduleRateSourceGrp? UnderlyingPaymentScheduleRateSourceGrp {get; set;}
			
			[TagDetails(Tag = 40686, Type = TagType.LocalDate, Offset = 32, Required = false)]
			public DateOnly? UnderlyingPaymentScheduleFixingDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 40687, Type = TagType.Float, Offset = 33, Required = false)]
			public double? UnderlyingPaymentScheduleWeight {get; set;}
			
			[TagDetails(Tag = 40688, Type = TagType.Int, Offset = 34, Required = false)]
			public int? UnderlyingPaymentScheduleFixingDateRelativeTo {get; set;}
			
			[TagDetails(Tag = 40689, Type = TagType.Int, Offset = 35, Required = false)]
			public int? UnderlyingPaymentScheduleFixingDateBusinessDayCnvtn {get; set;}
			
			[Component(Offset = 36, Required = false)]
			public UnderlyingPaymentScheduleFixingDateBusinessCenterGrp? UnderlyingPaymentScheduleFixingDateBusinessCenterGrp {get; set;}
			
			[TagDetails(Tag = 40691, Type = TagType.Int, Offset = 37, Required = false)]
			public int? UnderlyingPaymentScheduleFixingDateOffsetPeriod {get; set;}
			
			[TagDetails(Tag = 40692, Type = TagType.String, Offset = 38, Required = false)]
			public string? UnderlyingPaymentScheduleFixingDateOffsetUnit {get; set;}
			
			[TagDetails(Tag = 40693, Type = TagType.Int, Offset = 39, Required = false)]
			public int? UnderlyingPaymentScheduleFixingDateOffsetDayType {get; set;}
			
			[TagDetails(Tag = 41891, Type = TagType.Int, Offset = 40, Required = false)]
			public int? UnderlyingPaymentScheduleFixingDayDistribution {get; set;}
			
			[TagDetails(Tag = 41892, Type = TagType.Int, Offset = 41, Required = false)]
			public int? UnderlyingPaymentScheduleFixingDayCount {get; set;}
			
			[TagDetails(Tag = 40694, Type = TagType.LocalDate, Offset = 42, Required = false)]
			public DateOnly? UnderlyingPaymentScheduleFixingDateAdjusted {get; set;}
			
			[Component(Offset = 43, Required = false)]
			public UnderlyingPaymentScheduleFixingDayGrp? UnderlyingPaymentScheduleFixingDayGrp {get; set;}
			
			[TagDetails(Tag = 41893, Type = TagType.Int, Offset = 44, Required = false)]
			public int? UnderlyingPaymentScheduleFixingLagPeriod {get; set;}
			
			[TagDetails(Tag = 41894, Type = TagType.String, Offset = 45, Required = false)]
			public string? UnderlyingPaymentScheduleFixingLagUnit {get; set;}
			
			[TagDetails(Tag = 41895, Type = TagType.Int, Offset = 46, Required = false)]
			public int? UnderlyingPaymentScheduleFixingFirstObservationDateOffsetPeriod {get; set;}
			
			[TagDetails(Tag = 41896, Type = TagType.String, Offset = 47, Required = false)]
			public string? UnderlyingPaymentScheduleFixingFirstObservationDateOffsetUnit {get; set;}
			
			[TagDetails(Tag = 40695, Type = TagType.String, Offset = 48, Required = false)]
			public string? UnderlyingPaymentScheduleFixingTime {get; set;}
			
			[TagDetails(Tag = 40696, Type = TagType.String, Offset = 49, Required = false)]
			public string? UnderlyingPaymentScheduleFixingTimeBusinessCenter {get; set;}
			
			[TagDetails(Tag = 40697, Type = TagType.Int, Offset = 50, Required = false)]
			public int? UnderlyingPaymentScheduleInterimExchangePaymentDateRelativeTo {get; set;}
			
			[TagDetails(Tag = 40698, Type = TagType.Int, Offset = 51, Required = false)]
			public int? UnderlyingPaymentScheduleInterimExchangeDatesBizDayConvention {get; set;}
			
			[Component(Offset = 52, Required = false)]
			public UnderlyingPaymentScheduleInterimExchangeDateBusinessCenterGrp? UnderlyingPaymentScheduleInterimExchangeDateBusinessCenterGrp {get; set;}
			
			[TagDetails(Tag = 40700, Type = TagType.Int, Offset = 53, Required = false)]
			public int? UnderlyingPaymentScheduleInterimExchangeDatesOffsetPeriod {get; set;}
			
			[TagDetails(Tag = 40701, Type = TagType.String, Offset = 54, Required = false)]
			public string? UnderlyingPaymentScheduleInterimExchangeDatesOffsetUnit {get; set;}
			
			[TagDetails(Tag = 40702, Type = TagType.Int, Offset = 55, Required = false)]
			public int? UnderlyingPaymentScheduleInterimExchangeDatesOffsetDayType {get; set;}
			
			[TagDetails(Tag = 40703, Type = TagType.LocalDate, Offset = 56, Required = false)]
			public DateOnly? UnderlyingPaymentScheduleInterimExchangeDateAdjusted {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingPaymentScheduleType is not null) writer.WriteWholeNumber(40665, UnderlyingPaymentScheduleType.Value);
				if (UnderlyingPaymentScheduleXID is not null) writer.WriteString(41881, UnderlyingPaymentScheduleXID);
				if (UnderlyingPaymentScheduleXIDRef is not null) writer.WriteString(41882, UnderlyingPaymentScheduleXIDRef);
				if (UnderlyingPaymentScheduleStubType is not null) writer.WriteWholeNumber(40666, UnderlyingPaymentScheduleStubType.Value);
				if (UnderlyingPaymentScheduleStartDateUnadjusted is not null) writer.WriteLocalDateOnly(40667, UnderlyingPaymentScheduleStartDateUnadjusted.Value);
				if (UnderlyingPaymentScheduleEndDateUnadjusted is not null) writer.WriteLocalDateOnly(40668, UnderlyingPaymentScheduleEndDateUnadjusted.Value);
				if (UnderlyingPaymentSchedulePaySide is not null) writer.WriteWholeNumber(40669, UnderlyingPaymentSchedulePaySide.Value);
				if (UnderlyingPaymentScheduleReceiveSide is not null) writer.WriteWholeNumber(40670, UnderlyingPaymentScheduleReceiveSide.Value);
				if (UnderlyingPaymentScheduleNotional is not null) writer.WriteNumber(40671, UnderlyingPaymentScheduleNotional.Value);
				if (UnderlyingPaymentScheduleCurrency is not null) writer.WriteString(40672, UnderlyingPaymentScheduleCurrency);
				if (UnderlyingPaymentScheduleRate is not null) writer.WriteNumber(40673, UnderlyingPaymentScheduleRate.Value);
				if (UnderlyingPaymentScheduleRateMultiplier is not null) writer.WriteNumber(40674, UnderlyingPaymentScheduleRateMultiplier.Value);
				if (UnderlyingPaymentScheduleRateSpread is not null) writer.WriteNumber(40675, UnderlyingPaymentScheduleRateSpread.Value);
				if (UnderlyingPaymentScheduleRateCurrency is not null) writer.WriteString(41883, UnderlyingPaymentScheduleRateCurrency);
				if (UnderlyingPaymentScheduleRateUnitOfMeasure is not null) writer.WriteString(41884, UnderlyingPaymentScheduleRateUnitOfMeasure);
				if (UnderlyingPaymentScheduleRateConversionFactor is not null) writer.WriteNumber(41885, UnderlyingPaymentScheduleRateConversionFactor.Value);
				if (UnderlyingPaymentScheduleRateSpreadType is not null) writer.WriteWholeNumber(41886, UnderlyingPaymentScheduleRateSpreadType.Value);
				if (UnderlyingPaymentScheduleRateSpreadPositionType is not null) writer.WriteWholeNumber(40676, UnderlyingPaymentScheduleRateSpreadPositionType.Value);
				if (UnderlyingPaymentScheduleRateTreatment is not null) writer.WriteWholeNumber(40677, UnderlyingPaymentScheduleRateTreatment.Value);
				if (UnderlyingPaymentScheduleFixedAmount is not null) writer.WriteNumber(40678, UnderlyingPaymentScheduleFixedAmount.Value);
				if (UnderlyingPaymentScheduleFixedCurrency is not null) writer.WriteString(40679, UnderlyingPaymentScheduleFixedCurrency);
				if (UnderlyingPaymentScheduleSettlPeriodPrice is not null) writer.WriteNumber(41887, UnderlyingPaymentScheduleSettlPeriodPrice.Value);
				if (UnderlyingPaymentScheduleSettlPeriodPriceCurrency is not null) writer.WriteString(41888, UnderlyingPaymentScheduleSettlPeriodPriceCurrency);
				if (UnderlyingPaymentScheduleSettlPeriodPriceUnitOfMeasure is not null) writer.WriteString(41889, UnderlyingPaymentScheduleSettlPeriodPriceUnitOfMeasure);
				if (UnderlyingPaymentScheduleStepUnitOfMeasure is not null) writer.WriteString(41890, UnderlyingPaymentScheduleStepUnitOfMeasure);
				if (UnderlyingPaymentScheduleStepFrequencyPeriod is not null) writer.WriteWholeNumber(40680, UnderlyingPaymentScheduleStepFrequencyPeriod.Value);
				if (UnderlyingPaymentScheduleStepFrequencyUnit is not null) writer.WriteString(40681, UnderlyingPaymentScheduleStepFrequencyUnit);
				if (UnderlyingPaymentScheduleStepOffsetValue is not null) writer.WriteNumber(40682, UnderlyingPaymentScheduleStepOffsetValue.Value);
				if (UnderlyingPaymentScheduleStepRate is not null) writer.WriteNumber(40683, UnderlyingPaymentScheduleStepRate.Value);
				if (UnderlyingPaymentScheduleStepOffsetRate is not null) writer.WriteNumber(40684, UnderlyingPaymentScheduleStepOffsetRate.Value);
				if (UnderlyingPaymentScheduleStepRelativeTo is not null) writer.WriteWholeNumber(40685, UnderlyingPaymentScheduleStepRelativeTo.Value);
				if (UnderlyingPaymentScheduleRateSourceGrp is not null) ((IFixEncoder)UnderlyingPaymentScheduleRateSourceGrp).Encode(writer);
				if (UnderlyingPaymentScheduleFixingDateUnadjusted is not null) writer.WriteLocalDateOnly(40686, UnderlyingPaymentScheduleFixingDateUnadjusted.Value);
				if (UnderlyingPaymentScheduleWeight is not null) writer.WriteNumber(40687, UnderlyingPaymentScheduleWeight.Value);
				if (UnderlyingPaymentScheduleFixingDateRelativeTo is not null) writer.WriteWholeNumber(40688, UnderlyingPaymentScheduleFixingDateRelativeTo.Value);
				if (UnderlyingPaymentScheduleFixingDateBusinessDayCnvtn is not null) writer.WriteWholeNumber(40689, UnderlyingPaymentScheduleFixingDateBusinessDayCnvtn.Value);
				if (UnderlyingPaymentScheduleFixingDateBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingPaymentScheduleFixingDateBusinessCenterGrp).Encode(writer);
				if (UnderlyingPaymentScheduleFixingDateOffsetPeriod is not null) writer.WriteWholeNumber(40691, UnderlyingPaymentScheduleFixingDateOffsetPeriod.Value);
				if (UnderlyingPaymentScheduleFixingDateOffsetUnit is not null) writer.WriteString(40692, UnderlyingPaymentScheduleFixingDateOffsetUnit);
				if (UnderlyingPaymentScheduleFixingDateOffsetDayType is not null) writer.WriteWholeNumber(40693, UnderlyingPaymentScheduleFixingDateOffsetDayType.Value);
				if (UnderlyingPaymentScheduleFixingDayDistribution is not null) writer.WriteWholeNumber(41891, UnderlyingPaymentScheduleFixingDayDistribution.Value);
				if (UnderlyingPaymentScheduleFixingDayCount is not null) writer.WriteWholeNumber(41892, UnderlyingPaymentScheduleFixingDayCount.Value);
				if (UnderlyingPaymentScheduleFixingDateAdjusted is not null) writer.WriteLocalDateOnly(40694, UnderlyingPaymentScheduleFixingDateAdjusted.Value);
				if (UnderlyingPaymentScheduleFixingDayGrp is not null) ((IFixEncoder)UnderlyingPaymentScheduleFixingDayGrp).Encode(writer);
				if (UnderlyingPaymentScheduleFixingLagPeriod is not null) writer.WriteWholeNumber(41893, UnderlyingPaymentScheduleFixingLagPeriod.Value);
				if (UnderlyingPaymentScheduleFixingLagUnit is not null) writer.WriteString(41894, UnderlyingPaymentScheduleFixingLagUnit);
				if (UnderlyingPaymentScheduleFixingFirstObservationDateOffsetPeriod is not null) writer.WriteWholeNumber(41895, UnderlyingPaymentScheduleFixingFirstObservationDateOffsetPeriod.Value);
				if (UnderlyingPaymentScheduleFixingFirstObservationDateOffsetUnit is not null) writer.WriteString(41896, UnderlyingPaymentScheduleFixingFirstObservationDateOffsetUnit);
				if (UnderlyingPaymentScheduleFixingTime is not null) writer.WriteString(40695, UnderlyingPaymentScheduleFixingTime);
				if (UnderlyingPaymentScheduleFixingTimeBusinessCenter is not null) writer.WriteString(40696, UnderlyingPaymentScheduleFixingTimeBusinessCenter);
				if (UnderlyingPaymentScheduleInterimExchangePaymentDateRelativeTo is not null) writer.WriteWholeNumber(40697, UnderlyingPaymentScheduleInterimExchangePaymentDateRelativeTo.Value);
				if (UnderlyingPaymentScheduleInterimExchangeDatesBizDayConvention is not null) writer.WriteWholeNumber(40698, UnderlyingPaymentScheduleInterimExchangeDatesBizDayConvention.Value);
				if (UnderlyingPaymentScheduleInterimExchangeDateBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingPaymentScheduleInterimExchangeDateBusinessCenterGrp).Encode(writer);
				if (UnderlyingPaymentScheduleInterimExchangeDatesOffsetPeriod is not null) writer.WriteWholeNumber(40700, UnderlyingPaymentScheduleInterimExchangeDatesOffsetPeriod.Value);
				if (UnderlyingPaymentScheduleInterimExchangeDatesOffsetUnit is not null) writer.WriteString(40701, UnderlyingPaymentScheduleInterimExchangeDatesOffsetUnit);
				if (UnderlyingPaymentScheduleInterimExchangeDatesOffsetDayType is not null) writer.WriteWholeNumber(40702, UnderlyingPaymentScheduleInterimExchangeDatesOffsetDayType.Value);
				if (UnderlyingPaymentScheduleInterimExchangeDateAdjusted is not null) writer.WriteLocalDateOnly(40703, UnderlyingPaymentScheduleInterimExchangeDateAdjusted.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingPaymentScheduleType = view.GetInt32(40665);
				UnderlyingPaymentScheduleXID = view.GetString(41881);
				UnderlyingPaymentScheduleXIDRef = view.GetString(41882);
				UnderlyingPaymentScheduleStubType = view.GetInt32(40666);
				UnderlyingPaymentScheduleStartDateUnadjusted = view.GetDateOnly(40667);
				UnderlyingPaymentScheduleEndDateUnadjusted = view.GetDateOnly(40668);
				UnderlyingPaymentSchedulePaySide = view.GetInt32(40669);
				UnderlyingPaymentScheduleReceiveSide = view.GetInt32(40670);
				UnderlyingPaymentScheduleNotional = view.GetDouble(40671);
				UnderlyingPaymentScheduleCurrency = view.GetString(40672);
				UnderlyingPaymentScheduleRate = view.GetDouble(40673);
				UnderlyingPaymentScheduleRateMultiplier = view.GetDouble(40674);
				UnderlyingPaymentScheduleRateSpread = view.GetDouble(40675);
				UnderlyingPaymentScheduleRateCurrency = view.GetString(41883);
				UnderlyingPaymentScheduleRateUnitOfMeasure = view.GetString(41884);
				UnderlyingPaymentScheduleRateConversionFactor = view.GetDouble(41885);
				UnderlyingPaymentScheduleRateSpreadType = view.GetInt32(41886);
				UnderlyingPaymentScheduleRateSpreadPositionType = view.GetInt32(40676);
				UnderlyingPaymentScheduleRateTreatment = view.GetInt32(40677);
				UnderlyingPaymentScheduleFixedAmount = view.GetDouble(40678);
				UnderlyingPaymentScheduleFixedCurrency = view.GetString(40679);
				UnderlyingPaymentScheduleSettlPeriodPrice = view.GetDouble(41887);
				UnderlyingPaymentScheduleSettlPeriodPriceCurrency = view.GetString(41888);
				UnderlyingPaymentScheduleSettlPeriodPriceUnitOfMeasure = view.GetString(41889);
				UnderlyingPaymentScheduleStepUnitOfMeasure = view.GetString(41890);
				UnderlyingPaymentScheduleStepFrequencyPeriod = view.GetInt32(40680);
				UnderlyingPaymentScheduleStepFrequencyUnit = view.GetString(40681);
				UnderlyingPaymentScheduleStepOffsetValue = view.GetDouble(40682);
				UnderlyingPaymentScheduleStepRate = view.GetDouble(40683);
				UnderlyingPaymentScheduleStepOffsetRate = view.GetDouble(40684);
				UnderlyingPaymentScheduleStepRelativeTo = view.GetInt32(40685);
				if (view.GetView("UnderlyingPaymentScheduleRateSourceGrp") is IMessageView viewUnderlyingPaymentScheduleRateSourceGrp)
				{
					UnderlyingPaymentScheduleRateSourceGrp = new();
					((IFixParser)UnderlyingPaymentScheduleRateSourceGrp).Parse(viewUnderlyingPaymentScheduleRateSourceGrp);
				}
				UnderlyingPaymentScheduleFixingDateUnadjusted = view.GetDateOnly(40686);
				UnderlyingPaymentScheduleWeight = view.GetDouble(40687);
				UnderlyingPaymentScheduleFixingDateRelativeTo = view.GetInt32(40688);
				UnderlyingPaymentScheduleFixingDateBusinessDayCnvtn = view.GetInt32(40689);
				if (view.GetView("UnderlyingPaymentScheduleFixingDateBusinessCenterGrp") is IMessageView viewUnderlyingPaymentScheduleFixingDateBusinessCenterGrp)
				{
					UnderlyingPaymentScheduleFixingDateBusinessCenterGrp = new();
					((IFixParser)UnderlyingPaymentScheduleFixingDateBusinessCenterGrp).Parse(viewUnderlyingPaymentScheduleFixingDateBusinessCenterGrp);
				}
				UnderlyingPaymentScheduleFixingDateOffsetPeriod = view.GetInt32(40691);
				UnderlyingPaymentScheduleFixingDateOffsetUnit = view.GetString(40692);
				UnderlyingPaymentScheduleFixingDateOffsetDayType = view.GetInt32(40693);
				UnderlyingPaymentScheduleFixingDayDistribution = view.GetInt32(41891);
				UnderlyingPaymentScheduleFixingDayCount = view.GetInt32(41892);
				UnderlyingPaymentScheduleFixingDateAdjusted = view.GetDateOnly(40694);
				if (view.GetView("UnderlyingPaymentScheduleFixingDayGrp") is IMessageView viewUnderlyingPaymentScheduleFixingDayGrp)
				{
					UnderlyingPaymentScheduleFixingDayGrp = new();
					((IFixParser)UnderlyingPaymentScheduleFixingDayGrp).Parse(viewUnderlyingPaymentScheduleFixingDayGrp);
				}
				UnderlyingPaymentScheduleFixingLagPeriod = view.GetInt32(41893);
				UnderlyingPaymentScheduleFixingLagUnit = view.GetString(41894);
				UnderlyingPaymentScheduleFixingFirstObservationDateOffsetPeriod = view.GetInt32(41895);
				UnderlyingPaymentScheduleFixingFirstObservationDateOffsetUnit = view.GetString(41896);
				UnderlyingPaymentScheduleFixingTime = view.GetString(40695);
				UnderlyingPaymentScheduleFixingTimeBusinessCenter = view.GetString(40696);
				UnderlyingPaymentScheduleInterimExchangePaymentDateRelativeTo = view.GetInt32(40697);
				UnderlyingPaymentScheduleInterimExchangeDatesBizDayConvention = view.GetInt32(40698);
				if (view.GetView("UnderlyingPaymentScheduleInterimExchangeDateBusinessCenterGrp") is IMessageView viewUnderlyingPaymentScheduleInterimExchangeDateBusinessCenterGrp)
				{
					UnderlyingPaymentScheduleInterimExchangeDateBusinessCenterGrp = new();
					((IFixParser)UnderlyingPaymentScheduleInterimExchangeDateBusinessCenterGrp).Parse(viewUnderlyingPaymentScheduleInterimExchangeDateBusinessCenterGrp);
				}
				UnderlyingPaymentScheduleInterimExchangeDatesOffsetPeriod = view.GetInt32(40700);
				UnderlyingPaymentScheduleInterimExchangeDatesOffsetUnit = view.GetString(40701);
				UnderlyingPaymentScheduleInterimExchangeDatesOffsetDayType = view.GetInt32(40702);
				UnderlyingPaymentScheduleInterimExchangeDateAdjusted = view.GetDateOnly(40703);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingPaymentScheduleType":
					{
						value = UnderlyingPaymentScheduleType;
						break;
					}
					case "UnderlyingPaymentScheduleXID":
					{
						value = UnderlyingPaymentScheduleXID;
						break;
					}
					case "UnderlyingPaymentScheduleXIDRef":
					{
						value = UnderlyingPaymentScheduleXIDRef;
						break;
					}
					case "UnderlyingPaymentScheduleStubType":
					{
						value = UnderlyingPaymentScheduleStubType;
						break;
					}
					case "UnderlyingPaymentScheduleStartDateUnadjusted":
					{
						value = UnderlyingPaymentScheduleStartDateUnadjusted;
						break;
					}
					case "UnderlyingPaymentScheduleEndDateUnadjusted":
					{
						value = UnderlyingPaymentScheduleEndDateUnadjusted;
						break;
					}
					case "UnderlyingPaymentSchedulePaySide":
					{
						value = UnderlyingPaymentSchedulePaySide;
						break;
					}
					case "UnderlyingPaymentScheduleReceiveSide":
					{
						value = UnderlyingPaymentScheduleReceiveSide;
						break;
					}
					case "UnderlyingPaymentScheduleNotional":
					{
						value = UnderlyingPaymentScheduleNotional;
						break;
					}
					case "UnderlyingPaymentScheduleCurrency":
					{
						value = UnderlyingPaymentScheduleCurrency;
						break;
					}
					case "UnderlyingPaymentScheduleRate":
					{
						value = UnderlyingPaymentScheduleRate;
						break;
					}
					case "UnderlyingPaymentScheduleRateMultiplier":
					{
						value = UnderlyingPaymentScheduleRateMultiplier;
						break;
					}
					case "UnderlyingPaymentScheduleRateSpread":
					{
						value = UnderlyingPaymentScheduleRateSpread;
						break;
					}
					case "UnderlyingPaymentScheduleRateCurrency":
					{
						value = UnderlyingPaymentScheduleRateCurrency;
						break;
					}
					case "UnderlyingPaymentScheduleRateUnitOfMeasure":
					{
						value = UnderlyingPaymentScheduleRateUnitOfMeasure;
						break;
					}
					case "UnderlyingPaymentScheduleRateConversionFactor":
					{
						value = UnderlyingPaymentScheduleRateConversionFactor;
						break;
					}
					case "UnderlyingPaymentScheduleRateSpreadType":
					{
						value = UnderlyingPaymentScheduleRateSpreadType;
						break;
					}
					case "UnderlyingPaymentScheduleRateSpreadPositionType":
					{
						value = UnderlyingPaymentScheduleRateSpreadPositionType;
						break;
					}
					case "UnderlyingPaymentScheduleRateTreatment":
					{
						value = UnderlyingPaymentScheduleRateTreatment;
						break;
					}
					case "UnderlyingPaymentScheduleFixedAmount":
					{
						value = UnderlyingPaymentScheduleFixedAmount;
						break;
					}
					case "UnderlyingPaymentScheduleFixedCurrency":
					{
						value = UnderlyingPaymentScheduleFixedCurrency;
						break;
					}
					case "UnderlyingPaymentScheduleSettlPeriodPrice":
					{
						value = UnderlyingPaymentScheduleSettlPeriodPrice;
						break;
					}
					case "UnderlyingPaymentScheduleSettlPeriodPriceCurrency":
					{
						value = UnderlyingPaymentScheduleSettlPeriodPriceCurrency;
						break;
					}
					case "UnderlyingPaymentScheduleSettlPeriodPriceUnitOfMeasure":
					{
						value = UnderlyingPaymentScheduleSettlPeriodPriceUnitOfMeasure;
						break;
					}
					case "UnderlyingPaymentScheduleStepUnitOfMeasure":
					{
						value = UnderlyingPaymentScheduleStepUnitOfMeasure;
						break;
					}
					case "UnderlyingPaymentScheduleStepFrequencyPeriod":
					{
						value = UnderlyingPaymentScheduleStepFrequencyPeriod;
						break;
					}
					case "UnderlyingPaymentScheduleStepFrequencyUnit":
					{
						value = UnderlyingPaymentScheduleStepFrequencyUnit;
						break;
					}
					case "UnderlyingPaymentScheduleStepOffsetValue":
					{
						value = UnderlyingPaymentScheduleStepOffsetValue;
						break;
					}
					case "UnderlyingPaymentScheduleStepRate":
					{
						value = UnderlyingPaymentScheduleStepRate;
						break;
					}
					case "UnderlyingPaymentScheduleStepOffsetRate":
					{
						value = UnderlyingPaymentScheduleStepOffsetRate;
						break;
					}
					case "UnderlyingPaymentScheduleStepRelativeTo":
					{
						value = UnderlyingPaymentScheduleStepRelativeTo;
						break;
					}
					case "UnderlyingPaymentScheduleRateSourceGrp":
					{
						value = UnderlyingPaymentScheduleRateSourceGrp;
						break;
					}
					case "UnderlyingPaymentScheduleFixingDateUnadjusted":
					{
						value = UnderlyingPaymentScheduleFixingDateUnadjusted;
						break;
					}
					case "UnderlyingPaymentScheduleWeight":
					{
						value = UnderlyingPaymentScheduleWeight;
						break;
					}
					case "UnderlyingPaymentScheduleFixingDateRelativeTo":
					{
						value = UnderlyingPaymentScheduleFixingDateRelativeTo;
						break;
					}
					case "UnderlyingPaymentScheduleFixingDateBusinessDayCnvtn":
					{
						value = UnderlyingPaymentScheduleFixingDateBusinessDayCnvtn;
						break;
					}
					case "UnderlyingPaymentScheduleFixingDateBusinessCenterGrp":
					{
						value = UnderlyingPaymentScheduleFixingDateBusinessCenterGrp;
						break;
					}
					case "UnderlyingPaymentScheduleFixingDateOffsetPeriod":
					{
						value = UnderlyingPaymentScheduleFixingDateOffsetPeriod;
						break;
					}
					case "UnderlyingPaymentScheduleFixingDateOffsetUnit":
					{
						value = UnderlyingPaymentScheduleFixingDateOffsetUnit;
						break;
					}
					case "UnderlyingPaymentScheduleFixingDateOffsetDayType":
					{
						value = UnderlyingPaymentScheduleFixingDateOffsetDayType;
						break;
					}
					case "UnderlyingPaymentScheduleFixingDayDistribution":
					{
						value = UnderlyingPaymentScheduleFixingDayDistribution;
						break;
					}
					case "UnderlyingPaymentScheduleFixingDayCount":
					{
						value = UnderlyingPaymentScheduleFixingDayCount;
						break;
					}
					case "UnderlyingPaymentScheduleFixingDateAdjusted":
					{
						value = UnderlyingPaymentScheduleFixingDateAdjusted;
						break;
					}
					case "UnderlyingPaymentScheduleFixingDayGrp":
					{
						value = UnderlyingPaymentScheduleFixingDayGrp;
						break;
					}
					case "UnderlyingPaymentScheduleFixingLagPeriod":
					{
						value = UnderlyingPaymentScheduleFixingLagPeriod;
						break;
					}
					case "UnderlyingPaymentScheduleFixingLagUnit":
					{
						value = UnderlyingPaymentScheduleFixingLagUnit;
						break;
					}
					case "UnderlyingPaymentScheduleFixingFirstObservationDateOffsetPeriod":
					{
						value = UnderlyingPaymentScheduleFixingFirstObservationDateOffsetPeriod;
						break;
					}
					case "UnderlyingPaymentScheduleFixingFirstObservationDateOffsetUnit":
					{
						value = UnderlyingPaymentScheduleFixingFirstObservationDateOffsetUnit;
						break;
					}
					case "UnderlyingPaymentScheduleFixingTime":
					{
						value = UnderlyingPaymentScheduleFixingTime;
						break;
					}
					case "UnderlyingPaymentScheduleFixingTimeBusinessCenter":
					{
						value = UnderlyingPaymentScheduleFixingTimeBusinessCenter;
						break;
					}
					case "UnderlyingPaymentScheduleInterimExchangePaymentDateRelativeTo":
					{
						value = UnderlyingPaymentScheduleInterimExchangePaymentDateRelativeTo;
						break;
					}
					case "UnderlyingPaymentScheduleInterimExchangeDatesBizDayConvention":
					{
						value = UnderlyingPaymentScheduleInterimExchangeDatesBizDayConvention;
						break;
					}
					case "UnderlyingPaymentScheduleInterimExchangeDateBusinessCenterGrp":
					{
						value = UnderlyingPaymentScheduleInterimExchangeDateBusinessCenterGrp;
						break;
					}
					case "UnderlyingPaymentScheduleInterimExchangeDatesOffsetPeriod":
					{
						value = UnderlyingPaymentScheduleInterimExchangeDatesOffsetPeriod;
						break;
					}
					case "UnderlyingPaymentScheduleInterimExchangeDatesOffsetUnit":
					{
						value = UnderlyingPaymentScheduleInterimExchangeDatesOffsetUnit;
						break;
					}
					case "UnderlyingPaymentScheduleInterimExchangeDatesOffsetDayType":
					{
						value = UnderlyingPaymentScheduleInterimExchangeDatesOffsetDayType;
						break;
					}
					case "UnderlyingPaymentScheduleInterimExchangeDateAdjusted":
					{
						value = UnderlyingPaymentScheduleInterimExchangeDateAdjusted;
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
				UnderlyingPaymentScheduleType = null;
				UnderlyingPaymentScheduleXID = null;
				UnderlyingPaymentScheduleXIDRef = null;
				UnderlyingPaymentScheduleStubType = null;
				UnderlyingPaymentScheduleStartDateUnadjusted = null;
				UnderlyingPaymentScheduleEndDateUnadjusted = null;
				UnderlyingPaymentSchedulePaySide = null;
				UnderlyingPaymentScheduleReceiveSide = null;
				UnderlyingPaymentScheduleNotional = null;
				UnderlyingPaymentScheduleCurrency = null;
				UnderlyingPaymentScheduleRate = null;
				UnderlyingPaymentScheduleRateMultiplier = null;
				UnderlyingPaymentScheduleRateSpread = null;
				UnderlyingPaymentScheduleRateCurrency = null;
				UnderlyingPaymentScheduleRateUnitOfMeasure = null;
				UnderlyingPaymentScheduleRateConversionFactor = null;
				UnderlyingPaymentScheduleRateSpreadType = null;
				UnderlyingPaymentScheduleRateSpreadPositionType = null;
				UnderlyingPaymentScheduleRateTreatment = null;
				UnderlyingPaymentScheduleFixedAmount = null;
				UnderlyingPaymentScheduleFixedCurrency = null;
				UnderlyingPaymentScheduleSettlPeriodPrice = null;
				UnderlyingPaymentScheduleSettlPeriodPriceCurrency = null;
				UnderlyingPaymentScheduleSettlPeriodPriceUnitOfMeasure = null;
				UnderlyingPaymentScheduleStepUnitOfMeasure = null;
				UnderlyingPaymentScheduleStepFrequencyPeriod = null;
				UnderlyingPaymentScheduleStepFrequencyUnit = null;
				UnderlyingPaymentScheduleStepOffsetValue = null;
				UnderlyingPaymentScheduleStepRate = null;
				UnderlyingPaymentScheduleStepOffsetRate = null;
				UnderlyingPaymentScheduleStepRelativeTo = null;
				((IFixReset?)UnderlyingPaymentScheduleRateSourceGrp)?.Reset();
				UnderlyingPaymentScheduleFixingDateUnadjusted = null;
				UnderlyingPaymentScheduleWeight = null;
				UnderlyingPaymentScheduleFixingDateRelativeTo = null;
				UnderlyingPaymentScheduleFixingDateBusinessDayCnvtn = null;
				((IFixReset?)UnderlyingPaymentScheduleFixingDateBusinessCenterGrp)?.Reset();
				UnderlyingPaymentScheduleFixingDateOffsetPeriod = null;
				UnderlyingPaymentScheduleFixingDateOffsetUnit = null;
				UnderlyingPaymentScheduleFixingDateOffsetDayType = null;
				UnderlyingPaymentScheduleFixingDayDistribution = null;
				UnderlyingPaymentScheduleFixingDayCount = null;
				UnderlyingPaymentScheduleFixingDateAdjusted = null;
				((IFixReset?)UnderlyingPaymentScheduleFixingDayGrp)?.Reset();
				UnderlyingPaymentScheduleFixingLagPeriod = null;
				UnderlyingPaymentScheduleFixingLagUnit = null;
				UnderlyingPaymentScheduleFixingFirstObservationDateOffsetPeriod = null;
				UnderlyingPaymentScheduleFixingFirstObservationDateOffsetUnit = null;
				UnderlyingPaymentScheduleFixingTime = null;
				UnderlyingPaymentScheduleFixingTimeBusinessCenter = null;
				UnderlyingPaymentScheduleInterimExchangePaymentDateRelativeTo = null;
				UnderlyingPaymentScheduleInterimExchangeDatesBizDayConvention = null;
				((IFixReset?)UnderlyingPaymentScheduleInterimExchangeDateBusinessCenterGrp)?.Reset();
				UnderlyingPaymentScheduleInterimExchangeDatesOffsetPeriod = null;
				UnderlyingPaymentScheduleInterimExchangeDatesOffsetUnit = null;
				UnderlyingPaymentScheduleInterimExchangeDatesOffsetDayType = null;
				UnderlyingPaymentScheduleInterimExchangeDateAdjusted = null;
			}
		}
		[Group(NoOfTag = 40664, Offset = 0, Required = false)]
		public NoUnderlyingPaymentSchedules[]? UnderlyingPaymentSchedules {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentSchedules is not null && UnderlyingPaymentSchedules.Length != 0)
			{
				writer.WriteWholeNumber(40664, UnderlyingPaymentSchedules.Length);
				for (int i = 0; i < UnderlyingPaymentSchedules.Length; i++)
				{
					((IFixEncoder)UnderlyingPaymentSchedules[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingPaymentSchedules") is IMessageView viewNoUnderlyingPaymentSchedules)
			{
				var count = viewNoUnderlyingPaymentSchedules.GroupCount();
				UnderlyingPaymentSchedules = new NoUnderlyingPaymentSchedules[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingPaymentSchedules[i] = new();
					((IFixParser)UnderlyingPaymentSchedules[i]).Parse(viewNoUnderlyingPaymentSchedules.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingPaymentSchedules":
				{
					value = UnderlyingPaymentSchedules;
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
			UnderlyingPaymentSchedules = null;
		}
	}
}
