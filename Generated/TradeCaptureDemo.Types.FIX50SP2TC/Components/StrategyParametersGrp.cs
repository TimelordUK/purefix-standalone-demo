using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class StrategyParametersGrp : IFixComponent
	{
		public sealed partial class NoStrategyParameters : IFixGroup
		{
			[TagDetails(Tag = 958, Type = TagType.String, Offset = 0, Required = false)]
			public string? StrategyParameterName {get; set;}
			
			[TagDetails(Tag = 959, Type = TagType.Int, Offset = 1, Required = false)]
			public int? StrategyParameterType {get; set;}
			
			[TagDetails(Tag = 960, Type = TagType.String, Offset = 2, Required = false)]
			public string? StrategyParameterValue {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (StrategyParameterName is not null) writer.WriteString(958, StrategyParameterName);
				if (StrategyParameterType is not null) writer.WriteWholeNumber(959, StrategyParameterType.Value);
				if (StrategyParameterValue is not null) writer.WriteString(960, StrategyParameterValue);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				StrategyParameterName = view.GetString(958);
				StrategyParameterType = view.GetInt32(959);
				StrategyParameterValue = view.GetString(960);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "StrategyParameterName":
					{
						value = StrategyParameterName;
						break;
					}
					case "StrategyParameterType":
					{
						value = StrategyParameterType;
						break;
					}
					case "StrategyParameterValue":
					{
						value = StrategyParameterValue;
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
				StrategyParameterName = null;
				StrategyParameterType = null;
				StrategyParameterValue = null;
			}
		}
		[Group(NoOfTag = 957, Offset = 0, Required = false)]
		public NoStrategyParameters[]? StrategyParameters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (StrategyParameters is not null && StrategyParameters.Length != 0)
			{
				writer.WriteWholeNumber(957, StrategyParameters.Length);
				for (int i = 0; i < StrategyParameters.Length; i++)
				{
					((IFixEncoder)StrategyParameters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoStrategyParameters") is IMessageView viewNoStrategyParameters)
			{
				var count = viewNoStrategyParameters.GroupCount();
				StrategyParameters = new NoStrategyParameters[count];
				for (int i = 0; i < count; i++)
				{
					StrategyParameters[i] = new();
					((IFixParser)StrategyParameters[i]).Parse(viewNoStrategyParameters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoStrategyParameters":
				{
					value = StrategyParameters;
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
			StrategyParameters = null;
		}
	}
}
