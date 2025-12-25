using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("CO", FixVersion.FIX50SP2)]
	public sealed partial class SecurityMassStatus : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public ApplicationSequenceControl? ApplicationSequenceControl {get; set;}
		
		[TagDetails(Tag = 324, Type = TagType.String, Offset = 2, Required = false)]
		public string? SecurityStatusReqID {get; set;}
		
		[TagDetails(Tag = 1465, Type = TagType.String, Offset = 3, Required = false)]
		public string? SecurityListID {get; set;}
		
		[TagDetails(Tag = 1301, Type = TagType.String, Offset = 4, Required = false)]
		public string? MarketID {get; set;}
		
		[TagDetails(Tag = 1300, Type = TagType.String, Offset = 5, Required = false)]
		public string? MarketSegmentID {get; set;}
		
		[TagDetails(Tag = 75, Type = TagType.LocalDate, Offset = 6, Required = false)]
		public DateOnly? TradeDate {get; set;}
		
		[TagDetails(Tag = 336, Type = TagType.String, Offset = 7, Required = false)]
		public string? TradingSessionID {get; set;}
		
		[TagDetails(Tag = 625, Type = TagType.String, Offset = 8, Required = false)]
		public string? TradingSessionSubID {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public InstrumentScope? InstrumentScope {get; set;}
		
		[TagDetails(Tag = 325, Type = TagType.Boolean, Offset = 10, Required = false)]
		public bool? UnsolicitedIndicator {get; set;}
		
		[TagDetails(Tag = 1679, Type = TagType.Int, Offset = 11, Required = false)]
		public int? SecurityMassTradingStatus {get; set;}
		
		[TagDetails(Tag = 2447, Type = TagType.Boolean, Offset = 12, Required = false)]
		public bool? FastMarketIndicator {get; set;}
		
		[TagDetails(Tag = 1680, Type = TagType.Int, Offset = 13, Required = false)]
		public int? SecurityMassTradingEvent {get; set;}
		
		[TagDetails(Tag = 1681, Type = TagType.Int, Offset = 14, Required = false)]
		public int? MassHaltReason {get; set;}
		
		[TagDetails(Tag = 1021, Type = TagType.Int, Offset = 15, Required = false)]
		public int? MDBookType {get; set;}
		
		[TagDetails(Tag = 264, Type = TagType.Int, Offset = 16, Required = false)]
		public int? MarketDepth {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 17, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 334, Type = TagType.Int, Offset = 18, Required = false)]
		public int? Adjustment {get; set;}
		
		[Component(Offset = 19, Required = false)]
		public SecMassStatGrp? SecMassStatGrp {get; set;}
		
		[Component(Offset = 20, Required = true)]
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
			if (SecurityStatusReqID is not null) writer.WriteString(324, SecurityStatusReqID);
			if (SecurityListID is not null) writer.WriteString(1465, SecurityListID);
			if (MarketID is not null) writer.WriteString(1301, MarketID);
			if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
			if (TradeDate is not null) writer.WriteLocalDateOnly(75, TradeDate.Value);
			if (TradingSessionID is not null) writer.WriteString(336, TradingSessionID);
			if (TradingSessionSubID is not null) writer.WriteString(625, TradingSessionSubID);
			if (InstrumentScope is not null) ((IFixEncoder)InstrumentScope).Encode(writer);
			if (UnsolicitedIndicator is not null) writer.WriteBoolean(325, UnsolicitedIndicator.Value);
			if (SecurityMassTradingStatus is not null) writer.WriteWholeNumber(1679, SecurityMassTradingStatus.Value);
			if (FastMarketIndicator is not null) writer.WriteBoolean(2447, FastMarketIndicator.Value);
			if (SecurityMassTradingEvent is not null) writer.WriteWholeNumber(1680, SecurityMassTradingEvent.Value);
			if (MassHaltReason is not null) writer.WriteWholeNumber(1681, MassHaltReason.Value);
			if (MDBookType is not null) writer.WriteWholeNumber(1021, MDBookType.Value);
			if (MarketDepth is not null) writer.WriteWholeNumber(264, MarketDepth.Value);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (Adjustment is not null) writer.WriteWholeNumber(334, Adjustment.Value);
			if (SecMassStatGrp is not null) ((IFixEncoder)SecMassStatGrp).Encode(writer);
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
			SecurityStatusReqID = view.GetString(324);
			SecurityListID = view.GetString(1465);
			MarketID = view.GetString(1301);
			MarketSegmentID = view.GetString(1300);
			TradeDate = view.GetDateOnly(75);
			TradingSessionID = view.GetString(336);
			TradingSessionSubID = view.GetString(625);
			if (view.GetView("InstrumentScope") is IMessageView viewInstrumentScope)
			{
				InstrumentScope = new();
				((IFixParser)InstrumentScope).Parse(viewInstrumentScope);
			}
			UnsolicitedIndicator = view.GetBool(325);
			SecurityMassTradingStatus = view.GetInt32(1679);
			FastMarketIndicator = view.GetBool(2447);
			SecurityMassTradingEvent = view.GetInt32(1680);
			MassHaltReason = view.GetInt32(1681);
			MDBookType = view.GetInt32(1021);
			MarketDepth = view.GetInt32(264);
			TransactTime = view.GetDateTime(60);
			Adjustment = view.GetInt32(334);
			if (view.GetView("SecMassStatGrp") is IMessageView viewSecMassStatGrp)
			{
				SecMassStatGrp = new();
				((IFixParser)SecMassStatGrp).Parse(viewSecMassStatGrp);
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
				case "SecurityStatusReqID":
				{
					value = SecurityStatusReqID;
					break;
				}
				case "SecurityListID":
				{
					value = SecurityListID;
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
				case "TradeDate":
				{
					value = TradeDate;
					break;
				}
				case "TradingSessionID":
				{
					value = TradingSessionID;
					break;
				}
				case "TradingSessionSubID":
				{
					value = TradingSessionSubID;
					break;
				}
				case "InstrumentScope":
				{
					value = InstrumentScope;
					break;
				}
				case "UnsolicitedIndicator":
				{
					value = UnsolicitedIndicator;
					break;
				}
				case "SecurityMassTradingStatus":
				{
					value = SecurityMassTradingStatus;
					break;
				}
				case "FastMarketIndicator":
				{
					value = FastMarketIndicator;
					break;
				}
				case "SecurityMassTradingEvent":
				{
					value = SecurityMassTradingEvent;
					break;
				}
				case "MassHaltReason":
				{
					value = MassHaltReason;
					break;
				}
				case "MDBookType":
				{
					value = MDBookType;
					break;
				}
				case "MarketDepth":
				{
					value = MarketDepth;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "Adjustment":
				{
					value = Adjustment;
					break;
				}
				case "SecMassStatGrp":
				{
					value = SecMassStatGrp;
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
			SecurityStatusReqID = null;
			SecurityListID = null;
			MarketID = null;
			MarketSegmentID = null;
			TradeDate = null;
			TradingSessionID = null;
			TradingSessionSubID = null;
			((IFixReset?)InstrumentScope)?.Reset();
			UnsolicitedIndicator = null;
			SecurityMassTradingStatus = null;
			FastMarketIndicator = null;
			SecurityMassTradingEvent = null;
			MassHaltReason = null;
			MDBookType = null;
			MarketDepth = null;
			TransactTime = null;
			Adjustment = null;
			((IFixReset?)SecMassStatGrp)?.Reset();
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
