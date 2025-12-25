using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class MandatoryClearingJurisdictionGrp : IFixComponent
	{
		public sealed partial class NoMandatoryClearingJurisdictions : IFixGroup
		{
			[TagDetails(Tag = 41313, Type = TagType.String, Offset = 0, Required = false)]
			public string? MandatoryClearingJurisdiction {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (MandatoryClearingJurisdiction is not null) writer.WriteString(41313, MandatoryClearingJurisdiction);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				MandatoryClearingJurisdiction = view.GetString(41313);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "MandatoryClearingJurisdiction":
					{
						value = MandatoryClearingJurisdiction;
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
				MandatoryClearingJurisdiction = null;
			}
		}
		[Group(NoOfTag = 41312, Offset = 0, Required = false)]
		public NoMandatoryClearingJurisdictions[]? MandatoryClearingJurisdictions {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (MandatoryClearingJurisdictions is not null && MandatoryClearingJurisdictions.Length != 0)
			{
				writer.WriteWholeNumber(41312, MandatoryClearingJurisdictions.Length);
				for (int i = 0; i < MandatoryClearingJurisdictions.Length; i++)
				{
					((IFixEncoder)MandatoryClearingJurisdictions[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoMandatoryClearingJurisdictions") is IMessageView viewNoMandatoryClearingJurisdictions)
			{
				var count = viewNoMandatoryClearingJurisdictions.GroupCount();
				MandatoryClearingJurisdictions = new NoMandatoryClearingJurisdictions[count];
				for (int i = 0; i < count; i++)
				{
					MandatoryClearingJurisdictions[i] = new();
					((IFixParser)MandatoryClearingJurisdictions[i]).Parse(viewNoMandatoryClearingJurisdictions.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoMandatoryClearingJurisdictions":
				{
					value = MandatoryClearingJurisdictions;
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
			MandatoryClearingJurisdictions = null;
		}
	}
}
