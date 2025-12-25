using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegMarketDisruptionEventGrp : IFixComponent
	{
		public sealed partial class NoLegMarketDisruptionEvents : IFixGroup
		{
			[TagDetails(Tag = 41468, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegMarketDisruptionEvent {get; set;}
			
			[TagDetails(Tag = 40223, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegMarketDisruptionValue {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegMarketDisruptionEvent is not null) writer.WriteString(41468, LegMarketDisruptionEvent);
				if (LegMarketDisruptionValue is not null) writer.WriteString(40223, LegMarketDisruptionValue);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegMarketDisruptionEvent = view.GetString(41468);
				LegMarketDisruptionValue = view.GetString(40223);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegMarketDisruptionEvent":
					{
						value = LegMarketDisruptionEvent;
						break;
					}
					case "LegMarketDisruptionValue":
					{
						value = LegMarketDisruptionValue;
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
				LegMarketDisruptionEvent = null;
				LegMarketDisruptionValue = null;
			}
		}
		[Group(NoOfTag = 41467, Offset = 0, Required = false)]
		public NoLegMarketDisruptionEvents[]? LegMarketDisruptionEvents {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegMarketDisruptionEvents is not null && LegMarketDisruptionEvents.Length != 0)
			{
				writer.WriteWholeNumber(41467, LegMarketDisruptionEvents.Length);
				for (int i = 0; i < LegMarketDisruptionEvents.Length; i++)
				{
					((IFixEncoder)LegMarketDisruptionEvents[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegMarketDisruptionEvents") is IMessageView viewNoLegMarketDisruptionEvents)
			{
				var count = viewNoLegMarketDisruptionEvents.GroupCount();
				LegMarketDisruptionEvents = new NoLegMarketDisruptionEvents[count];
				for (int i = 0; i < count; i++)
				{
					LegMarketDisruptionEvents[i] = new();
					((IFixParser)LegMarketDisruptionEvents[i]).Parse(viewNoLegMarketDisruptionEvents.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegMarketDisruptionEvents":
				{
					value = LegMarketDisruptionEvents;
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
			LegMarketDisruptionEvents = null;
		}
	}
}
