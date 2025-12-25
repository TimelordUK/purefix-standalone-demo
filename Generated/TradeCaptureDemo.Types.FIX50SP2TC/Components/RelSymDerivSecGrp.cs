using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class RelSymDerivSecGrp : IFixComponent
	{
		public sealed partial class NoRelatedSym : IFixGroup
		{
			[Component(Offset = 0, Required = false)]
			public Instrument? Instrument {get; set;}
			
			[Component(Offset = 1, Required = false)]
			public SecondaryPriceLimits? SecondaryPriceLimits {get; set;}
			
			[TagDetails(Tag = 15, Type = TagType.String, Offset = 2, Required = false)]
			public string? Currency {get; set;}
			
			[TagDetails(Tag = 2897, Type = TagType.String, Offset = 3, Required = false)]
			public string? CurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 292, Type = TagType.String, Offset = 4, Required = false)]
			public string? CorporateAction {get; set;}
			
			[Component(Offset = 5, Required = false)]
			public InstrumentExtension? InstrumentExtension {get; set;}
			
			[Component(Offset = 6, Required = false)]
			public InstrmtLegGrp? InstrmtLegGrp {get; set;}
			
			[TagDetails(Tag = 1504, Type = TagType.UtcTimestamp, Offset = 7, Required = false)]
			public DateTime? RelSymTransactTime {get; set;}
			
			[TagDetails(Tag = 1606, Type = TagType.Int, Offset = 8, Required = false)]
			public int? NumOfSimpleInstruments {get; set;}
			
			[TagDetails(Tag = 58, Type = TagType.String, Offset = 9, Required = false)]
			public string? Text {get; set;}
			
			[TagDetails(Tag = 354, Type = TagType.Length, Offset = 10, Required = false)]
			public int? EncodedTextLen {get; set;}
			
			[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 11, Required = false)]
			public byte[]? EncodedText {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
				if (SecondaryPriceLimits is not null) ((IFixEncoder)SecondaryPriceLimits).Encode(writer);
				if (Currency is not null) writer.WriteString(15, Currency);
				if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
				if (CorporateAction is not null) writer.WriteString(292, CorporateAction);
				if (InstrumentExtension is not null) ((IFixEncoder)InstrumentExtension).Encode(writer);
				if (InstrmtLegGrp is not null) ((IFixEncoder)InstrmtLegGrp).Encode(writer);
				if (RelSymTransactTime is not null) writer.WriteUtcTimeStamp(1504, RelSymTransactTime.Value);
				if (NumOfSimpleInstruments is not null) writer.WriteWholeNumber(1606, NumOfSimpleInstruments.Value);
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
				if (view.GetView("SecondaryPriceLimits") is IMessageView viewSecondaryPriceLimits)
				{
					SecondaryPriceLimits = new();
					((IFixParser)SecondaryPriceLimits).Parse(viewSecondaryPriceLimits);
				}
				Currency = view.GetString(15);
				CurrencyCodeSource = view.GetString(2897);
				CorporateAction = view.GetString(292);
				if (view.GetView("InstrumentExtension") is IMessageView viewInstrumentExtension)
				{
					InstrumentExtension = new();
					((IFixParser)InstrumentExtension).Parse(viewInstrumentExtension);
				}
				if (view.GetView("InstrmtLegGrp") is IMessageView viewInstrmtLegGrp)
				{
					InstrmtLegGrp = new();
					((IFixParser)InstrmtLegGrp).Parse(viewInstrmtLegGrp);
				}
				RelSymTransactTime = view.GetDateTime(1504);
				NumOfSimpleInstruments = view.GetInt32(1606);
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
					case "SecondaryPriceLimits":
					{
						value = SecondaryPriceLimits;
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
					case "CorporateAction":
					{
						value = CorporateAction;
						break;
					}
					case "InstrumentExtension":
					{
						value = InstrumentExtension;
						break;
					}
					case "InstrmtLegGrp":
					{
						value = InstrmtLegGrp;
						break;
					}
					case "RelSymTransactTime":
					{
						value = RelSymTransactTime;
						break;
					}
					case "NumOfSimpleInstruments":
					{
						value = NumOfSimpleInstruments;
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
				((IFixReset?)SecondaryPriceLimits)?.Reset();
				Currency = null;
				CurrencyCodeSource = null;
				CorporateAction = null;
				((IFixReset?)InstrumentExtension)?.Reset();
				((IFixReset?)InstrmtLegGrp)?.Reset();
				RelSymTransactTime = null;
				NumOfSimpleInstruments = null;
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
