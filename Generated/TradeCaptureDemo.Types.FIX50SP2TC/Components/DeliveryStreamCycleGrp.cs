using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class DeliveryStreamCycleGrp : IFixComponent
	{
		public sealed partial class NoDeliveryStreamCycles : IFixGroup
		{
			[TagDetails(Tag = 41082, Type = TagType.String, Offset = 0, Required = false)]
			public string? DeliveryStreamCycleDesc {get; set;}
			
			[TagDetails(Tag = 41083, Type = TagType.Length, Offset = 1, Required = false)]
			public int? EncodedDeliveryStreamCycleDescLen {get; set;}
			
			[TagDetails(Tag = 41084, Type = TagType.RawData, Offset = 2, Required = false)]
			public byte[]? EncodedDeliveryStreamCycleDesc {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (DeliveryStreamCycleDesc is not null) writer.WriteString(41082, DeliveryStreamCycleDesc);
				if (EncodedDeliveryStreamCycleDescLen is not null) writer.WriteWholeNumber(41083, EncodedDeliveryStreamCycleDescLen.Value);
				if (EncodedDeliveryStreamCycleDesc is not null) writer.WriteBuffer(41084, EncodedDeliveryStreamCycleDesc);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				DeliveryStreamCycleDesc = view.GetString(41082);
				EncodedDeliveryStreamCycleDescLen = view.GetInt32(41083);
				EncodedDeliveryStreamCycleDesc = view.GetByteArray(41084);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "DeliveryStreamCycleDesc":
					{
						value = DeliveryStreamCycleDesc;
						break;
					}
					case "EncodedDeliveryStreamCycleDescLen":
					{
						value = EncodedDeliveryStreamCycleDescLen;
						break;
					}
					case "EncodedDeliveryStreamCycleDesc":
					{
						value = EncodedDeliveryStreamCycleDesc;
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
				DeliveryStreamCycleDesc = null;
				EncodedDeliveryStreamCycleDescLen = null;
				EncodedDeliveryStreamCycleDesc = null;
			}
		}
		[Group(NoOfTag = 41081, Offset = 0, Required = false)]
		public NoDeliveryStreamCycles[]? DeliveryStreamCycles {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (DeliveryStreamCycles is not null && DeliveryStreamCycles.Length != 0)
			{
				writer.WriteWholeNumber(41081, DeliveryStreamCycles.Length);
				for (int i = 0; i < DeliveryStreamCycles.Length; i++)
				{
					((IFixEncoder)DeliveryStreamCycles[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoDeliveryStreamCycles") is IMessageView viewNoDeliveryStreamCycles)
			{
				var count = viewNoDeliveryStreamCycles.GroupCount();
				DeliveryStreamCycles = new NoDeliveryStreamCycles[count];
				for (int i = 0; i < count; i++)
				{
					DeliveryStreamCycles[i] = new();
					((IFixParser)DeliveryStreamCycles[i]).Parse(viewNoDeliveryStreamCycles.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoDeliveryStreamCycles":
				{
					value = DeliveryStreamCycles;
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
			DeliveryStreamCycles = null;
		}
	}
}
