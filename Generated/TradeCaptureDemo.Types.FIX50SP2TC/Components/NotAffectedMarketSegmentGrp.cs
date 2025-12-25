using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class NotAffectedMarketSegmentGrp : IFixComponent
	{
		public sealed partial class NoNotAffectedMarketSegments : IFixGroup
		{
			[TagDetails(Tag = 1794, Type = TagType.String, Offset = 0, Required = false)]
			public string? NotAffectedMarketSegmentID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (NotAffectedMarketSegmentID is not null) writer.WriteString(1794, NotAffectedMarketSegmentID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				NotAffectedMarketSegmentID = view.GetString(1794);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "NotAffectedMarketSegmentID":
					{
						value = NotAffectedMarketSegmentID;
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
				NotAffectedMarketSegmentID = null;
			}
		}
		[Group(NoOfTag = 1793, Offset = 0, Required = false)]
		public NoNotAffectedMarketSegments[]? NotAffectedMarketSegments {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (NotAffectedMarketSegments is not null && NotAffectedMarketSegments.Length != 0)
			{
				writer.WriteWholeNumber(1793, NotAffectedMarketSegments.Length);
				for (int i = 0; i < NotAffectedMarketSegments.Length; i++)
				{
					((IFixEncoder)NotAffectedMarketSegments[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoNotAffectedMarketSegments") is IMessageView viewNoNotAffectedMarketSegments)
			{
				var count = viewNoNotAffectedMarketSegments.GroupCount();
				NotAffectedMarketSegments = new NoNotAffectedMarketSegments[count];
				for (int i = 0; i < count; i++)
				{
					NotAffectedMarketSegments[i] = new();
					((IFixParser)NotAffectedMarketSegments[i]).Parse(viewNoNotAffectedMarketSegments.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoNotAffectedMarketSegments":
				{
					value = NotAffectedMarketSegments;
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
			NotAffectedMarketSegments = null;
		}
	}
}
