using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class IndexRollMonthGrp : IFixComponent
	{
		public sealed partial class NoIndexRollMonths : IFixGroup
		{
			[TagDetails(Tag = 2733, Type = TagType.String, Offset = 0, Required = false)]
			public string? IndexRollMonth {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (IndexRollMonth is not null) writer.WriteString(2733, IndexRollMonth);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				IndexRollMonth = view.GetString(2733);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "IndexRollMonth":
					{
						value = IndexRollMonth;
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
				IndexRollMonth = null;
			}
		}
		[Group(NoOfTag = 2734, Offset = 0, Required = false)]
		public NoIndexRollMonths[]? IndexRollMonths {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (IndexRollMonths is not null && IndexRollMonths.Length != 0)
			{
				writer.WriteWholeNumber(2734, IndexRollMonths.Length);
				for (int i = 0; i < IndexRollMonths.Length; i++)
				{
					((IFixEncoder)IndexRollMonths[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoIndexRollMonths") is IMessageView viewNoIndexRollMonths)
			{
				var count = viewNoIndexRollMonths.GroupCount();
				IndexRollMonths = new NoIndexRollMonths[count];
				for (int i = 0; i < count; i++)
				{
					IndexRollMonths[i] = new();
					((IFixParser)IndexRollMonths[i]).Parse(viewNoIndexRollMonths.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoIndexRollMonths":
				{
					value = IndexRollMonths;
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
			IndexRollMonths = null;
		}
	}
}
