using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class SettlInstructionsData : IFixComponent
	{
		[TagDetails(Tag = 172, Type = TagType.Int, Offset = 0, Required = false)]
		public int? SettlDeliveryType {get; set;}
		
		[TagDetails(Tag = 169, Type = TagType.Int, Offset = 1, Required = false)]
		public int? StandInstDbType {get; set;}
		
		[TagDetails(Tag = 170, Type = TagType.String, Offset = 2, Required = false)]
		public string? StandInstDbName {get; set;}
		
		[TagDetails(Tag = 171, Type = TagType.String, Offset = 3, Required = false)]
		public string? StandInstDbID {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public DlvyInstGrp? DlvyInstGrp {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (SettlDeliveryType is not null) writer.WriteWholeNumber(172, SettlDeliveryType.Value);
			if (StandInstDbType is not null) writer.WriteWholeNumber(169, StandInstDbType.Value);
			if (StandInstDbName is not null) writer.WriteString(170, StandInstDbName);
			if (StandInstDbID is not null) writer.WriteString(171, StandInstDbID);
			if (DlvyInstGrp is not null) ((IFixEncoder)DlvyInstGrp).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			SettlDeliveryType = view.GetInt32(172);
			StandInstDbType = view.GetInt32(169);
			StandInstDbName = view.GetString(170);
			StandInstDbID = view.GetString(171);
			if (view.GetView("DlvyInstGrp") is IMessageView viewDlvyInstGrp)
			{
				DlvyInstGrp = new();
				((IFixParser)DlvyInstGrp).Parse(viewDlvyInstGrp);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "SettlDeliveryType":
				{
					value = SettlDeliveryType;
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
				case "DlvyInstGrp":
				{
					value = DlvyInstGrp;
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
			SettlDeliveryType = null;
			StandInstDbType = null;
			StandInstDbName = null;
			StandInstDbID = null;
			((IFixReset?)DlvyInstGrp)?.Reset();
		}
	}
}
