using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class RateSource : IFixComponent
	{
		public sealed partial class NoRateSources : IFixGroup
		{
			[TagDetails(Tag = 1446, Type = TagType.Int, Offset = 0, Required = false)]
			public int? RateSource {get; set;}
			
			[TagDetails(Tag = 1447, Type = TagType.Int, Offset = 1, Required = false)]
			public int? RateSourceType {get; set;}
			
			[TagDetails(Tag = 1448, Type = TagType.String, Offset = 2, Required = false)]
			public string? ReferencePage {get; set;}
			
			[TagDetails(Tag = 2412, Type = TagType.String, Offset = 3, Required = false)]
			public string? RateSourceReferemcePageHeading {get; set;}
			
			[TagDetails(Tag = 2796, Type = TagType.String, Offset = 4, Required = false)]
			public string? FXBenchmarkRateFix {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (RateSource is not null) writer.WriteWholeNumber(1446, RateSource.Value);
				if (RateSourceType is not null) writer.WriteWholeNumber(1447, RateSourceType.Value);
				if (ReferencePage is not null) writer.WriteString(1448, ReferencePage);
				if (RateSourceReferemcePageHeading is not null) writer.WriteString(2412, RateSourceReferemcePageHeading);
				if (FXBenchmarkRateFix is not null) writer.WriteString(2796, FXBenchmarkRateFix);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				RateSource = view.GetInt32(1446);
				RateSourceType = view.GetInt32(1447);
				ReferencePage = view.GetString(1448);
				RateSourceReferemcePageHeading = view.GetString(2412);
				FXBenchmarkRateFix = view.GetString(2796);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "RateSource":
					{
						value = RateSource;
						break;
					}
					case "RateSourceType":
					{
						value = RateSourceType;
						break;
					}
					case "ReferencePage":
					{
						value = ReferencePage;
						break;
					}
					case "RateSourceReferemcePageHeading":
					{
						value = RateSourceReferemcePageHeading;
						break;
					}
					case "FXBenchmarkRateFix":
					{
						value = FXBenchmarkRateFix;
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
				RateSource = null;
				RateSourceType = null;
				ReferencePage = null;
				RateSourceReferemcePageHeading = null;
				FXBenchmarkRateFix = null;
			}
		}
		[Group(NoOfTag = 1445, Offset = 0, Required = false)]
		public NoRateSources[]? RateSources {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (RateSources is not null && RateSources.Length != 0)
			{
				writer.WriteWholeNumber(1445, RateSources.Length);
				for (int i = 0; i < RateSources.Length; i++)
				{
					((IFixEncoder)RateSources[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoRateSources") is IMessageView viewNoRateSources)
			{
				var count = viewNoRateSources.GroupCount();
				RateSources = new NoRateSources[count];
				for (int i = 0; i < count; i++)
				{
					RateSources[i] = new();
					((IFixParser)RateSources[i]).Parse(viewNoRateSources.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoRateSources":
				{
					value = RateSources;
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
			RateSources = null;
		}
	}
}
