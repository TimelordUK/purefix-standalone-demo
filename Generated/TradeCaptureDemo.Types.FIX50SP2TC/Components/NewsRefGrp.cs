using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class NewsRefGrp : IFixComponent
	{
		public sealed partial class NoNewsRefIDs : IFixGroup
		{
			[TagDetails(Tag = 1476, Type = TagType.String, Offset = 0, Required = false)]
			public string? NewsRefID {get; set;}
			
			[TagDetails(Tag = 1477, Type = TagType.Int, Offset = 1, Required = false)]
			public int? NewsRefType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (NewsRefID is not null) writer.WriteString(1476, NewsRefID);
				if (NewsRefType is not null) writer.WriteWholeNumber(1477, NewsRefType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				NewsRefID = view.GetString(1476);
				NewsRefType = view.GetInt32(1477);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "NewsRefID":
					{
						value = NewsRefID;
						break;
					}
					case "NewsRefType":
					{
						value = NewsRefType;
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
				NewsRefID = null;
				NewsRefType = null;
			}
		}
		[Group(NoOfTag = 1475, Offset = 0, Required = false)]
		public NoNewsRefIDs[]? NewsRefIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (NewsRefIDs is not null && NewsRefIDs.Length != 0)
			{
				writer.WriteWholeNumber(1475, NewsRefIDs.Length);
				for (int i = 0; i < NewsRefIDs.Length; i++)
				{
					((IFixEncoder)NewsRefIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoNewsRefIDs") is IMessageView viewNoNewsRefIDs)
			{
				var count = viewNoNewsRefIDs.GroupCount();
				NewsRefIDs = new NoNewsRefIDs[count];
				for (int i = 0; i < count; i++)
				{
					NewsRefIDs[i] = new();
					((IFixParser)NewsRefIDs[i]).Parse(viewNoNewsRefIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoNewsRefIDs":
				{
					value = NewsRefIDs;
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
			NewsRefIDs = null;
		}
	}
}
