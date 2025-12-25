using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class StrmAsgnRptGrp : IFixComponent
	{
		public sealed partial class NoAsgnReqs : IFixGroup
		{
			[Component(Offset = 0, Required = false)]
			public Parties? Parties {get; set;}
			
			[Component(Offset = 1, Required = false)]
			public StrmAsgnRptInstrmtGrp? StrmAsgnRptInstrmtGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
				if (StrmAsgnRptInstrmtGrp is not null) ((IFixEncoder)StrmAsgnRptInstrmtGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				if (view.GetView("Parties") is IMessageView viewParties)
				{
					Parties = new();
					((IFixParser)Parties).Parse(viewParties);
				}
				if (view.GetView("StrmAsgnRptInstrmtGrp") is IMessageView viewStrmAsgnRptInstrmtGrp)
				{
					StrmAsgnRptInstrmtGrp = new();
					((IFixParser)StrmAsgnRptInstrmtGrp).Parse(viewStrmAsgnRptInstrmtGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "Parties":
					{
						value = Parties;
						break;
					}
					case "StrmAsgnRptInstrmtGrp":
					{
						value = StrmAsgnRptInstrmtGrp;
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
				((IFixReset?)Parties)?.Reset();
				((IFixReset?)StrmAsgnRptInstrmtGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 1499, Offset = 0, Required = false)]
		public NoAsgnReqs[]? AsgnReqs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (AsgnReqs is not null && AsgnReqs.Length != 0)
			{
				writer.WriteWholeNumber(1499, AsgnReqs.Length);
				for (int i = 0; i < AsgnReqs.Length; i++)
				{
					((IFixEncoder)AsgnReqs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoAsgnReqs") is IMessageView viewNoAsgnReqs)
			{
				var count = viewNoAsgnReqs.GroupCount();
				AsgnReqs = new NoAsgnReqs[count];
				for (int i = 0; i < count; i++)
				{
					AsgnReqs[i] = new();
					((IFixParser)AsgnReqs[i]).Parse(viewNoAsgnReqs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoAsgnReqs":
				{
					value = AsgnReqs;
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
			AsgnReqs = null;
		}
	}
}
