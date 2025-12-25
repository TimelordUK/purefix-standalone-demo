using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegStreamGrp : IFixComponent
	{
		public sealed partial class NoLegStreams : IFixGroup
		{
			[TagDetails(Tag = 40242, Type = TagType.Int, Offset = 0, Required = false)]
			public int? LegStreamType {get; set;}
			
			[TagDetails(Tag = 41700, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegStreamXID {get; set;}
			
			[TagDetails(Tag = 40243, Type = TagType.String, Offset = 2, Required = false)]
			public string? LegStreamDesc {get; set;}
			
			[TagDetails(Tag = 42583, Type = TagType.String, Offset = 3, Required = false)]
			public string? LegStreamVersion {get; set;}
			
			[TagDetails(Tag = 42584, Type = TagType.LocalDate, Offset = 4, Required = false)]
			public DateOnly? LegStreamVersionEffectiveDate {get; set;}
			
			[TagDetails(Tag = 40244, Type = TagType.Int, Offset = 5, Required = false)]
			public int? LegStreamPaySide {get; set;}
			
			[TagDetails(Tag = 40245, Type = TagType.Int, Offset = 6, Required = false)]
			public int? LegStreamReceiveSide {get; set;}
			
			[TagDetails(Tag = 41702, Type = TagType.String, Offset = 7, Required = false)]
			public string? LegStreamNotionalXIDRef {get; set;}
			
			[TagDetails(Tag = 40246, Type = TagType.Float, Offset = 8, Required = false)]
			public double? LegStreamNotional {get; set;}
			
			[TagDetails(Tag = 40247, Type = TagType.String, Offset = 9, Required = false)]
			public string? LegStreamCurrency {get; set;}
			
			[TagDetails(Tag = 42585, Type = TagType.String, Offset = 10, Required = false)]
			public string? LegStreamNotionalDeterminationMethod {get; set;}
			
			[TagDetails(Tag = 42586, Type = TagType.Int, Offset = 11, Required = false)]
			public int? LegStreamNotionalAdjustments {get; set;}
			
			[TagDetails(Tag = 41703, Type = TagType.Int, Offset = 12, Required = false)]
			public int? LegStreamNotionalFrequencyPeriod {get; set;}
			
			[TagDetails(Tag = 41704, Type = TagType.String, Offset = 13, Required = false)]
			public string? LegStreamNotionalFrequencyUnit {get; set;}
			
			[TagDetails(Tag = 41705, Type = TagType.Int, Offset = 14, Required = false)]
			public int? LegStreamNotionalCommodityFrequency {get; set;}
			
			[TagDetails(Tag = 41706, Type = TagType.String, Offset = 15, Required = false)]
			public string? LegStreamNotionalUnitOfMeasure {get; set;}
			
			[TagDetails(Tag = 41707, Type = TagType.Float, Offset = 16, Required = false)]
			public double? LegStreamTotalNotional {get; set;}
			
			[TagDetails(Tag = 41708, Type = TagType.String, Offset = 17, Required = false)]
			public string? LegStreamTotalNotionalUnitOfMeasure {get; set;}
			
			[Component(Offset = 18, Required = false)]
			public LegStreamCommodity? LegStreamCommodity {get; set;}
			
			[Component(Offset = 19, Required = false)]
			public LegStreamEffectiveDate? LegStreamEffectiveDate {get; set;}
			
			[Component(Offset = 20, Required = false)]
			public LegStreamTerminationDate? LegStreamTerminationDate {get; set;}
			
			[Component(Offset = 21, Required = false)]
			public LegStreamCalculationPeriodDates? LegStreamCalculationPeriodDates {get; set;}
			
			[Component(Offset = 22, Required = false)]
			public LegPaymentStream? LegPaymentStream {get; set;}
			
			[Component(Offset = 23, Required = false)]
			public LegPaymentScheduleGrp? LegPaymentScheduleGrp {get; set;}
			
			[Component(Offset = 24, Required = false)]
			public LegPaymentStubGrp? LegPaymentStubGrp {get; set;}
			
			[Component(Offset = 25, Required = false)]
			public LegDeliveryStream? LegDeliveryStream {get; set;}
			
			[Component(Offset = 26, Required = false)]
			public LegDeliveryScheduleGrp? LegDeliveryScheduleGrp {get; set;}
			
			[TagDetails(Tag = 40248, Type = TagType.String, Offset = 27, Required = false)]
			public string? LegStreamText {get; set;}
			
			[TagDetails(Tag = 40978, Type = TagType.Length, Offset = 28, Required = false)]
			public int? EncodedLegStreamTextLen {get; set;}
			
			[TagDetails(Tag = 40979, Type = TagType.RawData, Offset = 29, Required = false)]
			public byte[]? EncodedLegStreamText {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegStreamType is not null) writer.WriteWholeNumber(40242, LegStreamType.Value);
				if (LegStreamXID is not null) writer.WriteString(41700, LegStreamXID);
				if (LegStreamDesc is not null) writer.WriteString(40243, LegStreamDesc);
				if (LegStreamVersion is not null) writer.WriteString(42583, LegStreamVersion);
				if (LegStreamVersionEffectiveDate is not null) writer.WriteLocalDateOnly(42584, LegStreamVersionEffectiveDate.Value);
				if (LegStreamPaySide is not null) writer.WriteWholeNumber(40244, LegStreamPaySide.Value);
				if (LegStreamReceiveSide is not null) writer.WriteWholeNumber(40245, LegStreamReceiveSide.Value);
				if (LegStreamNotionalXIDRef is not null) writer.WriteString(41702, LegStreamNotionalXIDRef);
				if (LegStreamNotional is not null) writer.WriteNumber(40246, LegStreamNotional.Value);
				if (LegStreamCurrency is not null) writer.WriteString(40247, LegStreamCurrency);
				if (LegStreamNotionalDeterminationMethod is not null) writer.WriteString(42585, LegStreamNotionalDeterminationMethod);
				if (LegStreamNotionalAdjustments is not null) writer.WriteWholeNumber(42586, LegStreamNotionalAdjustments.Value);
				if (LegStreamNotionalFrequencyPeriod is not null) writer.WriteWholeNumber(41703, LegStreamNotionalFrequencyPeriod.Value);
				if (LegStreamNotionalFrequencyUnit is not null) writer.WriteString(41704, LegStreamNotionalFrequencyUnit);
				if (LegStreamNotionalCommodityFrequency is not null) writer.WriteWholeNumber(41705, LegStreamNotionalCommodityFrequency.Value);
				if (LegStreamNotionalUnitOfMeasure is not null) writer.WriteString(41706, LegStreamNotionalUnitOfMeasure);
				if (LegStreamTotalNotional is not null) writer.WriteNumber(41707, LegStreamTotalNotional.Value);
				if (LegStreamTotalNotionalUnitOfMeasure is not null) writer.WriteString(41708, LegStreamTotalNotionalUnitOfMeasure);
				if (LegStreamCommodity is not null) ((IFixEncoder)LegStreamCommodity).Encode(writer);
				if (LegStreamEffectiveDate is not null) ((IFixEncoder)LegStreamEffectiveDate).Encode(writer);
				if (LegStreamTerminationDate is not null) ((IFixEncoder)LegStreamTerminationDate).Encode(writer);
				if (LegStreamCalculationPeriodDates is not null) ((IFixEncoder)LegStreamCalculationPeriodDates).Encode(writer);
				if (LegPaymentStream is not null) ((IFixEncoder)LegPaymentStream).Encode(writer);
				if (LegPaymentScheduleGrp is not null) ((IFixEncoder)LegPaymentScheduleGrp).Encode(writer);
				if (LegPaymentStubGrp is not null) ((IFixEncoder)LegPaymentStubGrp).Encode(writer);
				if (LegDeliveryStream is not null) ((IFixEncoder)LegDeliveryStream).Encode(writer);
				if (LegDeliveryScheduleGrp is not null) ((IFixEncoder)LegDeliveryScheduleGrp).Encode(writer);
				if (LegStreamText is not null) writer.WriteString(40248, LegStreamText);
				if (EncodedLegStreamTextLen is not null) writer.WriteWholeNumber(40978, EncodedLegStreamTextLen.Value);
				if (EncodedLegStreamText is not null) writer.WriteBuffer(40979, EncodedLegStreamText);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegStreamType = view.GetInt32(40242);
				LegStreamXID = view.GetString(41700);
				LegStreamDesc = view.GetString(40243);
				LegStreamVersion = view.GetString(42583);
				LegStreamVersionEffectiveDate = view.GetDateOnly(42584);
				LegStreamPaySide = view.GetInt32(40244);
				LegStreamReceiveSide = view.GetInt32(40245);
				LegStreamNotionalXIDRef = view.GetString(41702);
				LegStreamNotional = view.GetDouble(40246);
				LegStreamCurrency = view.GetString(40247);
				LegStreamNotionalDeterminationMethod = view.GetString(42585);
				LegStreamNotionalAdjustments = view.GetInt32(42586);
				LegStreamNotionalFrequencyPeriod = view.GetInt32(41703);
				LegStreamNotionalFrequencyUnit = view.GetString(41704);
				LegStreamNotionalCommodityFrequency = view.GetInt32(41705);
				LegStreamNotionalUnitOfMeasure = view.GetString(41706);
				LegStreamTotalNotional = view.GetDouble(41707);
				LegStreamTotalNotionalUnitOfMeasure = view.GetString(41708);
				if (view.GetView("LegStreamCommodity") is IMessageView viewLegStreamCommodity)
				{
					LegStreamCommodity = new();
					((IFixParser)LegStreamCommodity).Parse(viewLegStreamCommodity);
				}
				if (view.GetView("LegStreamEffectiveDate") is IMessageView viewLegStreamEffectiveDate)
				{
					LegStreamEffectiveDate = new();
					((IFixParser)LegStreamEffectiveDate).Parse(viewLegStreamEffectiveDate);
				}
				if (view.GetView("LegStreamTerminationDate") is IMessageView viewLegStreamTerminationDate)
				{
					LegStreamTerminationDate = new();
					((IFixParser)LegStreamTerminationDate).Parse(viewLegStreamTerminationDate);
				}
				if (view.GetView("LegStreamCalculationPeriodDates") is IMessageView viewLegStreamCalculationPeriodDates)
				{
					LegStreamCalculationPeriodDates = new();
					((IFixParser)LegStreamCalculationPeriodDates).Parse(viewLegStreamCalculationPeriodDates);
				}
				if (view.GetView("LegPaymentStream") is IMessageView viewLegPaymentStream)
				{
					LegPaymentStream = new();
					((IFixParser)LegPaymentStream).Parse(viewLegPaymentStream);
				}
				if (view.GetView("LegPaymentScheduleGrp") is IMessageView viewLegPaymentScheduleGrp)
				{
					LegPaymentScheduleGrp = new();
					((IFixParser)LegPaymentScheduleGrp).Parse(viewLegPaymentScheduleGrp);
				}
				if (view.GetView("LegPaymentStubGrp") is IMessageView viewLegPaymentStubGrp)
				{
					LegPaymentStubGrp = new();
					((IFixParser)LegPaymentStubGrp).Parse(viewLegPaymentStubGrp);
				}
				if (view.GetView("LegDeliveryStream") is IMessageView viewLegDeliveryStream)
				{
					LegDeliveryStream = new();
					((IFixParser)LegDeliveryStream).Parse(viewLegDeliveryStream);
				}
				if (view.GetView("LegDeliveryScheduleGrp") is IMessageView viewLegDeliveryScheduleGrp)
				{
					LegDeliveryScheduleGrp = new();
					((IFixParser)LegDeliveryScheduleGrp).Parse(viewLegDeliveryScheduleGrp);
				}
				LegStreamText = view.GetString(40248);
				EncodedLegStreamTextLen = view.GetInt32(40978);
				EncodedLegStreamText = view.GetByteArray(40979);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegStreamType":
					{
						value = LegStreamType;
						break;
					}
					case "LegStreamXID":
					{
						value = LegStreamXID;
						break;
					}
					case "LegStreamDesc":
					{
						value = LegStreamDesc;
						break;
					}
					case "LegStreamVersion":
					{
						value = LegStreamVersion;
						break;
					}
					case "LegStreamVersionEffectiveDate":
					{
						value = LegStreamVersionEffectiveDate;
						break;
					}
					case "LegStreamPaySide":
					{
						value = LegStreamPaySide;
						break;
					}
					case "LegStreamReceiveSide":
					{
						value = LegStreamReceiveSide;
						break;
					}
					case "LegStreamNotionalXIDRef":
					{
						value = LegStreamNotionalXIDRef;
						break;
					}
					case "LegStreamNotional":
					{
						value = LegStreamNotional;
						break;
					}
					case "LegStreamCurrency":
					{
						value = LegStreamCurrency;
						break;
					}
					case "LegStreamNotionalDeterminationMethod":
					{
						value = LegStreamNotionalDeterminationMethod;
						break;
					}
					case "LegStreamNotionalAdjustments":
					{
						value = LegStreamNotionalAdjustments;
						break;
					}
					case "LegStreamNotionalFrequencyPeriod":
					{
						value = LegStreamNotionalFrequencyPeriod;
						break;
					}
					case "LegStreamNotionalFrequencyUnit":
					{
						value = LegStreamNotionalFrequencyUnit;
						break;
					}
					case "LegStreamNotionalCommodityFrequency":
					{
						value = LegStreamNotionalCommodityFrequency;
						break;
					}
					case "LegStreamNotionalUnitOfMeasure":
					{
						value = LegStreamNotionalUnitOfMeasure;
						break;
					}
					case "LegStreamTotalNotional":
					{
						value = LegStreamTotalNotional;
						break;
					}
					case "LegStreamTotalNotionalUnitOfMeasure":
					{
						value = LegStreamTotalNotionalUnitOfMeasure;
						break;
					}
					case "LegStreamCommodity":
					{
						value = LegStreamCommodity;
						break;
					}
					case "LegStreamEffectiveDate":
					{
						value = LegStreamEffectiveDate;
						break;
					}
					case "LegStreamTerminationDate":
					{
						value = LegStreamTerminationDate;
						break;
					}
					case "LegStreamCalculationPeriodDates":
					{
						value = LegStreamCalculationPeriodDates;
						break;
					}
					case "LegPaymentStream":
					{
						value = LegPaymentStream;
						break;
					}
					case "LegPaymentScheduleGrp":
					{
						value = LegPaymentScheduleGrp;
						break;
					}
					case "LegPaymentStubGrp":
					{
						value = LegPaymentStubGrp;
						break;
					}
					case "LegDeliveryStream":
					{
						value = LegDeliveryStream;
						break;
					}
					case "LegDeliveryScheduleGrp":
					{
						value = LegDeliveryScheduleGrp;
						break;
					}
					case "LegStreamText":
					{
						value = LegStreamText;
						break;
					}
					case "EncodedLegStreamTextLen":
					{
						value = EncodedLegStreamTextLen;
						break;
					}
					case "EncodedLegStreamText":
					{
						value = EncodedLegStreamText;
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
				LegStreamType = null;
				LegStreamXID = null;
				LegStreamDesc = null;
				LegStreamVersion = null;
				LegStreamVersionEffectiveDate = null;
				LegStreamPaySide = null;
				LegStreamReceiveSide = null;
				LegStreamNotionalXIDRef = null;
				LegStreamNotional = null;
				LegStreamCurrency = null;
				LegStreamNotionalDeterminationMethod = null;
				LegStreamNotionalAdjustments = null;
				LegStreamNotionalFrequencyPeriod = null;
				LegStreamNotionalFrequencyUnit = null;
				LegStreamNotionalCommodityFrequency = null;
				LegStreamNotionalUnitOfMeasure = null;
				LegStreamTotalNotional = null;
				LegStreamTotalNotionalUnitOfMeasure = null;
				((IFixReset?)LegStreamCommodity)?.Reset();
				((IFixReset?)LegStreamEffectiveDate)?.Reset();
				((IFixReset?)LegStreamTerminationDate)?.Reset();
				((IFixReset?)LegStreamCalculationPeriodDates)?.Reset();
				((IFixReset?)LegPaymentStream)?.Reset();
				((IFixReset?)LegPaymentScheduleGrp)?.Reset();
				((IFixReset?)LegPaymentStubGrp)?.Reset();
				((IFixReset?)LegDeliveryStream)?.Reset();
				((IFixReset?)LegDeliveryScheduleGrp)?.Reset();
				LegStreamText = null;
				EncodedLegStreamTextLen = null;
				EncodedLegStreamText = null;
			}
		}
		[Group(NoOfTag = 40241, Offset = 0, Required = false)]
		public NoLegStreams[]? LegStreams {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegStreams is not null && LegStreams.Length != 0)
			{
				writer.WriteWholeNumber(40241, LegStreams.Length);
				for (int i = 0; i < LegStreams.Length; i++)
				{
					((IFixEncoder)LegStreams[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegStreams") is IMessageView viewNoLegStreams)
			{
				var count = viewNoLegStreams.GroupCount();
				LegStreams = new NoLegStreams[count];
				for (int i = 0; i < count; i++)
				{
					LegStreams[i] = new();
					((IFixParser)LegStreams[i]).Parse(viewNoLegStreams.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegStreams":
				{
					value = LegStreams;
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
			LegStreams = null;
		}
	}
}
