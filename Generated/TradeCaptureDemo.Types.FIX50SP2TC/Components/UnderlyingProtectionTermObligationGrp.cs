using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingProtectionTermObligationGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingProtectionTermObligations : IFixGroup
		{
			[TagDetails(Tag = 42088, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingProtectionTermObligationType {get; set;}
			
			[TagDetails(Tag = 42089, Type = TagType.String, Offset = 1, Required = false)]
			public string? UnderlyingProtectionTermObligationValue {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingProtectionTermObligationType is not null) writer.WriteString(42088, UnderlyingProtectionTermObligationType);
				if (UnderlyingProtectionTermObligationValue is not null) writer.WriteString(42089, UnderlyingProtectionTermObligationValue);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingProtectionTermObligationType = view.GetString(42088);
				UnderlyingProtectionTermObligationValue = view.GetString(42089);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingProtectionTermObligationType":
					{
						value = UnderlyingProtectionTermObligationType;
						break;
					}
					case "UnderlyingProtectionTermObligationValue":
					{
						value = UnderlyingProtectionTermObligationValue;
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
				UnderlyingProtectionTermObligationType = null;
				UnderlyingProtectionTermObligationValue = null;
			}
		}
		[Group(NoOfTag = 42087, Offset = 0, Required = false)]
		public NoUnderlyingProtectionTermObligations[]? UnderlyingProtectionTermObligations {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingProtectionTermObligations is not null && UnderlyingProtectionTermObligations.Length != 0)
			{
				writer.WriteWholeNumber(42087, UnderlyingProtectionTermObligations.Length);
				for (int i = 0; i < UnderlyingProtectionTermObligations.Length; i++)
				{
					((IFixEncoder)UnderlyingProtectionTermObligations[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingProtectionTermObligations") is IMessageView viewNoUnderlyingProtectionTermObligations)
			{
				var count = viewNoUnderlyingProtectionTermObligations.GroupCount();
				UnderlyingProtectionTermObligations = new NoUnderlyingProtectionTermObligations[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingProtectionTermObligations[i] = new();
					((IFixParser)UnderlyingProtectionTermObligations[i]).Parse(viewNoUnderlyingProtectionTermObligations.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingProtectionTermObligations":
				{
					value = UnderlyingProtectionTermObligations;
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
			UnderlyingProtectionTermObligations = null;
		}
	}
}
