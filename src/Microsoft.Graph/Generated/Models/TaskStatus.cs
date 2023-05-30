using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum TaskStatus {
        [EnumMember(Value = "notStarted")]
        NotStarted,
        [EnumMember(Value = "inProgress")]
        InProgress,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "waitingOnOthers")]
        WaitingOnOthers,
        [EnumMember(Value = "deferred")]
        Deferred,
    }
}
