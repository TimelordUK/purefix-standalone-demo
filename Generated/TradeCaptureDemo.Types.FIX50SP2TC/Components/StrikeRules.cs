using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class StrikeRules : IFixComponent
	{
		public sealed partial class NoStrikeRules : IFixGroup
		{
			[TagDetails(Tag = 1223, Type = TagType.String, Offset = 0, Required = false)]
			public string? StrikeRuleID {get; set;}
			
			[TagDetails(Tag = 1202, Type = TagType.Float, Offset = 1, Required = false)]
			public double? StartStrikePxRange {get; set;}
			
			[TagDetails(Tag = 1203, Type = TagType.Float, Offset = 2, Required = false)]
			public double? EndStrikePxRange {get; set;}
			
			[TagDetails(Tag = 1204, Type = TagType.Float, Offset = 3, Required = false)]
			public double? StrikeIncrement {get; set;}
			
			[TagDetails(Tag = 1304, Type = TagType.Int, Offset = 4, Required = false)]
			public int? StrikeExerciseStyle {get; set;}
			
			[Component(Offset = 5, Required = false)]
			public MaturityRules? MaturityRules {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (StrikeRuleID is not null) writer.WriteString(1223, StrikeRuleID);
				if (StartStrikePxRange is not null) writer.WriteNumber(1202, StartStrikePxRange.Value);
				if (EndStrikePxRange is not null) writer.WriteNumber(1203, EndStrikePxRange.Value);
				if (StrikeIncrement is not null) writer.WriteNumber(1204, StrikeIncrement.Value);
				if (StrikeExerciseStyle is not null) writer.WriteWholeNumber(1304, StrikeExerciseStyle.Value);
				if (MaturityRules is not null) ((IFixEncoder)MaturityRules).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				StrikeRuleID = view.GetString(1223);
				StartStrikePxRange = view.GetDouble(1202);
				EndStrikePxRange = view.GetDouble(1203);
				StrikeIncrement = view.GetDouble(1204);
				StrikeExerciseStyle = view.GetInt32(1304);
				if (view.GetView("MaturityRules") is IMessageView viewMaturityRules)
				{
					MaturityRules = new();
					((IFixParser)MaturityRules).Parse(viewMaturityRules);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "StrikeRuleID":
					{
						value = StrikeRuleID;
						break;
					}
					case "StartStrikePxRange":
					{
						value = StartStrikePxRange;
						break;
					}
					case "EndStrikePxRange":
					{
						value = EndStrikePxRange;
						break;
					}
					case "StrikeIncrement":
					{
						value = StrikeIncrement;
						break;
					}
					case "StrikeExerciseStyle":
					{
						value = StrikeExerciseStyle;
						break;
					}
					case "MaturityRules":
					{
						value = MaturityRules;
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
				StrikeRuleID = null;
				StartStrikePxRange = null;
				EndStrikePxRange = null;
				StrikeIncrement = null;
				StrikeExerciseStyle = null;
				((IFixReset?)MaturityRules)?.Reset();
			}
		}
		[Group(NoOfTag = 1201, Offset = 0, Required = false)]
		public NoStrikeRules[]? StrikeRulesItems {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (StrikeRulesItems is not null && StrikeRulesItems.Length != 0)
			{
				writer.WriteWholeNumber(1201, StrikeRulesItems.Length);
				for (int i = 0; i < StrikeRulesItems.Length; i++)
				{
					((IFixEncoder)StrikeRulesItems[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoStrikeRules") is IMessageView viewNoStrikeRules)
			{
				var count = viewNoStrikeRules.GroupCount();
				StrikeRulesItems = new NoStrikeRules[count];
				for (int i = 0; i < count; i++)
				{
					StrikeRulesItems[i] = new();
					((IFixParser)StrikeRulesItems[i]).Parse(viewNoStrikeRules.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoStrikeRules":
				{
					value = StrikeRulesItems;
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
			StrikeRulesItems = null;
		}
	}
}
