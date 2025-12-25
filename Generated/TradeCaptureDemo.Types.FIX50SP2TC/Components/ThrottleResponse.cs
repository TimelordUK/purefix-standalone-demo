using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ThrottleResponse : IFixComponent
	{
		[TagDetails(Tag = 1685, Type = TagType.Int, Offset = 0, Required = false)]
		public int? ThrottleInst {get; set;}
		
		[TagDetails(Tag = 1609, Type = TagType.Int, Offset = 1, Required = false)]
		public int? ThrottleStatus {get; set;}
		
		[TagDetails(Tag = 1686, Type = TagType.Int, Offset = 2, Required = false)]
		public int? ThrottleCountIndicator {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ThrottleInst is not null) writer.WriteWholeNumber(1685, ThrottleInst.Value);
			if (ThrottleStatus is not null) writer.WriteWholeNumber(1609, ThrottleStatus.Value);
			if (ThrottleCountIndicator is not null) writer.WriteWholeNumber(1686, ThrottleCountIndicator.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			ThrottleInst = view.GetInt32(1685);
			ThrottleStatus = view.GetInt32(1609);
			ThrottleCountIndicator = view.GetInt32(1686);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "ThrottleInst":
				{
					value = ThrottleInst;
					break;
				}
				case "ThrottleStatus":
				{
					value = ThrottleStatus;
					break;
				}
				case "ThrottleCountIndicator":
				{
					value = ThrottleCountIndicator;
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
			ThrottleInst = null;
			ThrottleStatus = null;
			ThrottleCountIndicator = null;
		}
	}
}
