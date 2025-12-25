using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegDeliveryStreamCycleGrp : IFixComponent
	{
		public sealed partial class NoLegDeliveryStreamCycles : IFixGroup
		{
			[TagDetails(Tag = 41457, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegDeliveryStreamCycleDesc {get; set;}
			
			[TagDetails(Tag = 41458, Type = TagType.Length, Offset = 1, Required = false)]
			public int? EncodedLegDeliveryStreamCycleDescLen {get; set;}
			
			[TagDetails(Tag = 41459, Type = TagType.RawData, Offset = 2, Required = false)]
			public byte[]? EncodedLegDeliveryStreamCycleDesc {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegDeliveryStreamCycleDesc is not null) writer.WriteString(41457, LegDeliveryStreamCycleDesc);
				if (EncodedLegDeliveryStreamCycleDescLen is not null) writer.WriteWholeNumber(41458, EncodedLegDeliveryStreamCycleDescLen.Value);
				if (EncodedLegDeliveryStreamCycleDesc is not null) writer.WriteBuffer(41459, EncodedLegDeliveryStreamCycleDesc);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegDeliveryStreamCycleDesc = view.GetString(41457);
				EncodedLegDeliveryStreamCycleDescLen = view.GetInt32(41458);
				EncodedLegDeliveryStreamCycleDesc = view.GetByteArray(41459);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegDeliveryStreamCycleDesc":
					{
						value = LegDeliveryStreamCycleDesc;
						break;
					}
					case "EncodedLegDeliveryStreamCycleDescLen":
					{
						value = EncodedLegDeliveryStreamCycleDescLen;
						break;
					}
					case "EncodedLegDeliveryStreamCycleDesc":
					{
						value = EncodedLegDeliveryStreamCycleDesc;
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
				LegDeliveryStreamCycleDesc = null;
				EncodedLegDeliveryStreamCycleDescLen = null;
				EncodedLegDeliveryStreamCycleDesc = null;
			}
		}
		[Group(NoOfTag = 41456, Offset = 0, Required = false)]
		public NoLegDeliveryStreamCycles[]? LegDeliveryStreamCycles {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegDeliveryStreamCycles is not null && LegDeliveryStreamCycles.Length != 0)
			{
				writer.WriteWholeNumber(41456, LegDeliveryStreamCycles.Length);
				for (int i = 0; i < LegDeliveryStreamCycles.Length; i++)
				{
					((IFixEncoder)LegDeliveryStreamCycles[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegDeliveryStreamCycles") is IMessageView viewNoLegDeliveryStreamCycles)
			{
				var count = viewNoLegDeliveryStreamCycles.GroupCount();
				LegDeliveryStreamCycles = new NoLegDeliveryStreamCycles[count];
				for (int i = 0; i < count; i++)
				{
					LegDeliveryStreamCycles[i] = new();
					((IFixParser)LegDeliveryStreamCycles[i]).Parse(viewNoLegDeliveryStreamCycles.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegDeliveryStreamCycles":
				{
					value = LegDeliveryStreamCycles;
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
			LegDeliveryStreamCycles = null;
		}
	}
}
