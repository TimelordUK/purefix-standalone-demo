using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class CommissionData : IFixComponent
	{
		[TagDetails(Tag = 12, Type = TagType.Float, Offset = 0, Required = false)]
		public double? Commission {get; set;}
		
		[TagDetails(Tag = 13, Type = TagType.String, Offset = 1, Required = false)]
		public string? CommType {get; set;}
		
		[TagDetails(Tag = 479, Type = TagType.String, Offset = 2, Required = false)]
		public string? CommCurrency {get; set;}
		
		[TagDetails(Tag = 2922, Type = TagType.String, Offset = 3, Required = false)]
		public string? CommCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 1233, Type = TagType.Float, Offset = 4, Required = false)]
		public double? CommRate {get; set;}
		
		[TagDetails(Tag = 1238, Type = TagType.String, Offset = 5, Required = false)]
		public string? CommUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 497, Type = TagType.String, Offset = 6, Required = false)]
		public string? FundRenewWaiv {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Commission is not null) writer.WriteNumber(12, Commission.Value);
			if (CommType is not null) writer.WriteString(13, CommType);
			if (CommCurrency is not null) writer.WriteString(479, CommCurrency);
			if (CommCurrencyCodeSource is not null) writer.WriteString(2922, CommCurrencyCodeSource);
			if (CommRate is not null) writer.WriteNumber(1233, CommRate.Value);
			if (CommUnitOfMeasure is not null) writer.WriteString(1238, CommUnitOfMeasure);
			if (FundRenewWaiv is not null) writer.WriteString(497, FundRenewWaiv);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			Commission = view.GetDouble(12);
			CommType = view.GetString(13);
			CommCurrency = view.GetString(479);
			CommCurrencyCodeSource = view.GetString(2922);
			CommRate = view.GetDouble(1233);
			CommUnitOfMeasure = view.GetString(1238);
			FundRenewWaiv = view.GetString(497);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "Commission":
				{
					value = Commission;
					break;
				}
				case "CommType":
				{
					value = CommType;
					break;
				}
				case "CommCurrency":
				{
					value = CommCurrency;
					break;
				}
				case "CommCurrencyCodeSource":
				{
					value = CommCurrencyCodeSource;
					break;
				}
				case "CommRate":
				{
					value = CommRate;
					break;
				}
				case "CommUnitOfMeasure":
				{
					value = CommUnitOfMeasure;
					break;
				}
				case "FundRenewWaiv":
				{
					value = FundRenewWaiv;
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
			Commission = null;
			CommType = null;
			CommCurrency = null;
			CommCurrencyCodeSource = null;
			CommRate = null;
			CommUnitOfMeasure = null;
			FundRenewWaiv = null;
		}
	}
}
