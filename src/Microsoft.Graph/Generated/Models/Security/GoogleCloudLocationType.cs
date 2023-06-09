using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models.Security {
    public enum GoogleCloudLocationType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "regional")]
        Regional,
        [EnumMember(Value = "zonal")]
        Zonal,
        [EnumMember(Value = "global")]
        Global,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}