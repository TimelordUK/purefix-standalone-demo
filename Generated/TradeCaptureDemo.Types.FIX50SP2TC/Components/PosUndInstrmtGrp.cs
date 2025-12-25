using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PosUndInstrmtGrp : IFixComponent
	{
		public sealed partial class NoUnderlyings : IFixGroup
		{
			[Component(Offset = 0, Required = false)]
			public UnderlyingInstrument? UnderlyingInstrument {get; set;}
			
			[TagDetails(Tag = 732, Type = TagType.Float, Offset = 1, Required = false)]
			public double? UnderlyingSettlPrice {get; set;}
			
			[TagDetails(Tag = 733, Type = TagType.Int, Offset = 2, Required = false)]
			public int? UnderlyingSettlPriceType {get; set;}
			
			[TagDetails(Tag = 1037, Type = TagType.Float, Offset = 3, Required = false)]
			public double? UnderlyingDeliveryAmount {get; set;}
			
			[Component(Offset = 4, Required = false)]
			public UnderlyingAmount? UnderlyingAmount {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingInstrument is not null) ((IFixEncoder)UnderlyingInstrument).Encode(writer);
				if (UnderlyingSettlPrice is not null) writer.WriteNumber(732, UnderlyingSettlPrice.Value);
				if (UnderlyingSettlPriceType is not null) writer.WriteWholeNumber(733, UnderlyingSettlPriceType.Value);
				if (UnderlyingDeliveryAmount is not null) writer.WriteNumber(1037, UnderlyingDeliveryAmount.Value);
				if (UnderlyingAmount is not null) ((IFixEncoder)UnderlyingAmount).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				if (view.GetView("UnderlyingInstrument") is IMessageView viewUnderlyingInstrument)
				{
					UnderlyingInstrument = new();
					((IFixParser)UnderlyingInstrument).Parse(viewUnderlyingInstrument);
				}
				UnderlyingSettlPrice = view.GetDouble(732);
				UnderlyingSettlPriceType = view.GetInt32(733);
				UnderlyingDeliveryAmount = view.GetDouble(1037);
				if (view.GetView("UnderlyingAmount") is IMessageView viewUnderlyingAmount)
				{
					UnderlyingAmount = new();
					((IFixParser)UnderlyingAmount).Parse(viewUnderlyingAmount);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingInstrument":
					{
						value = UnderlyingInstrument;
						break;
					}
					case "UnderlyingSettlPrice":
					{
						value = UnderlyingSettlPrice;
						break;
					}
					case "UnderlyingSettlPriceType":
					{
						value = UnderlyingSettlPriceType;
						break;
					}
					case "UnderlyingDeliveryAmount":
					{
						value = UnderlyingDeliveryAmount;
						break;
					}
					case "UnderlyingAmount":
					{
						value = UnderlyingAmount;
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
				((IFixReset?)UnderlyingInstrument)?.Reset();
				UnderlyingSettlPrice = null;
				UnderlyingSettlPriceType = null;
				UnderlyingDeliveryAmount = null;
				((IFixReset?)UnderlyingAmount)?.Reset();
			}
		}
		[Group(NoOfTag = 711, Offset = 0, Required = false)]
		public NoUnderlyings[]? Underlyings {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Underlyings is not null && Underlyings.Length != 0)
			{
				writer.WriteWholeNumber(711, Underlyings.Length);
				for (int i = 0; i < Underlyings.Length; i++)
				{
					((IFixEncoder)Underlyings[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyings") is IMessageView viewNoUnderlyings)
			{
				var count = viewNoUnderlyings.GroupCount();
				Underlyings = new NoUnderlyings[count];
				for (int i = 0; i < count; i++)
				{
					Underlyings[i] = new();
					((IFixParser)Underlyings[i]).Parse(viewNoUnderlyings.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyings":
				{
					value = Underlyings;
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
			Underlyings = null;
		}
	}
}
