using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegStreamTerminationDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegStreamTerminationDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40259, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegStreamTerminationDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegStreamTerminationDateBusinessCenter is not null) writer.WriteString(40259, LegStreamTerminationDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegStreamTerminationDateBusinessCenter = view.GetString(40259);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegStreamTerminationDateBusinessCenter":
					{
						value = LegStreamTerminationDateBusinessCenter;
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
				LegStreamTerminationDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40943, Offset = 0, Required = false)]
		public NoLegStreamTerminationDateBusinessCenters[]? LegStreamTerminationDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegStreamTerminationDateBusinessCenters is not null && LegStreamTerminationDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40943, LegStreamTerminationDateBusinessCenters.Length);
				for (int i = 0; i < LegStreamTerminationDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegStreamTerminationDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegStreamTerminationDateBusinessCenters") is IMessageView viewNoLegStreamTerminationDateBusinessCenters)
			{
				var count = viewNoLegStreamTerminationDateBusinessCenters.GroupCount();
				LegStreamTerminationDateBusinessCenters = new NoLegStreamTerminationDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegStreamTerminationDateBusinessCenters[i] = new();
					((IFixParser)LegStreamTerminationDateBusinessCenters[i]).Parse(viewNoLegStreamTerminationDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegStreamTerminationDateBusinessCenters":
				{
					value = LegStreamTerminationDateBusinessCenters;
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
			LegStreamTerminationDateBusinessCenters = null;
		}
	}
}
