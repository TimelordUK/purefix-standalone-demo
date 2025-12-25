using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class StreamCommoditySettlDayGrp : IFixComponent
	{
		public sealed partial class NoStreamCommoditySettlDays : IFixGroup
		{
			[TagDetails(Tag = 41284, Type = TagType.Int, Offset = 0, Required = false)]
			public int? StreamCommoditySettlDay {get; set;}
			
			[TagDetails(Tag = 41285, Type = TagType.Int, Offset = 1, Required = false)]
			public int? StreamCommoditySettlTotalHours {get; set;}
			
			[Component(Offset = 2, Required = false)]
			public StreamCommoditySettlTimeGrp? StreamCommoditySettlTimeGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (StreamCommoditySettlDay is not null) writer.WriteWholeNumber(41284, StreamCommoditySettlDay.Value);
				if (StreamCommoditySettlTotalHours is not null) writer.WriteWholeNumber(41285, StreamCommoditySettlTotalHours.Value);
				if (StreamCommoditySettlTimeGrp is not null) ((IFixEncoder)StreamCommoditySettlTimeGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				StreamCommoditySettlDay = view.GetInt32(41284);
				StreamCommoditySettlTotalHours = view.GetInt32(41285);
				if (view.GetView("StreamCommoditySettlTimeGrp") is IMessageView viewStreamCommoditySettlTimeGrp)
				{
					StreamCommoditySettlTimeGrp = new();
					((IFixParser)StreamCommoditySettlTimeGrp).Parse(viewStreamCommoditySettlTimeGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "StreamCommoditySettlDay":
					{
						value = StreamCommoditySettlDay;
						break;
					}
					case "StreamCommoditySettlTotalHours":
					{
						value = StreamCommoditySettlTotalHours;
						break;
					}
					case "StreamCommoditySettlTimeGrp":
					{
						value = StreamCommoditySettlTimeGrp;
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
				StreamCommoditySettlDay = null;
				StreamCommoditySettlTotalHours = null;
				((IFixReset?)StreamCommoditySettlTimeGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 41283, Offset = 0, Required = false)]
		public NoStreamCommoditySettlDays[]? StreamCommoditySettlDays {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (StreamCommoditySettlDays is not null && StreamCommoditySettlDays.Length != 0)
			{
				writer.WriteWholeNumber(41283, StreamCommoditySettlDays.Length);
				for (int i = 0; i < StreamCommoditySettlDays.Length; i++)
				{
					((IFixEncoder)StreamCommoditySettlDays[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoStreamCommoditySettlDays") is IMessageView viewNoStreamCommoditySettlDays)
			{
				var count = viewNoStreamCommoditySettlDays.GroupCount();
				StreamCommoditySettlDays = new NoStreamCommoditySettlDays[count];
				for (int i = 0; i < count; i++)
				{
					StreamCommoditySettlDays[i] = new();
					((IFixParser)StreamCommoditySettlDays[i]).Parse(viewNoStreamCommoditySettlDays.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoStreamCommoditySettlDays":
				{
					value = StreamCommoditySettlDays;
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
			StreamCommoditySettlDays = null;
		}
	}
}
