using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegStreamCommodityDataSourceGrp : IFixComponent
	{
		public sealed partial class NoLegStreamCommodityDataSources : IFixGroup
		{
			[TagDetails(Tag = 41678, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegStreamCommodityDataSourceID {get; set;}
			
			[TagDetails(Tag = 41679, Type = TagType.Int, Offset = 1, Required = false)]
			public int? LegStreamCommodityDataSourceIDType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegStreamCommodityDataSourceID is not null) writer.WriteString(41678, LegStreamCommodityDataSourceID);
				if (LegStreamCommodityDataSourceIDType is not null) writer.WriteWholeNumber(41679, LegStreamCommodityDataSourceIDType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegStreamCommodityDataSourceID = view.GetString(41678);
				LegStreamCommodityDataSourceIDType = view.GetInt32(41679);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegStreamCommodityDataSourceID":
					{
						value = LegStreamCommodityDataSourceID;
						break;
					}
					case "LegStreamCommodityDataSourceIDType":
					{
						value = LegStreamCommodityDataSourceIDType;
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
				LegStreamCommodityDataSourceID = null;
				LegStreamCommodityDataSourceIDType = null;
			}
		}
		[Group(NoOfTag = 41677, Offset = 0, Required = false)]
		public NoLegStreamCommodityDataSources[]? LegStreamCommodityDataSources {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegStreamCommodityDataSources is not null && LegStreamCommodityDataSources.Length != 0)
			{
				writer.WriteWholeNumber(41677, LegStreamCommodityDataSources.Length);
				for (int i = 0; i < LegStreamCommodityDataSources.Length; i++)
				{
					((IFixEncoder)LegStreamCommodityDataSources[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegStreamCommodityDataSources") is IMessageView viewNoLegStreamCommodityDataSources)
			{
				var count = viewNoLegStreamCommodityDataSources.GroupCount();
				LegStreamCommodityDataSources = new NoLegStreamCommodityDataSources[count];
				for (int i = 0; i < count; i++)
				{
					LegStreamCommodityDataSources[i] = new();
					((IFixParser)LegStreamCommodityDataSources[i]).Parse(viewNoLegStreamCommodityDataSources.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegStreamCommodityDataSources":
				{
					value = LegStreamCommodityDataSources;
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
			LegStreamCommodityDataSources = null;
		}
	}
}
