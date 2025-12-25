using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStreamPricingBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingPaymentStreamPricingBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 41910, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingPaymentStreamPricingBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingPaymentStreamPricingBusinessCenter is not null) writer.WriteString(41910, UnderlyingPaymentStreamPricingBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingPaymentStreamPricingBusinessCenter = view.GetString(41910);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingPaymentStreamPricingBusinessCenter":
					{
						value = UnderlyingPaymentStreamPricingBusinessCenter;
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
				UnderlyingPaymentStreamPricingBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 41909, Offset = 0, Required = false)]
		public NoUnderlyingPaymentStreamPricingBusinessCenters[]? UnderlyingPaymentStreamPricingBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStreamPricingBusinessCenters is not null && UnderlyingPaymentStreamPricingBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(41909, UnderlyingPaymentStreamPricingBusinessCenters.Length);
				for (int i = 0; i < UnderlyingPaymentStreamPricingBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingPaymentStreamPricingBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingPaymentStreamPricingBusinessCenters") is IMessageView viewNoUnderlyingPaymentStreamPricingBusinessCenters)
			{
				var count = viewNoUnderlyingPaymentStreamPricingBusinessCenters.GroupCount();
				UnderlyingPaymentStreamPricingBusinessCenters = new NoUnderlyingPaymentStreamPricingBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingPaymentStreamPricingBusinessCenters[i] = new();
					((IFixParser)UnderlyingPaymentStreamPricingBusinessCenters[i]).Parse(viewNoUnderlyingPaymentStreamPricingBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingPaymentStreamPricingBusinessCenters":
				{
					value = UnderlyingPaymentStreamPricingBusinessCenters;
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
			UnderlyingPaymentStreamPricingBusinessCenters = null;
		}
	}
}
