using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class DividendConditions : IFixComponent
	{
		[TagDetails(Tag = 42245, Type = TagType.Boolean, Offset = 0, Required = false)]
		public bool? DividendReinvestmentIndicator {get; set;}
		
		[TagDetails(Tag = 42246, Type = TagType.Int, Offset = 1, Required = false)]
		public int? DividendEntitlementEvent {get; set;}
		
		[TagDetails(Tag = 42247, Type = TagType.Int, Offset = 2, Required = false)]
		public int? DividendAmountType {get; set;}
		
		[TagDetails(Tag = 42248, Type = TagType.String, Offset = 3, Required = false)]
		public string? DividendUnderlierRefID {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public DividendPeriodGrp? DividendPeriodGrp {get; set;}
		
		[TagDetails(Tag = 42249, Type = TagType.Int, Offset = 5, Required = false)]
		public int? ExtraordinaryDividendPartySide {get; set;}
		
		[TagDetails(Tag = 42250, Type = TagType.Int, Offset = 6, Required = false)]
		public int? ExtraordinaryDividendAmountType {get; set;}
		
		[TagDetails(Tag = 42251, Type = TagType.String, Offset = 7, Required = false)]
		public string? ExtraordinaryDividendCurrency {get; set;}
		
		[TagDetails(Tag = 42252, Type = TagType.String, Offset = 8, Required = false)]
		public string? ExtraordinaryDividendDeterminationMethod {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public DividendFXTriggerDate? DividendFXTriggerDate {get; set;}
		
		[Component(Offset = 10, Required = false)]
		public DividendAccrualFloatingRate? DividendAccrualFloatingRate {get; set;}
		
		[TagDetails(Tag = 42253, Type = TagType.Float, Offset = 11, Required = false)]
		public double? DividendAccrualFixedRate {get; set;}
		
		[Component(Offset = 12, Required = false)]
		public DividendAccrualPaymentDate? DividendAccrualPaymentDate {get; set;}
		
		[TagDetails(Tag = 42254, Type = TagType.Int, Offset = 13, Required = false)]
		public int? DividendCompoundingMethod {get; set;}
		
		[TagDetails(Tag = 42255, Type = TagType.Int, Offset = 14, Required = false)]
		public int? DividendNumOfIndexUnits {get; set;}
		
		[TagDetails(Tag = 42256, Type = TagType.Float, Offset = 15, Required = false)]
		public double? DividendCashPercentage {get; set;}
		
		[TagDetails(Tag = 42257, Type = TagType.Float, Offset = 16, Required = false)]
		public double? DividendCashEquivalentPercentage {get; set;}
		
		[TagDetails(Tag = 42258, Type = TagType.Int, Offset = 17, Required = false)]
		public int? NonCashDividendTreatment {get; set;}
		
		[TagDetails(Tag = 42259, Type = TagType.Int, Offset = 18, Required = false)]
		public int? DividendComposition {get; set;}
		
		[TagDetails(Tag = 42260, Type = TagType.Boolean, Offset = 19, Required = false)]
		public bool? SpecialDividendsIndicator {get; set;}
		
		[TagDetails(Tag = 42261, Type = TagType.Boolean, Offset = 20, Required = false)]
		public bool? MaterialDividendsIndicator {get; set;}
		
		[TagDetails(Tag = 42262, Type = TagType.Boolean, Offset = 21, Required = false)]
		public bool? OptionsExchangeDividendsIndicator {get; set;}
		
		[TagDetails(Tag = 42263, Type = TagType.Boolean, Offset = 22, Required = false)]
		public bool? AdditionalDividendsIndicator {get; set;}
		
		[TagDetails(Tag = 42264, Type = TagType.Boolean, Offset = 23, Required = false)]
		public bool? AllDividendsIndicator {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (DividendReinvestmentIndicator is not null) writer.WriteBoolean(42245, DividendReinvestmentIndicator.Value);
			if (DividendEntitlementEvent is not null) writer.WriteWholeNumber(42246, DividendEntitlementEvent.Value);
			if (DividendAmountType is not null) writer.WriteWholeNumber(42247, DividendAmountType.Value);
			if (DividendUnderlierRefID is not null) writer.WriteString(42248, DividendUnderlierRefID);
			if (DividendPeriodGrp is not null) ((IFixEncoder)DividendPeriodGrp).Encode(writer);
			if (ExtraordinaryDividendPartySide is not null) writer.WriteWholeNumber(42249, ExtraordinaryDividendPartySide.Value);
			if (ExtraordinaryDividendAmountType is not null) writer.WriteWholeNumber(42250, ExtraordinaryDividendAmountType.Value);
			if (ExtraordinaryDividendCurrency is not null) writer.WriteString(42251, ExtraordinaryDividendCurrency);
			if (ExtraordinaryDividendDeterminationMethod is not null) writer.WriteString(42252, ExtraordinaryDividendDeterminationMethod);
			if (DividendFXTriggerDate is not null) ((IFixEncoder)DividendFXTriggerDate).Encode(writer);
			if (DividendAccrualFloatingRate is not null) ((IFixEncoder)DividendAccrualFloatingRate).Encode(writer);
			if (DividendAccrualFixedRate is not null) writer.WriteNumber(42253, DividendAccrualFixedRate.Value);
			if (DividendAccrualPaymentDate is not null) ((IFixEncoder)DividendAccrualPaymentDate).Encode(writer);
			if (DividendCompoundingMethod is not null) writer.WriteWholeNumber(42254, DividendCompoundingMethod.Value);
			if (DividendNumOfIndexUnits is not null) writer.WriteWholeNumber(42255, DividendNumOfIndexUnits.Value);
			if (DividendCashPercentage is not null) writer.WriteNumber(42256, DividendCashPercentage.Value);
			if (DividendCashEquivalentPercentage is not null) writer.WriteNumber(42257, DividendCashEquivalentPercentage.Value);
			if (NonCashDividendTreatment is not null) writer.WriteWholeNumber(42258, NonCashDividendTreatment.Value);
			if (DividendComposition is not null) writer.WriteWholeNumber(42259, DividendComposition.Value);
			if (SpecialDividendsIndicator is not null) writer.WriteBoolean(42260, SpecialDividendsIndicator.Value);
			if (MaterialDividendsIndicator is not null) writer.WriteBoolean(42261, MaterialDividendsIndicator.Value);
			if (OptionsExchangeDividendsIndicator is not null) writer.WriteBoolean(42262, OptionsExchangeDividendsIndicator.Value);
			if (AdditionalDividendsIndicator is not null) writer.WriteBoolean(42263, AdditionalDividendsIndicator.Value);
			if (AllDividendsIndicator is not null) writer.WriteBoolean(42264, AllDividendsIndicator.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			DividendReinvestmentIndicator = view.GetBool(42245);
			DividendEntitlementEvent = view.GetInt32(42246);
			DividendAmountType = view.GetInt32(42247);
			DividendUnderlierRefID = view.GetString(42248);
			if (view.GetView("DividendPeriodGrp") is IMessageView viewDividendPeriodGrp)
			{
				DividendPeriodGrp = new();
				((IFixParser)DividendPeriodGrp).Parse(viewDividendPeriodGrp);
			}
			ExtraordinaryDividendPartySide = view.GetInt32(42249);
			ExtraordinaryDividendAmountType = view.GetInt32(42250);
			ExtraordinaryDividendCurrency = view.GetString(42251);
			ExtraordinaryDividendDeterminationMethod = view.GetString(42252);
			if (view.GetView("DividendFXTriggerDate") is IMessageView viewDividendFXTriggerDate)
			{
				DividendFXTriggerDate = new();
				((IFixParser)DividendFXTriggerDate).Parse(viewDividendFXTriggerDate);
			}
			if (view.GetView("DividendAccrualFloatingRate") is IMessageView viewDividendAccrualFloatingRate)
			{
				DividendAccrualFloatingRate = new();
				((IFixParser)DividendAccrualFloatingRate).Parse(viewDividendAccrualFloatingRate);
			}
			DividendAccrualFixedRate = view.GetDouble(42253);
			if (view.GetView("DividendAccrualPaymentDate") is IMessageView viewDividendAccrualPaymentDate)
			{
				DividendAccrualPaymentDate = new();
				((IFixParser)DividendAccrualPaymentDate).Parse(viewDividendAccrualPaymentDate);
			}
			DividendCompoundingMethod = view.GetInt32(42254);
			DividendNumOfIndexUnits = view.GetInt32(42255);
			DividendCashPercentage = view.GetDouble(42256);
			DividendCashEquivalentPercentage = view.GetDouble(42257);
			NonCashDividendTreatment = view.GetInt32(42258);
			DividendComposition = view.GetInt32(42259);
			SpecialDividendsIndicator = view.GetBool(42260);
			MaterialDividendsIndicator = view.GetBool(42261);
			OptionsExchangeDividendsIndicator = view.GetBool(42262);
			AdditionalDividendsIndicator = view.GetBool(42263);
			AllDividendsIndicator = view.GetBool(42264);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "DividendReinvestmentIndicator":
				{
					value = DividendReinvestmentIndicator;
					break;
				}
				case "DividendEntitlementEvent":
				{
					value = DividendEntitlementEvent;
					break;
				}
				case "DividendAmountType":
				{
					value = DividendAmountType;
					break;
				}
				case "DividendUnderlierRefID":
				{
					value = DividendUnderlierRefID;
					break;
				}
				case "DividendPeriodGrp":
				{
					value = DividendPeriodGrp;
					break;
				}
				case "ExtraordinaryDividendPartySide":
				{
					value = ExtraordinaryDividendPartySide;
					break;
				}
				case "ExtraordinaryDividendAmountType":
				{
					value = ExtraordinaryDividendAmountType;
					break;
				}
				case "ExtraordinaryDividendCurrency":
				{
					value = ExtraordinaryDividendCurrency;
					break;
				}
				case "ExtraordinaryDividendDeterminationMethod":
				{
					value = ExtraordinaryDividendDeterminationMethod;
					break;
				}
				case "DividendFXTriggerDate":
				{
					value = DividendFXTriggerDate;
					break;
				}
				case "DividendAccrualFloatingRate":
				{
					value = DividendAccrualFloatingRate;
					break;
				}
				case "DividendAccrualFixedRate":
				{
					value = DividendAccrualFixedRate;
					break;
				}
				case "DividendAccrualPaymentDate":
				{
					value = DividendAccrualPaymentDate;
					break;
				}
				case "DividendCompoundingMethod":
				{
					value = DividendCompoundingMethod;
					break;
				}
				case "DividendNumOfIndexUnits":
				{
					value = DividendNumOfIndexUnits;
					break;
				}
				case "DividendCashPercentage":
				{
					value = DividendCashPercentage;
					break;
				}
				case "DividendCashEquivalentPercentage":
				{
					value = DividendCashEquivalentPercentage;
					break;
				}
				case "NonCashDividendTreatment":
				{
					value = NonCashDividendTreatment;
					break;
				}
				case "DividendComposition":
				{
					value = DividendComposition;
					break;
				}
				case "SpecialDividendsIndicator":
				{
					value = SpecialDividendsIndicator;
					break;
				}
				case "MaterialDividendsIndicator":
				{
					value = MaterialDividendsIndicator;
					break;
				}
				case "OptionsExchangeDividendsIndicator":
				{
					value = OptionsExchangeDividendsIndicator;
					break;
				}
				case "AdditionalDividendsIndicator":
				{
					value = AdditionalDividendsIndicator;
					break;
				}
				case "AllDividendsIndicator":
				{
					value = AllDividendsIndicator;
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
			DividendReinvestmentIndicator = null;
			DividendEntitlementEvent = null;
			DividendAmountType = null;
			DividendUnderlierRefID = null;
			((IFixReset?)DividendPeriodGrp)?.Reset();
			ExtraordinaryDividendPartySide = null;
			ExtraordinaryDividendAmountType = null;
			ExtraordinaryDividendCurrency = null;
			ExtraordinaryDividendDeterminationMethod = null;
			((IFixReset?)DividendFXTriggerDate)?.Reset();
			((IFixReset?)DividendAccrualFloatingRate)?.Reset();
			DividendAccrualFixedRate = null;
			((IFixReset?)DividendAccrualPaymentDate)?.Reset();
			DividendCompoundingMethod = null;
			DividendNumOfIndexUnits = null;
			DividendCashPercentage = null;
			DividendCashEquivalentPercentage = null;
			NonCashDividendTreatment = null;
			DividendComposition = null;
			SpecialDividendsIndicator = null;
			MaterialDividendsIndicator = null;
			OptionsExchangeDividendsIndicator = null;
			AdditionalDividendsIndicator = null;
			AllDividendsIndicator = null;
		}
	}
}
