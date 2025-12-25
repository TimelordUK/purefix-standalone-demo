using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class EvntGrp : IFixComponent
	{
		public sealed partial class NoEvents : IFixGroup
		{
			[TagDetails(Tag = 865, Type = TagType.Int, Offset = 0, Required = false)]
			public int? EventType {get; set;}
			
			[TagDetails(Tag = 866, Type = TagType.LocalDate, Offset = 1, Required = false)]
			public DateOnly? EventDate {get; set;}
			
			[TagDetails(Tag = 1145, Type = TagType.UtcTimestamp, Offset = 2, Required = false)]
			public DateTime? EventTime {get; set;}
			
			[TagDetails(Tag = 1827, Type = TagType.String, Offset = 3, Required = false)]
			public string? EventTimeUnit {get; set;}
			
			[TagDetails(Tag = 1826, Type = TagType.Int, Offset = 4, Required = false)]
			public int? EventTimePeriod {get; set;}
			
			[TagDetails(Tag = 2340, Type = TagType.MonthYear, Offset = 5, Required = false)]
			public MonthYear? EventMonthYear {get; set;}
			
			[TagDetails(Tag = 867, Type = TagType.Float, Offset = 6, Required = false)]
			public double? EventPx {get; set;}
			
			[TagDetails(Tag = 868, Type = TagType.String, Offset = 7, Required = false)]
			public string? EventText {get; set;}
			
			[TagDetails(Tag = 1578, Type = TagType.Length, Offset = 8, Required = false)]
			public int? EncodedEventTextLen {get; set;}
			
			[TagDetails(Tag = 1579, Type = TagType.RawData, Offset = 9, Required = false)]
			public byte[]? EncodedEventText {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (EventType is not null) writer.WriteWholeNumber(865, EventType.Value);
				if (EventDate is not null) writer.WriteLocalDateOnly(866, EventDate.Value);
				if (EventTime is not null) writer.WriteUtcTimeStamp(1145, EventTime.Value);
				if (EventTimeUnit is not null) writer.WriteString(1827, EventTimeUnit);
				if (EventTimePeriod is not null) writer.WriteWholeNumber(1826, EventTimePeriod.Value);
				if (EventMonthYear is not null) writer.WriteMonthYear(2340, EventMonthYear.Value);
				if (EventPx is not null) writer.WriteNumber(867, EventPx.Value);
				if (EventText is not null) writer.WriteString(868, EventText);
				if (EncodedEventTextLen is not null) writer.WriteWholeNumber(1578, EncodedEventTextLen.Value);
				if (EncodedEventText is not null) writer.WriteBuffer(1579, EncodedEventText);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				EventType = view.GetInt32(865);
				EventDate = view.GetDateOnly(866);
				EventTime = view.GetDateTime(1145);
				EventTimeUnit = view.GetString(1827);
				EventTimePeriod = view.GetInt32(1826);
				EventMonthYear = view.GetMonthYear(2340);
				EventPx = view.GetDouble(867);
				EventText = view.GetString(868);
				EncodedEventTextLen = view.GetInt32(1578);
				EncodedEventText = view.GetByteArray(1579);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "EventType":
					{
						value = EventType;
						break;
					}
					case "EventDate":
					{
						value = EventDate;
						break;
					}
					case "EventTime":
					{
						value = EventTime;
						break;
					}
					case "EventTimeUnit":
					{
						value = EventTimeUnit;
						break;
					}
					case "EventTimePeriod":
					{
						value = EventTimePeriod;
						break;
					}
					case "EventMonthYear":
					{
						value = EventMonthYear;
						break;
					}
					case "EventPx":
					{
						value = EventPx;
						break;
					}
					case "EventText":
					{
						value = EventText;
						break;
					}
					case "EncodedEventTextLen":
					{
						value = EncodedEventTextLen;
						break;
					}
					case "EncodedEventText":
					{
						value = EncodedEventText;
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
				EventType = null;
				EventDate = null;
				EventTime = null;
				EventTimeUnit = null;
				EventTimePeriod = null;
				EventMonthYear = null;
				EventPx = null;
				EventText = null;
				EncodedEventTextLen = null;
				EncodedEventText = null;
			}
		}
		[Group(NoOfTag = 864, Offset = 0, Required = false)]
		public NoEvents[]? Events {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Events is not null && Events.Length != 0)
			{
				writer.WriteWholeNumber(864, Events.Length);
				for (int i = 0; i < Events.Length; i++)
				{
					((IFixEncoder)Events[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoEvents") is IMessageView viewNoEvents)
			{
				var count = viewNoEvents.GroupCount();
				Events = new NoEvents[count];
				for (int i = 0; i < count; i++)
				{
					Events[i] = new();
					((IFixParser)Events[i]).Parse(viewNoEvents.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoEvents":
				{
					value = Events;
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
			Events = null;
		}
	}
}
