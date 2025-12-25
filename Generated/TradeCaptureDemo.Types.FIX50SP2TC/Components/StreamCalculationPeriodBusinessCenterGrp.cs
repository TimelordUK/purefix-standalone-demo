using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class StreamCalculationPeriodBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoStreamCalculationPeriodBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40074, Type = TagType.String, Offset = 0, Required = false)]
			public string? StreamCalculationPeriodBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (StreamCalculationPeriodBusinessCenter is not null) writer.WriteString(40074, StreamCalculationPeriodBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				StreamCalculationPeriodBusinessCenter = view.GetString(40074);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "StreamCalculationPeriodBusinessCenter":
					{
						value = StreamCalculationPeriodBusinessCenter;
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
				StreamCalculationPeriodBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40958, Offset = 0, Required = false)]
		public NoStreamCalculationPeriodBusinessCenters[]? StreamCalculationPeriodBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (StreamCalculationPeriodBusinessCenters is not null && StreamCalculationPeriodBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40958, StreamCalculationPeriodBusinessCenters.Length);
				for (int i = 0; i < StreamCalculationPeriodBusinessCenters.Length; i++)
				{
					((IFixEncoder)StreamCalculationPeriodBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoStreamCalculationPeriodBusinessCenters") is IMessageView viewNoStreamCalculationPeriodBusinessCenters)
			{
				var count = viewNoStreamCalculationPeriodBusinessCenters.GroupCount();
				StreamCalculationPeriodBusinessCenters = new NoStreamCalculationPeriodBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					StreamCalculationPeriodBusinessCenters[i] = new();
					((IFixParser)StreamCalculationPeriodBusinessCenters[i]).Parse(viewNoStreamCalculationPeriodBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoStreamCalculationPeriodBusinessCenters":
				{
					value = StreamCalculationPeriodBusinessCenters;
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
			StreamCalculationPeriodBusinessCenters = null;
		}
	}
}
