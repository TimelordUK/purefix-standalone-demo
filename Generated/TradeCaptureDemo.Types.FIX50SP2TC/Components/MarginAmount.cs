using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class MarginAmount : IFixComponent
	{
		public sealed partial class NoMarginAmt : IFixGroup
		{
			[TagDetails(Tag = 1645, Type = TagType.Float, Offset = 0, Required = false)]
			public double? MarginAmt {get; set;}
			
			[TagDetails(Tag = 1644, Type = TagType.Int, Offset = 1, Required = false)]
			public int? MarginAmtType {get; set;}
			
			[TagDetails(Tag = 1646, Type = TagType.String, Offset = 2, Required = false)]
			public string? MarginAmtCcy {get; set;}
			
			[TagDetails(Tag = 2088, Type = TagType.Float, Offset = 3, Required = false)]
			public double? MarginAmtFXRate {get; set;}
			
			[TagDetails(Tag = 2089, Type = TagType.String, Offset = 4, Required = false)]
			public string? MarginAmtFXRateCalc {get; set;}
			
			[TagDetails(Tag = 1714, Type = TagType.String, Offset = 5, Required = false)]
			public string? MarginAmountMarketSegmentID {get; set;}
			
			[TagDetails(Tag = 1715, Type = TagType.String, Offset = 6, Required = false)]
			public string? MarginAmountMarketID {get; set;}
			
			[TagDetails(Tag = 2851, Type = TagType.Int, Offset = 7, Required = false)]
			public int? MarginDirection {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (MarginAmt is not null) writer.WriteNumber(1645, MarginAmt.Value);
				if (MarginAmtType is not null) writer.WriteWholeNumber(1644, MarginAmtType.Value);
				if (MarginAmtCcy is not null) writer.WriteString(1646, MarginAmtCcy);
				if (MarginAmtFXRate is not null) writer.WriteNumber(2088, MarginAmtFXRate.Value);
				if (MarginAmtFXRateCalc is not null) writer.WriteString(2089, MarginAmtFXRateCalc);
				if (MarginAmountMarketSegmentID is not null) writer.WriteString(1714, MarginAmountMarketSegmentID);
				if (MarginAmountMarketID is not null) writer.WriteString(1715, MarginAmountMarketID);
				if (MarginDirection is not null) writer.WriteWholeNumber(2851, MarginDirection.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				MarginAmt = view.GetDouble(1645);
				MarginAmtType = view.GetInt32(1644);
				MarginAmtCcy = view.GetString(1646);
				MarginAmtFXRate = view.GetDouble(2088);
				MarginAmtFXRateCalc = view.GetString(2089);
				MarginAmountMarketSegmentID = view.GetString(1714);
				MarginAmountMarketID = view.GetString(1715);
				MarginDirection = view.GetInt32(2851);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "MarginAmt":
					{
						value = MarginAmt;
						break;
					}
					case "MarginAmtType":
					{
						value = MarginAmtType;
						break;
					}
					case "MarginAmtCcy":
					{
						value = MarginAmtCcy;
						break;
					}
					case "MarginAmtFXRate":
					{
						value = MarginAmtFXRate;
						break;
					}
					case "MarginAmtFXRateCalc":
					{
						value = MarginAmtFXRateCalc;
						break;
					}
					case "MarginAmountMarketSegmentID":
					{
						value = MarginAmountMarketSegmentID;
						break;
					}
					case "MarginAmountMarketID":
					{
						value = MarginAmountMarketID;
						break;
					}
					case "MarginDirection":
					{
						value = MarginDirection;
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
				MarginAmt = null;
				MarginAmtType = null;
				MarginAmtCcy = null;
				MarginAmtFXRate = null;
				MarginAmtFXRateCalc = null;
				MarginAmountMarketSegmentID = null;
				MarginAmountMarketID = null;
				MarginDirection = null;
			}
		}
		[Group(NoOfTag = 1643, Offset = 0, Required = false)]
		public NoMarginAmt[]? MarginAmt {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (MarginAmt is not null && MarginAmt.Length != 0)
			{
				writer.WriteWholeNumber(1643, MarginAmt.Length);
				for (int i = 0; i < MarginAmt.Length; i++)
				{
					((IFixEncoder)MarginAmt[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoMarginAmt") is IMessageView viewNoMarginAmt)
			{
				var count = viewNoMarginAmt.GroupCount();
				MarginAmt = new NoMarginAmt[count];
				for (int i = 0; i < count; i++)
				{
					MarginAmt[i] = new();
					((IFixParser)MarginAmt[i]).Parse(viewNoMarginAmt.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoMarginAmt":
				{
					value = MarginAmt;
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
			MarginAmt = null;
		}
	}
}
