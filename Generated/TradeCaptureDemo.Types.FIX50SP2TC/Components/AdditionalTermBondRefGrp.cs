using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class AdditionalTermBondRefGrp : IFixComponent
	{
		public sealed partial class NoAdditionalTermBondRefs : IFixGroup
		{
			[TagDetails(Tag = 40001, Type = TagType.String, Offset = 0, Required = false)]
			public string? AdditionalTermBondSecurityID {get; set;}
			
			[TagDetails(Tag = 40002, Type = TagType.String, Offset = 1, Required = false)]
			public string? AdditionalTermBondSecurityIDSource {get; set;}
			
			[TagDetails(Tag = 40003, Type = TagType.String, Offset = 2, Required = false)]
			public string? AdditionalTermBondDesc {get; set;}
			
			[TagDetails(Tag = 40004, Type = TagType.Length, Offset = 3, Required = false)]
			public int? EncodedAdditionalTermBondDescLen {get; set;}
			
			[TagDetails(Tag = 40005, Type = TagType.RawData, Offset = 4, Required = false)]
			public byte[]? EncodedAdditionalTermBondDesc {get; set;}
			
			[TagDetails(Tag = 40006, Type = TagType.String, Offset = 5, Required = false)]
			public string? AdditionalTermBondCurrency {get; set;}
			
			[TagDetails(Tag = 40007, Type = TagType.String, Offset = 6, Required = false)]
			public string? AdditionalTermBondIssuer {get; set;}
			
			[TagDetails(Tag = 40008, Type = TagType.Length, Offset = 7, Required = false)]
			public int? EncodedAdditionalTermBondIssuerLen {get; set;}
			
			[TagDetails(Tag = 40009, Type = TagType.RawData, Offset = 8, Required = false)]
			public byte[]? EncodedAdditionalTermBondIssuer {get; set;}
			
			[TagDetails(Tag = 40010, Type = TagType.String, Offset = 9, Required = false)]
			public string? AdditionalTermBondSeniority {get; set;}
			
			[TagDetails(Tag = 40011, Type = TagType.Int, Offset = 10, Required = false)]
			public int? AdditionalTermBondCouponType {get; set;}
			
			[TagDetails(Tag = 40012, Type = TagType.Float, Offset = 11, Required = false)]
			public double? AdditionalTermBondCouponRate {get; set;}
			
			[TagDetails(Tag = 40013, Type = TagType.LocalDate, Offset = 12, Required = false)]
			public DateOnly? AdditionalTermBondMaturityDate {get; set;}
			
			[TagDetails(Tag = 40014, Type = TagType.Float, Offset = 13, Required = false)]
			public double? AdditionalTermBondParValue {get; set;}
			
			[TagDetails(Tag = 40015, Type = TagType.Float, Offset = 14, Required = false)]
			public double? AdditionalTermBondCurrentTotalIssuedAmount {get; set;}
			
			[TagDetails(Tag = 40016, Type = TagType.Int, Offset = 15, Required = false)]
			public int? AdditionalTermBondCouponFrequencyPeriod {get; set;}
			
			[TagDetails(Tag = 40017, Type = TagType.String, Offset = 16, Required = false)]
			public string? AdditionalTermBondCouponFrequencyUnit {get; set;}
			
			[TagDetails(Tag = 40018, Type = TagType.Int, Offset = 17, Required = false)]
			public int? AdditionalTermBondDayCount {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (AdditionalTermBondSecurityID is not null) writer.WriteString(40001, AdditionalTermBondSecurityID);
				if (AdditionalTermBondSecurityIDSource is not null) writer.WriteString(40002, AdditionalTermBondSecurityIDSource);
				if (AdditionalTermBondDesc is not null) writer.WriteString(40003, AdditionalTermBondDesc);
				if (EncodedAdditionalTermBondDescLen is not null) writer.WriteWholeNumber(40004, EncodedAdditionalTermBondDescLen.Value);
				if (EncodedAdditionalTermBondDesc is not null) writer.WriteBuffer(40005, EncodedAdditionalTermBondDesc);
				if (AdditionalTermBondCurrency is not null) writer.WriteString(40006, AdditionalTermBondCurrency);
				if (AdditionalTermBondIssuer is not null) writer.WriteString(40007, AdditionalTermBondIssuer);
				if (EncodedAdditionalTermBondIssuerLen is not null) writer.WriteWholeNumber(40008, EncodedAdditionalTermBondIssuerLen.Value);
				if (EncodedAdditionalTermBondIssuer is not null) writer.WriteBuffer(40009, EncodedAdditionalTermBondIssuer);
				if (AdditionalTermBondSeniority is not null) writer.WriteString(40010, AdditionalTermBondSeniority);
				if (AdditionalTermBondCouponType is not null) writer.WriteWholeNumber(40011, AdditionalTermBondCouponType.Value);
				if (AdditionalTermBondCouponRate is not null) writer.WriteNumber(40012, AdditionalTermBondCouponRate.Value);
				if (AdditionalTermBondMaturityDate is not null) writer.WriteLocalDateOnly(40013, AdditionalTermBondMaturityDate.Value);
				if (AdditionalTermBondParValue is not null) writer.WriteNumber(40014, AdditionalTermBondParValue.Value);
				if (AdditionalTermBondCurrentTotalIssuedAmount is not null) writer.WriteNumber(40015, AdditionalTermBondCurrentTotalIssuedAmount.Value);
				if (AdditionalTermBondCouponFrequencyPeriod is not null) writer.WriteWholeNumber(40016, AdditionalTermBondCouponFrequencyPeriod.Value);
				if (AdditionalTermBondCouponFrequencyUnit is not null) writer.WriteString(40017, AdditionalTermBondCouponFrequencyUnit);
				if (AdditionalTermBondDayCount is not null) writer.WriteWholeNumber(40018, AdditionalTermBondDayCount.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				AdditionalTermBondSecurityID = view.GetString(40001);
				AdditionalTermBondSecurityIDSource = view.GetString(40002);
				AdditionalTermBondDesc = view.GetString(40003);
				EncodedAdditionalTermBondDescLen = view.GetInt32(40004);
				EncodedAdditionalTermBondDesc = view.GetByteArray(40005);
				AdditionalTermBondCurrency = view.GetString(40006);
				AdditionalTermBondIssuer = view.GetString(40007);
				EncodedAdditionalTermBondIssuerLen = view.GetInt32(40008);
				EncodedAdditionalTermBondIssuer = view.GetByteArray(40009);
				AdditionalTermBondSeniority = view.GetString(40010);
				AdditionalTermBondCouponType = view.GetInt32(40011);
				AdditionalTermBondCouponRate = view.GetDouble(40012);
				AdditionalTermBondMaturityDate = view.GetDateOnly(40013);
				AdditionalTermBondParValue = view.GetDouble(40014);
				AdditionalTermBondCurrentTotalIssuedAmount = view.GetDouble(40015);
				AdditionalTermBondCouponFrequencyPeriod = view.GetInt32(40016);
				AdditionalTermBondCouponFrequencyUnit = view.GetString(40017);
				AdditionalTermBondDayCount = view.GetInt32(40018);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "AdditionalTermBondSecurityID":
					{
						value = AdditionalTermBondSecurityID;
						break;
					}
					case "AdditionalTermBondSecurityIDSource":
					{
						value = AdditionalTermBondSecurityIDSource;
						break;
					}
					case "AdditionalTermBondDesc":
					{
						value = AdditionalTermBondDesc;
						break;
					}
					case "EncodedAdditionalTermBondDescLen":
					{
						value = EncodedAdditionalTermBondDescLen;
						break;
					}
					case "EncodedAdditionalTermBondDesc":
					{
						value = EncodedAdditionalTermBondDesc;
						break;
					}
					case "AdditionalTermBondCurrency":
					{
						value = AdditionalTermBondCurrency;
						break;
					}
					case "AdditionalTermBondIssuer":
					{
						value = AdditionalTermBondIssuer;
						break;
					}
					case "EncodedAdditionalTermBondIssuerLen":
					{
						value = EncodedAdditionalTermBondIssuerLen;
						break;
					}
					case "EncodedAdditionalTermBondIssuer":
					{
						value = EncodedAdditionalTermBondIssuer;
						break;
					}
					case "AdditionalTermBondSeniority":
					{
						value = AdditionalTermBondSeniority;
						break;
					}
					case "AdditionalTermBondCouponType":
					{
						value = AdditionalTermBondCouponType;
						break;
					}
					case "AdditionalTermBondCouponRate":
					{
						value = AdditionalTermBondCouponRate;
						break;
					}
					case "AdditionalTermBondMaturityDate":
					{
						value = AdditionalTermBondMaturityDate;
						break;
					}
					case "AdditionalTermBondParValue":
					{
						value = AdditionalTermBondParValue;
						break;
					}
					case "AdditionalTermBondCurrentTotalIssuedAmount":
					{
						value = AdditionalTermBondCurrentTotalIssuedAmount;
						break;
					}
					case "AdditionalTermBondCouponFrequencyPeriod":
					{
						value = AdditionalTermBondCouponFrequencyPeriod;
						break;
					}
					case "AdditionalTermBondCouponFrequencyUnit":
					{
						value = AdditionalTermBondCouponFrequencyUnit;
						break;
					}
					case "AdditionalTermBondDayCount":
					{
						value = AdditionalTermBondDayCount;
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
				AdditionalTermBondSecurityID = null;
				AdditionalTermBondSecurityIDSource = null;
				AdditionalTermBondDesc = null;
				EncodedAdditionalTermBondDescLen = null;
				EncodedAdditionalTermBondDesc = null;
				AdditionalTermBondCurrency = null;
				AdditionalTermBondIssuer = null;
				EncodedAdditionalTermBondIssuerLen = null;
				EncodedAdditionalTermBondIssuer = null;
				AdditionalTermBondSeniority = null;
				AdditionalTermBondCouponType = null;
				AdditionalTermBondCouponRate = null;
				AdditionalTermBondMaturityDate = null;
				AdditionalTermBondParValue = null;
				AdditionalTermBondCurrentTotalIssuedAmount = null;
				AdditionalTermBondCouponFrequencyPeriod = null;
				AdditionalTermBondCouponFrequencyUnit = null;
				AdditionalTermBondDayCount = null;
			}
		}
		[Group(NoOfTag = 40000, Offset = 0, Required = false)]
		public NoAdditionalTermBondRefs[]? AdditionalTermBondRefs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (AdditionalTermBondRefs is not null && AdditionalTermBondRefs.Length != 0)
			{
				writer.WriteWholeNumber(40000, AdditionalTermBondRefs.Length);
				for (int i = 0; i < AdditionalTermBondRefs.Length; i++)
				{
					((IFixEncoder)AdditionalTermBondRefs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoAdditionalTermBondRefs") is IMessageView viewNoAdditionalTermBondRefs)
			{
				var count = viewNoAdditionalTermBondRefs.GroupCount();
				AdditionalTermBondRefs = new NoAdditionalTermBondRefs[count];
				for (int i = 0; i < count; i++)
				{
					AdditionalTermBondRefs[i] = new();
					((IFixParser)AdditionalTermBondRefs[i]).Parse(viewNoAdditionalTermBondRefs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoAdditionalTermBondRefs":
				{
					value = AdditionalTermBondRefs;
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
			AdditionalTermBondRefs = null;
		}
	}
}
