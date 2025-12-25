using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegDividendConditions : IFixComponent
	{
		[TagDetails(Tag = 42337, Type = TagType.Boolean, Offset = 0, Required = false)]
		public bool? LegDividendReinvestmentIndicator {get; set;}
		
		[TagDetails(Tag = 42338, Type = TagType.Int, Offset = 1, Required = false)]
		public int? LegDividendEntitlementEvent {get; set;}
		
		[TagDetails(Tag = 42339, Type = TagType.Int, Offset = 2, Required = false)]
		public int? LegDividendAmountType {get; set;}
		
		[TagDetails(Tag = 42340, Type = TagType.String, Offset = 3, Required = false)]
		public string? LegDividendUnderlierRefID {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public LegDividendPeriodGrp? LegDividendPeriodGrp {get; set;}
		
		[TagDetails(Tag = 42341, Type = TagType.Int, Offset = 5, Required = false)]
		public int? LegExtraordinaryDividendPartySide {get; set;}
		
		[TagDetails(Tag = 42342, Type = TagType.Int, Offset = 6, Required = false)]
		public int? LegExtraordinaryDividendAmountType {get; set;}
		
		[TagDetails(Tag = 42343, Type = TagType.String, Offset = 7, Required = false)]
		public string? LegExtraordinaryDividendCurrency {get; set;}
		
		[TagDetails(Tag = 42344, Type = TagType.String, Offset = 8, Required = false)]
		public string? LegExtraordinaryDividendDeterminationMethod {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public LegDividendFXTriggerDate? LegDividendFXTriggerDate {get; set;}
		
		[Component(Offset = 10, Required = false)]
		public LegDividendAccrualFloatingRate? LegDividendAccrualFloatingRate {get; set;}
		
		[TagDetails(Tag = 42345, Type = TagType.Float, Offset = 11, Required = false)]
		public double? LegDividendAccrualFixedRate {get; set;}
		
		[Component(Offset = 12, Required = false)]
		public LegDividendAccrualPaymentDate? LegDividendAccrualPaymentDate {get; set;}
		
		[TagDetails(Tag = 42346, Type = TagType.Int, Offset = 13, Required = false)]
		public int? LegDividendCompoundingMethod {get; set;}
		
		[TagDetails(Tag = 42347, Type = TagType.Int, Offset = 14, Required = false)]
		public int? LegDividendNumOfIndexUnits {get; set;}
		
		[TagDetails(Tag = 42348, Type = TagType.Float, Offset = 15, Required = false)]
		public double? LegDividendCashPercentage {get; set;}
		
		[TagDetails(Tag = 42349, Type = TagType.Float, Offset = 16, Required = false)]
		public double? LegDividendCashEquivalentPercentage {get; set;}
		
		[TagDetails(Tag = 42350, Type = TagType.Int, Offset = 17, Required = false)]
		public int? LegNonCashDividendTreatment {get; set;}
		
		[TagDetails(Tag = 42351, Type = TagType.Int, Offset = 18, Required = false)]
		public int? LegDividendComposition {get; set;}
		
		[TagDetails(Tag = 42352, Type = TagType.Boolean, Offset = 19, Required = false)]
		public bool? LegSpecialDividendsIndicator {get; set;}
		
		[TagDetails(Tag = 42353, Type = TagType.Boolean, Offset = 20, Required = false)]
		public bool? LegMaterialDividendsIndicator {get; set;}
		
		[TagDetails(Tag = 42354, Type = TagType.Boolean, Offset = 21, Required = false)]
		public bool? LegOptionsExchangeDividendsIndicator {get; set;}
		
		[TagDetails(Tag = 42355, Type = TagType.Boolean, Offset = 22, Required = false)]
		public bool? LegAdditionalDividendsIndicator {get; set;}
		
		[TagDetails(Tag = 42356, Type = TagType.Boolean, Offset = 23, Required = false)]
		public bool? LegAllDividendsIndicator {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegDividendReinvestmentIndicator is not null) writer.WriteBoolean(42337, LegDividendReinvestmentIndicator.Value);
			if (LegDividendEntitlementEvent is not null) writer.WriteWholeNumber(42338, LegDividendEntitlementEvent.Value);
			if (LegDividendAmountType is not null) writer.WriteWholeNumber(42339, LegDividendAmountType.Value);
			if (LegDividendUnderlierRefID is not null) writer.WriteString(42340, LegDividendUnderlierRefID);
			if (LegDividendPeriodGrp is not null) ((IFixEncoder)LegDividendPeriodGrp).Encode(writer);
			if (LegExtraordinaryDividendPartySide is not null) writer.WriteWholeNumber(42341, LegExtraordinaryDividendPartySide.Value);
			if (LegExtraordinaryDividendAmountType is not null) writer.WriteWholeNumber(42342, LegExtraordinaryDividendAmountType.Value);
			if (LegExtraordinaryDividendCurrency is not null) writer.WriteString(42343, LegExtraordinaryDividendCurrency);
			if (LegExtraordinaryDividendDeterminationMethod is not null) writer.WriteString(42344, LegExtraordinaryDividendDeterminationMethod);
			if (LegDividendFXTriggerDate is not null) ((IFixEncoder)LegDividendFXTriggerDate).Encode(writer);
			if (LegDividendAccrualFloatingRate is not null) ((IFixEncoder)LegDividendAccrualFloatingRate).Encode(writer);
			if (LegDividendAccrualFixedRate is not null) writer.WriteNumber(42345, LegDividendAccrualFixedRate.Value);
			if (LegDividendAccrualPaymentDate is not null) ((IFixEncoder)LegDividendAccrualPaymentDate).Encode(writer);
			if (LegDividendCompoundingMethod is not null) writer.WriteWholeNumber(42346, LegDividendCompoundingMethod.Value);
			if (LegDividendNumOfIndexUnits is not null) writer.WriteWholeNumber(42347, LegDividendNumOfIndexUnits.Value);
			if (LegDividendCashPercentage is not null) writer.WriteNumber(42348, LegDividendCashPercentage.Value);
			if (LegDividendCashEquivalentPercentage is not null) writer.WriteNumber(42349, LegDividendCashEquivalentPercentage.Value);
			if (LegNonCashDividendTreatment is not null) writer.WriteWholeNumber(42350, LegNonCashDividendTreatment.Value);
			if (LegDividendComposition is not null) writer.WriteWholeNumber(42351, LegDividendComposition.Value);
			if (LegSpecialDividendsIndicator is not null) writer.WriteBoolean(42352, LegSpecialDividendsIndicator.Value);
			if (LegMaterialDividendsIndicator is not null) writer.WriteBoolean(42353, LegMaterialDividendsIndicator.Value);
			if (LegOptionsExchangeDividendsIndicator is not null) writer.WriteBoolean(42354, LegOptionsExchangeDividendsIndicator.Value);
			if (LegAdditionalDividendsIndicator is not null) writer.WriteBoolean(42355, LegAdditionalDividendsIndicator.Value);
			if (LegAllDividendsIndicator is not null) writer.WriteBoolean(42356, LegAllDividendsIndicator.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegDividendReinvestmentIndicator = view.GetBool(42337);
			LegDividendEntitlementEvent = view.GetInt32(42338);
			LegDividendAmountType = view.GetInt32(42339);
			LegDividendUnderlierRefID = view.GetString(42340);
			if (view.GetView("LegDividendPeriodGrp") is IMessageView viewLegDividendPeriodGrp)
			{
				LegDividendPeriodGrp = new();
				((IFixParser)LegDividendPeriodGrp).Parse(viewLegDividendPeriodGrp);
			}
			LegExtraordinaryDividendPartySide = view.GetInt32(42341);
			LegExtraordinaryDividendAmountType = view.GetInt32(42342);
			LegExtraordinaryDividendCurrency = view.GetString(42343);
			LegExtraordinaryDividendDeterminationMethod = view.GetString(42344);
			if (view.GetView("LegDividendFXTriggerDate") is IMessageView viewLegDividendFXTriggerDate)
			{
				LegDividendFXTriggerDate = new();
				((IFixParser)LegDividendFXTriggerDate).Parse(viewLegDividendFXTriggerDate);
			}
			if (view.GetView("LegDividendAccrualFloatingRate") is IMessageView viewLegDividendAccrualFloatingRate)
			{
				LegDividendAccrualFloatingRate = new();
				((IFixParser)LegDividendAccrualFloatingRate).Parse(viewLegDividendAccrualFloatingRate);
			}
			LegDividendAccrualFixedRate = view.GetDouble(42345);
			if (view.GetView("LegDividendAccrualPaymentDate") is IMessageView viewLegDividendAccrualPaymentDate)
			{
				LegDividendAccrualPaymentDate = new();
				((IFixParser)LegDividendAccrualPaymentDate).Parse(viewLegDividendAccrualPaymentDate);
			}
			LegDividendCompoundingMethod = view.GetInt32(42346);
			LegDividendNumOfIndexUnits = view.GetInt32(42347);
			LegDividendCashPercentage = view.GetDouble(42348);
			LegDividendCashEquivalentPercentage = view.GetDouble(42349);
			LegNonCashDividendTreatment = view.GetInt32(42350);
			LegDividendComposition = view.GetInt32(42351);
			LegSpecialDividendsIndicator = view.GetBool(42352);
			LegMaterialDividendsIndicator = view.GetBool(42353);
			LegOptionsExchangeDividendsIndicator = view.GetBool(42354);
			LegAdditionalDividendsIndicator = view.GetBool(42355);
			LegAllDividendsIndicator = view.GetBool(42356);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegDividendReinvestmentIndicator":
				{
					value = LegDividendReinvestmentIndicator;
					break;
				}
				case "LegDividendEntitlementEvent":
				{
					value = LegDividendEntitlementEvent;
					break;
				}
				case "LegDividendAmountType":
				{
					value = LegDividendAmountType;
					break;
				}
				case "LegDividendUnderlierRefID":
				{
					value = LegDividendUnderlierRefID;
					break;
				}
				case "LegDividendPeriodGrp":
				{
					value = LegDividendPeriodGrp;
					break;
				}
				case "LegExtraordinaryDividendPartySide":
				{
					value = LegExtraordinaryDividendPartySide;
					break;
				}
				case "LegExtraordinaryDividendAmountType":
				{
					value = LegExtraordinaryDividendAmountType;
					break;
				}
				case "LegExtraordinaryDividendCurrency":
				{
					value = LegExtraordinaryDividendCurrency;
					break;
				}
				case "LegExtraordinaryDividendDeterminationMethod":
				{
					value = LegExtraordinaryDividendDeterminationMethod;
					break;
				}
				case "LegDividendFXTriggerDate":
				{
					value = LegDividendFXTriggerDate;
					break;
				}
				case "LegDividendAccrualFloatingRate":
				{
					value = LegDividendAccrualFloatingRate;
					break;
				}
				case "LegDividendAccrualFixedRate":
				{
					value = LegDividendAccrualFixedRate;
					break;
				}
				case "LegDividendAccrualPaymentDate":
				{
					value = LegDividendAccrualPaymentDate;
					break;
				}
				case "LegDividendCompoundingMethod":
				{
					value = LegDividendCompoundingMethod;
					break;
				}
				case "LegDividendNumOfIndexUnits":
				{
					value = LegDividendNumOfIndexUnits;
					break;
				}
				case "LegDividendCashPercentage":
				{
					value = LegDividendCashPercentage;
					break;
				}
				case "LegDividendCashEquivalentPercentage":
				{
					value = LegDividendCashEquivalentPercentage;
					break;
				}
				case "LegNonCashDividendTreatment":
				{
					value = LegNonCashDividendTreatment;
					break;
				}
				case "LegDividendComposition":
				{
					value = LegDividendComposition;
					break;
				}
				case "LegSpecialDividendsIndicator":
				{
					value = LegSpecialDividendsIndicator;
					break;
				}
				case "LegMaterialDividendsIndicator":
				{
					value = LegMaterialDividendsIndicator;
					break;
				}
				case "LegOptionsExchangeDividendsIndicator":
				{
					value = LegOptionsExchangeDividendsIndicator;
					break;
				}
				case "LegAdditionalDividendsIndicator":
				{
					value = LegAdditionalDividendsIndicator;
					break;
				}
				case "LegAllDividendsIndicator":
				{
					value = LegAllDividendsIndicator;
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
			LegDividendReinvestmentIndicator = null;
			LegDividendEntitlementEvent = null;
			LegDividendAmountType = null;
			LegDividendUnderlierRefID = null;
			((IFixReset?)LegDividendPeriodGrp)?.Reset();
			LegExtraordinaryDividendPartySide = null;
			LegExtraordinaryDividendAmountType = null;
			LegExtraordinaryDividendCurrency = null;
			LegExtraordinaryDividendDeterminationMethod = null;
			((IFixReset?)LegDividendFXTriggerDate)?.Reset();
			((IFixReset?)LegDividendAccrualFloatingRate)?.Reset();
			LegDividendAccrualFixedRate = null;
			((IFixReset?)LegDividendAccrualPaymentDate)?.Reset();
			LegDividendCompoundingMethod = null;
			LegDividendNumOfIndexUnits = null;
			LegDividendCashPercentage = null;
			LegDividendCashEquivalentPercentage = null;
			LegNonCashDividendTreatment = null;
			LegDividendComposition = null;
			LegSpecialDividendsIndicator = null;
			LegMaterialDividendsIndicator = null;
			LegOptionsExchangeDividendsIndicator = null;
			LegAdditionalDividendsIndicator = null;
			LegAllDividendsIndicator = null;
		}
	}
}
