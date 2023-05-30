using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum BodyType {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "html")]
        Html,
    }
}
