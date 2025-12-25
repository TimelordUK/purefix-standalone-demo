using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegStreamCommodityAltIDGrp : IFixComponent
	{
		public sealed partial class NoLegStreamCommodityAltIDs : IFixGroup
		{
			[TagDetails(Tag = 41675, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegStreamCommodityAltID {get; set;}
			
			[TagDetails(Tag = 41676, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegStreamCommodityAltIDSource {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegStreamCommodityAltID is not null) writer.WriteString(41675, LegStreamCommodityAltID);
				if (LegStreamCommodityAltIDSource is not null) writer.WriteString(41676, LegStreamCommodityAltIDSource);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegStreamCommodityAltID = view.GetString(41675);
				LegStreamCommodityAltIDSource = view.GetString(41676);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegStreamCommodityAltID":
					{
						value = LegStreamCommodityAltID;
						break;
					}
					case "LegStreamCommodityAltIDSource":
					{
						value = LegStreamCommodityAltIDSource;
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
				LegStreamCommodityAltID = null;
				LegStreamCommodityAltIDSource = null;
			}
		}
		[Group(NoOfTag = 41674, Offset = 0, Required = false)]
		public NoLegStreamCommodityAltIDs[]? LegStreamCommodityAltIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegStreamCommodityAltIDs is not null && LegStreamCommodityAltIDs.Length != 0)
			{
				writer.WriteWholeNumber(41674, LegStreamCommodityAltIDs.Length);
				for (int i = 0; i < LegStreamCommodityAltIDs.Length; i++)
				{
					((IFixEncoder)LegStreamCommodityAltIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegStreamCommodityAltIDs") is IMessageView viewNoLegStreamCommodityAltIDs)
			{
				var count = viewNoLegStreamCommodityAltIDs.GroupCount();
				LegStreamCommodityAltIDs = new NoLegStreamCommodityAltIDs[count];
				for (int i = 0; i < count; i++)
				{
					LegStreamCommodityAltIDs[i] = new();
					((IFixParser)LegStreamCommodityAltIDs[i]).Parse(viewNoLegStreamCommodityAltIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegStreamCommodityAltIDs":
				{
					value = LegStreamCommodityAltIDs;
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
			LegStreamCommodityAltIDs = null;
		}
	}
}
