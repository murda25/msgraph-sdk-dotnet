using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum ScopeOperatorType {
        [EnumMember(Value = "Binary")]
        Binary,
        [EnumMember(Value = "Unary")]
        Unary,
    }
}
