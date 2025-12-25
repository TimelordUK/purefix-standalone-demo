using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class SecSizesGrp : IFixComponent
	{
		public sealed partial class NoOfSecSizes : IFixGroup
		{
			[TagDetails(Tag = 1178, Type = TagType.Int, Offset = 0, Required = false)]
			public int? MDSecSizeType {get; set;}
			
			[TagDetails(Tag = 1179, Type = TagType.Float, Offset = 1, Required = false)]
			public double? MDSecSize {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (MDSecSizeType is not null) writer.WriteWholeNumber(1178, MDSecSizeType.Value);
				if (MDSecSize is not null) writer.WriteNumber(1179, MDSecSize.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				MDSecSizeType = view.GetInt32(1178);
				MDSecSize = view.GetDouble(1179);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "MDSecSizeType":
					{
						value = MDSecSizeType;
						break;
					}
					case "MDSecSize":
					{
						value = MDSecSize;
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
				MDSecSizeType = null;
				MDSecSize = null;
			}
		}
		[Group(NoOfTag = 1177, Offset = 0, Required = false)]
		public NoOfSecSizes[]? OfSecSizes {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (OfSecSizes is not null && OfSecSizes.Length != 0)
			{
				writer.WriteWholeNumber(1177, OfSecSizes.Length);
				for (int i = 0; i < OfSecSizes.Length; i++)
				{
					((IFixEncoder)OfSecSizes[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoOfSecSizes") is IMessageView viewNoOfSecSizes)
			{
				var count = viewNoOfSecSizes.GroupCount();
				OfSecSizes = new NoOfSecSizes[count];
				for (int i = 0; i < count; i++)
				{
					OfSecSizes[i] = new();
					((IFixParser)OfSecSizes[i]).Parse(viewNoOfSecSizes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoOfSecSizes":
				{
					value = OfSecSizes;
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
			OfSecSizes = null;
		}
	}
}
