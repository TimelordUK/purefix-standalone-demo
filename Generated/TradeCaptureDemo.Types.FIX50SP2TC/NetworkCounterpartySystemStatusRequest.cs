using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("BC", FixVersion.FIX50SP2)]
	public sealed partial class NetworkCounterpartySystemStatusRequest : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 935, Type = TagType.Int, Offset = 1, Required = true)]
		public int? NetworkRequestType {get; set;}
		
		[TagDetails(Tag = 933, Type = TagType.String, Offset = 2, Required = true)]
		public string? NetworkRequestID {get; set;}
		
		[Component(Offset = 3, Required = false)]
		public CompIDReqGrp? CompIDReqGrp {get; set;}
		
		[Component(Offset = 4, Required = true)]
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
			if (NetworkRequestType is not null) writer.WriteWholeNumber(935, NetworkRequestType.Value);
			if (NetworkRequestID is not null) writer.WriteString(933, NetworkRequestID);
			if (CompIDReqGrp is not null) ((IFixEncoder)CompIDReqGrp).Encode(writer);
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
			NetworkRequestType = view.GetInt32(935);
			NetworkRequestID = view.GetString(933);
			if (view.GetView("CompIDReqGrp") is IMessageView viewCompIDReqGrp)
			{
				CompIDReqGrp = new();
				((IFixParser)CompIDReqGrp).Parse(viewCompIDReqGrp);
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
				case "NetworkRequestType":
				{
					value = NetworkRequestType;
					break;
				}
				case "NetworkRequestID":
				{
					value = NetworkRequestID;
					break;
				}
				case "CompIDReqGrp":
				{
					value = CompIDReqGrp;
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
			NetworkRequestType = null;
			NetworkRequestID = null;
			((IFixReset?)CompIDReqGrp)?.Reset();
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
