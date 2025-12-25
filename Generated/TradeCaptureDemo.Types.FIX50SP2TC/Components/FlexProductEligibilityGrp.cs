using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class FlexProductEligibilityGrp : IFixComponent
	{
		public sealed partial class NoFlexProductEligibilities : IFixGroup
		{
			[TagDetails(Tag = 1242, Type = TagType.Boolean, Offset = 0, Required = false)]
			public bool? FlexProductEligibilityIndicator {get; set;}
			
			[TagDetails(Tag = 2561, Type = TagType.String, Offset = 1, Required = false)]
			public string? FlexProductEligibilityComplex {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (FlexProductEligibilityIndicator is not null) writer.WriteBoolean(1242, FlexProductEligibilityIndicator.Value);
				if (FlexProductEligibilityComplex is not null) writer.WriteString(2561, FlexProductEligibilityComplex);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				FlexProductEligibilityIndicator = view.GetBool(1242);
				FlexProductEligibilityComplex = view.GetString(2561);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "FlexProductEligibilityIndicator":
					{
						value = FlexProductEligibilityIndicator;
						break;
					}
					case "FlexProductEligibilityComplex":
					{
						value = FlexProductEligibilityComplex;
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
				FlexProductEligibilityIndicator = null;
				FlexProductEligibilityComplex = null;
			}
		}
		[Group(NoOfTag = 2560, Offset = 0, Required = false)]
		public NoFlexProductEligibilities[]? FlexProductEligibilities {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (FlexProductEligibilities is not null && FlexProductEligibilities.Length != 0)
			{
				writer.WriteWholeNumber(2560, FlexProductEligibilities.Length);
				for (int i = 0; i < FlexProductEligibilities.Length; i++)
				{
					((IFixEncoder)FlexProductEligibilities[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoFlexProductEligibilities") is IMessageView viewNoFlexProductEligibilities)
			{
				var count = viewNoFlexProductEligibilities.GroupCount();
				FlexProductEligibilities = new NoFlexProductEligibilities[count];
				for (int i = 0; i < count; i++)
				{
					FlexProductEligibilities[i] = new();
					((IFixParser)FlexProductEligibilities[i]).Parse(viewNoFlexProductEligibilities.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoFlexProductEligibilities":
				{
					value = FlexProductEligibilities;
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
			FlexProductEligibilities = null;
		}
	}
}
