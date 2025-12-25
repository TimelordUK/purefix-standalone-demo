using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40924, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegBusinessCenter is not null) writer.WriteString(40924, LegBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegBusinessCenter = view.GetString(40924);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegBusinessCenter":
					{
						value = LegBusinessCenter;
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
				LegBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40923, Offset = 0, Required = false)]
		public NoLegBusinessCenters[]? LegBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegBusinessCenters is not null && LegBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40923, LegBusinessCenters.Length);
				for (int i = 0; i < LegBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegBusinessCenters") is IMessageView viewNoLegBusinessCenters)
			{
				var count = viewNoLegBusinessCenters.GroupCount();
				LegBusinessCenters = new NoLegBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegBusinessCenters[i] = new();
					((IFixParser)LegBusinessCenters[i]).Parse(viewNoLegBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegBusinessCenters":
				{
					value = LegBusinessCenters;
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
			LegBusinessCenters = null;
		}
	}
}
