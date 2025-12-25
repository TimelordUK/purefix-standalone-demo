using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegComplexEventCreditEventQualifierGrp : IFixComponent
	{
		public sealed partial class NoLegComplexEventCreditEventQualifiers : IFixGroup
		{
			[TagDetails(Tag = 41375, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegComplexEventCreditEventQualifier {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegComplexEventCreditEventQualifier is not null) writer.WriteString(41375, LegComplexEventCreditEventQualifier);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegComplexEventCreditEventQualifier = view.GetString(41375);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegComplexEventCreditEventQualifier":
					{
						value = LegComplexEventCreditEventQualifier;
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
				LegComplexEventCreditEventQualifier = null;
			}
		}
		[Group(NoOfTag = 41374, Offset = 0, Required = false)]
		public NoLegComplexEventCreditEventQualifiers[]? LegComplexEventCreditEventQualifiers {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegComplexEventCreditEventQualifiers is not null && LegComplexEventCreditEventQualifiers.Length != 0)
			{
				writer.WriteWholeNumber(41374, LegComplexEventCreditEventQualifiers.Length);
				for (int i = 0; i < LegComplexEventCreditEventQualifiers.Length; i++)
				{
					((IFixEncoder)LegComplexEventCreditEventQualifiers[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegComplexEventCreditEventQualifiers") is IMessageView viewNoLegComplexEventCreditEventQualifiers)
			{
				var count = viewNoLegComplexEventCreditEventQualifiers.GroupCount();
				LegComplexEventCreditEventQualifiers = new NoLegComplexEventCreditEventQualifiers[count];
				for (int i = 0; i < count; i++)
				{
					LegComplexEventCreditEventQualifiers[i] = new();
					((IFixParser)LegComplexEventCreditEventQualifiers[i]).Parse(viewNoLegComplexEventCreditEventQualifiers.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegComplexEventCreditEventQualifiers":
				{
					value = LegComplexEventCreditEventQualifiers;
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
			LegComplexEventCreditEventQualifiers = null;
		}
	}
}
