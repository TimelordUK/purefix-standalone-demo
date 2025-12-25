using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegCashSettlDealerGrp : IFixComponent
	{
		public sealed partial class NoLegCashSettlDealers : IFixGroup
		{
			[TagDetails(Tag = 41343, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegCashSettlDealer {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegCashSettlDealer is not null) writer.WriteString(41343, LegCashSettlDealer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegCashSettlDealer = view.GetString(41343);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegCashSettlDealer":
					{
						value = LegCashSettlDealer;
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
				LegCashSettlDealer = null;
			}
		}
		[Group(NoOfTag = 41342, Offset = 0, Required = false)]
		public NoLegCashSettlDealers[]? LegCashSettlDealers {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegCashSettlDealers is not null && LegCashSettlDealers.Length != 0)
			{
				writer.WriteWholeNumber(41342, LegCashSettlDealers.Length);
				for (int i = 0; i < LegCashSettlDealers.Length; i++)
				{
					((IFixEncoder)LegCashSettlDealers[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegCashSettlDealers") is IMessageView viewNoLegCashSettlDealers)
			{
				var count = viewNoLegCashSettlDealers.GroupCount();
				LegCashSettlDealers = new NoLegCashSettlDealers[count];
				for (int i = 0; i < count; i++)
				{
					LegCashSettlDealers[i] = new();
					((IFixParser)LegCashSettlDealers[i]).Parse(viewNoLegCashSettlDealers.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegCashSettlDealers":
				{
					value = LegCashSettlDealers;
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
			LegCashSettlDealers = null;
		}
	}
}
