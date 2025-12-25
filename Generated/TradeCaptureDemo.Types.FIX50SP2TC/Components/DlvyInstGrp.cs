using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class DlvyInstGrp : IFixComponent
	{
		public sealed partial class NoDlvyInst : IFixGroup
		{
			[TagDetails(Tag = 165, Type = TagType.String, Offset = 0, Required = false)]
			public string? SettlInstSource {get; set;}
			
			[TagDetails(Tag = 787, Type = TagType.String, Offset = 1, Required = false)]
			public string? DlvyInstType {get; set;}
			
			[Component(Offset = 2, Required = false)]
			public SettlParties? SettlParties {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (SettlInstSource is not null) writer.WriteString(165, SettlInstSource);
				if (DlvyInstType is not null) writer.WriteString(787, DlvyInstType);
				if (SettlParties is not null) ((IFixEncoder)SettlParties).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				SettlInstSource = view.GetString(165);
				DlvyInstType = view.GetString(787);
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
					case "SettlInstSource":
					{
						value = SettlInstSource;
						break;
					}
					case "DlvyInstType":
					{
						value = DlvyInstType;
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
				SettlInstSource = null;
				DlvyInstType = null;
				((IFixReset?)SettlParties)?.Reset();
			}
		}
		[Group(NoOfTag = 85, Offset = 0, Required = false)]
		public NoDlvyInst[]? DlvyInst {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (DlvyInst is not null && DlvyInst.Length != 0)
			{
				writer.WriteWholeNumber(85, DlvyInst.Length);
				for (int i = 0; i < DlvyInst.Length; i++)
				{
					((IFixEncoder)DlvyInst[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoDlvyInst") is IMessageView viewNoDlvyInst)
			{
				var count = viewNoDlvyInst.GroupCount();
				DlvyInst = new NoDlvyInst[count];
				for (int i = 0; i < count; i++)
				{
					DlvyInst[i] = new();
					((IFixParser)DlvyInst[i]).Parse(viewNoDlvyInst.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoDlvyInst":
				{
					value = DlvyInst;
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
			DlvyInst = null;
		}
	}
}
