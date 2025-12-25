using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingLegSecurityAltIDGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingLegSecurityAltID : IFixGroup
		{
			[TagDetails(Tag = 1335, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingLegSecurityAltID {get; set;}
			
			[TagDetails(Tag = 1336, Type = TagType.String, Offset = 1, Required = false)]
			public string? UnderlyingLegSecurityAltIDSource {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingLegSecurityAltID is not null) writer.WriteString(1335, UnderlyingLegSecurityAltID);
				if (UnderlyingLegSecurityAltIDSource is not null) writer.WriteString(1336, UnderlyingLegSecurityAltIDSource);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingLegSecurityAltID = view.GetString(1335);
				UnderlyingLegSecurityAltIDSource = view.GetString(1336);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingLegSecurityAltID":
					{
						value = UnderlyingLegSecurityAltID;
						break;
					}
					case "UnderlyingLegSecurityAltIDSource":
					{
						value = UnderlyingLegSecurityAltIDSource;
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
				UnderlyingLegSecurityAltID = null;
				UnderlyingLegSecurityAltIDSource = null;
			}
		}
		[Group(NoOfTag = 1334, Offset = 0, Required = false)]
		public NoUnderlyingLegSecurityAltID[]? UnderlyingLegSecurityAltID {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingLegSecurityAltID is not null && UnderlyingLegSecurityAltID.Length != 0)
			{
				writer.WriteWholeNumber(1334, UnderlyingLegSecurityAltID.Length);
				for (int i = 0; i < UnderlyingLegSecurityAltID.Length; i++)
				{
					((IFixEncoder)UnderlyingLegSecurityAltID[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingLegSecurityAltID") is IMessageView viewNoUnderlyingLegSecurityAltID)
			{
				var count = viewNoUnderlyingLegSecurityAltID.GroupCount();
				UnderlyingLegSecurityAltID = new NoUnderlyingLegSecurityAltID[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingLegSecurityAltID[i] = new();
					((IFixParser)UnderlyingLegSecurityAltID[i]).Parse(viewNoUnderlyingLegSecurityAltID.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingLegSecurityAltID":
				{
					value = UnderlyingLegSecurityAltID;
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
			UnderlyingLegSecurityAltID = null;
		}
	}
}
