using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class DividendAccrualPaymentDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoDividendAccrualPaymentDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42237, Type = TagType.String, Offset = 0, Required = false)]
			public string? DividendAccrualPaymentDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (DividendAccrualPaymentDateBusinessCenter is not null) writer.WriteString(42237, DividendAccrualPaymentDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				DividendAccrualPaymentDateBusinessCenter = view.GetString(42237);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "DividendAccrualPaymentDateBusinessCenter":
					{
						value = DividendAccrualPaymentDateBusinessCenter;
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
				DividendAccrualPaymentDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42236, Offset = 0, Required = false)]
		public NoDividendAccrualPaymentDateBusinessCenters[]? DividendAccrualPaymentDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (DividendAccrualPaymentDateBusinessCenters is not null && DividendAccrualPaymentDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42236, DividendAccrualPaymentDateBusinessCenters.Length);
				for (int i = 0; i < DividendAccrualPaymentDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)DividendAccrualPaymentDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoDividendAccrualPaymentDateBusinessCenters") is IMessageView viewNoDividendAccrualPaymentDateBusinessCenters)
			{
				var count = viewNoDividendAccrualPaymentDateBusinessCenters.GroupCount();
				DividendAccrualPaymentDateBusinessCenters = new NoDividendAccrualPaymentDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					DividendAccrualPaymentDateBusinessCenters[i] = new();
					((IFixParser)DividendAccrualPaymentDateBusinessCenters[i]).Parse(viewNoDividendAccrualPaymentDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoDividendAccrualPaymentDateBusinessCenters":
				{
					value = DividendAccrualPaymentDateBusinessCenters;
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
			DividendAccrualPaymentDateBusinessCenters = null;
		}
	}
}
