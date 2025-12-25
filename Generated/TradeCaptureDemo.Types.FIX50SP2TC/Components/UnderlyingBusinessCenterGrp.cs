using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40963, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingBusinessCenter is not null) writer.WriteString(40963, UnderlyingBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingBusinessCenter = view.GetString(40963);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingBusinessCenter":
					{
						value = UnderlyingBusinessCenter;
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
				UnderlyingBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40962, Offset = 0, Required = false)]
		public NoUnderlyingBusinessCenters[]? UnderlyingBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingBusinessCenters is not null && UnderlyingBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40962, UnderlyingBusinessCenters.Length);
				for (int i = 0; i < UnderlyingBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingBusinessCenters") is IMessageView viewNoUnderlyingBusinessCenters)
			{
				var count = viewNoUnderlyingBusinessCenters.GroupCount();
				UnderlyingBusinessCenters = new NoUnderlyingBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingBusinessCenters[i] = new();
					((IFixParser)UnderlyingBusinessCenters[i]).Parse(viewNoUnderlyingBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingBusinessCenters":
				{
					value = UnderlyingBusinessCenters;
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
			UnderlyingBusinessCenters = null;
		}
	}
}
