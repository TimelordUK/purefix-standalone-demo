using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class CashSettlTermGrp : IFixComponent
	{
		public sealed partial class NoCashSettlTerms : IFixGroup
		{
			[TagDetails(Tag = 40023, Type = TagType.String, Offset = 0, Required = false)]
			public string? CashSettlCurrency {get; set;}
			
			[TagDetails(Tag = 40024, Type = TagType.Int, Offset = 1, Required = false)]
			public int? CashSettlValuationFirstBusinessDayOffset {get; set;}
			
			[TagDetails(Tag = 40916, Type = TagType.Int, Offset = 2, Required = false)]
			public int? CashSettlValuationSubsequentBusinessDaysOffset {get; set;}
			
			[TagDetails(Tag = 40917, Type = TagType.Int, Offset = 3, Required = false)]
			public int? CashSettlNumOfValuationDates {get; set;}
			
			[TagDetails(Tag = 40025, Type = TagType.String, Offset = 4, Required = false)]
			public string? CashSettlValuationTime {get; set;}
			
			[TagDetails(Tag = 40026, Type = TagType.String, Offset = 5, Required = false)]
			public string? CashSettlBusinessCenter {get; set;}
			
			[TagDetails(Tag = 40027, Type = TagType.Int, Offset = 6, Required = false)]
			public int? CashSettlQuoteMethod {get; set;}
			
			[TagDetails(Tag = 40028, Type = TagType.Float, Offset = 7, Required = false)]
			public double? CashSettlQuoteAmount {get; set;}
			
			[TagDetails(Tag = 40029, Type = TagType.String, Offset = 8, Required = false)]
			public string? CashSettlQuoteCurrency {get; set;}
			
			[TagDetails(Tag = 40030, Type = TagType.Float, Offset = 9, Required = false)]
			public double? CashSettlMinimumQuoteAmount {get; set;}
			
			[TagDetails(Tag = 40031, Type = TagType.String, Offset = 10, Required = false)]
			public string? CashSettlMinimumQuoteCurrency {get; set;}
			
			[Component(Offset = 11, Required = false)]
			public CashSettlDealerGrp? CashSettlDealerGrp {get; set;}
			
			[TagDetails(Tag = 42216, Type = TagType.String, Offset = 12, Required = false)]
			public string? CashSettlPriceSource {get; set;}
			
			[TagDetails(Tag = 42217, Type = TagType.Int, Offset = 13, Required = false)]
			public int? CashSettlPriceDefault {get; set;}
			
			[TagDetails(Tag = 40033, Type = TagType.Int, Offset = 14, Required = false)]
			public int? CashSettlBusinessDays {get; set;}
			
			[TagDetails(Tag = 40034, Type = TagType.Float, Offset = 15, Required = false)]
			public double? CashSettlAmount {get; set;}
			
			[Component(Offset = 16, Required = false)]
			public CashSettlDate? CashSettlDate {get; set;}
			
			[TagDetails(Tag = 40035, Type = TagType.Float, Offset = 17, Required = false)]
			public double? CashSettlRecoveryFactor {get; set;}
			
			[TagDetails(Tag = 40036, Type = TagType.Boolean, Offset = 18, Required = false)]
			public bool? CashSettlFixedTermIndicator {get; set;}
			
			[TagDetails(Tag = 40037, Type = TagType.Boolean, Offset = 19, Required = false)]
			public bool? CashSettlAccruedInterestIndicator {get; set;}
			
			[TagDetails(Tag = 40038, Type = TagType.Int, Offset = 20, Required = false)]
			public int? CashSettlValuationMethod {get; set;}
			
			[TagDetails(Tag = 40039, Type = TagType.String, Offset = 21, Required = false)]
			public string? CashSettlTermXID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (CashSettlCurrency is not null) writer.WriteString(40023, CashSettlCurrency);
				if (CashSettlValuationFirstBusinessDayOffset is not null) writer.WriteWholeNumber(40024, CashSettlValuationFirstBusinessDayOffset.Value);
				if (CashSettlValuationSubsequentBusinessDaysOffset is not null) writer.WriteWholeNumber(40916, CashSettlValuationSubsequentBusinessDaysOffset.Value);
				if (CashSettlNumOfValuationDates is not null) writer.WriteWholeNumber(40917, CashSettlNumOfValuationDates.Value);
				if (CashSettlValuationTime is not null) writer.WriteString(40025, CashSettlValuationTime);
				if (CashSettlBusinessCenter is not null) writer.WriteString(40026, CashSettlBusinessCenter);
				if (CashSettlQuoteMethod is not null) writer.WriteWholeNumber(40027, CashSettlQuoteMethod.Value);
				if (CashSettlQuoteAmount is not null) writer.WriteNumber(40028, CashSettlQuoteAmount.Value);
				if (CashSettlQuoteCurrency is not null) writer.WriteString(40029, CashSettlQuoteCurrency);
				if (CashSettlMinimumQuoteAmount is not null) writer.WriteNumber(40030, CashSettlMinimumQuoteAmount.Value);
				if (CashSettlMinimumQuoteCurrency is not null) writer.WriteString(40031, CashSettlMinimumQuoteCurrency);
				if (CashSettlDealerGrp is not null) ((IFixEncoder)CashSettlDealerGrp).Encode(writer);
				if (CashSettlPriceSource is not null) writer.WriteString(42216, CashSettlPriceSource);
				if (CashSettlPriceDefault is not null) writer.WriteWholeNumber(42217, CashSettlPriceDefault.Value);
				if (CashSettlBusinessDays is not null) writer.WriteWholeNumber(40033, CashSettlBusinessDays.Value);
				if (CashSettlAmount is not null) writer.WriteNumber(40034, CashSettlAmount.Value);
				if (CashSettlDate is not null) ((IFixEncoder)CashSettlDate).Encode(writer);
				if (CashSettlRecoveryFactor is not null) writer.WriteNumber(40035, CashSettlRecoveryFactor.Value);
				if (CashSettlFixedTermIndicator is not null) writer.WriteBoolean(40036, CashSettlFixedTermIndicator.Value);
				if (CashSettlAccruedInterestIndicator is not null) writer.WriteBoolean(40037, CashSettlAccruedInterestIndicator.Value);
				if (CashSettlValuationMethod is not null) writer.WriteWholeNumber(40038, CashSettlValuationMethod.Value);
				if (CashSettlTermXID is not null) writer.WriteString(40039, CashSettlTermXID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				CashSettlCurrency = view.GetString(40023);
				CashSettlValuationFirstBusinessDayOffset = view.GetInt32(40024);
				CashSettlValuationSubsequentBusinessDaysOffset = view.GetInt32(40916);
				CashSettlNumOfValuationDates = view.GetInt32(40917);
				CashSettlValuationTime = view.GetString(40025);
				CashSettlBusinessCenter = view.GetString(40026);
				CashSettlQuoteMethod = view.GetInt32(40027);
				CashSettlQuoteAmount = view.GetDouble(40028);
				CashSettlQuoteCurrency = view.GetString(40029);
				CashSettlMinimumQuoteAmount = view.GetDouble(40030);
				CashSettlMinimumQuoteCurrency = view.GetString(40031);
				if (view.GetView("CashSettlDealerGrp") is IMessageView viewCashSettlDealerGrp)
				{
					CashSettlDealerGrp = new();
					((IFixParser)CashSettlDealerGrp).Parse(viewCashSettlDealerGrp);
				}
				CashSettlPriceSource = view.GetString(42216);
				CashSettlPriceDefault = view.GetInt32(42217);
				CashSettlBusinessDays = view.GetInt32(40033);
				CashSettlAmount = view.GetDouble(40034);
				if (view.GetView("CashSettlDate") is IMessageView viewCashSettlDate)
				{
					CashSettlDate = new();
					((IFixParser)CashSettlDate).Parse(viewCashSettlDate);
				}
				CashSettlRecoveryFactor = view.GetDouble(40035);
				CashSettlFixedTermIndicator = view.GetBool(40036);
				CashSettlAccruedInterestIndicator = view.GetBool(40037);
				CashSettlValuationMethod = view.GetInt32(40038);
				CashSettlTermXID = view.GetString(40039);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "CashSettlCurrency":
					{
						value = CashSettlCurrency;
						break;
					}
					case "CashSettlValuationFirstBusinessDayOffset":
					{
						value = CashSettlValuationFirstBusinessDayOffset;
						break;
					}
					case "CashSettlValuationSubsequentBusinessDaysOffset":
					{
						value = CashSettlValuationSubsequentBusinessDaysOffset;
						break;
					}
					case "CashSettlNumOfValuationDates":
					{
						value = CashSettlNumOfValuationDates;
						break;
					}
					case "CashSettlValuationTime":
					{
						value = CashSettlValuationTime;
						break;
					}
					case "CashSettlBusinessCenter":
					{
						value = CashSettlBusinessCenter;
						break;
					}
					case "CashSettlQuoteMethod":
					{
						value = CashSettlQuoteMethod;
						break;
					}
					case "CashSettlQuoteAmount":
					{
						value = CashSettlQuoteAmount;
						break;
					}
					case "CashSettlQuoteCurrency":
					{
						value = CashSettlQuoteCurrency;
						break;
					}
					case "CashSettlMinimumQuoteAmount":
					{
						value = CashSettlMinimumQuoteAmount;
						break;
					}
					case "CashSettlMinimumQuoteCurrency":
					{
						value = CashSettlMinimumQuoteCurrency;
						break;
					}
					case "CashSettlDealerGrp":
					{
						value = CashSettlDealerGrp;
						break;
					}
					case "CashSettlPriceSource":
					{
						value = CashSettlPriceSource;
						break;
					}
					case "CashSettlPriceDefault":
					{
						value = CashSettlPriceDefault;
						break;
					}
					case "CashSettlBusinessDays":
					{
						value = CashSettlBusinessDays;
						break;
					}
					case "CashSettlAmount":
					{
						value = CashSettlAmount;
						break;
					}
					case "CashSettlDate":
					{
						value = CashSettlDate;
						break;
					}
					case "CashSettlRecoveryFactor":
					{
						value = CashSettlRecoveryFactor;
						break;
					}
					case "CashSettlFixedTermIndicator":
					{
						value = CashSettlFixedTermIndicator;
						break;
					}
					case "CashSettlAccruedInterestIndicator":
					{
						value = CashSettlAccruedInterestIndicator;
						break;
					}
					case "CashSettlValuationMethod":
					{
						value = CashSettlValuationMethod;
						break;
					}
					case "CashSettlTermXID":
					{
						value = CashSettlTermXID;
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
				CashSettlCurrency = null;
				CashSettlValuationFirstBusinessDayOffset = null;
				CashSettlValuationSubsequentBusinessDaysOffset = null;
				CashSettlNumOfValuationDates = null;
				CashSettlValuationTime = null;
				CashSettlBusinessCenter = null;
				CashSettlQuoteMethod = null;
				CashSettlQuoteAmount = null;
				CashSettlQuoteCurrency = null;
				CashSettlMinimumQuoteAmount = null;
				CashSettlMinimumQuoteCurrency = null;
				((IFixReset?)CashSettlDealerGrp)?.Reset();
				CashSettlPriceSource = null;
				CashSettlPriceDefault = null;
				CashSettlBusinessDays = null;
				CashSettlAmount = null;
				((IFixReset?)CashSettlDate)?.Reset();
				CashSettlRecoveryFactor = null;
				CashSettlFixedTermIndicator = null;
				CashSettlAccruedInterestIndicator = null;
				CashSettlValuationMethod = null;
				CashSettlTermXID = null;
			}
		}
		[Group(NoOfTag = 40022, Offset = 0, Required = false)]
		public NoCashSettlTerms[]? CashSettlTerms {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (CashSettlTerms is not null && CashSettlTerms.Length != 0)
			{
				writer.WriteWholeNumber(40022, CashSettlTerms.Length);
				for (int i = 0; i < CashSettlTerms.Length; i++)
				{
					((IFixEncoder)CashSettlTerms[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoCashSettlTerms") is IMessageView viewNoCashSettlTerms)
			{
				var count = viewNoCashSettlTerms.GroupCount();
				CashSettlTerms = new NoCashSettlTerms[count];
				for (int i = 0; i < count; i++)
				{
					CashSettlTerms[i] = new();
					((IFixParser)CashSettlTerms[i]).Parse(viewNoCashSettlTerms.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoCashSettlTerms":
				{
					value = CashSettlTerms;
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
			CashSettlTerms = null;
		}
	}
}
