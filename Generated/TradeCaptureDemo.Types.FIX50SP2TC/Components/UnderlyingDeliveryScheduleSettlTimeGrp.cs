using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingDeliveryScheduleSettlTimeGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingDeliveryScheduleSettlTimes : IFixGroup
		{
			[TagDetails(Tag = 41774, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingDeliveryScheduleSettlStart {get; set;}
			
			[TagDetails(Tag = 41775, Type = TagType.String, Offset = 1, Required = false)]
			public string? UnderlyingDeliveryScheduleSettlEnd {get; set;}
			
			[TagDetails(Tag = 41776, Type = TagType.Int, Offset = 2, Required = false)]
			public int? UnderlyingDeliveryScheduleSettlTimeType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingDeliveryScheduleSettlStart is not null) writer.WriteString(41774, UnderlyingDeliveryScheduleSettlStart);
				if (UnderlyingDeliveryScheduleSettlEnd is not null) writer.WriteString(41775, UnderlyingDeliveryScheduleSettlEnd);
				if (UnderlyingDeliveryScheduleSettlTimeType is not null) writer.WriteWholeNumber(41776, UnderlyingDeliveryScheduleSettlTimeType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingDeliveryScheduleSettlStart = view.GetString(41774);
				UnderlyingDeliveryScheduleSettlEnd = view.GetString(41775);
				UnderlyingDeliveryScheduleSettlTimeType = view.GetInt32(41776);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingDeliveryScheduleSettlStart":
					{
						value = UnderlyingDeliveryScheduleSettlStart;
						break;
					}
					case "UnderlyingDeliveryScheduleSettlEnd":
					{
						value = UnderlyingDeliveryScheduleSettlEnd;
						break;
					}
					case "UnderlyingDeliveryScheduleSettlTimeType":
					{
						value = UnderlyingDeliveryScheduleSettlTimeType;
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
				UnderlyingDeliveryScheduleSettlStart = null;
				UnderlyingDeliveryScheduleSettlEnd = null;
				UnderlyingDeliveryScheduleSettlTimeType = null;
			}
		}
		[Group(NoOfTag = 41773, Offset = 0, Required = false)]
		public NoUnderlyingDeliveryScheduleSettlTimes[]? UnderlyingDeliveryScheduleSettlTimes {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingDeliveryScheduleSettlTimes is not null && UnderlyingDeliveryScheduleSettlTimes.Length != 0)
			{
				writer.WriteWholeNumber(41773, UnderlyingDeliveryScheduleSettlTimes.Length);
				for (int i = 0; i < UnderlyingDeliveryScheduleSettlTimes.Length; i++)
				{
					((IFixEncoder)UnderlyingDeliveryScheduleSettlTimes[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingDeliveryScheduleSettlTimes") is IMessageView viewNoUnderlyingDeliveryScheduleSettlTimes)
			{
				var count = viewNoUnderlyingDeliveryScheduleSettlTimes.GroupCount();
				UnderlyingDeliveryScheduleSettlTimes = new NoUnderlyingDeliveryScheduleSettlTimes[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingDeliveryScheduleSettlTimes[i] = new();
					((IFixParser)UnderlyingDeliveryScheduleSettlTimes[i]).Parse(viewNoUnderlyingDeliveryScheduleSettlTimes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingDeliveryScheduleSettlTimes":
				{
					value = UnderlyingDeliveryScheduleSettlTimes;
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
			UnderlyingDeliveryScheduleSettlTimes = null;
		}
	}
}
