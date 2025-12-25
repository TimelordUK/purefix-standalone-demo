using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingExtraordinaryEventGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingExtraordinaryEvents : IFixGroup
		{
			[TagDetails(Tag = 42885, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingExtraordinaryEventType {get; set;}
			
			[TagDetails(Tag = 42886, Type = TagType.String, Offset = 1, Required = false)]
			public string? UnderlyingExtraordinaryEventValue {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingExtraordinaryEventType is not null) writer.WriteString(42885, UnderlyingExtraordinaryEventType);
				if (UnderlyingExtraordinaryEventValue is not null) writer.WriteString(42886, UnderlyingExtraordinaryEventValue);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingExtraordinaryEventType = view.GetString(42885);
				UnderlyingExtraordinaryEventValue = view.GetString(42886);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingExtraordinaryEventType":
					{
						value = UnderlyingExtraordinaryEventType;
						break;
					}
					case "UnderlyingExtraordinaryEventValue":
					{
						value = UnderlyingExtraordinaryEventValue;
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
				UnderlyingExtraordinaryEventType = null;
				UnderlyingExtraordinaryEventValue = null;
			}
		}
		[Group(NoOfTag = 42884, Offset = 0, Required = false)]
		public NoUnderlyingExtraordinaryEvents[]? UnderlyingExtraordinaryEvents {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingExtraordinaryEvents is not null && UnderlyingExtraordinaryEvents.Length != 0)
			{
				writer.WriteWholeNumber(42884, UnderlyingExtraordinaryEvents.Length);
				for (int i = 0; i < UnderlyingExtraordinaryEvents.Length; i++)
				{
					((IFixEncoder)UnderlyingExtraordinaryEvents[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingExtraordinaryEvents") is IMessageView viewNoUnderlyingExtraordinaryEvents)
			{
				var count = viewNoUnderlyingExtraordinaryEvents.GroupCount();
				UnderlyingExtraordinaryEvents = new NoUnderlyingExtraordinaryEvents[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingExtraordinaryEvents[i] = new();
					((IFixParser)UnderlyingExtraordinaryEvents[i]).Parse(viewNoUnderlyingExtraordinaryEvents.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingExtraordinaryEvents":
				{
					value = UnderlyingExtraordinaryEvents;
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
			UnderlyingExtraordinaryEvents = null;
		}
	}
}
