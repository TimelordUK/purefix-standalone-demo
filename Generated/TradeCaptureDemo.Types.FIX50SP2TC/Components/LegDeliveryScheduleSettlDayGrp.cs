using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegDeliveryScheduleSettlDayGrp : IFixComponent
	{
		public sealed partial class NoLegDeliveryScheduleSettlDays : IFixGroup
		{
			[TagDetails(Tag = 41423, Type = TagType.Int, Offset = 0, Required = false)]
			public int? LegDeliveryScheduleSettlDay {get; set;}
			
			[TagDetails(Tag = 41424, Type = TagType.Int, Offset = 1, Required = false)]
			public int? LegDeliveryScheduleSettlTotalHours {get; set;}
			
			[Component(Offset = 2, Required = false)]
			public LegDeliveryScheduleSettlTimeGrp? LegDeliveryScheduleSettlTimeGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegDeliveryScheduleSettlDay is not null) writer.WriteWholeNumber(41423, LegDeliveryScheduleSettlDay.Value);
				if (LegDeliveryScheduleSettlTotalHours is not null) writer.WriteWholeNumber(41424, LegDeliveryScheduleSettlTotalHours.Value);
				if (LegDeliveryScheduleSettlTimeGrp is not null) ((IFixEncoder)LegDeliveryScheduleSettlTimeGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegDeliveryScheduleSettlDay = view.GetInt32(41423);
				LegDeliveryScheduleSettlTotalHours = view.GetInt32(41424);
				if (view.GetView("LegDeliveryScheduleSettlTimeGrp") is IMessageView viewLegDeliveryScheduleSettlTimeGrp)
				{
					LegDeliveryScheduleSettlTimeGrp = new();
					((IFixParser)LegDeliveryScheduleSettlTimeGrp).Parse(viewLegDeliveryScheduleSettlTimeGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegDeliveryScheduleSettlDay":
					{
						value = LegDeliveryScheduleSettlDay;
						break;
					}
					case "LegDeliveryScheduleSettlTotalHours":
					{
						value = LegDeliveryScheduleSettlTotalHours;
						break;
					}
					case "LegDeliveryScheduleSettlTimeGrp":
					{
						value = LegDeliveryScheduleSettlTimeGrp;
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
				LegDeliveryScheduleSettlDay = null;
				LegDeliveryScheduleSettlTotalHours = null;
				((IFixReset?)LegDeliveryScheduleSettlTimeGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 41422, Offset = 0, Required = false)]
		public NoLegDeliveryScheduleSettlDays[]? LegDeliveryScheduleSettlDays {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegDeliveryScheduleSettlDays is not null && LegDeliveryScheduleSettlDays.Length != 0)
			{
				writer.WriteWholeNumber(41422, LegDeliveryScheduleSettlDays.Length);
				for (int i = 0; i < LegDeliveryScheduleSettlDays.Length; i++)
				{
					((IFixEncoder)LegDeliveryScheduleSettlDays[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegDeliveryScheduleSettlDays") is IMessageView viewNoLegDeliveryScheduleSettlDays)
			{
				var count = viewNoLegDeliveryScheduleSettlDays.GroupCount();
				LegDeliveryScheduleSettlDays = new NoLegDeliveryScheduleSettlDays[count];
				for (int i = 0; i < count; i++)
				{
					LegDeliveryScheduleSettlDays[i] = new();
					((IFixParser)LegDeliveryScheduleSettlDays[i]).Parse(viewNoLegDeliveryScheduleSettlDays.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegDeliveryScheduleSettlDays":
				{
					value = LegDeliveryScheduleSettlDays;
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
			LegDeliveryScheduleSettlDays = null;
		}
	}
}
