using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingProtectionTermEventNewsSourceGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingProtectionTermEventNewsSources : IFixGroup
		{
			[TagDetails(Tag = 42091, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingProtectionTermEventNewsSource {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingProtectionTermEventNewsSource is not null) writer.WriteString(42091, UnderlyingProtectionTermEventNewsSource);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingProtectionTermEventNewsSource = view.GetString(42091);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingProtectionTermEventNewsSource":
					{
						value = UnderlyingProtectionTermEventNewsSource;
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
				UnderlyingProtectionTermEventNewsSource = null;
			}
		}
		[Group(NoOfTag = 42090, Offset = 0, Required = false)]
		public NoUnderlyingProtectionTermEventNewsSources[]? UnderlyingProtectionTermEventNewsSources {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingProtectionTermEventNewsSources is not null && UnderlyingProtectionTermEventNewsSources.Length != 0)
			{
				writer.WriteWholeNumber(42090, UnderlyingProtectionTermEventNewsSources.Length);
				for (int i = 0; i < UnderlyingProtectionTermEventNewsSources.Length; i++)
				{
					((IFixEncoder)UnderlyingProtectionTermEventNewsSources[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingProtectionTermEventNewsSources") is IMessageView viewNoUnderlyingProtectionTermEventNewsSources)
			{
				var count = viewNoUnderlyingProtectionTermEventNewsSources.GroupCount();
				UnderlyingProtectionTermEventNewsSources = new NoUnderlyingProtectionTermEventNewsSources[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingProtectionTermEventNewsSources[i] = new();
					((IFixParser)UnderlyingProtectionTermEventNewsSources[i]).Parse(viewNoUnderlyingProtectionTermEventNewsSources.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingProtectionTermEventNewsSources":
				{
					value = UnderlyingProtectionTermEventNewsSources;
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
			UnderlyingProtectionTermEventNewsSources = null;
		}
	}
}
