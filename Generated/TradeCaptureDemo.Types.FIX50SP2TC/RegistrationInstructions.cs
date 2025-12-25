using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("o", FixVersion.FIX50SP2)]
	public sealed partial class RegistrationInstructions : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 513, Type = TagType.String, Offset = 1, Required = true)]
		public string? RegistID {get; set;}
		
		[TagDetails(Tag = 715, Type = TagType.LocalDate, Offset = 2, Required = false)]
		public DateOnly? ClearingBusinessDate {get; set;}
		
		[TagDetails(Tag = 514, Type = TagType.String, Offset = 3, Required = true)]
		public string? RegistTransType {get; set;}
		
		[TagDetails(Tag = 508, Type = TagType.String, Offset = 4, Required = true)]
		public string? RegistRefID {get; set;}
		
		[TagDetails(Tag = 11, Type = TagType.String, Offset = 5, Required = false)]
		public string? ClOrdID {get; set;}
		
		[Component(Offset = 6, Required = false)]
		public Parties? Parties {get; set;}
		
		[TagDetails(Tag = 1, Type = TagType.String, Offset = 7, Required = false)]
		public string? Account {get; set;}
		
		[TagDetails(Tag = 660, Type = TagType.Int, Offset = 8, Required = false)]
		public int? AcctIDSource {get; set;}
		
		[TagDetails(Tag = 493, Type = TagType.String, Offset = 9, Required = false)]
		public string? RegistAcctType {get; set;}
		
		[TagDetails(Tag = 495, Type = TagType.Int, Offset = 10, Required = false)]
		public int? TaxAdvantageType {get; set;}
		
		[TagDetails(Tag = 517, Type = TagType.String, Offset = 11, Required = false)]
		public string? OwnershipType {get; set;}
		
		[Component(Offset = 12, Required = false)]
		public RgstDtlsGrp? RgstDtlsGrp {get; set;}
		
		[Component(Offset = 13, Required = false)]
		public RgstDistInstGrp? RgstDistInstGrp {get; set;}
		
		[Component(Offset = 14, Required = true)]
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
			if (RegistID is not null) writer.WriteString(513, RegistID);
			if (ClearingBusinessDate is not null) writer.WriteLocalDateOnly(715, ClearingBusinessDate.Value);
			if (RegistTransType is not null) writer.WriteString(514, RegistTransType);
			if (RegistRefID is not null) writer.WriteString(508, RegistRefID);
			if (ClOrdID is not null) writer.WriteString(11, ClOrdID);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (Account is not null) writer.WriteString(1, Account);
			if (AcctIDSource is not null) writer.WriteWholeNumber(660, AcctIDSource.Value);
			if (RegistAcctType is not null) writer.WriteString(493, RegistAcctType);
			if (TaxAdvantageType is not null) writer.WriteWholeNumber(495, TaxAdvantageType.Value);
			if (OwnershipType is not null) writer.WriteString(517, OwnershipType);
			if (RgstDtlsGrp is not null) ((IFixEncoder)RgstDtlsGrp).Encode(writer);
			if (RgstDistInstGrp is not null) ((IFixEncoder)RgstDistInstGrp).Encode(writer);
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
			RegistID = view.GetString(513);
			ClearingBusinessDate = view.GetDateOnly(715);
			RegistTransType = view.GetString(514);
			RegistRefID = view.GetString(508);
			ClOrdID = view.GetString(11);
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			Account = view.GetString(1);
			AcctIDSource = view.GetInt32(660);
			RegistAcctType = view.GetString(493);
			TaxAdvantageType = view.GetInt32(495);
			OwnershipType = view.GetString(517);
			if (view.GetView("RgstDtlsGrp") is IMessageView viewRgstDtlsGrp)
			{
				RgstDtlsGrp = new();
				((IFixParser)RgstDtlsGrp).Parse(viewRgstDtlsGrp);
			}
			if (view.GetView("RgstDistInstGrp") is IMessageView viewRgstDistInstGrp)
			{
				RgstDistInstGrp = new();
				((IFixParser)RgstDistInstGrp).Parse(viewRgstDistInstGrp);
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
				case "RegistID":
				{
					value = RegistID;
					break;
				}
				case "ClearingBusinessDate":
				{
					value = ClearingBusinessDate;
					break;
				}
				case "RegistTransType":
				{
					value = RegistTransType;
					break;
				}
				case "RegistRefID":
				{
					value = RegistRefID;
					break;
				}
				case "ClOrdID":
				{
					value = ClOrdID;
					break;
				}
				case "Parties":
				{
					value = Parties;
					break;
				}
				case "Account":
				{
					value = Account;
					break;
				}
				case "AcctIDSource":
				{
					value = AcctIDSource;
					break;
				}
				case "RegistAcctType":
				{
					value = RegistAcctType;
					break;
				}
				case "TaxAdvantageType":
				{
					value = TaxAdvantageType;
					break;
				}
				case "OwnershipType":
				{
					value = OwnershipType;
					break;
				}
				case "RgstDtlsGrp":
				{
					value = RgstDtlsGrp;
					break;
				}
				case "RgstDistInstGrp":
				{
					value = RgstDistInstGrp;
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
			RegistID = null;
			ClearingBusinessDate = null;
			RegistTransType = null;
			RegistRefID = null;
			ClOrdID = null;
			((IFixReset?)Parties)?.Reset();
			Account = null;
			AcctIDSource = null;
			RegistAcctType = null;
			TaxAdvantageType = null;
			OwnershipType = null;
			((IFixReset?)RgstDtlsGrp)?.Reset();
			((IFixReset?)RgstDistInstGrp)?.Reset();
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
