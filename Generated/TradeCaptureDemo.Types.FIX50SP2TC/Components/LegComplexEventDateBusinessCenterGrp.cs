using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegComplexEventDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegComplexEventDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 41388, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegComplexEventDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegComplexEventDateBusinessCenter is not null) writer.WriteString(41388, LegComplexEventDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegComplexEventDateBusinessCenter = view.GetString(41388);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegComplexEventDateBusinessCenter":
					{
						value = LegComplexEventDateBusinessCenter;
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
				LegComplexEventDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 41387, Offset = 0, Required = false)]
		public NoLegComplexEventDateBusinessCenters[]? LegComplexEventDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegComplexEventDateBusinessCenters is not null && LegComplexEventDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(41387, LegComplexEventDateBusinessCenters.Length);
				for (int i = 0; i < LegComplexEventDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegComplexEventDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegComplexEventDateBusinessCenters") is IMessageView viewNoLegComplexEventDateBusinessCenters)
			{
				var count = viewNoLegComplexEventDateBusinessCenters.GroupCount();
				LegComplexEventDateBusinessCenters = new NoLegComplexEventDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegComplexEventDateBusinessCenters[i] = new();
					((IFixParser)LegComplexEventDateBusinessCenters[i]).Parse(viewNoLegComplexEventDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegComplexEventDateBusinessCenters":
				{
					value = LegComplexEventDateBusinessCenters;
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
			LegComplexEventDateBusinessCenters = null;
		}
	}
}
