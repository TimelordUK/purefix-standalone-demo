using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingAssetAttributeGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingAssetAttributes : IFixGroup
		{
			[TagDetails(Tag = 2313, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingAssetAttributeType {get; set;}
			
			[TagDetails(Tag = 2314, Type = TagType.String, Offset = 1, Required = false)]
			public string? UnderlyingAssetAttributeValue {get; set;}
			
			[TagDetails(Tag = 2315, Type = TagType.String, Offset = 2, Required = false)]
			public string? UnderlyingAssetAttributeLimit {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingAssetAttributeType is not null) writer.WriteString(2313, UnderlyingAssetAttributeType);
				if (UnderlyingAssetAttributeValue is not null) writer.WriteString(2314, UnderlyingAssetAttributeValue);
				if (UnderlyingAssetAttributeLimit is not null) writer.WriteString(2315, UnderlyingAssetAttributeLimit);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingAssetAttributeType = view.GetString(2313);
				UnderlyingAssetAttributeValue = view.GetString(2314);
				UnderlyingAssetAttributeLimit = view.GetString(2315);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingAssetAttributeType":
					{
						value = UnderlyingAssetAttributeType;
						break;
					}
					case "UnderlyingAssetAttributeValue":
					{
						value = UnderlyingAssetAttributeValue;
						break;
					}
					case "UnderlyingAssetAttributeLimit":
					{
						value = UnderlyingAssetAttributeLimit;
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
				UnderlyingAssetAttributeType = null;
				UnderlyingAssetAttributeValue = null;
				UnderlyingAssetAttributeLimit = null;
			}
		}
		[Group(NoOfTag = 2312, Offset = 0, Required = false)]
		public NoUnderlyingAssetAttributes[]? UnderlyingAssetAttributes {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingAssetAttributes is not null && UnderlyingAssetAttributes.Length != 0)
			{
				writer.WriteWholeNumber(2312, UnderlyingAssetAttributes.Length);
				for (int i = 0; i < UnderlyingAssetAttributes.Length; i++)
				{
					((IFixEncoder)UnderlyingAssetAttributes[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingAssetAttributes") is IMessageView viewNoUnderlyingAssetAttributes)
			{
				var count = viewNoUnderlyingAssetAttributes.GroupCount();
				UnderlyingAssetAttributes = new NoUnderlyingAssetAttributes[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingAssetAttributes[i] = new();
					((IFixParser)UnderlyingAssetAttributes[i]).Parse(viewNoUnderlyingAssetAttributes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingAssetAttributes":
				{
					value = UnderlyingAssetAttributes;
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
			UnderlyingAssetAttributes = null;
		}
	}
}
