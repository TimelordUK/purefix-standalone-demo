using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UndInstrmtGrp : IFixComponent
	{
		public sealed partial class NoUnderlyings : IFixGroup
		{
			[Component(Offset = 0, Required = false)]
			public UnderlyingInstrument? UnderlyingInstrument {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingInstrument is not null) ((IFixEncoder)UnderlyingInstrument).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				if (view.GetView("UnderlyingInstrument") is IMessageView viewUnderlyingInstrument)
				{
					UnderlyingInstrument = new();
					((IFixParser)UnderlyingInstrument).Parse(viewUnderlyingInstrument);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingInstrument":
					{
						value = UnderlyingInstrument;
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
				((IFixReset?)UnderlyingInstrument)?.Reset();
			}
		}
		[Group(NoOfTag = 711, Offset = 0, Required = false)]
		public NoUnderlyings[]? Underlyings {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Underlyings is not null && Underlyings.Length != 0)
			{
				writer.WriteWholeNumber(711, Underlyings.Length);
				for (int i = 0; i < Underlyings.Length; i++)
				{
					((IFixEncoder)Underlyings[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyings") is IMessageView viewNoUnderlyings)
			{
				var count = viewNoUnderlyings.GroupCount();
				Underlyings = new NoUnderlyings[count];
				for (int i = 0; i < count; i++)
				{
					Underlyings[i] = new();
					((IFixParser)Underlyings[i]).Parse(viewNoUnderlyings.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyings":
				{
					value = Underlyings;
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
			Underlyings = null;
		}
	}
}
