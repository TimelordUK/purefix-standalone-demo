using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class OrdTypeRules : IFixComponent
	{
		public sealed partial class NoOrdTypeRules : IFixGroup
		{
			[TagDetails(Tag = 40, Type = TagType.String, Offset = 0, Required = false)]
			public string? OrdType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (OrdType is not null) writer.WriteString(40, OrdType);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				OrdType = view.GetString(40);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "OrdType":
					{
						value = OrdType;
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
				OrdType = null;
			}
		}
		[Group(NoOfTag = 1237, Offset = 0, Required = false)]
		public NoOrdTypeRules[]? OrdTypeRulesItems {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (OrdTypeRulesItems is not null && OrdTypeRulesItems.Length != 0)
			{
				writer.WriteWholeNumber(1237, OrdTypeRulesItems.Length);
				for (int i = 0; i < OrdTypeRulesItems.Length; i++)
				{
					((IFixEncoder)OrdTypeRulesItems[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoOrdTypeRules") is IMessageView viewNoOrdTypeRules)
			{
				var count = viewNoOrdTypeRules.GroupCount();
				OrdTypeRulesItems = new NoOrdTypeRules[count];
				for (int i = 0; i < count; i++)
				{
					OrdTypeRulesItems[i] = new();
					((IFixParser)OrdTypeRulesItems[i]).Parse(viewNoOrdTypeRules.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoOrdTypeRules":
				{
					value = OrdTypeRulesItems;
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
			OrdTypeRulesItems = null;
		}
	}
}
