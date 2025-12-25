using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class SettlMethodElectionDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoSettlMethodElectionDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42776, Type = TagType.String, Offset = 0, Required = false)]
			public string? SettlMethodElectionDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (SettlMethodElectionDateBusinessCenter is not null) writer.WriteString(42776, SettlMethodElectionDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				SettlMethodElectionDateBusinessCenter = view.GetString(42776);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "SettlMethodElectionDateBusinessCenter":
					{
						value = SettlMethodElectionDateBusinessCenter;
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
				SettlMethodElectionDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42775, Offset = 0, Required = false)]
		public NoSettlMethodElectionDateBusinessCenters[]? SettlMethodElectionDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (SettlMethodElectionDateBusinessCenters is not null && SettlMethodElectionDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42775, SettlMethodElectionDateBusinessCenters.Length);
				for (int i = 0; i < SettlMethodElectionDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)SettlMethodElectionDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoSettlMethodElectionDateBusinessCenters") is IMessageView viewNoSettlMethodElectionDateBusinessCenters)
			{
				var count = viewNoSettlMethodElectionDateBusinessCenters.GroupCount();
				SettlMethodElectionDateBusinessCenters = new NoSettlMethodElectionDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					SettlMethodElectionDateBusinessCenters[i] = new();
					((IFixParser)SettlMethodElectionDateBusinessCenters[i]).Parse(viewNoSettlMethodElectionDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoSettlMethodElectionDateBusinessCenters":
				{
					value = SettlMethodElectionDateBusinessCenters;
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
			SettlMethodElectionDateBusinessCenters = null;
		}
	}
}
