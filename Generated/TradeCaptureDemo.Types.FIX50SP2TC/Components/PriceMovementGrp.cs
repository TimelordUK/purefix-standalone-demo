using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PriceMovementGrp : IFixComponent
	{
		public sealed partial class NoPriceMovements : IFixGroup
		{
			[Component(Offset = 0, Required = false)]
			public PriceMovementValueGrp? PriceMovementValueGrp {get; set;}
			
			[Component(Offset = 1, Required = false)]
			public ClearingAccountTypeGrp? ClearingAccountTypeGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PriceMovementValueGrp is not null) ((IFixEncoder)PriceMovementValueGrp).Encode(writer);
				if (ClearingAccountTypeGrp is not null) ((IFixEncoder)ClearingAccountTypeGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				if (view.GetView("PriceMovementValueGrp") is IMessageView viewPriceMovementValueGrp)
				{
					PriceMovementValueGrp = new();
					((IFixParser)PriceMovementValueGrp).Parse(viewPriceMovementValueGrp);
				}
				if (view.GetView("ClearingAccountTypeGrp") is IMessageView viewClearingAccountTypeGrp)
				{
					ClearingAccountTypeGrp = new();
					((IFixParser)ClearingAccountTypeGrp).Parse(viewClearingAccountTypeGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PriceMovementValueGrp":
					{
						value = PriceMovementValueGrp;
						break;
					}
					case "ClearingAccountTypeGrp":
					{
						value = ClearingAccountTypeGrp;
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
				((IFixReset?)PriceMovementValueGrp)?.Reset();
				((IFixReset?)ClearingAccountTypeGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 1919, Offset = 0, Required = false)]
		public NoPriceMovements[]? PriceMovements {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PriceMovements is not null && PriceMovements.Length != 0)
			{
				writer.WriteWholeNumber(1919, PriceMovements.Length);
				for (int i = 0; i < PriceMovements.Length; i++)
				{
					((IFixEncoder)PriceMovements[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPriceMovements") is IMessageView viewNoPriceMovements)
			{
				var count = viewNoPriceMovements.GroupCount();
				PriceMovements = new NoPriceMovements[count];
				for (int i = 0; i < count; i++)
				{
					PriceMovements[i] = new();
					((IFixParser)PriceMovements[i]).Parse(viewNoPriceMovements.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPriceMovements":
				{
					value = PriceMovements;
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
			PriceMovements = null;
		}
	}
}
