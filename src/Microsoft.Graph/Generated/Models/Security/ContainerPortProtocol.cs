using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models.Security {
    public enum ContainerPortProtocol {
        [EnumMember(Value = "udp")]
        Udp,
        [EnumMember(Value = "tcp")]
        Tcp,
        [EnumMember(Value = "sctp")]
        Sctp,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}