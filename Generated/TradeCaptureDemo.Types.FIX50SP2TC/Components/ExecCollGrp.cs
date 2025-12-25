using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ExecCollGrp : IFixComponent
	{
		public sealed partial class NoExecs : IFixGroup
		{
			[TagDetails(Tag = 17, Type = TagType.String, Offset = 0, Required = false)]
			public string? ExecID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ExecID is not null) writer.WriteString(17, ExecID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ExecID = view.GetString(17);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ExecID":
					{
						value = ExecID;
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
				ExecID = null;
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
