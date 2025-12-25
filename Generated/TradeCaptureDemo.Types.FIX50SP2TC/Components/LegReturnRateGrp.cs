using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegReturnRateGrp : IFixComponent
	{
		public sealed partial class NoLegReturnRates : IFixGroup
		{
			[TagDetails(Tag = 42535, Type = TagType.Int, Offset = 0, Required = false)]
			public int? LegReturnRatePriceSequence {get; set;}
			
			[TagDetails(Tag = 42536, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegReturnRateCommissionBasis {get; set;}
			
			[TagDetails(Tag = 42537, Type = TagType.Float, Offset = 2, Required = false)]
			public double? LegReturnRateCommissionAmount {get; set;}
			
			[TagDetails(Tag = 42538, Type = TagType.String, Offset = 3, Required = false)]
			public string? LegReturnRateCommissionCurrency {get; set;}
			
			[TagDetails(Tag = 42539, Type = TagType.Float, Offset = 4, Required = false)]
			public double? LegReturnRateTotalCommissionPerTrade {get; set;}
			
			[TagDetails(Tag = 42540, Type = TagType.String, Offset = 5, Required = false)]
			public string? LegReturnRateDeterminationMethod {get; set;}
			
			[Component(Offset = 6, Required = false)]
			public LegReturnRatePriceGrp? LegReturnRatePriceGrp {get; set;}
			
			[Component(Offset = 7, Required = false)]
			public LegReturnRateFXConversionGrp? LegReturnRateFXConversionGrp {get; set;}
			
			[TagDetails(Tag = 42541, Type = TagType.Int, Offset = 8, Required = false)]
			public int? LegReturnRateAmountRelativeTo {get; set;}
			
			[TagDetails(Tag = 42542, Type = TagType.String, Offset = 9, Required = false)]
			public string? LegReturnRateQuoteMeasureType {get; set;}
			
			[TagDetails(Tag = 42543, Type = TagType.String, Offset = 10, Required = false)]
			public string? LegReturnRateQuoteUnits {get; set;}
			
			[TagDetails(Tag = 42544, Type = TagType.Int, Offset = 11, Required = false)]
			public int? LegReturnRateQuoteMethod {get; set;}
			
			[TagDetails(Tag = 42545, Type = TagType.String, Offset = 12, Required = false)]
			public string? LegReturnRateQuoteCurrency {get; set;}
			
			[TagDetails(Tag = 42546, Type = TagType.String, Offset = 13, Required = false)]
			public string? LegReturnRateQuoteCurrencyType {get; set;}
			
			[TagDetails(Tag = 42547, Type = TagType.Int, Offset = 14, Required = false)]
			public int? LegReturnRateQuoteTimeType {get; set;}
			
			[TagDetails(Tag = 42548, Type = TagType.String, Offset = 15, Required = false)]
			public string? LegReturnRateQuoteTime {get; set;}
			
			[TagDetails(Tag = 42549, Type = TagType.LocalDate, Offset = 16, Required = false)]
			public DateOnly? LegReturnRateQuoteDate {get; set;}
			
			[TagDetails(Tag = 42550, Type = TagType.String, Offset = 17, Required = false)]
			public string? LegReturnRateQuoteExpirationTime {get; set;}
			
			[TagDetails(Tag = 42551, Type = TagType.String, Offset = 18, Required = false)]
			public string? LegReturnRateQuoteBusinessCenter {get; set;}
			
			[TagDetails(Tag = 42552, Type = TagType.String, Offset = 19, Required = false)]
			public string? LegReturnRateQuoteExchange {get; set;}
			
			[Component(Offset = 20, Required = false)]
			public LegReturnRateInformationSourceGrp? LegReturnRateInformationSourceGrp {get; set;}
			
			[TagDetails(Tag = 42553, Type = TagType.String, Offset = 21, Required = false)]
			public string? LegReturnRateQuotePricingModel {get; set;}
			
			[TagDetails(Tag = 42554, Type = TagType.String, Offset = 22, Required = false)]
			public string? LegReturnRateCashFlowType {get; set;}
			
			[Component(Offset = 23, Required = false)]
			public LegReturnRateDateGrp? LegReturnRateDateGrp {get; set;}
			
			[TagDetails(Tag = 42555, Type = TagType.Int, Offset = 24, Required = false)]
			public int? LegReturnRateValuationTimeType {get; set;}
			
			[TagDetails(Tag = 42556, Type = TagType.String, Offset = 25, Required = false)]
			public string? LegReturnRateValuationTime {get; set;}
			
			[TagDetails(Tag = 42557, Type = TagType.String, Offset = 26, Required = false)]
			public string? LegReturnRateValuationTimeBusinessCenter {get; set;}
			
			[TagDetails(Tag = 42558, Type = TagType.Int, Offset = 27, Required = false)]
			public int? LegReturnRateValuationPriceOption {get; set;}
			
			[TagDetails(Tag = 42559, Type = TagType.Int, Offset = 28, Required = false)]
			public int? LegReturnRateFinalPriceFallback {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegReturnRatePriceSequence is not null) writer.WriteWholeNumber(42535, LegReturnRatePriceSequence.Value);
				if (LegReturnRateCommissionBasis is not null) writer.WriteString(42536, LegReturnRateCommissionBasis);
				if (LegReturnRateCommissionAmount is not null) writer.WriteNumber(42537, LegReturnRateCommissionAmount.Value);
				if (LegReturnRateCommissionCurrency is not null) writer.WriteString(42538, LegReturnRateCommissionCurrency);
				if (LegReturnRateTotalCommissionPerTrade is not null) writer.WriteNumber(42539, LegReturnRateTotalCommissionPerTrade.Value);
				if (LegReturnRateDeterminationMethod is not null) writer.WriteString(42540, LegReturnRateDeterminationMethod);
				if (LegReturnRatePriceGrp is not null) ((IFixEncoder)LegReturnRatePriceGrp).Encode(writer);
				if (LegReturnRateFXConversionGrp is not null) ((IFixEncoder)LegReturnRateFXConversionGrp).Encode(writer);
				if (LegReturnRateAmountRelativeTo is not null) writer.WriteWholeNumber(42541, LegReturnRateAmountRelativeTo.Value);
				if (LegReturnRateQuoteMeasureType is not null) writer.WriteString(42542, LegReturnRateQuoteMeasureType);
				if (LegReturnRateQuoteUnits is not null) writer.WriteString(42543, LegReturnRateQuoteUnits);
				if (LegReturnRateQuoteMethod is not null) writer.WriteWholeNumber(42544, LegReturnRateQuoteMethod.Value);
				if (LegReturnRateQuoteCurrency is not null) writer.WriteString(42545, LegReturnRateQuoteCurrency);
				if (LegReturnRateQuoteCurrencyType is not null) writer.WriteString(42546, LegReturnRateQuoteCurrencyType);
				if (LegReturnRateQuoteTimeType is not null) writer.WriteWholeNumber(42547, LegReturnRateQuoteTimeType.Value);
				if (LegReturnRateQuoteTime is not null) writer.WriteString(42548, LegReturnRateQuoteTime);
				if (LegReturnRateQuoteDate is not null) writer.WriteLocalDateOnly(42549, LegReturnRateQuoteDate.Value);
				if (LegReturnRateQuoteExpirationTime is not null) writer.WriteString(42550, LegReturnRateQuoteExpirationTime);
				if (LegReturnRateQuoteBusinessCenter is not null) writer.WriteString(42551, LegReturnRateQuoteBusinessCenter);
				if (LegReturnRateQuoteExchange is not null) writer.WriteString(42552, LegReturnRateQuoteExchange);
				if (LegReturnRateInformationSourceGrp is not null) ((IFixEncoder)LegReturnRateInformationSourceGrp).Encode(writer);
				if (LegReturnRateQuotePricingModel is not null) writer.WriteString(42553, LegReturnRateQuotePricingModel);
				if (LegReturnRateCashFlowType is not null) writer.WriteString(42554, LegReturnRateCashFlowType);
				if (LegReturnRateDateGrp is not null) ((IFixEncoder)LegReturnRateDateGrp).Encode(writer);
				if (LegReturnRateValuationTimeType is not null) writer.WriteWholeNumber(42555, LegReturnRateValuationTimeType.Value);
				if (LegReturnRateValuationTime is not null) writer.WriteString(42556, LegReturnRateValuationTime);
				if (LegReturnRateValuationTimeBusinessCenter is not null) writer.WriteString(42557, LegReturnRateValuationTimeBusinessCenter);
				if (LegReturnRateValuationPriceOption is not null) writer.WriteWholeNumber(42558, LegReturnRateValuationPriceOption.Value);
				if (LegReturnRateFinalPriceFallback is not null) writer.WriteWholeNumber(42559, LegReturnRateFinalPriceFallback.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegReturnRatePriceSequence = view.GetInt32(42535);
				LegReturnRateCommissionBasis = view.GetString(42536);
				LegReturnRateCommissionAmount = view.GetDouble(42537);
				LegReturnRateCommissionCurrency = view.GetString(42538);
				LegReturnRateTotalCommissionPerTrade = view.GetDouble(42539);
				LegReturnRateDeterminationMethod = view.GetString(42540);
				if (view.GetView("LegReturnRatePriceGrp") is IMessageView viewLegReturnRatePriceGrp)
				{
					LegReturnRatePriceGrp = new();
					((IFixParser)LegReturnRatePriceGrp).Parse(viewLegReturnRatePriceGrp);
				}
				if (view.GetView("LegReturnRateFXConversionGrp") is IMessageView viewLegReturnRateFXConversionGrp)
				{
					LegReturnRateFXConversionGrp = new();
					((IFixParser)LegReturnRateFXConversionGrp).Parse(viewLegReturnRateFXConversionGrp);
				}
				LegReturnRateAmountRelativeTo = view.GetInt32(42541);
				LegReturnRateQuoteMeasureType = view.GetString(42542);
				LegReturnRateQuoteUnits = view.GetString(42543);
				LegReturnRateQuoteMethod = view.GetInt32(42544);
				LegReturnRateQuoteCurrency = view.GetString(42545);
				LegReturnRateQuoteCurrencyType = view.GetString(42546);
				LegReturnRateQuoteTimeType = view.GetInt32(42547);
				LegReturnRateQuoteTime = view.GetString(42548);
				LegReturnRateQuoteDate = view.GetDateOnly(42549);
				LegReturnRateQuoteExpirationTime = view.GetString(42550);
				LegReturnRateQuoteBusinessCenter = view.GetString(42551);
				LegReturnRateQuoteExchange = view.GetString(42552);
				if (view.GetView("LegReturnRateInformationSourceGrp") is IMessageView viewLegReturnRateInformationSourceGrp)
				{
					LegReturnRateInformationSourceGrp = new();
					((IFixParser)LegReturnRateInformationSourceGrp).Parse(viewLegReturnRateInformationSourceGrp);
				}
				LegReturnRateQuotePricingModel = view.GetString(42553);
				LegReturnRateCashFlowType = view.GetString(42554);
				if (view.GetView("LegReturnRateDateGrp") is IMessageView viewLegReturnRateDateGrp)
				{
					LegReturnRateDateGrp = new();
					((IFixParser)LegReturnRateDateGrp).Parse(viewLegReturnRateDateGrp);
				}
				LegReturnRateValuationTimeType = view.GetInt32(42555);
				LegReturnRateValuationTime = view.GetString(42556);
				LegReturnRateValuationTimeBusinessCenter = view.GetString(42557);
				LegReturnRateValuationPriceOption = view.GetInt32(42558);
				LegReturnRateFinalPriceFallback = view.GetInt32(42559);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegReturnRatePriceSequence":
					{
						value = LegReturnRatePriceSequence;
						break;
					}
					case "LegReturnRateCommissionBasis":
					{
						value = LegReturnRateCommissionBasis;
						break;
					}
					case "LegReturnRateCommissionAmount":
					{
						value = LegReturnRateCommissionAmount;
						break;
					}
					case "LegReturnRateCommissionCurrency":
					{
						value = LegReturnRateCommissionCurrency;
						break;
					}
					case "LegReturnRateTotalCommissionPerTrade":
					{
						value = LegReturnRateTotalCommissionPerTrade;
						break;
					}
					case "LegReturnRateDeterminationMethod":
					{
						value = LegReturnRateDeterminationMethod;
						break;
					}
					case "LegReturnRatePriceGrp":
					{
						value = LegReturnRatePriceGrp;
						break;
					}
					case "LegReturnRateFXConversionGrp":
					{
						value = LegReturnRateFXConversionGrp;
						break;
					}
					case "LegReturnRateAmountRelativeTo":
					{
						value = LegReturnRateAmountRelativeTo;
						break;
					}
					case "LegReturnRateQuoteMeasureType":
					{
						value = LegReturnRateQuoteMeasureType;
						break;
					}
					case "LegReturnRateQuoteUnits":
					{
						value = LegReturnRateQuoteUnits;
						break;
					}
					case "LegReturnRateQuoteMethod":
					{
						value = LegReturnRateQuoteMethod;
						break;
					}
					case "LegReturnRateQuoteCurrency":
					{
						value = LegReturnRateQuoteCurrency;
						break;
					}
					case "LegReturnRateQuoteCurrencyType":
					{
						value = LegReturnRateQuoteCurrencyType;
						break;
					}
					case "LegReturnRateQuoteTimeType":
					{
						value = LegReturnRateQuoteTimeType;
						break;
					}
					case "LegReturnRateQuoteTime":
					{
						value = LegReturnRateQuoteTime;
						break;
					}
					case "LegReturnRateQuoteDate":
					{
						value = LegReturnRateQuoteDate;
						break;
					}
					case "LegReturnRateQuoteExpirationTime":
					{
						value = LegReturnRateQuoteExpirationTime;
						break;
					}
					case "LegReturnRateQuoteBusinessCenter":
					{
						value = LegReturnRateQuoteBusinessCenter;
						break;
					}
					case "LegReturnRateQuoteExchange":
					{
						value = LegReturnRateQuoteExchange;
						break;
					}
					case "LegReturnRateInformationSourceGrp":
					{
						value = LegReturnRateInformationSourceGrp;
						break;
					}
					case "LegReturnRateQuotePricingModel":
					{
						value = LegReturnRateQuotePricingModel;
						break;
					}
					case "LegReturnRateCashFlowType":
					{
						value = LegReturnRateCashFlowType;
						break;
					}
					case "LegReturnRateDateGrp":
					{
						value = LegReturnRateDateGrp;
						break;
					}
					case "LegReturnRateValuationTimeType":
					{
						value = LegReturnRateValuationTimeType;
						break;
					}
					case "LegReturnRateValuationTime":
					{
						value = LegReturnRateValuationTime;
						break;
					}
					case "LegReturnRateValuationTimeBusinessCenter":
					{
						value = LegReturnRateValuationTimeBusinessCenter;
						break;
					}
					case "LegReturnRateValuationPriceOption":
					{
						value = LegReturnRateValuationPriceOption;
						break;
					}
					case "LegReturnRateFinalPriceFallback":
					{
						value = LegReturnRateFinalPriceFallback;
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
				LegReturnRatePriceSequence = null;
				LegReturnRateCommissionBasis = null;
				LegReturnRateCommissionAmount = null;
				LegReturnRateCommissionCurrency = null;
				LegReturnRateTotalCommissionPerTrade = null;
				LegReturnRateDeterminationMethod = null;
				((IFixReset?)LegReturnRatePriceGrp)?.Reset();
				((IFixReset?)LegReturnRateFXConversionGrp)?.Reset();
				LegReturnRateAmountRelativeTo = null;
				LegReturnRateQuoteMeasureType = null;
				LegReturnRateQuoteUnits = null;
				LegReturnRateQuoteMethod = null;
				LegReturnRateQuoteCurrency = null;
				LegReturnRateQuoteCurrencyType = null;
				LegReturnRateQuoteTimeType = null;
				LegReturnRateQuoteTime = null;
				LegReturnRateQuoteDate = null;
				LegReturnRateQuoteExpirationTime = null;
				LegReturnRateQuoteBusinessCenter = null;
				LegReturnRateQuoteExchange = null;
				((IFixReset?)LegReturnRateInformationSourceGrp)?.Reset();
				LegReturnRateQuotePricingModel = null;
				LegReturnRateCashFlowType = null;
				((IFixReset?)LegReturnRateDateGrp)?.Reset();
				LegReturnRateValuationTimeType = null;
				LegReturnRateValuationTime = null;
				LegReturnRateValuationTimeBusinessCenter = null;
				LegReturnRateValuationPriceOption = null;
				LegReturnRateFinalPriceFallback = null;
			}
		}
		[Group(NoOfTag = 42534, Offset = 0, Required = false)]
		public NoLegReturnRates[]? LegReturnRates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegReturnRates is not null && LegReturnRates.Length != 0)
			{
				writer.WriteWholeNumber(42534, LegReturnRates.Length);
				for (int i = 0; i < LegReturnRates.Length; i++)
				{
					((IFixEncoder)LegReturnRates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegReturnRates") is IMessageView viewNoLegReturnRates)
			{
				var count = viewNoLegReturnRates.GroupCount();
				LegReturnRates = new NoLegReturnRates[count];
				for (int i = 0; i < count; i++)
				{
					LegReturnRates[i] = new();
					((IFixParser)LegReturnRates[i]).Parse(viewNoLegReturnRates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegReturnRates":
				{
					value = LegReturnRates;
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
			LegReturnRates = null;
		}
	}
}
