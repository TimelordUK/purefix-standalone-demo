using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PriceQualifierGrp : IFixComponent
	{
		public sealed partial class NoPriceQualifiers : IFixGroup
		{
			[TagDetails(Tag = 2710, Type = TagType.Int, Offset = 0, Required = false)]
			public int? PriceQualifier {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PriceQualifier is not null) writer.WriteWholeNumber(2710, PriceQualifier.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PriceQualifier = view.GetInt32(2710);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PriceQualifier":
					{
						value = PriceQualifier;
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
				PriceQualifier = null;
			}
		}
		[Group(NoOfTag = 2709, Offset = 0, Required = false)]
		public NoPriceQualifiers[]? PriceQualifiers {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PriceQualifiers is not null && PriceQualifiers.Length != 0)
			{
				writer.WriteWholeNumber(2709, PriceQualifiers.Length);
				for (int i = 0; i < PriceQualifiers.Length; i++)
				{
					((IFixEncoder)PriceQualifiers[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPriceQualifiers") is IMessageView viewNoPriceQualifiers)
			{
				var count = viewNoPriceQualifiers.GroupCount();
				PriceQualifiers = new NoPriceQualifiers[count];
				for (int i = 0; i < count; i++)
				{
					PriceQualifiers[i] = new();
					((IFixParser)PriceQualifiers[i]).Parse(viewNoPriceQualifiers.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPriceQualifiers":
				{
					value = PriceQualifiers;
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
			PriceQualifiers = null;
		}
	}
}
