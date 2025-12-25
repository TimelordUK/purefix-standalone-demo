using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class DeliveryScheduleSettlTimeGrp : IFixComponent
	{
		public sealed partial class NoDeliveryScheduleSettlTimes : IFixGroup
		{
			[TagDetails(Tag = 41055, Type = TagType.String, Offset = 0, Required = false)]
			public string? DeliveryScheduleSettlStart {get; set;}
			
			[TagDetails(Tag = 41056, Type = TagType.String, Offset = 1, Required = false)]
			public string? DeliveryScheduleSettlEnd {get; set;}
			
			[TagDetails(Tag = 41057, Type = TagType.Int, Offset = 2, Required = false)]
			public int? DeliveryScheduleSettlTimeType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (DeliveryScheduleSettlStart is not null) writer.WriteString(41055, DeliveryScheduleSettlStart);
				if (DeliveryScheduleSettlEnd is not null) writer.WriteString(41056, DeliveryScheduleSettlEnd);
				if (DeliveryScheduleSettlTimeType is not null) writer.WriteWholeNumber(41057, DeliveryScheduleSettlTimeType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				DeliveryScheduleSettlStart = view.GetString(41055);
				DeliveryScheduleSettlEnd = view.GetString(41056);
				DeliveryScheduleSettlTimeType = view.GetInt32(41057);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "DeliveryScheduleSettlStart":
					{
						value = DeliveryScheduleSettlStart;
						break;
					}
					case "DeliveryScheduleSettlEnd":
					{
						value = DeliveryScheduleSettlEnd;
						break;
					}
					case "DeliveryScheduleSettlTimeType":
					{
						value = DeliveryScheduleSettlTimeType;
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
				DeliveryScheduleSettlStart = null;
				DeliveryScheduleSettlEnd = null;
				DeliveryScheduleSettlTimeType = null;
			}
		}
		[Group(NoOfTag = 41054, Offset = 0, Required = false)]
		public NoDeliveryScheduleSettlTimes[]? DeliveryScheduleSettlTimes {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (DeliveryScheduleSettlTimes is not null && DeliveryScheduleSettlTimes.Length != 0)
			{
				writer.WriteWholeNumber(41054, DeliveryScheduleSettlTimes.Length);
				for (int i = 0; i < DeliveryScheduleSettlTimes.Length; i++)
				{
					((IFixEncoder)DeliveryScheduleSettlTimes[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoDeliveryScheduleSettlTimes") is IMessageView viewNoDeliveryScheduleSettlTimes)
			{
				var count = viewNoDeliveryScheduleSettlTimes.GroupCount();
				DeliveryScheduleSettlTimes = new NoDeliveryScheduleSettlTimes[count];
				for (int i = 0; i < count; i++)
				{
					DeliveryScheduleSettlTimes[i] = new();
					((IFixParser)DeliveryScheduleSettlTimes[i]).Parse(viewNoDeliveryScheduleSettlTimes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoDeliveryScheduleSettlTimes":
				{
					value = DeliveryScheduleSettlTimes;
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
			DeliveryScheduleSettlTimes = null;
		}
	}
}
