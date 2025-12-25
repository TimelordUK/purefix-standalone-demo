using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegSecurityXML : IFixComponent
	{
		[TagDetails(Tag = 1871, Type = TagType.Length, Offset = 0, Required = false)]
		public int? LegSecurityXMLLen {get; set;}
		
		[TagDetails(Tag = 1872, Type = TagType.String, Offset = 1, Required = false)]
		public string? LegSecurityXMLValue {get; set;}
		
		[TagDetails(Tag = 1873, Type = TagType.String, Offset = 2, Required = false)]
		public string? LegSecurityXMLSchema {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegSecurityXMLLen is not null) writer.WriteWholeNumber(1871, LegSecurityXMLLen.Value);
			if (LegSecurityXMLValue is not null) writer.WriteString(1872, LegSecurityXMLValue);
			if (LegSecurityXMLSchema is not null) writer.WriteString(1873, LegSecurityXMLSchema);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegSecurityXMLLen = view.GetInt32(1871);
			LegSecurityXMLValue = view.GetString(1872);
			LegSecurityXMLSchema = view.GetString(1873);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegSecurityXMLLen":
				{
					value = LegSecurityXMLLen;
					break;
				}
				case "LegSecurityXML":
				{
					value = LegSecurityXMLValue;
					break;
				}
				case "LegSecurityXMLSchema":
				{
					value = LegSecurityXMLSchema;
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
			LegSecurityXMLLen = null;
			LegSecurityXMLValue = null;
			LegSecurityXMLSchema = null;
		}
	}
}
