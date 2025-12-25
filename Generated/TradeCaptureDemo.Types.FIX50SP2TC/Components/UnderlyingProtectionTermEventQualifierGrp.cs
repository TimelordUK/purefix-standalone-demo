using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingProtectionTermEventQualifierGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingProtectionTermEventQualifiers : IFixGroup
		{
			[TagDetails(Tag = 42086, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingProtectionTermEventQualifier {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingProtectionTermEventQualifier is not null) writer.WriteString(42086, UnderlyingProtectionTermEventQualifier);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingProtectionTermEventQualifier = view.GetString(42086);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingProtectionTermEventQualifier":
					{
						value = UnderlyingProtectionTermEventQualifier;
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
				UnderlyingProtectionTermEventQualifier = null;
			}
		}
		[Group(NoOfTag = 42085, Offset = 0, Required = false)]
		public NoUnderlyingProtectionTermEventQualifiers[]? UnderlyingProtectionTermEventQualifiers {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingProtectionTermEventQualifiers is not null && UnderlyingProtectionTermEventQualifiers.Length != 0)
			{
				writer.WriteWholeNumber(42085, UnderlyingProtectionTermEventQualifiers.Length);
				for (int i = 0; i < UnderlyingProtectionTermEventQualifiers.Length; i++)
				{
					((IFixEncoder)UnderlyingProtectionTermEventQualifiers[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingProtectionTermEventQualifiers") is IMessageView viewNoUnderlyingProtectionTermEventQualifiers)
			{
				var count = viewNoUnderlyingProtectionTermEventQualifiers.GroupCount();
				UnderlyingProtectionTermEventQualifiers = new NoUnderlyingProtectionTermEventQualifiers[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingProtectionTermEventQualifiers[i] = new();
					((IFixParser)UnderlyingProtectionTermEventQualifiers[i]).Parse(viewNoUnderlyingProtectionTermEventQualifiers.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingProtectionTermEventQualifiers":
				{
					value = UnderlyingProtectionTermEventQualifiers;
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
			UnderlyingProtectionTermEventQualifiers = null;
		}
	}
}
