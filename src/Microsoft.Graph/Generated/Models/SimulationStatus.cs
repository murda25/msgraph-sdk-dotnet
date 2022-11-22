namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum SimulationStatus {
        Unknown,
        Draft,
        Running,
        Scheduled,
        Succeeded,
        Failed,
        Cancelled,
        Excluded,
        UnknownFutureValue,
    }
}
