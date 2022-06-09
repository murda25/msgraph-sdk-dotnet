namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public enum LongRunningOperationStatus {
        NotStarted,
        Running,
        Succeeded,
        Failed,
        UnknownFutureValue,
    }
}