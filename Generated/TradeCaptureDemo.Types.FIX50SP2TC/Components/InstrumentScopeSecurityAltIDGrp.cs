using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class InstrumentScopeSecurityAltIDGrp : IFixComponent
	{
		public sealed partial class NoInstrumentScopeSecurityAltID : IFixGroup
		{
			[TagDetails(Tag = 1541, Type = TagType.String, Offset = 0, Required = false)]
			public string? InstrumentScopeSecurityAltID {get; set;}
			
			[TagDetails(Tag = 1542, Type = TagType.String, Offset = 1, Required = false)]
			public string? InstrumentScopeSecurityAltIDSource {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (InstrumentScopeSecurityAltID is not null) writer.WriteString(1541, InstrumentScopeSecurityAltID);
				if (InstrumentScopeSecurityAltIDSource is not null) writer.WriteString(1542, InstrumentScopeSecurityAltIDSource);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				InstrumentScopeSecurityAltID = view.GetString(1541);
				InstrumentScopeSecurityAltIDSource = view.GetString(1542);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "InstrumentScopeSecurityAltID":
					{
						value = InstrumentScopeSecurityAltID;
						break;
					}
					case "InstrumentScopeSecurityAltIDSource":
					{
						value = InstrumentScopeSecurityAltIDSource;
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
				InstrumentScopeSecurityAltID = null;
				InstrumentScopeSecurityAltIDSource = null;
			}
		}
		[Group(NoOfTag = 1540, Offset = 0, Required = false)]
		public NoInstrumentScopeSecurityAltID[]? InstrumentScopeSecurityAltID {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (InstrumentScopeSecurityAltID is not null && InstrumentScopeSecurityAltID.Length != 0)
			{
				writer.WriteWholeNumber(1540, InstrumentScopeSecurityAltID.Length);
				for (int i = 0; i < InstrumentScopeSecurityAltID.Length; i++)
				{
					((IFixEncoder)InstrumentScopeSecurityAltID[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoInstrumentScopeSecurityAltID") is IMessageView viewNoInstrumentScopeSecurityAltID)
			{
				var count = viewNoInstrumentScopeSecurityAltID.GroupCount();
				InstrumentScopeSecurityAltID = new NoInstrumentScopeSecurityAltID[count];
				for (int i = 0; i < count; i++)
				{
					InstrumentScopeSecurityAltID[i] = new();
					((IFixParser)InstrumentScopeSecurityAltID[i]).Parse(viewNoInstrumentScopeSecurityAltID.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoInstrumentScopeSecurityAltID":
				{
					value = InstrumentScopeSecurityAltID;
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
			InstrumentScopeSecurityAltID = null;
		}
	}
}
