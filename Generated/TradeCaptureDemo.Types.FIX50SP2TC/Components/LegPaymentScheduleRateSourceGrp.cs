using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentScheduleRateSourceGrp : IFixComponent
	{
		public sealed partial class NoLegPaymentScheduleRateSources : IFixGroup
		{
			[TagDetails(Tag = 40415, Type = TagType.Int, Offset = 0, Required = false)]
			public int? LegPaymentScheduleRateSource {get; set;}
			
			[TagDetails(Tag = 40416, Type = TagType.Int, Offset = 1, Required = false)]
			public int? LegPaymentScheduleRateSourceType {get; set;}
			
			[TagDetails(Tag = 40417, Type = TagType.String, Offset = 2, Required = false)]
			public string? LegPaymentScheduleReferencePage {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegPaymentScheduleRateSource is not null) writer.WriteWholeNumber(40415, LegPaymentScheduleRateSource.Value);
				if (LegPaymentScheduleRateSourceType is not null) writer.WriteWholeNumber(40416, LegPaymentScheduleRateSourceType.Value);
				if (LegPaymentScheduleReferencePage is not null) writer.WriteString(40417, LegPaymentScheduleReferencePage);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegPaymentScheduleRateSource = view.GetInt32(40415);
				LegPaymentScheduleRateSourceType = view.GetInt32(40416);
				LegPaymentScheduleReferencePage = view.GetString(40417);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegPaymentScheduleRateSource":
					{
						value = LegPaymentScheduleRateSource;
						break;
					}
					case "LegPaymentScheduleRateSourceType":
					{
						value = LegPaymentScheduleRateSourceType;
						break;
					}
					case "LegPaymentScheduleReferencePage":
					{
						value = LegPaymentScheduleReferencePage;
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
				LegPaymentScheduleRateSource = null;
				LegPaymentScheduleRateSourceType = null;
				LegPaymentScheduleReferencePage = null;
			}
		}
		[Group(NoOfTag = 40414, Offset = 0, Required = false)]
		public NoLegPaymentScheduleRateSources[]? LegPaymentScheduleRateSources {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentScheduleRateSources is not null && LegPaymentScheduleRateSources.Length != 0)
			{
				writer.WriteWholeNumber(40414, LegPaymentScheduleRateSources.Length);
				for (int i = 0; i < LegPaymentScheduleRateSources.Length; i++)
				{
					((IFixEncoder)LegPaymentScheduleRateSources[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegPaymentScheduleRateSources") is IMessageView viewNoLegPaymentScheduleRateSources)
			{
				var count = viewNoLegPaymentScheduleRateSources.GroupCount();
				LegPaymentScheduleRateSources = new NoLegPaymentScheduleRateSources[count];
				for (int i = 0; i < count; i++)
				{
					LegPaymentScheduleRateSources[i] = new();
					((IFixParser)LegPaymentScheduleRateSources[i]).Parse(viewNoLegPaymentScheduleRateSources.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegPaymentScheduleRateSources":
				{
					value = LegPaymentScheduleRateSources;
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
			LegPaymentScheduleRateSources = null;
		}
	}
}
