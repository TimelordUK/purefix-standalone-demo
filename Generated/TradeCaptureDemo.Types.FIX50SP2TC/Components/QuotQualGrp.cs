using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class QuotQualGrp : IFixComponent
	{
		public sealed partial class NoQuoteQualifiers : IFixGroup
		{
			[TagDetails(Tag = 695, Type = TagType.String, Offset = 0, Required = false)]
			public string? QuoteQualifier {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (QuoteQualifier is not null) writer.WriteString(695, QuoteQualifier);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				QuoteQualifier = view.GetString(695);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "QuoteQualifier":
					{
						value = QuoteQualifier;
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
				QuoteQualifier = null;
			}
		}
		[Group(NoOfTag = 735, Offset = 0, Required = false)]
		public NoQuoteQualifiers[]? QuoteQualifiers {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (QuoteQualifiers is not null && QuoteQualifiers.Length != 0)
			{
				writer.WriteWholeNumber(735, QuoteQualifiers.Length);
				for (int i = 0; i < QuoteQualifiers.Length; i++)
				{
					((IFixEncoder)QuoteQualifiers[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoQuoteQualifiers") is IMessageView viewNoQuoteQualifiers)
			{
				var count = viewNoQuoteQualifiers.GroupCount();
				QuoteQualifiers = new NoQuoteQualifiers[count];
				for (int i = 0; i < count; i++)
				{
					QuoteQualifiers[i] = new();
					((IFixParser)QuoteQualifiers[i]).Parse(viewNoQuoteQualifiers.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoQuoteQualifiers":
				{
					value = QuoteQualifiers;
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
			QuoteQualifiers = null;
		}
	}
}
