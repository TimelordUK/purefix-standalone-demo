using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class SecurityXML : IFixComponent
	{
		[TagDetails(Tag = 1184, Type = TagType.Length, Offset = 0, Required = false)]
		public int? SecurityXMLLen {get; set;}
		
		[TagDetails(Tag = 1185, Type = TagType.String, Offset = 1, Required = false)]
		public string? SecurityXMLValue {get; set;}
		
		[TagDetails(Tag = 1186, Type = TagType.String, Offset = 2, Required = false)]
		public string? SecurityXMLSchema {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (SecurityXMLLen is not null) writer.WriteWholeNumber(1184, SecurityXMLLen.Value);
			if (SecurityXMLValue is not null) writer.WriteString(1185, SecurityXMLValue);
			if (SecurityXMLSchema is not null) writer.WriteString(1186, SecurityXMLSchema);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			SecurityXMLLen = view.GetInt32(1184);
			SecurityXMLValue = view.GetString(1185);
			SecurityXMLSchema = view.GetString(1186);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "SecurityXMLLen":
				{
					value = SecurityXMLLen;
					break;
				}
				case "SecurityXML":
				{
					value = SecurityXMLValue;
					break;
				}
				case "SecurityXMLSchema":
				{
					value = SecurityXMLSchema;
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
			SecurityXMLLen = null;
			SecurityXMLValue = null;
			SecurityXMLSchema = null;
		}
	}
}
