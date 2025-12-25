using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class EntitlementTypeGrp : IFixComponent
	{
		public sealed partial class NoEntitlementTypes : IFixGroup
		{
			[TagDetails(Tag = 1775, Type = TagType.Int, Offset = 0, Required = false)]
			public int? EntitlementType {get; set;}
			
			[TagDetails(Tag = 2402, Type = TagType.Int, Offset = 1, Required = false)]
			public int? EntitlementSubType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (EntitlementType is not null) writer.WriteWholeNumber(1775, EntitlementType.Value);
				if (EntitlementSubType is not null) writer.WriteWholeNumber(2402, EntitlementSubType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				EntitlementType = view.GetInt32(1775);
				EntitlementSubType = view.GetInt32(2402);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "EntitlementType":
					{
						value = EntitlementType;
						break;
					}
					case "EntitlementSubType":
					{
						value = EntitlementSubType;
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
				EntitlementType = null;
				EntitlementSubType = null;
			}
		}
		[Group(NoOfTag = 2345, Offset = 0, Required = false)]
		public NoEntitlementTypes[]? EntitlementTypes {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (EntitlementTypes is not null && EntitlementTypes.Length != 0)
			{
				writer.WriteWholeNumber(2345, EntitlementTypes.Length);
				for (int i = 0; i < EntitlementTypes.Length; i++)
				{
					((IFixEncoder)EntitlementTypes[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoEntitlementTypes") is IMessageView viewNoEntitlementTypes)
			{
				var count = viewNoEntitlementTypes.GroupCount();
				EntitlementTypes = new NoEntitlementTypes[count];
				for (int i = 0; i < count; i++)
				{
					EntitlementTypes[i] = new();
					((IFixParser)EntitlementTypes[i]).Parse(viewNoEntitlementTypes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoEntitlementTypes":
				{
					value = EntitlementTypes;
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
			EntitlementTypes = null;
		}
	}
}
