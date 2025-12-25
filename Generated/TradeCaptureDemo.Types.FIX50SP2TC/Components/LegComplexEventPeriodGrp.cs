using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegComplexEventPeriodGrp : IFixComponent
	{
		public sealed partial class NoLegComplexEventPeriods : IFixGroup
		{
			[TagDetails(Tag = 41380, Type = TagType.Int, Offset = 0, Required = false)]
			public int? LegComplexEventPeriodType {get; set;}
			
			[TagDetails(Tag = 41381, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegComplexEventBusinessCenter {get; set;}
			
			[Component(Offset = 2, Required = false)]
			public LegComplexEventScheduleGrp? LegComplexEventScheduleGrp {get; set;}
			
			[Component(Offset = 3, Required = false)]
			public LegComplexEventPeriodDateGrp? LegComplexEventPeriodDateGrp {get; set;}
			
			[Component(Offset = 4, Required = false)]
			public LegComplexEventAveragingObservationGrp? LegComplexEventAveragingObservationGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegComplexEventPeriodType is not null) writer.WriteWholeNumber(41380, LegComplexEventPeriodType.Value);
				if (LegComplexEventBusinessCenter is not null) writer.WriteString(41381, LegComplexEventBusinessCenter);
				if (LegComplexEventScheduleGrp is not null) ((IFixEncoder)LegComplexEventScheduleGrp).Encode(writer);
				if (LegComplexEventPeriodDateGrp is not null) ((IFixEncoder)LegComplexEventPeriodDateGrp).Encode(writer);
				if (LegComplexEventAveragingObservationGrp is not null) ((IFixEncoder)LegComplexEventAveragingObservationGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegComplexEventPeriodType = view.GetInt32(41380);
				LegComplexEventBusinessCenter = view.GetString(41381);
				if (view.GetView("LegComplexEventScheduleGrp") is IMessageView viewLegComplexEventScheduleGrp)
				{
					LegComplexEventScheduleGrp = new();
					((IFixParser)LegComplexEventScheduleGrp).Parse(viewLegComplexEventScheduleGrp);
				}
				if (view.GetView("LegComplexEventPeriodDateGrp") is IMessageView viewLegComplexEventPeriodDateGrp)
				{
					LegComplexEventPeriodDateGrp = new();
					((IFixParser)LegComplexEventPeriodDateGrp).Parse(viewLegComplexEventPeriodDateGrp);
				}
				if (view.GetView("LegComplexEventAveragingObservationGrp") is IMessageView viewLegComplexEventAveragingObservationGrp)
				{
					LegComplexEventAveragingObservationGrp = new();
					((IFixParser)LegComplexEventAveragingObservationGrp).Parse(viewLegComplexEventAveragingObservationGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegComplexEventPeriodType":
					{
						value = LegComplexEventPeriodType;
						break;
					}
					case "LegComplexEventBusinessCenter":
					{
						value = LegComplexEventBusinessCenter;
						break;
					}
					case "LegComplexEventScheduleGrp":
					{
						value = LegComplexEventScheduleGrp;
						break;
					}
					case "LegComplexEventPeriodDateGrp":
					{
						value = LegComplexEventPeriodDateGrp;
						break;
					}
					case "LegComplexEventAveragingObservationGrp":
					{
						value = LegComplexEventAveragingObservationGrp;
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
				LegComplexEventPeriodType = null;
				LegComplexEventBusinessCenter = null;
				((IFixReset?)LegComplexEventScheduleGrp)?.Reset();
				((IFixReset?)LegComplexEventPeriodDateGrp)?.Reset();
				((IFixReset?)LegComplexEventAveragingObservationGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 41379, Offset = 0, Required = false)]
		public NoLegComplexEventPeriods[]? LegComplexEventPeriods {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegComplexEventPeriods is not null && LegComplexEventPeriods.Length != 0)
			{
				writer.WriteWholeNumber(41379, LegComplexEventPeriods.Length);
				for (int i = 0; i < LegComplexEventPeriods.Length; i++)
				{
					((IFixEncoder)LegComplexEventPeriods[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegComplexEventPeriods") is IMessageView viewNoLegComplexEventPeriods)
			{
				var count = viewNoLegComplexEventPeriods.GroupCount();
				LegComplexEventPeriods = new NoLegComplexEventPeriods[count];
				for (int i = 0; i < count; i++)
				{
					LegComplexEventPeriods[i] = new();
					((IFixParser)LegComplexEventPeriods[i]).Parse(viewNoLegComplexEventPeriods.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegComplexEventPeriods":
				{
					value = LegComplexEventPeriods;
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
			LegComplexEventPeriods = null;
		}
	}
}
