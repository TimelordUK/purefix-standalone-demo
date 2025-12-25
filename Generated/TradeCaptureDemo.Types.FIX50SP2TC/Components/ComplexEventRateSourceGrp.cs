using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ComplexEventRateSourceGrp : IFixComponent
	{
		public sealed partial class NoComplexEventRateSources : IFixGroup
		{
			[TagDetails(Tag = 41014, Type = TagType.Int, Offset = 0, Required = false)]
			public int? ComplexEventRateSource {get; set;}
			
			[TagDetails(Tag = 41015, Type = TagType.Int, Offset = 1, Required = false)]
			public int? ComplexEventRateSourceType {get; set;}
			
			[TagDetails(Tag = 41016, Type = TagType.String, Offset = 2, Required = false)]
			public string? ComplexEventReferencePage {get; set;}
			
			[TagDetails(Tag = 41017, Type = TagType.String, Offset = 3, Required = false)]
			public string? ComplexEventReferencePageHeading {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ComplexEventRateSource is not null) writer.WriteWholeNumber(41014, ComplexEventRateSource.Value);
				if (ComplexEventRateSourceType is not null) writer.WriteWholeNumber(41015, ComplexEventRateSourceType.Value);
				if (ComplexEventReferencePage is not null) writer.WriteString(41016, ComplexEventReferencePage);
				if (ComplexEventReferencePageHeading is not null) writer.WriteString(41017, ComplexEventReferencePageHeading);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ComplexEventRateSource = view.GetInt32(41014);
				ComplexEventRateSourceType = view.GetInt32(41015);
				ComplexEventReferencePage = view.GetString(41016);
				ComplexEventReferencePageHeading = view.GetString(41017);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ComplexEventRateSource":
					{
						value = ComplexEventRateSource;
						break;
					}
					case "ComplexEventRateSourceType":
					{
						value = ComplexEventRateSourceType;
						break;
					}
					case "ComplexEventReferencePage":
					{
						value = ComplexEventReferencePage;
						break;
					}
					case "ComplexEventReferencePageHeading":
					{
						value = ComplexEventReferencePageHeading;
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
				ComplexEventRateSource = null;
				ComplexEventRateSourceType = null;
				ComplexEventReferencePage = null;
				ComplexEventReferencePageHeading = null;
			}
		}
		[Group(NoOfTag = 41013, Offset = 0, Required = false)]
		public NoComplexEventRateSources[]? ComplexEventRateSources {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ComplexEventRateSources is not null && ComplexEventRateSources.Length != 0)
			{
				writer.WriteWholeNumber(41013, ComplexEventRateSources.Length);
				for (int i = 0; i < ComplexEventRateSources.Length; i++)
				{
					((IFixEncoder)ComplexEventRateSources[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoComplexEventRateSources") is IMessageView viewNoComplexEventRateSources)
			{
				var count = viewNoComplexEventRateSources.GroupCount();
				ComplexEventRateSources = new NoComplexEventRateSources[count];
				for (int i = 0; i < count; i++)
				{
					ComplexEventRateSources[i] = new();
					((IFixParser)ComplexEventRateSources[i]).Parse(viewNoComplexEventRateSources.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoComplexEventRateSources":
				{
					value = ComplexEventRateSources;
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
			ComplexEventRateSources = null;
		}
	}
}
