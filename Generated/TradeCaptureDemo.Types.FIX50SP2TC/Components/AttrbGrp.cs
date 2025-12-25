using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class AttrbGrp : IFixComponent
	{
		public sealed partial class NoInstrAttrib : IFixGroup
		{
			[TagDetails(Tag = 871, Type = TagType.Int, Offset = 0, Required = false)]
			public int? InstrAttribType {get; set;}
			
			[TagDetails(Tag = 872, Type = TagType.String, Offset = 1, Required = false)]
			public string? InstrAttribValue {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (InstrAttribType is not null) writer.WriteWholeNumber(871, InstrAttribType.Value);
				if (InstrAttribValue is not null) writer.WriteString(872, InstrAttribValue);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				InstrAttribType = view.GetInt32(871);
				InstrAttribValue = view.GetString(872);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "InstrAttribType":
					{
						value = InstrAttribType;
						break;
					}
					case "InstrAttribValue":
					{
						value = InstrAttribValue;
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
				InstrAttribType = null;
				InstrAttribValue = null;
			}
		}
		[Group(NoOfTag = 870, Offset = 0, Required = false)]
		public NoInstrAttrib[]? InstrAttrib {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (InstrAttrib is not null && InstrAttrib.Length != 0)
			{
				writer.WriteWholeNumber(870, InstrAttrib.Length);
				for (int i = 0; i < InstrAttrib.Length; i++)
				{
					((IFixEncoder)InstrAttrib[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoInstrAttrib") is IMessageView viewNoInstrAttrib)
			{
				var count = viewNoInstrAttrib.GroupCount();
				InstrAttrib = new NoInstrAttrib[count];
				for (int i = 0; i < count; i++)
				{
					InstrAttrib[i] = new();
					((IFixParser)InstrAttrib[i]).Parse(viewNoInstrAttrib.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoInstrAttrib":
				{
					value = InstrAttrib;
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
			InstrAttrib = null;
		}
	}
}
