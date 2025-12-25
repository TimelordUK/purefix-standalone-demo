using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegStipulations : IFixComponent
	{
		public sealed partial class NoLegStipulations : IFixGroup
		{
			[TagDetails(Tag = 688, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegStipulationType {get; set;}
			
			[TagDetails(Tag = 689, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegStipulationValue {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegStipulationType is not null) writer.WriteString(688, LegStipulationType);
				if (LegStipulationValue is not null) writer.WriteString(689, LegStipulationValue);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegStipulationType = view.GetString(688);
				LegStipulationValue = view.GetString(689);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegStipulationType":
					{
						value = LegStipulationType;
						break;
					}
					case "LegStipulationValue":
					{
						value = LegStipulationValue;
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
				LegStipulationType = null;
				LegStipulationValue = null;
			}
		}
		[Group(NoOfTag = 683, Offset = 0, Required = false)]
		public NoLegStipulations[]? LegStipulationsItems {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegStipulationsItems is not null && LegStipulationsItems.Length != 0)
			{
				writer.WriteWholeNumber(683, LegStipulationsItems.Length);
				for (int i = 0; i < LegStipulationsItems.Length; i++)
				{
					((IFixEncoder)LegStipulationsItems[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegStipulations") is IMessageView viewNoLegStipulations)
			{
				var count = viewNoLegStipulations.GroupCount();
				LegStipulationsItems = new NoLegStipulations[count];
				for (int i = 0; i < count; i++)
				{
					LegStipulationsItems[i] = new();
					((IFixParser)LegStipulationsItems[i]).Parse(viewNoLegStipulations.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegStipulations":
				{
					value = LegStipulationsItems;
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
			LegStipulationsItems = null;
		}
	}
}
