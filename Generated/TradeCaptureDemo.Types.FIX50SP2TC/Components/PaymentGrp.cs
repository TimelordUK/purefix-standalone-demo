using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentGrp : IFixComponent
	{
		public sealed partial class NoPayments : IFixGroup
		{
			[TagDetails(Tag = 40213, Type = TagType.Int, Offset = 0, Required = false)]
			public int? PaymentType {get; set;}
			
			[TagDetails(Tag = 40993, Type = TagType.Int, Offset = 1, Required = false)]
			public int? PaymentSubType {get; set;}
			
			[TagDetails(Tag = 40214, Type = TagType.Int, Offset = 2, Required = false)]
			public int? PaymentPaySide {get; set;}
			
			[TagDetails(Tag = 40215, Type = TagType.Int, Offset = 3, Required = false)]
			public int? PaymentReceiveSide {get; set;}
			
			[TagDetails(Tag = 43087, Type = TagType.String, Offset = 4, Required = false)]
			public string? PaymentDesc {get; set;}
			
			[TagDetails(Tag = 40216, Type = TagType.String, Offset = 5, Required = false)]
			public string? PaymentCurrency {get; set;}
			
			[TagDetails(Tag = 40217, Type = TagType.Float, Offset = 6, Required = false)]
			public double? PaymentAmount {get; set;}
			
			[TagDetails(Tag = 42598, Type = TagType.Int, Offset = 7, Required = false)]
			public int? PaymentAmountRelativeTo {get; set;}
			
			[TagDetails(Tag = 42599, Type = TagType.String, Offset = 8, Required = false)]
			public string? PaymentAmountDeterminationMethod {get; set;}
			
			[TagDetails(Tag = 43097, Type = TagType.Float, Offset = 9, Required = false)]
			public double? PaymentFixedRate {get; set;}
			
			[TagDetails(Tag = 43098, Type = TagType.String, Offset = 10, Required = false)]
			public string? PaymentFloatingRateIndex {get; set;}
			
			[TagDetails(Tag = 43100, Type = TagType.String, Offset = 11, Required = false)]
			public string? PaymentFloatingRateIndexCurveUnit {get; set;}
			
			[TagDetails(Tag = 43099, Type = TagType.Int, Offset = 12, Required = false)]
			public int? PaymentFloatingRateIndexCurvePeriod {get; set;}
			
			[TagDetails(Tag = 43101, Type = TagType.Float, Offset = 13, Required = false)]
			public double? PaymentFloatingRateSpread {get; set;}
			
			[TagDetails(Tag = 43105, Type = TagType.String, Offset = 14, Required = false)]
			public string? PaymentRateResetFrequencyUnit {get; set;}
			
			[TagDetails(Tag = 43104, Type = TagType.Int, Offset = 15, Required = false)]
			public int? PaymentRateResetFrequencyPeriod {get; set;}
			
			[TagDetails(Tag = 43103, Type = TagType.String, Offset = 16, Required = false)]
			public string? PaymentFrequencyUnit {get; set;}
			
			[TagDetails(Tag = 43102, Type = TagType.Int, Offset = 17, Required = false)]
			public int? PaymentFrequencyPeriod {get; set;}
			
			[TagDetails(Tag = 40218, Type = TagType.Float, Offset = 18, Required = false)]
			public double? PaymentPrice {get; set;}
			
			[TagDetails(Tag = 40919, Type = TagType.Int, Offset = 19, Required = false)]
			public int? PaymentPriceType {get; set;}
			
			[TagDetails(Tag = 41155, Type = TagType.String, Offset = 20, Required = false)]
			public string? PaymentUnitOfMeasure {get; set;}
			
			[TagDetails(Tag = 40219, Type = TagType.LocalDate, Offset = 21, Required = false)]
			public DateOnly? PaymentDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 40220, Type = TagType.Int, Offset = 22, Required = false)]
			public int? PaymentBusinessDayConvention {get; set;}
			
			[Component(Offset = 23, Required = false)]
			public PaymentBusinessCenterGrp? PaymentBusinessCenterGrp {get; set;}
			
			[TagDetails(Tag = 41156, Type = TagType.Int, Offset = 24, Required = false)]
			public int? PaymentDateRelativeTo {get; set;}
			
			[TagDetails(Tag = 41157, Type = TagType.Int, Offset = 25, Required = false)]
			public int? PaymentDateOffsetPeriod {get; set;}
			
			[TagDetails(Tag = 41158, Type = TagType.String, Offset = 26, Required = false)]
			public string? PaymentDateOffsetUnit {get; set;}
			
			[TagDetails(Tag = 41159, Type = TagType.Int, Offset = 27, Required = false)]
			public int? PaymentDateOffsetDayType {get; set;}
			
			[TagDetails(Tag = 40222, Type = TagType.LocalDate, Offset = 28, Required = false)]
			public DateOnly? PaymentDateAdjusted {get; set;}
			
			[TagDetails(Tag = 41160, Type = TagType.Int, Offset = 29, Required = false)]
			public int? PaymentForwardStartType {get; set;}
			
			[TagDetails(Tag = 40224, Type = TagType.Float, Offset = 30, Required = false)]
			public double? PaymentDiscountFactor {get; set;}
			
			[TagDetails(Tag = 40225, Type = TagType.Float, Offset = 31, Required = false)]
			public double? PaymentPresentValueAmount {get; set;}
			
			[TagDetails(Tag = 40226, Type = TagType.String, Offset = 32, Required = false)]
			public string? PaymentPresentValueCurrency {get; set;}
			
			[TagDetails(Tag = 40227, Type = TagType.Int, Offset = 33, Required = false)]
			public int? PaymentSettlStyle {get; set;}
			
			[TagDetails(Tag = 492, Type = TagType.Int, Offset = 34, Required = false)]
			public int? PaymentMethod {get; set;}
			
			[Component(Offset = 35, Required = false)]
			public PaymentSettlGrp? PaymentSettlGrp {get; set;}
			
			[TagDetails(Tag = 41304, Type = TagType.String, Offset = 36, Required = false)]
			public string? PaymentLegRefID {get; set;}
			
			[TagDetails(Tag = 40229, Type = TagType.String, Offset = 37, Required = false)]
			public string? PaymentText {get; set;}
			
			[TagDetails(Tag = 40984, Type = TagType.Length, Offset = 38, Required = false)]
			public int? EncodedPaymentTextLen {get; set;}
			
			[TagDetails(Tag = 40985, Type = TagType.RawData, Offset = 39, Required = false)]
			public byte[]? EncodedPaymentText {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PaymentType is not null) writer.WriteWholeNumber(40213, PaymentType.Value);
				if (PaymentSubType is not null) writer.WriteWholeNumber(40993, PaymentSubType.Value);
				if (PaymentPaySide is not null) writer.WriteWholeNumber(40214, PaymentPaySide.Value);
				if (PaymentReceiveSide is not null) writer.WriteWholeNumber(40215, PaymentReceiveSide.Value);
				if (PaymentDesc is not null) writer.WriteString(43087, PaymentDesc);
				if (PaymentCurrency is not null) writer.WriteString(40216, PaymentCurrency);
				if (PaymentAmount is not null) writer.WriteNumber(40217, PaymentAmount.Value);
				if (PaymentAmountRelativeTo is not null) writer.WriteWholeNumber(42598, PaymentAmountRelativeTo.Value);
				if (PaymentAmountDeterminationMethod is not null) writer.WriteString(42599, PaymentAmountDeterminationMethod);
				if (PaymentFixedRate is not null) writer.WriteNumber(43097, PaymentFixedRate.Value);
				if (PaymentFloatingRateIndex is not null) writer.WriteString(43098, PaymentFloatingRateIndex);
				if (PaymentFloatingRateIndexCurveUnit is not null) writer.WriteString(43100, PaymentFloatingRateIndexCurveUnit);
				if (PaymentFloatingRateIndexCurvePeriod is not null) writer.WriteWholeNumber(43099, PaymentFloatingRateIndexCurvePeriod.Value);
				if (PaymentFloatingRateSpread is not null) writer.WriteNumber(43101, PaymentFloatingRateSpread.Value);
				if (PaymentRateResetFrequencyUnit is not null) writer.WriteString(43105, PaymentRateResetFrequencyUnit);
				if (PaymentRateResetFrequencyPeriod is not null) writer.WriteWholeNumber(43104, PaymentRateResetFrequencyPeriod.Value);
				if (PaymentFrequencyUnit is not null) writer.WriteString(43103, PaymentFrequencyUnit);
				if (PaymentFrequencyPeriod is not null) writer.WriteWholeNumber(43102, PaymentFrequencyPeriod.Value);
				if (PaymentPrice is not null) writer.WriteNumber(40218, PaymentPrice.Value);
				if (PaymentPriceType is not null) writer.WriteWholeNumber(40919, PaymentPriceType.Value);
				if (PaymentUnitOfMeasure is not null) writer.WriteString(41155, PaymentUnitOfMeasure);
				if (PaymentDateUnadjusted is not null) writer.WriteLocalDateOnly(40219, PaymentDateUnadjusted.Value);
				if (PaymentBusinessDayConvention is not null) writer.WriteWholeNumber(40220, PaymentBusinessDayConvention.Value);
				if (PaymentBusinessCenterGrp is not null) ((IFixEncoder)PaymentBusinessCenterGrp).Encode(writer);
				if (PaymentDateRelativeTo is not null) writer.WriteWholeNumber(41156, PaymentDateRelativeTo.Value);
				if (PaymentDateOffsetPeriod is not null) writer.WriteWholeNumber(41157, PaymentDateOffsetPeriod.Value);
				if (PaymentDateOffsetUnit is not null) writer.WriteString(41158, PaymentDateOffsetUnit);
				if (PaymentDateOffsetDayType is not null) writer.WriteWholeNumber(41159, PaymentDateOffsetDayType.Value);
				if (PaymentDateAdjusted is not null) writer.WriteLocalDateOnly(40222, PaymentDateAdjusted.Value);
				if (PaymentForwardStartType is not null) writer.WriteWholeNumber(41160, PaymentForwardStartType.Value);
				if (PaymentDiscountFactor is not null) writer.WriteNumber(40224, PaymentDiscountFactor.Value);
				if (PaymentPresentValueAmount is not null) writer.WriteNumber(40225, PaymentPresentValueAmount.Value);
				if (PaymentPresentValueCurrency is not null) writer.WriteString(40226, PaymentPresentValueCurrency);
				if (PaymentSettlStyle is not null) writer.WriteWholeNumber(40227, PaymentSettlStyle.Value);
				if (PaymentMethod is not null) writer.WriteWholeNumber(492, PaymentMethod.Value);
				if (PaymentSettlGrp is not null) ((IFixEncoder)PaymentSettlGrp).Encode(writer);
				if (PaymentLegRefID is not null) writer.WriteString(41304, PaymentLegRefID);
				if (PaymentText is not null) writer.WriteString(40229, PaymentText);
				if (EncodedPaymentTextLen is not null) writer.WriteWholeNumber(40984, EncodedPaymentTextLen.Value);
				if (EncodedPaymentText is not null) writer.WriteBuffer(40985, EncodedPaymentText);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PaymentType = view.GetInt32(40213);
				PaymentSubType = view.GetInt32(40993);
				PaymentPaySide = view.GetInt32(40214);
				PaymentReceiveSide = view.GetInt32(40215);
				PaymentDesc = view.GetString(43087);
				PaymentCurrency = view.GetString(40216);
				PaymentAmount = view.GetDouble(40217);
				PaymentAmountRelativeTo = view.GetInt32(42598);
				PaymentAmountDeterminationMethod = view.GetString(42599);
				PaymentFixedRate = view.GetDouble(43097);
				PaymentFloatingRateIndex = view.GetString(43098);
				PaymentFloatingRateIndexCurveUnit = view.GetString(43100);
				PaymentFloatingRateIndexCurvePeriod = view.GetInt32(43099);
				PaymentFloatingRateSpread = view.GetDouble(43101);
				PaymentRateResetFrequencyUnit = view.GetString(43105);
				PaymentRateResetFrequencyPeriod = view.GetInt32(43104);
				PaymentFrequencyUnit = view.GetString(43103);
				PaymentFrequencyPeriod = view.GetInt32(43102);
				PaymentPrice = view.GetDouble(40218);
				PaymentPriceType = view.GetInt32(40919);
				PaymentUnitOfMeasure = view.GetString(41155);
				PaymentDateUnadjusted = view.GetDateOnly(40219);
				PaymentBusinessDayConvention = view.GetInt32(40220);
				if (view.GetView("PaymentBusinessCenterGrp") is IMessageView viewPaymentBusinessCenterGrp)
				{
					PaymentBusinessCenterGrp = new();
					((IFixParser)PaymentBusinessCenterGrp).Parse(viewPaymentBusinessCenterGrp);
				}
				PaymentDateRelativeTo = view.GetInt32(41156);
				PaymentDateOffsetPeriod = view.GetInt32(41157);
				PaymentDateOffsetUnit = view.GetString(41158);
				PaymentDateOffsetDayType = view.GetInt32(41159);
				PaymentDateAdjusted = view.GetDateOnly(40222);
				PaymentForwardStartType = view.GetInt32(41160);
				PaymentDiscountFactor = view.GetDouble(40224);
				PaymentPresentValueAmount = view.GetDouble(40225);
				PaymentPresentValueCurrency = view.GetString(40226);
				PaymentSettlStyle = view.GetInt32(40227);
				PaymentMethod = view.GetInt32(492);
				if (view.GetView("PaymentSettlGrp") is IMessageView viewPaymentSettlGrp)
				{
					PaymentSettlGrp = new();
					((IFixParser)PaymentSettlGrp).Parse(viewPaymentSettlGrp);
				}
				PaymentLegRefID = view.GetString(41304);
				PaymentText = view.GetString(40229);
				EncodedPaymentTextLen = view.GetInt32(40984);
				EncodedPaymentText = view.GetByteArray(40985);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PaymentType":
					{
						value = PaymentType;
						break;
					}
					case "PaymentSubType":
					{
						value = PaymentSubType;
						break;
					}
					case "PaymentPaySide":
					{
						value = PaymentPaySide;
						break;
					}
					case "PaymentReceiveSide":
					{
						value = PaymentReceiveSide;
						break;
					}
					case "PaymentDesc":
					{
						value = PaymentDesc;
						break;
					}
					case "PaymentCurrency":
					{
						value = PaymentCurrency;
						break;
					}
					case "PaymentAmount":
					{
						value = PaymentAmount;
						break;
					}
					case "PaymentAmountRelativeTo":
					{
						value = PaymentAmountRelativeTo;
						break;
					}
					case "PaymentAmountDeterminationMethod":
					{
						value = PaymentAmountDeterminationMethod;
						break;
					}
					case "PaymentFixedRate":
					{
						value = PaymentFixedRate;
						break;
					}
					case "PaymentFloatingRateIndex":
					{
						value = PaymentFloatingRateIndex;
						break;
					}
					case "PaymentFloatingRateIndexCurveUnit":
					{
						value = PaymentFloatingRateIndexCurveUnit;
						break;
					}
					case "PaymentFloatingRateIndexCurvePeriod":
					{
						value = PaymentFloatingRateIndexCurvePeriod;
						break;
					}
					case "PaymentFloatingRateSpread":
					{
						value = PaymentFloatingRateSpread;
						break;
					}
					case "PaymentRateResetFrequencyUnit":
					{
						value = PaymentRateResetFrequencyUnit;
						break;
					}
					case "PaymentRateResetFrequencyPeriod":
					{
						value = PaymentRateResetFrequencyPeriod;
						break;
					}
					case "PaymentFrequencyUnit":
					{
						value = PaymentFrequencyUnit;
						break;
					}
					case "PaymentFrequencyPeriod":
					{
						value = PaymentFrequencyPeriod;
						break;
					}
					case "PaymentPrice":
					{
						value = PaymentPrice;
						break;
					}
					case "PaymentPriceType":
					{
						value = PaymentPriceType;
						break;
					}
					case "PaymentUnitOfMeasure":
					{
						value = PaymentUnitOfMeasure;
						break;
					}
					case "PaymentDateUnadjusted":
					{
						value = PaymentDateUnadjusted;
						break;
					}
					case "PaymentBusinessDayConvention":
					{
						value = PaymentBusinessDayConvention;
						break;
					}
					case "PaymentBusinessCenterGrp":
					{
						value = PaymentBusinessCenterGrp;
						break;
					}
					case "PaymentDateRelativeTo":
					{
						value = PaymentDateRelativeTo;
						break;
					}
					case "PaymentDateOffsetPeriod":
					{
						value = PaymentDateOffsetPeriod;
						break;
					}
					case "PaymentDateOffsetUnit":
					{
						value = PaymentDateOffsetUnit;
						break;
					}
					case "PaymentDateOffsetDayType":
					{
						value = PaymentDateOffsetDayType;
						break;
					}
					case "PaymentDateAdjusted":
					{
						value = PaymentDateAdjusted;
						break;
					}
					case "PaymentForwardStartType":
					{
						value = PaymentForwardStartType;
						break;
					}
					case "PaymentDiscountFactor":
					{
						value = PaymentDiscountFactor;
						break;
					}
					case "PaymentPresentValueAmount":
					{
						value = PaymentPresentValueAmount;
						break;
					}
					case "PaymentPresentValueCurrency":
					{
						value = PaymentPresentValueCurrency;
						break;
					}
					case "PaymentSettlStyle":
					{
						value = PaymentSettlStyle;
						break;
					}
					case "PaymentMethod":
					{
						value = PaymentMethod;
						break;
					}
					case "PaymentSettlGrp":
					{
						value = PaymentSettlGrp;
						break;
					}
					case "PaymentLegRefID":
					{
						value = PaymentLegRefID;
						break;
					}
					case "PaymentText":
					{
						value = PaymentText;
						break;
					}
					case "EncodedPaymentTextLen":
					{
						value = EncodedPaymentTextLen;
						break;
					}
					case "EncodedPaymentText":
					{
						value = EncodedPaymentText;
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
				PaymentType = null;
				PaymentSubType = null;
				PaymentPaySide = null;
				PaymentReceiveSide = null;
				PaymentDesc = null;
				PaymentCurrency = null;
				PaymentAmount = null;
				PaymentAmountRelativeTo = null;
				PaymentAmountDeterminationMethod = null;
				PaymentFixedRate = null;
				PaymentFloatingRateIndex = null;
				PaymentFloatingRateIndexCurveUnit = null;
				PaymentFloatingRateIndexCurvePeriod = null;
				PaymentFloatingRateSpread = null;
				PaymentRateResetFrequencyUnit = null;
				PaymentRateResetFrequencyPeriod = null;
				PaymentFrequencyUnit = null;
				PaymentFrequencyPeriod = null;
				PaymentPrice = null;
				PaymentPriceType = null;
				PaymentUnitOfMeasure = null;
				PaymentDateUnadjusted = null;
				PaymentBusinessDayConvention = null;
				((IFixReset?)PaymentBusinessCenterGrp)?.Reset();
				PaymentDateRelativeTo = null;
				PaymentDateOffsetPeriod = null;
				PaymentDateOffsetUnit = null;
				PaymentDateOffsetDayType = null;
				PaymentDateAdjusted = null;
				PaymentForwardStartType = null;
				PaymentDiscountFactor = null;
				PaymentPresentValueAmount = null;
				PaymentPresentValueCurrency = null;
				PaymentSettlStyle = null;
				PaymentMethod = null;
				((IFixReset?)PaymentSettlGrp)?.Reset();
				PaymentLegRefID = null;
				PaymentText = null;
				EncodedPaymentTextLen = null;
				EncodedPaymentText = null;
			}
		}
		[Group(NoOfTag = 40212, Offset = 0, Required = false)]
		public NoPayments[]? Payments {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Payments is not null && Payments.Length != 0)
			{
				writer.WriteWholeNumber(40212, Payments.Length);
				for (int i = 0; i < Payments.Length; i++)
				{
					((IFixEncoder)Payments[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPayments") is IMessageView viewNoPayments)
			{
				var count = viewNoPayments.GroupCount();
				Payments = new NoPayments[count];
				for (int i = 0; i < count; i++)
				{
					Payments[i] = new();
					((IFixParser)Payments[i]).Parse(viewNoPayments.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPayments":
				{
					value = Payments;
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
			Payments = null;
		}
	}
}
