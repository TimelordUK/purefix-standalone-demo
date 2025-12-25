using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("m", FixVersion.FIX50SP2)]
	public sealed partial class ListStrikePrice : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 66, Type = TagType.String, Offset = 1, Required = true)]
		public string? ListID {get; set;}
		
		[TagDetails(Tag = 422, Type = TagType.Int, Offset = 2, Required = true)]
		public int? TotNoStrikes {get; set;}
		
		[TagDetails(Tag = 893, Type = TagType.Boolean, Offset = 3, Required = false)]
		public bool? LastFragment {get; set;}
		
		[Component(Offset = 4, Required = true)]
		public InstrmtStrkPxGrp? InstrmtStrkPxGrp {get; set;}
		
		[Component(Offset = 5, Required = true)]
		public StandardTrailer? StandardTrailer {get; set;}
		
		
		IStandardHeader? IFixMessage.StandardHeader => StandardHeader;
		
		IStandardTrailer? IFixMessage.StandardTrailer => StandardTrailer;
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return (!config.CheckStandardHeader || (StandardHeader is not null && ((IFixValidator)StandardHeader).IsValid(in config))) && (!config.CheckStandardTrailer || (StandardTrailer is not null && ((IFixValidator)StandardTrailer).IsValid(in config)));
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (StandardHeader is not null) ((IFixEncoder)StandardHeader).Encode(writer);
			if (ListID is not null) writer.WriteString(66, ListID);
			if (TotNoStrikes is not null) writer.WriteWholeNumber(422, TotNoStrikes.Value);
			if (LastFragment is not null) writer.WriteBoolean(893, LastFragment.Value);
			if (InstrmtStrkPxGrp is not null) ((IFixEncoder)InstrmtStrkPxGrp).Encode(writer);
			if (StandardTrailer is not null) ((IFixEncoder)StandardTrailer).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("StandardHeader") is IMessageView viewStandardHeader)
			{
				StandardHeader = new();
				((IFixParser)StandardHeader).Parse(viewStandardHeader);
			}
			ListID = view.GetString(66);
			TotNoStrikes = view.GetInt32(422);
			LastFragment = view.GetBool(893);
			if (view.GetView("InstrmtStrkPxGrp") is IMessageView viewInstrmtStrkPxGrp)
			{
				InstrmtStrkPxGrp = new();
				((IFixParser)InstrmtStrkPxGrp).Parse(viewInstrmtStrkPxGrp);
			}
			if (view.GetView("StandardTrailer") is IMessageView viewStandardTrailer)
			{
				StandardTrailer = new();
				((IFixParser)StandardTrailer).Parse(viewStandardTrailer);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "StandardHeader":
				{
					value = StandardHeader;
					break;
				}
				case "ListID":
				{
					value = ListID;
					break;
				}
				case "TotNoStrikes":
				{
					value = TotNoStrikes;
					break;
				}
				case "LastFragment":
				{
					value = LastFragment;
					break;
				}
				case "InstrmtStrkPxGrp":
				{
					value = InstrmtStrkPxGrp;
					break;
				}
				case "StandardTrailer":
				{
					value = StandardTrailer;
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
			((IFixReset?)StandardHeader)?.Reset();
			ListID = null;
			TotNoStrikes = null;
			LastFragment = null;
			((IFixReset?)InstrmtStrkPxGrp)?.Reset();
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
