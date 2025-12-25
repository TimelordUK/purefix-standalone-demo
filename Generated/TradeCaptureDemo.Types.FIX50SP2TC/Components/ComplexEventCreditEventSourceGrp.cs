using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ComplexEventCreditEventSourceGrp : IFixComponent
	{
		public sealed partial class NoComplexEventCreditEventSources : IFixGroup
		{
			[TagDetails(Tag = 41030, Type = TagType.String, Offset = 0, Required = false)]
			public string? ComplexEventCreditEventSource {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ComplexEventCreditEventSource is not null) writer.WriteString(41030, ComplexEventCreditEventSource);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ComplexEventCreditEventSource = view.GetString(41030);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ComplexEventCreditEventSource":
					{
						value = ComplexEventCreditEventSource;
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
				ComplexEventCreditEventSource = null;
			}
		}
		[Group(NoOfTag = 41029, Offset = 0, Required = false)]
		public NoComplexEventCreditEventSources[]? ComplexEventCreditEventSources {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ComplexEventCreditEventSources is not null && ComplexEventCreditEventSources.Length != 0)
			{
				writer.WriteWholeNumber(41029, ComplexEventCreditEventSources.Length);
				for (int i = 0; i < ComplexEventCreditEventSources.Length; i++)
				{
					((IFixEncoder)ComplexEventCreditEventSources[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoComplexEventCreditEventSources") is IMessageView viewNoComplexEventCreditEventSources)
			{
				var count = viewNoComplexEventCreditEventSources.GroupCount();
				ComplexEventCreditEventSources = new NoComplexEventCreditEventSources[count];
				for (int i = 0; i < count; i++)
				{
					ComplexEventCreditEventSources[i] = new();
					((IFixParser)ComplexEventCreditEventSources[i]).Parse(viewNoComplexEventCreditEventSources.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoComplexEventCreditEventSources":
				{
					value = ComplexEventCreditEventSources;
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
			ComplexEventCreditEventSources = null;
		}
	}
}
