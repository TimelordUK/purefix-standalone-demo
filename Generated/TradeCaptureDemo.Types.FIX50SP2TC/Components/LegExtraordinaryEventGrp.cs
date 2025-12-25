using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegExtraordinaryEventGrp : IFixComponent
	{
		public sealed partial class NoLegExtraordinaryEvents : IFixGroup
		{
			[TagDetails(Tag = 42389, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegExtraordinaryEventType {get; set;}
			
			[TagDetails(Tag = 42390, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegExtraordinaryEventValue {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegExtraordinaryEventType is not null) writer.WriteString(42389, LegExtraordinaryEventType);
				if (LegExtraordinaryEventValue is not null) writer.WriteString(42390, LegExtraordinaryEventValue);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegExtraordinaryEventType = view.GetString(42389);
				LegExtraordinaryEventValue = view.GetString(42390);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegExtraordinaryEventType":
					{
						value = LegExtraordinaryEventType;
						break;
					}
					case "LegExtraordinaryEventValue":
					{
						value = LegExtraordinaryEventValue;
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
				LegExtraordinaryEventType = null;
				LegExtraordinaryEventValue = null;
			}
		}
		[Group(NoOfTag = 42388, Offset = 0, Required = false)]
		public NoLegExtraordinaryEvents[]? LegExtraordinaryEvents {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegExtraordinaryEvents is not null && LegExtraordinaryEvents.Length != 0)
			{
				writer.WriteWholeNumber(42388, LegExtraordinaryEvents.Length);
				for (int i = 0; i < LegExtraordinaryEvents.Length; i++)
				{
					((IFixEncoder)LegExtraordinaryEvents[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegExtraordinaryEvents") is IMessageView viewNoLegExtraordinaryEvents)
			{
				var count = viewNoLegExtraordinaryEvents.GroupCount();
				LegExtraordinaryEvents = new NoLegExtraordinaryEvents[count];
				for (int i = 0; i < count; i++)
				{
					LegExtraordinaryEvents[i] = new();
					((IFixParser)LegExtraordinaryEvents[i]).Parse(viewNoLegExtraordinaryEvents.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegExtraordinaryEvents":
				{
					value = LegExtraordinaryEvents;
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
			LegExtraordinaryEvents = null;
		}
	}
}
