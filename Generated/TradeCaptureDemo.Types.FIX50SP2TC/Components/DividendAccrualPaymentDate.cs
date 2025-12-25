using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class DividendAccrualPaymentDate : IFixComponent
	{
		[TagDetails(Tag = 42238, Type = TagType.Int, Offset = 0, Required = false)]
		public int? DividendAccrualPaymentDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42239, Type = TagType.Int, Offset = 1, Required = false)]
		public int? DividendAccrualPaymentDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42240, Type = TagType.String, Offset = 2, Required = false)]
		public string? DividendAccrualPaymentDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42241, Type = TagType.Int, Offset = 3, Required = false)]
		public int? DividendAccrualPaymentDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42242, Type = TagType.LocalDate, Offset = 4, Required = false)]
		public DateOnly? DividendAccrualPaymentDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42243, Type = TagType.Int, Offset = 5, Required = false)]
		public int? DividendAccrualPaymeentDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 6, Required = false)]
		public DividendAccrualPaymentDateBusinessCenterGrp? DividendAccrualPaymentDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 42244, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? DividendAccrualPaymentDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (DividendAccrualPaymentDateRelativeTo is not null) writer.WriteWholeNumber(42238, DividendAccrualPaymentDateRelativeTo.Value);
			if (DividendAccrualPaymentDateOffsetPeriod is not null) writer.WriteWholeNumber(42239, DividendAccrualPaymentDateOffsetPeriod.Value);
			if (DividendAccrualPaymentDateOffsetUnit is not null) writer.WriteString(42240, DividendAccrualPaymentDateOffsetUnit);
			if (DividendAccrualPaymentDateOffsetDayType is not null) writer.WriteWholeNumber(42241, DividendAccrualPaymentDateOffsetDayType.Value);
			if (DividendAccrualPaymentDateUnadjusted is not null) writer.WriteLocalDateOnly(42242, DividendAccrualPaymentDateUnadjusted.Value);
			if (DividendAccrualPaymeentDateBusinessDayConvention is not null) writer.WriteWholeNumber(42243, DividendAccrualPaymeentDateBusinessDayConvention.Value);
			if (DividendAccrualPaymentDateBusinessCenterGrp is not null) ((IFixEncoder)DividendAccrualPaymentDateBusinessCenterGrp).Encode(writer);
			if (DividendAccrualPaymentDateAdjusted is not null) writer.WriteLocalDateOnly(42244, DividendAccrualPaymentDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			DividendAccrualPaymentDateRelativeTo = view.GetInt32(42238);
			DividendAccrualPaymentDateOffsetPeriod = view.GetInt32(42239);
			DividendAccrualPaymentDateOffsetUnit = view.GetString(42240);
			DividendAccrualPaymentDateOffsetDayType = view.GetInt32(42241);
			DividendAccrualPaymentDateUnadjusted = view.GetDateOnly(42242);
			DividendAccrualPaymeentDateBusinessDayConvention = view.GetInt32(42243);
			if (view.GetView("DividendAccrualPaymentDateBusinessCenterGrp") is IMessageView viewDividendAccrualPaymentDateBusinessCenterGrp)
			{
				DividendAccrualPaymentDateBusinessCenterGrp = new();
				((IFixParser)DividendAccrualPaymentDateBusinessCenterGrp).Parse(viewDividendAccrualPaymentDateBusinessCenterGrp);
			}
			DividendAccrualPaymentDateAdjusted = view.GetDateOnly(42244);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "DividendAccrualPaymentDateRelativeTo":
				{
					value = DividendAccrualPaymentDateRelativeTo;
					break;
				}
				case "DividendAccrualPaymentDateOffsetPeriod":
				{
					value = DividendAccrualPaymentDateOffsetPeriod;
					break;
				}
				case "DividendAccrualPaymentDateOffsetUnit":
				{
					value = DividendAccrualPaymentDateOffsetUnit;
					break;
				}
				case "DividendAccrualPaymentDateOffsetDayType":
				{
					value = DividendAccrualPaymentDateOffsetDayType;
					break;
				}
				case "DividendAccrualPaymentDateUnadjusted":
				{
					value = DividendAccrualPaymentDateUnadjusted;
					break;
				}
				case "DividendAccrualPaymeentDateBusinessDayConvention":
				{
					value = DividendAccrualPaymeentDateBusinessDayConvention;
					break;
				}
				case "DividendAccrualPaymentDateBusinessCenterGrp":
				{
					value = DividendAccrualPaymentDateBusinessCenterGrp;
					break;
				}
				case "DividendAccrualPaymentDateAdjusted":
				{
					value = DividendAccrualPaymentDateAdjusted;
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
			DividendAccrualPaymentDateRelativeTo = null;
			DividendAccrualPaymentDateOffsetPeriod = null;
			DividendAccrualPaymentDateOffsetUnit = null;
			DividendAccrualPaymentDateOffsetDayType = null;
			DividendAccrualPaymentDateUnadjusted = null;
			DividendAccrualPaymeentDateBusinessDayConvention = null;
			((IFixReset?)DividendAccrualPaymentDateBusinessCenterGrp)?.Reset();
			DividendAccrualPaymentDateAdjusted = null;
		}
	}
}
