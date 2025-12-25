using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPhysicalSettlTermGrp : IFixComponent
	{
		public sealed partial class NoLegPhysicalSettlTerms : IFixGroup
		{
			[Component(Offset = 0, Required = false)]
			public LegPhysicalSettlDeliverableObligationGrp? LegPhysicalSettlDeliverableObligationGrp {get; set;}
			
			[TagDetails(Tag = 41601, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegPhysicalSettlCurency {get; set;}
			
			[TagDetails(Tag = 41602, Type = TagType.Int, Offset = 2, Required = false)]
			public int? LegPhysicalSettlBusinessDays {get; set;}
			
			[TagDetails(Tag = 41603, Type = TagType.Int, Offset = 3, Required = false)]
			public int? LegPhysicalSettlMaximumBusinessDays {get; set;}
			
			[TagDetails(Tag = 41600, Type = TagType.String, Offset = 4, Required = false)]
			public string? LegPhysicalSettlTermXID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegPhysicalSettlDeliverableObligationGrp is not null) ((IFixEncoder)LegPhysicalSettlDeliverableObligationGrp).Encode(writer);
				if (LegPhysicalSettlCurency is not null) writer.WriteString(41601, LegPhysicalSettlCurency);
				if (LegPhysicalSettlBusinessDays is not null) writer.WriteWholeNumber(41602, LegPhysicalSettlBusinessDays.Value);
				if (LegPhysicalSettlMaximumBusinessDays is not null) writer.WriteWholeNumber(41603, LegPhysicalSettlMaximumBusinessDays.Value);
				if (LegPhysicalSettlTermXID is not null) writer.WriteString(41600, LegPhysicalSettlTermXID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				if (view.GetView("LegPhysicalSettlDeliverableObligationGrp") is IMessageView viewLegPhysicalSettlDeliverableObligationGrp)
				{
					LegPhysicalSettlDeliverableObligationGrp = new();
					((IFixParser)LegPhysicalSettlDeliverableObligationGrp).Parse(viewLegPhysicalSettlDeliverableObligationGrp);
				}
				LegPhysicalSettlCurency = view.GetString(41601);
				LegPhysicalSettlBusinessDays = view.GetInt32(41602);
				LegPhysicalSettlMaximumBusinessDays = view.GetInt32(41603);
				LegPhysicalSettlTermXID = view.GetString(41600);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegPhysicalSettlDeliverableObligationGrp":
					{
						value = LegPhysicalSettlDeliverableObligationGrp;
						break;
					}
					case "LegPhysicalSettlCurency":
					{
						value = LegPhysicalSettlCurency;
						break;
					}
					case "LegPhysicalSettlBusinessDays":
					{
						value = LegPhysicalSettlBusinessDays;
						break;
					}
					case "LegPhysicalSettlMaximumBusinessDays":
					{
						value = LegPhysicalSettlMaximumBusinessDays;
						break;
					}
					case "LegPhysicalSettlTermXID":
					{
						value = LegPhysicalSettlTermXID;
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
				((IFixReset?)LegPhysicalSettlDeliverableObligationGrp)?.Reset();
				LegPhysicalSettlCurency = null;
				LegPhysicalSettlBusinessDays = null;
				LegPhysicalSettlMaximumBusinessDays = null;
				LegPhysicalSettlTermXID = null;
			}
		}
		[Group(NoOfTag = 41599, Offset = 0, Required = false)]
		public NoLegPhysicalSettlTerms[]? LegPhysicalSettlTerms {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPhysicalSettlTerms is not null && LegPhysicalSettlTerms.Length != 0)
			{
				writer.WriteWholeNumber(41599, LegPhysicalSettlTerms.Length);
				for (int i = 0; i < LegPhysicalSettlTerms.Length; i++)
				{
					((IFixEncoder)LegPhysicalSettlTerms[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegPhysicalSettlTerms") is IMessageView viewNoLegPhysicalSettlTerms)
			{
				var count = viewNoLegPhysicalSettlTerms.GroupCount();
				LegPhysicalSettlTerms = new NoLegPhysicalSettlTerms[count];
				for (int i = 0; i < count; i++)
				{
					LegPhysicalSettlTerms[i] = new();
					((IFixParser)LegPhysicalSettlTerms[i]).Parse(viewNoLegPhysicalSettlTerms.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegPhysicalSettlTerms":
				{
					value = LegPhysicalSettlTerms;
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
			LegPhysicalSettlTerms = null;
		}
	}
}
