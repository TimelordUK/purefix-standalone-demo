using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class TrdSessLstGrp : IFixComponent
	{
		public sealed partial class NoTradingSessions : IFixGroup
		{
			[TagDetails(Tag = 336, Type = TagType.String, Offset = 0, Required = true)]
			public string? TradingSessionID {get; set;}
			
			[TagDetails(Tag = 625, Type = TagType.String, Offset = 1, Required = false)]
			public string? TradingSessionSubID {get; set;}
			
			[TagDetails(Tag = 1327, Type = TagType.String, Offset = 2, Required = false)]
			public string? TradSesUpdateAction {get; set;}
			
			[TagDetails(Tag = 207, Type = TagType.String, Offset = 3, Required = false)]
			public string? SecurityExchange {get; set;}
			
			[TagDetails(Tag = 1301, Type = TagType.String, Offset = 4, Required = false)]
			public string? MarketID {get; set;}
			
			[TagDetails(Tag = 1300, Type = TagType.String, Offset = 5, Required = false)]
			public string? MarketSegmentID {get; set;}
			
			[TagDetails(Tag = 1326, Type = TagType.String, Offset = 6, Required = false)]
			public string? TradingSessionDesc {get; set;}
			
			[TagDetails(Tag = 338, Type = TagType.Int, Offset = 7, Required = false)]
			public int? TradSesMethod {get; set;}
			
			[TagDetails(Tag = 339, Type = TagType.Int, Offset = 8, Required = false)]
			public int? TradSesMode {get; set;}
			
			[TagDetails(Tag = 325, Type = TagType.Boolean, Offset = 9, Required = false)]
			public bool? UnsolicitedIndicator {get; set;}
			
			[TagDetails(Tag = 340, Type = TagType.Int, Offset = 10, Required = true)]
			public int? TradSesStatus {get; set;}
			
			[TagDetails(Tag = 567, Type = TagType.Int, Offset = 11, Required = false)]
			public int? TradSesStatusRejReason {get; set;}
			
			[TagDetails(Tag = 341, Type = TagType.UtcTimestamp, Offset = 12, Required = false)]
			public DateTime? TradSesStartTime {get; set;}
			
			[TagDetails(Tag = 342, Type = TagType.UtcTimestamp, Offset = 13, Required = false)]
			public DateTime? TradSesOpenTime {get; set;}
			
			[TagDetails(Tag = 343, Type = TagType.UtcTimestamp, Offset = 14, Required = false)]
			public DateTime? TradSesPreCloseTime {get; set;}
			
			[TagDetails(Tag = 344, Type = TagType.UtcTimestamp, Offset = 15, Required = false)]
			public DateTime? TradSesCloseTime {get; set;}
			
			[TagDetails(Tag = 345, Type = TagType.UtcTimestamp, Offset = 16, Required = false)]
			public DateTime? TradSesEndTime {get; set;}
			
			[TagDetails(Tag = 387, Type = TagType.Float, Offset = 17, Required = false)]
			public double? TotalVolumeTraded {get; set;}
			
			[Component(Offset = 18, Required = false)]
			public TradingSessionRules? TradingSessionRules {get; set;}
			
			[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 19, Required = false)]
			public DateTime? TransactTime {get; set;}
			
			[TagDetails(Tag = 58, Type = TagType.String, Offset = 20, Required = false)]
			public string? Text {get; set;}
			
			[TagDetails(Tag = 354, Type = TagType.Length, Offset = 21, Required = false)]
			public int? EncodedTextLen {get; set;}
			
			[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 22, Required = false)]
			public byte[]? EncodedText {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (TradingSessionID is not null) writer.WriteString(336, TradingSessionID);
				if (TradingSessionSubID is not null) writer.WriteString(625, TradingSessionSubID);
				if (TradSesUpdateAction is not null) writer.WriteString(1327, TradSesUpdateAction);
				if (SecurityExchange is not null) writer.WriteString(207, SecurityExchange);
				if (MarketID is not null) writer.WriteString(1301, MarketID);
				if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
				if (TradingSessionDesc is not null) writer.WriteString(1326, TradingSessionDesc);
				if (TradSesMethod is not null) writer.WriteWholeNumber(338, TradSesMethod.Value);
				if (TradSesMode is not null) writer.WriteWholeNumber(339, TradSesMode.Value);
				if (UnsolicitedIndicator is not null) writer.WriteBoolean(325, UnsolicitedIndicator.Value);
				if (TradSesStatus is not null) writer.WriteWholeNumber(340, TradSesStatus.Value);
				if (TradSesStatusRejReason is not null) writer.WriteWholeNumber(567, TradSesStatusRejReason.Value);
				if (TradSesStartTime is not null) writer.WriteUtcTimeStamp(341, TradSesStartTime.Value);
				if (TradSesOpenTime is not null) writer.WriteUtcTimeStamp(342, TradSesOpenTime.Value);
				if (TradSesPreCloseTime is not null) writer.WriteUtcTimeStamp(343, TradSesPreCloseTime.Value);
				if (TradSesCloseTime is not null) writer.WriteUtcTimeStamp(344, TradSesCloseTime.Value);
				if (TradSesEndTime is not null) writer.WriteUtcTimeStamp(345, TradSesEndTime.Value);
				if (TotalVolumeTraded is not null) writer.WriteNumber(387, TotalVolumeTraded.Value);
				if (TradingSessionRules is not null) ((IFixEncoder)TradingSessionRules).Encode(writer);
				if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
				if (Text is not null) writer.WriteString(58, Text);
				if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
				if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				TradingSessionID = view.GetString(336);
				TradingSessionSubID = view.GetString(625);
				TradSesUpdateAction = view.GetString(1327);
				SecurityExchange = view.GetString(207);
				MarketID = view.GetString(1301);
				MarketSegmentID = view.GetString(1300);
				TradingSessionDesc = view.GetString(1326);
				TradSesMethod = view.GetInt32(338);
				TradSesMode = view.GetInt32(339);
				UnsolicitedIndicator = view.GetBool(325);
				TradSesStatus = view.GetInt32(340);
				TradSesStatusRejReason = view.GetInt32(567);
				TradSesStartTime = view.GetDateTime(341);
				TradSesOpenTime = view.GetDateTime(342);
				TradSesPreCloseTime = view.GetDateTime(343);
				TradSesCloseTime = view.GetDateTime(344);
				TradSesEndTime = view.GetDateTime(345);
				TotalVolumeTraded = view.GetDouble(387);
				if (view.GetView("TradingSessionRules") is IMessageView viewTradingSessionRules)
				{
					TradingSessionRules = new();
					((IFixParser)TradingSessionRules).Parse(viewTradingSessionRules);
				}
				TransactTime = view.GetDateTime(60);
				Text = view.GetString(58);
				EncodedTextLen = view.GetInt32(354);
				EncodedText = view.GetByteArray(355);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
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
					case "TradSesUpdateAction":
					{
						value = TradSesUpdateAction;
						break;
					}
					case "SecurityExchange":
					{
						value = SecurityExchange;
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
					case "TradingSessionDesc":
					{
						value = TradingSessionDesc;
						break;
					}
					case "TradSesMethod":
					{
						value = TradSesMethod;
						break;
					}
					case "TradSesMode":
					{
						value = TradSesMode;
						break;
					}
					case "UnsolicitedIndicator":
					{
						value = UnsolicitedIndicator;
						break;
					}
					case "TradSesStatus":
					{
						value = TradSesStatus;
						break;
					}
					case "TradSesStatusRejReason":
					{
						value = TradSesStatusRejReason;
						break;
					}
					case "TradSesStartTime":
					{
						value = TradSesStartTime;
						break;
					}
					case "TradSesOpenTime":
					{
						value = TradSesOpenTime;
						break;
					}
					case "TradSesPreCloseTime":
					{
						value = TradSesPreCloseTime;
						break;
					}
					case "TradSesCloseTime":
					{
						value = TradSesCloseTime;
						break;
					}
					case "TradSesEndTime":
					{
						value = TradSesEndTime;
						break;
					}
					case "TotalVolumeTraded":
					{
						value = TotalVolumeTraded;
						break;
					}
					case "TradingSessionRules":
					{
						value = TradingSessionRules;
						break;
					}
					case "TransactTime":
					{
						value = TransactTime;
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
				TradingSessionID = null;
				TradingSessionSubID = null;
				TradSesUpdateAction = null;
				SecurityExchange = null;
				MarketID = null;
				MarketSegmentID = null;
				TradingSessionDesc = null;
				TradSesMethod = null;
				TradSesMode = null;
				UnsolicitedIndicator = null;
				TradSesStatus = null;
				TradSesStatusRejReason = null;
				TradSesStartTime = null;
				TradSesOpenTime = null;
				TradSesPreCloseTime = null;
				TradSesCloseTime = null;
				TradSesEndTime = null;
				TotalVolumeTraded = null;
				((IFixReset?)TradingSessionRules)?.Reset();
				TransactTime = null;
				Text = null;
				EncodedTextLen = null;
				EncodedText = null;
			}
		}
		[Group(NoOfTag = 386, Offset = 0, Required = false)]
		public NoTradingSessions[]? TradingSessions {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (TradingSessions is not null && TradingSessions.Length != 0)
			{
				writer.WriteWholeNumber(386, TradingSessions.Length);
				for (int i = 0; i < TradingSessions.Length; i++)
				{
					((IFixEncoder)TradingSessions[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoTradingSessions") is IMessageView viewNoTradingSessions)
			{
				var count = viewNoTradingSessions.GroupCount();
				TradingSessions = new NoTradingSessions[count];
				for (int i = 0; i < count; i++)
				{
					TradingSessions[i] = new();
					((IFixParser)TradingSessions[i]).Parse(viewNoTradingSessions.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoTradingSessions":
				{
					value = TradingSessions;
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
			TradingSessions = null;
		}
	}
}
