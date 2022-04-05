namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the drive singleton.</summary>
    public enum ComplianceState {
        Unknown,
        Compliant,
        Noncompliant,
        Conflict,
        Error,
        InGracePeriod,
        ConfigManager,
    }
}
