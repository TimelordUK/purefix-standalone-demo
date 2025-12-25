using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class StreamTerminationDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoStreamTerminationDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40067, Type = TagType.String, Offset = 0, Required = false)]
			public string? StreamTerminationDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (StreamTerminationDateBusinessCenter is not null) writer.WriteString(40067, StreamTerminationDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				StreamTerminationDateBusinessCenter = view.GetString(40067);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "StreamTerminationDateBusinessCenter":
					{
						value = StreamTerminationDateBusinessCenter;
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
				StreamTerminationDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40961, Offset = 0, Required = false)]
		public NoStreamTerminationDateBusinessCenters[]? StreamTerminationDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (StreamTerminationDateBusinessCenters is not null && StreamTerminationDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40961, StreamTerminationDateBusinessCenters.Length);
				for (int i = 0; i < StreamTerminationDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)StreamTerminationDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoStreamTerminationDateBusinessCenters") is IMessageView viewNoStreamTerminationDateBusinessCenters)
			{
				var count = viewNoStreamTerminationDateBusinessCenters.GroupCount();
				StreamTerminationDateBusinessCenters = new NoStreamTerminationDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					StreamTerminationDateBusinessCenters[i] = new();
					((IFixParser)StreamTerminationDateBusinessCenters[i]).Parse(viewNoStreamTerminationDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoStreamTerminationDateBusinessCenters":
				{
					value = StreamTerminationDateBusinessCenters;
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
			StreamTerminationDateBusinessCenters = null;
		}
	}
}
