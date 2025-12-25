using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("N", FixVersion.FIX50SP2)]
	public sealed partial class ListStatus : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 66, Type = TagType.String, Offset = 1, Required = true)]
		public string? ListID {get; set;}
		
		[TagDetails(Tag = 429, Type = TagType.Int, Offset = 2, Required = true)]
		public int? ListStatusType {get; set;}
		
		[TagDetails(Tag = 82, Type = TagType.Int, Offset = 3, Required = true)]
		public int? NoRpts {get; set;}
		
		[TagDetails(Tag = 431, Type = TagType.Int, Offset = 4, Required = true)]
		public int? ListOrderStatus {get; set;}
		
		[TagDetails(Tag = 1385, Type = TagType.Int, Offset = 5, Required = false)]
		public int? ContingencyType {get; set;}
		
		[TagDetails(Tag = 1386, Type = TagType.Int, Offset = 6, Required = false)]
		public int? ListRejectReason {get; set;}
		
		[TagDetails(Tag = 83, Type = TagType.Int, Offset = 7, Required = true)]
		public int? RptSeq {get; set;}
		
		[TagDetails(Tag = 444, Type = TagType.String, Offset = 8, Required = false)]
		public string? ListStatusText {get; set;}
		
		[TagDetails(Tag = 445, Type = TagType.Length, Offset = 9, Required = false)]
		public int? EncodedListStatusTextLen {get; set;}
		
		[TagDetails(Tag = 446, Type = TagType.RawData, Offset = 10, Required = false)]
		public byte[]? EncodedListStatusText {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 11, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 68, Type = TagType.Int, Offset = 12, Required = true)]
		public int? TotNoOrders {get; set;}
		
		[TagDetails(Tag = 893, Type = TagType.Boolean, Offset = 13, Required = false)]
		public bool? LastFragment {get; set;}
		
		[Component(Offset = 14, Required = true)]
		public OrdListStatGrp? OrdListStatGrp {get; set;}
		
		[Component(Offset = 15, Required = true)]
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
			if (ListStatusType is not null) writer.WriteWholeNumber(429, ListStatusType.Value);
			if (NoRpts is not null) writer.WriteWholeNumber(82, NoRpts.Value);
			if (ListOrderStatus is not null) writer.WriteWholeNumber(431, ListOrderStatus.Value);
			if (ContingencyType is not null) writer.WriteWholeNumber(1385, ContingencyType.Value);
			if (ListRejectReason is not null) writer.WriteWholeNumber(1386, ListRejectReason.Value);
			if (RptSeq is not null) writer.WriteWholeNumber(83, RptSeq.Value);
			if (ListStatusText is not null) writer.WriteString(444, ListStatusText);
			if (EncodedListStatusTextLen is not null) writer.WriteWholeNumber(445, EncodedListStatusTextLen.Value);
			if (EncodedListStatusText is not null) writer.WriteBuffer(446, EncodedListStatusText);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (TotNoOrders is not null) writer.WriteWholeNumber(68, TotNoOrders.Value);
			if (LastFragment is not null) writer.WriteBoolean(893, LastFragment.Value);
			if (OrdListStatGrp is not null) ((IFixEncoder)OrdListStatGrp).Encode(writer);
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
			ListStatusType = view.GetInt32(429);
			NoRpts = view.GetInt32(82);
			ListOrderStatus = view.GetInt32(431);
			ContingencyType = view.GetInt32(1385);
			ListRejectReason = view.GetInt32(1386);
			RptSeq = view.GetInt32(83);
			ListStatusText = view.GetString(444);
			EncodedListStatusTextLen = view.GetInt32(445);
			EncodedListStatusText = view.GetByteArray(446);
			TransactTime = view.GetDateTime(60);
			TotNoOrders = view.GetInt32(68);
			LastFragment = view.GetBool(893);
			if (view.GetView("OrdListStatGrp") is IMessageView viewOrdListStatGrp)
			{
				OrdListStatGrp = new();
				((IFixParser)OrdListStatGrp).Parse(viewOrdListStatGrp);
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
				case "ListStatusType":
				{
					value = ListStatusType;
					break;
				}
				case "NoRpts":
				{
					value = NoRpts;
					break;
				}
				case "ListOrderStatus":
				{
					value = ListOrderStatus;
					break;
				}
				case "ContingencyType":
				{
					value = ContingencyType;
					break;
				}
				case "ListRejectReason":
				{
					value = ListRejectReason;
					break;
				}
				case "RptSeq":
				{
					value = RptSeq;
					break;
				}
				case "ListStatusText":
				{
					value = ListStatusText;
					break;
				}
				case "EncodedListStatusTextLen":
				{
					value = EncodedListStatusTextLen;
					break;
				}
				case "EncodedListStatusText":
				{
					value = EncodedListStatusText;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "TotNoOrders":
				{
					value = TotNoOrders;
					break;
				}
				case "LastFragment":
				{
					value = LastFragment;
					break;
				}
				case "OrdListStatGrp":
				{
					value = OrdListStatGrp;
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
			ListStatusType = null;
			NoRpts = null;
			ListOrderStatus = null;
			ContingencyType = null;
			ListRejectReason = null;
			RptSeq = null;
			ListStatusText = null;
			EncodedListStatusTextLen = null;
			EncodedListStatusText = null;
			TransactTime = null;
			TotNoOrders = null;
			LastFragment = null;
			((IFixReset?)OrdListStatGrp)?.Reset();
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
