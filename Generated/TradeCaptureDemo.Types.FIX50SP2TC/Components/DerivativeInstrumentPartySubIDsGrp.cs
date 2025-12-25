using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class DerivativeInstrumentPartySubIDsGrp : IFixComponent
	{
		public sealed partial class NoDerivativeInstrumentPartySubIDs : IFixGroup
		{
			[TagDetails(Tag = 1297, Type = TagType.String, Offset = 0, Required = false)]
			public string? DerivativeInstrumentPartySubID {get; set;}
			
			[TagDetails(Tag = 1298, Type = TagType.Int, Offset = 1, Required = false)]
			public int? DerivativeInstrumentPartySubIDType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (DerivativeInstrumentPartySubID is not null) writer.WriteString(1297, DerivativeInstrumentPartySubID);
				if (DerivativeInstrumentPartySubIDType is not null) writer.WriteWholeNumber(1298, DerivativeInstrumentPartySubIDType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				DerivativeInstrumentPartySubID = view.GetString(1297);
				DerivativeInstrumentPartySubIDType = view.GetInt32(1298);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "DerivativeInstrumentPartySubID":
					{
						value = DerivativeInstrumentPartySubID;
						break;
					}
					case "DerivativeInstrumentPartySubIDType":
					{
						value = DerivativeInstrumentPartySubIDType;
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
				DerivativeInstrumentPartySubID = null;
				DerivativeInstrumentPartySubIDType = null;
			}
		}
		[Group(NoOfTag = 1296, Offset = 0, Required = false)]
		public NoDerivativeInstrumentPartySubIDs[]? DerivativeInstrumentPartySubIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (DerivativeInstrumentPartySubIDs is not null && DerivativeInstrumentPartySubIDs.Length != 0)
			{
				writer.WriteWholeNumber(1296, DerivativeInstrumentPartySubIDs.Length);
				for (int i = 0; i < DerivativeInstrumentPartySubIDs.Length; i++)
				{
					((IFixEncoder)DerivativeInstrumentPartySubIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoDerivativeInstrumentPartySubIDs") is IMessageView viewNoDerivativeInstrumentPartySubIDs)
			{
				var count = viewNoDerivativeInstrumentPartySubIDs.GroupCount();
				DerivativeInstrumentPartySubIDs = new NoDerivativeInstrumentPartySubIDs[count];
				for (int i = 0; i < count; i++)
				{
					DerivativeInstrumentPartySubIDs[i] = new();
					((IFixParser)DerivativeInstrumentPartySubIDs[i]).Parse(viewNoDerivativeInstrumentPartySubIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoDerivativeInstrumentPartySubIDs":
				{
					value = DerivativeInstrumentPartySubIDs;
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
			DerivativeInstrumentPartySubIDs = null;
		}
	}
}
