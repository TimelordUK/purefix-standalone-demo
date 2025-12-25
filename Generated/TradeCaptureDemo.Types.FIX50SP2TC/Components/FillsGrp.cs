using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class FillsGrp : IFixComponent
	{
		public sealed partial class NoFills : IFixGroup
		{
			[TagDetails(Tag = 1363, Type = TagType.String, Offset = 0, Required = false)]
			public string? FillExecID {get; set;}
			
			[TagDetails(Tag = 1364, Type = TagType.Float, Offset = 1, Required = false)]
			public double? FillPx {get; set;}
			
			[TagDetails(Tag = 1365, Type = TagType.Float, Offset = 2, Required = false)]
			public double? FillQty {get; set;}
			
			[TagDetails(Tag = 2673, Type = TagType.String, Offset = 3, Required = false)]
			public string? FillMatchID {get; set;}
			
			[TagDetails(Tag = 2674, Type = TagType.String, Offset = 4, Required = false)]
			public string? FillMatchSubID {get; set;}
			
			[TagDetails(Tag = 1443, Type = TagType.Int, Offset = 5, Required = false)]
			public int? FillLiquidityInd {get; set;}
			
			[TagDetails(Tag = 1622, Type = TagType.String, Offset = 6, Required = false)]
			public string? FillYieldType {get; set;}
			
			[TagDetails(Tag = 1623, Type = TagType.Float, Offset = 7, Required = false)]
			public double? FillYield {get; set;}
			
			[Component(Offset = 8, Required = false)]
			public NestedParties4? NestedParties4 {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (FillExecID is not null) writer.WriteString(1363, FillExecID);
				if (FillPx is not null) writer.WriteNumber(1364, FillPx.Value);
				if (FillQty is not null) writer.WriteNumber(1365, FillQty.Value);
				if (FillMatchID is not null) writer.WriteString(2673, FillMatchID);
				if (FillMatchSubID is not null) writer.WriteString(2674, FillMatchSubID);
				if (FillLiquidityInd is not null) writer.WriteWholeNumber(1443, FillLiquidityInd.Value);
				if (FillYieldType is not null) writer.WriteString(1622, FillYieldType);
				if (FillYield is not null) writer.WriteNumber(1623, FillYield.Value);
				if (NestedParties4 is not null) ((IFixEncoder)NestedParties4).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				FillExecID = view.GetString(1363);
				FillPx = view.GetDouble(1364);
				FillQty = view.GetDouble(1365);
				FillMatchID = view.GetString(2673);
				FillMatchSubID = view.GetString(2674);
				FillLiquidityInd = view.GetInt32(1443);
				FillYieldType = view.GetString(1622);
				FillYield = view.GetDouble(1623);
				if (view.GetView("NestedParties4") is IMessageView viewNestedParties4)
				{
					NestedParties4 = new();
					((IFixParser)NestedParties4).Parse(viewNestedParties4);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "FillExecID":
					{
						value = FillExecID;
						break;
					}
					case "FillPx":
					{
						value = FillPx;
						break;
					}
					case "FillQty":
					{
						value = FillQty;
						break;
					}
					case "FillMatchID":
					{
						value = FillMatchID;
						break;
					}
					case "FillMatchSubID":
					{
						value = FillMatchSubID;
						break;
					}
					case "FillLiquidityInd":
					{
						value = FillLiquidityInd;
						break;
					}
					case "FillYieldType":
					{
						value = FillYieldType;
						break;
					}
					case "FillYield":
					{
						value = FillYield;
						break;
					}
					case "NestedParties4":
					{
						value = NestedParties4;
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
				FillExecID = null;
				FillPx = null;
				FillQty = null;
				FillMatchID = null;
				FillMatchSubID = null;
				FillLiquidityInd = null;
				FillYieldType = null;
				FillYield = null;
				((IFixReset?)NestedParties4)?.Reset();
			}
		}
		[Group(NoOfTag = 1362, Offset = 0, Required = false)]
		public NoFills[]? Fills {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Fills is not null && Fills.Length != 0)
			{
				writer.WriteWholeNumber(1362, Fills.Length);
				for (int i = 0; i < Fills.Length; i++)
				{
					((IFixEncoder)Fills[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoFills") is IMessageView viewNoFills)
			{
				var count = viewNoFills.GroupCount();
				Fills = new NoFills[count];
				for (int i = 0; i < count; i++)
				{
					Fills[i] = new();
					((IFixParser)Fills[i]).Parse(viewNoFills.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoFills":
				{
					value = Fills;
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
			Fills = null;
		}
	}
}
