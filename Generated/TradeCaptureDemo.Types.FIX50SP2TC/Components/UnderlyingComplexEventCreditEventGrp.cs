using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingComplexEventCreditEventGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingComplexEventCreditEvents : IFixGroup
		{
			[TagDetails(Tag = 41717, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingComplexEventCreditEventType {get; set;}
			
			[TagDetails(Tag = 41718, Type = TagType.String, Offset = 1, Required = false)]
			public string? UnderlyingComplexEventCreditEventValue {get; set;}
			
			[TagDetails(Tag = 41719, Type = TagType.String, Offset = 2, Required = false)]
			public string? UnderlyingComplexEventCreditEventCurrency {get; set;}
			
			[TagDetails(Tag = 41720, Type = TagType.Int, Offset = 3, Required = false)]
			public int? UnderlyingComplexEventCreditEventPeriod {get; set;}
			
			[TagDetails(Tag = 41721, Type = TagType.String, Offset = 4, Required = false)]
			public string? UnderlyingComplexEventCreditEventUnit {get; set;}
			
			[TagDetails(Tag = 41722, Type = TagType.Int, Offset = 5, Required = false)]
			public int? UnderlyingComplexEventCreditEventDayType {get; set;}
			
			[TagDetails(Tag = 41723, Type = TagType.Int, Offset = 6, Required = false)]
			public int? UnderlyingComplexEventCreditEventRateSource {get; set;}
			
			[Component(Offset = 7, Required = false)]
			public UnderlyingComplexEventCreditEventQualifierGrp? UnderlyingComplexEventCreditEventQualifierGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingComplexEventCreditEventType is not null) writer.WriteString(41717, UnderlyingComplexEventCreditEventType);
				if (UnderlyingComplexEventCreditEventValue is not null) writer.WriteString(41718, UnderlyingComplexEventCreditEventValue);
				if (UnderlyingComplexEventCreditEventCurrency is not null) writer.WriteString(41719, UnderlyingComplexEventCreditEventCurrency);
				if (UnderlyingComplexEventCreditEventPeriod is not null) writer.WriteWholeNumber(41720, UnderlyingComplexEventCreditEventPeriod.Value);
				if (UnderlyingComplexEventCreditEventUnit is not null) writer.WriteString(41721, UnderlyingComplexEventCreditEventUnit);
				if (UnderlyingComplexEventCreditEventDayType is not null) writer.WriteWholeNumber(41722, UnderlyingComplexEventCreditEventDayType.Value);
				if (UnderlyingComplexEventCreditEventRateSource is not null) writer.WriteWholeNumber(41723, UnderlyingComplexEventCreditEventRateSource.Value);
				if (UnderlyingComplexEventCreditEventQualifierGrp is not null) ((IFixEncoder)UnderlyingComplexEventCreditEventQualifierGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingComplexEventCreditEventType = view.GetString(41717);
				UnderlyingComplexEventCreditEventValue = view.GetString(41718);
				UnderlyingComplexEventCreditEventCurrency = view.GetString(41719);
				UnderlyingComplexEventCreditEventPeriod = view.GetInt32(41720);
				UnderlyingComplexEventCreditEventUnit = view.GetString(41721);
				UnderlyingComplexEventCreditEventDayType = view.GetInt32(41722);
				UnderlyingComplexEventCreditEventRateSource = view.GetInt32(41723);
				if (view.GetView("UnderlyingComplexEventCreditEventQualifierGrp") is IMessageView viewUnderlyingComplexEventCreditEventQualifierGrp)
				{
					UnderlyingComplexEventCreditEventQualifierGrp = new();
					((IFixParser)UnderlyingComplexEventCreditEventQualifierGrp).Parse(viewUnderlyingComplexEventCreditEventQualifierGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingComplexEventCreditEventType":
					{
						value = UnderlyingComplexEventCreditEventType;
						break;
					}
					case "UnderlyingComplexEventCreditEventValue":
					{
						value = UnderlyingComplexEventCreditEventValue;
						break;
					}
					case "UnderlyingComplexEventCreditEventCurrency":
					{
						value = UnderlyingComplexEventCreditEventCurrency;
						break;
					}
					case "UnderlyingComplexEventCreditEventPeriod":
					{
						value = UnderlyingComplexEventCreditEventPeriod;
						break;
					}
					case "UnderlyingComplexEventCreditEventUnit":
					{
						value = UnderlyingComplexEventCreditEventUnit;
						break;
					}
					case "UnderlyingComplexEventCreditEventDayType":
					{
						value = UnderlyingComplexEventCreditEventDayType;
						break;
					}
					case "UnderlyingComplexEventCreditEventRateSource":
					{
						value = UnderlyingComplexEventCreditEventRateSource;
						break;
					}
					case "UnderlyingComplexEventCreditEventQualifierGrp":
					{
						value = UnderlyingComplexEventCreditEventQualifierGrp;
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
				UnderlyingComplexEventCreditEventType = null;
				UnderlyingComplexEventCreditEventValue = null;
				UnderlyingComplexEventCreditEventCurrency = null;
				UnderlyingComplexEventCreditEventPeriod = null;
				UnderlyingComplexEventCreditEventUnit = null;
				UnderlyingComplexEventCreditEventDayType = null;
				UnderlyingComplexEventCreditEventRateSource = null;
				((IFixReset?)UnderlyingComplexEventCreditEventQualifierGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 41716, Offset = 0, Required = false)]
		public NoUnderlyingComplexEventCreditEvents[]? UnderlyingComplexEventCreditEvents {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingComplexEventCreditEvents is not null && UnderlyingComplexEventCreditEvents.Length != 0)
			{
				writer.WriteWholeNumber(41716, UnderlyingComplexEventCreditEvents.Length);
				for (int i = 0; i < UnderlyingComplexEventCreditEvents.Length; i++)
				{
					((IFixEncoder)UnderlyingComplexEventCreditEvents[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingComplexEventCreditEvents") is IMessageView viewNoUnderlyingComplexEventCreditEvents)
			{
				var count = viewNoUnderlyingComplexEventCreditEvents.GroupCount();
				UnderlyingComplexEventCreditEvents = new NoUnderlyingComplexEventCreditEvents[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingComplexEventCreditEvents[i] = new();
					((IFixParser)UnderlyingComplexEventCreditEvents[i]).Parse(viewNoUnderlyingComplexEventCreditEvents.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingComplexEventCreditEvents":
				{
					value = UnderlyingComplexEventCreditEvents;
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
			UnderlyingComplexEventCreditEvents = null;
		}
	}
}
