using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class InstrmtMDReqGrp : IFixComponent
	{
		public sealed partial class NoRelatedSym : IFixGroup
		{
			[Component(Offset = 0, Required = true)]
			public Instrument? Instrument {get; set;}
			
			[Component(Offset = 1, Required = false)]
			public InstrumentExtension? InstrumentExtension {get; set;}
			
			[Component(Offset = 2, Required = false)]
			public FinancingDetails? FinancingDetails {get; set;}
			
			[Component(Offset = 3, Required = false)]
			public UndInstrmtGrp? UndInstrmtGrp {get; set;}
			
			[Component(Offset = 4, Required = false)]
			public InstrmtLegGrp? InstrmtLegGrp {get; set;}
			
			[Component(Offset = 5, Required = false)]
			public RelatedInstrumentGrp? RelatedInstrumentGrp {get; set;}
			
			[Component(Offset = 6, Required = false)]
			public SpreadOrBenchmarkCurveData? SpreadOrBenchmarkCurveData {get; set;}
			
			[TagDetails(Tag = 15, Type = TagType.String, Offset = 7, Required = false)]
			public string? Currency {get; set;}
			
			[TagDetails(Tag = 2897, Type = TagType.String, Offset = 8, Required = false)]
			public string? CurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 537, Type = TagType.Int, Offset = 9, Required = false)]
			public int? QuoteType {get; set;}
			
			[TagDetails(Tag = 63, Type = TagType.String, Offset = 10, Required = false)]
			public string? SettlType {get; set;}
			
			[TagDetails(Tag = 64, Type = TagType.LocalDate, Offset = 11, Required = false)]
			public DateOnly? SettlDate {get; set;}
			
			[TagDetails(Tag = 271, Type = TagType.Float, Offset = 12, Required = false)]
			public double? MDEntrySize {get; set;}
			
			[TagDetails(Tag = 1500, Type = TagType.String, Offset = 13, Required = false)]
			public string? MDStreamID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
				if (InstrumentExtension is not null) ((IFixEncoder)InstrumentExtension).Encode(writer);
				if (FinancingDetails is not null) ((IFixEncoder)FinancingDetails).Encode(writer);
				if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
				if (InstrmtLegGrp is not null) ((IFixEncoder)InstrmtLegGrp).Encode(writer);
				if (RelatedInstrumentGrp is not null) ((IFixEncoder)RelatedInstrumentGrp).Encode(writer);
				if (SpreadOrBenchmarkCurveData is not null) ((IFixEncoder)SpreadOrBenchmarkCurveData).Encode(writer);
				if (Currency is not null) writer.WriteString(15, Currency);
				if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
				if (QuoteType is not null) writer.WriteWholeNumber(537, QuoteType.Value);
				if (SettlType is not null) writer.WriteString(63, SettlType);
				if (SettlDate is not null) writer.WriteLocalDateOnly(64, SettlDate.Value);
				if (MDEntrySize is not null) writer.WriteNumber(271, MDEntrySize.Value);
				if (MDStreamID is not null) writer.WriteString(1500, MDStreamID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				if (view.GetView("Instrument") is IMessageView viewInstrument)
				{
					Instrument = new();
					((IFixParser)Instrument).Parse(viewInstrument);
				}
				if (view.GetView("InstrumentExtension") is IMessageView viewInstrumentExtension)
				{
					InstrumentExtension = new();
					((IFixParser)InstrumentExtension).Parse(viewInstrumentExtension);
				}
				if (view.GetView("FinancingDetails") is IMessageView viewFinancingDetails)
				{
					FinancingDetails = new();
					((IFixParser)FinancingDetails).Parse(viewFinancingDetails);
				}
				if (view.GetView("UndInstrmtGrp") is IMessageView viewUndInstrmtGrp)
				{
					UndInstrmtGrp = new();
					((IFixParser)UndInstrmtGrp).Parse(viewUndInstrmtGrp);
				}
				if (view.GetView("InstrmtLegGrp") is IMessageView viewInstrmtLegGrp)
				{
					InstrmtLegGrp = new();
					((IFixParser)InstrmtLegGrp).Parse(viewInstrmtLegGrp);
				}
				if (view.GetView("RelatedInstrumentGrp") is IMessageView viewRelatedInstrumentGrp)
				{
					RelatedInstrumentGrp = new();
					((IFixParser)RelatedInstrumentGrp).Parse(viewRelatedInstrumentGrp);
				}
				if (view.GetView("SpreadOrBenchmarkCurveData") is IMessageView viewSpreadOrBenchmarkCurveData)
				{
					SpreadOrBenchmarkCurveData = new();
					((IFixParser)SpreadOrBenchmarkCurveData).Parse(viewSpreadOrBenchmarkCurveData);
				}
				Currency = view.GetString(15);
				CurrencyCodeSource = view.GetString(2897);
				QuoteType = view.GetInt32(537);
				SettlType = view.GetString(63);
				SettlDate = view.GetDateOnly(64);
				MDEntrySize = view.GetDouble(271);
				MDStreamID = view.GetString(1500);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "Instrument":
					{
						value = Instrument;
						break;
					}
					case "InstrumentExtension":
					{
						value = InstrumentExtension;
						break;
					}
					case "FinancingDetails":
					{
						value = FinancingDetails;
						break;
					}
					case "UndInstrmtGrp":
					{
						value = UndInstrmtGrp;
						break;
					}
					case "InstrmtLegGrp":
					{
						value = InstrmtLegGrp;
						break;
					}
					case "RelatedInstrumentGrp":
					{
						value = RelatedInstrumentGrp;
						break;
					}
					case "SpreadOrBenchmarkCurveData":
					{
						value = SpreadOrBenchmarkCurveData;
						break;
					}
					case "Currency":
					{
						value = Currency;
						break;
					}
					case "CurrencyCodeSource":
					{
						value = CurrencyCodeSource;
						break;
					}
					case "QuoteType":
					{
						value = QuoteType;
						break;
					}
					case "SettlType":
					{
						value = SettlType;
						break;
					}
					case "SettlDate":
					{
						value = SettlDate;
						break;
					}
					case "MDEntrySize":
					{
						value = MDEntrySize;
						break;
					}
					case "MDStreamID":
					{
						value = MDStreamID;
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
				((IFixReset?)Instrument)?.Reset();
				((IFixReset?)InstrumentExtension)?.Reset();
				((IFixReset?)FinancingDetails)?.Reset();
				((IFixReset?)UndInstrmtGrp)?.Reset();
				((IFixReset?)InstrmtLegGrp)?.Reset();
				((IFixReset?)RelatedInstrumentGrp)?.Reset();
				((IFixReset?)SpreadOrBenchmarkCurveData)?.Reset();
				Currency = null;
				CurrencyCodeSource = null;
				QuoteType = null;
				SettlType = null;
				SettlDate = null;
				MDEntrySize = null;
				MDStreamID = null;
			}
		}
		[Group(NoOfTag = 146, Offset = 0, Required = false)]
		public NoRelatedSym[]? RelatedSym {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (RelatedSym is not null && RelatedSym.Length != 0)
			{
				writer.WriteWholeNumber(146, RelatedSym.Length);
				for (int i = 0; i < RelatedSym.Length; i++)
				{
					((IFixEncoder)RelatedSym[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoRelatedSym") is IMessageView viewNoRelatedSym)
			{
				var count = viewNoRelatedSym.GroupCount();
				RelatedSym = new NoRelatedSym[count];
				for (int i = 0; i < count; i++)
				{
					RelatedSym[i] = new();
					((IFixParser)RelatedSym[i]).Parse(viewNoRelatedSym.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoRelatedSym":
				{
					value = RelatedSym;
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
			RelatedSym = null;
		}
	}
}
