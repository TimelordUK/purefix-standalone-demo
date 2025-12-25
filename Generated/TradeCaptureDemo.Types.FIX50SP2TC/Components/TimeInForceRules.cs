using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class TimeInForceRules : IFixComponent
	{
		public sealed partial class NoTimeInForceRules : IFixGroup
		{
			[TagDetails(Tag = 59, Type = TagType.String, Offset = 0, Required = false)]
			public string? TimeInForce {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (TimeInForce is not null) writer.WriteString(59, TimeInForce);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				TimeInForce = view.GetString(59);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "TimeInForce":
					{
						value = TimeInForce;
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
				TimeInForce = null;
			}
		}
		[Group(NoOfTag = 1239, Offset = 0, Required = false)]
		public NoTimeInForceRules[]? TimeInForceRulesItems {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (TimeInForceRulesItems is not null && TimeInForceRulesItems.Length != 0)
			{
				writer.WriteWholeNumber(1239, TimeInForceRulesItems.Length);
				for (int i = 0; i < TimeInForceRulesItems.Length; i++)
				{
					((IFixEncoder)TimeInForceRulesItems[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoTimeInForceRules") is IMessageView viewNoTimeInForceRules)
			{
				var count = viewNoTimeInForceRules.GroupCount();
				TimeInForceRulesItems = new NoTimeInForceRules[count];
				for (int i = 0; i < count; i++)
				{
					TimeInForceRulesItems[i] = new();
					((IFixParser)TimeInForceRulesItems[i]).Parse(viewNoTimeInForceRules.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoTimeInForceRules":
				{
					value = TimeInForceRulesItems;
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
			TimeInForceRulesItems = null;
		}
	}
}
