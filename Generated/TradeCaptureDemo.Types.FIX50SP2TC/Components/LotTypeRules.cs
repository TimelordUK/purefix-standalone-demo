using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LotTypeRules : IFixComponent
	{
		public sealed partial class NoLotTypeRules : IFixGroup
		{
			[TagDetails(Tag = 1093, Type = TagType.String, Offset = 0, Required = false)]
			public string? LotType {get; set;}
			
			[TagDetails(Tag = 1231, Type = TagType.Float, Offset = 1, Required = false)]
			public double? MinLotSize {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LotType is not null) writer.WriteString(1093, LotType);
				if (MinLotSize is not null) writer.WriteNumber(1231, MinLotSize.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LotType = view.GetString(1093);
				MinLotSize = view.GetDouble(1231);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LotType":
					{
						value = LotType;
						break;
					}
					case "MinLotSize":
					{
						value = MinLotSize;
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
				LotType = null;
				MinLotSize = null;
			}
		}
		[Group(NoOfTag = 1234, Offset = 0, Required = false)]
		public NoLotTypeRules[]? LotTypeRulesItems {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LotTypeRulesItems is not null && LotTypeRulesItems.Length != 0)
			{
				writer.WriteWholeNumber(1234, LotTypeRulesItems.Length);
				for (int i = 0; i < LotTypeRulesItems.Length; i++)
				{
					((IFixEncoder)LotTypeRulesItems[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLotTypeRules") is IMessageView viewNoLotTypeRules)
			{
				var count = viewNoLotTypeRules.GroupCount();
				LotTypeRulesItems = new NoLotTypeRules[count];
				for (int i = 0; i < count; i++)
				{
					LotTypeRulesItems[i] = new();
					((IFixParser)LotTypeRulesItems[i]).Parse(viewNoLotTypeRules.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLotTypeRules":
				{
					value = LotTypeRulesItems;
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
			LotTypeRulesItems = null;
		}
	}
}
