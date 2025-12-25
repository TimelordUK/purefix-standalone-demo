using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ComplexEventPeriodGrp : IFixComponent
	{
		public sealed partial class NoComplexEventPeriods : IFixGroup
		{
			[TagDetails(Tag = 41011, Type = TagType.Int, Offset = 0, Required = false)]
			public int? ComplexEventPeriodType {get; set;}
			
			[TagDetails(Tag = 41012, Type = TagType.String, Offset = 1, Required = false)]
			public string? ComplexEventBusinessCenter {get; set;}
			
			[Component(Offset = 2, Required = false)]
			public ComplexEventScheduleGrp? ComplexEventScheduleGrp {get; set;}
			
			[Component(Offset = 3, Required = false)]
			public ComplexEventPeriodDateGrp? ComplexEventPeriodDateGrp {get; set;}
			
			[Component(Offset = 4, Required = false)]
			public ComplexEventAveragingObservationGrp? ComplexEventAveragingObservationGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ComplexEventPeriodType is not null) writer.WriteWholeNumber(41011, ComplexEventPeriodType.Value);
				if (ComplexEventBusinessCenter is not null) writer.WriteString(41012, ComplexEventBusinessCenter);
				if (ComplexEventScheduleGrp is not null) ((IFixEncoder)ComplexEventScheduleGrp).Encode(writer);
				if (ComplexEventPeriodDateGrp is not null) ((IFixEncoder)ComplexEventPeriodDateGrp).Encode(writer);
				if (ComplexEventAveragingObservationGrp is not null) ((IFixEncoder)ComplexEventAveragingObservationGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ComplexEventPeriodType = view.GetInt32(41011);
				ComplexEventBusinessCenter = view.GetString(41012);
				if (view.GetView("ComplexEventScheduleGrp") is IMessageView viewComplexEventScheduleGrp)
				{
					ComplexEventScheduleGrp = new();
					((IFixParser)ComplexEventScheduleGrp).Parse(viewComplexEventScheduleGrp);
				}
				if (view.GetView("ComplexEventPeriodDateGrp") is IMessageView viewComplexEventPeriodDateGrp)
				{
					ComplexEventPeriodDateGrp = new();
					((IFixParser)ComplexEventPeriodDateGrp).Parse(viewComplexEventPeriodDateGrp);
				}
				if (view.GetView("ComplexEventAveragingObservationGrp") is IMessageView viewComplexEventAveragingObservationGrp)
				{
					ComplexEventAveragingObservationGrp = new();
					((IFixParser)ComplexEventAveragingObservationGrp).Parse(viewComplexEventAveragingObservationGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ComplexEventPeriodType":
					{
						value = ComplexEventPeriodType;
						break;
					}
					case "ComplexEventBusinessCenter":
					{
						value = ComplexEventBusinessCenter;
						break;
					}
					case "ComplexEventScheduleGrp":
					{
						value = ComplexEventScheduleGrp;
						break;
					}
					case "ComplexEventPeriodDateGrp":
					{
						value = ComplexEventPeriodDateGrp;
						break;
					}
					case "ComplexEventAveragingObservationGrp":
					{
						value = ComplexEventAveragingObservationGrp;
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
				ComplexEventPeriodType = null;
				ComplexEventBusinessCenter = null;
				((IFixReset?)ComplexEventScheduleGrp)?.Reset();
				((IFixReset?)ComplexEventPeriodDateGrp)?.Reset();
				((IFixReset?)ComplexEventAveragingObservationGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 41010, Offset = 0, Required = false)]
		public NoComplexEventPeriods[]? ComplexEventPeriods {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ComplexEventPeriods is not null && ComplexEventPeriods.Length != 0)
			{
				writer.WriteWholeNumber(41010, ComplexEventPeriods.Length);
				for (int i = 0; i < ComplexEventPeriods.Length; i++)
				{
					((IFixEncoder)ComplexEventPeriods[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoComplexEventPeriods") is IMessageView viewNoComplexEventPeriods)
			{
				var count = viewNoComplexEventPeriods.GroupCount();
				ComplexEventPeriods = new NoComplexEventPeriods[count];
				for (int i = 0; i < count; i++)
				{
					ComplexEventPeriods[i] = new();
					((IFixParser)ComplexEventPeriods[i]).Parse(viewNoComplexEventPeriods.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoComplexEventPeriods":
				{
					value = ComplexEventPeriods;
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
			ComplexEventPeriods = null;
		}
	}
}
