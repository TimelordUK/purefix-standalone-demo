using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class QuotSetGrp : IFixComponent
	{
		public sealed partial class NoQuoteSets : IFixGroup
		{
			[TagDetails(Tag = 302, Type = TagType.String, Offset = 0, Required = true)]
			public string? QuoteSetID {get; set;}
			
			[Component(Offset = 1, Required = false)]
			public UnderlyingInstrument? UnderlyingInstrument {get; set;}
			
			[TagDetails(Tag = 367, Type = TagType.UtcTimestamp, Offset = 2, Required = false)]
			public DateTime? QuoteSetValidUntilTime {get; set;}
			
			[TagDetails(Tag = 304, Type = TagType.Int, Offset = 3, Required = true)]
			public int? TotNoQuoteEntries {get; set;}
			
			[TagDetails(Tag = 893, Type = TagType.Boolean, Offset = 4, Required = false)]
			public bool? LastFragment {get; set;}
			
			[Component(Offset = 5, Required = true)]
			public QuotEntryGrp? QuotEntryGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (QuoteSetID is not null) writer.WriteString(302, QuoteSetID);
				if (UnderlyingInstrument is not null) ((IFixEncoder)UnderlyingInstrument).Encode(writer);
				if (QuoteSetValidUntilTime is not null) writer.WriteUtcTimeStamp(367, QuoteSetValidUntilTime.Value);
				if (TotNoQuoteEntries is not null) writer.WriteWholeNumber(304, TotNoQuoteEntries.Value);
				if (LastFragment is not null) writer.WriteBoolean(893, LastFragment.Value);
				if (QuotEntryGrp is not null) ((IFixEncoder)QuotEntryGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				QuoteSetID = view.GetString(302);
				if (view.GetView("UnderlyingInstrument") is IMessageView viewUnderlyingInstrument)
				{
					UnderlyingInstrument = new();
					((IFixParser)UnderlyingInstrument).Parse(viewUnderlyingInstrument);
				}
				QuoteSetValidUntilTime = view.GetDateTime(367);
				TotNoQuoteEntries = view.GetInt32(304);
				LastFragment = view.GetBool(893);
				if (view.GetView("QuotEntryGrp") is IMessageView viewQuotEntryGrp)
				{
					QuotEntryGrp = new();
					((IFixParser)QuotEntryGrp).Parse(viewQuotEntryGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "QuoteSetID":
					{
						value = QuoteSetID;
						break;
					}
					case "UnderlyingInstrument":
					{
						value = UnderlyingInstrument;
						break;
					}
					case "QuoteSetValidUntilTime":
					{
						value = QuoteSetValidUntilTime;
						break;
					}
					case "TotNoQuoteEntries":
					{
						value = TotNoQuoteEntries;
						break;
					}
					case "LastFragment":
					{
						value = LastFragment;
						break;
					}
					case "QuotEntryGrp":
					{
						value = QuotEntryGrp;
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
				QuoteSetID = null;
				((IFixReset?)UnderlyingInstrument)?.Reset();
				QuoteSetValidUntilTime = null;
				TotNoQuoteEntries = null;
				LastFragment = null;
				((IFixReset?)QuotEntryGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 296, Offset = 0, Required = false)]
		public NoQuoteSets[]? QuoteSets {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (QuoteSets is not null && QuoteSets.Length != 0)
			{
				writer.WriteWholeNumber(296, QuoteSets.Length);
				for (int i = 0; i < QuoteSets.Length; i++)
				{
					((IFixEncoder)QuoteSets[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoQuoteSets") is IMessageView viewNoQuoteSets)
			{
				var count = viewNoQuoteSets.GroupCount();
				QuoteSets = new NoQuoteSets[count];
				for (int i = 0; i < count; i++)
				{
					QuoteSets[i] = new();
					((IFixParser)QuoteSets[i]).Parse(viewNoQuoteSets.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoQuoteSets":
				{
					value = QuoteSets;
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
			QuoteSets = null;
		}
	}
}
