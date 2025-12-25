using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStreamInitialFixingDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegPaymentStreamInitialFixingDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40311, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegPaymentStreamInitialFixingDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegPaymentStreamInitialFixingDateBusinessCenter is not null) writer.WriteString(40311, LegPaymentStreamInitialFixingDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegPaymentStreamInitialFixingDateBusinessCenter = view.GetString(40311);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegPaymentStreamInitialFixingDateBusinessCenter":
					{
						value = LegPaymentStreamInitialFixingDateBusinessCenter;
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
				LegPaymentStreamInitialFixingDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40932, Offset = 0, Required = false)]
		public NoLegPaymentStreamInitialFixingDateBusinessCenters[]? LegPaymentStreamInitialFixingDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStreamInitialFixingDateBusinessCenters is not null && LegPaymentStreamInitialFixingDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40932, LegPaymentStreamInitialFixingDateBusinessCenters.Length);
				for (int i = 0; i < LegPaymentStreamInitialFixingDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegPaymentStreamInitialFixingDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegPaymentStreamInitialFixingDateBusinessCenters") is IMessageView viewNoLegPaymentStreamInitialFixingDateBusinessCenters)
			{
				var count = viewNoLegPaymentStreamInitialFixingDateBusinessCenters.GroupCount();
				LegPaymentStreamInitialFixingDateBusinessCenters = new NoLegPaymentStreamInitialFixingDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegPaymentStreamInitialFixingDateBusinessCenters[i] = new();
					((IFixParser)LegPaymentStreamInitialFixingDateBusinessCenters[i]).Parse(viewNoLegPaymentStreamInitialFixingDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegPaymentStreamInitialFixingDateBusinessCenters":
				{
					value = LegPaymentStreamInitialFixingDateBusinessCenters;
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
			LegPaymentStreamInitialFixingDateBusinessCenters = null;
		}
	}
}
