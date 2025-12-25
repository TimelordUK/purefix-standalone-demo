using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStreamPricingDayGrp : IFixComponent
	{
		public sealed partial class NoLegPaymentStreamPricingDays : IFixGroup
		{
			[TagDetails(Tag = 41597, Type = TagType.Int, Offset = 0, Required = false)]
			public int? LegPaymentStreamPricingDayOfWeek {get; set;}
			
			[TagDetails(Tag = 41598, Type = TagType.Int, Offset = 1, Required = false)]
			public int? LegPaymentStreamPricingDayNumber {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegPaymentStreamPricingDayOfWeek is not null) writer.WriteWholeNumber(41597, LegPaymentStreamPricingDayOfWeek.Value);
				if (LegPaymentStreamPricingDayNumber is not null) writer.WriteWholeNumber(41598, LegPaymentStreamPricingDayNumber.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegPaymentStreamPricingDayOfWeek = view.GetInt32(41597);
				LegPaymentStreamPricingDayNumber = view.GetInt32(41598);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegPaymentStreamPricingDayOfWeek":
					{
						value = LegPaymentStreamPricingDayOfWeek;
						break;
					}
					case "LegPaymentStreamPricingDayNumber":
					{
						value = LegPaymentStreamPricingDayNumber;
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
				LegPaymentStreamPricingDayOfWeek = null;
				LegPaymentStreamPricingDayNumber = null;
			}
		}
		[Group(NoOfTag = 41596, Offset = 0, Required = false)]
		public NoLegPaymentStreamPricingDays[]? LegPaymentStreamPricingDays {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStreamPricingDays is not null && LegPaymentStreamPricingDays.Length != 0)
			{
				writer.WriteWholeNumber(41596, LegPaymentStreamPricingDays.Length);
				for (int i = 0; i < LegPaymentStreamPricingDays.Length; i++)
				{
					((IFixEncoder)LegPaymentStreamPricingDays[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegPaymentStreamPricingDays") is IMessageView viewNoLegPaymentStreamPricingDays)
			{
				var count = viewNoLegPaymentStreamPricingDays.GroupCount();
				LegPaymentStreamPricingDays = new NoLegPaymentStreamPricingDays[count];
				for (int i = 0; i < count; i++)
				{
					LegPaymentStreamPricingDays[i] = new();
					((IFixParser)LegPaymentStreamPricingDays[i]).Parse(viewNoLegPaymentStreamPricingDays.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegPaymentStreamPricingDays":
				{
					value = LegPaymentStreamPricingDays;
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
			LegPaymentStreamPricingDays = null;
		}
	}
}
