using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class DeliveryStreamCommoditySourceGrp : IFixComponent
	{
		public sealed partial class NoDeliveryStreamCommoditySources : IFixGroup
		{
			[TagDetails(Tag = 41086, Type = TagType.String, Offset = 0, Required = false)]
			public string? DeliveryStreamCommoditySource {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (DeliveryStreamCommoditySource is not null) writer.WriteString(41086, DeliveryStreamCommoditySource);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				DeliveryStreamCommoditySource = view.GetString(41086);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "DeliveryStreamCommoditySource":
					{
						value = DeliveryStreamCommoditySource;
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
				DeliveryStreamCommoditySource = null;
			}
		}
		[Group(NoOfTag = 41085, Offset = 0, Required = false)]
		public NoDeliveryStreamCommoditySources[]? DeliveryStreamCommoditySources {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (DeliveryStreamCommoditySources is not null && DeliveryStreamCommoditySources.Length != 0)
			{
				writer.WriteWholeNumber(41085, DeliveryStreamCommoditySources.Length);
				for (int i = 0; i < DeliveryStreamCommoditySources.Length; i++)
				{
					((IFixEncoder)DeliveryStreamCommoditySources[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoDeliveryStreamCommoditySources") is IMessageView viewNoDeliveryStreamCommoditySources)
			{
				var count = viewNoDeliveryStreamCommoditySources.GroupCount();
				DeliveryStreamCommoditySources = new NoDeliveryStreamCommoditySources[count];
				for (int i = 0; i < count; i++)
				{
					DeliveryStreamCommoditySources[i] = new();
					((IFixParser)DeliveryStreamCommoditySources[i]).Parse(viewNoDeliveryStreamCommoditySources.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoDeliveryStreamCommoditySources":
				{
					value = DeliveryStreamCommoditySources;
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
			DeliveryStreamCommoditySources = null;
		}
	}
}
