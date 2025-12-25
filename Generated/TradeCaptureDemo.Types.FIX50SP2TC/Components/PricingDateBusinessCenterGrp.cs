using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PricingDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoPricingDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 41231, Type = TagType.String, Offset = 0, Required = false)]
			public string? PricingDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PricingDateBusinessCenter is not null) writer.WriteString(41231, PricingDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PricingDateBusinessCenter = view.GetString(41231);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PricingDateBusinessCenter":
					{
						value = PricingDateBusinessCenter;
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
				PricingDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 41230, Offset = 0, Required = false)]
		public NoPricingDateBusinessCenters[]? PricingDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PricingDateBusinessCenters is not null && PricingDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(41230, PricingDateBusinessCenters.Length);
				for (int i = 0; i < PricingDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)PricingDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPricingDateBusinessCenters") is IMessageView viewNoPricingDateBusinessCenters)
			{
				var count = viewNoPricingDateBusinessCenters.GroupCount();
				PricingDateBusinessCenters = new NoPricingDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					PricingDateBusinessCenters[i] = new();
					((IFixParser)PricingDateBusinessCenters[i]).Parse(viewNoPricingDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPricingDateBusinessCenters":
				{
					value = PricingDateBusinessCenters;
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
			PricingDateBusinessCenters = null;
		}
	}
}
