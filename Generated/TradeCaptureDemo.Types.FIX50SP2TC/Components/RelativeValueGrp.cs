using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class RelativeValueGrp : IFixComponent
	{
		public sealed partial class NoRelativeValues : IFixGroup
		{
			[TagDetails(Tag = 2530, Type = TagType.Int, Offset = 0, Required = false)]
			public int? RelativeValueType {get; set;}
			
			[TagDetails(Tag = 2531, Type = TagType.Float, Offset = 1, Required = false)]
			public double? RelativeValue {get; set;}
			
			[TagDetails(Tag = 2532, Type = TagType.Int, Offset = 2, Required = false)]
			public int? RelativeValueSide {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (RelativeValueType is not null) writer.WriteWholeNumber(2530, RelativeValueType.Value);
				if (RelativeValue is not null) writer.WriteNumber(2531, RelativeValue.Value);
				if (RelativeValueSide is not null) writer.WriteWholeNumber(2532, RelativeValueSide.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				RelativeValueType = view.GetInt32(2530);
				RelativeValue = view.GetDouble(2531);
				RelativeValueSide = view.GetInt32(2532);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "RelativeValueType":
					{
						value = RelativeValueType;
						break;
					}
					case "RelativeValue":
					{
						value = RelativeValue;
						break;
					}
					case "RelativeValueSide":
					{
						value = RelativeValueSide;
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
				RelativeValueType = null;
				RelativeValue = null;
				RelativeValueSide = null;
			}
		}
		[Group(NoOfTag = 2529, Offset = 0, Required = false)]
		public NoRelativeValues[]? RelativeValues {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (RelativeValues is not null && RelativeValues.Length != 0)
			{
				writer.WriteWholeNumber(2529, RelativeValues.Length);
				for (int i = 0; i < RelativeValues.Length; i++)
				{
					((IFixEncoder)RelativeValues[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoRelativeValues") is IMessageView viewNoRelativeValues)
			{
				var count = viewNoRelativeValues.GroupCount();
				RelativeValues = new NoRelativeValues[count];
				for (int i = 0; i < count; i++)
				{
					RelativeValues[i] = new();
					((IFixParser)RelativeValues[i]).Parse(viewNoRelativeValues.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoRelativeValues":
				{
					value = RelativeValues;
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
			RelativeValues = null;
		}
	}
}
