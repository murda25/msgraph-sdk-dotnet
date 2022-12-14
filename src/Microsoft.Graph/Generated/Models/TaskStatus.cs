namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the appCatalogs singleton.</summary>
    public enum TaskStatus {
        NotStarted,
        InProgress,
        Completed,
        WaitingOnOthers,
        Deferred,
    }
}
