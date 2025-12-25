using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingDividendConditions : IFixComponent
	{
		[TagDetails(Tag = 42826, Type = TagType.Boolean, Offset = 0, Required = false)]
		public bool? UnderlyingDividendReinvestmentIndicator {get; set;}
		
		[TagDetails(Tag = 42827, Type = TagType.Int, Offset = 1, Required = false)]
		public int? UnderlyingDividendEntitlementEvent {get; set;}
		
		[TagDetails(Tag = 42828, Type = TagType.Int, Offset = 2, Required = false)]
		public int? UnderlyingDividendAmountType {get; set;}
		
		[TagDetails(Tag = 42829, Type = TagType.String, Offset = 3, Required = false)]
		public string? UnderlyingDividendUnderlierRefID {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public UnderlyingDividendPeriodGrp? UnderlyingDividendPeriodGrp {get; set;}
		
		[TagDetails(Tag = 42830, Type = TagType.Int, Offset = 5, Required = false)]
		public int? UnderlyingExtraordinaryDividendPartySide {get; set;}
		
		[TagDetails(Tag = 42831, Type = TagType.Int, Offset = 6, Required = false)]
		public int? UnderlyingExtraordinaryDividendAmountType {get; set;}
		
		[TagDetails(Tag = 42832, Type = TagType.String, Offset = 7, Required = false)]
		public string? UnderlyingExtraordinaryDividendCurrency {get; set;}
		
		[TagDetails(Tag = 42833, Type = TagType.String, Offset = 8, Required = false)]
		public string? UnderlyingExtraordinaryDividendDeterminationMethod {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public UnderlyingDividendFXTriggerDate? UnderlyingDividendFXTriggerDate {get; set;}
		
		[Component(Offset = 10, Required = false)]
		public UnderlyingDividendAccrualFloatingRate? UnderlyingDividendAccrualFloatingRate {get; set;}
		
		[TagDetails(Tag = 42834, Type = TagType.Float, Offset = 11, Required = false)]
		public double? UnderlyingDividendAccrualFixedRate {get; set;}
		
		[Component(Offset = 12, Required = false)]
		public UnderlyingDividendAccrualPaymentDate? UnderlyingDividendAccrualPaymentDate {get; set;}
		
		[TagDetails(Tag = 42835, Type = TagType.Int, Offset = 13, Required = false)]
		public int? UnderlyingDividendCompoundingMethod {get; set;}
		
		[TagDetails(Tag = 42836, Type = TagType.Int, Offset = 14, Required = false)]
		public int? UnderlyingDividendNumOfIndexUnits {get; set;}
		
		[TagDetails(Tag = 42837, Type = TagType.Float, Offset = 15, Required = false)]
		public double? UnderlyingDividendCashPercentage {get; set;}
		
		[TagDetails(Tag = 42838, Type = TagType.Float, Offset = 16, Required = false)]
		public double? UnderlyingDividendCashEquivalentPercentage {get; set;}
		
		[TagDetails(Tag = 42839, Type = TagType.Int, Offset = 17, Required = false)]
		public int? UnderlyingNonCashDividendTreatment {get; set;}
		
		[TagDetails(Tag = 42840, Type = TagType.Int, Offset = 18, Required = false)]
		public int? UnderlyingDividendComposition {get; set;}
		
		[TagDetails(Tag = 42841, Type = TagType.Boolean, Offset = 19, Required = false)]
		public bool? UnderlyingSpecialDividendsIndicator {get; set;}
		
		[TagDetails(Tag = 42842, Type = TagType.Boolean, Offset = 20, Required = false)]
		public bool? UnderlyingMaterialDividendsIndicator {get; set;}
		
		[TagDetails(Tag = 42843, Type = TagType.Boolean, Offset = 21, Required = false)]
		public bool? UnderlyingOptionsExchangeDividendsIndicator {get; set;}
		
		[TagDetails(Tag = 42844, Type = TagType.Boolean, Offset = 22, Required = false)]
		public bool? UnderlyingAdditionalDividendsIndicator {get; set;}
		
		[TagDetails(Tag = 42845, Type = TagType.Boolean, Offset = 23, Required = false)]
		public bool? UnderlyingAllDividendsIndicator {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingDividendReinvestmentIndicator is not null) writer.WriteBoolean(42826, UnderlyingDividendReinvestmentIndicator.Value);
			if (UnderlyingDividendEntitlementEvent is not null) writer.WriteWholeNumber(42827, UnderlyingDividendEntitlementEvent.Value);
			if (UnderlyingDividendAmountType is not null) writer.WriteWholeNumber(42828, UnderlyingDividendAmountType.Value);
			if (UnderlyingDividendUnderlierRefID is not null) writer.WriteString(42829, UnderlyingDividendUnderlierRefID);
			if (UnderlyingDividendPeriodGrp is not null) ((IFixEncoder)UnderlyingDividendPeriodGrp).Encode(writer);
			if (UnderlyingExtraordinaryDividendPartySide is not null) writer.WriteWholeNumber(42830, UnderlyingExtraordinaryDividendPartySide.Value);
			if (UnderlyingExtraordinaryDividendAmountType is not null) writer.WriteWholeNumber(42831, UnderlyingExtraordinaryDividendAmountType.Value);
			if (UnderlyingExtraordinaryDividendCurrency is not null) writer.WriteString(42832, UnderlyingExtraordinaryDividendCurrency);
			if (UnderlyingExtraordinaryDividendDeterminationMethod is not null) writer.WriteString(42833, UnderlyingExtraordinaryDividendDeterminationMethod);
			if (UnderlyingDividendFXTriggerDate is not null) ((IFixEncoder)UnderlyingDividendFXTriggerDate).Encode(writer);
			if (UnderlyingDividendAccrualFloatingRate is not null) ((IFixEncoder)UnderlyingDividendAccrualFloatingRate).Encode(writer);
			if (UnderlyingDividendAccrualFixedRate is not null) writer.WriteNumber(42834, UnderlyingDividendAccrualFixedRate.Value);
			if (UnderlyingDividendAccrualPaymentDate is not null) ((IFixEncoder)UnderlyingDividendAccrualPaymentDate).Encode(writer);
			if (UnderlyingDividendCompoundingMethod is not null) writer.WriteWholeNumber(42835, UnderlyingDividendCompoundingMethod.Value);
			if (UnderlyingDividendNumOfIndexUnits is not null) writer.WriteWholeNumber(42836, UnderlyingDividendNumOfIndexUnits.Value);
			if (UnderlyingDividendCashPercentage is not null) writer.WriteNumber(42837, UnderlyingDividendCashPercentage.Value);
			if (UnderlyingDividendCashEquivalentPercentage is not null) writer.WriteNumber(42838, UnderlyingDividendCashEquivalentPercentage.Value);
			if (UnderlyingNonCashDividendTreatment is not null) writer.WriteWholeNumber(42839, UnderlyingNonCashDividendTreatment.Value);
			if (UnderlyingDividendComposition is not null) writer.WriteWholeNumber(42840, UnderlyingDividendComposition.Value);
			if (UnderlyingSpecialDividendsIndicator is not null) writer.WriteBoolean(42841, UnderlyingSpecialDividendsIndicator.Value);
			if (UnderlyingMaterialDividendsIndicator is not null) writer.WriteBoolean(42842, UnderlyingMaterialDividendsIndicator.Value);
			if (UnderlyingOptionsExchangeDividendsIndicator is not null) writer.WriteBoolean(42843, UnderlyingOptionsExchangeDividendsIndicator.Value);
			if (UnderlyingAdditionalDividendsIndicator is not null) writer.WriteBoolean(42844, UnderlyingAdditionalDividendsIndicator.Value);
			if (UnderlyingAllDividendsIndicator is not null) writer.WriteBoolean(42845, UnderlyingAllDividendsIndicator.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingDividendReinvestmentIndicator = view.GetBool(42826);
			UnderlyingDividendEntitlementEvent = view.GetInt32(42827);
			UnderlyingDividendAmountType = view.GetInt32(42828);
			UnderlyingDividendUnderlierRefID = view.GetString(42829);
			if (view.GetView("UnderlyingDividendPeriodGrp") is IMessageView viewUnderlyingDividendPeriodGrp)
			{
				UnderlyingDividendPeriodGrp = new();
				((IFixParser)UnderlyingDividendPeriodGrp).Parse(viewUnderlyingDividendPeriodGrp);
			}
			UnderlyingExtraordinaryDividendPartySide = view.GetInt32(42830);
			UnderlyingExtraordinaryDividendAmountType = view.GetInt32(42831);
			UnderlyingExtraordinaryDividendCurrency = view.GetString(42832);
			UnderlyingExtraordinaryDividendDeterminationMethod = view.GetString(42833);
			if (view.GetView("UnderlyingDividendFXTriggerDate") is IMessageView viewUnderlyingDividendFXTriggerDate)
			{
				UnderlyingDividendFXTriggerDate = new();
				((IFixParser)UnderlyingDividendFXTriggerDate).Parse(viewUnderlyingDividendFXTriggerDate);
			}
			if (view.GetView("UnderlyingDividendAccrualFloatingRate") is IMessageView viewUnderlyingDividendAccrualFloatingRate)
			{
				UnderlyingDividendAccrualFloatingRate = new();
				((IFixParser)UnderlyingDividendAccrualFloatingRate).Parse(viewUnderlyingDividendAccrualFloatingRate);
			}
			UnderlyingDividendAccrualFixedRate = view.GetDouble(42834);
			if (view.GetView("UnderlyingDividendAccrualPaymentDate") is IMessageView viewUnderlyingDividendAccrualPaymentDate)
			{
				UnderlyingDividendAccrualPaymentDate = new();
				((IFixParser)UnderlyingDividendAccrualPaymentDate).Parse(viewUnderlyingDividendAccrualPaymentDate);
			}
			UnderlyingDividendCompoundingMethod = view.GetInt32(42835);
			UnderlyingDividendNumOfIndexUnits = view.GetInt32(42836);
			UnderlyingDividendCashPercentage = view.GetDouble(42837);
			UnderlyingDividendCashEquivalentPercentage = view.GetDouble(42838);
			UnderlyingNonCashDividendTreatment = view.GetInt32(42839);
			UnderlyingDividendComposition = view.GetInt32(42840);
			UnderlyingSpecialDividendsIndicator = view.GetBool(42841);
			UnderlyingMaterialDividendsIndicator = view.GetBool(42842);
			UnderlyingOptionsExchangeDividendsIndicator = view.GetBool(42843);
			UnderlyingAdditionalDividendsIndicator = view.GetBool(42844);
			UnderlyingAllDividendsIndicator = view.GetBool(42845);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingDividendReinvestmentIndicator":
				{
					value = UnderlyingDividendReinvestmentIndicator;
					break;
				}
				case "UnderlyingDividendEntitlementEvent":
				{
					value = UnderlyingDividendEntitlementEvent;
					break;
				}
				case "UnderlyingDividendAmountType":
				{
					value = UnderlyingDividendAmountType;
					break;
				}
				case "UnderlyingDividendUnderlierRefID":
				{
					value = UnderlyingDividendUnderlierRefID;
					break;
				}
				case "UnderlyingDividendPeriodGrp":
				{
					value = UnderlyingDividendPeriodGrp;
					break;
				}
				case "UnderlyingExtraordinaryDividendPartySide":
				{
					value = UnderlyingExtraordinaryDividendPartySide;
					break;
				}
				case "UnderlyingExtraordinaryDividendAmountType":
				{
					value = UnderlyingExtraordinaryDividendAmountType;
					break;
				}
				case "UnderlyingExtraordinaryDividendCurrency":
				{
					value = UnderlyingExtraordinaryDividendCurrency;
					break;
				}
				case "UnderlyingExtraordinaryDividendDeterminationMethod":
				{
					value = UnderlyingExtraordinaryDividendDeterminationMethod;
					break;
				}
				case "UnderlyingDividendFXTriggerDate":
				{
					value = UnderlyingDividendFXTriggerDate;
					break;
				}
				case "UnderlyingDividendAccrualFloatingRate":
				{
					value = UnderlyingDividendAccrualFloatingRate;
					break;
				}
				case "UnderlyingDividendAccrualFixedRate":
				{
					value = UnderlyingDividendAccrualFixedRate;
					break;
				}
				case "UnderlyingDividendAccrualPaymentDate":
				{
					value = UnderlyingDividendAccrualPaymentDate;
					break;
				}
				case "UnderlyingDividendCompoundingMethod":
				{
					value = UnderlyingDividendCompoundingMethod;
					break;
				}
				case "UnderlyingDividendNumOfIndexUnits":
				{
					value = UnderlyingDividendNumOfIndexUnits;
					break;
				}
				case "UnderlyingDividendCashPercentage":
				{
					value = UnderlyingDividendCashPercentage;
					break;
				}
				case "UnderlyingDividendCashEquivalentPercentage":
				{
					value = UnderlyingDividendCashEquivalentPercentage;
					break;
				}
				case "UnderlyingNonCashDividendTreatment":
				{
					value = UnderlyingNonCashDividendTreatment;
					break;
				}
				case "UnderlyingDividendComposition":
				{
					value = UnderlyingDividendComposition;
					break;
				}
				case "UnderlyingSpecialDividendsIndicator":
				{
					value = UnderlyingSpecialDividendsIndicator;
					break;
				}
				case "UnderlyingMaterialDividendsIndicator":
				{
					value = UnderlyingMaterialDividendsIndicator;
					break;
				}
				case "UnderlyingOptionsExchangeDividendsIndicator":
				{
					value = UnderlyingOptionsExchangeDividendsIndicator;
					break;
				}
				case "UnderlyingAdditionalDividendsIndicator":
				{
					value = UnderlyingAdditionalDividendsIndicator;
					break;
				}
				case "UnderlyingAllDividendsIndicator":
				{
					value = UnderlyingAllDividendsIndicator;
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
			UnderlyingDividendReinvestmentIndicator = null;
			UnderlyingDividendEntitlementEvent = null;
			UnderlyingDividendAmountType = null;
			UnderlyingDividendUnderlierRefID = null;
			((IFixReset?)UnderlyingDividendPeriodGrp)?.Reset();
			UnderlyingExtraordinaryDividendPartySide = null;
			UnderlyingExtraordinaryDividendAmountType = null;
			UnderlyingExtraordinaryDividendCurrency = null;
			UnderlyingExtraordinaryDividendDeterminationMethod = null;
			((IFixReset?)UnderlyingDividendFXTriggerDate)?.Reset();
			((IFixReset?)UnderlyingDividendAccrualFloatingRate)?.Reset();
			UnderlyingDividendAccrualFixedRate = null;
			((IFixReset?)UnderlyingDividendAccrualPaymentDate)?.Reset();
			UnderlyingDividendCompoundingMethod = null;
			UnderlyingDividendNumOfIndexUnits = null;
			UnderlyingDividendCashPercentage = null;
			UnderlyingDividendCashEquivalentPercentage = null;
			UnderlyingNonCashDividendTreatment = null;
			UnderlyingDividendComposition = null;
			UnderlyingSpecialDividendsIndicator = null;
			UnderlyingMaterialDividendsIndicator = null;
			UnderlyingOptionsExchangeDividendsIndicator = null;
			UnderlyingAdditionalDividendsIndicator = null;
			UnderlyingAllDividendsIndicator = null;
		}
	}
}
