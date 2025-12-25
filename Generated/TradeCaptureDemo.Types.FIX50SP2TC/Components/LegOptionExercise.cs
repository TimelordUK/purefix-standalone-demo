using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegOptionExercise : IFixComponent
	{
		[TagDetails(Tag = 41481, Type = TagType.String, Offset = 0, Required = false)]
		public string? LegExerciseDesc {get; set;}
		
		[TagDetails(Tag = 41482, Type = TagType.Length, Offset = 1, Required = false)]
		public int? EncodedLegExerciseDescLen {get; set;}
		
		[TagDetails(Tag = 41483, Type = TagType.RawData, Offset = 2, Required = false)]
		public byte[]? EncodedLegExerciseDesc {get; set;}
		
		[TagDetails(Tag = 41484, Type = TagType.Boolean, Offset = 3, Required = false)]
		public bool? LegAutomaticExerciseIndicator {get; set;}
		
		[TagDetails(Tag = 41485, Type = TagType.Float, Offset = 4, Required = false)]
		public double? LegAutomaticExerciseThresholdRate {get; set;}
		
		[TagDetails(Tag = 41486, Type = TagType.Int, Offset = 5, Required = false)]
		public int? LegExerciseConfirmationMethod {get; set;}
		
		[TagDetails(Tag = 41487, Type = TagType.String, Offset = 6, Required = false)]
		public string? LegManualNoticeBusinessCenter {get; set;}
		
		[TagDetails(Tag = 41488, Type = TagType.Boolean, Offset = 7, Required = false)]
		public bool? LegFallbackExerciseIndicator {get; set;}
		
		[TagDetails(Tag = 41489, Type = TagType.Boolean, Offset = 8, Required = false)]
		public bool? LegLimitRightToConfirmIndicator {get; set;}
		
		[TagDetails(Tag = 41490, Type = TagType.Boolean, Offset = 9, Required = false)]
		public bool? LegExerciseSplitTicketIndicator {get; set;}
		
		[TagDetails(Tag = 42391, Type = TagType.Int, Offset = 10, Required = false)]
		public int? LegSettlMethodElectingPartySide {get; set;}
		
		[Component(Offset = 11, Required = false)]
		public LegSettlMethodElectionDate? LegSettlMethodElectionDate {get; set;}
		
		[Component(Offset = 12, Required = false)]
		public LegOptionExerciseDates? LegOptionExerciseDates {get; set;}
		
		[Component(Offset = 13, Required = false)]
		public LegOptionExerciseExpiration? LegOptionExerciseExpiration {get; set;}
		
		[Component(Offset = 14, Required = false)]
		public LegOptionExerciseMakeWholeProvision? LegOptionExerciseMakeWholeProvision {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegExerciseDesc is not null) writer.WriteString(41481, LegExerciseDesc);
			if (EncodedLegExerciseDescLen is not null) writer.WriteWholeNumber(41482, EncodedLegExerciseDescLen.Value);
			if (EncodedLegExerciseDesc is not null) writer.WriteBuffer(41483, EncodedLegExerciseDesc);
			if (LegAutomaticExerciseIndicator is not null) writer.WriteBoolean(41484, LegAutomaticExerciseIndicator.Value);
			if (LegAutomaticExerciseThresholdRate is not null) writer.WriteNumber(41485, LegAutomaticExerciseThresholdRate.Value);
			if (LegExerciseConfirmationMethod is not null) writer.WriteWholeNumber(41486, LegExerciseConfirmationMethod.Value);
			if (LegManualNoticeBusinessCenter is not null) writer.WriteString(41487, LegManualNoticeBusinessCenter);
			if (LegFallbackExerciseIndicator is not null) writer.WriteBoolean(41488, LegFallbackExerciseIndicator.Value);
			if (LegLimitRightToConfirmIndicator is not null) writer.WriteBoolean(41489, LegLimitRightToConfirmIndicator.Value);
			if (LegExerciseSplitTicketIndicator is not null) writer.WriteBoolean(41490, LegExerciseSplitTicketIndicator.Value);
			if (LegSettlMethodElectingPartySide is not null) writer.WriteWholeNumber(42391, LegSettlMethodElectingPartySide.Value);
			if (LegSettlMethodElectionDate is not null) ((IFixEncoder)LegSettlMethodElectionDate).Encode(writer);
			if (LegOptionExerciseDates is not null) ((IFixEncoder)LegOptionExerciseDates).Encode(writer);
			if (LegOptionExerciseExpiration is not null) ((IFixEncoder)LegOptionExerciseExpiration).Encode(writer);
			if (LegOptionExerciseMakeWholeProvision is not null) ((IFixEncoder)LegOptionExerciseMakeWholeProvision).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegExerciseDesc = view.GetString(41481);
			EncodedLegExerciseDescLen = view.GetInt32(41482);
			EncodedLegExerciseDesc = view.GetByteArray(41483);
			LegAutomaticExerciseIndicator = view.GetBool(41484);
			LegAutomaticExerciseThresholdRate = view.GetDouble(41485);
			LegExerciseConfirmationMethod = view.GetInt32(41486);
			LegManualNoticeBusinessCenter = view.GetString(41487);
			LegFallbackExerciseIndicator = view.GetBool(41488);
			LegLimitRightToConfirmIndicator = view.GetBool(41489);
			LegExerciseSplitTicketIndicator = view.GetBool(41490);
			LegSettlMethodElectingPartySide = view.GetInt32(42391);
			if (view.GetView("LegSettlMethodElectionDate") is IMessageView viewLegSettlMethodElectionDate)
			{
				LegSettlMethodElectionDate = new();
				((IFixParser)LegSettlMethodElectionDate).Parse(viewLegSettlMethodElectionDate);
			}
			if (view.GetView("LegOptionExerciseDates") is IMessageView viewLegOptionExerciseDates)
			{
				LegOptionExerciseDates = new();
				((IFixParser)LegOptionExerciseDates).Parse(viewLegOptionExerciseDates);
			}
			if (view.GetView("LegOptionExerciseExpiration") is IMessageView viewLegOptionExerciseExpiration)
			{
				LegOptionExerciseExpiration = new();
				((IFixParser)LegOptionExerciseExpiration).Parse(viewLegOptionExerciseExpiration);
			}
			if (view.GetView("LegOptionExerciseMakeWholeProvision") is IMessageView viewLegOptionExerciseMakeWholeProvision)
			{
				LegOptionExerciseMakeWholeProvision = new();
				((IFixParser)LegOptionExerciseMakeWholeProvision).Parse(viewLegOptionExerciseMakeWholeProvision);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegExerciseDesc":
				{
					value = LegExerciseDesc;
					break;
				}
				case "EncodedLegExerciseDescLen":
				{
					value = EncodedLegExerciseDescLen;
					break;
				}
				case "EncodedLegExerciseDesc":
				{
					value = EncodedLegExerciseDesc;
					break;
				}
				case "LegAutomaticExerciseIndicator":
				{
					value = LegAutomaticExerciseIndicator;
					break;
				}
				case "LegAutomaticExerciseThresholdRate":
				{
					value = LegAutomaticExerciseThresholdRate;
					break;
				}
				case "LegExerciseConfirmationMethod":
				{
					value = LegExerciseConfirmationMethod;
					break;
				}
				case "LegManualNoticeBusinessCenter":
				{
					value = LegManualNoticeBusinessCenter;
					break;
				}
				case "LegFallbackExerciseIndicator":
				{
					value = LegFallbackExerciseIndicator;
					break;
				}
				case "LegLimitRightToConfirmIndicator":
				{
					value = LegLimitRightToConfirmIndicator;
					break;
				}
				case "LegExerciseSplitTicketIndicator":
				{
					value = LegExerciseSplitTicketIndicator;
					break;
				}
				case "LegSettlMethodElectingPartySide":
				{
					value = LegSettlMethodElectingPartySide;
					break;
				}
				case "LegSettlMethodElectionDate":
				{
					value = LegSettlMethodElectionDate;
					break;
				}
				case "LegOptionExerciseDates":
				{
					value = LegOptionExerciseDates;
					break;
				}
				case "LegOptionExerciseExpiration":
				{
					value = LegOptionExerciseExpiration;
					break;
				}
				case "LegOptionExerciseMakeWholeProvision":
				{
					value = LegOptionExerciseMakeWholeProvision;
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
			LegExerciseDesc = null;
			EncodedLegExerciseDescLen = null;
			EncodedLegExerciseDesc = null;
			LegAutomaticExerciseIndicator = null;
			LegAutomaticExerciseThresholdRate = null;
			LegExerciseConfirmationMethod = null;
			LegManualNoticeBusinessCenter = null;
			LegFallbackExerciseIndicator = null;
			LegLimitRightToConfirmIndicator = null;
			LegExerciseSplitTicketIndicator = null;
			LegSettlMethodElectingPartySide = null;
			((IFixReset?)LegSettlMethodElectionDate)?.Reset();
			((IFixReset?)LegOptionExerciseDates)?.Reset();
			((IFixReset?)LegOptionExerciseExpiration)?.Reset();
			((IFixReset?)LegOptionExerciseMakeWholeProvision)?.Reset();
		}
	}
}
