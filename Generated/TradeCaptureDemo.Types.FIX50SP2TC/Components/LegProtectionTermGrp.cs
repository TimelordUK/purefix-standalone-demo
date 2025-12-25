using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegProtectionTermGrp : IFixComponent
	{
		public sealed partial class NoLegProtectionTerms : IFixGroup
		{
			[TagDetails(Tag = 41618, Type = TagType.Float, Offset = 0, Required = false)]
			public double? LegProtectionTermNotional {get; set;}
			
			[TagDetails(Tag = 41619, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegProtectionTermCurrency {get; set;}
			
			[TagDetails(Tag = 41620, Type = TagType.Boolean, Offset = 2, Required = false)]
			public bool? LegProtectionTermSellerNotifies {get; set;}
			
			[TagDetails(Tag = 41621, Type = TagType.Boolean, Offset = 3, Required = false)]
			public bool? LegProtectionTermBuyerNotifies {get; set;}
			
			[TagDetails(Tag = 41622, Type = TagType.String, Offset = 4, Required = false)]
			public string? LegProtectionTermEventBusinessCenter {get; set;}
			
			[TagDetails(Tag = 41623, Type = TagType.Boolean, Offset = 5, Required = false)]
			public bool? LegProtectionTermStandardSources {get; set;}
			
			[TagDetails(Tag = 41624, Type = TagType.Int, Offset = 6, Required = false)]
			public int? LegProtectionTermEventMinimumSources {get; set;}
			
			[Component(Offset = 7, Required = false)]
			public LegProtectionTermEventNewsSourceGrp? LegProtectionTermEventNewsSourceGrp {get; set;}
			
			[Component(Offset = 8, Required = false)]
			public LegProtectionTermEventGrp? LegProtectionTermEventGrp {get; set;}
			
			[Component(Offset = 9, Required = false)]
			public LegProtectionTermObligationGrp? LegProtectionTermObligationGrp {get; set;}
			
			[TagDetails(Tag = 41617, Type = TagType.String, Offset = 10, Required = false)]
			public string? LegProtectionTermXID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegProtectionTermNotional is not null) writer.WriteNumber(41618, LegProtectionTermNotional.Value);
				if (LegProtectionTermCurrency is not null) writer.WriteString(41619, LegProtectionTermCurrency);
				if (LegProtectionTermSellerNotifies is not null) writer.WriteBoolean(41620, LegProtectionTermSellerNotifies.Value);
				if (LegProtectionTermBuyerNotifies is not null) writer.WriteBoolean(41621, LegProtectionTermBuyerNotifies.Value);
				if (LegProtectionTermEventBusinessCenter is not null) writer.WriteString(41622, LegProtectionTermEventBusinessCenter);
				if (LegProtectionTermStandardSources is not null) writer.WriteBoolean(41623, LegProtectionTermStandardSources.Value);
				if (LegProtectionTermEventMinimumSources is not null) writer.WriteWholeNumber(41624, LegProtectionTermEventMinimumSources.Value);
				if (LegProtectionTermEventNewsSourceGrp is not null) ((IFixEncoder)LegProtectionTermEventNewsSourceGrp).Encode(writer);
				if (LegProtectionTermEventGrp is not null) ((IFixEncoder)LegProtectionTermEventGrp).Encode(writer);
				if (LegProtectionTermObligationGrp is not null) ((IFixEncoder)LegProtectionTermObligationGrp).Encode(writer);
				if (LegProtectionTermXID is not null) writer.WriteString(41617, LegProtectionTermXID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegProtectionTermNotional = view.GetDouble(41618);
				LegProtectionTermCurrency = view.GetString(41619);
				LegProtectionTermSellerNotifies = view.GetBool(41620);
				LegProtectionTermBuyerNotifies = view.GetBool(41621);
				LegProtectionTermEventBusinessCenter = view.GetString(41622);
				LegProtectionTermStandardSources = view.GetBool(41623);
				LegProtectionTermEventMinimumSources = view.GetInt32(41624);
				if (view.GetView("LegProtectionTermEventNewsSourceGrp") is IMessageView viewLegProtectionTermEventNewsSourceGrp)
				{
					LegProtectionTermEventNewsSourceGrp = new();
					((IFixParser)LegProtectionTermEventNewsSourceGrp).Parse(viewLegProtectionTermEventNewsSourceGrp);
				}
				if (view.GetView("LegProtectionTermEventGrp") is IMessageView viewLegProtectionTermEventGrp)
				{
					LegProtectionTermEventGrp = new();
					((IFixParser)LegProtectionTermEventGrp).Parse(viewLegProtectionTermEventGrp);
				}
				if (view.GetView("LegProtectionTermObligationGrp") is IMessageView viewLegProtectionTermObligationGrp)
				{
					LegProtectionTermObligationGrp = new();
					((IFixParser)LegProtectionTermObligationGrp).Parse(viewLegProtectionTermObligationGrp);
				}
				LegProtectionTermXID = view.GetString(41617);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegProtectionTermNotional":
					{
						value = LegProtectionTermNotional;
						break;
					}
					case "LegProtectionTermCurrency":
					{
						value = LegProtectionTermCurrency;
						break;
					}
					case "LegProtectionTermSellerNotifies":
					{
						value = LegProtectionTermSellerNotifies;
						break;
					}
					case "LegProtectionTermBuyerNotifies":
					{
						value = LegProtectionTermBuyerNotifies;
						break;
					}
					case "LegProtectionTermEventBusinessCenter":
					{
						value = LegProtectionTermEventBusinessCenter;
						break;
					}
					case "LegProtectionTermStandardSources":
					{
						value = LegProtectionTermStandardSources;
						break;
					}
					case "LegProtectionTermEventMinimumSources":
					{
						value = LegProtectionTermEventMinimumSources;
						break;
					}
					case "LegProtectionTermEventNewsSourceGrp":
					{
						value = LegProtectionTermEventNewsSourceGrp;
						break;
					}
					case "LegProtectionTermEventGrp":
					{
						value = LegProtectionTermEventGrp;
						break;
					}
					case "LegProtectionTermObligationGrp":
					{
						value = LegProtectionTermObligationGrp;
						break;
					}
					case "LegProtectionTermXID":
					{
						value = LegProtectionTermXID;
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
				LegProtectionTermNotional = null;
				LegProtectionTermCurrency = null;
				LegProtectionTermSellerNotifies = null;
				LegProtectionTermBuyerNotifies = null;
				LegProtectionTermEventBusinessCenter = null;
				LegProtectionTermStandardSources = null;
				LegProtectionTermEventMinimumSources = null;
				((IFixReset?)LegProtectionTermEventNewsSourceGrp)?.Reset();
				((IFixReset?)LegProtectionTermEventGrp)?.Reset();
				((IFixReset?)LegProtectionTermObligationGrp)?.Reset();
				LegProtectionTermXID = null;
			}
		}
		[Group(NoOfTag = 41616, Offset = 0, Required = false)]
		public NoLegProtectionTerms[]? LegProtectionTerms {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegProtectionTerms is not null && LegProtectionTerms.Length != 0)
			{
				writer.WriteWholeNumber(41616, LegProtectionTerms.Length);
				for (int i = 0; i < LegProtectionTerms.Length; i++)
				{
					((IFixEncoder)LegProtectionTerms[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegProtectionTerms") is IMessageView viewNoLegProtectionTerms)
			{
				var count = viewNoLegProtectionTerms.GroupCount();
				LegProtectionTerms = new NoLegProtectionTerms[count];
				for (int i = 0; i < count; i++)
				{
					LegProtectionTerms[i] = new();
					((IFixParser)LegProtectionTerms[i]).Parse(viewNoLegProtectionTerms.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegProtectionTerms":
				{
					value = LegProtectionTerms;
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
			LegProtectionTerms = null;
		}
	}
}
