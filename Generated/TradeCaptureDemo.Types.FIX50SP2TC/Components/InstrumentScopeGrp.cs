using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class InstrumentScopeGrp : IFixComponent
	{
		public sealed partial class NoInstrumentScopes : IFixGroup
		{
			[TagDetails(Tag = 1535, Type = TagType.Int, Offset = 0, Required = false)]
			public int? InstrumentScopeOperator {get; set;}
			
			[Component(Offset = 1, Required = false)]
			public InstrumentScope? InstrumentScope {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (InstrumentScopeOperator is not null) writer.WriteWholeNumber(1535, InstrumentScopeOperator.Value);
				if (InstrumentScope is not null) ((IFixEncoder)InstrumentScope).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				InstrumentScopeOperator = view.GetInt32(1535);
				if (view.GetView("InstrumentScope") is IMessageView viewInstrumentScope)
				{
					InstrumentScope = new();
					((IFixParser)InstrumentScope).Parse(viewInstrumentScope);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "InstrumentScopeOperator":
					{
						value = InstrumentScopeOperator;
						break;
					}
					case "InstrumentScope":
					{
						value = InstrumentScope;
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
				InstrumentScopeOperator = null;
				((IFixReset?)InstrumentScope)?.Reset();
			}
		}
		[Group(NoOfTag = 1656, Offset = 0, Required = false)]
		public NoInstrumentScopes[]? InstrumentScopes {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (InstrumentScopes is not null && InstrumentScopes.Length != 0)
			{
				writer.WriteWholeNumber(1656, InstrumentScopes.Length);
				for (int i = 0; i < InstrumentScopes.Length; i++)
				{
					((IFixEncoder)InstrumentScopes[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoInstrumentScopes") is IMessageView viewNoInstrumentScopes)
			{
				var count = viewNoInstrumentScopes.GroupCount();
				InstrumentScopes = new NoInstrumentScopes[count];
				for (int i = 0; i < count; i++)
				{
					InstrumentScopes[i] = new();
					((IFixParser)InstrumentScopes[i]).Parse(viewNoInstrumentScopes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoInstrumentScopes":
				{
					value = InstrumentScopes;
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
			InstrumentScopes = null;
		}
	}
}
