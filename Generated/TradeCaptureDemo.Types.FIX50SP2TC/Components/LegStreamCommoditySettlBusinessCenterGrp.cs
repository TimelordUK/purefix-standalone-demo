using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegStreamCommoditySettlBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegStreamCommoditySettlBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 41647, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegStreamCommoditySettlBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegStreamCommoditySettlBusinessCenter is not null) writer.WriteString(41647, LegStreamCommoditySettlBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegStreamCommoditySettlBusinessCenter = view.GetString(41647);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegStreamCommoditySettlBusinessCenter":
					{
						value = LegStreamCommoditySettlBusinessCenter;
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
				LegStreamCommoditySettlBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 41646, Offset = 0, Required = false)]
		public NoLegStreamCommoditySettlBusinessCenters[]? LegStreamCommoditySettlBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegStreamCommoditySettlBusinessCenters is not null && LegStreamCommoditySettlBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(41646, LegStreamCommoditySettlBusinessCenters.Length);
				for (int i = 0; i < LegStreamCommoditySettlBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegStreamCommoditySettlBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegStreamCommoditySettlBusinessCenters") is IMessageView viewNoLegStreamCommoditySettlBusinessCenters)
			{
				var count = viewNoLegStreamCommoditySettlBusinessCenters.GroupCount();
				LegStreamCommoditySettlBusinessCenters = new NoLegStreamCommoditySettlBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegStreamCommoditySettlBusinessCenters[i] = new();
					((IFixParser)LegStreamCommoditySettlBusinessCenters[i]).Parse(viewNoLegStreamCommoditySettlBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegStreamCommoditySettlBusinessCenters":
				{
					value = LegStreamCommoditySettlBusinessCenters;
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
			LegStreamCommoditySettlBusinessCenters = null;
		}
	}
}
