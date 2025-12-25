using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("CC", FixVersion.FIX50SP2)]
	public sealed partial class StreamAssignmentRequest : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 1497, Type = TagType.String, Offset = 1, Required = true)]
		public string? StreamAsgnReqID {get; set;}
		
		[TagDetails(Tag = 1498, Type = TagType.Int, Offset = 2, Required = true)]
		public int? StreamAsgnReqType {get; set;}
		
		[Component(Offset = 3, Required = true)]
		public StrmAsgnReqGrp? StrmAsgnReqGrp {get; set;}
		
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
			if (StreamAsgnReqID is not null) writer.WriteString(1497, StreamAsgnReqID);
			if (StreamAsgnReqType is not null) writer.WriteWholeNumber(1498, StreamAsgnReqType.Value);
			if (StrmAsgnReqGrp is not null) ((IFixEncoder)StrmAsgnReqGrp).Encode(writer);
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
			StreamAsgnReqID = view.GetString(1497);
			StreamAsgnReqType = view.GetInt32(1498);
			if (view.GetView("StrmAsgnReqGrp") is IMessageView viewStrmAsgnReqGrp)
			{
				StrmAsgnReqGrp = new();
				((IFixParser)StrmAsgnReqGrp).Parse(viewStrmAsgnReqGrp);
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
				case "StreamAsgnReqID":
				{
					value = StreamAsgnReqID;
					break;
				}
				case "StreamAsgnReqType":
				{
					value = StreamAsgnReqType;
					break;
				}
				case "StrmAsgnReqGrp":
				{
					value = StrmAsgnReqGrp;
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
			StreamAsgnReqID = null;
			StreamAsgnReqType = null;
			((IFixReset?)StrmAsgnReqGrp)?.Reset();
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
