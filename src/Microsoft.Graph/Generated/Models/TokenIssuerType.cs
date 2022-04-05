namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the identityProtectionRoot singleton.</summary>
    public enum TokenIssuerType {
        AzureAD,
        ADFederationServices,
        UnknownFutureValue,
        AzureADBackupAuth,
        ADFederationServicesMFAAdapter,
        NPSExtension,
    }
}
