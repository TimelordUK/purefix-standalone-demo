using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class StreamGrp : IFixComponent
	{
		public sealed partial class NoStreams : IFixGroup
		{
			[TagDetails(Tag = 40050, Type = TagType.Int, Offset = 0, Required = false)]
			public int? StreamType {get; set;}
			
			[TagDetails(Tag = 41303, Type = TagType.String, Offset = 1, Required = false)]
			public string? StreamXID {get; set;}
			
			[TagDetails(Tag = 40051, Type = TagType.String, Offset = 2, Required = false)]
			public string? StreamDesc {get; set;}
			
			[TagDetails(Tag = 42784, Type = TagType.String, Offset = 3, Required = false)]
			public string? StreamVersion {get; set;}
			
			[TagDetails(Tag = 42785, Type = TagType.LocalDate, Offset = 4, Required = false)]
			public DateOnly? StreamVersionEffectiveDate {get; set;}
			
			[TagDetails(Tag = 40052, Type = TagType.Int, Offset = 5, Required = false)]
			public int? StreamPaySide {get; set;}
			
			[TagDetails(Tag = 40053, Type = TagType.Int, Offset = 6, Required = false)]
			public int? StreamReceiveSide {get; set;}
			
			[TagDetails(Tag = 41305, Type = TagType.String, Offset = 7, Required = false)]
			public string? StreamNotionalXIDRef {get; set;}
			
			[TagDetails(Tag = 40054, Type = TagType.Float, Offset = 8, Required = false)]
			public double? StreamNotional {get; set;}
			
			[TagDetails(Tag = 40055, Type = TagType.String, Offset = 9, Required = false)]
			public string? StreamCurrency {get; set;}
			
			[TagDetails(Tag = 42786, Type = TagType.String, Offset = 10, Required = false)]
			public string? StreamNotionalDeterminationMethod {get; set;}
			
			[TagDetails(Tag = 42787, Type = TagType.Int, Offset = 11, Required = false)]
			public int? StreamNotionalAdjustments {get; set;}
			
			[TagDetails(Tag = 41306, Type = TagType.Int, Offset = 12, Required = false)]
			public int? StreamNotionalFrequencyPeriod {get; set;}
			
			[TagDetails(Tag = 41307, Type = TagType.String, Offset = 13, Required = false)]
			public string? StreamNotionalFrequencyUnit {get; set;}
			
			[TagDetails(Tag = 41308, Type = TagType.Int, Offset = 14, Required = false)]
			public int? StreamNotionalCommodityFrequency {get; set;}
			
			[TagDetails(Tag = 41309, Type = TagType.String, Offset = 15, Required = false)]
			public string? StreamNotionalUnitOfMeasure {get; set;}
			
			[TagDetails(Tag = 41310, Type = TagType.Float, Offset = 16, Required = false)]
			public double? StreamTotalNotional {get; set;}
			
			[TagDetails(Tag = 41311, Type = TagType.String, Offset = 17, Required = false)]
			public string? StreamTotalNotionalUnitOfMeasure {get; set;}
			
			[Component(Offset = 18, Required = false)]
			public StreamCommodity? StreamCommodity {get; set;}
			
			[Component(Offset = 19, Required = false)]
			public StreamEffectiveDate? StreamEffectiveDate {get; set;}
			
			[Component(Offset = 20, Required = false)]
			public StreamTerminationDate? StreamTerminationDate {get; set;}
			
			[Component(Offset = 21, Required = false)]
			public StreamCalculationPeriodDates? StreamCalculationPeriodDates {get; set;}
			
			[Component(Offset = 22, Required = false)]
			public PaymentStream? PaymentStream {get; set;}
			
			[Component(Offset = 23, Required = false)]
			public PaymentScheduleGrp? PaymentScheduleGrp {get; set;}
			
			[Component(Offset = 24, Required = false)]
			public PaymentStubGrp? PaymentStubGrp {get; set;}
			
			[Component(Offset = 25, Required = false)]
			public DeliveryStream? DeliveryStream {get; set;}
			
			[Component(Offset = 26, Required = false)]
			public DeliveryScheduleGrp? DeliveryScheduleGrp {get; set;}
			
			[TagDetails(Tag = 40056, Type = TagType.String, Offset = 27, Required = false)]
			public string? StreamText {get; set;}
			
			[TagDetails(Tag = 40982, Type = TagType.Length, Offset = 28, Required = false)]
			public int? EncodedStreamTextLen {get; set;}
			
			[TagDetails(Tag = 40983, Type = TagType.RawData, Offset = 29, Required = false)]
			public byte[]? EncodedStreamText {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (StreamType is not null) writer.WriteWholeNumber(40050, StreamType.Value);
				if (StreamXID is not null) writer.WriteString(41303, StreamXID);
				if (StreamDesc is not null) writer.WriteString(40051, StreamDesc);
				if (StreamVersion is not null) writer.WriteString(42784, StreamVersion);
				if (StreamVersionEffectiveDate is not null) writer.WriteLocalDateOnly(42785, StreamVersionEffectiveDate.Value);
				if (StreamPaySide is not null) writer.WriteWholeNumber(40052, StreamPaySide.Value);
				if (StreamReceiveSide is not null) writer.WriteWholeNumber(40053, StreamReceiveSide.Value);
				if (StreamNotionalXIDRef is not null) writer.WriteString(41305, StreamNotionalXIDRef);
				if (StreamNotional is not null) writer.WriteNumber(40054, StreamNotional.Value);
				if (StreamCurrency is not null) writer.WriteString(40055, StreamCurrency);
				if (StreamNotionalDeterminationMethod is not null) writer.WriteString(42786, StreamNotionalDeterminationMethod);
				if (StreamNotionalAdjustments is not null) writer.WriteWholeNumber(42787, StreamNotionalAdjustments.Value);
				if (StreamNotionalFrequencyPeriod is not null) writer.WriteWholeNumber(41306, StreamNotionalFrequencyPeriod.Value);
				if (StreamNotionalFrequencyUnit is not null) writer.WriteString(41307, StreamNotionalFrequencyUnit);
				if (StreamNotionalCommodityFrequency is not null) writer.WriteWholeNumber(41308, StreamNotionalCommodityFrequency.Value);
				if (StreamNotionalUnitOfMeasure is not null) writer.WriteString(41309, StreamNotionalUnitOfMeasure);
				if (StreamTotalNotional is not null) writer.WriteNumber(41310, StreamTotalNotional.Value);
				if (StreamTotalNotionalUnitOfMeasure is not null) writer.WriteString(41311, StreamTotalNotionalUnitOfMeasure);
				if (StreamCommodity is not null) ((IFixEncoder)StreamCommodity).Encode(writer);
				if (StreamEffectiveDate is not null) ((IFixEncoder)StreamEffectiveDate).Encode(writer);
				if (StreamTerminationDate is not null) ((IFixEncoder)StreamTerminationDate).Encode(writer);
				if (StreamCalculationPeriodDates is not null) ((IFixEncoder)StreamCalculationPeriodDates).Encode(writer);
				if (PaymentStream is not null) ((IFixEncoder)PaymentStream).Encode(writer);
				if (PaymentScheduleGrp is not null) ((IFixEncoder)PaymentScheduleGrp).Encode(writer);
				if (PaymentStubGrp is not null) ((IFixEncoder)PaymentStubGrp).Encode(writer);
				if (DeliveryStream is not null) ((IFixEncoder)DeliveryStream).Encode(writer);
				if (DeliveryScheduleGrp is not null) ((IFixEncoder)DeliveryScheduleGrp).Encode(writer);
				if (StreamText is not null) writer.WriteString(40056, StreamText);
				if (EncodedStreamTextLen is not null) writer.WriteWholeNumber(40982, EncodedStreamTextLen.Value);
				if (EncodedStreamText is not null) writer.WriteBuffer(40983, EncodedStreamText);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				StreamType = view.GetInt32(40050);
				StreamXID = view.GetString(41303);
				StreamDesc = view.GetString(40051);
				StreamVersion = view.GetString(42784);
				StreamVersionEffectiveDate = view.GetDateOnly(42785);
				StreamPaySide = view.GetInt32(40052);
				StreamReceiveSide = view.GetInt32(40053);
				StreamNotionalXIDRef = view.GetString(41305);
				StreamNotional = view.GetDouble(40054);
				StreamCurrency = view.GetString(40055);
				StreamNotionalDeterminationMethod = view.GetString(42786);
				StreamNotionalAdjustments = view.GetInt32(42787);
				StreamNotionalFrequencyPeriod = view.GetInt32(41306);
				StreamNotionalFrequencyUnit = view.GetString(41307);
				StreamNotionalCommodityFrequency = view.GetInt32(41308);
				StreamNotionalUnitOfMeasure = view.GetString(41309);
				StreamTotalNotional = view.GetDouble(41310);
				StreamTotalNotionalUnitOfMeasure = view.GetString(41311);
				if (view.GetView("StreamCommodity") is IMessageView viewStreamCommodity)
				{
					StreamCommodity = new();
					((IFixParser)StreamCommodity).Parse(viewStreamCommodity);
				}
				if (view.GetView("StreamEffectiveDate") is IMessageView viewStreamEffectiveDate)
				{
					StreamEffectiveDate = new();
					((IFixParser)StreamEffectiveDate).Parse(viewStreamEffectiveDate);
				}
				if (view.GetView("StreamTerminationDate") is IMessageView viewStreamTerminationDate)
				{
					StreamTerminationDate = new();
					((IFixParser)StreamTerminationDate).Parse(viewStreamTerminationDate);
				}
				if (view.GetView("StreamCalculationPeriodDates") is IMessageView viewStreamCalculationPeriodDates)
				{
					StreamCalculationPeriodDates = new();
					((IFixParser)StreamCalculationPeriodDates).Parse(viewStreamCalculationPeriodDates);
				}
				if (view.GetView("PaymentStream") is IMessageView viewPaymentStream)
				{
					PaymentStream = new();
					((IFixParser)PaymentStream).Parse(viewPaymentStream);
				}
				if (view.GetView("PaymentScheduleGrp") is IMessageView viewPaymentScheduleGrp)
				{
					PaymentScheduleGrp = new();
					((IFixParser)PaymentScheduleGrp).Parse(viewPaymentScheduleGrp);
				}
				if (view.GetView("PaymentStubGrp") is IMessageView viewPaymentStubGrp)
				{
					PaymentStubGrp = new();
					((IFixParser)PaymentStubGrp).Parse(viewPaymentStubGrp);
				}
				if (view.GetView("DeliveryStream") is IMessageView viewDeliveryStream)
				{
					DeliveryStream = new();
					((IFixParser)DeliveryStream).Parse(viewDeliveryStream);
				}
				if (view.GetView("DeliveryScheduleGrp") is IMessageView viewDeliveryScheduleGrp)
				{
					DeliveryScheduleGrp = new();
					((IFixParser)DeliveryScheduleGrp).Parse(viewDeliveryScheduleGrp);
				}
				StreamText = view.GetString(40056);
				EncodedStreamTextLen = view.GetInt32(40982);
				EncodedStreamText = view.GetByteArray(40983);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "StreamType":
					{
						value = StreamType;
						break;
					}
					case "StreamXID":
					{
						value = StreamXID;
						break;
					}
					case "StreamDesc":
					{
						value = StreamDesc;
						break;
					}
					case "StreamVersion":
					{
						value = StreamVersion;
						break;
					}
					case "StreamVersionEffectiveDate":
					{
						value = StreamVersionEffectiveDate;
						break;
					}
					case "StreamPaySide":
					{
						value = StreamPaySide;
						break;
					}
					case "StreamReceiveSide":
					{
						value = StreamReceiveSide;
						break;
					}
					case "StreamNotionalXIDRef":
					{
						value = StreamNotionalXIDRef;
						break;
					}
					case "StreamNotional":
					{
						value = StreamNotional;
						break;
					}
					case "StreamCurrency":
					{
						value = StreamCurrency;
						break;
					}
					case "StreamNotionalDeterminationMethod":
					{
						value = StreamNotionalDeterminationMethod;
						break;
					}
					case "StreamNotionalAdjustments":
					{
						value = StreamNotionalAdjustments;
						break;
					}
					case "StreamNotionalFrequencyPeriod":
					{
						value = StreamNotionalFrequencyPeriod;
						break;
					}
					case "StreamNotionalFrequencyUnit":
					{
						value = StreamNotionalFrequencyUnit;
						break;
					}
					case "StreamNotionalCommodityFrequency":
					{
						value = StreamNotionalCommodityFrequency;
						break;
					}
					case "StreamNotionalUnitOfMeasure":
					{
						value = StreamNotionalUnitOfMeasure;
						break;
					}
					case "StreamTotalNotional":
					{
						value = StreamTotalNotional;
						break;
					}
					case "StreamTotalNotionalUnitOfMeasure":
					{
						value = StreamTotalNotionalUnitOfMeasure;
						break;
					}
					case "StreamCommodity":
					{
						value = StreamCommodity;
						break;
					}
					case "StreamEffectiveDate":
					{
						value = StreamEffectiveDate;
						break;
					}
					case "StreamTerminationDate":
					{
						value = StreamTerminationDate;
						break;
					}
					case "StreamCalculationPeriodDates":
					{
						value = StreamCalculationPeriodDates;
						break;
					}
					case "PaymentStream":
					{
						value = PaymentStream;
						break;
					}
					case "PaymentScheduleGrp":
					{
						value = PaymentScheduleGrp;
						break;
					}
					case "PaymentStubGrp":
					{
						value = PaymentStubGrp;
						break;
					}
					case "DeliveryStream":
					{
						value = DeliveryStream;
						break;
					}
					case "DeliveryScheduleGrp":
					{
						value = DeliveryScheduleGrp;
						break;
					}
					case "StreamText":
					{
						value = StreamText;
						break;
					}
					case "EncodedStreamTextLen":
					{
						value = EncodedStreamTextLen;
						break;
					}
					case "EncodedStreamText":
					{
						value = EncodedStreamText;
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
				StreamType = null;
				StreamXID = null;
				StreamDesc = null;
				StreamVersion = null;
				StreamVersionEffectiveDate = null;
				StreamPaySide = null;
				StreamReceiveSide = null;
				StreamNotionalXIDRef = null;
				StreamNotional = null;
				StreamCurrency = null;
				StreamNotionalDeterminationMethod = null;
				StreamNotionalAdjustments = null;
				StreamNotionalFrequencyPeriod = null;
				StreamNotionalFrequencyUnit = null;
				StreamNotionalCommodityFrequency = null;
				StreamNotionalUnitOfMeasure = null;
				StreamTotalNotional = null;
				StreamTotalNotionalUnitOfMeasure = null;
				((IFixReset?)StreamCommodity)?.Reset();
				((IFixReset?)StreamEffectiveDate)?.Reset();
				((IFixReset?)StreamTerminationDate)?.Reset();
				((IFixReset?)StreamCalculationPeriodDates)?.Reset();
				((IFixReset?)PaymentStream)?.Reset();
				((IFixReset?)PaymentScheduleGrp)?.Reset();
				((IFixReset?)PaymentStubGrp)?.Reset();
				((IFixReset?)DeliveryStream)?.Reset();
				((IFixReset?)DeliveryScheduleGrp)?.Reset();
				StreamText = null;
				EncodedStreamTextLen = null;
				EncodedStreamText = null;
			}
		}
		[Group(NoOfTag = 40049, Offset = 0, Required = false)]
		public NoStreams[]? Streams {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Streams is not null && Streams.Length != 0)
			{
				writer.WriteWholeNumber(40049, Streams.Length);
				for (int i = 0; i < Streams.Length; i++)
				{
					((IFixEncoder)Streams[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoStreams") is IMessageView viewNoStreams)
			{
				var count = viewNoStreams.GroupCount();
				Streams = new NoStreams[count];
				for (int i = 0; i < count; i++)
				{
					Streams[i] = new();
					((IFixParser)Streams[i]).Parse(viewNoStreams.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoStreams":
				{
					value = Streams;
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
			Streams = null;
		}
	}
}
