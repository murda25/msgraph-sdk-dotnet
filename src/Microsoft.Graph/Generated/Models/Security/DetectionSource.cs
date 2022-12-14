namespace Microsoft.Graph.Models.Security {
    /// <summary>Provides operations to manage the appCatalogs singleton.</summary>
    public enum DetectionSource {
        Unknown,
        MicrosoftDefenderForEndpoint,
        Antivirus,
        SmartScreen,
        CustomTi,
        MicrosoftDefenderForOffice365,
        AutomatedInvestigation,
        MicrosoftThreatExperts,
        CustomDetection,
        MicrosoftDefenderForIdentity,
        CloudAppSecurity,
        Microsoft365Defender,
        AzureAdIdentityProtection,
        Manual,
        MicrosoftDataLossPrevention,
        AppGovernancePolicy,
        AppGovernanceDetection,
        UnknownFutureValue,
    }
}
