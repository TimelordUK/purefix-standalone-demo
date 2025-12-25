using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingProtectionTermGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingProtectionTerms : IFixGroup
		{
			[TagDetails(Tag = 42069, Type = TagType.Float, Offset = 0, Required = false)]
			public double? UnderlyingProtectionTermNotional {get; set;}
			
			[TagDetails(Tag = 42070, Type = TagType.String, Offset = 1, Required = false)]
			public string? UnderlyingProtectionTermCurrency {get; set;}
			
			[TagDetails(Tag = 42071, Type = TagType.Boolean, Offset = 2, Required = false)]
			public bool? UnderlyingProtectionTermSellerNotifies {get; set;}
			
			[TagDetails(Tag = 42072, Type = TagType.Boolean, Offset = 3, Required = false)]
			public bool? UnderlyingProtectionTermBuyerNotifies {get; set;}
			
			[TagDetails(Tag = 42073, Type = TagType.String, Offset = 4, Required = false)]
			public string? UnderlyingProtectionTermEventBusinessCenter {get; set;}
			
			[TagDetails(Tag = 42074, Type = TagType.Boolean, Offset = 5, Required = false)]
			public bool? UnderlyingProtectionTermStandardSources {get; set;}
			
			[TagDetails(Tag = 42075, Type = TagType.Int, Offset = 6, Required = false)]
			public int? UnderlyingProtectionTermEventMinimumSources {get; set;}
			
			[Component(Offset = 7, Required = false)]
			public UnderlyingProtectionTermEventNewsSourceGrp? UnderlyingProtectionTermEventNewsSourceGrp {get; set;}
			
			[Component(Offset = 8, Required = false)]
			public UnderlyingProtectionTermEventGrp? UnderlyingProtectionTermEventGrp {get; set;}
			
			[Component(Offset = 9, Required = false)]
			public UnderlyingProtectionTermObligationGrp? UnderlyingProtectionTermObligationGrp {get; set;}
			
			[TagDetails(Tag = 42076, Type = TagType.String, Offset = 10, Required = false)]
			public string? UnderlyingProtectionTermXID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingProtectionTermNotional is not null) writer.WriteNumber(42069, UnderlyingProtectionTermNotional.Value);
				if (UnderlyingProtectionTermCurrency is not null) writer.WriteString(42070, UnderlyingProtectionTermCurrency);
				if (UnderlyingProtectionTermSellerNotifies is not null) writer.WriteBoolean(42071, UnderlyingProtectionTermSellerNotifies.Value);
				if (UnderlyingProtectionTermBuyerNotifies is not null) writer.WriteBoolean(42072, UnderlyingProtectionTermBuyerNotifies.Value);
				if (UnderlyingProtectionTermEventBusinessCenter is not null) writer.WriteString(42073, UnderlyingProtectionTermEventBusinessCenter);
				if (UnderlyingProtectionTermStandardSources is not null) writer.WriteBoolean(42074, UnderlyingProtectionTermStandardSources.Value);
				if (UnderlyingProtectionTermEventMinimumSources is not null) writer.WriteWholeNumber(42075, UnderlyingProtectionTermEventMinimumSources.Value);
				if (UnderlyingProtectionTermEventNewsSourceGrp is not null) ((IFixEncoder)UnderlyingProtectionTermEventNewsSourceGrp).Encode(writer);
				if (UnderlyingProtectionTermEventGrp is not null) ((IFixEncoder)UnderlyingProtectionTermEventGrp).Encode(writer);
				if (UnderlyingProtectionTermObligationGrp is not null) ((IFixEncoder)UnderlyingProtectionTermObligationGrp).Encode(writer);
				if (UnderlyingProtectionTermXID is not null) writer.WriteString(42076, UnderlyingProtectionTermXID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingProtectionTermNotional = view.GetDouble(42069);
				UnderlyingProtectionTermCurrency = view.GetString(42070);
				UnderlyingProtectionTermSellerNotifies = view.GetBool(42071);
				UnderlyingProtectionTermBuyerNotifies = view.GetBool(42072);
				UnderlyingProtectionTermEventBusinessCenter = view.GetString(42073);
				UnderlyingProtectionTermStandardSources = view.GetBool(42074);
				UnderlyingProtectionTermEventMinimumSources = view.GetInt32(42075);
				if (view.GetView("UnderlyingProtectionTermEventNewsSourceGrp") is IMessageView viewUnderlyingProtectionTermEventNewsSourceGrp)
				{
					UnderlyingProtectionTermEventNewsSourceGrp = new();
					((IFixParser)UnderlyingProtectionTermEventNewsSourceGrp).Parse(viewUnderlyingProtectionTermEventNewsSourceGrp);
				}
				if (view.GetView("UnderlyingProtectionTermEventGrp") is IMessageView viewUnderlyingProtectionTermEventGrp)
				{
					UnderlyingProtectionTermEventGrp = new();
					((IFixParser)UnderlyingProtectionTermEventGrp).Parse(viewUnderlyingProtectionTermEventGrp);
				}
				if (view.GetView("UnderlyingProtectionTermObligationGrp") is IMessageView viewUnderlyingProtectionTermObligationGrp)
				{
					UnderlyingProtectionTermObligationGrp = new();
					((IFixParser)UnderlyingProtectionTermObligationGrp).Parse(viewUnderlyingProtectionTermObligationGrp);
				}
				UnderlyingProtectionTermXID = view.GetString(42076);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingProtectionTermNotional":
					{
						value = UnderlyingProtectionTermNotional;
						break;
					}
					case "UnderlyingProtectionTermCurrency":
					{
						value = UnderlyingProtectionTermCurrency;
						break;
					}
					case "UnderlyingProtectionTermSellerNotifies":
					{
						value = UnderlyingProtectionTermSellerNotifies;
						break;
					}
					case "UnderlyingProtectionTermBuyerNotifies":
					{
						value = UnderlyingProtectionTermBuyerNotifies;
						break;
					}
					case "UnderlyingProtectionTermEventBusinessCenter":
					{
						value = UnderlyingProtectionTermEventBusinessCenter;
						break;
					}
					case "UnderlyingProtectionTermStandardSources":
					{
						value = UnderlyingProtectionTermStandardSources;
						break;
					}
					case "UnderlyingProtectionTermEventMinimumSources":
					{
						value = UnderlyingProtectionTermEventMinimumSources;
						break;
					}
					case "UnderlyingProtectionTermEventNewsSourceGrp":
					{
						value = UnderlyingProtectionTermEventNewsSourceGrp;
						break;
					}
					case "UnderlyingProtectionTermEventGrp":
					{
						value = UnderlyingProtectionTermEventGrp;
						break;
					}
					case "UnderlyingProtectionTermObligationGrp":
					{
						value = UnderlyingProtectionTermObligationGrp;
						break;
					}
					case "UnderlyingProtectionTermXID":
					{
						value = UnderlyingProtectionTermXID;
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
				UnderlyingProtectionTermNotional = null;
				UnderlyingProtectionTermCurrency = null;
				UnderlyingProtectionTermSellerNotifies = null;
				UnderlyingProtectionTermBuyerNotifies = null;
				UnderlyingProtectionTermEventBusinessCenter = null;
				UnderlyingProtectionTermStandardSources = null;
				UnderlyingProtectionTermEventMinimumSources = null;
				((IFixReset?)UnderlyingProtectionTermEventNewsSourceGrp)?.Reset();
				((IFixReset?)UnderlyingProtectionTermEventGrp)?.Reset();
				((IFixReset?)UnderlyingProtectionTermObligationGrp)?.Reset();
				UnderlyingProtectionTermXID = null;
			}
		}
		[Group(NoOfTag = 42068, Offset = 0, Required = false)]
		public NoUnderlyingProtectionTerms[]? UnderlyingProtectionTerms {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingProtectionTerms is not null && UnderlyingProtectionTerms.Length != 0)
			{
				writer.WriteWholeNumber(42068, UnderlyingProtectionTerms.Length);
				for (int i = 0; i < UnderlyingProtectionTerms.Length; i++)
				{
					((IFixEncoder)UnderlyingProtectionTerms[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingProtectionTerms") is IMessageView viewNoUnderlyingProtectionTerms)
			{
				var count = viewNoUnderlyingProtectionTerms.GroupCount();
				UnderlyingProtectionTerms = new NoUnderlyingProtectionTerms[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingProtectionTerms[i] = new();
					((IFixParser)UnderlyingProtectionTerms[i]).Parse(viewNoUnderlyingProtectionTerms.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingProtectionTerms":
				{
					value = UnderlyingProtectionTerms;
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
			UnderlyingProtectionTerms = null;
		}
	}
}
