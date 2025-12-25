using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ComplexEventAveragingObservationGrp : IFixComponent
	{
		public sealed partial class NoComplexEventAveragingObservations : IFixGroup
		{
			[TagDetails(Tag = 40995, Type = TagType.Int, Offset = 0, Required = false)]
			public int? ComplexEventAveragingObservationNumber {get; set;}
			
			[TagDetails(Tag = 40996, Type = TagType.Float, Offset = 1, Required = false)]
			public double? ComplexEventAveragingWeight {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ComplexEventAveragingObservationNumber is not null) writer.WriteWholeNumber(40995, ComplexEventAveragingObservationNumber.Value);
				if (ComplexEventAveragingWeight is not null) writer.WriteNumber(40996, ComplexEventAveragingWeight.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ComplexEventAveragingObservationNumber = view.GetInt32(40995);
				ComplexEventAveragingWeight = view.GetDouble(40996);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ComplexEventAveragingObservationNumber":
					{
						value = ComplexEventAveragingObservationNumber;
						break;
					}
					case "ComplexEventAveragingWeight":
					{
						value = ComplexEventAveragingWeight;
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
				ComplexEventAveragingObservationNumber = null;
				ComplexEventAveragingWeight = null;
			}
		}
		[Group(NoOfTag = 40994, Offset = 0, Required = false)]
		public NoComplexEventAveragingObservations[]? ComplexEventAveragingObservations {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ComplexEventAveragingObservations is not null && ComplexEventAveragingObservations.Length != 0)
			{
				writer.WriteWholeNumber(40994, ComplexEventAveragingObservations.Length);
				for (int i = 0; i < ComplexEventAveragingObservations.Length; i++)
				{
					((IFixEncoder)ComplexEventAveragingObservations[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoComplexEventAveragingObservations") is IMessageView viewNoComplexEventAveragingObservations)
			{
				var count = viewNoComplexEventAveragingObservations.GroupCount();
				ComplexEventAveragingObservations = new NoComplexEventAveragingObservations[count];
				for (int i = 0; i < count; i++)
				{
					ComplexEventAveragingObservations[i] = new();
					((IFixParser)ComplexEventAveragingObservations[i]).Parse(viewNoComplexEventAveragingObservations.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoComplexEventAveragingObservations":
				{
					value = ComplexEventAveragingObservations;
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
			ComplexEventAveragingObservations = null;
		}
	}
}
