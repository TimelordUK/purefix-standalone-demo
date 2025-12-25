using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class MDStatisticRptGrp : IFixComponent
	{
		public sealed partial class NoMDStatistics : IFixGroup
		{
			[Component(Offset = 0, Required = false)]
			public MDStatisticParameters? MDStatisticParameters {get; set;}
			
			[TagDetails(Tag = 2475, Type = TagType.String, Offset = 1, Required = false)]
			public string? MDStatisticID {get; set;}
			
			[TagDetails(Tag = 2476, Type = TagType.UtcTimestamp, Offset = 2, Required = false)]
			public DateTime? MDStatisticTime {get; set;}
			
			[TagDetails(Tag = 2477, Type = TagType.Int, Offset = 3, Required = false)]
			public int? MDStatisticStatus {get; set;}
			
			[TagDetails(Tag = 2478, Type = TagType.Float, Offset = 4, Required = false)]
			public double? MDStatisticValue {get; set;}
			
			[TagDetails(Tag = 2479, Type = TagType.Int, Offset = 5, Required = false)]
			public int? MDStatisticValueType {get; set;}
			
			[TagDetails(Tag = 2480, Type = TagType.Int, Offset = 6, Required = false)]
			public int? MDStatisticValueUnit {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (MDStatisticParameters is not null) ((IFixEncoder)MDStatisticParameters).Encode(writer);
				if (MDStatisticID is not null) writer.WriteString(2475, MDStatisticID);
				if (MDStatisticTime is not null) writer.WriteUtcTimeStamp(2476, MDStatisticTime.Value);
				if (MDStatisticStatus is not null) writer.WriteWholeNumber(2477, MDStatisticStatus.Value);
				if (MDStatisticValue is not null) writer.WriteNumber(2478, MDStatisticValue.Value);
				if (MDStatisticValueType is not null) writer.WriteWholeNumber(2479, MDStatisticValueType.Value);
				if (MDStatisticValueUnit is not null) writer.WriteWholeNumber(2480, MDStatisticValueUnit.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				if (view.GetView("MDStatisticParameters") is IMessageView viewMDStatisticParameters)
				{
					MDStatisticParameters = new();
					((IFixParser)MDStatisticParameters).Parse(viewMDStatisticParameters);
				}
				MDStatisticID = view.GetString(2475);
				MDStatisticTime = view.GetDateTime(2476);
				MDStatisticStatus = view.GetInt32(2477);
				MDStatisticValue = view.GetDouble(2478);
				MDStatisticValueType = view.GetInt32(2479);
				MDStatisticValueUnit = view.GetInt32(2480);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "MDStatisticParameters":
					{
						value = MDStatisticParameters;
						break;
					}
					case "MDStatisticID":
					{
						value = MDStatisticID;
						break;
					}
					case "MDStatisticTime":
					{
						value = MDStatisticTime;
						break;
					}
					case "MDStatisticStatus":
					{
						value = MDStatisticStatus;
						break;
					}
					case "MDStatisticValue":
					{
						value = MDStatisticValue;
						break;
					}
					case "MDStatisticValueType":
					{
						value = MDStatisticValueType;
						break;
					}
					case "MDStatisticValueUnit":
					{
						value = MDStatisticValueUnit;
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
				((IFixReset?)MDStatisticParameters)?.Reset();
				MDStatisticID = null;
				MDStatisticTime = null;
				MDStatisticStatus = null;
				MDStatisticValue = null;
				MDStatisticValueType = null;
				MDStatisticValueUnit = null;
			}
		}
		[Group(NoOfTag = 2474, Offset = 0, Required = false)]
		public NoMDStatistics[]? MDStatistics {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (MDStatistics is not null && MDStatistics.Length != 0)
			{
				writer.WriteWholeNumber(2474, MDStatistics.Length);
				for (int i = 0; i < MDStatistics.Length; i++)
				{
					((IFixEncoder)MDStatistics[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoMDStatistics") is IMessageView viewNoMDStatistics)
			{
				var count = viewNoMDStatistics.GroupCount();
				MDStatistics = new NoMDStatistics[count];
				for (int i = 0; i < count; i++)
				{
					MDStatistics[i] = new();
					((IFixParser)MDStatistics[i]).Parse(viewNoMDStatistics.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoMDStatistics":
				{
					value = MDStatistics;
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
			MDStatistics = null;
		}
	}
}
