using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPricingDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegPricingDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 41608, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegPricingDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegPricingDateBusinessCenter is not null) writer.WriteString(41608, LegPricingDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegPricingDateBusinessCenter = view.GetString(41608);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegPricingDateBusinessCenter":
					{
						value = LegPricingDateBusinessCenter;
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
				LegPricingDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 41607, Offset = 0, Required = false)]
		public NoLegPricingDateBusinessCenters[]? LegPricingDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPricingDateBusinessCenters is not null && LegPricingDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(41607, LegPricingDateBusinessCenters.Length);
				for (int i = 0; i < LegPricingDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegPricingDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegPricingDateBusinessCenters") is IMessageView viewNoLegPricingDateBusinessCenters)
			{
				var count = viewNoLegPricingDateBusinessCenters.GroupCount();
				LegPricingDateBusinessCenters = new NoLegPricingDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegPricingDateBusinessCenters[i] = new();
					((IFixParser)LegPricingDateBusinessCenters[i]).Parse(viewNoLegPricingDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegPricingDateBusinessCenters":
				{
					value = LegPricingDateBusinessCenters;
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
			LegPricingDateBusinessCenters = null;
		}
	}
}
