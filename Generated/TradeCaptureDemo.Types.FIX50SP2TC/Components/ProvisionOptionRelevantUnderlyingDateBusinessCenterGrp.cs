using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ProvisionOptionRelevantUnderlyingDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoProvisionOptionRelevantUnderlyingDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40157, Type = TagType.String, Offset = 0, Required = false)]
			public string? ProvisionOptionRelevantUnderlyingDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ProvisionOptionRelevantUnderlyingDateBusinessCenter is not null) writer.WriteString(40157, ProvisionOptionRelevantUnderlyingDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ProvisionOptionRelevantUnderlyingDateBusinessCenter = view.GetString(40157);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ProvisionOptionRelevantUnderlyingDateBusinessCenter":
					{
						value = ProvisionOptionRelevantUnderlyingDateBusinessCenter;
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
				ProvisionOptionRelevantUnderlyingDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40956, Offset = 0, Required = false)]
		public NoProvisionOptionRelevantUnderlyingDateBusinessCenters[]? ProvisionOptionRelevantUnderlyingDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ProvisionOptionRelevantUnderlyingDateBusinessCenters is not null && ProvisionOptionRelevantUnderlyingDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40956, ProvisionOptionRelevantUnderlyingDateBusinessCenters.Length);
				for (int i = 0; i < ProvisionOptionRelevantUnderlyingDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)ProvisionOptionRelevantUnderlyingDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoProvisionOptionRelevantUnderlyingDateBusinessCenters") is IMessageView viewNoProvisionOptionRelevantUnderlyingDateBusinessCenters)
			{
				var count = viewNoProvisionOptionRelevantUnderlyingDateBusinessCenters.GroupCount();
				ProvisionOptionRelevantUnderlyingDateBusinessCenters = new NoProvisionOptionRelevantUnderlyingDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					ProvisionOptionRelevantUnderlyingDateBusinessCenters[i] = new();
					((IFixParser)ProvisionOptionRelevantUnderlyingDateBusinessCenters[i]).Parse(viewNoProvisionOptionRelevantUnderlyingDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoProvisionOptionRelevantUnderlyingDateBusinessCenters":
				{
					value = ProvisionOptionRelevantUnderlyingDateBusinessCenters;
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
			ProvisionOptionRelevantUnderlyingDateBusinessCenters = null;
		}
	}
}
