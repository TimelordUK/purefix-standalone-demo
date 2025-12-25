using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("CD", FixVersion.FIX50SP2)]
	public sealed partial class StreamAssignmentReport : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 1501, Type = TagType.String, Offset = 1, Required = true)]
		public string? StreamAsgnRptID {get; set;}
		
		[TagDetails(Tag = 1498, Type = TagType.Int, Offset = 2, Required = false)]
		public int? StreamAsgnReqType {get; set;}
		
		[TagDetails(Tag = 1497, Type = TagType.String, Offset = 3, Required = false)]
		public string? StreamAsgnReqID {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public StrmAsgnRptGrp? StrmAsgnRptGrp {get; set;}
		
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
			if (StreamAsgnRptID is not null) writer.WriteString(1501, StreamAsgnRptID);
			if (StreamAsgnReqType is not null) writer.WriteWholeNumber(1498, StreamAsgnReqType.Value);
			if (StreamAsgnReqID is not null) writer.WriteString(1497, StreamAsgnReqID);
			if (StrmAsgnRptGrp is not null) ((IFixEncoder)StrmAsgnRptGrp).Encode(writer);
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
			StreamAsgnRptID = view.GetString(1501);
			StreamAsgnReqType = view.GetInt32(1498);
			StreamAsgnReqID = view.GetString(1497);
			if (view.GetView("StrmAsgnRptGrp") is IMessageView viewStrmAsgnRptGrp)
			{
				StrmAsgnRptGrp = new();
				((IFixParser)StrmAsgnRptGrp).Parse(viewStrmAsgnRptGrp);
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
				case "StreamAsgnRptID":
				{
					value = StreamAsgnRptID;
					break;
				}
				case "StreamAsgnReqType":
				{
					value = StreamAsgnReqType;
					break;
				}
				case "StreamAsgnReqID":
				{
					value = StreamAsgnReqID;
					break;
				}
				case "StrmAsgnRptGrp":
				{
					value = StrmAsgnRptGrp;
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
			StreamAsgnRptID = null;
			StreamAsgnReqType = null;
			StreamAsgnReqID = null;
			((IFixReset?)StrmAsgnRptGrp)?.Reset();
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
