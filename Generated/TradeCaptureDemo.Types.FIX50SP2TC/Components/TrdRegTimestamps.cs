using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class TrdRegTimestamps : IFixComponent
	{
		public sealed partial class NoTrdRegTimestamps : IFixGroup
		{
			[TagDetails(Tag = 769, Type = TagType.UtcTimestamp, Offset = 0, Required = false)]
			public DateTime? TrdRegTimestamp {get; set;}
			
			[TagDetails(Tag = 770, Type = TagType.Int, Offset = 1, Required = false)]
			public int? TrdRegTimestampType {get; set;}
			
			[TagDetails(Tag = 771, Type = TagType.String, Offset = 2, Required = false)]
			public string? TrdRegTimestampOrigin {get; set;}
			
			[TagDetails(Tag = 2839, Type = TagType.Boolean, Offset = 3, Required = false)]
			public bool? TrdRegTimestampManualIndicator {get; set;}
			
			[TagDetails(Tag = 1033, Type = TagType.String, Offset = 4, Required = false)]
			public string? DeskType {get; set;}
			
			[TagDetails(Tag = 1034, Type = TagType.Int, Offset = 5, Required = false)]
			public int? DeskTypeSource {get; set;}
			
			[TagDetails(Tag = 1035, Type = TagType.String, Offset = 6, Required = false)]
			public string? DeskOrderHandlingInst {get; set;}
			
			[TagDetails(Tag = 1727, Type = TagType.String, Offset = 7, Required = false)]
			public string? InformationBarrierID {get; set;}
			
			[TagDetails(Tag = 2831, Type = TagType.Int, Offset = 8, Required = false)]
			public int? NBBOEntryType {get; set;}
			
			[TagDetails(Tag = 2832, Type = TagType.Float, Offset = 9, Required = false)]
			public double? NBBOPrice {get; set;}
			
			[TagDetails(Tag = 2833, Type = TagType.Float, Offset = 10, Required = false)]
			public double? NBBOQty {get; set;}
			
			[TagDetails(Tag = 2834, Type = TagType.Int, Offset = 11, Required = false)]
			public int? NBBOSource {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (TrdRegTimestamp is not null) writer.WriteUtcTimeStamp(769, TrdRegTimestamp.Value);
				if (TrdRegTimestampType is not null) writer.WriteWholeNumber(770, TrdRegTimestampType.Value);
				if (TrdRegTimestampOrigin is not null) writer.WriteString(771, TrdRegTimestampOrigin);
				if (TrdRegTimestampManualIndicator is not null) writer.WriteBoolean(2839, TrdRegTimestampManualIndicator.Value);
				if (DeskType is not null) writer.WriteString(1033, DeskType);
				if (DeskTypeSource is not null) writer.WriteWholeNumber(1034, DeskTypeSource.Value);
				if (DeskOrderHandlingInst is not null) writer.WriteString(1035, DeskOrderHandlingInst);
				if (InformationBarrierID is not null) writer.WriteString(1727, InformationBarrierID);
				if (NBBOEntryType is not null) writer.WriteWholeNumber(2831, NBBOEntryType.Value);
				if (NBBOPrice is not null) writer.WriteNumber(2832, NBBOPrice.Value);
				if (NBBOQty is not null) writer.WriteNumber(2833, NBBOQty.Value);
				if (NBBOSource is not null) writer.WriteWholeNumber(2834, NBBOSource.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				TrdRegTimestamp = view.GetDateTime(769);
				TrdRegTimestampType = view.GetInt32(770);
				TrdRegTimestampOrigin = view.GetString(771);
				TrdRegTimestampManualIndicator = view.GetBool(2839);
				DeskType = view.GetString(1033);
				DeskTypeSource = view.GetInt32(1034);
				DeskOrderHandlingInst = view.GetString(1035);
				InformationBarrierID = view.GetString(1727);
				NBBOEntryType = view.GetInt32(2831);
				NBBOPrice = view.GetDouble(2832);
				NBBOQty = view.GetDouble(2833);
				NBBOSource = view.GetInt32(2834);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "TrdRegTimestamp":
					{
						value = TrdRegTimestamp;
						break;
					}
					case "TrdRegTimestampType":
					{
						value = TrdRegTimestampType;
						break;
					}
					case "TrdRegTimestampOrigin":
					{
						value = TrdRegTimestampOrigin;
						break;
					}
					case "TrdRegTimestampManualIndicator":
					{
						value = TrdRegTimestampManualIndicator;
						break;
					}
					case "DeskType":
					{
						value = DeskType;
						break;
					}
					case "DeskTypeSource":
					{
						value = DeskTypeSource;
						break;
					}
					case "DeskOrderHandlingInst":
					{
						value = DeskOrderHandlingInst;
						break;
					}
					case "InformationBarrierID":
					{
						value = InformationBarrierID;
						break;
					}
					case "NBBOEntryType":
					{
						value = NBBOEntryType;
						break;
					}
					case "NBBOPrice":
					{
						value = NBBOPrice;
						break;
					}
					case "NBBOQty":
					{
						value = NBBOQty;
						break;
					}
					case "NBBOSource":
					{
						value = NBBOSource;
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
				TrdRegTimestamp = null;
				TrdRegTimestampType = null;
				TrdRegTimestampOrigin = null;
				TrdRegTimestampManualIndicator = null;
				DeskType = null;
				DeskTypeSource = null;
				DeskOrderHandlingInst = null;
				InformationBarrierID = null;
				NBBOEntryType = null;
				NBBOPrice = null;
				NBBOQty = null;
				NBBOSource = null;
			}
		}
		[Group(NoOfTag = 768, Offset = 0, Required = false)]
		public NoTrdRegTimestamps[]? TrdRegTimestampsItems {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (TrdRegTimestampsItems is not null && TrdRegTimestampsItems.Length != 0)
			{
				writer.WriteWholeNumber(768, TrdRegTimestampsItems.Length);
				for (int i = 0; i < TrdRegTimestampsItems.Length; i++)
				{
					((IFixEncoder)TrdRegTimestampsItems[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoTrdRegTimestamps") is IMessageView viewNoTrdRegTimestamps)
			{
				var count = viewNoTrdRegTimestamps.GroupCount();
				TrdRegTimestampsItems = new NoTrdRegTimestamps[count];
				for (int i = 0; i < count; i++)
				{
					TrdRegTimestampsItems[i] = new();
					((IFixParser)TrdRegTimestampsItems[i]).Parse(viewNoTrdRegTimestamps.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoTrdRegTimestamps":
				{
					value = TrdRegTimestampsItems;
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
			TrdRegTimestampsItems = null;
		}
	}
}
