using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class MDReqGrp : IFixComponent
	{
		public sealed partial class NoMDEntryTypes : IFixGroup
		{
			[TagDetails(Tag = 269, Type = TagType.String, Offset = 0, Required = true)]
			public string? MDEntryType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (MDEntryType is not null) writer.WriteString(269, MDEntryType);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				MDEntryType = view.GetString(269);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "MDEntryType":
					{
						value = MDEntryType;
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
				MDEntryType = null;
			}
		}
		[Group(NoOfTag = 267, Offset = 0, Required = false)]
		public NoMDEntryTypes[]? MDEntryTypes {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (MDEntryTypes is not null && MDEntryTypes.Length != 0)
			{
				writer.WriteWholeNumber(267, MDEntryTypes.Length);
				for (int i = 0; i < MDEntryTypes.Length; i++)
				{
					((IFixEncoder)MDEntryTypes[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoMDEntryTypes") is IMessageView viewNoMDEntryTypes)
			{
				var count = viewNoMDEntryTypes.GroupCount();
				MDEntryTypes = new NoMDEntryTypes[count];
				for (int i = 0; i < count; i++)
				{
					MDEntryTypes[i] = new();
					((IFixParser)MDEntryTypes[i]).Parse(viewNoMDEntryTypes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoMDEntryTypes":
				{
					value = MDEntryTypes;
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
			MDEntryTypes = null;
		}
	}
}
