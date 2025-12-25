using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class AllocRegulatoryTradeIDGrp : IFixComponent
	{
		public sealed partial class NoAllocRegulatoryTradeIDs : IFixGroup
		{
			[TagDetails(Tag = 1909, Type = TagType.String, Offset = 0, Required = false)]
			public string? AllocRegulatoryTradeID {get; set;}
			
			[TagDetails(Tag = 1910, Type = TagType.String, Offset = 1, Required = false)]
			public string? AllocRegulatoryTradeIDSource {get; set;}
			
			[TagDetails(Tag = 1911, Type = TagType.Int, Offset = 2, Required = false)]
			public int? AllocRegulatoryTradeIDEvent {get; set;}
			
			[TagDetails(Tag = 1912, Type = TagType.Int, Offset = 3, Required = false)]
			public int? AllocRegulatoryTradeIDType {get; set;}
			
			[TagDetails(Tag = 2406, Type = TagType.String, Offset = 4, Required = false)]
			public string? AllocRegulatoryLegRefID {get; set;}
			
			[TagDetails(Tag = 2399, Type = TagType.Int, Offset = 5, Required = false)]
			public int? AllocRegulatoryTradeIDScope {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (AllocRegulatoryTradeID is not null) writer.WriteString(1909, AllocRegulatoryTradeID);
				if (AllocRegulatoryTradeIDSource is not null) writer.WriteString(1910, AllocRegulatoryTradeIDSource);
				if (AllocRegulatoryTradeIDEvent is not null) writer.WriteWholeNumber(1911, AllocRegulatoryTradeIDEvent.Value);
				if (AllocRegulatoryTradeIDType is not null) writer.WriteWholeNumber(1912, AllocRegulatoryTradeIDType.Value);
				if (AllocRegulatoryLegRefID is not null) writer.WriteString(2406, AllocRegulatoryLegRefID);
				if (AllocRegulatoryTradeIDScope is not null) writer.WriteWholeNumber(2399, AllocRegulatoryTradeIDScope.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				AllocRegulatoryTradeID = view.GetString(1909);
				AllocRegulatoryTradeIDSource = view.GetString(1910);
				AllocRegulatoryTradeIDEvent = view.GetInt32(1911);
				AllocRegulatoryTradeIDType = view.GetInt32(1912);
				AllocRegulatoryLegRefID = view.GetString(2406);
				AllocRegulatoryTradeIDScope = view.GetInt32(2399);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "AllocRegulatoryTradeID":
					{
						value = AllocRegulatoryTradeID;
						break;
					}
					case "AllocRegulatoryTradeIDSource":
					{
						value = AllocRegulatoryTradeIDSource;
						break;
					}
					case "AllocRegulatoryTradeIDEvent":
					{
						value = AllocRegulatoryTradeIDEvent;
						break;
					}
					case "AllocRegulatoryTradeIDType":
					{
						value = AllocRegulatoryTradeIDType;
						break;
					}
					case "AllocRegulatoryLegRefID":
					{
						value = AllocRegulatoryLegRefID;
						break;
					}
					case "AllocRegulatoryTradeIDScope":
					{
						value = AllocRegulatoryTradeIDScope;
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
				AllocRegulatoryTradeID = null;
				AllocRegulatoryTradeIDSource = null;
				AllocRegulatoryTradeIDEvent = null;
				AllocRegulatoryTradeIDType = null;
				AllocRegulatoryLegRefID = null;
				AllocRegulatoryTradeIDScope = null;
			}
		}
		[Group(NoOfTag = 1908, Offset = 0, Required = false)]
		public NoAllocRegulatoryTradeIDs[]? AllocRegulatoryTradeIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (AllocRegulatoryTradeIDs is not null && AllocRegulatoryTradeIDs.Length != 0)
			{
				writer.WriteWholeNumber(1908, AllocRegulatoryTradeIDs.Length);
				for (int i = 0; i < AllocRegulatoryTradeIDs.Length; i++)
				{
					((IFixEncoder)AllocRegulatoryTradeIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoAllocRegulatoryTradeIDs") is IMessageView viewNoAllocRegulatoryTradeIDs)
			{
				var count = viewNoAllocRegulatoryTradeIDs.GroupCount();
				AllocRegulatoryTradeIDs = new NoAllocRegulatoryTradeIDs[count];
				for (int i = 0; i < count; i++)
				{
					AllocRegulatoryTradeIDs[i] = new();
					((IFixParser)AllocRegulatoryTradeIDs[i]).Parse(viewNoAllocRegulatoryTradeIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoAllocRegulatoryTradeIDs":
				{
					value = AllocRegulatoryTradeIDs;
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
			AllocRegulatoryTradeIDs = null;
		}
	}
}
