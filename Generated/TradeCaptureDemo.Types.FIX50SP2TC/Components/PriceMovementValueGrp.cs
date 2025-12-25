using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PriceMovementValueGrp : IFixComponent
	{
		public sealed partial class NoPriceMovementValues : IFixGroup
		{
			[TagDetails(Tag = 1921, Type = TagType.Float, Offset = 0, Required = false)]
			public double? PriceMovementValue {get; set;}
			
			[TagDetails(Tag = 1922, Type = TagType.Int, Offset = 1, Required = false)]
			public int? PriceMovementPoint {get; set;}
			
			[TagDetails(Tag = 1923, Type = TagType.Int, Offset = 2, Required = false)]
			public int? PriceMovementType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PriceMovementValue is not null) writer.WriteNumber(1921, PriceMovementValue.Value);
				if (PriceMovementPoint is not null) writer.WriteWholeNumber(1922, PriceMovementPoint.Value);
				if (PriceMovementType is not null) writer.WriteWholeNumber(1923, PriceMovementType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PriceMovementValue = view.GetDouble(1921);
				PriceMovementPoint = view.GetInt32(1922);
				PriceMovementType = view.GetInt32(1923);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PriceMovementValue":
					{
						value = PriceMovementValue;
						break;
					}
					case "PriceMovementPoint":
					{
						value = PriceMovementPoint;
						break;
					}
					case "PriceMovementType":
					{
						value = PriceMovementType;
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
				PriceMovementValue = null;
				PriceMovementPoint = null;
				PriceMovementType = null;
			}
		}
		[Group(NoOfTag = 1920, Offset = 0, Required = false)]
		public NoPriceMovementValues[]? PriceMovementValues {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PriceMovementValues is not null && PriceMovementValues.Length != 0)
			{
				writer.WriteWholeNumber(1920, PriceMovementValues.Length);
				for (int i = 0; i < PriceMovementValues.Length; i++)
				{
					((IFixEncoder)PriceMovementValues[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPriceMovementValues") is IMessageView viewNoPriceMovementValues)
			{
				var count = viewNoPriceMovementValues.GroupCount();
				PriceMovementValues = new NoPriceMovementValues[count];
				for (int i = 0; i < count; i++)
				{
					PriceMovementValues[i] = new();
					((IFixParser)PriceMovementValues[i]).Parse(viewNoPriceMovementValues.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPriceMovementValues":
				{
					value = PriceMovementValues;
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
			PriceMovementValues = null;
		}
	}
}
