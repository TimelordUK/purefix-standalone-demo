using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingSecurityXML : IFixComponent
	{
		[TagDetails(Tag = 1874, Type = TagType.Length, Offset = 0, Required = false)]
		public int? UnderlyingSecurityXMLLen {get; set;}
		
		[TagDetails(Tag = 1875, Type = TagType.String, Offset = 1, Required = false)]
		public string? UnderlyingSecurityXMLValue {get; set;}
		
		[TagDetails(Tag = 1876, Type = TagType.String, Offset = 2, Required = false)]
		public string? UnderlyingSecurityXMLSchema {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingSecurityXMLLen is not null) writer.WriteWholeNumber(1874, UnderlyingSecurityXMLLen.Value);
			if (UnderlyingSecurityXMLValue is not null) writer.WriteString(1875, UnderlyingSecurityXMLValue);
			if (UnderlyingSecurityXMLSchema is not null) writer.WriteString(1876, UnderlyingSecurityXMLSchema);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingSecurityXMLLen = view.GetInt32(1874);
			UnderlyingSecurityXMLValue = view.GetString(1875);
			UnderlyingSecurityXMLSchema = view.GetString(1876);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingSecurityXMLLen":
				{
					value = UnderlyingSecurityXMLLen;
					break;
				}
				case "UnderlyingSecurityXML":
				{
					value = UnderlyingSecurityXMLValue;
					break;
				}
				case "UnderlyingSecurityXMLSchema":
				{
					value = UnderlyingSecurityXMLSchema;
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
			UnderlyingSecurityXMLLen = null;
			UnderlyingSecurityXMLValue = null;
			UnderlyingSecurityXMLSchema = null;
		}
	}
}
