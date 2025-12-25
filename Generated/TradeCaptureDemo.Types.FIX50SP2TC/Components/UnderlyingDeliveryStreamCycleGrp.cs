using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingDeliveryStreamCycleGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingDeliveryStreamCycles : IFixGroup
		{
			[TagDetails(Tag = 41805, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingDeliveryStreamCycleDesc {get; set;}
			
			[TagDetails(Tag = 41806, Type = TagType.Length, Offset = 1, Required = false)]
			public int? EncodedUnderlyingDeliveryStreamCycleDescLen {get; set;}
			
			[TagDetails(Tag = 41807, Type = TagType.RawData, Offset = 2, Required = false)]
			public byte[]? EncodedUnderlyingDeliveryStreamCycleDesc {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingDeliveryStreamCycleDesc is not null) writer.WriteString(41805, UnderlyingDeliveryStreamCycleDesc);
				if (EncodedUnderlyingDeliveryStreamCycleDescLen is not null) writer.WriteWholeNumber(41806, EncodedUnderlyingDeliveryStreamCycleDescLen.Value);
				if (EncodedUnderlyingDeliveryStreamCycleDesc is not null) writer.WriteBuffer(41807, EncodedUnderlyingDeliveryStreamCycleDesc);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingDeliveryStreamCycleDesc = view.GetString(41805);
				EncodedUnderlyingDeliveryStreamCycleDescLen = view.GetInt32(41806);
				EncodedUnderlyingDeliveryStreamCycleDesc = view.GetByteArray(41807);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingDeliveryStreamCycleDesc":
					{
						value = UnderlyingDeliveryStreamCycleDesc;
						break;
					}
					case "EncodedUnderlyingDeliveryStreamCycleDescLen":
					{
						value = EncodedUnderlyingDeliveryStreamCycleDescLen;
						break;
					}
					case "EncodedUnderlyingDeliveryStreamCycleDesc":
					{
						value = EncodedUnderlyingDeliveryStreamCycleDesc;
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
				UnderlyingDeliveryStreamCycleDesc = null;
				EncodedUnderlyingDeliveryStreamCycleDescLen = null;
				EncodedUnderlyingDeliveryStreamCycleDesc = null;
			}
		}
		[Group(NoOfTag = 41804, Offset = 0, Required = false)]
		public NoUnderlyingDeliveryStreamCycles[]? UnderlyingDeliveryStreamCycles {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingDeliveryStreamCycles is not null && UnderlyingDeliveryStreamCycles.Length != 0)
			{
				writer.WriteWholeNumber(41804, UnderlyingDeliveryStreamCycles.Length);
				for (int i = 0; i < UnderlyingDeliveryStreamCycles.Length; i++)
				{
					((IFixEncoder)UnderlyingDeliveryStreamCycles[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingDeliveryStreamCycles") is IMessageView viewNoUnderlyingDeliveryStreamCycles)
			{
				var count = viewNoUnderlyingDeliveryStreamCycles.GroupCount();
				UnderlyingDeliveryStreamCycles = new NoUnderlyingDeliveryStreamCycles[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingDeliveryStreamCycles[i] = new();
					((IFixParser)UnderlyingDeliveryStreamCycles[i]).Parse(viewNoUnderlyingDeliveryStreamCycles.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingDeliveryStreamCycles":
				{
					value = UnderlyingDeliveryStreamCycles;
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
			UnderlyingDeliveryStreamCycles = null;
		}
	}
}
