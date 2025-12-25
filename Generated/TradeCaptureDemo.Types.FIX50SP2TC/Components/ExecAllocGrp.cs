using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ExecAllocGrp : IFixComponent
	{
		public sealed partial class NoExecs : IFixGroup
		{
			[TagDetails(Tag = 32, Type = TagType.Float, Offset = 0, Required = false)]
			public double? LastQty {get; set;}
			
			[TagDetails(Tag = 17, Type = TagType.String, Offset = 1, Required = false)]
			public string? ExecID {get; set;}
			
			[TagDetails(Tag = 527, Type = TagType.String, Offset = 2, Required = false)]
			public string? SecondaryExecID {get; set;}
			
			[TagDetails(Tag = 31, Type = TagType.Float, Offset = 3, Required = false)]
			public double? LastPx {get; set;}
			
			[TagDetails(Tag = 669, Type = TagType.Float, Offset = 4, Required = false)]
			public double? LastParPx {get; set;}
			
			[TagDetails(Tag = 29, Type = TagType.String, Offset = 5, Required = false)]
			public string? LastCapacity {get; set;}
			
			[TagDetails(Tag = 1003, Type = TagType.String, Offset = 6, Required = false)]
			public string? TradeID {get; set;}
			
			[TagDetails(Tag = 1041, Type = TagType.String, Offset = 7, Required = false)]
			public string? FirmTradeID {get; set;}
			
			[TagDetails(Tag = 880, Type = TagType.String, Offset = 8, Required = false)]
			public string? TrdMatchID {get; set;}
			
			[TagDetails(Tag = 2749, Type = TagType.UtcTimestamp, Offset = 9, Required = false)]
			public DateTime? ExecutionTimestamp {get; set;}
			
			[TagDetails(Tag = 2524, Type = TagType.Int, Offset = 10, Required = false)]
			public int? TradeReportingIndicator {get; set;}
			
			[Component(Offset = 11, Required = false)]
			public TrdRegPublicationGrp? TrdRegPublicationGrp {get; set;}
			
			[Component(Offset = 12, Required = false)]
			public TradePriceConditionGrp? TradePriceConditionGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LastQty is not null) writer.WriteNumber(32, LastQty.Value);
				if (ExecID is not null) writer.WriteString(17, ExecID);
				if (SecondaryExecID is not null) writer.WriteString(527, SecondaryExecID);
				if (LastPx is not null) writer.WriteNumber(31, LastPx.Value);
				if (LastParPx is not null) writer.WriteNumber(669, LastParPx.Value);
				if (LastCapacity is not null) writer.WriteString(29, LastCapacity);
				if (TradeID is not null) writer.WriteString(1003, TradeID);
				if (FirmTradeID is not null) writer.WriteString(1041, FirmTradeID);
				if (TrdMatchID is not null) writer.WriteString(880, TrdMatchID);
				if (ExecutionTimestamp is not null) writer.WriteUtcTimeStamp(2749, ExecutionTimestamp.Value);
				if (TradeReportingIndicator is not null) writer.WriteWholeNumber(2524, TradeReportingIndicator.Value);
				if (TrdRegPublicationGrp is not null) ((IFixEncoder)TrdRegPublicationGrp).Encode(writer);
				if (TradePriceConditionGrp is not null) ((IFixEncoder)TradePriceConditionGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LastQty = view.GetDouble(32);
				ExecID = view.GetString(17);
				SecondaryExecID = view.GetString(527);
				LastPx = view.GetDouble(31);
				LastParPx = view.GetDouble(669);
				LastCapacity = view.GetString(29);
				TradeID = view.GetString(1003);
				FirmTradeID = view.GetString(1041);
				TrdMatchID = view.GetString(880);
				ExecutionTimestamp = view.GetDateTime(2749);
				TradeReportingIndicator = view.GetInt32(2524);
				if (view.GetView("TrdRegPublicationGrp") is IMessageView viewTrdRegPublicationGrp)
				{
					TrdRegPublicationGrp = new();
					((IFixParser)TrdRegPublicationGrp).Parse(viewTrdRegPublicationGrp);
				}
				if (view.GetView("TradePriceConditionGrp") is IMessageView viewTradePriceConditionGrp)
				{
					TradePriceConditionGrp = new();
					((IFixParser)TradePriceConditionGrp).Parse(viewTradePriceConditionGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LastQty":
					{
						value = LastQty;
						break;
					}
					case "ExecID":
					{
						value = ExecID;
						break;
					}
					case "SecondaryExecID":
					{
						value = SecondaryExecID;
						break;
					}
					case "LastPx":
					{
						value = LastPx;
						break;
					}
					case "LastParPx":
					{
						value = LastParPx;
						break;
					}
					case "LastCapacity":
					{
						value = LastCapacity;
						break;
					}
					case "TradeID":
					{
						value = TradeID;
						break;
					}
					case "FirmTradeID":
					{
						value = FirmTradeID;
						break;
					}
					case "TrdMatchID":
					{
						value = TrdMatchID;
						break;
					}
					case "ExecutionTimestamp":
					{
						value = ExecutionTimestamp;
						break;
					}
					case "TradeReportingIndicator":
					{
						value = TradeReportingIndicator;
						break;
					}
					case "TrdRegPublicationGrp":
					{
						value = TrdRegPublicationGrp;
						break;
					}
					case "TradePriceConditionGrp":
					{
						value = TradePriceConditionGrp;
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
				LastQty = null;
				ExecID = null;
				SecondaryExecID = null;
				LastPx = null;
				LastParPx = null;
				LastCapacity = null;
				TradeID = null;
				FirmTradeID = null;
				TrdMatchID = null;
				ExecutionTimestamp = null;
				TradeReportingIndicator = null;
				((IFixReset?)TrdRegPublicationGrp)?.Reset();
				((IFixReset?)TradePriceConditionGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 124, Offset = 0, Required = false)]
		public NoExecs[]? Execs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Execs is not null && Execs.Length != 0)
			{
				writer.WriteWholeNumber(124, Execs.Length);
				for (int i = 0; i < Execs.Length; i++)
				{
					((IFixEncoder)Execs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoExecs") is IMessageView viewNoExecs)
			{
				var count = viewNoExecs.GroupCount();
				Execs = new NoExecs[count];
				for (int i = 0; i < count; i++)
				{
					Execs[i] = new();
					((IFixParser)Execs[i]).Parse(viewNoExecs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoExecs":
				{
					value = Execs;
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
			Execs = null;
		}
	}
}
