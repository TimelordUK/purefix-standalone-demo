using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class CommissionDataGrp : IFixComponent
	{
		public sealed partial class NoCommissions : IFixGroup
		{
			[TagDetails(Tag = 2640, Type = TagType.Float, Offset = 0, Required = false)]
			public double? CommissionAmount {get; set;}
			
			[TagDetails(Tag = 2641, Type = TagType.Int, Offset = 1, Required = false)]
			public int? CommissionAmountType {get; set;}
			
			[TagDetails(Tag = 2725, Type = TagType.Int, Offset = 2, Required = false)]
			public int? CommissionAmountSubType {get; set;}
			
			[TagDetails(Tag = 2642, Type = TagType.String, Offset = 3, Required = false)]
			public string? CommissionBasis {get; set;}
			
			[TagDetails(Tag = 2643, Type = TagType.String, Offset = 4, Required = false)]
			public string? CommissionCurrency {get; set;}
			
			[TagDetails(Tag = 2923, Type = TagType.String, Offset = 5, Required = false)]
			public string? CommissionCurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 2644, Type = TagType.String, Offset = 6, Required = false)]
			public string? CommissionUnitOfMeasure {get; set;}
			
			[TagDetails(Tag = 2645, Type = TagType.String, Offset = 7, Required = false)]
			public string? CommissionUnitOfMeasureCurrency {get; set;}
			
			[TagDetails(Tag = 2924, Type = TagType.String, Offset = 8, Required = false)]
			public string? CommissionUnitOfMeasureCurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 2646, Type = TagType.Float, Offset = 9, Required = false)]
			public double? CommissionRate {get; set;}
			
			[TagDetails(Tag = 2647, Type = TagType.Boolean, Offset = 10, Required = false)]
			public bool? CommissionSharedIndicator {get; set;}
			
			[TagDetails(Tag = 2648, Type = TagType.Float, Offset = 11, Required = false)]
			public double? CommissionAmountShared {get; set;}
			
			[TagDetails(Tag = 2649, Type = TagType.String, Offset = 12, Required = false)]
			public string? CommissionLegRefID {get; set;}
			
			[TagDetails(Tag = 2650, Type = TagType.String, Offset = 13, Required = false)]
			public string? CommissionDesc {get; set;}
			
			[TagDetails(Tag = 2651, Type = TagType.Length, Offset = 14, Required = false)]
			public int? EncodedCommissionDescLen {get; set;}
			
			[TagDetails(Tag = 2652, Type = TagType.RawData, Offset = 15, Required = false)]
			public byte[]? EncodedCommissionDesc {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (CommissionAmount is not null) writer.WriteNumber(2640, CommissionAmount.Value);
				if (CommissionAmountType is not null) writer.WriteWholeNumber(2641, CommissionAmountType.Value);
				if (CommissionAmountSubType is not null) writer.WriteWholeNumber(2725, CommissionAmountSubType.Value);
				if (CommissionBasis is not null) writer.WriteString(2642, CommissionBasis);
				if (CommissionCurrency is not null) writer.WriteString(2643, CommissionCurrency);
				if (CommissionCurrencyCodeSource is not null) writer.WriteString(2923, CommissionCurrencyCodeSource);
				if (CommissionUnitOfMeasure is not null) writer.WriteString(2644, CommissionUnitOfMeasure);
				if (CommissionUnitOfMeasureCurrency is not null) writer.WriteString(2645, CommissionUnitOfMeasureCurrency);
				if (CommissionUnitOfMeasureCurrencyCodeSource is not null) writer.WriteString(2924, CommissionUnitOfMeasureCurrencyCodeSource);
				if (CommissionRate is not null) writer.WriteNumber(2646, CommissionRate.Value);
				if (CommissionSharedIndicator is not null) writer.WriteBoolean(2647, CommissionSharedIndicator.Value);
				if (CommissionAmountShared is not null) writer.WriteNumber(2648, CommissionAmountShared.Value);
				if (CommissionLegRefID is not null) writer.WriteString(2649, CommissionLegRefID);
				if (CommissionDesc is not null) writer.WriteString(2650, CommissionDesc);
				if (EncodedCommissionDescLen is not null) writer.WriteWholeNumber(2651, EncodedCommissionDescLen.Value);
				if (EncodedCommissionDesc is not null) writer.WriteBuffer(2652, EncodedCommissionDesc);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				CommissionAmount = view.GetDouble(2640);
				CommissionAmountType = view.GetInt32(2641);
				CommissionAmountSubType = view.GetInt32(2725);
				CommissionBasis = view.GetString(2642);
				CommissionCurrency = view.GetString(2643);
				CommissionCurrencyCodeSource = view.GetString(2923);
				CommissionUnitOfMeasure = view.GetString(2644);
				CommissionUnitOfMeasureCurrency = view.GetString(2645);
				CommissionUnitOfMeasureCurrencyCodeSource = view.GetString(2924);
				CommissionRate = view.GetDouble(2646);
				CommissionSharedIndicator = view.GetBool(2647);
				CommissionAmountShared = view.GetDouble(2648);
				CommissionLegRefID = view.GetString(2649);
				CommissionDesc = view.GetString(2650);
				EncodedCommissionDescLen = view.GetInt32(2651);
				EncodedCommissionDesc = view.GetByteArray(2652);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "CommissionAmount":
					{
						value = CommissionAmount;
						break;
					}
					case "CommissionAmountType":
					{
						value = CommissionAmountType;
						break;
					}
					case "CommissionAmountSubType":
					{
						value = CommissionAmountSubType;
						break;
					}
					case "CommissionBasis":
					{
						value = CommissionBasis;
						break;
					}
					case "CommissionCurrency":
					{
						value = CommissionCurrency;
						break;
					}
					case "CommissionCurrencyCodeSource":
					{
						value = CommissionCurrencyCodeSource;
						break;
					}
					case "CommissionUnitOfMeasure":
					{
						value = CommissionUnitOfMeasure;
						break;
					}
					case "CommissionUnitOfMeasureCurrency":
					{
						value = CommissionUnitOfMeasureCurrency;
						break;
					}
					case "CommissionUnitOfMeasureCurrencyCodeSource":
					{
						value = CommissionUnitOfMeasureCurrencyCodeSource;
						break;
					}
					case "CommissionRate":
					{
						value = CommissionRate;
						break;
					}
					case "CommissionSharedIndicator":
					{
						value = CommissionSharedIndicator;
						break;
					}
					case "CommissionAmountShared":
					{
						value = CommissionAmountShared;
						break;
					}
					case "CommissionLegRefID":
					{
						value = CommissionLegRefID;
						break;
					}
					case "CommissionDesc":
					{
						value = CommissionDesc;
						break;
					}
					case "EncodedCommissionDescLen":
					{
						value = EncodedCommissionDescLen;
						break;
					}
					case "EncodedCommissionDesc":
					{
						value = EncodedCommissionDesc;
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
				CommissionAmount = null;
				CommissionAmountType = null;
				CommissionAmountSubType = null;
				CommissionBasis = null;
				CommissionCurrency = null;
				CommissionCurrencyCodeSource = null;
				CommissionUnitOfMeasure = null;
				CommissionUnitOfMeasureCurrency = null;
				CommissionUnitOfMeasureCurrencyCodeSource = null;
				CommissionRate = null;
				CommissionSharedIndicator = null;
				CommissionAmountShared = null;
				CommissionLegRefID = null;
				CommissionDesc = null;
				EncodedCommissionDescLen = null;
				EncodedCommissionDesc = null;
			}
		}
		[Group(NoOfTag = 2639, Offset = 0, Required = false)]
		public NoCommissions[]? Commissions {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Commissions is not null && Commissions.Length != 0)
			{
				writer.WriteWholeNumber(2639, Commissions.Length);
				for (int i = 0; i < Commissions.Length; i++)
				{
					((IFixEncoder)Commissions[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoCommissions") is IMessageView viewNoCommissions)
			{
				var count = viewNoCommissions.GroupCount();
				Commissions = new NoCommissions[count];
				for (int i = 0; i < count; i++)
				{
					Commissions[i] = new();
					((IFixParser)Commissions[i]).Parse(viewNoCommissions.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoCommissions":
				{
					value = Commissions;
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
			Commissions = null;
		}
	}
}
