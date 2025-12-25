using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ReturnRateGrp : IFixComponent
	{
		public sealed partial class NoReturnRates : IFixGroup
		{
			[TagDetails(Tag = 42736, Type = TagType.Int, Offset = 0, Required = false)]
			public int? ReturnRatePriceSequence {get; set;}
			
			[TagDetails(Tag = 42737, Type = TagType.String, Offset = 1, Required = false)]
			public string? ReturnRateCommissionBasis {get; set;}
			
			[TagDetails(Tag = 42738, Type = TagType.Float, Offset = 2, Required = false)]
			public double? ReturnRateCommissionAmount {get; set;}
			
			[TagDetails(Tag = 42739, Type = TagType.String, Offset = 3, Required = false)]
			public string? ReturnRateCommissionCurrency {get; set;}
			
			[TagDetails(Tag = 42740, Type = TagType.Float, Offset = 4, Required = false)]
			public double? ReturnRateTotalCommissionPerTrade {get; set;}
			
			[TagDetails(Tag = 42741, Type = TagType.String, Offset = 5, Required = false)]
			public string? ReturnRateDeterminationMethod {get; set;}
			
			[Component(Offset = 6, Required = false)]
			public ReturnRatePriceGrp? ReturnRatePriceGrp {get; set;}
			
			[Component(Offset = 7, Required = false)]
			public ReturnRateFXConversionGrp? ReturnRateFXConversionGrp {get; set;}
			
			[TagDetails(Tag = 42742, Type = TagType.Int, Offset = 8, Required = false)]
			public int? ReturnRateAmountRelativeTo {get; set;}
			
			[TagDetails(Tag = 42743, Type = TagType.String, Offset = 9, Required = false)]
			public string? ReturnRateQuoteMeasureType {get; set;}
			
			[TagDetails(Tag = 42744, Type = TagType.String, Offset = 10, Required = false)]
			public string? ReturnRateQuoteUnits {get; set;}
			
			[TagDetails(Tag = 42745, Type = TagType.Int, Offset = 11, Required = false)]
			public int? ReturnRateQuoteMethod {get; set;}
			
			[TagDetails(Tag = 42746, Type = TagType.String, Offset = 12, Required = false)]
			public string? ReturnRateQuoteCurrency {get; set;}
			
			[TagDetails(Tag = 42747, Type = TagType.String, Offset = 13, Required = false)]
			public string? ReturnRateQuoteCurrencyType {get; set;}
			
			[TagDetails(Tag = 42748, Type = TagType.Int, Offset = 14, Required = false)]
			public int? ReturnRateQuoteTimeType {get; set;}
			
			[TagDetails(Tag = 42749, Type = TagType.String, Offset = 15, Required = false)]
			public string? ReturnRateQuoteTime {get; set;}
			
			[TagDetails(Tag = 42750, Type = TagType.LocalDate, Offset = 16, Required = false)]
			public DateOnly? ReturnRateQuoteDate {get; set;}
			
			[TagDetails(Tag = 42751, Type = TagType.String, Offset = 17, Required = false)]
			public string? ReturnRateQuoteExpirationTime {get; set;}
			
			[TagDetails(Tag = 42752, Type = TagType.String, Offset = 18, Required = false)]
			public string? ReturnRateQuoteBusinessCenter {get; set;}
			
			[TagDetails(Tag = 42753, Type = TagType.String, Offset = 19, Required = false)]
			public string? ReturnRateQuoteExchange {get; set;}
			
			[Component(Offset = 20, Required = false)]
			public ReturnRateInformationSourceGrp? ReturnRateInformationSourceGrp {get; set;}
			
			[TagDetails(Tag = 42754, Type = TagType.String, Offset = 21, Required = false)]
			public string? ReturnRateQuotePricingModel {get; set;}
			
			[TagDetails(Tag = 42755, Type = TagType.String, Offset = 22, Required = false)]
			public string? ReturnRateCashFlowType {get; set;}
			
			[Component(Offset = 23, Required = false)]
			public ReturnRateDateGrp? ReturnRateDateGrp {get; set;}
			
			[TagDetails(Tag = 42756, Type = TagType.Int, Offset = 24, Required = false)]
			public int? ReturnRateValuationTimeType {get; set;}
			
			[TagDetails(Tag = 42757, Type = TagType.String, Offset = 25, Required = false)]
			public string? ReturnRateValuationTime {get; set;}
			
			[TagDetails(Tag = 42758, Type = TagType.String, Offset = 26, Required = false)]
			public string? ReturnRateValuationTimeBusinessCenter {get; set;}
			
			[TagDetails(Tag = 42759, Type = TagType.Int, Offset = 27, Required = false)]
			public int? ReturnRateValuationPriceOption {get; set;}
			
			[TagDetails(Tag = 42760, Type = TagType.Int, Offset = 28, Required = false)]
			public int? ReturnRateFinalPriceFallback {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ReturnRatePriceSequence is not null) writer.WriteWholeNumber(42736, ReturnRatePriceSequence.Value);
				if (ReturnRateCommissionBasis is not null) writer.WriteString(42737, ReturnRateCommissionBasis);
				if (ReturnRateCommissionAmount is not null) writer.WriteNumber(42738, ReturnRateCommissionAmount.Value);
				if (ReturnRateCommissionCurrency is not null) writer.WriteString(42739, ReturnRateCommissionCurrency);
				if (ReturnRateTotalCommissionPerTrade is not null) writer.WriteNumber(42740, ReturnRateTotalCommissionPerTrade.Value);
				if (ReturnRateDeterminationMethod is not null) writer.WriteString(42741, ReturnRateDeterminationMethod);
				if (ReturnRatePriceGrp is not null) ((IFixEncoder)ReturnRatePriceGrp).Encode(writer);
				if (ReturnRateFXConversionGrp is not null) ((IFixEncoder)ReturnRateFXConversionGrp).Encode(writer);
				if (ReturnRateAmountRelativeTo is not null) writer.WriteWholeNumber(42742, ReturnRateAmountRelativeTo.Value);
				if (ReturnRateQuoteMeasureType is not null) writer.WriteString(42743, ReturnRateQuoteMeasureType);
				if (ReturnRateQuoteUnits is not null) writer.WriteString(42744, ReturnRateQuoteUnits);
				if (ReturnRateQuoteMethod is not null) writer.WriteWholeNumber(42745, ReturnRateQuoteMethod.Value);
				if (ReturnRateQuoteCurrency is not null) writer.WriteString(42746, ReturnRateQuoteCurrency);
				if (ReturnRateQuoteCurrencyType is not null) writer.WriteString(42747, ReturnRateQuoteCurrencyType);
				if (ReturnRateQuoteTimeType is not null) writer.WriteWholeNumber(42748, ReturnRateQuoteTimeType.Value);
				if (ReturnRateQuoteTime is not null) writer.WriteString(42749, ReturnRateQuoteTime);
				if (ReturnRateQuoteDate is not null) writer.WriteLocalDateOnly(42750, ReturnRateQuoteDate.Value);
				if (ReturnRateQuoteExpirationTime is not null) writer.WriteString(42751, ReturnRateQuoteExpirationTime);
				if (ReturnRateQuoteBusinessCenter is not null) writer.WriteString(42752, ReturnRateQuoteBusinessCenter);
				if (ReturnRateQuoteExchange is not null) writer.WriteString(42753, ReturnRateQuoteExchange);
				if (ReturnRateInformationSourceGrp is not null) ((IFixEncoder)ReturnRateInformationSourceGrp).Encode(writer);
				if (ReturnRateQuotePricingModel is not null) writer.WriteString(42754, ReturnRateQuotePricingModel);
				if (ReturnRateCashFlowType is not null) writer.WriteString(42755, ReturnRateCashFlowType);
				if (ReturnRateDateGrp is not null) ((IFixEncoder)ReturnRateDateGrp).Encode(writer);
				if (ReturnRateValuationTimeType is not null) writer.WriteWholeNumber(42756, ReturnRateValuationTimeType.Value);
				if (ReturnRateValuationTime is not null) writer.WriteString(42757, ReturnRateValuationTime);
				if (ReturnRateValuationTimeBusinessCenter is not null) writer.WriteString(42758, ReturnRateValuationTimeBusinessCenter);
				if (ReturnRateValuationPriceOption is not null) writer.WriteWholeNumber(42759, ReturnRateValuationPriceOption.Value);
				if (ReturnRateFinalPriceFallback is not null) writer.WriteWholeNumber(42760, ReturnRateFinalPriceFallback.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ReturnRatePriceSequence = view.GetInt32(42736);
				ReturnRateCommissionBasis = view.GetString(42737);
				ReturnRateCommissionAmount = view.GetDouble(42738);
				ReturnRateCommissionCurrency = view.GetString(42739);
				ReturnRateTotalCommissionPerTrade = view.GetDouble(42740);
				ReturnRateDeterminationMethod = view.GetString(42741);
				if (view.GetView("ReturnRatePriceGrp") is IMessageView viewReturnRatePriceGrp)
				{
					ReturnRatePriceGrp = new();
					((IFixParser)ReturnRatePriceGrp).Parse(viewReturnRatePriceGrp);
				}
				if (view.GetView("ReturnRateFXConversionGrp") is IMessageView viewReturnRateFXConversionGrp)
				{
					ReturnRateFXConversionGrp = new();
					((IFixParser)ReturnRateFXConversionGrp).Parse(viewReturnRateFXConversionGrp);
				}
				ReturnRateAmountRelativeTo = view.GetInt32(42742);
				ReturnRateQuoteMeasureType = view.GetString(42743);
				ReturnRateQuoteUnits = view.GetString(42744);
				ReturnRateQuoteMethod = view.GetInt32(42745);
				ReturnRateQuoteCurrency = view.GetString(42746);
				ReturnRateQuoteCurrencyType = view.GetString(42747);
				ReturnRateQuoteTimeType = view.GetInt32(42748);
				ReturnRateQuoteTime = view.GetString(42749);
				ReturnRateQuoteDate = view.GetDateOnly(42750);
				ReturnRateQuoteExpirationTime = view.GetString(42751);
				ReturnRateQuoteBusinessCenter = view.GetString(42752);
				ReturnRateQuoteExchange = view.GetString(42753);
				if (view.GetView("ReturnRateInformationSourceGrp") is IMessageView viewReturnRateInformationSourceGrp)
				{
					ReturnRateInformationSourceGrp = new();
					((IFixParser)ReturnRateInformationSourceGrp).Parse(viewReturnRateInformationSourceGrp);
				}
				ReturnRateQuotePricingModel = view.GetString(42754);
				ReturnRateCashFlowType = view.GetString(42755);
				if (view.GetView("ReturnRateDateGrp") is IMessageView viewReturnRateDateGrp)
				{
					ReturnRateDateGrp = new();
					((IFixParser)ReturnRateDateGrp).Parse(viewReturnRateDateGrp);
				}
				ReturnRateValuationTimeType = view.GetInt32(42756);
				ReturnRateValuationTime = view.GetString(42757);
				ReturnRateValuationTimeBusinessCenter = view.GetString(42758);
				ReturnRateValuationPriceOption = view.GetInt32(42759);
				ReturnRateFinalPriceFallback = view.GetInt32(42760);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ReturnRatePriceSequence":
					{
						value = ReturnRatePriceSequence;
						break;
					}
					case "ReturnRateCommissionBasis":
					{
						value = ReturnRateCommissionBasis;
						break;
					}
					case "ReturnRateCommissionAmount":
					{
						value = ReturnRateCommissionAmount;
						break;
					}
					case "ReturnRateCommissionCurrency":
					{
						value = ReturnRateCommissionCurrency;
						break;
					}
					case "ReturnRateTotalCommissionPerTrade":
					{
						value = ReturnRateTotalCommissionPerTrade;
						break;
					}
					case "ReturnRateDeterminationMethod":
					{
						value = ReturnRateDeterminationMethod;
						break;
					}
					case "ReturnRatePriceGrp":
					{
						value = ReturnRatePriceGrp;
						break;
					}
					case "ReturnRateFXConversionGrp":
					{
						value = ReturnRateFXConversionGrp;
						break;
					}
					case "ReturnRateAmountRelativeTo":
					{
						value = ReturnRateAmountRelativeTo;
						break;
					}
					case "ReturnRateQuoteMeasureType":
					{
						value = ReturnRateQuoteMeasureType;
						break;
					}
					case "ReturnRateQuoteUnits":
					{
						value = ReturnRateQuoteUnits;
						break;
					}
					case "ReturnRateQuoteMethod":
					{
						value = ReturnRateQuoteMethod;
						break;
					}
					case "ReturnRateQuoteCurrency":
					{
						value = ReturnRateQuoteCurrency;
						break;
					}
					case "ReturnRateQuoteCurrencyType":
					{
						value = ReturnRateQuoteCurrencyType;
						break;
					}
					case "ReturnRateQuoteTimeType":
					{
						value = ReturnRateQuoteTimeType;
						break;
					}
					case "ReturnRateQuoteTime":
					{
						value = ReturnRateQuoteTime;
						break;
					}
					case "ReturnRateQuoteDate":
					{
						value = ReturnRateQuoteDate;
						break;
					}
					case "ReturnRateQuoteExpirationTime":
					{
						value = ReturnRateQuoteExpirationTime;
						break;
					}
					case "ReturnRateQuoteBusinessCenter":
					{
						value = ReturnRateQuoteBusinessCenter;
						break;
					}
					case "ReturnRateQuoteExchange":
					{
						value = ReturnRateQuoteExchange;
						break;
					}
					case "ReturnRateInformationSourceGrp":
					{
						value = ReturnRateInformationSourceGrp;
						break;
					}
					case "ReturnRateQuotePricingModel":
					{
						value = ReturnRateQuotePricingModel;
						break;
					}
					case "ReturnRateCashFlowType":
					{
						value = ReturnRateCashFlowType;
						break;
					}
					case "ReturnRateDateGrp":
					{
						value = ReturnRateDateGrp;
						break;
					}
					case "ReturnRateValuationTimeType":
					{
						value = ReturnRateValuationTimeType;
						break;
					}
					case "ReturnRateValuationTime":
					{
						value = ReturnRateValuationTime;
						break;
					}
					case "ReturnRateValuationTimeBusinessCenter":
					{
						value = ReturnRateValuationTimeBusinessCenter;
						break;
					}
					case "ReturnRateValuationPriceOption":
					{
						value = ReturnRateValuationPriceOption;
						break;
					}
					case "ReturnRateFinalPriceFallback":
					{
						value = ReturnRateFinalPriceFallback;
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
				ReturnRatePriceSequence = null;
				ReturnRateCommissionBasis = null;
				ReturnRateCommissionAmount = null;
				ReturnRateCommissionCurrency = null;
				ReturnRateTotalCommissionPerTrade = null;
				ReturnRateDeterminationMethod = null;
				((IFixReset?)ReturnRatePriceGrp)?.Reset();
				((IFixReset?)ReturnRateFXConversionGrp)?.Reset();
				ReturnRateAmountRelativeTo = null;
				ReturnRateQuoteMeasureType = null;
				ReturnRateQuoteUnits = null;
				ReturnRateQuoteMethod = null;
				ReturnRateQuoteCurrency = null;
				ReturnRateQuoteCurrencyType = null;
				ReturnRateQuoteTimeType = null;
				ReturnRateQuoteTime = null;
				ReturnRateQuoteDate = null;
				ReturnRateQuoteExpirationTime = null;
				ReturnRateQuoteBusinessCenter = null;
				ReturnRateQuoteExchange = null;
				((IFixReset?)ReturnRateInformationSourceGrp)?.Reset();
				ReturnRateQuotePricingModel = null;
				ReturnRateCashFlowType = null;
				((IFixReset?)ReturnRateDateGrp)?.Reset();
				ReturnRateValuationTimeType = null;
				ReturnRateValuationTime = null;
				ReturnRateValuationTimeBusinessCenter = null;
				ReturnRateValuationPriceOption = null;
				ReturnRateFinalPriceFallback = null;
			}
		}
		[Group(NoOfTag = 42735, Offset = 0, Required = false)]
		public NoReturnRates[]? ReturnRates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ReturnRates is not null && ReturnRates.Length != 0)
			{
				writer.WriteWholeNumber(42735, ReturnRates.Length);
				for (int i = 0; i < ReturnRates.Length; i++)
				{
					((IFixEncoder)ReturnRates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoReturnRates") is IMessageView viewNoReturnRates)
			{
				var count = viewNoReturnRates.GroupCount();
				ReturnRates = new NoReturnRates[count];
				for (int i = 0; i < count; i++)
				{
					ReturnRates[i] = new();
					((IFixParser)ReturnRates[i]).Parse(viewNoReturnRates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoReturnRates":
				{
					value = ReturnRates;
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
			ReturnRates = null;
		}
	}
}
