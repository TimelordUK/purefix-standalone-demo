using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("DU", FixVersion.FIX50SP2)]
	public sealed partial class AllocationInstructionAlertRequest : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 2758, Type = TagType.String, Offset = 1, Required = false)]
		public string? AllocRequestID {get; set;}
		
		[TagDetails(Tag = 1730, Type = TagType.String, Offset = 2, Required = false)]
		public string? AllocGroupID {get; set;}
		
		[TagDetails(Tag = 1731, Type = TagType.String, Offset = 3, Required = false)]
		public string? AvgPxGroupID {get; set;}
		
		[TagDetails(Tag = 75, Type = TagType.LocalDate, Offset = 4, Required = false)]
		public DateOnly? TradeDate {get; set;}
		
		[Component(Offset = 5, Required = false)]
		public Parties? Parties {get; set;}
		
		[Component(Offset = 6, Required = true)]
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
			if (AllocRequestID is not null) writer.WriteString(2758, AllocRequestID);
			if (AllocGroupID is not null) writer.WriteString(1730, AllocGroupID);
			if (AvgPxGroupID is not null) writer.WriteString(1731, AvgPxGroupID);
			if (TradeDate is not null) writer.WriteLocalDateOnly(75, TradeDate.Value);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
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
			AllocRequestID = view.GetString(2758);
			AllocGroupID = view.GetString(1730);
			AvgPxGroupID = view.GetString(1731);
			TradeDate = view.GetDateOnly(75);
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
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
				case "AllocRequestID":
				{
					value = AllocRequestID;
					break;
				}
				case "AllocGroupID":
				{
					value = AllocGroupID;
					break;
				}
				case "AvgPxGroupID":
				{
					value = AvgPxGroupID;
					break;
				}
				case "TradeDate":
				{
					value = TradeDate;
					break;
				}
				case "Parties":
				{
					value = Parties;
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
			AllocRequestID = null;
			AllocGroupID = null;
			AvgPxGroupID = null;
			TradeDate = null;
			((IFixReset?)Parties)?.Reset();
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
