using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingComplexEventCreditEventSourceGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingComplexEventCreditEventSources : IFixGroup
		{
			[TagDetails(Tag = 41749, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingComplexEventCreditEventSource {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingComplexEventCreditEventSource is not null) writer.WriteString(41749, UnderlyingComplexEventCreditEventSource);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingComplexEventCreditEventSource = view.GetString(41749);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingComplexEventCreditEventSource":
					{
						value = UnderlyingComplexEventCreditEventSource;
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
				UnderlyingComplexEventCreditEventSource = null;
			}
		}
		[Group(NoOfTag = 41748, Offset = 0, Required = false)]
		public NoUnderlyingComplexEventCreditEventSources[]? UnderlyingComplexEventCreditEventSources {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingComplexEventCreditEventSources is not null && UnderlyingComplexEventCreditEventSources.Length != 0)
			{
				writer.WriteWholeNumber(41748, UnderlyingComplexEventCreditEventSources.Length);
				for (int i = 0; i < UnderlyingComplexEventCreditEventSources.Length; i++)
				{
					((IFixEncoder)UnderlyingComplexEventCreditEventSources[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingComplexEventCreditEventSources") is IMessageView viewNoUnderlyingComplexEventCreditEventSources)
			{
				var count = viewNoUnderlyingComplexEventCreditEventSources.GroupCount();
				UnderlyingComplexEventCreditEventSources = new NoUnderlyingComplexEventCreditEventSources[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingComplexEventCreditEventSources[i] = new();
					((IFixParser)UnderlyingComplexEventCreditEventSources[i]).Parse(viewNoUnderlyingComplexEventCreditEventSources.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingComplexEventCreditEventSources":
				{
					value = UnderlyingComplexEventCreditEventSources;
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
			UnderlyingComplexEventCreditEventSources = null;
		}
	}
}
