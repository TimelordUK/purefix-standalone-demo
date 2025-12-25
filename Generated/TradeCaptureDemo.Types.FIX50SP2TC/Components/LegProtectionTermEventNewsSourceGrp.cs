using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegProtectionTermEventNewsSourceGrp : IFixComponent
	{
		public sealed partial class NoLegProtectionTermEventNewsSources : IFixGroup
		{
			[TagDetails(Tag = 41615, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegProtectionTermEventNewsSource {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegProtectionTermEventNewsSource is not null) writer.WriteString(41615, LegProtectionTermEventNewsSource);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegProtectionTermEventNewsSource = view.GetString(41615);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegProtectionTermEventNewsSource":
					{
						value = LegProtectionTermEventNewsSource;
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
				LegProtectionTermEventNewsSource = null;
			}
		}
		[Group(NoOfTag = 41614, Offset = 0, Required = false)]
		public NoLegProtectionTermEventNewsSources[]? LegProtectionTermEventNewsSources {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegProtectionTermEventNewsSources is not null && LegProtectionTermEventNewsSources.Length != 0)
			{
				writer.WriteWholeNumber(41614, LegProtectionTermEventNewsSources.Length);
				for (int i = 0; i < LegProtectionTermEventNewsSources.Length; i++)
				{
					((IFixEncoder)LegProtectionTermEventNewsSources[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegProtectionTermEventNewsSources") is IMessageView viewNoLegProtectionTermEventNewsSources)
			{
				var count = viewNoLegProtectionTermEventNewsSources.GroupCount();
				LegProtectionTermEventNewsSources = new NoLegProtectionTermEventNewsSources[count];
				for (int i = 0; i < count; i++)
				{
					LegProtectionTermEventNewsSources[i] = new();
					((IFixParser)LegProtectionTermEventNewsSources[i]).Parse(viewNoLegProtectionTermEventNewsSources.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegProtectionTermEventNewsSources":
				{
					value = LegProtectionTermEventNewsSources;
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
			LegProtectionTermEventNewsSources = null;
		}
	}
}
