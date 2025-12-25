using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegComplexEventCreditEventSourceGrp : IFixComponent
	{
		public sealed partial class NoLegComplexEventCreditEventSources : IFixGroup
		{
			[TagDetails(Tag = 41399, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegComplexEventCreditEventSource {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegComplexEventCreditEventSource is not null) writer.WriteString(41399, LegComplexEventCreditEventSource);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegComplexEventCreditEventSource = view.GetString(41399);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegComplexEventCreditEventSource":
					{
						value = LegComplexEventCreditEventSource;
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
				LegComplexEventCreditEventSource = null;
			}
		}
		[Group(NoOfTag = 41398, Offset = 0, Required = false)]
		public NoLegComplexEventCreditEventSources[]? LegComplexEventCreditEventSources {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegComplexEventCreditEventSources is not null && LegComplexEventCreditEventSources.Length != 0)
			{
				writer.WriteWholeNumber(41398, LegComplexEventCreditEventSources.Length);
				for (int i = 0; i < LegComplexEventCreditEventSources.Length; i++)
				{
					((IFixEncoder)LegComplexEventCreditEventSources[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegComplexEventCreditEventSources") is IMessageView viewNoLegComplexEventCreditEventSources)
			{
				var count = viewNoLegComplexEventCreditEventSources.GroupCount();
				LegComplexEventCreditEventSources = new NoLegComplexEventCreditEventSources[count];
				for (int i = 0; i < count; i++)
				{
					LegComplexEventCreditEventSources[i] = new();
					((IFixParser)LegComplexEventCreditEventSources[i]).Parse(viewNoLegComplexEventCreditEventSources.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegComplexEventCreditEventSources":
				{
					value = LegComplexEventCreditEventSources;
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
			LegComplexEventCreditEventSources = null;
		}
	}
}
