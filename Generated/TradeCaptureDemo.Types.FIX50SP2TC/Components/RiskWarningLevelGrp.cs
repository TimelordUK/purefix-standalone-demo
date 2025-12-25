using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class RiskWarningLevelGrp : IFixComponent
	{
		public sealed partial class NoRiskWarningLevels : IFixGroup
		{
			[TagDetails(Tag = 1769, Type = TagType.Int, Offset = 0, Required = false)]
			public int? RiskWarningLevelAction {get; set;}
			
			[TagDetails(Tag = 1560, Type = TagType.Float, Offset = 1, Required = false)]
			public double? RiskWarningLevelPercent {get; set;}
			
			[TagDetails(Tag = 1768, Type = TagType.Int, Offset = 2, Required = false)]
			public int? RiskWarningLevelAmount {get; set;}
			
			[TagDetails(Tag = 1561, Type = TagType.String, Offset = 3, Required = false)]
			public string? RiskWarningLevelName {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (RiskWarningLevelAction is not null) writer.WriteWholeNumber(1769, RiskWarningLevelAction.Value);
				if (RiskWarningLevelPercent is not null) writer.WriteNumber(1560, RiskWarningLevelPercent.Value);
				if (RiskWarningLevelAmount is not null) writer.WriteWholeNumber(1768, RiskWarningLevelAmount.Value);
				if (RiskWarningLevelName is not null) writer.WriteString(1561, RiskWarningLevelName);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				RiskWarningLevelAction = view.GetInt32(1769);
				RiskWarningLevelPercent = view.GetDouble(1560);
				RiskWarningLevelAmount = view.GetInt32(1768);
				RiskWarningLevelName = view.GetString(1561);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "RiskWarningLevelAction":
					{
						value = RiskWarningLevelAction;
						break;
					}
					case "RiskWarningLevelPercent":
					{
						value = RiskWarningLevelPercent;
						break;
					}
					case "RiskWarningLevelAmount":
					{
						value = RiskWarningLevelAmount;
						break;
					}
					case "RiskWarningLevelName":
					{
						value = RiskWarningLevelName;
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
				RiskWarningLevelAction = null;
				RiskWarningLevelPercent = null;
				RiskWarningLevelAmount = null;
				RiskWarningLevelName = null;
			}
		}
		[Group(NoOfTag = 1559, Offset = 0, Required = false)]
		public NoRiskWarningLevels[]? RiskWarningLevels {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (RiskWarningLevels is not null && RiskWarningLevels.Length != 0)
			{
				writer.WriteWholeNumber(1559, RiskWarningLevels.Length);
				for (int i = 0; i < RiskWarningLevels.Length; i++)
				{
					((IFixEncoder)RiskWarningLevels[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoRiskWarningLevels") is IMessageView viewNoRiskWarningLevels)
			{
				var count = viewNoRiskWarningLevels.GroupCount();
				RiskWarningLevels = new NoRiskWarningLevels[count];
				for (int i = 0; i < count; i++)
				{
					RiskWarningLevels[i] = new();
					((IFixParser)RiskWarningLevels[i]).Parse(viewNoRiskWarningLevels.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoRiskWarningLevels":
				{
					value = RiskWarningLevels;
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
			RiskWarningLevels = null;
		}
	}
}
