namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the collection of agreement entities.</summary>
    public enum RiskEventType {
        UnlikelyTravel,
        AnonymizedIPAddress,
        MaliciousIPAddress,
        UnfamiliarFeatures,
        MalwareInfectedIPAddress,
        SuspiciousIPAddress,
        LeakedCredentials,
        InvestigationsThreatIntelligence,
        Generic,
        AdminConfirmedUserCompromised,
        McasImpossibleTravel,
        McasSuspiciousInboxManipulationRules,
        InvestigationsThreatIntelligenceSigninLinked,
        MaliciousIPAddressValidCredentialsBlockedIP,
        UnknownFutureValue,
    }
}
