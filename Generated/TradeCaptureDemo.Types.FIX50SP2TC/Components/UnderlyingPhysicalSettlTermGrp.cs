using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPhysicalSettlTermGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingPhysicalSettlTerms : IFixGroup
		{
			[Component(Offset = 0, Required = false)]
			public UnderlyingPhysicalSettlDeliverableObligationGrp? UnderlyingPhysicalSettlDeliverableObligationGrp {get; set;}
			
			[TagDetails(Tag = 42061, Type = TagType.String, Offset = 1, Required = false)]
			public string? UnderlyingPhysicalSettlCurrency {get; set;}
			
			[TagDetails(Tag = 42062, Type = TagType.Int, Offset = 2, Required = false)]
			public int? UnderlyingPhysicalSettlBusinessDays {get; set;}
			
			[TagDetails(Tag = 42063, Type = TagType.Int, Offset = 3, Required = false)]
			public int? UnderlyingPhysicalSettlMaximumBusinessDays {get; set;}
			
			[TagDetails(Tag = 42064, Type = TagType.String, Offset = 4, Required = false)]
			public string? UnderlyingPhysicalSettlTermXID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingPhysicalSettlDeliverableObligationGrp is not null) ((IFixEncoder)UnderlyingPhysicalSettlDeliverableObligationGrp).Encode(writer);
				if (UnderlyingPhysicalSettlCurrency is not null) writer.WriteString(42061, UnderlyingPhysicalSettlCurrency);
				if (UnderlyingPhysicalSettlBusinessDays is not null) writer.WriteWholeNumber(42062, UnderlyingPhysicalSettlBusinessDays.Value);
				if (UnderlyingPhysicalSettlMaximumBusinessDays is not null) writer.WriteWholeNumber(42063, UnderlyingPhysicalSettlMaximumBusinessDays.Value);
				if (UnderlyingPhysicalSettlTermXID is not null) writer.WriteString(42064, UnderlyingPhysicalSettlTermXID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				if (view.GetView("UnderlyingPhysicalSettlDeliverableObligationGrp") is IMessageView viewUnderlyingPhysicalSettlDeliverableObligationGrp)
				{
					UnderlyingPhysicalSettlDeliverableObligationGrp = new();
					((IFixParser)UnderlyingPhysicalSettlDeliverableObligationGrp).Parse(viewUnderlyingPhysicalSettlDeliverableObligationGrp);
				}
				UnderlyingPhysicalSettlCurrency = view.GetString(42061);
				UnderlyingPhysicalSettlBusinessDays = view.GetInt32(42062);
				UnderlyingPhysicalSettlMaximumBusinessDays = view.GetInt32(42063);
				UnderlyingPhysicalSettlTermXID = view.GetString(42064);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingPhysicalSettlDeliverableObligationGrp":
					{
						value = UnderlyingPhysicalSettlDeliverableObligationGrp;
						break;
					}
					case "UnderlyingPhysicalSettlCurrency":
					{
						value = UnderlyingPhysicalSettlCurrency;
						break;
					}
					case "UnderlyingPhysicalSettlBusinessDays":
					{
						value = UnderlyingPhysicalSettlBusinessDays;
						break;
					}
					case "UnderlyingPhysicalSettlMaximumBusinessDays":
					{
						value = UnderlyingPhysicalSettlMaximumBusinessDays;
						break;
					}
					case "UnderlyingPhysicalSettlTermXID":
					{
						value = UnderlyingPhysicalSettlTermXID;
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
				((IFixReset?)UnderlyingPhysicalSettlDeliverableObligationGrp)?.Reset();
				UnderlyingPhysicalSettlCurrency = null;
				UnderlyingPhysicalSettlBusinessDays = null;
				UnderlyingPhysicalSettlMaximumBusinessDays = null;
				UnderlyingPhysicalSettlTermXID = null;
			}
		}
		[Group(NoOfTag = 42060, Offset = 0, Required = false)]
		public NoUnderlyingPhysicalSettlTerms[]? UnderlyingPhysicalSettlTerms {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPhysicalSettlTerms is not null && UnderlyingPhysicalSettlTerms.Length != 0)
			{
				writer.WriteWholeNumber(42060, UnderlyingPhysicalSettlTerms.Length);
				for (int i = 0; i < UnderlyingPhysicalSettlTerms.Length; i++)
				{
					((IFixEncoder)UnderlyingPhysicalSettlTerms[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingPhysicalSettlTerms") is IMessageView viewNoUnderlyingPhysicalSettlTerms)
			{
				var count = viewNoUnderlyingPhysicalSettlTerms.GroupCount();
				UnderlyingPhysicalSettlTerms = new NoUnderlyingPhysicalSettlTerms[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingPhysicalSettlTerms[i] = new();
					((IFixParser)UnderlyingPhysicalSettlTerms[i]).Parse(viewNoUnderlyingPhysicalSettlTerms.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingPhysicalSettlTerms":
				{
					value = UnderlyingPhysicalSettlTerms;
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
			UnderlyingPhysicalSettlTerms = null;
		}
	}
}
