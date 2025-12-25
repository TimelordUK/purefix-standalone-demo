using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ProvisionOptionExpirationDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoProvisionOptionExpirationDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40147, Type = TagType.String, Offset = 0, Required = false)]
			public string? ProvisionOptionExpirationDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ProvisionOptionExpirationDateBusinessCenter is not null) writer.WriteString(40147, ProvisionOptionExpirationDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ProvisionOptionExpirationDateBusinessCenter = view.GetString(40147);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ProvisionOptionExpirationDateBusinessCenter":
					{
						value = ProvisionOptionExpirationDateBusinessCenter;
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
				ProvisionOptionExpirationDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40955, Offset = 0, Required = false)]
		public NoProvisionOptionExpirationDateBusinessCenters[]? ProvisionOptionExpirationDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ProvisionOptionExpirationDateBusinessCenters is not null && ProvisionOptionExpirationDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40955, ProvisionOptionExpirationDateBusinessCenters.Length);
				for (int i = 0; i < ProvisionOptionExpirationDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)ProvisionOptionExpirationDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoProvisionOptionExpirationDateBusinessCenters") is IMessageView viewNoProvisionOptionExpirationDateBusinessCenters)
			{
				var count = viewNoProvisionOptionExpirationDateBusinessCenters.GroupCount();
				ProvisionOptionExpirationDateBusinessCenters = new NoProvisionOptionExpirationDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					ProvisionOptionExpirationDateBusinessCenters[i] = new();
					((IFixParser)ProvisionOptionExpirationDateBusinessCenters[i]).Parse(viewNoProvisionOptionExpirationDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoProvisionOptionExpirationDateBusinessCenters":
				{
					value = ProvisionOptionExpirationDateBusinessCenters;
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
			ProvisionOptionExpirationDateBusinessCenters = null;
		}
	}
}
