using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class SecurityClassificationGrp : IFixComponent
	{
		public sealed partial class NoSecurityClassifications : IFixGroup
		{
			[TagDetails(Tag = 1583, Type = TagType.Int, Offset = 0, Required = false)]
			public int? SecurityClassificationReason {get; set;}
			
			[TagDetails(Tag = 1584, Type = TagType.String, Offset = 1, Required = false)]
			public string? SecurityClassificationValue {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (SecurityClassificationReason is not null) writer.WriteWholeNumber(1583, SecurityClassificationReason.Value);
				if (SecurityClassificationValue is not null) writer.WriteString(1584, SecurityClassificationValue);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				SecurityClassificationReason = view.GetInt32(1583);
				SecurityClassificationValue = view.GetString(1584);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "SecurityClassificationReason":
					{
						value = SecurityClassificationReason;
						break;
					}
					case "SecurityClassificationValue":
					{
						value = SecurityClassificationValue;
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
				SecurityClassificationReason = null;
				SecurityClassificationValue = null;
			}
		}
		[Group(NoOfTag = 1582, Offset = 0, Required = false)]
		public NoSecurityClassifications[]? SecurityClassifications {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (SecurityClassifications is not null && SecurityClassifications.Length != 0)
			{
				writer.WriteWholeNumber(1582, SecurityClassifications.Length);
				for (int i = 0; i < SecurityClassifications.Length; i++)
				{
					((IFixEncoder)SecurityClassifications[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoSecurityClassifications") is IMessageView viewNoSecurityClassifications)
			{
				var count = viewNoSecurityClassifications.GroupCount();
				SecurityClassifications = new NoSecurityClassifications[count];
				for (int i = 0; i < count; i++)
				{
					SecurityClassifications[i] = new();
					((IFixParser)SecurityClassifications[i]).Parse(viewNoSecurityClassifications.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoSecurityClassifications":
				{
					value = SecurityClassifications;
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
			SecurityClassifications = null;
		}
	}
}
