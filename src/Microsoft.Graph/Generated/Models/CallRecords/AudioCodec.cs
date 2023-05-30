using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models.CallRecords {
    public enum AudioCodec {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "invalid")]
        Invalid,
        [EnumMember(Value = "cn")]
        Cn,
        [EnumMember(Value = "pcma")]
        Pcma,
        [EnumMember(Value = "pcmu")]
        Pcmu,
        [EnumMember(Value = "amrWide")]
        AmrWide,
        [EnumMember(Value = "g722")]
        G722,
        [EnumMember(Value = "g7221")]
        G7221,
        [EnumMember(Value = "g7221c")]
        G7221c,
        [EnumMember(Value = "g729")]
        G729,
        [EnumMember(Value = "multiChannelAudio")]
        MultiChannelAudio,
        [EnumMember(Value = "muchv2")]
        Muchv2,
        [EnumMember(Value = "opus")]
        Opus,
        [EnumMember(Value = "satin")]
        Satin,
        [EnumMember(Value = "satinFullband")]
        SatinFullband,
        [EnumMember(Value = "rtAudio8")]
        RtAudio8,
        [EnumMember(Value = "rtAudio16")]
        RtAudio16,
        [EnumMember(Value = "silk")]
        Silk,
        [EnumMember(Value = "silkNarrow")]
        SilkNarrow,
        [EnumMember(Value = "silkWide")]
        SilkWide,
        [EnumMember(Value = "siren")]
        Siren,
        [EnumMember(Value = "xmsRta")]
        XmsRta,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
