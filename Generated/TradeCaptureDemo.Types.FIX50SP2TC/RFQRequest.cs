using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("AH", FixVersion.FIX50SP2)]
	public sealed partial class RFQRequest : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 644, Type = TagType.String, Offset = 1, Required = true)]
		public string? RFQReqID {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public Parties? Parties {get; set;}
		
		[Component(Offset = 3, Required = true)]
		public RFQReqGrp? RFQReqGrp {get; set;}
		
		[TagDetails(Tag = 263, Type = TagType.String, Offset = 4, Required = false)]
		public string? SubscriptionRequestType {get; set;}
		
		[TagDetails(Tag = 1171, Type = TagType.Boolean, Offset = 5, Required = false)]
		public bool? PrivateQuote {get; set;}
		
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
			if (RFQReqID is not null) writer.WriteString(644, RFQReqID);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (RFQReqGrp is not null) ((IFixEncoder)RFQReqGrp).Encode(writer);
			if (SubscriptionRequestType is not null) writer.WriteString(263, SubscriptionRequestType);
			if (PrivateQuote is not null) writer.WriteBoolean(1171, PrivateQuote.Value);
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
			RFQReqID = view.GetString(644);
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			if (view.GetView("RFQReqGrp") is IMessageView viewRFQReqGrp)
			{
				RFQReqGrp = new();
				((IFixParser)RFQReqGrp).Parse(viewRFQReqGrp);
			}
			SubscriptionRequestType = view.GetString(263);
			PrivateQuote = view.GetBool(1171);
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
				case "RFQReqID":
				{
					value = RFQReqID;
					break;
				}
				case "Parties":
				{
					value = Parties;
					break;
				}
				case "RFQReqGrp":
				{
					value = RFQReqGrp;
					break;
				}
				case "SubscriptionRequestType":
				{
					value = SubscriptionRequestType;
					break;
				}
				case "PrivateQuote":
				{
					value = PrivateQuote;
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
			RFQReqID = null;
			((IFixReset?)Parties)?.Reset();
			((IFixReset?)RFQReqGrp)?.Reset();
			SubscriptionRequestType = null;
			PrivateQuote = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
