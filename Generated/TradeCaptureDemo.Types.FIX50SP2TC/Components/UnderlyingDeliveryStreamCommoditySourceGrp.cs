using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingDeliveryStreamCommoditySourceGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingDeliveryStreamCommoditySources : IFixGroup
		{
			[TagDetails(Tag = 41809, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingDeliveryStreamCommoditySource {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingDeliveryStreamCommoditySource is not null) writer.WriteString(41809, UnderlyingDeliveryStreamCommoditySource);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingDeliveryStreamCommoditySource = view.GetString(41809);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingDeliveryStreamCommoditySource":
					{
						value = UnderlyingDeliveryStreamCommoditySource;
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
				UnderlyingDeliveryStreamCommoditySource = null;
			}
		}
		[Group(NoOfTag = 41808, Offset = 0, Required = false)]
		public NoUnderlyingDeliveryStreamCommoditySources[]? UnderlyingDeliveryStreamCommoditySources {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingDeliveryStreamCommoditySources is not null && UnderlyingDeliveryStreamCommoditySources.Length != 0)
			{
				writer.WriteWholeNumber(41808, UnderlyingDeliveryStreamCommoditySources.Length);
				for (int i = 0; i < UnderlyingDeliveryStreamCommoditySources.Length; i++)
				{
					((IFixEncoder)UnderlyingDeliveryStreamCommoditySources[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingDeliveryStreamCommoditySources") is IMessageView viewNoUnderlyingDeliveryStreamCommoditySources)
			{
				var count = viewNoUnderlyingDeliveryStreamCommoditySources.GroupCount();
				UnderlyingDeliveryStreamCommoditySources = new NoUnderlyingDeliveryStreamCommoditySources[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingDeliveryStreamCommoditySources[i] = new();
					((IFixParser)UnderlyingDeliveryStreamCommoditySources[i]).Parse(viewNoUnderlyingDeliveryStreamCommoditySources.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingDeliveryStreamCommoditySources":
				{
					value = UnderlyingDeliveryStreamCommoditySources;
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
			UnderlyingDeliveryStreamCommoditySources = null;
		}
	}
}
