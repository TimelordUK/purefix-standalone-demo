using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingStipulations : IFixComponent
	{
		public sealed partial class NoUnderlyingStips : IFixGroup
		{
			[TagDetails(Tag = 888, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingStipType {get; set;}
			
			[TagDetails(Tag = 889, Type = TagType.String, Offset = 1, Required = false)]
			public string? UnderlyingStipValue {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingStipType is not null) writer.WriteString(888, UnderlyingStipType);
				if (UnderlyingStipValue is not null) writer.WriteString(889, UnderlyingStipValue);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingStipType = view.GetString(888);
				UnderlyingStipValue = view.GetString(889);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingStipType":
					{
						value = UnderlyingStipType;
						break;
					}
					case "UnderlyingStipValue":
					{
						value = UnderlyingStipValue;
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
				UnderlyingStipType = null;
				UnderlyingStipValue = null;
			}
		}
		[Group(NoOfTag = 887, Offset = 0, Required = false)]
		public NoUnderlyingStips[]? UnderlyingStips {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingStips is not null && UnderlyingStips.Length != 0)
			{
				writer.WriteWholeNumber(887, UnderlyingStips.Length);
				for (int i = 0; i < UnderlyingStips.Length; i++)
				{
					((IFixEncoder)UnderlyingStips[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingStips") is IMessageView viewNoUnderlyingStips)
			{
				var count = viewNoUnderlyingStips.GroupCount();
				UnderlyingStips = new NoUnderlyingStips[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingStips[i] = new();
					((IFixParser)UnderlyingStips[i]).Parse(viewNoUnderlyingStips.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingStips":
				{
					value = UnderlyingStips;
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
			UnderlyingStips = null;
		}
	}
}
