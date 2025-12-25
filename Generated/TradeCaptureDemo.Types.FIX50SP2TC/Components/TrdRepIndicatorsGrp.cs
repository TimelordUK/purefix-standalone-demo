using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class TrdRepIndicatorsGrp : IFixComponent
	{
		public sealed partial class NoTrdRepIndicators : IFixGroup
		{
			[TagDetails(Tag = 1388, Type = TagType.Int, Offset = 0, Required = false)]
			public int? TrdRepPartyRole {get; set;}
			
			[TagDetails(Tag = 1389, Type = TagType.Boolean, Offset = 1, Required = false)]
			public bool? TrdRepIndicator {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (TrdRepPartyRole is not null) writer.WriteWholeNumber(1388, TrdRepPartyRole.Value);
				if (TrdRepIndicator is not null) writer.WriteBoolean(1389, TrdRepIndicator.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				TrdRepPartyRole = view.GetInt32(1388);
				TrdRepIndicator = view.GetBool(1389);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "TrdRepPartyRole":
					{
						value = TrdRepPartyRole;
						break;
					}
					case "TrdRepIndicator":
					{
						value = TrdRepIndicator;
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
				TrdRepPartyRole = null;
				TrdRepIndicator = null;
			}
		}
		[Group(NoOfTag = 1387, Offset = 0, Required = false)]
		public NoTrdRepIndicators[]? TrdRepIndicators {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (TrdRepIndicators is not null && TrdRepIndicators.Length != 0)
			{
				writer.WriteWholeNumber(1387, TrdRepIndicators.Length);
				for (int i = 0; i < TrdRepIndicators.Length; i++)
				{
					((IFixEncoder)TrdRepIndicators[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoTrdRepIndicators") is IMessageView viewNoTrdRepIndicators)
			{
				var count = viewNoTrdRepIndicators.GroupCount();
				TrdRepIndicators = new NoTrdRepIndicators[count];
				for (int i = 0; i < count; i++)
				{
					TrdRepIndicators[i] = new();
					((IFixParser)TrdRepIndicators[i]).Parse(viewNoTrdRepIndicators.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoTrdRepIndicators":
				{
					value = TrdRepIndicators;
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
			TrdRepIndicators = null;
		}
	}
}
