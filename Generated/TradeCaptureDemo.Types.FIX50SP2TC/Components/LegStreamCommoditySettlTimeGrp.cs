using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegStreamCommoditySettlTimeGrp : IFixComponent
	{
		public sealed partial class NoLegStreamCommoditySettlTimes : IFixGroup
		{
			[TagDetails(Tag = 41684, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegStreamCommoditySettlStart {get; set;}
			
			[TagDetails(Tag = 41685, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegStreamCommoditySettlEnd {get; set;}
			
			[TagDetails(Tag = 41935, Type = TagType.Int, Offset = 2, Required = false)]
			public int? LegStreamCommoditySettlTimeType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegStreamCommoditySettlStart is not null) writer.WriteString(41684, LegStreamCommoditySettlStart);
				if (LegStreamCommoditySettlEnd is not null) writer.WriteString(41685, LegStreamCommoditySettlEnd);
				if (LegStreamCommoditySettlTimeType is not null) writer.WriteWholeNumber(41935, LegStreamCommoditySettlTimeType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegStreamCommoditySettlStart = view.GetString(41684);
				LegStreamCommoditySettlEnd = view.GetString(41685);
				LegStreamCommoditySettlTimeType = view.GetInt32(41935);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegStreamCommoditySettlStart":
					{
						value = LegStreamCommoditySettlStart;
						break;
					}
					case "LegStreamCommoditySettlEnd":
					{
						value = LegStreamCommoditySettlEnd;
						break;
					}
					case "LegStreamCommoditySettlTimeType":
					{
						value = LegStreamCommoditySettlTimeType;
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
				LegStreamCommoditySettlStart = null;
				LegStreamCommoditySettlEnd = null;
				LegStreamCommoditySettlTimeType = null;
			}
		}
		[Group(NoOfTag = 41683, Offset = 0, Required = false)]
		public NoLegStreamCommoditySettlTimes[]? LegStreamCommoditySettlTimes {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegStreamCommoditySettlTimes is not null && LegStreamCommoditySettlTimes.Length != 0)
			{
				writer.WriteWholeNumber(41683, LegStreamCommoditySettlTimes.Length);
				for (int i = 0; i < LegStreamCommoditySettlTimes.Length; i++)
				{
					((IFixEncoder)LegStreamCommoditySettlTimes[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegStreamCommoditySettlTimes") is IMessageView viewNoLegStreamCommoditySettlTimes)
			{
				var count = viewNoLegStreamCommoditySettlTimes.GroupCount();
				LegStreamCommoditySettlTimes = new NoLegStreamCommoditySettlTimes[count];
				for (int i = 0; i < count; i++)
				{
					LegStreamCommoditySettlTimes[i] = new();
					((IFixParser)LegStreamCommoditySettlTimes[i]).Parse(viewNoLegStreamCommoditySettlTimes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegStreamCommoditySettlTimes":
				{
					value = LegStreamCommoditySettlTimes;
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
			LegStreamCommoditySettlTimes = null;
		}
	}
}
