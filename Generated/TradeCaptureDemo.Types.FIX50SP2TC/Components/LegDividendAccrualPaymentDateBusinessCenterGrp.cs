using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegDividendAccrualPaymentDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegDividendAccrualPaymentDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42311, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegDividendAccrualPaymentDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegDividendAccrualPaymentDateBusinessCenter is not null) writer.WriteString(42311, LegDividendAccrualPaymentDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegDividendAccrualPaymentDateBusinessCenter = view.GetString(42311);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegDividendAccrualPaymentDateBusinessCenter":
					{
						value = LegDividendAccrualPaymentDateBusinessCenter;
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
				LegDividendAccrualPaymentDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42310, Offset = 0, Required = false)]
		public NoLegDividendAccrualPaymentDateBusinessCenters[]? LegDividendAccrualPaymentDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegDividendAccrualPaymentDateBusinessCenters is not null && LegDividendAccrualPaymentDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42310, LegDividendAccrualPaymentDateBusinessCenters.Length);
				for (int i = 0; i < LegDividendAccrualPaymentDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegDividendAccrualPaymentDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegDividendAccrualPaymentDateBusinessCenters") is IMessageView viewNoLegDividendAccrualPaymentDateBusinessCenters)
			{
				var count = viewNoLegDividendAccrualPaymentDateBusinessCenters.GroupCount();
				LegDividendAccrualPaymentDateBusinessCenters = new NoLegDividendAccrualPaymentDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegDividendAccrualPaymentDateBusinessCenters[i] = new();
					((IFixParser)LegDividendAccrualPaymentDateBusinessCenters[i]).Parse(viewNoLegDividendAccrualPaymentDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegDividendAccrualPaymentDateBusinessCenters":
				{
					value = LegDividendAccrualPaymentDateBusinessCenters;
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
			LegDividendAccrualPaymentDateBusinessCenters = null;
		}
	}
}
