using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class SettlDetails : IFixComponent
	{
		public sealed partial class NoSettlDetails : IFixGroup
		{
			[TagDetails(Tag = 1164, Type = TagType.String, Offset = 0, Required = false)]
			public string? SettlObligSource {get; set;}
			
			[TagDetails(Tag = 169, Type = TagType.Int, Offset = 1, Required = false)]
			public int? StandInstDbType {get; set;}
			
			[TagDetails(Tag = 170, Type = TagType.String, Offset = 2, Required = false)]
			public string? StandInstDbName {get; set;}
			
			[TagDetails(Tag = 171, Type = TagType.String, Offset = 3, Required = false)]
			public string? StandInstDbID {get; set;}
			
			[Component(Offset = 4, Required = false)]
			public SettlParties? SettlParties {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (SettlObligSource is not null) writer.WriteString(1164, SettlObligSource);
				if (StandInstDbType is not null) writer.WriteWholeNumber(169, StandInstDbType.Value);
				if (StandInstDbName is not null) writer.WriteString(170, StandInstDbName);
				if (StandInstDbID is not null) writer.WriteString(171, StandInstDbID);
				if (SettlParties is not null) ((IFixEncoder)SettlParties).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				SettlObligSource = view.GetString(1164);
				StandInstDbType = view.GetInt32(169);
				StandInstDbName = view.GetString(170);
				StandInstDbID = view.GetString(171);
				if (view.GetView("SettlParties") is IMessageView viewSettlParties)
				{
					SettlParties = new();
					((IFixParser)SettlParties).Parse(viewSettlParties);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "SettlObligSource":
					{
						value = SettlObligSource;
						break;
					}
					case "StandInstDbType":
					{
						value = StandInstDbType;
						break;
					}
					case "StandInstDbName":
					{
						value = StandInstDbName;
						break;
					}
					case "StandInstDbID":
					{
						value = StandInstDbID;
						break;
					}
					case "SettlParties":
					{
						value = SettlParties;
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
				SettlObligSource = null;
				StandInstDbType = null;
				StandInstDbName = null;
				StandInstDbID = null;
				((IFixReset?)SettlParties)?.Reset();
			}
		}
		[Group(NoOfTag = 1158, Offset = 0, Required = false)]
		public NoSettlDetails[]? SettlDetailsItems {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (SettlDetailsItems is not null && SettlDetailsItems.Length != 0)
			{
				writer.WriteWholeNumber(1158, SettlDetailsItems.Length);
				for (int i = 0; i < SettlDetailsItems.Length; i++)
				{
					((IFixEncoder)SettlDetailsItems[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoSettlDetails") is IMessageView viewNoSettlDetails)
			{
				var count = viewNoSettlDetails.GroupCount();
				SettlDetailsItems = new NoSettlDetails[count];
				for (int i = 0; i < count; i++)
				{
					SettlDetailsItems[i] = new();
					((IFixParser)SettlDetailsItems[i]).Parse(viewNoSettlDetails.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoSettlDetails":
				{
					value = SettlDetailsItems;
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
			SettlDetailsItems = null;
		}
	}
}
