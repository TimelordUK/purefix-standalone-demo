using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingStreamCommoditySettlDayGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingStreamCommoditySettlDays : IFixGroup
		{
			[TagDetails(Tag = 41997, Type = TagType.Int, Offset = 0, Required = false)]
			public int? UnderlyingStreamCommoditySettlDay {get; set;}
			
			[TagDetails(Tag = 41998, Type = TagType.Int, Offset = 1, Required = false)]
			public int? UnderlyingStreamCommoditySettlTotalHours {get; set;}
			
			[Component(Offset = 2, Required = false)]
			public UnderlyingStreamCommoditySettlTimeGrp? UnderlyingStreamCommoditySettlTimeGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingStreamCommoditySettlDay is not null) writer.WriteWholeNumber(41997, UnderlyingStreamCommoditySettlDay.Value);
				if (UnderlyingStreamCommoditySettlTotalHours is not null) writer.WriteWholeNumber(41998, UnderlyingStreamCommoditySettlTotalHours.Value);
				if (UnderlyingStreamCommoditySettlTimeGrp is not null) ((IFixEncoder)UnderlyingStreamCommoditySettlTimeGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingStreamCommoditySettlDay = view.GetInt32(41997);
				UnderlyingStreamCommoditySettlTotalHours = view.GetInt32(41998);
				if (view.GetView("UnderlyingStreamCommoditySettlTimeGrp") is IMessageView viewUnderlyingStreamCommoditySettlTimeGrp)
				{
					UnderlyingStreamCommoditySettlTimeGrp = new();
					((IFixParser)UnderlyingStreamCommoditySettlTimeGrp).Parse(viewUnderlyingStreamCommoditySettlTimeGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingStreamCommoditySettlDay":
					{
						value = UnderlyingStreamCommoditySettlDay;
						break;
					}
					case "UnderlyingStreamCommoditySettlTotalHours":
					{
						value = UnderlyingStreamCommoditySettlTotalHours;
						break;
					}
					case "UnderlyingStreamCommoditySettlTimeGrp":
					{
						value = UnderlyingStreamCommoditySettlTimeGrp;
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
				UnderlyingStreamCommoditySettlDay = null;
				UnderlyingStreamCommoditySettlTotalHours = null;
				((IFixReset?)UnderlyingStreamCommoditySettlTimeGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 41996, Offset = 0, Required = false)]
		public NoUnderlyingStreamCommoditySettlDays[]? UnderlyingStreamCommoditySettlDays {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingStreamCommoditySettlDays is not null && UnderlyingStreamCommoditySettlDays.Length != 0)
			{
				writer.WriteWholeNumber(41996, UnderlyingStreamCommoditySettlDays.Length);
				for (int i = 0; i < UnderlyingStreamCommoditySettlDays.Length; i++)
				{
					((IFixEncoder)UnderlyingStreamCommoditySettlDays[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingStreamCommoditySettlDays") is IMessageView viewNoUnderlyingStreamCommoditySettlDays)
			{
				var count = viewNoUnderlyingStreamCommoditySettlDays.GroupCount();
				UnderlyingStreamCommoditySettlDays = new NoUnderlyingStreamCommoditySettlDays[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingStreamCommoditySettlDays[i] = new();
					((IFixParser)UnderlyingStreamCommoditySettlDays[i]).Parse(viewNoUnderlyingStreamCommoditySettlDays.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingStreamCommoditySettlDays":
				{
					value = UnderlyingStreamCommoditySettlDays;
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
			UnderlyingStreamCommoditySettlDays = null;
		}
	}
}
