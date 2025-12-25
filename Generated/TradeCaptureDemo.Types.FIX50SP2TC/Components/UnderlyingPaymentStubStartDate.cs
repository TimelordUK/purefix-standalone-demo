using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStubStartDate : IFixComponent
	{
		[TagDetails(Tag = 42993, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? UnderlyingPaymentStubStartDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42994, Type = TagType.Int, Offset = 1, Required = false)]
		public int? UnderlyingPaymentStubStartDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public UnderlyingPaymentStubStartDateBusinessCenterGrp? UnderlyingPaymentStubStartDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 42995, Type = TagType.Int, Offset = 3, Required = false)]
		public int? UnderlyingPaymentStubStartDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42996, Type = TagType.Int, Offset = 4, Required = false)]
		public int? UnderlyingPaymentStubStartDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42997, Type = TagType.String, Offset = 5, Required = false)]
		public string? UnderlyingPaymentStubStartDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42998, Type = TagType.Int, Offset = 6, Required = false)]
		public int? UnderlyingPaymentStubStartDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42999, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? UnderlyingPaymentStubStartDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStubStartDateUnadjusted is not null) writer.WriteLocalDateOnly(42993, UnderlyingPaymentStubStartDateUnadjusted.Value);
			if (UnderlyingPaymentStubStartDateBusinessDayConvention is not null) writer.WriteWholeNumber(42994, UnderlyingPaymentStubStartDateBusinessDayConvention.Value);
			if (UnderlyingPaymentStubStartDateBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingPaymentStubStartDateBusinessCenterGrp).Encode(writer);
			if (UnderlyingPaymentStubStartDateRelativeTo is not null) writer.WriteWholeNumber(42995, UnderlyingPaymentStubStartDateRelativeTo.Value);
			if (UnderlyingPaymentStubStartDateOffsetPeriod is not null) writer.WriteWholeNumber(42996, UnderlyingPaymentStubStartDateOffsetPeriod.Value);
			if (UnderlyingPaymentStubStartDateOffsetUnit is not null) writer.WriteString(42997, UnderlyingPaymentStubStartDateOffsetUnit);
			if (UnderlyingPaymentStubStartDateOffsetDayType is not null) writer.WriteWholeNumber(42998, UnderlyingPaymentStubStartDateOffsetDayType.Value);
			if (UnderlyingPaymentStubStartDateAdjusted is not null) writer.WriteLocalDateOnly(42999, UnderlyingPaymentStubStartDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingPaymentStubStartDateUnadjusted = view.GetDateOnly(42993);
			UnderlyingPaymentStubStartDateBusinessDayConvention = view.GetInt32(42994);
			if (view.GetView("UnderlyingPaymentStubStartDateBusinessCenterGrp") is IMessageView viewUnderlyingPaymentStubStartDateBusinessCenterGrp)
			{
				UnderlyingPaymentStubStartDateBusinessCenterGrp = new();
				((IFixParser)UnderlyingPaymentStubStartDateBusinessCenterGrp).Parse(viewUnderlyingPaymentStubStartDateBusinessCenterGrp);
			}
			UnderlyingPaymentStubStartDateRelativeTo = view.GetInt32(42995);
			UnderlyingPaymentStubStartDateOffsetPeriod = view.GetInt32(42996);
			UnderlyingPaymentStubStartDateOffsetUnit = view.GetString(42997);
			UnderlyingPaymentStubStartDateOffsetDayType = view.GetInt32(42998);
			UnderlyingPaymentStubStartDateAdjusted = view.GetDateOnly(42999);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingPaymentStubStartDateUnadjusted":
				{
					value = UnderlyingPaymentStubStartDateUnadjusted;
					break;
				}
				case "UnderlyingPaymentStubStartDateBusinessDayConvention":
				{
					value = UnderlyingPaymentStubStartDateBusinessDayConvention;
					break;
				}
				case "UnderlyingPaymentStubStartDateBusinessCenterGrp":
				{
					value = UnderlyingPaymentStubStartDateBusinessCenterGrp;
					break;
				}
				case "UnderlyingPaymentStubStartDateRelativeTo":
				{
					value = UnderlyingPaymentStubStartDateRelativeTo;
					break;
				}
				case "UnderlyingPaymentStubStartDateOffsetPeriod":
				{
					value = UnderlyingPaymentStubStartDateOffsetPeriod;
					break;
				}
				case "UnderlyingPaymentStubStartDateOffsetUnit":
				{
					value = UnderlyingPaymentStubStartDateOffsetUnit;
					break;
				}
				case "UnderlyingPaymentStubStartDateOffsetDayType":
				{
					value = UnderlyingPaymentStubStartDateOffsetDayType;
					break;
				}
				case "UnderlyingPaymentStubStartDateAdjusted":
				{
					value = UnderlyingPaymentStubStartDateAdjusted;
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
			UnderlyingPaymentStubStartDateUnadjusted = null;
			UnderlyingPaymentStubStartDateBusinessDayConvention = null;
			((IFixReset?)UnderlyingPaymentStubStartDateBusinessCenterGrp)?.Reset();
			UnderlyingPaymentStubStartDateRelativeTo = null;
			UnderlyingPaymentStubStartDateOffsetPeriod = null;
			UnderlyingPaymentStubStartDateOffsetUnit = null;
			UnderlyingPaymentStubStartDateOffsetDayType = null;
			UnderlyingPaymentStubStartDateAdjusted = null;
		}
	}
}
