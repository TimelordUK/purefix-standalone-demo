using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class DerivativeSecurityAltIDGrp : IFixComponent
	{
		public sealed partial class NoDerivativeSecurityAltID : IFixGroup
		{
			[TagDetails(Tag = 1219, Type = TagType.String, Offset = 0, Required = false)]
			public string? DerivativeSecurityAltID {get; set;}
			
			[TagDetails(Tag = 1220, Type = TagType.String, Offset = 1, Required = false)]
			public string? DerivativeSecurityAltIDSource {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (DerivativeSecurityAltID is not null) writer.WriteString(1219, DerivativeSecurityAltID);
				if (DerivativeSecurityAltIDSource is not null) writer.WriteString(1220, DerivativeSecurityAltIDSource);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				DerivativeSecurityAltID = view.GetString(1219);
				DerivativeSecurityAltIDSource = view.GetString(1220);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "DerivativeSecurityAltID":
					{
						value = DerivativeSecurityAltID;
						break;
					}
					case "DerivativeSecurityAltIDSource":
					{
						value = DerivativeSecurityAltIDSource;
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
				DerivativeSecurityAltID = null;
				DerivativeSecurityAltIDSource = null;
			}
		}
		[Group(NoOfTag = 1218, Offset = 0, Required = false)]
		public NoDerivativeSecurityAltID[]? DerivativeSecurityAltID {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (DerivativeSecurityAltID is not null && DerivativeSecurityAltID.Length != 0)
			{
				writer.WriteWholeNumber(1218, DerivativeSecurityAltID.Length);
				for (int i = 0; i < DerivativeSecurityAltID.Length; i++)
				{
					((IFixEncoder)DerivativeSecurityAltID[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoDerivativeSecurityAltID") is IMessageView viewNoDerivativeSecurityAltID)
			{
				var count = viewNoDerivativeSecurityAltID.GroupCount();
				DerivativeSecurityAltID = new NoDerivativeSecurityAltID[count];
				for (int i = 0; i < count; i++)
				{
					DerivativeSecurityAltID[i] = new();
					((IFixParser)DerivativeSecurityAltID[i]).Parse(viewNoDerivativeSecurityAltID.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoDerivativeSecurityAltID":
				{
					value = DerivativeSecurityAltID;
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
			DerivativeSecurityAltID = null;
		}
	}
}
