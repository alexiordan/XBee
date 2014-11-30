﻿using System.Collections.Generic;
using BinarySerialization;
using XBee.Converters;

namespace XBee.Frames
{
    public class RxIndicatorSampleExtFrame : CommandFrameContent
    {
        public LongAddress Source { get; set; }

        public ShortAddress ShortAddress { get; set; }

        public ReceiveOptionsExt ReceiveOptions { get; set; }

        public byte SampleCount { get; set; }

        public DigitalSampleChannels DigitalChannels { get; set; }

        public AnalogSampleChannels AnalogChannels { get; set; }


        [SerializeWhen("DigitalChannels", DigitalSampleChannels.Input0,
            ConverterType = typeof(BitwiseAndConverter), ConverterParameter = DigitalSampleChannels.Input0)]
        [SerializeWhen("DigitalChannels", DigitalSampleChannels.Input1,
            ConverterType = typeof(BitwiseAndConverter), ConverterParameter = DigitalSampleChannels.Input1)]
        [SerializeWhen("DigitalChannels", DigitalSampleChannels.Input2,
            ConverterType = typeof(BitwiseAndConverter), ConverterParameter = DigitalSampleChannels.Input2)]
        [SerializeWhen("DigitalChannels", DigitalSampleChannels.Input3,
            ConverterType = typeof(BitwiseAndConverter), ConverterParameter = DigitalSampleChannels.Input3)]
        [SerializeWhen("DigitalChannels", DigitalSampleChannels.Input4,
            ConverterType = typeof(BitwiseAndConverter), ConverterParameter = DigitalSampleChannels.Input4)]
        [SerializeWhen("DigitalChannels", DigitalSampleChannels.Input5,
            ConverterType = typeof(BitwiseAndConverter), ConverterParameter = DigitalSampleChannels.Input5)]
        [SerializeWhen("DigitalChannels", DigitalSampleChannels.Input6,
            ConverterType = typeof(BitwiseAndConverter), ConverterParameter = DigitalSampleChannels.Input6)]
        [SerializeWhen("DigitalChannels", DigitalSampleChannels.Input7,
            ConverterType = typeof(BitwiseAndConverter), ConverterParameter = DigitalSampleChannels.Input7)]
        [SerializeWhen("DigitalChannels", DigitalSampleChannels.Input8,
            ConverterType = typeof(BitwiseAndConverter), ConverterParameter = DigitalSampleChannels.Input8)]
        [SerializeWhen("DigitalChannels", DigitalSampleChannels.Input9,
            ConverterType = typeof(BitwiseAndConverter), ConverterParameter = DigitalSampleChannels.Input9)]
        [SerializeWhen("DigitalChannels", DigitalSampleChannels.Input10,
            ConverterType = typeof(BitwiseAndConverter), ConverterParameter = DigitalSampleChannels.Input10)]
        [SerializeWhen("DigitalChannels", DigitalSampleChannels.Input11,
            ConverterType = typeof(BitwiseAndConverter), ConverterParameter = DigitalSampleChannels.Input11)]
        [SerializeWhen("DigitalChannels", DigitalSampleChannels.Input12,
            ConverterType = typeof(BitwiseAndConverter), ConverterParameter = DigitalSampleChannels.Input12)]
        public DigitalSampleState DigitalSampleState { get; set; }


        [SerializeWhen("AnalogSampleChannels", AnalogSampleChannels.Input0, 
            ConverterType = typeof(BitwiseAndConverter), ConverterParameter = AnalogSampleChannels.Input0)]
        [SerializeWhen("AnalogSampleChannels", AnalogSampleChannels.Input1, 
            ConverterType = typeof(BitwiseAndConverter), ConverterParameter = AnalogSampleChannels.Input1)]
        [SerializeWhen("AnalogSampleChannels", AnalogSampleChannels.Input2, 
            ConverterType = typeof(BitwiseAndConverter), ConverterParameter = AnalogSampleChannels.Input2)]
        [SerializeWhen("AnalogSampleChannels", AnalogSampleChannels.Input3, 
            ConverterType = typeof(BitwiseAndConverter), ConverterParameter = AnalogSampleChannels.Input3)]
        [FieldCount(Path = "AnalogSampleChannels",
            ConverterType = typeof(BitCountingConverter), ConverterParameter = AnalogSampleChannels.All)]
        public List<ushort> AnalogSamples { get; set; } 
    }
}