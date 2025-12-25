using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class TargetMarketSegmentGrp : IFixComponent
	{
		public sealed partial class NoTargetMarketSegments : IFixGroup
		{
			[TagDetails(Tag = 1790, Type = TagType.String, Offset = 0, Required = false)]
			public string? TargetMarketSegmentID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (TargetMarketSegmentID is not null) writer.WriteString(1790, TargetMarketSegmentID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				TargetMarketSegmentID = view.GetString(1790);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "TargetMarketSegmentID":
					{
						value = TargetMarketSegmentID;
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
				TargetMarketSegmentID = null;
			}
		}
		[Group(NoOfTag = 1789, Offset = 0, Required = false)]
		public NoTargetMarketSegments[]? TargetMarketSegments {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (TargetMarketSegments is not null && TargetMarketSegments.Length != 0)
			{
				writer.WriteWholeNumber(1789, TargetMarketSegments.Length);
				for (int i = 0; i < TargetMarketSegments.Length; i++)
				{
					((IFixEncoder)TargetMarketSegments[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoTargetMarketSegments") is IMessageView viewNoTargetMarketSegments)
			{
				var count = viewNoTargetMarketSegments.GroupCount();
				TargetMarketSegments = new NoTargetMarketSegments[count];
				for (int i = 0; i < count; i++)
				{
					TargetMarketSegments[i] = new();
					((IFixParser)TargetMarketSegments[i]).Parse(viewNoTargetMarketSegments.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoTargetMarketSegments":
				{
					value = TargetMarketSegments;
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
			TargetMarketSegments = null;
		}
	}
}
