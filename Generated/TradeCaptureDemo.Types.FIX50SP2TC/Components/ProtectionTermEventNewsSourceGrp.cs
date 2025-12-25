using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ProtectionTermEventNewsSourceGrp : IFixComponent
	{
		public sealed partial class NoProtectionTermEventNewsSources : IFixGroup
		{
			[TagDetails(Tag = 40189, Type = TagType.String, Offset = 0, Required = false)]
			public string? ProtectionTermEventNewsSource {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ProtectionTermEventNewsSource is not null) writer.WriteString(40189, ProtectionTermEventNewsSource);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ProtectionTermEventNewsSource = view.GetString(40189);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ProtectionTermEventNewsSource":
					{
						value = ProtectionTermEventNewsSource;
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
				ProtectionTermEventNewsSource = null;
			}
		}
		[Group(NoOfTag = 40951, Offset = 0, Required = false)]
		public NoProtectionTermEventNewsSources[]? ProtectionTermEventNewsSources {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ProtectionTermEventNewsSources is not null && ProtectionTermEventNewsSources.Length != 0)
			{
				writer.WriteWholeNumber(40951, ProtectionTermEventNewsSources.Length);
				for (int i = 0; i < ProtectionTermEventNewsSources.Length; i++)
				{
					((IFixEncoder)ProtectionTermEventNewsSources[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoProtectionTermEventNewsSources") is IMessageView viewNoProtectionTermEventNewsSources)
			{
				var count = viewNoProtectionTermEventNewsSources.GroupCount();
				ProtectionTermEventNewsSources = new NoProtectionTermEventNewsSources[count];
				for (int i = 0; i < count; i++)
				{
					ProtectionTermEventNewsSources[i] = new();
					((IFixParser)ProtectionTermEventNewsSources[i]).Parse(viewNoProtectionTermEventNewsSources.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoProtectionTermEventNewsSources":
				{
					value = ProtectionTermEventNewsSources;
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
			ProtectionTermEventNewsSources = null;
		}
	}
}
