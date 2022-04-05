namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the print singleton.</summary>
    public enum PrintOperationProcessingState {
        NotStarted,
        Running,
        Succeeded,
        Failed,
        UnknownFutureValue,
    }
}