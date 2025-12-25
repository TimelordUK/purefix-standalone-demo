using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingComplexEventCreditEventQualifierGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingComplexEventCreditEventQualifiers : IFixGroup
		{
			[TagDetails(Tag = 41725, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingComplexEventCreditEventQualifier {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingComplexEventCreditEventQualifier is not null) writer.WriteString(41725, UnderlyingComplexEventCreditEventQualifier);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingComplexEventCreditEventQualifier = view.GetString(41725);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingComplexEventCreditEventQualifier":
					{
						value = UnderlyingComplexEventCreditEventQualifier;
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
				UnderlyingComplexEventCreditEventQualifier = null;
			}
		}
		[Group(NoOfTag = 41724, Offset = 0, Required = false)]
		public NoUnderlyingComplexEventCreditEventQualifiers[]? UnderlyingComplexEventCreditEventQualifiers {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingComplexEventCreditEventQualifiers is not null && UnderlyingComplexEventCreditEventQualifiers.Length != 0)
			{
				writer.WriteWholeNumber(41724, UnderlyingComplexEventCreditEventQualifiers.Length);
				for (int i = 0; i < UnderlyingComplexEventCreditEventQualifiers.Length; i++)
				{
					((IFixEncoder)UnderlyingComplexEventCreditEventQualifiers[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingComplexEventCreditEventQualifiers") is IMessageView viewNoUnderlyingComplexEventCreditEventQualifiers)
			{
				var count = viewNoUnderlyingComplexEventCreditEventQualifiers.GroupCount();
				UnderlyingComplexEventCreditEventQualifiers = new NoUnderlyingComplexEventCreditEventQualifiers[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingComplexEventCreditEventQualifiers[i] = new();
					((IFixParser)UnderlyingComplexEventCreditEventQualifiers[i]).Parse(viewNoUnderlyingComplexEventCreditEventQualifiers.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingComplexEventCreditEventQualifiers":
				{
					value = UnderlyingComplexEventCreditEventQualifiers;
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
			UnderlyingComplexEventCreditEventQualifiers = null;
		}
	}
}
