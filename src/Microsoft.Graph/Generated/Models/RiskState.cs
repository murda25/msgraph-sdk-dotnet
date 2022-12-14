namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the appCatalogs singleton.</summary>
    public enum RiskState {
        None,
        ConfirmedSafe,
        Remediated,
        Dismissed,
        AtRisk,
        ConfirmedCompromised,
        UnknownFutureValue,
    }
}
