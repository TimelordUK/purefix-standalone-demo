using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class StreamCommoditySettlTimeGrp : IFixComponent
	{
		public sealed partial class NoStreamCommoditySettlTimes : IFixGroup
		{
			[TagDetails(Tag = 41287, Type = TagType.String, Offset = 0, Required = false)]
			public string? StreamCommoditySettlStart {get; set;}
			
			[TagDetails(Tag = 41288, Type = TagType.String, Offset = 1, Required = false)]
			public string? StreamCommoditySettlEnd {get; set;}
			
			[TagDetails(Tag = 41588, Type = TagType.Int, Offset = 2, Required = false)]
			public int? StreamCommoditySettlTimeType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (StreamCommoditySettlStart is not null) writer.WriteString(41287, StreamCommoditySettlStart);
				if (StreamCommoditySettlEnd is not null) writer.WriteString(41288, StreamCommoditySettlEnd);
				if (StreamCommoditySettlTimeType is not null) writer.WriteWholeNumber(41588, StreamCommoditySettlTimeType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				StreamCommoditySettlStart = view.GetString(41287);
				StreamCommoditySettlEnd = view.GetString(41288);
				StreamCommoditySettlTimeType = view.GetInt32(41588);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "StreamCommoditySettlStart":
					{
						value = StreamCommoditySettlStart;
						break;
					}
					case "StreamCommoditySettlEnd":
					{
						value = StreamCommoditySettlEnd;
						break;
					}
					case "StreamCommoditySettlTimeType":
					{
						value = StreamCommoditySettlTimeType;
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
				StreamCommoditySettlStart = null;
				StreamCommoditySettlEnd = null;
				StreamCommoditySettlTimeType = null;
			}
		}
		[Group(NoOfTag = 41286, Offset = 0, Required = false)]
		public NoStreamCommoditySettlTimes[]? StreamCommoditySettlTimes {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (StreamCommoditySettlTimes is not null && StreamCommoditySettlTimes.Length != 0)
			{
				writer.WriteWholeNumber(41286, StreamCommoditySettlTimes.Length);
				for (int i = 0; i < StreamCommoditySettlTimes.Length; i++)
				{
					((IFixEncoder)StreamCommoditySettlTimes[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoStreamCommoditySettlTimes") is IMessageView viewNoStreamCommoditySettlTimes)
			{
				var count = viewNoStreamCommoditySettlTimes.GroupCount();
				StreamCommoditySettlTimes = new NoStreamCommoditySettlTimes[count];
				for (int i = 0; i < count; i++)
				{
					StreamCommoditySettlTimes[i] = new();
					((IFixParser)StreamCommoditySettlTimes[i]).Parse(viewNoStreamCommoditySettlTimes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoStreamCommoditySettlTimes":
				{
					value = StreamCommoditySettlTimes;
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
			StreamCommoditySettlTimes = null;
		}
	}
}
