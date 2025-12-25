using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("CQ", FixVersion.FIX50SP2)]
	public sealed partial class AccountSummaryReport : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public ApplicationSequenceControl? ApplicationSequenceControl {get; set;}
		
		[TagDetails(Tag = 1699, Type = TagType.String, Offset = 2, Required = true)]
		public string? AccountSummaryReportID {get; set;}
		
		[TagDetails(Tag = 715, Type = TagType.LocalDate, Offset = 3, Required = true)]
		public DateOnly? ClearingBusinessDate {get; set;}
		
		[TagDetails(Tag = 15, Type = TagType.String, Offset = 4, Required = false)]
		public string? Currency {get; set;}
		
		[TagDetails(Tag = 900, Type = TagType.Float, Offset = 5, Required = false)]
		public double? TotalNetValue {get; set;}
		
		[TagDetails(Tag = 899, Type = TagType.Float, Offset = 6, Required = false)]
		public double? MarginExcess {get; set;}
		
		[TagDetails(Tag = 716, Type = TagType.String, Offset = 7, Required = false)]
		public string? SettlSessID {get; set;}
		
		[TagDetails(Tag = 717, Type = TagType.String, Offset = 8, Required = false)]
		public string? SettlSessSubID {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 9, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[Component(Offset = 10, Required = false)]
		public SettlementAmountGrp? SettlementAmountGrp {get; set;}
		
		[Component(Offset = 11, Required = false)]
		public MarginAmount? MarginAmount {get; set;}
		
		[Component(Offset = 12, Required = true)]
		public Parties? Parties {get; set;}
		
		[Component(Offset = 13, Required = false)]
		public CollateralAmountGrp? CollateralAmountGrp {get; set;}
		
		[Component(Offset = 14, Required = false)]
		public PayCollectGrp? PayCollectGrp {get; set;}
		
		[Component(Offset = 15, Required = false)]
		public PositionAmountData? PositionAmountData {get; set;}
		
		[Component(Offset = 16, Required = true)]
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
			if (AccountSummaryReportID is not null) writer.WriteString(1699, AccountSummaryReportID);
			if (ClearingBusinessDate is not null) writer.WriteLocalDateOnly(715, ClearingBusinessDate.Value);
			if (Currency is not null) writer.WriteString(15, Currency);
			if (TotalNetValue is not null) writer.WriteNumber(900, TotalNetValue.Value);
			if (MarginExcess is not null) writer.WriteNumber(899, MarginExcess.Value);
			if (SettlSessID is not null) writer.WriteString(716, SettlSessID);
			if (SettlSessSubID is not null) writer.WriteString(717, SettlSessSubID);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (SettlementAmountGrp is not null) ((IFixEncoder)SettlementAmountGrp).Encode(writer);
			if (MarginAmount is not null) ((IFixEncoder)MarginAmount).Encode(writer);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (CollateralAmountGrp is not null) ((IFixEncoder)CollateralAmountGrp).Encode(writer);
			if (PayCollectGrp is not null) ((IFixEncoder)PayCollectGrp).Encode(writer);
			if (PositionAmountData is not null) ((IFixEncoder)PositionAmountData).Encode(writer);
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
			AccountSummaryReportID = view.GetString(1699);
			ClearingBusinessDate = view.GetDateOnly(715);
			Currency = view.GetString(15);
			TotalNetValue = view.GetDouble(900);
			MarginExcess = view.GetDouble(899);
			SettlSessID = view.GetString(716);
			SettlSessSubID = view.GetString(717);
			TransactTime = view.GetDateTime(60);
			if (view.GetView("SettlementAmountGrp") is IMessageView viewSettlementAmountGrp)
			{
				SettlementAmountGrp = new();
				((IFixParser)SettlementAmountGrp).Parse(viewSettlementAmountGrp);
			}
			if (view.GetView("MarginAmount") is IMessageView viewMarginAmount)
			{
				MarginAmount = new();
				((IFixParser)MarginAmount).Parse(viewMarginAmount);
			}
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			if (view.GetView("CollateralAmountGrp") is IMessageView viewCollateralAmountGrp)
			{
				CollateralAmountGrp = new();
				((IFixParser)CollateralAmountGrp).Parse(viewCollateralAmountGrp);
			}
			if (view.GetView("PayCollectGrp") is IMessageView viewPayCollectGrp)
			{
				PayCollectGrp = new();
				((IFixParser)PayCollectGrp).Parse(viewPayCollectGrp);
			}
			if (view.GetView("PositionAmountData") is IMessageView viewPositionAmountData)
			{
				PositionAmountData = new();
				((IFixParser)PositionAmountData).Parse(viewPositionAmountData);
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
				case "AccountSummaryReportID":
				{
					value = AccountSummaryReportID;
					break;
				}
				case "ClearingBusinessDate":
				{
					value = ClearingBusinessDate;
					break;
				}
				case "Currency":
				{
					value = Currency;
					break;
				}
				case "TotalNetValue":
				{
					value = TotalNetValue;
					break;
				}
				case "MarginExcess":
				{
					value = MarginExcess;
					break;
				}
				case "SettlSessID":
				{
					value = SettlSessID;
					break;
				}
				case "SettlSessSubID":
				{
					value = SettlSessSubID;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "SettlementAmountGrp":
				{
					value = SettlementAmountGrp;
					break;
				}
				case "MarginAmount":
				{
					value = MarginAmount;
					break;
				}
				case "Parties":
				{
					value = Parties;
					break;
				}
				case "CollateralAmountGrp":
				{
					value = CollateralAmountGrp;
					break;
				}
				case "PayCollectGrp":
				{
					value = PayCollectGrp;
					break;
				}
				case "PositionAmountData":
				{
					value = PositionAmountData;
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
			AccountSummaryReportID = null;
			ClearingBusinessDate = null;
			Currency = null;
			TotalNetValue = null;
			MarginExcess = null;
			SettlSessID = null;
			SettlSessSubID = null;
			TransactTime = null;
			((IFixReset?)SettlementAmountGrp)?.Reset();
			((IFixReset?)MarginAmount)?.Reset();
			((IFixReset?)Parties)?.Reset();
			((IFixReset?)CollateralAmountGrp)?.Reset();
			((IFixReset?)PayCollectGrp)?.Reset();
			((IFixReset?)PositionAmountData)?.Reset();
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
