using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingProvisionCashSettlPaymentDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingProvisionCashSettlPaymentDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42181, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingProvisionCashSettlPaymentDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingProvisionCashSettlPaymentDateBusinessCenter is not null) writer.WriteString(42181, UnderlyingProvisionCashSettlPaymentDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingProvisionCashSettlPaymentDateBusinessCenter = view.GetString(42181);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingProvisionCashSettlPaymentDateBusinessCenter":
					{
						value = UnderlyingProvisionCashSettlPaymentDateBusinessCenter;
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
				UnderlyingProvisionCashSettlPaymentDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42180, Offset = 0, Required = false)]
		public NoUnderlyingProvisionCashSettlPaymentDateBusinessCenters[]? UnderlyingProvisionCashSettlPaymentDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingProvisionCashSettlPaymentDateBusinessCenters is not null && UnderlyingProvisionCashSettlPaymentDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42180, UnderlyingProvisionCashSettlPaymentDateBusinessCenters.Length);
				for (int i = 0; i < UnderlyingProvisionCashSettlPaymentDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingProvisionCashSettlPaymentDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingProvisionCashSettlPaymentDateBusinessCenters") is IMessageView viewNoUnderlyingProvisionCashSettlPaymentDateBusinessCenters)
			{
				var count = viewNoUnderlyingProvisionCashSettlPaymentDateBusinessCenters.GroupCount();
				UnderlyingProvisionCashSettlPaymentDateBusinessCenters = new NoUnderlyingProvisionCashSettlPaymentDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingProvisionCashSettlPaymentDateBusinessCenters[i] = new();
					((IFixParser)UnderlyingProvisionCashSettlPaymentDateBusinessCenters[i]).Parse(viewNoUnderlyingProvisionCashSettlPaymentDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingProvisionCashSettlPaymentDateBusinessCenters":
				{
					value = UnderlyingProvisionCashSettlPaymentDateBusinessCenters;
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
			UnderlyingProvisionCashSettlPaymentDateBusinessCenters = null;
		}
	}
}
