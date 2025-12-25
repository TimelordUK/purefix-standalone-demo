using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class TradeCapLegUnderlyingsGrp : IFixComponent
	{
		public sealed partial class NoOfLegUnderlyings : IFixGroup
		{
			[Component(Offset = 0, Required = false)]
			public UnderlyingLegInstrument? UnderlyingLegInstrument {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingLegInstrument is not null) ((IFixEncoder)UnderlyingLegInstrument).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				if (view.GetView("UnderlyingLegInstrument") is IMessageView viewUnderlyingLegInstrument)
				{
					UnderlyingLegInstrument = new();
					((IFixParser)UnderlyingLegInstrument).Parse(viewUnderlyingLegInstrument);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingLegInstrument":
					{
						value = UnderlyingLegInstrument;
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
				((IFixReset?)UnderlyingLegInstrument)?.Reset();
			}
		}
		[Group(NoOfTag = 1342, Offset = 0, Required = false)]
		public NoOfLegUnderlyings[]? OfLegUnderlyings {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (OfLegUnderlyings is not null && OfLegUnderlyings.Length != 0)
			{
				writer.WriteWholeNumber(1342, OfLegUnderlyings.Length);
				for (int i = 0; i < OfLegUnderlyings.Length; i++)
				{
					((IFixEncoder)OfLegUnderlyings[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoOfLegUnderlyings") is IMessageView viewNoOfLegUnderlyings)
			{
				var count = viewNoOfLegUnderlyings.GroupCount();
				OfLegUnderlyings = new NoOfLegUnderlyings[count];
				for (int i = 0; i < count; i++)
				{
					OfLegUnderlyings[i] = new();
					((IFixParser)OfLegUnderlyings[i]).Parse(viewNoOfLegUnderlyings.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoOfLegUnderlyings":
				{
					value = OfLegUnderlyings;
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
			OfLegUnderlyings = null;
		}
	}
}
