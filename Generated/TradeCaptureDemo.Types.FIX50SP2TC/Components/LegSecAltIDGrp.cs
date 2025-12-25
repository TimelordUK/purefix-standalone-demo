using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegSecAltIDGrp : IFixComponent
	{
		public sealed partial class NoLegSecurityAltID : IFixGroup
		{
			[TagDetails(Tag = 605, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegSecurityAltID {get; set;}
			
			[TagDetails(Tag = 606, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegSecurityAltIDSource {get; set;}
			
			[TagDetails(Tag = 2958, Type = TagType.Int, Offset = 2, Required = false)]
			public int? LegSymbolPositionNumber {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegSecurityAltID is not null) writer.WriteString(605, LegSecurityAltID);
				if (LegSecurityAltIDSource is not null) writer.WriteString(606, LegSecurityAltIDSource);
				if (LegSymbolPositionNumber is not null) writer.WriteWholeNumber(2958, LegSymbolPositionNumber.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegSecurityAltID = view.GetString(605);
				LegSecurityAltIDSource = view.GetString(606);
				LegSymbolPositionNumber = view.GetInt32(2958);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegSecurityAltID":
					{
						value = LegSecurityAltID;
						break;
					}
					case "LegSecurityAltIDSource":
					{
						value = LegSecurityAltIDSource;
						break;
					}
					case "LegSymbolPositionNumber":
					{
						value = LegSymbolPositionNumber;
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
				LegSecurityAltID = null;
				LegSecurityAltIDSource = null;
				LegSymbolPositionNumber = null;
			}
		}
		[Group(NoOfTag = 604, Offset = 0, Required = false)]
		public NoLegSecurityAltID[]? LegSecurityAltID {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegSecurityAltID is not null && LegSecurityAltID.Length != 0)
			{
				writer.WriteWholeNumber(604, LegSecurityAltID.Length);
				for (int i = 0; i < LegSecurityAltID.Length; i++)
				{
					((IFixEncoder)LegSecurityAltID[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegSecurityAltID") is IMessageView viewNoLegSecurityAltID)
			{
				var count = viewNoLegSecurityAltID.GroupCount();
				LegSecurityAltID = new NoLegSecurityAltID[count];
				for (int i = 0; i < count; i++)
				{
					LegSecurityAltID[i] = new();
					((IFixParser)LegSecurityAltID[i]).Parse(viewNoLegSecurityAltID.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegSecurityAltID":
				{
					value = LegSecurityAltID;
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
			LegSecurityAltID = null;
		}
	}
}
