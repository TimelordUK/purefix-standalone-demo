using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegStreamEffectiveDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegStreamEffectiveDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40251, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegStreamEffectiveDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegStreamEffectiveDateBusinessCenter is not null) writer.WriteString(40251, LegStreamEffectiveDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegStreamEffectiveDateBusinessCenter = view.GetString(40251);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegStreamEffectiveDateBusinessCenter":
					{
						value = LegStreamEffectiveDateBusinessCenter;
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
				LegStreamEffectiveDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40942, Offset = 0, Required = false)]
		public NoLegStreamEffectiveDateBusinessCenters[]? LegStreamEffectiveDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegStreamEffectiveDateBusinessCenters is not null && LegStreamEffectiveDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40942, LegStreamEffectiveDateBusinessCenters.Length);
				for (int i = 0; i < LegStreamEffectiveDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegStreamEffectiveDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegStreamEffectiveDateBusinessCenters") is IMessageView viewNoLegStreamEffectiveDateBusinessCenters)
			{
				var count = viewNoLegStreamEffectiveDateBusinessCenters.GroupCount();
				LegStreamEffectiveDateBusinessCenters = new NoLegStreamEffectiveDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegStreamEffectiveDateBusinessCenters[i] = new();
					((IFixParser)LegStreamEffectiveDateBusinessCenters[i]).Parse(viewNoLegStreamEffectiveDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegStreamEffectiveDateBusinessCenters":
				{
					value = LegStreamEffectiveDateBusinessCenters;
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
			LegStreamEffectiveDateBusinessCenters = null;
		}
	}
}
