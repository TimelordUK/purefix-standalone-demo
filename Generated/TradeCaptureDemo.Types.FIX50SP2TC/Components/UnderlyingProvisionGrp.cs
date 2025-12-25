using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingProvisionGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingProvisions : IFixGroup
		{
			[TagDetails(Tag = 42150, Type = TagType.Int, Offset = 0, Required = false)]
			public int? UnderlyingProvisionType {get; set;}
			
			[TagDetails(Tag = 42151, Type = TagType.LocalDate, Offset = 1, Required = false)]
			public DateOnly? UnderlyingProvisionDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 42152, Type = TagType.Int, Offset = 2, Required = false)]
			public int? UnderlyingProvisionDateBusinessDayConvention {get; set;}
			
			[Component(Offset = 3, Required = false)]
			public UnderlyingProvisionDateBusinessCenterGrp? UnderlyingProvisionDateBusinessCenterGrp {get; set;}
			
			[TagDetails(Tag = 42153, Type = TagType.LocalDate, Offset = 4, Required = false)]
			public DateOnly? UnderlyingProvisionDateAdjusted {get; set;}
			
			[TagDetails(Tag = 42154, Type = TagType.Int, Offset = 5, Required = false)]
			public int? UnderlyingProvisionDateTenorPeriod {get; set;}
			
			[TagDetails(Tag = 42155, Type = TagType.String, Offset = 6, Required = false)]
			public string? UnderlyingProvisionDateTenorUnit {get; set;}
			
			[TagDetails(Tag = 43002, Type = TagType.Int, Offset = 7, Required = false)]
			public int? UnderlyingProvisionBreakFeeElection {get; set;}
			
			[TagDetails(Tag = 43003, Type = TagType.Float, Offset = 8, Required = false)]
			public double? UnderlyingProvisionBreakFeeRate {get; set;}
			
			[TagDetails(Tag = 42156, Type = TagType.Int, Offset = 9, Required = false)]
			public int? UnderlyingProvisionCalculationAgent {get; set;}
			
			[TagDetails(Tag = 42157, Type = TagType.Int, Offset = 10, Required = false)]
			public int? UnderlyingProvisionOptionSinglePartyBuyerSide {get; set;}
			
			[TagDetails(Tag = 42158, Type = TagType.Int, Offset = 11, Required = false)]
			public int? UnderlyingProvisionOptionSinglePartySellerSide {get; set;}
			
			[Component(Offset = 12, Required = false)]
			public UnderlyingProvisionCashSettlValueDates? UnderlyingProvisionCashSettlValueDates {get; set;}
			
			[Component(Offset = 13, Required = false)]
			public UnderlyingProvisionOptionExerciseDates? UnderlyingProvisionOptionExerciseDates {get; set;}
			
			[Component(Offset = 14, Required = false)]
			public UnderlyingProvisionOptionExpirationDate? UnderlyingProvisionOptionExpirationDate {get; set;}
			
			[Component(Offset = 15, Required = false)]
			public UnderlyingProvisionOptionRelevantUnderlyingDate? UnderlyingProvisionOptionRelevantUnderlyingDate {get; set;}
			
			[TagDetails(Tag = 42159, Type = TagType.Int, Offset = 16, Required = false)]
			public int? UnderlyingProvisionOptionExerciseStyle {get; set;}
			
			[TagDetails(Tag = 42160, Type = TagType.Float, Offset = 17, Required = false)]
			public double? UnderlyingProvisionOptionExerciseMultipleNotional {get; set;}
			
			[TagDetails(Tag = 42161, Type = TagType.Float, Offset = 18, Required = false)]
			public double? UnderlyingProvisionOptionExerciseMinimumNotional {get; set;}
			
			[TagDetails(Tag = 42162, Type = TagType.Float, Offset = 19, Required = false)]
			public double? UnderlyingProvisionOptionExerciseMaximumNotional {get; set;}
			
			[TagDetails(Tag = 42163, Type = TagType.Int, Offset = 20, Required = false)]
			public int? UnderlyingProvisionOptionMinimumNumber {get; set;}
			
			[TagDetails(Tag = 42164, Type = TagType.Int, Offset = 21, Required = false)]
			public int? UnderlyingProvisionOptionMaximumNumber {get; set;}
			
			[TagDetails(Tag = 42165, Type = TagType.Boolean, Offset = 22, Required = false)]
			public bool? UnderlyingProvisionOptionExerciseConfirmation {get; set;}
			
			[Component(Offset = 23, Required = false)]
			public UnderlyingProvisionCashSettlPaymentDates? UnderlyingProvisionCashSettlPaymentDates {get; set;}
			
			[TagDetails(Tag = 42166, Type = TagType.Int, Offset = 24, Required = false)]
			public int? UnderlyingProvisionCashSettlMethod {get; set;}
			
			[TagDetails(Tag = 42167, Type = TagType.String, Offset = 25, Required = false)]
			public string? UnderlyingProvisionCashSettlCurrency {get; set;}
			
			[TagDetails(Tag = 42168, Type = TagType.String, Offset = 26, Required = false)]
			public string? UnderlyingProvisionCashSettlCurrency2 {get; set;}
			
			[TagDetails(Tag = 42169, Type = TagType.Int, Offset = 27, Required = false)]
			public int? UnderlyingProvisionCashSettlQuoteType {get; set;}
			
			[Component(Offset = 28, Required = false)]
			public UnderlyingProvisionCashSettlQuoteSource? UnderlyingProvisionCashSettlQuoteSource {get; set;}
			
			[TagDetails(Tag = 42170, Type = TagType.String, Offset = 29, Required = false)]
			public string? UnderlyingProvisionText {get; set;}
			
			[TagDetails(Tag = 42171, Type = TagType.Length, Offset = 30, Required = false)]
			public int? EncodedUnderlyingProvisionTextLen {get; set;}
			
			[TagDetails(Tag = 42172, Type = TagType.RawData, Offset = 31, Required = false)]
			public byte[]? EncodedUnderlyingProvisionText {get; set;}
			
			[Component(Offset = 32, Required = false)]
			public UnderlyingProvisionParties? UnderlyingProvisionParties {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingProvisionType is not null) writer.WriteWholeNumber(42150, UnderlyingProvisionType.Value);
				if (UnderlyingProvisionDateUnadjusted is not null) writer.WriteLocalDateOnly(42151, UnderlyingProvisionDateUnadjusted.Value);
				if (UnderlyingProvisionDateBusinessDayConvention is not null) writer.WriteWholeNumber(42152, UnderlyingProvisionDateBusinessDayConvention.Value);
				if (UnderlyingProvisionDateBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingProvisionDateBusinessCenterGrp).Encode(writer);
				if (UnderlyingProvisionDateAdjusted is not null) writer.WriteLocalDateOnly(42153, UnderlyingProvisionDateAdjusted.Value);
				if (UnderlyingProvisionDateTenorPeriod is not null) writer.WriteWholeNumber(42154, UnderlyingProvisionDateTenorPeriod.Value);
				if (UnderlyingProvisionDateTenorUnit is not null) writer.WriteString(42155, UnderlyingProvisionDateTenorUnit);
				if (UnderlyingProvisionBreakFeeElection is not null) writer.WriteWholeNumber(43002, UnderlyingProvisionBreakFeeElection.Value);
				if (UnderlyingProvisionBreakFeeRate is not null) writer.WriteNumber(43003, UnderlyingProvisionBreakFeeRate.Value);
				if (UnderlyingProvisionCalculationAgent is not null) writer.WriteWholeNumber(42156, UnderlyingProvisionCalculationAgent.Value);
				if (UnderlyingProvisionOptionSinglePartyBuyerSide is not null) writer.WriteWholeNumber(42157, UnderlyingProvisionOptionSinglePartyBuyerSide.Value);
				if (UnderlyingProvisionOptionSinglePartySellerSide is not null) writer.WriteWholeNumber(42158, UnderlyingProvisionOptionSinglePartySellerSide.Value);
				if (UnderlyingProvisionCashSettlValueDates is not null) ((IFixEncoder)UnderlyingProvisionCashSettlValueDates).Encode(writer);
				if (UnderlyingProvisionOptionExerciseDates is not null) ((IFixEncoder)UnderlyingProvisionOptionExerciseDates).Encode(writer);
				if (UnderlyingProvisionOptionExpirationDate is not null) ((IFixEncoder)UnderlyingProvisionOptionExpirationDate).Encode(writer);
				if (UnderlyingProvisionOptionRelevantUnderlyingDate is not null) ((IFixEncoder)UnderlyingProvisionOptionRelevantUnderlyingDate).Encode(writer);
				if (UnderlyingProvisionOptionExerciseStyle is not null) writer.WriteWholeNumber(42159, UnderlyingProvisionOptionExerciseStyle.Value);
				if (UnderlyingProvisionOptionExerciseMultipleNotional is not null) writer.WriteNumber(42160, UnderlyingProvisionOptionExerciseMultipleNotional.Value);
				if (UnderlyingProvisionOptionExerciseMinimumNotional is not null) writer.WriteNumber(42161, UnderlyingProvisionOptionExerciseMinimumNotional.Value);
				if (UnderlyingProvisionOptionExerciseMaximumNotional is not null) writer.WriteNumber(42162, UnderlyingProvisionOptionExerciseMaximumNotional.Value);
				if (UnderlyingProvisionOptionMinimumNumber is not null) writer.WriteWholeNumber(42163, UnderlyingProvisionOptionMinimumNumber.Value);
				if (UnderlyingProvisionOptionMaximumNumber is not null) writer.WriteWholeNumber(42164, UnderlyingProvisionOptionMaximumNumber.Value);
				if (UnderlyingProvisionOptionExerciseConfirmation is not null) writer.WriteBoolean(42165, UnderlyingProvisionOptionExerciseConfirmation.Value);
				if (UnderlyingProvisionCashSettlPaymentDates is not null) ((IFixEncoder)UnderlyingProvisionCashSettlPaymentDates).Encode(writer);
				if (UnderlyingProvisionCashSettlMethod is not null) writer.WriteWholeNumber(42166, UnderlyingProvisionCashSettlMethod.Value);
				if (UnderlyingProvisionCashSettlCurrency is not null) writer.WriteString(42167, UnderlyingProvisionCashSettlCurrency);
				if (UnderlyingProvisionCashSettlCurrency2 is not null) writer.WriteString(42168, UnderlyingProvisionCashSettlCurrency2);
				if (UnderlyingProvisionCashSettlQuoteType is not null) writer.WriteWholeNumber(42169, UnderlyingProvisionCashSettlQuoteType.Value);
				if (UnderlyingProvisionCashSettlQuoteSource is not null) ((IFixEncoder)UnderlyingProvisionCashSettlQuoteSource).Encode(writer);
				if (UnderlyingProvisionText is not null) writer.WriteString(42170, UnderlyingProvisionText);
				if (EncodedUnderlyingProvisionTextLen is not null) writer.WriteWholeNumber(42171, EncodedUnderlyingProvisionTextLen.Value);
				if (EncodedUnderlyingProvisionText is not null) writer.WriteBuffer(42172, EncodedUnderlyingProvisionText);
				if (UnderlyingProvisionParties is not null) ((IFixEncoder)UnderlyingProvisionParties).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingProvisionType = view.GetInt32(42150);
				UnderlyingProvisionDateUnadjusted = view.GetDateOnly(42151);
				UnderlyingProvisionDateBusinessDayConvention = view.GetInt32(42152);
				if (view.GetView("UnderlyingProvisionDateBusinessCenterGrp") is IMessageView viewUnderlyingProvisionDateBusinessCenterGrp)
				{
					UnderlyingProvisionDateBusinessCenterGrp = new();
					((IFixParser)UnderlyingProvisionDateBusinessCenterGrp).Parse(viewUnderlyingProvisionDateBusinessCenterGrp);
				}
				UnderlyingProvisionDateAdjusted = view.GetDateOnly(42153);
				UnderlyingProvisionDateTenorPeriod = view.GetInt32(42154);
				UnderlyingProvisionDateTenorUnit = view.GetString(42155);
				UnderlyingProvisionBreakFeeElection = view.GetInt32(43002);
				UnderlyingProvisionBreakFeeRate = view.GetDouble(43003);
				UnderlyingProvisionCalculationAgent = view.GetInt32(42156);
				UnderlyingProvisionOptionSinglePartyBuyerSide = view.GetInt32(42157);
				UnderlyingProvisionOptionSinglePartySellerSide = view.GetInt32(42158);
				if (view.GetView("UnderlyingProvisionCashSettlValueDates") is IMessageView viewUnderlyingProvisionCashSettlValueDates)
				{
					UnderlyingProvisionCashSettlValueDates = new();
					((IFixParser)UnderlyingProvisionCashSettlValueDates).Parse(viewUnderlyingProvisionCashSettlValueDates);
				}
				if (view.GetView("UnderlyingProvisionOptionExerciseDates") is IMessageView viewUnderlyingProvisionOptionExerciseDates)
				{
					UnderlyingProvisionOptionExerciseDates = new();
					((IFixParser)UnderlyingProvisionOptionExerciseDates).Parse(viewUnderlyingProvisionOptionExerciseDates);
				}
				if (view.GetView("UnderlyingProvisionOptionExpirationDate") is IMessageView viewUnderlyingProvisionOptionExpirationDate)
				{
					UnderlyingProvisionOptionExpirationDate = new();
					((IFixParser)UnderlyingProvisionOptionExpirationDate).Parse(viewUnderlyingProvisionOptionExpirationDate);
				}
				if (view.GetView("UnderlyingProvisionOptionRelevantUnderlyingDate") is IMessageView viewUnderlyingProvisionOptionRelevantUnderlyingDate)
				{
					UnderlyingProvisionOptionRelevantUnderlyingDate = new();
					((IFixParser)UnderlyingProvisionOptionRelevantUnderlyingDate).Parse(viewUnderlyingProvisionOptionRelevantUnderlyingDate);
				}
				UnderlyingProvisionOptionExerciseStyle = view.GetInt32(42159);
				UnderlyingProvisionOptionExerciseMultipleNotional = view.GetDouble(42160);
				UnderlyingProvisionOptionExerciseMinimumNotional = view.GetDouble(42161);
				UnderlyingProvisionOptionExerciseMaximumNotional = view.GetDouble(42162);
				UnderlyingProvisionOptionMinimumNumber = view.GetInt32(42163);
				UnderlyingProvisionOptionMaximumNumber = view.GetInt32(42164);
				UnderlyingProvisionOptionExerciseConfirmation = view.GetBool(42165);
				if (view.GetView("UnderlyingProvisionCashSettlPaymentDates") is IMessageView viewUnderlyingProvisionCashSettlPaymentDates)
				{
					UnderlyingProvisionCashSettlPaymentDates = new();
					((IFixParser)UnderlyingProvisionCashSettlPaymentDates).Parse(viewUnderlyingProvisionCashSettlPaymentDates);
				}
				UnderlyingProvisionCashSettlMethod = view.GetInt32(42166);
				UnderlyingProvisionCashSettlCurrency = view.GetString(42167);
				UnderlyingProvisionCashSettlCurrency2 = view.GetString(42168);
				UnderlyingProvisionCashSettlQuoteType = view.GetInt32(42169);
				if (view.GetView("UnderlyingProvisionCashSettlQuoteSource") is IMessageView viewUnderlyingProvisionCashSettlQuoteSource)
				{
					UnderlyingProvisionCashSettlQuoteSource = new();
					((IFixParser)UnderlyingProvisionCashSettlQuoteSource).Parse(viewUnderlyingProvisionCashSettlQuoteSource);
				}
				UnderlyingProvisionText = view.GetString(42170);
				EncodedUnderlyingProvisionTextLen = view.GetInt32(42171);
				EncodedUnderlyingProvisionText = view.GetByteArray(42172);
				if (view.GetView("UnderlyingProvisionParties") is IMessageView viewUnderlyingProvisionParties)
				{
					UnderlyingProvisionParties = new();
					((IFixParser)UnderlyingProvisionParties).Parse(viewUnderlyingProvisionParties);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingProvisionType":
					{
						value = UnderlyingProvisionType;
						break;
					}
					case "UnderlyingProvisionDateUnadjusted":
					{
						value = UnderlyingProvisionDateUnadjusted;
						break;
					}
					case "UnderlyingProvisionDateBusinessDayConvention":
					{
						value = UnderlyingProvisionDateBusinessDayConvention;
						break;
					}
					case "UnderlyingProvisionDateBusinessCenterGrp":
					{
						value = UnderlyingProvisionDateBusinessCenterGrp;
						break;
					}
					case "UnderlyingProvisionDateAdjusted":
					{
						value = UnderlyingProvisionDateAdjusted;
						break;
					}
					case "UnderlyingProvisionDateTenorPeriod":
					{
						value = UnderlyingProvisionDateTenorPeriod;
						break;
					}
					case "UnderlyingProvisionDateTenorUnit":
					{
						value = UnderlyingProvisionDateTenorUnit;
						break;
					}
					case "UnderlyingProvisionBreakFeeElection":
					{
						value = UnderlyingProvisionBreakFeeElection;
						break;
					}
					case "UnderlyingProvisionBreakFeeRate":
					{
						value = UnderlyingProvisionBreakFeeRate;
						break;
					}
					case "UnderlyingProvisionCalculationAgent":
					{
						value = UnderlyingProvisionCalculationAgent;
						break;
					}
					case "UnderlyingProvisionOptionSinglePartyBuyerSide":
					{
						value = UnderlyingProvisionOptionSinglePartyBuyerSide;
						break;
					}
					case "UnderlyingProvisionOptionSinglePartySellerSide":
					{
						value = UnderlyingProvisionOptionSinglePartySellerSide;
						break;
					}
					case "UnderlyingProvisionCashSettlValueDates":
					{
						value = UnderlyingProvisionCashSettlValueDates;
						break;
					}
					case "UnderlyingProvisionOptionExerciseDates":
					{
						value = UnderlyingProvisionOptionExerciseDates;
						break;
					}
					case "UnderlyingProvisionOptionExpirationDate":
					{
						value = UnderlyingProvisionOptionExpirationDate;
						break;
					}
					case "UnderlyingProvisionOptionRelevantUnderlyingDate":
					{
						value = UnderlyingProvisionOptionRelevantUnderlyingDate;
						break;
					}
					case "UnderlyingProvisionOptionExerciseStyle":
					{
						value = UnderlyingProvisionOptionExerciseStyle;
						break;
					}
					case "UnderlyingProvisionOptionExerciseMultipleNotional":
					{
						value = UnderlyingProvisionOptionExerciseMultipleNotional;
						break;
					}
					case "UnderlyingProvisionOptionExerciseMinimumNotional":
					{
						value = UnderlyingProvisionOptionExerciseMinimumNotional;
						break;
					}
					case "UnderlyingProvisionOptionExerciseMaximumNotional":
					{
						value = UnderlyingProvisionOptionExerciseMaximumNotional;
						break;
					}
					case "UnderlyingProvisionOptionMinimumNumber":
					{
						value = UnderlyingProvisionOptionMinimumNumber;
						break;
					}
					case "UnderlyingProvisionOptionMaximumNumber":
					{
						value = UnderlyingProvisionOptionMaximumNumber;
						break;
					}
					case "UnderlyingProvisionOptionExerciseConfirmation":
					{
						value = UnderlyingProvisionOptionExerciseConfirmation;
						break;
					}
					case "UnderlyingProvisionCashSettlPaymentDates":
					{
						value = UnderlyingProvisionCashSettlPaymentDates;
						break;
					}
					case "UnderlyingProvisionCashSettlMethod":
					{
						value = UnderlyingProvisionCashSettlMethod;
						break;
					}
					case "UnderlyingProvisionCashSettlCurrency":
					{
						value = UnderlyingProvisionCashSettlCurrency;
						break;
					}
					case "UnderlyingProvisionCashSettlCurrency2":
					{
						value = UnderlyingProvisionCashSettlCurrency2;
						break;
					}
					case "UnderlyingProvisionCashSettlQuoteType":
					{
						value = UnderlyingProvisionCashSettlQuoteType;
						break;
					}
					case "UnderlyingProvisionCashSettlQuoteSource":
					{
						value = UnderlyingProvisionCashSettlQuoteSource;
						break;
					}
					case "UnderlyingProvisionText":
					{
						value = UnderlyingProvisionText;
						break;
					}
					case "EncodedUnderlyingProvisionTextLen":
					{
						value = EncodedUnderlyingProvisionTextLen;
						break;
					}
					case "EncodedUnderlyingProvisionText":
					{
						value = EncodedUnderlyingProvisionText;
						break;
					}
					case "UnderlyingProvisionParties":
					{
						value = UnderlyingProvisionParties;
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
				UnderlyingProvisionType = null;
				UnderlyingProvisionDateUnadjusted = null;
				UnderlyingProvisionDateBusinessDayConvention = null;
				((IFixReset?)UnderlyingProvisionDateBusinessCenterGrp)?.Reset();
				UnderlyingProvisionDateAdjusted = null;
				UnderlyingProvisionDateTenorPeriod = null;
				UnderlyingProvisionDateTenorUnit = null;
				UnderlyingProvisionBreakFeeElection = null;
				UnderlyingProvisionBreakFeeRate = null;
				UnderlyingProvisionCalculationAgent = null;
				UnderlyingProvisionOptionSinglePartyBuyerSide = null;
				UnderlyingProvisionOptionSinglePartySellerSide = null;
				((IFixReset?)UnderlyingProvisionCashSettlValueDates)?.Reset();
				((IFixReset?)UnderlyingProvisionOptionExerciseDates)?.Reset();
				((IFixReset?)UnderlyingProvisionOptionExpirationDate)?.Reset();
				((IFixReset?)UnderlyingProvisionOptionRelevantUnderlyingDate)?.Reset();
				UnderlyingProvisionOptionExerciseStyle = null;
				UnderlyingProvisionOptionExerciseMultipleNotional = null;
				UnderlyingProvisionOptionExerciseMinimumNotional = null;
				UnderlyingProvisionOptionExerciseMaximumNotional = null;
				UnderlyingProvisionOptionMinimumNumber = null;
				UnderlyingProvisionOptionMaximumNumber = null;
				UnderlyingProvisionOptionExerciseConfirmation = null;
				((IFixReset?)UnderlyingProvisionCashSettlPaymentDates)?.Reset();
				UnderlyingProvisionCashSettlMethod = null;
				UnderlyingProvisionCashSettlCurrency = null;
				UnderlyingProvisionCashSettlCurrency2 = null;
				UnderlyingProvisionCashSettlQuoteType = null;
				((IFixReset?)UnderlyingProvisionCashSettlQuoteSource)?.Reset();
				UnderlyingProvisionText = null;
				EncodedUnderlyingProvisionTextLen = null;
				EncodedUnderlyingProvisionText = null;
				((IFixReset?)UnderlyingProvisionParties)?.Reset();
			}
		}
		[Group(NoOfTag = 42149, Offset = 0, Required = false)]
		public NoUnderlyingProvisions[]? UnderlyingProvisions {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingProvisions is not null && UnderlyingProvisions.Length != 0)
			{
				writer.WriteWholeNumber(42149, UnderlyingProvisions.Length);
				for (int i = 0; i < UnderlyingProvisions.Length; i++)
				{
					((IFixEncoder)UnderlyingProvisions[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingProvisions") is IMessageView viewNoUnderlyingProvisions)
			{
				var count = viewNoUnderlyingProvisions.GroupCount();
				UnderlyingProvisions = new NoUnderlyingProvisions[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingProvisions[i] = new();
					((IFixParser)UnderlyingProvisions[i]).Parse(viewNoUnderlyingProvisions.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingProvisions":
				{
					value = UnderlyingProvisions;
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
			UnderlyingProvisions = null;
		}
	}
}
