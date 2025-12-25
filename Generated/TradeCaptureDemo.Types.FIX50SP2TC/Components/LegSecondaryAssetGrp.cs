using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegSecondaryAssetGrp : IFixComponent
	{
		public sealed partial class NoLegSecondaryAssetClasses : IFixGroup
		{
			[TagDetails(Tag = 2077, Type = TagType.Int, Offset = 0, Required = false)]
			public int? LegSecondaryAssetClass {get; set;}
			
			[TagDetails(Tag = 2078, Type = TagType.Int, Offset = 1, Required = false)]
			public int? LegSecondaryAssetSubClass {get; set;}
			
			[TagDetails(Tag = 2079, Type = TagType.String, Offset = 2, Required = false)]
			public string? LegSecondaryAssetType {get; set;}
			
			[TagDetails(Tag = 2743, Type = TagType.String, Offset = 3, Required = false)]
			public string? LegSecondaryAssetSubType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegSecondaryAssetClass is not null) writer.WriteWholeNumber(2077, LegSecondaryAssetClass.Value);
				if (LegSecondaryAssetSubClass is not null) writer.WriteWholeNumber(2078, LegSecondaryAssetSubClass.Value);
				if (LegSecondaryAssetType is not null) writer.WriteString(2079, LegSecondaryAssetType);
				if (LegSecondaryAssetSubType is not null) writer.WriteString(2743, LegSecondaryAssetSubType);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegSecondaryAssetClass = view.GetInt32(2077);
				LegSecondaryAssetSubClass = view.GetInt32(2078);
				LegSecondaryAssetType = view.GetString(2079);
				LegSecondaryAssetSubType = view.GetString(2743);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegSecondaryAssetClass":
					{
						value = LegSecondaryAssetClass;
						break;
					}
					case "LegSecondaryAssetSubClass":
					{
						value = LegSecondaryAssetSubClass;
						break;
					}
					case "LegSecondaryAssetType":
					{
						value = LegSecondaryAssetType;
						break;
					}
					case "LegSecondaryAssetSubType":
					{
						value = LegSecondaryAssetSubType;
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
				LegSecondaryAssetClass = null;
				LegSecondaryAssetSubClass = null;
				LegSecondaryAssetType = null;
				LegSecondaryAssetSubType = null;
			}
		}
		[Group(NoOfTag = 2076, Offset = 0, Required = false)]
		public NoLegSecondaryAssetClasses[]? LegSecondaryAssetClasses {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegSecondaryAssetClasses is not null && LegSecondaryAssetClasses.Length != 0)
			{
				writer.WriteWholeNumber(2076, LegSecondaryAssetClasses.Length);
				for (int i = 0; i < LegSecondaryAssetClasses.Length; i++)
				{
					((IFixEncoder)LegSecondaryAssetClasses[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegSecondaryAssetClasses") is IMessageView viewNoLegSecondaryAssetClasses)
			{
				var count = viewNoLegSecondaryAssetClasses.GroupCount();
				LegSecondaryAssetClasses = new NoLegSecondaryAssetClasses[count];
				for (int i = 0; i < count; i++)
				{
					LegSecondaryAssetClasses[i] = new();
					((IFixParser)LegSecondaryAssetClasses[i]).Parse(viewNoLegSecondaryAssetClasses.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegSecondaryAssetClasses":
				{
					value = LegSecondaryAssetClasses;
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
			LegSecondaryAssetClasses = null;
		}
	}
}
