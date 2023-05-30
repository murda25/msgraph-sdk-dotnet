using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>Tenant mobile device management subscription state.</summary>
    public enum DeviceManagementSubscriptionState {
        /// <summary>Pending</summary>
        [EnumMember(Value = "pending")]
        Pending,
        /// <summary>Active</summary>
        [EnumMember(Value = "active")]
        Active,
        /// <summary>Warning</summary>
        [EnumMember(Value = "warning")]
        Warning,
        /// <summary>Disabled</summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>Deleted</summary>
        [EnumMember(Value = "deleted")]
        Deleted,
        /// <summary>Blocked</summary>
        [EnumMember(Value = "blocked")]
        Blocked,
        /// <summary>LockedOut</summary>
        [EnumMember(Value = "lockedOut")]
        LockedOut,
    }
}
