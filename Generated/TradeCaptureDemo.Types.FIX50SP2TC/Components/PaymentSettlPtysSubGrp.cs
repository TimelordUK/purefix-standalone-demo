using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentSettlPtysSubGrp : IFixComponent
	{
		public sealed partial class NoPaymentSettlPartySubIDs : IFixGroup
		{
			[TagDetails(Tag = 40239, Type = TagType.String, Offset = 0, Required = false)]
			public string? PaymentSettlPartySubID {get; set;}
			
			[TagDetails(Tag = 40240, Type = TagType.Int, Offset = 1, Required = false)]
			public int? PaymentSettlPartySubIDType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PaymentSettlPartySubID is not null) writer.WriteString(40239, PaymentSettlPartySubID);
				if (PaymentSettlPartySubIDType is not null) writer.WriteWholeNumber(40240, PaymentSettlPartySubIDType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PaymentSettlPartySubID = view.GetString(40239);
				PaymentSettlPartySubIDType = view.GetInt32(40240);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PaymentSettlPartySubID":
					{
						value = PaymentSettlPartySubID;
						break;
					}
					case "PaymentSettlPartySubIDType":
					{
						value = PaymentSettlPartySubIDType;
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
				PaymentSettlPartySubID = null;
				PaymentSettlPartySubIDType = null;
			}
		}
		[Group(NoOfTag = 40238, Offset = 0, Required = false)]
		public NoPaymentSettlPartySubIDs[]? PaymentSettlPartySubIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentSettlPartySubIDs is not null && PaymentSettlPartySubIDs.Length != 0)
			{
				writer.WriteWholeNumber(40238, PaymentSettlPartySubIDs.Length);
				for (int i = 0; i < PaymentSettlPartySubIDs.Length; i++)
				{
					((IFixEncoder)PaymentSettlPartySubIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPaymentSettlPartySubIDs") is IMessageView viewNoPaymentSettlPartySubIDs)
			{
				var count = viewNoPaymentSettlPartySubIDs.GroupCount();
				PaymentSettlPartySubIDs = new NoPaymentSettlPartySubIDs[count];
				for (int i = 0; i < count; i++)
				{
					PaymentSettlPartySubIDs[i] = new();
					((IFixParser)PaymentSettlPartySubIDs[i]).Parse(viewNoPaymentSettlPartySubIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPaymentSettlPartySubIDs":
				{
					value = PaymentSettlPartySubIDs;
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
			PaymentSettlPartySubIDs = null;
		}
	}
}
