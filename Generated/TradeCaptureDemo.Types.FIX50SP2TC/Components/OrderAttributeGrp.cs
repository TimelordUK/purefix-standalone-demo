using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class OrderAttributeGrp : IFixComponent
	{
		public sealed partial class NoOrderAttributes : IFixGroup
		{
			[TagDetails(Tag = 2594, Type = TagType.Int, Offset = 0, Required = false)]
			public int? OrderAttributeType {get; set;}
			
			[TagDetails(Tag = 2595, Type = TagType.String, Offset = 1, Required = false)]
			public string? OrderAttributeValue {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (OrderAttributeType is not null) writer.WriteWholeNumber(2594, OrderAttributeType.Value);
				if (OrderAttributeValue is not null) writer.WriteString(2595, OrderAttributeValue);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				OrderAttributeType = view.GetInt32(2594);
				OrderAttributeValue = view.GetString(2595);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "OrderAttributeType":
					{
						value = OrderAttributeType;
						break;
					}
					case "OrderAttributeValue":
					{
						value = OrderAttributeValue;
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
				OrderAttributeType = null;
				OrderAttributeValue = null;
			}
		}
		[Group(NoOfTag = 2593, Offset = 0, Required = false)]
		public NoOrderAttributes[]? OrderAttributes {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (OrderAttributes is not null && OrderAttributes.Length != 0)
			{
				writer.WriteWholeNumber(2593, OrderAttributes.Length);
				for (int i = 0; i < OrderAttributes.Length; i++)
				{
					((IFixEncoder)OrderAttributes[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoOrderAttributes") is IMessageView viewNoOrderAttributes)
			{
				var count = viewNoOrderAttributes.GroupCount();
				OrderAttributes = new NoOrderAttributes[count];
				for (int i = 0; i < count; i++)
				{
					OrderAttributes[i] = new();
					((IFixParser)OrderAttributes[i]).Parse(viewNoOrderAttributes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoOrderAttributes":
				{
					value = OrderAttributes;
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
			OrderAttributes = null;
		}
	}
}
