using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegComplexEventAveragingObservationGrp : IFixComponent
	{
		public sealed partial class NoLegComplexEventAveragingObservations : IFixGroup
		{
			[TagDetails(Tag = 41364, Type = TagType.Int, Offset = 0, Required = false)]
			public int? LegComplexEventAveragingObservationNumber {get; set;}
			
			[TagDetails(Tag = 41365, Type = TagType.Float, Offset = 1, Required = false)]
			public double? LegComplexEventAveragingWeight {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegComplexEventAveragingObservationNumber is not null) writer.WriteWholeNumber(41364, LegComplexEventAveragingObservationNumber.Value);
				if (LegComplexEventAveragingWeight is not null) writer.WriteNumber(41365, LegComplexEventAveragingWeight.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegComplexEventAveragingObservationNumber = view.GetInt32(41364);
				LegComplexEventAveragingWeight = view.GetDouble(41365);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegComplexEventAveragingObservationNumber":
					{
						value = LegComplexEventAveragingObservationNumber;
						break;
					}
					case "LegComplexEventAveragingWeight":
					{
						value = LegComplexEventAveragingWeight;
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
				LegComplexEventAveragingObservationNumber = null;
				LegComplexEventAveragingWeight = null;
			}
		}
		[Group(NoOfTag = 41363, Offset = 0, Required = false)]
		public NoLegComplexEventAveragingObservations[]? LegComplexEventAveragingObservations {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegComplexEventAveragingObservations is not null && LegComplexEventAveragingObservations.Length != 0)
			{
				writer.WriteWholeNumber(41363, LegComplexEventAveragingObservations.Length);
				for (int i = 0; i < LegComplexEventAveragingObservations.Length; i++)
				{
					((IFixEncoder)LegComplexEventAveragingObservations[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegComplexEventAveragingObservations") is IMessageView viewNoLegComplexEventAveragingObservations)
			{
				var count = viewNoLegComplexEventAveragingObservations.GroupCount();
				LegComplexEventAveragingObservations = new NoLegComplexEventAveragingObservations[count];
				for (int i = 0; i < count; i++)
				{
					LegComplexEventAveragingObservations[i] = new();
					((IFixParser)LegComplexEventAveragingObservations[i]).Parse(viewNoLegComplexEventAveragingObservations.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegComplexEventAveragingObservations":
				{
					value = LegComplexEventAveragingObservations;
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
			LegComplexEventAveragingObservations = null;
		}
	}
}
