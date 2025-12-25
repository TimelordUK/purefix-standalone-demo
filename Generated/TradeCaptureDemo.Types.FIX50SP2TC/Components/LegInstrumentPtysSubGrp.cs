using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegInstrumentPtysSubGrp : IFixComponent
	{
		public sealed partial class NoLegInstrumentPartySubIDs : IFixGroup
		{
			[TagDetails(Tag = 2259, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegInstrumentPartySubID {get; set;}
			
			[TagDetails(Tag = 2260, Type = TagType.Int, Offset = 1, Required = false)]
			public int? LegInstrumentPartySubIDType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegInstrumentPartySubID is not null) writer.WriteString(2259, LegInstrumentPartySubID);
				if (LegInstrumentPartySubIDType is not null) writer.WriteWholeNumber(2260, LegInstrumentPartySubIDType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegInstrumentPartySubID = view.GetString(2259);
				LegInstrumentPartySubIDType = view.GetInt32(2260);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegInstrumentPartySubID":
					{
						value = LegInstrumentPartySubID;
						break;
					}
					case "LegInstrumentPartySubIDType":
					{
						value = LegInstrumentPartySubIDType;
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
				LegInstrumentPartySubID = null;
				LegInstrumentPartySubIDType = null;
			}
		}
		[Group(NoOfTag = 2258, Offset = 0, Required = false)]
		public NoLegInstrumentPartySubIDs[]? LegInstrumentPartySubIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegInstrumentPartySubIDs is not null && LegInstrumentPartySubIDs.Length != 0)
			{
				writer.WriteWholeNumber(2258, LegInstrumentPartySubIDs.Length);
				for (int i = 0; i < LegInstrumentPartySubIDs.Length; i++)
				{
					((IFixEncoder)LegInstrumentPartySubIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegInstrumentPartySubIDs") is IMessageView viewNoLegInstrumentPartySubIDs)
			{
				var count = viewNoLegInstrumentPartySubIDs.GroupCount();
				LegInstrumentPartySubIDs = new NoLegInstrumentPartySubIDs[count];
				for (int i = 0; i < count; i++)
				{
					LegInstrumentPartySubIDs[i] = new();
					((IFixParser)LegInstrumentPartySubIDs[i]).Parse(viewNoLegInstrumentPartySubIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegInstrumentPartySubIDs":
				{
					value = LegInstrumentPartySubIDs;
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
			LegInstrumentPartySubIDs = null;
		}
	}
}
