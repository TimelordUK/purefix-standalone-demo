using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class IOIQualGrp : IFixComponent
	{
		public sealed partial class NoIOIQualifiers : IFixGroup
		{
			[TagDetails(Tag = 104, Type = TagType.String, Offset = 0, Required = false)]
			public string? IOIQualifier {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (IOIQualifier is not null) writer.WriteString(104, IOIQualifier);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				IOIQualifier = view.GetString(104);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "IOIQualifier":
					{
						value = IOIQualifier;
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
				IOIQualifier = null;
			}
		}
		[Group(NoOfTag = 199, Offset = 0, Required = false)]
		public NoIOIQualifiers[]? IOIQualifiers {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (IOIQualifiers is not null && IOIQualifiers.Length != 0)
			{
				writer.WriteWholeNumber(199, IOIQualifiers.Length);
				for (int i = 0; i < IOIQualifiers.Length; i++)
				{
					((IFixEncoder)IOIQualifiers[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoIOIQualifiers") is IMessageView viewNoIOIQualifiers)
			{
				var count = viewNoIOIQualifiers.GroupCount();
				IOIQualifiers = new NoIOIQualifiers[count];
				for (int i = 0; i < count; i++)
				{
					IOIQualifiers[i] = new();
					((IFixParser)IOIQualifiers[i]).Parse(viewNoIOIQualifiers.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoIOIQualifiers":
				{
					value = IOIQualifiers;
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
			IOIQualifiers = null;
		}
	}
}
