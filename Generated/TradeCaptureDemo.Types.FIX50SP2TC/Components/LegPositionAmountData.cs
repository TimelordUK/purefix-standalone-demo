using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPositionAmountData : IFixComponent
	{
		public sealed partial class NoLegPosAmt : IFixGroup
		{
			[TagDetails(Tag = 1587, Type = TagType.Float, Offset = 0, Required = false)]
			public double? LegPosAmt {get; set;}
			
			[TagDetails(Tag = 1588, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegPosAmtType {get; set;}
			
			[TagDetails(Tag = 1589, Type = TagType.String, Offset = 2, Required = false)]
			public string? LegPosCurrency {get; set;}
			
			[TagDetails(Tag = 2938, Type = TagType.String, Offset = 3, Required = false)]
			public string? LegPosCurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 1590, Type = TagType.Int, Offset = 4, Required = false)]
			public int? LegPosAmtReason {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegPosAmt is not null) writer.WriteNumber(1587, LegPosAmt.Value);
				if (LegPosAmtType is not null) writer.WriteString(1588, LegPosAmtType);
				if (LegPosCurrency is not null) writer.WriteString(1589, LegPosCurrency);
				if (LegPosCurrencyCodeSource is not null) writer.WriteString(2938, LegPosCurrencyCodeSource);
				if (LegPosAmtReason is not null) writer.WriteWholeNumber(1590, LegPosAmtReason.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegPosAmt = view.GetDouble(1587);
				LegPosAmtType = view.GetString(1588);
				LegPosCurrency = view.GetString(1589);
				LegPosCurrencyCodeSource = view.GetString(2938);
				LegPosAmtReason = view.GetInt32(1590);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegPosAmt":
					{
						value = LegPosAmt;
						break;
					}
					case "LegPosAmtType":
					{
						value = LegPosAmtType;
						break;
					}
					case "LegPosCurrency":
					{
						value = LegPosCurrency;
						break;
					}
					case "LegPosCurrencyCodeSource":
					{
						value = LegPosCurrencyCodeSource;
						break;
					}
					case "LegPosAmtReason":
					{
						value = LegPosAmtReason;
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
				LegPosAmt = null;
				LegPosAmtType = null;
				LegPosCurrency = null;
				LegPosCurrencyCodeSource = null;
				LegPosAmtReason = null;
			}
		}
		[Group(NoOfTag = 1586, Offset = 0, Required = false)]
		public NoLegPosAmt[]? LegPosAmt {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPosAmt is not null && LegPosAmt.Length != 0)
			{
				writer.WriteWholeNumber(1586, LegPosAmt.Length);
				for (int i = 0; i < LegPosAmt.Length; i++)
				{
					((IFixEncoder)LegPosAmt[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegPosAmt") is IMessageView viewNoLegPosAmt)
			{
				var count = viewNoLegPosAmt.GroupCount();
				LegPosAmt = new NoLegPosAmt[count];
				for (int i = 0; i < count; i++)
				{
					LegPosAmt[i] = new();
					((IFixParser)LegPosAmt[i]).Parse(viewNoLegPosAmt.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegPosAmt":
				{
					value = LegPosAmt;
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
			LegPosAmt = null;
		}
	}
}
