using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingSettlMethodElectionDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingSettlMethodElectionDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 43075, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingSettlMethodElectionDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingSettlMethodElectionDateBusinessCenter is not null) writer.WriteString(43075, UnderlyingSettlMethodElectionDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingSettlMethodElectionDateBusinessCenter = view.GetString(43075);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingSettlMethodElectionDateBusinessCenter":
					{
						value = UnderlyingSettlMethodElectionDateBusinessCenter;
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
				UnderlyingSettlMethodElectionDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 43074, Offset = 0, Required = false)]
		public NoUnderlyingSettlMethodElectionDateBusinessCenters[]? UnderlyingSettlMethodElectionDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingSettlMethodElectionDateBusinessCenters is not null && UnderlyingSettlMethodElectionDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(43074, UnderlyingSettlMethodElectionDateBusinessCenters.Length);
				for (int i = 0; i < UnderlyingSettlMethodElectionDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingSettlMethodElectionDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingSettlMethodElectionDateBusinessCenters") is IMessageView viewNoUnderlyingSettlMethodElectionDateBusinessCenters)
			{
				var count = viewNoUnderlyingSettlMethodElectionDateBusinessCenters.GroupCount();
				UnderlyingSettlMethodElectionDateBusinessCenters = new NoUnderlyingSettlMethodElectionDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingSettlMethodElectionDateBusinessCenters[i] = new();
					((IFixParser)UnderlyingSettlMethodElectionDateBusinessCenters[i]).Parse(viewNoUnderlyingSettlMethodElectionDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingSettlMethodElectionDateBusinessCenters":
				{
					value = UnderlyingSettlMethodElectionDateBusinessCenters;
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
			UnderlyingSettlMethodElectionDateBusinessCenters = null;
		}
	}
}
