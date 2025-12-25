using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegDeliveryStreamCommoditySourceGrp : IFixComponent
	{
		public sealed partial class NoLegDeliveryStreamCommoditySources : IFixGroup
		{
			[TagDetails(Tag = 41461, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegDeliveryStreamCommoditySource {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegDeliveryStreamCommoditySource is not null) writer.WriteString(41461, LegDeliveryStreamCommoditySource);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegDeliveryStreamCommoditySource = view.GetString(41461);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegDeliveryStreamCommoditySource":
					{
						value = LegDeliveryStreamCommoditySource;
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
				LegDeliveryStreamCommoditySource = null;
			}
		}
		[Group(NoOfTag = 41460, Offset = 0, Required = false)]
		public NoLegDeliveryStreamCommoditySources[]? LegDeliveryStreamCommoditySources {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegDeliveryStreamCommoditySources is not null && LegDeliveryStreamCommoditySources.Length != 0)
			{
				writer.WriteWholeNumber(41460, LegDeliveryStreamCommoditySources.Length);
				for (int i = 0; i < LegDeliveryStreamCommoditySources.Length; i++)
				{
					((IFixEncoder)LegDeliveryStreamCommoditySources[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegDeliveryStreamCommoditySources") is IMessageView viewNoLegDeliveryStreamCommoditySources)
			{
				var count = viewNoLegDeliveryStreamCommoditySources.GroupCount();
				LegDeliveryStreamCommoditySources = new NoLegDeliveryStreamCommoditySources[count];
				for (int i = 0; i < count; i++)
				{
					LegDeliveryStreamCommoditySources[i] = new();
					((IFixParser)LegDeliveryStreamCommoditySources[i]).Parse(viewNoLegDeliveryStreamCommoditySources.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegDeliveryStreamCommoditySources":
				{
					value = LegDeliveryStreamCommoditySources;
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
			LegDeliveryStreamCommoditySources = null;
		}
	}
}
