using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingAdditionalTermBondRefGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingAdditionalTermBondRefs : IFixGroup
		{
			[TagDetails(Tag = 41341, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingAdditionalTermBondSecurityID {get; set;}
			
			[TagDetails(Tag = 41701, Type = TagType.String, Offset = 1, Required = false)]
			public string? UnderlyingAdditionalTermBondSecurityIDSource {get; set;}
			
			[TagDetails(Tag = 41709, Type = TagType.String, Offset = 2, Required = false)]
			public string? UnderlyingAdditionalTermBondDesc {get; set;}
			
			[TagDetails(Tag = 41710, Type = TagType.Length, Offset = 3, Required = false)]
			public int? EncodedUnderlyingAdditionalTermBondDescLen {get; set;}
			
			[TagDetails(Tag = 41711, Type = TagType.RawData, Offset = 4, Required = false)]
			public byte[]? EncodedUnderlyingAdditionalTermBondDesc {get; set;}
			
			[TagDetails(Tag = 41712, Type = TagType.String, Offset = 5, Required = false)]
			public string? UnderlyingAdditionalTermBondCurrency {get; set;}
			
			[TagDetails(Tag = 42017, Type = TagType.String, Offset = 6, Required = false)]
			public string? UnderlyingAdditionalTermBondIssuer {get; set;}
			
			[TagDetails(Tag = 42025, Type = TagType.Length, Offset = 7, Required = false)]
			public int? EncodedUnderlyingAdditionalTermBondIssuerLen {get; set;}
			
			[TagDetails(Tag = 42026, Type = TagType.RawData, Offset = 8, Required = false)]
			public byte[]? EncodedUnderlyingAdditionalTermBondIssuer {get; set;}
			
			[TagDetails(Tag = 42027, Type = TagType.String, Offset = 9, Required = false)]
			public string? UnderlyingAdditionalTermBondSeniority {get; set;}
			
			[TagDetails(Tag = 42028, Type = TagType.Int, Offset = 10, Required = false)]
			public int? UnderlyingAdditionalTermBondCouponType {get; set;}
			
			[TagDetails(Tag = 42029, Type = TagType.Float, Offset = 11, Required = false)]
			public double? UnderlyingAdditionalTermBondCouponRate {get; set;}
			
			[TagDetails(Tag = 42030, Type = TagType.LocalDate, Offset = 12, Required = false)]
			public DateOnly? UnderlyingAdditionalTermBondMaturityDate {get; set;}
			
			[TagDetails(Tag = 42031, Type = TagType.Float, Offset = 13, Required = false)]
			public double? UnderlyingAdditionalTermBondParValue {get; set;}
			
			[TagDetails(Tag = 42032, Type = TagType.Float, Offset = 14, Required = false)]
			public double? UnderlyingAdditionalTermBondCurrentTotalIssuedAmount {get; set;}
			
			[TagDetails(Tag = 42033, Type = TagType.Int, Offset = 15, Required = false)]
			public int? UnderlyingAdditionalTermBondCouponFrequencyPeriod {get; set;}
			
			[TagDetails(Tag = 42034, Type = TagType.String, Offset = 16, Required = false)]
			public string? UnderlyingAdditionalTermBondCouponFrequencyUnit {get; set;}
			
			[TagDetails(Tag = 42035, Type = TagType.Int, Offset = 17, Required = false)]
			public int? UnderlyingAdditionalTermBondDayCount {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingAdditionalTermBondSecurityID is not null) writer.WriteString(41341, UnderlyingAdditionalTermBondSecurityID);
				if (UnderlyingAdditionalTermBondSecurityIDSource is not null) writer.WriteString(41701, UnderlyingAdditionalTermBondSecurityIDSource);
				if (UnderlyingAdditionalTermBondDesc is not null) writer.WriteString(41709, UnderlyingAdditionalTermBondDesc);
				if (EncodedUnderlyingAdditionalTermBondDescLen is not null) writer.WriteWholeNumber(41710, EncodedUnderlyingAdditionalTermBondDescLen.Value);
				if (EncodedUnderlyingAdditionalTermBondDesc is not null) writer.WriteBuffer(41711, EncodedUnderlyingAdditionalTermBondDesc);
				if (UnderlyingAdditionalTermBondCurrency is not null) writer.WriteString(41712, UnderlyingAdditionalTermBondCurrency);
				if (UnderlyingAdditionalTermBondIssuer is not null) writer.WriteString(42017, UnderlyingAdditionalTermBondIssuer);
				if (EncodedUnderlyingAdditionalTermBondIssuerLen is not null) writer.WriteWholeNumber(42025, EncodedUnderlyingAdditionalTermBondIssuerLen.Value);
				if (EncodedUnderlyingAdditionalTermBondIssuer is not null) writer.WriteBuffer(42026, EncodedUnderlyingAdditionalTermBondIssuer);
				if (UnderlyingAdditionalTermBondSeniority is not null) writer.WriteString(42027, UnderlyingAdditionalTermBondSeniority);
				if (UnderlyingAdditionalTermBondCouponType is not null) writer.WriteWholeNumber(42028, UnderlyingAdditionalTermBondCouponType.Value);
				if (UnderlyingAdditionalTermBondCouponRate is not null) writer.WriteNumber(42029, UnderlyingAdditionalTermBondCouponRate.Value);
				if (UnderlyingAdditionalTermBondMaturityDate is not null) writer.WriteLocalDateOnly(42030, UnderlyingAdditionalTermBondMaturityDate.Value);
				if (UnderlyingAdditionalTermBondParValue is not null) writer.WriteNumber(42031, UnderlyingAdditionalTermBondParValue.Value);
				if (UnderlyingAdditionalTermBondCurrentTotalIssuedAmount is not null) writer.WriteNumber(42032, UnderlyingAdditionalTermBondCurrentTotalIssuedAmount.Value);
				if (UnderlyingAdditionalTermBondCouponFrequencyPeriod is not null) writer.WriteWholeNumber(42033, UnderlyingAdditionalTermBondCouponFrequencyPeriod.Value);
				if (UnderlyingAdditionalTermBondCouponFrequencyUnit is not null) writer.WriteString(42034, UnderlyingAdditionalTermBondCouponFrequencyUnit);
				if (UnderlyingAdditionalTermBondDayCount is not null) writer.WriteWholeNumber(42035, UnderlyingAdditionalTermBondDayCount.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingAdditionalTermBondSecurityID = view.GetString(41341);
				UnderlyingAdditionalTermBondSecurityIDSource = view.GetString(41701);
				UnderlyingAdditionalTermBondDesc = view.GetString(41709);
				EncodedUnderlyingAdditionalTermBondDescLen = view.GetInt32(41710);
				EncodedUnderlyingAdditionalTermBondDesc = view.GetByteArray(41711);
				UnderlyingAdditionalTermBondCurrency = view.GetString(41712);
				UnderlyingAdditionalTermBondIssuer = view.GetString(42017);
				EncodedUnderlyingAdditionalTermBondIssuerLen = view.GetInt32(42025);
				EncodedUnderlyingAdditionalTermBondIssuer = view.GetByteArray(42026);
				UnderlyingAdditionalTermBondSeniority = view.GetString(42027);
				UnderlyingAdditionalTermBondCouponType = view.GetInt32(42028);
				UnderlyingAdditionalTermBondCouponRate = view.GetDouble(42029);
				UnderlyingAdditionalTermBondMaturityDate = view.GetDateOnly(42030);
				UnderlyingAdditionalTermBondParValue = view.GetDouble(42031);
				UnderlyingAdditionalTermBondCurrentTotalIssuedAmount = view.GetDouble(42032);
				UnderlyingAdditionalTermBondCouponFrequencyPeriod = view.GetInt32(42033);
				UnderlyingAdditionalTermBondCouponFrequencyUnit = view.GetString(42034);
				UnderlyingAdditionalTermBondDayCount = view.GetInt32(42035);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingAdditionalTermBondSecurityID":
					{
						value = UnderlyingAdditionalTermBondSecurityID;
						break;
					}
					case "UnderlyingAdditionalTermBondSecurityIDSource":
					{
						value = UnderlyingAdditionalTermBondSecurityIDSource;
						break;
					}
					case "UnderlyingAdditionalTermBondDesc":
					{
						value = UnderlyingAdditionalTermBondDesc;
						break;
					}
					case "EncodedUnderlyingAdditionalTermBondDescLen":
					{
						value = EncodedUnderlyingAdditionalTermBondDescLen;
						break;
					}
					case "EncodedUnderlyingAdditionalTermBondDesc":
					{
						value = EncodedUnderlyingAdditionalTermBondDesc;
						break;
					}
					case "UnderlyingAdditionalTermBondCurrency":
					{
						value = UnderlyingAdditionalTermBondCurrency;
						break;
					}
					case "UnderlyingAdditionalTermBondIssuer":
					{
						value = UnderlyingAdditionalTermBondIssuer;
						break;
					}
					case "EncodedUnderlyingAdditionalTermBondIssuerLen":
					{
						value = EncodedUnderlyingAdditionalTermBondIssuerLen;
						break;
					}
					case "EncodedUnderlyingAdditionalTermBondIssuer":
					{
						value = EncodedUnderlyingAdditionalTermBondIssuer;
						break;
					}
					case "UnderlyingAdditionalTermBondSeniority":
					{
						value = UnderlyingAdditionalTermBondSeniority;
						break;
					}
					case "UnderlyingAdditionalTermBondCouponType":
					{
						value = UnderlyingAdditionalTermBondCouponType;
						break;
					}
					case "UnderlyingAdditionalTermBondCouponRate":
					{
						value = UnderlyingAdditionalTermBondCouponRate;
						break;
					}
					case "UnderlyingAdditionalTermBondMaturityDate":
					{
						value = UnderlyingAdditionalTermBondMaturityDate;
						break;
					}
					case "UnderlyingAdditionalTermBondParValue":
					{
						value = UnderlyingAdditionalTermBondParValue;
						break;
					}
					case "UnderlyingAdditionalTermBondCurrentTotalIssuedAmount":
					{
						value = UnderlyingAdditionalTermBondCurrentTotalIssuedAmount;
						break;
					}
					case "UnderlyingAdditionalTermBondCouponFrequencyPeriod":
					{
						value = UnderlyingAdditionalTermBondCouponFrequencyPeriod;
						break;
					}
					case "UnderlyingAdditionalTermBondCouponFrequencyUnit":
					{
						value = UnderlyingAdditionalTermBondCouponFrequencyUnit;
						break;
					}
					case "UnderlyingAdditionalTermBondDayCount":
					{
						value = UnderlyingAdditionalTermBondDayCount;
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
				UnderlyingAdditionalTermBondSecurityID = null;
				UnderlyingAdditionalTermBondSecurityIDSource = null;
				UnderlyingAdditionalTermBondDesc = null;
				EncodedUnderlyingAdditionalTermBondDescLen = null;
				EncodedUnderlyingAdditionalTermBondDesc = null;
				UnderlyingAdditionalTermBondCurrency = null;
				UnderlyingAdditionalTermBondIssuer = null;
				EncodedUnderlyingAdditionalTermBondIssuerLen = null;
				EncodedUnderlyingAdditionalTermBondIssuer = null;
				UnderlyingAdditionalTermBondSeniority = null;
				UnderlyingAdditionalTermBondCouponType = null;
				UnderlyingAdditionalTermBondCouponRate = null;
				UnderlyingAdditionalTermBondMaturityDate = null;
				UnderlyingAdditionalTermBondParValue = null;
				UnderlyingAdditionalTermBondCurrentTotalIssuedAmount = null;
				UnderlyingAdditionalTermBondCouponFrequencyPeriod = null;
				UnderlyingAdditionalTermBondCouponFrequencyUnit = null;
				UnderlyingAdditionalTermBondDayCount = null;
			}
		}
		[Group(NoOfTag = 41340, Offset = 0, Required = false)]
		public NoUnderlyingAdditionalTermBondRefs[]? UnderlyingAdditionalTermBondRefs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingAdditionalTermBondRefs is not null && UnderlyingAdditionalTermBondRefs.Length != 0)
			{
				writer.WriteWholeNumber(41340, UnderlyingAdditionalTermBondRefs.Length);
				for (int i = 0; i < UnderlyingAdditionalTermBondRefs.Length; i++)
				{
					((IFixEncoder)UnderlyingAdditionalTermBondRefs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingAdditionalTermBondRefs") is IMessageView viewNoUnderlyingAdditionalTermBondRefs)
			{
				var count = viewNoUnderlyingAdditionalTermBondRefs.GroupCount();
				UnderlyingAdditionalTermBondRefs = new NoUnderlyingAdditionalTermBondRefs[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingAdditionalTermBondRefs[i] = new();
					((IFixParser)UnderlyingAdditionalTermBondRefs[i]).Parse(viewNoUnderlyingAdditionalTermBondRefs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingAdditionalTermBondRefs":
				{
					value = UnderlyingAdditionalTermBondRefs;
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
			UnderlyingAdditionalTermBondRefs = null;
		}
	}
}
