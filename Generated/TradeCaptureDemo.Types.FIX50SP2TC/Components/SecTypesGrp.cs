using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class SecTypesGrp : IFixComponent
	{
		public sealed partial class NoSecurityTypes : IFixGroup
		{
			[TagDetails(Tag = 167, Type = TagType.String, Offset = 0, Required = false)]
			public string? SecurityType {get; set;}
			
			[TagDetails(Tag = 762, Type = TagType.String, Offset = 1, Required = false)]
			public string? SecuritySubType {get; set;}
			
			[TagDetails(Tag = 460, Type = TagType.Int, Offset = 2, Required = false)]
			public int? Product {get; set;}
			
			[TagDetails(Tag = 461, Type = TagType.String, Offset = 3, Required = false)]
			public string? CFICode {get; set;}
			
			[TagDetails(Tag = 2891, Type = TagType.String, Offset = 4, Required = false)]
			public string? UPICode {get; set;}
			
			[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 5, Required = false)]
			public DateTime? TransactTime {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (SecurityType is not null) writer.WriteString(167, SecurityType);
				if (SecuritySubType is not null) writer.WriteString(762, SecuritySubType);
				if (Product is not null) writer.WriteWholeNumber(460, Product.Value);
				if (CFICode is not null) writer.WriteString(461, CFICode);
				if (UPICode is not null) writer.WriteString(2891, UPICode);
				if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				SecurityType = view.GetString(167);
				SecuritySubType = view.GetString(762);
				Product = view.GetInt32(460);
				CFICode = view.GetString(461);
				UPICode = view.GetString(2891);
				TransactTime = view.GetDateTime(60);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "SecurityType":
					{
						value = SecurityType;
						break;
					}
					case "SecuritySubType":
					{
						value = SecuritySubType;
						break;
					}
					case "Product":
					{
						value = Product;
						break;
					}
					case "CFICode":
					{
						value = CFICode;
						break;
					}
					case "UPICode":
					{
						value = UPICode;
						break;
					}
					case "TransactTime":
					{
						value = TransactTime;
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
				SecurityType = null;
				SecuritySubType = null;
				Product = null;
				CFICode = null;
				UPICode = null;
				TransactTime = null;
			}
		}
		[Group(NoOfTag = 558, Offset = 0, Required = false)]
		public NoSecurityTypes[]? SecurityTypes {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (SecurityTypes is not null && SecurityTypes.Length != 0)
			{
				writer.WriteWholeNumber(558, SecurityTypes.Length);
				for (int i = 0; i < SecurityTypes.Length; i++)
				{
					((IFixEncoder)SecurityTypes[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoSecurityTypes") is IMessageView viewNoSecurityTypes)
			{
				var count = viewNoSecurityTypes.GroupCount();
				SecurityTypes = new NoSecurityTypes[count];
				for (int i = 0; i < count; i++)
				{
					SecurityTypes[i] = new();
					((IFixParser)SecurityTypes[i]).Parse(viewNoSecurityTypes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoSecurityTypes":
				{
					value = SecurityTypes;
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
			SecurityTypes = null;
		}
	}
}
