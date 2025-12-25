using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegDividendPeriodBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegDividendPeriodBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42387, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegDividendPeriodBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegDividendPeriodBusinessCenter is not null) writer.WriteString(42387, LegDividendPeriodBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegDividendPeriodBusinessCenter = view.GetString(42387);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegDividendPeriodBusinessCenter":
					{
						value = LegDividendPeriodBusinessCenter;
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
				LegDividendPeriodBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42386, Offset = 0, Required = false)]
		public NoLegDividendPeriodBusinessCenters[]? LegDividendPeriodBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegDividendPeriodBusinessCenters is not null && LegDividendPeriodBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42386, LegDividendPeriodBusinessCenters.Length);
				for (int i = 0; i < LegDividendPeriodBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegDividendPeriodBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegDividendPeriodBusinessCenters") is IMessageView viewNoLegDividendPeriodBusinessCenters)
			{
				var count = viewNoLegDividendPeriodBusinessCenters.GroupCount();
				LegDividendPeriodBusinessCenters = new NoLegDividendPeriodBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegDividendPeriodBusinessCenters[i] = new();
					((IFixParser)LegDividendPeriodBusinessCenters[i]).Parse(viewNoLegDividendPeriodBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegDividendPeriodBusinessCenters":
				{
					value = LegDividendPeriodBusinessCenters;
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
			LegDividendPeriodBusinessCenters = null;
		}
	}
}
