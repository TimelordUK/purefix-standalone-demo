using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class Stipulations : IFixComponent
	{
		public sealed partial class NoStipulations : IFixGroup
		{
			[TagDetails(Tag = 233, Type = TagType.String, Offset = 0, Required = false)]
			public string? StipulationType {get; set;}
			
			[TagDetails(Tag = 234, Type = TagType.String, Offset = 1, Required = false)]
			public string? StipulationValue {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (StipulationType is not null) writer.WriteString(233, StipulationType);
				if (StipulationValue is not null) writer.WriteString(234, StipulationValue);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				StipulationType = view.GetString(233);
				StipulationValue = view.GetString(234);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "StipulationType":
					{
						value = StipulationType;
						break;
					}
					case "StipulationValue":
					{
						value = StipulationValue;
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
				StipulationType = null;
				StipulationValue = null;
			}
		}
		[Group(NoOfTag = 232, Offset = 0, Required = false)]
		public NoStipulations[]? StipulationsItems {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (StipulationsItems is not null && StipulationsItems.Length != 0)
			{
				writer.WriteWholeNumber(232, StipulationsItems.Length);
				for (int i = 0; i < StipulationsItems.Length; i++)
				{
					((IFixEncoder)StipulationsItems[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoStipulations") is IMessageView viewNoStipulations)
			{
				var count = viewNoStipulations.GroupCount();
				StipulationsItems = new NoStipulations[count];
				for (int i = 0; i < count; i++)
				{
					StipulationsItems[i] = new();
					((IFixParser)StipulationsItems[i]).Parse(viewNoStipulations.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoStipulations":
				{
					value = StipulationsItems;
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
			StipulationsItems = null;
		}
	}
}
