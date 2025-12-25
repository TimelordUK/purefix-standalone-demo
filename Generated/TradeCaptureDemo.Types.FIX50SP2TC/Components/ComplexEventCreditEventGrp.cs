using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ComplexEventCreditEventGrp : IFixComponent
	{
		public sealed partial class NoComplexEventCreditEvents : IFixGroup
		{
			[TagDetails(Tag = 40998, Type = TagType.String, Offset = 0, Required = false)]
			public string? ComplexEventCreditEventType {get; set;}
			
			[TagDetails(Tag = 40999, Type = TagType.String, Offset = 1, Required = false)]
			public string? ComplexEventCreditEventValue {get; set;}
			
			[TagDetails(Tag = 41000, Type = TagType.String, Offset = 2, Required = false)]
			public string? ComplexEventCreditEventCurrency {get; set;}
			
			[TagDetails(Tag = 41001, Type = TagType.Int, Offset = 3, Required = false)]
			public int? ComplexEventCreditEventPeriod {get; set;}
			
			[TagDetails(Tag = 41002, Type = TagType.String, Offset = 4, Required = false)]
			public string? ComplexEventCreditEventUnit {get; set;}
			
			[TagDetails(Tag = 41003, Type = TagType.Int, Offset = 5, Required = false)]
			public int? ComplexEventCreditEventDayType {get; set;}
			
			[TagDetails(Tag = 41004, Type = TagType.Int, Offset = 6, Required = false)]
			public int? ComplexEventCreditEventRateSource {get; set;}
			
			[Component(Offset = 7, Required = false)]
			public ComplexEventCreditEventQualifierGrp? ComplexEventCreditEventQualifierGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ComplexEventCreditEventType is not null) writer.WriteString(40998, ComplexEventCreditEventType);
				if (ComplexEventCreditEventValue is not null) writer.WriteString(40999, ComplexEventCreditEventValue);
				if (ComplexEventCreditEventCurrency is not null) writer.WriteString(41000, ComplexEventCreditEventCurrency);
				if (ComplexEventCreditEventPeriod is not null) writer.WriteWholeNumber(41001, ComplexEventCreditEventPeriod.Value);
				if (ComplexEventCreditEventUnit is not null) writer.WriteString(41002, ComplexEventCreditEventUnit);
				if (ComplexEventCreditEventDayType is not null) writer.WriteWholeNumber(41003, ComplexEventCreditEventDayType.Value);
				if (ComplexEventCreditEventRateSource is not null) writer.WriteWholeNumber(41004, ComplexEventCreditEventRateSource.Value);
				if (ComplexEventCreditEventQualifierGrp is not null) ((IFixEncoder)ComplexEventCreditEventQualifierGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ComplexEventCreditEventType = view.GetString(40998);
				ComplexEventCreditEventValue = view.GetString(40999);
				ComplexEventCreditEventCurrency = view.GetString(41000);
				ComplexEventCreditEventPeriod = view.GetInt32(41001);
				ComplexEventCreditEventUnit = view.GetString(41002);
				ComplexEventCreditEventDayType = view.GetInt32(41003);
				ComplexEventCreditEventRateSource = view.GetInt32(41004);
				if (view.GetView("ComplexEventCreditEventQualifierGrp") is IMessageView viewComplexEventCreditEventQualifierGrp)
				{
					ComplexEventCreditEventQualifierGrp = new();
					((IFixParser)ComplexEventCreditEventQualifierGrp).Parse(viewComplexEventCreditEventQualifierGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ComplexEventCreditEventType":
					{
						value = ComplexEventCreditEventType;
						break;
					}
					case "ComplexEventCreditEventValue":
					{
						value = ComplexEventCreditEventValue;
						break;
					}
					case "ComplexEventCreditEventCurrency":
					{
						value = ComplexEventCreditEventCurrency;
						break;
					}
					case "ComplexEventCreditEventPeriod":
					{
						value = ComplexEventCreditEventPeriod;
						break;
					}
					case "ComplexEventCreditEventUnit":
					{
						value = ComplexEventCreditEventUnit;
						break;
					}
					case "ComplexEventCreditEventDayType":
					{
						value = ComplexEventCreditEventDayType;
						break;
					}
					case "ComplexEventCreditEventRateSource":
					{
						value = ComplexEventCreditEventRateSource;
						break;
					}
					case "ComplexEventCreditEventQualifierGrp":
					{
						value = ComplexEventCreditEventQualifierGrp;
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
				ComplexEventCreditEventType = null;
				ComplexEventCreditEventValue = null;
				ComplexEventCreditEventCurrency = null;
				ComplexEventCreditEventPeriod = null;
				ComplexEventCreditEventUnit = null;
				ComplexEventCreditEventDayType = null;
				ComplexEventCreditEventRateSource = null;
				((IFixReset?)ComplexEventCreditEventQualifierGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 40997, Offset = 0, Required = false)]
		public NoComplexEventCreditEvents[]? ComplexEventCreditEvents {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ComplexEventCreditEvents is not null && ComplexEventCreditEvents.Length != 0)
			{
				writer.WriteWholeNumber(40997, ComplexEventCreditEvents.Length);
				for (int i = 0; i < ComplexEventCreditEvents.Length; i++)
				{
					((IFixEncoder)ComplexEventCreditEvents[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoComplexEventCreditEvents") is IMessageView viewNoComplexEventCreditEvents)
			{
				var count = viewNoComplexEventCreditEvents.GroupCount();
				ComplexEventCreditEvents = new NoComplexEventCreditEvents[count];
				for (int i = 0; i < count; i++)
				{
					ComplexEventCreditEvents[i] = new();
					((IFixParser)ComplexEventCreditEvents[i]).Parse(viewNoComplexEventCreditEvents.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoComplexEventCreditEvents":
				{
					value = ComplexEventCreditEvents;
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
			ComplexEventCreditEvents = null;
		}
	}
}
