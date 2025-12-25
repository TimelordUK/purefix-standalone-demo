using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PhysicalSettlTermGrp : IFixComponent
	{
		public sealed partial class NoPhysicalSettlTerms : IFixGroup
		{
			[Component(Offset = 0, Required = false)]
			public PhysicalSettlDeliverableObligationGrp? PhysicalSettlDeliverableObligationGrp {get; set;}
			
			[TagDetails(Tag = 40205, Type = TagType.String, Offset = 1, Required = false)]
			public string? PhysicalSettlCurrency {get; set;}
			
			[TagDetails(Tag = 40206, Type = TagType.Int, Offset = 2, Required = false)]
			public int? PhysicalSettlBusinessDays {get; set;}
			
			[TagDetails(Tag = 40207, Type = TagType.Int, Offset = 3, Required = false)]
			public int? PhysicalSettlMaximumBusinessDays {get; set;}
			
			[TagDetails(Tag = 40208, Type = TagType.String, Offset = 4, Required = false)]
			public string? PhysicalSettlTermXID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PhysicalSettlDeliverableObligationGrp is not null) ((IFixEncoder)PhysicalSettlDeliverableObligationGrp).Encode(writer);
				if (PhysicalSettlCurrency is not null) writer.WriteString(40205, PhysicalSettlCurrency);
				if (PhysicalSettlBusinessDays is not null) writer.WriteWholeNumber(40206, PhysicalSettlBusinessDays.Value);
				if (PhysicalSettlMaximumBusinessDays is not null) writer.WriteWholeNumber(40207, PhysicalSettlMaximumBusinessDays.Value);
				if (PhysicalSettlTermXID is not null) writer.WriteString(40208, PhysicalSettlTermXID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				if (view.GetView("PhysicalSettlDeliverableObligationGrp") is IMessageView viewPhysicalSettlDeliverableObligationGrp)
				{
					PhysicalSettlDeliverableObligationGrp = new();
					((IFixParser)PhysicalSettlDeliverableObligationGrp).Parse(viewPhysicalSettlDeliverableObligationGrp);
				}
				PhysicalSettlCurrency = view.GetString(40205);
				PhysicalSettlBusinessDays = view.GetInt32(40206);
				PhysicalSettlMaximumBusinessDays = view.GetInt32(40207);
				PhysicalSettlTermXID = view.GetString(40208);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PhysicalSettlDeliverableObligationGrp":
					{
						value = PhysicalSettlDeliverableObligationGrp;
						break;
					}
					case "PhysicalSettlCurrency":
					{
						value = PhysicalSettlCurrency;
						break;
					}
					case "PhysicalSettlBusinessDays":
					{
						value = PhysicalSettlBusinessDays;
						break;
					}
					case "PhysicalSettlMaximumBusinessDays":
					{
						value = PhysicalSettlMaximumBusinessDays;
						break;
					}
					case "PhysicalSettlTermXID":
					{
						value = PhysicalSettlTermXID;
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
				((IFixReset?)PhysicalSettlDeliverableObligationGrp)?.Reset();
				PhysicalSettlCurrency = null;
				PhysicalSettlBusinessDays = null;
				PhysicalSettlMaximumBusinessDays = null;
				PhysicalSettlTermXID = null;
			}
		}
		[Group(NoOfTag = 40204, Offset = 0, Required = false)]
		public NoPhysicalSettlTerms[]? PhysicalSettlTerms {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PhysicalSettlTerms is not null && PhysicalSettlTerms.Length != 0)
			{
				writer.WriteWholeNumber(40204, PhysicalSettlTerms.Length);
				for (int i = 0; i < PhysicalSettlTerms.Length; i++)
				{
					((IFixEncoder)PhysicalSettlTerms[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPhysicalSettlTerms") is IMessageView viewNoPhysicalSettlTerms)
			{
				var count = viewNoPhysicalSettlTerms.GroupCount();
				PhysicalSettlTerms = new NoPhysicalSettlTerms[count];
				for (int i = 0; i < count; i++)
				{
					PhysicalSettlTerms[i] = new();
					((IFixParser)PhysicalSettlTerms[i]).Parse(viewNoPhysicalSettlTerms.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPhysicalSettlTerms":
				{
					value = PhysicalSettlTerms;
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
			PhysicalSettlTerms = null;
		}
	}
}
