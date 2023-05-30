using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum WebsiteType {
        [EnumMember(Value = "other")]
        Other,
        [EnumMember(Value = "home")]
        Home,
        [EnumMember(Value = "work")]
        Work,
        [EnumMember(Value = "blog")]
        Blog,
        [EnumMember(Value = "profile")]
        Profile,
    }
}
