using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingCashSettlDealerGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingCashSettlDealers : IFixGroup
		{
			[TagDetails(Tag = 42040, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingCashSettlDealer {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingCashSettlDealer is not null) writer.WriteString(42040, UnderlyingCashSettlDealer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingCashSettlDealer = view.GetString(42040);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingCashSettlDealer":
					{
						value = UnderlyingCashSettlDealer;
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
				UnderlyingCashSettlDealer = null;
			}
		}
		[Group(NoOfTag = 42039, Offset = 0, Required = false)]
		public NoUnderlyingCashSettlDealers[]? UnderlyingCashSettlDealers {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingCashSettlDealers is not null && UnderlyingCashSettlDealers.Length != 0)
			{
				writer.WriteWholeNumber(42039, UnderlyingCashSettlDealers.Length);
				for (int i = 0; i < UnderlyingCashSettlDealers.Length; i++)
				{
					((IFixEncoder)UnderlyingCashSettlDealers[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingCashSettlDealers") is IMessageView viewNoUnderlyingCashSettlDealers)
			{
				var count = viewNoUnderlyingCashSettlDealers.GroupCount();
				UnderlyingCashSettlDealers = new NoUnderlyingCashSettlDealers[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingCashSettlDealers[i] = new();
					((IFixParser)UnderlyingCashSettlDealers[i]).Parse(viewNoUnderlyingCashSettlDealers.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingCashSettlDealers":
				{
					value = UnderlyingCashSettlDealers;
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
			UnderlyingCashSettlDealers = null;
		}
	}
}
