using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class BidDescReqGrp : IFixComponent
	{
		public sealed partial class NoBidDescriptors : IFixGroup
		{
			[TagDetails(Tag = 399, Type = TagType.Int, Offset = 0, Required = false)]
			public int? BidDescriptorType {get; set;}
			
			[TagDetails(Tag = 400, Type = TagType.String, Offset = 1, Required = false)]
			public string? BidDescriptor {get; set;}
			
			[TagDetails(Tag = 401, Type = TagType.Int, Offset = 2, Required = false)]
			public int? SideValueInd {get; set;}
			
			[TagDetails(Tag = 404, Type = TagType.Float, Offset = 3, Required = false)]
			public double? LiquidityValue {get; set;}
			
			[TagDetails(Tag = 441, Type = TagType.Int, Offset = 4, Required = false)]
			public int? LiquidityNumSecurities {get; set;}
			
			[TagDetails(Tag = 402, Type = TagType.Float, Offset = 5, Required = false)]
			public double? LiquidityPctLow {get; set;}
			
			[TagDetails(Tag = 403, Type = TagType.Float, Offset = 6, Required = false)]
			public double? LiquidityPctHigh {get; set;}
			
			[TagDetails(Tag = 405, Type = TagType.Float, Offset = 7, Required = false)]
			public double? EFPTrackingError {get; set;}
			
			[TagDetails(Tag = 406, Type = TagType.Float, Offset = 8, Required = false)]
			public double? FairValue {get; set;}
			
			[TagDetails(Tag = 407, Type = TagType.Float, Offset = 9, Required = false)]
			public double? OutsideIndexPct {get; set;}
			
			[TagDetails(Tag = 408, Type = TagType.Float, Offset = 10, Required = false)]
			public double? ValueOfFutures {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (BidDescriptorType is not null) writer.WriteWholeNumber(399, BidDescriptorType.Value);
				if (BidDescriptor is not null) writer.WriteString(400, BidDescriptor);
				if (SideValueInd is not null) writer.WriteWholeNumber(401, SideValueInd.Value);
				if (LiquidityValue is not null) writer.WriteNumber(404, LiquidityValue.Value);
				if (LiquidityNumSecurities is not null) writer.WriteWholeNumber(441, LiquidityNumSecurities.Value);
				if (LiquidityPctLow is not null) writer.WriteNumber(402, LiquidityPctLow.Value);
				if (LiquidityPctHigh is not null) writer.WriteNumber(403, LiquidityPctHigh.Value);
				if (EFPTrackingError is not null) writer.WriteNumber(405, EFPTrackingError.Value);
				if (FairValue is not null) writer.WriteNumber(406, FairValue.Value);
				if (OutsideIndexPct is not null) writer.WriteNumber(407, OutsideIndexPct.Value);
				if (ValueOfFutures is not null) writer.WriteNumber(408, ValueOfFutures.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				BidDescriptorType = view.GetInt32(399);
				BidDescriptor = view.GetString(400);
				SideValueInd = view.GetInt32(401);
				LiquidityValue = view.GetDouble(404);
				LiquidityNumSecurities = view.GetInt32(441);
				LiquidityPctLow = view.GetDouble(402);
				LiquidityPctHigh = view.GetDouble(403);
				EFPTrackingError = view.GetDouble(405);
				FairValue = view.GetDouble(406);
				OutsideIndexPct = view.GetDouble(407);
				ValueOfFutures = view.GetDouble(408);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "BidDescriptorType":
					{
						value = BidDescriptorType;
						break;
					}
					case "BidDescriptor":
					{
						value = BidDescriptor;
						break;
					}
					case "SideValueInd":
					{
						value = SideValueInd;
						break;
					}
					case "LiquidityValue":
					{
						value = LiquidityValue;
						break;
					}
					case "LiquidityNumSecurities":
					{
						value = LiquidityNumSecurities;
						break;
					}
					case "LiquidityPctLow":
					{
						value = LiquidityPctLow;
						break;
					}
					case "LiquidityPctHigh":
					{
						value = LiquidityPctHigh;
						break;
					}
					case "EFPTrackingError":
					{
						value = EFPTrackingError;
						break;
					}
					case "FairValue":
					{
						value = FairValue;
						break;
					}
					case "OutsideIndexPct":
					{
						value = OutsideIndexPct;
						break;
					}
					case "ValueOfFutures":
					{
						value = ValueOfFutures;
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
				BidDescriptorType = null;
				BidDescriptor = null;
				SideValueInd = null;
				LiquidityValue = null;
				LiquidityNumSecurities = null;
				LiquidityPctLow = null;
				LiquidityPctHigh = null;
				EFPTrackingError = null;
				FairValue = null;
				OutsideIndexPct = null;
				ValueOfFutures = null;
			}
		}
		[Group(NoOfTag = 398, Offset = 0, Required = false)]
		public NoBidDescriptors[]? BidDescriptors {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (BidDescriptors is not null && BidDescriptors.Length != 0)
			{
				writer.WriteWholeNumber(398, BidDescriptors.Length);
				for (int i = 0; i < BidDescriptors.Length; i++)
				{
					((IFixEncoder)BidDescriptors[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoBidDescriptors") is IMessageView viewNoBidDescriptors)
			{
				var count = viewNoBidDescriptors.GroupCount();
				BidDescriptors = new NoBidDescriptors[count];
				for (int i = 0; i < count; i++)
				{
					BidDescriptors[i] = new();
					((IFixParser)BidDescriptors[i]).Parse(viewNoBidDescriptors.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoBidDescriptors":
				{
					value = BidDescriptors;
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
			BidDescriptors = null;
		}
	}
}
