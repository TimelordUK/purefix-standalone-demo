using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ProvisionCashSettlPaymentDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoProvisionCashSettlPaymentDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40164, Type = TagType.String, Offset = 0, Required = false)]
			public string? ProvisionCashSettlPaymentDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ProvisionCashSettlPaymentDateBusinessCenter is not null) writer.WriteString(40164, ProvisionCashSettlPaymentDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ProvisionCashSettlPaymentDateBusinessCenter = view.GetString(40164);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ProvisionCashSettlPaymentDateBusinessCenter":
					{
						value = ProvisionCashSettlPaymentDateBusinessCenter;
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
				ProvisionCashSettlPaymentDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40952, Offset = 0, Required = false)]
		public NoProvisionCashSettlPaymentDateBusinessCenters[]? ProvisionCashSettlPaymentDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ProvisionCashSettlPaymentDateBusinessCenters is not null && ProvisionCashSettlPaymentDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40952, ProvisionCashSettlPaymentDateBusinessCenters.Length);
				for (int i = 0; i < ProvisionCashSettlPaymentDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)ProvisionCashSettlPaymentDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoProvisionCashSettlPaymentDateBusinessCenters") is IMessageView viewNoProvisionCashSettlPaymentDateBusinessCenters)
			{
				var count = viewNoProvisionCashSettlPaymentDateBusinessCenters.GroupCount();
				ProvisionCashSettlPaymentDateBusinessCenters = new NoProvisionCashSettlPaymentDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					ProvisionCashSettlPaymentDateBusinessCenters[i] = new();
					((IFixParser)ProvisionCashSettlPaymentDateBusinessCenters[i]).Parse(viewNoProvisionCashSettlPaymentDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoProvisionCashSettlPaymentDateBusinessCenters":
				{
					value = ProvisionCashSettlPaymentDateBusinessCenters;
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
			ProvisionCashSettlPaymentDateBusinessCenters = null;
		}
	}
}
