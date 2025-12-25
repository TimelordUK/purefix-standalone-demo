using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class QuoteAttributeGrp : IFixComponent
	{
		public sealed partial class NoQuoteAttributes : IFixGroup
		{
			[TagDetails(Tag = 2707, Type = TagType.Int, Offset = 0, Required = false)]
			public int? QuoteAttributeType {get; set;}
			
			[TagDetails(Tag = 2708, Type = TagType.String, Offset = 1, Required = false)]
			public string? QuoteAttributeValue {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (QuoteAttributeType is not null) writer.WriteWholeNumber(2707, QuoteAttributeType.Value);
				if (QuoteAttributeValue is not null) writer.WriteString(2708, QuoteAttributeValue);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				QuoteAttributeType = view.GetInt32(2707);
				QuoteAttributeValue = view.GetString(2708);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "QuoteAttributeType":
					{
						value = QuoteAttributeType;
						break;
					}
					case "QuoteAttributeValue":
					{
						value = QuoteAttributeValue;
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
				QuoteAttributeType = null;
				QuoteAttributeValue = null;
			}
		}
		[Group(NoOfTag = 2706, Offset = 0, Required = false)]
		public NoQuoteAttributes[]? QuoteAttributes {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (QuoteAttributes is not null && QuoteAttributes.Length != 0)
			{
				writer.WriteWholeNumber(2706, QuoteAttributes.Length);
				for (int i = 0; i < QuoteAttributes.Length; i++)
				{
					((IFixEncoder)QuoteAttributes[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoQuoteAttributes") is IMessageView viewNoQuoteAttributes)
			{
				var count = viewNoQuoteAttributes.GroupCount();
				QuoteAttributes = new NoQuoteAttributes[count];
				for (int i = 0; i < count; i++)
				{
					QuoteAttributes[i] = new();
					((IFixParser)QuoteAttributes[i]).Parse(viewNoQuoteAttributes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoQuoteAttributes":
				{
					value = QuoteAttributes;
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
			QuoteAttributes = null;
		}
	}
}
