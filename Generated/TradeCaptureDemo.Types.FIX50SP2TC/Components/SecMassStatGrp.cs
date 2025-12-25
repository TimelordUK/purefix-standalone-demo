using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class SecMassStatGrp : IFixComponent
	{
		public sealed partial class NoRelatedSym : IFixGroup
		{
			[Component(Offset = 0, Required = false)]
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
			
			[TagDetails(Tag = 326, Type = TagType.Int, Offset = 6, Required = false)]
			public int? SecurityTradingStatus {get; set;}
			
			[TagDetails(Tag = 1174, Type = TagType.Int, Offset = 7, Required = false)]
			public int? SecurityTradingEvent {get; set;}
			
			[TagDetails(Tag = 327, Type = TagType.Int, Offset = 8, Required = false)]
			public int? HaltReasonInt {get; set;}
			
			[TagDetails(Tag = 291, Type = TagType.String, Offset = 9, Required = false)]
			public string? FinancialStatus {get; set;}
			
			[TagDetails(Tag = 292, Type = TagType.String, Offset = 10, Required = false)]
			public string? CorporateAction {get; set;}
			
			[TagDetails(Tag = 58, Type = TagType.String, Offset = 11, Required = false)]
			public string? Text {get; set;}
			
			[TagDetails(Tag = 354, Type = TagType.Length, Offset = 12, Required = false)]
			public int? EncodedTextLen {get; set;}
			
			[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 13, Required = false)]
			public byte[]? EncodedText {get; set;}
			
			
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
				if (SecurityTradingStatus is not null) writer.WriteWholeNumber(326, SecurityTradingStatus.Value);
				if (SecurityTradingEvent is not null) writer.WriteWholeNumber(1174, SecurityTradingEvent.Value);
				if (HaltReasonInt is not null) writer.WriteWholeNumber(327, HaltReasonInt.Value);
				if (FinancialStatus is not null) writer.WriteString(291, FinancialStatus);
				if (CorporateAction is not null) writer.WriteString(292, CorporateAction);
				if (Text is not null) writer.WriteString(58, Text);
				if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
				if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
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
				SecurityTradingStatus = view.GetInt32(326);
				SecurityTradingEvent = view.GetInt32(1174);
				HaltReasonInt = view.GetInt32(327);
				FinancialStatus = view.GetString(291);
				CorporateAction = view.GetString(292);
				Text = view.GetString(58);
				EncodedTextLen = view.GetInt32(354);
				EncodedText = view.GetByteArray(355);
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
					case "SecurityTradingStatus":
					{
						value = SecurityTradingStatus;
						break;
					}
					case "SecurityTradingEvent":
					{
						value = SecurityTradingEvent;
						break;
					}
					case "HaltReasonInt":
					{
						value = HaltReasonInt;
						break;
					}
					case "FinancialStatus":
					{
						value = FinancialStatus;
						break;
					}
					case "CorporateAction":
					{
						value = CorporateAction;
						break;
					}
					case "Text":
					{
						value = Text;
						break;
					}
					case "EncodedTextLen":
					{
						value = EncodedTextLen;
						break;
					}
					case "EncodedText":
					{
						value = EncodedText;
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
				SecurityTradingStatus = null;
				SecurityTradingEvent = null;
				HaltReasonInt = null;
				FinancialStatus = null;
				CorporateAction = null;
				Text = null;
				EncodedTextLen = null;
				EncodedText = null;
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
