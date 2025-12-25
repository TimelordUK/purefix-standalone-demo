using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ValueChecksGrp : IFixComponent
	{
		public sealed partial class NoValueChecks : IFixGroup
		{
			[TagDetails(Tag = 1869, Type = TagType.Int, Offset = 0, Required = false)]
			public int? ValueCheckType {get; set;}
			
			[TagDetails(Tag = 1870, Type = TagType.Int, Offset = 1, Required = false)]
			public int? ValueCheckAction {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ValueCheckType is not null) writer.WriteWholeNumber(1869, ValueCheckType.Value);
				if (ValueCheckAction is not null) writer.WriteWholeNumber(1870, ValueCheckAction.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ValueCheckType = view.GetInt32(1869);
				ValueCheckAction = view.GetInt32(1870);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ValueCheckType":
					{
						value = ValueCheckType;
						break;
					}
					case "ValueCheckAction":
					{
						value = ValueCheckAction;
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
				ValueCheckType = null;
				ValueCheckAction = null;
			}
		}
		[Group(NoOfTag = 1868, Offset = 0, Required = false)]
		public NoValueChecks[]? ValueChecks {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ValueChecks is not null && ValueChecks.Length != 0)
			{
				writer.WriteWholeNumber(1868, ValueChecks.Length);
				for (int i = 0; i < ValueChecks.Length; i++)
				{
					((IFixEncoder)ValueChecks[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoValueChecks") is IMessageView viewNoValueChecks)
			{
				var count = viewNoValueChecks.GroupCount();
				ValueChecks = new NoValueChecks[count];
				for (int i = 0; i < count; i++)
				{
					ValueChecks[i] = new();
					((IFixParser)ValueChecks[i]).Parse(viewNoValueChecks.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoValueChecks":
				{
					value = ValueChecks;
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
			ValueChecks = null;
		}
	}
}
