using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegProtectionTermObligationGrp : IFixComponent
	{
		public sealed partial class NoLegProtectionTermObligations : IFixGroup
		{
			[TagDetails(Tag = 41636, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegProtectionTermObligationType {get; set;}
			
			[TagDetails(Tag = 41637, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegProtectionTermObligationValue {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegProtectionTermObligationType is not null) writer.WriteString(41636, LegProtectionTermObligationType);
				if (LegProtectionTermObligationValue is not null) writer.WriteString(41637, LegProtectionTermObligationValue);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegProtectionTermObligationType = view.GetString(41636);
				LegProtectionTermObligationValue = view.GetString(41637);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegProtectionTermObligationType":
					{
						value = LegProtectionTermObligationType;
						break;
					}
					case "LegProtectionTermObligationValue":
					{
						value = LegProtectionTermObligationValue;
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
				LegProtectionTermObligationType = null;
				LegProtectionTermObligationValue = null;
			}
		}
		[Group(NoOfTag = 41635, Offset = 0, Required = false)]
		public NoLegProtectionTermObligations[]? LegProtectionTermObligations {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegProtectionTermObligations is not null && LegProtectionTermObligations.Length != 0)
			{
				writer.WriteWholeNumber(41635, LegProtectionTermObligations.Length);
				for (int i = 0; i < LegProtectionTermObligations.Length; i++)
				{
					((IFixEncoder)LegProtectionTermObligations[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegProtectionTermObligations") is IMessageView viewNoLegProtectionTermObligations)
			{
				var count = viewNoLegProtectionTermObligations.GroupCount();
				LegProtectionTermObligations = new NoLegProtectionTermObligations[count];
				for (int i = 0; i < count; i++)
				{
					LegProtectionTermObligations[i] = new();
					((IFixParser)LegProtectionTermObligations[i]).Parse(viewNoLegProtectionTermObligations.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegProtectionTermObligations":
				{
					value = LegProtectionTermObligations;
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
			LegProtectionTermObligations = null;
		}
	}
}
