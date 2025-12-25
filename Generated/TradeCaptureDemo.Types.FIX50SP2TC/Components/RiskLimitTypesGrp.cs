using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class RiskLimitTypesGrp : IFixComponent
	{
		public sealed partial class NoRiskLimitTypes : IFixGroup
		{
			[TagDetails(Tag = 1530, Type = TagType.Int, Offset = 0, Required = false)]
			public int? RiskLimitType {get; set;}
			
			[TagDetails(Tag = 1531, Type = TagType.Float, Offset = 1, Required = false)]
			public double? RiskLimitAmount {get; set;}
			
			[TagDetails(Tag = 1767, Type = TagType.Int, Offset = 2, Required = false)]
			public int? RiskLimitAction {get; set;}
			
			[TagDetails(Tag = 1766, Type = TagType.Float, Offset = 3, Required = false)]
			public double? RiskLimitUtilizationAmount {get; set;}
			
			[TagDetails(Tag = 1765, Type = TagType.Float, Offset = 4, Required = false)]
			public double? RiskLimitUtilizationPercent {get; set;}
			
			[TagDetails(Tag = 1532, Type = TagType.String, Offset = 5, Required = false)]
			public string? RiskLimitCurrency {get; set;}
			
			[TagDetails(Tag = 2939, Type = TagType.String, Offset = 6, Required = false)]
			public string? RiskLimitCurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 1533, Type = TagType.String, Offset = 7, Required = false)]
			public string? RiskLimitPlatform {get; set;}
			
			[TagDetails(Tag = 2336, Type = TagType.Int, Offset = 8, Required = false)]
			public int? RiskLimitVelocityPeriod {get; set;}
			
			[TagDetails(Tag = 2337, Type = TagType.String, Offset = 9, Required = false)]
			public string? RiskLimitVelocityUnit {get; set;}
			
			[Component(Offset = 10, Required = false)]
			public RiskWarningLevelGrp? RiskWarningLevelGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (RiskLimitType is not null) writer.WriteWholeNumber(1530, RiskLimitType.Value);
				if (RiskLimitAmount is not null) writer.WriteNumber(1531, RiskLimitAmount.Value);
				if (RiskLimitAction is not null) writer.WriteWholeNumber(1767, RiskLimitAction.Value);
				if (RiskLimitUtilizationAmount is not null) writer.WriteNumber(1766, RiskLimitUtilizationAmount.Value);
				if (RiskLimitUtilizationPercent is not null) writer.WriteNumber(1765, RiskLimitUtilizationPercent.Value);
				if (RiskLimitCurrency is not null) writer.WriteString(1532, RiskLimitCurrency);
				if (RiskLimitCurrencyCodeSource is not null) writer.WriteString(2939, RiskLimitCurrencyCodeSource);
				if (RiskLimitPlatform is not null) writer.WriteString(1533, RiskLimitPlatform);
				if (RiskLimitVelocityPeriod is not null) writer.WriteWholeNumber(2336, RiskLimitVelocityPeriod.Value);
				if (RiskLimitVelocityUnit is not null) writer.WriteString(2337, RiskLimitVelocityUnit);
				if (RiskWarningLevelGrp is not null) ((IFixEncoder)RiskWarningLevelGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				RiskLimitType = view.GetInt32(1530);
				RiskLimitAmount = view.GetDouble(1531);
				RiskLimitAction = view.GetInt32(1767);
				RiskLimitUtilizationAmount = view.GetDouble(1766);
				RiskLimitUtilizationPercent = view.GetDouble(1765);
				RiskLimitCurrency = view.GetString(1532);
				RiskLimitCurrencyCodeSource = view.GetString(2939);
				RiskLimitPlatform = view.GetString(1533);
				RiskLimitVelocityPeriod = view.GetInt32(2336);
				RiskLimitVelocityUnit = view.GetString(2337);
				if (view.GetView("RiskWarningLevelGrp") is IMessageView viewRiskWarningLevelGrp)
				{
					RiskWarningLevelGrp = new();
					((IFixParser)RiskWarningLevelGrp).Parse(viewRiskWarningLevelGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "RiskLimitType":
					{
						value = RiskLimitType;
						break;
					}
					case "RiskLimitAmount":
					{
						value = RiskLimitAmount;
						break;
					}
					case "RiskLimitAction":
					{
						value = RiskLimitAction;
						break;
					}
					case "RiskLimitUtilizationAmount":
					{
						value = RiskLimitUtilizationAmount;
						break;
					}
					case "RiskLimitUtilizationPercent":
					{
						value = RiskLimitUtilizationPercent;
						break;
					}
					case "RiskLimitCurrency":
					{
						value = RiskLimitCurrency;
						break;
					}
					case "RiskLimitCurrencyCodeSource":
					{
						value = RiskLimitCurrencyCodeSource;
						break;
					}
					case "RiskLimitPlatform":
					{
						value = RiskLimitPlatform;
						break;
					}
					case "RiskLimitVelocityPeriod":
					{
						value = RiskLimitVelocityPeriod;
						break;
					}
					case "RiskLimitVelocityUnit":
					{
						value = RiskLimitVelocityUnit;
						break;
					}
					case "RiskWarningLevelGrp":
					{
						value = RiskWarningLevelGrp;
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
				RiskLimitType = null;
				RiskLimitAmount = null;
				RiskLimitAction = null;
				RiskLimitUtilizationAmount = null;
				RiskLimitUtilizationPercent = null;
				RiskLimitCurrency = null;
				RiskLimitCurrencyCodeSource = null;
				RiskLimitPlatform = null;
				RiskLimitVelocityPeriod = null;
				RiskLimitVelocityUnit = null;
				((IFixReset?)RiskWarningLevelGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 1529, Offset = 0, Required = false)]
		public NoRiskLimitTypes[]? RiskLimitTypes {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (RiskLimitTypes is not null && RiskLimitTypes.Length != 0)
			{
				writer.WriteWholeNumber(1529, RiskLimitTypes.Length);
				for (int i = 0; i < RiskLimitTypes.Length; i++)
				{
					((IFixEncoder)RiskLimitTypes[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoRiskLimitTypes") is IMessageView viewNoRiskLimitTypes)
			{
				var count = viewNoRiskLimitTypes.GroupCount();
				RiskLimitTypes = new NoRiskLimitTypes[count];
				for (int i = 0; i < count; i++)
				{
					RiskLimitTypes[i] = new();
					((IFixParser)RiskLimitTypes[i]).Parse(viewNoRiskLimitTypes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoRiskLimitTypes":
				{
					value = RiskLimitTypes;
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
			RiskLimitTypes = null;
		}
	}
}
