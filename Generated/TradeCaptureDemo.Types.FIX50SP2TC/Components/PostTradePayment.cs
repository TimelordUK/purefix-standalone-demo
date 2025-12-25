using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PostTradePayment : IFixComponent
	{
		[TagDetails(Tag = 2824, Type = TagType.String, Offset = 0, Required = true)]
		public string? PostTradePaymentType {get; set;}
		
		[TagDetails(Tag = 2817, Type = TagType.Float, Offset = 1, Required = true)]
		public double? PostTradePaymentAmount {get; set;}
		
		[TagDetails(Tag = 2818, Type = TagType.String, Offset = 2, Required = false)]
		public string? PostTradePaymentCurrency {get; set;}
		
		[TagDetails(Tag = 2956, Type = TagType.String, Offset = 3, Required = false)]
		public string? PostTradePaymentCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 2825, Type = TagType.LocalDate, Offset = 4, Required = true)]
		public DateOnly? PostTradePaymentCalculationDate {get; set;}
		
		[TagDetails(Tag = 2826, Type = TagType.LocalDate, Offset = 5, Required = true)]
		public DateOnly? PostTradePaymentValueDate {get; set;}
		
		[TagDetails(Tag = 2827, Type = TagType.LocalDate, Offset = 6, Required = false)]
		public DateOnly? PostTradePaymentFinalValueDate {get; set;}
		
		[TagDetails(Tag = 2819, Type = TagType.Int, Offset = 7, Required = true)]
		public int? PostTradePaymentDebitOrCredit {get; set;}
		
		[TagDetails(Tag = 2816, Type = TagType.String, Offset = 8, Required = true)]
		public string? PostTradePaymentAccount {get; set;}
		
		[TagDetails(Tag = 2821, Type = TagType.String, Offset = 9, Required = false)]
		public string? PostTradePaymentID {get; set;}
		
		[TagDetails(Tag = 2820, Type = TagType.String, Offset = 10, Required = false)]
		public string? PostTradePaymentDesc {get; set;}
		
		[TagDetails(Tag = 2815, Type = TagType.Length, Offset = 11, Required = false)]
		public int? EncodedPostTradePaymentDescLen {get; set;}
		
		[TagDetails(Tag = 2814, Type = TagType.RawData, Offset = 12, Required = false)]
		public byte[]? EncodedPostTradePaymentDesc {get; set;}
		
		[TagDetails(Tag = 2822, Type = TagType.String, Offset = 13, Required = false)]
		public string? PostTradePaymentLinkID {get; set;}
		
		[TagDetails(Tag = 2823, Type = TagType.Int, Offset = 14, Required = false)]
		public int? PostTradePaymentStatus {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PostTradePaymentType is not null) writer.WriteString(2824, PostTradePaymentType);
			if (PostTradePaymentAmount is not null) writer.WriteNumber(2817, PostTradePaymentAmount.Value);
			if (PostTradePaymentCurrency is not null) writer.WriteString(2818, PostTradePaymentCurrency);
			if (PostTradePaymentCurrencyCodeSource is not null) writer.WriteString(2956, PostTradePaymentCurrencyCodeSource);
			if (PostTradePaymentCalculationDate is not null) writer.WriteLocalDateOnly(2825, PostTradePaymentCalculationDate.Value);
			if (PostTradePaymentValueDate is not null) writer.WriteLocalDateOnly(2826, PostTradePaymentValueDate.Value);
			if (PostTradePaymentFinalValueDate is not null) writer.WriteLocalDateOnly(2827, PostTradePaymentFinalValueDate.Value);
			if (PostTradePaymentDebitOrCredit is not null) writer.WriteWholeNumber(2819, PostTradePaymentDebitOrCredit.Value);
			if (PostTradePaymentAccount is not null) writer.WriteString(2816, PostTradePaymentAccount);
			if (PostTradePaymentID is not null) writer.WriteString(2821, PostTradePaymentID);
			if (PostTradePaymentDesc is not null) writer.WriteString(2820, PostTradePaymentDesc);
			if (EncodedPostTradePaymentDescLen is not null) writer.WriteWholeNumber(2815, EncodedPostTradePaymentDescLen.Value);
			if (EncodedPostTradePaymentDesc is not null) writer.WriteBuffer(2814, EncodedPostTradePaymentDesc);
			if (PostTradePaymentLinkID is not null) writer.WriteString(2822, PostTradePaymentLinkID);
			if (PostTradePaymentStatus is not null) writer.WriteWholeNumber(2823, PostTradePaymentStatus.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			PostTradePaymentType = view.GetString(2824);
			PostTradePaymentAmount = view.GetDouble(2817);
			PostTradePaymentCurrency = view.GetString(2818);
			PostTradePaymentCurrencyCodeSource = view.GetString(2956);
			PostTradePaymentCalculationDate = view.GetDateOnly(2825);
			PostTradePaymentValueDate = view.GetDateOnly(2826);
			PostTradePaymentFinalValueDate = view.GetDateOnly(2827);
			PostTradePaymentDebitOrCredit = view.GetInt32(2819);
			PostTradePaymentAccount = view.GetString(2816);
			PostTradePaymentID = view.GetString(2821);
			PostTradePaymentDesc = view.GetString(2820);
			EncodedPostTradePaymentDescLen = view.GetInt32(2815);
			EncodedPostTradePaymentDesc = view.GetByteArray(2814);
			PostTradePaymentLinkID = view.GetString(2822);
			PostTradePaymentStatus = view.GetInt32(2823);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "PostTradePaymentType":
				{
					value = PostTradePaymentType;
					break;
				}
				case "PostTradePaymentAmount":
				{
					value = PostTradePaymentAmount;
					break;
				}
				case "PostTradePaymentCurrency":
				{
					value = PostTradePaymentCurrency;
					break;
				}
				case "PostTradePaymentCurrencyCodeSource":
				{
					value = PostTradePaymentCurrencyCodeSource;
					break;
				}
				case "PostTradePaymentCalculationDate":
				{
					value = PostTradePaymentCalculationDate;
					break;
				}
				case "PostTradePaymentValueDate":
				{
					value = PostTradePaymentValueDate;
					break;
				}
				case "PostTradePaymentFinalValueDate":
				{
					value = PostTradePaymentFinalValueDate;
					break;
				}
				case "PostTradePaymentDebitOrCredit":
				{
					value = PostTradePaymentDebitOrCredit;
					break;
				}
				case "PostTradePaymentAccount":
				{
					value = PostTradePaymentAccount;
					break;
				}
				case "PostTradePaymentID":
				{
					value = PostTradePaymentID;
					break;
				}
				case "PostTradePaymentDesc":
				{
					value = PostTradePaymentDesc;
					break;
				}
				case "EncodedPostTradePaymentDescLen":
				{
					value = EncodedPostTradePaymentDescLen;
					break;
				}
				case "EncodedPostTradePaymentDesc":
				{
					value = EncodedPostTradePaymentDesc;
					break;
				}
				case "PostTradePaymentLinkID":
				{
					value = PostTradePaymentLinkID;
					break;
				}
				case "PostTradePaymentStatus":
				{
					value = PostTradePaymentStatus;
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
			PostTradePaymentType = null;
			PostTradePaymentAmount = null;
			PostTradePaymentCurrency = null;
			PostTradePaymentCurrencyCodeSource = null;
			PostTradePaymentCalculationDate = null;
			PostTradePaymentValueDate = null;
			PostTradePaymentFinalValueDate = null;
			PostTradePaymentDebitOrCredit = null;
			PostTradePaymentAccount = null;
			PostTradePaymentID = null;
			PostTradePaymentDesc = null;
			EncodedPostTradePaymentDescLen = null;
			EncodedPostTradePaymentDesc = null;
			PostTradePaymentLinkID = null;
			PostTradePaymentStatus = null;
		}
	}
}
