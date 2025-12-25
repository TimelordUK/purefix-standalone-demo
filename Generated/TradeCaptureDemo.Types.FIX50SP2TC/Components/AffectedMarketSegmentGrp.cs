using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class AffectedMarketSegmentGrp : IFixComponent
	{
		public sealed partial class NoAffectedMarketSegments : IFixGroup
		{
			[TagDetails(Tag = 1792, Type = TagType.String, Offset = 0, Required = false)]
			public string? AffectedMarketSegmentID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (AffectedMarketSegmentID is not null) writer.WriteString(1792, AffectedMarketSegmentID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				AffectedMarketSegmentID = view.GetString(1792);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "AffectedMarketSegmentID":
					{
						value = AffectedMarketSegmentID;
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
				AffectedMarketSegmentID = null;
			}
		}
		[Group(NoOfTag = 1791, Offset = 0, Required = false)]
		public NoAffectedMarketSegments[]? AffectedMarketSegments {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (AffectedMarketSegments is not null && AffectedMarketSegments.Length != 0)
			{
				writer.WriteWholeNumber(1791, AffectedMarketSegments.Length);
				for (int i = 0; i < AffectedMarketSegments.Length; i++)
				{
					((IFixEncoder)AffectedMarketSegments[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoAffectedMarketSegments") is IMessageView viewNoAffectedMarketSegments)
			{
				var count = viewNoAffectedMarketSegments.GroupCount();
				AffectedMarketSegments = new NoAffectedMarketSegments[count];
				for (int i = 0; i < count; i++)
				{
					AffectedMarketSegments[i] = new();
					((IFixParser)AffectedMarketSegments[i]).Parse(viewNoAffectedMarketSegments.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoAffectedMarketSegments":
				{
					value = AffectedMarketSegments;
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
			AffectedMarketSegments = null;
		}
	}
}
