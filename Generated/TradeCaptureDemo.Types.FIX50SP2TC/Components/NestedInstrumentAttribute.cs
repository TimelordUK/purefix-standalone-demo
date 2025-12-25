using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class NestedInstrumentAttribute : IFixComponent
	{
		public sealed partial class NoNestedInstrAttrib : IFixGroup
		{
			[TagDetails(Tag = 1210, Type = TagType.Int, Offset = 0, Required = false)]
			public int? NestedInstrAttribType {get; set;}
			
			[TagDetails(Tag = 1211, Type = TagType.String, Offset = 1, Required = false)]
			public string? NestedInstrAttribValue {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (NestedInstrAttribType is not null) writer.WriteWholeNumber(1210, NestedInstrAttribType.Value);
				if (NestedInstrAttribValue is not null) writer.WriteString(1211, NestedInstrAttribValue);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				NestedInstrAttribType = view.GetInt32(1210);
				NestedInstrAttribValue = view.GetString(1211);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "NestedInstrAttribType":
					{
						value = NestedInstrAttribType;
						break;
					}
					case "NestedInstrAttribValue":
					{
						value = NestedInstrAttribValue;
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
				NestedInstrAttribType = null;
				NestedInstrAttribValue = null;
			}
		}
		[Group(NoOfTag = 1312, Offset = 0, Required = false)]
		public NoNestedInstrAttrib[]? NestedInstrAttrib {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (NestedInstrAttrib is not null && NestedInstrAttrib.Length != 0)
			{
				writer.WriteWholeNumber(1312, NestedInstrAttrib.Length);
				for (int i = 0; i < NestedInstrAttrib.Length; i++)
				{
					((IFixEncoder)NestedInstrAttrib[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoNestedInstrAttrib") is IMessageView viewNoNestedInstrAttrib)
			{
				var count = viewNoNestedInstrAttrib.GroupCount();
				NestedInstrAttrib = new NoNestedInstrAttrib[count];
				for (int i = 0; i < count; i++)
				{
					NestedInstrAttrib[i] = new();
					((IFixParser)NestedInstrAttrib[i]).Parse(viewNoNestedInstrAttrib.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoNestedInstrAttrib":
				{
					value = NestedInstrAttrib;
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
			NestedInstrAttrib = null;
		}
	}
}
