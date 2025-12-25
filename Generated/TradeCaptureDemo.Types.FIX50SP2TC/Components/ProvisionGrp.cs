using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ProvisionGrp : IFixComponent
	{
		public sealed partial class NoProvisions : IFixGroup
		{
			[TagDetails(Tag = 40091, Type = TagType.Int, Offset = 0, Required = false)]
			public int? ProvisionType {get; set;}
			
			[TagDetails(Tag = 40092, Type = TagType.LocalDate, Offset = 1, Required = false)]
			public DateOnly? ProvisionDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 40093, Type = TagType.Int, Offset = 2, Required = false)]
			public int? ProvisionDateBusinessDayConvention {get; set;}
			
			[Component(Offset = 3, Required = false)]
			public ProvisionDateBusinessCenterGrp? ProvisionDateBusinessCenterGrp {get; set;}
			
			[TagDetails(Tag = 40095, Type = TagType.LocalDate, Offset = 4, Required = false)]
			public DateOnly? ProvisionDateAdjusted {get; set;}
			
			[TagDetails(Tag = 40096, Type = TagType.Int, Offset = 5, Required = false)]
			public int? ProvisionDateTenorPeriod {get; set;}
			
			[TagDetails(Tag = 40097, Type = TagType.String, Offset = 6, Required = false)]
			public string? ProvisionDateTenorUnit {get; set;}
			
			[TagDetails(Tag = 42707, Type = TagType.Int, Offset = 7, Required = false)]
			public int? ProvisionBreakFeeElection {get; set;}
			
			[TagDetails(Tag = 42708, Type = TagType.Float, Offset = 8, Required = false)]
			public double? ProvisionBreakFeeRate {get; set;}
			
			[TagDetails(Tag = 40098, Type = TagType.Int, Offset = 9, Required = false)]
			public int? ProvisionCalculationAgent {get; set;}
			
			[TagDetails(Tag = 40099, Type = TagType.Int, Offset = 10, Required = false)]
			public int? ProvisionOptionSinglePartyBuyerSide {get; set;}
			
			[TagDetails(Tag = 40100, Type = TagType.Int, Offset = 11, Required = false)]
			public int? ProvisionOptionSinglePartySellerSide {get; set;}
			
			[Component(Offset = 12, Required = false)]
			public ProvisionCashSettlValueDates? ProvisionCashSettlValueDates {get; set;}
			
			[Component(Offset = 13, Required = false)]
			public ProvisionOptionExerciseDates? ProvisionOptionExerciseDates {get; set;}
			
			[Component(Offset = 14, Required = false)]
			public ProvisionOptionExpirationDate? ProvisionOptionExpirationDate {get; set;}
			
			[Component(Offset = 15, Required = false)]
			public ProvisionOptionRelevantUnderlyingDate? ProvisionOptionRelevantUnderlyingDate {get; set;}
			
			[TagDetails(Tag = 40101, Type = TagType.Int, Offset = 16, Required = false)]
			public int? ProvisionOptionExerciseStyle {get; set;}
			
			[TagDetails(Tag = 40102, Type = TagType.Float, Offset = 17, Required = false)]
			public double? ProvisionOptionExerciseMultipleNotional {get; set;}
			
			[TagDetails(Tag = 40103, Type = TagType.Float, Offset = 18, Required = false)]
			public double? ProvisionOptionExerciseMinimumNotional {get; set;}
			
			[TagDetails(Tag = 40104, Type = TagType.Float, Offset = 19, Required = false)]
			public double? ProvisionOptionExerciseMaximumNotional {get; set;}
			
			[TagDetails(Tag = 40105, Type = TagType.Int, Offset = 20, Required = false)]
			public int? ProvisionOptionMinimumNumber {get; set;}
			
			[TagDetails(Tag = 40106, Type = TagType.Int, Offset = 21, Required = false)]
			public int? ProvisionOptionMaximumNumber {get; set;}
			
			[TagDetails(Tag = 40107, Type = TagType.Boolean, Offset = 22, Required = false)]
			public bool? ProvisionOptionExerciseConfirmation {get; set;}
			
			[Component(Offset = 23, Required = false)]
			public ProvisionCashSettlPaymentDates? ProvisionCashSettlPaymentDates {get; set;}
			
			[TagDetails(Tag = 40108, Type = TagType.Int, Offset = 24, Required = false)]
			public int? ProvisionCashSettlMethod {get; set;}
			
			[TagDetails(Tag = 40109, Type = TagType.String, Offset = 25, Required = false)]
			public string? ProvisionCashSettlCurrency {get; set;}
			
			[TagDetails(Tag = 40110, Type = TagType.String, Offset = 26, Required = false)]
			public string? ProvisionCashSettlCurrency2 {get; set;}
			
			[TagDetails(Tag = 40111, Type = TagType.Int, Offset = 27, Required = false)]
			public int? ProvisionCashSettlQuoteType {get; set;}
			
			[Component(Offset = 28, Required = false)]
			public ProvisionCashSettlQuoteSource? ProvisionCashSettlQuoteSource {get; set;}
			
			[TagDetails(Tag = 40113, Type = TagType.String, Offset = 29, Required = false)]
			public string? ProvisionText {get; set;}
			
			[TagDetails(Tag = 40986, Type = TagType.Length, Offset = 30, Required = false)]
			public int? EncodedProvisionTextLen {get; set;}
			
			[TagDetails(Tag = 40987, Type = TagType.RawData, Offset = 31, Required = false)]
			public byte[]? EncodedProvisionText {get; set;}
			
			[Component(Offset = 32, Required = false)]
			public ProvisionParties? ProvisionParties {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ProvisionType is not null) writer.WriteWholeNumber(40091, ProvisionType.Value);
				if (ProvisionDateUnadjusted is not null) writer.WriteLocalDateOnly(40092, ProvisionDateUnadjusted.Value);
				if (ProvisionDateBusinessDayConvention is not null) writer.WriteWholeNumber(40093, ProvisionDateBusinessDayConvention.Value);
				if (ProvisionDateBusinessCenterGrp is not null) ((IFixEncoder)ProvisionDateBusinessCenterGrp).Encode(writer);
				if (ProvisionDateAdjusted is not null) writer.WriteLocalDateOnly(40095, ProvisionDateAdjusted.Value);
				if (ProvisionDateTenorPeriod is not null) writer.WriteWholeNumber(40096, ProvisionDateTenorPeriod.Value);
				if (ProvisionDateTenorUnit is not null) writer.WriteString(40097, ProvisionDateTenorUnit);
				if (ProvisionBreakFeeElection is not null) writer.WriteWholeNumber(42707, ProvisionBreakFeeElection.Value);
				if (ProvisionBreakFeeRate is not null) writer.WriteNumber(42708, ProvisionBreakFeeRate.Value);
				if (ProvisionCalculationAgent is not null) writer.WriteWholeNumber(40098, ProvisionCalculationAgent.Value);
				if (ProvisionOptionSinglePartyBuyerSide is not null) writer.WriteWholeNumber(40099, ProvisionOptionSinglePartyBuyerSide.Value);
				if (ProvisionOptionSinglePartySellerSide is not null) writer.WriteWholeNumber(40100, ProvisionOptionSinglePartySellerSide.Value);
				if (ProvisionCashSettlValueDates is not null) ((IFixEncoder)ProvisionCashSettlValueDates).Encode(writer);
				if (ProvisionOptionExerciseDates is not null) ((IFixEncoder)ProvisionOptionExerciseDates).Encode(writer);
				if (ProvisionOptionExpirationDate is not null) ((IFixEncoder)ProvisionOptionExpirationDate).Encode(writer);
				if (ProvisionOptionRelevantUnderlyingDate is not null) ((IFixEncoder)ProvisionOptionRelevantUnderlyingDate).Encode(writer);
				if (ProvisionOptionExerciseStyle is not null) writer.WriteWholeNumber(40101, ProvisionOptionExerciseStyle.Value);
				if (ProvisionOptionExerciseMultipleNotional is not null) writer.WriteNumber(40102, ProvisionOptionExerciseMultipleNotional.Value);
				if (ProvisionOptionExerciseMinimumNotional is not null) writer.WriteNumber(40103, ProvisionOptionExerciseMinimumNotional.Value);
				if (ProvisionOptionExerciseMaximumNotional is not null) writer.WriteNumber(40104, ProvisionOptionExerciseMaximumNotional.Value);
				if (ProvisionOptionMinimumNumber is not null) writer.WriteWholeNumber(40105, ProvisionOptionMinimumNumber.Value);
				if (ProvisionOptionMaximumNumber is not null) writer.WriteWholeNumber(40106, ProvisionOptionMaximumNumber.Value);
				if (ProvisionOptionExerciseConfirmation is not null) writer.WriteBoolean(40107, ProvisionOptionExerciseConfirmation.Value);
				if (ProvisionCashSettlPaymentDates is not null) ((IFixEncoder)ProvisionCashSettlPaymentDates).Encode(writer);
				if (ProvisionCashSettlMethod is not null) writer.WriteWholeNumber(40108, ProvisionCashSettlMethod.Value);
				if (ProvisionCashSettlCurrency is not null) writer.WriteString(40109, ProvisionCashSettlCurrency);
				if (ProvisionCashSettlCurrency2 is not null) writer.WriteString(40110, ProvisionCashSettlCurrency2);
				if (ProvisionCashSettlQuoteType is not null) writer.WriteWholeNumber(40111, ProvisionCashSettlQuoteType.Value);
				if (ProvisionCashSettlQuoteSource is not null) ((IFixEncoder)ProvisionCashSettlQuoteSource).Encode(writer);
				if (ProvisionText is not null) writer.WriteString(40113, ProvisionText);
				if (EncodedProvisionTextLen is not null) writer.WriteWholeNumber(40986, EncodedProvisionTextLen.Value);
				if (EncodedProvisionText is not null) writer.WriteBuffer(40987, EncodedProvisionText);
				if (ProvisionParties is not null) ((IFixEncoder)ProvisionParties).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ProvisionType = view.GetInt32(40091);
				ProvisionDateUnadjusted = view.GetDateOnly(40092);
				ProvisionDateBusinessDayConvention = view.GetInt32(40093);
				if (view.GetView("ProvisionDateBusinessCenterGrp") is IMessageView viewProvisionDateBusinessCenterGrp)
				{
					ProvisionDateBusinessCenterGrp = new();
					((IFixParser)ProvisionDateBusinessCenterGrp).Parse(viewProvisionDateBusinessCenterGrp);
				}
				ProvisionDateAdjusted = view.GetDateOnly(40095);
				ProvisionDateTenorPeriod = view.GetInt32(40096);
				ProvisionDateTenorUnit = view.GetString(40097);
				ProvisionBreakFeeElection = view.GetInt32(42707);
				ProvisionBreakFeeRate = view.GetDouble(42708);
				ProvisionCalculationAgent = view.GetInt32(40098);
				ProvisionOptionSinglePartyBuyerSide = view.GetInt32(40099);
				ProvisionOptionSinglePartySellerSide = view.GetInt32(40100);
				if (view.GetView("ProvisionCashSettlValueDates") is IMessageView viewProvisionCashSettlValueDates)
				{
					ProvisionCashSettlValueDates = new();
					((IFixParser)ProvisionCashSettlValueDates).Parse(viewProvisionCashSettlValueDates);
				}
				if (view.GetView("ProvisionOptionExerciseDates") is IMessageView viewProvisionOptionExerciseDates)
				{
					ProvisionOptionExerciseDates = new();
					((IFixParser)ProvisionOptionExerciseDates).Parse(viewProvisionOptionExerciseDates);
				}
				if (view.GetView("ProvisionOptionExpirationDate") is IMessageView viewProvisionOptionExpirationDate)
				{
					ProvisionOptionExpirationDate = new();
					((IFixParser)ProvisionOptionExpirationDate).Parse(viewProvisionOptionExpirationDate);
				}
				if (view.GetView("ProvisionOptionRelevantUnderlyingDate") is IMessageView viewProvisionOptionRelevantUnderlyingDate)
				{
					ProvisionOptionRelevantUnderlyingDate = new();
					((IFixParser)ProvisionOptionRelevantUnderlyingDate).Parse(viewProvisionOptionRelevantUnderlyingDate);
				}
				ProvisionOptionExerciseStyle = view.GetInt32(40101);
				ProvisionOptionExerciseMultipleNotional = view.GetDouble(40102);
				ProvisionOptionExerciseMinimumNotional = view.GetDouble(40103);
				ProvisionOptionExerciseMaximumNotional = view.GetDouble(40104);
				ProvisionOptionMinimumNumber = view.GetInt32(40105);
				ProvisionOptionMaximumNumber = view.GetInt32(40106);
				ProvisionOptionExerciseConfirmation = view.GetBool(40107);
				if (view.GetView("ProvisionCashSettlPaymentDates") is IMessageView viewProvisionCashSettlPaymentDates)
				{
					ProvisionCashSettlPaymentDates = new();
					((IFixParser)ProvisionCashSettlPaymentDates).Parse(viewProvisionCashSettlPaymentDates);
				}
				ProvisionCashSettlMethod = view.GetInt32(40108);
				ProvisionCashSettlCurrency = view.GetString(40109);
				ProvisionCashSettlCurrency2 = view.GetString(40110);
				ProvisionCashSettlQuoteType = view.GetInt32(40111);
				if (view.GetView("ProvisionCashSettlQuoteSource") is IMessageView viewProvisionCashSettlQuoteSource)
				{
					ProvisionCashSettlQuoteSource = new();
					((IFixParser)ProvisionCashSettlQuoteSource).Parse(viewProvisionCashSettlQuoteSource);
				}
				ProvisionText = view.GetString(40113);
				EncodedProvisionTextLen = view.GetInt32(40986);
				EncodedProvisionText = view.GetByteArray(40987);
				if (view.GetView("ProvisionParties") is IMessageView viewProvisionParties)
				{
					ProvisionParties = new();
					((IFixParser)ProvisionParties).Parse(viewProvisionParties);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ProvisionType":
					{
						value = ProvisionType;
						break;
					}
					case "ProvisionDateUnadjusted":
					{
						value = ProvisionDateUnadjusted;
						break;
					}
					case "ProvisionDateBusinessDayConvention":
					{
						value = ProvisionDateBusinessDayConvention;
						break;
					}
					case "ProvisionDateBusinessCenterGrp":
					{
						value = ProvisionDateBusinessCenterGrp;
						break;
					}
					case "ProvisionDateAdjusted":
					{
						value = ProvisionDateAdjusted;
						break;
					}
					case "ProvisionDateTenorPeriod":
					{
						value = ProvisionDateTenorPeriod;
						break;
					}
					case "ProvisionDateTenorUnit":
					{
						value = ProvisionDateTenorUnit;
						break;
					}
					case "ProvisionBreakFeeElection":
					{
						value = ProvisionBreakFeeElection;
						break;
					}
					case "ProvisionBreakFeeRate":
					{
						value = ProvisionBreakFeeRate;
						break;
					}
					case "ProvisionCalculationAgent":
					{
						value = ProvisionCalculationAgent;
						break;
					}
					case "ProvisionOptionSinglePartyBuyerSide":
					{
						value = ProvisionOptionSinglePartyBuyerSide;
						break;
					}
					case "ProvisionOptionSinglePartySellerSide":
					{
						value = ProvisionOptionSinglePartySellerSide;
						break;
					}
					case "ProvisionCashSettlValueDates":
					{
						value = ProvisionCashSettlValueDates;
						break;
					}
					case "ProvisionOptionExerciseDates":
					{
						value = ProvisionOptionExerciseDates;
						break;
					}
					case "ProvisionOptionExpirationDate":
					{
						value = ProvisionOptionExpirationDate;
						break;
					}
					case "ProvisionOptionRelevantUnderlyingDate":
					{
						value = ProvisionOptionRelevantUnderlyingDate;
						break;
					}
					case "ProvisionOptionExerciseStyle":
					{
						value = ProvisionOptionExerciseStyle;
						break;
					}
					case "ProvisionOptionExerciseMultipleNotional":
					{
						value = ProvisionOptionExerciseMultipleNotional;
						break;
					}
					case "ProvisionOptionExerciseMinimumNotional":
					{
						value = ProvisionOptionExerciseMinimumNotional;
						break;
					}
					case "ProvisionOptionExerciseMaximumNotional":
					{
						value = ProvisionOptionExerciseMaximumNotional;
						break;
					}
					case "ProvisionOptionMinimumNumber":
					{
						value = ProvisionOptionMinimumNumber;
						break;
					}
					case "ProvisionOptionMaximumNumber":
					{
						value = ProvisionOptionMaximumNumber;
						break;
					}
					case "ProvisionOptionExerciseConfirmation":
					{
						value = ProvisionOptionExerciseConfirmation;
						break;
					}
					case "ProvisionCashSettlPaymentDates":
					{
						value = ProvisionCashSettlPaymentDates;
						break;
					}
					case "ProvisionCashSettlMethod":
					{
						value = ProvisionCashSettlMethod;
						break;
					}
					case "ProvisionCashSettlCurrency":
					{
						value = ProvisionCashSettlCurrency;
						break;
					}
					case "ProvisionCashSettlCurrency2":
					{
						value = ProvisionCashSettlCurrency2;
						break;
					}
					case "ProvisionCashSettlQuoteType":
					{
						value = ProvisionCashSettlQuoteType;
						break;
					}
					case "ProvisionCashSettlQuoteSource":
					{
						value = ProvisionCashSettlQuoteSource;
						break;
					}
					case "ProvisionText":
					{
						value = ProvisionText;
						break;
					}
					case "EncodedProvisionTextLen":
					{
						value = EncodedProvisionTextLen;
						break;
					}
					case "EncodedProvisionText":
					{
						value = EncodedProvisionText;
						break;
					}
					case "ProvisionParties":
					{
						value = ProvisionParties;
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
				ProvisionType = null;
				ProvisionDateUnadjusted = null;
				ProvisionDateBusinessDayConvention = null;
				((IFixReset?)ProvisionDateBusinessCenterGrp)?.Reset();
				ProvisionDateAdjusted = null;
				ProvisionDateTenorPeriod = null;
				ProvisionDateTenorUnit = null;
				ProvisionBreakFeeElection = null;
				ProvisionBreakFeeRate = null;
				ProvisionCalculationAgent = null;
				ProvisionOptionSinglePartyBuyerSide = null;
				ProvisionOptionSinglePartySellerSide = null;
				((IFixReset?)ProvisionCashSettlValueDates)?.Reset();
				((IFixReset?)ProvisionOptionExerciseDates)?.Reset();
				((IFixReset?)ProvisionOptionExpirationDate)?.Reset();
				((IFixReset?)ProvisionOptionRelevantUnderlyingDate)?.Reset();
				ProvisionOptionExerciseStyle = null;
				ProvisionOptionExerciseMultipleNotional = null;
				ProvisionOptionExerciseMinimumNotional = null;
				ProvisionOptionExerciseMaximumNotional = null;
				ProvisionOptionMinimumNumber = null;
				ProvisionOptionMaximumNumber = null;
				ProvisionOptionExerciseConfirmation = null;
				((IFixReset?)ProvisionCashSettlPaymentDates)?.Reset();
				ProvisionCashSettlMethod = null;
				ProvisionCashSettlCurrency = null;
				ProvisionCashSettlCurrency2 = null;
				ProvisionCashSettlQuoteType = null;
				((IFixReset?)ProvisionCashSettlQuoteSource)?.Reset();
				ProvisionText = null;
				EncodedProvisionTextLen = null;
				EncodedProvisionText = null;
				((IFixReset?)ProvisionParties)?.Reset();
			}
		}
		[Group(NoOfTag = 40090, Offset = 0, Required = false)]
		public NoProvisions[]? Provisions {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Provisions is not null && Provisions.Length != 0)
			{
				writer.WriteWholeNumber(40090, Provisions.Length);
				for (int i = 0; i < Provisions.Length; i++)
				{
					((IFixEncoder)Provisions[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoProvisions") is IMessageView viewNoProvisions)
			{
				var count = viewNoProvisions.GroupCount();
				Provisions = new NoProvisions[count];
				for (int i = 0; i < count; i++)
				{
					Provisions[i] = new();
					((IFixParser)Provisions[i]).Parse(viewNoProvisions.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoProvisions":
				{
					value = Provisions;
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
			Provisions = null;
		}
	}
}
