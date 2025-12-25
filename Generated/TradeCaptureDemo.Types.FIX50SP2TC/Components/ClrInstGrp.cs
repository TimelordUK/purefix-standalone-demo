using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ClrInstGrp : IFixComponent
	{
		public sealed partial class NoClearingInstructions : IFixGroup
		{
			[TagDetails(Tag = 577, Type = TagType.Int, Offset = 0, Required = false)]
			public int? ClearingInstruction {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ClearingInstruction is not null) writer.WriteWholeNumber(577, ClearingInstruction.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ClearingInstruction = view.GetInt32(577);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ClearingInstruction":
					{
						value = ClearingInstruction;
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
				ClearingInstruction = null;
			}
		}
		[Group(NoOfTag = 576, Offset = 0, Required = false)]
		public NoClearingInstructions[]? ClearingInstructions {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ClearingInstructions is not null && ClearingInstructions.Length != 0)
			{
				writer.WriteWholeNumber(576, ClearingInstructions.Length);
				for (int i = 0; i < ClearingInstructions.Length; i++)
				{
					((IFixEncoder)ClearingInstructions[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoClearingInstructions") is IMessageView viewNoClearingInstructions)
			{
				var count = viewNoClearingInstructions.GroupCount();
				ClearingInstructions = new NoClearingInstructions[count];
				for (int i = 0; i < count; i++)
				{
					ClearingInstructions[i] = new();
					((IFixParser)ClearingInstructions[i]).Parse(viewNoClearingInstructions.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoClearingInstructions":
				{
					value = ClearingInstructions;
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
			ClearingInstructions = null;
		}
	}
}
