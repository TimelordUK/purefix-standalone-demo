using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingDeliveryScheduleSettlDayGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingDeliveryScheduleSettlDays : IFixGroup
		{
			[TagDetails(Tag = 41771, Type = TagType.Int, Offset = 0, Required = false)]
			public int? UnderlyingDeliveryScheduleSettlDay {get; set;}
			
			[TagDetails(Tag = 41772, Type = TagType.Int, Offset = 1, Required = false)]
			public int? UnderlyingDeliveryScheduleSettlTotalHours {get; set;}
			
			[Component(Offset = 2, Required = false)]
			public UnderlyingDeliveryScheduleSettlTimeGrp? UnderlyingDeliveryScheduleSettlTimeGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingDeliveryScheduleSettlDay is not null) writer.WriteWholeNumber(41771, UnderlyingDeliveryScheduleSettlDay.Value);
				if (UnderlyingDeliveryScheduleSettlTotalHours is not null) writer.WriteWholeNumber(41772, UnderlyingDeliveryScheduleSettlTotalHours.Value);
				if (UnderlyingDeliveryScheduleSettlTimeGrp is not null) ((IFixEncoder)UnderlyingDeliveryScheduleSettlTimeGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingDeliveryScheduleSettlDay = view.GetInt32(41771);
				UnderlyingDeliveryScheduleSettlTotalHours = view.GetInt32(41772);
				if (view.GetView("UnderlyingDeliveryScheduleSettlTimeGrp") is IMessageView viewUnderlyingDeliveryScheduleSettlTimeGrp)
				{
					UnderlyingDeliveryScheduleSettlTimeGrp = new();
					((IFixParser)UnderlyingDeliveryScheduleSettlTimeGrp).Parse(viewUnderlyingDeliveryScheduleSettlTimeGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingDeliveryScheduleSettlDay":
					{
						value = UnderlyingDeliveryScheduleSettlDay;
						break;
					}
					case "UnderlyingDeliveryScheduleSettlTotalHours":
					{
						value = UnderlyingDeliveryScheduleSettlTotalHours;
						break;
					}
					case "UnderlyingDeliveryScheduleSettlTimeGrp":
					{
						value = UnderlyingDeliveryScheduleSettlTimeGrp;
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
				UnderlyingDeliveryScheduleSettlDay = null;
				UnderlyingDeliveryScheduleSettlTotalHours = null;
				((IFixReset?)UnderlyingDeliveryScheduleSettlTimeGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 41770, Offset = 0, Required = false)]
		public NoUnderlyingDeliveryScheduleSettlDays[]? UnderlyingDeliveryScheduleSettlDays {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingDeliveryScheduleSettlDays is not null && UnderlyingDeliveryScheduleSettlDays.Length != 0)
			{
				writer.WriteWholeNumber(41770, UnderlyingDeliveryScheduleSettlDays.Length);
				for (int i = 0; i < UnderlyingDeliveryScheduleSettlDays.Length; i++)
				{
					((IFixEncoder)UnderlyingDeliveryScheduleSettlDays[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingDeliveryScheduleSettlDays") is IMessageView viewNoUnderlyingDeliveryScheduleSettlDays)
			{
				var count = viewNoUnderlyingDeliveryScheduleSettlDays.GroupCount();
				UnderlyingDeliveryScheduleSettlDays = new NoUnderlyingDeliveryScheduleSettlDays[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingDeliveryScheduleSettlDays[i] = new();
					((IFixParser)UnderlyingDeliveryScheduleSettlDays[i]).Parse(viewNoUnderlyingDeliveryScheduleSettlDays.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingDeliveryScheduleSettlDays":
				{
					value = UnderlyingDeliveryScheduleSettlDays;
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
			UnderlyingDeliveryScheduleSettlDays = null;
		}
	}
}
