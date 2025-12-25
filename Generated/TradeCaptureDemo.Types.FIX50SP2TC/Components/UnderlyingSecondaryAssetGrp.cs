using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingSecondaryAssetGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingSecondaryAssetClasses : IFixGroup
		{
			[TagDetails(Tag = 2081, Type = TagType.Int, Offset = 0, Required = false)]
			public int? UnderlyingSecondaryAssetClass {get; set;}
			
			[TagDetails(Tag = 2082, Type = TagType.Int, Offset = 1, Required = false)]
			public int? UnderlyingSecondaryAssetSubClass {get; set;}
			
			[TagDetails(Tag = 2083, Type = TagType.String, Offset = 2, Required = false)]
			public string? UnderlyingSecondaryAssetType {get; set;}
			
			[TagDetails(Tag = 2745, Type = TagType.String, Offset = 3, Required = false)]
			public string? UnderlyingSecondaryAssetSubType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingSecondaryAssetClass is not null) writer.WriteWholeNumber(2081, UnderlyingSecondaryAssetClass.Value);
				if (UnderlyingSecondaryAssetSubClass is not null) writer.WriteWholeNumber(2082, UnderlyingSecondaryAssetSubClass.Value);
				if (UnderlyingSecondaryAssetType is not null) writer.WriteString(2083, UnderlyingSecondaryAssetType);
				if (UnderlyingSecondaryAssetSubType is not null) writer.WriteString(2745, UnderlyingSecondaryAssetSubType);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingSecondaryAssetClass = view.GetInt32(2081);
				UnderlyingSecondaryAssetSubClass = view.GetInt32(2082);
				UnderlyingSecondaryAssetType = view.GetString(2083);
				UnderlyingSecondaryAssetSubType = view.GetString(2745);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingSecondaryAssetClass":
					{
						value = UnderlyingSecondaryAssetClass;
						break;
					}
					case "UnderlyingSecondaryAssetSubClass":
					{
						value = UnderlyingSecondaryAssetSubClass;
						break;
					}
					case "UnderlyingSecondaryAssetType":
					{
						value = UnderlyingSecondaryAssetType;
						break;
					}
					case "UnderlyingSecondaryAssetSubType":
					{
						value = UnderlyingSecondaryAssetSubType;
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
				UnderlyingSecondaryAssetClass = null;
				UnderlyingSecondaryAssetSubClass = null;
				UnderlyingSecondaryAssetType = null;
				UnderlyingSecondaryAssetSubType = null;
			}
		}
		[Group(NoOfTag = 2080, Offset = 0, Required = false)]
		public NoUnderlyingSecondaryAssetClasses[]? UnderlyingSecondaryAssetClasses {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingSecondaryAssetClasses is not null && UnderlyingSecondaryAssetClasses.Length != 0)
			{
				writer.WriteWholeNumber(2080, UnderlyingSecondaryAssetClasses.Length);
				for (int i = 0; i < UnderlyingSecondaryAssetClasses.Length; i++)
				{
					((IFixEncoder)UnderlyingSecondaryAssetClasses[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingSecondaryAssetClasses") is IMessageView viewNoUnderlyingSecondaryAssetClasses)
			{
				var count = viewNoUnderlyingSecondaryAssetClasses.GroupCount();
				UnderlyingSecondaryAssetClasses = new NoUnderlyingSecondaryAssetClasses[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingSecondaryAssetClasses[i] = new();
					((IFixParser)UnderlyingSecondaryAssetClasses[i]).Parse(viewNoUnderlyingSecondaryAssetClasses.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingSecondaryAssetClasses":
				{
					value = UnderlyingSecondaryAssetClasses;
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
			UnderlyingSecondaryAssetClasses = null;
		}
	}
}
