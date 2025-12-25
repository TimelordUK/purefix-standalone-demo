using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStubEndDate : IFixComponent
	{
		[TagDetails(Tag = 42984, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? UnderlyingPaymentStubEndDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42985, Type = TagType.Int, Offset = 1, Required = false)]
		public int? UnderlyingPaymentStubEndDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public UnderlyingPaymentStubEndDateBusinessCenterGrp? UnderlyingPaymentStubEndDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 42986, Type = TagType.Int, Offset = 3, Required = false)]
		public int? UnderlyingPaymentStubEndDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42987, Type = TagType.Int, Offset = 4, Required = false)]
		public int? UnderlyingPaymentStubEndDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42988, Type = TagType.String, Offset = 5, Required = false)]
		public string? UnderlyingPaymentStubEndDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42989, Type = TagType.Int, Offset = 6, Required = false)]
		public int? UnderlyingPaymentStubEndDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42990, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? UnderlyingPaymentStubEndDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStubEndDateUnadjusted is not null) writer.WriteLocalDateOnly(42984, UnderlyingPaymentStubEndDateUnadjusted.Value);
			if (UnderlyingPaymentStubEndDateBusinessDayConvention is not null) writer.WriteWholeNumber(42985, UnderlyingPaymentStubEndDateBusinessDayConvention.Value);
			if (UnderlyingPaymentStubEndDateBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingPaymentStubEndDateBusinessCenterGrp).Encode(writer);
			if (UnderlyingPaymentStubEndDateRelativeTo is not null) writer.WriteWholeNumber(42986, UnderlyingPaymentStubEndDateRelativeTo.Value);
			if (UnderlyingPaymentStubEndDateOffsetPeriod is not null) writer.WriteWholeNumber(42987, UnderlyingPaymentStubEndDateOffsetPeriod.Value);
			if (UnderlyingPaymentStubEndDateOffsetUnit is not null) writer.WriteString(42988, UnderlyingPaymentStubEndDateOffsetUnit);
			if (UnderlyingPaymentStubEndDateOffsetDayType is not null) writer.WriteWholeNumber(42989, UnderlyingPaymentStubEndDateOffsetDayType.Value);
			if (UnderlyingPaymentStubEndDateAdjusted is not null) writer.WriteLocalDateOnly(42990, UnderlyingPaymentStubEndDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingPaymentStubEndDateUnadjusted = view.GetDateOnly(42984);
			UnderlyingPaymentStubEndDateBusinessDayConvention = view.GetInt32(42985);
			if (view.GetView("UnderlyingPaymentStubEndDateBusinessCenterGrp") is IMessageView viewUnderlyingPaymentStubEndDateBusinessCenterGrp)
			{
				UnderlyingPaymentStubEndDateBusinessCenterGrp = new();
				((IFixParser)UnderlyingPaymentStubEndDateBusinessCenterGrp).Parse(viewUnderlyingPaymentStubEndDateBusinessCenterGrp);
			}
			UnderlyingPaymentStubEndDateRelativeTo = view.GetInt32(42986);
			UnderlyingPaymentStubEndDateOffsetPeriod = view.GetInt32(42987);
			UnderlyingPaymentStubEndDateOffsetUnit = view.GetString(42988);
			UnderlyingPaymentStubEndDateOffsetDayType = view.GetInt32(42989);
			UnderlyingPaymentStubEndDateAdjusted = view.GetDateOnly(42990);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingPaymentStubEndDateUnadjusted":
				{
					value = UnderlyingPaymentStubEndDateUnadjusted;
					break;
				}
				case "UnderlyingPaymentStubEndDateBusinessDayConvention":
				{
					value = UnderlyingPaymentStubEndDateBusinessDayConvention;
					break;
				}
				case "UnderlyingPaymentStubEndDateBusinessCenterGrp":
				{
					value = UnderlyingPaymentStubEndDateBusinessCenterGrp;
					break;
				}
				case "UnderlyingPaymentStubEndDateRelativeTo":
				{
					value = UnderlyingPaymentStubEndDateRelativeTo;
					break;
				}
				case "UnderlyingPaymentStubEndDateOffsetPeriod":
				{
					value = UnderlyingPaymentStubEndDateOffsetPeriod;
					break;
				}
				case "UnderlyingPaymentStubEndDateOffsetUnit":
				{
					value = UnderlyingPaymentStubEndDateOffsetUnit;
					break;
				}
				case "UnderlyingPaymentStubEndDateOffsetDayType":
				{
					value = UnderlyingPaymentStubEndDateOffsetDayType;
					break;
				}
				case "UnderlyingPaymentStubEndDateAdjusted":
				{
					value = UnderlyingPaymentStubEndDateAdjusted;
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
			UnderlyingPaymentStubEndDateUnadjusted = null;
			UnderlyingPaymentStubEndDateBusinessDayConvention = null;
			((IFixReset?)UnderlyingPaymentStubEndDateBusinessCenterGrp)?.Reset();
			UnderlyingPaymentStubEndDateRelativeTo = null;
			UnderlyingPaymentStubEndDateOffsetPeriod = null;
			UnderlyingPaymentStubEndDateOffsetUnit = null;
			UnderlyingPaymentStubEndDateOffsetDayType = null;
			UnderlyingPaymentStubEndDateAdjusted = null;
		}
	}
}
