using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("AA", FixVersion.FIX50SP2)]
	public sealed partial class DerivativeSecurityList : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public ApplicationSequenceControl? ApplicationSequenceControl {get; set;}
		
		[TagDetails(Tag = 964, Type = TagType.Int, Offset = 2, Required = false)]
		public int? SecurityReportID {get; set;}
		
		[TagDetails(Tag = 320, Type = TagType.String, Offset = 3, Required = false)]
		public string? SecurityReqID {get; set;}
		
		[TagDetails(Tag = 322, Type = TagType.String, Offset = 4, Required = false)]
		public string? SecurityResponseID {get; set;}
		
		[TagDetails(Tag = 560, Type = TagType.Int, Offset = 5, Required = false)]
		public int? SecurityRequestResult {get; set;}
		
		[TagDetails(Tag = 1607, Type = TagType.Int, Offset = 6, Required = false)]
		public int? SecurityRejectReason {get; set;}
		
		[TagDetails(Tag = 715, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? ClearingBusinessDate {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public UnderlyingInstrument? UnderlyingInstrument {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public DerivativeSecurityDefinition? DerivativeSecurityDefinition {get; set;}
		
		[TagDetails(Tag = 779, Type = TagType.UtcTimestamp, Offset = 10, Required = false)]
		public DateTime? LastUpdateTime {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 11, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 393, Type = TagType.Int, Offset = 12, Required = false)]
		public int? TotNoRelatedSym {get; set;}
		
		[TagDetails(Tag = 893, Type = TagType.Boolean, Offset = 13, Required = false)]
		public bool? LastFragment {get; set;}
		
		[Component(Offset = 14, Required = false)]
		public RelSymDerivSecGrp? RelSymDerivSecGrp {get; set;}
		
		[Component(Offset = 15, Required = true)]
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
			if (SecurityReqID is not null) writer.WriteString(320, SecurityReqID);
			if (SecurityResponseID is not null) writer.WriteString(322, SecurityResponseID);
			if (SecurityRequestResult is not null) writer.WriteWholeNumber(560, SecurityRequestResult.Value);
			if (SecurityRejectReason is not null) writer.WriteWholeNumber(1607, SecurityRejectReason.Value);
			if (ClearingBusinessDate is not null) writer.WriteLocalDateOnly(715, ClearingBusinessDate.Value);
			if (UnderlyingInstrument is not null) ((IFixEncoder)UnderlyingInstrument).Encode(writer);
			if (DerivativeSecurityDefinition is not null) ((IFixEncoder)DerivativeSecurityDefinition).Encode(writer);
			if (LastUpdateTime is not null) writer.WriteUtcTimeStamp(779, LastUpdateTime.Value);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (TotNoRelatedSym is not null) writer.WriteWholeNumber(393, TotNoRelatedSym.Value);
			if (LastFragment is not null) writer.WriteBoolean(893, LastFragment.Value);
			if (RelSymDerivSecGrp is not null) ((IFixEncoder)RelSymDerivSecGrp).Encode(writer);
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
			SecurityReqID = view.GetString(320);
			SecurityResponseID = view.GetString(322);
			SecurityRequestResult = view.GetInt32(560);
			SecurityRejectReason = view.GetInt32(1607);
			ClearingBusinessDate = view.GetDateOnly(715);
			if (view.GetView("UnderlyingInstrument") is IMessageView viewUnderlyingInstrument)
			{
				UnderlyingInstrument = new();
				((IFixParser)UnderlyingInstrument).Parse(viewUnderlyingInstrument);
			}
			if (view.GetView("DerivativeSecurityDefinition") is IMessageView viewDerivativeSecurityDefinition)
			{
				DerivativeSecurityDefinition = new();
				((IFixParser)DerivativeSecurityDefinition).Parse(viewDerivativeSecurityDefinition);
			}
			LastUpdateTime = view.GetDateTime(779);
			TransactTime = view.GetDateTime(60);
			TotNoRelatedSym = view.GetInt32(393);
			LastFragment = view.GetBool(893);
			if (view.GetView("RelSymDerivSecGrp") is IMessageView viewRelSymDerivSecGrp)
			{
				RelSymDerivSecGrp = new();
				((IFixParser)RelSymDerivSecGrp).Parse(viewRelSymDerivSecGrp);
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
				case "SecurityRejectReason":
				{
					value = SecurityRejectReason;
					break;
				}
				case "ClearingBusinessDate":
				{
					value = ClearingBusinessDate;
					break;
				}
				case "UnderlyingInstrument":
				{
					value = UnderlyingInstrument;
					break;
				}
				case "DerivativeSecurityDefinition":
				{
					value = DerivativeSecurityDefinition;
					break;
				}
				case "LastUpdateTime":
				{
					value = LastUpdateTime;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "TotNoRelatedSym":
				{
					value = TotNoRelatedSym;
					break;
				}
				case "LastFragment":
				{
					value = LastFragment;
					break;
				}
				case "RelSymDerivSecGrp":
				{
					value = RelSymDerivSecGrp;
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
			SecurityReqID = null;
			SecurityResponseID = null;
			SecurityRequestResult = null;
			SecurityRejectReason = null;
			ClearingBusinessDate = null;
			((IFixReset?)UnderlyingInstrument)?.Reset();
			((IFixReset?)DerivativeSecurityDefinition)?.Reset();
			LastUpdateTime = null;
			TransactTime = null;
			TotNoRelatedSym = null;
			LastFragment = null;
			((IFixReset?)RelSymDerivSecGrp)?.Reset();
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
