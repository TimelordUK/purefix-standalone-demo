using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegProvisionCashSettlValueDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegProvisionCashSettlValueDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40527, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegProvisionCashSettlValueDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegProvisionCashSettlValueDateBusinessCenter is not null) writer.WriteString(40527, LegProvisionCashSettlValueDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegProvisionCashSettlValueDateBusinessCenter = view.GetString(40527);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegProvisionCashSettlValueDateBusinessCenter":
					{
						value = LegProvisionCashSettlValueDateBusinessCenter;
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
				LegProvisionCashSettlValueDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40935, Offset = 0, Required = false)]
		public NoLegProvisionCashSettlValueDateBusinessCenters[]? LegProvisionCashSettlValueDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegProvisionCashSettlValueDateBusinessCenters is not null && LegProvisionCashSettlValueDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40935, LegProvisionCashSettlValueDateBusinessCenters.Length);
				for (int i = 0; i < LegProvisionCashSettlValueDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegProvisionCashSettlValueDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegProvisionCashSettlValueDateBusinessCenters") is IMessageView viewNoLegProvisionCashSettlValueDateBusinessCenters)
			{
				var count = viewNoLegProvisionCashSettlValueDateBusinessCenters.GroupCount();
				LegProvisionCashSettlValueDateBusinessCenters = new NoLegProvisionCashSettlValueDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegProvisionCashSettlValueDateBusinessCenters[i] = new();
					((IFixParser)LegProvisionCashSettlValueDateBusinessCenters[i]).Parse(viewNoLegProvisionCashSettlValueDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegProvisionCashSettlValueDateBusinessCenters":
				{
					value = LegProvisionCashSettlValueDateBusinessCenters;
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
			LegProvisionCashSettlValueDateBusinessCenters = null;
		}
	}
}
