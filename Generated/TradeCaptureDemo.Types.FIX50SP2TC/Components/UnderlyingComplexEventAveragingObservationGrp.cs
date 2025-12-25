using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingComplexEventAveragingObservationGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingComplexEventAveragingObservations : IFixGroup
		{
			[TagDetails(Tag = 41714, Type = TagType.Int, Offset = 0, Required = false)]
			public int? UnderlyingComplexEventAveragingObservationNumber {get; set;}
			
			[TagDetails(Tag = 41715, Type = TagType.Float, Offset = 1, Required = false)]
			public double? UnderlyingComplexEventAveragingWeight {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingComplexEventAveragingObservationNumber is not null) writer.WriteWholeNumber(41714, UnderlyingComplexEventAveragingObservationNumber.Value);
				if (UnderlyingComplexEventAveragingWeight is not null) writer.WriteNumber(41715, UnderlyingComplexEventAveragingWeight.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingComplexEventAveragingObservationNumber = view.GetInt32(41714);
				UnderlyingComplexEventAveragingWeight = view.GetDouble(41715);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingComplexEventAveragingObservationNumber":
					{
						value = UnderlyingComplexEventAveragingObservationNumber;
						break;
					}
					case "UnderlyingComplexEventAveragingWeight":
					{
						value = UnderlyingComplexEventAveragingWeight;
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
				UnderlyingComplexEventAveragingObservationNumber = null;
				UnderlyingComplexEventAveragingWeight = null;
			}
		}
		[Group(NoOfTag = 41713, Offset = 0, Required = false)]
		public NoUnderlyingComplexEventAveragingObservations[]? UnderlyingComplexEventAveragingObservations {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingComplexEventAveragingObservations is not null && UnderlyingComplexEventAveragingObservations.Length != 0)
			{
				writer.WriteWholeNumber(41713, UnderlyingComplexEventAveragingObservations.Length);
				for (int i = 0; i < UnderlyingComplexEventAveragingObservations.Length; i++)
				{
					((IFixEncoder)UnderlyingComplexEventAveragingObservations[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingComplexEventAveragingObservations") is IMessageView viewNoUnderlyingComplexEventAveragingObservations)
			{
				var count = viewNoUnderlyingComplexEventAveragingObservations.GroupCount();
				UnderlyingComplexEventAveragingObservations = new NoUnderlyingComplexEventAveragingObservations[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingComplexEventAveragingObservations[i] = new();
					((IFixParser)UnderlyingComplexEventAveragingObservations[i]).Parse(viewNoUnderlyingComplexEventAveragingObservations.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingComplexEventAveragingObservations":
				{
					value = UnderlyingComplexEventAveragingObservations;
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
			UnderlyingComplexEventAveragingObservations = null;
		}
	}
}
