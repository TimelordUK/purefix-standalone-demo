using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class SideTrdRegTS : IFixComponent
	{
		public sealed partial class NoSideTrdRegTS : IFixGroup
		{
			[TagDetails(Tag = 1012, Type = TagType.UtcTimestamp, Offset = 0, Required = false)]
			public DateTime? SideTrdRegTimestamp {get; set;}
			
			[TagDetails(Tag = 1013, Type = TagType.Int, Offset = 1, Required = false)]
			public int? SideTrdRegTimestampType {get; set;}
			
			[TagDetails(Tag = 1014, Type = TagType.String, Offset = 2, Required = false)]
			public string? SideTrdRegTimestampSrc {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (SideTrdRegTimestamp is not null) writer.WriteUtcTimeStamp(1012, SideTrdRegTimestamp.Value);
				if (SideTrdRegTimestampType is not null) writer.WriteWholeNumber(1013, SideTrdRegTimestampType.Value);
				if (SideTrdRegTimestampSrc is not null) writer.WriteString(1014, SideTrdRegTimestampSrc);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				SideTrdRegTimestamp = view.GetDateTime(1012);
				SideTrdRegTimestampType = view.GetInt32(1013);
				SideTrdRegTimestampSrc = view.GetString(1014);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "SideTrdRegTimestamp":
					{
						value = SideTrdRegTimestamp;
						break;
					}
					case "SideTrdRegTimestampType":
					{
						value = SideTrdRegTimestampType;
						break;
					}
					case "SideTrdRegTimestampSrc":
					{
						value = SideTrdRegTimestampSrc;
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
				SideTrdRegTimestamp = null;
				SideTrdRegTimestampType = null;
				SideTrdRegTimestampSrc = null;
			}
		}
		[Group(NoOfTag = 1016, Offset = 0, Required = false)]
		public NoSideTrdRegTS[]? SideTrdRegTSItems {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (SideTrdRegTSItems is not null && SideTrdRegTSItems.Length != 0)
			{
				writer.WriteWholeNumber(1016, SideTrdRegTSItems.Length);
				for (int i = 0; i < SideTrdRegTSItems.Length; i++)
				{
					((IFixEncoder)SideTrdRegTSItems[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoSideTrdRegTS") is IMessageView viewNoSideTrdRegTS)
			{
				var count = viewNoSideTrdRegTS.GroupCount();
				SideTrdRegTSItems = new NoSideTrdRegTS[count];
				for (int i = 0; i < count; i++)
				{
					SideTrdRegTSItems[i] = new();
					((IFixParser)SideTrdRegTSItems[i]).Parse(viewNoSideTrdRegTS.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoSideTrdRegTS":
				{
					value = SideTrdRegTSItems;
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
			SideTrdRegTSItems = null;
		}
	}
}
