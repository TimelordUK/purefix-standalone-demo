using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingProvisionDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingProvisionDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42191, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingProvisionDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingProvisionDateBusinessCenter is not null) writer.WriteString(42191, UnderlyingProvisionDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingProvisionDateBusinessCenter = view.GetString(42191);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingProvisionDateBusinessCenter":
					{
						value = UnderlyingProvisionDateBusinessCenter;
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
				UnderlyingProvisionDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42190, Offset = 0, Required = false)]
		public NoUnderlyingProvisionDateBusinessCenters[]? UnderlyingProvisionDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingProvisionDateBusinessCenters is not null && UnderlyingProvisionDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42190, UnderlyingProvisionDateBusinessCenters.Length);
				for (int i = 0; i < UnderlyingProvisionDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingProvisionDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingProvisionDateBusinessCenters") is IMessageView viewNoUnderlyingProvisionDateBusinessCenters)
			{
				var count = viewNoUnderlyingProvisionDateBusinessCenters.GroupCount();
				UnderlyingProvisionDateBusinessCenters = new NoUnderlyingProvisionDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingProvisionDateBusinessCenters[i] = new();
					((IFixParser)UnderlyingProvisionDateBusinessCenters[i]).Parse(viewNoUnderlyingProvisionDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingProvisionDateBusinessCenters":
				{
					value = UnderlyingProvisionDateBusinessCenters;
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
			UnderlyingProvisionDateBusinessCenters = null;
		}
	}
}
