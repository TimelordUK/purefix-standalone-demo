using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class MarketDataFeedTypes : IFixComponent
	{
		public sealed partial class NoMDFeedTypes : IFixGroup
		{
			[TagDetails(Tag = 1022, Type = TagType.String, Offset = 0, Required = false)]
			public string? MDFeedType {get; set;}
			
			[TagDetails(Tag = 1683, Type = TagType.String, Offset = 1, Required = false)]
			public string? MDSubFeedType {get; set;}
			
			[TagDetails(Tag = 264, Type = TagType.Int, Offset = 2, Required = false)]
			public int? MarketDepth {get; set;}
			
			[TagDetails(Tag = 2563, Type = TagType.Int, Offset = 3, Required = false)]
			public int? MarketDepthTimeInterval {get; set;}
			
			[TagDetails(Tag = 2564, Type = TagType.Int, Offset = 4, Required = false)]
			public int? MarketDepthTimeIntervalUnit {get; set;}
			
			[TagDetails(Tag = 2565, Type = TagType.Int, Offset = 5, Required = false)]
			public int? MDRecoveryTimeInterval {get; set;}
			
			[TagDetails(Tag = 2566, Type = TagType.Int, Offset = 6, Required = false)]
			public int? MDRecoveryTimeIntervalUnit {get; set;}
			
			[TagDetails(Tag = 1021, Type = TagType.Int, Offset = 7, Required = false)]
			public int? MDBookType {get; set;}
			
			[TagDetails(Tag = 1173, Type = TagType.Int, Offset = 8, Required = false)]
			public int? MDSubBookType {get; set;}
			
			[TagDetails(Tag = 2567, Type = TagType.String, Offset = 9, Required = false)]
			public string? PrimaryServiceLocationID {get; set;}
			
			[TagDetails(Tag = 2568, Type = TagType.String, Offset = 10, Required = false)]
			public string? SecondaryServiceLocationID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (MDFeedType is not null) writer.WriteString(1022, MDFeedType);
				if (MDSubFeedType is not null) writer.WriteString(1683, MDSubFeedType);
				if (MarketDepth is not null) writer.WriteWholeNumber(264, MarketDepth.Value);
				if (MarketDepthTimeInterval is not null) writer.WriteWholeNumber(2563, MarketDepthTimeInterval.Value);
				if (MarketDepthTimeIntervalUnit is not null) writer.WriteWholeNumber(2564, MarketDepthTimeIntervalUnit.Value);
				if (MDRecoveryTimeInterval is not null) writer.WriteWholeNumber(2565, MDRecoveryTimeInterval.Value);
				if (MDRecoveryTimeIntervalUnit is not null) writer.WriteWholeNumber(2566, MDRecoveryTimeIntervalUnit.Value);
				if (MDBookType is not null) writer.WriteWholeNumber(1021, MDBookType.Value);
				if (MDSubBookType is not null) writer.WriteWholeNumber(1173, MDSubBookType.Value);
				if (PrimaryServiceLocationID is not null) writer.WriteString(2567, PrimaryServiceLocationID);
				if (SecondaryServiceLocationID is not null) writer.WriteString(2568, SecondaryServiceLocationID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				MDFeedType = view.GetString(1022);
				MDSubFeedType = view.GetString(1683);
				MarketDepth = view.GetInt32(264);
				MarketDepthTimeInterval = view.GetInt32(2563);
				MarketDepthTimeIntervalUnit = view.GetInt32(2564);
				MDRecoveryTimeInterval = view.GetInt32(2565);
				MDRecoveryTimeIntervalUnit = view.GetInt32(2566);
				MDBookType = view.GetInt32(1021);
				MDSubBookType = view.GetInt32(1173);
				PrimaryServiceLocationID = view.GetString(2567);
				SecondaryServiceLocationID = view.GetString(2568);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "MDFeedType":
					{
						value = MDFeedType;
						break;
					}
					case "MDSubFeedType":
					{
						value = MDSubFeedType;
						break;
					}
					case "MarketDepth":
					{
						value = MarketDepth;
						break;
					}
					case "MarketDepthTimeInterval":
					{
						value = MarketDepthTimeInterval;
						break;
					}
					case "MarketDepthTimeIntervalUnit":
					{
						value = MarketDepthTimeIntervalUnit;
						break;
					}
					case "MDRecoveryTimeInterval":
					{
						value = MDRecoveryTimeInterval;
						break;
					}
					case "MDRecoveryTimeIntervalUnit":
					{
						value = MDRecoveryTimeIntervalUnit;
						break;
					}
					case "MDBookType":
					{
						value = MDBookType;
						break;
					}
					case "MDSubBookType":
					{
						value = MDSubBookType;
						break;
					}
					case "PrimaryServiceLocationID":
					{
						value = PrimaryServiceLocationID;
						break;
					}
					case "SecondaryServiceLocationID":
					{
						value = SecondaryServiceLocationID;
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
				MDFeedType = null;
				MDSubFeedType = null;
				MarketDepth = null;
				MarketDepthTimeInterval = null;
				MarketDepthTimeIntervalUnit = null;
				MDRecoveryTimeInterval = null;
				MDRecoveryTimeIntervalUnit = null;
				MDBookType = null;
				MDSubBookType = null;
				PrimaryServiceLocationID = null;
				SecondaryServiceLocationID = null;
			}
		}
		[Group(NoOfTag = 1141, Offset = 0, Required = false)]
		public NoMDFeedTypes[]? MDFeedTypes {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (MDFeedTypes is not null && MDFeedTypes.Length != 0)
			{
				writer.WriteWholeNumber(1141, MDFeedTypes.Length);
				for (int i = 0; i < MDFeedTypes.Length; i++)
				{
					((IFixEncoder)MDFeedTypes[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoMDFeedTypes") is IMessageView viewNoMDFeedTypes)
			{
				var count = viewNoMDFeedTypes.GroupCount();
				MDFeedTypes = new NoMDFeedTypes[count];
				for (int i = 0; i < count; i++)
				{
					MDFeedTypes[i] = new();
					((IFixParser)MDFeedTypes[i]).Parse(viewNoMDFeedTypes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoMDFeedTypes":
				{
					value = MDFeedTypes;
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
			MDFeedTypes = null;
		}
	}
}
