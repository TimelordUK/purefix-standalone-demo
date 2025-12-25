using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class DerivativeSecurityXML : IFixComponent
	{
		[TagDetails(Tag = 1282, Type = TagType.Length, Offset = 0, Required = false)]
		public int? DerivativeSecurityXMLLen {get; set;}
		
		[TagDetails(Tag = 1283, Type = TagType.String, Offset = 1, Required = false)]
		public string? DerivativeSecurityXMLValue {get; set;}
		
		[TagDetails(Tag = 1284, Type = TagType.String, Offset = 2, Required = false)]
		public string? DerivativeSecurityXMLSchema {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (DerivativeSecurityXMLLen is not null) writer.WriteWholeNumber(1282, DerivativeSecurityXMLLen.Value);
			if (DerivativeSecurityXMLValue is not null) writer.WriteString(1283, DerivativeSecurityXMLValue);
			if (DerivativeSecurityXMLSchema is not null) writer.WriteString(1284, DerivativeSecurityXMLSchema);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			DerivativeSecurityXMLLen = view.GetInt32(1282);
			DerivativeSecurityXMLValue = view.GetString(1283);
			DerivativeSecurityXMLSchema = view.GetString(1284);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "DerivativeSecurityXMLLen":
				{
					value = DerivativeSecurityXMLLen;
					break;
				}
				case "DerivativeSecurityXML":
				{
					value = DerivativeSecurityXMLValue;
					break;
				}
				case "DerivativeSecurityXMLSchema":
				{
					value = DerivativeSecurityXMLSchema;
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
			DerivativeSecurityXMLLen = null;
			DerivativeSecurityXMLValue = null;
			DerivativeSecurityXMLSchema = null;
		}
	}
}
