using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingMarketDisruptionFallbackReferencePriceGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingMarketDisruptionFallbackReferencePrices : IFixGroup
		{
			[TagDetails(Tag = 41869, Type = TagType.Int, Offset = 0, Required = false)]
			public int? UnderlyingMarketDisruptionFallbackUnderlierType {get; set;}
			
			[TagDetails(Tag = 41870, Type = TagType.String, Offset = 1, Required = false)]
			public string? UnderlyingMarketDisruptionFallbackUnderlierSecurityID {get; set;}
			
			[TagDetails(Tag = 41871, Type = TagType.String, Offset = 2, Required = false)]
			public string? UnderlyingMarketDisruptionFallbackUnderlierSecurityIDSource {get; set;}
			
			[TagDetails(Tag = 41872, Type = TagType.String, Offset = 3, Required = false)]
			public string? UnderlyingMarketDisruptionFallbackUnderlierSecurityDesc {get; set;}
			
			[TagDetails(Tag = 41873, Type = TagType.Length, Offset = 4, Required = false)]
			public int? EncodedUnderlyingMarketDisruptionFallbackUnderlierSecDescLen {get; set;}
			
			[TagDetails(Tag = 41874, Type = TagType.RawData, Offset = 5, Required = false)]
			public byte[]? EncodedUnderlyingMarketDisruptionFallbackUnderlierSecurityDesc {get; set;}
			
			[TagDetails(Tag = 41875, Type = TagType.Float, Offset = 6, Required = false)]
			public double? UnderlyingMarketDisruptionFallbackOpenUnits {get; set;}
			
			[TagDetails(Tag = 41876, Type = TagType.String, Offset = 7, Required = false)]
			public string? UnderlyingMarketDisruptionFallbackBasketCurrency {get; set;}
			
			[TagDetails(Tag = 41877, Type = TagType.Float, Offset = 8, Required = false)]
			public double? UnderlyingMarketDisruptionFallbackBasketDivisor {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingMarketDisruptionFallbackUnderlierType is not null) writer.WriteWholeNumber(41869, UnderlyingMarketDisruptionFallbackUnderlierType.Value);
				if (UnderlyingMarketDisruptionFallbackUnderlierSecurityID is not null) writer.WriteString(41870, UnderlyingMarketDisruptionFallbackUnderlierSecurityID);
				if (UnderlyingMarketDisruptionFallbackUnderlierSecurityIDSource is not null) writer.WriteString(41871, UnderlyingMarketDisruptionFallbackUnderlierSecurityIDSource);
				if (UnderlyingMarketDisruptionFallbackUnderlierSecurityDesc is not null) writer.WriteString(41872, UnderlyingMarketDisruptionFallbackUnderlierSecurityDesc);
				if (EncodedUnderlyingMarketDisruptionFallbackUnderlierSecDescLen is not null) writer.WriteWholeNumber(41873, EncodedUnderlyingMarketDisruptionFallbackUnderlierSecDescLen.Value);
				if (EncodedUnderlyingMarketDisruptionFallbackUnderlierSecurityDesc is not null) writer.WriteBuffer(41874, EncodedUnderlyingMarketDisruptionFallbackUnderlierSecurityDesc);
				if (UnderlyingMarketDisruptionFallbackOpenUnits is not null) writer.WriteNumber(41875, UnderlyingMarketDisruptionFallbackOpenUnits.Value);
				if (UnderlyingMarketDisruptionFallbackBasketCurrency is not null) writer.WriteString(41876, UnderlyingMarketDisruptionFallbackBasketCurrency);
				if (UnderlyingMarketDisruptionFallbackBasketDivisor is not null) writer.WriteNumber(41877, UnderlyingMarketDisruptionFallbackBasketDivisor.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingMarketDisruptionFallbackUnderlierType = view.GetInt32(41869);
				UnderlyingMarketDisruptionFallbackUnderlierSecurityID = view.GetString(41870);
				UnderlyingMarketDisruptionFallbackUnderlierSecurityIDSource = view.GetString(41871);
				UnderlyingMarketDisruptionFallbackUnderlierSecurityDesc = view.GetString(41872);
				EncodedUnderlyingMarketDisruptionFallbackUnderlierSecDescLen = view.GetInt32(41873);
				EncodedUnderlyingMarketDisruptionFallbackUnderlierSecurityDesc = view.GetByteArray(41874);
				UnderlyingMarketDisruptionFallbackOpenUnits = view.GetDouble(41875);
				UnderlyingMarketDisruptionFallbackBasketCurrency = view.GetString(41876);
				UnderlyingMarketDisruptionFallbackBasketDivisor = view.GetDouble(41877);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingMarketDisruptionFallbackUnderlierType":
					{
						value = UnderlyingMarketDisruptionFallbackUnderlierType;
						break;
					}
					case "UnderlyingMarketDisruptionFallbackUnderlierSecurityID":
					{
						value = UnderlyingMarketDisruptionFallbackUnderlierSecurityID;
						break;
					}
					case "UnderlyingMarketDisruptionFallbackUnderlierSecurityIDSource":
					{
						value = UnderlyingMarketDisruptionFallbackUnderlierSecurityIDSource;
						break;
					}
					case "UnderlyingMarketDisruptionFallbackUnderlierSecurityDesc":
					{
						value = UnderlyingMarketDisruptionFallbackUnderlierSecurityDesc;
						break;
					}
					case "EncodedUnderlyingMarketDisruptionFallbackUnderlierSecDescLen":
					{
						value = EncodedUnderlyingMarketDisruptionFallbackUnderlierSecDescLen;
						break;
					}
					case "EncodedUnderlyingMarketDisruptionFallbackUnderlierSecurityDesc":
					{
						value = EncodedUnderlyingMarketDisruptionFallbackUnderlierSecurityDesc;
						break;
					}
					case "UnderlyingMarketDisruptionFallbackOpenUnits":
					{
						value = UnderlyingMarketDisruptionFallbackOpenUnits;
						break;
					}
					case "UnderlyingMarketDisruptionFallbackBasketCurrency":
					{
						value = UnderlyingMarketDisruptionFallbackBasketCurrency;
						break;
					}
					case "UnderlyingMarketDisruptionFallbackBasketDivisor":
					{
						value = UnderlyingMarketDisruptionFallbackBasketDivisor;
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
				UnderlyingMarketDisruptionFallbackUnderlierType = null;
				UnderlyingMarketDisruptionFallbackUnderlierSecurityID = null;
				UnderlyingMarketDisruptionFallbackUnderlierSecurityIDSource = null;
				UnderlyingMarketDisruptionFallbackUnderlierSecurityDesc = null;
				EncodedUnderlyingMarketDisruptionFallbackUnderlierSecDescLen = null;
				EncodedUnderlyingMarketDisruptionFallbackUnderlierSecurityDesc = null;
				UnderlyingMarketDisruptionFallbackOpenUnits = null;
				UnderlyingMarketDisruptionFallbackBasketCurrency = null;
				UnderlyingMarketDisruptionFallbackBasketDivisor = null;
			}
		}
		[Group(NoOfTag = 41868, Offset = 0, Required = false)]
		public NoUnderlyingMarketDisruptionFallbackReferencePrices[]? UnderlyingMarketDisruptionFallbackReferencePrices {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingMarketDisruptionFallbackReferencePrices is not null && UnderlyingMarketDisruptionFallbackReferencePrices.Length != 0)
			{
				writer.WriteWholeNumber(41868, UnderlyingMarketDisruptionFallbackReferencePrices.Length);
				for (int i = 0; i < UnderlyingMarketDisruptionFallbackReferencePrices.Length; i++)
				{
					((IFixEncoder)UnderlyingMarketDisruptionFallbackReferencePrices[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingMarketDisruptionFallbackReferencePrices") is IMessageView viewNoUnderlyingMarketDisruptionFallbackReferencePrices)
			{
				var count = viewNoUnderlyingMarketDisruptionFallbackReferencePrices.GroupCount();
				UnderlyingMarketDisruptionFallbackReferencePrices = new NoUnderlyingMarketDisruptionFallbackReferencePrices[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingMarketDisruptionFallbackReferencePrices[i] = new();
					((IFixParser)UnderlyingMarketDisruptionFallbackReferencePrices[i]).Parse(viewNoUnderlyingMarketDisruptionFallbackReferencePrices.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingMarketDisruptionFallbackReferencePrices":
				{
					value = UnderlyingMarketDisruptionFallbackReferencePrices;
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
			UnderlyingMarketDisruptionFallbackReferencePrices = null;
		}
	}
}
