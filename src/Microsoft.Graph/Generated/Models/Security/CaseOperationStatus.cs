namespace Microsoft.Graph.Models.Security {
    /// <summary>Provides operations to manage the appCatalogs singleton.</summary>
    public enum CaseOperationStatus {
        NotStarted,
        SubmissionFailed,
        Running,
        Succeeded,
        PartiallySucceeded,
        Failed,
        UnknownFutureValue,
    }
}
