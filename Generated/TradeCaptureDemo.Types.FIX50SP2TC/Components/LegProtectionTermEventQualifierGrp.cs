using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegProtectionTermEventQualifierGrp : IFixComponent
	{
		public sealed partial class NoLegProtectionTermEventQualifiers : IFixGroup
		{
			[TagDetails(Tag = 41634, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegProtectionTermEventQualifier {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegProtectionTermEventQualifier is not null) writer.WriteString(41634, LegProtectionTermEventQualifier);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegProtectionTermEventQualifier = view.GetString(41634);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegProtectionTermEventQualifier":
					{
						value = LegProtectionTermEventQualifier;
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
				LegProtectionTermEventQualifier = null;
			}
		}
		[Group(NoOfTag = 41633, Offset = 0, Required = false)]
		public NoLegProtectionTermEventQualifiers[]? LegProtectionTermEventQualifiers {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegProtectionTermEventQualifiers is not null && LegProtectionTermEventQualifiers.Length != 0)
			{
				writer.WriteWholeNumber(41633, LegProtectionTermEventQualifiers.Length);
				for (int i = 0; i < LegProtectionTermEventQualifiers.Length; i++)
				{
					((IFixEncoder)LegProtectionTermEventQualifiers[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegProtectionTermEventQualifiers") is IMessageView viewNoLegProtectionTermEventQualifiers)
			{
				var count = viewNoLegProtectionTermEventQualifiers.GroupCount();
				LegProtectionTermEventQualifiers = new NoLegProtectionTermEventQualifiers[count];
				for (int i = 0; i < count; i++)
				{
					LegProtectionTermEventQualifiers[i] = new();
					((IFixParser)LegProtectionTermEventQualifiers[i]).Parse(viewNoLegProtectionTermEventQualifiers.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegProtectionTermEventQualifiers":
				{
					value = LegProtectionTermEventQualifiers;
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
			LegProtectionTermEventQualifiers = null;
		}
	}
}
