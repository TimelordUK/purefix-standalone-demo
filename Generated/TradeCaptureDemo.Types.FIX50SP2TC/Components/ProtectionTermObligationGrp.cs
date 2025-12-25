using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ProtectionTermObligationGrp : IFixComponent
	{
		public sealed partial class NoProtectionTermObligations : IFixGroup
		{
			[TagDetails(Tag = 40202, Type = TagType.String, Offset = 0, Required = false)]
			public string? ProtectionTermObligationType {get; set;}
			
			[TagDetails(Tag = 40203, Type = TagType.String, Offset = 1, Required = false)]
			public string? ProtectionTermObligationValue {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ProtectionTermObligationType is not null) writer.WriteString(40202, ProtectionTermObligationType);
				if (ProtectionTermObligationValue is not null) writer.WriteString(40203, ProtectionTermObligationValue);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ProtectionTermObligationType = view.GetString(40202);
				ProtectionTermObligationValue = view.GetString(40203);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ProtectionTermObligationType":
					{
						value = ProtectionTermObligationType;
						break;
					}
					case "ProtectionTermObligationValue":
					{
						value = ProtectionTermObligationValue;
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
				ProtectionTermObligationType = null;
				ProtectionTermObligationValue = null;
			}
		}
		[Group(NoOfTag = 40201, Offset = 0, Required = false)]
		public NoProtectionTermObligations[]? ProtectionTermObligations {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ProtectionTermObligations is not null && ProtectionTermObligations.Length != 0)
			{
				writer.WriteWholeNumber(40201, ProtectionTermObligations.Length);
				for (int i = 0; i < ProtectionTermObligations.Length; i++)
				{
					((IFixEncoder)ProtectionTermObligations[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoProtectionTermObligations") is IMessageView viewNoProtectionTermObligations)
			{
				var count = viewNoProtectionTermObligations.GroupCount();
				ProtectionTermObligations = new NoProtectionTermObligations[count];
				for (int i = 0; i < count; i++)
				{
					ProtectionTermObligations[i] = new();
					((IFixParser)ProtectionTermObligations[i]).Parse(viewNoProtectionTermObligations.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoProtectionTermObligations":
				{
					value = ProtectionTermObligations;
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
			ProtectionTermObligations = null;
		}
	}
}
