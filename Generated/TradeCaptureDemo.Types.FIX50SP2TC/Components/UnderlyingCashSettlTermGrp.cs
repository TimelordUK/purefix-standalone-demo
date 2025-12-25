using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingCashSettlTermGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingCashSettlTerms : IFixGroup
		{
			[TagDetails(Tag = 42042, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingCashSettlCurrency {get; set;}
			
			[TagDetails(Tag = 42043, Type = TagType.Int, Offset = 1, Required = false)]
			public int? UnderlyingCashSettlValuationFirstBusinessDayOffset {get; set;}
			
			[TagDetails(Tag = 42044, Type = TagType.Int, Offset = 2, Required = false)]
			public int? UnderlyingCashSettlValuationSubsequentBusinessDaysOffset {get; set;}
			
			[TagDetails(Tag = 42045, Type = TagType.Int, Offset = 3, Required = false)]
			public int? UnderlyingCashSettlNumOfValuationDates {get; set;}
			
			[TagDetails(Tag = 42046, Type = TagType.String, Offset = 4, Required = false)]
			public string? UnderlyingCashSettlValuationTime {get; set;}
			
			[TagDetails(Tag = 42047, Type = TagType.String, Offset = 5, Required = false)]
			public string? UnderlyingCashSettlBusinessCenter {get; set;}
			
			[TagDetails(Tag = 42048, Type = TagType.Int, Offset = 6, Required = false)]
			public int? UnderlyingCashSettlQuoteMethod {get; set;}
			
			[TagDetails(Tag = 42049, Type = TagType.Float, Offset = 7, Required = false)]
			public double? UnderlyingCashSettlQuoteAmount {get; set;}
			
			[TagDetails(Tag = 42050, Type = TagType.String, Offset = 8, Required = false)]
			public string? UnderlyingCashSettlQuoteCurrency {get; set;}
			
			[TagDetails(Tag = 42051, Type = TagType.Float, Offset = 9, Required = false)]
			public double? UnderlyingCashSettlMinimumQuoteAmount {get; set;}
			
			[TagDetails(Tag = 42052, Type = TagType.String, Offset = 10, Required = false)]
			public string? UnderlyingCashSettlMinimumQuoteCurrency {get; set;}
			
			[Component(Offset = 11, Required = false)]
			public UnderlyingCashSettlDealerGrp? UnderlyingCashSettlDealerGrp {get; set;}
			
			[TagDetails(Tag = 42797, Type = TagType.String, Offset = 12, Required = false)]
			public string? UnderlyingCashSettlPriceSource {get; set;}
			
			[TagDetails(Tag = 42798, Type = TagType.Int, Offset = 13, Required = false)]
			public int? UnderlyingCashSettlPriceDefault {get; set;}
			
			[TagDetails(Tag = 42053, Type = TagType.Int, Offset = 14, Required = false)]
			public int? UnderlyingCashSettlBusinessDays {get; set;}
			
			[TagDetails(Tag = 42054, Type = TagType.Float, Offset = 15, Required = false)]
			public double? UnderlyingCashSettlAmount {get; set;}
			
			[Component(Offset = 16, Required = false)]
			public UnderlyingCashSettlDate? UnderlyingCashSettlDate {get; set;}
			
			[TagDetails(Tag = 42055, Type = TagType.Float, Offset = 17, Required = false)]
			public double? UnderlyingCashSettlRecoveryFactor {get; set;}
			
			[TagDetails(Tag = 42056, Type = TagType.Boolean, Offset = 18, Required = false)]
			public bool? UnderlyingCashSettlFixedTermIndicator {get; set;}
			
			[TagDetails(Tag = 42057, Type = TagType.Boolean, Offset = 19, Required = false)]
			public bool? UnderlyingCashSettlAccruedInterestIndicator {get; set;}
			
			[TagDetails(Tag = 42058, Type = TagType.Int, Offset = 20, Required = false)]
			public int? UnderlyingCashSettlValuationMethod {get; set;}
			
			[TagDetails(Tag = 42059, Type = TagType.String, Offset = 21, Required = false)]
			public string? UnderlyingCashSettlTermXID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingCashSettlCurrency is not null) writer.WriteString(42042, UnderlyingCashSettlCurrency);
				if (UnderlyingCashSettlValuationFirstBusinessDayOffset is not null) writer.WriteWholeNumber(42043, UnderlyingCashSettlValuationFirstBusinessDayOffset.Value);
				if (UnderlyingCashSettlValuationSubsequentBusinessDaysOffset is not null) writer.WriteWholeNumber(42044, UnderlyingCashSettlValuationSubsequentBusinessDaysOffset.Value);
				if (UnderlyingCashSettlNumOfValuationDates is not null) writer.WriteWholeNumber(42045, UnderlyingCashSettlNumOfValuationDates.Value);
				if (UnderlyingCashSettlValuationTime is not null) writer.WriteString(42046, UnderlyingCashSettlValuationTime);
				if (UnderlyingCashSettlBusinessCenter is not null) writer.WriteString(42047, UnderlyingCashSettlBusinessCenter);
				if (UnderlyingCashSettlQuoteMethod is not null) writer.WriteWholeNumber(42048, UnderlyingCashSettlQuoteMethod.Value);
				if (UnderlyingCashSettlQuoteAmount is not null) writer.WriteNumber(42049, UnderlyingCashSettlQuoteAmount.Value);
				if (UnderlyingCashSettlQuoteCurrency is not null) writer.WriteString(42050, UnderlyingCashSettlQuoteCurrency);
				if (UnderlyingCashSettlMinimumQuoteAmount is not null) writer.WriteNumber(42051, UnderlyingCashSettlMinimumQuoteAmount.Value);
				if (UnderlyingCashSettlMinimumQuoteCurrency is not null) writer.WriteString(42052, UnderlyingCashSettlMinimumQuoteCurrency);
				if (UnderlyingCashSettlDealerGrp is not null) ((IFixEncoder)UnderlyingCashSettlDealerGrp).Encode(writer);
				if (UnderlyingCashSettlPriceSource is not null) writer.WriteString(42797, UnderlyingCashSettlPriceSource);
				if (UnderlyingCashSettlPriceDefault is not null) writer.WriteWholeNumber(42798, UnderlyingCashSettlPriceDefault.Value);
				if (UnderlyingCashSettlBusinessDays is not null) writer.WriteWholeNumber(42053, UnderlyingCashSettlBusinessDays.Value);
				if (UnderlyingCashSettlAmount is not null) writer.WriteNumber(42054, UnderlyingCashSettlAmount.Value);
				if (UnderlyingCashSettlDate is not null) ((IFixEncoder)UnderlyingCashSettlDate).Encode(writer);
				if (UnderlyingCashSettlRecoveryFactor is not null) writer.WriteNumber(42055, UnderlyingCashSettlRecoveryFactor.Value);
				if (UnderlyingCashSettlFixedTermIndicator is not null) writer.WriteBoolean(42056, UnderlyingCashSettlFixedTermIndicator.Value);
				if (UnderlyingCashSettlAccruedInterestIndicator is not null) writer.WriteBoolean(42057, UnderlyingCashSettlAccruedInterestIndicator.Value);
				if (UnderlyingCashSettlValuationMethod is not null) writer.WriteWholeNumber(42058, UnderlyingCashSettlValuationMethod.Value);
				if (UnderlyingCashSettlTermXID is not null) writer.WriteString(42059, UnderlyingCashSettlTermXID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingCashSettlCurrency = view.GetString(42042);
				UnderlyingCashSettlValuationFirstBusinessDayOffset = view.GetInt32(42043);
				UnderlyingCashSettlValuationSubsequentBusinessDaysOffset = view.GetInt32(42044);
				UnderlyingCashSettlNumOfValuationDates = view.GetInt32(42045);
				UnderlyingCashSettlValuationTime = view.GetString(42046);
				UnderlyingCashSettlBusinessCenter = view.GetString(42047);
				UnderlyingCashSettlQuoteMethod = view.GetInt32(42048);
				UnderlyingCashSettlQuoteAmount = view.GetDouble(42049);
				UnderlyingCashSettlQuoteCurrency = view.GetString(42050);
				UnderlyingCashSettlMinimumQuoteAmount = view.GetDouble(42051);
				UnderlyingCashSettlMinimumQuoteCurrency = view.GetString(42052);
				if (view.GetView("UnderlyingCashSettlDealerGrp") is IMessageView viewUnderlyingCashSettlDealerGrp)
				{
					UnderlyingCashSettlDealerGrp = new();
					((IFixParser)UnderlyingCashSettlDealerGrp).Parse(viewUnderlyingCashSettlDealerGrp);
				}
				UnderlyingCashSettlPriceSource = view.GetString(42797);
				UnderlyingCashSettlPriceDefault = view.GetInt32(42798);
				UnderlyingCashSettlBusinessDays = view.GetInt32(42053);
				UnderlyingCashSettlAmount = view.GetDouble(42054);
				if (view.GetView("UnderlyingCashSettlDate") is IMessageView viewUnderlyingCashSettlDate)
				{
					UnderlyingCashSettlDate = new();
					((IFixParser)UnderlyingCashSettlDate).Parse(viewUnderlyingCashSettlDate);
				}
				UnderlyingCashSettlRecoveryFactor = view.GetDouble(42055);
				UnderlyingCashSettlFixedTermIndicator = view.GetBool(42056);
				UnderlyingCashSettlAccruedInterestIndicator = view.GetBool(42057);
				UnderlyingCashSettlValuationMethod = view.GetInt32(42058);
				UnderlyingCashSettlTermXID = view.GetString(42059);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingCashSettlCurrency":
					{
						value = UnderlyingCashSettlCurrency;
						break;
					}
					case "UnderlyingCashSettlValuationFirstBusinessDayOffset":
					{
						value = UnderlyingCashSettlValuationFirstBusinessDayOffset;
						break;
					}
					case "UnderlyingCashSettlValuationSubsequentBusinessDaysOffset":
					{
						value = UnderlyingCashSettlValuationSubsequentBusinessDaysOffset;
						break;
					}
					case "UnderlyingCashSettlNumOfValuationDates":
					{
						value = UnderlyingCashSettlNumOfValuationDates;
						break;
					}
					case "UnderlyingCashSettlValuationTime":
					{
						value = UnderlyingCashSettlValuationTime;
						break;
					}
					case "UnderlyingCashSettlBusinessCenter":
					{
						value = UnderlyingCashSettlBusinessCenter;
						break;
					}
					case "UnderlyingCashSettlQuoteMethod":
					{
						value = UnderlyingCashSettlQuoteMethod;
						break;
					}
					case "UnderlyingCashSettlQuoteAmount":
					{
						value = UnderlyingCashSettlQuoteAmount;
						break;
					}
					case "UnderlyingCashSettlQuoteCurrency":
					{
						value = UnderlyingCashSettlQuoteCurrency;
						break;
					}
					case "UnderlyingCashSettlMinimumQuoteAmount":
					{
						value = UnderlyingCashSettlMinimumQuoteAmount;
						break;
					}
					case "UnderlyingCashSettlMinimumQuoteCurrency":
					{
						value = UnderlyingCashSettlMinimumQuoteCurrency;
						break;
					}
					case "UnderlyingCashSettlDealerGrp":
					{
						value = UnderlyingCashSettlDealerGrp;
						break;
					}
					case "UnderlyingCashSettlPriceSource":
					{
						value = UnderlyingCashSettlPriceSource;
						break;
					}
					case "UnderlyingCashSettlPriceDefault":
					{
						value = UnderlyingCashSettlPriceDefault;
						break;
					}
					case "UnderlyingCashSettlBusinessDays":
					{
						value = UnderlyingCashSettlBusinessDays;
						break;
					}
					case "UnderlyingCashSettlAmount":
					{
						value = UnderlyingCashSettlAmount;
						break;
					}
					case "UnderlyingCashSettlDate":
					{
						value = UnderlyingCashSettlDate;
						break;
					}
					case "UnderlyingCashSettlRecoveryFactor":
					{
						value = UnderlyingCashSettlRecoveryFactor;
						break;
					}
					case "UnderlyingCashSettlFixedTermIndicator":
					{
						value = UnderlyingCashSettlFixedTermIndicator;
						break;
					}
					case "UnderlyingCashSettlAccruedInterestIndicator":
					{
						value = UnderlyingCashSettlAccruedInterestIndicator;
						break;
					}
					case "UnderlyingCashSettlValuationMethod":
					{
						value = UnderlyingCashSettlValuationMethod;
						break;
					}
					case "UnderlyingCashSettlTermXID":
					{
						value = UnderlyingCashSettlTermXID;
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
				UnderlyingCashSettlCurrency = null;
				UnderlyingCashSettlValuationFirstBusinessDayOffset = null;
				UnderlyingCashSettlValuationSubsequentBusinessDaysOffset = null;
				UnderlyingCashSettlNumOfValuationDates = null;
				UnderlyingCashSettlValuationTime = null;
				UnderlyingCashSettlBusinessCenter = null;
				UnderlyingCashSettlQuoteMethod = null;
				UnderlyingCashSettlQuoteAmount = null;
				UnderlyingCashSettlQuoteCurrency = null;
				UnderlyingCashSettlMinimumQuoteAmount = null;
				UnderlyingCashSettlMinimumQuoteCurrency = null;
				((IFixReset?)UnderlyingCashSettlDealerGrp)?.Reset();
				UnderlyingCashSettlPriceSource = null;
				UnderlyingCashSettlPriceDefault = null;
				UnderlyingCashSettlBusinessDays = null;
				UnderlyingCashSettlAmount = null;
				((IFixReset?)UnderlyingCashSettlDate)?.Reset();
				UnderlyingCashSettlRecoveryFactor = null;
				UnderlyingCashSettlFixedTermIndicator = null;
				UnderlyingCashSettlAccruedInterestIndicator = null;
				UnderlyingCashSettlValuationMethod = null;
				UnderlyingCashSettlTermXID = null;
			}
		}
		[Group(NoOfTag = 42041, Offset = 0, Required = false)]
		public NoUnderlyingCashSettlTerms[]? UnderlyingCashSettlTerms {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingCashSettlTerms is not null && UnderlyingCashSettlTerms.Length != 0)
			{
				writer.WriteWholeNumber(42041, UnderlyingCashSettlTerms.Length);
				for (int i = 0; i < UnderlyingCashSettlTerms.Length; i++)
				{
					((IFixEncoder)UnderlyingCashSettlTerms[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingCashSettlTerms") is IMessageView viewNoUnderlyingCashSettlTerms)
			{
				var count = viewNoUnderlyingCashSettlTerms.GroupCount();
				UnderlyingCashSettlTerms = new NoUnderlyingCashSettlTerms[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingCashSettlTerms[i] = new();
					((IFixParser)UnderlyingCashSettlTerms[i]).Parse(viewNoUnderlyingCashSettlTerms.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingCashSettlTerms":
				{
					value = UnderlyingCashSettlTerms;
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
			UnderlyingCashSettlTerms = null;
		}
	}
}
