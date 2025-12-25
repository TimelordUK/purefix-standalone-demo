using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class MatchingInstructions : IFixComponent
	{
		public sealed partial class NoMatchInst : IFixGroup
		{
			[TagDetails(Tag = 1625, Type = TagType.Int, Offset = 0, Required = false)]
			public int? MatchInst {get; set;}
			
			[TagDetails(Tag = 1673, Type = TagType.String, Offset = 1, Required = false)]
			public string? MatchInstMarketID {get; set;}
			
			[TagDetails(Tag = 1626, Type = TagType.String, Offset = 2, Required = false)]
			public string? MatchAttribTagID {get; set;}
			
			[TagDetails(Tag = 1627, Type = TagType.String, Offset = 3, Required = false)]
			public string? MatchAttribValue {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (MatchInst is not null) writer.WriteWholeNumber(1625, MatchInst.Value);
				if (MatchInstMarketID is not null) writer.WriteString(1673, MatchInstMarketID);
				if (MatchAttribTagID is not null) writer.WriteString(1626, MatchAttribTagID);
				if (MatchAttribValue is not null) writer.WriteString(1627, MatchAttribValue);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				MatchInst = view.GetInt32(1625);
				MatchInstMarketID = view.GetString(1673);
				MatchAttribTagID = view.GetString(1626);
				MatchAttribValue = view.GetString(1627);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "MatchInst":
					{
						value = MatchInst;
						break;
					}
					case "MatchInstMarketID":
					{
						value = MatchInstMarketID;
						break;
					}
					case "MatchAttribTagID":
					{
						value = MatchAttribTagID;
						break;
					}
					case "MatchAttribValue":
					{
						value = MatchAttribValue;
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
				MatchInst = null;
				MatchInstMarketID = null;
				MatchAttribTagID = null;
				MatchAttribValue = null;
			}
		}
		[Group(NoOfTag = 1624, Offset = 0, Required = false)]
		public NoMatchInst[]? MatchInst {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (MatchInst is not null && MatchInst.Length != 0)
			{
				writer.WriteWholeNumber(1624, MatchInst.Length);
				for (int i = 0; i < MatchInst.Length; i++)
				{
					((IFixEncoder)MatchInst[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoMatchInst") is IMessageView viewNoMatchInst)
			{
				var count = viewNoMatchInst.GroupCount();
				MatchInst = new NoMatchInst[count];
				for (int i = 0; i < count; i++)
				{
					MatchInst[i] = new();
					((IFixParser)MatchInst[i]).Parse(viewNoMatchInst.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoMatchInst":
				{
					value = MatchInst;
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
			MatchInst = null;
		}
	}
}
