using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ClearingAccountTypeGrp : IFixComponent
	{
		public sealed partial class NoClearingAccountTypes : IFixGroup
		{
			[TagDetails(Tag = 1816, Type = TagType.Int, Offset = 0, Required = false)]
			public int? ClearingAccountType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ClearingAccountType is not null) writer.WriteWholeNumber(1816, ClearingAccountType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ClearingAccountType = view.GetInt32(1816);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ClearingAccountType":
					{
						value = ClearingAccountType;
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
				ClearingAccountType = null;
			}
		}
		[Group(NoOfTag = 1918, Offset = 0, Required = false)]
		public NoClearingAccountTypes[]? ClearingAccountTypes {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ClearingAccountTypes is not null && ClearingAccountTypes.Length != 0)
			{
				writer.WriteWholeNumber(1918, ClearingAccountTypes.Length);
				for (int i = 0; i < ClearingAccountTypes.Length; i++)
				{
					((IFixEncoder)ClearingAccountTypes[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoClearingAccountTypes") is IMessageView viewNoClearingAccountTypes)
			{
				var count = viewNoClearingAccountTypes.GroupCount();
				ClearingAccountTypes = new NoClearingAccountTypes[count];
				for (int i = 0; i < count; i++)
				{
					ClearingAccountTypes[i] = new();
					((IFixParser)ClearingAccountTypes[i]).Parse(viewNoClearingAccountTypes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoClearingAccountTypes":
				{
					value = ClearingAccountTypes;
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
			ClearingAccountTypes = null;
		}
	}
}
