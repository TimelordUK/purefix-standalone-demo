using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ProtectionTermEventQualifierGrp : IFixComponent
	{
		public sealed partial class NoProtectionTermEventQualifiers : IFixGroup
		{
			[TagDetails(Tag = 40200, Type = TagType.String, Offset = 0, Required = false)]
			public string? ProtectionTermEventQualifier {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ProtectionTermEventQualifier is not null) writer.WriteString(40200, ProtectionTermEventQualifier);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ProtectionTermEventQualifier = view.GetString(40200);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ProtectionTermEventQualifier":
					{
						value = ProtectionTermEventQualifier;
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
				ProtectionTermEventQualifier = null;
			}
		}
		[Group(NoOfTag = 40199, Offset = 0, Required = false)]
		public NoProtectionTermEventQualifiers[]? ProtectionTermEventQualifiers {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ProtectionTermEventQualifiers is not null && ProtectionTermEventQualifiers.Length != 0)
			{
				writer.WriteWholeNumber(40199, ProtectionTermEventQualifiers.Length);
				for (int i = 0; i < ProtectionTermEventQualifiers.Length; i++)
				{
					((IFixEncoder)ProtectionTermEventQualifiers[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoProtectionTermEventQualifiers") is IMessageView viewNoProtectionTermEventQualifiers)
			{
				var count = viewNoProtectionTermEventQualifiers.GroupCount();
				ProtectionTermEventQualifiers = new NoProtectionTermEventQualifiers[count];
				for (int i = 0; i < count; i++)
				{
					ProtectionTermEventQualifiers[i] = new();
					((IFixParser)ProtectionTermEventQualifiers[i]).Parse(viewNoProtectionTermEventQualifiers.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoProtectionTermEventQualifiers":
				{
					value = ProtectionTermEventQualifiers;
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
			ProtectionTermEventQualifiers = null;
		}
	}
}
