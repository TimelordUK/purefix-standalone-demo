using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegReturnRateValuationDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegReturnRateValuationDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42570, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegReturnRateValuationDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegReturnRateValuationDateBusinessCenter is not null) writer.WriteString(42570, LegReturnRateValuationDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegReturnRateValuationDateBusinessCenter = view.GetString(42570);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegReturnRateValuationDateBusinessCenter":
					{
						value = LegReturnRateValuationDateBusinessCenter;
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
				LegReturnRateValuationDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42569, Offset = 0, Required = false)]
		public NoLegReturnRateValuationDateBusinessCenters[]? LegReturnRateValuationDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegReturnRateValuationDateBusinessCenters is not null && LegReturnRateValuationDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42569, LegReturnRateValuationDateBusinessCenters.Length);
				for (int i = 0; i < LegReturnRateValuationDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegReturnRateValuationDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegReturnRateValuationDateBusinessCenters") is IMessageView viewNoLegReturnRateValuationDateBusinessCenters)
			{
				var count = viewNoLegReturnRateValuationDateBusinessCenters.GroupCount();
				LegReturnRateValuationDateBusinessCenters = new NoLegReturnRateValuationDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegReturnRateValuationDateBusinessCenters[i] = new();
					((IFixParser)LegReturnRateValuationDateBusinessCenters[i]).Parse(viewNoLegReturnRateValuationDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegReturnRateValuationDateBusinessCenters":
				{
					value = LegReturnRateValuationDateBusinessCenters;
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
			LegReturnRateValuationDateBusinessCenters = null;
		}
	}
}
