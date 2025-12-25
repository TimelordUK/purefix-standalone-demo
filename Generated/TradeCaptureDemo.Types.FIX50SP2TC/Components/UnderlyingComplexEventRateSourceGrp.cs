using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingComplexEventRateSourceGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingComplexEventRateSources : IFixGroup
		{
			[TagDetails(Tag = 41733, Type = TagType.Int, Offset = 0, Required = false)]
			public int? UnderlyingComplexEventRateSource {get; set;}
			
			[TagDetails(Tag = 41734, Type = TagType.Int, Offset = 1, Required = false)]
			public int? UnderlyingComplexEventRateSourceType {get; set;}
			
			[TagDetails(Tag = 41735, Type = TagType.String, Offset = 2, Required = false)]
			public string? UnderlyingComplexEventReferencePage {get; set;}
			
			[TagDetails(Tag = 41736, Type = TagType.String, Offset = 3, Required = false)]
			public string? UnderlyingComplexEventReferencePageHeading {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingComplexEventRateSource is not null) writer.WriteWholeNumber(41733, UnderlyingComplexEventRateSource.Value);
				if (UnderlyingComplexEventRateSourceType is not null) writer.WriteWholeNumber(41734, UnderlyingComplexEventRateSourceType.Value);
				if (UnderlyingComplexEventReferencePage is not null) writer.WriteString(41735, UnderlyingComplexEventReferencePage);
				if (UnderlyingComplexEventReferencePageHeading is not null) writer.WriteString(41736, UnderlyingComplexEventReferencePageHeading);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingComplexEventRateSource = view.GetInt32(41733);
				UnderlyingComplexEventRateSourceType = view.GetInt32(41734);
				UnderlyingComplexEventReferencePage = view.GetString(41735);
				UnderlyingComplexEventReferencePageHeading = view.GetString(41736);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingComplexEventRateSource":
					{
						value = UnderlyingComplexEventRateSource;
						break;
					}
					case "UnderlyingComplexEventRateSourceType":
					{
						value = UnderlyingComplexEventRateSourceType;
						break;
					}
					case "UnderlyingComplexEventReferencePage":
					{
						value = UnderlyingComplexEventReferencePage;
						break;
					}
					case "UnderlyingComplexEventReferencePageHeading":
					{
						value = UnderlyingComplexEventReferencePageHeading;
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
				UnderlyingComplexEventRateSource = null;
				UnderlyingComplexEventRateSourceType = null;
				UnderlyingComplexEventReferencePage = null;
				UnderlyingComplexEventReferencePageHeading = null;
			}
		}
		[Group(NoOfTag = 41732, Offset = 0, Required = false)]
		public NoUnderlyingComplexEventRateSources[]? UnderlyingComplexEventRateSources {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingComplexEventRateSources is not null && UnderlyingComplexEventRateSources.Length != 0)
			{
				writer.WriteWholeNumber(41732, UnderlyingComplexEventRateSources.Length);
				for (int i = 0; i < UnderlyingComplexEventRateSources.Length; i++)
				{
					((IFixEncoder)UnderlyingComplexEventRateSources[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingComplexEventRateSources") is IMessageView viewNoUnderlyingComplexEventRateSources)
			{
				var count = viewNoUnderlyingComplexEventRateSources.GroupCount();
				UnderlyingComplexEventRateSources = new NoUnderlyingComplexEventRateSources[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingComplexEventRateSources[i] = new();
					((IFixParser)UnderlyingComplexEventRateSources[i]).Parse(viewNoUnderlyingComplexEventRateSources.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingComplexEventRateSources":
				{
					value = UnderlyingComplexEventRateSources;
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
			UnderlyingComplexEventRateSources = null;
		}
	}
}
