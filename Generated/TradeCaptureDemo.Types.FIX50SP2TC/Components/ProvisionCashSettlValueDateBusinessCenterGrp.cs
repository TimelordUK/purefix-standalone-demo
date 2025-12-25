using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ProvisionCashSettlValueDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoProvisionCashSettlValueDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40117, Type = TagType.String, Offset = 0, Required = false)]
			public string? ProvisionCashSettlValueDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ProvisionCashSettlValueDateBusinessCenter is not null) writer.WriteString(40117, ProvisionCashSettlValueDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ProvisionCashSettlValueDateBusinessCenter = view.GetString(40117);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ProvisionCashSettlValueDateBusinessCenter":
					{
						value = ProvisionCashSettlValueDateBusinessCenter;
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
				ProvisionCashSettlValueDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40953, Offset = 0, Required = false)]
		public NoProvisionCashSettlValueDateBusinessCenters[]? ProvisionCashSettlValueDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ProvisionCashSettlValueDateBusinessCenters is not null && ProvisionCashSettlValueDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40953, ProvisionCashSettlValueDateBusinessCenters.Length);
				for (int i = 0; i < ProvisionCashSettlValueDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)ProvisionCashSettlValueDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoProvisionCashSettlValueDateBusinessCenters") is IMessageView viewNoProvisionCashSettlValueDateBusinessCenters)
			{
				var count = viewNoProvisionCashSettlValueDateBusinessCenters.GroupCount();
				ProvisionCashSettlValueDateBusinessCenters = new NoProvisionCashSettlValueDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					ProvisionCashSettlValueDateBusinessCenters[i] = new();
					((IFixParser)ProvisionCashSettlValueDateBusinessCenters[i]).Parse(viewNoProvisionCashSettlValueDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoProvisionCashSettlValueDateBusinessCenters":
				{
					value = ProvisionCashSettlValueDateBusinessCenters;
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
			ProvisionCashSettlValueDateBusinessCenters = null;
		}
	}
}
