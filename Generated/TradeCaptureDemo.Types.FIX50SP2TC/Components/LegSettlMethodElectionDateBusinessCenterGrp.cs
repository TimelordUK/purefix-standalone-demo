using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegSettlMethodElectionDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegSettlMethodElectionDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42582, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegSettlMethodElectionDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegSettlMethodElectionDateBusinessCenter is not null) writer.WriteString(42582, LegSettlMethodElectionDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegSettlMethodElectionDateBusinessCenter = view.GetString(42582);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegSettlMethodElectionDateBusinessCenter":
					{
						value = LegSettlMethodElectionDateBusinessCenter;
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
				LegSettlMethodElectionDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42581, Offset = 0, Required = false)]
		public NoLegSettlMethodElectionDateBusinessCenters[]? LegSettlMethodElectionDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegSettlMethodElectionDateBusinessCenters is not null && LegSettlMethodElectionDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42581, LegSettlMethodElectionDateBusinessCenters.Length);
				for (int i = 0; i < LegSettlMethodElectionDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegSettlMethodElectionDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegSettlMethodElectionDateBusinessCenters") is IMessageView viewNoLegSettlMethodElectionDateBusinessCenters)
			{
				var count = viewNoLegSettlMethodElectionDateBusinessCenters.GroupCount();
				LegSettlMethodElectionDateBusinessCenters = new NoLegSettlMethodElectionDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegSettlMethodElectionDateBusinessCenters[i] = new();
					((IFixParser)LegSettlMethodElectionDateBusinessCenters[i]).Parse(viewNoLegSettlMethodElectionDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegSettlMethodElectionDateBusinessCenters":
				{
					value = LegSettlMethodElectionDateBusinessCenters;
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
			LegSettlMethodElectionDateBusinessCenters = null;
		}
	}
}
