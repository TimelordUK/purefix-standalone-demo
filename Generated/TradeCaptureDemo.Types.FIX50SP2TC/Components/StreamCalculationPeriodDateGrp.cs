using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class StreamCalculationPeriodDateGrp : IFixComponent
	{
		public sealed partial class NoStreamCalculationPeriodDates : IFixGroup
		{
			[TagDetails(Tag = 41242, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? StreamCalculationPeriodDate {get; set;}
			
			[TagDetails(Tag = 41243, Type = TagType.Int, Offset = 1, Required = false)]
			public int? StreamCalculationPeriodDateType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (StreamCalculationPeriodDate is not null) writer.WriteLocalDateOnly(41242, StreamCalculationPeriodDate.Value);
				if (StreamCalculationPeriodDateType is not null) writer.WriteWholeNumber(41243, StreamCalculationPeriodDateType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				StreamCalculationPeriodDate = view.GetDateOnly(41242);
				StreamCalculationPeriodDateType = view.GetInt32(41243);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "StreamCalculationPeriodDate":
					{
						value = StreamCalculationPeriodDate;
						break;
					}
					case "StreamCalculationPeriodDateType":
					{
						value = StreamCalculationPeriodDateType;
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
				StreamCalculationPeriodDate = null;
				StreamCalculationPeriodDateType = null;
			}
		}
		[Group(NoOfTag = 41241, Offset = 0, Required = false)]
		public NoStreamCalculationPeriodDates[]? StreamCalculationPeriodDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (StreamCalculationPeriodDates is not null && StreamCalculationPeriodDates.Length != 0)
			{
				writer.WriteWholeNumber(41241, StreamCalculationPeriodDates.Length);
				for (int i = 0; i < StreamCalculationPeriodDates.Length; i++)
				{
					((IFixEncoder)StreamCalculationPeriodDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoStreamCalculationPeriodDates") is IMessageView viewNoStreamCalculationPeriodDates)
			{
				var count = viewNoStreamCalculationPeriodDates.GroupCount();
				StreamCalculationPeriodDates = new NoStreamCalculationPeriodDates[count];
				for (int i = 0; i < count; i++)
				{
					StreamCalculationPeriodDates[i] = new();
					((IFixParser)StreamCalculationPeriodDates[i]).Parse(viewNoStreamCalculationPeriodDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoStreamCalculationPeriodDates":
				{
					value = StreamCalculationPeriodDates;
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
			StreamCalculationPeriodDates = null;
		}
	}
}
