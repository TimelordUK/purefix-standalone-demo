using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LimitAmts : IFixComponent
	{
		public sealed partial class NoLimitAmts : IFixGroup
		{
			[TagDetails(Tag = 1631, Type = TagType.Int, Offset = 0, Required = false)]
			public int? LimitAmtType {get; set;}
			
			[TagDetails(Tag = 1632, Type = TagType.Float, Offset = 1, Required = false)]
			public double? LastLimitAmt {get; set;}
			
			[TagDetails(Tag = 1633, Type = TagType.Float, Offset = 2, Required = false)]
			public double? LimitAmtRemaining {get; set;}
			
			[TagDetails(Tag = 2394, Type = TagType.Float, Offset = 3, Required = false)]
			public double? LimitUtilizationAmt {get; set;}
			
			[TagDetails(Tag = 2395, Type = TagType.Float, Offset = 4, Required = false)]
			public double? LimitAmt {get; set;}
			
			[TagDetails(Tag = 1634, Type = TagType.String, Offset = 5, Required = false)]
			public string? LimitAmtCurrency {get; set;}
			
			[TagDetails(Tag = 2935, Type = TagType.String, Offset = 6, Required = false)]
			public string? LimitAmtCurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 2396, Type = TagType.Int, Offset = 7, Required = false)]
			public int? LimitRole {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LimitAmtType is not null) writer.WriteWholeNumber(1631, LimitAmtType.Value);
				if (LastLimitAmt is not null) writer.WriteNumber(1632, LastLimitAmt.Value);
				if (LimitAmtRemaining is not null) writer.WriteNumber(1633, LimitAmtRemaining.Value);
				if (LimitUtilizationAmt is not null) writer.WriteNumber(2394, LimitUtilizationAmt.Value);
				if (LimitAmt is not null) writer.WriteNumber(2395, LimitAmt.Value);
				if (LimitAmtCurrency is not null) writer.WriteString(1634, LimitAmtCurrency);
				if (LimitAmtCurrencyCodeSource is not null) writer.WriteString(2935, LimitAmtCurrencyCodeSource);
				if (LimitRole is not null) writer.WriteWholeNumber(2396, LimitRole.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LimitAmtType = view.GetInt32(1631);
				LastLimitAmt = view.GetDouble(1632);
				LimitAmtRemaining = view.GetDouble(1633);
				LimitUtilizationAmt = view.GetDouble(2394);
				LimitAmt = view.GetDouble(2395);
				LimitAmtCurrency = view.GetString(1634);
				LimitAmtCurrencyCodeSource = view.GetString(2935);
				LimitRole = view.GetInt32(2396);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LimitAmtType":
					{
						value = LimitAmtType;
						break;
					}
					case "LastLimitAmt":
					{
						value = LastLimitAmt;
						break;
					}
					case "LimitAmtRemaining":
					{
						value = LimitAmtRemaining;
						break;
					}
					case "LimitUtilizationAmt":
					{
						value = LimitUtilizationAmt;
						break;
					}
					case "LimitAmt":
					{
						value = LimitAmt;
						break;
					}
					case "LimitAmtCurrency":
					{
						value = LimitAmtCurrency;
						break;
					}
					case "LimitAmtCurrencyCodeSource":
					{
						value = LimitAmtCurrencyCodeSource;
						break;
					}
					case "LimitRole":
					{
						value = LimitRole;
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
				LimitAmtType = null;
				LastLimitAmt = null;
				LimitAmtRemaining = null;
				LimitUtilizationAmt = null;
				LimitAmt = null;
				LimitAmtCurrency = null;
				LimitAmtCurrencyCodeSource = null;
				LimitRole = null;
			}
		}
		[Group(NoOfTag = 1630, Offset = 0, Required = false)]
		public NoLimitAmts[]? LimitAmtsItems {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LimitAmtsItems is not null && LimitAmtsItems.Length != 0)
			{
				writer.WriteWholeNumber(1630, LimitAmtsItems.Length);
				for (int i = 0; i < LimitAmtsItems.Length; i++)
				{
					((IFixEncoder)LimitAmtsItems[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLimitAmts") is IMessageView viewNoLimitAmts)
			{
				var count = viewNoLimitAmts.GroupCount();
				LimitAmtsItems = new NoLimitAmts[count];
				for (int i = 0; i < count; i++)
				{
					LimitAmtsItems[i] = new();
					((IFixParser)LimitAmtsItems[i]).Parse(viewNoLimitAmts.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLimitAmts":
				{
					value = LimitAmtsItems;
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
			LimitAmtsItems = null;
		}
	}
}
