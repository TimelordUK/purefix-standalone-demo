using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStreamCompoundingDatesBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegPaymentStreamCompoundingDatesBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42420, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegPaymentStreamCompoundingDatesBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegPaymentStreamCompoundingDatesBusinessCenter is not null) writer.WriteString(42420, LegPaymentStreamCompoundingDatesBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegPaymentStreamCompoundingDatesBusinessCenter = view.GetString(42420);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegPaymentStreamCompoundingDatesBusinessCenter":
					{
						value = LegPaymentStreamCompoundingDatesBusinessCenter;
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
				LegPaymentStreamCompoundingDatesBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42419, Offset = 0, Required = false)]
		public NoLegPaymentStreamCompoundingDatesBusinessCenters[]? LegPaymentStreamCompoundingDatesBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStreamCompoundingDatesBusinessCenters is not null && LegPaymentStreamCompoundingDatesBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42419, LegPaymentStreamCompoundingDatesBusinessCenters.Length);
				for (int i = 0; i < LegPaymentStreamCompoundingDatesBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegPaymentStreamCompoundingDatesBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegPaymentStreamCompoundingDatesBusinessCenters") is IMessageView viewNoLegPaymentStreamCompoundingDatesBusinessCenters)
			{
				var count = viewNoLegPaymentStreamCompoundingDatesBusinessCenters.GroupCount();
				LegPaymentStreamCompoundingDatesBusinessCenters = new NoLegPaymentStreamCompoundingDatesBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegPaymentStreamCompoundingDatesBusinessCenters[i] = new();
					((IFixParser)LegPaymentStreamCompoundingDatesBusinessCenters[i]).Parse(viewNoLegPaymentStreamCompoundingDatesBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegPaymentStreamCompoundingDatesBusinessCenters":
				{
					value = LegPaymentStreamCompoundingDatesBusinessCenters;
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
			LegPaymentStreamCompoundingDatesBusinessCenters = null;
		}
	}
}
