using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentScheduleGrp : IFixComponent
	{
		public sealed partial class NoLegPaymentSchedules : IFixGroup
		{
			[TagDetails(Tag = 40375, Type = TagType.Int, Offset = 0, Required = false)]
			public int? LegPaymentScheduleType {get; set;}
			
			[TagDetails(Tag = 41533, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegPaymentScheduleXID {get; set;}
			
			[TagDetails(Tag = 41534, Type = TagType.String, Offset = 2, Required = false)]
			public string? LegPaymentScheduleXIDRef {get; set;}
			
			[TagDetails(Tag = 40376, Type = TagType.Int, Offset = 3, Required = false)]
			public int? LegPaymentScheduleStubType {get; set;}
			
			[TagDetails(Tag = 40377, Type = TagType.LocalDate, Offset = 4, Required = false)]
			public DateOnly? LegPaymentScheduleStartDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 40378, Type = TagType.LocalDate, Offset = 5, Required = false)]
			public DateOnly? LegPaymentScheduleEndDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 40379, Type = TagType.Int, Offset = 6, Required = false)]
			public int? LegPaymentSchedulePaySide {get; set;}
			
			[TagDetails(Tag = 40380, Type = TagType.Int, Offset = 7, Required = false)]
			public int? LegPaymentScheduleReceiveSide {get; set;}
			
			[TagDetails(Tag = 40381, Type = TagType.Float, Offset = 8, Required = false)]
			public double? LegPaymentScheduleNotional {get; set;}
			
			[TagDetails(Tag = 40382, Type = TagType.String, Offset = 9, Required = false)]
			public string? LegPaymentScheduleCurrency {get; set;}
			
			[TagDetails(Tag = 40383, Type = TagType.Float, Offset = 10, Required = false)]
			public double? LegPaymentScheduleRate {get; set;}
			
			[TagDetails(Tag = 40384, Type = TagType.Float, Offset = 11, Required = false)]
			public double? LegPaymentScheduleRateMultiplier {get; set;}
			
			[TagDetails(Tag = 40385, Type = TagType.Float, Offset = 12, Required = false)]
			public double? LegPaymentScheduleRateSpread {get; set;}
			
			[TagDetails(Tag = 41535, Type = TagType.String, Offset = 13, Required = false)]
			public string? LegPaymentScheduleRateCurrency {get; set;}
			
			[TagDetails(Tag = 41536, Type = TagType.String, Offset = 14, Required = false)]
			public string? LegPaymentScheduleRateUnitOfMeasure {get; set;}
			
			[TagDetails(Tag = 41537, Type = TagType.Float, Offset = 15, Required = false)]
			public double? LegPaymentScheduleRateConversionFactor {get; set;}
			
			[TagDetails(Tag = 41538, Type = TagType.Int, Offset = 16, Required = false)]
			public int? LegPaymentScheduleRateSpreadType {get; set;}
			
			[TagDetails(Tag = 40386, Type = TagType.Int, Offset = 17, Required = false)]
			public int? LegPaymentScheduleRateSpreadPositionType {get; set;}
			
			[TagDetails(Tag = 40387, Type = TagType.Int, Offset = 18, Required = false)]
			public int? LegPaymentScheduleRateTreatment {get; set;}
			
			[TagDetails(Tag = 40388, Type = TagType.Float, Offset = 19, Required = false)]
			public double? LegPaymentScheduleFixedAmount {get; set;}
			
			[TagDetails(Tag = 40389, Type = TagType.String, Offset = 20, Required = false)]
			public string? LegPaymentScheduleFixedCurrency {get; set;}
			
			[TagDetails(Tag = 41539, Type = TagType.Float, Offset = 21, Required = false)]
			public double? LegPaymentScheduleSettlPeriodPrice {get; set;}
			
			[TagDetails(Tag = 41540, Type = TagType.String, Offset = 22, Required = false)]
			public string? LegPaymentScheduleSettlPeriodPriceCurrency {get; set;}
			
			[TagDetails(Tag = 41541, Type = TagType.String, Offset = 23, Required = false)]
			public string? LegPaymentScheduleSettlPeriodPriceUnitOfMeasure {get; set;}
			
			[TagDetails(Tag = 41542, Type = TagType.String, Offset = 24, Required = false)]
			public string? LegPaymentScheduleStepUnitOfMeasure {get; set;}
			
			[TagDetails(Tag = 40390, Type = TagType.Int, Offset = 25, Required = false)]
			public int? LegPaymentScheduleStepFrequencyPeriod {get; set;}
			
			[TagDetails(Tag = 40391, Type = TagType.String, Offset = 26, Required = false)]
			public string? LegPaymentScheduleStepFrequencyUnit {get; set;}
			
			[TagDetails(Tag = 40392, Type = TagType.Float, Offset = 27, Required = false)]
			public double? LegPaymentScheduleStepOffsetValue {get; set;}
			
			[TagDetails(Tag = 40393, Type = TagType.Float, Offset = 28, Required = false)]
			public double? LegPaymentScheduleStepRate {get; set;}
			
			[TagDetails(Tag = 40394, Type = TagType.Float, Offset = 29, Required = false)]
			public double? LegPaymentScheduleStepOffsetRate {get; set;}
			
			[TagDetails(Tag = 40395, Type = TagType.Int, Offset = 30, Required = false)]
			public int? LegPaymentScheduleStepRelativeTo {get; set;}
			
			[Component(Offset = 31, Required = false)]
			public LegPaymentScheduleRateSourceGrp? LegPaymentScheduleRateSourceGrp {get; set;}
			
			[TagDetails(Tag = 40396, Type = TagType.LocalDate, Offset = 32, Required = false)]
			public DateOnly? LegPaymentScheduleFixingDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 40397, Type = TagType.Float, Offset = 33, Required = false)]
			public double? LegPaymentScheduleWeight {get; set;}
			
			[TagDetails(Tag = 40398, Type = TagType.Int, Offset = 34, Required = false)]
			public int? LegPaymentScheduleFixingDateRelativeTo {get; set;}
			
			[TagDetails(Tag = 40399, Type = TagType.Int, Offset = 35, Required = false)]
			public int? LegPaymentScheduleFixingDateBusinessDayConvention {get; set;}
			
			[Component(Offset = 36, Required = false)]
			public LegPaymentScheduleFixingDateBusinessCenterGrp? LegPaymentScheduleFixingDateBusinessCenterGrp {get; set;}
			
			[TagDetails(Tag = 40401, Type = TagType.Int, Offset = 37, Required = false)]
			public int? LegPaymentScheduleFixingDateOffsetPeriod {get; set;}
			
			[TagDetails(Tag = 40402, Type = TagType.String, Offset = 38, Required = false)]
			public string? LegPaymentScheduleFixingDateOffsetUnit {get; set;}
			
			[TagDetails(Tag = 40403, Type = TagType.Int, Offset = 39, Required = false)]
			public int? LegPaymentScheduleFixingDateOffsetDayType {get; set;}
			
			[TagDetails(Tag = 41543, Type = TagType.Int, Offset = 40, Required = false)]
			public int? LegPaymentScheduleFixingDayDistribution {get; set;}
			
			[TagDetails(Tag = 41544, Type = TagType.Int, Offset = 41, Required = false)]
			public int? LegPaymentScheduleFixingDayCount {get; set;}
			
			[TagDetails(Tag = 40404, Type = TagType.LocalDate, Offset = 42, Required = false)]
			public DateOnly? LegPaymentScheduleFixingDateAdjusted {get; set;}
			
			[Component(Offset = 43, Required = false)]
			public LegPaymentScheduleFixingDayGrp? LegPaymentScheduleFixingDayGrp {get; set;}
			
			[TagDetails(Tag = 41545, Type = TagType.Int, Offset = 44, Required = false)]
			public int? LegPaymentScheduleFixingLagPeriod {get; set;}
			
			[TagDetails(Tag = 41546, Type = TagType.String, Offset = 45, Required = false)]
			public string? LegPaymentScheduleFixingLagUnit {get; set;}
			
			[TagDetails(Tag = 41547, Type = TagType.Int, Offset = 46, Required = false)]
			public int? LegPaymentScheduleFixingFirstObservationDateOffsetPeriod {get; set;}
			
			[TagDetails(Tag = 41548, Type = TagType.String, Offset = 47, Required = false)]
			public string? LegPaymentScheduleFixingFirstObservationDateOffsetUnit {get; set;}
			
			[TagDetails(Tag = 40405, Type = TagType.String, Offset = 48, Required = false)]
			public string? LegPaymentScheduleFixingTime {get; set;}
			
			[TagDetails(Tag = 40406, Type = TagType.String, Offset = 49, Required = false)]
			public string? LegPaymentScheduleFixingTimeBusinessCenter {get; set;}
			
			[TagDetails(Tag = 40407, Type = TagType.Int, Offset = 50, Required = false)]
			public int? LegPaymentScheduleInterimExchangePaymentDateRelativeTo {get; set;}
			
			[TagDetails(Tag = 40408, Type = TagType.Int, Offset = 51, Required = false)]
			public int? LegPaymentScheduleInterimExchangeDatesBusinessDayConvention {get; set;}
			
			[Component(Offset = 52, Required = false)]
			public LegPaymentScheduleInterimExchangeDateBusinessCenterGrp? LegPaymentScheduleInterimExchangeDateBusinessCenterGrp {get; set;}
			
			[TagDetails(Tag = 40410, Type = TagType.Int, Offset = 53, Required = false)]
			public int? LegPaymentScheduleInterimExchangeDatesOffsetPeriod {get; set;}
			
			[TagDetails(Tag = 40411, Type = TagType.String, Offset = 54, Required = false)]
			public string? LegPaymentScheduleInterimExchangeDatesOffsetUnit {get; set;}
			
			[TagDetails(Tag = 40412, Type = TagType.Int, Offset = 55, Required = false)]
			public int? LegPaymentScheduleInterimExchangeDatesOffsetDayType {get; set;}
			
			[TagDetails(Tag = 40413, Type = TagType.LocalDate, Offset = 56, Required = false)]
			public DateOnly? LegPaymentScheduleInterimExchangeDateAdjusted {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegPaymentScheduleType is not null) writer.WriteWholeNumber(40375, LegPaymentScheduleType.Value);
				if (LegPaymentScheduleXID is not null) writer.WriteString(41533, LegPaymentScheduleXID);
				if (LegPaymentScheduleXIDRef is not null) writer.WriteString(41534, LegPaymentScheduleXIDRef);
				if (LegPaymentScheduleStubType is not null) writer.WriteWholeNumber(40376, LegPaymentScheduleStubType.Value);
				if (LegPaymentScheduleStartDateUnadjusted is not null) writer.WriteLocalDateOnly(40377, LegPaymentScheduleStartDateUnadjusted.Value);
				if (LegPaymentScheduleEndDateUnadjusted is not null) writer.WriteLocalDateOnly(40378, LegPaymentScheduleEndDateUnadjusted.Value);
				if (LegPaymentSchedulePaySide is not null) writer.WriteWholeNumber(40379, LegPaymentSchedulePaySide.Value);
				if (LegPaymentScheduleReceiveSide is not null) writer.WriteWholeNumber(40380, LegPaymentScheduleReceiveSide.Value);
				if (LegPaymentScheduleNotional is not null) writer.WriteNumber(40381, LegPaymentScheduleNotional.Value);
				if (LegPaymentScheduleCurrency is not null) writer.WriteString(40382, LegPaymentScheduleCurrency);
				if (LegPaymentScheduleRate is not null) writer.WriteNumber(40383, LegPaymentScheduleRate.Value);
				if (LegPaymentScheduleRateMultiplier is not null) writer.WriteNumber(40384, LegPaymentScheduleRateMultiplier.Value);
				if (LegPaymentScheduleRateSpread is not null) writer.WriteNumber(40385, LegPaymentScheduleRateSpread.Value);
				if (LegPaymentScheduleRateCurrency is not null) writer.WriteString(41535, LegPaymentScheduleRateCurrency);
				if (LegPaymentScheduleRateUnitOfMeasure is not null) writer.WriteString(41536, LegPaymentScheduleRateUnitOfMeasure);
				if (LegPaymentScheduleRateConversionFactor is not null) writer.WriteNumber(41537, LegPaymentScheduleRateConversionFactor.Value);
				if (LegPaymentScheduleRateSpreadType is not null) writer.WriteWholeNumber(41538, LegPaymentScheduleRateSpreadType.Value);
				if (LegPaymentScheduleRateSpreadPositionType is not null) writer.WriteWholeNumber(40386, LegPaymentScheduleRateSpreadPositionType.Value);
				if (LegPaymentScheduleRateTreatment is not null) writer.WriteWholeNumber(40387, LegPaymentScheduleRateTreatment.Value);
				if (LegPaymentScheduleFixedAmount is not null) writer.WriteNumber(40388, LegPaymentScheduleFixedAmount.Value);
				if (LegPaymentScheduleFixedCurrency is not null) writer.WriteString(40389, LegPaymentScheduleFixedCurrency);
				if (LegPaymentScheduleSettlPeriodPrice is not null) writer.WriteNumber(41539, LegPaymentScheduleSettlPeriodPrice.Value);
				if (LegPaymentScheduleSettlPeriodPriceCurrency is not null) writer.WriteString(41540, LegPaymentScheduleSettlPeriodPriceCurrency);
				if (LegPaymentScheduleSettlPeriodPriceUnitOfMeasure is not null) writer.WriteString(41541, LegPaymentScheduleSettlPeriodPriceUnitOfMeasure);
				if (LegPaymentScheduleStepUnitOfMeasure is not null) writer.WriteString(41542, LegPaymentScheduleStepUnitOfMeasure);
				if (LegPaymentScheduleStepFrequencyPeriod is not null) writer.WriteWholeNumber(40390, LegPaymentScheduleStepFrequencyPeriod.Value);
				if (LegPaymentScheduleStepFrequencyUnit is not null) writer.WriteString(40391, LegPaymentScheduleStepFrequencyUnit);
				if (LegPaymentScheduleStepOffsetValue is not null) writer.WriteNumber(40392, LegPaymentScheduleStepOffsetValue.Value);
				if (LegPaymentScheduleStepRate is not null) writer.WriteNumber(40393, LegPaymentScheduleStepRate.Value);
				if (LegPaymentScheduleStepOffsetRate is not null) writer.WriteNumber(40394, LegPaymentScheduleStepOffsetRate.Value);
				if (LegPaymentScheduleStepRelativeTo is not null) writer.WriteWholeNumber(40395, LegPaymentScheduleStepRelativeTo.Value);
				if (LegPaymentScheduleRateSourceGrp is not null) ((IFixEncoder)LegPaymentScheduleRateSourceGrp).Encode(writer);
				if (LegPaymentScheduleFixingDateUnadjusted is not null) writer.WriteLocalDateOnly(40396, LegPaymentScheduleFixingDateUnadjusted.Value);
				if (LegPaymentScheduleWeight is not null) writer.WriteNumber(40397, LegPaymentScheduleWeight.Value);
				if (LegPaymentScheduleFixingDateRelativeTo is not null) writer.WriteWholeNumber(40398, LegPaymentScheduleFixingDateRelativeTo.Value);
				if (LegPaymentScheduleFixingDateBusinessDayConvention is not null) writer.WriteWholeNumber(40399, LegPaymentScheduleFixingDateBusinessDayConvention.Value);
				if (LegPaymentScheduleFixingDateBusinessCenterGrp is not null) ((IFixEncoder)LegPaymentScheduleFixingDateBusinessCenterGrp).Encode(writer);
				if (LegPaymentScheduleFixingDateOffsetPeriod is not null) writer.WriteWholeNumber(40401, LegPaymentScheduleFixingDateOffsetPeriod.Value);
				if (LegPaymentScheduleFixingDateOffsetUnit is not null) writer.WriteString(40402, LegPaymentScheduleFixingDateOffsetUnit);
				if (LegPaymentScheduleFixingDateOffsetDayType is not null) writer.WriteWholeNumber(40403, LegPaymentScheduleFixingDateOffsetDayType.Value);
				if (LegPaymentScheduleFixingDayDistribution is not null) writer.WriteWholeNumber(41543, LegPaymentScheduleFixingDayDistribution.Value);
				if (LegPaymentScheduleFixingDayCount is not null) writer.WriteWholeNumber(41544, LegPaymentScheduleFixingDayCount.Value);
				if (LegPaymentScheduleFixingDateAdjusted is not null) writer.WriteLocalDateOnly(40404, LegPaymentScheduleFixingDateAdjusted.Value);
				if (LegPaymentScheduleFixingDayGrp is not null) ((IFixEncoder)LegPaymentScheduleFixingDayGrp).Encode(writer);
				if (LegPaymentScheduleFixingLagPeriod is not null) writer.WriteWholeNumber(41545, LegPaymentScheduleFixingLagPeriod.Value);
				if (LegPaymentScheduleFixingLagUnit is not null) writer.WriteString(41546, LegPaymentScheduleFixingLagUnit);
				if (LegPaymentScheduleFixingFirstObservationDateOffsetPeriod is not null) writer.WriteWholeNumber(41547, LegPaymentScheduleFixingFirstObservationDateOffsetPeriod.Value);
				if (LegPaymentScheduleFixingFirstObservationDateOffsetUnit is not null) writer.WriteString(41548, LegPaymentScheduleFixingFirstObservationDateOffsetUnit);
				if (LegPaymentScheduleFixingTime is not null) writer.WriteString(40405, LegPaymentScheduleFixingTime);
				if (LegPaymentScheduleFixingTimeBusinessCenter is not null) writer.WriteString(40406, LegPaymentScheduleFixingTimeBusinessCenter);
				if (LegPaymentScheduleInterimExchangePaymentDateRelativeTo is not null) writer.WriteWholeNumber(40407, LegPaymentScheduleInterimExchangePaymentDateRelativeTo.Value);
				if (LegPaymentScheduleInterimExchangeDatesBusinessDayConvention is not null) writer.WriteWholeNumber(40408, LegPaymentScheduleInterimExchangeDatesBusinessDayConvention.Value);
				if (LegPaymentScheduleInterimExchangeDateBusinessCenterGrp is not null) ((IFixEncoder)LegPaymentScheduleInterimExchangeDateBusinessCenterGrp).Encode(writer);
				if (LegPaymentScheduleInterimExchangeDatesOffsetPeriod is not null) writer.WriteWholeNumber(40410, LegPaymentScheduleInterimExchangeDatesOffsetPeriod.Value);
				if (LegPaymentScheduleInterimExchangeDatesOffsetUnit is not null) writer.WriteString(40411, LegPaymentScheduleInterimExchangeDatesOffsetUnit);
				if (LegPaymentScheduleInterimExchangeDatesOffsetDayType is not null) writer.WriteWholeNumber(40412, LegPaymentScheduleInterimExchangeDatesOffsetDayType.Value);
				if (LegPaymentScheduleInterimExchangeDateAdjusted is not null) writer.WriteLocalDateOnly(40413, LegPaymentScheduleInterimExchangeDateAdjusted.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegPaymentScheduleType = view.GetInt32(40375);
				LegPaymentScheduleXID = view.GetString(41533);
				LegPaymentScheduleXIDRef = view.GetString(41534);
				LegPaymentScheduleStubType = view.GetInt32(40376);
				LegPaymentScheduleStartDateUnadjusted = view.GetDateOnly(40377);
				LegPaymentScheduleEndDateUnadjusted = view.GetDateOnly(40378);
				LegPaymentSchedulePaySide = view.GetInt32(40379);
				LegPaymentScheduleReceiveSide = view.GetInt32(40380);
				LegPaymentScheduleNotional = view.GetDouble(40381);
				LegPaymentScheduleCurrency = view.GetString(40382);
				LegPaymentScheduleRate = view.GetDouble(40383);
				LegPaymentScheduleRateMultiplier = view.GetDouble(40384);
				LegPaymentScheduleRateSpread = view.GetDouble(40385);
				LegPaymentScheduleRateCurrency = view.GetString(41535);
				LegPaymentScheduleRateUnitOfMeasure = view.GetString(41536);
				LegPaymentScheduleRateConversionFactor = view.GetDouble(41537);
				LegPaymentScheduleRateSpreadType = view.GetInt32(41538);
				LegPaymentScheduleRateSpreadPositionType = view.GetInt32(40386);
				LegPaymentScheduleRateTreatment = view.GetInt32(40387);
				LegPaymentScheduleFixedAmount = view.GetDouble(40388);
				LegPaymentScheduleFixedCurrency = view.GetString(40389);
				LegPaymentScheduleSettlPeriodPrice = view.GetDouble(41539);
				LegPaymentScheduleSettlPeriodPriceCurrency = view.GetString(41540);
				LegPaymentScheduleSettlPeriodPriceUnitOfMeasure = view.GetString(41541);
				LegPaymentScheduleStepUnitOfMeasure = view.GetString(41542);
				LegPaymentScheduleStepFrequencyPeriod = view.GetInt32(40390);
				LegPaymentScheduleStepFrequencyUnit = view.GetString(40391);
				LegPaymentScheduleStepOffsetValue = view.GetDouble(40392);
				LegPaymentScheduleStepRate = view.GetDouble(40393);
				LegPaymentScheduleStepOffsetRate = view.GetDouble(40394);
				LegPaymentScheduleStepRelativeTo = view.GetInt32(40395);
				if (view.GetView("LegPaymentScheduleRateSourceGrp") is IMessageView viewLegPaymentScheduleRateSourceGrp)
				{
					LegPaymentScheduleRateSourceGrp = new();
					((IFixParser)LegPaymentScheduleRateSourceGrp).Parse(viewLegPaymentScheduleRateSourceGrp);
				}
				LegPaymentScheduleFixingDateUnadjusted = view.GetDateOnly(40396);
				LegPaymentScheduleWeight = view.GetDouble(40397);
				LegPaymentScheduleFixingDateRelativeTo = view.GetInt32(40398);
				LegPaymentScheduleFixingDateBusinessDayConvention = view.GetInt32(40399);
				if (view.GetView("LegPaymentScheduleFixingDateBusinessCenterGrp") is IMessageView viewLegPaymentScheduleFixingDateBusinessCenterGrp)
				{
					LegPaymentScheduleFixingDateBusinessCenterGrp = new();
					((IFixParser)LegPaymentScheduleFixingDateBusinessCenterGrp).Parse(viewLegPaymentScheduleFixingDateBusinessCenterGrp);
				}
				LegPaymentScheduleFixingDateOffsetPeriod = view.GetInt32(40401);
				LegPaymentScheduleFixingDateOffsetUnit = view.GetString(40402);
				LegPaymentScheduleFixingDateOffsetDayType = view.GetInt32(40403);
				LegPaymentScheduleFixingDayDistribution = view.GetInt32(41543);
				LegPaymentScheduleFixingDayCount = view.GetInt32(41544);
				LegPaymentScheduleFixingDateAdjusted = view.GetDateOnly(40404);
				if (view.GetView("LegPaymentScheduleFixingDayGrp") is IMessageView viewLegPaymentScheduleFixingDayGrp)
				{
					LegPaymentScheduleFixingDayGrp = new();
					((IFixParser)LegPaymentScheduleFixingDayGrp).Parse(viewLegPaymentScheduleFixingDayGrp);
				}
				LegPaymentScheduleFixingLagPeriod = view.GetInt32(41545);
				LegPaymentScheduleFixingLagUnit = view.GetString(41546);
				LegPaymentScheduleFixingFirstObservationDateOffsetPeriod = view.GetInt32(41547);
				LegPaymentScheduleFixingFirstObservationDateOffsetUnit = view.GetString(41548);
				LegPaymentScheduleFixingTime = view.GetString(40405);
				LegPaymentScheduleFixingTimeBusinessCenter = view.GetString(40406);
				LegPaymentScheduleInterimExchangePaymentDateRelativeTo = view.GetInt32(40407);
				LegPaymentScheduleInterimExchangeDatesBusinessDayConvention = view.GetInt32(40408);
				if (view.GetView("LegPaymentScheduleInterimExchangeDateBusinessCenterGrp") is IMessageView viewLegPaymentScheduleInterimExchangeDateBusinessCenterGrp)
				{
					LegPaymentScheduleInterimExchangeDateBusinessCenterGrp = new();
					((IFixParser)LegPaymentScheduleInterimExchangeDateBusinessCenterGrp).Parse(viewLegPaymentScheduleInterimExchangeDateBusinessCenterGrp);
				}
				LegPaymentScheduleInterimExchangeDatesOffsetPeriod = view.GetInt32(40410);
				LegPaymentScheduleInterimExchangeDatesOffsetUnit = view.GetString(40411);
				LegPaymentScheduleInterimExchangeDatesOffsetDayType = view.GetInt32(40412);
				LegPaymentScheduleInterimExchangeDateAdjusted = view.GetDateOnly(40413);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegPaymentScheduleType":
					{
						value = LegPaymentScheduleType;
						break;
					}
					case "LegPaymentScheduleXID":
					{
						value = LegPaymentScheduleXID;
						break;
					}
					case "LegPaymentScheduleXIDRef":
					{
						value = LegPaymentScheduleXIDRef;
						break;
					}
					case "LegPaymentScheduleStubType":
					{
						value = LegPaymentScheduleStubType;
						break;
					}
					case "LegPaymentScheduleStartDateUnadjusted":
					{
						value = LegPaymentScheduleStartDateUnadjusted;
						break;
					}
					case "LegPaymentScheduleEndDateUnadjusted":
					{
						value = LegPaymentScheduleEndDateUnadjusted;
						break;
					}
					case "LegPaymentSchedulePaySide":
					{
						value = LegPaymentSchedulePaySide;
						break;
					}
					case "LegPaymentScheduleReceiveSide":
					{
						value = LegPaymentScheduleReceiveSide;
						break;
					}
					case "LegPaymentScheduleNotional":
					{
						value = LegPaymentScheduleNotional;
						break;
					}
					case "LegPaymentScheduleCurrency":
					{
						value = LegPaymentScheduleCurrency;
						break;
					}
					case "LegPaymentScheduleRate":
					{
						value = LegPaymentScheduleRate;
						break;
					}
					case "LegPaymentScheduleRateMultiplier":
					{
						value = LegPaymentScheduleRateMultiplier;
						break;
					}
					case "LegPaymentScheduleRateSpread":
					{
						value = LegPaymentScheduleRateSpread;
						break;
					}
					case "LegPaymentScheduleRateCurrency":
					{
						value = LegPaymentScheduleRateCurrency;
						break;
					}
					case "LegPaymentScheduleRateUnitOfMeasure":
					{
						value = LegPaymentScheduleRateUnitOfMeasure;
						break;
					}
					case "LegPaymentScheduleRateConversionFactor":
					{
						value = LegPaymentScheduleRateConversionFactor;
						break;
					}
					case "LegPaymentScheduleRateSpreadType":
					{
						value = LegPaymentScheduleRateSpreadType;
						break;
					}
					case "LegPaymentScheduleRateSpreadPositionType":
					{
						value = LegPaymentScheduleRateSpreadPositionType;
						break;
					}
					case "LegPaymentScheduleRateTreatment":
					{
						value = LegPaymentScheduleRateTreatment;
						break;
					}
					case "LegPaymentScheduleFixedAmount":
					{
						value = LegPaymentScheduleFixedAmount;
						break;
					}
					case "LegPaymentScheduleFixedCurrency":
					{
						value = LegPaymentScheduleFixedCurrency;
						break;
					}
					case "LegPaymentScheduleSettlPeriodPrice":
					{
						value = LegPaymentScheduleSettlPeriodPrice;
						break;
					}
					case "LegPaymentScheduleSettlPeriodPriceCurrency":
					{
						value = LegPaymentScheduleSettlPeriodPriceCurrency;
						break;
					}
					case "LegPaymentScheduleSettlPeriodPriceUnitOfMeasure":
					{
						value = LegPaymentScheduleSettlPeriodPriceUnitOfMeasure;
						break;
					}
					case "LegPaymentScheduleStepUnitOfMeasure":
					{
						value = LegPaymentScheduleStepUnitOfMeasure;
						break;
					}
					case "LegPaymentScheduleStepFrequencyPeriod":
					{
						value = LegPaymentScheduleStepFrequencyPeriod;
						break;
					}
					case "LegPaymentScheduleStepFrequencyUnit":
					{
						value = LegPaymentScheduleStepFrequencyUnit;
						break;
					}
					case "LegPaymentScheduleStepOffsetValue":
					{
						value = LegPaymentScheduleStepOffsetValue;
						break;
					}
					case "LegPaymentScheduleStepRate":
					{
						value = LegPaymentScheduleStepRate;
						break;
					}
					case "LegPaymentScheduleStepOffsetRate":
					{
						value = LegPaymentScheduleStepOffsetRate;
						break;
					}
					case "LegPaymentScheduleStepRelativeTo":
					{
						value = LegPaymentScheduleStepRelativeTo;
						break;
					}
					case "LegPaymentScheduleRateSourceGrp":
					{
						value = LegPaymentScheduleRateSourceGrp;
						break;
					}
					case "LegPaymentScheduleFixingDateUnadjusted":
					{
						value = LegPaymentScheduleFixingDateUnadjusted;
						break;
					}
					case "LegPaymentScheduleWeight":
					{
						value = LegPaymentScheduleWeight;
						break;
					}
					case "LegPaymentScheduleFixingDateRelativeTo":
					{
						value = LegPaymentScheduleFixingDateRelativeTo;
						break;
					}
					case "LegPaymentScheduleFixingDateBusinessDayConvention":
					{
						value = LegPaymentScheduleFixingDateBusinessDayConvention;
						break;
					}
					case "LegPaymentScheduleFixingDateBusinessCenterGrp":
					{
						value = LegPaymentScheduleFixingDateBusinessCenterGrp;
						break;
					}
					case "LegPaymentScheduleFixingDateOffsetPeriod":
					{
						value = LegPaymentScheduleFixingDateOffsetPeriod;
						break;
					}
					case "LegPaymentScheduleFixingDateOffsetUnit":
					{
						value = LegPaymentScheduleFixingDateOffsetUnit;
						break;
					}
					case "LegPaymentScheduleFixingDateOffsetDayType":
					{
						value = LegPaymentScheduleFixingDateOffsetDayType;
						break;
					}
					case "LegPaymentScheduleFixingDayDistribution":
					{
						value = LegPaymentScheduleFixingDayDistribution;
						break;
					}
					case "LegPaymentScheduleFixingDayCount":
					{
						value = LegPaymentScheduleFixingDayCount;
						break;
					}
					case "LegPaymentScheduleFixingDateAdjusted":
					{
						value = LegPaymentScheduleFixingDateAdjusted;
						break;
					}
					case "LegPaymentScheduleFixingDayGrp":
					{
						value = LegPaymentScheduleFixingDayGrp;
						break;
					}
					case "LegPaymentScheduleFixingLagPeriod":
					{
						value = LegPaymentScheduleFixingLagPeriod;
						break;
					}
					case "LegPaymentScheduleFixingLagUnit":
					{
						value = LegPaymentScheduleFixingLagUnit;
						break;
					}
					case "LegPaymentScheduleFixingFirstObservationDateOffsetPeriod":
					{
						value = LegPaymentScheduleFixingFirstObservationDateOffsetPeriod;
						break;
					}
					case "LegPaymentScheduleFixingFirstObservationDateOffsetUnit":
					{
						value = LegPaymentScheduleFixingFirstObservationDateOffsetUnit;
						break;
					}
					case "LegPaymentScheduleFixingTime":
					{
						value = LegPaymentScheduleFixingTime;
						break;
					}
					case "LegPaymentScheduleFixingTimeBusinessCenter":
					{
						value = LegPaymentScheduleFixingTimeBusinessCenter;
						break;
					}
					case "LegPaymentScheduleInterimExchangePaymentDateRelativeTo":
					{
						value = LegPaymentScheduleInterimExchangePaymentDateRelativeTo;
						break;
					}
					case "LegPaymentScheduleInterimExchangeDatesBusinessDayConvention":
					{
						value = LegPaymentScheduleInterimExchangeDatesBusinessDayConvention;
						break;
					}
					case "LegPaymentScheduleInterimExchangeDateBusinessCenterGrp":
					{
						value = LegPaymentScheduleInterimExchangeDateBusinessCenterGrp;
						break;
					}
					case "LegPaymentScheduleInterimExchangeDatesOffsetPeriod":
					{
						value = LegPaymentScheduleInterimExchangeDatesOffsetPeriod;
						break;
					}
					case "LegPaymentScheduleInterimExchangeDatesOffsetUnit":
					{
						value = LegPaymentScheduleInterimExchangeDatesOffsetUnit;
						break;
					}
					case "LegPaymentScheduleInterimExchangeDatesOffsetDayType":
					{
						value = LegPaymentScheduleInterimExchangeDatesOffsetDayType;
						break;
					}
					case "LegPaymentScheduleInterimExchangeDateAdjusted":
					{
						value = LegPaymentScheduleInterimExchangeDateAdjusted;
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
				LegPaymentScheduleType = null;
				LegPaymentScheduleXID = null;
				LegPaymentScheduleXIDRef = null;
				LegPaymentScheduleStubType = null;
				LegPaymentScheduleStartDateUnadjusted = null;
				LegPaymentScheduleEndDateUnadjusted = null;
				LegPaymentSchedulePaySide = null;
				LegPaymentScheduleReceiveSide = null;
				LegPaymentScheduleNotional = null;
				LegPaymentScheduleCurrency = null;
				LegPaymentScheduleRate = null;
				LegPaymentScheduleRateMultiplier = null;
				LegPaymentScheduleRateSpread = null;
				LegPaymentScheduleRateCurrency = null;
				LegPaymentScheduleRateUnitOfMeasure = null;
				LegPaymentScheduleRateConversionFactor = null;
				LegPaymentScheduleRateSpreadType = null;
				LegPaymentScheduleRateSpreadPositionType = null;
				LegPaymentScheduleRateTreatment = null;
				LegPaymentScheduleFixedAmount = null;
				LegPaymentScheduleFixedCurrency = null;
				LegPaymentScheduleSettlPeriodPrice = null;
				LegPaymentScheduleSettlPeriodPriceCurrency = null;
				LegPaymentScheduleSettlPeriodPriceUnitOfMeasure = null;
				LegPaymentScheduleStepUnitOfMeasure = null;
				LegPaymentScheduleStepFrequencyPeriod = null;
				LegPaymentScheduleStepFrequencyUnit = null;
				LegPaymentScheduleStepOffsetValue = null;
				LegPaymentScheduleStepRate = null;
				LegPaymentScheduleStepOffsetRate = null;
				LegPaymentScheduleStepRelativeTo = null;
				((IFixReset?)LegPaymentScheduleRateSourceGrp)?.Reset();
				LegPaymentScheduleFixingDateUnadjusted = null;
				LegPaymentScheduleWeight = null;
				LegPaymentScheduleFixingDateRelativeTo = null;
				LegPaymentScheduleFixingDateBusinessDayConvention = null;
				((IFixReset?)LegPaymentScheduleFixingDateBusinessCenterGrp)?.Reset();
				LegPaymentScheduleFixingDateOffsetPeriod = null;
				LegPaymentScheduleFixingDateOffsetUnit = null;
				LegPaymentScheduleFixingDateOffsetDayType = null;
				LegPaymentScheduleFixingDayDistribution = null;
				LegPaymentScheduleFixingDayCount = null;
				LegPaymentScheduleFixingDateAdjusted = null;
				((IFixReset?)LegPaymentScheduleFixingDayGrp)?.Reset();
				LegPaymentScheduleFixingLagPeriod = null;
				LegPaymentScheduleFixingLagUnit = null;
				LegPaymentScheduleFixingFirstObservationDateOffsetPeriod = null;
				LegPaymentScheduleFixingFirstObservationDateOffsetUnit = null;
				LegPaymentScheduleFixingTime = null;
				LegPaymentScheduleFixingTimeBusinessCenter = null;
				LegPaymentScheduleInterimExchangePaymentDateRelativeTo = null;
				LegPaymentScheduleInterimExchangeDatesBusinessDayConvention = null;
				((IFixReset?)LegPaymentScheduleInterimExchangeDateBusinessCenterGrp)?.Reset();
				LegPaymentScheduleInterimExchangeDatesOffsetPeriod = null;
				LegPaymentScheduleInterimExchangeDatesOffsetUnit = null;
				LegPaymentScheduleInterimExchangeDatesOffsetDayType = null;
				LegPaymentScheduleInterimExchangeDateAdjusted = null;
			}
		}
		[Group(NoOfTag = 40374, Offset = 0, Required = false)]
		public NoLegPaymentSchedules[]? LegPaymentSchedules {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentSchedules is not null && LegPaymentSchedules.Length != 0)
			{
				writer.WriteWholeNumber(40374, LegPaymentSchedules.Length);
				for (int i = 0; i < LegPaymentSchedules.Length; i++)
				{
					((IFixEncoder)LegPaymentSchedules[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegPaymentSchedules") is IMessageView viewNoLegPaymentSchedules)
			{
				var count = viewNoLegPaymentSchedules.GroupCount();
				LegPaymentSchedules = new NoLegPaymentSchedules[count];
				for (int i = 0; i < count; i++)
				{
					LegPaymentSchedules[i] = new();
					((IFixParser)LegPaymentSchedules[i]).Parse(viewNoLegPaymentSchedules.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegPaymentSchedules":
				{
					value = LegPaymentSchedules;
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
			LegPaymentSchedules = null;
		}
	}
}
