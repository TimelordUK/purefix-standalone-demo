using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingProvisionCashSettlValueDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingProvisionCashSettlValueDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42183, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingProvisionCashSettlValueDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingProvisionCashSettlValueDateBusinessCenter is not null) writer.WriteString(42183, UnderlyingProvisionCashSettlValueDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingProvisionCashSettlValueDateBusinessCenter = view.GetString(42183);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingProvisionCashSettlValueDateBusinessCenter":
					{
						value = UnderlyingProvisionCashSettlValueDateBusinessCenter;
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
				UnderlyingProvisionCashSettlValueDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42182, Offset = 0, Required = false)]
		public NoUnderlyingProvisionCashSettlValueDateBusinessCenters[]? UnderlyingProvisionCashSettlValueDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingProvisionCashSettlValueDateBusinessCenters is not null && UnderlyingProvisionCashSettlValueDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42182, UnderlyingProvisionCashSettlValueDateBusinessCenters.Length);
				for (int i = 0; i < UnderlyingProvisionCashSettlValueDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingProvisionCashSettlValueDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingProvisionCashSettlValueDateBusinessCenters") is IMessageView viewNoUnderlyingProvisionCashSettlValueDateBusinessCenters)
			{
				var count = viewNoUnderlyingProvisionCashSettlValueDateBusinessCenters.GroupCount();
				UnderlyingProvisionCashSettlValueDateBusinessCenters = new NoUnderlyingProvisionCashSettlValueDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingProvisionCashSettlValueDateBusinessCenters[i] = new();
					((IFixParser)UnderlyingProvisionCashSettlValueDateBusinessCenters[i]).Parse(viewNoUnderlyingProvisionCashSettlValueDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingProvisionCashSettlValueDateBusinessCenters":
				{
					value = UnderlyingProvisionCashSettlValueDateBusinessCenters;
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
			UnderlyingProvisionCashSettlValueDateBusinessCenters = null;
		}
	}
}
