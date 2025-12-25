using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegStreamAssetAttributeGrp : IFixComponent
	{
		public sealed partial class NoLegStreamAssetAttributes : IFixGroup
		{
			[TagDetails(Tag = 41453, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegStreamAssetAttributeType {get; set;}
			
			[TagDetails(Tag = 41454, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegStreamAssetAttributeValue {get; set;}
			
			[TagDetails(Tag = 41455, Type = TagType.String, Offset = 2, Required = false)]
			public string? LegStreamAssetAttributeLimit {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegStreamAssetAttributeType is not null) writer.WriteString(41453, LegStreamAssetAttributeType);
				if (LegStreamAssetAttributeValue is not null) writer.WriteString(41454, LegStreamAssetAttributeValue);
				if (LegStreamAssetAttributeLimit is not null) writer.WriteString(41455, LegStreamAssetAttributeLimit);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegStreamAssetAttributeType = view.GetString(41453);
				LegStreamAssetAttributeValue = view.GetString(41454);
				LegStreamAssetAttributeLimit = view.GetString(41455);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegStreamAssetAttributeType":
					{
						value = LegStreamAssetAttributeType;
						break;
					}
					case "LegStreamAssetAttributeValue":
					{
						value = LegStreamAssetAttributeValue;
						break;
					}
					case "LegStreamAssetAttributeLimit":
					{
						value = LegStreamAssetAttributeLimit;
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
				LegStreamAssetAttributeType = null;
				LegStreamAssetAttributeValue = null;
				LegStreamAssetAttributeLimit = null;
			}
		}
		[Group(NoOfTag = 41452, Offset = 0, Required = false)]
		public NoLegStreamAssetAttributes[]? LegStreamAssetAttributes {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegStreamAssetAttributes is not null && LegStreamAssetAttributes.Length != 0)
			{
				writer.WriteWholeNumber(41452, LegStreamAssetAttributes.Length);
				for (int i = 0; i < LegStreamAssetAttributes.Length; i++)
				{
					((IFixEncoder)LegStreamAssetAttributes[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegStreamAssetAttributes") is IMessageView viewNoLegStreamAssetAttributes)
			{
				var count = viewNoLegStreamAssetAttributes.GroupCount();
				LegStreamAssetAttributes = new NoLegStreamAssetAttributes[count];
				for (int i = 0; i < count; i++)
				{
					LegStreamAssetAttributes[i] = new();
					((IFixParser)LegStreamAssetAttributes[i]).Parse(viewNoLegStreamAssetAttributes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegStreamAssetAttributes":
				{
					value = LegStreamAssetAttributes;
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
			LegStreamAssetAttributes = null;
		}
	}
}
