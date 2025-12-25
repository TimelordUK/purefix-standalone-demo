using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class AssetAttributeGrp : IFixComponent
	{
		public sealed partial class NoAssetAttributes : IFixGroup
		{
			[TagDetails(Tag = 2305, Type = TagType.String, Offset = 0, Required = false)]
			public string? AssetAttributeType {get; set;}
			
			[TagDetails(Tag = 2306, Type = TagType.String, Offset = 1, Required = false)]
			public string? AssetAttributeValue {get; set;}
			
			[TagDetails(Tag = 2307, Type = TagType.String, Offset = 2, Required = false)]
			public string? AssetAttributeLimit {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (AssetAttributeType is not null) writer.WriteString(2305, AssetAttributeType);
				if (AssetAttributeValue is not null) writer.WriteString(2306, AssetAttributeValue);
				if (AssetAttributeLimit is not null) writer.WriteString(2307, AssetAttributeLimit);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				AssetAttributeType = view.GetString(2305);
				AssetAttributeValue = view.GetString(2306);
				AssetAttributeLimit = view.GetString(2307);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "AssetAttributeType":
					{
						value = AssetAttributeType;
						break;
					}
					case "AssetAttributeValue":
					{
						value = AssetAttributeValue;
						break;
					}
					case "AssetAttributeLimit":
					{
						value = AssetAttributeLimit;
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
				AssetAttributeType = null;
				AssetAttributeValue = null;
				AssetAttributeLimit = null;
			}
		}
		[Group(NoOfTag = 2304, Offset = 0, Required = false)]
		public NoAssetAttributes[]? AssetAttributes {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (AssetAttributes is not null && AssetAttributes.Length != 0)
			{
				writer.WriteWholeNumber(2304, AssetAttributes.Length);
				for (int i = 0; i < AssetAttributes.Length; i++)
				{
					((IFixEncoder)AssetAttributes[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoAssetAttributes") is IMessageView viewNoAssetAttributes)
			{
				var count = viewNoAssetAttributes.GroupCount();
				AssetAttributes = new NoAssetAttributes[count];
				for (int i = 0; i < count; i++)
				{
					AssetAttributes[i] = new();
					((IFixParser)AssetAttributes[i]).Parse(viewNoAssetAttributes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoAssetAttributes":
				{
					value = AssetAttributes;
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
			AssetAttributes = null;
		}
	}
}
