using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ProtectionTermEventGrp : IFixComponent
	{
		public sealed partial class NoProtectionTermEvents : IFixGroup
		{
			[TagDetails(Tag = 40192, Type = TagType.String, Offset = 0, Required = false)]
			public string? ProtectionTermEventType {get; set;}
			
			[TagDetails(Tag = 40193, Type = TagType.String, Offset = 1, Required = false)]
			public string? ProtectionTermEventValue {get; set;}
			
			[TagDetails(Tag = 40194, Type = TagType.String, Offset = 2, Required = false)]
			public string? ProtectionTermEventCurrency {get; set;}
			
			[TagDetails(Tag = 40195, Type = TagType.Int, Offset = 3, Required = false)]
			public int? ProtectionTermEventPeriod {get; set;}
			
			[TagDetails(Tag = 40196, Type = TagType.String, Offset = 4, Required = false)]
			public string? ProtectionTermEventUnit {get; set;}
			
			[TagDetails(Tag = 40197, Type = TagType.Int, Offset = 5, Required = false)]
			public int? ProtectionTermEventDayType {get; set;}
			
			[TagDetails(Tag = 40198, Type = TagType.String, Offset = 6, Required = false)]
			public string? ProtectionTermEventRateSource {get; set;}
			
			[Component(Offset = 7, Required = false)]
			public ProtectionTermEventQualifierGrp? ProtectionTermEventQualifierGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ProtectionTermEventType is not null) writer.WriteString(40192, ProtectionTermEventType);
				if (ProtectionTermEventValue is not null) writer.WriteString(40193, ProtectionTermEventValue);
				if (ProtectionTermEventCurrency is not null) writer.WriteString(40194, ProtectionTermEventCurrency);
				if (ProtectionTermEventPeriod is not null) writer.WriteWholeNumber(40195, ProtectionTermEventPeriod.Value);
				if (ProtectionTermEventUnit is not null) writer.WriteString(40196, ProtectionTermEventUnit);
				if (ProtectionTermEventDayType is not null) writer.WriteWholeNumber(40197, ProtectionTermEventDayType.Value);
				if (ProtectionTermEventRateSource is not null) writer.WriteString(40198, ProtectionTermEventRateSource);
				if (ProtectionTermEventQualifierGrp is not null) ((IFixEncoder)ProtectionTermEventQualifierGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ProtectionTermEventType = view.GetString(40192);
				ProtectionTermEventValue = view.GetString(40193);
				ProtectionTermEventCurrency = view.GetString(40194);
				ProtectionTermEventPeriod = view.GetInt32(40195);
				ProtectionTermEventUnit = view.GetString(40196);
				ProtectionTermEventDayType = view.GetInt32(40197);
				ProtectionTermEventRateSource = view.GetString(40198);
				if (view.GetView("ProtectionTermEventQualifierGrp") is IMessageView viewProtectionTermEventQualifierGrp)
				{
					ProtectionTermEventQualifierGrp = new();
					((IFixParser)ProtectionTermEventQualifierGrp).Parse(viewProtectionTermEventQualifierGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ProtectionTermEventType":
					{
						value = ProtectionTermEventType;
						break;
					}
					case "ProtectionTermEventValue":
					{
						value = ProtectionTermEventValue;
						break;
					}
					case "ProtectionTermEventCurrency":
					{
						value = ProtectionTermEventCurrency;
						break;
					}
					case "ProtectionTermEventPeriod":
					{
						value = ProtectionTermEventPeriod;
						break;
					}
					case "ProtectionTermEventUnit":
					{
						value = ProtectionTermEventUnit;
						break;
					}
					case "ProtectionTermEventDayType":
					{
						value = ProtectionTermEventDayType;
						break;
					}
					case "ProtectionTermEventRateSource":
					{
						value = ProtectionTermEventRateSource;
						break;
					}
					case "ProtectionTermEventQualifierGrp":
					{
						value = ProtectionTermEventQualifierGrp;
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
				ProtectionTermEventType = null;
				ProtectionTermEventValue = null;
				ProtectionTermEventCurrency = null;
				ProtectionTermEventPeriod = null;
				ProtectionTermEventUnit = null;
				ProtectionTermEventDayType = null;
				ProtectionTermEventRateSource = null;
				((IFixReset?)ProtectionTermEventQualifierGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 40191, Offset = 0, Required = false)]
		public NoProtectionTermEvents[]? ProtectionTermEvents {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ProtectionTermEvents is not null && ProtectionTermEvents.Length != 0)
			{
				writer.WriteWholeNumber(40191, ProtectionTermEvents.Length);
				for (int i = 0; i < ProtectionTermEvents.Length; i++)
				{
					((IFixEncoder)ProtectionTermEvents[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoProtectionTermEvents") is IMessageView viewNoProtectionTermEvents)
			{
				var count = viewNoProtectionTermEvents.GroupCount();
				ProtectionTermEvents = new NoProtectionTermEvents[count];
				for (int i = 0; i < count; i++)
				{
					ProtectionTermEvents[i] = new();
					((IFixParser)ProtectionTermEvents[i]).Parse(viewNoProtectionTermEvents.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoProtectionTermEvents":
				{
					value = ProtectionTermEvents;
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
			ProtectionTermEvents = null;
		}
	}
}
