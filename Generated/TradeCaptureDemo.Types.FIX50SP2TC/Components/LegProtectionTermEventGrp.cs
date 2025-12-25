using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegProtectionTermEventGrp : IFixComponent
	{
		public sealed partial class NoLegProtectionTermEvents : IFixGroup
		{
			[TagDetails(Tag = 41626, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegProtectionTermEventType {get; set;}
			
			[TagDetails(Tag = 41627, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegProtectionTermEventValue {get; set;}
			
			[TagDetails(Tag = 41628, Type = TagType.String, Offset = 2, Required = false)]
			public string? LegProtectionTermEventCurrency {get; set;}
			
			[TagDetails(Tag = 41629, Type = TagType.Int, Offset = 3, Required = false)]
			public int? LegProtectionTermEventPeriod {get; set;}
			
			[TagDetails(Tag = 41630, Type = TagType.String, Offset = 4, Required = false)]
			public string? LegProtectionTermEventUnit {get; set;}
			
			[TagDetails(Tag = 41631, Type = TagType.Int, Offset = 5, Required = false)]
			public int? LegProtectionTermEventDayType {get; set;}
			
			[TagDetails(Tag = 41632, Type = TagType.String, Offset = 6, Required = false)]
			public string? LegProtectionTermEventRateSource {get; set;}
			
			[Component(Offset = 7, Required = false)]
			public LegProtectionTermEventQualifierGrp? LegProtectionTermEventQualifierGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegProtectionTermEventType is not null) writer.WriteString(41626, LegProtectionTermEventType);
				if (LegProtectionTermEventValue is not null) writer.WriteString(41627, LegProtectionTermEventValue);
				if (LegProtectionTermEventCurrency is not null) writer.WriteString(41628, LegProtectionTermEventCurrency);
				if (LegProtectionTermEventPeriod is not null) writer.WriteWholeNumber(41629, LegProtectionTermEventPeriod.Value);
				if (LegProtectionTermEventUnit is not null) writer.WriteString(41630, LegProtectionTermEventUnit);
				if (LegProtectionTermEventDayType is not null) writer.WriteWholeNumber(41631, LegProtectionTermEventDayType.Value);
				if (LegProtectionTermEventRateSource is not null) writer.WriteString(41632, LegProtectionTermEventRateSource);
				if (LegProtectionTermEventQualifierGrp is not null) ((IFixEncoder)LegProtectionTermEventQualifierGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegProtectionTermEventType = view.GetString(41626);
				LegProtectionTermEventValue = view.GetString(41627);
				LegProtectionTermEventCurrency = view.GetString(41628);
				LegProtectionTermEventPeriod = view.GetInt32(41629);
				LegProtectionTermEventUnit = view.GetString(41630);
				LegProtectionTermEventDayType = view.GetInt32(41631);
				LegProtectionTermEventRateSource = view.GetString(41632);
				if (view.GetView("LegProtectionTermEventQualifierGrp") is IMessageView viewLegProtectionTermEventQualifierGrp)
				{
					LegProtectionTermEventQualifierGrp = new();
					((IFixParser)LegProtectionTermEventQualifierGrp).Parse(viewLegProtectionTermEventQualifierGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegProtectionTermEventType":
					{
						value = LegProtectionTermEventType;
						break;
					}
					case "LegProtectionTermEventValue":
					{
						value = LegProtectionTermEventValue;
						break;
					}
					case "LegProtectionTermEventCurrency":
					{
						value = LegProtectionTermEventCurrency;
						break;
					}
					case "LegProtectionTermEventPeriod":
					{
						value = LegProtectionTermEventPeriod;
						break;
					}
					case "LegProtectionTermEventUnit":
					{
						value = LegProtectionTermEventUnit;
						break;
					}
					case "LegProtectionTermEventDayType":
					{
						value = LegProtectionTermEventDayType;
						break;
					}
					case "LegProtectionTermEventRateSource":
					{
						value = LegProtectionTermEventRateSource;
						break;
					}
					case "LegProtectionTermEventQualifierGrp":
					{
						value = LegProtectionTermEventQualifierGrp;
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
				LegProtectionTermEventType = null;
				LegProtectionTermEventValue = null;
				LegProtectionTermEventCurrency = null;
				LegProtectionTermEventPeriod = null;
				LegProtectionTermEventUnit = null;
				LegProtectionTermEventDayType = null;
				LegProtectionTermEventRateSource = null;
				((IFixReset?)LegProtectionTermEventQualifierGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 41625, Offset = 0, Required = false)]
		public NoLegProtectionTermEvents[]? LegProtectionTermEvents {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegProtectionTermEvents is not null && LegProtectionTermEvents.Length != 0)
			{
				writer.WriteWholeNumber(41625, LegProtectionTermEvents.Length);
				for (int i = 0; i < LegProtectionTermEvents.Length; i++)
				{
					((IFixEncoder)LegProtectionTermEvents[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegProtectionTermEvents") is IMessageView viewNoLegProtectionTermEvents)
			{
				var count = viewNoLegProtectionTermEvents.GroupCount();
				LegProtectionTermEvents = new NoLegProtectionTermEvents[count];
				for (int i = 0; i < count; i++)
				{
					LegProtectionTermEvents[i] = new();
					((IFixParser)LegProtectionTermEvents[i]).Parse(viewNoLegProtectionTermEvents.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegProtectionTermEvents":
				{
					value = LegProtectionTermEvents;
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
			LegProtectionTermEvents = null;
		}
	}
}
