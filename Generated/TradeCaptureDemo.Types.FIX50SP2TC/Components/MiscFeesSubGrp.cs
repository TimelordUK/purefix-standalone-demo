using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class MiscFeesSubGrp : IFixComponent
	{
		public sealed partial class NoMiscFeeSubTypes : IFixGroup
		{
			[TagDetails(Tag = 2634, Type = TagType.String, Offset = 0, Required = false)]
			public string? MiscFeeSubType {get; set;}
			
			[TagDetails(Tag = 2635, Type = TagType.Float, Offset = 1, Required = false)]
			public double? MiscFeeSubTypeAmt {get; set;}
			
			[TagDetails(Tag = 2636, Type = TagType.String, Offset = 2, Required = false)]
			public string? MiscFeeSubTypeDesc {get; set;}
			
			[TagDetails(Tag = 2637, Type = TagType.Length, Offset = 3, Required = false)]
			public int? EncodedMiscFeeSubTypeDescLen {get; set;}
			
			[TagDetails(Tag = 2638, Type = TagType.RawData, Offset = 4, Required = false)]
			public byte[]? EncodedMiscFeeSubTypeDesc {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (MiscFeeSubType is not null) writer.WriteString(2634, MiscFeeSubType);
				if (MiscFeeSubTypeAmt is not null) writer.WriteNumber(2635, MiscFeeSubTypeAmt.Value);
				if (MiscFeeSubTypeDesc is not null) writer.WriteString(2636, MiscFeeSubTypeDesc);
				if (EncodedMiscFeeSubTypeDescLen is not null) writer.WriteWholeNumber(2637, EncodedMiscFeeSubTypeDescLen.Value);
				if (EncodedMiscFeeSubTypeDesc is not null) writer.WriteBuffer(2638, EncodedMiscFeeSubTypeDesc);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				MiscFeeSubType = view.GetString(2634);
				MiscFeeSubTypeAmt = view.GetDouble(2635);
				MiscFeeSubTypeDesc = view.GetString(2636);
				EncodedMiscFeeSubTypeDescLen = view.GetInt32(2637);
				EncodedMiscFeeSubTypeDesc = view.GetByteArray(2638);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "MiscFeeSubType":
					{
						value = MiscFeeSubType;
						break;
					}
					case "MiscFeeSubTypeAmt":
					{
						value = MiscFeeSubTypeAmt;
						break;
					}
					case "MiscFeeSubTypeDesc":
					{
						value = MiscFeeSubTypeDesc;
						break;
					}
					case "EncodedMiscFeeSubTypeDescLen":
					{
						value = EncodedMiscFeeSubTypeDescLen;
						break;
					}
					case "EncodedMiscFeeSubTypeDesc":
					{
						value = EncodedMiscFeeSubTypeDesc;
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
				MiscFeeSubType = null;
				MiscFeeSubTypeAmt = null;
				MiscFeeSubTypeDesc = null;
				EncodedMiscFeeSubTypeDescLen = null;
				EncodedMiscFeeSubTypeDesc = null;
			}
		}
		[Group(NoOfTag = 2633, Offset = 0, Required = false)]
		public NoMiscFeeSubTypes[]? MiscFeeSubTypes {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (MiscFeeSubTypes is not null && MiscFeeSubTypes.Length != 0)
			{
				writer.WriteWholeNumber(2633, MiscFeeSubTypes.Length);
				for (int i = 0; i < MiscFeeSubTypes.Length; i++)
				{
					((IFixEncoder)MiscFeeSubTypes[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoMiscFeeSubTypes") is IMessageView viewNoMiscFeeSubTypes)
			{
				var count = viewNoMiscFeeSubTypes.GroupCount();
				MiscFeeSubTypes = new NoMiscFeeSubTypes[count];
				for (int i = 0; i < count; i++)
				{
					MiscFeeSubTypes[i] = new();
					((IFixParser)MiscFeeSubTypes[i]).Parse(viewNoMiscFeeSubTypes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoMiscFeeSubTypes":
				{
					value = MiscFeeSubTypes;
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
			MiscFeeSubTypes = null;
		}
	}
}
