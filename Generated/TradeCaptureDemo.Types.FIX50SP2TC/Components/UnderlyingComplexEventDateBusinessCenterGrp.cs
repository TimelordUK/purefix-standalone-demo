using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingComplexEventDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingComplexEventDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 41738, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingComplexEventDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingComplexEventDateBusinessCenter is not null) writer.WriteString(41738, UnderlyingComplexEventDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingComplexEventDateBusinessCenter = view.GetString(41738);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingComplexEventDateBusinessCenter":
					{
						value = UnderlyingComplexEventDateBusinessCenter;
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
				UnderlyingComplexEventDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 41737, Offset = 0, Required = false)]
		public NoUnderlyingComplexEventDateBusinessCenters[]? UnderlyingComplexEventDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingComplexEventDateBusinessCenters is not null && UnderlyingComplexEventDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(41737, UnderlyingComplexEventDateBusinessCenters.Length);
				for (int i = 0; i < UnderlyingComplexEventDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingComplexEventDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingComplexEventDateBusinessCenters") is IMessageView viewNoUnderlyingComplexEventDateBusinessCenters)
			{
				var count = viewNoUnderlyingComplexEventDateBusinessCenters.GroupCount();
				UnderlyingComplexEventDateBusinessCenters = new NoUnderlyingComplexEventDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingComplexEventDateBusinessCenters[i] = new();
					((IFixParser)UnderlyingComplexEventDateBusinessCenters[i]).Parse(viewNoUnderlyingComplexEventDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingComplexEventDateBusinessCenters":
				{
					value = UnderlyingComplexEventDateBusinessCenters;
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
			UnderlyingComplexEventDateBusinessCenters = null;
		}
	}
}
