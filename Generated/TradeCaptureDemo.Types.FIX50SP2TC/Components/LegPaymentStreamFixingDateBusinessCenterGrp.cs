using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStreamFixingDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegPaymentStreamFixingDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40318, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegPaymentStreamFixingDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegPaymentStreamFixingDateBusinessCenter is not null) writer.WriteString(40318, LegPaymentStreamFixingDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegPaymentStreamFixingDateBusinessCenter = view.GetString(40318);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegPaymentStreamFixingDateBusinessCenter":
					{
						value = LegPaymentStreamFixingDateBusinessCenter;
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
				LegPaymentStreamFixingDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40933, Offset = 0, Required = false)]
		public NoLegPaymentStreamFixingDateBusinessCenters[]? LegPaymentStreamFixingDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStreamFixingDateBusinessCenters is not null && LegPaymentStreamFixingDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40933, LegPaymentStreamFixingDateBusinessCenters.Length);
				for (int i = 0; i < LegPaymentStreamFixingDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegPaymentStreamFixingDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegPaymentStreamFixingDateBusinessCenters") is IMessageView viewNoLegPaymentStreamFixingDateBusinessCenters)
			{
				var count = viewNoLegPaymentStreamFixingDateBusinessCenters.GroupCount();
				LegPaymentStreamFixingDateBusinessCenters = new NoLegPaymentStreamFixingDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegPaymentStreamFixingDateBusinessCenters[i] = new();
					((IFixParser)LegPaymentStreamFixingDateBusinessCenters[i]).Parse(viewNoLegPaymentStreamFixingDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegPaymentStreamFixingDateBusinessCenters":
				{
					value = LegPaymentStreamFixingDateBusinessCenters;
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
			LegPaymentStreamFixingDateBusinessCenters = null;
		}
	}
}
