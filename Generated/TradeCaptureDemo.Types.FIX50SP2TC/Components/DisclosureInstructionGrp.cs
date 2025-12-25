using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class DisclosureInstructionGrp : IFixComponent
	{
		public sealed partial class NoDisclosureInstructions : IFixGroup
		{
			[TagDetails(Tag = 1813, Type = TagType.Int, Offset = 0, Required = false)]
			public int? DisclosureType {get; set;}
			
			[TagDetails(Tag = 1814, Type = TagType.Int, Offset = 1, Required = false)]
			public int? DisclosureInstruction {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (DisclosureType is not null) writer.WriteWholeNumber(1813, DisclosureType.Value);
				if (DisclosureInstruction is not null) writer.WriteWholeNumber(1814, DisclosureInstruction.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				DisclosureType = view.GetInt32(1813);
				DisclosureInstruction = view.GetInt32(1814);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "DisclosureType":
					{
						value = DisclosureType;
						break;
					}
					case "DisclosureInstruction":
					{
						value = DisclosureInstruction;
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
				DisclosureType = null;
				DisclosureInstruction = null;
			}
		}
		[Group(NoOfTag = 1812, Offset = 0, Required = false)]
		public NoDisclosureInstructions[]? DisclosureInstructions {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (DisclosureInstructions is not null && DisclosureInstructions.Length != 0)
			{
				writer.WriteWholeNumber(1812, DisclosureInstructions.Length);
				for (int i = 0; i < DisclosureInstructions.Length; i++)
				{
					((IFixEncoder)DisclosureInstructions[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoDisclosureInstructions") is IMessageView viewNoDisclosureInstructions)
			{
				var count = viewNoDisclosureInstructions.GroupCount();
				DisclosureInstructions = new NoDisclosureInstructions[count];
				for (int i = 0; i < count; i++)
				{
					DisclosureInstructions[i] = new();
					((IFixParser)DisclosureInstructions[i]).Parse(viewNoDisclosureInstructions.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoDisclosureInstructions":
				{
					value = DisclosureInstructions;
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
			DisclosureInstructions = null;
		}
	}
}
