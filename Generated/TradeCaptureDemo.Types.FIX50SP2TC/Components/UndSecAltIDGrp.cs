using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UndSecAltIDGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingSecurityAltID : IFixGroup
		{
			[TagDetails(Tag = 458, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingSecurityAltID {get; set;}
			
			[TagDetails(Tag = 459, Type = TagType.String, Offset = 1, Required = false)]
			public string? UnderlyingSecurityAltIDSource {get; set;}
			
			[TagDetails(Tag = 2959, Type = TagType.Int, Offset = 2, Required = false)]
			public int? UnderlyingSymbolPositionNumber {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingSecurityAltID is not null) writer.WriteString(458, UnderlyingSecurityAltID);
				if (UnderlyingSecurityAltIDSource is not null) writer.WriteString(459, UnderlyingSecurityAltIDSource);
				if (UnderlyingSymbolPositionNumber is not null) writer.WriteWholeNumber(2959, UnderlyingSymbolPositionNumber.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingSecurityAltID = view.GetString(458);
				UnderlyingSecurityAltIDSource = view.GetString(459);
				UnderlyingSymbolPositionNumber = view.GetInt32(2959);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingSecurityAltID":
					{
						value = UnderlyingSecurityAltID;
						break;
					}
					case "UnderlyingSecurityAltIDSource":
					{
						value = UnderlyingSecurityAltIDSource;
						break;
					}
					case "UnderlyingSymbolPositionNumber":
					{
						value = UnderlyingSymbolPositionNumber;
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
				UnderlyingSecurityAltID = null;
				UnderlyingSecurityAltIDSource = null;
				UnderlyingSymbolPositionNumber = null;
			}
		}
		[Group(NoOfTag = 457, Offset = 0, Required = false)]
		public NoUnderlyingSecurityAltID[]? UnderlyingSecurityAltID {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingSecurityAltID is not null && UnderlyingSecurityAltID.Length != 0)
			{
				writer.WriteWholeNumber(457, UnderlyingSecurityAltID.Length);
				for (int i = 0; i < UnderlyingSecurityAltID.Length; i++)
				{
					((IFixEncoder)UnderlyingSecurityAltID[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingSecurityAltID") is IMessageView viewNoUnderlyingSecurityAltID)
			{
				var count = viewNoUnderlyingSecurityAltID.GroupCount();
				UnderlyingSecurityAltID = new NoUnderlyingSecurityAltID[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingSecurityAltID[i] = new();
					((IFixParser)UnderlyingSecurityAltID[i]).Parse(viewNoUnderlyingSecurityAltID.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingSecurityAltID":
				{
					value = UnderlyingSecurityAltID;
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
			UnderlyingSecurityAltID = null;
		}
	}
}
