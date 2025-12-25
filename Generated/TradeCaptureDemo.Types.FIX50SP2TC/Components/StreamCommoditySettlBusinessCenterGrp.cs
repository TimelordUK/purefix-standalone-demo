using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class StreamCommoditySettlBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoStreamCommoditySettlBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 41250, Type = TagType.String, Offset = 0, Required = false)]
			public string? StreamCommoditySettlBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (StreamCommoditySettlBusinessCenter is not null) writer.WriteString(41250, StreamCommoditySettlBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				StreamCommoditySettlBusinessCenter = view.GetString(41250);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "StreamCommoditySettlBusinessCenter":
					{
						value = StreamCommoditySettlBusinessCenter;
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
				StreamCommoditySettlBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 41249, Offset = 0, Required = false)]
		public NoStreamCommoditySettlBusinessCenters[]? StreamCommoditySettlBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (StreamCommoditySettlBusinessCenters is not null && StreamCommoditySettlBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(41249, StreamCommoditySettlBusinessCenters.Length);
				for (int i = 0; i < StreamCommoditySettlBusinessCenters.Length; i++)
				{
					((IFixEncoder)StreamCommoditySettlBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoStreamCommoditySettlBusinessCenters") is IMessageView viewNoStreamCommoditySettlBusinessCenters)
			{
				var count = viewNoStreamCommoditySettlBusinessCenters.GroupCount();
				StreamCommoditySettlBusinessCenters = new NoStreamCommoditySettlBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					StreamCommoditySettlBusinessCenters[i] = new();
					((IFixParser)StreamCommoditySettlBusinessCenters[i]).Parse(viewNoStreamCommoditySettlBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoStreamCommoditySettlBusinessCenters":
				{
					value = StreamCommoditySettlBusinessCenters;
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
			StreamCommoditySettlBusinessCenters = null;
		}
	}
}
