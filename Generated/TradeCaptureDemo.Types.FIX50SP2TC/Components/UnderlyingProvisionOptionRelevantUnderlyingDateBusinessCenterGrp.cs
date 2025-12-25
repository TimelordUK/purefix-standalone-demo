using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42189, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenter is not null) writer.WriteString(42189, UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenter = view.GetString(42189);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenter":
					{
						value = UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenter;
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
				UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42188, Offset = 0, Required = false)]
		public NoUnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenters[]? UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenters is not null && UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42188, UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenters.Length);
				for (int i = 0; i < UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenters") is IMessageView viewNoUnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenters)
			{
				var count = viewNoUnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenters.GroupCount();
				UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenters = new NoUnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenters[i] = new();
					((IFixParser)UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenters[i]).Parse(viewNoUnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenters":
				{
					value = UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenters;
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
			UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenters = null;
		}
	}
}
