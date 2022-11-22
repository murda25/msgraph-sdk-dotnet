namespace Microsoft.Graph.Models.ExternalConnectors {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum ConnectionState {
        Draft,
        Ready,
        Obsolete,
        LimitExceeded,
        UnknownFutureValue,
    }
}
