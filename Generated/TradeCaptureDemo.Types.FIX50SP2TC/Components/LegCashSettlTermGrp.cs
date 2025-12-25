using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegCashSettlTermGrp : IFixComponent
	{
		public sealed partial class NoLegCashSettlTerms : IFixGroup
		{
			[TagDetails(Tag = 41345, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegCashSettlCurrency {get; set;}
			
			[TagDetails(Tag = 41346, Type = TagType.Int, Offset = 1, Required = false)]
			public int? LegCasSettlValuationFirstBusinessDayOffset {get; set;}
			
			[TagDetails(Tag = 41347, Type = TagType.Int, Offset = 2, Required = false)]
			public int? LegCashSettlValuationSubsequentBusinessDaysOffset {get; set;}
			
			[TagDetails(Tag = 41348, Type = TagType.Int, Offset = 3, Required = false)]
			public int? LegCashSettlNumOfValuationDates {get; set;}
			
			[TagDetails(Tag = 41349, Type = TagType.String, Offset = 4, Required = false)]
			public string? LegCashSettlValuationTime {get; set;}
			
			[TagDetails(Tag = 41350, Type = TagType.String, Offset = 5, Required = false)]
			public string? LegCashSettlBusinessCenter {get; set;}
			
			[TagDetails(Tag = 41351, Type = TagType.Int, Offset = 6, Required = false)]
			public int? LegCashSettlQuoteMethod {get; set;}
			
			[TagDetails(Tag = 41352, Type = TagType.Float, Offset = 7, Required = false)]
			public double? LegCashSettlQuoteAmount {get; set;}
			
			[TagDetails(Tag = 41353, Type = TagType.String, Offset = 8, Required = false)]
			public string? LegCashSettlQuoteCurrency {get; set;}
			
			[TagDetails(Tag = 41354, Type = TagType.Float, Offset = 9, Required = false)]
			public double? LegCashSettlMinimumQuoteAmount {get; set;}
			
			[TagDetails(Tag = 41355, Type = TagType.String, Offset = 10, Required = false)]
			public string? LegCashSettlMinimumQuoteCurrency {get; set;}
			
			[Component(Offset = 11, Required = false)]
			public LegCashSettlDealerGrp? LegCashSettlDealerGrp {get; set;}
			
			[TagDetails(Tag = 42308, Type = TagType.String, Offset = 12, Required = false)]
			public string? LegCashSettlPriceSource {get; set;}
			
			[TagDetails(Tag = 42309, Type = TagType.Int, Offset = 13, Required = false)]
			public int? LegCashSettlPriceDefault {get; set;}
			
			[TagDetails(Tag = 41356, Type = TagType.Int, Offset = 14, Required = false)]
			public int? LegCashSettlBusinessDays {get; set;}
			
			[TagDetails(Tag = 41357, Type = TagType.Float, Offset = 15, Required = false)]
			public double? LegCashSettlAmount {get; set;}
			
			[Component(Offset = 16, Required = false)]
			public LegCashSettlDate? LegCashSettlDate {get; set;}
			
			[TagDetails(Tag = 41358, Type = TagType.Float, Offset = 17, Required = false)]
			public double? LegCashSettlRecoveryFactor {get; set;}
			
			[TagDetails(Tag = 41359, Type = TagType.Boolean, Offset = 18, Required = false)]
			public bool? LegCashSettlFixedTermIndicator {get; set;}
			
			[TagDetails(Tag = 41360, Type = TagType.Boolean, Offset = 19, Required = false)]
			public bool? LegCashSettlAccruedInterestIndicator {get; set;}
			
			[TagDetails(Tag = 41361, Type = TagType.Int, Offset = 20, Required = false)]
			public int? LegCashSettlValuationMethod {get; set;}
			
			[TagDetails(Tag = 41362, Type = TagType.String, Offset = 21, Required = false)]
			public string? LegCashSettlTermXID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegCashSettlCurrency is not null) writer.WriteString(41345, LegCashSettlCurrency);
				if (LegCasSettlValuationFirstBusinessDayOffset is not null) writer.WriteWholeNumber(41346, LegCasSettlValuationFirstBusinessDayOffset.Value);
				if (LegCashSettlValuationSubsequentBusinessDaysOffset is not null) writer.WriteWholeNumber(41347, LegCashSettlValuationSubsequentBusinessDaysOffset.Value);
				if (LegCashSettlNumOfValuationDates is not null) writer.WriteWholeNumber(41348, LegCashSettlNumOfValuationDates.Value);
				if (LegCashSettlValuationTime is not null) writer.WriteString(41349, LegCashSettlValuationTime);
				if (LegCashSettlBusinessCenter is not null) writer.WriteString(41350, LegCashSettlBusinessCenter);
				if (LegCashSettlQuoteMethod is not null) writer.WriteWholeNumber(41351, LegCashSettlQuoteMethod.Value);
				if (LegCashSettlQuoteAmount is not null) writer.WriteNumber(41352, LegCashSettlQuoteAmount.Value);
				if (LegCashSettlQuoteCurrency is not null) writer.WriteString(41353, LegCashSettlQuoteCurrency);
				if (LegCashSettlMinimumQuoteAmount is not null) writer.WriteNumber(41354, LegCashSettlMinimumQuoteAmount.Value);
				if (LegCashSettlMinimumQuoteCurrency is not null) writer.WriteString(41355, LegCashSettlMinimumQuoteCurrency);
				if (LegCashSettlDealerGrp is not null) ((IFixEncoder)LegCashSettlDealerGrp).Encode(writer);
				if (LegCashSettlPriceSource is not null) writer.WriteString(42308, LegCashSettlPriceSource);
				if (LegCashSettlPriceDefault is not null) writer.WriteWholeNumber(42309, LegCashSettlPriceDefault.Value);
				if (LegCashSettlBusinessDays is not null) writer.WriteWholeNumber(41356, LegCashSettlBusinessDays.Value);
				if (LegCashSettlAmount is not null) writer.WriteNumber(41357, LegCashSettlAmount.Value);
				if (LegCashSettlDate is not null) ((IFixEncoder)LegCashSettlDate).Encode(writer);
				if (LegCashSettlRecoveryFactor is not null) writer.WriteNumber(41358, LegCashSettlRecoveryFactor.Value);
				if (LegCashSettlFixedTermIndicator is not null) writer.WriteBoolean(41359, LegCashSettlFixedTermIndicator.Value);
				if (LegCashSettlAccruedInterestIndicator is not null) writer.WriteBoolean(41360, LegCashSettlAccruedInterestIndicator.Value);
				if (LegCashSettlValuationMethod is not null) writer.WriteWholeNumber(41361, LegCashSettlValuationMethod.Value);
				if (LegCashSettlTermXID is not null) writer.WriteString(41362, LegCashSettlTermXID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegCashSettlCurrency = view.GetString(41345);
				LegCasSettlValuationFirstBusinessDayOffset = view.GetInt32(41346);
				LegCashSettlValuationSubsequentBusinessDaysOffset = view.GetInt32(41347);
				LegCashSettlNumOfValuationDates = view.GetInt32(41348);
				LegCashSettlValuationTime = view.GetString(41349);
				LegCashSettlBusinessCenter = view.GetString(41350);
				LegCashSettlQuoteMethod = view.GetInt32(41351);
				LegCashSettlQuoteAmount = view.GetDouble(41352);
				LegCashSettlQuoteCurrency = view.GetString(41353);
				LegCashSettlMinimumQuoteAmount = view.GetDouble(41354);
				LegCashSettlMinimumQuoteCurrency = view.GetString(41355);
				if (view.GetView("LegCashSettlDealerGrp") is IMessageView viewLegCashSettlDealerGrp)
				{
					LegCashSettlDealerGrp = new();
					((IFixParser)LegCashSettlDealerGrp).Parse(viewLegCashSettlDealerGrp);
				}
				LegCashSettlPriceSource = view.GetString(42308);
				LegCashSettlPriceDefault = view.GetInt32(42309);
				LegCashSettlBusinessDays = view.GetInt32(41356);
				LegCashSettlAmount = view.GetDouble(41357);
				if (view.GetView("LegCashSettlDate") is IMessageView viewLegCashSettlDate)
				{
					LegCashSettlDate = new();
					((IFixParser)LegCashSettlDate).Parse(viewLegCashSettlDate);
				}
				LegCashSettlRecoveryFactor = view.GetDouble(41358);
				LegCashSettlFixedTermIndicator = view.GetBool(41359);
				LegCashSettlAccruedInterestIndicator = view.GetBool(41360);
				LegCashSettlValuationMethod = view.GetInt32(41361);
				LegCashSettlTermXID = view.GetString(41362);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegCashSettlCurrency":
					{
						value = LegCashSettlCurrency;
						break;
					}
					case "LegCasSettlValuationFirstBusinessDayOffset":
					{
						value = LegCasSettlValuationFirstBusinessDayOffset;
						break;
					}
					case "LegCashSettlValuationSubsequentBusinessDaysOffset":
					{
						value = LegCashSettlValuationSubsequentBusinessDaysOffset;
						break;
					}
					case "LegCashSettlNumOfValuationDates":
					{
						value = LegCashSettlNumOfValuationDates;
						break;
					}
					case "LegCashSettlValuationTime":
					{
						value = LegCashSettlValuationTime;
						break;
					}
					case "LegCashSettlBusinessCenter":
					{
						value = LegCashSettlBusinessCenter;
						break;
					}
					case "LegCashSettlQuoteMethod":
					{
						value = LegCashSettlQuoteMethod;
						break;
					}
					case "LegCashSettlQuoteAmount":
					{
						value = LegCashSettlQuoteAmount;
						break;
					}
					case "LegCashSettlQuoteCurrency":
					{
						value = LegCashSettlQuoteCurrency;
						break;
					}
					case "LegCashSettlMinimumQuoteAmount":
					{
						value = LegCashSettlMinimumQuoteAmount;
						break;
					}
					case "LegCashSettlMinimumQuoteCurrency":
					{
						value = LegCashSettlMinimumQuoteCurrency;
						break;
					}
					case "LegCashSettlDealerGrp":
					{
						value = LegCashSettlDealerGrp;
						break;
					}
					case "LegCashSettlPriceSource":
					{
						value = LegCashSettlPriceSource;
						break;
					}
					case "LegCashSettlPriceDefault":
					{
						value = LegCashSettlPriceDefault;
						break;
					}
					case "LegCashSettlBusinessDays":
					{
						value = LegCashSettlBusinessDays;
						break;
					}
					case "LegCashSettlAmount":
					{
						value = LegCashSettlAmount;
						break;
					}
					case "LegCashSettlDate":
					{
						value = LegCashSettlDate;
						break;
					}
					case "LegCashSettlRecoveryFactor":
					{
						value = LegCashSettlRecoveryFactor;
						break;
					}
					case "LegCashSettlFixedTermIndicator":
					{
						value = LegCashSettlFixedTermIndicator;
						break;
					}
					case "LegCashSettlAccruedInterestIndicator":
					{
						value = LegCashSettlAccruedInterestIndicator;
						break;
					}
					case "LegCashSettlValuationMethod":
					{
						value = LegCashSettlValuationMethod;
						break;
					}
					case "LegCashSettlTermXID":
					{
						value = LegCashSettlTermXID;
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
				LegCashSettlCurrency = null;
				LegCasSettlValuationFirstBusinessDayOffset = null;
				LegCashSettlValuationSubsequentBusinessDaysOffset = null;
				LegCashSettlNumOfValuationDates = null;
				LegCashSettlValuationTime = null;
				LegCashSettlBusinessCenter = null;
				LegCashSettlQuoteMethod = null;
				LegCashSettlQuoteAmount = null;
				LegCashSettlQuoteCurrency = null;
				LegCashSettlMinimumQuoteAmount = null;
				LegCashSettlMinimumQuoteCurrency = null;
				((IFixReset?)LegCashSettlDealerGrp)?.Reset();
				LegCashSettlPriceSource = null;
				LegCashSettlPriceDefault = null;
				LegCashSettlBusinessDays = null;
				LegCashSettlAmount = null;
				((IFixReset?)LegCashSettlDate)?.Reset();
				LegCashSettlRecoveryFactor = null;
				LegCashSettlFixedTermIndicator = null;
				LegCashSettlAccruedInterestIndicator = null;
				LegCashSettlValuationMethod = null;
				LegCashSettlTermXID = null;
			}
		}
		[Group(NoOfTag = 41344, Offset = 0, Required = false)]
		public NoLegCashSettlTerms[]? LegCashSettlTerms {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegCashSettlTerms is not null && LegCashSettlTerms.Length != 0)
			{
				writer.WriteWholeNumber(41344, LegCashSettlTerms.Length);
				for (int i = 0; i < LegCashSettlTerms.Length; i++)
				{
					((IFixEncoder)LegCashSettlTerms[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegCashSettlTerms") is IMessageView viewNoLegCashSettlTerms)
			{
				var count = viewNoLegCashSettlTerms.GroupCount();
				LegCashSettlTerms = new NoLegCashSettlTerms[count];
				for (int i = 0; i < count; i++)
				{
					LegCashSettlTerms[i] = new();
					((IFixParser)LegCashSettlTerms[i]).Parse(viewNoLegCashSettlTerms.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegCashSettlTerms":
				{
					value = LegCashSettlTerms;
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
			LegCashSettlTerms = null;
		}
	}
}
