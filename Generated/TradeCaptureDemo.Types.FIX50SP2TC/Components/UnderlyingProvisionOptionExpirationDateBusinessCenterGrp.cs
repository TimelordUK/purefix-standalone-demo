using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingProvisionOptionExpirationDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingProvisionOptionExpirationDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42187, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingProvisionOptionExpirationDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingProvisionOptionExpirationDateBusinessCenter is not null) writer.WriteString(42187, UnderlyingProvisionOptionExpirationDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingProvisionOptionExpirationDateBusinessCenter = view.GetString(42187);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingProvisionOptionExpirationDateBusinessCenter":
					{
						value = UnderlyingProvisionOptionExpirationDateBusinessCenter;
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
				UnderlyingProvisionOptionExpirationDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42186, Offset = 0, Required = false)]
		public NoUnderlyingProvisionOptionExpirationDateBusinessCenters[]? UnderlyingProvisionOptionExpirationDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingProvisionOptionExpirationDateBusinessCenters is not null && UnderlyingProvisionOptionExpirationDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42186, UnderlyingProvisionOptionExpirationDateBusinessCenters.Length);
				for (int i = 0; i < UnderlyingProvisionOptionExpirationDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingProvisionOptionExpirationDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingProvisionOptionExpirationDateBusinessCenters") is IMessageView viewNoUnderlyingProvisionOptionExpirationDateBusinessCenters)
			{
				var count = viewNoUnderlyingProvisionOptionExpirationDateBusinessCenters.GroupCount();
				UnderlyingProvisionOptionExpirationDateBusinessCenters = new NoUnderlyingProvisionOptionExpirationDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingProvisionOptionExpirationDateBusinessCenters[i] = new();
					((IFixParser)UnderlyingProvisionOptionExpirationDateBusinessCenters[i]).Parse(viewNoUnderlyingProvisionOptionExpirationDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingProvisionOptionExpirationDateBusinessCenters":
				{
					value = UnderlyingProvisionOptionExpirationDateBusinessCenters;
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
			UnderlyingProvisionOptionExpirationDateBusinessCenters = null;
		}
	}
}
