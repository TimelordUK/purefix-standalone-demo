using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ExecutionAggregationGrp : IFixComponent
	{
		public sealed partial class NoExecs : IFixGroup
		{
			[TagDetails(Tag = 32, Type = TagType.Float, Offset = 0, Required = false)]
			public double? LastQty {get; set;}
			
			[TagDetails(Tag = 17, Type = TagType.String, Offset = 1, Required = false)]
			public string? ExecID {get; set;}
			
			[TagDetails(Tag = 1003, Type = TagType.String, Offset = 2, Required = false)]
			public string? TradeID {get; set;}
			
			[TagDetails(Tag = 31, Type = TagType.Float, Offset = 3, Required = false)]
			public double? LastPx {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LastQty is not null) writer.WriteNumber(32, LastQty.Value);
				if (ExecID is not null) writer.WriteString(17, ExecID);
				if (TradeID is not null) writer.WriteString(1003, TradeID);
				if (LastPx is not null) writer.WriteNumber(31, LastPx.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LastQty = view.GetDouble(32);
				ExecID = view.GetString(17);
				TradeID = view.GetString(1003);
				LastPx = view.GetDouble(31);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LastQty":
					{
						value = LastQty;
						break;
					}
					case "ExecID":
					{
						value = ExecID;
						break;
					}
					case "TradeID":
					{
						value = TradeID;
						break;
					}
					case "LastPx":
					{
						value = LastPx;
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
				LastQty = null;
				ExecID = null;
				TradeID = null;
				LastPx = null;
			}
		}
		[Group(NoOfTag = 124, Offset = 0, Required = false)]
		public NoExecs[]? Execs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Execs is not null && Execs.Length != 0)
			{
				writer.WriteWholeNumber(124, Execs.Length);
				for (int i = 0; i < Execs.Length; i++)
				{
					((IFixEncoder)Execs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoExecs") is IMessageView viewNoExecs)
			{
				var count = viewNoExecs.GroupCount();
				Execs = new NoExecs[count];
				for (int i = 0; i < count; i++)
				{
					Execs[i] = new();
					((IFixParser)Execs[i]).Parse(viewNoExecs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoExecs":
				{
					value = Execs;
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
			Execs = null;
		}
	}
}
