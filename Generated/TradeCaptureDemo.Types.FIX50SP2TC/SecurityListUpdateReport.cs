using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("BK", FixVersion.FIX50SP2)]
	public sealed partial class SecurityListUpdateReport : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public ApplicationSequenceControl? ApplicationSequenceControl {get; set;}
		
		[TagDetails(Tag = 964, Type = TagType.Int, Offset = 2, Required = false)]
		public int? SecurityReportID {get; set;}
		
		[TagDetails(Tag = 1465, Type = TagType.String, Offset = 3, Required = false)]
		public string? SecurityListID {get; set;}
		
		[TagDetails(Tag = 1466, Type = TagType.String, Offset = 4, Required = false)]
		public string? SecurityListRefID {get; set;}
		
		[TagDetails(Tag = 1467, Type = TagType.String, Offset = 5, Required = false)]
		public string? SecurityListDesc {get; set;}
		
		[TagDetails(Tag = 1468, Type = TagType.Length, Offset = 6, Required = false)]
		public int? EncodedSecurityListDescLen {get; set;}
		
		[TagDetails(Tag = 1469, Type = TagType.RawData, Offset = 7, Required = false)]
		public byte[]? EncodedSecurityListDesc {get; set;}
		
		[TagDetails(Tag = 1470, Type = TagType.Int, Offset = 8, Required = false)]
		public int? SecurityListType {get; set;}
		
		[TagDetails(Tag = 1471, Type = TagType.Int, Offset = 9, Required = false)]
		public int? SecurityListTypeSource {get; set;}
		
		[TagDetails(Tag = 320, Type = TagType.String, Offset = 10, Required = false)]
		public string? SecurityReqID {get; set;}
		
		[TagDetails(Tag = 322, Type = TagType.String, Offset = 11, Required = false)]
		public string? SecurityResponseID {get; set;}
		
		[TagDetails(Tag = 560, Type = TagType.Int, Offset = 12, Required = false)]
		public int? SecurityRequestResult {get; set;}
		
		[TagDetails(Tag = 393, Type = TagType.Int, Offset = 13, Required = false)]
		public int? TotNoRelatedSym {get; set;}
		
		[TagDetails(Tag = 715, Type = TagType.LocalDate, Offset = 14, Required = false)]
		public DateOnly? ClearingBusinessDate {get; set;}
		
		[TagDetails(Tag = 980, Type = TagType.String, Offset = 15, Required = false)]
		public string? SecurityUpdateAction {get; set;}
		
		[TagDetails(Tag = 292, Type = TagType.String, Offset = 16, Required = false)]
		public string? CorporateAction {get; set;}
		
		[TagDetails(Tag = 1301, Type = TagType.String, Offset = 17, Required = false)]
		public string? MarketID {get; set;}
		
		[TagDetails(Tag = 1300, Type = TagType.String, Offset = 18, Required = false)]
		public string? MarketSegmentID {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 19, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 893, Type = TagType.Boolean, Offset = 20, Required = false)]
		public bool? LastFragment {get; set;}
		
		[Component(Offset = 21, Required = false)]
		public SecLstUpdRelSymGrp? SecLstUpdRelSymGrp {get; set;}
		
		[Component(Offset = 22, Required = true)]
		public StandardTrailer? StandardTrailer {get; set;}
		
		
		IStandardHeader? IFixMessage.StandardHeader => StandardHeader;
		
		IStandardTrailer? IFixMessage.StandardTrailer => StandardTrailer;
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return (!config.CheckStandardHeader || (StandardHeader is not null && ((IFixValidator)StandardHeader).IsValid(in config))) && (!config.CheckStandardTrailer || (StandardTrailer is not null && ((IFixValidator)StandardTrailer).IsValid(in config)));
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (StandardHeader is not null) ((IFixEncoder)StandardHeader).Encode(writer);
			if (ApplicationSequenceControl is not null) ((IFixEncoder)ApplicationSequenceControl).Encode(writer);
			if (SecurityReportID is not null) writer.WriteWholeNumber(964, SecurityReportID.Value);
			if (SecurityListID is not null) writer.WriteString(1465, SecurityListID);
			if (SecurityListRefID is not null) writer.WriteString(1466, SecurityListRefID);
			if (SecurityListDesc is not null) writer.WriteString(1467, SecurityListDesc);
			if (EncodedSecurityListDescLen is not null) writer.WriteWholeNumber(1468, EncodedSecurityListDescLen.Value);
			if (EncodedSecurityListDesc is not null) writer.WriteBuffer(1469, EncodedSecurityListDesc);
			if (SecurityListType is not null) writer.WriteWholeNumber(1470, SecurityListType.Value);
			if (SecurityListTypeSource is not null) writer.WriteWholeNumber(1471, SecurityListTypeSource.Value);
			if (SecurityReqID is not null) writer.WriteString(320, SecurityReqID);
			if (SecurityResponseID is not null) writer.WriteString(322, SecurityResponseID);
			if (SecurityRequestResult is not null) writer.WriteWholeNumber(560, SecurityRequestResult.Value);
			if (TotNoRelatedSym is not null) writer.WriteWholeNumber(393, TotNoRelatedSym.Value);
			if (ClearingBusinessDate is not null) writer.WriteLocalDateOnly(715, ClearingBusinessDate.Value);
			if (SecurityUpdateAction is not null) writer.WriteString(980, SecurityUpdateAction);
			if (CorporateAction is not null) writer.WriteString(292, CorporateAction);
			if (MarketID is not null) writer.WriteString(1301, MarketID);
			if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (LastFragment is not null) writer.WriteBoolean(893, LastFragment.Value);
			if (SecLstUpdRelSymGrp is not null) ((IFixEncoder)SecLstUpdRelSymGrp).Encode(writer);
			if (StandardTrailer is not null) ((IFixEncoder)StandardTrailer).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("StandardHeader") is IMessageView viewStandardHeader)
			{
				StandardHeader = new();
				((IFixParser)StandardHeader).Parse(viewStandardHeader);
			}
			if (view.GetView("ApplicationSequenceControl") is IMessageView viewApplicationSequenceControl)
			{
				ApplicationSequenceControl = new();
				((IFixParser)ApplicationSequenceControl).Parse(viewApplicationSequenceControl);
			}
			SecurityReportID = view.GetInt32(964);
			SecurityListID = view.GetString(1465);
			SecurityListRefID = view.GetString(1466);
			SecurityListDesc = view.GetString(1467);
			EncodedSecurityListDescLen = view.GetInt32(1468);
			EncodedSecurityListDesc = view.GetByteArray(1469);
			SecurityListType = view.GetInt32(1470);
			SecurityListTypeSource = view.GetInt32(1471);
			SecurityReqID = view.GetString(320);
			SecurityResponseID = view.GetString(322);
			SecurityRequestResult = view.GetInt32(560);
			TotNoRelatedSym = view.GetInt32(393);
			ClearingBusinessDate = view.GetDateOnly(715);
			SecurityUpdateAction = view.GetString(980);
			CorporateAction = view.GetString(292);
			MarketID = view.GetString(1301);
			MarketSegmentID = view.GetString(1300);
			TransactTime = view.GetDateTime(60);
			LastFragment = view.GetBool(893);
			if (view.GetView("SecLstUpdRelSymGrp") is IMessageView viewSecLstUpdRelSymGrp)
			{
				SecLstUpdRelSymGrp = new();
				((IFixParser)SecLstUpdRelSymGrp).Parse(viewSecLstUpdRelSymGrp);
			}
			if (view.GetView("StandardTrailer") is IMessageView viewStandardTrailer)
			{
				StandardTrailer = new();
				((IFixParser)StandardTrailer).Parse(viewStandardTrailer);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "StandardHeader":
				{
					value = StandardHeader;
					break;
				}
				case "ApplicationSequenceControl":
				{
					value = ApplicationSequenceControl;
					break;
				}
				case "SecurityReportID":
				{
					value = SecurityReportID;
					break;
				}
				case "SecurityListID":
				{
					value = SecurityListID;
					break;
				}
				case "SecurityListRefID":
				{
					value = SecurityListRefID;
					break;
				}
				case "SecurityListDesc":
				{
					value = SecurityListDesc;
					break;
				}
				case "EncodedSecurityListDescLen":
				{
					value = EncodedSecurityListDescLen;
					break;
				}
				case "EncodedSecurityListDesc":
				{
					value = EncodedSecurityListDesc;
					break;
				}
				case "SecurityListType":
				{
					value = SecurityListType;
					break;
				}
				case "SecurityListTypeSource":
				{
					value = SecurityListTypeSource;
					break;
				}
				case "SecurityReqID":
				{
					value = SecurityReqID;
					break;
				}
				case "SecurityResponseID":
				{
					value = SecurityResponseID;
					break;
				}
				case "SecurityRequestResult":
				{
					value = SecurityRequestResult;
					break;
				}
				case "TotNoRelatedSym":
				{
					value = TotNoRelatedSym;
					break;
				}
				case "ClearingBusinessDate":
				{
					value = ClearingBusinessDate;
					break;
				}
				case "SecurityUpdateAction":
				{
					value = SecurityUpdateAction;
					break;
				}
				case "CorporateAction":
				{
					value = CorporateAction;
					break;
				}
				case "MarketID":
				{
					value = MarketID;
					break;
				}
				case "MarketSegmentID":
				{
					value = MarketSegmentID;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "LastFragment":
				{
					value = LastFragment;
					break;
				}
				case "SecLstUpdRelSymGrp":
				{
					value = SecLstUpdRelSymGrp;
					break;
				}
				case "StandardTrailer":
				{
					value = StandardTrailer;
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
			((IFixReset?)StandardHeader)?.Reset();
			((IFixReset?)ApplicationSequenceControl)?.Reset();
			SecurityReportID = null;
			SecurityListID = null;
			SecurityListRefID = null;
			SecurityListDesc = null;
			EncodedSecurityListDescLen = null;
			EncodedSecurityListDesc = null;
			SecurityListType = null;
			SecurityListTypeSource = null;
			SecurityReqID = null;
			SecurityResponseID = null;
			SecurityRequestResult = null;
			TotNoRelatedSym = null;
			ClearingBusinessDate = null;
			SecurityUpdateAction = null;
			CorporateAction = null;
			MarketID = null;
			MarketSegmentID = null;
			TransactTime = null;
			LastFragment = null;
			((IFixReset?)SecLstUpdRelSymGrp)?.Reset();
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
