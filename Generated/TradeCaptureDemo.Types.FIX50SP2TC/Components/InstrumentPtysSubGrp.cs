using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class InstrumentPtysSubGrp : IFixComponent
	{
		public sealed partial class NoInstrumentPartySubIDs : IFixGroup
		{
			[TagDetails(Tag = 1053, Type = TagType.String, Offset = 0, Required = false)]
			public string? InstrumentPartySubID {get; set;}
			
			[TagDetails(Tag = 1054, Type = TagType.Int, Offset = 1, Required = false)]
			public int? InstrumentPartySubIDType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (InstrumentPartySubID is not null) writer.WriteString(1053, InstrumentPartySubID);
				if (InstrumentPartySubIDType is not null) writer.WriteWholeNumber(1054, InstrumentPartySubIDType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				InstrumentPartySubID = view.GetString(1053);
				InstrumentPartySubIDType = view.GetInt32(1054);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "InstrumentPartySubID":
					{
						value = InstrumentPartySubID;
						break;
					}
					case "InstrumentPartySubIDType":
					{
						value = InstrumentPartySubIDType;
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
				InstrumentPartySubID = null;
				InstrumentPartySubIDType = null;
			}
		}
		[Group(NoOfTag = 1052, Offset = 0, Required = false)]
		public NoInstrumentPartySubIDs[]? InstrumentPartySubIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (InstrumentPartySubIDs is not null && InstrumentPartySubIDs.Length != 0)
			{
				writer.WriteWholeNumber(1052, InstrumentPartySubIDs.Length);
				for (int i = 0; i < InstrumentPartySubIDs.Length; i++)
				{
					((IFixEncoder)InstrumentPartySubIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoInstrumentPartySubIDs") is IMessageView viewNoInstrumentPartySubIDs)
			{
				var count = viewNoInstrumentPartySubIDs.GroupCount();
				InstrumentPartySubIDs = new NoInstrumentPartySubIDs[count];
				for (int i = 0; i < count; i++)
				{
					InstrumentPartySubIDs[i] = new();
					((IFixParser)InstrumentPartySubIDs[i]).Parse(viewNoInstrumentPartySubIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoInstrumentPartySubIDs":
				{
					value = InstrumentPartySubIDs;
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
			InstrumentPartySubIDs = null;
		}
	}
}
