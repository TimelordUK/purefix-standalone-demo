using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class SideRegulatoryTradeIDGrp : IFixComponent
	{
		public sealed partial class NoSideRegulatoryTradeIDs : IFixGroup
		{
			[TagDetails(Tag = 1972, Type = TagType.String, Offset = 0, Required = false)]
			public string? SideRegulatoryTradeID {get; set;}
			
			[TagDetails(Tag = 1973, Type = TagType.String, Offset = 1, Required = false)]
			public string? SideRegulatoryTradeIDSource {get; set;}
			
			[TagDetails(Tag = 1974, Type = TagType.Int, Offset = 2, Required = false)]
			public int? SideRegulatoryTradeIDEvent {get; set;}
			
			[TagDetails(Tag = 1975, Type = TagType.Int, Offset = 3, Required = false)]
			public int? SideRegulatoryTradeIDType {get; set;}
			
			[TagDetails(Tag = 2416, Type = TagType.String, Offset = 4, Required = false)]
			public string? SideRegulatoryLegRefID {get; set;}
			
			[TagDetails(Tag = 2398, Type = TagType.Int, Offset = 5, Required = false)]
			public int? SideRegulatoryTradeIDScope {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (SideRegulatoryTradeID is not null) writer.WriteString(1972, SideRegulatoryTradeID);
				if (SideRegulatoryTradeIDSource is not null) writer.WriteString(1973, SideRegulatoryTradeIDSource);
				if (SideRegulatoryTradeIDEvent is not null) writer.WriteWholeNumber(1974, SideRegulatoryTradeIDEvent.Value);
				if (SideRegulatoryTradeIDType is not null) writer.WriteWholeNumber(1975, SideRegulatoryTradeIDType.Value);
				if (SideRegulatoryLegRefID is not null) writer.WriteString(2416, SideRegulatoryLegRefID);
				if (SideRegulatoryTradeIDScope is not null) writer.WriteWholeNumber(2398, SideRegulatoryTradeIDScope.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				SideRegulatoryTradeID = view.GetString(1972);
				SideRegulatoryTradeIDSource = view.GetString(1973);
				SideRegulatoryTradeIDEvent = view.GetInt32(1974);
				SideRegulatoryTradeIDType = view.GetInt32(1975);
				SideRegulatoryLegRefID = view.GetString(2416);
				SideRegulatoryTradeIDScope = view.GetInt32(2398);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "SideRegulatoryTradeID":
					{
						value = SideRegulatoryTradeID;
						break;
					}
					case "SideRegulatoryTradeIDSource":
					{
						value = SideRegulatoryTradeIDSource;
						break;
					}
					case "SideRegulatoryTradeIDEvent":
					{
						value = SideRegulatoryTradeIDEvent;
						break;
					}
					case "SideRegulatoryTradeIDType":
					{
						value = SideRegulatoryTradeIDType;
						break;
					}
					case "SideRegulatoryLegRefID":
					{
						value = SideRegulatoryLegRefID;
						break;
					}
					case "SideRegulatoryTradeIDScope":
					{
						value = SideRegulatoryTradeIDScope;
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
				SideRegulatoryTradeID = null;
				SideRegulatoryTradeIDSource = null;
				SideRegulatoryTradeIDEvent = null;
				SideRegulatoryTradeIDType = null;
				SideRegulatoryLegRefID = null;
				SideRegulatoryTradeIDScope = null;
			}
		}
		[Group(NoOfTag = 1971, Offset = 0, Required = false)]
		public NoSideRegulatoryTradeIDs[]? SideRegulatoryTradeIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (SideRegulatoryTradeIDs is not null && SideRegulatoryTradeIDs.Length != 0)
			{
				writer.WriteWholeNumber(1971, SideRegulatoryTradeIDs.Length);
				for (int i = 0; i < SideRegulatoryTradeIDs.Length; i++)
				{
					((IFixEncoder)SideRegulatoryTradeIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoSideRegulatoryTradeIDs") is IMessageView viewNoSideRegulatoryTradeIDs)
			{
				var count = viewNoSideRegulatoryTradeIDs.GroupCount();
				SideRegulatoryTradeIDs = new NoSideRegulatoryTradeIDs[count];
				for (int i = 0; i < count; i++)
				{
					SideRegulatoryTradeIDs[i] = new();
					((IFixParser)SideRegulatoryTradeIDs[i]).Parse(viewNoSideRegulatoryTradeIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoSideRegulatoryTradeIDs":
				{
					value = SideRegulatoryTradeIDs;
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
			SideRegulatoryTradeIDs = null;
		}
	}
}
