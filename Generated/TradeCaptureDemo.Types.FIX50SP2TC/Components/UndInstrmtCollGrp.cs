using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UndInstrmtCollGrp : IFixComponent
	{
		public sealed partial class NoUnderlyings : IFixGroup
		{
			[Component(Offset = 0, Required = false)]
			public UnderlyingInstrument? UnderlyingInstrument {get; set;}
			
			[TagDetails(Tag = 944, Type = TagType.Int, Offset = 1, Required = false)]
			public int? CollAction {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingInstrument is not null) ((IFixEncoder)UnderlyingInstrument).Encode(writer);
				if (CollAction is not null) writer.WriteWholeNumber(944, CollAction.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				if (view.GetView("UnderlyingInstrument") is IMessageView viewUnderlyingInstrument)
				{
					UnderlyingInstrument = new();
					((IFixParser)UnderlyingInstrument).Parse(viewUnderlyingInstrument);
				}
				CollAction = view.GetInt32(944);
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
					case "CollAction":
					{
						value = CollAction;
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
				CollAction = null;
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
