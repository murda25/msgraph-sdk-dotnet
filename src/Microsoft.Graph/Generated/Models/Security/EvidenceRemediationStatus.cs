namespace Microsoft.Graph.Models.Security {
    /// <summary>Provides operations to manage the appCatalogs singleton.</summary>
    public enum EvidenceRemediationStatus {
        None,
        Remediated,
        Prevented,
        Blocked,
        NotFound,
        UnknownFutureValue,
    }
}
