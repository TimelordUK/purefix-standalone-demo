using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class TransactionAttributeGrp : IFixComponent
	{
		public sealed partial class NoTransactionAttributes : IFixGroup
		{
			[TagDetails(Tag = 2872, Type = TagType.Int, Offset = 0, Required = false)]
			public int? TransactionAttributeType {get; set;}
			
			[TagDetails(Tag = 2873, Type = TagType.String, Offset = 1, Required = false)]
			public string? TransactionAttributeValue {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (TransactionAttributeType is not null) writer.WriteWholeNumber(2872, TransactionAttributeType.Value);
				if (TransactionAttributeValue is not null) writer.WriteString(2873, TransactionAttributeValue);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				TransactionAttributeType = view.GetInt32(2872);
				TransactionAttributeValue = view.GetString(2873);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "TransactionAttributeType":
					{
						value = TransactionAttributeType;
						break;
					}
					case "TransactionAttributeValue":
					{
						value = TransactionAttributeValue;
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
				TransactionAttributeType = null;
				TransactionAttributeValue = null;
			}
		}
		[Group(NoOfTag = 2871, Offset = 0, Required = false)]
		public NoTransactionAttributes[]? TransactionAttributes {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (TransactionAttributes is not null && TransactionAttributes.Length != 0)
			{
				writer.WriteWholeNumber(2871, TransactionAttributes.Length);
				for (int i = 0; i < TransactionAttributes.Length; i++)
				{
					((IFixEncoder)TransactionAttributes[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoTransactionAttributes") is IMessageView viewNoTransactionAttributes)
			{
				var count = viewNoTransactionAttributes.GroupCount();
				TransactionAttributes = new NoTransactionAttributes[count];
				for (int i = 0; i < count; i++)
				{
					TransactionAttributes[i] = new();
					((IFixParser)TransactionAttributes[i]).Parse(viewNoTransactionAttributes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoTransactionAttributes":
				{
					value = TransactionAttributes;
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
			TransactionAttributes = null;
		}
	}
}
