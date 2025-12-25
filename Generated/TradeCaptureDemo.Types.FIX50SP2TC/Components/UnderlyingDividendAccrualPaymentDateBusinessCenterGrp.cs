using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingDividendAccrualPaymentDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingDividendAccrualPaymentDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42800, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingDividendAccrualPaymentDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingDividendAccrualPaymentDateBusinessCenter is not null) writer.WriteString(42800, UnderlyingDividendAccrualPaymentDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingDividendAccrualPaymentDateBusinessCenter = view.GetString(42800);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingDividendAccrualPaymentDateBusinessCenter":
					{
						value = UnderlyingDividendAccrualPaymentDateBusinessCenter;
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
				UnderlyingDividendAccrualPaymentDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42799, Offset = 0, Required = false)]
		public NoUnderlyingDividendAccrualPaymentDateBusinessCenters[]? UnderlyingDividendAccrualPaymentDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingDividendAccrualPaymentDateBusinessCenters is not null && UnderlyingDividendAccrualPaymentDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42799, UnderlyingDividendAccrualPaymentDateBusinessCenters.Length);
				for (int i = 0; i < UnderlyingDividendAccrualPaymentDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingDividendAccrualPaymentDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingDividendAccrualPaymentDateBusinessCenters") is IMessageView viewNoUnderlyingDividendAccrualPaymentDateBusinessCenters)
			{
				var count = viewNoUnderlyingDividendAccrualPaymentDateBusinessCenters.GroupCount();
				UnderlyingDividendAccrualPaymentDateBusinessCenters = new NoUnderlyingDividendAccrualPaymentDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingDividendAccrualPaymentDateBusinessCenters[i] = new();
					((IFixParser)UnderlyingDividendAccrualPaymentDateBusinessCenters[i]).Parse(viewNoUnderlyingDividendAccrualPaymentDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingDividendAccrualPaymentDateBusinessCenters":
				{
					value = UnderlyingDividendAccrualPaymentDateBusinessCenters;
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
			UnderlyingDividendAccrualPaymentDateBusinessCenters = null;
		}
	}
}
