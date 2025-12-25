using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegComplexEventCreditEventGrp : IFixComponent
	{
		public sealed partial class NoLegComplexEventCreditEvents : IFixGroup
		{
			[TagDetails(Tag = 41367, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegComplexEventCreditEventType {get; set;}
			
			[TagDetails(Tag = 41368, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegComplexEventCreditEventValue {get; set;}
			
			[TagDetails(Tag = 41369, Type = TagType.String, Offset = 2, Required = false)]
			public string? LegComplexEventCreditEventCurrency {get; set;}
			
			[TagDetails(Tag = 41370, Type = TagType.Int, Offset = 3, Required = false)]
			public int? LegComplexEventCreditEventPeriod {get; set;}
			
			[TagDetails(Tag = 41371, Type = TagType.String, Offset = 4, Required = false)]
			public string? LegComplexEventCreditEventUnit {get; set;}
			
			[TagDetails(Tag = 41372, Type = TagType.Int, Offset = 5, Required = false)]
			public int? LegComplexEventCreditEventDayType {get; set;}
			
			[TagDetails(Tag = 41373, Type = TagType.Int, Offset = 6, Required = false)]
			public int? LegComplexEventCreditEventRateSource {get; set;}
			
			[Component(Offset = 7, Required = false)]
			public LegComplexEventCreditEventQualifierGrp? LegComplexEventCreditEventQualifierGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegComplexEventCreditEventType is not null) writer.WriteString(41367, LegComplexEventCreditEventType);
				if (LegComplexEventCreditEventValue is not null) writer.WriteString(41368, LegComplexEventCreditEventValue);
				if (LegComplexEventCreditEventCurrency is not null) writer.WriteString(41369, LegComplexEventCreditEventCurrency);
				if (LegComplexEventCreditEventPeriod is not null) writer.WriteWholeNumber(41370, LegComplexEventCreditEventPeriod.Value);
				if (LegComplexEventCreditEventUnit is not null) writer.WriteString(41371, LegComplexEventCreditEventUnit);
				if (LegComplexEventCreditEventDayType is not null) writer.WriteWholeNumber(41372, LegComplexEventCreditEventDayType.Value);
				if (LegComplexEventCreditEventRateSource is not null) writer.WriteWholeNumber(41373, LegComplexEventCreditEventRateSource.Value);
				if (LegComplexEventCreditEventQualifierGrp is not null) ((IFixEncoder)LegComplexEventCreditEventQualifierGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegComplexEventCreditEventType = view.GetString(41367);
				LegComplexEventCreditEventValue = view.GetString(41368);
				LegComplexEventCreditEventCurrency = view.GetString(41369);
				LegComplexEventCreditEventPeriod = view.GetInt32(41370);
				LegComplexEventCreditEventUnit = view.GetString(41371);
				LegComplexEventCreditEventDayType = view.GetInt32(41372);
				LegComplexEventCreditEventRateSource = view.GetInt32(41373);
				if (view.GetView("LegComplexEventCreditEventQualifierGrp") is IMessageView viewLegComplexEventCreditEventQualifierGrp)
				{
					LegComplexEventCreditEventQualifierGrp = new();
					((IFixParser)LegComplexEventCreditEventQualifierGrp).Parse(viewLegComplexEventCreditEventQualifierGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegComplexEventCreditEventType":
					{
						value = LegComplexEventCreditEventType;
						break;
					}
					case "LegComplexEventCreditEventValue":
					{
						value = LegComplexEventCreditEventValue;
						break;
					}
					case "LegComplexEventCreditEventCurrency":
					{
						value = LegComplexEventCreditEventCurrency;
						break;
					}
					case "LegComplexEventCreditEventPeriod":
					{
						value = LegComplexEventCreditEventPeriod;
						break;
					}
					case "LegComplexEventCreditEventUnit":
					{
						value = LegComplexEventCreditEventUnit;
						break;
					}
					case "LegComplexEventCreditEventDayType":
					{
						value = LegComplexEventCreditEventDayType;
						break;
					}
					case "LegComplexEventCreditEventRateSource":
					{
						value = LegComplexEventCreditEventRateSource;
						break;
					}
					case "LegComplexEventCreditEventQualifierGrp":
					{
						value = LegComplexEventCreditEventQualifierGrp;
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
				LegComplexEventCreditEventType = null;
				LegComplexEventCreditEventValue = null;
				LegComplexEventCreditEventCurrency = null;
				LegComplexEventCreditEventPeriod = null;
				LegComplexEventCreditEventUnit = null;
				LegComplexEventCreditEventDayType = null;
				LegComplexEventCreditEventRateSource = null;
				((IFixReset?)LegComplexEventCreditEventQualifierGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 41366, Offset = 0, Required = false)]
		public NoLegComplexEventCreditEvents[]? LegComplexEventCreditEvents {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegComplexEventCreditEvents is not null && LegComplexEventCreditEvents.Length != 0)
			{
				writer.WriteWholeNumber(41366, LegComplexEventCreditEvents.Length);
				for (int i = 0; i < LegComplexEventCreditEvents.Length; i++)
				{
					((IFixEncoder)LegComplexEventCreditEvents[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegComplexEventCreditEvents") is IMessageView viewNoLegComplexEventCreditEvents)
			{
				var count = viewNoLegComplexEventCreditEvents.GroupCount();
				LegComplexEventCreditEvents = new NoLegComplexEventCreditEvents[count];
				for (int i = 0; i < count; i++)
				{
					LegComplexEventCreditEvents[i] = new();
					((IFixParser)LegComplexEventCreditEvents[i]).Parse(viewNoLegComplexEventCreditEvents.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegComplexEventCreditEvents":
				{
					value = LegComplexEventCreditEvents;
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
			LegComplexEventCreditEvents = null;
		}
	}
}
