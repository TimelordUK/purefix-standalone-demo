using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class SettlementAmountGrp : IFixComponent
	{
		public sealed partial class NoSettlementAmounts : IFixGroup
		{
			[TagDetails(Tag = 1701, Type = TagType.Float, Offset = 0, Required = false)]
			public double? SettlementAmount {get; set;}
			
			[TagDetails(Tag = 1702, Type = TagType.String, Offset = 1, Required = false)]
			public string? SettlementAmountCurrency {get; set;}
			
			[TagDetails(Tag = 2903, Type = TagType.String, Offset = 2, Required = false)]
			public string? SettlementAmountCurrencyCodeSource {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (SettlementAmount is not null) writer.WriteNumber(1701, SettlementAmount.Value);
				if (SettlementAmountCurrency is not null) writer.WriteString(1702, SettlementAmountCurrency);
				if (SettlementAmountCurrencyCodeSource is not null) writer.WriteString(2903, SettlementAmountCurrencyCodeSource);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				SettlementAmount = view.GetDouble(1701);
				SettlementAmountCurrency = view.GetString(1702);
				SettlementAmountCurrencyCodeSource = view.GetString(2903);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "SettlementAmount":
					{
						value = SettlementAmount;
						break;
					}
					case "SettlementAmountCurrency":
					{
						value = SettlementAmountCurrency;
						break;
					}
					case "SettlementAmountCurrencyCodeSource":
					{
						value = SettlementAmountCurrencyCodeSource;
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
				SettlementAmount = null;
				SettlementAmountCurrency = null;
				SettlementAmountCurrencyCodeSource = null;
			}
		}
		[Group(NoOfTag = 1700, Offset = 0, Required = false)]
		public NoSettlementAmounts[]? SettlementAmounts {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (SettlementAmounts is not null && SettlementAmounts.Length != 0)
			{
				writer.WriteWholeNumber(1700, SettlementAmounts.Length);
				for (int i = 0; i < SettlementAmounts.Length; i++)
				{
					((IFixEncoder)SettlementAmounts[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoSettlementAmounts") is IMessageView viewNoSettlementAmounts)
			{
				var count = viewNoSettlementAmounts.GroupCount();
				SettlementAmounts = new NoSettlementAmounts[count];
				for (int i = 0; i < count; i++)
				{
					SettlementAmounts[i] = new();
					((IFixParser)SettlementAmounts[i]).Parse(viewNoSettlementAmounts.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoSettlementAmounts":
				{
					value = SettlementAmounts;
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
			SettlementAmounts = null;
		}
	}
}
