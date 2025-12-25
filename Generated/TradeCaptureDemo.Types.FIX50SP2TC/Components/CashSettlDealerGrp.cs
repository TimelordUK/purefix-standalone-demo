using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class CashSettlDealerGrp : IFixComponent
	{
		public sealed partial class NoCashSettlDealers : IFixGroup
		{
			[TagDetails(Tag = 40032, Type = TagType.String, Offset = 0, Required = false)]
			public string? CashSettlDealer {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (CashSettlDealer is not null) writer.WriteString(40032, CashSettlDealer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				CashSettlDealer = view.GetString(40032);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "CashSettlDealer":
					{
						value = CashSettlDealer;
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
				CashSettlDealer = null;
			}
		}
		[Group(NoOfTag = 40277, Offset = 0, Required = false)]
		public NoCashSettlDealers[]? CashSettlDealers {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (CashSettlDealers is not null && CashSettlDealers.Length != 0)
			{
				writer.WriteWholeNumber(40277, CashSettlDealers.Length);
				for (int i = 0; i < CashSettlDealers.Length; i++)
				{
					((IFixEncoder)CashSettlDealers[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoCashSettlDealers") is IMessageView viewNoCashSettlDealers)
			{
				var count = viewNoCashSettlDealers.GroupCount();
				CashSettlDealers = new NoCashSettlDealers[count];
				for (int i = 0; i < count; i++)
				{
					CashSettlDealers[i] = new();
					((IFixParser)CashSettlDealers[i]).Parse(viewNoCashSettlDealers.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoCashSettlDealers":
				{
					value = CashSettlDealers;
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
			CashSettlDealers = null;
		}
	}
}
