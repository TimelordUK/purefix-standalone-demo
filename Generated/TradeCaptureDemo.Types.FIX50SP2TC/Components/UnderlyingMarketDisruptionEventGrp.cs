using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingMarketDisruptionEventGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingMarketDisruptionEvents : IFixGroup
		{
			[TagDetails(Tag = 41865, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingMarketDisruptionEvent {get; set;}
			
			[TagDetails(Tag = 41338, Type = TagType.String, Offset = 1, Required = false)]
			public string? UnderlyingMarketDisruptionValue {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingMarketDisruptionEvent is not null) writer.WriteString(41865, UnderlyingMarketDisruptionEvent);
				if (UnderlyingMarketDisruptionValue is not null) writer.WriteString(41338, UnderlyingMarketDisruptionValue);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingMarketDisruptionEvent = view.GetString(41865);
				UnderlyingMarketDisruptionValue = view.GetString(41338);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingMarketDisruptionEvent":
					{
						value = UnderlyingMarketDisruptionEvent;
						break;
					}
					case "UnderlyingMarketDisruptionValue":
					{
						value = UnderlyingMarketDisruptionValue;
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
				UnderlyingMarketDisruptionEvent = null;
				UnderlyingMarketDisruptionValue = null;
			}
		}
		[Group(NoOfTag = 41864, Offset = 0, Required = false)]
		public NoUnderlyingMarketDisruptionEvents[]? UnderlyingMarketDisruptionEvents {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingMarketDisruptionEvents is not null && UnderlyingMarketDisruptionEvents.Length != 0)
			{
				writer.WriteWholeNumber(41864, UnderlyingMarketDisruptionEvents.Length);
				for (int i = 0; i < UnderlyingMarketDisruptionEvents.Length; i++)
				{
					((IFixEncoder)UnderlyingMarketDisruptionEvents[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingMarketDisruptionEvents") is IMessageView viewNoUnderlyingMarketDisruptionEvents)
			{
				var count = viewNoUnderlyingMarketDisruptionEvents.GroupCount();
				UnderlyingMarketDisruptionEvents = new NoUnderlyingMarketDisruptionEvents[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingMarketDisruptionEvents[i] = new();
					((IFixParser)UnderlyingMarketDisruptionEvents[i]).Parse(viewNoUnderlyingMarketDisruptionEvents.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingMarketDisruptionEvents":
				{
					value = UnderlyingMarketDisruptionEvents;
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
			UnderlyingMarketDisruptionEvents = null;
		}
	}
}
