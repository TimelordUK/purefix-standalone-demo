using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ComplexEventCreditEventQualifierGrp : IFixComponent
	{
		public sealed partial class NoComplexEventCreditEventQualifiers : IFixGroup
		{
			[TagDetails(Tag = 41006, Type = TagType.String, Offset = 0, Required = false)]
			public string? ComplexEventCreditEventQualifier {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ComplexEventCreditEventQualifier is not null) writer.WriteString(41006, ComplexEventCreditEventQualifier);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ComplexEventCreditEventQualifier = view.GetString(41006);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ComplexEventCreditEventQualifier":
					{
						value = ComplexEventCreditEventQualifier;
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
				ComplexEventCreditEventQualifier = null;
			}
		}
		[Group(NoOfTag = 41005, Offset = 0, Required = false)]
		public NoComplexEventCreditEventQualifiers[]? ComplexEventCreditEventQualifiers {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ComplexEventCreditEventQualifiers is not null && ComplexEventCreditEventQualifiers.Length != 0)
			{
				writer.WriteWholeNumber(41005, ComplexEventCreditEventQualifiers.Length);
				for (int i = 0; i < ComplexEventCreditEventQualifiers.Length; i++)
				{
					((IFixEncoder)ComplexEventCreditEventQualifiers[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoComplexEventCreditEventQualifiers") is IMessageView viewNoComplexEventCreditEventQualifiers)
			{
				var count = viewNoComplexEventCreditEventQualifiers.GroupCount();
				ComplexEventCreditEventQualifiers = new NoComplexEventCreditEventQualifiers[count];
				for (int i = 0; i < count; i++)
				{
					ComplexEventCreditEventQualifiers[i] = new();
					((IFixParser)ComplexEventCreditEventQualifiers[i]).Parse(viewNoComplexEventCreditEventQualifiers.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoComplexEventCreditEventQualifiers":
				{
					value = ComplexEventCreditEventQualifiers;
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
			ComplexEventCreditEventQualifiers = null;
		}
	}
}
