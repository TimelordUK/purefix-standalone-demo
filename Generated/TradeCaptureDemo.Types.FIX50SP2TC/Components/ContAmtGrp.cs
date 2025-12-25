using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ContAmtGrp : IFixComponent
	{
		public sealed partial class NoContAmts : IFixGroup
		{
			[TagDetails(Tag = 519, Type = TagType.Int, Offset = 0, Required = false)]
			public int? ContAmtType {get; set;}
			
			[TagDetails(Tag = 520, Type = TagType.Float, Offset = 1, Required = false)]
			public double? ContAmtValue {get; set;}
			
			[TagDetails(Tag = 521, Type = TagType.String, Offset = 2, Required = false)]
			public string? ContAmtCurr {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ContAmtType is not null) writer.WriteWholeNumber(519, ContAmtType.Value);
				if (ContAmtValue is not null) writer.WriteNumber(520, ContAmtValue.Value);
				if (ContAmtCurr is not null) writer.WriteString(521, ContAmtCurr);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ContAmtType = view.GetInt32(519);
				ContAmtValue = view.GetDouble(520);
				ContAmtCurr = view.GetString(521);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ContAmtType":
					{
						value = ContAmtType;
						break;
					}
					case "ContAmtValue":
					{
						value = ContAmtValue;
						break;
					}
					case "ContAmtCurr":
					{
						value = ContAmtCurr;
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
				ContAmtType = null;
				ContAmtValue = null;
				ContAmtCurr = null;
			}
		}
		[Group(NoOfTag = 518, Offset = 0, Required = false)]
		public NoContAmts[]? ContAmts {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ContAmts is not null && ContAmts.Length != 0)
			{
				writer.WriteWholeNumber(518, ContAmts.Length);
				for (int i = 0; i < ContAmts.Length; i++)
				{
					((IFixEncoder)ContAmts[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoContAmts") is IMessageView viewNoContAmts)
			{
				var count = viewNoContAmts.GroupCount();
				ContAmts = new NoContAmts[count];
				for (int i = 0; i < count; i++)
				{
					ContAmts[i] = new();
					((IFixParser)ContAmts[i]).Parse(viewNoContAmts.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoContAmts":
				{
					value = ContAmts;
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
			ContAmts = null;
		}
	}
}
