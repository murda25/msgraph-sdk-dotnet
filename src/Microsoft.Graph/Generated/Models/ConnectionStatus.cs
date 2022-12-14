namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the appCatalogs singleton.</summary>
    public enum ConnectionStatus {
        Unknown,
        Attempted,
        Succeeded,
        Blocked,
        Failed,
        UnknownFutureValue,
    }
}
