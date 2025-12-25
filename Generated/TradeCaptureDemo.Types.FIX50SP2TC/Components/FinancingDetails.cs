using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class FinancingDetails : IFixComponent
	{
		[TagDetails(Tag = 913, Type = TagType.String, Offset = 0, Required = false)]
		public string? AgreementDesc {get; set;}
		
		[TagDetails(Tag = 914, Type = TagType.String, Offset = 1, Required = false)]
		public string? AgreementID {get; set;}
		
		[TagDetails(Tag = 1961, Type = TagType.String, Offset = 2, Required = false)]
		public string? AgreementVersion {get; set;}
		
		[TagDetails(Tag = 915, Type = TagType.LocalDate, Offset = 3, Required = false)]
		public DateOnly? AgreementDate {get; set;}
		
		[TagDetails(Tag = 918, Type = TagType.String, Offset = 4, Required = false)]
		public string? AgreementCurrency {get; set;}
		
		[TagDetails(Tag = 2952, Type = TagType.String, Offset = 5, Required = false)]
		public string? AgreementCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 1962, Type = TagType.String, Offset = 6, Required = false)]
		public string? MasterConfirmationDesc {get; set;}
		
		[TagDetails(Tag = 1963, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? MasterConfirmationDate {get; set;}
		
		[TagDetails(Tag = 1964, Type = TagType.String, Offset = 8, Required = false)]
		public string? MasterConfirmationAnnexDesc {get; set;}
		
		[TagDetails(Tag = 1965, Type = TagType.LocalDate, Offset = 9, Required = false)]
		public DateOnly? MasterConfirmationAnnexDate {get; set;}
		
		[TagDetails(Tag = 1966, Type = TagType.String, Offset = 10, Required = false)]
		public string? BrokerConfirmationDesc {get; set;}
		
		[Component(Offset = 11, Required = false)]
		public FinancingContractualDefinitionGrp? FinancingContractualDefinitionGrp {get; set;}
		
		[Component(Offset = 12, Required = false)]
		public FinancingTermSupplementGrp? FinancingTermSupplementGrp {get; set;}
		
		[Component(Offset = 13, Required = false)]
		public FinancingContractualMatrixGrp? FinancingContractualMatrixGrp {get; set;}
		
		[TagDetails(Tag = 1967, Type = TagType.String, Offset = 14, Required = false)]
		public string? CreditSupportAgreementDesc {get; set;}
		
		[TagDetails(Tag = 1968, Type = TagType.LocalDate, Offset = 15, Required = false)]
		public DateOnly? CreditSupportAgreementDate {get; set;}
		
		[TagDetails(Tag = 1969, Type = TagType.String, Offset = 16, Required = false)]
		public string? CreditSupportAgreementID {get; set;}
		
		[TagDetails(Tag = 1970, Type = TagType.String, Offset = 17, Required = false)]
		public string? GoverningLaw {get; set;}
		
		[TagDetails(Tag = 1513, Type = TagType.String, Offset = 18, Required = false)]
		public string? DocumentationText {get; set;}
		
		[TagDetails(Tag = 1525, Type = TagType.Length, Offset = 19, Required = false)]
		public int? EncodedDocumentationTextLen {get; set;}
		
		[TagDetails(Tag = 1527, Type = TagType.RawData, Offset = 20, Required = false)]
		public byte[]? EncodedDocumentationText {get; set;}
		
		[TagDetails(Tag = 788, Type = TagType.Int, Offset = 21, Required = false)]
		public int? TerminationType {get; set;}
		
		[TagDetails(Tag = 916, Type = TagType.LocalDate, Offset = 22, Required = false)]
		public DateOnly? StartDate {get; set;}
		
		[TagDetails(Tag = 917, Type = TagType.LocalDate, Offset = 23, Required = false)]
		public DateOnly? EndDate {get; set;}
		
		[TagDetails(Tag = 919, Type = TagType.Int, Offset = 24, Required = false)]
		public int? DeliveryType {get; set;}
		
		[TagDetails(Tag = 898, Type = TagType.Float, Offset = 25, Required = false)]
		public double? MarginRatio {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (AgreementDesc is not null) writer.WriteString(913, AgreementDesc);
			if (AgreementID is not null) writer.WriteString(914, AgreementID);
			if (AgreementVersion is not null) writer.WriteString(1961, AgreementVersion);
			if (AgreementDate is not null) writer.WriteLocalDateOnly(915, AgreementDate.Value);
			if (AgreementCurrency is not null) writer.WriteString(918, AgreementCurrency);
			if (AgreementCurrencyCodeSource is not null) writer.WriteString(2952, AgreementCurrencyCodeSource);
			if (MasterConfirmationDesc is not null) writer.WriteString(1962, MasterConfirmationDesc);
			if (MasterConfirmationDate is not null) writer.WriteLocalDateOnly(1963, MasterConfirmationDate.Value);
			if (MasterConfirmationAnnexDesc is not null) writer.WriteString(1964, MasterConfirmationAnnexDesc);
			if (MasterConfirmationAnnexDate is not null) writer.WriteLocalDateOnly(1965, MasterConfirmationAnnexDate.Value);
			if (BrokerConfirmationDesc is not null) writer.WriteString(1966, BrokerConfirmationDesc);
			if (FinancingContractualDefinitionGrp is not null) ((IFixEncoder)FinancingContractualDefinitionGrp).Encode(writer);
			if (FinancingTermSupplementGrp is not null) ((IFixEncoder)FinancingTermSupplementGrp).Encode(writer);
			if (FinancingContractualMatrixGrp is not null) ((IFixEncoder)FinancingContractualMatrixGrp).Encode(writer);
			if (CreditSupportAgreementDesc is not null) writer.WriteString(1967, CreditSupportAgreementDesc);
			if (CreditSupportAgreementDate is not null) writer.WriteLocalDateOnly(1968, CreditSupportAgreementDate.Value);
			if (CreditSupportAgreementID is not null) writer.WriteString(1969, CreditSupportAgreementID);
			if (GoverningLaw is not null) writer.WriteString(1970, GoverningLaw);
			if (DocumentationText is not null) writer.WriteString(1513, DocumentationText);
			if (EncodedDocumentationTextLen is not null) writer.WriteWholeNumber(1525, EncodedDocumentationTextLen.Value);
			if (EncodedDocumentationText is not null) writer.WriteBuffer(1527, EncodedDocumentationText);
			if (TerminationType is not null) writer.WriteWholeNumber(788, TerminationType.Value);
			if (StartDate is not null) writer.WriteLocalDateOnly(916, StartDate.Value);
			if (EndDate is not null) writer.WriteLocalDateOnly(917, EndDate.Value);
			if (DeliveryType is not null) writer.WriteWholeNumber(919, DeliveryType.Value);
			if (MarginRatio is not null) writer.WriteNumber(898, MarginRatio.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			AgreementDesc = view.GetString(913);
			AgreementID = view.GetString(914);
			AgreementVersion = view.GetString(1961);
			AgreementDate = view.GetDateOnly(915);
			AgreementCurrency = view.GetString(918);
			AgreementCurrencyCodeSource = view.GetString(2952);
			MasterConfirmationDesc = view.GetString(1962);
			MasterConfirmationDate = view.GetDateOnly(1963);
			MasterConfirmationAnnexDesc = view.GetString(1964);
			MasterConfirmationAnnexDate = view.GetDateOnly(1965);
			BrokerConfirmationDesc = view.GetString(1966);
			if (view.GetView("FinancingContractualDefinitionGrp") is IMessageView viewFinancingContractualDefinitionGrp)
			{
				FinancingContractualDefinitionGrp = new();
				((IFixParser)FinancingContractualDefinitionGrp).Parse(viewFinancingContractualDefinitionGrp);
			}
			if (view.GetView("FinancingTermSupplementGrp") is IMessageView viewFinancingTermSupplementGrp)
			{
				FinancingTermSupplementGrp = new();
				((IFixParser)FinancingTermSupplementGrp).Parse(viewFinancingTermSupplementGrp);
			}
			if (view.GetView("FinancingContractualMatrixGrp") is IMessageView viewFinancingContractualMatrixGrp)
			{
				FinancingContractualMatrixGrp = new();
				((IFixParser)FinancingContractualMatrixGrp).Parse(viewFinancingContractualMatrixGrp);
			}
			CreditSupportAgreementDesc = view.GetString(1967);
			CreditSupportAgreementDate = view.GetDateOnly(1968);
			CreditSupportAgreementID = view.GetString(1969);
			GoverningLaw = view.GetString(1970);
			DocumentationText = view.GetString(1513);
			EncodedDocumentationTextLen = view.GetInt32(1525);
			EncodedDocumentationText = view.GetByteArray(1527);
			TerminationType = view.GetInt32(788);
			StartDate = view.GetDateOnly(916);
			EndDate = view.GetDateOnly(917);
			DeliveryType = view.GetInt32(919);
			MarginRatio = view.GetDouble(898);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "AgreementDesc":
				{
					value = AgreementDesc;
					break;
				}
				case "AgreementID":
				{
					value = AgreementID;
					break;
				}
				case "AgreementVersion":
				{
					value = AgreementVersion;
					break;
				}
				case "AgreementDate":
				{
					value = AgreementDate;
					break;
				}
				case "AgreementCurrency":
				{
					value = AgreementCurrency;
					break;
				}
				case "AgreementCurrencyCodeSource":
				{
					value = AgreementCurrencyCodeSource;
					break;
				}
				case "MasterConfirmationDesc":
				{
					value = MasterConfirmationDesc;
					break;
				}
				case "MasterConfirmationDate":
				{
					value = MasterConfirmationDate;
					break;
				}
				case "MasterConfirmationAnnexDesc":
				{
					value = MasterConfirmationAnnexDesc;
					break;
				}
				case "MasterConfirmationAnnexDate":
				{
					value = MasterConfirmationAnnexDate;
					break;
				}
				case "BrokerConfirmationDesc":
				{
					value = BrokerConfirmationDesc;
					break;
				}
				case "FinancingContractualDefinitionGrp":
				{
					value = FinancingContractualDefinitionGrp;
					break;
				}
				case "FinancingTermSupplementGrp":
				{
					value = FinancingTermSupplementGrp;
					break;
				}
				case "FinancingContractualMatrixGrp":
				{
					value = FinancingContractualMatrixGrp;
					break;
				}
				case "CreditSupportAgreementDesc":
				{
					value = CreditSupportAgreementDesc;
					break;
				}
				case "CreditSupportAgreementDate":
				{
					value = CreditSupportAgreementDate;
					break;
				}
				case "CreditSupportAgreementID":
				{
					value = CreditSupportAgreementID;
					break;
				}
				case "GoverningLaw":
				{
					value = GoverningLaw;
					break;
				}
				case "DocumentationText":
				{
					value = DocumentationText;
					break;
				}
				case "EncodedDocumentationTextLen":
				{
					value = EncodedDocumentationTextLen;
					break;
				}
				case "EncodedDocumentationText":
				{
					value = EncodedDocumentationText;
					break;
				}
				case "TerminationType":
				{
					value = TerminationType;
					break;
				}
				case "StartDate":
				{
					value = StartDate;
					break;
				}
				case "EndDate":
				{
					value = EndDate;
					break;
				}
				case "DeliveryType":
				{
					value = DeliveryType;
					break;
				}
				case "MarginRatio":
				{
					value = MarginRatio;
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
			AgreementDesc = null;
			AgreementID = null;
			AgreementVersion = null;
			AgreementDate = null;
			AgreementCurrency = null;
			AgreementCurrencyCodeSource = null;
			MasterConfirmationDesc = null;
			MasterConfirmationDate = null;
			MasterConfirmationAnnexDesc = null;
			MasterConfirmationAnnexDate = null;
			BrokerConfirmationDesc = null;
			((IFixReset?)FinancingContractualDefinitionGrp)?.Reset();
			((IFixReset?)FinancingTermSupplementGrp)?.Reset();
			((IFixReset?)FinancingContractualMatrixGrp)?.Reset();
			CreditSupportAgreementDesc = null;
			CreditSupportAgreementDate = null;
			CreditSupportAgreementID = null;
			GoverningLaw = null;
			DocumentationText = null;
			EncodedDocumentationTextLen = null;
			EncodedDocumentationText = null;
			TerminationType = null;
			StartDate = null;
			EndDate = null;
			DeliveryType = null;
			MarginRatio = null;
		}
	}
}
