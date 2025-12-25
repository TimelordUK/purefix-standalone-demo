using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class AllocCommissionDataGrp : IFixComponent
	{
		public sealed partial class NoAllocCommissions : IFixGroup
		{
			[TagDetails(Tag = 2654, Type = TagType.Float, Offset = 0, Required = false)]
			public double? AllocCommissionAmount {get; set;}
			
			[TagDetails(Tag = 2655, Type = TagType.Int, Offset = 1, Required = false)]
			public int? AllocCommissionAmountType {get; set;}
			
			[TagDetails(Tag = 2726, Type = TagType.Int, Offset = 2, Required = false)]
			public int? AllocCommissionAmountSubType {get; set;}
			
			[TagDetails(Tag = 2656, Type = TagType.String, Offset = 3, Required = false)]
			public string? AllocCommissionBasis {get; set;}
			
			[TagDetails(Tag = 2657, Type = TagType.String, Offset = 4, Required = false)]
			public string? AllocCommissionCurrency {get; set;}
			
			[TagDetails(Tag = 2925, Type = TagType.String, Offset = 5, Required = false)]
			public string? AllocCommissionCurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 2658, Type = TagType.String, Offset = 6, Required = false)]
			public string? AllocCommissionUnitOfMeasure {get; set;}
			
			[TagDetails(Tag = 2659, Type = TagType.String, Offset = 7, Required = false)]
			public string? AllocCommissionUnitOfMeasureCurrency {get; set;}
			
			[TagDetails(Tag = 2926, Type = TagType.String, Offset = 8, Required = false)]
			public string? AllocCommissionUnitOfMeasureCurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 2660, Type = TagType.Float, Offset = 9, Required = false)]
			public double? AllocCommissionRate {get; set;}
			
			[TagDetails(Tag = 2661, Type = TagType.Boolean, Offset = 10, Required = false)]
			public bool? AllocCommissionSharedIndicator {get; set;}
			
			[TagDetails(Tag = 2662, Type = TagType.Float, Offset = 11, Required = false)]
			public double? AllocCommissionAmountShared {get; set;}
			
			[TagDetails(Tag = 2663, Type = TagType.String, Offset = 12, Required = false)]
			public string? AllocCommissionLegRefID {get; set;}
			
			[TagDetails(Tag = 2664, Type = TagType.String, Offset = 13, Required = false)]
			public string? AllocCommissionDesc {get; set;}
			
			[TagDetails(Tag = 2665, Type = TagType.Length, Offset = 14, Required = false)]
			public int? EncodedAllocCommissionDescLen {get; set;}
			
			[TagDetails(Tag = 2666, Type = TagType.RawData, Offset = 15, Required = false)]
			public byte[]? EncodedAllocCommissionDesc {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (AllocCommissionAmount is not null) writer.WriteNumber(2654, AllocCommissionAmount.Value);
				if (AllocCommissionAmountType is not null) writer.WriteWholeNumber(2655, AllocCommissionAmountType.Value);
				if (AllocCommissionAmountSubType is not null) writer.WriteWholeNumber(2726, AllocCommissionAmountSubType.Value);
				if (AllocCommissionBasis is not null) writer.WriteString(2656, AllocCommissionBasis);
				if (AllocCommissionCurrency is not null) writer.WriteString(2657, AllocCommissionCurrency);
				if (AllocCommissionCurrencyCodeSource is not null) writer.WriteString(2925, AllocCommissionCurrencyCodeSource);
				if (AllocCommissionUnitOfMeasure is not null) writer.WriteString(2658, AllocCommissionUnitOfMeasure);
				if (AllocCommissionUnitOfMeasureCurrency is not null) writer.WriteString(2659, AllocCommissionUnitOfMeasureCurrency);
				if (AllocCommissionUnitOfMeasureCurrencyCodeSource is not null) writer.WriteString(2926, AllocCommissionUnitOfMeasureCurrencyCodeSource);
				if (AllocCommissionRate is not null) writer.WriteNumber(2660, AllocCommissionRate.Value);
				if (AllocCommissionSharedIndicator is not null) writer.WriteBoolean(2661, AllocCommissionSharedIndicator.Value);
				if (AllocCommissionAmountShared is not null) writer.WriteNumber(2662, AllocCommissionAmountShared.Value);
				if (AllocCommissionLegRefID is not null) writer.WriteString(2663, AllocCommissionLegRefID);
				if (AllocCommissionDesc is not null) writer.WriteString(2664, AllocCommissionDesc);
				if (EncodedAllocCommissionDescLen is not null) writer.WriteWholeNumber(2665, EncodedAllocCommissionDescLen.Value);
				if (EncodedAllocCommissionDesc is not null) writer.WriteBuffer(2666, EncodedAllocCommissionDesc);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				AllocCommissionAmount = view.GetDouble(2654);
				AllocCommissionAmountType = view.GetInt32(2655);
				AllocCommissionAmountSubType = view.GetInt32(2726);
				AllocCommissionBasis = view.GetString(2656);
				AllocCommissionCurrency = view.GetString(2657);
				AllocCommissionCurrencyCodeSource = view.GetString(2925);
				AllocCommissionUnitOfMeasure = view.GetString(2658);
				AllocCommissionUnitOfMeasureCurrency = view.GetString(2659);
				AllocCommissionUnitOfMeasureCurrencyCodeSource = view.GetString(2926);
				AllocCommissionRate = view.GetDouble(2660);
				AllocCommissionSharedIndicator = view.GetBool(2661);
				AllocCommissionAmountShared = view.GetDouble(2662);
				AllocCommissionLegRefID = view.GetString(2663);
				AllocCommissionDesc = view.GetString(2664);
				EncodedAllocCommissionDescLen = view.GetInt32(2665);
				EncodedAllocCommissionDesc = view.GetByteArray(2666);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "AllocCommissionAmount":
					{
						value = AllocCommissionAmount;
						break;
					}
					case "AllocCommissionAmountType":
					{
						value = AllocCommissionAmountType;
						break;
					}
					case "AllocCommissionAmountSubType":
					{
						value = AllocCommissionAmountSubType;
						break;
					}
					case "AllocCommissionBasis":
					{
						value = AllocCommissionBasis;
						break;
					}
					case "AllocCommissionCurrency":
					{
						value = AllocCommissionCurrency;
						break;
					}
					case "AllocCommissionCurrencyCodeSource":
					{
						value = AllocCommissionCurrencyCodeSource;
						break;
					}
					case "AllocCommissionUnitOfMeasure":
					{
						value = AllocCommissionUnitOfMeasure;
						break;
					}
					case "AllocCommissionUnitOfMeasureCurrency":
					{
						value = AllocCommissionUnitOfMeasureCurrency;
						break;
					}
					case "AllocCommissionUnitOfMeasureCurrencyCodeSource":
					{
						value = AllocCommissionUnitOfMeasureCurrencyCodeSource;
						break;
					}
					case "AllocCommissionRate":
					{
						value = AllocCommissionRate;
						break;
					}
					case "AllocCommissionSharedIndicator":
					{
						value = AllocCommissionSharedIndicator;
						break;
					}
					case "AllocCommissionAmountShared":
					{
						value = AllocCommissionAmountShared;
						break;
					}
					case "AllocCommissionLegRefID":
					{
						value = AllocCommissionLegRefID;
						break;
					}
					case "AllocCommissionDesc":
					{
						value = AllocCommissionDesc;
						break;
					}
					case "EncodedAllocCommissionDescLen":
					{
						value = EncodedAllocCommissionDescLen;
						break;
					}
					case "EncodedAllocCommissionDesc":
					{
						value = EncodedAllocCommissionDesc;
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
				AllocCommissionAmount = null;
				AllocCommissionAmountType = null;
				AllocCommissionAmountSubType = null;
				AllocCommissionBasis = null;
				AllocCommissionCurrency = null;
				AllocCommissionCurrencyCodeSource = null;
				AllocCommissionUnitOfMeasure = null;
				AllocCommissionUnitOfMeasureCurrency = null;
				AllocCommissionUnitOfMeasureCurrencyCodeSource = null;
				AllocCommissionRate = null;
				AllocCommissionSharedIndicator = null;
				AllocCommissionAmountShared = null;
				AllocCommissionLegRefID = null;
				AllocCommissionDesc = null;
				EncodedAllocCommissionDescLen = null;
				EncodedAllocCommissionDesc = null;
			}
		}
		[Group(NoOfTag = 2653, Offset = 0, Required = false)]
		public NoAllocCommissions[]? AllocCommissions {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (AllocCommissions is not null && AllocCommissions.Length != 0)
			{
				writer.WriteWholeNumber(2653, AllocCommissions.Length);
				for (int i = 0; i < AllocCommissions.Length; i++)
				{
					((IFixEncoder)AllocCommissions[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoAllocCommissions") is IMessageView viewNoAllocCommissions)
			{
				var count = viewNoAllocCommissions.GroupCount();
				AllocCommissions = new NoAllocCommissions[count];
				for (int i = 0; i < count; i++)
				{
					AllocCommissions[i] = new();
					((IFixParser)AllocCommissions[i]).Parse(viewNoAllocCommissions.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoAllocCommissions":
				{
					value = AllocCommissions;
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
			AllocCommissions = null;
		}
	}
}
