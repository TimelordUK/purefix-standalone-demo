using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingStreamCommoditySettlBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingStreamCommoditySettlBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 41963, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingStreamCommoditySettlBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingStreamCommoditySettlBusinessCenter is not null) writer.WriteString(41963, UnderlyingStreamCommoditySettlBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingStreamCommoditySettlBusinessCenter = view.GetString(41963);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingStreamCommoditySettlBusinessCenter":
					{
						value = UnderlyingStreamCommoditySettlBusinessCenter;
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
				UnderlyingStreamCommoditySettlBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 41962, Offset = 0, Required = false)]
		public NoUnderlyingStreamCommoditySettlBusinessCenters[]? UnderlyingStreamCommoditySettlBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingStreamCommoditySettlBusinessCenters is not null && UnderlyingStreamCommoditySettlBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(41962, UnderlyingStreamCommoditySettlBusinessCenters.Length);
				for (int i = 0; i < UnderlyingStreamCommoditySettlBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingStreamCommoditySettlBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingStreamCommoditySettlBusinessCenters") is IMessageView viewNoUnderlyingStreamCommoditySettlBusinessCenters)
			{
				var count = viewNoUnderlyingStreamCommoditySettlBusinessCenters.GroupCount();
				UnderlyingStreamCommoditySettlBusinessCenters = new NoUnderlyingStreamCommoditySettlBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingStreamCommoditySettlBusinessCenters[i] = new();
					((IFixParser)UnderlyingStreamCommoditySettlBusinessCenters[i]).Parse(viewNoUnderlyingStreamCommoditySettlBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingStreamCommoditySettlBusinessCenters":
				{
					value = UnderlyingStreamCommoditySettlBusinessCenters;
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
			UnderlyingStreamCommoditySettlBusinessCenters = null;
		}
	}
}
