using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ExecInstRules : IFixComponent
	{
		public sealed partial class NoExecInstRules : IFixGroup
		{
			[TagDetails(Tag = 1308, Type = TagType.String, Offset = 0, Required = false)]
			public string? ExecInstValue {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ExecInstValue is not null) writer.WriteString(1308, ExecInstValue);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ExecInstValue = view.GetString(1308);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ExecInstValue":
					{
						value = ExecInstValue;
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
				ExecInstValue = null;
			}
		}
		[Group(NoOfTag = 1232, Offset = 0, Required = false)]
		public NoExecInstRules[]? ExecInstRulesItems {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ExecInstRulesItems is not null && ExecInstRulesItems.Length != 0)
			{
				writer.WriteWholeNumber(1232, ExecInstRulesItems.Length);
				for (int i = 0; i < ExecInstRulesItems.Length; i++)
				{
					((IFixEncoder)ExecInstRulesItems[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoExecInstRules") is IMessageView viewNoExecInstRules)
			{
				var count = viewNoExecInstRules.GroupCount();
				ExecInstRulesItems = new NoExecInstRules[count];
				for (int i = 0; i < count; i++)
				{
					ExecInstRulesItems[i] = new();
					((IFixParser)ExecInstRulesItems[i]).Parse(viewNoExecInstRules.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoExecInstRules":
				{
					value = ExecInstRulesItems;
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
			ExecInstRulesItems = null;
		}
	}
}
