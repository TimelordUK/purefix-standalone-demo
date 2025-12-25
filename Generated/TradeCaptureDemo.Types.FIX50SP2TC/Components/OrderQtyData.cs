using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class OrderQtyData : IFixComponent
	{
		[TagDetails(Tag = 38, Type = TagType.Float, Offset = 0, Required = false)]
		public double? OrderQty {get; set;}
		
		[TagDetails(Tag = 152, Type = TagType.Float, Offset = 1, Required = false)]
		public double? CashOrderQty {get; set;}
		
		[TagDetails(Tag = 516, Type = TagType.Float, Offset = 2, Required = false)]
		public double? OrderPercent {get; set;}
		
		[TagDetails(Tag = 468, Type = TagType.String, Offset = 3, Required = false)]
		public string? RoundingDirection {get; set;}
		
		[TagDetails(Tag = 469, Type = TagType.Float, Offset = 4, Required = false)]
		public double? RoundingModulus {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (OrderQty is not null) writer.WriteNumber(38, OrderQty.Value);
			if (CashOrderQty is not null) writer.WriteNumber(152, CashOrderQty.Value);
			if (OrderPercent is not null) writer.WriteNumber(516, OrderPercent.Value);
			if (RoundingDirection is not null) writer.WriteString(468, RoundingDirection);
			if (RoundingModulus is not null) writer.WriteNumber(469, RoundingModulus.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			OrderQty = view.GetDouble(38);
			CashOrderQty = view.GetDouble(152);
			OrderPercent = view.GetDouble(516);
			RoundingDirection = view.GetString(468);
			RoundingModulus = view.GetDouble(469);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "OrderQty":
				{
					value = OrderQty;
					break;
				}
				case "CashOrderQty":
				{
					value = CashOrderQty;
					break;
				}
				case "OrderPercent":
				{
					value = OrderPercent;
					break;
				}
				case "RoundingDirection":
				{
					value = RoundingDirection;
					break;
				}
				case "RoundingModulus":
				{
					value = RoundingModulus;
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
			OrderQty = null;
			CashOrderQty = null;
			OrderPercent = null;
			RoundingDirection = null;
			RoundingModulus = null;
		}
	}
}
