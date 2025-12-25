using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPricingDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingPricingDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 41948, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingPricingDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingPricingDateBusinessCenter is not null) writer.WriteString(41948, UnderlyingPricingDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingPricingDateBusinessCenter = view.GetString(41948);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingPricingDateBusinessCenter":
					{
						value = UnderlyingPricingDateBusinessCenter;
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
				UnderlyingPricingDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 41947, Offset = 0, Required = false)]
		public NoUnderlyingPricingDateBusinessCenters[]? UnderlyingPricingDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPricingDateBusinessCenters is not null && UnderlyingPricingDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(41947, UnderlyingPricingDateBusinessCenters.Length);
				for (int i = 0; i < UnderlyingPricingDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingPricingDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingPricingDateBusinessCenters") is IMessageView viewNoUnderlyingPricingDateBusinessCenters)
			{
				var count = viewNoUnderlyingPricingDateBusinessCenters.GroupCount();
				UnderlyingPricingDateBusinessCenters = new NoUnderlyingPricingDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingPricingDateBusinessCenters[i] = new();
					((IFixParser)UnderlyingPricingDateBusinessCenters[i]).Parse(viewNoUnderlyingPricingDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingPricingDateBusinessCenters":
				{
					value = UnderlyingPricingDateBusinessCenters;
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
			UnderlyingPricingDateBusinessCenters = null;
		}
	}
}
