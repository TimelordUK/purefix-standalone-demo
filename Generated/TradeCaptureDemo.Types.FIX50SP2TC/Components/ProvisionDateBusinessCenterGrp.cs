using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ProvisionDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoProvisionDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40094, Type = TagType.String, Offset = 0, Required = false)]
			public string? ProvisionDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ProvisionDateBusinessCenter is not null) writer.WriteString(40094, ProvisionDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ProvisionDateBusinessCenter = view.GetString(40094);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ProvisionDateBusinessCenter":
					{
						value = ProvisionDateBusinessCenter;
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
				ProvisionDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40957, Offset = 0, Required = false)]
		public NoProvisionDateBusinessCenters[]? ProvisionDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ProvisionDateBusinessCenters is not null && ProvisionDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40957, ProvisionDateBusinessCenters.Length);
				for (int i = 0; i < ProvisionDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)ProvisionDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoProvisionDateBusinessCenters") is IMessageView viewNoProvisionDateBusinessCenters)
			{
				var count = viewNoProvisionDateBusinessCenters.GroupCount();
				ProvisionDateBusinessCenters = new NoProvisionDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					ProvisionDateBusinessCenters[i] = new();
					((IFixParser)ProvisionDateBusinessCenters[i]).Parse(viewNoProvisionDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoProvisionDateBusinessCenters":
				{
					value = ProvisionDateBusinessCenters;
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
			ProvisionDateBusinessCenters = null;
		}
	}
}
