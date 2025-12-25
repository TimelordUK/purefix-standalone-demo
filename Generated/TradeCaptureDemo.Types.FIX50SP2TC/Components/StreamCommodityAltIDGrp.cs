using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class StreamCommodityAltIDGrp : IFixComponent
	{
		public sealed partial class NoStreamCommodityAltIDs : IFixGroup
		{
			[TagDetails(Tag = 41278, Type = TagType.String, Offset = 0, Required = false)]
			public string? StreamCommodityAltID {get; set;}
			
			[TagDetails(Tag = 41279, Type = TagType.String, Offset = 1, Required = false)]
			public string? StreamCommodityAltIDSource {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (StreamCommodityAltID is not null) writer.WriteString(41278, StreamCommodityAltID);
				if (StreamCommodityAltIDSource is not null) writer.WriteString(41279, StreamCommodityAltIDSource);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				StreamCommodityAltID = view.GetString(41278);
				StreamCommodityAltIDSource = view.GetString(41279);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "StreamCommodityAltID":
					{
						value = StreamCommodityAltID;
						break;
					}
					case "StreamCommodityAltIDSource":
					{
						value = StreamCommodityAltIDSource;
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
				StreamCommodityAltID = null;
				StreamCommodityAltIDSource = null;
			}
		}
		[Group(NoOfTag = 41277, Offset = 0, Required = false)]
		public NoStreamCommodityAltIDs[]? StreamCommodityAltIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (StreamCommodityAltIDs is not null && StreamCommodityAltIDs.Length != 0)
			{
				writer.WriteWholeNumber(41277, StreamCommodityAltIDs.Length);
				for (int i = 0; i < StreamCommodityAltIDs.Length; i++)
				{
					((IFixEncoder)StreamCommodityAltIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoStreamCommodityAltIDs") is IMessageView viewNoStreamCommodityAltIDs)
			{
				var count = viewNoStreamCommodityAltIDs.GroupCount();
				StreamCommodityAltIDs = new NoStreamCommodityAltIDs[count];
				for (int i = 0; i < count; i++)
				{
					StreamCommodityAltIDs[i] = new();
					((IFixParser)StreamCommodityAltIDs[i]).Parse(viewNoStreamCommodityAltIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoStreamCommodityAltIDs":
				{
					value = StreamCommodityAltIDs;
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
			StreamCommodityAltIDs = null;
		}
	}
}
