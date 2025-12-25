using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class StreamFirstPeriodStartDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoStreamFirstPeriodStartDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40077, Type = TagType.String, Offset = 0, Required = false)]
			public string? StreamFirstPeriodStartDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (StreamFirstPeriodStartDateBusinessCenter is not null) writer.WriteString(40077, StreamFirstPeriodStartDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				StreamFirstPeriodStartDateBusinessCenter = view.GetString(40077);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "StreamFirstPeriodStartDateBusinessCenter":
					{
						value = StreamFirstPeriodStartDateBusinessCenter;
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
				StreamFirstPeriodStartDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40959, Offset = 0, Required = false)]
		public NoStreamFirstPeriodStartDateBusinessCenters[]? StreamFirstPeriodStartDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (StreamFirstPeriodStartDateBusinessCenters is not null && StreamFirstPeriodStartDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40959, StreamFirstPeriodStartDateBusinessCenters.Length);
				for (int i = 0; i < StreamFirstPeriodStartDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)StreamFirstPeriodStartDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoStreamFirstPeriodStartDateBusinessCenters") is IMessageView viewNoStreamFirstPeriodStartDateBusinessCenters)
			{
				var count = viewNoStreamFirstPeriodStartDateBusinessCenters.GroupCount();
				StreamFirstPeriodStartDateBusinessCenters = new NoStreamFirstPeriodStartDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					StreamFirstPeriodStartDateBusinessCenters[i] = new();
					((IFixParser)StreamFirstPeriodStartDateBusinessCenters[i]).Parse(viewNoStreamFirstPeriodStartDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoStreamFirstPeriodStartDateBusinessCenters":
				{
					value = StreamFirstPeriodStartDateBusinessCenters;
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
			StreamFirstPeriodStartDateBusinessCenters = null;
		}
	}
}
