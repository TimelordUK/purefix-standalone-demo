using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ProtectionTermGrp : IFixComponent
	{
		public sealed partial class NoProtectionTerms : IFixGroup
		{
			[TagDetails(Tag = 40182, Type = TagType.Float, Offset = 0, Required = false)]
			public double? ProtectionTermNotional {get; set;}
			
			[TagDetails(Tag = 40183, Type = TagType.String, Offset = 1, Required = false)]
			public string? ProtectionTermCurrency {get; set;}
			
			[TagDetails(Tag = 40184, Type = TagType.Boolean, Offset = 2, Required = false)]
			public bool? ProtectionTermSellerNotifies {get; set;}
			
			[TagDetails(Tag = 40185, Type = TagType.Boolean, Offset = 3, Required = false)]
			public bool? ProtectionTermBuyerNotifies {get; set;}
			
			[TagDetails(Tag = 40186, Type = TagType.String, Offset = 4, Required = false)]
			public string? ProtectionTermEventBusinessCenter {get; set;}
			
			[TagDetails(Tag = 40187, Type = TagType.Boolean, Offset = 5, Required = false)]
			public bool? ProtectionTermStandardSources {get; set;}
			
			[TagDetails(Tag = 40188, Type = TagType.Int, Offset = 6, Required = false)]
			public int? ProtectionTermEventMinimumSources {get; set;}
			
			[Component(Offset = 7, Required = false)]
			public ProtectionTermEventNewsSourceGrp? ProtectionTermEventNewsSourceGrp {get; set;}
			
			[Component(Offset = 8, Required = false)]
			public ProtectionTermEventGrp? ProtectionTermEventGrp {get; set;}
			
			[Component(Offset = 9, Required = false)]
			public ProtectionTermObligationGrp? ProtectionTermObligationGrp {get; set;}
			
			[TagDetails(Tag = 40190, Type = TagType.String, Offset = 10, Required = false)]
			public string? ProtectionTermXID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ProtectionTermNotional is not null) writer.WriteNumber(40182, ProtectionTermNotional.Value);
				if (ProtectionTermCurrency is not null) writer.WriteString(40183, ProtectionTermCurrency);
				if (ProtectionTermSellerNotifies is not null) writer.WriteBoolean(40184, ProtectionTermSellerNotifies.Value);
				if (ProtectionTermBuyerNotifies is not null) writer.WriteBoolean(40185, ProtectionTermBuyerNotifies.Value);
				if (ProtectionTermEventBusinessCenter is not null) writer.WriteString(40186, ProtectionTermEventBusinessCenter);
				if (ProtectionTermStandardSources is not null) writer.WriteBoolean(40187, ProtectionTermStandardSources.Value);
				if (ProtectionTermEventMinimumSources is not null) writer.WriteWholeNumber(40188, ProtectionTermEventMinimumSources.Value);
				if (ProtectionTermEventNewsSourceGrp is not null) ((IFixEncoder)ProtectionTermEventNewsSourceGrp).Encode(writer);
				if (ProtectionTermEventGrp is not null) ((IFixEncoder)ProtectionTermEventGrp).Encode(writer);
				if (ProtectionTermObligationGrp is not null) ((IFixEncoder)ProtectionTermObligationGrp).Encode(writer);
				if (ProtectionTermXID is not null) writer.WriteString(40190, ProtectionTermXID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ProtectionTermNotional = view.GetDouble(40182);
				ProtectionTermCurrency = view.GetString(40183);
				ProtectionTermSellerNotifies = view.GetBool(40184);
				ProtectionTermBuyerNotifies = view.GetBool(40185);
				ProtectionTermEventBusinessCenter = view.GetString(40186);
				ProtectionTermStandardSources = view.GetBool(40187);
				ProtectionTermEventMinimumSources = view.GetInt32(40188);
				if (view.GetView("ProtectionTermEventNewsSourceGrp") is IMessageView viewProtectionTermEventNewsSourceGrp)
				{
					ProtectionTermEventNewsSourceGrp = new();
					((IFixParser)ProtectionTermEventNewsSourceGrp).Parse(viewProtectionTermEventNewsSourceGrp);
				}
				if (view.GetView("ProtectionTermEventGrp") is IMessageView viewProtectionTermEventGrp)
				{
					ProtectionTermEventGrp = new();
					((IFixParser)ProtectionTermEventGrp).Parse(viewProtectionTermEventGrp);
				}
				if (view.GetView("ProtectionTermObligationGrp") is IMessageView viewProtectionTermObligationGrp)
				{
					ProtectionTermObligationGrp = new();
					((IFixParser)ProtectionTermObligationGrp).Parse(viewProtectionTermObligationGrp);
				}
				ProtectionTermXID = view.GetString(40190);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ProtectionTermNotional":
					{
						value = ProtectionTermNotional;
						break;
					}
					case "ProtectionTermCurrency":
					{
						value = ProtectionTermCurrency;
						break;
					}
					case "ProtectionTermSellerNotifies":
					{
						value = ProtectionTermSellerNotifies;
						break;
					}
					case "ProtectionTermBuyerNotifies":
					{
						value = ProtectionTermBuyerNotifies;
						break;
					}
					case "ProtectionTermEventBusinessCenter":
					{
						value = ProtectionTermEventBusinessCenter;
						break;
					}
					case "ProtectionTermStandardSources":
					{
						value = ProtectionTermStandardSources;
						break;
					}
					case "ProtectionTermEventMinimumSources":
					{
						value = ProtectionTermEventMinimumSources;
						break;
					}
					case "ProtectionTermEventNewsSourceGrp":
					{
						value = ProtectionTermEventNewsSourceGrp;
						break;
					}
					case "ProtectionTermEventGrp":
					{
						value = ProtectionTermEventGrp;
						break;
					}
					case "ProtectionTermObligationGrp":
					{
						value = ProtectionTermObligationGrp;
						break;
					}
					case "ProtectionTermXID":
					{
						value = ProtectionTermXID;
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
				ProtectionTermNotional = null;
				ProtectionTermCurrency = null;
				ProtectionTermSellerNotifies = null;
				ProtectionTermBuyerNotifies = null;
				ProtectionTermEventBusinessCenter = null;
				ProtectionTermStandardSources = null;
				ProtectionTermEventMinimumSources = null;
				((IFixReset?)ProtectionTermEventNewsSourceGrp)?.Reset();
				((IFixReset?)ProtectionTermEventGrp)?.Reset();
				((IFixReset?)ProtectionTermObligationGrp)?.Reset();
				ProtectionTermXID = null;
			}
		}
		[Group(NoOfTag = 40181, Offset = 0, Required = false)]
		public NoProtectionTerms[]? ProtectionTerms {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ProtectionTerms is not null && ProtectionTerms.Length != 0)
			{
				writer.WriteWholeNumber(40181, ProtectionTerms.Length);
				for (int i = 0; i < ProtectionTerms.Length; i++)
				{
					((IFixEncoder)ProtectionTerms[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoProtectionTerms") is IMessageView viewNoProtectionTerms)
			{
				var count = viewNoProtectionTerms.GroupCount();
				ProtectionTerms = new NoProtectionTerms[count];
				for (int i = 0; i < count; i++)
				{
					ProtectionTerms[i] = new();
					((IFixParser)ProtectionTerms[i]).Parse(viewNoProtectionTerms.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoProtectionTerms":
				{
					value = ProtectionTerms;
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
			ProtectionTerms = null;
		}
	}
}
