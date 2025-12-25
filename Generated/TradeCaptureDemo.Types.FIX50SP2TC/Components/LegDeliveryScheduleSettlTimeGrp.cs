using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegDeliveryScheduleSettlTimeGrp : IFixComponent
	{
		public sealed partial class NoLegDeliveryScheduleSettlTimes : IFixGroup
		{
			[TagDetails(Tag = 41426, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegDeliveryScheduleSettlStart {get; set;}
			
			[TagDetails(Tag = 41427, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegDeliveryScheduleSettlEnd {get; set;}
			
			[TagDetails(Tag = 41428, Type = TagType.Int, Offset = 2, Required = false)]
			public int? LegDeliveryScheduleSettlTimeType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegDeliveryScheduleSettlStart is not null) writer.WriteString(41426, LegDeliveryScheduleSettlStart);
				if (LegDeliveryScheduleSettlEnd is not null) writer.WriteString(41427, LegDeliveryScheduleSettlEnd);
				if (LegDeliveryScheduleSettlTimeType is not null) writer.WriteWholeNumber(41428, LegDeliveryScheduleSettlTimeType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegDeliveryScheduleSettlStart = view.GetString(41426);
				LegDeliveryScheduleSettlEnd = view.GetString(41427);
				LegDeliveryScheduleSettlTimeType = view.GetInt32(41428);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegDeliveryScheduleSettlStart":
					{
						value = LegDeliveryScheduleSettlStart;
						break;
					}
					case "LegDeliveryScheduleSettlEnd":
					{
						value = LegDeliveryScheduleSettlEnd;
						break;
					}
					case "LegDeliveryScheduleSettlTimeType":
					{
						value = LegDeliveryScheduleSettlTimeType;
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
				LegDeliveryScheduleSettlStart = null;
				LegDeliveryScheduleSettlEnd = null;
				LegDeliveryScheduleSettlTimeType = null;
			}
		}
		[Group(NoOfTag = 41425, Offset = 0, Required = false)]
		public NoLegDeliveryScheduleSettlTimes[]? LegDeliveryScheduleSettlTimes {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegDeliveryScheduleSettlTimes is not null && LegDeliveryScheduleSettlTimes.Length != 0)
			{
				writer.WriteWholeNumber(41425, LegDeliveryScheduleSettlTimes.Length);
				for (int i = 0; i < LegDeliveryScheduleSettlTimes.Length; i++)
				{
					((IFixEncoder)LegDeliveryScheduleSettlTimes[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegDeliveryScheduleSettlTimes") is IMessageView viewNoLegDeliveryScheduleSettlTimes)
			{
				var count = viewNoLegDeliveryScheduleSettlTimes.GroupCount();
				LegDeliveryScheduleSettlTimes = new NoLegDeliveryScheduleSettlTimes[count];
				for (int i = 0; i < count; i++)
				{
					LegDeliveryScheduleSettlTimes[i] = new();
					((IFixParser)LegDeliveryScheduleSettlTimes[i]).Parse(viewNoLegDeliveryScheduleSettlTimes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegDeliveryScheduleSettlTimes":
				{
					value = LegDeliveryScheduleSettlTimes;
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
			LegDeliveryScheduleSettlTimes = null;
		}
	}
}
