using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class OptionExercise : IFixComponent
	{
		[TagDetails(Tag = 41106, Type = TagType.String, Offset = 0, Required = false)]
		public string? ExerciseDesc {get; set;}
		
		[TagDetails(Tag = 41107, Type = TagType.Length, Offset = 1, Required = false)]
		public int? EncodedExerciseDescLen {get; set;}
		
		[TagDetails(Tag = 41108, Type = TagType.RawData, Offset = 2, Required = false)]
		public byte[]? EncodedExerciseDesc {get; set;}
		
		[TagDetails(Tag = 41109, Type = TagType.Boolean, Offset = 3, Required = false)]
		public bool? AutomaticExerciseIndicator {get; set;}
		
		[TagDetails(Tag = 41110, Type = TagType.Float, Offset = 4, Required = false)]
		public double? AutomaticExerciseThresholdRate {get; set;}
		
		[TagDetails(Tag = 41111, Type = TagType.Int, Offset = 5, Required = false)]
		public int? ExerciseConfirmationMethod {get; set;}
		
		[TagDetails(Tag = 41112, Type = TagType.String, Offset = 6, Required = false)]
		public string? ManualNoticeBusinessCenter {get; set;}
		
		[TagDetails(Tag = 41113, Type = TagType.Boolean, Offset = 7, Required = false)]
		public bool? FallbackExerciseIndicator {get; set;}
		
		[TagDetails(Tag = 41114, Type = TagType.Boolean, Offset = 8, Required = false)]
		public bool? LimitedRightToConfirmIndicator {get; set;}
		
		[TagDetails(Tag = 41115, Type = TagType.Boolean, Offset = 9, Required = false)]
		public bool? ExerciseSplitTicketIndicator {get; set;}
		
		[TagDetails(Tag = 42590, Type = TagType.Int, Offset = 10, Required = false)]
		public int? SettlMethodElectingPartySide {get; set;}
		
		[Component(Offset = 11, Required = false)]
		public SettlMethodElectionDate? SettlMethodElectionDate {get; set;}
		
		[Component(Offset = 12, Required = false)]
		public OptionExerciseDates? OptionExerciseDates {get; set;}
		
		[Component(Offset = 13, Required = false)]
		public OptionExerciseExpiration? OptionExerciseExpiration {get; set;}
		
		[Component(Offset = 14, Required = false)]
		public OptionExerciseMakeWholeProvision? OptionExerciseMakeWholeProvision {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ExerciseDesc is not null) writer.WriteString(41106, ExerciseDesc);
			if (EncodedExerciseDescLen is not null) writer.WriteWholeNumber(41107, EncodedExerciseDescLen.Value);
			if (EncodedExerciseDesc is not null) writer.WriteBuffer(41108, EncodedExerciseDesc);
			if (AutomaticExerciseIndicator is not null) writer.WriteBoolean(41109, AutomaticExerciseIndicator.Value);
			if (AutomaticExerciseThresholdRate is not null) writer.WriteNumber(41110, AutomaticExerciseThresholdRate.Value);
			if (ExerciseConfirmationMethod is not null) writer.WriteWholeNumber(41111, ExerciseConfirmationMethod.Value);
			if (ManualNoticeBusinessCenter is not null) writer.WriteString(41112, ManualNoticeBusinessCenter);
			if (FallbackExerciseIndicator is not null) writer.WriteBoolean(41113, FallbackExerciseIndicator.Value);
			if (LimitedRightToConfirmIndicator is not null) writer.WriteBoolean(41114, LimitedRightToConfirmIndicator.Value);
			if (ExerciseSplitTicketIndicator is not null) writer.WriteBoolean(41115, ExerciseSplitTicketIndicator.Value);
			if (SettlMethodElectingPartySide is not null) writer.WriteWholeNumber(42590, SettlMethodElectingPartySide.Value);
			if (SettlMethodElectionDate is not null) ((IFixEncoder)SettlMethodElectionDate).Encode(writer);
			if (OptionExerciseDates is not null) ((IFixEncoder)OptionExerciseDates).Encode(writer);
			if (OptionExerciseExpiration is not null) ((IFixEncoder)OptionExerciseExpiration).Encode(writer);
			if (OptionExerciseMakeWholeProvision is not null) ((IFixEncoder)OptionExerciseMakeWholeProvision).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			ExerciseDesc = view.GetString(41106);
			EncodedExerciseDescLen = view.GetInt32(41107);
			EncodedExerciseDesc = view.GetByteArray(41108);
			AutomaticExerciseIndicator = view.GetBool(41109);
			AutomaticExerciseThresholdRate = view.GetDouble(41110);
			ExerciseConfirmationMethod = view.GetInt32(41111);
			ManualNoticeBusinessCenter = view.GetString(41112);
			FallbackExerciseIndicator = view.GetBool(41113);
			LimitedRightToConfirmIndicator = view.GetBool(41114);
			ExerciseSplitTicketIndicator = view.GetBool(41115);
			SettlMethodElectingPartySide = view.GetInt32(42590);
			if (view.GetView("SettlMethodElectionDate") is IMessageView viewSettlMethodElectionDate)
			{
				SettlMethodElectionDate = new();
				((IFixParser)SettlMethodElectionDate).Parse(viewSettlMethodElectionDate);
			}
			if (view.GetView("OptionExerciseDates") is IMessageView viewOptionExerciseDates)
			{
				OptionExerciseDates = new();
				((IFixParser)OptionExerciseDates).Parse(viewOptionExerciseDates);
			}
			if (view.GetView("OptionExerciseExpiration") is IMessageView viewOptionExerciseExpiration)
			{
				OptionExerciseExpiration = new();
				((IFixParser)OptionExerciseExpiration).Parse(viewOptionExerciseExpiration);
			}
			if (view.GetView("OptionExerciseMakeWholeProvision") is IMessageView viewOptionExerciseMakeWholeProvision)
			{
				OptionExerciseMakeWholeProvision = new();
				((IFixParser)OptionExerciseMakeWholeProvision).Parse(viewOptionExerciseMakeWholeProvision);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "ExerciseDesc":
				{
					value = ExerciseDesc;
					break;
				}
				case "EncodedExerciseDescLen":
				{
					value = EncodedExerciseDescLen;
					break;
				}
				case "EncodedExerciseDesc":
				{
					value = EncodedExerciseDesc;
					break;
				}
				case "AutomaticExerciseIndicator":
				{
					value = AutomaticExerciseIndicator;
					break;
				}
				case "AutomaticExerciseThresholdRate":
				{
					value = AutomaticExerciseThresholdRate;
					break;
				}
				case "ExerciseConfirmationMethod":
				{
					value = ExerciseConfirmationMethod;
					break;
				}
				case "ManualNoticeBusinessCenter":
				{
					value = ManualNoticeBusinessCenter;
					break;
				}
				case "FallbackExerciseIndicator":
				{
					value = FallbackExerciseIndicator;
					break;
				}
				case "LimitedRightToConfirmIndicator":
				{
					value = LimitedRightToConfirmIndicator;
					break;
				}
				case "ExerciseSplitTicketIndicator":
				{
					value = ExerciseSplitTicketIndicator;
					break;
				}
				case "SettlMethodElectingPartySide":
				{
					value = SettlMethodElectingPartySide;
					break;
				}
				case "SettlMethodElectionDate":
				{
					value = SettlMethodElectionDate;
					break;
				}
				case "OptionExerciseDates":
				{
					value = OptionExerciseDates;
					break;
				}
				case "OptionExerciseExpiration":
				{
					value = OptionExerciseExpiration;
					break;
				}
				case "OptionExerciseMakeWholeProvision":
				{
					value = OptionExerciseMakeWholeProvision;
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
			ExerciseDesc = null;
			EncodedExerciseDescLen = null;
			EncodedExerciseDesc = null;
			AutomaticExerciseIndicator = null;
			AutomaticExerciseThresholdRate = null;
			ExerciseConfirmationMethod = null;
			ManualNoticeBusinessCenter = null;
			FallbackExerciseIndicator = null;
			LimitedRightToConfirmIndicator = null;
			ExerciseSplitTicketIndicator = null;
			SettlMethodElectingPartySide = null;
			((IFixReset?)SettlMethodElectionDate)?.Reset();
			((IFixReset?)OptionExerciseDates)?.Reset();
			((IFixReset?)OptionExerciseExpiration)?.Reset();
			((IFixReset?)OptionExerciseMakeWholeProvision)?.Reset();
		}
	}
}
