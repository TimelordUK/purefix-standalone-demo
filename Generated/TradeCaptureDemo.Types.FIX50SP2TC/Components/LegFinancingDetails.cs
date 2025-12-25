using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegFinancingDetails : IFixComponent
	{
		[TagDetails(Tag = 2497, Type = TagType.String, Offset = 0, Required = false)]
		public string? LegAgreementDesc {get; set;}
		
		[TagDetails(Tag = 2498, Type = TagType.String, Offset = 1, Required = false)]
		public string? LegAgreementID {get; set;}
		
		[TagDetails(Tag = 2499, Type = TagType.String, Offset = 2, Required = false)]
		public string? LegAgreementVersion {get; set;}
		
		[TagDetails(Tag = 2496, Type = TagType.LocalDate, Offset = 3, Required = false)]
		public DateOnly? LegAgreementDate {get; set;}
		
		[TagDetails(Tag = 2495, Type = TagType.String, Offset = 4, Required = false)]
		public string? LegAgreementCurrency {get; set;}
		
		[TagDetails(Tag = 2953, Type = TagType.String, Offset = 5, Required = false)]
		public string? LegAgreementCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 2511, Type = TagType.String, Offset = 6, Required = false)]
		public string? LegMasterConfirmationDesc {get; set;}
		
		[TagDetails(Tag = 2510, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? LegMasterConfirmationDate {get; set;}
		
		[TagDetails(Tag = 2512, Type = TagType.String, Offset = 8, Required = false)]
		public string? LegMasterConfirmationAnnexDesc {get; set;}
		
		[TagDetails(Tag = 2509, Type = TagType.LocalDate, Offset = 9, Required = false)]
		public DateOnly? LegMasterConfirmationAnnexDate {get; set;}
		
		[TagDetails(Tag = 2500, Type = TagType.String, Offset = 10, Required = false)]
		public string? LegBrokerConfirmationDesc {get; set;}
		
		[Component(Offset = 11, Required = false)]
		public LegFinancingContractualDefinitionsGrp? LegFinancingContractualDefinitionsGrp {get; set;}
		
		[Component(Offset = 12, Required = false)]
		public LegFinancingTermSupplementGrp? LegFinancingTermSupplementGrp {get; set;}
		
		[Component(Offset = 13, Required = false)]
		public LegFinancingContractualMatrixGrp? LegFinancingContractualMatrixGrp {get; set;}
		
		[TagDetails(Tag = 2502, Type = TagType.String, Offset = 14, Required = false)]
		public string? LegCreditSupportAgreementDesc {get; set;}
		
		[TagDetails(Tag = 2501, Type = TagType.LocalDate, Offset = 15, Required = false)]
		public DateOnly? LegCreditSupportAgreementDate {get; set;}
		
		[TagDetails(Tag = 2503, Type = TagType.String, Offset = 16, Required = false)]
		public string? LegCreditSupportAgreementID {get; set;}
		
		[TagDetails(Tag = 2507, Type = TagType.String, Offset = 17, Required = false)]
		public string? LegGoverningLaw {get; set;}
		
		[TagDetails(Tag = 2505, Type = TagType.String, Offset = 18, Required = false)]
		public string? LegDocumentationText {get; set;}
		
		[TagDetails(Tag = 2494, Type = TagType.Length, Offset = 19, Required = false)]
		public int? EncodedLegDocumentationTextLen {get; set;}
		
		[TagDetails(Tag = 2493, Type = TagType.RawData, Offset = 20, Required = false)]
		public byte[]? EncodedLegDocumentationText {get; set;}
		
		[TagDetails(Tag = 2514, Type = TagType.Int, Offset = 21, Required = false)]
		public int? LegTerminationType {get; set;}
		
		[TagDetails(Tag = 2513, Type = TagType.LocalDate, Offset = 22, Required = false)]
		public DateOnly? LegStartDate {get; set;}
		
		[TagDetails(Tag = 2506, Type = TagType.LocalDate, Offset = 23, Required = false)]
		public DateOnly? LegEndDate {get; set;}
		
		[TagDetails(Tag = 2504, Type = TagType.Int, Offset = 24, Required = false)]
		public int? LegDeliveryType {get; set;}
		
		[TagDetails(Tag = 2508, Type = TagType.Float, Offset = 25, Required = false)]
		public double? LegMarginRatio {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegAgreementDesc is not null) writer.WriteString(2497, LegAgreementDesc);
			if (LegAgreementID is not null) writer.WriteString(2498, LegAgreementID);
			if (LegAgreementVersion is not null) writer.WriteString(2499, LegAgreementVersion);
			if (LegAgreementDate is not null) writer.WriteLocalDateOnly(2496, LegAgreementDate.Value);
			if (LegAgreementCurrency is not null) writer.WriteString(2495, LegAgreementCurrency);
			if (LegAgreementCurrencyCodeSource is not null) writer.WriteString(2953, LegAgreementCurrencyCodeSource);
			if (LegMasterConfirmationDesc is not null) writer.WriteString(2511, LegMasterConfirmationDesc);
			if (LegMasterConfirmationDate is not null) writer.WriteLocalDateOnly(2510, LegMasterConfirmationDate.Value);
			if (LegMasterConfirmationAnnexDesc is not null) writer.WriteString(2512, LegMasterConfirmationAnnexDesc);
			if (LegMasterConfirmationAnnexDate is not null) writer.WriteLocalDateOnly(2509, LegMasterConfirmationAnnexDate.Value);
			if (LegBrokerConfirmationDesc is not null) writer.WriteString(2500, LegBrokerConfirmationDesc);
			if (LegFinancingContractualDefinitionsGrp is not null) ((IFixEncoder)LegFinancingContractualDefinitionsGrp).Encode(writer);
			if (LegFinancingTermSupplementGrp is not null) ((IFixEncoder)LegFinancingTermSupplementGrp).Encode(writer);
			if (LegFinancingContractualMatrixGrp is not null) ((IFixEncoder)LegFinancingContractualMatrixGrp).Encode(writer);
			if (LegCreditSupportAgreementDesc is not null) writer.WriteString(2502, LegCreditSupportAgreementDesc);
			if (LegCreditSupportAgreementDate is not null) writer.WriteLocalDateOnly(2501, LegCreditSupportAgreementDate.Value);
			if (LegCreditSupportAgreementID is not null) writer.WriteString(2503, LegCreditSupportAgreementID);
			if (LegGoverningLaw is not null) writer.WriteString(2507, LegGoverningLaw);
			if (LegDocumentationText is not null) writer.WriteString(2505, LegDocumentationText);
			if (EncodedLegDocumentationTextLen is not null) writer.WriteWholeNumber(2494, EncodedLegDocumentationTextLen.Value);
			if (EncodedLegDocumentationText is not null) writer.WriteBuffer(2493, EncodedLegDocumentationText);
			if (LegTerminationType is not null) writer.WriteWholeNumber(2514, LegTerminationType.Value);
			if (LegStartDate is not null) writer.WriteLocalDateOnly(2513, LegStartDate.Value);
			if (LegEndDate is not null) writer.WriteLocalDateOnly(2506, LegEndDate.Value);
			if (LegDeliveryType is not null) writer.WriteWholeNumber(2504, LegDeliveryType.Value);
			if (LegMarginRatio is not null) writer.WriteNumber(2508, LegMarginRatio.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegAgreementDesc = view.GetString(2497);
			LegAgreementID = view.GetString(2498);
			LegAgreementVersion = view.GetString(2499);
			LegAgreementDate = view.GetDateOnly(2496);
			LegAgreementCurrency = view.GetString(2495);
			LegAgreementCurrencyCodeSource = view.GetString(2953);
			LegMasterConfirmationDesc = view.GetString(2511);
			LegMasterConfirmationDate = view.GetDateOnly(2510);
			LegMasterConfirmationAnnexDesc = view.GetString(2512);
			LegMasterConfirmationAnnexDate = view.GetDateOnly(2509);
			LegBrokerConfirmationDesc = view.GetString(2500);
			if (view.GetView("LegFinancingContractualDefinitionsGrp") is IMessageView viewLegFinancingContractualDefinitionsGrp)
			{
				LegFinancingContractualDefinitionsGrp = new();
				((IFixParser)LegFinancingContractualDefinitionsGrp).Parse(viewLegFinancingContractualDefinitionsGrp);
			}
			if (view.GetView("LegFinancingTermSupplementGrp") is IMessageView viewLegFinancingTermSupplementGrp)
			{
				LegFinancingTermSupplementGrp = new();
				((IFixParser)LegFinancingTermSupplementGrp).Parse(viewLegFinancingTermSupplementGrp);
			}
			if (view.GetView("LegFinancingContractualMatrixGrp") is IMessageView viewLegFinancingContractualMatrixGrp)
			{
				LegFinancingContractualMatrixGrp = new();
				((IFixParser)LegFinancingContractualMatrixGrp).Parse(viewLegFinancingContractualMatrixGrp);
			}
			LegCreditSupportAgreementDesc = view.GetString(2502);
			LegCreditSupportAgreementDate = view.GetDateOnly(2501);
			LegCreditSupportAgreementID = view.GetString(2503);
			LegGoverningLaw = view.GetString(2507);
			LegDocumentationText = view.GetString(2505);
			EncodedLegDocumentationTextLen = view.GetInt32(2494);
			EncodedLegDocumentationText = view.GetByteArray(2493);
			LegTerminationType = view.GetInt32(2514);
			LegStartDate = view.GetDateOnly(2513);
			LegEndDate = view.GetDateOnly(2506);
			LegDeliveryType = view.GetInt32(2504);
			LegMarginRatio = view.GetDouble(2508);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegAgreementDesc":
				{
					value = LegAgreementDesc;
					break;
				}
				case "LegAgreementID":
				{
					value = LegAgreementID;
					break;
				}
				case "LegAgreementVersion":
				{
					value = LegAgreementVersion;
					break;
				}
				case "LegAgreementDate":
				{
					value = LegAgreementDate;
					break;
				}
				case "LegAgreementCurrency":
				{
					value = LegAgreementCurrency;
					break;
				}
				case "LegAgreementCurrencyCodeSource":
				{
					value = LegAgreementCurrencyCodeSource;
					break;
				}
				case "LegMasterConfirmationDesc":
				{
					value = LegMasterConfirmationDesc;
					break;
				}
				case "LegMasterConfirmationDate":
				{
					value = LegMasterConfirmationDate;
					break;
				}
				case "LegMasterConfirmationAnnexDesc":
				{
					value = LegMasterConfirmationAnnexDesc;
					break;
				}
				case "LegMasterConfirmationAnnexDate":
				{
					value = LegMasterConfirmationAnnexDate;
					break;
				}
				case "LegBrokerConfirmationDesc":
				{
					value = LegBrokerConfirmationDesc;
					break;
				}
				case "LegFinancingContractualDefinitionsGrp":
				{
					value = LegFinancingContractualDefinitionsGrp;
					break;
				}
				case "LegFinancingTermSupplementGrp":
				{
					value = LegFinancingTermSupplementGrp;
					break;
				}
				case "LegFinancingContractualMatrixGrp":
				{
					value = LegFinancingContractualMatrixGrp;
					break;
				}
				case "LegCreditSupportAgreementDesc":
				{
					value = LegCreditSupportAgreementDesc;
					break;
				}
				case "LegCreditSupportAgreementDate":
				{
					value = LegCreditSupportAgreementDate;
					break;
				}
				case "LegCreditSupportAgreementID":
				{
					value = LegCreditSupportAgreementID;
					break;
				}
				case "LegGoverningLaw":
				{
					value = LegGoverningLaw;
					break;
				}
				case "LegDocumentationText":
				{
					value = LegDocumentationText;
					break;
				}
				case "EncodedLegDocumentationTextLen":
				{
					value = EncodedLegDocumentationTextLen;
					break;
				}
				case "EncodedLegDocumentationText":
				{
					value = EncodedLegDocumentationText;
					break;
				}
				case "LegTerminationType":
				{
					value = LegTerminationType;
					break;
				}
				case "LegStartDate":
				{
					value = LegStartDate;
					break;
				}
				case "LegEndDate":
				{
					value = LegEndDate;
					break;
				}
				case "LegDeliveryType":
				{
					value = LegDeliveryType;
					break;
				}
				case "LegMarginRatio":
				{
					value = LegMarginRatio;
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
			LegAgreementDesc = null;
			LegAgreementID = null;
			LegAgreementVersion = null;
			LegAgreementDate = null;
			LegAgreementCurrency = null;
			LegAgreementCurrencyCodeSource = null;
			LegMasterConfirmationDesc = null;
			LegMasterConfirmationDate = null;
			LegMasterConfirmationAnnexDesc = null;
			LegMasterConfirmationAnnexDate = null;
			LegBrokerConfirmationDesc = null;
			((IFixReset?)LegFinancingContractualDefinitionsGrp)?.Reset();
			((IFixReset?)LegFinancingTermSupplementGrp)?.Reset();
			((IFixReset?)LegFinancingContractualMatrixGrp)?.Reset();
			LegCreditSupportAgreementDesc = null;
			LegCreditSupportAgreementDate = null;
			LegCreditSupportAgreementID = null;
			LegGoverningLaw = null;
			LegDocumentationText = null;
			EncodedLegDocumentationTextLen = null;
			EncodedLegDocumentationText = null;
			LegTerminationType = null;
			LegStartDate = null;
			LegEndDate = null;
			LegDeliveryType = null;
			LegMarginRatio = null;
		}
	}
}
