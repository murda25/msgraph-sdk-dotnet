using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum SigninFrequencyType {
        [EnumMember(Value = "days")]
        Days,
        [EnumMember(Value = "hours")]
        Hours,
    }
}
