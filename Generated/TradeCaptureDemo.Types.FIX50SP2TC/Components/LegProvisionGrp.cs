using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegProvisionGrp : IFixComponent
	{
		public sealed partial class NoLegProvisions : IFixGroup
		{
			[TagDetails(Tag = 40449, Type = TagType.Int, Offset = 0, Required = false)]
			public int? LegProvisionType {get; set;}
			
			[TagDetails(Tag = 40450, Type = TagType.LocalDate, Offset = 1, Required = false)]
			public DateOnly? LegProvisionDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 40451, Type = TagType.Int, Offset = 2, Required = false)]
			public int? LegProvisionDateBusinessDayConvention {get; set;}
			
			[Component(Offset = 3, Required = false)]
			public LegProvisionDateBusinessCenterGrp? LegProvisionDateBusinessCenterGrp {get; set;}
			
			[TagDetails(Tag = 40453, Type = TagType.LocalDate, Offset = 4, Required = false)]
			public DateOnly? LegProvisionDateAdjusted {get; set;}
			
			[TagDetails(Tag = 40454, Type = TagType.Int, Offset = 5, Required = false)]
			public int? LegProvisionDateTenorPeriod {get; set;}
			
			[TagDetails(Tag = 40455, Type = TagType.String, Offset = 6, Required = false)]
			public string? LegProvisionDateTenorUnit {get; set;}
			
			[TagDetails(Tag = 42506, Type = TagType.Int, Offset = 7, Required = false)]
			public int? LegProvisionBreakFeeElection {get; set;}
			
			[TagDetails(Tag = 42507, Type = TagType.Float, Offset = 8, Required = false)]
			public double? LegProvisionBreakFeeRate {get; set;}
			
			[TagDetails(Tag = 40456, Type = TagType.Int, Offset = 9, Required = false)]
			public int? LegProvisionCalculationAgent {get; set;}
			
			[TagDetails(Tag = 40457, Type = TagType.Int, Offset = 10, Required = false)]
			public int? LegProvisionOptionSinglePartyBuyerSide {get; set;}
			
			[TagDetails(Tag = 40458, Type = TagType.Int, Offset = 11, Required = false)]
			public int? LegProvisionOptionSinglePartySellerSide {get; set;}
			
			[Component(Offset = 12, Required = false)]
			public LegProvisionCashSettlValueDates? LegProvisionCashSettlValueDates {get; set;}
			
			[Component(Offset = 13, Required = false)]
			public LegProvisionOptionExerciseDates? LegProvisionOptionExerciseDates {get; set;}
			
			[Component(Offset = 14, Required = false)]
			public LegProvisionOptionExpirationDate? LegProvisionOptionExpirationDate {get; set;}
			
			[Component(Offset = 15, Required = false)]
			public LegProvisionOptionRelevantUnderlyingDate? LegProvisionOptionRelevantUnderlyingDate {get; set;}
			
			[TagDetails(Tag = 40459, Type = TagType.Int, Offset = 16, Required = false)]
			public int? LegProvisionOptionExerciseStyle {get; set;}
			
			[TagDetails(Tag = 40460, Type = TagType.Float, Offset = 17, Required = false)]
			public double? LegProvisionOptionExerciseMultipleNotional {get; set;}
			
			[TagDetails(Tag = 40461, Type = TagType.Float, Offset = 18, Required = false)]
			public double? LegProvisionOptionExerciseMinimumNotional {get; set;}
			
			[TagDetails(Tag = 40462, Type = TagType.Float, Offset = 19, Required = false)]
			public double? LegProvisionOptionExerciseMaximumNotional {get; set;}
			
			[TagDetails(Tag = 40463, Type = TagType.Int, Offset = 20, Required = false)]
			public int? LegProvisionOptionMinimumNumber {get; set;}
			
			[TagDetails(Tag = 40464, Type = TagType.Int, Offset = 21, Required = false)]
			public int? LegProvisionOptionMaximumNumber {get; set;}
			
			[TagDetails(Tag = 40465, Type = TagType.Boolean, Offset = 22, Required = false)]
			public bool? LegProvisionOptionExerciseConfirmation {get; set;}
			
			[Component(Offset = 23, Required = false)]
			public LegProvisionCashSettlPaymentDates? LegProvisionCashSettlPaymentDates {get; set;}
			
			[TagDetails(Tag = 40466, Type = TagType.Int, Offset = 24, Required = false)]
			public int? LegProvisionCashSettlMethod {get; set;}
			
			[TagDetails(Tag = 40467, Type = TagType.String, Offset = 25, Required = false)]
			public string? LegProvisionCashSettlCurrency {get; set;}
			
			[TagDetails(Tag = 40468, Type = TagType.String, Offset = 26, Required = false)]
			public string? LegProvisionCashSettlCurrency2 {get; set;}
			
			[TagDetails(Tag = 40469, Type = TagType.Int, Offset = 27, Required = false)]
			public int? LegProvisionCashSettlQuoteType {get; set;}
			
			[Component(Offset = 28, Required = false)]
			public LegProvisionCashSettlQuoteSource? LegProvisionCashSettlQuoteSource {get; set;}
			
			[TagDetails(Tag = 40472, Type = TagType.String, Offset = 29, Required = false)]
			public string? LegProvisionText {get; set;}
			
			[TagDetails(Tag = 40980, Type = TagType.Length, Offset = 30, Required = false)]
			public int? EncodedLegProvisionTextLen {get; set;}
			
			[TagDetails(Tag = 40981, Type = TagType.RawData, Offset = 31, Required = false)]
			public byte[]? EncodedLegProvisionText {get; set;}
			
			[Component(Offset = 32, Required = false)]
			public LegProvisionParties? LegProvisionParties {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegProvisionType is not null) writer.WriteWholeNumber(40449, LegProvisionType.Value);
				if (LegProvisionDateUnadjusted is not null) writer.WriteLocalDateOnly(40450, LegProvisionDateUnadjusted.Value);
				if (LegProvisionDateBusinessDayConvention is not null) writer.WriteWholeNumber(40451, LegProvisionDateBusinessDayConvention.Value);
				if (LegProvisionDateBusinessCenterGrp is not null) ((IFixEncoder)LegProvisionDateBusinessCenterGrp).Encode(writer);
				if (LegProvisionDateAdjusted is not null) writer.WriteLocalDateOnly(40453, LegProvisionDateAdjusted.Value);
				if (LegProvisionDateTenorPeriod is not null) writer.WriteWholeNumber(40454, LegProvisionDateTenorPeriod.Value);
				if (LegProvisionDateTenorUnit is not null) writer.WriteString(40455, LegProvisionDateTenorUnit);
				if (LegProvisionBreakFeeElection is not null) writer.WriteWholeNumber(42506, LegProvisionBreakFeeElection.Value);
				if (LegProvisionBreakFeeRate is not null) writer.WriteNumber(42507, LegProvisionBreakFeeRate.Value);
				if (LegProvisionCalculationAgent is not null) writer.WriteWholeNumber(40456, LegProvisionCalculationAgent.Value);
				if (LegProvisionOptionSinglePartyBuyerSide is not null) writer.WriteWholeNumber(40457, LegProvisionOptionSinglePartyBuyerSide.Value);
				if (LegProvisionOptionSinglePartySellerSide is not null) writer.WriteWholeNumber(40458, LegProvisionOptionSinglePartySellerSide.Value);
				if (LegProvisionCashSettlValueDates is not null) ((IFixEncoder)LegProvisionCashSettlValueDates).Encode(writer);
				if (LegProvisionOptionExerciseDates is not null) ((IFixEncoder)LegProvisionOptionExerciseDates).Encode(writer);
				if (LegProvisionOptionExpirationDate is not null) ((IFixEncoder)LegProvisionOptionExpirationDate).Encode(writer);
				if (LegProvisionOptionRelevantUnderlyingDate is not null) ((IFixEncoder)LegProvisionOptionRelevantUnderlyingDate).Encode(writer);
				if (LegProvisionOptionExerciseStyle is not null) writer.WriteWholeNumber(40459, LegProvisionOptionExerciseStyle.Value);
				if (LegProvisionOptionExerciseMultipleNotional is not null) writer.WriteNumber(40460, LegProvisionOptionExerciseMultipleNotional.Value);
				if (LegProvisionOptionExerciseMinimumNotional is not null) writer.WriteNumber(40461, LegProvisionOptionExerciseMinimumNotional.Value);
				if (LegProvisionOptionExerciseMaximumNotional is not null) writer.WriteNumber(40462, LegProvisionOptionExerciseMaximumNotional.Value);
				if (LegProvisionOptionMinimumNumber is not null) writer.WriteWholeNumber(40463, LegProvisionOptionMinimumNumber.Value);
				if (LegProvisionOptionMaximumNumber is not null) writer.WriteWholeNumber(40464, LegProvisionOptionMaximumNumber.Value);
				if (LegProvisionOptionExerciseConfirmation is not null) writer.WriteBoolean(40465, LegProvisionOptionExerciseConfirmation.Value);
				if (LegProvisionCashSettlPaymentDates is not null) ((IFixEncoder)LegProvisionCashSettlPaymentDates).Encode(writer);
				if (LegProvisionCashSettlMethod is not null) writer.WriteWholeNumber(40466, LegProvisionCashSettlMethod.Value);
				if (LegProvisionCashSettlCurrency is not null) writer.WriteString(40467, LegProvisionCashSettlCurrency);
				if (LegProvisionCashSettlCurrency2 is not null) writer.WriteString(40468, LegProvisionCashSettlCurrency2);
				if (LegProvisionCashSettlQuoteType is not null) writer.WriteWholeNumber(40469, LegProvisionCashSettlQuoteType.Value);
				if (LegProvisionCashSettlQuoteSource is not null) ((IFixEncoder)LegProvisionCashSettlQuoteSource).Encode(writer);
				if (LegProvisionText is not null) writer.WriteString(40472, LegProvisionText);
				if (EncodedLegProvisionTextLen is not null) writer.WriteWholeNumber(40980, EncodedLegProvisionTextLen.Value);
				if (EncodedLegProvisionText is not null) writer.WriteBuffer(40981, EncodedLegProvisionText);
				if (LegProvisionParties is not null) ((IFixEncoder)LegProvisionParties).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegProvisionType = view.GetInt32(40449);
				LegProvisionDateUnadjusted = view.GetDateOnly(40450);
				LegProvisionDateBusinessDayConvention = view.GetInt32(40451);
				if (view.GetView("LegProvisionDateBusinessCenterGrp") is IMessageView viewLegProvisionDateBusinessCenterGrp)
				{
					LegProvisionDateBusinessCenterGrp = new();
					((IFixParser)LegProvisionDateBusinessCenterGrp).Parse(viewLegProvisionDateBusinessCenterGrp);
				}
				LegProvisionDateAdjusted = view.GetDateOnly(40453);
				LegProvisionDateTenorPeriod = view.GetInt32(40454);
				LegProvisionDateTenorUnit = view.GetString(40455);
				LegProvisionBreakFeeElection = view.GetInt32(42506);
				LegProvisionBreakFeeRate = view.GetDouble(42507);
				LegProvisionCalculationAgent = view.GetInt32(40456);
				LegProvisionOptionSinglePartyBuyerSide = view.GetInt32(40457);
				LegProvisionOptionSinglePartySellerSide = view.GetInt32(40458);
				if (view.GetView("LegProvisionCashSettlValueDates") is IMessageView viewLegProvisionCashSettlValueDates)
				{
					LegProvisionCashSettlValueDates = new();
					((IFixParser)LegProvisionCashSettlValueDates).Parse(viewLegProvisionCashSettlValueDates);
				}
				if (view.GetView("LegProvisionOptionExerciseDates") is IMessageView viewLegProvisionOptionExerciseDates)
				{
					LegProvisionOptionExerciseDates = new();
					((IFixParser)LegProvisionOptionExerciseDates).Parse(viewLegProvisionOptionExerciseDates);
				}
				if (view.GetView("LegProvisionOptionExpirationDate") is IMessageView viewLegProvisionOptionExpirationDate)
				{
					LegProvisionOptionExpirationDate = new();
					((IFixParser)LegProvisionOptionExpirationDate).Parse(viewLegProvisionOptionExpirationDate);
				}
				if (view.GetView("LegProvisionOptionRelevantUnderlyingDate") is IMessageView viewLegProvisionOptionRelevantUnderlyingDate)
				{
					LegProvisionOptionRelevantUnderlyingDate = new();
					((IFixParser)LegProvisionOptionRelevantUnderlyingDate).Parse(viewLegProvisionOptionRelevantUnderlyingDate);
				}
				LegProvisionOptionExerciseStyle = view.GetInt32(40459);
				LegProvisionOptionExerciseMultipleNotional = view.GetDouble(40460);
				LegProvisionOptionExerciseMinimumNotional = view.GetDouble(40461);
				LegProvisionOptionExerciseMaximumNotional = view.GetDouble(40462);
				LegProvisionOptionMinimumNumber = view.GetInt32(40463);
				LegProvisionOptionMaximumNumber = view.GetInt32(40464);
				LegProvisionOptionExerciseConfirmation = view.GetBool(40465);
				if (view.GetView("LegProvisionCashSettlPaymentDates") is IMessageView viewLegProvisionCashSettlPaymentDates)
				{
					LegProvisionCashSettlPaymentDates = new();
					((IFixParser)LegProvisionCashSettlPaymentDates).Parse(viewLegProvisionCashSettlPaymentDates);
				}
				LegProvisionCashSettlMethod = view.GetInt32(40466);
				LegProvisionCashSettlCurrency = view.GetString(40467);
				LegProvisionCashSettlCurrency2 = view.GetString(40468);
				LegProvisionCashSettlQuoteType = view.GetInt32(40469);
				if (view.GetView("LegProvisionCashSettlQuoteSource") is IMessageView viewLegProvisionCashSettlQuoteSource)
				{
					LegProvisionCashSettlQuoteSource = new();
					((IFixParser)LegProvisionCashSettlQuoteSource).Parse(viewLegProvisionCashSettlQuoteSource);
				}
				LegProvisionText = view.GetString(40472);
				EncodedLegProvisionTextLen = view.GetInt32(40980);
				EncodedLegProvisionText = view.GetByteArray(40981);
				if (view.GetView("LegProvisionParties") is IMessageView viewLegProvisionParties)
				{
					LegProvisionParties = new();
					((IFixParser)LegProvisionParties).Parse(viewLegProvisionParties);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegProvisionType":
					{
						value = LegProvisionType;
						break;
					}
					case "LegProvisionDateUnadjusted":
					{
						value = LegProvisionDateUnadjusted;
						break;
					}
					case "LegProvisionDateBusinessDayConvention":
					{
						value = LegProvisionDateBusinessDayConvention;
						break;
					}
					case "LegProvisionDateBusinessCenterGrp":
					{
						value = LegProvisionDateBusinessCenterGrp;
						break;
					}
					case "LegProvisionDateAdjusted":
					{
						value = LegProvisionDateAdjusted;
						break;
					}
					case "LegProvisionDateTenorPeriod":
					{
						value = LegProvisionDateTenorPeriod;
						break;
					}
					case "LegProvisionDateTenorUnit":
					{
						value = LegProvisionDateTenorUnit;
						break;
					}
					case "LegProvisionBreakFeeElection":
					{
						value = LegProvisionBreakFeeElection;
						break;
					}
					case "LegProvisionBreakFeeRate":
					{
						value = LegProvisionBreakFeeRate;
						break;
					}
					case "LegProvisionCalculationAgent":
					{
						value = LegProvisionCalculationAgent;
						break;
					}
					case "LegProvisionOptionSinglePartyBuyerSide":
					{
						value = LegProvisionOptionSinglePartyBuyerSide;
						break;
					}
					case "LegProvisionOptionSinglePartySellerSide":
					{
						value = LegProvisionOptionSinglePartySellerSide;
						break;
					}
					case "LegProvisionCashSettlValueDates":
					{
						value = LegProvisionCashSettlValueDates;
						break;
					}
					case "LegProvisionOptionExerciseDates":
					{
						value = LegProvisionOptionExerciseDates;
						break;
					}
					case "LegProvisionOptionExpirationDate":
					{
						value = LegProvisionOptionExpirationDate;
						break;
					}
					case "LegProvisionOptionRelevantUnderlyingDate":
					{
						value = LegProvisionOptionRelevantUnderlyingDate;
						break;
					}
					case "LegProvisionOptionExerciseStyle":
					{
						value = LegProvisionOptionExerciseStyle;
						break;
					}
					case "LegProvisionOptionExerciseMultipleNotional":
					{
						value = LegProvisionOptionExerciseMultipleNotional;
						break;
					}
					case "LegProvisionOptionExerciseMinimumNotional":
					{
						value = LegProvisionOptionExerciseMinimumNotional;
						break;
					}
					case "LegProvisionOptionExerciseMaximumNotional":
					{
						value = LegProvisionOptionExerciseMaximumNotional;
						break;
					}
					case "LegProvisionOptionMinimumNumber":
					{
						value = LegProvisionOptionMinimumNumber;
						break;
					}
					case "LegProvisionOptionMaximumNumber":
					{
						value = LegProvisionOptionMaximumNumber;
						break;
					}
					case "LegProvisionOptionExerciseConfirmation":
					{
						value = LegProvisionOptionExerciseConfirmation;
						break;
					}
					case "LegProvisionCashSettlPaymentDates":
					{
						value = LegProvisionCashSettlPaymentDates;
						break;
					}
					case "LegProvisionCashSettlMethod":
					{
						value = LegProvisionCashSettlMethod;
						break;
					}
					case "LegProvisionCashSettlCurrency":
					{
						value = LegProvisionCashSettlCurrency;
						break;
					}
					case "LegProvisionCashSettlCurrency2":
					{
						value = LegProvisionCashSettlCurrency2;
						break;
					}
					case "LegProvisionCashSettlQuoteType":
					{
						value = LegProvisionCashSettlQuoteType;
						break;
					}
					case "LegProvisionCashSettlQuoteSource":
					{
						value = LegProvisionCashSettlQuoteSource;
						break;
					}
					case "LegProvisionText":
					{
						value = LegProvisionText;
						break;
					}
					case "EncodedLegProvisionTextLen":
					{
						value = EncodedLegProvisionTextLen;
						break;
					}
					case "EncodedLegProvisionText":
					{
						value = EncodedLegProvisionText;
						break;
					}
					case "LegProvisionParties":
					{
						value = LegProvisionParties;
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
				LegProvisionType = null;
				LegProvisionDateUnadjusted = null;
				LegProvisionDateBusinessDayConvention = null;
				((IFixReset?)LegProvisionDateBusinessCenterGrp)?.Reset();
				LegProvisionDateAdjusted = null;
				LegProvisionDateTenorPeriod = null;
				LegProvisionDateTenorUnit = null;
				LegProvisionBreakFeeElection = null;
				LegProvisionBreakFeeRate = null;
				LegProvisionCalculationAgent = null;
				LegProvisionOptionSinglePartyBuyerSide = null;
				LegProvisionOptionSinglePartySellerSide = null;
				((IFixReset?)LegProvisionCashSettlValueDates)?.Reset();
				((IFixReset?)LegProvisionOptionExerciseDates)?.Reset();
				((IFixReset?)LegProvisionOptionExpirationDate)?.Reset();
				((IFixReset?)LegProvisionOptionRelevantUnderlyingDate)?.Reset();
				LegProvisionOptionExerciseStyle = null;
				LegProvisionOptionExerciseMultipleNotional = null;
				LegProvisionOptionExerciseMinimumNotional = null;
				LegProvisionOptionExerciseMaximumNotional = null;
				LegProvisionOptionMinimumNumber = null;
				LegProvisionOptionMaximumNumber = null;
				LegProvisionOptionExerciseConfirmation = null;
				((IFixReset?)LegProvisionCashSettlPaymentDates)?.Reset();
				LegProvisionCashSettlMethod = null;
				LegProvisionCashSettlCurrency = null;
				LegProvisionCashSettlCurrency2 = null;
				LegProvisionCashSettlQuoteType = null;
				((IFixReset?)LegProvisionCashSettlQuoteSource)?.Reset();
				LegProvisionText = null;
				EncodedLegProvisionTextLen = null;
				EncodedLegProvisionText = null;
				((IFixReset?)LegProvisionParties)?.Reset();
			}
		}
		[Group(NoOfTag = 40448, Offset = 0, Required = false)]
		public NoLegProvisions[]? LegProvisions {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegProvisions is not null && LegProvisions.Length != 0)
			{
				writer.WriteWholeNumber(40448, LegProvisions.Length);
				for (int i = 0; i < LegProvisions.Length; i++)
				{
					((IFixEncoder)LegProvisions[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegProvisions") is IMessageView viewNoLegProvisions)
			{
				var count = viewNoLegProvisions.GroupCount();
				LegProvisions = new NoLegProvisions[count];
				for (int i = 0; i < count; i++)
				{
					LegProvisions[i] = new();
					((IFixParser)LegProvisions[i]).Parse(viewNoLegProvisions.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegProvisions":
				{
					value = LegProvisions;
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
			LegProvisions = null;
		}
	}
}
