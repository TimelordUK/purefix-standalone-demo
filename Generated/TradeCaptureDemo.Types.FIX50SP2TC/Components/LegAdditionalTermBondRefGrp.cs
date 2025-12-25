using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegAdditionalTermBondRefGrp : IFixComponent
	{
		public sealed partial class NoLegAdditionalTermBondRefs : IFixGroup
		{
			[TagDetails(Tag = 41317, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegAdditionalTermBondSecurityID {get; set;}
			
			[TagDetails(Tag = 41318, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegAdditionalTermBondSecurityIDSource {get; set;}
			
			[TagDetails(Tag = 41319, Type = TagType.String, Offset = 2, Required = false)]
			public string? LegAdditionalTermBondDesc {get; set;}
			
			[TagDetails(Tag = 41320, Type = TagType.Length, Offset = 3, Required = false)]
			public int? EncodedLegAdditionalTermBondDescLen {get; set;}
			
			[TagDetails(Tag = 41321, Type = TagType.RawData, Offset = 4, Required = false)]
			public byte[]? EncodedLegAdditionalTermBondDesc {get; set;}
			
			[TagDetails(Tag = 41322, Type = TagType.String, Offset = 5, Required = false)]
			public string? LegAdditionalTermBondCurrency {get; set;}
			
			[TagDetails(Tag = 41323, Type = TagType.String, Offset = 6, Required = false)]
			public string? LegAdditionalTermBondIssuer {get; set;}
			
			[TagDetails(Tag = 41324, Type = TagType.Length, Offset = 7, Required = false)]
			public int? EncodedLegAdditionalTermBondIssuerLen {get; set;}
			
			[TagDetails(Tag = 41325, Type = TagType.RawData, Offset = 8, Required = false)]
			public byte[]? EncodedLegAdditionalTermBondIssuer {get; set;}
			
			[TagDetails(Tag = 41326, Type = TagType.String, Offset = 9, Required = false)]
			public string? LegAdditionalTermBondSeniority {get; set;}
			
			[TagDetails(Tag = 41327, Type = TagType.Int, Offset = 10, Required = false)]
			public int? LegAdditionalTermBondCouponType {get; set;}
			
			[TagDetails(Tag = 41328, Type = TagType.Float, Offset = 11, Required = false)]
			public double? LegAdditionalTermBondCouponRate {get; set;}
			
			[TagDetails(Tag = 41329, Type = TagType.LocalDate, Offset = 12, Required = false)]
			public DateOnly? LegAdditionalTermBondMaturityDate {get; set;}
			
			[TagDetails(Tag = 41330, Type = TagType.Float, Offset = 13, Required = false)]
			public double? LegAdditionalTermBondParValue {get; set;}
			
			[TagDetails(Tag = 41331, Type = TagType.Float, Offset = 14, Required = false)]
			public double? LegAdditionalTermBondCurrentTotalIssuedAmount {get; set;}
			
			[TagDetails(Tag = 41332, Type = TagType.Int, Offset = 15, Required = false)]
			public int? LegAdditionalTermBondCouponFrequencyPeriod {get; set;}
			
			[TagDetails(Tag = 41333, Type = TagType.String, Offset = 16, Required = false)]
			public string? LegAdditionalTermBondCouponFrequencyUnit {get; set;}
			
			[TagDetails(Tag = 41334, Type = TagType.Int, Offset = 17, Required = false)]
			public int? LegAdditionalTermBondDayCount {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegAdditionalTermBondSecurityID is not null) writer.WriteString(41317, LegAdditionalTermBondSecurityID);
				if (LegAdditionalTermBondSecurityIDSource is not null) writer.WriteString(41318, LegAdditionalTermBondSecurityIDSource);
				if (LegAdditionalTermBondDesc is not null) writer.WriteString(41319, LegAdditionalTermBondDesc);
				if (EncodedLegAdditionalTermBondDescLen is not null) writer.WriteWholeNumber(41320, EncodedLegAdditionalTermBondDescLen.Value);
				if (EncodedLegAdditionalTermBondDesc is not null) writer.WriteBuffer(41321, EncodedLegAdditionalTermBondDesc);
				if (LegAdditionalTermBondCurrency is not null) writer.WriteString(41322, LegAdditionalTermBondCurrency);
				if (LegAdditionalTermBondIssuer is not null) writer.WriteString(41323, LegAdditionalTermBondIssuer);
				if (EncodedLegAdditionalTermBondIssuerLen is not null) writer.WriteWholeNumber(41324, EncodedLegAdditionalTermBondIssuerLen.Value);
				if (EncodedLegAdditionalTermBondIssuer is not null) writer.WriteBuffer(41325, EncodedLegAdditionalTermBondIssuer);
				if (LegAdditionalTermBondSeniority is not null) writer.WriteString(41326, LegAdditionalTermBondSeniority);
				if (LegAdditionalTermBondCouponType is not null) writer.WriteWholeNumber(41327, LegAdditionalTermBondCouponType.Value);
				if (LegAdditionalTermBondCouponRate is not null) writer.WriteNumber(41328, LegAdditionalTermBondCouponRate.Value);
				if (LegAdditionalTermBondMaturityDate is not null) writer.WriteLocalDateOnly(41329, LegAdditionalTermBondMaturityDate.Value);
				if (LegAdditionalTermBondParValue is not null) writer.WriteNumber(41330, LegAdditionalTermBondParValue.Value);
				if (LegAdditionalTermBondCurrentTotalIssuedAmount is not null) writer.WriteNumber(41331, LegAdditionalTermBondCurrentTotalIssuedAmount.Value);
				if (LegAdditionalTermBondCouponFrequencyPeriod is not null) writer.WriteWholeNumber(41332, LegAdditionalTermBondCouponFrequencyPeriod.Value);
				if (LegAdditionalTermBondCouponFrequencyUnit is not null) writer.WriteString(41333, LegAdditionalTermBondCouponFrequencyUnit);
				if (LegAdditionalTermBondDayCount is not null) writer.WriteWholeNumber(41334, LegAdditionalTermBondDayCount.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegAdditionalTermBondSecurityID = view.GetString(41317);
				LegAdditionalTermBondSecurityIDSource = view.GetString(41318);
				LegAdditionalTermBondDesc = view.GetString(41319);
				EncodedLegAdditionalTermBondDescLen = view.GetInt32(41320);
				EncodedLegAdditionalTermBondDesc = view.GetByteArray(41321);
				LegAdditionalTermBondCurrency = view.GetString(41322);
				LegAdditionalTermBondIssuer = view.GetString(41323);
				EncodedLegAdditionalTermBondIssuerLen = view.GetInt32(41324);
				EncodedLegAdditionalTermBondIssuer = view.GetByteArray(41325);
				LegAdditionalTermBondSeniority = view.GetString(41326);
				LegAdditionalTermBondCouponType = view.GetInt32(41327);
				LegAdditionalTermBondCouponRate = view.GetDouble(41328);
				LegAdditionalTermBondMaturityDate = view.GetDateOnly(41329);
				LegAdditionalTermBondParValue = view.GetDouble(41330);
				LegAdditionalTermBondCurrentTotalIssuedAmount = view.GetDouble(41331);
				LegAdditionalTermBondCouponFrequencyPeriod = view.GetInt32(41332);
				LegAdditionalTermBondCouponFrequencyUnit = view.GetString(41333);
				LegAdditionalTermBondDayCount = view.GetInt32(41334);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegAdditionalTermBondSecurityID":
					{
						value = LegAdditionalTermBondSecurityID;
						break;
					}
					case "LegAdditionalTermBondSecurityIDSource":
					{
						value = LegAdditionalTermBondSecurityIDSource;
						break;
					}
					case "LegAdditionalTermBondDesc":
					{
						value = LegAdditionalTermBondDesc;
						break;
					}
					case "EncodedLegAdditionalTermBondDescLen":
					{
						value = EncodedLegAdditionalTermBondDescLen;
						break;
					}
					case "EncodedLegAdditionalTermBondDesc":
					{
						value = EncodedLegAdditionalTermBondDesc;
						break;
					}
					case "LegAdditionalTermBondCurrency":
					{
						value = LegAdditionalTermBondCurrency;
						break;
					}
					case "LegAdditionalTermBondIssuer":
					{
						value = LegAdditionalTermBondIssuer;
						break;
					}
					case "EncodedLegAdditionalTermBondIssuerLen":
					{
						value = EncodedLegAdditionalTermBondIssuerLen;
						break;
					}
					case "EncodedLegAdditionalTermBondIssuer":
					{
						value = EncodedLegAdditionalTermBondIssuer;
						break;
					}
					case "LegAdditionalTermBondSeniority":
					{
						value = LegAdditionalTermBondSeniority;
						break;
					}
					case "LegAdditionalTermBondCouponType":
					{
						value = LegAdditionalTermBondCouponType;
						break;
					}
					case "LegAdditionalTermBondCouponRate":
					{
						value = LegAdditionalTermBondCouponRate;
						break;
					}
					case "LegAdditionalTermBondMaturityDate":
					{
						value = LegAdditionalTermBondMaturityDate;
						break;
					}
					case "LegAdditionalTermBondParValue":
					{
						value = LegAdditionalTermBondParValue;
						break;
					}
					case "LegAdditionalTermBondCurrentTotalIssuedAmount":
					{
						value = LegAdditionalTermBondCurrentTotalIssuedAmount;
						break;
					}
					case "LegAdditionalTermBondCouponFrequencyPeriod":
					{
						value = LegAdditionalTermBondCouponFrequencyPeriod;
						break;
					}
					case "LegAdditionalTermBondCouponFrequencyUnit":
					{
						value = LegAdditionalTermBondCouponFrequencyUnit;
						break;
					}
					case "LegAdditionalTermBondDayCount":
					{
						value = LegAdditionalTermBondDayCount;
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
				LegAdditionalTermBondSecurityID = null;
				LegAdditionalTermBondSecurityIDSource = null;
				LegAdditionalTermBondDesc = null;
				EncodedLegAdditionalTermBondDescLen = null;
				EncodedLegAdditionalTermBondDesc = null;
				LegAdditionalTermBondCurrency = null;
				LegAdditionalTermBondIssuer = null;
				EncodedLegAdditionalTermBondIssuerLen = null;
				EncodedLegAdditionalTermBondIssuer = null;
				LegAdditionalTermBondSeniority = null;
				LegAdditionalTermBondCouponType = null;
				LegAdditionalTermBondCouponRate = null;
				LegAdditionalTermBondMaturityDate = null;
				LegAdditionalTermBondParValue = null;
				LegAdditionalTermBondCurrentTotalIssuedAmount = null;
				LegAdditionalTermBondCouponFrequencyPeriod = null;
				LegAdditionalTermBondCouponFrequencyUnit = null;
				LegAdditionalTermBondDayCount = null;
			}
		}
		[Group(NoOfTag = 41316, Offset = 0, Required = false)]
		public NoLegAdditionalTermBondRefs[]? LegAdditionalTermBondRefs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegAdditionalTermBondRefs is not null && LegAdditionalTermBondRefs.Length != 0)
			{
				writer.WriteWholeNumber(41316, LegAdditionalTermBondRefs.Length);
				for (int i = 0; i < LegAdditionalTermBondRefs.Length; i++)
				{
					((IFixEncoder)LegAdditionalTermBondRefs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegAdditionalTermBondRefs") is IMessageView viewNoLegAdditionalTermBondRefs)
			{
				var count = viewNoLegAdditionalTermBondRefs.GroupCount();
				LegAdditionalTermBondRefs = new NoLegAdditionalTermBondRefs[count];
				for (int i = 0; i < count; i++)
				{
					LegAdditionalTermBondRefs[i] = new();
					((IFixParser)LegAdditionalTermBondRefs[i]).Parse(viewNoLegAdditionalTermBondRefs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegAdditionalTermBondRefs":
				{
					value = LegAdditionalTermBondRefs;
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
			LegAdditionalTermBondRefs = null;
		}
	}
}
