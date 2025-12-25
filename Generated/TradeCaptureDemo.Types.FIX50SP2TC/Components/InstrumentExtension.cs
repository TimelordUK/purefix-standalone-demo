using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class InstrumentExtension : IFixComponent
	{
		[TagDetails(Tag = 668, Type = TagType.Int, Offset = 0, Required = false)]
		public int? DeliveryForm {get; set;}
		
		[TagDetails(Tag = 869, Type = TagType.Float, Offset = 1, Required = false)]
		public double? PctAtRisk {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public AttrbGrp? AttrbGrp {get; set;}
		
		[TagDetails(Tag = 2736, Type = TagType.Int, Offset = 3, Required = false)]
		public int? CommodityFinalPriceType {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public IndexRollMonthGrp? IndexRollMonthGrp {get; set;}
		
		[TagDetails(Tag = 2738, Type = TagType.LocalDate, Offset = 5, Required = false)]
		public DateOnly? NextIndexRollDate {get; set;}
		
		[Component(Offset = 6, Required = false)]
		public FloatingRateIndex? FloatingRateIndex {get; set;}
		
		[Component(Offset = 7, Required = false)]
		public ReferenceDataDateGrp? ReferenceDataDateGrp {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (DeliveryForm is not null) writer.WriteWholeNumber(668, DeliveryForm.Value);
			if (PctAtRisk is not null) writer.WriteNumber(869, PctAtRisk.Value);
			if (AttrbGrp is not null) ((IFixEncoder)AttrbGrp).Encode(writer);
			if (CommodityFinalPriceType is not null) writer.WriteWholeNumber(2736, CommodityFinalPriceType.Value);
			if (IndexRollMonthGrp is not null) ((IFixEncoder)IndexRollMonthGrp).Encode(writer);
			if (NextIndexRollDate is not null) writer.WriteLocalDateOnly(2738, NextIndexRollDate.Value);
			if (FloatingRateIndex is not null) ((IFixEncoder)FloatingRateIndex).Encode(writer);
			if (ReferenceDataDateGrp is not null) ((IFixEncoder)ReferenceDataDateGrp).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			DeliveryForm = view.GetInt32(668);
			PctAtRisk = view.GetDouble(869);
			if (view.GetView("AttrbGrp") is IMessageView viewAttrbGrp)
			{
				AttrbGrp = new();
				((IFixParser)AttrbGrp).Parse(viewAttrbGrp);
			}
			CommodityFinalPriceType = view.GetInt32(2736);
			if (view.GetView("IndexRollMonthGrp") is IMessageView viewIndexRollMonthGrp)
			{
				IndexRollMonthGrp = new();
				((IFixParser)IndexRollMonthGrp).Parse(viewIndexRollMonthGrp);
			}
			NextIndexRollDate = view.GetDateOnly(2738);
			if (view.GetView("FloatingRateIndex") is IMessageView viewFloatingRateIndex)
			{
				FloatingRateIndex = new();
				((IFixParser)FloatingRateIndex).Parse(viewFloatingRateIndex);
			}
			if (view.GetView("ReferenceDataDateGrp") is IMessageView viewReferenceDataDateGrp)
			{
				ReferenceDataDateGrp = new();
				((IFixParser)ReferenceDataDateGrp).Parse(viewReferenceDataDateGrp);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "DeliveryForm":
				{
					value = DeliveryForm;
					break;
				}
				case "PctAtRisk":
				{
					value = PctAtRisk;
					break;
				}
				case "AttrbGrp":
				{
					value = AttrbGrp;
					break;
				}
				case "CommodityFinalPriceType":
				{
					value = CommodityFinalPriceType;
					break;
				}
				case "IndexRollMonthGrp":
				{
					value = IndexRollMonthGrp;
					break;
				}
				case "NextIndexRollDate":
				{
					value = NextIndexRollDate;
					break;
				}
				case "FloatingRateIndex":
				{
					value = FloatingRateIndex;
					break;
				}
				case "ReferenceDataDateGrp":
				{
					value = ReferenceDataDateGrp;
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
			DeliveryForm = null;
			PctAtRisk = null;
			((IFixReset?)AttrbGrp)?.Reset();
			CommodityFinalPriceType = null;
			((IFixReset?)IndexRollMonthGrp)?.Reset();
			NextIndexRollDate = null;
			((IFixReset?)FloatingRateIndex)?.Reset();
			((IFixReset?)ReferenceDataDateGrp)?.Reset();
		}
	}
}
