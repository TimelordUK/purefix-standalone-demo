using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingReturnRateGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingReturnRates : IFixGroup
		{
			[TagDetails(Tag = 43035, Type = TagType.Int, Offset = 0, Required = false)]
			public int? UnderlyingReturnRatePriceSequence {get; set;}
			
			[TagDetails(Tag = 43036, Type = TagType.String, Offset = 1, Required = false)]
			public string? UnderlyingReturnRateCommissionBasis {get; set;}
			
			[TagDetails(Tag = 43037, Type = TagType.Float, Offset = 2, Required = false)]
			public double? UnderlyingReturnRateCommissionAmount {get; set;}
			
			[TagDetails(Tag = 43038, Type = TagType.String, Offset = 3, Required = false)]
			public string? UnderlyingReturnRateCommissionCurrency {get; set;}
			
			[TagDetails(Tag = 43039, Type = TagType.Float, Offset = 4, Required = false)]
			public double? UnderlyingReturnRateTotalCommissionPerTrade {get; set;}
			
			[TagDetails(Tag = 43040, Type = TagType.String, Offset = 5, Required = false)]
			public string? UnderlyingReturnRateDeterminationMethod {get; set;}
			
			[Component(Offset = 6, Required = false)]
			public UnderlyingReturnRatePriceGrp? UnderlyingReturnRatePriceGrp {get; set;}
			
			[Component(Offset = 7, Required = false)]
			public UnderlyingReturnRateFXConversionGrp? UnderlyingReturnRateFXConversionGrp {get; set;}
			
			[TagDetails(Tag = 43041, Type = TagType.Int, Offset = 8, Required = false)]
			public int? UnderlyingReturnRateAmountRelativeTo {get; set;}
			
			[TagDetails(Tag = 43042, Type = TagType.String, Offset = 9, Required = false)]
			public string? UnderlyingReturnRateQuoteMeasureType {get; set;}
			
			[TagDetails(Tag = 43043, Type = TagType.String, Offset = 10, Required = false)]
			public string? UnderlyingReturnRateQuoteUnits {get; set;}
			
			[TagDetails(Tag = 43044, Type = TagType.Int, Offset = 11, Required = false)]
			public int? UnderlyingReturnRateQuoteMethod {get; set;}
			
			[TagDetails(Tag = 43045, Type = TagType.String, Offset = 12, Required = false)]
			public string? UnderlyingReturnRateQuoteCurrency {get; set;}
			
			[TagDetails(Tag = 43046, Type = TagType.String, Offset = 13, Required = false)]
			public string? UnderlyingReturnRateQuoteCurrencyType {get; set;}
			
			[TagDetails(Tag = 43047, Type = TagType.Int, Offset = 14, Required = false)]
			public int? UnderlyingReturnRateQuoteTimeType {get; set;}
			
			[TagDetails(Tag = 43048, Type = TagType.LocalDate, Offset = 15, Required = false)]
			public DateOnly? UnderlyingReturnRateQuoteTime {get; set;}
			
			[TagDetails(Tag = 43049, Type = TagType.LocalDate, Offset = 16, Required = false)]
			public DateOnly? UnderlyingReturnRateQuoteDate {get; set;}
			
			[TagDetails(Tag = 43050, Type = TagType.String, Offset = 17, Required = false)]
			public string? UnderlyingReturnRateQuoteExpirationTime {get; set;}
			
			[TagDetails(Tag = 43051, Type = TagType.String, Offset = 18, Required = false)]
			public string? UnderlyingReturnRateQuoteBusinessCenter {get; set;}
			
			[TagDetails(Tag = 43052, Type = TagType.String, Offset = 19, Required = false)]
			public string? UnderlyingReturnRateQuoteExchange {get; set;}
			
			[Component(Offset = 20, Required = false)]
			public UnderlyingReturnRateInformationSourceGrp? UnderlyingReturnRateInformationSourceGrp {get; set;}
			
			[TagDetails(Tag = 43053, Type = TagType.String, Offset = 21, Required = false)]
			public string? UnderlyingReturnRateQuotePricingModel {get; set;}
			
			[TagDetails(Tag = 43054, Type = TagType.String, Offset = 22, Required = false)]
			public string? UnderlyingReturnRateCashFlowType {get; set;}
			
			[Component(Offset = 23, Required = false)]
			public UnderlyingReturnRateDateGrp? UnderlyingReturnRateDateGrp {get; set;}
			
			[TagDetails(Tag = 43055, Type = TagType.Int, Offset = 24, Required = false)]
			public int? UnderlyingReturnRateValuationTimeType {get; set;}
			
			[TagDetails(Tag = 43056, Type = TagType.String, Offset = 25, Required = false)]
			public string? UnderlyingReturnRateValuationTime {get; set;}
			
			[TagDetails(Tag = 43057, Type = TagType.String, Offset = 26, Required = false)]
			public string? UnderlyingReturnRateValuationTimeBusinessCenter {get; set;}
			
			[TagDetails(Tag = 43058, Type = TagType.Int, Offset = 27, Required = false)]
			public int? UnderlyingReturnRateValuationPriceOption {get; set;}
			
			[TagDetails(Tag = 43059, Type = TagType.Int, Offset = 28, Required = false)]
			public int? UnderlyingReturnRateFinalPriceFallback {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingReturnRatePriceSequence is not null) writer.WriteWholeNumber(43035, UnderlyingReturnRatePriceSequence.Value);
				if (UnderlyingReturnRateCommissionBasis is not null) writer.WriteString(43036, UnderlyingReturnRateCommissionBasis);
				if (UnderlyingReturnRateCommissionAmount is not null) writer.WriteNumber(43037, UnderlyingReturnRateCommissionAmount.Value);
				if (UnderlyingReturnRateCommissionCurrency is not null) writer.WriteString(43038, UnderlyingReturnRateCommissionCurrency);
				if (UnderlyingReturnRateTotalCommissionPerTrade is not null) writer.WriteNumber(43039, UnderlyingReturnRateTotalCommissionPerTrade.Value);
				if (UnderlyingReturnRateDeterminationMethod is not null) writer.WriteString(43040, UnderlyingReturnRateDeterminationMethod);
				if (UnderlyingReturnRatePriceGrp is not null) ((IFixEncoder)UnderlyingReturnRatePriceGrp).Encode(writer);
				if (UnderlyingReturnRateFXConversionGrp is not null) ((IFixEncoder)UnderlyingReturnRateFXConversionGrp).Encode(writer);
				if (UnderlyingReturnRateAmountRelativeTo is not null) writer.WriteWholeNumber(43041, UnderlyingReturnRateAmountRelativeTo.Value);
				if (UnderlyingReturnRateQuoteMeasureType is not null) writer.WriteString(43042, UnderlyingReturnRateQuoteMeasureType);
				if (UnderlyingReturnRateQuoteUnits is not null) writer.WriteString(43043, UnderlyingReturnRateQuoteUnits);
				if (UnderlyingReturnRateQuoteMethod is not null) writer.WriteWholeNumber(43044, UnderlyingReturnRateQuoteMethod.Value);
				if (UnderlyingReturnRateQuoteCurrency is not null) writer.WriteString(43045, UnderlyingReturnRateQuoteCurrency);
				if (UnderlyingReturnRateQuoteCurrencyType is not null) writer.WriteString(43046, UnderlyingReturnRateQuoteCurrencyType);
				if (UnderlyingReturnRateQuoteTimeType is not null) writer.WriteWholeNumber(43047, UnderlyingReturnRateQuoteTimeType.Value);
				if (UnderlyingReturnRateQuoteTime is not null) writer.WriteLocalDateOnly(43048, UnderlyingReturnRateQuoteTime.Value);
				if (UnderlyingReturnRateQuoteDate is not null) writer.WriteLocalDateOnly(43049, UnderlyingReturnRateQuoteDate.Value);
				if (UnderlyingReturnRateQuoteExpirationTime is not null) writer.WriteString(43050, UnderlyingReturnRateQuoteExpirationTime);
				if (UnderlyingReturnRateQuoteBusinessCenter is not null) writer.WriteString(43051, UnderlyingReturnRateQuoteBusinessCenter);
				if (UnderlyingReturnRateQuoteExchange is not null) writer.WriteString(43052, UnderlyingReturnRateQuoteExchange);
				if (UnderlyingReturnRateInformationSourceGrp is not null) ((IFixEncoder)UnderlyingReturnRateInformationSourceGrp).Encode(writer);
				if (UnderlyingReturnRateQuotePricingModel is not null) writer.WriteString(43053, UnderlyingReturnRateQuotePricingModel);
				if (UnderlyingReturnRateCashFlowType is not null) writer.WriteString(43054, UnderlyingReturnRateCashFlowType);
				if (UnderlyingReturnRateDateGrp is not null) ((IFixEncoder)UnderlyingReturnRateDateGrp).Encode(writer);
				if (UnderlyingReturnRateValuationTimeType is not null) writer.WriteWholeNumber(43055, UnderlyingReturnRateValuationTimeType.Value);
				if (UnderlyingReturnRateValuationTime is not null) writer.WriteString(43056, UnderlyingReturnRateValuationTime);
				if (UnderlyingReturnRateValuationTimeBusinessCenter is not null) writer.WriteString(43057, UnderlyingReturnRateValuationTimeBusinessCenter);
				if (UnderlyingReturnRateValuationPriceOption is not null) writer.WriteWholeNumber(43058, UnderlyingReturnRateValuationPriceOption.Value);
				if (UnderlyingReturnRateFinalPriceFallback is not null) writer.WriteWholeNumber(43059, UnderlyingReturnRateFinalPriceFallback.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingReturnRatePriceSequence = view.GetInt32(43035);
				UnderlyingReturnRateCommissionBasis = view.GetString(43036);
				UnderlyingReturnRateCommissionAmount = view.GetDouble(43037);
				UnderlyingReturnRateCommissionCurrency = view.GetString(43038);
				UnderlyingReturnRateTotalCommissionPerTrade = view.GetDouble(43039);
				UnderlyingReturnRateDeterminationMethod = view.GetString(43040);
				if (view.GetView("UnderlyingReturnRatePriceGrp") is IMessageView viewUnderlyingReturnRatePriceGrp)
				{
					UnderlyingReturnRatePriceGrp = new();
					((IFixParser)UnderlyingReturnRatePriceGrp).Parse(viewUnderlyingReturnRatePriceGrp);
				}
				if (view.GetView("UnderlyingReturnRateFXConversionGrp") is IMessageView viewUnderlyingReturnRateFXConversionGrp)
				{
					UnderlyingReturnRateFXConversionGrp = new();
					((IFixParser)UnderlyingReturnRateFXConversionGrp).Parse(viewUnderlyingReturnRateFXConversionGrp);
				}
				UnderlyingReturnRateAmountRelativeTo = view.GetInt32(43041);
				UnderlyingReturnRateQuoteMeasureType = view.GetString(43042);
				UnderlyingReturnRateQuoteUnits = view.GetString(43043);
				UnderlyingReturnRateQuoteMethod = view.GetInt32(43044);
				UnderlyingReturnRateQuoteCurrency = view.GetString(43045);
				UnderlyingReturnRateQuoteCurrencyType = view.GetString(43046);
				UnderlyingReturnRateQuoteTimeType = view.GetInt32(43047);
				UnderlyingReturnRateQuoteTime = view.GetDateOnly(43048);
				UnderlyingReturnRateQuoteDate = view.GetDateOnly(43049);
				UnderlyingReturnRateQuoteExpirationTime = view.GetString(43050);
				UnderlyingReturnRateQuoteBusinessCenter = view.GetString(43051);
				UnderlyingReturnRateQuoteExchange = view.GetString(43052);
				if (view.GetView("UnderlyingReturnRateInformationSourceGrp") is IMessageView viewUnderlyingReturnRateInformationSourceGrp)
				{
					UnderlyingReturnRateInformationSourceGrp = new();
					((IFixParser)UnderlyingReturnRateInformationSourceGrp).Parse(viewUnderlyingReturnRateInformationSourceGrp);
				}
				UnderlyingReturnRateQuotePricingModel = view.GetString(43053);
				UnderlyingReturnRateCashFlowType = view.GetString(43054);
				if (view.GetView("UnderlyingReturnRateDateGrp") is IMessageView viewUnderlyingReturnRateDateGrp)
				{
					UnderlyingReturnRateDateGrp = new();
					((IFixParser)UnderlyingReturnRateDateGrp).Parse(viewUnderlyingReturnRateDateGrp);
				}
				UnderlyingReturnRateValuationTimeType = view.GetInt32(43055);
				UnderlyingReturnRateValuationTime = view.GetString(43056);
				UnderlyingReturnRateValuationTimeBusinessCenter = view.GetString(43057);
				UnderlyingReturnRateValuationPriceOption = view.GetInt32(43058);
				UnderlyingReturnRateFinalPriceFallback = view.GetInt32(43059);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingReturnRatePriceSequence":
					{
						value = UnderlyingReturnRatePriceSequence;
						break;
					}
					case "UnderlyingReturnRateCommissionBasis":
					{
						value = UnderlyingReturnRateCommissionBasis;
						break;
					}
					case "UnderlyingReturnRateCommissionAmount":
					{
						value = UnderlyingReturnRateCommissionAmount;
						break;
					}
					case "UnderlyingReturnRateCommissionCurrency":
					{
						value = UnderlyingReturnRateCommissionCurrency;
						break;
					}
					case "UnderlyingReturnRateTotalCommissionPerTrade":
					{
						value = UnderlyingReturnRateTotalCommissionPerTrade;
						break;
					}
					case "UnderlyingReturnRateDeterminationMethod":
					{
						value = UnderlyingReturnRateDeterminationMethod;
						break;
					}
					case "UnderlyingReturnRatePriceGrp":
					{
						value = UnderlyingReturnRatePriceGrp;
						break;
					}
					case "UnderlyingReturnRateFXConversionGrp":
					{
						value = UnderlyingReturnRateFXConversionGrp;
						break;
					}
					case "UnderlyingReturnRateAmountRelativeTo":
					{
						value = UnderlyingReturnRateAmountRelativeTo;
						break;
					}
					case "UnderlyingReturnRateQuoteMeasureType":
					{
						value = UnderlyingReturnRateQuoteMeasureType;
						break;
					}
					case "UnderlyingReturnRateQuoteUnits":
					{
						value = UnderlyingReturnRateQuoteUnits;
						break;
					}
					case "UnderlyingReturnRateQuoteMethod":
					{
						value = UnderlyingReturnRateQuoteMethod;
						break;
					}
					case "UnderlyingReturnRateQuoteCurrency":
					{
						value = UnderlyingReturnRateQuoteCurrency;
						break;
					}
					case "UnderlyingReturnRateQuoteCurrencyType":
					{
						value = UnderlyingReturnRateQuoteCurrencyType;
						break;
					}
					case "UnderlyingReturnRateQuoteTimeType":
					{
						value = UnderlyingReturnRateQuoteTimeType;
						break;
					}
					case "UnderlyingReturnRateQuoteTime":
					{
						value = UnderlyingReturnRateQuoteTime;
						break;
					}
					case "UnderlyingReturnRateQuoteDate":
					{
						value = UnderlyingReturnRateQuoteDate;
						break;
					}
					case "UnderlyingReturnRateQuoteExpirationTime":
					{
						value = UnderlyingReturnRateQuoteExpirationTime;
						break;
					}
					case "UnderlyingReturnRateQuoteBusinessCenter":
					{
						value = UnderlyingReturnRateQuoteBusinessCenter;
						break;
					}
					case "UnderlyingReturnRateQuoteExchange":
					{
						value = UnderlyingReturnRateQuoteExchange;
						break;
					}
					case "UnderlyingReturnRateInformationSourceGrp":
					{
						value = UnderlyingReturnRateInformationSourceGrp;
						break;
					}
					case "UnderlyingReturnRateQuotePricingModel":
					{
						value = UnderlyingReturnRateQuotePricingModel;
						break;
					}
					case "UnderlyingReturnRateCashFlowType":
					{
						value = UnderlyingReturnRateCashFlowType;
						break;
					}
					case "UnderlyingReturnRateDateGrp":
					{
						value = UnderlyingReturnRateDateGrp;
						break;
					}
					case "UnderlyingReturnRateValuationTimeType":
					{
						value = UnderlyingReturnRateValuationTimeType;
						break;
					}
					case "UnderlyingReturnRateValuationTime":
					{
						value = UnderlyingReturnRateValuationTime;
						break;
					}
					case "UnderlyingReturnRateValuationTimeBusinessCenter":
					{
						value = UnderlyingReturnRateValuationTimeBusinessCenter;
						break;
					}
					case "UnderlyingReturnRateValuationPriceOption":
					{
						value = UnderlyingReturnRateValuationPriceOption;
						break;
					}
					case "UnderlyingReturnRateFinalPriceFallback":
					{
						value = UnderlyingReturnRateFinalPriceFallback;
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
				UnderlyingReturnRatePriceSequence = null;
				UnderlyingReturnRateCommissionBasis = null;
				UnderlyingReturnRateCommissionAmount = null;
				UnderlyingReturnRateCommissionCurrency = null;
				UnderlyingReturnRateTotalCommissionPerTrade = null;
				UnderlyingReturnRateDeterminationMethod = null;
				((IFixReset?)UnderlyingReturnRatePriceGrp)?.Reset();
				((IFixReset?)UnderlyingReturnRateFXConversionGrp)?.Reset();
				UnderlyingReturnRateAmountRelativeTo = null;
				UnderlyingReturnRateQuoteMeasureType = null;
				UnderlyingReturnRateQuoteUnits = null;
				UnderlyingReturnRateQuoteMethod = null;
				UnderlyingReturnRateQuoteCurrency = null;
				UnderlyingReturnRateQuoteCurrencyType = null;
				UnderlyingReturnRateQuoteTimeType = null;
				UnderlyingReturnRateQuoteTime = null;
				UnderlyingReturnRateQuoteDate = null;
				UnderlyingReturnRateQuoteExpirationTime = null;
				UnderlyingReturnRateQuoteBusinessCenter = null;
				UnderlyingReturnRateQuoteExchange = null;
				((IFixReset?)UnderlyingReturnRateInformationSourceGrp)?.Reset();
				UnderlyingReturnRateQuotePricingModel = null;
				UnderlyingReturnRateCashFlowType = null;
				((IFixReset?)UnderlyingReturnRateDateGrp)?.Reset();
				UnderlyingReturnRateValuationTimeType = null;
				UnderlyingReturnRateValuationTime = null;
				UnderlyingReturnRateValuationTimeBusinessCenter = null;
				UnderlyingReturnRateValuationPriceOption = null;
				UnderlyingReturnRateFinalPriceFallback = null;
			}
		}
		[Group(NoOfTag = 43034, Offset = 0, Required = false)]
		public NoUnderlyingReturnRates[]? UnderlyingReturnRates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingReturnRates is not null && UnderlyingReturnRates.Length != 0)
			{
				writer.WriteWholeNumber(43034, UnderlyingReturnRates.Length);
				for (int i = 0; i < UnderlyingReturnRates.Length; i++)
				{
					((IFixEncoder)UnderlyingReturnRates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingReturnRates") is IMessageView viewNoUnderlyingReturnRates)
			{
				var count = viewNoUnderlyingReturnRates.GroupCount();
				UnderlyingReturnRates = new NoUnderlyingReturnRates[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingReturnRates[i] = new();
					((IFixParser)UnderlyingReturnRates[i]).Parse(viewNoUnderlyingReturnRates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingReturnRates":
				{
					value = UnderlyingReturnRates;
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
			UnderlyingReturnRates = null;
		}
	}
}
