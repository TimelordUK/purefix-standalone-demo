using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentSettlParties : IFixComponent
	{
		public sealed partial class NoPaymentSettlPartyIDs : IFixGroup
		{
			[TagDetails(Tag = 40234, Type = TagType.String, Offset = 0, Required = false)]
			public string? PaymentSettlPartyID {get; set;}
			
			[TagDetails(Tag = 40235, Type = TagType.String, Offset = 1, Required = false)]
			public string? PaymentSettlPartyIDSource {get; set;}
			
			[TagDetails(Tag = 40236, Type = TagType.Int, Offset = 2, Required = false)]
			public int? PaymentSettlPartyRole {get; set;}
			
			[TagDetails(Tag = 40237, Type = TagType.Int, Offset = 3, Required = false)]
			public int? PaymentSettlPartyRoleQualifier {get; set;}
			
			[Component(Offset = 4, Required = false)]
			public PaymentSettlPtysSubGrp? PaymentSettlPtysSubGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PaymentSettlPartyID is not null) writer.WriteString(40234, PaymentSettlPartyID);
				if (PaymentSettlPartyIDSource is not null) writer.WriteString(40235, PaymentSettlPartyIDSource);
				if (PaymentSettlPartyRole is not null) writer.WriteWholeNumber(40236, PaymentSettlPartyRole.Value);
				if (PaymentSettlPartyRoleQualifier is not null) writer.WriteWholeNumber(40237, PaymentSettlPartyRoleQualifier.Value);
				if (PaymentSettlPtysSubGrp is not null) ((IFixEncoder)PaymentSettlPtysSubGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PaymentSettlPartyID = view.GetString(40234);
				PaymentSettlPartyIDSource = view.GetString(40235);
				PaymentSettlPartyRole = view.GetInt32(40236);
				PaymentSettlPartyRoleQualifier = view.GetInt32(40237);
				if (view.GetView("PaymentSettlPtysSubGrp") is IMessageView viewPaymentSettlPtysSubGrp)
				{
					PaymentSettlPtysSubGrp = new();
					((IFixParser)PaymentSettlPtysSubGrp).Parse(viewPaymentSettlPtysSubGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PaymentSettlPartyID":
					{
						value = PaymentSettlPartyID;
						break;
					}
					case "PaymentSettlPartyIDSource":
					{
						value = PaymentSettlPartyIDSource;
						break;
					}
					case "PaymentSettlPartyRole":
					{
						value = PaymentSettlPartyRole;
						break;
					}
					case "PaymentSettlPartyRoleQualifier":
					{
						value = PaymentSettlPartyRoleQualifier;
						break;
					}
					case "PaymentSettlPtysSubGrp":
					{
						value = PaymentSettlPtysSubGrp;
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
				PaymentSettlPartyID = null;
				PaymentSettlPartyIDSource = null;
				PaymentSettlPartyRole = null;
				PaymentSettlPartyRoleQualifier = null;
				((IFixReset?)PaymentSettlPtysSubGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 40233, Offset = 0, Required = false)]
		public NoPaymentSettlPartyIDs[]? PaymentSettlPartyIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentSettlPartyIDs is not null && PaymentSettlPartyIDs.Length != 0)
			{
				writer.WriteWholeNumber(40233, PaymentSettlPartyIDs.Length);
				for (int i = 0; i < PaymentSettlPartyIDs.Length; i++)
				{
					((IFixEncoder)PaymentSettlPartyIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPaymentSettlPartyIDs") is IMessageView viewNoPaymentSettlPartyIDs)
			{
				var count = viewNoPaymentSettlPartyIDs.GroupCount();
				PaymentSettlPartyIDs = new NoPaymentSettlPartyIDs[count];
				for (int i = 0; i < count; i++)
				{
					PaymentSettlPartyIDs[i] = new();
					((IFixParser)PaymentSettlPartyIDs[i]).Parse(viewNoPaymentSettlPartyIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPaymentSettlPartyIDs":
				{
					value = PaymentSettlPartyIDs;
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
			PaymentSettlPartyIDs = null;
		}
	}
}
