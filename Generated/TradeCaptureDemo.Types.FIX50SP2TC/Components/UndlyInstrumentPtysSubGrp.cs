using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UndlyInstrumentPtysSubGrp : IFixComponent
	{
		public sealed partial class NoUndlyInstrumentPartySubIDs : IFixGroup
		{
			[TagDetails(Tag = 1063, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingInstrumentPartySubID {get; set;}
			
			[TagDetails(Tag = 1064, Type = TagType.Int, Offset = 1, Required = false)]
			public int? UnderlyingInstrumentPartySubIDType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingInstrumentPartySubID is not null) writer.WriteString(1063, UnderlyingInstrumentPartySubID);
				if (UnderlyingInstrumentPartySubIDType is not null) writer.WriteWholeNumber(1064, UnderlyingInstrumentPartySubIDType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingInstrumentPartySubID = view.GetString(1063);
				UnderlyingInstrumentPartySubIDType = view.GetInt32(1064);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingInstrumentPartySubID":
					{
						value = UnderlyingInstrumentPartySubID;
						break;
					}
					case "UnderlyingInstrumentPartySubIDType":
					{
						value = UnderlyingInstrumentPartySubIDType;
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
				UnderlyingInstrumentPartySubID = null;
				UnderlyingInstrumentPartySubIDType = null;
			}
		}
		[Group(NoOfTag = 1062, Offset = 0, Required = false)]
		public NoUndlyInstrumentPartySubIDs[]? UndlyInstrumentPartySubIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UndlyInstrumentPartySubIDs is not null && UndlyInstrumentPartySubIDs.Length != 0)
			{
				writer.WriteWholeNumber(1062, UndlyInstrumentPartySubIDs.Length);
				for (int i = 0; i < UndlyInstrumentPartySubIDs.Length; i++)
				{
					((IFixEncoder)UndlyInstrumentPartySubIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUndlyInstrumentPartySubIDs") is IMessageView viewNoUndlyInstrumentPartySubIDs)
			{
				var count = viewNoUndlyInstrumentPartySubIDs.GroupCount();
				UndlyInstrumentPartySubIDs = new NoUndlyInstrumentPartySubIDs[count];
				for (int i = 0; i < count; i++)
				{
					UndlyInstrumentPartySubIDs[i] = new();
					((IFixParser)UndlyInstrumentPartySubIDs[i]).Parse(viewNoUndlyInstrumentPartySubIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUndlyInstrumentPartySubIDs":
				{
					value = UndlyInstrumentPartySubIDs;
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
			UndlyInstrumentPartySubIDs = null;
		}
	}
}
