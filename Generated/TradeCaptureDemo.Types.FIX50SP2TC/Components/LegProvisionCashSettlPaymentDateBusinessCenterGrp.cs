using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegProvisionCashSettlPaymentDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegProvisionCashSettlPaymentDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40517, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegProvisionCashSettlPaymentDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegProvisionCashSettlPaymentDateBusinessCenter is not null) writer.WriteString(40517, LegProvisionCashSettlPaymentDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegProvisionCashSettlPaymentDateBusinessCenter = view.GetString(40517);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegProvisionCashSettlPaymentDateBusinessCenter":
					{
						value = LegProvisionCashSettlPaymentDateBusinessCenter;
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
				LegProvisionCashSettlPaymentDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40934, Offset = 0, Required = false)]
		public NoLegProvisionCashSettlPaymentDateBusinessCenters[]? LegProvisionCashSettlPaymentDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegProvisionCashSettlPaymentDateBusinessCenters is not null && LegProvisionCashSettlPaymentDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40934, LegProvisionCashSettlPaymentDateBusinessCenters.Length);
				for (int i = 0; i < LegProvisionCashSettlPaymentDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegProvisionCashSettlPaymentDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegProvisionCashSettlPaymentDateBusinessCenters") is IMessageView viewNoLegProvisionCashSettlPaymentDateBusinessCenters)
			{
				var count = viewNoLegProvisionCashSettlPaymentDateBusinessCenters.GroupCount();
				LegProvisionCashSettlPaymentDateBusinessCenters = new NoLegProvisionCashSettlPaymentDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegProvisionCashSettlPaymentDateBusinessCenters[i] = new();
					((IFixParser)LegProvisionCashSettlPaymentDateBusinessCenters[i]).Parse(viewNoLegProvisionCashSettlPaymentDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegProvisionCashSettlPaymentDateBusinessCenters":
				{
					value = LegProvisionCashSettlPaymentDateBusinessCenters;
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
			LegProvisionCashSettlPaymentDateBusinessCenters = null;
		}
	}
}
