using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegDividendFXTriggerDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegDividendFXTriggerDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42365, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegDividendFXTriggerDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegDividendFXTriggerDateBusinessCenter is not null) writer.WriteString(42365, LegDividendFXTriggerDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegDividendFXTriggerDateBusinessCenter = view.GetString(42365);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegDividendFXTriggerDateBusinessCenter":
					{
						value = LegDividendFXTriggerDateBusinessCenter;
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
				LegDividendFXTriggerDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42364, Offset = 0, Required = false)]
		public NoLegDividendFXTriggerDateBusinessCenters[]? LegDividendFXTriggerDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegDividendFXTriggerDateBusinessCenters is not null && LegDividendFXTriggerDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42364, LegDividendFXTriggerDateBusinessCenters.Length);
				for (int i = 0; i < LegDividendFXTriggerDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegDividendFXTriggerDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegDividendFXTriggerDateBusinessCenters") is IMessageView viewNoLegDividendFXTriggerDateBusinessCenters)
			{
				var count = viewNoLegDividendFXTriggerDateBusinessCenters.GroupCount();
				LegDividendFXTriggerDateBusinessCenters = new NoLegDividendFXTriggerDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegDividendFXTriggerDateBusinessCenters[i] = new();
					((IFixParser)LegDividendFXTriggerDateBusinessCenters[i]).Parse(viewNoLegDividendFXTriggerDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegDividendFXTriggerDateBusinessCenters":
				{
					value = LegDividendFXTriggerDateBusinessCenters;
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
			LegDividendFXTriggerDateBusinessCenters = null;
		}
	}
}
