using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class MDStatisticReqGrp : IFixComponent
	{
		public sealed partial class NoMDStatistics : IFixGroup
		{
			[TagDetails(Tag = 2475, Type = TagType.String, Offset = 0, Required = false)]
			public string? MDStatisticID {get; set;}
			
			[Component(Offset = 1, Required = false)]
			public MDStatisticParameters? MDStatisticParameters {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (MDStatisticID is not null) writer.WriteString(2475, MDStatisticID);
				if (MDStatisticParameters is not null) ((IFixEncoder)MDStatisticParameters).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				MDStatisticID = view.GetString(2475);
				if (view.GetView("MDStatisticParameters") is IMessageView viewMDStatisticParameters)
				{
					MDStatisticParameters = new();
					((IFixParser)MDStatisticParameters).Parse(viewMDStatisticParameters);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "MDStatisticID":
					{
						value = MDStatisticID;
						break;
					}
					case "MDStatisticParameters":
					{
						value = MDStatisticParameters;
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
				MDStatisticID = null;
				((IFixReset?)MDStatisticParameters)?.Reset();
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
