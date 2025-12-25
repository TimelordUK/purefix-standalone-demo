using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ComplexEventDates : IFixComponent
	{
		public sealed partial class NoComplexEventDates : IFixGroup
		{
			[TagDetails(Tag = 1492, Type = TagType.UtcDateOnly, Offset = 0, Required = false)]
			public DateOnly? ComplexEventStartDate {get; set;}
			
			[TagDetails(Tag = 1493, Type = TagType.UtcDateOnly, Offset = 1, Required = false)]
			public DateOnly? ComplexEventEndDate {get; set;}
			
			[Component(Offset = 2, Required = false)]
			public ComplexEventTimes? ComplexEventTimes {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ComplexEventStartDate is not null) writer.WriteUtcDateOnly(1492, ComplexEventStartDate.Value);
				if (ComplexEventEndDate is not null) writer.WriteUtcDateOnly(1493, ComplexEventEndDate.Value);
				if (ComplexEventTimes is not null) ((IFixEncoder)ComplexEventTimes).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ComplexEventStartDate = view.GetDateOnly(1492);
				ComplexEventEndDate = view.GetDateOnly(1493);
				if (view.GetView("ComplexEventTimes") is IMessageView viewComplexEventTimes)
				{
					ComplexEventTimes = new();
					((IFixParser)ComplexEventTimes).Parse(viewComplexEventTimes);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ComplexEventStartDate":
					{
						value = ComplexEventStartDate;
						break;
					}
					case "ComplexEventEndDate":
					{
						value = ComplexEventEndDate;
						break;
					}
					case "ComplexEventTimes":
					{
						value = ComplexEventTimes;
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
				ComplexEventStartDate = null;
				ComplexEventEndDate = null;
				((IFixReset?)ComplexEventTimes)?.Reset();
			}
		}
		[Group(NoOfTag = 1491, Offset = 0, Required = false)]
		public NoComplexEventDates[]? ComplexEventDatesItems {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ComplexEventDatesItems is not null && ComplexEventDatesItems.Length != 0)
			{
				writer.WriteWholeNumber(1491, ComplexEventDatesItems.Length);
				for (int i = 0; i < ComplexEventDatesItems.Length; i++)
				{
					((IFixEncoder)ComplexEventDatesItems[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoComplexEventDates") is IMessageView viewNoComplexEventDates)
			{
				var count = viewNoComplexEventDates.GroupCount();
				ComplexEventDatesItems = new NoComplexEventDates[count];
				for (int i = 0; i < count; i++)
				{
					ComplexEventDatesItems[i] = new();
					((IFixParser)ComplexEventDatesItems[i]).Parse(viewNoComplexEventDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoComplexEventDates":
				{
					value = ComplexEventDatesItems;
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
			ComplexEventDatesItems = null;
		}
	}
}
