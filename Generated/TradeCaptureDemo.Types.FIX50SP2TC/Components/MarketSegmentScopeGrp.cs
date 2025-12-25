using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class MarketSegmentScopeGrp : IFixComponent
	{
		public sealed partial class NoMarketSegments : IFixGroup
		{
			[TagDetails(Tag = 1301, Type = TagType.String, Offset = 0, Required = false)]
			public string? MarketID {get; set;}
			
			[TagDetails(Tag = 1300, Type = TagType.String, Offset = 1, Required = false)]
			public string? MarketSegmentID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (MarketID is not null) writer.WriteString(1301, MarketID);
				if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				MarketID = view.GetString(1301);
				MarketSegmentID = view.GetString(1300);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "MarketID":
					{
						value = MarketID;
						break;
					}
					case "MarketSegmentID":
					{
						value = MarketSegmentID;
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
				MarketID = null;
				MarketSegmentID = null;
			}
		}
		[Group(NoOfTag = 1310, Offset = 0, Required = false)]
		public NoMarketSegments[]? MarketSegments {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (MarketSegments is not null && MarketSegments.Length != 0)
			{
				writer.WriteWholeNumber(1310, MarketSegments.Length);
				for (int i = 0; i < MarketSegments.Length; i++)
				{
					((IFixEncoder)MarketSegments[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoMarketSegments") is IMessageView viewNoMarketSegments)
			{
				var count = viewNoMarketSegments.GroupCount();
				MarketSegments = new NoMarketSegments[count];
				for (int i = 0; i < count; i++)
				{
					MarketSegments[i] = new();
					((IFixParser)MarketSegments[i]).Parse(viewNoMarketSegments.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoMarketSegments":
				{
					value = MarketSegments;
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
			MarketSegments = null;
		}
	}
}
