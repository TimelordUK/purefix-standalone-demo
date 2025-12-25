using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("BD", FixVersion.FIX50SP2)]
	public sealed partial class NetworkCounterpartySystemStatusResponse : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 937, Type = TagType.Int, Offset = 1, Required = true)]
		public int? NetworkStatusResponseType {get; set;}
		
		[TagDetails(Tag = 933, Type = TagType.String, Offset = 2, Required = false)]
		public string? NetworkRequestID {get; set;}
		
		[TagDetails(Tag = 932, Type = TagType.String, Offset = 3, Required = true)]
		public string? NetworkResponseID {get; set;}
		
		[TagDetails(Tag = 934, Type = TagType.String, Offset = 4, Required = false)]
		public string? LastNetworkResponseID {get; set;}
		
		[Component(Offset = 5, Required = true)]
		public CompIDStatGrp? CompIDStatGrp {get; set;}
		
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
			if (NetworkStatusResponseType is not null) writer.WriteWholeNumber(937, NetworkStatusResponseType.Value);
			if (NetworkRequestID is not null) writer.WriteString(933, NetworkRequestID);
			if (NetworkResponseID is not null) writer.WriteString(932, NetworkResponseID);
			if (LastNetworkResponseID is not null) writer.WriteString(934, LastNetworkResponseID);
			if (CompIDStatGrp is not null) ((IFixEncoder)CompIDStatGrp).Encode(writer);
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
			NetworkStatusResponseType = view.GetInt32(937);
			NetworkRequestID = view.GetString(933);
			NetworkResponseID = view.GetString(932);
			LastNetworkResponseID = view.GetString(934);
			if (view.GetView("CompIDStatGrp") is IMessageView viewCompIDStatGrp)
			{
				CompIDStatGrp = new();
				((IFixParser)CompIDStatGrp).Parse(viewCompIDStatGrp);
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
				case "NetworkStatusResponseType":
				{
					value = NetworkStatusResponseType;
					break;
				}
				case "NetworkRequestID":
				{
					value = NetworkRequestID;
					break;
				}
				case "NetworkResponseID":
				{
					value = NetworkResponseID;
					break;
				}
				case "LastNetworkResponseID":
				{
					value = LastNetworkResponseID;
					break;
				}
				case "CompIDStatGrp":
				{
					value = CompIDStatGrp;
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
			NetworkStatusResponseType = null;
			NetworkRequestID = null;
			NetworkResponseID = null;
			LastNetworkResponseID = null;
			((IFixReset?)CompIDStatGrp)?.Reset();
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
